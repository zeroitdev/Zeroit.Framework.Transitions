// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 05-05-2018
// ***********************************************************************
// <copyright file="Animations.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace Zeroit.Framework.Transitions
{
    /// <summary>
    /// Enum representing MatAnimationType
    /// </summary>
    public enum MatAnimationType
    {
        /// <summary>
        /// The linear
        /// </summary>
        Linear,
        /// <summary>
        /// The ease in out
        /// </summary>
        EaseInOut,
        /// <summary>
        /// The ease out
        /// </summary>
        EaseOut,
        /// <summary>
        /// The custom quadratic
        /// </summary>
        CustomQuadratic
    }

    /// <summary>
    /// A class collection for Linear animation.
    /// </summary>
    public static class AnimationLinear
    {
        /// <summary>
        /// Calculates the progress.
        /// </summary>
        /// <param name="progress">The progress.</param>
        /// <returns>System.Double.</returns>
        public static double CalculateProgress(double progress)
        {
            return progress;
        }
    }

    /// <summary>
    /// A class collection for EaseInOut animation for <c><see cref="" /></c>.
    /// </summary>
    public static class AnimationEaseInOut
    {
        /// <summary>
        /// The pi
        /// </summary>
        public static double PI = Math.PI;
        /// <summary>
        /// The pi half
        /// </summary>
        public static double PI_HALF = Math.PI / 2;

        /// <summary>
        /// Calculates the progress.
        /// </summary>
        /// <param name="progress">The progress.</param>
        /// <returns>System.Double.</returns>
        public static double CalculateProgress(double progress)
        {
            return EaseInOut(progress);
        }

        /// <summary>
        /// Eases the in out.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.Double.</returns>
        private static double EaseInOut(double s)
        {
            return s - Math.Sin(s * 2 * PI) / (2 * PI);
        }
    }

    /// <summary>
    /// A class collection EaseOut animation.
    /// </summary>
    public static class AnimationEaseOut
    {
        /// <summary>
        /// Calculates the progress.
        /// </summary>
        /// <param name="progress">The progress.</param>
        /// <returns>System.Double.</returns>
        public static double CalculateProgress(double progress)
        {
            return -1 * progress * (progress - 2);
        }
    }

    /// <summary>
    /// A class collection for Custom Quadratic.
    /// </summary>
    public static class AnimationCustomQuadratic
    {
        /// <summary>
        /// Calculates the progress.
        /// </summary>
        /// <param name="progress">The progress.</param>
        /// <returns>System.Double.</returns>
        public static double CalculateProgress(double progress)
        {
            var kickoff = 0.6;
            return 1 - Math.Cos((Math.Max(progress, kickoff) - kickoff) * Math.PI / (2 - (2 * kickoff)));
        }
    }

}
