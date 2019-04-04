// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FormFadeEffect.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.Transitions
{
    #region FormFadeEffect
    /// <summary>
    /// Class FormFadeEffect.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.IEffect" />
    public class FormFadeEffect : IEffect
    {
        /// <summary>
        /// Gets the current value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="Exception">Fading effect can be applied only on forms</exception>
        public int GetCurrentValue(Control control)
        {
            if (!(control is System.Windows.Forms.Form))
                throw new Exception("Fading effect can be applied only on forms");

            var form = (System.Windows.Forms.Form)control;
            return (int)(form.Opacity * 100);
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="originalValue">The original value.</param>
        /// <param name="valueToReach">The value to reach.</param>
        /// <param name="newValue">The new value.</param>
        /// <exception cref="Exception">Fading effect can be applied only on forms</exception>
        public void SetValue(Control control, int originalValue, int valueToReach, int newValue)
        {
            if (!(control is System.Windows.Forms.Form))
                throw new Exception("Fading effect can be applied only on forms");

            var form = (System.Windows.Forms.Form)control;
            form.Opacity = ((float)newValue) / 100;
        }

        /// <summary>
        /// Gets the minimum value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>System.Int32.</returns>
        public int GetMinimumValue(Control control)
        {
            return 0;
        }

        /// <summary>
        /// Gets the maximum value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>System.Int32.</returns>
        public int GetMaximumValue(Control control)
        {
            return 100;
        }

        /// <summary>
        /// Gets the interaction.
        /// </summary>
        /// <value>The interaction.</value>
        public EffectInteractions Interaction
        {
            get { return EffectInteractions.TRANSPARENCY; }
        }
    }
    #endregion
}
