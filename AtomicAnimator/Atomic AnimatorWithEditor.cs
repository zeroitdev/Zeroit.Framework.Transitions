// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Atomic AnimatorWithEditor.cs" company="Zeroit Dev Technologies">
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

#region Imports

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using Zeroit.Framework.Transitions.AnimationEditors;

#endregion

#region Old Imports

//using System;
//using System.Threading;
//using System.Collections.Generic;
//using System.Windows.Forms; 

#endregion


namespace Zeroit.Framework.Transitions.AtomicAnimator
{
    /// <summary>
    /// A utility class that handles the timing and threading of animation contexts.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    /// <seealso cref="AnimationContext" />
    public class ZeroitAtomEdit : Component
    {

        #region Private Fields
        /// <summary>
        /// The m runner
        /// </summary>
        private static Thread m_runner;
        /// <summary>
        /// The m running
        /// </summary>
        private static volatile bool m_running = false;
        /// <summary>
        /// The m anims
        /// </summary>
        private static Dictionary<string, AnimationContext> m_anims = new Dictionary<string, AnimationContext>();

        /// <summary>
        /// <c><see cref="ZeroitAtomEdit" /></c> : Sets the Property to be animated.
        /// </summary>
        public enum PropertyAnimated
        {
            /// <summary>
            /// Sets the property to be animated to BackColor.
            /// </summary>
            BackColor,
            /// <summary>
            /// Sets the property to be animated to ForeColor.
            /// </summary>
            ForeColor,
            /// <summary>
            /// Sets the property to be animated to Location.
            /// </summary>
            Location,
            /// <summary>
            /// Sets the property to be animated to Size.
            /// </summary>
            Size,
            /// <summary>
            /// Sets the property to be animated to None.
            /// </summary>
            None
            /*, Text */
        }

        /// <summary>
        /// <c><see cref="ZeroitAtomEdit" /></c> : Sets the type of animation.
        /// </summary>
        public enum Animations
        {
            /// <summary>
            /// Sets the animation type to Default.
            /// </summary>
            Default,
            /// <summary>
            /// Sets the animation type to EaseIn.
            /// </summary>
            EaseIn,
            /// <summary>
            /// Sets the animation type to EaseOut.
            /// </summary>
            EaseOut,
            /// <summary>
            /// Sets the animation type to EaseInEaseOut.
            /// </summary>
            EaseInEaseOut,
            /// <summary>
            /// Sets the animation type to Linear.
            /// </summary>
            Linear,
            /// <summary>
            /// Sets the animation type to CustomAnimation2Points.
            /// </summary>
            CustomAnimation2Points,
            /// <summary>
            /// Sets the animation type to CustomAnimation3Points.
            /// </summary>
            CustomAnimation3Points,
            /// <summary>
            /// Sets the animation type to CustomAnimation4Points.
            /// </summary>
            CustomAnimation4Points
        }


        /// <summary>
        /// The atomic animator input
        /// </summary>
        private AtomicAnimatorInput atomicAnimatorInput = new AtomicAnimatorInput(
            ZeroitAtomEdit.PropertyAnimated.Size,
            0.5f,
            0.0f,
            0.5f,
            1.0f,
            0.5f,
            0.5f,
            1.0f,
            0.0f,
            "text",
            new System.Drawing.Size(100, 100),
            new System.Drawing.Point(447, 356),
            Color.Black,
            Color.Transparent,
            true,
            2f,
            ZeroitAtomEdit.Animations.EaseInEaseOut,
            ""

        );


        #endregion

        #region Old Code
        //public PointF point1 = new PointF(0.5f, 0.0f);
        //public PointF point2 = new PointF(0.5f, 1.0f);

        //public PointF point3 = new PointF(0.7f, 1.0f);
        //public PointF point4 = new PointF(1.0f, 0.0f);

