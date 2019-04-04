// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ControlFadeEffect2_UserControl.cs" company="Zeroit Dev Technologies">
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
    public partial class ControlFadeEffect2_UserControl : UserControl
    {
        public ControlFadeEffect2_UserControl()
        {
            InitializeComponent();
        }

        private void controlFadeEffect2_Preview_Btn_Click(object sender, EventArgs e)
        {
            //controlFade2_Animator.Activate();
        }

        private void controlFadeEffect2_Preview_Btn_MouseEnter(object sender, EventArgs e)
        {
            controlFadeEffect2_Preview_Btn.FlatAppearance.BorderSize = 1;
            controlFadeEffect2_Preview_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        private void controlFadeEffect2_Preview_Btn_MouseLeave(object sender, EventArgs e)
        {
            controlFadeEffect2_Preview_Btn.FlatAppearance.BorderSize = 0;
            controlFadeEffect2_Preview_Btn.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
        }

        
    }
}
