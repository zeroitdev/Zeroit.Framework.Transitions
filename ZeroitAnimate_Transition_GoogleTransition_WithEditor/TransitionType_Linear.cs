// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="TransitionType_Linear.cs" company="Zeroit Dev Technologies">
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
    #region TransitionType_Linear
    /// <summary>
    /// This class manages a linear transition. The percentage complete for the transition
    /// increases linearly with time.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.ZeroitAnimateTransitionWithEditor.ITransitionType" />
    public class TransitionType_Linear : ITransitionType
    {
        #region Public methods

        /// <summary>
        /// Constructor. You pass in the time (in milliseconds) that the
        /// transition will take.
        /// </summary>
        /// <param name="iTransitionTime">The i transition time.</param>
        /// <exception cref="System.Exception">Transition time must be greater than zero.</exception>
        public TransitionType_Linear(int iTransitionTime)
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
        /// We return the percentage completed.
        /// </summary>
        /// <param name="iTime">The i time.</param>
        /// <param name="dPercentage">The d percentage.</param>
        /// <param name="bCompleted">if set to <c>true</c> [b completed].</param>
        public void onTimer(int iTime, out double dPercentage, out bool bCompleted)
        {
            dPercentage = (iTime / m_dTransitionTime);
            if (dPercentage >= 1.0)
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
