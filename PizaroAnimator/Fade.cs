// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Fade.cs" company="Zeroit Dev Technologies">
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
        public Fade(Control control, float start, float end, int duration, Func<float,float> accelFunc)
            : base(control, new float[] { start }, new float[] { end }, duration, accelFunc) {
            m_OpacityProperty = control.GetType().GetProperty("Opacity");
        }

        /// <summary>
        /// Animation event handler that will set the opacity of a control.
        /// </summary>
        protected override void UpdateStyleInternal() {
            if (m_OpacityProperty != null) {
                m_OpacityProperty.SetValue(m_Control, m_Current[0], null);
            } else {

                
                //if(m_Current[0] > 1)
                //{
                //    m_Current[0] = (float)Math.Pow(m_Current[0], 0);
                //}
                //else if(m_Current[0] < 0)
                //{
                //    m_Current[0] = 0;
                //}

                //------------Working-------------//
                m_Control.BackColor = Color.FromArgb((int)Math.Round(m_Current[0] * Byte.MaxValue), m_Control.BackColor);

                //m_Control.BackColor = Color.FromArgb((int)Math.Round((float)Math.Log((float)Math.Sqrt((float)Math.Pow(m_Current[0], m_Current[0]))) * Byte.MaxValue), m_Control.BackColor);

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
            try
            {
                m_Control.Hide();
            }
            catch (Exception)
            {
                               
            }
            
        }
    }
}
