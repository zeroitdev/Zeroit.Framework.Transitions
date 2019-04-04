// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ZeroitTransitionInput.cs" company="Zeroit Dev Technologies">
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
using Zeroit.Framework.Transitions.ZeroitAnimateTransitionWithEditor;

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    /// Class ZeroitTransitionInput.
    /// </summary>
    [TypeConverter(typeof(ZeroitTransitionInput.ZeroitTransitionInputConverter))]
    [Editor(typeof(ZeroitTransitionAnimatorEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public class ZeroitTransitionInput
    {

        #region Private Fields
        /// <summary>
        /// The transition
        /// </summary>
        private ZeroitTransitorEdit.TransitionType _Transition = ZeroitTransitorEdit.TransitionType.Accelaration;
        /// <summary>
        /// The destination
        /// </summary>
        private int _destination = 0;
        /// <summary>
        /// The position
        /// </summary>
        private ZeroitTransitorEdit.Positions _Position = ZeroitTransitorEdit.Positions.Left;
        /// <summary>
        /// The transition time
        /// </summary>
        private int _TransitionTime = 2000;
        /// <summary>
        /// The no of flashes
        /// </summary>
        private int _No_Of_Flashes = 1;
        /// <summary>
        /// The target
        /// </summary>
        private Control _Target;

        /// <summary>
        /// The dummy int
        /// </summary>
        private int dummy_int = 0;
        /// <summary>
        /// The dummy float
        /// </summary>
        private float dummy_float = 0;
        /// <summary>
        /// The dummy double
        /// </summary>
        private double dummy_double = 0;
        /// <summary>
        /// The dummy decimal
        /// </summary>
        private decimal dummy_decimal = 0;
        /// <summary>
        /// The dummy long
        /// </summary>
        private long dummy_long = 0;
        /// <summary>
        /// The dummy string
        /// </summary>
        private string dummy_string = "";
        /// <summary>
        /// The dummy bool
        /// </summary>
        private bool dummy_bool = false;


        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the transitions.
        /// </summary>
        /// <value>The transitions.</value>
        public ZeroitTransitorEdit.TransitionType Transitions
        {
            get { return _Transition; }
            set
            {
                _Transition = value;
            }
        }

        /// <summary>
        /// Gets or sets the target.
        /// </summary>
        /// <value>The target.</value>
        public Control Target
        {
            get { return _Target; }
            set
            {
                _Target = value;

            }
        }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>The position.</value>
        public ZeroitTransitorEdit.Positions Position
        {
            get { return _Position; }
            set
            {
                _Position = value;
            }
        }

        /// <summary>
        /// Gets or sets the destination.
        /// </summary>
        /// <value>The destination.</value>
        public Int32 Destination
        {
            get { return _destination; }
            set
            {
                _destination = value;
            }
        }

        /// <summary>
        /// Gets or sets the transition time.
        /// </summary>
        /// <value>The transition time.</value>
        public Int32 TransitionTime
        {
            get { return _TransitionTime; }
            set
            {
                _TransitionTime = value;
            }
        }

        /// <summary>
        /// Gets or sets the no of flashes.
        /// </summary>
        /// <value>The no of flashes.</value>
        public Int32 No_Of_Flashes
        {
            get { return _No_Of_Flashes; }
            set
            {
                _No_Of_Flashes = value;
            }
        }

        #endregion

        #region Constructor

        // Internal Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitTransitionInput"/> class.
        /// </summary>
        /// <param name="_Transition">The transition.</param>
        /// <param name="_destination">The destination.</param>
        /// <param name="_Position">The position.</param>
        /// <param name="_TransitionTime">The transition time.</param>
        /// <param name="_No_Of_Flashes">The no of flashes.</param>
        public ZeroitTransitionInput(
            ZeroitTransitorEdit.TransitionType _Transition,
            int _destination,
            ZeroitTransitorEdit.Positions _Position,
            int _TransitionTime,
            int _No_Of_Flashes
            )
        {
            this._Transition = _Transition;
            this._destination = _destination;
            this._Position = _Position;
            this._TransitionTime = _TransitionTime;
            this._No_Of_Flashes = _No_Of_Flashes;

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitTransitionInput"/> class.
        /// </summary>
        public ZeroitTransitionInput() : this(ZeroitTransitorEdit.TransitionType.Accelaration, 0,
            ZeroitTransitorEdit.Positions.Left, 2000, 1)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitTransitionInput"/> class.
        /// </summary>
        /// <param name="Accelaration">The accelaration.</param>
        /// <param name="_destination">The destination.</param>
        /// <param name="_Position">The position.</param>
        /// <param name="_TransitionTime">The transition time.</param>
        /// <param name="_No_Of_Flashes">The no of flashes.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        public ZeroitTransitionInput(
            ZeroitTransitorEdit.TransitionType Accelaration,
            int _destination,
            ZeroitTransitorEdit.Positions _Position,
            int _TransitionTime,
            int _No_Of_Flashes,
            Control _Target,
            int dummy
            ) : this(ZeroitTransitorEdit.TransitionType.Accelaration, 0,
            ZeroitTransitorEdit.Positions.Left, 2000, 1)
        {
            this._Transition = Accelaration;
            this._destination = _destination;
            this._Position = _Position;
            this._TransitionTime = _TransitionTime;
            this._No_Of_Flashes = _No_Of_Flashes;
            this._Target = _Target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitTransitionInput"/> class.
        /// </summary>
        /// <param name="Bounce">The bounce.</param>
        /// <param name="_destination">The destination.</param>
        /// <param name="_Position">The position.</param>
        /// <param name="_TransitionTime">The transition time.</param>
        /// <param name="_No_Of_Flashes">The no of flashes.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        public ZeroitTransitionInput(
            ZeroitTransitorEdit.TransitionType Bounce,
            int _destination,
            ZeroitTransitorEdit.Positions _Position,
            int _TransitionTime,
            int _No_Of_Flashes,
            Control _Target,
            float dummy
        ) : this(ZeroitTransitorEdit.TransitionType.Bounce, 0,
            ZeroitTransitorEdit.Positions.Left, 2000, 1)
        {
            this._Transition = Bounce;
            this._destination = _destination;
            this._Position = _Position;
            this._TransitionTime = _TransitionTime;
            this._No_Of_Flashes = _No_Of_Flashes;
            this._Target = _Target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitTransitionInput"/> class.
        /// </summary>
        /// <param name="CriticalDamping">The critical damping.</param>
        /// <param name="_destination">The destination.</param>
        /// <param name="_Position">The position.</param>
        /// <param name="_TransitionTime">The transition time.</param>
        /// <param name="_No_Of_Flashes">The no of flashes.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        public ZeroitTransitionInput(
            ZeroitTransitorEdit.TransitionType CriticalDamping,
            int _destination,
            ZeroitTransitorEdit.Positions _Position,
            int _TransitionTime,
            int _No_Of_Flashes,
            Control _Target,
            double dummy
        ) : this(ZeroitTransitorEdit.TransitionType.CriticalDamping, 0,
            ZeroitTransitorEdit.Positions.Left, 2000, 1)
        {
            this._Transition = CriticalDamping;
            this._destination = _destination;
            this._Position = _Position;
            this._TransitionTime = _TransitionTime;
            this._No_Of_Flashes = _No_Of_Flashes;
            this._Target = _Target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitTransitionInput"/> class.
        /// </summary>
        /// <param name="Deceleration">The deceleration.</param>
        /// <param name="_destination">The destination.</param>
        /// <param name="_Position">The position.</param>
        /// <param name="_TransitionTime">The transition time.</param>
        /// <param name="_No_Of_Flashes">The no of flashes.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        public ZeroitTransitionInput(
            ZeroitTransitorEdit.TransitionType Deceleration,
            int _destination,
            ZeroitTransitorEdit.Positions _Position,
            int _TransitionTime,
            int _No_Of_Flashes,
            Control _Target,
            decimal dummy
        ) : this(ZeroitTransitorEdit.TransitionType.Deceleration, 0,
            ZeroitTransitorEdit.Positions.Left, 2000, 1)
        {
            this._Transition = Deceleration;
            this._destination = _destination;
            this._Position = _Position;
            this._TransitionTime = _TransitionTime;
            this._No_Of_Flashes = _No_Of_Flashes;
            this._Target = _Target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitTransitionInput"/> class.
        /// </summary>
        /// <param name="EaseInEaseOut">The ease in ease out.</param>
        /// <param name="_destination">The destination.</param>
        /// <param name="_Position">The position.</param>
        /// <param name="_TransitionTime">The transition time.</param>
        /// <param name="_No_Of_Flashes">The no of flashes.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        public ZeroitTransitionInput(
            ZeroitTransitorEdit.TransitionType EaseInEaseOut,
            int _destination,
            ZeroitTransitorEdit.Positions _Position,
            int _TransitionTime,
            int _No_Of_Flashes,
            Control _Target,
            long dummy
        ) : this(ZeroitTransitorEdit.TransitionType.EaseInEaseOut, 0,
            ZeroitTransitorEdit.Positions.Left, 2000, 1)
        {
            this._Transition = EaseInEaseOut;
            this._destination = _destination;
            this._Position = _Position;
            this._TransitionTime = _TransitionTime;
            this._No_Of_Flashes = _No_Of_Flashes;
            this._Target = _Target;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitTransitionInput"/> class.
        /// </summary>
        /// <param name="Flash">The flash.</param>
        /// <param name="_destination">The destination.</param>
        /// <param name="_Position">The position.</param>
        /// <param name="_TransitionTime">The transition time.</param>
        /// <param name="_No_Of_Flashes">The no of flashes.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        public ZeroitTransitionInput(
            ZeroitTransitorEdit.TransitionType Flash,
            int _destination,
            ZeroitTransitorEdit.Positions _Position,
            int _TransitionTime,
            int _No_Of_Flashes,
            Control _Target,
            string dummy
        ) : this(ZeroitTransitorEdit.TransitionType.Flash, 0,
            ZeroitTransitorEdit.Positions.Left, 2000, 1)
        {
            this._Transition = Flash;
            this._destination = _destination;
            this._Position = _Position;
            this._TransitionTime = _TransitionTime;
            this._No_Of_Flashes = _No_Of_Flashes;
            this._Target = _Target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitTransitionInput"/> class.
        /// </summary>
        /// <param name="Linear">The linear.</param>
        /// <param name="_destination">The destination.</param>
        /// <param name="_Position">The position.</param>
        /// <param name="_TransitionTime">The transition time.</param>
        /// <param name="_No_Of_Flashes">The no of flashes.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">if set to <c>true</c> [dummy].</param>
        public ZeroitTransitionInput(
            ZeroitTransitorEdit.TransitionType Linear,
            int _destination,
            ZeroitTransitorEdit.Positions _Position,
            int _TransitionTime,
            int _No_Of_Flashes,
            Control _Target,
            bool dummy
        ) : this(ZeroitTransitorEdit.TransitionType.Linear, 0,
            ZeroitTransitorEdit.Positions.Left, 2000, 1)
        {
            this._Transition = Linear;
            this._destination = _destination;
            this._Position = _Position;
            this._TransitionTime = _TransitionTime;
            this._No_Of_Flashes = _No_Of_Flashes;
            this._Target = _Target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitTransitionInput"/> class.
        /// </summary>
        /// <param name="ThrowAndCatch">The throw and catch.</param>
        /// <param name="_destination">The destination.</param>
        /// <param name="_Position">The position.</param>
        /// <param name="_TransitionTime">The transition time.</param>
        /// <param name="_No_Of_Flashes">The no of flashes.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public ZeroitTransitionInput(
            ZeroitTransitorEdit.TransitionType ThrowAndCatch,
            int _destination,
            ZeroitTransitorEdit.Positions _Position,
            int _TransitionTime,
            int _No_Of_Flashes,
            Control _Target,
            int dummy, int dummy1
        ) : this(ZeroitTransitorEdit.TransitionType.ThrowAndCatch, 0,
            ZeroitTransitorEdit.Positions.Left, 2000, 1)
        {
            this._Transition = ThrowAndCatch;
            this._destination = _destination;
            this._Position = _Position;
            this._TransitionTime = _TransitionTime;
            this._No_Of_Flashes = _No_Of_Flashes;
            this._Target = _Target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitTransitionInput"/> class.
        /// </summary>
        /// <param name="Zeroit">The zeroit.</param>
        /// <param name="_destination">The destination.</param>
        /// <param name="_Position">The position.</param>
        /// <param name="_TransitionTime">The transition time.</param>
        /// <param name="_No_Of_Flashes">The no of flashes.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public ZeroitTransitionInput(
            ZeroitTransitorEdit.TransitionType Zeroit,
            int _destination,
            ZeroitTransitorEdit.Positions _Position,
            int _TransitionTime,
            int _No_Of_Flashes,
            Control _Target,
            int dummy, float dummy1
        ) : this(ZeroitTransitorEdit.TransitionType.Zeroit, 0,
            ZeroitTransitorEdit.Positions.Left, 2000, 1)
        {
            this._Transition = Zeroit;
            this._destination = _destination;
            this._Position = _Position;
            this._TransitionTime = _TransitionTime;
            this._No_Of_Flashes = _No_Of_Flashes;
            this._Target = _Target;
        }


        #endregion

        #region Public Methods

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>ZeroitTransitionInput.</returns>
        public ZeroitTransitionInput Clone()
        {
            return new ZeroitTransitionInput(
                 _Transition,
            _destination,
                _Position,
             _TransitionTime,
            _No_Of_Flashes
            );
        }

        /// <summary>
        /// Empties this instance.
        /// </summary>
        /// <returns>ZeroitTransitionInput.</returns>
        public static ZeroitTransitionInput Empty()
        {
            return new ZeroitTransitionInput();
        }


        #endregion


        #region Converter

        /// <summary>
        /// Class ZeroitTransitionInputConverter.
        /// </summary>
        /// <seealso cref="System.ComponentModel.TypeConverter" />
        internal class ZeroitTransitionInputConverter : TypeConverter
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


                    else if (destinationType == typeof(InstanceDescriptor) && value is ZeroitTransitionInput)
                    {
                        ZeroitTransitionInput zeroitTransitionInput = (ZeroitTransitionInput)value;

                        if (zeroitTransitionInput.Transitions == ZeroitTransitorEdit.TransitionType.Accelaration)
                        {
                            ConstructorInfo ctor = typeof(ZeroitTransitionInput).GetConstructor(new Type[]
                            {

                                
                                typeof(ZeroitTransitorEdit.TransitionType),
                                typeof(int),
                                typeof(ZeroitTransitorEdit.Positions),
                                typeof(int),
                                typeof(int),
                                typeof(Control),
                                typeof(int)



                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    

                                    zeroitTransitionInput._Transition,
                                    zeroitTransitionInput._destination,
                                    zeroitTransitionInput._Position,
                                    zeroitTransitionInput._TransitionTime,
                                    zeroitTransitionInput._No_Of_Flashes,
                                    zeroitTransitionInput._Target,
                                    zeroitTransitionInput.dummy_int


                                });
                            }
                        }

                        else if (zeroitTransitionInput.Transitions == ZeroitTransitorEdit.TransitionType.Bounce)
                        {
                            ConstructorInfo ctor = typeof(ZeroitTransitionInput).GetConstructor(new Type[] {


                                typeof(ZeroitTransitorEdit.TransitionType),
                                typeof(int),
                                typeof(ZeroitTransitorEdit.Positions),
                                typeof(int),
                                typeof(int),
                                typeof(Control),
                                typeof(float)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {
                                    zeroitTransitionInput._Transition,
                                    zeroitTransitionInput._destination,
                                    zeroitTransitionInput._Position,
                                    zeroitTransitionInput._TransitionTime,
                                    zeroitTransitionInput._No_Of_Flashes,
                                    zeroitTransitionInput._Target,
                                    zeroitTransitionInput.dummy_float

                                });
                            }
                        }
                        else if (zeroitTransitionInput.Transitions == ZeroitTransitorEdit.TransitionType.CriticalDamping)
                        {
                            ConstructorInfo ctor = typeof(ZeroitTransitionInput).GetConstructor(new Type[] {


                                typeof(ZeroitTransitorEdit.TransitionType),
                                typeof(int),
                                typeof(ZeroitTransitorEdit.Positions),
                                typeof(int),
                                typeof(int),
                                typeof(Control),
                                typeof(double)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    zeroitTransitionInput._Transition,
                                    zeroitTransitionInput._destination,
                                    zeroitTransitionInput._Position,
                                    zeroitTransitionInput._TransitionTime,
                                    zeroitTransitionInput._No_Of_Flashes,
                                    zeroitTransitionInput._Target,
                                    zeroitTransitionInput.dummy_double

                            });
                            }
                        }

                        else if (zeroitTransitionInput.Transitions == ZeroitTransitorEdit.TransitionType.Deceleration)
                        {
                            ConstructorInfo ctor = typeof(ZeroitTransitionInput).GetConstructor(new Type[] {


                                typeof(ZeroitTransitorEdit.TransitionType),
                                typeof(int),
                                typeof(ZeroitTransitorEdit.Positions),
                                typeof(int),
                                typeof(int),
                                typeof(Control),
                                typeof(decimal)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    zeroitTransitionInput._Transition,
                                    zeroitTransitionInput._destination,
                                    zeroitTransitionInput._Position,
                                    zeroitTransitionInput._TransitionTime,
                                    zeroitTransitionInput._No_Of_Flashes,
                                    zeroitTransitionInput._Target,
                                    zeroitTransitionInput.dummy_decimal

                            });
                            }
                        }


                        else if (zeroitTransitionInput.Transitions == ZeroitTransitorEdit.TransitionType.EaseInEaseOut)
                        {
                            ConstructorInfo ctor = typeof(ZeroitTransitionInput).GetConstructor(new Type[] {


                                typeof(ZeroitTransitorEdit.TransitionType),
                                typeof(int),
                                typeof(ZeroitTransitorEdit.Positions),
                                typeof(int),
                                typeof(int),
                                typeof(Control),
                                typeof(long)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    zeroitTransitionInput._Transition,
                                    zeroitTransitionInput._destination,
                                    zeroitTransitionInput._Position,
                                    zeroitTransitionInput._TransitionTime,
                                    zeroitTransitionInput._No_Of_Flashes,
                                    zeroitTransitionInput._Target,
                                    zeroitTransitionInput.dummy_long

                                });
                            }
                        }

                        else if (zeroitTransitionInput.Transitions == ZeroitTransitorEdit.TransitionType.Flash)
                        {
                            ConstructorInfo ctor = typeof(ZeroitTransitionInput).GetConstructor(new Type[] {

                                typeof(ZeroitTransitorEdit.TransitionType),
                                typeof(int),
                                typeof(ZeroitTransitorEdit.Positions),
                                typeof(int),
                                typeof(int),
                                typeof(Control),
                                typeof(string)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    zeroitTransitionInput._Transition,
                                    zeroitTransitionInput._destination,
                                    zeroitTransitionInput._Position,
                                    zeroitTransitionInput._TransitionTime,
                                    zeroitTransitionInput._No_Of_Flashes,
                                    zeroitTransitionInput._Target,
                                    zeroitTransitionInput.dummy_string

                                });
                            }
                        }

                        else if (zeroitTransitionInput.Transitions == ZeroitTransitorEdit.TransitionType.Linear)
                        {
                            ConstructorInfo ctor = typeof(ZeroitTransitionInput).GetConstructor(new Type[] {

                                typeof(ZeroitTransitorEdit.TransitionType),
                                typeof(int),
                                typeof(ZeroitTransitorEdit.Positions),
                                typeof(int),
                                typeof(int),
                                typeof(Control),
                                typeof(bool)


                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    zeroitTransitionInput._Transition,
                                    zeroitTransitionInput._destination,
                                    zeroitTransitionInput._Position,
                                    zeroitTransitionInput._TransitionTime,
                                    zeroitTransitionInput._No_Of_Flashes,
                                    zeroitTransitionInput._Target,
                                    zeroitTransitionInput.dummy_bool


                                });
                            }
                        }

                        else if (zeroitTransitionInput.Transitions == ZeroitTransitorEdit.TransitionType.ThrowAndCatch)
                        {
                            ConstructorInfo ctor = typeof(ZeroitTransitionInput).GetConstructor(new Type[] {


                                typeof(ZeroitTransitorEdit.TransitionType),
                                typeof(int),
                                typeof(ZeroitTransitorEdit.Positions),
                                typeof(int),
                                typeof(int),
                                typeof(Control),
                                typeof(int),
                                typeof(int)


                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    zeroitTransitionInput._Transition,
                                    zeroitTransitionInput._destination,
                                    zeroitTransitionInput._Position,
                                    zeroitTransitionInput._TransitionTime,
                                    zeroitTransitionInput._No_Of_Flashes,
                                    zeroitTransitionInput._Target,
                                    zeroitTransitionInput.dummy_int,
                                    zeroitTransitionInput.dummy_int

                                });
                            }
                        }

                        else if (zeroitTransitionInput.Transitions == ZeroitTransitorEdit.TransitionType.Zeroit)
                        {
                            ConstructorInfo ctor = typeof(ZeroitTransitionInput).GetConstructor(new Type[] {


                                typeof(ZeroitTransitorEdit.TransitionType),
                                typeof(int),
                                typeof(ZeroitTransitorEdit.Positions),
                                typeof(int),
                                typeof(int),
                                typeof(Control),
                                typeof(int),
                                typeof(float)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    zeroitTransitionInput._Transition,
                                    zeroitTransitionInput._destination,
                                    zeroitTransitionInput._Position,
                                    zeroitTransitionInput._TransitionTime,
                                    zeroitTransitionInput._No_Of_Flashes,
                                    zeroitTransitionInput._Target,
                                    zeroitTransitionInput.dummy_int,
                                    zeroitTransitionInput.dummy_float


                                });
                            }
                        }

                        else
                        {
                            ConstructorInfo ctor = typeof(ZeroitTransitionInput).GetConstructor(Type.EmptyTypes);
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
