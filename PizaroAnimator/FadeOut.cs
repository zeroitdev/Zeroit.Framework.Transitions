// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FadeOut.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.ZeroitPizaroAnimator
{
    /// <summary>
    /// Fades a control out from full opacity to completely transparent.
    /// </summary>
    public class FadeOut : Fade {
        /// <summary>
        /// Constructs an animation object that fades a control out from full opacity to completely
        /// transparent.
        /// </summary>
        /// <param name="control"></param>
        /// <param name="duration"></param>
        /// <param name="accelFunc"></param>
        public FadeOut(Control control, int duration, Func<double, double> accelFunc)
            : base(control, 1, 0, duration, accelFunc) {
        }
    }
}
