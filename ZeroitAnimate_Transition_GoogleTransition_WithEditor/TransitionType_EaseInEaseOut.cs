﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="TransitionType_EaseInEaseOut.cs" company="Zeroit Dev Technologies">
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
    #region TransitionType_EaseInEaseOut
    /// <summary>
    /// Manages an ease-in-ease-out transition. This accelerates during the first
    /// half of the transition, and then decelerates during the second half.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.ZeroitAnimateTransitionWithEditor.ITransitionType" />
    public class TransitionType_EaseInEaseOut : ITransitionType
    {
        #region Public methods

        /// <summary>
        /// Constructor. You pass in the time that the transition
        /// will take (in milliseconds).
        /// </summary>
        /// <param name="iTransitionTime">The i transition time.</param>
        /// <exception cref="System.Exception">Transition time must be greater than zero.</exception>
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
