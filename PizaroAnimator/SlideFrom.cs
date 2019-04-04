// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="SlideFrom.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.ZeroitPizaroAnimator
{
    /// <summary>
    /// Slides an element from its current position.
    /// </summary>
    public class SlideFrom : Slide {
        /// <summary>
        /// Constructs an animation object that slides an element from its current position.
        /// </summary>
        /// <param name="control">The Windows Forms control to be used in the animation.</param>
        /// <param name="end">2D array for end co-ordinates (X, Y).</param>
        /// <param name="duration">Length of animation in milliseconds.</param>
        /// <param name="accelFunc">Acceleration function, returns 0-1 for inputs 0-1.</param>
        public SlideFrom(Control control, double[] end, int duration, Func<double, double> accelFunc)
            : base(control, new double[] { control.Left, control.Top }, end, duration, accelFunc) {
        }

        /// <inheritdoc/>
        protected override void OnBegin() {
            m_Start = new double[] { m_Control.Left, m_Control.Top };
            base.OnBegin();
        }
    }
}
