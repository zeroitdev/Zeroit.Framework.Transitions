// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="TransitionType_CriticalDamping.cs" company="Zeroit Dev Technologies">
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
    #region TransitionType_CriticalDamping
    /// <summary>
    /// This transition animates with an exponential decay. This has a damping effect
    /// similar to the motion of a needle on an electomagnetically controlled dial.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.ZeroitAnimateTransitionWithEditor.ITransitionType" />
    public class TransitionType_CriticalDamping : ITransitionType
    {
        #region Public methods

        /// <summary>
        /// Constructor. You pass in the time that the transition
        /// will take (in milliseconds).
        /// </summary>
        /// <param name="iTransitionTime">The i transition time.</param>
        /// <exception cref="System.Exception">Transition time must be greater than zero.</exception>
        public TransitionType_CriticalDamping(int iTransitionTime)
        {
            if (iTransitionTime <= 0)
            {
                throw new Exception("Transition time must be greater than zero.");
            }
            m_dTransitionTime = iTransitionTime;
        }

        #endregion

        #region ITransitionMethod Members

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
        public void onTimer(int iTime, out double dPercentage, out bool bCompleted)
        {
            // We find the percentage time elapsed...
            double dElapsed = iTime / m_dTransitionTime;
            dPercentage = (1.0 - Math.Exp(-1.0 * dElapsed * 5)) / 0.993262053;

            if (dElapsed >= 1.0)
            {
                dPercentage = 1.0;
                bCompleted = true;
            }
            else
            {
                bCompleted = false;
            }
        }

        #endregion

        #region Private data

        /// <summary>
        /// The m d transition time
        /// </summary>
        private double m_dTransitionTime = 0.0;

        #endregion
    }
    #endregion
}
