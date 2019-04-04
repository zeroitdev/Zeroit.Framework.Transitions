// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="TransitionType_EaseInEaseOut.cs" company="Zeroit Dev Technologies">
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
    #region TransitionType_EaseInEaseOut
    /// <summary>
    /// Manages an ease-in-ease-out transition. This accelerates during the first
    /// half of the transition, and then decelerates during the second half.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.ITransitionType" />
    public class TransitionType_EaseInEaseOut : ITransitionType
    {
        #region Public methods

        /// <summary>
        /// Constructor. You pass in the time that the transition
        /// will take (in milliseconds).
        /// </summary>
        /// <param name="iTransitionTime">The i transition time.</param>
        /// <exception cref="Exception">Transition time must be greater than zero.</exception>
        public TransitionType_EaseInEaseOut(int iTransitionTime)
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
        /// Works out the percentage completed given the time passed in.
        /// This uses the formula:
        /// s = ut + 1/2at^2
        /// We accelerate as at the rate needed (a=4) to get to 0.5 at t=0.5, and
        /// then decelerate at the same rate to end up at 1.0 at t=1.0.
        /// </summary>
        /// <param name="iTime">The i time.</param>
        /// <param name="dPercentage">The d percentage.</param>
        /// <param name="bCompleted">if set to <c>true</c> [b completed].</param>
        public void onTimer(int iTime, out double dPercentage, out bool bCompleted)
        {
            // We find the percentage time elapsed...
            double dElapsed = iTime / m_dTransitionTime;
            dPercentage = Utility.convertLinearToEaseInEaseOut(dElapsed);

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
