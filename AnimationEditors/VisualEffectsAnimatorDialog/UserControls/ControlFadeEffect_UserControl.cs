// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ControlFadeEffect_UserControl.cs" company="Zeroit Dev Technologies">
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
    public partial class ControlFadeEffect_UserControl : UserControl
    {
        public ControlFadeEffect_UserControl()
        {
            InitializeComponent();
        }

        private void controlFade_Preview_Btn_Click(object sender, EventArgs e)
        {
            controlFade_Animator.Activate();
        }

        private void controlFade_Preview_Btn_MouseEnter(object sender, EventArgs e)
        {
            controlFade_Preview_Btn.FlatAppearance.BorderSize = 1;
            controlFade_Preview_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        private void controlFade_Preview_Btn_MouseLeave(object sender, EventArgs e)
        {
            controlFade_Preview_Btn.FlatAppearance.BorderSize = 0;
            controlFade_Preview_Btn.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
        }
    }
}
