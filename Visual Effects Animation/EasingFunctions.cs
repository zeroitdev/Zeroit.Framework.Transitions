// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="EasingFunctions.cs" company="Zeroit Dev Technologies">
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
#region Imports

using System;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.Transitions
{
    #region EasingFunctions

    /// <summary>
    /// Delegate EasingDelegate
    /// </summary>
    /// <param name="currentTime">The current time.</param>
    /// <param name="minValue">The minimum value.</param>
    /// <param name="maxValue">The maximum value.</param>
    /// <param name="duration">The duration.</param>
    /// <returns>System.Double.</returns>
    public delegate double EasingDelegate(double currentTime,
        double minValue, double maxValue, double duration);

    /// <summary>
    /// Class EasingFunctions.
    /// </summary>
    public static class EasingFunctions
    {
        /// <summary>
        /// The result linear
        /// </summary>
        static double Result_Linear;
        #region Linear

        /// <summary>
        /// Easing equation function for a simple linear tweening, with no easing.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double Linear(double currentTime, double minHeight, double maxHeight, double duration)
        {
            return maxHeight * currentTime / duration + minHeight;

        }

        #endregion

        #region Expo

        /// <summary>
        /// Easing equation function for an exponential (2^currentTime) easing out:
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double ExpoEaseOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            return (currentTime == duration) ? minHeight + maxHeight : maxHeight * (-Math.Pow(2, -10 * currentTime / duration) + 1) + minHeight;
        }

        /// <summary>
        /// Easing equation function for an exponential (2^currentTime) easing in:
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double ExpoEaseIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            return (currentTime == 0) ? minHeight : maxHeight * Math.Pow(2, 10 * (currentTime / duration - 1)) + minHeight;
        }

        /// <summary>
        /// Easing equation function for an exponential (2^currentTime) easing in/out:
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double ExpoEaseInOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if (currentTime == 0)
                return minHeight;

            if (currentTime == duration)
                return minHeight + maxHeight;

            if ((currentTime /= duration / 2) < 1)
                return maxHeight / 2 * Math.Pow(2, 10 * (currentTime - 1)) + minHeight;

            return maxHeight / 2 * (-Math.Pow(2, -10 * --currentTime) + 2) + minHeight;
        }

        /// <summary>
        /// Easing equation function for an exponential (2^currentTime) easing out/in:
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double ExpoEaseOutIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if (currentTime < duration / 2)
                return ExpoEaseOut(currentTime * 2, minHeight, maxHeight / 2, duration);

            return ExpoEaseIn((currentTime * 2) - duration, minHeight + maxHeight / 2, maxHeight / 2, duration);
        }

        #endregion

        #region Circular

        /// <summary>
        /// Easing equation function for a circular (sqrt(1-currentTime^2)) easing out:
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double CircEaseOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            return maxHeight * Math.Sqrt(1 - (currentTime = currentTime / duration - 1) * currentTime) + minHeight;
        }

        /// <summary>
        /// Easing equation function for a circular (sqrt(1-currentTime^2)) easing in:
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double CircEaseIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            var sqrt = Math.Sqrt(1 - (currentTime /= duration) * currentTime);

            if (Double.IsNaN(sqrt))
                sqrt = 0;

            return -maxHeight * (sqrt - 1) + minHeight;
        }

        /// <summary>
        /// Easing equation function for a circular (sqrt(1-currentTime^2)) easing in/out:
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double CircEaseInOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if ((currentTime /= duration / 2) < 1)
                return -maxHeight / 2 * (Math.Sqrt(1 - currentTime * currentTime) - 1) + minHeight;

            return maxHeight / 2 * (Math.Sqrt(1 - (currentTime -= 2) * currentTime) + 1) + minHeight;
        }

        /// <summary>
        /// Easing equation function for a circular (sqrt(1-currentTime^2)) easing in/out:
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double CircEaseOutIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if (currentTime < duration / 2)
                return CircEaseOut(currentTime * 2, minHeight, maxHeight / 2, duration);

            return CircEaseIn((currentTime * 2) - duration, minHeight + maxHeight / 2, maxHeight / 2, duration);
        }

        #endregion

        #region Quad

        /// <summary>
        /// Easing equation function for a quadratic (currentTime^2) easing out:
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double QuadEaseOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            return -maxHeight * (currentTime /= duration) * (currentTime - 2) + minHeight;
        }

        /// <summary>
        /// Easing equation function for a quadratic (currentTime^2) easing in:
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double QuadEaseIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            return maxHeight * (currentTime /= duration) * currentTime + minHeight;
        }

        /// <summary>
        /// Easing equation function for a quadratic (currentTime^2) easing in/out:
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double QuadEaseInOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if ((currentTime /= duration / 2) < 1)
                return maxHeight / 2 * currentTime * currentTime + minHeight;

            return -maxHeight / 2 * ((--currentTime) * (currentTime - 2) - 1) + minHeight;
        }

        /// <summary>
        /// Easing equation function for a quadratic (currentTime^2) easing out/in:
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double QuadEaseOutIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if (currentTime < duration / 2)
                return QuadEaseOut(currentTime * 2, minHeight, maxHeight / 2, duration);

            return QuadEaseIn((currentTime * 2) - duration, minHeight + maxHeight / 2, maxHeight / 2, duration);
        }

        #endregion

        #region Sine

        /// <summary>
        /// Easing equation function for a sinusoidal (sin(currentTime)) easing out:
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double SineEaseOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            return maxHeight * Math.Sin(currentTime / duration * (Math.PI / 2)) + minHeight;
        }

        /// <summary>
        /// Easing equation function for a sinusoidal (sin(currentTime)) easing in:
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double SineEaseIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            return -maxHeight * Math.Cos(currentTime / duration * (Math.PI / 2)) + maxHeight + minHeight;
        }

        /// <summary>
        /// Easing equation function for a sinusoidal (sin(currentTime)) easing in/out:
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double SineEaseInOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if ((currentTime /= duration / 2) < 1)
                return maxHeight / 2 * (Math.Sin(Math.PI * currentTime / 2)) + minHeight;

            return -maxHeight / 2 * (Math.Cos(Math.PI * --currentTime / 2) - 2) + minHeight;
        }

        /// <summary>
        /// Easing equation function for a sinusoidal (sin(currentTime)) easing in/out:
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double SineEaseOutIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if (currentTime < duration / 2)
                return SineEaseOut(currentTime * 2, minHeight, maxHeight / 2, duration);

            return SineEaseIn((currentTime * 2) - duration, minHeight + maxHeight / 2, maxHeight / 2, duration);
        }

        #endregion

        #region Cubic

        /// <summary>
        /// Easing equation function for a cubic (currentTime^3) easing out:
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double CubicEaseOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            return maxHeight * ((currentTime = currentTime / duration - 1) * currentTime * currentTime + 1) + minHeight;
        }

        /// <summary>
        /// Easing equation function for a cubic (currentTime^3) easing in:
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double CubicEaseIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            return maxHeight * (currentTime /= duration) * currentTime * currentTime + minHeight;
        }

        /// <summary>
        /// Easing equation function for a cubic (currentTime^3) easing in/out:
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double CubicEaseInOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if ((currentTime /= duration / 2) < 1)
                return maxHeight / 2 * currentTime * currentTime * currentTime + minHeight;

            return maxHeight / 2 * ((currentTime -= 2) * currentTime * currentTime + 2) + minHeight;
        }

        /// <summary>
        /// Easing equation function for a cubic (currentTime^3) easing out/in:
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double CubicEaseOutIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if (currentTime < duration / 2)
                return CubicEaseOut(currentTime * 2, minHeight, maxHeight / 2, duration);

            return CubicEaseIn((currentTime * 2) - duration, minHeight + maxHeight / 2, maxHeight / 2, duration);
        }

        #endregion

        #region Quartic

        /// <summary>
        /// Easing equation function for a quartic (currentTime^4) easing out:
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double QuartEaseOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            return -maxHeight * ((currentTime = currentTime / duration - 1) * currentTime * currentTime * currentTime - 1) + minHeight;
        }

        /// <summary>
        /// Easing equation function for a quartic (currentTime^4) easing in:
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double QuartEaseIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            return maxHeight * (currentTime /= duration) * currentTime * currentTime * currentTime + minHeight;
        }

        /// <summary>
        /// Easing equation function for a quartic (currentTime^4) easing in/out:
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double QuartEaseInOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if ((currentTime /= duration / 2) < 1)
                return maxHeight / 2 * currentTime * currentTime * currentTime * currentTime + minHeight;

            return -maxHeight / 2 * ((currentTime -= 2) * currentTime * currentTime * currentTime - 2) + minHeight;
        }

        /// <summary>
        /// Easing equation function for a quartic (currentTime^4) easing out/in:
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double QuartEaseOutIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if (currentTime < duration / 2)
                return QuartEaseOut(currentTime * 2, minHeight, maxHeight / 2, duration);

            return QuartEaseIn((currentTime * 2) - duration, minHeight + maxHeight / 2, maxHeight / 2, duration);
        }

        #endregion

        #region Quintic

        /// <summary>
        /// Easing equation function for a quintic (currentTime^5) easing out:
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double QuintEaseOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            return maxHeight * ((currentTime = currentTime / duration - 1) * currentTime * currentTime * currentTime * currentTime + 1) + minHeight;
        }

        /// <summary>
        /// Easing equation function for a quintic (currentTime^5) easing in:
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double QuintEaseIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            return maxHeight * (currentTime /= duration) * currentTime * currentTime * currentTime * currentTime + minHeight;
        }

        /// <summary>
        /// Easing equation function for a quintic (currentTime^5) easing in/out:
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double QuintEaseInOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if ((currentTime /= duration / 2) < 1)
                return maxHeight / 2 * currentTime * currentTime * currentTime * currentTime * currentTime + minHeight;
            return maxHeight / 2 * ((currentTime -= 2) * currentTime * currentTime * currentTime * currentTime + 2) + minHeight;
        }

        /// <summary>
        /// Easing equation function for a quintic (currentTime^5) easing in/out:
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double QuintEaseOutIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if (currentTime < duration / 2)
                return QuintEaseOut(currentTime * 2, minHeight, maxHeight / 2, duration);
            return QuintEaseIn((currentTime * 2) - duration, minHeight + maxHeight / 2, maxHeight / 2, duration);
        }

        #endregion

        #region Elastic

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing out:
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double ElasticEaseOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if ((currentTime /= duration) == 1)
                return minHeight + maxHeight;

            double p = duration * .3;
            double s = p / 4;

            return (maxHeight * Math.Pow(2, -10 * currentTime) * Math.Sin((currentTime * duration - s) * (2 * Math.PI) / p) + maxHeight + minHeight);
        }

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing in:
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double ElasticEaseIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if ((currentTime /= duration) == 1)
                return minHeight + maxHeight;

            double p = duration * .3;
            double s = p / 4;

            return -(maxHeight * Math.Pow(2, 10 * (currentTime -= 1)) * Math.Sin((currentTime * duration - s) * (2 * Math.PI) / p)) + minHeight;
        }

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing in/out:
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double ElasticEaseInOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if ((currentTime /= duration / 2) == 2)
                return minHeight + maxHeight;

            double p = duration * (.3 * 1.5);
            double s = p / 4;

            if (currentTime < 1)
                return -.5 * (maxHeight * Math.Pow(2, 10 * (currentTime -= 1)) * Math.Sin((currentTime * duration - s) * (2 * Math.PI) / p)) + minHeight;
            return maxHeight * Math.Pow(2, -10 * (currentTime -= 1)) * Math.Sin((currentTime * duration - s) * (2 * Math.PI) / p) * .5 + maxHeight + minHeight;
        }

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing out/in:
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double ElasticEaseOutIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if (currentTime < duration / 2)
                return ElasticEaseOut(currentTime * 2, minHeight, maxHeight / 2, duration);
            return ElasticEaseIn((currentTime * 2) - duration, minHeight + maxHeight / 2, maxHeight / 2, duration);
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

        #region Back

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*currentTime^3 - s*currentTime^2) easing out:
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double BackEaseOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            return maxHeight * ((currentTime = currentTime / duration - 1) * currentTime * ((1.70158 + 1) * currentTime + 1.70158) + 1) + minHeight;
        }

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*currentTime^3 - s*currentTime^2) easing in:
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double BackEaseIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            return maxHeight * (currentTime /= duration) * currentTime * ((1.70158 + 1) * currentTime - 1.70158) + minHeight;
        }

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*currentTime^3 - s*currentTime^2) easing in/out:
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double BackEaseInOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            double s = 1.70158;
            if ((currentTime /= duration / 2) < 1)
                return maxHeight / 2 * (currentTime * currentTime * (((s *= (1.525)) + 1) * currentTime - s)) + minHeight;
            return maxHeight / 2 * ((currentTime -= 2) * currentTime * (((s *= (1.525)) + 1) * currentTime + s) + 2) + minHeight;
        }

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*currentTime^3 - s*currentTime^2) easing out/in:
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="currentTime">The current time.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>System.Double.</returns>
        public static double BackEaseOutIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            if (currentTime < duration / 2)
                return BackEaseOut(currentTime * 2, minHeight, maxHeight / 2, duration);
            return BackEaseIn((currentTime * 2) - duration, minHeight + maxHeight / 2, maxHeight / 2, duration);
        }

        #endregion
    }

    #endregion
}
