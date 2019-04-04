// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FadeIn.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.ZeroitPizaroAnimator
{
    /// <summary>
    /// Fades a control in from completely transparent to fully opaque.
    /// </summary>
    public class FadeIn : Fade {
        /// <summary>
        /// Constructs an animation that fades a control in from transparent to opaque.
        /// </summary>
        /// <param name="control">The Windows Forms control to be used in the animation.</param>
        /// <param name="duration">Length of animation in milliseconds.</param>
        /// <param name="accelFunc">Acceleration function, returns 0-1 for inputs 0-1.</param>
        public FadeIn(Control control, int duration, Func<double, double> accelFunc)
            : base(control, 0, 1, duration, accelFunc) {
        }
    }
}
