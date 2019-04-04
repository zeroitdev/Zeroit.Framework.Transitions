// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ObjectAnimatorInput.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using static Zeroit.Framework.Transitions.ZeroitOJAnimEdit;

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    /// Class ObjectAnimatorInput.
    /// </summary>
    [TypeConverter(typeof(ObjectAnimatorInput.Converter))]
    [EditorAttribute(typeof(ObjectInputEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public class ObjectAnimatorInput
    {

        #region Private Fields

        /// <summary>
        /// The control
        /// </summary>
        private Control control = new Control();


        /// <summary>
        /// The color animation
        /// </summary>
        private ZeroitObjectColorAnimation _colorAnimation = ZeroitObjectColorAnimation.FillEllipse;
        /// <summary>
        /// The form animation
        /// </summary>
        private ZeroitObjectFormAnimation _formAnimation = ZeroitObjectFormAnimation.FadeIn;
        /// <summary>
        /// The standard animation
        /// </summary>
        private ZeroitObjectStandardAnimation _standardAnimation = ZeroitObjectStandardAnimation.Hop;
        /// <summary>
        /// The animation mode
        /// </summary>
        private ZeroitObjectAnimationMode _animationMode = ZeroitObjectAnimationMode.StandardAnimation;

        /// <summary>
        /// The color
        /// </summary>
        private Color color = Color.Orange;
        /// <summary>
        /// The keep color
        /// </summary>
        bool keepColor = true;
        /// <summary>
        /// The animation speed
        /// </summary>
        int animationSpeed = 1;
        /// <summary>
        /// The upper speed limit
        /// </summary>
        int upperSpeedLimit = 10;
        /// <summary>
        /// The lower speed limit
        /// </summary>
        int lowerSpeedLimit = 1;

        /// <summary>
        /// The delay
        /// </summary>
        int delay = 200;
        /// <summary>
        /// The color delay
        /// </summary>
        int colorDelay = 10;
        /// <summary>
        /// The form delay
        /// </summary>
        int formDelay = 50;

        /// <summary>
        /// The standard slide delay
        /// </summary>
        int standardSlideDelay = 40;
        /// <summary>
        /// The standard slug delay
        /// </summary>
        int[] standardSlugDelay = new int[] { 100, 50 };
        /// <summary>
        /// The standard hop delay
        /// </summary>
        int standardHopDelay = 100;
        /// <summary>
        /// The standard shoot delay
        /// </summary>
        int standardShootDelay = 50;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the standard shoot delay.
        /// </summary>
        /// <value>The standard shoot delay.</value>
        public int StandardShootDelay
        {
            get { return standardShootDelay; }
            set
            {
                standardShootDelay = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the standard hop delay.
        /// </summary>
        /// <value>The standard hop delay.</value>
        public int StandardHopDelay
        {
            get { return standardHopDelay; }
            set
            {
                standardHopDelay = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the standard slug delay.
        /// </summary>
        /// <value>The standard slug delay.</value>
        public int[] StandardSlugDelay
        {
            get { return standardSlugDelay; }
            set
            {
                standardSlugDelay = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the standard slide delay.
        /// </summary>
        /// <value>The standard slide delay.</value>
        public int StandardSlideDelay
        {
            get { return standardSlideDelay; }
            set
            {
                standardSlideDelay = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the color animation delay.
        /// </summary>
        /// <value>The color animation delay.</value>
        public int ColorAnimationDelay
        {
            get { return colorDelay; }
            set
            {
                colorDelay = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the form animation delay.
        /// </summary>
        /// <value>The form animation delay.</value>
        public int FormAnimationDelay
        {
            get { return formDelay; }
            set
            {
                formDelay = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the upper speed limit.
        /// </summary>
        /// <value>The upper speed limit.</value>
        public int UpperSpeedLimit
        {
            get { return upperSpeedLimit; }
            set
            {
                upperSpeedLimit = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the lower speed limit.
        /// </summary>
        /// <value>The lower speed limit.</value>
        public int LowerSpeedLimit
        {
            get { return lowerSpeedLimit; }
            set
            {
                lowerSpeedLimit = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the animation mode.
        /// </summary>
        /// <value>The animation mode.</value>
        public ZeroitObjectAnimationMode AnimationMode
        {
            get { return _animationMode; }
            set
            {
                _animationMode = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color animation.
        /// </summary>
        /// <value>The color animation.</value>
        public ZeroitObjectColorAnimation ColorAnimation
        {
            get { return _colorAnimation; }
            set
            {
                _colorAnimation = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the form animation.
        /// </summary>
        /// <value>The form animation.</value>
        public ZeroitObjectFormAnimation FormAnimation
        {
            get { return _formAnimation; }
            set
            {
                _formAnimation = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the standard animation.
        /// </summary>
        /// <value>The standard animation.</value>
        public ZeroitObjectStandardAnimation StandardAnimation
        {
            get { return _standardAnimation; }
            set
            {
                _standardAnimation = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the delay.
        /// </summary>
        /// <value>The delay.</value>
        public int Delay
        {
            get { return delay; }
            set
            {
                delay = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the animation speed.
        /// </summary>
        /// <value>The animation speed.</value>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Value must be greater than 1
        /// or
        /// Value must be less than 10
        /// </exception>
        public int AnimationSpeed
        {
            get { return animationSpeed; }
            set
            {
                if (value < lowerSpeedLimit)
                {
                    value = 1;
                    throw new ArgumentOutOfRangeException("Value must be greater than 1");
                }

                if (value > upperSpeedLimit)
                {
                    value = 10;
                    throw new ArgumentOutOfRangeException("Value must be less than 10");
                }

                animationSpeed = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [keep color].
        /// </summary>
        /// <value><c>true</c> if [keep color]; otherwise, <c>false</c>.</value>
        public bool KeepColor
        {
            get { return keepColor; }
            set
            {
                keepColor = value;
                

            }
        }

        /// <summary>
        /// Gets or sets the color to animate.
        /// </summary>
        /// <value>The color to animate.</value>
        public Color ColorToAnimate
        {
            get { return color; }
            set
            {
                color = value;
                
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
                
            }
        }
        #endregion

        #region Constructors

        //Internal Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectAnimatorInput"/> class.
        /// </summary>
        /// <param name="_colorAnimation">The color animation.</param>
        /// <param name="_formAnimation">The form animation.</param>
        /// <param name="_standardAnimation">The standard animation.</param>
        /// <param name="_animationMode">The animation mode.</param>
        /// <param name="color">The color.</param>
        /// <param name="keepColor">if set to <c>true</c> [keep color].</param>
        /// <param name="animationSpeed">The animation speed.</param>
        /// <param name="upperSpeedLimit">The upper speed limit.</param>
        /// <param name="lowerSpeedLimit">The lower speed limit.</param>
        /// <param name="delay">The delay.</param>
        /// <param name="colorDelay">The color delay.</param>
        /// <param name="formDelay">The form delay.</param>
        /// <param name="standardSlideDelay">The standard slide delay.</param>
        /// <param name="standardSlugDelay">The standard slug delay.</param>
        /// <param name="standardHopDelay">The standard hop delay.</param>
        /// <param name="standardShootDelay">The standard shoot delay.</param>
        public ObjectAnimatorInput(
            
                ZeroitObjectColorAnimation _colorAnimation,
                ZeroitObjectFormAnimation _formAnimation,
                ZeroitObjectStandardAnimation _standardAnimation,
                ZeroitObjectAnimationMode _animationMode,
                Color color,
                bool keepColor,
                int animationSpeed,
                int upperSpeedLimit,
                int lowerSpeedLimit,
                int delay,
                int colorDelay,
                int formDelay,
                int standardSlideDelay,
                int[] standardSlugDelay,
                int standardHopDelay,
                int standardShootDelay
            )
        {

            this._colorAnimation = _colorAnimation;
            this._formAnimation = _formAnimation;
            this._standardAnimation = _standardAnimation;
            this._animationMode = _animationMode;
            this.color = color;
            this.keepColor = keepColor;
            this.animationSpeed = animationSpeed;
            this.upperSpeedLimit = upperSpeedLimit;
            this.lowerSpeedLimit = lowerSpeedLimit;
            this.delay = delay;
            this.colorDelay = colorDelay;
            this.formDelay = formDelay;
            this.standardSlideDelay = standardSlideDelay;
            this.standardSlugDelay = standardSlugDelay;
            this.standardHopDelay = standardHopDelay;
            this.standardShootDelay = standardShootDelay;
        }

        /// <summary>
        /// Constructor for no Input.
        /// </summary>
        public ObjectAnimatorInput() : 
            this(
                    ZeroitObjectColorAnimation.FillEllipse,
                    ZeroitObjectFormAnimation.FadeIn,
                    ZeroitObjectStandardAnimation.Hop,
                    ZeroitObjectAnimationMode.StandardAnimation,
                    Color.Orange,
                    true,
                    1,
                    10,
                    1,
                    200,
                    10,
                    50,
                    40,
                    new int[] { 100, 50 },
                    100,
                    50
                )
        {

        }

        /// <summary>
        /// Constructor for Standard Animation.
        /// </summary>
        /// <param name="_animationMode">The animation mode.</param>
        /// <param name="_standardAnimation">The standard animation.</param>
        /// <param name="animationSpeed">The animation speed.</param>
        /// <param name="upperSpeedLimit">The upper speed limit.</param>
        /// <param name="lowerSpeedLimit">The lower speed limit.</param>
        /// <param name="delay">The delay.</param>
        /// <param name="control">The control.</param>
        /// <param name="standardSlideDelay">The standard slide delay.</param>
        /// <param name="standardSlugDelay">The standard slug delay.</param>
        /// <param name="standardHopDelay">The standard hop delay.</param>
        /// <param name="standardShootDelay">The standard shoot delay.</param>
        public ObjectAnimatorInput
            (ZeroitObjectAnimationMode _animationMode, 
            ZeroitObjectStandardAnimation _standardAnimation, 
            int animationSpeed, 
            int upperSpeedLimit, 
            int lowerSpeedLimit, 
            int delay,
            Control control,
            int standardSlideDelay, 
            int[] standardSlugDelay, 
            int standardHopDelay, 
            int standardShootDelay) :
            
            
            this(
                    ZeroitObjectColorAnimation.FillEllipse,
                    ZeroitObjectFormAnimation.FadeIn,
                    ZeroitObjectStandardAnimation.Hop,
                    ZeroitObjectAnimationMode.StandardAnimation,
                    Color.Orange,
                    false,
                    1,
                    10,
                    1,
                    200,
                    10,
                    50,
                    40,
                    new int[] { 100, 50 },
                    100,
                    50
                )
        {
            this._animationMode = _animationMode;
            this._standardAnimation = _standardAnimation;
            this.animationSpeed = animationSpeed;
            this.upperSpeedLimit = upperSpeedLimit;
            this.lowerSpeedLimit = lowerSpeedLimit;
            this.delay = delay;
            this.control = control;
            this.standardSlideDelay = standardSlideDelay;
            this.standardSlugDelay = standardSlugDelay;
            this.standardHopDelay = standardHopDelay;
            this.standardShootDelay = standardShootDelay;
        }

        /// <summary>
        /// Constructor for Form Animation.
        /// </summary>
        /// <param name="_animationMode">The animation mode.</param>
        /// <param name="_formAnimation">The form animation.</param>
        /// <param name="animationSpeed">The animation speed.</param>
        /// <param name="upperSpeedLimit">The upper speed limit.</param>
        /// <param name="lowerSpeedLimit">The lower speed limit.</param>
        /// <param name="delay">The delay.</param>
        /// <param name="formDelay">The form delay.</param>
        /// <param name="control">The control.</param>
        public ObjectAnimatorInput(
            
            ZeroitObjectAnimationMode _animationMode,
            ZeroitObjectFormAnimation _formAnimation,
            int animationSpeed,
            int upperSpeedLimit,
            int lowerSpeedLimit,
            int delay,
            int formDelay,
            Control control

            ) :
            this(
                    ZeroitObjectColorAnimation.FillEllipse,
                    ZeroitObjectFormAnimation.FadeIn,
                    ZeroitObjectStandardAnimation.Hop,
                    ZeroitObjectAnimationMode.FormAnimation,
                    Color.Orange,
                    false,
                    1,
                    10,
                    1,
                    200,
                    10,
                    50,
                    40,
                    new int[] { 100, 50 },
                    100,
                    50
                )
        {
            this._animationMode = _animationMode;
            this._formAnimation = _formAnimation;
            this.animationSpeed = animationSpeed;
            this.upperSpeedLimit = upperSpeedLimit;
            this.lowerSpeedLimit = lowerSpeedLimit;
            this.delay = delay;
            this.formDelay = formDelay;
            this.control = control;
        }

        /// <summary>
        /// Constructor for Color Animation.
        /// </summary>
        /// <param name="_animationMode">The animation mode.</param>
        /// <param name="_colorAnimation">The color animation.</param>
        /// <param name="animationSpeed">The animation speed.</param>
        /// <param name="upperSpeedLimit">The upper speed limit.</param>
        /// <param name="lowerSpeedLimit">The lower speed limit.</param>
        /// <param name="delay">The delay.</param>
        /// <param name="colorDelay">The color delay.</param>
        /// <param name="control">The control.</param>
        /// <param name="color">The color.</param>
        /// <param name="keepColor">if set to <c>true</c> [keep color].</param>
        public ObjectAnimatorInput(
            
            ZeroitObjectAnimationMode _animationMode,
            ZeroitObjectColorAnimation _colorAnimation,
            int animationSpeed,
            int upperSpeedLimit,
            int lowerSpeedLimit,
            int delay,
            int colorDelay,
            Control control,
            Color color,
            bool keepColor) :
            this(
                    ZeroitObjectColorAnimation.FillEllipse,
                    ZeroitObjectFormAnimation.FadeIn,
                    ZeroitObjectStandardAnimation.Hop,
                    ZeroitObjectAnimationMode.StandardAnimation,
                    Color.Orange,
                    false,
                    1,
                    10,
                    1,
                    200,
                    10,
                    50,
                    40,
                    new int[] { 100, 50 },
                    100,
                    50
                )
        {
            this._animationMode = _animationMode;
            this._colorAnimation = _colorAnimation;
            this.animationSpeed = animationSpeed;
            this.upperSpeedLimit = upperSpeedLimit;
            this.lowerSpeedLimit = lowerSpeedLimit;
            this.delay = delay;
            this.colorDelay = colorDelay;
            this.control = control;
            this.color = color;
            this.keepColor = keepColor;
        }


        #endregion

        #region Public Methods

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>ObjectAnimatorInput.</returns>
        public ObjectAnimatorInput Clone()
        {
            return new ObjectAnimatorInput(
            _colorAnimation,
            _formAnimation,
            _standardAnimation,
            _animationMode,
            color,
            keepColor,
            animationSpeed,
            upperSpeedLimit,
            lowerSpeedLimit,
            delay,
            colorDelay,
            formDelay,
            standardSlideDelay,
            standardSlugDelay,
            standardHopDelay,
            standardShootDelay
                );
        }

        /// <summary>
        /// Empties this instance.
        /// </summary>
        /// <returns>ObjectAnimatorInput.</returns>
        public static ObjectAnimatorInput Empty()
        {
            return new ObjectAnimatorInput();
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
                    else if (destinationType == typeof(InstanceDescriptor) && value is ObjectAnimatorInput)
                    {
                        ObjectAnimatorInput objectAnimatorInput = (ObjectAnimatorInput)value;

                        if (objectAnimatorInput.AnimationMode == ZeroitObjectAnimationMode.ColorAnimation)
                        {
                            ConstructorInfo ctor = typeof(ObjectAnimatorInput).GetConstructor(new Type[]
                            {
                                 
                                typeof(ZeroitObjectAnimationMode),
                                typeof(ZeroitObjectColorAnimation),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                typeof(Control),
                                typeof(Color),
                                typeof(bool)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {
                                    objectAnimatorInput._animationMode,
                                    objectAnimatorInput._colorAnimation,
                                    objectAnimatorInput.animationSpeed,
                                    objectAnimatorInput.upperSpeedLimit,
                                    objectAnimatorInput.lowerSpeedLimit,
                                    objectAnimatorInput.delay,
                                    objectAnimatorInput.colorDelay,
                                    objectAnimatorInput.control,
                                    objectAnimatorInput.color,
                                    objectAnimatorInput.keepColor

                                });
                            }
                        }

                        else if (objectAnimatorInput.AnimationMode == ZeroitObjectAnimationMode.FormAnimation)
                        {
                            ConstructorInfo ctor = typeof(ObjectAnimatorInput).GetConstructor(new Type[] {
                                
                                typeof(ZeroitObjectAnimationMode),
                                typeof(ZeroitObjectFormAnimation),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                typeof(Control),
                                

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    objectAnimatorInput._animationMode,
                                    objectAnimatorInput._formAnimation,
                                    objectAnimatorInput.animationSpeed,
                                    objectAnimatorInput.upperSpeedLimit,
                                    objectAnimatorInput.lowerSpeedLimit,
                                    objectAnimatorInput.delay,
                                    objectAnimatorInput.formDelay,
                                    objectAnimatorInput.control,
                                });
                            }
                        }
                        else if (objectAnimatorInput.AnimationMode == ZeroitObjectAnimationMode.StandardAnimation)
                        {
                            ConstructorInfo ctor = typeof(ObjectAnimatorInput).GetConstructor(new Type[] {

                                
                                typeof(ZeroitObjectAnimationMode),
                                typeof(ZeroitObjectStandardAnimation),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                typeof(Control),
                                typeof(int),
                                typeof(int[]),
                                typeof(int),
                                typeof(int),

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    

                                    objectAnimatorInput._animationMode,
                                    objectAnimatorInput._standardAnimation,
                                    objectAnimatorInput.animationSpeed,
                                    objectAnimatorInput.upperSpeedLimit,
                                    objectAnimatorInput.lowerSpeedLimit,
                                    objectAnimatorInput.delay,
                                    objectAnimatorInput.control,
                                    objectAnimatorInput.standardSlideDelay,
                                    objectAnimatorInput.standardSlugDelay,
                                    objectAnimatorInput.standardHopDelay,
                                    objectAnimatorInput.standardShootDelay,

                                });
                            }
                        }
                           

                        else
                        {
                            ConstructorInfo ctor = typeof(ObjectAnimatorInput).GetConstructor(Type.EmptyTypes);
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
