// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ITransitionType.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.Transitions
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
