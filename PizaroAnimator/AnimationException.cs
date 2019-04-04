// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="AnimationException.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace Zeroit.Framework.Transitions.ZeroitPizaroAnimator
{
    /// <summary>
    /// An exception that is fired when something goes wrong with animation.
    /// </summary>
    public class AnimationException : Exception {
        /// <summary>
        /// Constructs a new AnimationException.
        /// </summary>
        /// <param name="message">The exception message to display.</param>
        public AnimationException(string message) : base(message) { }
    }
}
