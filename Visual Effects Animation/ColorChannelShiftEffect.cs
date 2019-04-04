// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ColorChannelShiftEffect.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System.Drawing;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.Transitions
{
    #region ColorChannelShiftEffect
    /// <summary>
    /// Class ColorChannelShiftEffect.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.IEffect" />
    public class ColorChannelShiftEffect : IEffect
    {
        /// <summary>
        /// Sets the color channel for <c><see cref="ZeroitVisAnim" /></c> animator.
        /// </summary>
        public enum ColorChannels
        {
            /// <summary>
            /// Alpha
            /// </summary>
            A,
            /// <summary>
            /// Red
            /// </summary>
            R,
            /// <summary>
            /// Green
            /// </summary>
            G,
            /// <summary>
            /// Blue
            /// </summary>
            B

        };

        /// <summary>
        /// The color channel
        /// </summary>
        public ColorChannels ColorChannel;

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorChannelShiftEffect"/> class.
        /// </summary>
        /// <param name="channel">The channel.</param>
        public ColorChannelShiftEffect(ColorChannels channel)
        {
            this.ColorChannel = channel;
        }

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
        public int GetCurrentValue(System.Windows.Forms.Control control)
        {
            if (ColorChannel == ColorChannels.A)
                return control.BackColor.A;

            if (ColorChannel == ColorChannels.R)
                return control.BackColor.R;

            if (ColorChannel == ColorChannels.G)
                return control.BackColor.G;

            return control.BackColor.B;
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
            if (newValue >= 0 && newValue <= 255)
            {
                int a = control.BackColor.A;
                int r = control.BackColor.R;
                int g = control.BackColor.G;
                int b = control.BackColor.B;

                switch (ColorChannel)
                {
                    case ColorChannels.A: a = newValue; break;
                    case ColorChannels.R: r = newValue; break;
                    case ColorChannels.G: g = newValue; break;
                    case ColorChannels.B: b = newValue; break;
                }

                control.BackColor = Color.FromArgb(a, r, g, b);
            }
        }

        /// <summary>
        /// Gets the minimum value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>System.Int32.</returns>
        public int GetMinimumValue(System.Windows.Forms.Control control)
        {
            return 0;
        }

        /// <summary>
        /// Gets the maximum value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>System.Int32.</returns>
        public int GetMaximumValue(System.Windows.Forms.Control control)
        {
            return 255;
        }
    }
    #endregion
}
