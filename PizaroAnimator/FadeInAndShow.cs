// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FadeInAndShow.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.ZeroitPizaroAnimator
{
    /// <summary>
    /// Sets a control to be visible and then fades it in from transparent to opaque.
    /// </summary>
    public class FadeInAndShow : FadeIn {
        /// <summary>
        /// Constructs an animation that sets a control to be visible and then fades it in from
        /// transparent to opaque.
        /// </summary>
        /// <param name="control">The Windows Forms control to be used in the animation.</param>
        /// <param name="duration">Length of animation in milliseconds.</param>
        /// <param name="accelFunc">Acceleration function, returns 0-1 for inputs 0-1.</param>
        public FadeInAndShow(Control control, int duration, Func<double, double> accelFunc)
            : base(control, duration, accelFunc) {
        }

        /// <inheritdoc/>
        protected override void OnBegin() {
            this.Show();
            base.OnBegin();
        }
    }
}
