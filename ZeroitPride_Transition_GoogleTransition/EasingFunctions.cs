// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="EasingFunctions.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace Zeroit.Framework.Transitions.FormSpark.GoogleTransition
{

    #region Easing Functions
    /// <summary>
    /// Easing functions for animations.
    /// </summary>
    public static class Easing
    {

        #region Linear
        /// <summary>
        /// A linear transition.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double Linear(double t)
        {
            return t;
        }
        #endregion

        #region EaseIn
        /// <summary>
        /// Ease in - start slow and speed up.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseIn(double t)
        {
            return t * t * t;
        }
        #endregion

        #region EaseOut
        /// <summary>
        /// Ease out - start fast and slow to a stop.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseOut(double t)
        {
            return 1 - Math.Pow(1 - t, 3);
        }
        #endregion

        #region EaseInAndOut
        /// <summary>
        /// Ease in and out - start slow, speed up, then slow down.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInAndOut(double t)
        {
            return 3 * t * t - 2 * t * t * t;
        }
        #endregion

        #region Bounce

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out:
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double BounceEaseOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if ((currentTime /= duration) < (1 / 2.75))
                return maxHeight * (7.5625 * currentTime * currentTime) + minHeight;

            if (currentTime < (2 / 2.75))
                return maxHeight * (7.5625 * (currentTime -= (1.5 / 2.75)) * currentTime + .75) + minHeight;

            if (currentTime < (2.5 / 2.75))
                return maxHeight * (7.5625 * (currentTime -= (2.25 / 2.75)) * currentTime + .9375) + minHeight;

            return maxHeight * (7.5625 * (currentTime -= (2.625 / 2.75)) * currentTime + .984375) + minHeight;
        }

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in:
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double BounceEaseIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            return maxHeight - BounceEaseOut(duration - currentTime, 0, maxHeight, duration) + minHeight;
        }

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out:
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double BounceEaseInOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if (currentTime < duration / 2)
                return BounceEaseIn(currentTime * 2, 0, maxHeight, duration) * .5 + minHeight;

            return BounceEaseOut(currentTime * 2 - duration, 0, maxHeight, duration) * .5 + maxHeight * .5 + minHeight;
        }

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in:
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double BounceEaseOutIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if (currentTime < duration / 2)
                return BounceEaseOut(currentTime * 2, minHeight, maxHeight / 2, duration);

            return BounceEaseIn((currentTime * 2) - duration, minHeight + maxHeight / 2, maxHeight / 2, duration);
        }

        #endregion

        #region LinearTween
        /// <summary>
        /// Simple linear tweening - no easing, no acceleration.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double LinearTween(double t, double b, double c, double d)
        {
            return (c * t) / (d + b);
        }
        #endregion

        #region EaseInQuad
        /// <summary>
        /// Quadratic easing in - accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInQuad(double t, double b, double c, double d)
        {
            t /= d;
            return c * t * t + b;

        }
        #endregion

        #region EaseOutQuad
        /// <summary>
        /// Quadratic easing out - decelerating to zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseOutQuad(double t, double b, double c, double d)
        {
            t /= d;
            return -c * t * (t - 2) + b;

        }
        #endregion

        #region EaseInOutQuad
        /// <summary>
        /// Quadratic easing in/out - acceleration until halfway, then deceleration
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInOutQuad(double t, double b, double c, double d)
        {
            t /= d / 2;
            if (t < 1) return c / 2 * t * t + b;
            t--;
            return -c / 2 * (t * (t - 2) - 1) + b;

        }
        #endregion

        #region EaseInCubic
        /// <summary>
        /// Cubic easing in - accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInCubic(double t, double b, double c, double d)
        {
            t /= d;
            return c * t * t * t + b;

        }
        #endregion

        #region EaseOutCubic
        /// <summary>
        /// Cubic easing out - decelerating to zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseOutCubic(double t, double b, double c, double d)
        {
            t /= d;
            t--;
            return c * (t * t * t + 1) + b;

        }
        #endregion

        #region EaseInOutCubic
        /// <summary>
        /// Cubic easing in/out - acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInOutCubic(double t, double b, double c, double d)
        {
            t /= d / 2;
            if (t < 1) return c / 2 * t * t * t + b;
            t -= 2;
            return c / 2 * (t * t * t + 2) + b;

        }
        #endregion

        #region EaseInQuart
        /// <summary>
        /// Quartic easing in - accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInQuart(double t, double b, double c, double d)
        {
            t /= d;
            return c * t * t * t * t + b;

        }
        #endregion

        #region EaseOutQuart
        /// <summary>
        /// Quartic easing out - decelerating to zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseOutQuart(double t, double b, double c, double d)
        {
            t /= d;
            t--;
            return -c * (t * t * t * t - 1) + b;

        }
        #endregion

        #region EaseInOutQuart
        /// <summary>
        /// Quartic easing in/out - acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInOutQuart(double t, double b, double c, double d)
        {
            t /= d / 2;
            if (t < 1) return c / 2 * t * t * t * t + b;
            t -= 2;
            return -c / 2 * (t * t * t * t - 2) + b;

        }
        #endregion

        #region EaseInQuint
        /// <summary>
        /// Quintic easing in - accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInQuint(double t, double b, double c, double d)
        {
            t /= d;
            return c * t * t * t * t * t + b;

        }
        #endregion

        #region EaseOutQuint
        /// <summary>
        /// Quintic easing out - decelerating to zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseOutQuint(double t, double b, double c, double d)
        {
            t /= d;
            t--;
            return c * (t * t * t * t * t + 1) + b;

        }
        #endregion

        #region EaseInOutQuint
        /// <summary>
        /// Quintic easing in/out - acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInOutQuint(double t, double b, double c, double d)
        {
            t /= d / 2;
            if (t < 1) return c / 2 * t * t * t * t * t + b;
            t -= 2;
            return c / 2 * (t * t * t * t * t + 2) + b;

        }
        #endregion

        #region EaseInSine
        /// <summary>
        /// Sinusoidal easing in - accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInSine(double t, double b, double c, double d)
        {
            return -c * Math.Cos(t / d * (Math.PI / 2)) + c + b;

        }
        #endregion

        #region EaseOutSine
        /// <summary>
        /// Sinusoidal easing out - decelerating to zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseOutSine(double t, double b, double c, double d)
        {
            return c * Math.Sin(t / d * (Math.PI / 2)) + b;

        }
        #endregion

        #region EaseInOutSine
        /// <summary>
        /// sinusoidal easing in/out - accelerating until halfway, then decelerating.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInOutSine(double t, double b, double c, double d)
        {
            return -c / 2 * (Math.Cos(Math.PI * t / d) - 1) + b;

        }
        #endregion

        #region EaseInExpo
        /// <summary>
        /// Exponential easing in - accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInExpo(double t, double b, double c, double d)
        {
            return c * Math.Pow(2, 10 * (t / d - 1)) + b;

        }
        #endregion

        #region EaseOutExpo
        /// <summary>
        /// exponential easing out - decelerating to zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseOutExpo(double t, double b, double c, double d)
        {
            return c * (-Math.Pow(2, -10 * t / d) + 1) + b;

        }
        #endregion

        #region EaseInOutExpo
        /// <summary>
        /// Exponential easing in/out - accelerating until halfway, then decelerating.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInOutExpo(double t, double b, double c, double d)
        {
            t /= d / 2;
            if (t < 1) return c / 2 * Math.Pow(2, 10 * (t - 1)) + b;
            t--;
            return c / 2 * (-Math.Pow(2, -10 * t) + 2) + b;

        }
        #endregion

        #region EaseInCirc
        /// <summary>
        /// circular easing in - accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInCirc(double t, double b, double c, double d)
        {
            t /= d;
            return -c * (Math.Sqrt(1 - t * t) - 1) + b;

        }
        #endregion

        #region EaseOutCirc
        /// <summary>
        /// Circular easing out - decelerating to zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseOutCirc(double t, double b, double c, double d)
        {
            t /= d;
            t--;
            return c * Math.Sqrt(1 - t * t) + b;

        }
        #endregion

        #region EaseInOutCirc
        /// <summary>
        /// circular easing in/out - acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">Duration. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInOutCirc(double t, double b, double c, double d)
        {
            t /= d / 2;
            if (t < 1) return -c / 2 * (Math.Sqrt(1 - t * t) - 1) + b;
            t -= 2;
            return c / 2 * (Math.Sqrt(1 - t * t) + 1) + b;
        }
        #endregion


    }
    #endregion
    
}
