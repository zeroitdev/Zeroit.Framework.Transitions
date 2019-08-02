// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="PizaroTransitionWithEditor.cs" company="Zeroit Dev Technologies">
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
using Zeroit.Framework.Transitions.AnimationEditors;



#endregion 

namespace Zeroit.Framework.Transitions.ZeroitPizaroAnimator
{
    /// <summary>
    /// A class collection that provides animation functionalities.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    public class ZeroitPizaroAnimEdit : Component
    {
        #region Private Fields

        /// <summary>
        /// The accel
        /// </summary>
        public double accel;

        /// <summary>
        /// The function
        /// </summary>
        Func<double, double> func = num => num;
        /// <summary>
        /// Sets the animation type for the <c><see cref="ZeroitPizaroAnimEdit" /></c> animator.
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
        /// The pizaro animator input
        /// </summary>
        ZeroitPizaroAnimatorInput pizaroAnimatorInput = new ZeroitPizaroAnimatorInput(animationType.None, new Control());

        //ZeroitPizaroAnimatorInput pizaroAnimatorInput = new ZeroitPizaroAnimatorInput(ZeroitPizaroAnimEdit.animationType.Resize, 10, 10, 50, 50);


        #endregion

        #region Easing Property

        /// <summary>
        /// Sets the easing function for the <c><see cref="ZeroitPizaroAnimEdit" /></c> animator.
        /// </summary>
        public enum easingNames
        {

            None,
            BackEaseIn,
            BackEaseInOut,
            BackEaseOut,
            BackEaseOutIn,
            BounceEaseIn,
            BounceEaseInOut,
            BounceEaseInOutV2,
            BounceEaseInV2,
            BounceEaseOut,
            BounceEaseOutIn,
            BounceEaseOutInV2,
            BounceEaseOutV2,
            CircularEaseIn,
            CircularEaseInOut,
            CircularEaseOut,
            CubicEaseIn,
            CubicEaseInOut,
            CubicEaseOut,
            EaseIn,
            EaseInAndOut,
            EaseInCirc,
            EaseInCubic,
            EaseInExpo,
            EaseInOutCirc,
            EaseInOutCubic,
            EaseInOutExpo,
            EaseInOutQuad,
            EaseInOutQuart,
            EaseInOutQuint,
            EaseInOutSine,
            EaseInQuad,
            EaseInQuart,
            EaseInQuint,
            EaseInSine,
            EaseOut,
            EaseOutCirc,
            EaseOutCubic,
            EaseOutExpo,
            EaseOutQuad,
            EaseOutQuart,
            EaseOutQuint,
            EaseOutSine,
            ElasticEaseIn,
            ElasticEaseInOut,
            ElasticEaseOut,
            ElasticEaseOutIn,
            ExponentialEaseIn,
            ExponentialEaseInOut,
            ExponentialEaseOut,
            Linear,
            LinearTween,
            Liner,
            QuadraticEaseIn,
            QuadraticEaseInOut,
            QuadraticEaseOut,
            QuarticEaseIn,
            QuarticEaseInOut,
            QuarticEaseOut,
            QuinticEaseIn,
            QuinticEaseInOut,
            QuinticEaseOut,
            SinusoidalEaseIn,
            SinusoidalEaseInOut,
            SinusoidalEaseOut,

        }


        /// <summary>
        /// This sets the type of easing to use for the animation.
        /// </summary>
        /// <value>The easing names.</value>
        [Browsable(true), Category("Easing Parameters")]
        public easingNames EasingNames
        {
            get { return pizaroAnimatorInput.EasingNames; }
            set
            {
                pizaroAnimatorInput.EasingNames = value;
                //pizaroAnimatorInput.Control.Invalidate();
            }

        }

        #endregion

        #region Public Properties        
        /// <summary>
        /// Gets or sets the pizaro animator input.
        /// <para> These are values to use in the animation editor.</para>
        /// </summary>
        /// <value>The pizaro animator input.</value>
        public ZeroitPizaroAnimatorInput Editor
        {
            get { return pizaroAnimatorInput; }
            set
            {
                pizaroAnimatorInput = value;
                ////pizaroAnimatorInput.Control.Invalidate();
            }
        }

        /// <summary>
        /// This sets the fade animation start of the Control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The easing start.</value>
        [Browsable(true), Category("Easing Parameters")]
        public float EasingStart
        {
            get { return pizaroAnimatorInput.EasingStart; }
            set
            {
                pizaroAnimatorInput.EasingStart = value;
                //pizaroAnimatorInput.Control.Invalidate();

            }
        }

        /// <summary>
        /// This sets the fade animation start of the Control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The easing end.</value>
        [Browsable(true), Category("Easing Parameters")]
        public float EasingEnd
        {
            get { return pizaroAnimatorInput.EasingEnd; }
            set
            {
                pizaroAnimatorInput.EasingEnd = value;
                //pizaroAnimatorInput.Control.Invalidate();

            }
        }

        /// <summary>
        /// This sets the fade animation start of the Control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The fade begin.</value>
        [Browsable(true), Category("Fade Animation")]
        public float Fade_Begin
        {
            get { return pizaroAnimatorInput.Fade_Begin; }
            set
            {
                if(value > 1)
                {
                    value = 1;
                }
                pizaroAnimatorInput.Fade_Begin = value;
                //pizaroAnimatorInput.Control.Invalidate();
            }
        }

        /// <summary>
        /// This sets the fade animation limit of the Control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The fade limit.</value>
        [Browsable(true), Category("Fade Animation")]
        public float Fade_Limit
        {
            get { return pizaroAnimatorInput.Fade_Limit; }
            set
            {
                if (value > 1)
                {
                    value = 1;
                }
                pizaroAnimatorInput.Fade_Limit = value;
                //pizaroAnimatorInput.Control.Invalidate();
            }
        }

        /// <summary>
        /// This sets the fade animation limit of the Control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The resize height begin.</value>
        [Browsable(true), Category("ResizeHeight Animation")]
        public float ResizeHeight_Begin
        {
            get { return pizaroAnimatorInput.ResizeHeight_Begin; }
            set
            {

                pizaroAnimatorInput.ResizeHeight_Begin = value;
                //pizaroAnimatorInput.Control.Invalidate();
            }
        }

        /// <summary>
        /// This sets the fade animation limit of the Control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The resize height limit.</value>
        [Browsable(true), Category("ResizeHeight Animation")]
        public float ResizeHeight_Limit
        {
            get { return pizaroAnimatorInput.ResizeHeight_Limit; }
            set
            {

                pizaroAnimatorInput.ResizeHeight_Limit = value;
                //pizaroAnimatorInput.Control.Invalidate();
            }
        }

        /// <summary>
        /// This sets the fade animation limit of the Control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The resize width begin.</value>
        [Browsable(true), Category("ResizeWidth Animation")]
        public float ResizeWidth_Begin
        {
            get { return pizaroAnimatorInput.ResizeWidth_Begin; }
            set
            {

                pizaroAnimatorInput.ResizeWidth_Begin = value;
                //pizaroAnimatorInput.Control.Invalidate();
            }
        }

        /// <summary>
        /// This sets the fade animation limit of the Control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The resize width limit.</value>
        [Browsable(true), Category("ResizeWidth Animation")]
        public float ResizeWidth_Limit
        {
            get { return pizaroAnimatorInput.ResizeWidth_Limit; }
            set
            {

                pizaroAnimatorInput.ResizeWidth_Limit = value;
                //pizaroAnimatorInput.Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the cordinate start x for the Resize/Slide/SlideFrom Animation.
        /// </summary>
        /// <value>The cordinate start x.</value>
        [Browsable(true), Category("Resize/Slide/SlideFrom Animation")]
        public float CordinateStart_X
        {
            get { return pizaroAnimatorInput.CordinateStart_X; }
            set
            {
                pizaroAnimatorInput.CordinateStart_X = value;
                //pizaroAnimatorInput.Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the cordinate start y for the Resize/Slide/SlideFrom Animation.
        /// </summary>
        /// <value>The cordinate start y.</value>
        [Browsable(true), Category("Resize/Slide/SlideFrom Animation")]
        public float CordinateStart_Y
        {
            get { return pizaroAnimatorInput.CordinateStart_Y; }
            set
            {
                pizaroAnimatorInput.CordinateStart_Y = value;
                //pizaroAnimatorInput.Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the cordinate end x for the Resize/Slide/SlideFrom Animation.
        /// </summary>
        /// <value>The cordinate end x.</value>
        [Browsable(true), Category("Resize/Slide/SlideFrom Animation")]
        public float CordinateEnd_X
        {
            get { return pizaroAnimatorInput.cordinateEnd_X; }
            set
            {
                pizaroAnimatorInput.cordinateEnd_X = value;
                //pizaroAnimatorInput.Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the cordinate end y for the Resize/Slide/SlideFrom Animation.
        /// </summary>
        /// <value>The cordinate end y.</value>
        [Browsable(true), Category("Resize/Slide/SlideFrom Animation")]
        public float CordinateEnd_Y
        {
            get { return pizaroAnimatorInput.cordinateEnd_Y; }
            set
            {
                pizaroAnimatorInput.cordinateEnd_Y = value;
                //pizaroAnimatorInput.Control.Invalidate();
            }
        }

        /// <summary>
        /// Sets the animation type of animation.
        /// SlideFrom - requires
        /// </summary>
        /// <value>The type of the animation.</value>
        public animationType AnimationType
        {
            get { return pizaroAnimatorInput.AnimationType; }
            set
            {
                pizaroAnimatorInput.AnimationType = value;
                //pizaroAnimatorInput.Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the acceleration.
        /// </summary>
        /// <value>The acceleration.</value>
        public float Acceleration
        {
            get { return pizaroAnimatorInput.Acceleration; }
            set
            {
                if(value > 1)
                {
                    value = 1;
                }
                pizaroAnimatorInput.Acceleration = value;
                //pizaroAnimatorInput.Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets and sets the duration of the animation.
        /// </summary>
        /// <value>The duration.</value>
        /// <remarks>Duration should be in milliseconds (eg. 1000 for 1s)</remarks>
        public int Duration
        {
            get { return pizaroAnimatorInput.Duration; }
            set
            {
                pizaroAnimatorInput.Duration = value;
                //pizaroAnimatorInput.Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets and Sets the control to be used for the animation.
        /// </summary>
        /// <value>The control.</value>
        public Control Control
        {
            get { return pizaroAnimatorInput.Control; }
            set
            {

                pizaroAnimatorInput.Control = value;
                //pizaroAnimatorInput.Control.Invalidate();
            }
        }

        #region Control code
        //private Control control = new Control();

        ///// <summary>
        ///// Selects the Control to be used
        ///// </summary>
        //public Control Control
        //{
        //    get
        //    {
        //        return control;

        //    }
        //    set
        //    {

        //        control = value;
        //        PizaControl = value;
        //        //control.Invalidate();

        //        control.Invalidate();
        //        PizaControl.Invalidate();
        //    }
        //    //get;
        //    //set;
        //}

        //[Browsable(true)]
        //public Control PizaControl
        //{
        //    get { return pizaroAnimatorInput.control; }
        //    set
        //    {
        //        pizaroAnimatorInput.control = value;
        //        control = value;

        //        control.Invalidate();
        //        pizaroAnimatorInput.Control.Invalidate();
        //    }
        //} 
        #endregion

        /// <summary>
        /// The control styles
        /// </summary>
        public ControlStyles controlStyles = ControlStyles.OptimizedDoubleBuffer;

        //[DefaultValue(true)]
        //public bool ControlStylesBool
        //{
        //    get;
        //    set;
        //}
        //public ControlStyles ControlStyles
        //{
        //    get { return controlStyles; }
        //    set
        //    {
        //        controlStyles = value;

        //        #region Old Code
        //        //switch (controlStyles)
        //        //{

        //        //    case ControlStyles.UserPaint:
        //        //        ControlStyles.UserPaint.Equals(ControlStylesBool);
        //        //        break;

        //        //    case ControlStyles.ResizeRedraw:
        //        //        ControlStyles.ResizeRedraw.Equals(true);
        //        //        break;

        //        //    case ControlStyles.SupportsTransparentBackColor:
        //        //        ControlStyles.SupportsTransparentBackColor.Equals(true);
        //        //        break;

        //        //    case ControlStyles.AllPaintingInWmPaint:
        //        //        ControlStyles.AllPaintingInWmPaint.Equals(true);
        //        //        break;

        //        //    case ControlStyles.OptimizedDoubleBuffer:
        //        //        ControlStyles.OptimizedDoubleBuffer.Equals(true);
        //        //        break;

        //        //    default:
        //        //        break;
        //        //} 
        //        #endregion

        //        switch (controlStyles)
        //        {
        //            case ControlStyles.ContainerControl:
        //                ControlStyles.ContainerControl.Equals(ControlStylesBool);
        //                break;
        //            case ControlStyles.UserPaint:
        //                ControlStyles.UserPaint.Equals(ControlStylesBool);
        //                break;
        //            case ControlStyles.Opaque:
        //                ControlStyles.Opaque.Equals(ControlStylesBool);
        //                break;
        //            case ControlStyles.ResizeRedraw:
        //                ControlStyles.ResizeRedraw.Equals(ControlStylesBool);
        //                break;
        //            case ControlStyles.FixedWidth:
        //                ControlStyles.FixedWidth.Equals(ControlStylesBool);
        //                break;
        //            case ControlStyles.FixedHeight:
        //                ControlStyles.FixedHeight.Equals(ControlStylesBool);
        //                break;
        //            case ControlStyles.StandardClick:
        //                ControlStyles.StandardClick.Equals(ControlStylesBool);
        //                break;
        //            case ControlStyles.Selectable:
        //                ControlStyles.Selectable.Equals(ControlStylesBool);
        //                break;
        //            case ControlStyles.UserMouse:
        //                ControlStyles.UserMouse.Equals(ControlStylesBool);
        //                break;
        //            case ControlStyles.SupportsTransparentBackColor:
        //                ControlStyles.SupportsTransparentBackColor.Equals(ControlStylesBool);
        //                break;
        //            case ControlStyles.StandardDoubleClick:
        //                ControlStyles.StandardDoubleClick.Equals(ControlStylesBool);
        //                break;
        //            case ControlStyles.AllPaintingInWmPaint:
        //                ControlStyles.AllPaintingInWmPaint.Equals(ControlStylesBool);
        //                break;
        //            case ControlStyles.CacheText:
        //                ControlStyles.CacheText.Equals(ControlStylesBool);
        //                break;
        //            case ControlStyles.EnableNotifyMessage:
        //                ControlStyles.EnableNotifyMessage.Equals(ControlStylesBool);
        //                break;
        //            case ControlStyles.DoubleBuffer:
        //                ControlStyles.DoubleBuffer.Equals(ControlStylesBool);
        //                break;
        //            case ControlStyles.OptimizedDoubleBuffer:
        //                ControlStyles.OptimizedDoubleBuffer.Equals(ControlStylesBool);
        //                break;
        //            case ControlStyles.UseTextForAccessibility:
        //                ControlStyles.UseTextForAccessibility.Equals(ControlStylesBool);
        //                break;
        //            default:
        //                break;
        //        }

        //        //Control.Invalidate();
        //    }
        //}



        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitPizaroAnimEdit" /> class.
        /// </summary>
        public ZeroitPizaroAnimEdit()
        {
            
        }

        #endregion

        #region Activate


        ///// <summary>
        ///// Starts the animation.
        ///// </summary>
        //public void Activate()
        //{

        //    //double[] start = new double[] { pizaroAnimatorInput.CordinateStart_X, pizaroAnimatorInput.CordinateStart_Y };

        //    //double[] end = new double[] { pizaroAnimatorInput.CordinateEnd_X, pizaroAnimatorInput.CordinateEnd_Y };

            
        //    switch (EasingNames)
        //    {
        //        case easingNames.Linear:
        //            double accel = Easing.Linear(DateTime.Now.Millisecond);
        //            func(accel * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseIn:
        //            double accel1 = Easing.EaseIn(DateTime.Now.Millisecond);
        //            func(accel1 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseOut:
        //            double accel2 = Easing.EaseOut(DateTime.Now.Millisecond);
        //            func(accel2 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseInAndOut:
        //            double accel3 = Easing.EaseInAndOut(DateTime.Now.Millisecond);
        //            func(accel3 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.LinearTween:
        //            double accel4 = Easing.LinearTween(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel4 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseInQuad:
        //            double accel5 = Easing.EaseInQuad(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel5 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseOutQuad:
        //            double accel6 = Easing.EaseOutQuad(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel6 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseInOutQuad:
        //            double accel7 = Easing.EaseInOutQuad(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel7 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseInCubic:
        //            double accel8 = Easing.EaseInCubic(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel8 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseOutCubic:
        //            double accel9 = Easing.EaseOutCubic(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel9 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseInOutCubic:
        //            double accel10 = Easing.EaseInOutCubic(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel10 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseInQuart:
        //            double accel11 = Easing.EaseInQuart(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel11 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseOutQuart:
        //            double accel12 = Easing.EaseOutQuart(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel12 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseInOutQuart:
        //            double accel13 = Easing.EaseInOutQuart(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel13 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseInQuint:
        //            double accel14 = Easing.EaseInQuint(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel14 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseOutQuint:
        //            double accel15 = Easing.EaseOutQuint(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel15 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseInOutQuint:
        //            double accel16 = Easing.EaseInOutQuint(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel16 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseInSine:
        //            double accel17 = Easing.EaseInSine(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel17 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseOutSine:
        //            double accel18 = Easing.EaseOutSine(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel18 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseInOutSine:
        //            double accel19 = Easing.EaseInOutSine(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel19 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseInExpo:
        //            double accel20 = Easing.EaseInExpo(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel20 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseOutExpo:
        //            double accel21 = Easing.EaseOutExpo(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel21 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseInOutExpo:
        //            double accel22 = Easing.EaseInOutExpo(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel22 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseInCirc:
        //            double accel23 = Easing.EaseInCirc(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel23 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseOutCirc:
        //            double accel24 = Easing.EaseOutCirc(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel24 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.EaseInOutCirc:
        //            double accel25 = Easing.EaseInOutCirc(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel25 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.ElasticEaseOut:
        //            double accel26 = Easing.ElasticEaseOut(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel26 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.ElasticEaseIn:
        //            double accel27 = Easing.ElasticEaseIn(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel27 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.ElasticEaseInOut:
        //            double accel28 = Easing.ElasticEaseInOut(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel28 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.ElasticEaseOutIn:
        //            double accel29 = Easing.ElasticEaseOutIn(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel29 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.BounceEaseOut:
        //            double accel30 = Easing.BounceEaseOut(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel30 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.BounceEaseIn:
        //            double accel31 = Easing.BounceEaseIn(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel31 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.BounceEaseInOut:
        //            double accel32 = Easing.BounceEaseInOut(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel32 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.BounceEaseOutIn:
        //            double accel33 = Easing.BounceEaseOutIn(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel33 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.BackEaseOut:
        //            double accel34 = Easing.BackEaseOut(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel34 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.BackEaseIn:
        //            double accel35 = Easing.BackEaseIn(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel35 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.BackEaseInOut:
        //            double accel36 = Easing.BackEaseInOut(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel36 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        case easingNames.BackEaseOutIn:
        //            double accel37 = Easing.BackEaseOutIn(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
        //            func(accel37 * pizaroAnimatorInput.Acceleration);
        //            break;
        //        default:
        //            break;
        //    }

            
        //    //func(pizaroAnimatorInput.Acceleration);
        //    //func(accel);

        //    switch (AnimationType)
        //    {
        //        case animationType.Fade:
        //            Fade fade = new Fade(Control, pizaroAnimatorInput.Fade_Begin, pizaroAnimatorInput.Fade_Limit, pizaroAnimatorInput.Duration, func);
        //            fade.Play();
        //            break;
        //        case animationType.FadeIn:
        //            FadeIn fadeIn = new FadeIn(Control, pizaroAnimatorInput.Duration, func);
        //            fadeIn.Play();
        //            break;
        //        case animationType.FadeInAndShow:
        //            FadeInAndShow fadeInAndShow = new FadeInAndShow(Control, pizaroAnimatorInput.Duration, func);
        //            fadeInAndShow.Play();
        //            break;
        //        case animationType.FadeOut:
        //            FadeOut fadeOut = new FadeOut(Control, pizaroAnimatorInput.Duration, func);
        //            fadeOut.Play();
        //            break;
        //        case animationType.FadeOutandHide:
        //            FadeOutAndHide fadeOutandHide = new FadeOutAndHide(Control, pizaroAnimatorInput.Duration, func);
        //            fadeOutandHide.Play();
        //            break;
        //        case animationType.Resize:
        //            Resize resize = new Resize(Control, new double[] { pizaroAnimatorInput.CordinateStart_X, pizaroAnimatorInput.CordinateStart_Y }, new double[] { pizaroAnimatorInput.CordinateEnd_X, pizaroAnimatorInput.CordinateEnd_Y }, pizaroAnimatorInput.Duration, func);
        //            resize.Play();
        //            break;
        //        case animationType.ResizeHeight:
        //            ResizeHeight resizeHeight = new ResizeHeight(Control, ResizeHeight_Begin, ResizeHeight_Limit, pizaroAnimatorInput.Duration, func);
        //            resizeHeight.Play();
        //            break;
        //        case animationType.ResizeWidth:
        //            ResizeWidth resizeWidth = new ResizeWidth(Control, ResizeWidth_Begin, ResizeWidth_Limit, pizaroAnimatorInput.Duration, func);
        //            resizeWidth.Play();
        //            break;
        //        case animationType.Slide:
        //            Slide slide = new Slide(Control, new double[] { pizaroAnimatorInput.CordinateStart_X, pizaroAnimatorInput.CordinateStart_Y }, new double[] { pizaroAnimatorInput.CordinateEnd_X, pizaroAnimatorInput.CordinateEnd_Y }, pizaroAnimatorInput.Duration, func);
        //            slide.Play();
        //            break;
        //        case animationType.SlideFrom:
        //            SlideFrom slideFrom = new SlideFrom(Control, new double[] { pizaroAnimatorInput.CordinateEnd_X, pizaroAnimatorInput.CordinateEnd_Y }, pizaroAnimatorInput.Duration, func);
        //            slideFrom.Play();
        //            break;
        //        default:
        //            break;
        //    }

            

        //}

        #endregion
            
        #region NewlyAdded

        Fade fade;

        FadeIn fadeIn;

        FadeInAndShow fadeInAndShow;

        FadeOut fadeOut;

        FadeOutAndHide fadeOutandHide;

        Resize resize;

        ResizeHeight resizeHeight;

        ResizeWidth resizeWidth;

        Slide slide;

        SlideFrom slideFrom;

        #endregion

        #region Activate

        public float AcceptAll(float var1, float var2, float var3, float var4)
        {

            
            switch (EasingNames)
            {
                case easingNames.Linear:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseIn:
                    return Easing.EaseIn(var1);
                    break;
                case easingNames.EaseOut:
                    return Easing.EaseOut(var1);
                    break;
                case easingNames.EaseInAndOut:
                    return Easing.EaseInAndOut(var1);
                    break;
                case easingNames.None:

                    break;
                case easingNames.BounceEaseOut:
                    return Easing.BounceEaseOut(var1, var2, var3, var4);
                    break;
                case easingNames.BounceEaseIn:
                    return Easing.BounceEaseIn(var1, var2, var3, var4);
                    break;
                case easingNames.BounceEaseInOut:
                    return Easing.BounceEaseInOut(var1, var2, var3, var4);
                    break;
                case easingNames.BounceEaseOutIn:
                    return Easing.BounceEaseOutIn(var1, var2, var3, var4);
                    break;
                case easingNames.CubicEaseIn:
                    return Easing.CubicEaseIn(var1, var2, var3, var4);
                    break;
                case easingNames.CubicEaseInOut:
                    return Easing.CubicEaseInOut(var1, var2, var3, var4);
                    break;
                case easingNames.CubicEaseOut:
                    return Easing.CubicEaseOut(var1, var2, var3, var4);
                    break;
                case easingNames.Liner:
                    return Easing.Liner(var1, var2, var3, var4);
                    break;
                case easingNames.CircularEaseInOut:
                    return Easing.CircularEaseInOut(var1, var2, var3, var4);
                    break;
                case easingNames.CircularEaseIn:
                    return Easing.CircularEaseIn(var1, var2, var3, var4);
                    break;
                case easingNames.CircularEaseOut:
                    return Easing.CircularEaseOut(var1, var2, var3, var4);
                    break;
                case easingNames.QuadraticEaseIn:
                    return Easing.QuadraticEaseIn(var1, var2, var3, var4);
                    break;
                case easingNames.QuadraticEaseOut:
                    return Easing.QuadraticEaseOut(var1, var2, var3, var4);
                    break;
                case easingNames.QuadraticEaseInOut:
                    return Easing.QuadraticEaseInOut(var1, var2, var3, var4);
                    break;
                case easingNames.QuarticEaseIn:
                    return Easing.QuarticEaseIn(var1, var2, var3, var4);
                    break;
                case easingNames.QuarticEaseOut:
                    return Easing.QuarticEaseOut(var1, var2, var3, var4);
                    break;
                case easingNames.QuarticEaseInOut:
                    return Easing.QuarticEaseInOut(var1, var2, var3, var4);
                    break;
                case easingNames.QuinticEaseInOut:
                    return Easing.QuinticEaseInOut(var1, var2, var3, var4);
                    break;
                case easingNames.QuinticEaseIn:
                    return Easing.QuinticEaseIn(var1, var2, var3, var4);
                    break;
                case easingNames.QuinticEaseOut:
                    return Easing.QuinticEaseOut(var1, var2, var3, var4);
                    break;
                case easingNames.SinusoidalEaseIn:
                    return Easing.SinusoidalEaseIn(var1, var2, var3, var4);
                    break;
                case easingNames.SinusoidalEaseOut:
                    return Easing.SinusoidalEaseOut(var1, var2, var3, var4);
                    break;
                case easingNames.SinusoidalEaseInOut:
                    return Easing.SinusoidalEaseInOut(var1, var2, var3, var4);
                    break;
                case easingNames.ExponentialEaseIn:
                    return Easing.ExponentialEaseIn(var1, var2, var3, var4);
                    break;
                case easingNames.ExponentialEaseOut:
                    return Easing.ExponentialEaseOut(var1, var2, var3, var4);
                    break;
                case easingNames.ExponentialEaseInOut:
                    return Easing.ExponentialEaseInOut(var1, var2, var3, var4);
                    break;
                case easingNames.LinearTween:
                    return Easing.LinearTween(var1, var2, var3, var4);
                    break;
                case easingNames.EaseInQuad:
                    return Easing.EaseInQuad(var1, var2, var3, var4);
                    break;
                case easingNames.EaseOutQuad:
                    return Easing.EaseOutQuad(var1, var2, var3, var4);
                    break;
                case easingNames.EaseInOutQuad:
                    return Easing.EaseInOutQuad(var1, var2, var3, var4);
                    break;
                case easingNames.EaseInCubic:
                    return Easing.EaseInCubic(var1, var2, var3, var4);
                    break;
                case easingNames.EaseOutCubic:
                    return Easing.EaseOutCubic(var1, var2, var3, var4);
                    break;
                case easingNames.EaseInOutCubic:
                    return Easing.EaseInOutCubic(var1, var2, var3, var4);
                    break;
                case easingNames.EaseInQuart:
                    return Easing.EaseInQuart(var1, var2, var3, var4);
                    break;
                case easingNames.EaseOutQuart:
                    return Easing.EaseOutQuart(var1, var2, var3, var4);
                    break;
                case easingNames.EaseInOutQuart:
                    return Easing.EaseInOutQuart(var1, var2, var3, var4);
                    break;
                case easingNames.EaseInQuint:
                    return Easing.EaseInQuint(var1, var2, var3, var4);
                    break;
                case easingNames.EaseOutQuint:
                    return Easing.EaseOutQuint(var1, var2, var3, var4);
                    break;
                case easingNames.EaseInOutQuint:
                    return Easing.EaseInOutQuint(var1, var2, var3, var4);
                    break;
                case easingNames.EaseInSine:
                    return Easing.EaseInSine(var1, var2, var3, var4);
                    break;
                case easingNames.EaseOutSine:
                    return Easing.EaseOutSine(var1, var2, var3, var4);
                    break;
                case easingNames.EaseInOutSine:
                    return Easing.EaseInOutSine(var1, var2, var3, var4);
                    break;
                case easingNames.EaseInExpo:
                    return Easing.EaseInExpo(var1, var2, var3, var4);
                    break;
                case easingNames.EaseOutExpo:
                    return Easing.EaseOutExpo(var1, var2, var3, var4);
                    break;
                case easingNames.EaseInOutExpo:
                    return Easing.EaseInOutExpo(var1, var2, var3, var4);
                    break;
                case easingNames.EaseInCirc:
                    return Easing.EaseInCirc(var1, var2, var3, var4);
                    break;
                case easingNames.EaseOutCirc:
                    return Easing.EaseOutCirc(var1, var2, var3, var4);
                    break;
                case easingNames.EaseInOutCirc:
                    return Easing.EaseInOutCirc(var1, var2, var3, var4);
                    break;
                case easingNames.ElasticEaseOut:
                    return Easing.ElasticEaseOut(var1, var2, var3, var4);
                    break;
                case easingNames.ElasticEaseIn:
                    return Easing.ElasticEaseIn(var1, var2, var3, var4);
                    break;
                case easingNames.ElasticEaseInOut:
                    return Easing.ElasticEaseInOut(var1, var2, var3, var4);
                    break;
                case easingNames.ElasticEaseOutIn:
                    return Easing.ElasticEaseOutIn(var1, var2, var3, var4);
                    break;
                case easingNames.BounceEaseOutV2:
                    return Easing.BounceEaseOutV2(var1, var2, var3, var4);
                    break;
                case easingNames.BounceEaseInV2:
                    return Easing.BounceEaseInV2(var1, var2, var3, var4);
                    break;
                case easingNames.BounceEaseInOutV2:
                    return Easing.BounceEaseInOutV2(var1, var2, var3, var4);
                    break;
                case easingNames.BounceEaseOutInV2:
                    return Easing.BounceEaseOutInV2(var1, var2, var3, var4);
                    break;
                case easingNames.BackEaseOut:
                    return Easing.BackEaseOut(var1, var2, var3, var4);
                    break;
                case easingNames.BackEaseIn:
                    return Easing.BackEaseIn(var1, var2, var3, var4);
                    break;
                case easingNames.BackEaseInOut:
                    return Easing.BackEaseInOut(var1, var2, var3, var4);
                    break;
                case easingNames.BackEaseOutIn:
                    return Easing.BackEaseOutIn(var1, var2, var3, var4);
                    break;
                default:
                    break;
            }

            return AcceptAll(var1, var2, var3, var4);
        }

        public float FadeAll(float var1)
        {
            
            switch (EasingNames)
            {
                case easingNames.Linear:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseIn:
                    return Easing.EaseIn(var1);
                    break;
                case easingNames.EaseOut:
                    return Easing.EaseOut(var1);
                    break;
                case easingNames.EaseInAndOut:
                    return Easing.EaseInAndOut(var1);
                    break;
                case easingNames.None:
                    break;
                case easingNames.BounceEaseOut:
                    return Easing.Linear(var1);
                    break;
                case easingNames.BounceEaseIn:
                    return Easing.Linear(var1);
                    break;
                case easingNames.BounceEaseInOut:
                    return Easing.Linear(var1);
                    break;
                case easingNames.BounceEaseOutIn:
                    return Easing.Linear(var1);
                    break;
                case easingNames.CubicEaseIn:
                    return Easing.Linear(var1);
                    break;
                case easingNames.CubicEaseInOut:
                    return Easing.Linear(var1);
                    break;
                case easingNames.CubicEaseOut:
                    return Easing.Linear(var1);
                    break;
                case easingNames.Liner:
                    return Easing.Linear(var1);
                    break;
                case easingNames.CircularEaseInOut:
                    return Easing.Linear(var1);
                    break;
                case easingNames.CircularEaseIn:
                    return Easing.Linear(var1);
                    break;
                case easingNames.CircularEaseOut:
                    return Easing.Linear(var1);
                    break;
                case easingNames.QuadraticEaseIn:
                    return Easing.Linear(var1);
                    break;
                case easingNames.QuadraticEaseOut:
                    return Easing.Linear(var1);
                    break;
                case easingNames.QuadraticEaseInOut:
                    return Easing.Linear(var1);
                    break;
                case easingNames.QuarticEaseIn:
                    return Easing.Linear(var1);
                    break;
                case easingNames.QuarticEaseOut:
                    return Easing.Linear(var1);
                    break;
                case easingNames.QuarticEaseInOut:
                    return Easing.Linear(var1);
                    break;
                case easingNames.QuinticEaseInOut:
                    return Easing.Linear(var1);
                    break;
                case easingNames.QuinticEaseIn:
                    return Easing.Linear(var1);
                    break;
                case easingNames.QuinticEaseOut:
                    return Easing.Linear(var1);
                    break;
                case easingNames.SinusoidalEaseIn:
                    return Easing.Linear(var1);
                    break;
                case easingNames.SinusoidalEaseOut:
                    return Easing.Linear(var1);
                    break;
                case easingNames.SinusoidalEaseInOut:
                    return Easing.Linear(var1);
                    break;
                case easingNames.ExponentialEaseIn:
                    return Easing.Linear(var1);
                    break;
                case easingNames.ExponentialEaseOut:
                    return Easing.Linear(var1);
                    break;
                case easingNames.ExponentialEaseInOut:
                    return Easing.Linear(var1);
                    break;
                case easingNames.LinearTween:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseInQuad:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseOutQuad:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseInOutQuad:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseInCubic:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseOutCubic:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseInOutCubic:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseInQuart:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseOutQuart:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseInOutQuart:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseInQuint:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseOutQuint:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseInOutQuint:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseInSine:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseOutSine:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseInOutSine:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseInExpo:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseOutExpo:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseInOutExpo:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseInCirc:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseOutCirc:
                    return Easing.Linear(var1);
                    break;
                case easingNames.EaseInOutCirc:
                    return Easing.Linear(var1);
                    break;
                case easingNames.ElasticEaseOut:
                    return Easing.Linear(var1);
                    break;
                case easingNames.ElasticEaseIn:
                    return Easing.Linear(var1);
                    break;
                case easingNames.ElasticEaseInOut:
                    return Easing.Linear(var1);
                    break;
                case easingNames.ElasticEaseOutIn:
                    return Easing.Linear(var1);
                    break;
                case easingNames.BounceEaseOutV2:
                    return Easing.Linear(var1);
                    break;
                case easingNames.BounceEaseInV2:
                    return Easing.Linear(var1);
                    break;
                case easingNames.BounceEaseInOutV2:
                    return Easing.Linear(var1);
                    break;
                case easingNames.BounceEaseOutInV2:
                    return Easing.Linear(var1);
                    break;
                case easingNames.BackEaseOut:
                    return Easing.Linear(var1);
                    break;
                case easingNames.BackEaseIn:
                    return Easing.Linear(var1);
                    break;
                case easingNames.BackEaseInOut:
                    return Easing.Linear(var1);
                    break;
                case easingNames.BackEaseOutIn:
                    return Easing.Linear(var1);
                    break;
                default:
                    break;
            }


            return FadeAll(var1);
        }


        /// <summary>
        /// Starts the animation.
        /// </summary>
        public void Activate()
        {

            float[] start = new float[] { CordinateStart_X, CordinateStart_Y };

            float[] end = new float[] { CordinateEnd_X, CordinateEnd_Y };

            Func<float, float, float, float, float> func = new Func<float, float, float, float, float>(AcceptAll);

            Func<float, float> fadeAll = new Func<float, float>(FadeAll);


            switch (AnimationType)
            {
                case animationType.Fade:
                    fade = new Fade(Control, Fade_Begin, Fade_Limit, Duration, fadeAll);
                    fade.Play();
                    break;
                case animationType.FadeIn:
                    fadeIn = new FadeIn(Control, Duration, fadeAll);
                    fadeIn.Play();
                    break;
                case animationType.FadeInAndShow:
                    fadeInAndShow = new FadeInAndShow(Control, Duration, fadeAll);
                    fadeInAndShow.Play();
                    break;
                case animationType.FadeOut:
                    fadeOut = new FadeOut(Control, Duration, fadeAll);
                    fadeOut.Play();
                    break;
                case animationType.FadeOutandHide:
                    fadeOutandHide = new FadeOutAndHide(Control, Duration, fadeAll);
                    fadeOutandHide.Play();
                    break;
                case animationType.Resize:
                    resize = new Resize(Control, start, end, Duration, func);
                    resize.Play();
                    break;
                case animationType.ResizeHeight:
                    resizeHeight = new ResizeHeight(Control, ResizeHeight_Begin, ResizeHeight_Limit, Duration, func);
                    resizeHeight.Play();
                    break;
                case animationType.ResizeWidth:
                    resizeWidth = new ResizeWidth(Control, ResizeWidth_Begin, ResizeWidth_Limit, Duration, func);
                    resizeWidth.Play();
                    break;
                case animationType.Slide:
                    slide = new Slide(Control, start, end, Duration, func);
                    slide.Play();
                    break;
                case animationType.SlideFrom:
                    slideFrom = new SlideFrom(Control, end, Duration, func);
                    slideFrom.Play();
                    break;
                default:
                    break;
            }



        }

        public void Stop()
        {
            switch (AnimationType)
            {
                case animationType.None:
                    break;
                case animationType.Fade:
                    fade.Stop(false);
                    break;
                case animationType.FadeIn:
                    fadeIn.Stop(false);
                    break;
                case animationType.FadeInAndShow:
                    fadeInAndShow.Stop(false);
                    break;
                case animationType.FadeOut:
                    fadeOut.Stop(false);
                    break;
                case animationType.FadeOutandHide:
                    fadeOutandHide.Stop(false);
                    break;
                case animationType.Resize:
                    resize.Stop(false);
                    break;
                case animationType.ResizeHeight:
                    resizeHeight.Stop(false);
                    break;
                case animationType.ResizeWidth:
                    resizeWidth.Stop(false);
                    break;
                case animationType.Slide:
                    slide.Stop(false);
                    break;
                case animationType.SlideFrom:
                    slideFrom.Stop(false);
                    break;
                default:
                    break;
            }
        }

        public void Pause()
        {
            switch (AnimationType)
            {
                case animationType.None:
                    break;
                case animationType.Fade:
                    fade.Pause();
                    break;
                case animationType.FadeIn:
                    fadeIn.Pause();
                    break;
                case animationType.FadeInAndShow:
                    fadeInAndShow.Pause();
                    break;
                case animationType.FadeOut:
                    fadeOut.Pause();
                    break;
                case animationType.FadeOutandHide:
                    fadeOutandHide.Pause();
                    break;
                case animationType.Resize:
                    resize.Pause();
                    break;
                case animationType.ResizeHeight:
                    resizeHeight.Pause();
                    break;
                case animationType.ResizeWidth:
                    resizeWidth.Pause();
                    break;
                case animationType.Slide:
                    slide.Pause();
                    break;
                case animationType.SlideFrom:
                    slideFrom.Pause();
                    break;
                default:
                    break;
            }
        }

        public void Resume()
        {
            switch (AnimationType)
            {
                case animationType.None:
                    break;
                case animationType.Fade:
                    fade.Resumes(true);
                    break;
                case animationType.FadeIn:
                    fadeIn.Resumes(true);
                    break;
                case animationType.FadeInAndShow:
                    fadeInAndShow.Resumes(true);
                    break;
                case animationType.FadeOut:
                    fadeOut.Resumes(true);
                    break;
                case animationType.FadeOutandHide:
                    fadeOutandHide.Resumes(true);
                    break;
                case animationType.Resize:
                    resize.Resumes(true);
                    break;
                case animationType.ResizeHeight:
                    resizeHeight.Resumes(true);
                    break;
                case animationType.ResizeWidth:
                    resizeWidth.Resumes(true);
                    break;
                case animationType.Slide:
                    slide.Resumes(true);
                    break;
                case animationType.SlideFrom:
                    slideFrom.Resumes(true);
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
