// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="TopAnchoredHeightEffect.cs" company="Zeroit Dev Technologies">
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
    #region TopAnchoredHeightEffect
    /// <summary>
    /// Class TopAnchoredHeightEffect.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.IEffect" />
    public class TopAnchoredHeightEffect : IEffect
    {
        /// <summary>
        /// Gets the current value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>System.Int32.</returns>
        public int GetCurrentValue(Control control)
        {
            return control.Height;
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="originalValue">The original value.</param>
        /// <param name="valueToReach">The value to reach.</param>
        /// <param name="newValue">The new value.</param>
        public void SetValue(Control control, int originalValue, int valueToReach, int newValue)
        {
            control.Height = newValue;
        }

        /// <summary>
        /// Gets the minimum value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>System.Int32.</returns>
        public int GetMinimumValue(Control control)
        {
            return control.MinimumSize.IsEmpty ? Int32.MinValue
                : control.MinimumSize.Height;
        }

        /// <summary>
        /// Gets the maximum value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>System.Int32.</returns>
        public int GetMaximumValue(Control control)
        {
            return control.MaximumSize.IsEmpty ? Int32.MaxValue
                : control.MaximumSize.Height;
        }

        /// <summary>
        /// Gets the interaction.
        /// </summary>
        /// <value>The interaction.</value>
        public EffectInteractions Interaction
        {
            get { return EffectInteractions.HEIGHT; }
        }
    }
    #endregion
}
