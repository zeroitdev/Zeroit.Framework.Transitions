// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-04-2018
// ***********************************************************************
// <copyright file="Pizaro_Slide_UserControl.Designer.cs" company="Zeroit Dev Technologies">
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
    /// <summary>
    /// Class Pizaro_Slide_UserControl.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    partial class Pizaro_Slide_UserControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.slide_EndY_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.slide_StartY_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.slide_EndX_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.slide_StartX_Numeric = new System.Windows.Forms.NumericUpDown();
            this.slide_Preview_btn = new System.Windows.Forms.Button();
            this.slide_Rotating_Cube = new Transitions._HelpingControls.Rotating3DCube.RotatingCube();
            this.slide_Animator = new Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slide_EndY_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slide_StartY_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slide_EndX_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slide_StartX_Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.slide_EndY_Numeric);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.slide_StartY_Numeric);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.slide_EndX_Numeric);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.slide_StartX_Numeric);
            this.groupBox1.Controls.Add(this.slide_Preview_btn);
            this.groupBox1.Controls.Add(this.slide_Rotating_Cube);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 190);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Slide Animation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(270, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "End - Y";
            // 
            // slide_EndY_Numeric
            // 
            this.slide_EndY_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.slide_EndY_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slide_EndY_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.slide_EndY_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.slide_EndY_Numeric.Location = new System.Drawing.Point(378, 109);
            this.slide_EndY_Numeric.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.slide_EndY_Numeric.Name = "slide_EndY_Numeric";
            this.slide_EndY_Numeric.Size = new System.Drawing.Size(76, 29);
            this.slide_EndY_Numeric.TabIndex = 43;
            this.slide_EndY_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.slide_EndY_Numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(270, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "Start - Y";
            // 
            // slide_StartY_Numeric
            // 
            this.slide_StartY_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.slide_StartY_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slide_StartY_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.slide_StartY_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.slide_StartY_Numeric.Location = new System.Drawing.Point(378, 35);
            this.slide_StartY_Numeric.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.slide_StartY_Numeric.Name = "slide_StartY_Numeric";
            this.slide_StartY_Numeric.Size = new System.Drawing.Size(76, 29);
            this.slide_StartY_Numeric.TabIndex = 41;
            this.slide_StartY_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.slide_StartY_Numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(18, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "End - Y";
            // 
            // slide_EndX_Numeric
            // 
            this.slide_EndX_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.slide_EndX_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slide_EndX_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.slide_EndX_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.slide_EndX_Numeric.Location = new System.Drawing.Point(161, 109);
            this.slide_EndX_Numeric.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.slide_EndX_Numeric.Name = "slide_EndX_Numeric";
            this.slide_EndX_Numeric.Size = new System.Drawing.Size(76, 29);
            this.slide_EndX_Numeric.TabIndex = 39;
            this.slide_EndX_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.slide_EndX_Numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(18, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 38;
            this.label3.Text = "Start - X";
            // 
            // slide_StartX_Numeric
            // 
            this.slide_StartX_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.slide_StartX_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slide_StartX_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.slide_StartX_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.slide_StartX_Numeric.Location = new System.Drawing.Point(161, 37);
            this.slide_StartX_Numeric.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.slide_StartX_Numeric.Name = "slide_StartX_Numeric";
            this.slide_StartX_Numeric.Size = new System.Drawing.Size(76, 29);
            this.slide_StartX_Numeric.TabIndex = 37;
            this.slide_StartX_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.slide_StartX_Numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // slide_Preview_btn
            // 
            this.slide_Preview_btn.FlatAppearance.BorderSize = 0;
            this.slide_Preview_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slide_Preview_btn.Font = new System.Drawing.Font("Verdana", 10F);
            this.slide_Preview_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.slide_Preview_btn.Location = new System.Drawing.Point(561, 25);
            this.slide_Preview_btn.Name = "slide_Preview_btn";
            this.slide_Preview_btn.Size = new System.Drawing.Size(104, 28);
            this.slide_Preview_btn.TabIndex = 36;
            this.slide_Preview_btn.Text = "Preview";
            this.slide_Preview_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.slide_Preview_btn.UseVisualStyleBackColor = false;
            this.slide_Preview_btn.Click += new System.EventHandler(this.slide_Preview_btn_Click);
            this.slide_Preview_btn.MouseEnter += new System.EventHandler(this.slide_Preview_btn_MouseEnter);
            this.slide_Preview_btn.MouseLeave += new System.EventHandler(this.slide_Preview_btn_MouseLeave);
            // 
            // slide_Rotating_Cube
            // 
            this.slide_Rotating_Cube.AutoAnimate = true;
            this.slide_Rotating_Cube.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.BlueViolet,
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Green,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Violet,
        System.Drawing.Color.LightSkyBlue};
            this.slide_Rotating_Cube.Location = new System.Drawing.Point(574, 66);
            this.slide_Rotating_Cube.Name = "slide_Rotating_Cube";
            this.slide_Rotating_Cube.Shrink = 4;
            this.slide_Rotating_Cube.Size = new System.Drawing.Size(84, 86);
            this.slide_Rotating_Cube.SpeedAdjust = 10;
            this.slide_Rotating_Cube.TabIndex = 0;
            this.slide_Rotating_Cube.Text = "rotatingCube1";
            // 
            // slide_Animator
            // 
            this.slide_Animator.Acceleration = 0.7D;
            this.slide_Animator.AnimationType = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.animationType.Slide;
            this.slide_Animator.Control = this.slide_Rotating_Cube;
            this.slide_Animator.ControlStyles = System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer;
            this.slide_Animator.ControlStylesBool = false;
            this.slide_Animator.CordinateEnd_X = 50D;
            this.slide_Animator.CordinateEnd_Y = 50D;
            this.slide_Animator.CordinateStart_X = 10D;
            this.slide_Animator.CordinateStart_Y = 10D;
            this.slide_Animator.Duration = 1000;
            this.slide_Animator.EasingEnd = 1D;
            this.slide_Animator.EasingNames = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseIn;
            this.slide_Animator.EasingStart = 0.2D;
            this.slide_Animator.Fade_Begin = 0D;
            this.slide_Animator.Fade_Limit = 1D;
            this.slide_Animator.ResizeHeight_Begin = 10D;
            this.slide_Animator.ResizeHeight_Limit = 50D;
            this.slide_Animator.ResizeWidth_Begin = 10D;
            this.slide_Animator.ResizeWidth_Limit = 50D;
            // 
            // Pizaro_Slide_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.groupBox1);
            this.Name = "Pizaro_Slide_UserControl";
            this.Size = new System.Drawing.Size(686, 190);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slide_EndY_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slide_StartY_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slide_EndX_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slide_StartX_Numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The group box1
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox1;
        /// <summary>
        /// The label2
        /// </summary>
        private System.Windows.Forms.Label label2;
        /// <summary>
        /// The slide end y numeric
        /// </summary>
        public System.Windows.Forms.NumericUpDown slide_EndY_Numeric;
        /// <summary>
        /// The label4
        /// </summary>
        private System.Windows.Forms.Label label4;
        /// <summary>
        /// The slide start y numeric
        /// </summary>
        public System.Windows.Forms.NumericUpDown slide_StartY_Numeric;
        /// <summary>
        /// The label1
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// The slide end x numeric
        /// </summary>
        public System.Windows.Forms.NumericUpDown slide_EndX_Numeric;
        /// <summary>
        /// The label3
        /// </summary>
        private System.Windows.Forms.Label label3;
        /// <summary>
        /// The slide start x numeric
        /// </summary>
        public System.Windows.Forms.NumericUpDown slide_StartX_Numeric;
        /// <summary>
        /// The slide preview BTN
        /// </summary>
        public System.Windows.Forms.Button slide_Preview_btn;
        /// <summary>
        /// The slide rotating cube
        /// </summary>
        public Transitions._HelpingControls.Rotating3DCube.RotatingCube slide_Rotating_Cube;
        /// <summary>
        /// The slide animator
        /// </summary>
        public ZeroitPizaroAnimator.ZeroitPizaroAnim slide_Animator;
    }
}
