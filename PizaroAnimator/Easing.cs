// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Easing.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace Zeroit.Framework.Transitions.ZeroitPizaroAnimator
{

    #region Easing Function


    /// <summary>
    /// Delegate EasingDelegate
    /// </summary>
    /// <param name="t">The t.</param>
    /// <param name="b">The b.</param>
    /// <param name="c">The c.</param>
    /// <param name="d">The d.</param>
    /// <returns>System.Double.</returns>
    public delegate double EasingDelegate(double t,
    double b, double c, double d);

    #endregion

    #region Easing Functions

    /// <summary>
    /// Easing functions for animations.
    /// </summary>
    public static class Easing
    {
        /// <summary>
        /// The bee
        /// </summary>
        private static double bee = 0.5;
        /// <summary>
        /// The cee
        /// </summary>
        private static double cee = 0.5;
        /// <summary>
        /// The dee
        /// </summary>
        private static double dee = 0.5;

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

        #region Zeroit Easing Functions

        #region Linear Easing Functions

        #region LinearTween
        /// <summary>
        /// Simple linear tweening - no easing, no acceleration.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double LinearTween(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;
            return (c * t) / (d + b);
        }
        #endregion

        #endregion

        #region Quadratic Easing Functions

        #region EaseInQuad
        /// <summary>
        /// Quadratic easing in - accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInQuad(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

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
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseOutQuad(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

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
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInOutQuad(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

            t /= d / 2;
            if (t < 1) return c / 2 * t * t + b;
            t--;
            return -c / 2 * (t * (t - 2) - 1) + b;

        }
        #endregion
        #endregion

        #region Cubic Easing Functions

        #region EaseInCubic
        /// <summary>
        /// Cubic easing in - accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInCubic(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

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
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseOutCubic(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

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
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInOutCubic(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

            t /= d / 2;
            if (t < 1) return c / 2 * t * t * t + b;
            t -= 2;
            return c / 2 * (t * t * t + 2) + b;

        }
        #endregion

        #endregion

        #region Quartic Easing Functions

        #region EaseInQuart
        /// <summary>
        /// Quartic easing in - accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInQuart(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

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
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseOutQuart(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

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
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInOutQuart(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

            t /= d / 2;
            if (t < 1) return c / 2 * t * t * t * t + b;
            t -= 2;
            return -c / 2 * (t * t * t * t - 2) + b;

        }
        #endregion

        #endregion

        #region Quintic Easing Functions

        #region EaseInQuint
        /// <summary>
        /// Quintic easing in - accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInQuint(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

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
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseOutQuint(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

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
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInOutQuint(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

            t /= d / 2;
            if (t < 1) return c / 2 * t * t * t * t * t + b;
            t -= 2;
            return c / 2 * (t * t * t * t * t + 2) + b;

        }
        #endregion

        #endregion

        #region Sinusoidal Easing Functions

        #region EaseInSine
        /// <summary>
        /// Sinusoidal easing in - accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInSine(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

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
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseOutSine(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

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
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInOutSine(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

            return -c / 2 * (Math.Cos(Math.PI * t / d) - 1) + b;

        }
        #endregion

        #endregion

        #region Exponential Easing Functions

        #region EaseInExpo
        /// <summary>
        /// Exponential easing in - accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInExpo(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

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
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseOutExpo(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

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
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInOutExpo(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

            t /= d / 2;
            if (t < 1) return c / 2 * Math.Pow(2, 10 * (t - 1)) + b;
            t--;
            return c / 2 * (-Math.Pow(2, -10 * t) + 2) + b;

        }
        #endregion

        #endregion

        #region Circular Easing Functions

        #region EaseInCirc
        /// <summary>
        /// circular easing in - accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <param name="b">Start Value. Input between 0 and 1.</param>
        /// <param name="c">Change in Value. Input between 0 and 1.</param>
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInCirc(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

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
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseOutCirc(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

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
        /// <param name="d">d. Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public static double EaseInOutCirc(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

            t /= d / 2;
            if (t < 1) return -c / 2 * (Math.Sqrt(1 - t * t) - 1) + b;
            t -= 2;
            return c / 2 * (Math.Sqrt(1 - t * t) + 1) + b;
        }
        #endregion

        #endregion

        #region Elastic

        #region ElasticEaseOut
        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing out:
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        /// <returns>System.Double.</returns>
        public static double ElasticEaseOut(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

            if ((t /= d) == 1)
                return b + c;

            double p = d * .3;
            double s = p / 4;

            return (c * Math.Pow(2, -10 * t) * Math.Sin((t * d - s) * (2 * Math.PI) / p) + c + b);
        }

        #endregion

        #region ElasticEaseIn

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing in:
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        /// <returns>System.Double.</returns>
        public static double ElasticEaseIn(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

            if ((t /= d) == 1)
                return b + c;

            double p = d * .3;
            double s = p / 4;

            return -(c * Math.Pow(2, 10 * (t -= 1)) * Math.Sin((t * d - s) * (2 * Math.PI) / p)) + b;
        }
        #endregion

        #region ElasticEaseInOut

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing in/out:
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        /// <returns>System.Double.</returns>
        public static double ElasticEaseInOut(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

            if ((t /= d / 2) == 2)
                return b + c;

            double p = d * (.3 * 1.5);
            double s = p / 4;

            if (t < 1)
                return -.5 * (c * Math.Pow(2, 10 * (t -= 1)) * Math.Sin((t * d - s) * (2 * Math.PI) / p)) + b;
            return c * Math.Pow(2, -10 * (t -= 1)) * Math.Sin((t * d - s) * (2 * Math.PI) / p) * .5 + c + b;
        }

        #endregion

        #region ElasticEaseOutIn

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing out/in:
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        /// <returns>System.Double.</returns>
        public static double ElasticEaseOutIn(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

            if (t < d / 2)
                return ElasticEaseOut(t * 2, b, c / 2, d);
            return ElasticEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #endregion

        #region Bounce

        #region BounceEaseOut

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out:
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        /// <returns>System.Double.</returns>
        public static double BounceEaseOut(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

            if ((t /= d) < (1 / 2.75))
                return c * (7.5625 * t * t) + b;

            if (t < (2 / 2.75))
                return c * (7.5625 * (t -= (1.5 / 2.75)) * t + .75) + b;

            if (t < (2.5 / 2.75))
                return c * (7.5625 * (t -= (2.25 / 2.75)) * t + .9375) + b;

            return c * (7.5625 * (t -= (2.625 / 2.75)) * t + .984375) + b;
        }

        #endregion

        #region BounceEaseIn

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in:
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        /// <returns>System.Double.</returns>
        public static double BounceEaseIn(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

            return c - BounceEaseOut(d - t, 0, c, d) + b;
        }

        #endregion

        #region BounceEaseInOut

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out:
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        /// <returns>System.Double.</returns>
        public static double BounceEaseInOut(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

            if (t < d / 2)
                return BounceEaseIn(t * 2, 0, c, d) * .5 + b;

            return BounceEaseOut(t * 2 - d, 0, c, d) * .5 + c * .5 + b;
        }

        #endregion

        #region BounceEaseOutIn

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in:
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        /// <returns>System.Double.</returns>
        public static double BounceEaseOutIn(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

            if (t < d / 2)
                return BounceEaseOut(t * 2, b, c / 2, d);

            return BounceEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #endregion

        #region Back

        #region BackEaseOut
        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out:
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        /// <returns>System.Double.</returns>
        public static double BackEaseOut(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

            return c * ((t = t / d - 1) * t * ((1.70158 + 1) * t + 1.70158) + 1) + b;
        }
        #endregion

        #region BackEaseIn


        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in:
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        /// <returns>System.Double.</returns>
        public static double BackEaseIn(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

            return c * (t /= d) * t * ((1.70158 + 1) * t - 1.70158) + b;
        }

        #endregion

        #region BackEaseInOut

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out:
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        /// <returns>System.Double.</returns>
        public static double BackEaseInOut(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

            double s = 1.70158;
            if ((t /= d / 2) < 1)
                return c / 2 * (t * t * (((s *= (1.525)) + 1) * t - s)) + b;
            return c / 2 * ((t -= 2) * t * (((s *= (1.525)) + 1) * t + s) + 2) + b;
        }

        #endregion

        #region BackEaseOutIn

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in:
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        /// <returns>System.Double.</returns>
        public static double BackEaseOutIn(double t, double b, double c, double d)
        {
            b = bee;
            c = cee;
            d = dee;

            if (t < d / 2)
                return BackEaseOut(t * 2, b, c / 2, d);
            return BackEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #endregion

        #endregion

    }

    #region In Progress
    //public class EasingAnimations
    //{


    //    #region Linear
    //    /// <summary>
    //    /// A linear transition.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double Linear(double t)
    //    {
    //        return t;
    //    }
    //    #endregion

    //    #region EaseIn
    //    /// <summary>
    //    /// Ease in - start slow and speed up.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseIn(double t)
    //    {
    //        return t * t * t;
    //    }
    //    #endregion

    //    #region EaseOut
    //    /// <summary>
    //    /// Ease out - start fast and slow to a stop.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseOut(double t)
    //    {
    //        return 1 - Math.Pow(1 - t, 3);
    //    }
    //    #endregion

    //    #region EaseInAndOut
    //    /// <summary>
    //    /// Ease in and out - start slow, speed up, then slow down.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseInAndOut(double t)
    //    {
    //        return 3 * t * t - 2 * t * t * t;
    //    }
    //    #endregion

    //    #region Zeroit Easing Functions

    //    #region Linear Easing Functions

    //    #region LinearTween
    //    /// <summary>
    //    /// Simple linear tweening - no easing, no acceleration.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double LinearTween(double t, double b, double c, double d)
    //    {
    //        return (c * t) / (d + b);
    //    }
    //    #endregion

    //    #endregion

    //    #region Quadratic Easing Functions

    //    #region EaseInQuad
    //    /// <summary>
    //    /// Quadratic easing in - accelerating from zero velocity.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseInQuad(double t, double b, double c, double d)
    //    {
    //        t /= d;
    //        return c * t * t + b;

    //    }
    //    #endregion

    //    #region EaseOutQuad
    //    /// <summary>
    //    /// Quadratic easing out - decelerating to zero velocity.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseOutQuad(double t, double b, double c, double d)
    //    {
    //        t /= d;
    //        return -c * t * (t - 2) + b;

    //    }
    //    #endregion

    //    #region EaseInOutQuad
    //    /// <summary>
    //    /// Quadratic easing in/out - acceleration until halfway, then deceleration
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseInOutQuad(double t, double b, double c, double d)
    //    {
    //        t /= d / 2;
    //        if (t < 1) return c / 2 * t * t + b;
    //        t--;
    //        return -c / 2 * (t * (t - 2) - 1) + b;

    //    }
    //    #endregion
    //    #endregion

    //    #region Cubic Easing Functions

    //    #region EaseInCubic
    //    /// <summary>
    //    /// Cubic easing in - accelerating from zero velocity.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseInCubic(double t, double b, double c, double d)
    //    {
    //        t /= d;
    //        return c * t * t * t + b;

    //    }
    //    #endregion

    //    #region EaseOutCubic
    //    /// <summary>
    //    /// Cubic easing out - decelerating to zero velocity.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseOutCubic(double t, double b, double c, double d)
    //    {
    //        t /= d;
    //        t--;
    //        return c * (t * t * t + 1) + b;

    //    }
    //    #endregion

    //    #region EaseInOutCubic
    //    /// <summary>
    //    /// Cubic easing in/out - acceleration until halfway, then deceleration.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseInOutCubic(double t, double b, double c, double d)
    //    {
    //        t /= d / 2;
    //        if (t < 1) return c / 2 * t * t * t + b;
    //        t -= 2;
    //        return c / 2 * (t * t * t + 2) + b;

    //    }
    //    #endregion

    //    #endregion

    //    #region Quartic Easing Functions

    //    #region EaseInQuart
    //    /// <summary>
    //    /// Quartic easing in - accelerating from zero velocity.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseInQuart(double t, double b, double c, double d)
    //    {
    //        t /= d;
    //        return c * t * t * t * t + b;

    //    }
    //    #endregion

    //    #region EaseOutQuart
    //    /// <summary>
    //    /// Quartic easing out - decelerating to zero velocity.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseOutQuart(double t, double b, double c, double d)
    //    {
    //        t /= d;
    //        t--;
    //        return -c * (t * t * t * t - 1) + b;

    //    }
    //    #endregion

    //    #region EaseInOutQuart
    //    /// <summary>
    //    /// Quartic easing in/out - acceleration until halfway, then deceleration.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseInOutQuart(double t, double b, double c, double d)
    //    {
    //        t /= d / 2;
    //        if (t < 1) return c / 2 * t * t * t * t + b;
    //        t -= 2;
    //        return -c / 2 * (t * t * t * t - 2) + b;

    //    }
    //    #endregion

    //    #endregion

    //    #region Quintic Easing Functions

    //    #region EaseInQuint
    //    /// <summary>
    //    /// Quintic easing in - accelerating from zero velocity.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseInQuint(double t, double b, double c, double d)
    //    {
    //        t /= d;
    //        return c * t * t * t * t * t + b;

    //    }
    //    #endregion

    //    #region EaseOutQuint
    //    /// <summary>
    //    /// Quintic easing out - decelerating to zero velocity.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseOutQuint(double t, double b, double c, double d)
    //    {
    //        t /= d;
    //        t--;
    //        return c * (t * t * t * t * t + 1) + b;

    //    }
    //    #endregion

    //    #region EaseInOutQuint
    //    /// <summary>
    //    /// Quintic easing in/out - acceleration until halfway, then deceleration.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseInOutQuint(double t, double b, double c, double d)
    //    {
    //        t /= d / 2;
    //        if (t < 1) return c / 2 * t * t * t * t * t + b;
    //        t -= 2;
    //        return c / 2 * (t * t * t * t * t + 2) + b;

    //    }
    //    #endregion

    //    #endregion

    //    #region Sinusoidal Easing Functions

    //    #region EaseInSine
    //    /// <summary>
    //    /// Sinusoidal easing in - accelerating from zero velocity.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseInSine(double t, double b, double c, double d)
    //    {
    //        return -c * Math.Cos(t / d * (Math.PI / 2)) + c + b;

    //    }
    //    #endregion

    //    #region EaseOutSine
    //    /// <summary>
    //    /// Sinusoidal easing out - decelerating to zero velocity.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseOutSine(double t, double b, double c, double d)
    //    {
    //        return c * Math.Sin(t / d * (Math.PI / 2)) + b;

    //    }
    //    #endregion

    //    #region EaseInOutSine
    //    /// <summary>
    //    /// sinusoidal easing in/out - accelerating until halfway, then decelerating.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseInOutSine(double t, double b, double c, double d)
    //    {
    //        return -c / 2 * (Math.Cos(Math.PI * t / d) - 1) + b;

    //    }
    //    #endregion

    //    #endregion

    //    #region Exponential Easing Functions

    //    #region EaseInExpo
    //    /// <summary>
    //    /// Exponential easing in - accelerating from zero velocity.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseInExpo(double t, double b, double c, double d)
    //    {
    //        return c * Math.Pow(2, 10 * (t / d - 1)) + b;

    //    }
    //    #endregion

    //    #region EaseOutExpo
    //    /// <summary>
    //    /// exponential easing out - decelerating to zero velocity.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseOutExpo(double t, double b, double c, double d)
    //    {
    //        return c * (-Math.Pow(2, -10 * t / d) + 1) + b;

    //    }
    //    #endregion

    //    #region EaseInOutExpo
    //    /// <summary>
    //    /// Exponential easing in/out - accelerating until halfway, then decelerating.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseInOutExpo(double t, double b, double c, double d)
    //    {
    //        t /= d / 2;
    //        if (t < 1) return c / 2 * Math.Pow(2, 10 * (t - 1)) + b;
    //        t--;
    //        return c / 2 * (-Math.Pow(2, -10 * t) + 2) + b;

    //    }
    //    #endregion

    //    #endregion

    //    #region Circular Easing Functions

    //    #region EaseInCirc
    //    /// <summary>
    //    /// circular easing in - accelerating from zero velocity.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseInCirc(double t, double b, double c, double d)
    //    {
    //        t /= d;
    //        return -c * (Math.Sqrt(1 - t * t) - 1) + b;

    //    }
    //    #endregion

    //    #region EaseOutCirc
    //    /// <summary>
    //    /// Circular easing out - decelerating to zero velocity.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseOutCirc(double t, double b, double c, double d)
    //    {
    //        t /= d;
    //        t--;
    //        return c * Math.Sqrt(1 - t * t) + b;

    //    }
    //    #endregion

    //    #region EaseInOutCirc
    //    /// <summary>
    //    /// circular easing in/out - acceleration until halfway, then deceleration.
    //    /// </summary>
    //    /// <param name="t">Input between 0 and 1.</param>
    //    /// <param name="b">Start Value. Input between 0 and 1.</param>
    //    /// <param name="c">Change in Value. Input between 0 and 1.</param>
    //    /// <param name="d">d. Input between 0 and 1.</param>
    //    /// <returns>Output between 0 and 1.</returns>
    //    public double EaseInOutCirc(double t, double b, double c, double d)
    //    {
    //        t /= d / 2;
    //        if (t < 1) return -c / 2 * (Math.Sqrt(1 - t * t) - 1) + b;
    //        t -= 2;
    //        return c / 2 * (Math.Sqrt(1 - t * t) + 1) + b;
    //    }
    //    #endregion

    //    #endregion

    //    #region Elastic

    //    #region ElasticEaseOut
    //    /// <summary>
    //    /// Easing equation function for an elastic (exponentially decaying sine wave) easing out: 
    //    /// decelerating from zero velocity.
    //    /// </summary>
    //    public double ElasticEaseOut(double t, double b, double c, double d)
    //    {
    //        if ((t /= d) == 1)
    //            return b + c;

    //        double p = d * .3;
    //        double s = p / 4;

    //        return (c * Math.Pow(2, -10 * t) * Math.Sin((t * d - s) * (2 * Math.PI) / p) + c + b);
    //    }

    //    #endregion

    //    #region ElasticEaseIn

    //    /// <summary>
    //    /// Easing equation function for an elastic (exponentially decaying sine wave) easing in: 
    //    /// accelerating from zero velocity.
    //    /// </summary>
    //    public double ElasticEaseIn(double t, double b, double c, double d)
    //    {
    //        if ((t /= d) == 1)
    //            return b + c;

    //        double p = d * .3;
    //        double s = p / 4;

    //        return -(c * Math.Pow(2, 10 * (t -= 1)) * Math.Sin((t * d - s) * (2 * Math.PI) / p)) + b;
    //    }
    //    #endregion

    //    #region ElasticEaseInOut

    //    /// <summary>
    //    /// Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: 
    //    /// acceleration until halfway, then deceleration.
    //    /// </summary>
    //    public double ElasticEaseInOut(double t, double b, double c, double d)
    //    {
    //        if ((t /= d / 2) == 2)
    //            return b + c;

    //        double p = d * (.3 * 1.5);
    //        double s = p / 4;

    //        if (t < 1)
    //            return -.5 * (c * Math.Pow(2, 10 * (t -= 1)) * Math.Sin((t * d - s) * (2 * Math.PI) / p)) + b;
    //        return c * Math.Pow(2, -10 * (t -= 1)) * Math.Sin((t * d - s) * (2 * Math.PI) / p) * .5 + c + b;
    //    }

    //    #endregion

    //    #region ElasticEaseOutIn

    //    /// <summary>
    //    /// Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: 
    //    /// deceleration until halfway, then acceleration.
    //    /// </summary>
    //    public double ElasticEaseOutIn(double t, double b, double c, double d)
    //    {
    //        if (t < d / 2)
    //            return ElasticEaseOut(t * 2, b, c / 2, d);
    //        return ElasticEaseIn((t * 2) - d, b + c / 2, c / 2, d);
    //    }

    //    #endregion

    //    #endregion

    //    #region Bounce

    //    #region BounceEaseOut

    //    /// <summary>
    //    /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: 
    //    /// decelerating from zero velocity.
    //    /// </summary>
    //    public double BounceEaseOut(double t, double b, double c, double d)
    //    {
    //        if ((t /= d) < (1 / 2.75))
    //            return c * (7.5625 * t * t) + b;

    //        if (t < (2 / 2.75))
    //            return c * (7.5625 * (t -= (1.5 / 2.75)) * t + .75) + b;

    //        if (t < (2.5 / 2.75))
    //            return c * (7.5625 * (t -= (2.25 / 2.75)) * t + .9375) + b;

    //        return c * (7.5625 * (t -= (2.625 / 2.75)) * t + .984375) + b;
    //    }

    //    #endregion

    //    #region BounceEaseIn

    //    /// <summary>
    //    /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: 
    //    /// accelerating from zero velocity.
    //    /// </summary>
    //    public double BounceEaseIn(double t, double b, double c, double d)
    //    {
    //        return c - BounceEaseOut(d - t, 0, c, d) + b;
    //    }

    //    #endregion

    //    #region BounceEaseInOut

    //    /// <summary>
    //    /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: 
    //    /// acceleration until halfway, then deceleration.
    //    /// </summary>
    //    public double BounceEaseInOut(double t, double b, double c, double d)
    //    {
    //        if (t < d / 2)
    //            return BounceEaseIn(t * 2, 0, c, d) * .5 + b;

    //        return BounceEaseOut(t * 2 - d, 0, c, d) * .5 + c * .5 + b;
    //    }

    //    #endregion

    //    #region BounceEaseOutIn

    //    /// <summary>
    //    /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: 
    //    /// deceleration until halfway, then acceleration.
    //    /// </summary>
    //    public double BounceEaseOutIn(double t, double b, double c, double d)
    //    {
    //        if (t < d / 2)
    //            return BounceEaseOut(t * 2, b, c / 2, d);

    //        return BounceEaseIn((t * 2) - d, b + c / 2, c / 2, d);
    //    }

    //    #endregion

    //    #endregion

    //    #region Back

    //    #region BackEaseOut
    //    /// <summary>
    //    /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: 
    //    /// decelerating from zero velocity.
    //    /// </summary>
    //    public double BackEaseOut(double t, double b, double c, double d)
    //    {
    //        return c * ((t = t / d - 1) * t * ((1.70158 + 1) * t + 1.70158) + 1) + b;
    //    }
    //    #endregion

    //    #region BackEaseIn


    //    /// <summary>
    //    /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: 
    //    /// accelerating from zero velocity.
    //    /// </summary>
    //    public double BackEaseIn(double t, double b, double c, double d)
    //    {
    //        return c * (t /= d) * t * ((1.70158 + 1) * t - 1.70158) + b;
    //    }

    //    #endregion

    //    #region BackEaseInOut

    //    /// <summary>
    //    /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: 
    //    /// acceleration until halfway, then deceleration.
    //    /// </summary>
    //    public double BackEaseInOut(double t, double b, double c, double d)
    //    {
    //        double s = 1.70158;
    //        if ((t /= d / 2) < 1)
    //            return c / 2 * (t * t * (((s *= (1.525)) + 1) * t - s)) + b;
    //        return c / 2 * ((t -= 2) * t * (((s *= (1.525)) + 1) * t + s) + 2) + b;
    //    }

    //    #endregion

    //    #region BackEaseOutIn

    //    /// <summary>
    //    /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: 
    //    /// deceleration until halfway, then acceleration.
    //    /// </summary>
    //    public double BackEaseOutIn(double t, double b, double c, double d)
    //    {
    //        if (t < d / 2)
    //            return BackEaseOut(t * 2, b, c / 2, d);
    //        return BackEaseIn((t * 2) - d, b + c / 2, c / 2, d);
    //    }

    //    #endregion

    //    #endregion

    //    #endregion

    //}

    #endregion

    #endregion

}
