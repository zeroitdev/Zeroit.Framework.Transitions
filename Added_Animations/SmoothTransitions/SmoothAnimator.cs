// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="SmoothAnimator.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.SmoothTransitions
{
    /// <summary>
    /// Class ZeroitSmoothAnimator.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    public class ZeroitSmoothAnimator : Component
    {

        #region Private Properties

        /// <summary>
        /// The control
        /// </summary>
        private Control control = new Control();

        /// <summary>
        /// The offset
        /// </summary>
        private float offset = 10;

        /// <summary>
        /// The duration
        /// </summary>
        private int duration = 1000;

        /// <summary>
        /// The reversed duration
        /// </summary>
        private int reversed_duration = 1000;

        /// <summary>
        /// The start value
        /// </summary>
        private int startValue = 100;

        /// <summary>
        /// The allow call back
        /// </summary>
        private bool allowCallBack = false;

        /// <summary>
        /// The animation types
        /// </summary>
        private AnimationTypes animationTypes = AnimationTypes.ResizeHoriz;

        /// <summary>
        /// The animation
        /// </summary>
        private Animation animation;

        /// <summary>
        /// The control size
        /// </summary>
        private static Size controlSize;

        /// <summary>
        /// The control location
        /// </summary>
        private static Point controlLocation;

        /// <summary>
        /// The timer interval
        /// </summary>
        private int timerInterval = 10;

        /// <summary>
        /// The timer passed
        /// </summary>
        private int timerPassed = 0;

        /// <summary>
        /// The reversed time passed
        /// </summary>
        private int reversed_timePassed = 0;

        /// <summary>
        /// The reverse
        /// </summary>
        private bool reverse = true;


        #endregion

        #region Public Properties


        /// <summary>
        /// Gets or sets the type of the animation.
        /// </summary>
        /// <value>The type of the animation.</value>
        public AnimationTypes AnimationType
        {
            get { return animationTypes; }
            set
            {
                animationTypes = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the control.
        /// </summary>
        /// <value>The control.</value>
        public Control Control
        {
            get { return control; }
            set
            {
                control = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the offset.
        /// </summary>
        /// <value>The offset.</value>
        public float Offset
        {
            get { return offset; }
            set
            {
                offset = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        /// <value>The duration.</value>
        public int Duration
        {
            get { return duration; }
            set
            {
                duration = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the start value.
        /// </summary>
        /// <value>The start value.</value>
        public int StartValue
        {
            get { return startValue; }
            set
            {
                startValue = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the timer interval.
        /// </summary>
        /// <value>The timer interval.</value>
        public int TimerInterval
        {
            get { return timerInterval; }
            set
            {
                timerInterval = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the timer passed.
        /// </summary>
        /// <value>The timer passed.</value>
        public int TimerPassed
        {
            get { return timerPassed; }
            set
            {
                timerPassed = value;
                control.Invalidate();
            }
        }



        /// <summary>
        /// Gets or sets a value indicating whether [smooth out].
        /// </summary>
        /// <value><c>true</c> if [smooth out]; otherwise, <c>false</c>.</value>
        public bool SmoothOut
        {
            get { return allowCallBack; }
            set
            {
                allowCallBack = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ZeroitSmoothAnimator"/> is reverse.
        /// </summary>
        /// <value><c>true</c> if reverse; otherwise, <c>false</c>.</value>
        public bool Reverse
        {
            get { return reverse; }
            set
            {
                reverse = value;
                control.Invalidate();
            }
        }

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitSmoothAnimator"/> class.
        /// </summary>
        public ZeroitSmoothAnimator()
        {
            //animation = new Animation(animationTypes, control, offset, AnimationFinished);

            controlSize = control.Size;
            controlLocation = control.Location;
        }

        /// <summary>
        /// Starts this instance.
        /// </summary>
        public void Start()
        {
            if (allowCallBack)
            {
                if (animationTypes == AnimationTypes.ResizeHoriz)
                {
                    animation = new Animation(animationTypes, control, offset - control.Width, AnimationFinished, duration, Animation_CallBack,
                        startValue, timerInterval, timerPassed, reversed_duration, reversed_timePassed);
                }
                else if (animationTypes == AnimationTypes.ResizeVert)
                {
                    animation = new Animation(animationTypes, control, offset - control.Height, AnimationFinished, duration,
                        Animation_CallBack,
                        startValue, timerInterval, timerPassed, reversed_duration, reversed_timePassed);
                }
                else
                {
                    animation = new Animation(animationTypes, control, offset, AnimationFinished, duration,
                        Animation_CallBack,
                        startValue, timerInterval, timerPassed, reversed_duration, reversed_timePassed);
                }
                
            }
            else
            {
                if (animationTypes == AnimationTypes.ResizeHoriz)
                {
                    animation = new Animation(animationTypes, control, offset - control.Width, AnimationFinished, duration);

                }

                else if (animationTypes == AnimationTypes.ResizeVert)
                {
                    animation = new Animation(animationTypes, control, offset - control.Height, AnimationFinished, duration);

                }

                else
                {
                    animation = new Animation(animationTypes, control, offset, AnimationFinished, duration);

                }

            }

            
        }

        /// <summary>
        /// Stops this instance.
        /// </summary>
        public void Stop()
        {
            reverse = false;
                animation.Cancel();
            
        }

        /// <summary>
        /// Nexts this instance.
        /// </summary>
        public void Next()
        {
            animation.Next();
        }

        /// <summary>
        /// Reverseds this instance.
        /// </summary>
        public void Reversed()
        {
            if(reverse)
                animation.Reversed();
        }

        /// <summary>
        /// Animations the finished.
        /// </summary>
        /// <param name="sender">The sender.</param>
        public void AnimationFinished(object sender)
        {
            if (reverse)
            {
                if (animationTypes == AnimationTypes.ResizeHoriz)
                {
                    if (control.GetType() == typeof(System.Windows.Forms.Form))
                    {
                        animation = new Animation(animationTypes, control, offset * ((offset * 2) + offset - (offset / 2)) /*- control.Width*/, AnimationContinued,
                            duration, Animation_CallBack, startValue,
                            timerInterval, timerPassed, reversed_duration, reversed_timePassed);
                    }
                    else
                    {
                        animation = new Animation(animationTypes, control, offset * ((offset * 2)/* + offset - (offset / 2)*/)/* - control.Width*/, AnimationContinued,
                            duration, Animation_CallBack, startValue,
                            timerInterval, timerPassed, reversed_duration, reversed_timePassed);
                    }

                }

                else if (animationTypes == AnimationTypes.ResizeVert)
                {
                    if (control.GetType() == typeof(System.Windows.Forms.Form))
                    {
                        animation = new Animation(animationTypes, control, offset * ((offset * 2) + offset - (offset / 2))/* - control.Height*/, AnimationContinued,
                            duration, Animation_CallBack, startValue,
                            timerInterval, timerPassed, reversed_duration, reversed_timePassed);
                    }
                    else
                    {
                        animation = new Animation(animationTypes, control, offset * ((offset * 2)/* + offset - (offset / 2)*/) /*- control.Height*/, AnimationContinued,
                            duration, Animation_CallBack, startValue,
                            timerInterval, timerPassed, reversed_duration, reversed_timePassed);
                    }

                }



                else
                {
                    if (control.GetType() == typeof(System.Windows.Forms.Form))
                    {
                        animation = new Animation(animationTypes, control, offset * ((offset * 2) + offset - (offset / 2)), AnimationContinued,
                            duration, Animation_CallBack, startValue,
                            timerInterval, timerPassed, reversed_duration, reversed_timePassed);
                    }
                    else
                    {
                        animation = new Animation(animationTypes, control, offset * ((offset * 2)/* + offset - (offset / 2)*/), AnimationContinued,
                            duration, Animation_CallBack, startValue,
                            timerInterval, timerPassed, reversed_duration, reversed_timePassed);
                    }


                }

            }
            else
            {

            }

            //animation.Reversed();
        }

        /// <summary>
        /// Animations the continued.
        /// </summary>
        /// <param name="sender">The sender.</param>
        public void AnimationContinued(object sender)
        {
            DelayedCall.DisposeAll();
        }


        /// <summary>
        /// Animations the call back.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="value">The value.</param>
        public void Animation_CallBack(object sender, int value)
        {
            sender = this.Control;
            
        }

        
    }

}
