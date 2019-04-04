// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 08-17-2017
// ***********************************************************************
// <copyright file="PointValueHandler.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Drawing;

namespace Zeroit.Framework.Transitions.AtomicAnimator.ValueHandlers
{
    /// <summary>
    /// Value handler for System.Drawing.Point.
    /// </summary>
    /// <seealso cref="IValueHandler"/>
    /// <seealso cref="Point"/>
    public class PointValueHandler : IValueHandler<Point>
    {
        #region IValueHandler<Point> Members

        /// <summary>
        /// Gets the type that this value handler manages.
        /// </summary>
        /// <returns>The type that this value handler manages.</returns>
        public Type GetManagedType()
        {
            return typeof(Point);
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
        public Point Interpolate(Point from, Point to, float amount)
        {
            float xdiff = (float)(to.X - from.X) * amount;
            float ydiff = (float)(to.Y - from.Y) * amount;

            return new Point(from.X + (int)xdiff, from.Y + (int)ydiff);
        }

        #endregion
    }
}
