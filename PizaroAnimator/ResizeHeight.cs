// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ResizeHeight.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.ZeroitPizaroAnimator
{
    /// <summary>
    /// An animation object that resizes a control between two heights.
    /// </summary>
    public class ResizeHeight : PredefinedEffect {
        /// <summary>
        /// Creates an animation object that will resize an element between two heights.
        /// </summary>
        /// <param name="control">Windows Forms control to be used in the animation.</param>
        /// <param name="start">Start height.</param>
        /// <param name="end">End height.</param>
        /// <param name="duration">Length of animation in milliseconds.</param>
        /// <param name="accelFunc">Acceleration function, returns 0-1 for inputs 0-1.</param>
        public ResizeHeight(Control control, double start, double end, int duration, Func<double, double> accelFunc)
            : base(control, new double[] { start }, new double[] { end }, duration, accelFunc) {
        }

        /// <summary>
        /// Animation event handler that will resize an element by setting its height.
        /// </summary>
        protected override void UpdateStyleInternal() {
            m_Control.Height = (int)Math.Round(m_Current[0]);
        }
    }
}
