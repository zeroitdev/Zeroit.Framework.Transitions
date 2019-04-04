﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="PizaroTransitionWithEditor.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
        public ZeroitPizaroAnimatorInput ZeroitPizaroAnimatorInput
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
        public double EasingStart
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
        public double EasingEnd
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
        public double Fade_Begin
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
        public double Fade_Limit
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
        public double ResizeHeight_Begin
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
        public double ResizeHeight_Limit
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
        public double ResizeWidth_Begin
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
        public double ResizeWidth_Limit
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
        public double CordinateStart_X
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
        public double CordinateStart_Y
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
        public double CordinateEnd_X
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
        public double CordinateEnd_Y
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
        public double Acceleration
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


        /// <summary>
        /// Starts the animation.
        /// </summary>
        public void Activate()
        {

            //double[] start = new double[] { pizaroAnimatorInput.CordinateStart_X, pizaroAnimatorInput.CordinateStart_Y };

            //double[] end = new double[] { pizaroAnimatorInput.CordinateEnd_X, pizaroAnimatorInput.CordinateEnd_Y };

            
            switch (EasingNames)
            {
                case easingNames.Linear:
                    double accel = Easing.Linear(DateTime.Now.Millisecond);
                    func(accel * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseIn:
                    double accel1 = Easing.EaseIn(DateTime.Now.Millisecond);
                    func(accel1 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseOut:
                    double accel2 = Easing.EaseOut(DateTime.Now.Millisecond);
                    func(accel2 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseInAndOut:
                    double accel3 = Easing.EaseInAndOut(DateTime.Now.Millisecond);
                    func(accel3 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.LinearTween:
                    double accel4 = Easing.LinearTween(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel4 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseInQuad:
                    double accel5 = Easing.EaseInQuad(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel5 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseOutQuad:
                    double accel6 = Easing.EaseOutQuad(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel6 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseInOutQuad:
                    double accel7 = Easing.EaseInOutQuad(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel7 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseInCubic:
                    double accel8 = Easing.EaseInCubic(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel8 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseOutCubic:
                    double accel9 = Easing.EaseOutCubic(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel9 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseInOutCubic:
                    double accel10 = Easing.EaseInOutCubic(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel10 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseInQuart:
                    double accel11 = Easing.EaseInQuart(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel11 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseOutQuart:
                    double accel12 = Easing.EaseOutQuart(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel12 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseInOutQuart:
                    double accel13 = Easing.EaseInOutQuart(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel13 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseInQuint:
                    double accel14 = Easing.EaseInQuint(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel14 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseOutQuint:
                    double accel15 = Easing.EaseOutQuint(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel15 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseInOutQuint:
                    double accel16 = Easing.EaseInOutQuint(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel16 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseInSine:
                    double accel17 = Easing.EaseInSine(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel17 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseOutSine:
                    double accel18 = Easing.EaseOutSine(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel18 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseInOutSine:
                    double accel19 = Easing.EaseInOutSine(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel19 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseInExpo:
                    double accel20 = Easing.EaseInExpo(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel20 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseOutExpo:
                    double accel21 = Easing.EaseOutExpo(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel21 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseInOutExpo:
                    double accel22 = Easing.EaseInOutExpo(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel22 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseInCirc:
                    double accel23 = Easing.EaseInCirc(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel23 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseOutCirc:
                    double accel24 = Easing.EaseOutCirc(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel24 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.EaseInOutCirc:
                    double accel25 = Easing.EaseInOutCirc(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel25 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.ElasticEaseOut:
                    double accel26 = Easing.ElasticEaseOut(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel26 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.ElasticEaseIn:
                    double accel27 = Easing.ElasticEaseIn(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel27 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.ElasticEaseInOut:
                    double accel28 = Easing.ElasticEaseInOut(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel28 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.ElasticEaseOutIn:
                    double accel29 = Easing.ElasticEaseOutIn(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel29 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.BounceEaseOut:
                    double accel30 = Easing.BounceEaseOut(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel30 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.BounceEaseIn:
                    double accel31 = Easing.BounceEaseIn(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel31 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.BounceEaseInOut:
                    double accel32 = Easing.BounceEaseInOut(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel32 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.BounceEaseOutIn:
                    double accel33 = Easing.BounceEaseOutIn(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel33 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.BackEaseOut:
                    double accel34 = Easing.BackEaseOut(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel34 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.BackEaseIn:
                    double accel35 = Easing.BackEaseIn(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel35 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.BackEaseInOut:
                    double accel36 = Easing.BackEaseInOut(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel36 * pizaroAnimatorInput.Acceleration);
                    break;
                case easingNames.BackEaseOutIn:
                    double accel37 = Easing.BackEaseOutIn(DateTime.Now.Millisecond, pizaroAnimatorInput.EasingStart, pizaroAnimatorInput.EasingEnd, pizaroAnimatorInput.Duration);
                    func(accel37 * pizaroAnimatorInput.Acceleration);
                    break;
                default:
                    break;
            }

            
            //func(pizaroAnimatorInput.Acceleration);
            //func(accel);

            switch (AnimationType)
            {
                case animationType.Fade:
                    Fade fade = new Fade(Control, pizaroAnimatorInput.Fade_Begin, pizaroAnimatorInput.Fade_Limit, pizaroAnimatorInput.Duration, func);
                    fade.Play();
                    break;
                case animationType.FadeIn:
                    FadeIn fadeIn = new FadeIn(Control, pizaroAnimatorInput.Duration, func);
                    fadeIn.Play();
                    break;
                case animationType.FadeInAndShow:
                    FadeInAndShow fadeInAndShow = new FadeInAndShow(Control, pizaroAnimatorInput.Duration, func);
                    fadeInAndShow.Play();
                    break;
                case animationType.FadeOut:
                    FadeOut fadeOut = new FadeOut(Control, pizaroAnimatorInput.Duration, func);
                    fadeOut.Play();
                    break;
                case animationType.FadeOutandHide:
                    FadeOutAndHide fadeOutandHide = new FadeOutAndHide(Control, pizaroAnimatorInput.Duration, func);
                    fadeOutandHide.Play();
                    break;
                case animationType.Resize:
                    Resize resize = new Resize(Control, new double[] { pizaroAnimatorInput.CordinateStart_X, pizaroAnimatorInput.CordinateStart_Y }, new double[] { pizaroAnimatorInput.CordinateEnd_X, pizaroAnimatorInput.CordinateEnd_Y }, pizaroAnimatorInput.Duration, func);
                    resize.Play();
                    break;
                case animationType.ResizeHeight:
                    ResizeHeight resizeHeight = new ResizeHeight(Control, ResizeHeight_Begin, ResizeHeight_Limit, pizaroAnimatorInput.Duration, func);
                    resizeHeight.Play();
                    break;
                case animationType.ResizeWidth:
                    ResizeWidth resizeWidth = new ResizeWidth(Control, ResizeWidth_Begin, ResizeWidth_Limit, pizaroAnimatorInput.Duration, func);
                    resizeWidth.Play();
                    break;
                case animationType.Slide:
                    Slide slide = new Slide(Control, new double[] { pizaroAnimatorInput.CordinateStart_X, pizaroAnimatorInput.CordinateStart_Y }, new double[] { pizaroAnimatorInput.CordinateEnd_X, pizaroAnimatorInput.CordinateEnd_Y }, pizaroAnimatorInput.Duration, func);
                    slide.Play();
                    break;
                case animationType.SlideFrom:
                    SlideFrom slideFrom = new SlideFrom(Control, new double[] { pizaroAnimatorInput.CordinateEnd_X, pizaroAnimatorInput.CordinateEnd_Y }, pizaroAnimatorInput.Duration, func);
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