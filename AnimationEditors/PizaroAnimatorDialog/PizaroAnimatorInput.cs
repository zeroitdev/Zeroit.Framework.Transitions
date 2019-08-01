// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="PizaroAnimatorInput.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using static Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnimEdit;

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    /// Class ZeroitPizaroAnimatorInput.
    /// </summary>
    [TypeConverter(typeof(ZeroitPizaroAnimatorInput.Converter))]
    [EditorAttribute(typeof(PizaroInputEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public class ZeroitPizaroAnimatorInput
    {

        #region Imported Code
        
        #region Private Fields

        /// <summary>
        /// The always true
        /// </summary>
        bool alwaysTrue = true;
        /// <summary>
        /// The dummy
        /// </summary>
        string dummy = "";

        //private Control Control = new Control();
        /// <summary>
        /// The duration
        /// </summary>
        private int duration = 1000;
        /// <summary>
        /// The accelerate
        /// </summary>
        private float accelerate = 0.7f;
        /// <summary>
        /// The fadebegin
        /// </summary>
        private float fadebegin = 0;
        /// <summary>
        /// The fadelimit
        /// </summary>
        private float fadelimit = 1;

        /// <summary>
        /// The resizeheightbegin
        /// </summary>
        private float resizeheightbegin = 10;
        /// <summary>
        /// The resizeheightlimit
        /// </summary>
        private float resizeheightlimit = 50;

        /// <summary>
        /// The resizewidthbegin
        /// </summary>
        private float resizewidthbegin = 10;
        /// <summary>
        /// The resizewidthlimit
        /// </summary>
        private float resizewidthlimit = 50;

        /// <summary>
        /// The cordinate start x
        /// </summary>
        public float cordinateStart_X = 10;
        /// <summary>
        /// The cordinate start y
        /// </summary>
        public float cordinateStart_Y = 10;
        /// <summary>
        /// The cordinate end x
        /// </summary>
        public float cordinateEnd_X = 50;
        /// <summary>
        /// The cordinate end y
        /// </summary>
        public float cordinateEnd_Y = 50;

        /// <summary>
        /// The easingstart
        /// </summary>
        private float easingstart = 0.2f;
        /// <summary>
        /// The easingend
        /// </summary>
        private float easingend = 1;
        /// <summary>
        /// The accel
        /// </summary>
        private float accel;

        /// <summary>
        /// The animation type
        /// </summary>
        private animationType _animationType = animationType.Resize;
        /// <summary>
        /// The animation type resize
        /// </summary>
        private readonly animationType _animationTypeResize = animationType.Resize;
        /// <summary>
        /// The animation type resize height
        /// </summary>
        private readonly animationType _animationTypeResizeHeight = animationType.ResizeHeight;
        /// <summary>
        /// The animation type resize width
        /// </summary>
        private readonly animationType _animationTypeResizeWidth = animationType.ResizeWidth;
        /// <summary>
        /// The animation type slide
        /// </summary>
        private readonly animationType _animationTypeSlide = animationType.Slide;
        /// <summary>
        /// The animation type slide from
        /// </summary>
        private readonly animationType _animationTypeSlideFrom = animationType.SlideFrom;
        /// <summary>
        /// The animation type fade
        /// </summary>
        private readonly animationType _animationTypeFade = animationType.Fade;
        /// <summary>
        /// The animation type fade in
        /// </summary>
        private readonly animationType _animationTypeFadeIn = animationType.FadeIn;
        /// <summary>
        /// The animation type fade in and show
        /// </summary>
        private readonly animationType _animationTypeFadeInAndShow = animationType.FadeInAndShow;
        /// <summary>
        /// The animation type fade out
        /// </summary>
        private readonly animationType _animationTypeFadeOut = animationType.FadeOut;
        /// <summary>
        /// The animation type fade outand hide
        /// </summary>
        private readonly animationType _animationTypeFadeOutandHide = animationType.FadeOutandHide;
        /// <summary>
        /// The animation type none
        /// </summary>
        private readonly animationType _animationTypeNone = animationType.None;


        #endregion

        #region Easing Property


        /// <summary>
        /// The easing names
        /// </summary>
        private easingNames _easingNames = easingNames.BackEaseIn;


        /// <summary>
        /// Gets or sets the easing names.
        /// </summary>
        /// <value>The easing names.</value>
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
        /// This sets the fade animation start of the Control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The easing start.</value>

        public float EasingStart
        {
            get { return easingstart; }
            set
            {
                easingstart = value;
                control.Invalidate();

            }
        }

        /// <summary>
        /// This sets the fade animation start of the Control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The easing end.</value>

        public float EasingEnd
        {
            get { return easingend; }
            set
            {
                easingend = value;
                control.Invalidate();

            }
        }

        /// <summary>
        /// This sets the fade animation start of the Control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The fade begin.</value>

        public float Fade_Begin
        {
            get { return fadebegin; }
            set
            {
                if (value > 1)
                {
                    value = 1;
                }
                fadebegin = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// This sets the fade animation limit of the Control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The fade limit.</value>

        public float Fade_Limit
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
        /// This sets the fade animation limit of the Control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The resize height begin.</value>

        public float ResizeHeight_Begin
        {
            get { return resizeheightbegin; }
            set
            {

                resizeheightbegin = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// This sets the fade animation limit of the Control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The resize height limit.</value>

        public float ResizeHeight_Limit
        {
            get { return resizeheightlimit; }
            set
            {

                resizeheightlimit = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// This sets the fade animation limit of the Control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The resize width begin.</value>

        public float ResizeWidth_Begin
        {
            get { return resizewidthbegin; }
            set
            {

                resizewidthbegin = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// This sets the fade animation limit of the Control. Value should be between 0 and 1.
        /// </summary>
        /// <value>The resize width limit.</value>

        public float ResizeWidth_Limit
        {
            get { return resizewidthlimit; }
            set
            {

                resizewidthlimit = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the cordinate start x.
        /// </summary>
        /// <value>The cordinate start x.</value>
        public float CordinateStart_X
        {
            get { return cordinateStart_X; }
            set
            {
                cordinateStart_X = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the cordinate start y.
        /// </summary>
        /// <value>The cordinate start y.</value>
        public float CordinateStart_Y
        {
            get { return cordinateStart_Y; }
            set
            {
                cordinateStart_Y = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the cordinate end x.
        /// </summary>
        /// <value>The cordinate end x.</value>
        public float CordinateEnd_X
        {
            get { return cordinateEnd_X; }
            set
            {
                cordinateEnd_X = value;
                control.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the cordinate end y.
        /// </summary>
        /// <value>The cordinate end y.</value>
        public float CordinateEnd_Y
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
        /// Sets the animation type of animation.
        /// SlideFrom - requires
        /// </summary>
        /// <value>The animation type resize.</value>
        public animationType AnimationTypeResize
        {
            get { return _animationTypeResize; }
            
        }

        /// <summary>
        /// Sets the animation type of animation.
        /// SlideFrom - requires
        /// </summary>
        /// <value>The height of the animation type resize.</value>
        public animationType AnimationTypeResizeHeight
        {
            get { return _animationTypeResizeHeight; }

        }

        /// <summary>
        /// Sets the animation type of animation.
        /// SlideFrom - requires
        /// </summary>
        /// <value>The width of the animation type resize.</value>
        public animationType AnimationTypeResizeWidth
        {
            get { return _animationTypeResizeWidth; }

        }

        /// <summary>
        /// Sets the animation type of animation.
        /// SlideFrom - requires
        /// </summary>
        /// <value>The animation type fade.</value>
        public animationType AnimationTypeFade
        {
            get { return _animationTypeFade; }

        }

        /// <summary>
        /// Sets the animation type of animation.
        /// SlideFrom - requires
        /// </summary>
        /// <value>The animation type fade in.</value>
        public animationType AnimationTypeFadeIn
        {
            get { return _animationTypeFadeIn; }

        }

        /// <summary>
        /// Sets the animation type of animation.
        /// SlideFrom - requires
        /// </summary>
        /// <value>The animation type fade in and show.</value>
        public animationType AnimationTypeFadeInAndShow
        {
            get { return _animationTypeFadeInAndShow; }

        }

        /// <summary>
        /// Sets the animation type of animation.
        /// SlideFrom - requires
        /// </summary>
        /// <value>The animation type fade out.</value>
        public animationType AnimationTypeFadeOut
        {
            get { return _animationTypeFadeOut; }

        }

        /// <summary>
        /// Sets the animation type of animation.
        /// SlideFrom - requires
        /// </summary>
        /// <value>The animation type fade out and hide.</value>
        public animationType AnimationTypeFadeOutAndHide
        {
            get { return _animationTypeFadeOutandHide; }

        }

        /// <summary>
        /// Sets the animation type of animation.
        /// SlideFrom - requires
        /// </summary>
        /// <value>The animation type slide.</value>
        public animationType AnimationTypeSlide
        {
            get { return _animationTypeSlide; }

        }

        /// <summary>
        /// Sets the animation type of animation.
        /// SlideFrom - requires
        /// </summary>
        /// <value>The animation type slide from.</value>
        public animationType AnimationTypeSlideFrom
        {
            get { return _animationTypeSlideFrom; }

        }



        /// <summary>
        /// Gets or sets the acceleration.
        /// </summary>
        /// <value>The acceleration.</value>
        public float Acceleration
        {
            get { return accelerate; }
            set
            {
                if (value > 1)
                {
                    value = 1;
                }
                accelerate = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Duration should be in milliseconds (eg. 1000 for 1s)
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
        /// The control
        /// </summary>
        public Control control = new Control();
        /// <summary>
        /// Selects the Control to be used
        /// </summary>
        /// <value>The control.</value>
        public Control Control
        {
            get { return control; }
            set
            {

                control = value;
                //control.Invalidate();
                //Control.Invalidate();
            }

            //get;
            //set;
        }


        #endregion
        
        #endregion

        #region Constructor

        //Internal Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitPizaroAnimatorInput"/> class.
        /// </summary>
        /// <param name="_animationType">Type of the animation.</param>
        /// <param name="duration_para">The duration para.</param>
        /// <param name="accelerate_para">The accelerate para.</param>
        /// <param name="fadebegin_para">The fadebegin para.</param>
        /// <param name="fadelimit_para">The fadelimit para.</param>
        /// <param name="resizeheightbegin_para">The resizeheightbegin para.</param>
        /// <param name="resizeheightlimit_para">The resizeheightlimit para.</param>
        /// <param name="resizewidthbegin_para">The resizewidthbegin para.</param>
        /// <param name="resizewidthlimit_para">The resizewidthlimit para.</param>
        /// <param name="cordinateStart_X_para">The cordinate start x para.</param>
        /// <param name="cordinateStart_Y_para">The cordinate start y para.</param>
        /// <param name="cordinateEnd_X_para">The cordinate end x para.</param>
        /// <param name="cordinateEnd_Y_para">The cordinate end y para.</param>
        /// <param name="easingstart_para">The easingstart para.</param>
        /// <param name="easingend_para">The easingend para.</param>
        public ZeroitPizaroAnimatorInput(
                
                animationType _animationType,
                int duration_para,
                float accelerate_para,
                float fadebegin_para,
                float fadelimit_para,
                float resizeheightbegin_para,
                float resizeheightlimit_para,
                float resizewidthbegin_para,
                float resizewidthlimit_para,
                float cordinateStart_X_para,
                float cordinateStart_Y_para,
                float cordinateEnd_X_para,
                float cordinateEnd_Y_para,
                float easingstart_para,
                float easingend_para
                

            )
        {
            this._animationType = _animationType;
            duration = duration_para;
            accelerate = accelerate_para;
            fadebegin = fadebegin_para;
            fadelimit = fadelimit_para;
            resizeheightbegin = resizeheightbegin_para;
            resizeheightlimit = resizeheightlimit_para;
            resizewidthbegin = resizewidthbegin_para;
            resizewidthlimit = resizewidthlimit_para;
            cordinateStart_X = cordinateStart_X_para;
            cordinateStart_Y = cordinateStart_Y_para;
            cordinateEnd_X = cordinateEnd_X_para;
            cordinateEnd_Y = cordinateEnd_Y_para;
            easingstart = easingstart_para;
            easingend = easingend_para;
            
        }

        #region Old Code
        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitPizaroAnimatorInput"/> class.
        /// </summary>
        public ZeroitPizaroAnimatorInput() : this

            (
                animationType.None,
                1000,
                0.7f,
                0,
                1,
                10,
                50,
                10,
                50,
                10,
                10,
                50,
                50,
                0.2f,
                1
            )
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitPizaroAnimatorInput"/> class.
        /// </summary>
        /// <param name="None">The none.</param>
        /// <param name="control">The control.</param>
        public ZeroitPizaroAnimatorInput(animationType None, Control control) : this

            (
            animationType.None,
            1000,
            0.7f,
            0,
            1,
            10,
            50,
            10,
            50,
            10,
            10,
            50,
            50,
            0.2f,
            1
            )
        {
            this._animationType = None;
            this.control = control;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitPizaroAnimatorInput"/> class.
        /// </summary>
        /// <param name="resize">The resize.</param>
        /// <param name="cordinateStart_X">The cordinate start x.</param>
        /// <param name="cordinateStart_Y">The cordinate start y.</param>
        /// <param name="cordinateEnd_X">The cordinate end x.</param>
        /// <param name="cordinateEnd_Y">The cordinate end y.</param>
        /// <param name="control">The control.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="accelerate">The accelerate.</param>
        /// <param name="easingstart">The easingstart.</param>
        /// <param name="easingend">The easingend.</param>
        public ZeroitPizaroAnimatorInput(animationType resize, float cordinateStart_X, float cordinateStart_Y, float cordinateEnd_X, float cordinateEnd_Y, Control control, int duration,
            float accelerate, float easingstart, float easingend) : this

            (
            animationType.Resize,
            1000,
            0.7f,
            0,
            1,
            10,
            50,
            10,
            50,
            10,
            10,
            50,
            50,
            0.2f,
            1
            )
        {
            this._animationType = resize;
            this.cordinateStart_X = cordinateStart_X;
            this.cordinateStart_Y = cordinateStart_Y;
            this.cordinateEnd_X = cordinateEnd_X;
            this.cordinateEnd_Y = cordinateEnd_Y;
            this.control = control;
            this.duration = duration;
            this.accelerate = accelerate;
            this.easingstart = easingstart;
            this.easingend = easingend;

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitPizaroAnimatorInput"/> class.
        /// </summary>
        /// <param name="resizeHeight">Height of the resize.</param>
        /// <param name="alwaysTrue">if set to <c>true</c> [always true].</param>
        /// <param name="begin">The begin.</param>
        /// <param name="limit">The limit.</param>
        /// <param name="control">The control.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="accelerate">The accelerate.</param>
        /// <param name="easingstart">The easingstart.</param>
        /// <param name="easingend">The easingend.</param>
        public ZeroitPizaroAnimatorInput(animationType resizeHeight, bool alwaysTrue, float begin, float limit, Control control, int duration,
            float accelerate, float easingstart, float easingend) : this

            (
            animationType.ResizeHeight,
            1000,
            0.7f,
            0,
            1,
            10,
            50,
            10,
            50,
            10,
            10,
            50,
            50,
            0.2f,
            1

            )
        {
            this._animationTypeResize = resizeHeight;
            this.resizeheightbegin = begin;
            this.resizeheightlimit = limit;
            this.control = control;
            this.duration = duration;
            this.accelerate = accelerate;
            this.easingstart = easingstart;
            this.easingend = easingend;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitPizaroAnimatorInput"/> class.
        /// </summary>
        /// <param name="resizeWidth">Width of the resize.</param>
        /// <param name="alwaysTrue">The always true.</param>
        /// <param name="begin">The begin.</param>
        /// <param name="limit">The limit.</param>
        /// <param name="control">The control.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="accelerate">The accelerate.</param>
        /// <param name="easingstart">The easingstart.</param>
        /// <param name="easingend">The easingend.</param>
        public ZeroitPizaroAnimatorInput(animationType resizeWidth, string alwaysTrue, float begin, float limit, Control control, int duration,
            float accelerate, float easingstart, float easingend) : this

            (
            animationType.ResizeWidth,
            1000,
            0.7f,
            0,
            1,
            10,
            50,
            10,
            50,
            10,
            10,
            50,
            50,
            0.2f,
            1

            )
        {
            this._animationTypeResize = resizeWidth;
            this.resizeheightbegin = begin;
            this.resizeheightlimit = limit;
            this.control = control;
            this.duration = duration;
            this.accelerate = accelerate;
            this.easingstart = easingstart;
            this.easingend = easingend;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitPizaroAnimatorInput"/> class.
        /// </summary>
        /// <param name="fade">The fade.</param>
        /// <param name="fadebegin">The fadebegin.</param>
        /// <param name="fadelimit">The fadelimit.</param>
        /// <param name="control">The control.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="accelerate">The accelerate.</param>
        /// <param name="easingstart">The easingstart.</param>
        /// <param name="easingend">The easingend.</param>
        public ZeroitPizaroAnimatorInput(animationType fade, float fadebegin, float fadelimit, Control control, int duration,
            float accelerate, float easingstart, float easingend) : this

            (
            animationType.Fade,
            1000,
            0.7f,
            0,
            1,
            10,
            50,
            10,
            50,
            10,
            10,
            50,
            50,
            0.2f,
            1

            )
        {
            this._animationType = fade;
            this.fadebegin = fadebegin;
            this.fadelimit = fadelimit;
            this.control = control;
            this.duration = duration;
            this.accelerate = accelerate;
            this.easingstart = easingstart;
            this.easingend = easingend;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitPizaroAnimatorInput"/> class.
        /// </summary>
        /// <param name="fadeIn">The fade in.</param>
        /// <param name="fadebegin">The fadebegin.</param>
        /// <param name="fadelimit">The fadelimit.</param>
        /// <param name="setTrue1">if set to <c>true</c> [set true1].</param>
        /// <param name="control">The control.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="accelerate">The accelerate.</param>
        /// <param name="easingstart">The easingstart.</param>
        /// <param name="easingend">The easingend.</param>
        public ZeroitPizaroAnimatorInput(animationType fadeIn, float fadebegin, float fadelimit, bool setTrue1, Control control, int duration,
            float accelerate, float easingstart, float easingend) : this

            (
            animationType.FadeIn,
            1000,
            0.7f,
            0,
            1,
            10,
            50,
            10,
            50,
            10,
            10,
            50,
            50,
            0.2f,
            1

            )
        {
            this._animationType = fadeIn;
            this.fadebegin = fadebegin;
            this.fadelimit = fadelimit;
            this.control = control;
            this.duration = duration;
            this.accelerate = accelerate;
            this.easingstart = easingstart;
            this.easingend = easingend;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitPizaroAnimatorInput"/> class.
        /// </summary>
        /// <param name="fadeInAndShow">The fade in and show.</param>
        /// <param name="fadebegin">The fadebegin.</param>
        /// <param name="fadelimit">The fadelimit.</param>
        /// <param name="setTrue1">if set to <c>true</c> [set true1].</param>
        /// <param name="setTrue2">if set to <c>true</c> [set true2].</param>
        /// <param name="control">The control.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="accelerate">The accelerate.</param>
        /// <param name="easingstart">The easingstart.</param>
        /// <param name="easingend">The easingend.</param>
        public ZeroitPizaroAnimatorInput(animationType fadeInAndShow, float fadebegin, float fadelimit, bool setTrue1, bool setTrue2, Control control, int duration,
            float accelerate, float easingstart, float easingend) : this

            (
            animationType.FadeInAndShow,
            1000,
            0.7f,
            0,
            1,
            10,
            50,
            10,
            50,
            10,
            10,
            50,
            50,
            0.2f,
            1

            )
        {
            this._animationType = fadeInAndShow;
            this.fadebegin = fadebegin;
            this.fadelimit = fadelimit;
            this.control = control;
            this.duration = duration;
            this.accelerate = accelerate;
            this.easingstart = easingstart;
            this.easingend = easingend;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitPizaroAnimatorInput"/> class.
        /// </summary>
        /// <param name="fadeOut">The fade out.</param>
        /// <param name="fadebegin">The fadebegin.</param>
        /// <param name="fadelimit">The fadelimit.</param>
        /// <param name="dummy1">The dummy1.</param>
        /// <param name="control">The control.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="accelerate">The accelerate.</param>
        /// <param name="easingstart">The easingstart.</param>
        /// <param name="easingend">The easingend.</param>
        public ZeroitPizaroAnimatorInput(animationType fadeOut, float fadebegin, float fadelimit, string dummy1, Control control, int duration,
            float accelerate, float easingstart, float easingend) : this

            (
            animationType.FadeOut,
            1000,
            0.7f,
            0,
            1,
            10,
            50,
            10,
            50,
            10,
            10,
            50,
            50,
            0.2f,
            1

            )
        {
            this._animationType = fadeOut;
            this.fadebegin = fadebegin;
            this.fadelimit = fadelimit;
            this.control = control;
            this.duration = duration;
            this.accelerate = accelerate;
            this.easingstart = easingstart;
            this.easingend = easingend;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitPizaroAnimatorInput"/> class.
        /// </summary>
        /// <param name="fadeOutandHide">The fade outand hide.</param>
        /// <param name="fadebegin">The fadebegin.</param>
        /// <param name="fadelimit">The fadelimit.</param>
        /// <param name="dummy1">The dummy1.</param>
        /// <param name="dummy2">The dummy2.</param>
        /// <param name="control">The control.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="accelerate">The accelerate.</param>
        /// <param name="easingstart">The easingstart.</param>
        /// <param name="easingend">The easingend.</param>
        public ZeroitPizaroAnimatorInput(animationType fadeOutandHide, float fadebegin, float fadelimit, string dummy1, string dummy2, Control control, int duration,
            float accelerate, float easingstart, float easingend) : this

            (
            animationType.FadeOutandHide,
            1000,
            0.7f,
            0,
            1,
            10,
            50,
            10,
            50,
            10,
            10,
            50,
            50,
            0.2f,
            1

            )
        {
            this._animationType = fadeOutandHide;
            this.fadebegin = fadebegin;
            this.fadelimit = fadelimit;
            this.control = control;
            this.duration = duration;
            this.accelerate = accelerate;
            this.easingstart = easingstart;
            this.easingend = easingend;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitPizaroAnimatorInput"/> class.
        /// </summary>
        /// <param name="slide">The slide.</param>
        /// <param name="cordinateStart_X">The cordinate start x.</param>
        /// <param name="cordinateStart_Y">The cordinate start y.</param>
        /// <param name="cordinateEnd_X">The cordinate end x.</param>
        /// <param name="cordinateEnd_Y">The cordinate end y.</param>
        /// <param name="alwaysTrue">if set to <c>true</c> [always true].</param>
        /// <param name="control">The control.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="accelerate">The accelerate.</param>
        /// <param name="easingstart">The easingstart.</param>
        /// <param name="easingend">The easingend.</param>
        public ZeroitPizaroAnimatorInput(animationType slide, float cordinateStart_X, float cordinateStart_Y, float cordinateEnd_X, float cordinateEnd_Y, bool alwaysTrue, Control control, int duration,
            float accelerate, float easingstart, float easingend) : this

            (
            animationType.Slide,
            1000,
            0.7f,
            0,
            1,
            10,
            50,
            10,
            50,
            10,
            10,
            50,
            50,
            0.2f,
            1

            )
        {
            this._animationType = slide;
            this.cordinateStart_X = cordinateStart_X;
            this.cordinateStart_Y = cordinateStart_Y;
            this.cordinateEnd_X = cordinateEnd_X;
            this.cordinateEnd_Y = cordinateEnd_Y;
            this.control = control;
            this.duration = duration;
            this.accelerate = accelerate;
            this.easingstart = easingstart;
            this.easingend = easingend;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitPizaroAnimatorInput"/> class.
        /// </summary>
        /// <param name="slideFrom">The slide from.</param>
        /// <param name="cordinateStart_X">The cordinate start x.</param>
        /// <param name="cordinateStart_Y">The cordinate start y.</param>
        /// <param name="cordinateEnd_X">The cordinate end x.</param>
        /// <param name="cordinateEnd_Y">The cordinate end y.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="control">The control.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="accelerate">The accelerate.</param>
        /// <param name="easingstart">The easingstart.</param>
        /// <param name="easingend">The easingend.</param>
        public ZeroitPizaroAnimatorInput(animationType slideFrom, float cordinateStart_X, float cordinateStart_Y, float cordinateEnd_X, float cordinateEnd_Y, string dummy, Control control, int duration,
            float accelerate, float easingstart, float easingend) : this

            (
            animationType.SlideFrom,
            1000,
            0.7f,
            0,
            1,
            10,
            50,
            10,
            50,
            10,
            10,
            50,
            50,
            0.2f,
            1

            )
        {
            this._animationType = slideFrom;
            this.cordinateStart_X = cordinateStart_X;
            this.cordinateStart_Y = cordinateStart_Y;
            this.cordinateEnd_X = cordinateEnd_X;
            this.cordinateEnd_Y = cordinateEnd_Y;
            this.control = control;
            this.duration = duration;
            this.accelerate = accelerate;
            this.easingstart = easingstart;
            this.easingend = easingend;
        }
        #endregion

        #region Static Code
        //public ZeroitPizaroAnimatorInput() : this

        //(
        //animationType.Resize,
        //duration,
        //accelerate,
        //fadebegin,
        //fadelimit,
        //resizeheightbegin,
        //resizeheightlimit,
        //resizewidthbegin,
        //resizewidthlimit,
        //cordinateStart_X,
        //cordinateStart_Y,
        //cordinateEnd_X,
        //cordinateEnd_Y,
        //easingstart,
        //easingend

        //)
        //{

        //}

        //public ZeroitPizaroAnimatorInput(animationType resize, float cordinateStart_X, float cordinateStart_Y, float cordinateEnd_X, float cordinateEnd_Y) : this

        //    (
        //    animationType.Resize,
        //    duration,
        //    accelerate,
        //    fadebegin,
        //    fadelimit,
        //    resizeheightbegin,
        //    resizeheightlimit,
        //    resizewidthbegin,
        //    resizewidthlimit,
        //    cordinateStart_X,
        //    cordinateStart_Y,
        //    cordinateEnd_X,
        //    cordinateEnd_Y,
        //    easingstart,
        //    easingend
        //    )
        //{

        //}

        //public ZeroitPizaroAnimatorInput(animationType resizeHeight, bool alwaysTrue, float begin, float limit) : this

        //    (
        //    animationType.ResizeHeight,
        //    duration,
        //    accelerate,
        //    fadebegin,
        //    fadelimit,
        //    resizeheightbegin,
        //    resizeheightlimit,
        //    resizewidthbegin,
        //    resizewidthlimit,
        //    cordinateStart_X,
        //    cordinateStart_Y,
        //    cordinateEnd_X,
        //    cordinateEnd_Y,
        //    easingstart,
        //    easingend

        //    )
        //{

        //}

        //public ZeroitPizaroAnimatorInput(animationType resizeWidth, string alwaysTrue, float begin, float limit) : this

        //    (
        //    animationType.ResizeWidth,
        //    duration,
        //    accelerate,
        //    fadebegin,
        //    fadelimit,
        //    resizeheightbegin,
        //    resizeheightlimit,
        //    resizewidthbegin,
        //    resizewidthlimit,
        //    cordinateStart_X,
        //    cordinateStart_Y,
        //    cordinateEnd_X,
        //    cordinateEnd_Y,
        //    easingstart,
        //    easingend

        //    )
        //{

        //}

        //public ZeroitPizaroAnimatorInput(animationType fade, float fadebegin, float fadelimit) : this

        //    (
        //    animationType.Fade,
        //    duration,
        //    accelerate,
        //    fadebegin,
        //    fadelimit,
        //    resizeheightbegin,
        //    resizeheightlimit,
        //    resizewidthbegin,
        //    resizewidthlimit,
        //    cordinateStart_X,
        //    cordinateStart_Y,
        //    cordinateEnd_X,
        //    cordinateEnd_Y,
        //    easingstart,
        //    easingend

        //    )
        //{

        //}

        //public ZeroitPizaroAnimatorInput(animationType fadeIn, float fadebegin, float fadelimit, bool setTrue1) : this

        //    (
        //    animationType.FadeIn,
        //    duration,
        //    accelerate,
        //    fadebegin,
        //    fadelimit,
        //    resizeheightbegin,
        //    resizeheightlimit,
        //    resizewidthbegin,
        //    resizewidthlimit,
        //    cordinateStart_X,
        //    cordinateStart_Y,
        //    cordinateEnd_X,
        //    cordinateEnd_Y,
        //    easingstart,
        //    easingend

        //    )
        //{

        //}

        //public ZeroitPizaroAnimatorInput(animationType fadeInAndShow, float fadebegin, float fadelimit, bool setTrue1, bool setTrue2) : this

        //    (
        //    animationType.FadeInAndShow,
        //    duration,
        //    accelerate,
        //    fadebegin,
        //    fadelimit,
        //    resizeheightbegin,
        //    resizeheightlimit,
        //    resizewidthbegin,
        //    resizewidthlimit,
        //    cordinateStart_X,
        //    cordinateStart_Y,
        //    cordinateEnd_X,
        //    cordinateEnd_Y,
        //    easingstart,
        //    easingend

        //    )
        //{

        //}

        //public ZeroitPizaroAnimatorInput(animationType fadeOut, float fadebegin, float fadelimit, string dummy1) : this

        //    (
        //    animationType.FadeOut,
        //    duration,
        //    accelerate,
        //    fadebegin,
        //    fadelimit,
        //    resizeheightbegin,
        //    resizeheightlimit,
        //    resizewidthbegin,
        //    resizewidthlimit,
        //    cordinateStart_X,
        //    cordinateStart_Y,
        //    cordinateEnd_X,
        //    cordinateEnd_Y,
        //    easingstart,
        //    easingend

        //    )
        //{

        //}

        //public ZeroitPizaroAnimatorInput(animationType fadeOutandHide, float fadebegin, float fadelimit, string dummy1, string dummy2) : this

        //    (
        //    animationType.FadeOutandHide,
        //    duration,
        //    accelerate,
        //    fadebegin,
        //    fadelimit,
        //    resizeheightbegin,
        //    resizeheightlimit,
        //    resizewidthbegin,
        //    resizewidthlimit,
        //    cordinateStart_X,
        //    cordinateStart_Y,
        //    cordinateEnd_X,
        //    cordinateEnd_Y,
        //    easingstart,
        //    easingend

        //    )
        //{

        //}

        //public ZeroitPizaroAnimatorInput(animationType slide, float cordinateStart_X, float cordinateStart_Y, float cordinateEnd_X, float cordinateEnd_Y, bool alwaysTrue) : this

        //    (
        //    animationType.Slide,
        //    duration,
        //    accelerate,
        //    fadebegin,
        //    fadelimit,
        //    resizeheightbegin,
        //    resizeheightlimit,
        //    resizewidthbegin,
        //    resizewidthlimit,
        //    cordinateStart_X,
        //    cordinateStart_Y,
        //    cordinateEnd_X,
        //    cordinateEnd_Y,
        //    easingstart,
        //    easingend

        //    )
        //{

        //}

        //public ZeroitPizaroAnimatorInput(animationType slideFrom, float cordinateStart_X, float cordinateStart_Y, float cordinateEnd_X, float cordinateEnd_Y, string dummy) : this

        //    (
        //    animationType.SlideFrom,
        //    duration,
        //    accelerate,
        //    fadebegin,
        //    fadelimit,
        //    resizeheightbegin,
        //    resizeheightlimit,
        //    resizewidthbegin,
        //    resizewidthlimit,
        //    cordinateStart_X,
        //    cordinateStart_Y,
        //    cordinateEnd_X,
        //    cordinateEnd_Y,
        //    easingstart,
        //    easingend

        //    )
        //{

        //} 
        #endregion



        #endregion

        #region Public Methods

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>ZeroitPizaroAnimatorInput.</returns>
        public ZeroitPizaroAnimatorInput Clone()
        {
            return new ZeroitPizaroAnimatorInput(
            _animationType,
                duration,
                accelerate,
                fadebegin,
                fadelimit,
                resizeheightbegin,
                resizeheightlimit,
                resizewidthbegin,
                resizewidthlimit,
                cordinateStart_X,
                cordinateStart_Y,
                cordinateEnd_X,
                cordinateEnd_Y,
                easingstart,
                easingend
                );
        }

        /// <summary>
        /// Empties this instance.
        /// </summary>
        /// <returns>ZeroitPizaroAnimatorInput.</returns>
        public static ZeroitPizaroAnimatorInput Empty()
        {
            return new ZeroitPizaroAnimatorInput();
        }


        #endregion

        #region Converter

        /// <summary>
        /// Class Converter.
        /// </summary>
        /// <seealso cref="System.ComponentModel.TypeConverter" />
        internal class Converter : TypeConverter
        {

            /// <summary>
            /// Returns whether this converter can convert the object to the specified type, using the specified context.
            /// </summary>
            /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
            /// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type you want to convert to.</param>
            /// <returns>true if this converter can perform the conversion; otherwise, false.</returns>
            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            {
                if (destinationType == typeof(InstanceDescriptor)/* || destinationType == typeof(string)*/)
                {
                    return true;
                }
                return base.CanConvertTo(context, destinationType);
            }

            // This code allows the designer to generate the Shape constructor

            /// <summary>
            /// Converts the given value object to the specified type, using the specified context and culture information.
            /// </summary>
            /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
            /// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" />. If null is passed, the current culture is assumed.</param>
            /// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
            /// <param name="destinationType">The <see cref="T:System.Type" /> to convert the <paramref name="value" /> parameter to.</param>
            /// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
            public override object ConvertTo(ITypeDescriptorContext context,
                CultureInfo culture,
                object value,
                Type destinationType)
            {
                
                    if (destinationType == typeof(string))
                    {
                        // Display string in designer
                        return "(Customize)";
                    }

                    
                    else if (destinationType == typeof(InstanceDescriptor) && value is ZeroitPizaroAnimatorInput)
                    {
                        ZeroitPizaroAnimatorInput pizaroAnimatorInput = (ZeroitPizaroAnimatorInput)value;

                        if (pizaroAnimatorInput.AnimationType == animationType.Resize)
                        {
                            ConstructorInfo ctor = typeof(ZeroitPizaroAnimatorInput).GetConstructor(new Type[]
                            {
                                

                                typeof(animationType),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(Control),
                                typeof(int),
                                typeof(float),
                                typeof(float),
                                typeof(float)


                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {
                                    
                                    pizaroAnimatorInput._animationTypeResize,
                                    pizaroAnimatorInput.cordinateStart_X,
                                    pizaroAnimatorInput.cordinateStart_Y,
                                    pizaroAnimatorInput.cordinateEnd_X,
                                    pizaroAnimatorInput.cordinateEnd_Y,
                                    pizaroAnimatorInput.control,

                                    pizaroAnimatorInput.duration,
                                    pizaroAnimatorInput.accelerate,
                                    pizaroAnimatorInput.easingstart,
                                    pizaroAnimatorInput.easingend


                                });
                            }
                        }

                        else if (pizaroAnimatorInput.AnimationType == animationType.None)
                        {
                            ConstructorInfo ctor = typeof(ZeroitPizaroAnimatorInput).GetConstructor(new Type[] {
                                typeof(animationType),
                                typeof(Control),
                                typeof(int),
                                typeof(float),
                                typeof(float),
                                typeof(float)
                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {
                                    pizaroAnimatorInput._animationTypeNone,
                                    pizaroAnimatorInput.control,

                                    pizaroAnimatorInput.duration,
                                    pizaroAnimatorInput.accelerate,
                                    pizaroAnimatorInput.easingstart,
                                    pizaroAnimatorInput.easingend
                                });
                            }
                        }
                        else if (pizaroAnimatorInput.AnimationType == animationType.ResizeWidth)
                        {
                            ConstructorInfo ctor = typeof(ZeroitPizaroAnimatorInput).GetConstructor(new Type[] {

                                
                                typeof(animationType),
                                typeof(string),
                                typeof(float),
                                typeof(float),
                                typeof(Control),
                                typeof(int),
                                typeof(float),
                                typeof(float),
                                typeof(float)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {
                                    
                                    pizaroAnimatorInput._animationTypeResizeWidth,
                                    pizaroAnimatorInput.dummy,
                                    pizaroAnimatorInput.resizewidthbegin,
                                    pizaroAnimatorInput.resizewidthlimit,
                                    pizaroAnimatorInput.control,

                                    pizaroAnimatorInput.duration,
                                    pizaroAnimatorInput.accelerate,
                                    pizaroAnimatorInput.easingstart,
                                    pizaroAnimatorInput.easingend
                                });
                            }
                        }

                        else if (pizaroAnimatorInput.AnimationType == animationType.ResizeHeight)
                        {
                            ConstructorInfo ctor = typeof(ZeroitPizaroAnimatorInput).GetConstructor(new Type[] {


                                typeof(animationType),
                                typeof(bool),
                                typeof(float),
                                typeof(float),
                                typeof(Control),
                                typeof(int),
                                typeof(float),
                                typeof(float),
                                typeof(float)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    pizaroAnimatorInput._animationTypeResizeHeight,
                                    pizaroAnimatorInput.alwaysTrue,
                                    pizaroAnimatorInput.resizeheightbegin,
                                    pizaroAnimatorInput.resizeheightlimit,
                                    pizaroAnimatorInput.control,

                                    pizaroAnimatorInput.duration,
                                    pizaroAnimatorInput.accelerate,
                                    pizaroAnimatorInput.easingstart,
                                    pizaroAnimatorInput.easingend
                                });
                            }
                        }
                        

                        else if (pizaroAnimatorInput.AnimationType == animationType.Fade)
                        {
                            ConstructorInfo ctor = typeof(ZeroitPizaroAnimatorInput).GetConstructor(new Type[] {

                                
                                typeof(animationType),
                                typeof(float),
                                typeof(float),
                                typeof(Control),
                                typeof(int),
                                typeof(float),
                                typeof(float),
                                typeof(float)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    
                                    pizaroAnimatorInput._animationTypeFade,
                                    pizaroAnimatorInput.fadebegin,
                                    pizaroAnimatorInput.fadelimit,
                                    pizaroAnimatorInput.control,

                                    pizaroAnimatorInput.duration,
                                    pizaroAnimatorInput.accelerate,
                                    pizaroAnimatorInput.easingstart,
                                    pizaroAnimatorInput.easingend

                                });
                            }
                        }

                        else if (pizaroAnimatorInput.AnimationType == animationType.FadeIn)
                        {
                            ConstructorInfo ctor = typeof(ZeroitPizaroAnimatorInput).GetConstructor(new Type[] {

                                typeof(animationType),
                                typeof(float),
                                typeof(float),
                                typeof(bool),
                                typeof(Control),
                                typeof(int),
                                typeof(float),
                                typeof(float),
                                typeof(float)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {
                                    
                                    pizaroAnimatorInput._animationTypeFadeIn,
                                    pizaroAnimatorInput.fadebegin,
                                    pizaroAnimatorInput.fadelimit,
                                    pizaroAnimatorInput.alwaysTrue,
                                    pizaroAnimatorInput.control,

                                    pizaroAnimatorInput.duration,
                                    pizaroAnimatorInput.accelerate,
                                    pizaroAnimatorInput.easingstart,
                                    pizaroAnimatorInput.easingend

                                });
                            }
                        }

                        else if (pizaroAnimatorInput.AnimationType == animationType.FadeInAndShow)
                        {
                            ConstructorInfo ctor = typeof(ZeroitPizaroAnimatorInput).GetConstructor(new Type[] {

                                typeof(animationType),
                                typeof(float),
                                typeof(float),
                                typeof(bool),
                                typeof(bool),
                                typeof(Control),
                                typeof(int),
                                typeof(float),
                                typeof(float),
                                typeof(float)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {
                                    
                                    pizaroAnimatorInput._animationTypeFadeInAndShow,
                                    pizaroAnimatorInput.fadebegin,
                                    pizaroAnimatorInput.fadelimit,
                                    pizaroAnimatorInput.alwaysTrue,
                                    pizaroAnimatorInput.alwaysTrue,
                                    pizaroAnimatorInput.control,

                                    pizaroAnimatorInput.duration,
                                    pizaroAnimatorInput.accelerate,
                                    pizaroAnimatorInput.easingstart,
                                    pizaroAnimatorInput.easingend

                                });
                            }
                        }

                        else if (pizaroAnimatorInput.AnimationType == animationType.FadeOut)
                        {
                            ConstructorInfo ctor = typeof(ZeroitPizaroAnimatorInput).GetConstructor(new Type[] {

                                
                                typeof(animationType),
                                typeof(float),
                                typeof(float),
                                typeof(string),
                                typeof(Control),
                                typeof(int),
                                typeof(float),
                                typeof(float),
                                typeof(float)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    
                                    pizaroAnimatorInput._animationTypeFadeOut,
                                    pizaroAnimatorInput.fadebegin,
                                    pizaroAnimatorInput.fadelimit,
                                    pizaroAnimatorInput.dummy,
                                    pizaroAnimatorInput.control,

                                    pizaroAnimatorInput.duration,
                                    pizaroAnimatorInput.accelerate,
                                    pizaroAnimatorInput.easingstart,
                                    pizaroAnimatorInput.easingend

                                });
                            }
                        }

                        else if (pizaroAnimatorInput.AnimationType == animationType.FadeOutandHide)
                        {
                            ConstructorInfo ctor = typeof(ZeroitPizaroAnimatorInput).GetConstructor(new Type[] {

                                
                                typeof(animationType),                                
                                typeof(float),
                                typeof(float),
                                typeof(string),
                                typeof(string),
                                typeof(Control),
                                typeof(int),
                                typeof(float),
                                typeof(float),
                                typeof(float)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    
                                    pizaroAnimatorInput._animationTypeFadeOutandHide,
                                    pizaroAnimatorInput.fadebegin,
                                    pizaroAnimatorInput.fadelimit,
                                    pizaroAnimatorInput.dummy,
                                    pizaroAnimatorInput.dummy,
                                    pizaroAnimatorInput.control,

                                    pizaroAnimatorInput.duration,
                                    pizaroAnimatorInput.accelerate,
                                    pizaroAnimatorInput.easingstart,
                                    pizaroAnimatorInput.easingend

                                });
                            }
                        }

                        else if (pizaroAnimatorInput.AnimationType == animationType.Slide)
                        {
                            ConstructorInfo ctor = typeof(ZeroitPizaroAnimatorInput).GetConstructor(new Type[] {

                                
                                typeof(animationType),                                
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(bool),
                                typeof(Control),
                                typeof(int),
                                typeof(float),
                                typeof(float),
                                typeof(float)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    
                                    pizaroAnimatorInput._animationTypeSlide,
                                    pizaroAnimatorInput.cordinateStart_X,
                                    pizaroAnimatorInput.cordinateStart_Y,
                                    pizaroAnimatorInput.cordinateEnd_X,
                                    pizaroAnimatorInput.cordinateEnd_Y,
                                    pizaroAnimatorInput.alwaysTrue,
                                    pizaroAnimatorInput.control,

                                    pizaroAnimatorInput.duration,
                                    pizaroAnimatorInput.accelerate,
                                    pizaroAnimatorInput.easingstart,
                                    pizaroAnimatorInput.easingend

                                });
                            }
                        }

                        else if (pizaroAnimatorInput.AnimationType == animationType.SlideFrom)
                        {
                            ConstructorInfo ctor = typeof(ZeroitPizaroAnimatorInput).GetConstructor(new Type[] {

                                
                                typeof(animationType),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(string),
                                typeof(Control),
                                typeof(int),
                                typeof(float),
                                typeof(float),
                                typeof(float)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    
                                    pizaroAnimatorInput._animationTypeSlideFrom,
                                    pizaroAnimatorInput.cordinateStart_X,
                                    pizaroAnimatorInput.cordinateStart_Y,
                                    pizaroAnimatorInput.cordinateEnd_X,
                                    pizaroAnimatorInput.cordinateEnd_Y,
                                    pizaroAnimatorInput.dummy,
                                    pizaroAnimatorInput.control,

                                    pizaroAnimatorInput.duration,
                                    pizaroAnimatorInput.accelerate,
                                    pizaroAnimatorInput.easingstart,
                                    pizaroAnimatorInput.easingend

                                });
                            }
                        }


                        else
                        {
                            ConstructorInfo ctor = typeof(ZeroitPizaroAnimatorInput).GetConstructor(Type.EmptyTypes);
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, null);
                            }
                        }
                    }
                
                return base.ConvertTo(context, culture, value, destinationType);
            }
        }

        #endregion


    }
    


}
