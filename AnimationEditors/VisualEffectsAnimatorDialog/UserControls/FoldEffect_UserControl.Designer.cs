// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 11-17-2018
// ***********************************************************************
// <copyright file="FoldEffect_UserControl.Designer.cs" company="Zeroit Dev Technologies">
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

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    partial class FoldEffect_UserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Zeroit.Framework.Transitions.FoldSizes foldSizes1 = new Zeroit.Framework.Transitions.FoldSizes();
            this.rotatingCube1 = new Transitions._HelpingControls.Rotating3DCube.RotatingCube();
            this.fold_Preview_Btn = new System.Windows.Forms.Button();
            this.fold_Animator = new Zeroit.Framework.Transitions.ZeroitVisAnim();
            this.label5 = new System.Windows.Forms.Label();
            this.fold_MaxWidth_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.fold_MaxHeight_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.fold_MinHeight_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.fold_MinWidth_Numeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.fold_MaxWidth_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fold_MaxHeight_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fold_MinHeight_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fold_MinWidth_Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // rotatingCube1
            // 
            this.rotatingCube1.AutoAnimate = true;
            this.rotatingCube1.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.BlueViolet,
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Green,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Violet,
        System.Drawing.Color.LightSkyBlue};
            this.rotatingCube1.Location = new System.Drawing.Point(231, 35);
            this.rotatingCube1.Name = "rotatingCube1";
            this.rotatingCube1.Shrink = 4;
            this.rotatingCube1.Size = new System.Drawing.Size(118, 124);
            this.rotatingCube1.SpeedAdjust = 10;
            this.rotatingCube1.TabIndex = 0;
            this.rotatingCube1.Text = "rotatingCube1";
            // 
            // fold_Preview_Btn
            // 
            this.fold_Preview_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.fold_Preview_Btn.FlatAppearance.BorderSize = 0;
            this.fold_Preview_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fold_Preview_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fold_Preview_Btn.Location = new System.Drawing.Point(486, 8);
            this.fold_Preview_Btn.Name = "fold_Preview_Btn";
            this.fold_Preview_Btn.Size = new System.Drawing.Size(91, 36);
            this.fold_Preview_Btn.TabIndex = 1;
            this.fold_Preview_Btn.Text = "Preview";
            this.fold_Preview_Btn.UseVisualStyleBackColor = true;
            this.fold_Preview_Btn.Click += new System.EventHandler(this.fold_Preview_Btn_Click);
            this.fold_Preview_Btn.MouseEnter += new System.EventHandler(this.fold_Preview_Btn_MouseEnter);
            this.fold_Preview_Btn.MouseLeave += new System.EventHandler(this.fold_Preview_Btn_MouseLeave);
            // 
            // fold_Animator
            // 
            this.fold_Animator.AnimationType = Zeroit.Framework.Transitions.ZeroitVisAnim.GetAnimationType.FoldEffect;
            this.fold_Animator.Delay = 0;
            this.fold_Animator.Duration = 2000;
            this.fold_Animator.EasingType = Zeroit.Framework.Transitions.ZeroitVisAnim.EasingFunctionTypes.BackEaseIn;
            foldSizes1.MaximumSize = new System.Drawing.Size(0, 0);
            foldSizes1.MinimumSize = new System.Drawing.Size(100, 100);
            this.fold_Animator.FoldSizes = foldSizes1;
            this.fold_Animator.FoldStyle = Zeroit.Framework.Transitions.ZeroitVisAnim.FoldMethod.Show;
            this.fold_Animator.Loops = 1;
            this.fold_Animator.Reverse = true;
            this.fold_Animator.Target = this;
            this.fold_Animator.ValueToReach = 10000;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(9, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 73;
            this.label5.Text = "Max-Width";
            // 
            // fold_MaxWidth_Numeric
            // 
            this.fold_MaxWidth_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.fold_MaxWidth_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fold_MaxWidth_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fold_MaxWidth_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.fold_MaxWidth_Numeric.Location = new System.Drawing.Point(104, 30);
            this.fold_MaxWidth_Numeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fold_MaxWidth_Numeric.Name = "fold_MaxWidth_Numeric";
            this.fold_MaxWidth_Numeric.Size = new System.Drawing.Size(58, 29);
            this.fold_MaxWidth_Numeric.TabIndex = 72;
            this.fold_MaxWidth_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fold_MaxWidth_Numeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fold_MaxWidth_Numeric.ValueChanged += new System.EventHandler(this.fold_MaxWidth_Numeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(9, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 75;
            this.label1.Text = "Max-Height";
            // 
            // fold_MaxHeight_Numeric
            // 
            this.fold_MaxHeight_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.fold_MaxHeight_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fold_MaxHeight_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fold_MaxHeight_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.fold_MaxHeight_Numeric.Location = new System.Drawing.Point(104, 79);
            this.fold_MaxHeight_Numeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fold_MaxHeight_Numeric.Name = "fold_MaxHeight_Numeric";
            this.fold_MaxHeight_Numeric.Size = new System.Drawing.Size(58, 29);
            this.fold_MaxHeight_Numeric.TabIndex = 74;
            this.fold_MaxHeight_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fold_MaxHeight_Numeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fold_MaxHeight_Numeric.ValueChanged += new System.EventHandler(this.fold_MaxHeight_Numeric_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(9, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 79;
            this.label2.Text = "Min-Height";
            // 
            // fold_MinHeight_Numeric
            // 
            this.fold_MinHeight_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.fold_MinHeight_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fold_MinHeight_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fold_MinHeight_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.fold_MinHeight_Numeric.Location = new System.Drawing.Point(104, 174);
            this.fold_MinHeight_Numeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fold_MinHeight_Numeric.Name = "fold_MinHeight_Numeric";
            this.fold_MinHeight_Numeric.Size = new System.Drawing.Size(58, 29);
            this.fold_MinHeight_Numeric.TabIndex = 78;
            this.fold_MinHeight_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fold_MinHeight_Numeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fold_MinHeight_Numeric.ValueChanged += new System.EventHandler(this.fold_MinHeight_Numeric_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 77;
            this.label3.Text = "Min-Width";
            // 
            // fold_MinWidth_Numeric
            // 
            this.fold_MinWidth_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.fold_MinWidth_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fold_MinWidth_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fold_MinWidth_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.fold_MinWidth_Numeric.Location = new System.Drawing.Point(104, 125);
            this.fold_MinWidth_Numeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fold_MinWidth_Numeric.Name = "fold_MinWidth_Numeric";
            this.fold_MinWidth_Numeric.Size = new System.Drawing.Size(58, 29);
            this.fold_MinWidth_Numeric.TabIndex = 76;
            this.fold_MinWidth_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fold_MinWidth_Numeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fold_MinWidth_Numeric.ValueChanged += new System.EventHandler(this.fold_MinWidth_Numeric_ValueChanged);
            // 
            // FoldEffect_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fold_MinHeight_Numeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fold_MinWidth_Numeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fold_MaxHeight_Numeric);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fold_MaxWidth_Numeric);
            this.Controls.Add(this.fold_Preview_Btn);
            this.Controls.Add(this.rotatingCube1);
            this.Name = "FoldEffect_UserControl";
            this.Size = new System.Drawing.Size(591, 220);
            ((System.ComponentModel.ISupportInitialize)(this.fold_MaxWidth_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fold_MaxHeight_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fold_MinHeight_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fold_MinWidth_Numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Transitions._HelpingControls.Rotating3DCube.RotatingCube rotatingCube1;
        private System.Windows.Forms.Button fold_Preview_Btn;
        public ZeroitVisAnim fold_Animator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown fold_MinHeight_Numeric;
        public System.Windows.Forms.NumericUpDown fold_MinWidth_Numeric;
        public System.Windows.Forms.NumericUpDown fold_MaxHeight_Numeric;
        public System.Windows.Forms.NumericUpDown fold_MaxWidth_Numeric;
    }
}
