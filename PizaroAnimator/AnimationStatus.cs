// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-04-2018
// ***********************************************************************
// <copyright file="AnimationStatus.cs" company="Zeroit Dev Technologies">
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

using System.Diagnostics;
using System.Threading;

#endregion 

namespace Zeroit.Framework.Transitions.ZeroitPizaroAnimator
{
    #region AnimationStatus

    /// <summary>
    /// Class AnimationStatus.
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public class AnimationStatus : EventArgs
    {
        /// <summary>
        /// The stopwatch
        /// </summary>
        private Stopwatch _stopwatch;

        /// <summary>
        /// Gets the elapsed milliseconds.
        /// </summary>
        /// <value>The elapsed milliseconds.</value>
        public long ElapsedMilliseconds
        {
            get { return _stopwatch.ElapsedMilliseconds; }
        }
        /// <summary>
        /// Gets the cancellation token.
        /// </summary>
        /// <value>The cancellation token.</value>
        public CancellationTokenSource CancellationToken { get; private set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is completed.
        /// </summary>
        /// <value><c>true</c> if this instance is completed; otherwise, <c>false</c>.</value>
        public bool IsCompleted { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationStatus"/> class.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="stopwatch">The stopwatch.</param>
        public AnimationStatus(CancellationTokenSource token, Stopwatch stopwatch)
        {
            this.CancellationToken = token;
            _stopwatch = stopwatch;
        }
    }
    #endregion
}
