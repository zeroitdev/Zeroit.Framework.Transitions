// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ColorShiftEffect.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
using System.Drawing;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.Transitions
{
    #region ColorShiftEffect
    /// <summary>
    /// Class ColorShiftEffect.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.IEffect" />
    public class ColorShiftEffect : IEffect
    {
        /// <summary>
        /// Gets the interaction.
        /// </summary>
        /// <value>The interaction.</value>
        public EffectInteractions Interaction
        {
            get { return EffectInteractions.COLOR; }
        }

        /// <summary>
        /// Gets the current value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>System.Int32.</returns>
        public int GetCurrentValue(Control control)
        {
            return control.BackColor.ToArgb();
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
            int actualValueChange = Math.Abs(originalValue - valueToReach);
            int currentValue = this.GetCurrentValue(control);

            double absoluteChangePerc = ((double)((originalValue - newValue) * 100)) / actualValueChange;
            absoluteChangePerc = Math.Abs(absoluteChangePerc);

            if (absoluteChangePerc > 100.0f)
                return;

            Color originalColor = Color.FromArgb(originalValue);
            Color newColor = Color.FromArgb(valueToReach);

            int newA = (int)Interpolate(originalColor.A, newColor.A, absoluteChangePerc);
            int newR = (int)Interpolate(originalColor.R, newColor.R, absoluteChangePerc);
            int newG = (int)Interpolate(originalColor.G, newColor.G, absoluteChangePerc);
            int newB = (int)Interpolate(originalColor.B, newColor.B, absoluteChangePerc);

            control.BackColor = Color.FromArgb(newA, newR, newG, newB);
            Console.WriteLine(control.BackColor + " " + newColor);
        }

        /// <summary>
        /// Gets the minimum value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>System.Int32.</returns>
        public int GetMinimumValue(Control control)
        {
            return Color.Black.ToArgb();
        }

        /// <summary>
        /// Gets the maximum value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>System.Int32.</returns>
        public int GetMaximumValue(Control control)
        {
            return Color.White.ToArgb();
        }

        /// <summary>
        /// Interpolates the specified val1.
        /// </summary>
        /// <param name="val1">The val1.</param>
        /// <param name="val2">The val2.</param>
        /// <param name="changePerc">The change perc.</param>
        /// <returns>System.Int32.</returns>
        private int Interpolate(int val1, int val2, double changePerc)
        {
            int difference = val2 - val1;
            int distance = (int)(difference * (changePerc / 100));
            return (int)(val1 + distance);
        }
    }
    #endregion
}
