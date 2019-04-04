// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="AnimationExtensions.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.Transitions
{
    #region AnimationExtensions
    /// <summary>
    /// Class AnimationExtensions.
    /// </summary>
    public static class AnimationExtensions
    {
        /// <summary>
        /// Animates the specified control.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="iAnimation">The ianimation.</param>
        /// <param name="easing">The easing.</param>
        /// <param name="valueToReach">The value to reach.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="delay">The delay.</param>
        /// <param name="reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="loops">The loops.</param>
        /// <returns>AnimationStatus.</returns>
        public static AnimationStatus Animate(this Control control, IEffect iAnimation,
            EasingDelegate easing, int valueToReach, int duration, int delay, bool reverse = false, int loops = 1)
        {
            return ZeroitVisAnim.Animate(control, iAnimation, easing, valueToReach, duration, delay, reverse, loops);
        }
    }
    #endregion
}
