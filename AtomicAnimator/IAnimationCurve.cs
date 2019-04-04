// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="IAnimationCurve.cs" company="Zeroit Dev Technologies">
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

namespace Zeroit.Framework.Transitions.AtomicAnimator
{
    /// <summary>
    /// Describes an "animation curve." Animation curves are timing functions that map a
    /// T value (elapsed time / total time = %complete) to an interpolation value to be passed
    /// to a value handler.
    /// </summary>
    /// <seealso cref="IValueHandler"/>
    public interface IAnimationCurve
    {
        /// <summary>
        /// Sets the duration of the animation curve.
        /// </summary>
        /// <param name="secs">The duration in seconds.</param>
        void SetDuration(float secs);

        /// <summary>
        /// Gets the duration of the animation curve.
        /// </summary>
        /// <returns>The duration of the animation curve (in seconds).</returns>
        float GetDuration();

        /// <summary>
        /// Gets the current elapsed time for the animation curve. This is updated
        /// with every call to |Update|.
        /// </summary>
        /// <returns>The current elapsed time (in seconds).</returns>
        /// <see cref="Update"/>
        float GetElapsed();

        /// <summary>
        /// Sets the current elapsed time.
        /// </summary>
        /// <param name="secs">The elapsed time in seconds.</param>
        void SetElapsed(float secs);

        /// <summary>
        /// Resets the elapsed time.
        /// </summary>
        void Reset();

        /// <summary>
        /// Updates the elapsed time and returns the current interpolation
        /// value (where inbetween our to [1.0] and from [0.0] values we are at).
        /// </summary>
        /// <param name="timeDelta">
        /// The number of seconds that have elapsed since our last call to |Update|,
        /// or the amount of time we want to increase our elapsed time by.
        /// </param>
        /// <returns>The current interpolation value.</returns>
        /// <remarks>
        /// Implementations SHOULD "clamp" the T value (elapsed / duration) so that it is
        /// in [0,1].
        /// </remarks>
        float Update(float timeDelta);
    }
}
