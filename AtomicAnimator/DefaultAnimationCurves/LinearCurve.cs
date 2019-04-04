// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="LinearCurve.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Zeroit.Framework.Transitions.AtomicAnimator.AnimationCurves
{
    /// <summary>
    /// Represents a linear timing function for animations.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.AtomicAnimator.IAnimationCurve" />
    /// <seealso cref="IAnimationCurve" />
    /// <seealso cref="AnimationCurve" />
    public class LinearCurve : IAnimationCurve
    {
        /// <summary>
        /// The m duration
        /// </summary>
        private float m_duration = 1.0f;
        /// <summary>
        /// The m elapsed
        /// </summary>
        private float m_elapsed;

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
        /// <see cref="Update" />
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

        /// <summary>
        /// Updates the elapsed time and returns the current interpolation
        /// value (where inbetween our to [1.0] and from [0.0] values we are at).
        /// </summary>
        /// <param name="timeDelta">The number of seconds that have elapsed since our last call to |Update|,
        /// or the amount of time we want to increase our elapsed time by.</param>
        /// <returns>The current interpolation value.</returns>
        /// <remarks>Implementations SHOULD "clamp" the T value (elapsed / duration) so that it is
        /// in [0,1].</remarks>
        public float Update(float timeDelta)
        {
            this.m_elapsed += timeDelta;

            if (this.m_elapsed > this.m_duration)
            {
                this.m_elapsed = this.m_duration;
            }

            // the linear curve is simple to calculate,
            // our interpolation value is simply the %complete
            // our animation is (elapsed / duration)

            return this.m_elapsed / this.m_duration;
        }

        #endregion
    }
}
