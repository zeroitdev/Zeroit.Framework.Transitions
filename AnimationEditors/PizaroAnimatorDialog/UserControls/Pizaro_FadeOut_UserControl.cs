// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Pizaro_FadeOut_UserControl.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    /// Class Pizaro_FadeOut_UserControl.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    [ToolboxItem(false)]
    public partial class Pizaro_FadeOut_UserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pizaro_FadeOut_UserControl"/> class.
        /// </summary>
        public Pizaro_FadeOut_UserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the MouseEnter event of the fadeOut_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void fadeOut_Preview_btn_MouseEnter(object sender, EventArgs e)
        {
            fadeOut_Preview_btn.FlatAppearance.BorderSize = 1;
            fadeOut_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the fadeOut_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void fadeOut_Preview_btn_MouseLeave(object sender, EventArgs e)
        {
            fadeOut_Preview_btn.FlatAppearance.BorderSize = 0;
            fadeOut_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
        }

        /// <summary>
        /// Handles the Click event of the fadeOut_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void fadeOut_Preview_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
