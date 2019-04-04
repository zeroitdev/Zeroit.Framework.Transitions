// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="IManagedType.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
