// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 08-17-2017
// ***********************************************************************
// <copyright file="WPFColorValueHandler.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Media;

namespace Zeroit.Framework.Transitions.AtomicAnimator.ValueHandlers
{
    /// <summary>
    /// Value handler for System.Windows.Media.Color.
    /// </summary>
    /// <seealso cref="IValueHandler"/>
    /// <seealso cref="Color"/>
    public class WPFColorValueHandler : IValueHandler<Color>
    {
        #region IValueHandler<Color> Members

        /// <summary>
        /// Gets the type that this value handler manages.
        /// </summary>
        /// <returns>The type that this value handler manages.</returns>
        public Type GetManagedType()
        {
            return typeof(Color);
        }

        /// <summary>
        /// Interpolates two values. This uses a "line" between |from| and
        /// |to| and calculates a value on it that is %|amount| between the two
        /// endpoints.
        /// </summary>
        /// <param name="from">The from value.</param>
        /// <param name="to">The to value.</param>
        /// <param name="amount">The amount to interpolate. The value is in [0,1].</param>
        /// <returns>The interpolated value.</returns>
        public Color Interpolate(Color from, Color to, float amount)
        {
            float ad = ((float)to.A - (float)from.A) * amount;
            float rd = ((float)to.R - (float)from.R) * amount;
            float gd = ((float)to.G - (float)from.G) * amount;
            float bd = ((float)to.B - (float)from.B) * amount;

            byte a = (byte)Math.Min(Math.Max(((float)from.A + ad), 0.0f), 255.0f);
            byte r = (byte)Math.Min(Math.Max(((float)from.R + rd), 0.0f), 255.0f);
            byte g = (byte)Math.Min(Math.Max(((float)from.G + gd), 0.0f), 255.0f);
            byte b = (byte)Math.Min(Math.Max(((float)from.B + bd), 0.0f), 255.0f);

            return Color.FromArgb(a, r, g, b);
        }

        #endregion
    }
}
