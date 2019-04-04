// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="TransitionType_Flash.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System.Collections.Generic;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.Transitions.ZeroitAnimateTransitionWithEditor
{
    #region TransitionType_Flash
    /// <summary>
    /// This transition type 'flashes' the properties a specified number of times, ending
    /// up by reverting them to their initial values. You specify the number of bounces and
    /// the length of each bounce.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.ZeroitAnimateTransitionWithEditor.TransitionType_UserDefined" />
    public class TransitionType_Flash : TransitionType_UserDefined
    {
        #region Public methods

        /// <summary>
        /// You specify the number of bounces and the time taken for each bounce.
        /// </summary>
        /// <param name="iNumberOfFlashes">The i number of flashes.</param>
        /// <param name="iFlashTime">The i flash time.</param>
        public TransitionType_Flash(int iNumberOfFlashes, int iFlashTime)
        {
            // This class is derived from the user-defined transition type.
            // Here we set up a custom "user-defined" transition for the 
            // number of flashes passed in...
            double dFlashInterval = 100.0 / iNumberOfFlashes;

            // We set up the elements of the user-defined transition...
            IList<TransitionElement> elements = new List<TransitionElement>();
            for (int i = 0; i < iNumberOfFlashes; ++i)
            {
                // Each flash consists of two elements: one going to the destination value, 
                // and another going back again...
                double dFlashStartTime = i * dFlashInterval;
                double dFlashEndTime = dFlashStartTime + dFlashInterval;
                double dFlashMidPoint = (dFlashStartTime + dFlashEndTime) / 2.0;
                elements.Add(new TransitionElement(dFlashMidPoint, 100, InterpolationMethod.EaseInEaseOut));
                elements.Add(new TransitionElement(dFlashEndTime, 0, InterpolationMethod.EaseInEaseOut));
            }

            base.setup(elements, iFlashTime * iNumberOfFlashes);
        }

        #endregion

    }
    #endregion
}
