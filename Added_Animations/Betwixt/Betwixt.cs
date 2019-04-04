// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Betwixt.cs" company="Zeroit Dev Technologies">
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
using System.Reflection;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.Betwixt
{

    /// <summary>
    /// Enum EasingAnimations
    /// </summary>
    public enum EasingAnimations
    {
        /// <summary>
        /// The back in
        /// </summary>
        BackIn,
        /// <summary>
        /// The back out
        /// </summary>
        BackOut,
        /// <summary>
        /// The back in out
        /// </summary>
        BackInOut,
        /// <summary>
        /// The bounce in
        /// </summary>
        BounceIn,
        /// <summary>
        /// The bounce out
        /// </summary>
        BounceOut,
        /// <summary>
        /// The bounce in out
        /// </summary>
        BounceInOut,
        /// <summary>
        /// The circ in
        /// </summary>
        CircIn,
        /// <summary>
        /// The circ out
        /// </summary>
        CircOut,
        /// <summary>
        /// The circ in out
        /// </summary>
        CircInOut,
        /// <summary>
        /// The cubic in
        /// </summary>
        CubicIn,
        /// <summary>
        /// The cubic out
        /// </summary>
        CubicOut,
        /// <summary>
        /// The cubic in out
        /// </summary>
        CubicInOut,
        /// <summary>
        /// The elastic in
        /// </summary>
        ElasticIn,
        /// <summary>
        /// The elastic out
        /// </summary>
        ElasticOut,
        /// <summary>
        /// The elastic in out
        /// </summary>
        ElasticInOut,
        /// <summary>
        /// The expo in
        /// </summary>
        ExpoIn,
        /// <summary>
        /// The expo out
        /// </summary>
        ExpoOut,
        /// <summary>
        /// The expo in out
        /// </summary>
        ExpoInOut,
        /// <summary>
        /// The quad in
        /// </summary>
        QuadIn,
        /// <summary>
        /// The quad out
        /// </summary>
        QuadOut,
        /// <summary>
        /// The quad in out
        /// </summary>
        QuadInOut,
        /// <summary>
        /// The quart in
        /// </summary>
        QuartIn,
        /// <summary>
        /// The quart out
        /// </summary>
        QuartOut,
        /// <summary>
        /// The quart in out
        /// </summary>
        QuartInOut,
        /// <summary>
        /// The quint in
        /// </summary>
        QuintIn,
        /// <summary>
        /// The quint out
        /// </summary>
        QuintOut,
        /// <summary>
        /// The quint in out
        /// </summary>
        QuintInOut,
        /// <summary>
        /// The sine in
        /// </summary>
        SineIn,
        /// <summary>
        /// The sine out
        /// </summary>
        SineOut,
        /// <summary>
        /// The sine in out
        /// </summary>
        SineInOut,
        /// <summary>
        /// The linear
        /// </summary>
        Linear
    }

    /// <summary>
    /// Enum animatedProperty
    /// </summary>
    public enum animatedProperty
    {
        /// <summary>
        /// The back color
        /// </summary>
        BackColor,
        /// <summary>
        /// The size
        /// </summary>
        Size,
        /// <summary>
        /// The location
        /// </summary>
        Location,
        /// <summary>
        /// The value
        /// </summary>
        Value,
        /// <summary>
        /// The custom
        /// </summary>
        Custom
    }

    /// <summary>
    /// Class ZeroitEastTweener.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    [ToolboxItem(false)]
    public class ZeroitEastTweener : Component
    {


        #region Private Fields

        /// <summary>
        /// The easing animations
        /// </summary>
        private EasingAnimations easingAnimations = EasingAnimations.BounceInOut;

        /// <summary>
        /// The animated property
        /// </summary>
        private animatedProperty animatedProperty = animatedProperty.Value;

        /// <summary>
        /// The control
        /// </summary>
        private Control control = new Control();

        /// <summary>
        /// The start
        /// </summary>
        private float start = 0f;
        /// <summary>
        /// The end
        /// </summary>
        private float end = 10f;
        /// <summary>
        /// The duration
        /// </summary>
        private float duration = 2f;

        /// <summary>
        /// The delta time
        /// </summary>
        private float deltaTime = 1f;

        /// <summary>
        /// The property name
        /// </summary>
        private string propertyName = "";

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the easing.
        /// </summary>
        /// <value>The easing.</value>
        public EasingAnimations Easing
        {
            get { return easingAnimations; }
            set
            {
                easingAnimations = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the animated property.
        /// </summary>
        /// <value>The animated property.</value>
        public animatedProperty AnimatedProperty
        {
            get { return animatedProperty; }
            set
            {
                animatedProperty = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the start value.
        /// </summary>
        /// <value>The start value.</value>
        public float StartValue
        {
            get { return start; }
            set
            {
                start = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the end value.
        /// </summary>
        /// <value>The end value.</value>
        public float EndValue
        {
            get { return end; }
            set
            {
                end = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        /// <value>The duration.</value>
        public float Duration
        {
            get { return duration; }
            set
            {
                duration = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the delta time.
        /// </summary>
        /// <value>The delta time.</value>
        public float DeltaTime
        {
            get { return deltaTime; }
            set
            {
                deltaTime = value;
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
        /// Gets or sets the name of the property.
        /// </summary>
        /// <value>The name of the property.</value>
        public string PropertyName
        {
            get { return propertyName; }
            set
            {
                propertyName = value;
                control.Invalidate();
            }
        }

        #endregion

        /// <summary>
        /// Starts this instance.
        /// </summary>
        public void Start()
        {

            //Get the Type object corresponding to MyClass.
            Type myType = control.GetType();
            
            //Get the PropertyInfo object by passing the property name.
            PropertyInfo myPropInfo = myType.GetProperty(control.GetType().GetProperty(propertyName).ToString());



            if (control.GetType().Equals(typeof(int)))
            {
                // Initialisation
                Tweener<int> tweener_int = new Tweener<int>((int)start, (int)end, duration, EasingFuction());

                // Update
                tweener_int.Update(deltaTime);

                control.GetType().GetProperty(propertyName).SetValue(control, tweener_int.Value);


                //myPropInfo.GetValue(tweener_int.Value);
            }
            //myPropInfo.PropertyType == typeof(double)
            if (control.GetType().Equals(typeof(double)))
            {
                // Initialisation
                Tweener<double> tweener_double = new Tweener<double>(start, end, duration, EasingFuction());

                // Update
                tweener_double.Update(deltaTime);

                control.GetType().GetProperty(propertyName).SetValue(control, tweener_double.Value);


                //myPropInfo.GetValue(tweener_double.Value);
            }

            else if (control.GetType().Equals(typeof(ulong)))
            {
                // Initialisation
                Tweener<ulong> tweener_ulong = new Tweener<ulong>((ulong)start, (ulong)end, duration, EasingFuction());

                // Update
                tweener_ulong.Update(deltaTime);

                control.GetType().GetProperty(propertyName).SetValue(control, tweener_ulong.Value);


                //myPropInfo.GetValue(tweener_ulong.Value);
            }

            else if (control.GetType().Equals(typeof(decimal)))
            {
                // Initialisation
                Tweener<decimal> tweener_decimal = new Tweener<decimal>((decimal)start, (decimal)end, duration, EasingFuction());

                // Update
                tweener_decimal.Update(deltaTime);

                control.GetType().GetProperty(propertyName).SetValue(control, tweener_decimal.Value);


                //myPropInfo.GetValue(tweener_decimal.Value);
            }

            else if (control.GetType().Equals(typeof(byte)))
            {
                // Initialisation
                Tweener<byte> tweener_byte = new Tweener<byte>((byte)start, (byte)end, duration, EasingFuction());

                // Update
                tweener_byte.Update(deltaTime);

                control.GetType().GetProperty(propertyName).SetValue(control, tweener_byte.Value);


                //myPropInfo.GetValue(tweener_byte.Value);
            }

            else if (control.GetType().Equals(typeof(long)))
            {
                // Initialisation
                Tweener<long> tweener_long = new Tweener<long>((long)start, (long)end, duration, EasingFuction());

                // Update
                tweener_long.Update(deltaTime);

                control.GetType().GetProperty(propertyName).SetValue(control, tweener_long.Value);


                //myPropInfo.GetValue(tweener_long.Value);
            }

            else if (control.GetType().Equals(typeof(Single)))
            {
                // Initialisation
                Tweener<Single> tweener_single = new Tweener<Single>(start, end, duration, EasingFuction());

                // Update
                tweener_single.Update(deltaTime);

                control.GetType().GetProperty(propertyName).SetValue(control, tweener_single.Value);


                //myPropInfo.GetValue(tweener_long.Value);
            }

            else
            {
                // Initialisation
                Tweener<float> tweener_float = new Tweener<float>(start, end, duration, EasingFuction());

                // Update
                tweener_float.Update(deltaTime);

                control.GetType().GetProperty(propertyName).SetValue(control, Convert.ToInt32(tweener_float.Value));

                //myPropInfo.GetValue(tweener_float.Value);
            }

            
            
            // Anywhere
            //float newValue = tweener.Value;
            
        }

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        public void Size()
        {
            
        }
        /// <summary>
        /// Locations this instance.
        /// </summary>
        public void Location()
        {
            
        }

        /// <summary>
        /// Texts this instance.
        /// </summary>
        public void Text()
        {
            
        }

        /// <summary>
        /// Easings the fuction.
        /// </summary>
        /// <returns>EaseFunc.</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public EaseFunc EasingFuction()
        {
            switch (easingAnimations)
            {
                case EasingAnimations.BackIn:
                    return  Ease.Back.In;
                    break;
                case EasingAnimations.BackOut:
                    
                    return Ease.Back.Out;
                    break;
                case EasingAnimations.BackInOut:
                    return Ease.Back.InOut;

                    break;
                case EasingAnimations.BounceIn:
                    return Ease.Bounce.In;
                    
                    break;
                case EasingAnimations.BounceOut:
                    
                    return Ease.Bounce.Out;
                    break;
                case EasingAnimations.BounceInOut:
                    return Ease.Bounce.InOut;

                    break;
                case EasingAnimations.CircIn:
                    return Ease.Circ.In;
                    
                    break;
                case EasingAnimations.CircOut:
                    
                    return Ease.Circ.Out;
                    break;
                case EasingAnimations.CircInOut:
                    return Ease.Circ.InOut;
                    break;
                case EasingAnimations.CubicIn:
                    return Ease.Cubic.In;
                    
                    break;
                case EasingAnimations.CubicOut:
                    
                    return Ease.Cubic.Out;
                    break;
                case EasingAnimations.CubicInOut:
                    return Ease.Cubic.InOut;

                    break;
                case EasingAnimations.ElasticIn:
                    return Ease.Elastic.In;
                    
                    break;
                case EasingAnimations.ElasticOut:
                    
                    return Ease.Elastic.Out;
                    break;
                case EasingAnimations.ElasticInOut:
                    return Ease.Elastic.InOut;
                    break;
                case EasingAnimations.ExpoIn:
                    return Ease.Expo.In;
                    
                    break;
                case EasingAnimations.ExpoOut:
                    
                    return Ease.Expo.Out;
                    break;
                case EasingAnimations.ExpoInOut:
                    return Ease.Expo.InOut;
                    break;
                case EasingAnimations.QuadIn:
                    return Ease.Quad.In;
                    
                    break;
                case EasingAnimations.QuadOut:
                    
                    return Ease.Quad.Out;
                    break;
                case EasingAnimations.QuadInOut:
                    return Ease.Quad.InOut;
                    break;
                case EasingAnimations.QuartIn:
                    return Ease.Quart.In;
                    
                    break;
                case EasingAnimations.QuartOut:
                    
                    return Ease.Quart.Out;
                    break;
                case EasingAnimations.QuartInOut:
                    return Ease.Quart.InOut;
                    break;
                case EasingAnimations.QuintIn:
                    return Ease.Quint.In;
                    
                    break;
                case EasingAnimations.QuintOut:
                    
                    return Ease.Quint.Out;
                    break;
                case EasingAnimations.QuintInOut:
                    return Ease.Quint.InOut;
                    break;
                case EasingAnimations.SineIn:
                    return Ease.Sine.In;
                    
                    break;
                case EasingAnimations.SineOut:
                    
                    return Ease.Sine.Out;
                    break;
                case EasingAnimations.SineInOut:
                    return Ease.Sine.InOut;
                    break;
                case EasingAnimations.Linear:
                    return Ease.Linear;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            

            

            




        }
    }
}
