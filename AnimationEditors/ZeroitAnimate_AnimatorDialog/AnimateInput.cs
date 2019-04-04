// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="AnimateInput.cs" company="Zeroit Dev Technologies">
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

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    /// Class AnimateInput.
    /// </summary>
    [TypeConverter(typeof(AnimateInput.AnimateInputConverter))]
    [Editor(typeof(AnimatorEditor), typeof(System.Drawing.Design.UITypeEditor))]

    public class AnimateInput
    {
        #region Variables

        /// <summary>
        /// The target
        /// </summary>
        private Control _target = new Control();
        /// <summary>
        /// The target width
        /// </summary>
        private int targetWidth;
        /// <summary>
        /// The target height
        /// </summary>
        private int targetHeight;
        //private float timestep;
        /// <summary>
        /// The duration
        /// </summary>
        private int duration;
        /// <summary>
        /// The interval
        /// </summary>
        private int interval;
        /// <summary>
        /// The animation type
        /// </summary>
        private Transitions.AnimatorWithEditor.AnimationType animationType = Transitions.AnimatorWithEditor.AnimationType.Mosaic;
        /// <summary>
        /// The animate editor instance
        /// </summary>
        private Transitions.AnimatorWithEditor.ZeroitAnimate_Animation animateEditorInstance = new Transitions.AnimatorWithEditor.ZeroitAnimate_Animation();
        /// <summary>
        /// The dummy int
        /// </summary>
        private int dummy_int = 0;
        /// <summary>
        /// The dummy float
        /// </summary>
        private float dummy_float = 0f;
        /// <summary>
        /// The dummy double
        /// </summary>
        private double dummy_double = 0D;
        /// <summary>
        /// The dummy long
        /// </summary>
        private long dummy_long = 0;
        /// <summary>
        /// The dummy decimal
        /// </summary>
        private decimal dummy_decimal = 0;
        /// <summary>
        /// The dummy string
        /// </summary>
        private string dummy_string = "";


        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the target.
        /// </summary>
        /// <value>The target.</value>
        public Control Target
        {
            get { return _target; }
            set
            {
                _target = value;
                _target.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the width of the target.
        /// </summary>
        /// <value>The width of the target.</value>
        public int TargetWidth
        {
            get { return targetWidth; }
            set
            {
                targetWidth = value;
                _target.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the height of the target.
        /// </summary>
        /// <value>The height of the target.</value>
        public int TargetHeight
        {
            get { return targetHeight; }
            set
            {
                targetHeight = value;
                
            }
        }

        ///// <summary>
        ///// Time step
        ///// </summary>
        //[DefaultValue(0.02f)]
        //public float TimeStep {
        //    get { return timestep; }
        //    set
        //    {
        //        timestep = value;

        //    } 
        //}

        /// <summary>
        /// Max time of animation (ms)
        /// </summary>
        /// <value>The duration.</value>
        [DefaultValue(1500)]
        public int Duration
        {
            get { return duration; }
            set
            {
                duration = value;
                
            }
        }

        /// <summary>
        /// Default animation
        /// </summary>
        /// <value>The default animation.</value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Transitions.AnimatorWithEditor.ZeroitAnimate_Animation DefaultAnimation
        {
            get { return animateEditorInstance; }
            set
            {
                animateEditorInstance = value;
                
            }
        }

        /// <summary>
        /// Interval between frames (ms)
        /// </summary>
        /// <value>The interval.</value>
        [DefaultValue(10)]
        public int Interval
        {
            get { return interval; }
            set
            {
                interval = value;
                
            }
        }


        /// <summary>
        /// Type of built-in animation
        /// </summary>
        /// <value>The type of the animation.</value>
        public Transitions.AnimatorWithEditor.AnimationType AnimationType
        {
            get { return animationType; }
            set
            {
                animationType = value;
                

            }
        }

        #endregion

        #region Constructor

        //Internal Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="AnimateInput"/> class.
        /// </summary>
        /// <param name="animationType">Type of the animation.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="targetWidth">Width of the target.</param>
        /// <param name="targetHeight">Height of the target.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animateEditorInstance">The animate editor instance.</param>
        public AnimateInput(
            Transitions.AnimatorWithEditor.AnimationType animationType, 
            int interval,
            int targetWidth, 
            int targetHeight, 
            //float timestep, 
            int duration,
            Transitions.AnimatorWithEditor.ZeroitAnimate_Animation animateEditorInstance)
        {
            this.animationType = animationType;
            this.interval = interval;
            this.targetWidth = targetWidth;
            this.targetHeight = targetHeight;
            //this.timestep = timestep;
            this.duration = duration;
            this.animateEditorInstance = animateEditorInstance;
        }

        /// <summary>
        /// Constructor for No Input
        /// </summary>
        public AnimateInput() : this(Transitions.AnimatorWithEditor.AnimationType.Scale,10, 100,100/*,0.02f*/,1500, new Transitions.AnimatorWithEditor.ZeroitAnimate_Animation())
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimateInput"/> class.
        /// </summary>
        /// <param name="Custom">The custom.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="targetWidth">Width of the target.</param>
        /// <param name="targetHeight">Height of the target.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animateEditorInstance">The animate editor instance.</param>
        /// <param name="_target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        public AnimateInput(
            Transitions.AnimatorWithEditor.AnimationType Custom,
            int interval,
            int targetWidth,
            int targetHeight,
            //float timestep,
            int duration,
            Transitions.AnimatorWithEditor.ZeroitAnimate_Animation animateEditorInstance,
            Control _target,
            int dummy) : this(Transitions.AnimatorWithEditor.AnimationType.Custom, 10, 100, 100/*,0.02f*/, 1500, new Transitions.AnimatorWithEditor.ZeroitAnimate_Animation())
        {
            this.animationType = Custom;
            this.interval = interval;
            this.targetWidth = targetWidth;
            this.targetHeight = targetHeight;
            //this.timestep = timestep;
            this.duration = duration;
            this.animateEditorInstance = animateEditorInstance;
            this._target = _target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimateInput"/> class.
        /// </summary>
        /// <param name="Rotate">The rotate.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="targetWidth">Width of the target.</param>
        /// <param name="targetHeight">Height of the target.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animateEditorInstance">The animate editor instance.</param>
        /// <param name="_target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        public AnimateInput(
            Transitions.AnimatorWithEditor.AnimationType Rotate,
            int interval,
            int targetWidth,
            int targetHeight,
            //float timestep,
            int duration,
            Transitions.AnimatorWithEditor.ZeroitAnimate_Animation animateEditorInstance,
            Control _target,
            float dummy) : this(Transitions.AnimatorWithEditor.AnimationType.Rotate, 10, 100, 100/*,0.02f*/, 1500, new Transitions.AnimatorWithEditor.ZeroitAnimate_Animation())
        {
            this.animationType = Rotate;
            this.interval = interval;
            this.targetWidth = targetWidth;
            this.targetHeight = targetHeight;
            //this.timestep = timestep;
            this.duration = duration;
            this.animateEditorInstance = animateEditorInstance;
            this._target = _target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimateInput"/> class.
        /// </summary>
        /// <param name="HorizSlide">The horiz slide.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="targetWidth">Width of the target.</param>
        /// <param name="targetHeight">Height of the target.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animateEditorInstance">The animate editor instance.</param>
        /// <param name="_target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        public AnimateInput(
            Transitions.AnimatorWithEditor.AnimationType HorizSlide,
            int interval,
            int targetWidth,
            int targetHeight,
            //float timestep,
            int duration,
            Transitions.AnimatorWithEditor.ZeroitAnimate_Animation animateEditorInstance,
            Control _target,
            double dummy) : this(Transitions.AnimatorWithEditor.AnimationType.HorizSlide, 10, 100, 100/*,0.02f*/, 1500, new Transitions.AnimatorWithEditor.ZeroitAnimate_Animation())
        {
            this.animationType = HorizSlide;
            this.interval = interval;
            this.targetWidth = targetWidth;
            this.targetHeight = targetHeight;
            //this.timestep = timestep;
            this.duration = duration;
            this.animateEditorInstance = animateEditorInstance;
            this._target = _target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimateInput"/> class.
        /// </summary>
        /// <param name="VertSlide">The vert slide.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="targetWidth">Width of the target.</param>
        /// <param name="targetHeight">Height of the target.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animateEditorInstance">The animate editor instance.</param>
        /// <param name="_target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        public AnimateInput(
            Transitions.AnimatorWithEditor.AnimationType VertSlide,
            int interval,
            int targetWidth,
            int targetHeight,
            //float timestep,
            int duration,
            Transitions.AnimatorWithEditor.ZeroitAnimate_Animation animateEditorInstance,
            Control _target,
            decimal dummy) : this(Transitions.AnimatorWithEditor.AnimationType.VertSlide, 10, 100, 100/*,0.02f*/, 1500, new Transitions.AnimatorWithEditor.ZeroitAnimate_Animation())
        {
            this.animationType = VertSlide;
            this.interval = interval;
            this.targetWidth = targetWidth;
            this.targetHeight = targetHeight;
            //this.timestep = timestep;
            this.duration = duration;
            this.animateEditorInstance = animateEditorInstance;
            this._target = _target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimateInput"/> class.
        /// </summary>
        /// <param name="Scale">The scale.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="targetWidth">Width of the target.</param>
        /// <param name="targetHeight">Height of the target.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animateEditorInstance">The animate editor instance.</param>
        /// <param name="_target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        public AnimateInput(
            Transitions.AnimatorWithEditor.AnimationType Scale,
            int interval,
            int targetWidth,
            int targetHeight,
            //float timestep,
            int duration,
            Transitions.AnimatorWithEditor.ZeroitAnimate_Animation animateEditorInstance,
            Control _target,
            long dummy) : this(Transitions.AnimatorWithEditor.AnimationType.Scale, 10, 100, 100/*,0.02f*/, 1500, new Transitions.AnimatorWithEditor.ZeroitAnimate_Animation())
        {
            this.animationType = Scale;
            this.interval = interval;
            this.targetWidth = targetWidth;
            this.targetHeight = targetHeight;
            //this.timestep = timestep;
            this.duration = duration;
            this.animateEditorInstance = animateEditorInstance;
            this._target = _target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimateInput"/> class.
        /// </summary>
        /// <param name="ScaleRotate">The scale rotate.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="targetWidth">Width of the target.</param>
        /// <param name="targetHeight">Height of the target.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animateEditorInstance">The animate editor instance.</param>
        /// <param name="_target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        public AnimateInput(
            Transitions.AnimatorWithEditor.AnimationType ScaleRotate,
            int interval,
            int targetWidth,
            int targetHeight,
            //float timestep,
            int duration,
            Transitions.AnimatorWithEditor.ZeroitAnimate_Animation animateEditorInstance,
            Control _target,
            string dummy) : this(Transitions.AnimatorWithEditor.AnimationType.ScaleAndRotate, 10, 100, 100/*,0.02f*/, 1500, new Transitions.AnimatorWithEditor.ZeroitAnimate_Animation())
        {
            this.animationType = ScaleRotate;
            this.interval = interval;
            this.targetWidth = targetWidth;
            this.targetHeight = targetHeight;
            //this.timestep = timestep;
            this.duration = duration;
            this.animateEditorInstance = animateEditorInstance;
            this._target = _target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimateInput"/> class.
        /// </summary>
        /// <param name="HorizSlideAndRotate">The horiz slide and rotate.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="targetWidth">Width of the target.</param>
        /// <param name="targetHeight">Height of the target.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animateEditorInstance">The animate editor instance.</param>
        /// <param name="_target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public AnimateInput(
            Transitions.AnimatorWithEditor.AnimationType HorizSlideAndRotate,
            int interval,
            int targetWidth,
            int targetHeight,
            //float timestep,
            int duration,
            Transitions.AnimatorWithEditor.ZeroitAnimate_Animation animateEditorInstance,
            Control _target,
            int dummy, float dummy1) : this(Transitions.AnimatorWithEditor.AnimationType.HorizSlideAndRotate, 10, 100, 100/*,0.02f*/, 1500, new Transitions.AnimatorWithEditor.ZeroitAnimate_Animation())
        {
            this.animationType = HorizSlideAndRotate;
            this.interval = interval;
            this.targetWidth = targetWidth;
            this.targetHeight = targetHeight;
            //this.timestep = timestep;
            this.duration = duration;
            this.animateEditorInstance = animateEditorInstance;
            this._target = _target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimateInput"/> class.
        /// </summary>
        /// <param name="ScaleAndHorizSlide">The scale and horiz slide.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="targetWidth">Width of the target.</param>
        /// <param name="targetHeight">Height of the target.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animateEditorInstance">The animate editor instance.</param>
        /// <param name="_target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public AnimateInput(
            Transitions.AnimatorWithEditor.AnimationType ScaleAndHorizSlide,
            int interval,
            int targetWidth,
            int targetHeight,
            //float timestep,
            int duration,
            Transitions.AnimatorWithEditor.ZeroitAnimate_Animation animateEditorInstance,
            Control _target,
            int dummy, double dummy1) : this(Transitions.AnimatorWithEditor.AnimationType.ScaleAndHorizSlide, 10, 100, 100/*,0.02f*/, 1500, new Transitions.AnimatorWithEditor.ZeroitAnimate_Animation())
        {
            this.animationType = ScaleAndHorizSlide;
            this.interval = interval;
            this.targetWidth = targetWidth;
            this.targetHeight = targetHeight;
            //this.timestep = timestep;
            this.duration = duration;
            this.animateEditorInstance = animateEditorInstance;
            this._target = _target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimateInput"/> class.
        /// </summary>
        /// <param name="Transparent">The transparent.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="targetWidth">Width of the target.</param>
        /// <param name="targetHeight">Height of the target.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animateEditorInstance">The animate editor instance.</param>
        /// <param name="_target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public AnimateInput(
            Transitions.AnimatorWithEditor.AnimationType Transparent,
            int interval,
            int targetWidth,
            int targetHeight,
            //float timestep,
            int duration,
            Transitions.AnimatorWithEditor.ZeroitAnimate_Animation animateEditorInstance,
            Control _target,
            int dummy, decimal dummy1) : this(Transitions.AnimatorWithEditor.AnimationType.Transparent, 10, 100, 100/*,0.02f*/, 1500, new Transitions.AnimatorWithEditor.ZeroitAnimate_Animation())
        {
            this.animationType = Transparent;
            this.interval = interval;
            this.targetWidth = targetWidth;
            this.targetHeight = targetHeight;
            //this.timestep = timestep;
            this.duration = duration;
            this.animateEditorInstance = animateEditorInstance;
            this._target = _target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimateInput"/> class.
        /// </summary>
        /// <param name="Leaf">The leaf.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="targetWidth">Width of the target.</param>
        /// <param name="targetHeight">Height of the target.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animateEditorInstance">The animate editor instance.</param>
        /// <param name="_target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public AnimateInput(
            Transitions.AnimatorWithEditor.AnimationType Leaf,
            int interval,
            int targetWidth,
            int targetHeight,
            //float timestep,
            int duration,
            Transitions.AnimatorWithEditor.ZeroitAnimate_Animation animateEditorInstance,
            Control _target,
            int dummy, long dummy1) : this(Transitions.AnimatorWithEditor.AnimationType.Leaf, 10, 100, 100/*,0.02f*/, 1500, new Transitions.AnimatorWithEditor.ZeroitAnimate_Animation())
        {
            this.animationType = Leaf;
            this.interval = interval;
            this.targetWidth = targetWidth;
            this.targetHeight = targetHeight;
            //this.timestep = timestep;
            this.duration = duration;
            this.animateEditorInstance = animateEditorInstance;
            this._target = _target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimateInput"/> class.
        /// </summary>
        /// <param name="Mosaic">The mosaic.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="targetWidth">Width of the target.</param>
        /// <param name="targetHeight">Height of the target.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animateEditorInstance">The animate editor instance.</param>
        /// <param name="_target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public AnimateInput(
            Transitions.AnimatorWithEditor.AnimationType Mosaic,
            int interval,
            int targetWidth,
            int targetHeight,
            //float timestep,
            int duration,
            Transitions.AnimatorWithEditor.ZeroitAnimate_Animation animateEditorInstance,
            Control _target,
            int dummy, string dummy1) : this(Transitions.AnimatorWithEditor.AnimationType.Mosaic, 10, 100, 100/*,0.02f*/, 1500, new Transitions.AnimatorWithEditor.ZeroitAnimate_Animation())
        {
            this.animationType = Mosaic;
            this.interval = interval;
            this.targetWidth = targetWidth;
            this.targetHeight = targetHeight;
            //this.timestep = timestep;
            this.duration = duration;
            this.animateEditorInstance = animateEditorInstance;
            this._target = _target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimateInput"/> class.
        /// </summary>
        /// <param name="Particles">The particles.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="targetWidth">Width of the target.</param>
        /// <param name="targetHeight">Height of the target.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animateEditorInstance">The animate editor instance.</param>
        /// <param name="_target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public AnimateInput(
            Transitions.AnimatorWithEditor.AnimationType Particles,
            int interval,
            int targetWidth,
            int targetHeight,
            //float timestep,
            int duration,
            Transitions.AnimatorWithEditor.ZeroitAnimate_Animation animateEditorInstance,
            Control _target,
            float dummy, int dummy1) : this(Transitions.AnimatorWithEditor.AnimationType.Particles, 10, 100, 100/*,0.02f*/, 1500, new Transitions.AnimatorWithEditor.ZeroitAnimate_Animation())
        {
            this.animationType = Particles;
            this.interval = interval;
            this.targetWidth = targetWidth;
            this.targetHeight = targetHeight;
            //this.timestep = timestep;
            this.duration = duration;
            this.animateEditorInstance = animateEditorInstance;
            this._target = _target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimateInput"/> class.
        /// </summary>
        /// <param name="VertBlind">The vert blind.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="targetWidth">Width of the target.</param>
        /// <param name="targetHeight">Height of the target.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animateEditorInstance">The animate editor instance.</param>
        /// <param name="_target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public AnimateInput(
            Transitions.AnimatorWithEditor.AnimationType VertBlind,
            int interval,
            int targetWidth,
            int targetHeight,
            //float timestep,
            int duration,
            Transitions.AnimatorWithEditor.ZeroitAnimate_Animation animateEditorInstance,
            Control _target,
            float dummy, float dummy1) : this(Transitions.AnimatorWithEditor.AnimationType.VertBlind, 10, 100, 100/*,0.02f*/, 1500, new Transitions.AnimatorWithEditor.ZeroitAnimate_Animation())
        {
            this.animationType = VertBlind;
            this.interval = interval;
            this.targetWidth = targetWidth;
            this.targetHeight = targetHeight;
            //this.timestep = timestep;
            this.duration = duration;
            this.animateEditorInstance = animateEditorInstance;
            this._target = _target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimateInput"/> class.
        /// </summary>
        /// <param name="HorizBlind">The horiz blind.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="targetWidth">Width of the target.</param>
        /// <param name="targetHeight">Height of the target.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animateEditorInstance">The animate editor instance.</param>
        /// <param name="_target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public AnimateInput(
            Transitions.AnimatorWithEditor.AnimationType HorizBlind,
            int interval,
            int targetWidth,
            int targetHeight,
            //float timestep,
            int duration,
            Transitions.AnimatorWithEditor.ZeroitAnimate_Animation animateEditorInstance,
            Control _target,
            float dummy, double dummy1) : this(Transitions.AnimatorWithEditor.AnimationType.HorizBlind, 10, 100, 100/*,0.02f*/, 1500, new Transitions.AnimatorWithEditor.ZeroitAnimate_Animation())
        {
            this.animationType = HorizBlind;
            this.interval = interval;
            this.targetWidth = targetWidth;
            this.targetHeight = targetHeight;
            //this.timestep = timestep;
            this.duration = duration;
            this.animateEditorInstance = animateEditorInstance;
            this._target = _target;
        }


        #endregion


        #region Public Methods

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>AnimateInput.</returns>
        public AnimateInput Clone()
        {
            return new AnimateInput(
                animationType,
                interval,
                targetWidth,
                targetHeight,
                //timestep,
                duration,
                animateEditorInstance
            );
        }

        /// <summary>
        /// Empties this instance.
        /// </summary>
        /// <returns>AnimateInput.</returns>
        public static AnimateInput Empty()
        {
            return new AnimateInput();
        }


        #endregion


        #region Converter

        /// <summary>
        /// Class AnimateInputConverter.
        /// </summary>
        /// <seealso cref="System.ComponentModel.TypeConverter" />
        internal class AnimateInputConverter : TypeConverter
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


                    else if (destinationType == typeof(InstanceDescriptor) && value is AnimateInput)
                    {
                        AnimateInput animateInput = (AnimateInput)value;

                        if (animateInput.AnimationType == 
                            Transitions.AnimatorWithEditor.AnimationType.Custom)
                        {
                            ConstructorInfo ctor = typeof(AnimateInput).GetConstructor(new Type[]
                            {

                                typeof(Transitions.AnimatorWithEditor.AnimationType),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                //typeof(float),
                                typeof(int),
                                typeof(Transitions.AnimatorWithEditor.ZeroitAnimate_Animation),
                                typeof(Control),
                                typeof(int)
                                


                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {
                                    

                                    animateInput.animationType,
                                    animateInput.interval,
                                    animateInput.targetWidth,
                                    animateInput.targetHeight,
                                    //animateInput.timestep,
                                    animateInput.duration,
                                    animateInput.animateEditorInstance,
                                    animateInput._target,
                                    animateInput.dummy_int


                                });
                            }
                        }

                        else if (animateInput.AnimationType == 
                            Transitions.AnimatorWithEditor.AnimationType.Rotate)
                        {
                            ConstructorInfo ctor = typeof(AnimateInput).GetConstructor(new Type[] {


                                typeof(Transitions.AnimatorWithEditor.AnimationType),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                //typeof(float),
                                typeof(int),
                                typeof(Transitions.AnimatorWithEditor.ZeroitAnimate_Animation),
                                typeof(Control),
                                typeof(float)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {
                                    animateInput.animationType,
                                    animateInput.interval,
                                    animateInput.targetWidth,
                                    animateInput.targetHeight,
                                    //animateInput.timestep,
                                    animateInput.duration,
                                    animateInput.animateEditorInstance,
                                    animateInput._target,
                                    animateInput.dummy_float,

                                });
                            }
                        }
                        else if (animateInput.AnimationType == 
                            Transitions.AnimatorWithEditor.AnimationType.HorizSlide)
                        {
                            ConstructorInfo ctor = typeof(AnimateInput).GetConstructor(new Type[] {


                                typeof(Transitions.AnimatorWithEditor.AnimationType),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                //typeof(float),
                                typeof(int),
                                typeof(Transitions.AnimatorWithEditor.ZeroitAnimate_Animation),
                                typeof(Control),
                                typeof(double)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    animateInput.animationType,
                                    animateInput.interval,
                                    animateInput.targetWidth,
                                    animateInput.targetHeight,
                                    //animateInput.timestep,
                                    animateInput.duration,
                                    animateInput.animateEditorInstance,
                                    animateInput._target,
                                    animateInput.dummy_double

                            });
                            }
                        }

                        else if (animateInput.AnimationType == 
                            Transitions.AnimatorWithEditor.AnimationType.VertSlide)
                        {
                            ConstructorInfo ctor = typeof(AnimateInput).GetConstructor(new Type[] {


                                typeof(Transitions.AnimatorWithEditor.AnimationType),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                //typeof(float),
                                typeof(int),
                                typeof(Transitions.AnimatorWithEditor.ZeroitAnimate_Animation),
                                typeof(Control),
                                typeof(decimal)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    animateInput.animationType,
                                    animateInput.interval,
                                    animateInput.targetWidth,
                                    animateInput.targetHeight,
                                    //animateInput.timestep,
                                    animateInput.duration,
                                    animateInput.animateEditorInstance,
                                    animateInput._target,
                                    animateInput.dummy_decimal

                            });
                            }
                        }


                        else if (animateInput.AnimationType == 
                            Transitions.AnimatorWithEditor.AnimationType.Scale)
                        {
                            ConstructorInfo ctor = typeof(AnimateInput).GetConstructor(new Type[] {


                                typeof(Transitions.AnimatorWithEditor.AnimationType),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                //typeof(float),
                                typeof(int),
                                typeof(Transitions.AnimatorWithEditor.ZeroitAnimate_Animation),
                                typeof(Control),
                                typeof(long)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    animateInput.animationType,
                                    animateInput.interval,
                                    animateInput.targetWidth,
                                    animateInput.targetHeight,
                                    //animateInput.timestep,
                                    animateInput.duration,
                                    animateInput.animateEditorInstance,
                                    animateInput._target,
                                    animateInput.dummy_long

                                });
                            }
                        }

                        else if (animateInput.AnimationType == 
                            Transitions.AnimatorWithEditor.AnimationType.ScaleAndRotate)
                        {
                            ConstructorInfo ctor = typeof(AnimateInput).GetConstructor(new Type[] {

                                typeof(Transitions.AnimatorWithEditor.AnimationType),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                //typeof(float),
                                typeof(int),
                                typeof(Transitions.AnimatorWithEditor.ZeroitAnimate_Animation),
                                typeof(Control),
                                typeof(string)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    animateInput.animationType,
                                    animateInput.interval,
                                    animateInput.targetWidth,
                                    animateInput.targetHeight,
                                    //animateInput.timestep,
                                    animateInput.duration,
                                    animateInput.animateEditorInstance,
                                    animateInput._target,
                                    animateInput.dummy_string

                                });
                            }
                        }

                        else if (animateInput.AnimationType == 
                            Transitions.AnimatorWithEditor.AnimationType.HorizSlideAndRotate)
                        {
                            ConstructorInfo ctor = typeof(AnimateInput).GetConstructor(new Type[] {

                                typeof(Transitions.AnimatorWithEditor.AnimationType),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                //typeof(float),
                                typeof(int),
                                typeof(Transitions.AnimatorWithEditor.ZeroitAnimate_Animation),
                                typeof(Control),
                                typeof(int),
                                typeof(float)


                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    animateInput.animationType,
                                    animateInput.interval,
                                    animateInput.targetWidth,
                                    animateInput.targetHeight,
                                    //animateInput.timestep,
                                    animateInput.duration,
                                    animateInput.animateEditorInstance,
                                    animateInput._target,
                                    animateInput.dummy_int,
                                    animateInput.dummy_float


                                });
                            }
                        }

                        else if (animateInput.AnimationType == 
                            Transitions.AnimatorWithEditor.AnimationType.ScaleAndHorizSlide)
                        {
                            ConstructorInfo ctor = typeof(AnimateInput).GetConstructor(new Type[] {


                                typeof(Transitions.AnimatorWithEditor.AnimationType),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                //typeof(float),
                                typeof(int),
                                typeof(Transitions.AnimatorWithEditor.ZeroitAnimate_Animation),
                                typeof(Control),
                                typeof(int),
                                typeof(double)


                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    animateInput.animationType,
                                    animateInput.interval,
                                    animateInput.targetWidth,
                                    animateInput.targetHeight,
                                    //animateInput.timestep,
                                    animateInput.duration,
                                    animateInput.animateEditorInstance,
                                    animateInput._target,
                                    animateInput.dummy_int,
                                    animateInput.dummy_double


                                });
                            }
                        }

                        else if (animateInput.AnimationType == 
                            Transitions.AnimatorWithEditor.AnimationType.Transparent)
                        {
                            ConstructorInfo ctor = typeof(AnimateInput).GetConstructor(new Type[] {


                                typeof(Transitions.AnimatorWithEditor.AnimationType),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                //typeof(float),
                                typeof(int),
                                typeof(Transitions.AnimatorWithEditor.ZeroitAnimate_Animation),
                                typeof(Control),
                                typeof(int),
                                typeof(decimal)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    animateInput.animationType,
                                    animateInput.interval,
                                    animateInput.targetWidth,
                                    animateInput.targetHeight,
                                    //animateInput.timestep,
                                    animateInput.duration,
                                    animateInput.animateEditorInstance,
                                    animateInput._target,
                                    animateInput.dummy_int,
                                    animateInput.dummy_decimal


                                });
                            }
                        }

                        else if (animateInput.AnimationType == 
                            Transitions.AnimatorWithEditor.AnimationType.Leaf)
                        {
                            ConstructorInfo ctor = typeof(AnimateInput).GetConstructor(new Type[] {


                                typeof(Transitions.AnimatorWithEditor.AnimationType),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                //typeof(float),
                                typeof(int),
                                typeof(Transitions.AnimatorWithEditor.ZeroitAnimate_Animation),
                                typeof(Control),
                                typeof(int),
                                typeof(long)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    animateInput.animationType,
                                    animateInput.interval,
                                    animateInput.targetWidth,
                                    animateInput.targetHeight,
                                    //animateInput.timestep,
                                    animateInput.duration,
                                    animateInput.animateEditorInstance,
                                    animateInput._target,
                                    animateInput.dummy_int,
                                    animateInput.dummy_long

                                });
                            }
                        }

                        else if (animateInput.AnimationType == 
                            Transitions.AnimatorWithEditor.AnimationType.Mosaic)
                        {
                            ConstructorInfo ctor = typeof(AnimateInput).GetConstructor(new Type[] {


                                typeof(Transitions.AnimatorWithEditor.AnimationType),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                //typeof(float),
                                typeof(int),
                                typeof(Transitions.AnimatorWithEditor.ZeroitAnimate_Animation),
                                typeof(Control),
                                typeof(int),
                                typeof(string)


                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    animateInput.animationType,
                                    animateInput.interval,
                                    animateInput.targetWidth,
                                    animateInput.targetHeight,
                                    //animateInput.timestep,
                                    animateInput.duration,
                                    animateInput.animateEditorInstance,
                                    animateInput._target,
                                    animateInput.dummy_int,
                                    animateInput.dummy_string

                                });
                            }
                        }

                        else if (animateInput.AnimationType == 
                            Transitions.AnimatorWithEditor.AnimationType.Particles)
                        {
                            ConstructorInfo ctor = typeof(AnimateInput).GetConstructor(new Type[] {


                                typeof(Transitions.AnimatorWithEditor.AnimationType),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                //typeof(float),
                                typeof(int),
                                typeof(Transitions.AnimatorWithEditor.ZeroitAnimate_Animation),
                                typeof(Control),
                                typeof(float),
                                typeof(int)

                        });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    animateInput.animationType,
                                    animateInput.interval,
                                    animateInput.targetWidth,
                                    animateInput.targetHeight,
                                    //animateInput.timestep,
                                    animateInput.duration,
                                    animateInput.animateEditorInstance,
                                    animateInput._target,
                                    animateInput.dummy_float,
                                    animateInput.dummy_int


                            });
                            }
                        }

                        else if (animateInput.AnimationType == 
                            Transitions.AnimatorWithEditor.AnimationType.VertBlind)
                        {
                            ConstructorInfo ctor = typeof(AnimateInput).GetConstructor(new Type[] {


                                typeof(Transitions.AnimatorWithEditor.AnimationType),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                //typeof(float),
                                typeof(int),
                                typeof(Transitions.AnimatorWithEditor.ZeroitAnimate_Animation),
                                typeof(Control),
                                typeof(float),
                                typeof(float)

                        });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    animateInput.animationType,
                                    animateInput.interval,
                                    animateInput.targetWidth,
                                    animateInput.targetHeight,
                                    //animateInput.timestep,
                                    animateInput.duration,
                                    animateInput.animateEditorInstance,
                                    animateInput._target,
                                    animateInput.dummy_float,
                                    animateInput.dummy_float

                            });
                            }
                        }

                        else if (animateInput.AnimationType == 
                            Transitions.AnimatorWithEditor.AnimationType.HorizBlind)
                        {
                            ConstructorInfo ctor = typeof(AnimateInput).GetConstructor(new Type[] {

                                typeof(Transitions.AnimatorWithEditor.AnimationType),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                //typeof(float),
                                typeof(int),
                                typeof(Transitions.AnimatorWithEditor.ZeroitAnimate_Animation),
                                typeof(Control),
                                typeof(float),
                                typeof(double)

                        });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    animateInput.animationType,
                                    animateInput.interval,
                                    animateInput.targetWidth,
                                    animateInput.targetHeight,
                                    //animateInput.timestep,
                                    animateInput.duration,
                                    animateInput.animateEditorInstance,
                                    animateInput._target,
                                    animateInput.dummy_float,
                                    animateInput.dummy_double

                            });
                            }
                        }
                        
                        else
                        {
                            ConstructorInfo ctor = typeof(AnimateInput).GetConstructor(Type.EmptyTypes);
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
