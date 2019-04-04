// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="IManagedType.cs" company="Zeroit Dev Technologies">
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
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.Transitions.ZeroitAnimateTransitionWithEditor
{
    #region IManagedType
    /// <summary>
    /// Interface for all types we can perform transitions on.
    /// Each type (e.g. int, double, Color) that we can perform a transition on
    /// needs to have its own class that implements this interface. These classes
    /// tell the transition system how to act on objects of that type.
    /// </summary>
    internal interface IManagedType
    {
        /// <summary>
        /// Returns the Type that the instance is managing.
        /// </summary>
        /// <returns>Type.</returns>
        Type getManagedType();

        /// <summary>
        /// Returns a deep copy of the object passed in. (In particular this is
        /// needed for types that are objects.)
        /// </summary>
        /// <param name="o">The o.</param>
        /// <returns>System.Object.</returns>
        object copy(object o);

        /// <summary>
        /// Returns an object holding the value between the start and end corresponding
        /// to the percentage passed in. (Note: the percentage can be less than 0% or
        /// greater than 100%.)
        /// </summary>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <param name="dPercentage">The d percentage.</param>
        /// <returns>System.Object.</returns>
        object getIntermediateValue(object start, object end, double dPercentage);

    }
    #endregion
}
