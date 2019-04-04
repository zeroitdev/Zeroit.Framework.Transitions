// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="PredefinedEffect.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.ZeroitPizaroAnimator
{
    /// <summary>
    /// Abstract class that provides reusable functionality for predefined animations that
    /// manipulate a single Windows Forms control.
    /// </summary>
    public abstract class PredefinedEffect : Animation {
        /// <summary>
        /// Windows Forms control that will be used in the animation.
        /// </summary>
        protected Control m_Control;

        /// <summary>
        /// Constructs a PredefinedEffect.
        /// </summary>
        /// <param name="control">The Windows Forms control to be used in the animation.</param>
        /// <param name="start">Array of start co-ordinates.</param>
        /// <param name="end">Array of end co-ordinates.</param>
        /// <param name="duration">Length of animation in milliseconds.</param>
        /// <param name="accelFunc">Acceleration function, returns 0-1 for inputs 0-1.</param>
        public PredefinedEffect(Control control, double[] start, double[] end, int duration, Func<double, double> accelFunc)
            : base(start, end, duration, accelFunc) {
            m_Control = control;
        }

        /// <summary>
        /// Called to update the style of the element.
        /// </summary>
        protected abstract void UpdateStyleInternal();

        private void UpdateStyle() {
            if (m_Control.InvokeRequired) {
                m_Control.Invoke(new Action(UpdateStyleInternal));
            } else {
                UpdateStyleInternal();
            }
        }

        /// <inheritdoc/>
        protected override void OnAnimate() {
            this.UpdateStyle();
            base.OnAnimate();
        }

        /// <inheritdoc/>
        protected override void OnEnd() {
            this.UpdateStyle();
            base.OnEnd();
        }

        /// <inheritdoc/>
        protected override void OnBegin() {
            this.UpdateStyle();
            base.OnBegin();
        }
    }
}
