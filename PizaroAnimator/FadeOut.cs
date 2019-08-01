// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FadeOut.cs" company="Zeroit Dev Technologies">
//    This program is for creating components to aid in Animating controls.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
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
        public FadeOut(Control control, int duration, Func<float,float> accelFunc)
            : base(control, 1, 0, duration, accelFunc) {
        }
    }
}
