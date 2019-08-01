// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Slide .cs" company="Zeroit Dev Technologies">
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
    /// Creates an animation object that will slide an element from A to B.
    /// </summary>
    public class Slide : PredefinedEffect {
        /// <summary>
        /// Creates an animation object that will slide an element from A to B.
        /// 
        /// Start and End should be 2 dimensional arrays.
        /// </summary>
        /// <param name="control">Windows Forms control to be used in the animation.</param>
        /// <param name="start">2D array for start co-ordinates (x, y).</param>
        /// <param name="end">2D array for end co-ordinates (x, y).</param>
        /// <param name="duration">Length of animation in milliseconds.</param>
        /// <param name="accelFunc">Acceleration function, returns 0-1 for inputs 0-1.</param>
        public Slide(Control control, float[] start, float[] end, int duration, Func<float, float,float, float, float> accelFunc)
            : base(control, start, end, duration, accelFunc) {
            if (start.Length != 2 || end.Length != 2) {
                throw new AnimationException("Start and end points must be 2D");
            }
        }

        /// <inheritdoc/>
        protected override void UpdateStyleInternal() {
            m_Control.Left = (int)Math.Round(m_Current[0]);
            m_Control.Top = (int)Math.Round(m_Current[1]);
        }
    }
}
