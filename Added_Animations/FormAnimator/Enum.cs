// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Enum.cs" company="Zeroit Dev Technologies">
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
namespace Zeroit.Framework.Transitions.ZeroitFormAnimator
{
    /// <summary>
    /// Enum FormAnimationTypes
    /// </summary>
    public enum FormAnimationTypes
    {
        /// <summary>
        /// The left to right
        /// </summary>
        LeftToRight,
        /// <summary>
        /// The right to left
        /// </summary>
        RightToLeft,
        /// <summary>
        /// The top to bottom
        /// </summary>
        TopToBottom,
        /// <summary>
        /// The bottom to top
        /// </summary>
        BottomToTop,
        /// <summary>
        /// The fade in
        /// </summary>
        FadeIn,
        /// <summary>
        /// The fade out
        /// </summary>
        FadeOut,
        /// <summary>
        /// The hide controls
        /// </summary>
        HideControls,
        /// <summary>
        /// The show controls
        /// </summary>
        ShowControls,
        /// <summary>
        /// The grow horizontal
        /// </summary>
        GrowHorizontal,
        /// <summary>
        /// The grow vertical
        /// </summary>
        GrowVertical,
        /// <summary>
        /// The grow xy
        /// </summary>
        GrowXY,
        /// <summary>
        /// The shrink horizontal
        /// </summary>
        ShrinkHorizontal,
        /// <summary>
        /// The shrink vertical
        /// </summary>
        ShrinkVertical,
        /// <summary>
        /// The shrink xy
        /// </summary>
        ShrinkXY,
        /// <summary>
        /// The move
        /// </summary>
        Move,
        /// <summary>
        /// The grow move xy
        /// </summary>
        GrowMoveXY,
        /// <summary>
        /// The shrink move xy
        /// </summary>
        ShrinkMoveXY,
        /// <summary>
        /// The shake
        /// </summary>
        Shake,
        /// <summary>
        /// The shake f out
        /// </summary>
        ShakeFOut,
        /// <summary>
        /// The determiner position
        /// </summary>
        DeterminerPosition,
        /// <summary>
        /// The left to right vertical
        /// </summary>
        LeftToRightVertical,

                
    }

    /// <summary>
    /// Enum FormLocations
    /// </summary>
    public enum FormLocations
    {

        /// <summary>
        /// The top left
        /// </summary>
        TopLeft,
        /// <summary>
        /// The top right
        /// </summary>
        TopRight,
        /// <summary>
        /// The bottom left
        /// </summary>
        BottomLeft,
        /// <summary>
        /// The bottom right
        /// </summary>
        BottomRight,
        /// <summary>
        /// The top center
        /// </summary>
        TopCenter,
        /// <summary>
        /// The bottom center
        /// </summary>
        BottomCenter,
        /// <summary>
        /// The left center
        /// </summary>
        LeftCenter,
        /// <summary>
        /// The right center
        /// </summary>
        RightCenter,
        /// <summary>
        /// The random point
        /// </summary>
        RandomPoint,
        /// <summary>
        /// The center screen
        /// </summary>
        CenterScreen

    }

    /// <summary>
    /// Enum ShakeType
    /// </summary>
    public enum ShakeType
    {
        /// <summary>
        /// The horizontal
        /// </summary>
        Horizontal,
        /// <summary>
        /// The vertical
        /// </summary>
        Vertical,
        /// <summary>
        /// The both
        /// </summary>
        Both
    }
}
