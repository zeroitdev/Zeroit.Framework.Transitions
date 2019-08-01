//// ***********************************************************************
//// Assembly         : Zeroit.Framework.Transitions
//// Author           : ZEROIT
//// Created          : 12-25-2018
////
//// Last Modified By : ZEROIT
//// Last Modified On : 12-25-2018
//// ***********************************************************************
//// <copyright file="DummyAnimator.cs" company="Zeroit Dev Technologies">
////    This program is for creating components to aid in Animating controls.
////    Copyright ©  2017  Zeroit Dev Technologies
////
////    This program is free software: you can redistribute it and/or modify
////    it under the terms of the GNU General Public License as published by
////    the Free Software Foundation, either version 3 of the License, or
////    (at your option) any later version.
////
////    This program is distributed in the hope that it will be useful,
////    but WITHOUT ANY WARRANTY; without even the implied warranty of
////    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
////    GNU General Public License for more details.
////
////    You should have received a copy of the GNU General Public License
////    along with this program.  If not, see <https://www.gnu.org/licenses/>.
////
////    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
//// </copyright>
//// <summary></summary>
//// ***********************************************************************

//using System;
//using System.ComponentModel;
//using System.Reflection;
//using System.Windows.Forms;

//namespace Zeroit.Framework.Transitions.SpecAnimator
//{
//    /// <summary>
//    /// Class ZeroitSpecDummyAnimator.
//    /// </summary>
//    /// <seealso cref="Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecAnimatorBase" />
//    public class ZeroitSpecDummyAnimator : ZeroitSpecAnimatorBase
//    {
//        /// <summary>
//        /// The start value
//        /// </summary>
//        private int _startValue = 0;
//        /// <summary>
//        /// The end value
//        /// </summary>
//        private int _endValue = 0;
//        /// <summary>
//        /// The default value
//        /// </summary>
//        private const int DEFAULT_VALUE = 0;
//        /// <summary>
//        /// The track bar
//        /// </summary>
//        private Control control = new Control();

        
//        string propertyName = "Value";

//        float value = 0;

//        /// <summary>
//        /// Initializes a new instance of the <see cref="ZeroitSpecValueAnimator"/> class.
//        /// </summary>
//        /// <param name="container">The container.</param>
//        public ZeroitSpecDummyAnimator(IContainer container)
//      : base(container)
//        {
//        }
        

//        /// <summary>
//        /// Initializes a new instance of the <see cref="ZeroitSpecValueAnimator"/> class.
//        /// </summary>
//        public ZeroitSpecDummyAnimator()
//        {

//            //Get the Type object corresponding to MyClass.
//            Type myType = control.GetType();

//            //Get the PropertyInfo object by passing the property name.
//            PropertyInfo myPropInfo = myType.GetProperty(control.GetType().GetProperty(propertyName).ToString());

//            control.GetType().GetProperty(propertyName).SetValue(control, Value);


//        }

//        public string PropertyName
//        {
//            get { return propertyName; }
//            set
//            {
//                propertyName = value;
//                control.Invalidate();
//            }
//        }

//        public float Value
//        {
//            get { return value; }
//            set
//            {
//                this.value = value;
//                control.Invalidate();
//            }
//        }

//        /// <summary>
//        /// Gets or sets the start track bar value.
//        /// </summary>
//        /// <value>The start track bar value.</value>
//        [Description("Gets or sets the starting Value for the animation.")]
//        [Browsable(true)]
//        [DefaultValue(0)]
//        [Category("Appearance")]
//        public int ControlStartValue
//        {
//            get
//            {
//                return this._startValue;
//            }
//            set
//            {
//                if (this._startValue == value)
//                    return;
//                this._startValue = value;
//                this.CheckValues();
//                this.OnStartValueChanged(EventArgs.Empty);
//            }
//        }

