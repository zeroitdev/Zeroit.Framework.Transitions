// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Flags.cs" company="Zeroit Dev Technologies">
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

namespace Zeroit.Framework.Transitions.ZeroitPizaroAnimator
{
    #region Flags    
    /// <summary>
    /// Set the effect interactions for the <c><see cref="ZeroitPizaroAnim"/></c>
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
