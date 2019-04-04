// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Animation.cs" company="Zeroit Dev Technologies">
//    This program is for creating components to aid in Animating controls.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Timers;

namespace Zeroit.Framework.Transitions.ZeroitPizaroAnimator
{
    /// <summary>
    /// A class for performing animations and visual transitions.
    /// </summary>
    public class Animation

    {
        /// <summary>Default timeout for animations (in milliseconds).</summary>
        public const int TIMEOUT = 15;

        /// <summary>
        /// Start point of the animation.
        /// </summary>
        protected double[] m_Start;

        /// <summary>
        /// End point of the animation.
        /// </summary>
        protected double[] m_End;

        /// <summary>
        /// Duration of the animation in milliseconds.
        /// </summary>
        protected int m_Duration;

        /// <summary>
        /// Acceleration function, which must return a number between 0 and 1 for inputs between 0
        /// and 1.
        /// </summary>
        private Func<double, double> m_AccelFunc;

        

        /// <summary>
        /// Timestamp for when the animation was started.
        /// </summary>
        protected DateTime m_StartTime;

        /// <summary>
        /// Timestamp for when the last frame was run.
        /// </summary>
        protected DateTime m_LastFrame;

        /// <summary>
        /// Current frame rate.
        /// </summary>
        private int m_Fps;

        /// <summary>
        /// Timestamp for when animation is expected to finish.
        /// </summary>
        protected DateTime m_EndTime;

        /// <summary>
        /// Current co-ordinates for animation.
        /// </summary>
        protected double[] m_Current;

        /// <summary>
        /// Current state of the animation.
        /// </summary>
        private AnimationState m_State;

        /// <summary>
        /// Percent of the way through the animation (between 0.0 and 1.0).
        /// </summary>
        protected double m_Progress;

        private Timer m_Timer;

        /// <summary>
        /// Constructs an animation object.
        /// </summary>
        /// <param name="start">Array of start co-ordinates.</param>
        /// <param name="end">Array of end co-ordinates.</param>
        /// <param name="duration">Length of animation in milliseconds.</param>
        /// <param name="accelFunc">Acceleration function, returns 0-1 for inputs 0-1.</param>
        public Animation(double[] start, double[] end, int duration, Func<double, double> accelFunc) {
            if (start.Length != end.Length) {
                throw new AnimationException("Start and end arrays must be the same length.");
            }
            m_Start = start;
            m_End = end;
            m_Duration = duration;
            m_AccelFunc = accelFunc;

            m_Current = new double[m_Start.Length];
            m_State = AnimationState.Stopped;
            m_Progress = 0;
            m_Timer = new Timer(TIMEOUT);
            m_Timer.Elapsed += new ElapsedEventHandler(m_Timer_Elapsed);
        }

        

        void m_Timer_Elapsed(object sender, ElapsedEventArgs e) {
            Cycle(e.SignalTime);
        }

        /// <summary>
        /// Enum for the possible states of an animation.
        /// </summary>
        public enum AnimationState {
            Stopped,
            Paused,
            Playing
        }

        /// <summary>
        /// Gets the animation state.
        /// </summary>
        public AnimationState State {
            get { return m_State; }
        }

        /// <summary>
        /// Gets the current co-ordinates of the animation.
        /// </summary>
        public double[] CurrentCoordinates {
            get { return m_Current; }
        }

        /// <summary>
        /// Gets the progress of the animation (a number between 0.0 and 1.0).
        /// </summary>
        public double Progress {
            get { return m_Progress; }
        }

        /// <summary>
        /// Gets or sets the duration of the animation (in milliseconds).
        /// </summary>
        public int Duration {
            get { return m_Duration; }
            set { m_Duration = value; }
        }

        /// <summary>
        /// Starts or resumes an animation.
        /// </summary>
        /// <returns>Whether animation was started.</returns>
        public bool Play() {
            return Play(false);
        }

        /// <summary>
        /// Starts or resumes an animation.
        /// </summary>
        /// <param name="restart">
        /// Whether to restart the animation from the beginning if it has been paused.
        /// </param>
        /// <returns>Whether animation was started.</returns>
        public bool Play(bool restart) {
            if (restart || m_State == AnimationState.Stopped) {
                m_Progress = 0;
                m_Current = m_Start;
            } else if (m_State == AnimationState.Playing) {
                return false;
            }

            m_Timer.Stop();

            m_StartTime = DateTime.Now;

            if (m_State == AnimationState.Paused) {
                m_StartTime.AddMilliseconds(-m_Duration * m_Progress);
            }

            m_EndTime = m_StartTime + new TimeSpan(m_Duration * 10000);
            m_LastFrame = m_StartTime;

            if (m_Progress == 0) {
                OnBegin();
            }

            OnPlay();

            if (m_State == AnimationState.Paused) {
                OnResume();
            }

            m_State = AnimationState.Playing;

            m_Timer.Start();
            Cycle(m_StartTime);

            return true;
        }

