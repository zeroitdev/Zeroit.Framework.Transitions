// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="PointFConverter.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.Transitions.AnimatorWithEditor
{
    #region PointFConverter
    /// <summary>
    /// PointFConverter
    /// Thanks for Jay Riggs
    /// </summary>
    /// <seealso cref="System.ComponentModel.ExpandableObjectConverter" />
    public class PointFConverter : ExpandableObjectConverter
    {
        /// <summary>
        /// Creates a new instance of PointFConverter
        /// </summary>
        public PointFConverter()
        {
        }

        /// <summary>
        /// Boolean, true if the source type is a string
        /// </summary>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
        /// <param name="sourceType">A <see cref="T:System.Type" /> that represents the type you want to convert from.</param>
        /// <returns>true if this converter can perform the conversion; otherwise, false.</returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string)) return true;
            return base.CanConvertFrom(context, sourceType);
        }

        /// <summary>
        /// Converts the specified string into a PointF
        /// </summary>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
        /// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use as the current culture.</param>
        /// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
        /// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
        /// <exception cref="ArgumentException">Cannot convert [" + value.ToString() + "] to pointF</exception>
        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is string)
            {
                try
                {
                    string s = (string)value;
                    string[] converterParts = s.Split(',');
                    float x = 0;
                    float y = 0;
                    if (converterParts.Length > 1)
                    {
                        x = float.Parse(converterParts[0].Trim().Trim('{', 'X', 'x', '='));
                        y = float.Parse(converterParts[1].Trim().Trim('}', 'Y', 'y', '='));
                    }
                    else if (converterParts.Length == 1)
                    {
                        x = float.Parse(converterParts[0].Trim());
                        y = 0;
                    }
                    else
                    {
                        x = 0F;
                        y = 0F;
                    }
                    return new PointF(x, y);
                }
                catch
                {
                    throw new ArgumentException("Cannot convert [" + value.ToString() + "] to pointF");
                }
            }
            return base.ConvertFrom(context, culture, value);
        }

        /// <summary>
        /// Converts the PointF into a string
        /// </summary>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
        /// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" />. If null is passed, the current culture is assumed.</param>
        /// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
        /// <param name="destinationType">The <see cref="T:System.Type" /> to convert the <paramref name="value" /> parameter to.</param>
        /// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                if (value.GetType() == typeof(PointF))
                {
                    PointF pt = (PointF)value;
                    return string.Format("{{X={0}, Y={1}}}", pt.X, pt.Y);
                }
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
    #endregion
}
