// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="TransitionType_ThrowAndCatch.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System.Collections.Generic;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.Transitions
{
    #region TransitionType_ThrowAndCatch
    /// <summary>
    /// This transition bounces the property to a destination value and back to the
    /// original value. It is decelerated to the destination and then acclerated back
    /// as if being thrown against gravity and then descending back with gravity.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.TransitionType_UserDefined" />
    public class TransitionType_ThrowAndCatch : TransitionType_UserDefined
    {
        #region Public methods

        /// <summary>
        /// Constructor. You pass in the total time taken for the bounce.
        /// </summary>
        /// <param name="iTransitionTime">The i transition time.</param>
        public TransitionType_ThrowAndCatch(int iTransitionTime)
        {
            // We create a custom "user-defined" transition to do the work...
            IList<TransitionElement> elements = new List<TransitionElement>();
            elements.Add(new TransitionElement(50, 100, InterpolationMethod.Deceleration));
            elements.Add(new TransitionElement(100, 0, InterpolationMethod.Accleration));
            base.setup(elements, iTransitionTime);
        }

        #endregion
    }
    #endregion
}
