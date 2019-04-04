// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ITransitionType.cs" company="Zeroit Dev Technologies">
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

//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.Transitions.ZeroitAnimateTransitionWithEditor
{
    #region ITransitionType
    /// <summary>
    /// Interface ITransitionType
    /// </summary>
    public interface ITransitionType
    {
        /// <summary>
        /// Called by the Transition framework when its timer ticks to pass in the
        /// time (in ms) since the transition started.
        /// You should return (in an out parameter) the percentage movement towards
        /// the destination value for the time passed in. Note: this does not need to
        /// be a smooth transition from 0% to 100%. You can overshoot with values
        /// greater than 100% or undershoot if you need to (for example, to have some
        /// form of "elasticity").
        /// The percentage should be returned as (for example) 0.1 for 10%.
        /// You should return (in an out parameter) whether the transition has completed.
        /// (This may not be at the same time as the percentage has moved to 100%.)
        /// </summary>
        /// <param name="iTime">The i time.</param>
        /// <param name="dPercentage">The d percentage.</param>
        /// <param name="bCompleted">if set to <c>true</c> [b completed].</param>
        void onTimer(int iTime, out double dPercentage, out bool bCompleted);
    }
    #endregion
}
