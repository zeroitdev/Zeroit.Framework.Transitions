// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Flags.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.Transitions
{
    #region Flags
    /// <summary>
    /// Set the effect interactions for <c><see cref="ZeroitVisAnim" /></c> and
    /// <br></br><c><see cref="ZeroitVisAnimEdit" /></c> animators.
    /// </summary>
    [Flags]
    public enum EffectInteractions
    {
        /// <summary>
        /// The x
        /// </summary>
        X = 1,
        /// <summary>
        /// The y
        /// </summary>
        Y = 2,
        /// <summary>
        /// The width
        /// </summary>
        WIDTH = 8,
        /// <summary>
        /// The height
        /// </summary>
        HEIGHT = 4,
        /// <summary>
        /// The color
        /// </summary>
        COLOR = 16,
        /// <summary>
        /// The transparency
        /// </summary>
        TRANSPARENCY = 32,
        /// <summary>
        /// The location
        /// </summary>
        LOCATION = X | Y,
        /// <summary>
        /// The size
        /// </summary>
        SIZE = WIDTH | HEIGHT,
        /// <summary>
        /// The bounds
        /// </summary>
        BOUNDS = X | Y | WIDTH | HEIGHT
    }
    #endregion
}