//        /// <summary>
//        /// Gets or sets the end track bar value.
//        /// </summary>
//        /// <value>The end track bar value.</value>
//        [Description("Gets or sets the ending Value for the animation.")]
//        [DefaultValue(0)]
//        [Category("Appearance")]
//        [Browsable(true)]
//        public int ControlEndValue
//        {
//            get
//            {
//                return this._endValue;
//            }
//            set
//            {
                
//                if (this._endValue == value)
//                    return;
//                this._endValue = value;
//                this.CheckValues();
//                this.OnEndValueChanged(EventArgs.Empty);
//            }
//        }

//        /// <summary>
//        /// Gets or sets the track bar.
//        /// </summary>
//        /// <value>The track bar.</value>
//        [DefaultValue(null)]
//        [Browsable(true)]
//        [Category("Behavior")]
//        [RefreshProperties(RefreshProperties.Repaint)]
//        [Description("Gets or sets which TrackBar should be animated.")]
//        public Control Control
//        {
//            get
//            {
//                return this.control;
//            }
//            set
//            {
//                if (this.control == value)
//                    return;
//                //if (this.control != null)
//                //    this.control.ValueChanged -= OnCurrentValueChanged;
//                this.control = value;
//                //if (this.control != null)
//                //    this.control.ValueChanged += OnCurrentValueChanged;
//                this.ResetValues();
//            }
//        }

//        /// <summary>
//        /// Gets or sets the current value internal.
//        /// </summary>
//        /// <value>The current value internal.</value>
//        protected override object CurrentValueInternal
//        {
//            get
//            {
//                return (object)(this.control == null ? 0 : control.GetType().GetProperty(propertyName).GetValue(Value));
//            }
//            set
//            {
//                if (this.control == null)
//                    return;

//                control.GetType().GetProperty(propertyName).SetValue(control, (int)value);

                
//            }
//        }

//        /// <summary>
//        /// Gets or sets the start value.
//        /// </summary>
//        /// <value>The start value.</value>
//        public override object StartValue
//        {
//            get
//            {
//                return (object)this.ControlStartValue;
//            }
//            set
//            {
//                this.ControlStartValue = (int)value;
//            }
//        }

//        /// <summary>
//        /// Gets or sets the end value.
//        /// </summary>
//        /// <value>The end value.</value>
//        public override object EndValue
//        {
//            get
//            {
//                return (object)this.ControlEndValue;
//            }
//            set
//            {
//                this.ControlEndValue = (int)value;
//            }
//        }

//        /// <summary>
//        /// Gets the value for step.
//        /// </summary>
//        /// <param name="step">The step.</param>
//        /// <returns>System.Object.</returns>
//        protected override object GetValueForStep(double step)
//        {
//            return (object)this.CheckValue(ZeroitSpecAnimatorBase.InterpolateIntegerValues(this._startValue, this._endValue, step));
//        }

//        /// <summary>
//        /// Handles the <see cref="E:CurrentValueChanged" /> event.
//        /// </summary>
//        /// <param name="sender">The sender.</param>
//        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
//        protected override void OnCurrentValueChanged(object sender, EventArgs e)
//        {
//            base.OnCurrentValueChanged(sender, e);
//            this.CheckValues();
//        }

//        /// <summary>
//        /// Checks the values.
//        /// </summary>
//        private void CheckValues()
//        {
//            this._startValue = this.CheckValue(this._startValue);
//            this._endValue = this.CheckValue(this._endValue);
//        }

//        /// <summary>
//        /// Checks the value.
//        /// </summary>
//        /// <param name="value">The value.</param>
//        /// <returns>System.Int32.</returns>
//        private int CheckValue(int value)
//        {
//            if (this.control == null)
//                return value;
//            if (value < (int)control.GetType().GetProperty("Minimum").GetValue(Convert.ToInt32(Value)))
//                value = (int)control.GetType().GetProperty("Minimum").GetValue(Convert.ToInt32(Value));
//            else if (value > (int)control.GetType().GetProperty("Maximum").GetValue(Convert.ToInt32(Value)))
//                value = (int)control.GetType().GetProperty("Minimum").GetValue(Convert.ToInt32(Value));
//            return value;
//        }

        
//    }
//}
