// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2017
// ***********************************************************************
// <copyright file="EaseImplementations.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

using Zeroit.Framework.Transitions.Betwixt.Annotations;

namespace Zeroit.Framework.Transitions.Betwixt
{
    // The implementations only specify an In or an Out (depending on which is easier to write)
    // And the rest of the set is created via Generic Ease Creation

    /// <summary>
    /// Implementation of Quadratic Ease
    /// </summary>
    internal static class QuadraticImpl
    {
        /// <summary>
        /// Ins the specified percent.
        /// </summary>
        /// <param name="percent">The percent.</param>
        /// <returns>System.Single.</returns>
        public static float In(float percent)
        {
            return (float)Math.Pow(percent, 2);
        }
    }

    /// <summary>
    /// Implementation of Cubic Ease
    /// </summary>
    internal static class CubicImpl
    {
        /// <summary>
        /// Ins the specified percent.
        /// </summary>
        /// <param name="percent">The percent.</param>
        /// <returns>System.Single.</returns>
        public static float In(float percent)
        {
            return (float)Math.Pow(percent, 3);
        }
    }

    /// <summary>
    /// Implementation of Quartic Ease
    /// </summary>
    internal static class QuarticImpl
    {
        /// <summary>
        /// Ins the specified percent.
        /// </summary>
        /// <param name="percent">The percent.</param>
        /// <returns>System.Single.</returns>
        public static float In(float percent)
        {
            return (float)Math.Pow(percent, 4);
        }
    }

    /// <summary>
    /// Implementation of Quintic Ease
    /// </summary>
    internal static class QuinticImpl
    {
        /// <summary>
        /// Ins the specified percent.
        /// </summary>
        /// <param name="percent">The percent.</param>
        /// <returns>System.Single.</returns>
        public static float In(float percent)
        {
            return (float)Math.Pow(percent, 5);
        }
    }

    /// <summary>
    /// Implementation of Sine Ease
    /// </summary>
    internal static class SineImpl
    {
        /// <summary>
        /// Outs the specified percent.
        /// </summary>
        /// <param name="percent">The percent.</param>
        /// <returns>System.Single.</returns>
        public static float Out(float percent)
        {
            return (float)Math.Sin(percent * (Math.PI / 2));
        }
    }

    /// <summary>
    /// Implementation of Exponential Ease
    /// </summary>
    internal static class ExponentialImpl
    {
        /// <summary>
        /// Outs the specified percent.
        /// </summary>
        /// <param name="percent">The percent.</param>
        /// <returns>System.Single.</returns>
        public static float Out(float percent)
        {
            return (float)Math.Pow(2, 10 * (percent - 1));
        }
    }

    /// <summary>
    /// Implementation of Circlic Ease
    /// </summary>
    internal static class CircImpl
    {
        /// <summary>
        /// Outs the specified percent.
        /// </summary>
        /// <param name="percent">The percent.</param>
        /// <returns>System.Single.</returns>
        public static float Out(float percent)
        {
            return (float)Math.Sqrt(1 - Math.Pow(percent - 1, 2));
        }
    }

    /// <summary>
    /// Implementation of "Back" Ease
    /// </summary>
    internal static class BackImpl
    {
        /// <summary>
        /// Ins the specified percent.
        /// </summary>
        /// <param name="percent">The percent.</param>
        /// <returns>System.Single.</returns>
        public static float In(float percent)
        {
            const float s = 1.70158f;
            return (float)Math.Pow(percent, 2) * ((s + 1) * percent - s);
        }
    }

    /// <summary>
    /// Implementation of "Elastic" Ease
    /// </summary>
    [UsedImplicitly]
    internal static class ElasticImpl
    {
        /// <summary>
        /// Outs the specified percent.
        /// </summary>
        /// <param name="percent">The percent.</param>
        /// <returns>System.Single.</returns>
        public static float Out(float percent)
        {
            return (float)(1 + Math.Pow(2, -10 * percent) * Math.Sin((percent - 0.075) * (2 * Math.PI) / 0.3));
        }
    }

    /// <summary>
    /// Implementation of "Bounce" Ease
    /// </summary>
    [UsedImplicitly]
    internal static class BounceImpl
    {
        /// <summary>
        /// Outs the specified percent.
        /// </summary>
        /// <param name="percent">The percent.</param>
        /// <returns>System.Single.</returns>
        public static float Out(float percent)
        {
            const float s = 7.5625f;
            const float p = 2.75f;

            if (percent < (1 / p))
            {
                return (float)(s * Math.Pow(percent, 2));
            }

            if (percent < (2 / p))
            {
                percent -= (1.5f / p);
                return (float)(s * Math.Pow(percent, 2) + .75);
            }

            if (percent < (2.5f / p))
            {
                percent -= (2.25f / p);
                return (float)(s * Math.Pow(percent, 2) + .9375);
            }

            percent -= (2.625f / p);
            return (float)(s * Math.Pow(percent, 2) + .984375);
        }
    }
}
