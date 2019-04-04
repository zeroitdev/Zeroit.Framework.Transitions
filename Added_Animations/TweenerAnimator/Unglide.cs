// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Unglide.cs" company="Zeroit Dev Technologies">
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
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.TweenerAnimator
{

    /// <summary>
    /// Class UnglideInfo.
    /// </summary>
    internal class UnglideInfo
    {
        /// <summary>
        /// Initializes static members of the <see cref="UnglideInfo"/> class.
        /// </summary>
        static UnglideInfo()
        {
            NumericTypes = new[] {
                typeof(Int16),
                typeof(Int32),
                typeof(Int64),
                typeof(UInt16),
                typeof(UInt32),
                typeof(UInt64),
                typeof(Single),
                typeof(Double)
            };
        }

        /// <summary>
        /// The numeric types
        /// </summary>
        private static readonly Type[] NumericTypes;

        /// <summary>
        /// The field
        /// </summary>
        private readonly FieldInfo _field;
        /// <summary>
        /// The property
        /// </summary>
        private readonly PropertyInfo _prop;
        /// <summary>
        /// The is numeric
        /// </summary>
        private readonly bool _isNumeric;

        /// <summary>
        /// The target
        /// </summary>
        private readonly object _target;

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public object Value
        {
            get { return _field != null ? _field.GetValue(_target) : _prop.GetValue(_target, null); }
            set
            {

                if (_isNumeric)
                {
                    Type type = null;
                    if (_field != null) type = _field.FieldType;
                    if (_prop != null) type = _prop.PropertyType;
                    if (AnyEquals(type, NumericTypes))
                        value = Convert.ChangeType(value, type);
                }

                if (_field != null)
                    _field.SetValue(_target, value);
                else
                    _prop?.SetValue(_target, value, null);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnglideInfo"/> class.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="property">The property.</param>
        /// <param name="writeRequired">if set to <c>true</c> [write required].</param>
        public UnglideInfo(object target, string property, bool writeRequired = true)
        {
            _target = target;
            Name = property;

            Type targetType;
            if (IsType(target))
            {
                targetType = (Type)target;
            }
            else
            {
                targetType = target.GetType();
            }

            _field = targetType.GetTypeInfo().DeclaredFields.FirstOrDefault(f =>
                string.Equals(property, f.Name) && !f.IsStatic);

            _prop = writeRequired
                ? targetType.GetTypeInfo().DeclaredProperties.FirstOrDefault(p =>
                    string.Equals(property, p.Name) && !p.GetMethod.IsStatic && p.CanRead && p.CanWrite)
                : targetType.GetTypeInfo().DeclaredProperties.FirstOrDefault(p =>
                    string.Equals(property, p.Name) && !p.GetMethod.IsStatic && p.CanRead);

            if (_field == null)
            {
                if (_prop == null)
                {
                    //	Couldn't find either

                    MessageBox.Show(string.Format("Field or '{0}' property '{1}' not found on object of type {2}.",
                        writeRequired ? "read/write" : "readable",
                        property, targetType.FullName));

                    //throw new Exception(string.Format("Field or '{0}' property '{1}' not found on object of type {2}.",
                    //    writeRequired ? "read/write" : "readable",
                    //    property, targetType.FullName));
                }
            }

            var valueType = Value.GetType();
            _isNumeric = AnyEquals(valueType, NumericTypes);
            CheckPropertyType(valueType, property, targetType.Name);
        }

        /// <summary>
        /// Determines whether the specified target is type.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <returns><c>true</c> if the specified target is type; otherwise, <c>false</c>.</returns>
        bool IsType(object target)
        {
            var type = target.GetType();
            var baseType = typeof(Type);

            if (type == baseType)
                return true;

            var rootType = typeof(object);

            while (type != null && type != rootType)
            {
                var info = type.GetTypeInfo();
                var current = info.IsGenericType && info.IsGenericTypeDefinition ? info.GetGenericTypeDefinition() : type;
                if (baseType == current)
                    return true;
                type = info.BaseType;
            }

            return false;
        }

        /// <summary>
        /// Checks the type of the property.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="prop">The property.</param>
        /// <param name="targetTypeName">Name of the target type.</param>
        /// <exception cref="InvalidCastException"></exception>
        private void CheckPropertyType(Type type, string prop, string targetTypeName)
        {
            if (!ValidatePropertyType(type))
            {
                throw new InvalidCastException(string.Format("Property is invalid: ({0} on {1}).", prop, targetTypeName));
            }
        }

        /// <summary>
        /// Validates the type of the property.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        protected virtual bool ValidatePropertyType(Type type)
        {
            return _isNumeric;
        }

        /// <summary>
        /// Anies the equals.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="options">The options.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        static bool AnyEquals<T>(T value, params T[] options)
        {
            foreach (var option in options)
                if (value.Equals(option)) return true;

            return false;
        }
    }

}
