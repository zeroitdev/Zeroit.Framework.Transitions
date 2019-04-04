// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-04-2018
// ***********************************************************************
// <copyright file="AnimationStatus.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
