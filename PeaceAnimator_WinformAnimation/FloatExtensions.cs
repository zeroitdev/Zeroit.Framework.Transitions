// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 08-25-2017
// ***********************************************************************
// <copyright file="FloatExtensions.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;

namespace Zeroit.Framework.Transitions.WinFormAnimation
{
    /// <summary>
    ///     Contains public extension methods about Float2D and Fload3D classes
    /// </summary>
    public static class FloatExtensions
    {
        /// <summary>
        ///     Creates and returns a new instance of the <see cref="Float2D" /> class from this instance
        /// </summary>
        /// <param name="point">The object to create the <see cref="Float2D" /> instance from</param>
        /// <returns>The newly created <see cref="Float2D" /> instance</returns>
        public static Float2D ToFloat2D(this Point point)
        {
            return Float2D.FromPoint(point);
        }

        /// <summary>
        ///     Creates and returns a new instance of the <see cref="Float2D" /> class from this instance
        /// </summary>
        /// <param name="point">The object to create the <see cref="Float2D" /> instance from</param>
        /// <returns>The newly created <see cref="Float2D" /> instance</returns>
        public static Float2D ToFloat2D(this PointF point)
        {
            return Float2D.FromPoint(point);
        }

        /// <summary>
        ///     Creates and returns a new instance of the <see cref="Float2D" /> class from this instance
        /// </summary>
        /// <param name="size">The object to create the <see cref="Float2D" /> instance from</param>
        /// <returns>The newly created <see cref="Float2D" /> instance</returns>
        public static Float2D ToFloat2D(this Size size)
        {
            return Float2D.FromSize(size);
        }

        /// <summary>
        ///     Creates and returns a new instance of the <see cref="Float2D" /> class from this instance
        /// </summary>
        /// <param name="size">The object to create the <see cref="Float2D" /> instance from</param>
        /// <returns>The newly created <see cref="Float2D" /> instance</returns>
        public static Float2D ToFloat2D(this SizeF size)
        {
            return Float2D.FromSize(size);
        }

        /// <summary>
        ///     Creates and returns a new instance of the <see cref="Float3D" /> class from this instance
        /// </summary>
        /// <param name="color">The object to create the <see cref="Float3D" /> instance from</param>
        /// <returns>The newly created <see cref="Float3D" /> instance</returns>
        public static Float3D ToFloat3D(this Color color)
        {
            return Float3D.FromColor(color);
        }
    }
}