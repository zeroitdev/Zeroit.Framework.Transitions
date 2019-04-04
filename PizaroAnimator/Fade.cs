// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Fade.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;

namespace Zeroit.Framework.Transitions.ZeroitPizaroAnimator
{
    /// <summary>
    /// An animation object that fades the opacity of a control between two limits.
    /// </summary>
    public class Fade : PredefinedEffect {
        private PropertyInfo m_OpacityProperty;

        /// <summary>
        /// Creates an animation object that fades the opacity of a control between two limits.
        /// 
        /// Start and End should be floats between 0 and 1.
        /// </summary>
        /// <param name="control">Windows Forms control to be used in the animation.</param>
        /// <param name="start">Start opacity.</param>
        /// <param name="end">End opacity.</param>
        /// <param name="duration">Length of animation in milliseconds.</param>
        /// <param name="accelFunc">Acceleration function, returns 0-1 for inputs 0-1.</param>
        public Fade(Control control, double start, double end, int duration, Func<double, double> accelFunc)
            : base(control, new double[] { start }, new double[] { end }, duration, accelFunc) {
            m_OpacityProperty = control.GetType().GetProperty("Opacity");
        }

        /// <summary>
        /// Animation event handler that will set the opacity of a control.
        /// </summary>
        protected override void UpdateStyleInternal() {
            if (m_OpacityProperty != null) {
                m_OpacityProperty.SetValue(m_Control, m_Current[0], null);
            } else {
                m_Control.BackColor = Color.FromArgb((int)Math.Round(m_Current[0] * Byte.MaxValue), m_Control.BackColor);
            }
        }

        /// <summary>
        /// Animation event handler that will show the control.
        /// </summary>
        public void Show() {
            m_Control.Show();
        }

        /// <summary>
        /// Animation event handler that will hide the control.
        /// </summary>
        public void Hide() {
            m_Control.Hide();
        }
    }
}
