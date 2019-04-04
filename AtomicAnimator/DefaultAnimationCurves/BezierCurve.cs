// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 08-17-2017
// ***********************************************************************
// <copyright file="BezierCurve.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;

namespace Zeroit.Framework.Transitions.AtomicAnimator.AnimationCurves
{
    /// <summary>
    /// Represents a timing function as a Bezier curve with the current interpolation value on the Y axis
    /// and the percentage complete for the animation on the X axis. The curve is approximated (linear approximation
    /// using cached values at a fixed number of points along the curve).
    /// </summary>
    /// <remarks>
    /// The Bezier function is given as:
    ///     F(t) = (1-t)^3*p0 + 3t*(1-t)^2*p1 + 3t^2*(1-t)*p2 + t^3*p3
    ///     F(t) = [Fx(t), Fy(t)]
    /// </remarks>
    public class BezierCurve : IAnimationCurve
    {
        internal const int LookupCount = 15; // the higher the number the more accurate the estimated values
        internal const float QStepValue = 1.0f / 1000.0f; // the smaller the value the more accurate the estimated values

        private PointF m_p0;
        private PointF m_p1;
        private PointF m_p2;
        private PointF m_p3;

        // stores the Fy(q) values for certain t values
        private float[,] m_lookups;
        private float m_duration = 1.0f;
        private float m_elapsed;

        #region Constructors

        /// <summary>
        /// Initializes a |BezierCurve| intance.
        /// </summary>
        /// <param name="p0">Control point #1.</param>
        /// <param name="p1">Control point #2.</param>
        /// <param name="p2">Control point #3.</param>
        /// <param name="p3">Control point #4.</param>
        /// <remarks>
        /// The X and Y values in each of the control points should be in [0,1].
        /// The control points MUST also follow the rule:
        ///     p0.X &lt;= p1.X &lt;= p2.X &lt;= p3.X
        ///     p0.Y &lt;= p1.Y &lt;= p2.Y &lt;= p3.Y
        /// </remarks>
        public BezierCurve(PointF p0, PointF p1, PointF p2, PointF p3)
        {
            this.m_p0 = p0;
            this.m_p1 = p1;
            this.m_p2 = p2;
            this.m_p3 = p3;

            calculateLookups();
        }

        public BezierCurve(PointF p0, PointF p1, PointF p2)
        {
            this.m_p0 = p0;
            this.m_p1 = p1;
            this.m_p2 = p2;
            
            calculateLookups();
        }

        /// <summary>
        /// Initializes a |BezierCurve| intance. Control point 1 is set to (0,0)
        /// and control point 4 is set to (1,1).
        /// </summary>
        /// <param name="p1">Control point #2.</param>
        /// <param name="p2">Control point #3.</param>
        /// <remarks>
        /// The X and Y values in each of the control points should be in [0,1].
        /// The control points MUST also follow the rule:
        ///     p0.X &lt;= p1.X &lt;= p2.X &lt;= p3.X
        ///     p0.Y &lt;= p1.Y &lt;= p2.Y &lt;= p3.Y
        /// </remarks>
        public BezierCurve(PointF p1, PointF p2)
        {
            this.m_p0 = new PointF(0.0f, 0.0f);
            this.m_p1 = p1;
            this.m_p2 = p2;
            this.m_p3 = new PointF(1.0f, 1.0f);

            calculateLookups();
        }

        /// <summary>
        /// Initializes a |BezierCurve| intance. Control point 1 is set to (0,0)
        /// and control point 4 is set to (1,1). Control points 2 and 3 are both
        /// set to (0.25,0.1).
        /// </summary>
        /// <remarks>
        /// The X and Y values in each of the control points should be in [0,1].
        /// The control points MUST also follow the rule:
        ///     p0.X &lt;= p1.X &lt;= p2.X &lt;= p3.X
        ///     p0.Y &lt;= p1.Y &lt;= p2.Y &lt;= p3.Y
        /// </remarks>
        public BezierCurve()
        {
            this.m_p0 = new PointF(0.0f, 0.0f);
            this.m_p1 = new PointF(0.25f, 0.1f);
            this.m_p2 = new PointF(0.25f, 0.1f);
            this.m_p3 = new PointF(1.0f, 1.0f);

            calculateLookups();
        }