        /// <summary>
        /// Stops the animation.
        /// </summary>
        /// <param name="gotoEnd">If true, the animation will move to the end co-ordinates.</param>
        public void Stop(bool gotoEnd) {
            m_Timer.Stop();
            m_State = AnimationState.Stopped;

            if (gotoEnd) {
                m_Progress = 1;
            }

            UpdateCoords(m_Progress);

            OnStop();
            OnEnd();
        }

        /// <summary>
        /// Pauses the animation (iff it's playing).
        /// </summary>
        public void Pause() {
            if (m_State == AnimationState.Playing) {
                m_Timer.Stop();
                m_State = AnimationState.Paused;
                OnPause();
            }
        }

        /// <summary>
        /// Handles the actual iteration of the animation in a timeout.
        /// </summary>
        /// <param name="now">The current time.</param>
        private void Cycle(DateTime now) {
            m_Progress = (now - m_StartTime).TotalMilliseconds / (m_EndTime - m_StartTime).TotalMilliseconds;

            if (m_Progress >= 1) {
                m_Progress = 1;
            }

            m_Fps = (int)(1000d / (now - m_LastFrame).TotalMilliseconds);


            #region Zeroit Additions

            
            #endregion

            m_LastFrame = now;

            if (m_AccelFunc == null) {
                UpdateCoords(m_Progress);
            } else {
                UpdateCoords(m_AccelFunc(m_Progress));
            }

            // Animation has finished.
            if (m_Progress == 1) {
                m_State = AnimationState.Stopped;
                m_Timer.Stop();

                OnFinish();
                OnEnd();
            // Animation is still under way.
            } else if (m_State == AnimationState.Playing) {
                OnAnimate();
            }
        }

        /// <summary>
        /// Calculates current co-ordinates, based on the current state.
        /// </summary>
        /// <param name="t">Percentage of the way through the animation as a decimal.</param>
        private void UpdateCoords(double t) {
            if (t == 1) {
                m_Current = m_End;
            } else {
                m_Current = new double[m_Start.Length];
                for (int i = 0; i < m_Start.Length; i++) {
                    m_Current[i] = (m_End[i] - m_Start[i]) * t + m_Start[i];
                }
            }
        }

        #region Events
        /// <summary>
        /// Dispatches the Animate event. Subclasses should override this instead of listening to
        /// the event.
        /// </summary>
        protected virtual void OnAnimate() {
            if (Animate != null) {
                Animate(this);
            }
        }

        /// <summary>
        /// Dispatches the Begin event. Subclasses should override this instead of listening to
        /// the event.
        /// </summary>
        protected virtual void OnBegin() {
            if (Begin != null) {
                Begin(this);
            }
        }

        /// <summary>
        /// Dispatches the End event. Subclasses should override this instead of listening to
        /// the event.
        /// </summary>
        protected virtual void OnEnd() {
            if (End != null) {
                End(this);
            }
        }

        /// <summary>
        /// Dispatches the Finish event. Subclasses should override this instead of listening to
        /// the event.
        /// </summary>
        protected virtual void OnFinish() {
            if (Finish != null) {
                Finish(this);
            }
        }

        /// <summary>
        /// Dispatches the Pause event. Subclasses should override this instead of listening to
        /// the event.
        /// </summary>
        protected virtual void OnPause() {
            if (PauseEvent != null) {
                PauseEvent(this);
            }
        }

        /// <summary>
        /// Dispatches the Play event. Subclasses should override this instead of listening to
        /// the event.
        /// </summary>
        protected virtual void OnPlay() {
            if (PlayEvent != null) {
                PlayEvent(this);
            }
        }

        /// <summary>
        /// Dispatches the Resume event. Subclasses should override this instead of listening to
        /// the event.
        /// </summary>
        protected virtual void OnResume() {
            if (Resume != null) {
                Resume(this);
            }
        }

        /// <summary>
        /// Dispatches the Stop event. Subclasses should override this instead of listening to
        /// the event.
        /// </summary>
        protected virtual void OnStop() {
            if (StopEvent != null) {
                StopEvent(this);
            }
        }

        /// <summary>
        /// Event that is fired on each animation step.
        /// </summary>
        public event AnimationEvent Animate;

        /// <summary>
        /// Event that is fired when animation begins.
        /// </summary>
        public event AnimationEvent Begin;
        
        /// <summary>
        /// Event that is fired when animation ends.
        /// </summary>
        public event AnimationEvent End;

        /// <summary>
        /// Event that is fired when animation finishes naturally.
        /// </summary>
        public event AnimationEvent Finish;

        /// <summary>
        /// Event that is fired when animation is paused.
        /// </summary>
        public event AnimationEvent PauseEvent;

        /// <summary>
        /// Event that is fired when the Play method is called.
        /// </summary>
        public event AnimationEvent PlayEvent;

        /// <summary>
        /// Event that is fired when animation resumes.
        /// </summary>
        public event AnimationEvent Resume;

        /// <summary>
        /// Event that is fired when animation is forcefully stopped.
        /// </summary>
        public event AnimationEvent StopEvent;
        #endregion
    }

    /// <summary>
    /// Defines an event handler to handle animation events.
    /// </summary>
    /// <param name="animation">The animation firing the event.</param>
    public delegate void AnimationEvent(Animation animation);
}
