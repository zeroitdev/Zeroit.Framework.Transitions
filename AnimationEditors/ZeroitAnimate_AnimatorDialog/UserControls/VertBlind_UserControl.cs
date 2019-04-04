// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="VertBlind_UserControl.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
    public partial class VertBlind_UserControl : UserControl
    {
        public VertBlind_UserControl()
        {
            InitializeComponent();
        }

        private void vertBlind_Preview_Btn_Click(object sender, EventArgs e)
        {
            zeroitAnimate_Animator1.Activate();
        }

        private void vertBlind_Preview_Btn_MouseEnter(object sender, EventArgs e)
        {
            vertBlind_Preview_Btn.FlatAppearance.BorderSize = 1;
            vertBlind_Preview_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        private void vertBlind_Preview_Btn_MouseLeave(object sender, EventArgs e)
        {
            vertBlind_Preview_Btn.FlatAppearance.BorderSize = 0;
            vertBlind_Preview_Btn.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
        }
    }
}