        #endregion

        #region calculateLookups (private method)

        #region calculateLookups helpers

        #region calculateBezier...Component

        /// <summary>
        /// Calculates the X component of the point on the Bezier curve
        /// for a certaion T value.
        /// </summary>
        /// <param name="t">T value for our parametric function.</param>
        /// <returns>Fx(t)</returns>
        private float calculateBezierXComponent(float t)
        {
            float mt = 1.0f - t;
            float mt2 = mt * mt;
            float mt3 = mt2 * mt;
            float t2 = t * t;

            return (mt3 * this.m_p0.X) + (3.0f * t * mt2 * this.m_p1.X) + (3.0f * t2 * mt * this.m_p2.X) + (t2 * t * this.m_p3.X);
        }

        /// <summary>
        /// Calculates the Y component of the point on the Bezier curve
        /// for a certaion T value.
        /// </summary>
        /// <param name="t">T value for our parametric function.</param>
        /// <returns>Fy(t)</returns>
        private float calculateBezierYComponent(float t)
        {
            float mt = 1.0f - t;
            float mt2 = mt * mt;
            float mt3 = mt2 * mt;
            float t2 = t * t;

            return (mt3 * this.m_p0.Y) + (3.0f * t * mt2 * this.m_p1.Y) + (3.0f * t2 * mt * this.m_p2.Y) + (t2 * t * this.m_p3.Y);
        }

        #endregion

        #region estimateQForT

        /// <summary>
        /// Estimates a Q value for a T value (the Q value is the value such that
        /// Fx(Q) = T).
        /// </summary>
        /// <param name="lastQ">The last Q value to be returned.</param>
        /// <param name="t">T value.</param>
        /// <returns>Estimated Q value.</returns>
        /// <remarks>
        /// To help speed up calculations, this method accepts the last Q value
        /// that was returned from this method. Since we force the components of the
        /// control points to follow the rule:
        ///     p0 &lt; p1 &lt; p2 &lt; p3
        /// We know that for increasing values of T, the Q value will also increase.
        /// Thus when estimating Q values for increasing values of T we can start
        /// our search at the last Q value.
        /// </remarks>
        private float estimateQForT(float lastQ, float t)
        {
            float q = lastQ, fx;

            while (true)
            {
                fx = calculateBezierXComponent(q);

                if (fx >= t)
                {
                    break;
                }

                q += BezierCurve.QStepValue;
            }

            return q;
        }

        #endregion

        #endregion