        //private PointF[] customAnimationPoints = new PointF[1]; 
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the atomic animator values in an editor.
        /// </summary>
        /// <value>The atomic animator input.</value>
        /// <remarks>This opens up an editor that sets the values and provides preview functionalities for the animation selected.</remarks>
        public AtomicAnimatorInput Editor
        {
            get
            {
                return atomicAnimatorInput;

            }
            set
            {
                atomicAnimatorInput = value;
                Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets the custom animation2 points.
        /// </summary>
        /// <value>The custom animation2 points.</value>
        [Browsable(false)]
        public IAnimationCurve CustomAnimation2Points
        {
            get { return atomicAnimatorInput.CustomAnimation2Points; }

        }

        /// <summary>
        /// Gets the custom animation3 points.
        /// </summary>
        /// <value>The custom animation3 points.</value>
        [Browsable(false)]
        public IAnimationCurve CustomAnimation3Points
        {
            get
            {
                return atomicAnimatorInput.CustomAnimation3Points;
            }

        }

        /// <summary>
        /// Gets the custom animation4 points.
        /// </summary>
        /// <value>The custom animation4 points.</value>
        [Browsable(false)]
        public IAnimationCurve CustomAnimation4Points
        {
            get
            {
                return atomicAnimatorInput.CustomAnimation4Points;
            }

        }

        /// <summary>
        /// Gets or sets the x value of the custom animation point1.
        /// </summary>
        /// <value>The custom animation point1 x value.</value>
        public float CustomAnimationPoint1X
        {
            get { return atomicAnimatorInput.CustomAnimationPoint1X; }
            set
            {
                atomicAnimatorInput.CustomAnimationPoint1X = value;
            }
        }

        /// <summary>
        /// Gets or sets the y value of the custom animation point1.
        /// </summary>
        /// <value>The custom animation point1 y value.</value>
        public float CustomAnimationPoint1Y
        {
            get { return atomicAnimatorInput.CustomAnimationPoint1Y; }
            set
            {
                atomicAnimatorInput.CustomAnimationPoint1Y = value;
            }
        }

        /// <summary>
        /// Gets or sets the x value of the custom animation point2.
        /// </summary>
        /// <value>The custom animation point2 x value.</value>
        public float CustomAnimationPoint2X
        {
            get { return atomicAnimatorInput.CustomAnimationPoint2X; }
            set
            {
                atomicAnimatorInput.CustomAnimationPoint2X = value;
            }
        }

        /// <summary>
        /// Gets or sets the y value of the custom animation point2.
        /// </summary>
        /// <value>The custom animation point2 y value.</value>
        public float CustomAnimationPoint2Y
        {
            get { return atomicAnimatorInput.CustomAnimationPoint2Y; }
            set
            {
                atomicAnimatorInput.CustomAnimationPoint2Y = value;
            }
        }

        /// <summary>
        /// Gets or sets the x value of the custom animation point3.
        /// </summary>
        /// <value>The custom animation point3 x value.</value>
        public float CustomAnimationPoint3X
        {
            get { return atomicAnimatorInput.CustomAnimationPoint3X; }
            set
            {
                atomicAnimatorInput.CustomAnimationPoint3X = value;
            }
        }

        /// <summary>
        /// Gets or sets the y value of the custom animation point3.
        /// </summary>
        /// <value>The custom animation point3 y value.</value>
        public float CustomAnimationPoint3Y
        {
            get { return atomicAnimatorInput.CustomAnimationPoint3Y; }
            set
            {
                atomicAnimatorInput.CustomAnimationPoint3Y = value;
            }
        }

        /// <summary>
        /// Gets or sets the x value of the custom animation point4.
        /// </summary>
        /// <value>The custom animation point4 x value.</value>
        public float CustomAnimationPoint4X
        {
            get { return atomicAnimatorInput.CustomAnimationPoint4X; }
            set
            {
                atomicAnimatorInput.CustomAnimationPoint4X = value;
            }
        }

        /// <summary>
        /// Gets or sets the y value of the custom animation point4.
        /// </summary>
        /// <value>The custom animation point4 y value.</value>
        public float CustomAnimationPoint4Y
        {
            get { return atomicAnimatorInput.CustomAnimationPoint4Y; }
            set
            {
                atomicAnimatorInput.CustomAnimationPoint4Y = value;
            }
        }

        /// <summary>
        /// Gets or sets the control for the animation.
        /// </summary>
        /// <value>The control.</value>
        public Control Control
        {
            get { return atomicAnimatorInput.Control; }
            set
            {
                atomicAnimatorInput.Control = value;

            }
        }

        //public string ControlAnimationString
        //{
        //    get { return controlAnimationText; }
        //    set
        //    {

        //        controlAnimationText = value;
        //        if(DesignMode)
        //        {
        //            Control.Text = controlAnimationText;
        //        }
        //    }
        //}

        /// <summary>
        /// Gets or sets the size of the control animation.
        /// </summary>
        /// <value>The size of the control animation.</value>
        public System.Drawing.Size ControlAnimationSize
        {
            get { return atomicAnimatorInput.ControlAnimationSize; }
            set
            {
                atomicAnimatorInput.ControlAnimationSize = value;
            }
        }

        /// <summary>
        /// Gets or sets the control's location.
        /// </summary>
        /// <value>The control's location.</value>
        public System.Drawing.Point ControlLocation
        {
            get { return atomicAnimatorInput.ControlLocation; }
            set
            {
                atomicAnimatorInput.ControlLocation = value;
            }
        }

        /// <summary>
        /// Gets or sets the color of the control's foreground.
        /// </summary>
        /// <value>The color of the control foreground.</value>
        public Color ControlForeColor
        {
            get { return atomicAnimatorInput.ControlForeColor; }
            set
            {
                atomicAnimatorInput.ControlForeColor = value;
                

            }
        }

        /// <summary>
        /// Gets or sets the color of the control's background.
        /// </summary>
        /// <value>The color of the control background.</value>
        public Color ControlBackColor
        {
            get { return atomicAnimatorInput.ControlBackColor; }
            set
            {
                atomicAnimatorInput.ControlBackColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the animated property.
        /// </summary>
        /// <value>The animated property.</value>
        public PropertyAnimated AnimatedProperty
        {
            get { return atomicAnimatorInput.AnimatedProperty; }
            set
            {
                atomicAnimatorInput.AnimatedProperty = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the animation should reverse.
        /// </summary>
        /// <value><c>true</c> if reverse; otherwise, <c>false</c>.</value>
        public bool Reverse
        {
            get { return atomicAnimatorInput.Reverse; }
            set
            {
                atomicAnimatorInput.Reverse = value;
            }
        }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        /// <value>The duration.</value>
        public float Duration
        {
            get { return atomicAnimatorInput.Duration; }
            set
            {
                atomicAnimatorInput.Duration = value;
            }
        }

        //public int ControlAnimatedSize
        //{
        //    get { return controlAnimatedSize; }
        //    set
        //    {
        //        controlAnimatedSize = value;

        //    }
        //}

        /// <summary>
        /// Gets or sets the transition.
        /// </summary>
        /// <value>The transition.</value>
        public Animations Transition
        {
            get { return atomicAnimatorInput.Transition; }
            set
            {
                atomicAnimatorInput.Transition = value;

            }
        }

        /// <summary>
        /// Gets or sets the animation string.
        /// </summary>
        /// <value>The animation string.</value>
        public string AnimationString
        {
            get { return atomicAnimatorInput.AnimationString; }
            set
            {
                atomicAnimatorInput.AnimationString = value;

            }
        }

        #endregion

        /// <summary>
        /// Activates the Animation.
        /// </summary>
        public void Activate()
        {

            switch (Transition)
            {
                case Animations.Default:
                    AnimationContext btnsAnim = new AnimationContext(AnimationCurves.AnimationCurve.Default);
                    btnsAnim.Curve.SetDuration(Duration);
                    switch (AnimatedProperty)
                    {
                        case PropertyAnimated.BackColor:
                            btnsAnim.AddAnimation<Control, Color>(Control, ControlBackColor, "BackColor");
                            break;
                        case PropertyAnimated.ForeColor:
                            btnsAnim.AddAnimation<Control, Color>(Control, ControlForeColor, "ForeColor");
                            break;
                        case PropertyAnimated.Location:
                            btnsAnim.AddAnimation<Control, System.Drawing.Point>(Control, ControlLocation, "Location");
                            break;
                        case PropertyAnimated.Size:
                            btnsAnim.AddAnimation<Control, System.Drawing.Size>(Control, ControlAnimationSize, "Size");
                            break;
                        //case PropertyAnimated.Text:
                        //    btnsAnim.AddAnimation<Control, String>(Control, controlAnimationText, "Text");
                        //    break;
                        default:
                            break;
                    }

                    btnsAnim.Reverses = Reverse;
                    ZeroitAtom.InitWithControl(Control);

                    ZeroitAtom.Run(AnimationString, btnsAnim);
                    break;
                case Animations.EaseIn:
                    AnimationContext btnsAnim1 = new AnimationContext(AnimationCurves.AnimationCurve.EaseIn);
                    btnsAnim1.Curve.SetDuration(Duration);
                    switch (AnimatedProperty)
                    {
                        case PropertyAnimated.BackColor:
                            btnsAnim1.AddAnimation<Control, Color>(Control, ControlBackColor, "BackColor");
                            break;
                        case PropertyAnimated.ForeColor:
                            btnsAnim1.AddAnimation<Control, Color>(Control, ControlForeColor, "ForeColor");
                            break;
                        case PropertyAnimated.Location:
                            btnsAnim1.AddAnimation<Control, System.Drawing.Point>(Control, ControlLocation, "Location");
                            break;
                        case PropertyAnimated.Size:
                            btnsAnim1.AddAnimation<Control, System.Drawing.Size>(Control, ControlAnimationSize, "Size");
                            break;
                        //case PropertyAnimated.Text:
                        //    btnsAnim1.AddAnimation<Control, String>(Control, controlAnimationText, "Text");
                        //    break;
                        default:
                            break;
                    }

                    btnsAnim1.Reverses = Reverse;

                    ZeroitAtom.InitWithControl(Control);

                    ZeroitAtom.Run(AnimationString, btnsAnim1);
                    break;
                case Animations.EaseOut:
                    AnimationContext btnsAnim2 = new AnimationContext(AnimationCurves.AnimationCurve.EaseOut);
                    btnsAnim2.Curve.SetDuration(Duration);
                    switch (AnimatedProperty)
                    {
                        case PropertyAnimated.BackColor:
                            btnsAnim2.AddAnimation<Control, Color>(Control, ControlBackColor, "BackColor");
                            break;
                        case PropertyAnimated.ForeColor:
                            btnsAnim2.AddAnimation<Control, Color>(Control, ControlForeColor, "ForeColor");
                            break;
                        case PropertyAnimated.Location:
                            btnsAnim2.AddAnimation<Control, System.Drawing.Point>(Control, ControlLocation, "Location");
                            break;
                        case PropertyAnimated.Size:
                            btnsAnim2.AddAnimation<Control, System.Drawing.Size>(Control, ControlAnimationSize, "Size");
                            break;
                        //case PropertyAnimated.Text:
                        //    btnsAnim2.AddAnimation<Control, String>(Control, controlAnimationText, "Text");
                        //    break;
                        default:
                            break;
                    }

                    btnsAnim2.Reverses = Reverse;

                    ZeroitAtom.InitWithControl(Control);

                    ZeroitAtom.Run(AnimationString, btnsAnim2);
                    break;
                case Animations.EaseInEaseOut:
                    AnimationContext btnsAnim3 = new AnimationContext(AnimationCurves.AnimationCurve.EaseInEaseOut);
                    btnsAnim3.Curve.SetDuration(Duration);
                    switch (AnimatedProperty)
                    {
                        case PropertyAnimated.BackColor:
                            btnsAnim3.AddAnimation<Control, Color>(Control, ControlBackColor, "BackColor");
                            break;
                        case PropertyAnimated.ForeColor:
                            btnsAnim3.AddAnimation<Control, Color>(Control, ControlForeColor, "ForeColor");
                            break;
                        case PropertyAnimated.Location:
                            btnsAnim3.AddAnimation<Control, System.Drawing.Point>(Control, ControlLocation, "Location");
                            break;
                        case PropertyAnimated.Size:
                            btnsAnim3.AddAnimation<Control, System.Drawing.Size>(Control, ControlAnimationSize, "Size");
                            break;
                        //case PropertyAnimated.Text:
                        //    btnsAnim3.AddAnimation<Control, String>(Control, controlAnimationText, "Text");
                        //    break;
                        default:
                            break;
                    }

                    btnsAnim3.Reverses = Reverse;

                    ZeroitAtom.InitWithControl(Control);

                    ZeroitAtom.Run(AnimationString, btnsAnim3);
                    break;
                case Animations.Linear:
                    AnimationContext btnsAnim4 = new AnimationContext(AnimationCurves.AnimationCurve.Linear);
                    btnsAnim4.Curve.SetDuration(Duration);
                    switch (AnimatedProperty)
                    {
                        case PropertyAnimated.BackColor:
                            btnsAnim4.AddAnimation<Control, Color>(Control, ControlBackColor, "BackColor");
                            break;
                        case PropertyAnimated.ForeColor:
                            btnsAnim4.AddAnimation<Control, Color>(Control, ControlForeColor, "ForeColor");
                            break;
                        case PropertyAnimated.Location:
                            btnsAnim4.AddAnimation<Control, System.Drawing.Point>(Control, ControlLocation, "Location");
                            break;
                        case PropertyAnimated.Size:
                            btnsAnim4.AddAnimation<Control, System.Drawing.Size>(Control, ControlAnimationSize, "Size");
                            break;
                        //case PropertyAnimated.Text:
                        //    btnsAnim4.AddAnimation<Control, String>(Control, controlAnimationText, "Text");
                        //    break;
                        default:
                            break;
                    }

                    btnsAnim4.Reverses = Reverse;

                    ZeroitAtom.InitWithControl(Control);

                    ZeroitAtom.Run(AnimationString, btnsAnim4);
                    break;
                case Animations.CustomAnimation2Points:
                    AnimationContext btnsAnim5 = new AnimationContext(CustomAnimation2Points);
                    btnsAnim5.Curve.SetDuration(Duration);
                    switch (AnimatedProperty)
                    {
                        case PropertyAnimated.BackColor:
                            btnsAnim5.AddAnimation<Control, Color>(Control, ControlBackColor, "BackColor");
                            break;
                        case PropertyAnimated.ForeColor:
                            btnsAnim5.AddAnimation<Control, Color>(Control, ControlForeColor, "ForeColor");
                            break;
                        case PropertyAnimated.Location:
                            btnsAnim5.AddAnimation<Control, System.Drawing.Point>(Control, ControlLocation, "Location");
                            break;
                        case PropertyAnimated.Size:
                            btnsAnim5.AddAnimation<Control, System.Drawing.Size>(Control, ControlAnimationSize, "Size");
                            break;
                        //case PropertyAnimated.Text:
                        //    btnsAnim5.AddAnimation<Control, String>(Control, controlAnimationText, "Text");
                        //    break;
                        default:
                            break;
                    }

                    btnsAnim5.Reverses = Reverse;
                    ZeroitAtom.InitWithControl(Control);

                    ZeroitAtom.Run(AnimationString, btnsAnim5);
                    break;
                case Animations.CustomAnimation3Points:
                    AnimationContext threepoints = new AnimationContext(CustomAnimation4Points);
                    threepoints.Curve.SetDuration(Duration);

                    switch (AnimatedProperty)
                    {
                        case PropertyAnimated.BackColor:
                            threepoints.AddAnimation<Control, Color>(Control, ControlBackColor, "BackColor");
                            break;
                        case PropertyAnimated.ForeColor:
                            threepoints.AddAnimation<Control, Color>(Control, ControlForeColor, "ForeColor");
                            break;
                        case PropertyAnimated.Location:
                            threepoints.AddAnimation<Control, System.Drawing.Point>(Control, ControlLocation, "Location");
                            break;
                        case PropertyAnimated.Size:
                            threepoints.AddAnimation<Control, System.Drawing.Size>(Control, ControlAnimationSize, "Size");
                            break;
                        //case PropertyAnimated.Text:
                        //    btnsAnim7.AddAnimation<Control, String>(Control, controlAnimationText, "Text");
                        //    break;
                        default:
                            break;
                    }

                    threepoints.Reverses = Reverse;
                    ZeroitAtom.InitWithControl(Control);

                    ZeroitAtom.Run(AnimationString, threepoints);

                    break;
                case Animations.CustomAnimation4Points:
                    AnimationContext btnsAnim7 = new AnimationContext(CustomAnimation4Points);
                    btnsAnim7.Curve.SetDuration(Duration);
                    switch (AnimatedProperty)
                    {
                        case PropertyAnimated.BackColor:
                            btnsAnim7.AddAnimation<Control, Color>(Control, ControlBackColor, "BackColor");
                            break;
                        case PropertyAnimated.ForeColor:
                            btnsAnim7.AddAnimation<Control, Color>(Control, ControlForeColor, "ForeColor");
                            break;
                        case PropertyAnimated.Location:
                            btnsAnim7.AddAnimation<Control, System.Drawing.Point>(Control, ControlLocation, "Location");
                            break;
                        case PropertyAnimated.Size:
                            btnsAnim7.AddAnimation<Control, System.Drawing.Size>(Control, ControlAnimationSize, "Size");
                            break;
                        //case PropertyAnimated.Text:
                        //    btnsAnim7.AddAnimation<Control, String>(Control, controlAnimationText, "Text");
                        //    break;
                        default:
                            break;
                    }

                    btnsAnim7.Reverses = Reverse;
                    ZeroitAtom.InitWithControl(Control);

                    ZeroitAtom.Run(AnimationString, btnsAnim7);
                    break;
                default:
                    break;
            }

            
        }

        #region ManualInit

        /// <summary>
        /// "Manually" initializes the animator. This should be called by non-UI applications.
        /// </summary>
        public static void ManualInit()
        {
            if (m_runner == null)
            {
                AnimationContext.DefaultRequiresMainThread = false;

                m_runner = new Thread(new ThreadStart(run));
                m_running = true;
                m_runner.Start();
            }
        }

        #endregion

        #region InitWithControl

        /// <summary>
        /// Initializes the animator for a Windows Forms application.
        /// </summary>
        /// <param name="ctrl">A Control that lives for the Duration of the entire application (e.g. the main window).</param>
        public static void InitWithControl(System.Windows.Forms.Control ctrl)
        {
            MainThreadCallerControl mtcc = new MainThreadCallerControl();
            ctrl.Controls.Add(mtcc);

            System.Windows.Forms.Application.ApplicationExit += new EventHandler(ApplicationExiting);

            ManualInit();
            AnimationContext.DefaultRequiresMainThread = true;
        }

        #endregion

        #region InitWithWPFPanel

        /// <summary>
        /// Initializes the animator for a WPF application.
        /// </summary>
        /// <param name="ctrl">A Control that lives for the Duration of the entire application (e.g. the main window's content panel).</param>
        public static void InitWithWPFPanel(System.Windows.Controls.Panel ctrl)
        {
            MainThreadCallerWPFControl mtcc = new MainThreadCallerWPFControl();
            ctrl.Children.Add(mtcc);

            System.Windows.Application.Current.Exit += new System.Windows.ExitEventHandler(WPFApplicationExiting);

            ManualInit();
            AnimationContext.DefaultRequiresMainThread = true;
        }

        #endregion

        #region Exiting methods

        /// <summary>
        /// Should be called by non-UI applications when the application is terminating.
        /// </summary>
        public static void ManualExit()
        {
            if (m_runner != null)
            {
                Dispatch.MainThreadDispatcher = null;
                m_running = false;

                if (!m_runner.Join(500))
                {
                    m_runner.Abort();
                }

                m_runner = null;
            }
        }

        /// <summary>
        /// Called by the .NET runtime when the application is ending.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event.</param>
        private static void ApplicationExiting(object sender, EventArgs e)
        {
            ManualExit();
        }

        /// <summary>
        /// Called by the .NET runtime when the application is ending.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event.</param>
        private static void WPFApplicationExiting(object sender, System.Windows.ExitEventArgs e)
        {
            ManualExit();
        }

        #endregion

        #region Run

        /// <summary>
        /// Runs an animation context with a given name. Any animation with the same name
        /// will be replaced.
        /// </summary>
        /// <param name="name">The name of the animation.</param>
        /// <param name="context">The animation context.</param>
        /// <remarks>As the list of animations must be locked before the animation
        /// can be added, this task is grouped into a work item and dispatched
        /// to the thread pool to prevent the calling thread from hanging
        /// while a lock is acquired.</remarks>
        public static void Run(string name, AnimationContext context)
        {
            Dispatch.Run(() =>
            {
                lock (m_anims)
                {
                    m_anims[name] = context;
                }
            });
        }

        #endregion

        #region IsAnimationRunning

        /// <summary>
        /// Determines if an animation is running.
        /// </summary>
        /// <param name="name">The name of the animation.</param>
        /// <returns>True if the animation is running, or false if the animation has completed or doesn't exist.</returns>
        public static bool IsAnimationRunning(string name)
        {
            AnimationContext context = null;

            if (!m_anims.TryGetValue(name, out context))
            {
                return false;
            }

            return !context.Completed;
        }

        #endregion

        #region CancelAnimation

        /// <summary>
        /// Cancels an anmiation with a given name if it exists.
        /// </summary>
        /// <param name="name">The name of the animation.</param>
        /// <remarks>As the list of animations must be locked before the animation
        /// can be removed, this task is grouped into a work item and dispatched
        /// to the thread pool to prevent the calling thread from hanging
        /// while a lock is acquired.</remarks>
        public static void CancelAnimation(string name)
        {
            Dispatch.Run(() =>
            {
                lock (m_anims)
                {
                    if (m_anims.ContainsKey(name))
                    {
                        m_anims.Remove(name);
                    }
                }
            });
        }

        #endregion

        #region run

        /// <summary>
        /// This is our "run" method for the animation thread.
        /// </summary>
        private static void run()
        {
            DateTime then = DateTime.Now, now = DateTime.Now;
            
            // while the animation thread should running
            while (m_running)
            {
                // calculate the time delta since the last iteration of our loop in seconds
                now = DateTime.Now;
                float delta = (float)(now - then).Milliseconds / 1000.0f;
                then = now;

                // get a lock on the list of animations
                lock (m_anims)
                {
                    // TODO: there has to be a better way to do this... is there an iterator
                    // that allows us to remove objects as we iterate?
                    List<string> keysToRemove = new List<string>(5);

                    // check each animation in our list of animations
                    foreach (string key in m_anims.Keys)
                    {
                        AnimationContext context = m_anims[key];

                        // if it has completed and we shouldn't keep it after it has been completed,
                        // add it to our list of animations to remove
                        if (context.Completed && !context.KeepAfterCompleted)
                        {
                            keysToRemove.Add(key);
                        }
                        else
                        {
                            // we throw every context update out to the threadpool (allows for better performance
                            // than just trying to animate everything on a single thread)
                            Dispatch.Run(() =>
                            {
                                context.Update(delta);
                            });
                        }
                    }

                    // remove animations from our list if needed
                    if (keysToRemove.Count > 0)
                    {
                        foreach (string key in keysToRemove)
                        {
                            m_anims.Remove(key);
                        }
                    }
                }
                
                // let some other threads do some work for a while
                Thread.Sleep(25);
            }
        }

        #endregion
    }


}
