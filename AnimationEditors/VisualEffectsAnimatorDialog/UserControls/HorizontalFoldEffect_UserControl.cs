// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="HorizontalFoldEffect_UserControl.cs" company="Zeroit Dev Technologies">
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