        /// <summary>
        /// Calculates our lookup values that we use later for our linear
        /// approximations.
        /// </summary>
        private void calculateLookups()
        {
            // REMEMBER: We can't just use our typical t value (elapsed / duration) for
            // calculating the value of the curve to use as the interpolation value (Fx(t) does not = t).
            // We want the value of the curve at the intersection point of curve and the line x=t. To do this
            // we need to find some other "time value" q such that Fx(q)=t. Naturally, solving a cubic polynomial
            // is slow (which is why we are using approximations); however, we can estimate a value q' that is close to q
            // by evaluating increasing values of q' until Fx(q')>=t . Thus to estimate a value on the curve we
            // figure out which line segment t falls on and calculate the y(t).

            this.m_lookups = new float[BezierCurve.LookupCount, 3];

            float v1, v2;
            float delta = 1.0f / (float)BezierCurve.LookupCount;
            float t1 = 0, t2 = delta;
            float q = 0;

            for (int i = 0; i < BezierCurve.LookupCount; ++i)
            {
                q = estimateQForT(q, t1);
                v1 = calculateBezierYComponent(q);

                q = estimateQForT(q, t2);
                v2 = calculateBezierYComponent(q);

                this.m_lookups[i, 0] = v1;
                this.m_lookups[i, 1] = v2;

                // we also cache the slope of our line segment for use
                // later when calculating y(t) (which is the interpolation value we
                // want to return in |Update|)
                this.m_lookups[i, 2] = (v2 - v1) / delta;

                t1 = t2;
                t2 += delta;
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Control point #1.
        /// </summary>
        public PointF P0
        {
            get
            {
                return this.m_p0;
            }
        }

        /// <summary>
        /// Control point #2.
        /// </summary>
        public PointF P1
        {
            get
            {
                return this.m_p1;
            }
        }

        /// <summary>
        /// Control point #3.
        /// </summary>
        public PointF P2
        {
            get
            {
                return this.m_p2;
            }
        }

        /// <summary>
        /// Control point #4.
        /// </summary>
        public PointF P3
        {
            get
            {
                return this.m_p3;
            }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Returns the control point at the given index.
        /// </summary>
        /// <param name="index">The control point index.</param>
        /// <returns>The control point at the specific index.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown if |index| is less than 0 or greater than 3.</exception>
        public PointF this [int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return m_p0;
                    case 1:
                        return m_p1;
                    case 2:
                        return m_p2;
                    case 3:
                        return m_p3;
                }

                throw new IndexOutOfRangeException();
            }
        }

        #endregion

        #region IAnimationCurve Members

        /// <summary>
        /// Sets the duration of the animation curve.
        /// </summary>
        /// <param name="secs">The duration in seconds.</param>
        public void SetDuration(float secs)
        {
            this.m_duration = secs;
            this.m_elapsed = 0.0f;
        }

        /// <summary>
        /// Gets the duration of the animation curve.
        /// </summary>
        /// <returns>The duration of the animation curve (in seconds).</returns>
        public float GetDuration()
        {
            return this.m_duration;
        }

        /// <summary>
        /// Gets the current elapsed time for the animation curve. This is updated
        /// with every call to |Update|.
        /// </summary>
        /// <returns>The current elapsed time (in seconds).</returns>
        /// <see cref="Update"/>
        public float GetElapsed()
        {
            return this.m_elapsed;
        }

        /// <summary>
        /// Sets the current elapsed time.
        /// </summary>
        /// <param name="secs">The elapsed time in seconds.</param>
        public void SetElapsed(float secs)
        {
            this.m_elapsed = secs;
        }

        /// <summary>
        /// Resets the elapsed time.
        /// </summary>
        public void Reset()
        {
            this.m_elapsed = 0.0f;
        }

        #region valueForT (private method)

        /// <summary>
        /// Uses linear approximation to approximate a Q value for the given T value
        /// using our lookup table.
        /// </summary>
        /// <param name="t">The T value.</param>
        /// <returns>Estimated Q value.</returns>
        private float valueForT(float t)
        {
            int index;

            // calculate the index into our lookup table that contains
            // the line segment that our T value falls on
            if (t != 1.0f)
            {
                if (t < 0.0f)
                {
                    t = 0.0f;
                    index = 0;
                }
                else
                {
                    index = (int)(t * (float)BezierCurve.LookupCount);
                }
            }
            else
            {
                index = BezierCurve.LookupCount - 1;
            }

            // calculate 
            float t0 = (float)index / (float)BezierCurve.LookupCount;

            // REMEMBER: m_lookups[..., 2] is the slope of that line segment, while
            // m_lookups[..., 0] is the Q value of the lesser T value (left end) and
            // m_lookups[..., 1] is the Q value of the greater T value (right end).

            // y(t) = m(t - t0) + y0
            return this.m_lookups[index, 2] * (t - t0) + this.m_lookups[index, 0];
        }

        #endregion

        /// <summary>
        /// Updates the elapsed time and returns the current interpolation
        /// value (where inbetween our to [1.0] and from [0.0] values we are at).
        /// </summary>
        /// <param name="timeDelta">
        /// The number of seconds that have elapsed since our last call to |Update|,
        /// or the amount of time we want to increase our elapsed time by.
        /// </param>
        /// <returns>The current interpolation value.</returns>
        public float Update(float timeDelta)
        {
            this.m_elapsed += timeDelta;

            float t = this.m_elapsed / this.m_duration;

            if (t > 1.0f)
            {
                t = 1.0f;
            }

            // use our lookup table to get an estimated value from our curve
            // for this T value.
            // REMEMBER: if our lookup table was a graph the T value would be the X axis
            // and the Q value would be the Y axis.
            return valueForT(t);
        }

        #endregion
    }
}
