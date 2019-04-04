// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Custom_UserControl.cs" company="Zeroit Dev Technologies">
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
    public partial class Custom_UserControl : UserControl
    {
        public Custom_UserControl()
        {
            InitializeComponent();

            blind_Coeff_X_Numeric.Value = (int)zeroitAnimate_Animator1.DefaultAnimation.BlindCoeff.X;
            blind_Coeff_Y_Numeric.Value = (int)zeroitAnimate_Animator1.DefaultAnimation.BlindCoeff.Y;

            scale_Coeff_X_Numeric.Value = (int)zeroitAnimate_Animator1.DefaultAnimation.ScaleCoeff.X;
            scale_Coeff_Y_Numeric.Value = (int)zeroitAnimate_Animator1.DefaultAnimation.ScaleCoeff.Y;

            mosaic_Coeff_X_Numeric.Value = (int)zeroitAnimate_Animator1.DefaultAnimation.MosaicCoeff.X;
            mosaic_Coeff_Y_Numeric.Value = (int)zeroitAnimate_Animator1.DefaultAnimation.MosaicCoeff.Y;

            mosaic_Shift_X_Numeric.Value = (int)zeroitAnimate_Animator1.DefaultAnimation.MosaicShift.X;
            mosaic_Shift_Y_Numeric.Value = (int)zeroitAnimate_Animator1.DefaultAnimation.MosaicShift.Y;

            slide_Coeff_X_Numeric.Value = (int)zeroitAnimate_Animator1.DefaultAnimation.SlideCoeff.X;
            slide_Coeff_Y_Numeric.Value = (int)zeroitAnimate_Animator1.DefaultAnimation.SlideCoeff.Y;

            leaf_Coeff_Numeric.Value = (int)zeroitAnimate_Animator1.DefaultAnimation.LeafCoeff;

            rotate_Coeff_Numeric.Value = (int)zeroitAnimate_Animator1.DefaultAnimation.RotateCoeff;

            rotate_Limit_Numeric.Value = (int)zeroitAnimate_Animator1.DefaultAnimation.RotateLimit;

            time_Coeff_Numeric.Value = (int)zeroitAnimate_Animator1.DefaultAnimation.TimeCoeff;

            mosaic_Size_Numeric.Value = (int)zeroitAnimate_Animator1.DefaultAnimation.MosaicSize;

            transparency_Coeff_Numeric.Value = (int)zeroitAnimate_Animator1.DefaultAnimation.TransparencyCoeff;

            max_Time_Numeric.Value = (int)zeroitAnimate_Animator1.DefaultAnimation.MaxTime;

            min_Time_Numeric.Value = (int)zeroitAnimate_Animator1.DefaultAnimation.MinTime;





        }

        private void custom_Preview_MouseEnter(object sender, EventArgs e)
        {
            custom_Preview_Btn.FlatAppearance.BorderSize = 1;
            custom_Preview_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        private void custom_Preview_Btn_MouseLeave(object sender, EventArgs e)
        {
            custom_Preview_Btn.FlatAppearance.BorderSize = 0;
            custom_Preview_Btn.FlatAppearance.BorderColor = Color.FromArgb(31,31,31);
        }

        private void custom_Preview_Btn_Click(object sender, EventArgs e)
        {
            zeroitAnimate_Animator1.Activate();
        }

        private void blind_Coeff_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            zeroitAnimate_Animator1.DefaultAnimation.BlindCoeff = new PointF((int)blind_Coeff_X_Numeric.Value, (int)blind_Coeff_Y_Numeric.Value);
            
        }

        private void blind_Coeff_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            zeroitAnimate_Animator1.DefaultAnimation.BlindCoeff = new PointF((int)blind_Coeff_X_Numeric.Value, (int)blind_Coeff_Y_Numeric.Value);

        }

        private void scale_Coeff_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            zeroitAnimate_Animator1.DefaultAnimation.ScaleCoeff = new PointF((int)scale_Coeff_X_Numeric.Value, (int)scale_Coeff_Y_Numeric.Value);

        }

        private void scale_Coeff_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            zeroitAnimate_Animator1.DefaultAnimation.ScaleCoeff = new PointF((int)scale_Coeff_X_Numeric.Value, (int)scale_Coeff_Y_Numeric.Value);

        }

        private void mosaic_Coeff_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            zeroitAnimate_Animator1.DefaultAnimation.MosaicCoeff = new PointF((int)mosaic_Coeff_X_Numeric.Value, (int)mosaic_Coeff_Y_Numeric.Value);

        }

        private void mosaic_Coeff_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            zeroitAnimate_Animator1.DefaultAnimation.MosaicCoeff = new PointF((int)mosaic_Coeff_X_Numeric.Value, (int)mosaic_Coeff_Y_Numeric.Value);

        }

        private void mosaic_Shift_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            zeroitAnimate_Animator1.DefaultAnimation.MosaicShift = new PointF((int)mosaic_Shift_X_Numeric.Value, (int)mosaic_Shift_Y_Numeric.Value);

        }

        private void mosaic_Shift_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            zeroitAnimate_Animator1.DefaultAnimation.MosaicShift = new PointF((int)mosaic_Shift_X_Numeric.Value, (int)mosaic_Shift_Y_Numeric.Value);

        }

        private void slide_Coeff_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            zeroitAnimate_Animator1.DefaultAnimation.SlideCoeff = new PointF((int)slide_Coeff_X_Numeric.Value, (int)slide_Coeff_Y_Numeric.Value);

        }

        private void slide_Coeff_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            zeroitAnimate_Animator1.DefaultAnimation.SlideCoeff = new PointF((int)slide_Coeff_X_Numeric.Value, (int)slide_Coeff_Y_Numeric.Value);
            
        }

        private void animateDiff_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (animateDiff_Yes_RadioBtn.Checked)
            {
                zeroitAnimate_Animator1.DefaultAnimation.AnimateOnlyDifferences = true;
            }
            else
            {
                zeroitAnimate_Animator1.DefaultAnimation.AnimateOnlyDifferences = false;
            }
        }

        private void leaf_Coeff_Numeric_ValueChanged(object sender, EventArgs e)
        {
            zeroitAnimate_Animator1.DefaultAnimation.LeafCoeff = (int)leaf_Coeff_Numeric.Value;

        }

        private void rotate_Coeff_Numeric_ValueChanged(object sender, EventArgs e)
        {
            zeroitAnimate_Animator1.DefaultAnimation.RotateCoeff = (int)rotate_Coeff_Numeric.Value;

        }

        private void rotate_Limit_Numeric_ValueChanged(object sender, EventArgs e)
        {
            zeroitAnimate_Animator1.DefaultAnimation.RotateLimit = (int)rotate_Limit_Numeric.Value;

        }

        private void time_Coeff_Numeric_ValueChanged(object sender, EventArgs e)
        {
            zeroitAnimate_Animator1.DefaultAnimation.TimeCoeff = (int)time_Coeff_Numeric.Value;

        }

        private void mosaic_Size_Numeric_ValueChanged(object sender, EventArgs e)
        {
            zeroitAnimate_Animator1.DefaultAnimation.MosaicSize = (int)mosaic_Size_Numeric.Value;

        }

        private void transparency_Coeff_Numeric_ValueChanged(object sender, EventArgs e)
        {
            zeroitAnimate_Animator1.DefaultAnimation.TransparencyCoeff = (int)transparency_Coeff_Numeric.Value;

        }

        private void max_Time_Numeric_ValueChanged(object sender, EventArgs e)
        {
            zeroitAnimate_Animator1.DefaultAnimation.MaxTime = (int)max_Time_Numeric.Value;

        }

        private void min_Time_Numeric_ValueChanged(object sender, EventArgs e)
        {
            zeroitAnimate_Animator1.DefaultAnimation.MinTime = (int)min_Time_Numeric.Value;

        }
    }
}
