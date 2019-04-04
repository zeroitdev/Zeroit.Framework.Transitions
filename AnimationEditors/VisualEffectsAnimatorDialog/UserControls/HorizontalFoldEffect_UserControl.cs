// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="HorizontalFoldEffect_UserControl.cs" company="Zeroit Dev Technologies">
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
    [ToolboxItem(false)]
    public partial class HorizontalFoldEffect_UserControl : UserControl
    {
        public HorizontalFoldEffect_UserControl()
        {
            InitializeComponent();
        }

        private void horizontalFold_Preview_Btn_Click(object sender, EventArgs e)
        {
            horizontalFold_Animator.Activate();
        }

        private void horizontalFold_Preview_Btn_MouseEnter(object sender, EventArgs e)
        {
            horizontalFold_Preview_Btn.FlatAppearance.BorderSize = 1;
            horizontalFold_Preview_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        private void horizontalFold_Preview_Btn_MouseLeave(object sender, EventArgs e)
        {
            horizontalFold_Preview_Btn.FlatAppearance.BorderSize = 0;
            horizontalFold_Preview_Btn.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
        }
    }
}
