// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="PizaroTransition.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion 

namespace Zeroit.Framework.Transitions.ZeroitPizaroAnimator
{

    /// <summary>
    /// A class collection that provides animation functionalities.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    public class ZeroitPizaroAnim : Component
    {
        #region Private Fields

        /// <summary>
        /// The control
        /// </summary>
        private Control control = new Control();
        /// <summary>
        /// The duration
        /// </summary>
        private int duration = 1000;
        /// <summary>
        /// The accelerate
        /// </summary>
        private double accelerate = 0.7;
        /// <summary>
        /// The fadebegin
        /// </summary>
        double fadebegin = 0;
        /// <summary>
        /// The fadelimit
        /// </summary>
        double fadelimit = 1;

        /// <summary>
        /// The resizeheightbegin
        /// </summary>
        double resizeheightbegin = 10;
        /// <summary>
        /// The resizeheightlimit
        /// </summary>
        double resizeheightlimit = 50;

        /// <summary>
        /// The resizewidthbegin
        /// </summary>
        double resizewidthbegin = 10;
        /// <summary>
        /// The resizewidthlimit
        /// </summary>
        double resizewidthlimit = 50;

        /// <summary>
        /// The cordinate start x
        /// </summary>
        double cordinateStart_X = 10;
        /// <summary>
        /// The cordinate start y
        /// </summary>
        double cordinateStart_Y = 10;
        /// <summary>
        /// The cordinate end x
        /// </summary>
        double cordinateEnd_X = 50;
        /// <summary>
        /// The cordinate end y
        /// </summary>
        double cordinateEnd_Y = 50;

        /// <summary>
        /// The easingstart
        /// </summary>
        double easingstart = 0.2;
        /// <summary>
        /// The easingend
        /// </summary>
        double easingend = 1;
        /// <summary>
        /// The accel
        /// </summary>
        public double accel;

        /// <summary>
        /// The function
        /// </summary>
        Func<double, double> func = num => num;

        /// <summary>
        /// Sets the animation type for the <c><see cref="ZeroitPizaroAnim" /></c> animator.
        /// </summary>
        public enum animationType
        {
            /// <summary>
            /// Sets the animation type to None.
            /// </summary>
            None,
            /// <summary>
            /// Sets the animation type to Fade.
            /// </summary>
            Fade,
            /// <summary>
            /// Sets the animation type to FadeIn.
            /// </summary>
            FadeIn,
            /// <summary>
            /// Sets the animation type to FadeInAndShow.
            /// </summary>
            FadeInAndShow,
            /// <summary>
            /// Sets the animation type to FadeOut.
            /// </summary>
            FadeOut,
            /// <summary>
            /// Sets the animation type to FadeOutandHide.
            /// </summary>
            FadeOutandHide,
            /// <summary>
            /// Sets the animation type to Resize.
            /// </summary>
            Resize,
            /// <summary>
            /// Sets the animation type to ResizeHeight.
            /// </summary>
            ResizeHeight,
            /// <summary>
            /// Sets the animation type to ResizeWidth.
            /// </summary>
            ResizeWidth,
            /// <summary>
            /// Sets the animation type to Slide.
            /// </summary>
            Slide,
            /// <summary>
            /// Sets the animation type to SlideFrom.
            /// </summary>
            SlideFrom
        }


        /// <summary>
        /// The animation type
        /// </summary>
        private animationType _animationType = animationType.Resize;

        #endregion

        #region Easing Property

        /// <summary>
        /// Sets the easing function for the <c><see cref="ZeroitPizaroAnim" /></c> animator.
        /// </summary>
        public enum easingNames
        {
            /// <summary>
            /// The linear
            /// </summary>
            Linear,
            /// <summary>
            /// The ease in
            /// </summary>
            EaseIn,
            /// <summary>
            /// The ease out
            /// </summary>
            EaseOut,
            /// <summary>
            /// The ease in and out
            /// </summary>
            EaseInAndOut,
            /// <summary>
            /// The linear tween
            /// </summary>
            LinearTween,
            /// <summary>
            /// The ease in quad
            /// </summary>
            EaseInQuad,
            /// <summary>
            /// The ease out quad
            /// </summary>
            EaseOutQuad,
            /// <summary>
            /// The ease in out quad
            /// </summary>
            EaseInOutQuad,
            /// <summary>
            /// The ease in cubic
            /// </summary>
            EaseInCubic,
            /// <summary>
            /// The ease out cubic
            /// </summary>
            EaseOutCubic,
            /// <summary>
            /// The ease in out cubic
            /// </summary>
            EaseInOutCubic,
            /// <summary>
            /// The ease in quart
            /// </summary>
            EaseInQuart,
            /// <summary>
            /// The ease out quart
            /// </summary>
            EaseOutQuart,
            /// <summary>
            /// The ease in out quart
            /// </summary>
            EaseInOutQuart,
            /// <summary>
            /// The ease in quint
            /// </summary>
            EaseInQuint,
            /// <summary>
            /// The ease out quint
            /// </summary>
            EaseOutQuint,
            /// <summary>
            /// The ease in out quint
            /// </summary>
            EaseInOutQuint,
            /// <summary>
            /// The ease in sine
            /// </summary>
            EaseInSine,
            /// <summary>
            /// The ease out sine
            /// </summary>
            EaseOutSine,
            /// <summary>
            /// The ease in out sine
            /// </summary>
            EaseInOutSine,
            /// <summary>
            /// The ease in expo
            /// </summary>
            EaseInExpo,
            /// <summary>
            /// The ease out expo
            /// </summary>
            EaseOutExpo,
            /// <summary>
            /// The ease in out expo
            /// </summary>
            EaseInOutExpo,
            /// <summary>
            /// The ease in circ
            /// </summary>
            EaseInCirc,
            /// <summary>
            /// The ease out circ
            /// </summary>
            EaseOutCirc,
            /// <summary>
            /// The ease in out circ
            /// </summary>
            EaseInOutCirc,
            /// <summary>
            /// The elastic ease out
            /// </summary>
            ElasticEaseOut,
            /// <summary>
            /// The elastic ease in
            /// </summary>
            ElasticEaseIn,
            /// <summary>
            /// The elastic ease in out
            /// </summary>
            ElasticEaseInOut,
            /// <summary>
            /// The elastic ease out in
            /// </summary>
            ElasticEaseOutIn,
            /// <summary>
            /// The bounce ease out
            /// </summary>
            BounceEaseOut,
            /// <summary>
            /// The bounce ease in
            /// </summary>
            BounceEaseIn,
            /// <summary>
            /// The bounce ease in out
            /// </summary>
            BounceEaseInOut,
            /// <summary>
            /// The bounce ease out in
            /// </summary>
            BounceEaseOutIn,
            /// <summary>
            /// The back ease out
            /// </summary>
            BackEaseOut,
            /// <summary>
            /// The back ease in
            /// </summary>
            BackEaseIn,
            /// <summary>
            /// The back ease in out
            /// </summary>
            BackEaseInOut,
            /// <summary>
            /// The back ease out in
            /// </summary>
            BackEaseOutIn


        }

        /// <summary>
        /// The easing names
        /// </summary>
        private easingNames _easingNames = easingNames.BackEaseIn;


        /// <summary>
        /// This sets the type of easing to use for the animation.
        /// </summary>
        /// <value>The easing names.</value>
        [Browsable(true), Category("Easing Parameters")]
        public easingNames EasingNames
        {
            get { return _easingNames; }
            set
            {
                _easingNames = value;
                control.Invalidate();
            }

        }

        #endregion

        #region Public Properties
        /// <summary>
        /// This sets the fade animation start of the control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The easing start.</value>
        [Browsable(true), Category("Easing Parameters")]
        public double EasingStart
        {
            get { return easingstart; }
            set
            {
                easingstart = value;
                
            }
        }

        /// <summary>
        /// This sets the fade animation start of the control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The easing end.</value>
        [Browsable(true), Category("Easing Parameters")]
        public double EasingEnd
        {
            get { return easingend; }
            set
            {
                easingend = value;

            }
        }

        /// <summary>
        /// This sets the fade animation start of the control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The fade begin.</value>
        [Browsable(true), Category("Fade Animation")]
        public double Fade_Begin
        {
            get { return fadebegin; }
            set
            {
                if(value > 1)
                {
                    value = 1;
                }
                fadebegin = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// This sets the fade animation limit of the control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The fade limit.</value>
        [Browsable(true), Category("Fade Animation")]
        public double Fade_Limit
        {
            get { return fadelimit; }
            set
            {
                if (value > 1)
                {
                    value = 1;
                }
                fadelimit = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// This sets the fade animation limit of the control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The resize height begin.</value>
        [Browsable(true), Category("ResizeHeight Animation")]
        public double ResizeHeight_Begin
        {
            get { return resizeheightbegin; }
            set
            {
                
                resizeheightbegin = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// This sets the fade animation limit of the control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The resize height limit.</value>
        [Browsable(true), Category("ResizeHeight Animation")]
        public double ResizeHeight_Limit
        {
            get { return resizeheightlimit; }
            set
            {

                resizeheightlimit = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// This sets the fade animation limit of the control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The resize width begin.</value>
        [Browsable(true), Category("ResizeWidth Animation")]
        public double ResizeWidth_Begin
        {
            get { return resizewidthbegin; }
            set
            {

                resizewidthbegin = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// This sets the fade animation limit of the control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The resize width limit.</value>
        [Browsable(true), Category("ResizeWidth Animation")]
        public double ResizeWidth_Limit
        {
            get { return resizewidthlimit; }
            set
            {
                
                resizewidthlimit = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the cordinate start x for the Resize/Slide/SlideFrom Animation.
        /// </summary>
        /// <value>The cordinate start x.</value>
        [Browsable(true), Category("Resize/Slide/SlideFrom Animation")]
        public double CordinateStart_X
        {
            get { return cordinateStart_X; }
            set
            {
                cordinateStart_X = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the cordinate start y for the Resize/Slide/SlideFrom Animation.
        /// </summary>
        /// <value>The cordinate start y.</value>
        [Browsable(true), Category("Resize/Slide/SlideFrom Animation")]
        public double CordinateStart_Y
        {
            get { return cordinateStart_Y; }
            set
            {
                cordinateStart_Y = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the cordinate end x for the Resize/Slide/SlideFrom Animation.
        /// </summary>
        /// <value>The cordinate end x.</value>
        [Browsable(true), Category("Resize/Slide/SlideFrom Animation")]
        public double CordinateEnd_X
        {
            get { return cordinateEnd_X; }
            set
            {
                cordinateEnd_X = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the cordinate end y for the Resize/Slide/SlideFrom Animation.
        /// </summary>
        /// <value>The cordinate end y.</value>
        [Browsable(true), Category("Resize/Slide/SlideFrom Animation")]
        public double CordinateEnd_Y
        {
            get { return cordinateEnd_Y; }
            set
            {
                cordinateEnd_Y = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Sets the animation type of animation.
        /// SlideFrom - requires
        /// </summary>
        /// <value>The type of the animation.</value>
        public animationType AnimationType
        {
            get { return _animationType; }
            set
            {
                _animationType = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the acceleration.
        /// </summary>
        /// <value>The acceleration.</value>
        public double Acceleration
        {
            get { return accelerate; }
            set
            {
                if(value > 1)
                {
                    value = 1;
                }
                accelerate = value;
                control.Invalidate();
            }
        }
        /// <summary>
        /// Gets and sets the duration of the animation.
        /// </summary>
        /// <value>The duration.</value>
        /// <remarks>Duration should be in milliseconds (eg. 1000 for 1s)</remarks>
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
        /// Gets and Sets the control to be used for the animation.
        /// </summary>
        /// <value>The control.</value>
        public Control Control
        {
            get { return control; }
            set
            {
                if(control.Enabled)
                {
                    SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                    SetStyle(ControlStyles.UserPaint, true);
                    SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                }
                control = value;
                //control.Invalidate();
            }
        }

        /// <summary>
        /// The control styles
        /// </summary>
        public ControlStyles controlStyles = ControlStyles.OptimizedDoubleBuffer;

        /// <summary>
        /// Gets or sets a value indicating whether control styles should be enabled or disabled.
        /// </summary>
        /// <value><c>true</c> if control styles; otherwise, <c>false</c>.</value>
        [DefaultValue(true)]
        public bool ControlStylesBool
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the control styles.
        /// </summary>
        /// <value>The control styles.</value>
        public ControlStyles ControlStyles
        {
            get { return controlStyles; }
            set
            {
                controlStyles = value;

                #region Old Code
                //switch (controlStyles)
                //{

                //    case ControlStyles.UserPaint:
                //        ControlStyles.UserPaint.Equals(ControlStylesBool);
                //        break;

                //    case ControlStyles.ResizeRedraw:
                //        ControlStyles.ResizeRedraw.Equals(true);
                //        break;

                //    case ControlStyles.SupportsTransparentBackColor:
                //        ControlStyles.SupportsTransparentBackColor.Equals(true);
                //        break;

                //    case ControlStyles.AllPaintingInWmPaint:
                //        ControlStyles.AllPaintingInWmPaint.Equals(true);
                //        break;

                //    case ControlStyles.OptimizedDoubleBuffer:
                //        ControlStyles.OptimizedDoubleBuffer.Equals(true);
                //        break;

                //    default:
                //        break;
                //} 
                #endregion

                switch (controlStyles)
                {
                    case ControlStyles.ContainerControl:
                        ControlStyles.ContainerControl.Equals(ControlStylesBool);
                        break;
                    case ControlStyles.UserPaint:
                        ControlStyles.UserPaint.Equals(ControlStylesBool);
                        break;
                    case ControlStyles.Opaque:
                        ControlStyles.Opaque.Equals(ControlStylesBool);
                        break;
                    case ControlStyles.ResizeRedraw:
                        ControlStyles.ResizeRedraw.Equals(ControlStylesBool);
                        break;
                    case ControlStyles.FixedWidth:
                        ControlStyles.FixedWidth.Equals(ControlStylesBool);
                        break;
                    case ControlStyles.FixedHeight:
                        ControlStyles.FixedHeight.Equals(ControlStylesBool);
                        break;
                    case ControlStyles.StandardClick:
                        ControlStyles.StandardClick.Equals(ControlStylesBool);
                        break;
                    case ControlStyles.Selectable:
                        ControlStyles.Selectable.Equals(ControlStylesBool);
                        break;
                    case ControlStyles.UserMouse:
                        ControlStyles.UserMouse.Equals(ControlStylesBool);
                        break;
                    case ControlStyles.SupportsTransparentBackColor:
                        ControlStyles.SupportsTransparentBackColor.Equals(ControlStylesBool);
                        break;
                    case ControlStyles.StandardDoubleClick:
                        ControlStyles.StandardDoubleClick.Equals(ControlStylesBool);
                        break;
                    case ControlStyles.AllPaintingInWmPaint:
                        ControlStyles.AllPaintingInWmPaint.Equals(ControlStylesBool);
                        break;
                    case ControlStyles.CacheText:
                        ControlStyles.CacheText.Equals(ControlStylesBool);
                        break;
                    case ControlStyles.EnableNotifyMessage:
                        ControlStyles.EnableNotifyMessage.Equals(ControlStylesBool);
                        break;
                    case ControlStyles.DoubleBuffer:
                        ControlStyles.DoubleBuffer.Equals(ControlStylesBool);
                        break;
                    case ControlStyles.OptimizedDoubleBuffer:
                        ControlStyles.OptimizedDoubleBuffer.Equals(ControlStylesBool);
                        break;
                    case ControlStyles.UseTextForAccessibility:
                        ControlStyles.UseTextForAccessibility.Equals(ControlStylesBool);
                        break;
                    default:
                        break;
                }

                control.Invalidate();
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitPizaroAnim" /> class.
        /// </summary>
        public ZeroitPizaroAnim()
        {
            
        }

        #endregion

        #region Activate


        /// <summary>
        /// Starts the animation.
        /// </summary>
        public void Activate()
        {

            double[] start = new double[] { cordinateStart_X, cordinateStart_Y };

            double[] end = new double[] { cordinateEnd_X, cordinateEnd_Y };

            
            switch (_easingNames)
            {
                case easingNames.Linear:
                    double accel = Easing.Linear(DateTime.Now.Millisecond);
                    func(accel * accelerate);
                    break;
                case easingNames.EaseIn:
                    double accel1 = Easing.EaseIn(DateTime.Now.Millisecond);
                    func(accel1 * accelerate);
                    break;
                case easingNames.EaseOut:
                    double accel2 = Easing.EaseOut(DateTime.Now.Millisecond);
                    func(accel2 * accelerate);
                    break;
                case easingNames.EaseInAndOut:
                    double accel3 = Easing.EaseInAndOut(DateTime.Now.Millisecond);
                    func(accel3 * accelerate);
                    break;
                case easingNames.LinearTween:
                    double accel4 = Easing.LinearTween(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel4 * accelerate);
                    break;
                case easingNames.EaseInQuad:
                    double accel5 = Easing.EaseInQuad(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel5 * accelerate);
                    break;
                case easingNames.EaseOutQuad:
                    double accel6 = Easing.EaseOutQuad(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel6 * accelerate);
                    break;
                case easingNames.EaseInOutQuad:
                    double accel7 = Easing.EaseInOutQuad(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel7 * accelerate);
                    break;
                case easingNames.EaseInCubic:
                    double accel8 = Easing.EaseInCubic(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel8 * accelerate);
                    break;
                case easingNames.EaseOutCubic:
                    double accel9 = Easing.EaseOutCubic(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel9 * accelerate);
                    break;
                case easingNames.EaseInOutCubic:
                    double accel10 = Easing.EaseInOutCubic(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel10 * accelerate);
                    break;
                case easingNames.EaseInQuart:
                    double accel11 = Easing.EaseInQuart(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel11 * accelerate);
                    break;
                case easingNames.EaseOutQuart:
                    double accel12 = Easing.EaseOutQuart(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel12 * accelerate);
                    break;
                case easingNames.EaseInOutQuart:
                    double accel13 = Easing.EaseInOutQuart(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel13 * accelerate);
                    break;
                case easingNames.EaseInQuint:
                    double accel14 = Easing.EaseInQuint(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel14 * accelerate);
                    break;
                case easingNames.EaseOutQuint:
                    double accel15 = Easing.EaseOutQuint(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel15 * accelerate);
                    break;
                case easingNames.EaseInOutQuint:
                    double accel16 = Easing.EaseInOutQuint(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel16 * accelerate);
                    break;
                case easingNames.EaseInSine:
                    double accel17 = Easing.EaseInSine(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel17 * accelerate);
                    break;
                case easingNames.EaseOutSine:
                    double accel18 = Easing.EaseOutSine(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel18 * accelerate);
                    break;
                case easingNames.EaseInOutSine:
                    double accel19 = Easing.EaseInOutSine(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel19 * accelerate);
                    break;
                case easingNames.EaseInExpo:
                    double accel20 = Easing.EaseInExpo(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel20 * accelerate);
                    break;
                case easingNames.EaseOutExpo:
                    double accel21 = Easing.EaseOutExpo(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel21 * accelerate);
                    break;
                case easingNames.EaseInOutExpo:
                    double accel22 = Easing.EaseInOutExpo(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel22 * accelerate);
                    break;
                case easingNames.EaseInCirc:
                    double accel23 = Easing.EaseInCirc(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel23 * accelerate);
                    break;
                case easingNames.EaseOutCirc:
                    double accel24 = Easing.EaseOutCirc(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel24 * accelerate);
                    break;
                case easingNames.EaseInOutCirc:
                    double accel25 = Easing.EaseInOutCirc(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel25 * accelerate);
                    break;
                case easingNames.ElasticEaseOut:
                    double accel26 = Easing.ElasticEaseOut(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel26 * accelerate);
                    break;
                case easingNames.ElasticEaseIn:
                    double accel27 = Easing.ElasticEaseIn(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel27 * accelerate);
                    break;
                case easingNames.ElasticEaseInOut:
                    double accel28 = Easing.ElasticEaseInOut(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel28 * accelerate);
                    break;
                case easingNames.ElasticEaseOutIn:
                    double accel29 = Easing.ElasticEaseOutIn(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel29 * accelerate);
                    break;
                case easingNames.BounceEaseOut:
                    double accel30 = Easing.BounceEaseOut(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel30 * accelerate);
                    break;
                case easingNames.BounceEaseIn:
                    double accel31 = Easing.BounceEaseIn(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel31 * accelerate);
                    break;
                case easingNames.BounceEaseInOut:
                    double accel32 = Easing.BounceEaseInOut(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel32 * accelerate);
                    break;
                case easingNames.BounceEaseOutIn:
                    double accel33 = Easing.BounceEaseOutIn(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel33 * accelerate);
                    break;
                case easingNames.BackEaseOut:
                    double accel34 = Easing.BackEaseOut(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel34 * accelerate);
                    break;
                case easingNames.BackEaseIn:
                    double accel35 = Easing.BackEaseIn(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel35 * accelerate);
                    break;
                case easingNames.BackEaseInOut:
                    double accel36 = Easing.BackEaseInOut(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel36 * accelerate);
                    break;
                case easingNames.BackEaseOutIn:
                    double accel37 = Easing.BackEaseOutIn(DateTime.Now.Millisecond, easingstart, easingend, duration);
                    func(accel37 * accelerate);
                    break;
                default:
                    break;
            }

            
            //func(accelerate);
            //func(accel);

            switch (_animationType)
            {
                case animationType.Fade:
                    Fade fade = new Fade(control, fadebegin, fadelimit, duration, func);
                    fade.Play();
                    break;
                case animationType.FadeIn:
                    FadeIn fadeIn = new FadeIn(control, duration, func);
                    fadeIn.Play();
                    break;
                case animationType.FadeInAndShow:
                    FadeInAndShow fadeInAndShow = new FadeInAndShow(control, duration, func);
                    fadeInAndShow.Play();
                    break;
                case animationType.FadeOut:
                    FadeOut fadeOut = new FadeOut(control, duration, func);
                    fadeOut.Play();
                    break;
                case animationType.FadeOutandHide:
                    FadeOutAndHide fadeOutandHide = new FadeOutAndHide(control, duration, func);
                    fadeOutandHide.Play();
                    break;
                case animationType.Resize:
                    Resize resize = new Resize(control, start, end, duration, func);
                    resize.Play();
                    break;
                case animationType.ResizeHeight:
                    ResizeHeight resizeHeight = new ResizeHeight(control, resizeheightbegin, resizeheightlimit, duration, func);
                    resizeHeight.Play();
                    break;
                case animationType.ResizeWidth:
                    ResizeWidth resizeWidth = new ResizeWidth(control, resizewidthbegin, resizewidthlimit, duration, func);
                    resizeWidth.Play();
                    break;
                case animationType.Slide:
                    Slide slide = new Slide(control, start, end, duration, func);
                    slide.Play();
                    break;
                case animationType.SlideFrom:
                    SlideFrom slideFrom = new SlideFrom(control, end, duration, func);
                    slideFrom.Play();
                    break;
                default:
                    break;
            }

            

        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Sets the style.
        /// </summary>
        /// <param name="controlstyles">The controlstyles.</param>
        /// <param name="setbool">if set to <c>true</c> [setbool].</param>
        public void SetStyle(ControlStyles controlstyles, bool setbool)
        {
            controlstyles = controlStyles;
        }

        #endregion

    }

    
}
