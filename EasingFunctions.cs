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
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions
{
    #region Easing Functions
    /// <summary>
    /// Easing functions for animations.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    [ToolboxItem(false)]
    public class EasingAnimation : Component
    {

        #region Private Fields
        /// <summary>
        /// The size width
        /// </summary>
        int size_width = 100;
        /// <summary>
        /// The size height
        /// </summary>
        int size_height = 100;
        /// <summary>
        /// The location x
        /// </summary>
        int location_x = 10;
        /// <summary>
        /// The location y
        /// </summary>
        int location_y = 10;

        /// <summary>
        /// The control
        /// </summary>
        Control control = new Control();
        /// <summary>
        /// The elapsed
        /// </summary>
        Stopwatch elapsed = new Stopwatch();
        /// <summary>
        /// The timer
        /// </summary>
        Timer timer = new Timer();

        /// <summary>
        /// Sets the animation property for <c><see cref="EasingAnimation" /></c> animator.
        /// </summary>
        public enum AnimateProperty
        {
            /// <summary>
            /// The size
            /// </summary>
            Size,
            /// <summary>
            /// The location
            /// </summary>
            Location

        }

        /// <summary>
        /// The animated property
        /// </summary>
        public AnimateProperty _animatedProperty = AnimateProperty.Size;

        /// <summary>
        /// The easing function
        /// </summary>
        private EasingFunctions _easingFunction = EasingFunctions.Linear;
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the easing fuctions.
        /// </summary>
        /// <value>The easing fuctions.</value>
        public EasingFunctions EasingFuctions
        {
            get { return _easingFunction; }
            set
            {
                _easingFunction = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the animated property.
        /// </summary>
        /// <value>The animated property.</value>
        public AnimateProperty AnimatedProperty
        {
            get { return _animatedProperty; }
            set
            {
                _animatedProperty = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the width of the animated size.
        /// </summary>
        /// <value>The width of the animated size.</value>
        public int AnimatedSizeWidth
        {
            get { return size_width; }
            set
            {
                size_width = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the height of the animated size.
        /// </summary>
        /// <value>The height of the animated size.</value>
        public int AnimatedSizeHeight
        {
            get { return size_height; }
            set
            {
                size_height = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the animated location x.
        /// </summary>
        /// <value>The animated location x.</value>
        public int AnimatedLocationX
        {
            get { return location_x; }
            set
            {
                location_x = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the animated location y.
        /// </summary>
        /// <value>The animated location y.</value>
        public int AnimatedLocationY
        {
            get { return location_y; }
            set
            {
                location_y = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the control.
        /// </summary>
        /// <value>The control.</value>
        public Control Control
        {
            get { return control; }
            set
            {
                control = value;
                control.Invalidate();
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="EasingAnimation"/> class.
        /// </summary>
        public EasingAnimation()
        {


            if (!DesignMode)
            {
                timer.Enabled = true;
                timer.Start();

                timer.Tick += Timer_Tick;
            }

            if (DesignMode)
            {
                timer.Enabled = false;
                timer.Stop();
            }




        }


        #endregion

        #region Events

        /// <summary>
        /// Handles the Tick event of the Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            switch (_animatedProperty)
            {
                case AnimateProperty.Size:
                    control.Size = new System.Drawing.Size(size_width, size_height);
                    break;
                case AnimateProperty.Location:
                    control.Location = new System.Drawing.Point(location_x, location_y);
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Starts this instance.
        /// </summary>
        public void Start()
        {
            EasingAnimation ease = new EasingAnimation();

            ease.Linear(0.5);

        }

        #endregion

        #region Easing Functions

        /// <summary>
        /// Set the easing functions for <c><see cref="EasingAnimation" /></c> animator.
        /// </summary>
        public enum EasingFunctions
        {
            /// <summary>
            /// The linear
            /// </summary>
            Linear,
            /// <summary>
            /// The ease in
            /// </summary>
            EaseIn,
            /// <summary>
            /// The ease out
            /// </summary>
            EaseOut,
            /// <summary>
            /// The ease in and out
            /// </summary>
            EaseInAndOut,
            /// <summary>
            /// The bounce ease out
            /// </summary>
            BounceEaseOut,
            /// <summary>
            /// The linear tween
            /// </summary>
            LinearTween,
            /// <summary>
            /// The ease in quad
            /// </summary>
            EaseInQuad,
            /// <summary>
            /// The ease out quad
            /// </summary>
            EaseOutQuad,
            /// <summary>
            /// The ease in out quad
            /// </summary>
            EaseInOutQuad,
            /// <summary>
            /// The ease in cubic
            /// </summary>
            EaseInCubic,
            /// <summary>
            /// The ease out cubic
            /// </summary>
            EaseOutCubic,
            /// <summary>
            /// The ease in out cubic
            /// </summary>
            EaseInOutCubic,
            /// <summary>
            /// The ease in quart
            /// </summary>
            EaseInQuart


        }


        #region Linear
        /// <summary>
        /// A linear transition.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public double Linear(double t)
        {
            double elapsedtime = elapsed.Elapsed.Milliseconds / 1000;
            double velocity = timer.Interval * elapsedtime;

            return velocity * t;
        }
        #endregion

        #region EaseIn
        /// <summary>
        /// Ease in - start slow and speed up.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public double EaseIn(double t)
        {
            double elapsedtime = elapsed.Elapsed.Milliseconds / elapsed.Elapsed.Seconds;
            double velocity = timer.Interval * elapsedtime;

            return velocity * t * t * t;
        }
        #endregion

        #region EaseOut
        /// <summary>
        /// Ease out - start fast and slow to a stop.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public double EaseOut(double t)
        {
            double elapsedtime = elapsed.Elapsed.Milliseconds / elapsed.Elapsed.Seconds;
            double velocity = timer.Interval * elapsedtime;

            return 1 - Math.Pow(1 - velocity * t, 3);
        }
        #endregion

        #region EaseInAndOut
        /// <summary>
        /// Ease in and out - start slow, speed up, then slow down.
        /// </summary>
        /// <param name="t">Input between 0 and 1.</param>
        /// <returns>Output between 0 and 1.</returns>
        public double EaseInAndOut(double t)
        {
            double elapsedtime = elapsed.Elapsed.Milliseconds / elapsed.Elapsed.Seconds;
            double velocity = timer.Interval * elapsedtime;

            return 3 * velocity * (t * t - 2 * t * t * t);
        }
        #endregion

        #region Bounce

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out:
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="currenttime">The currenttime.</param>
        /// <param name="startime">The startime.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="maxHeight">The maximum height.</param>
        /// <returns>System.Double.</returns>
        public double BounceEaseOut(double currenttime, double startime, double minHeight, double maxHeight)
        {

            currenttime = elapsed.Elapsed.Milliseconds / elapsed.Elapsed.Seconds;
            double velocity = timer.Interval * currenttime;

            if ((currenttime /= timer.Interval) < (1 / 2.75))
                return maxHeight * velocity * (7.5625 * currenttime * currenttime) + minHeight;

            if (currenttime < (2 / 2.75))
                return maxHeight * velocity * (7.5625 * (currenttime -= (1.5 / 2.75)) * currenttime + .75) + minHeight;

            if (currenttime < (2.5 / 2.75))
                return maxHeight * velocity * (7.5625 * (currenttime -= (2.25 / 2.75)) * currenttime + .9375) + minHeight;

            return maxHeight * velocity * (7.5625 * (currenttime -= (2.625 / 2.75)) * currenttime + .984375) + minHeight;
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
        public double BounceEaseIn(double currentTime, double minHeight, double maxHeight, double duration)
        {
            currentTime = elapsed.Elapsed.Milliseconds / elapsed.Elapsed.Seconds;
            double velocity = timer.Interval * currentTime;

            return maxHeight - BounceEaseOut(velocity * (duration - currentTime), 0, maxHeight, duration) + minHeight;
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
        public double BounceEaseInOut(double currentTime, double minHeight, double maxHeight, double duration)
        {
            currentTime = elapsed.Elapsed.Milliseconds / elapsed.Elapsed.Seconds;
            double velocity = timer.Interval * currentTime;

            if (currentTime < duration / 2)
                return BounceEaseIn(currentTime * 2, 0, maxHeight, duration) * .5 * velocity + minHeight;

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
        public double BounceEaseOutIn(double currentTime, double minHeight, double maxHeight, double duration)
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
        #endregion


    }

    #endregion
}
