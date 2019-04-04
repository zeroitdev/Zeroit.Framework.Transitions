// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 08-17-2017
// ***********************************************************************
// <copyright file="ColorValueHandler.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Drawing;

namespace Zeroit.Framework.Transitions.AtomicAnimator.ValueHandlers
{
    /// <summary>
    /// Value handler for System.Drawing.Color.
    /// </summary>
    /// <seealso cref="IValueHandler"/>
    /// <seealso cref="Color"/>
    public class ColorValueHandler : IValueHandler<Color>
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

            int a = (int)Math.Min(Math.Max(((float)from.A + ad), 0.0f), 255.0f);
            int r = (int)Math.Min(Math.Max(((float)from.R + rd), 0.0f), 255.0f);
            int g = (int)Math.Min(Math.Max(((float)from.G + gd), 0.0f), 255.0f);
            int b = (int)Math.Min(Math.Max(((float)from.B + bd), 0.0f), 255.0f);

            return Color.FromArgb(a, r, g, b);
        }

        #endregion
    }
}
