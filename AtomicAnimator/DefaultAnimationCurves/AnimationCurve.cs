﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="AnimationCurve.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;

namespace Zeroit.Framework.Transitions.AtomicAnimator.AnimationCurves
{
    /// <summary>
    /// A utility class for creating commonly used animation curves. It is important to remember
    /// that these methods don't return a shared instance but rather create instances on demand.
    /// </summary>
    /// <seealso cref="LinearCurve"/>
    /// <seealso cref="BezierCurve"/>
    /// <seealso cref="IAnimationCurve"/>
    public class AnimationCurve
    {
        /// <summary>
        /// Linear animation curve.
        /// </summary>
        /// <seealso cref="IAnimationCurve"/>
        /// <seealso cref="LinearCurve"/>
        public static IAnimationCurve Linear
        {
            get
            {
                return new LinearCurve();
            }
        }

        /// <summary>
        /// Default animation curve (Bezier similar to |EaseIn| but doesn't start off as slow)
        /// </summary>
        /// <seealso cref="IAnimationCurve"/>
        /// <seealso cref="BezierCurve"/>
        public static IAnimationCurve Default
        {
            get
            {
                return new BezierCurve();
            }
        }

        /// <summary>
        /// Animation curve that causes animations to "ease in." Animations start of slow then
        /// get faster.
        /// </summary>
        /// <seealso cref="IAnimationCurve"/>
        /// <seealso cref="BezierCurve"/>
        public static IAnimationCurve EaseIn
        {
            get
            {
                return new BezierCurve(new PointF(0.5f, 0.0f), new PointF(0.5f, 0.0f));
            }
        }

        /// <summary>
        /// Animation curve that causes animations to "ease out." Animations start off
        /// comparatively fast then slow down as they finish.
        /// </summary>
        /// <seealso cref="IAnimationCurve"/>
        /// <seealso cref="BezierCurve"/>
        public static IAnimationCurve EaseOut
        {
            get
            {
                return new BezierCurve(new PointF(0.2f, 0.8f), new PointF(0.2f, 0.8f));
            }
        }

        /// <summary>
        /// Animation curve that is a combination of |EaseIn| and |EaseOut|. Animations start of slow,
        /// get faster in the middle, then slow down again as they finish.
        /// </summary>
        /// <seealso cref="IAnimationCurve"/>
        /// <seealso cref="BezierCurve"/>
        public static IAnimationCurve EaseInEaseOut
        {
            get
            {
                return new BezierCurve(new PointF(0.5f, 0.0f), new PointF(0.5f, 1.0f));
            }
        }
    }
}
