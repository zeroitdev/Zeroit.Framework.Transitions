// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 08-17-2017
// ***********************************************************************
// <copyright file="IValueHandler.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace Zeroit.Framework.Transitions.AtomicAnimator
{
    /// <summary>
    /// Describes a "value handler." Value handlers interpolate to values. For example,
    /// an |IValueHandler&lt;int&gt;| would interpolate integer values.
    /// </summary>
    /// <typeparam name="T">The type that the value handler manages.</typeparam>
    public interface IValueHandler<T>
    {
        /// <summary>
        /// Gets the type that this value handler manages.
        /// </summary>
        /// <returns>The type that this value handler manages.</returns>
        Type GetManagedType();

        /// <summary>
        /// Interpolates two values. This uses a "line" between |from| and
        /// |to| and calculates a value on it that is %|amount| between the two
        /// endpoints.
        /// </summary>
        /// <param name="from">The from value.</param>
        /// <param name="to">The to value.</param>
        /// <param name="amount">The amount to interpolate. The value is in [0,1].</param>
        /// <returns>The interpolated value.</returns>
        T Interpolate(T from, T to, float amount);
    }
}
