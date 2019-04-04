// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FoldEffect_UserControl.cs" company="Zeroit Dev Technologies">
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
    public partial class FoldEffect_UserControl : UserControl
    {
        public FoldEffect_UserControl()
        {
            InitializeComponent();

            fold_MaxWidth_Numeric.Value = fold_Animator.FoldSizes.MaximumSize.Width;
            fold_MaxHeight_Numeric.Value = fold_Animator.FoldSizes.MaximumSize.Height;
            fold_MinWidth_Numeric.Value = fold_Animator.FoldSizes.MinimumSize.Width;
            fold_MinHeight_Numeric.Value = fold_Animator.FoldSizes.MinimumSize.Height;
        }

        private void fold_Preview_Btn_MouseEnter(object sender, EventArgs e)
        {
            fold_Preview_Btn.FlatAppearance.BorderSize = 1;
            fold_Preview_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        private void fold_Preview_Btn_MouseLeave(object sender, EventArgs e)
        {
            fold_Preview_Btn.FlatAppearance.BorderSize = 0;
            fold_Preview_Btn.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
        }

        private void fold_Preview_Btn_Click(object sender, EventArgs e)
        {
            fold_Animator.Activate();
        }

        private void fold_MaxWidth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            fold_Animator.FoldSizes.MaximumSize = new Size((int)fold_MaxWidth_Numeric.Value, (int)fold_MaxHeight_Numeric.Value);
        }

        private void fold_MaxHeight_Numeric_ValueChanged(object sender, EventArgs e)
        {
            fold_Animator.FoldSizes.MaximumSize = new Size((int)fold_MaxWidth_Numeric.Value, (int)fold_MaxHeight_Numeric.Value);
        }

        private void fold_MinWidth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            fold_Animator.FoldSizes.MinimumSize = new Size((int)fold_MinWidth_Numeric.Value, (int)fold_MinHeight_Numeric.Value);
        }

        private void fold_MinHeight_Numeric_ValueChanged(object sender, EventArgs e)
        {
            fold_Animator.FoldSizes.MinimumSize = new Size((int)fold_MinWidth_Numeric.Value, (int)fold_MinHeight_Numeric.Value);
        }

        
    }
}
