// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-04-2018
// ***********************************************************************
// <copyright file="Pizaro_SlideFrom_UserControl.Designer.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    /// Class Pizaro_SlideFrom_UserControl.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    partial class Pizaro_SlideFrom_UserControl
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
            this.slideFrom_EndY_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.slideFrom_StartY_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.slideFrom_EndX_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.slideFrom_StartX_Numeric = new System.Windows.Forms.NumericUpDown();
            this.slideFrom_Preview_btn = new System.Windows.Forms.Button();
            this.slideFrom_Rotating_Cube = new Transitions._HelpingControls.Rotating3DCube.RotatingCube();
            this.slideFrom_Animator = new Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideFrom_EndY_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideFrom_StartY_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideFrom_EndX_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideFrom_StartX_Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.slideFrom_EndY_Numeric);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.slideFrom_StartY_Numeric);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.slideFrom_EndX_Numeric);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.slideFrom_StartX_Numeric);
            this.groupBox1.Controls.Add(this.slideFrom_Preview_btn);
            this.groupBox1.Controls.Add(this.slideFrom_Rotating_Cube);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 190);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SlideFrom Animation";
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
            // slideFrom_EndY_Numeric
            // 
            this.slideFrom_EndY_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.slideFrom_EndY_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slideFrom_EndY_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.slideFrom_EndY_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.slideFrom_EndY_Numeric.Location = new System.Drawing.Point(378, 109);
            this.slideFrom_EndY_Numeric.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.slideFrom_EndY_Numeric.Name = "slideFrom_EndY_Numeric";
            this.slideFrom_EndY_Numeric.Size = new System.Drawing.Size(76, 29);
            this.slideFrom_EndY_Numeric.TabIndex = 43;
            this.slideFrom_EndY_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.slideFrom_EndY_Numeric.Value = new decimal(new int[] {
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
            // slideFrom_StartY_Numeric
            // 
            this.slideFrom_StartY_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.slideFrom_StartY_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slideFrom_StartY_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.slideFrom_StartY_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.slideFrom_StartY_Numeric.Location = new System.Drawing.Point(378, 35);
            this.slideFrom_StartY_Numeric.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.slideFrom_StartY_Numeric.Name = "slideFrom_StartY_Numeric";
            this.slideFrom_StartY_Numeric.Size = new System.Drawing.Size(76, 29);
            this.slideFrom_StartY_Numeric.TabIndex = 41;
            this.slideFrom_StartY_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.slideFrom_StartY_Numeric.Value = new decimal(new int[] {
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
            // slideFrom_EndX_Numeric
            // 
            this.slideFrom_EndX_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.slideFrom_EndX_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slideFrom_EndX_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.slideFrom_EndX_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.slideFrom_EndX_Numeric.Location = new System.Drawing.Point(161, 109);
            this.slideFrom_EndX_Numeric.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.slideFrom_EndX_Numeric.Name = "slideFrom_EndX_Numeric";
            this.slideFrom_EndX_Numeric.Size = new System.Drawing.Size(76, 29);
            this.slideFrom_EndX_Numeric.TabIndex = 39;
            this.slideFrom_EndX_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.slideFrom_EndX_Numeric.Value = new decimal(new int[] {
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
            // slideFrom_StartX_Numeric
            // 
            this.slideFrom_StartX_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.slideFrom_StartX_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slideFrom_StartX_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.slideFrom_StartX_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.slideFrom_StartX_Numeric.Location = new System.Drawing.Point(161, 37);
            this.slideFrom_StartX_Numeric.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.slideFrom_StartX_Numeric.Name = "slideFrom_StartX_Numeric";
            this.slideFrom_StartX_Numeric.Size = new System.Drawing.Size(76, 29);
            this.slideFrom_StartX_Numeric.TabIndex = 37;
            this.slideFrom_StartX_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.slideFrom_StartX_Numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // slideFrom_Preview_btn
            // 
            this.slideFrom_Preview_btn.FlatAppearance.BorderSize = 0;
            this.slideFrom_Preview_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slideFrom_Preview_btn.Font = new System.Drawing.Font("Verdana", 10F);
            this.slideFrom_Preview_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.slideFrom_Preview_btn.Location = new System.Drawing.Point(561, 25);
            this.slideFrom_Preview_btn.Name = "slideFrom_Preview_btn";
            this.slideFrom_Preview_btn.Size = new System.Drawing.Size(104, 28);
            this.slideFrom_Preview_btn.TabIndex = 36;
            this.slideFrom_Preview_btn.Text = "Preview";
            this.slideFrom_Preview_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.slideFrom_Preview_btn.UseVisualStyleBackColor = false;
            this.slideFrom_Preview_btn.Click += new System.EventHandler(this.slideFrom_Preview_btn_Click);
            this.slideFrom_Preview_btn.MouseEnter += new System.EventHandler(this.slideFrom_Preview_btn_MouseEnter);
            this.slideFrom_Preview_btn.MouseLeave += new System.EventHandler(this.slideFrom_Preview_btn_MouseLeave);
            // 
            // slideFrom_Rotating_Cube
            // 
            this.slideFrom_Rotating_Cube.AutoAnimate = true;
            this.slideFrom_Rotating_Cube.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.BlueViolet,
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Green,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Violet,
        System.Drawing.Color.LightSkyBlue};
            this.slideFrom_Rotating_Cube.Location = new System.Drawing.Point(574, 66);
            this.slideFrom_Rotating_Cube.Name = "slideFrom_Rotating_Cube";
            this.slideFrom_Rotating_Cube.Shrink = 4;
            this.slideFrom_Rotating_Cube.Size = new System.Drawing.Size(84, 86);
            this.slideFrom_Rotating_Cube.SpeedAdjust = 10;
            this.slideFrom_Rotating_Cube.TabIndex = 0;
            this.slideFrom_Rotating_Cube.Text = "rotatingCube1";
            // 
            // slideFrom_Animator
            // 
            this.slideFrom_Animator.Acceleration = 0.7D;
            this.slideFrom_Animator.AnimationType = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.animationType.SlideFrom;
            this.slideFrom_Animator.Control = this.slideFrom_Rotating_Cube;
            this.slideFrom_Animator.ControlStyles = System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer;
            this.slideFrom_Animator.ControlStylesBool = false;
            this.slideFrom_Animator.CordinateEnd_X = 50D;
            this.slideFrom_Animator.CordinateEnd_Y = 50D;
            this.slideFrom_Animator.CordinateStart_X = 10D;
            this.slideFrom_Animator.CordinateStart_Y = 10D;
            this.slideFrom_Animator.Duration = 1000;
            this.slideFrom_Animator.EasingEnd = 1D;
            this.slideFrom_Animator.EasingNames = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseIn;
            this.slideFrom_Animator.EasingStart = 0.2D;
            this.slideFrom_Animator.Fade_Begin = 0D;
            this.slideFrom_Animator.Fade_Limit = 1D;
            this.slideFrom_Animator.ResizeHeight_Begin = 10D;
            this.slideFrom_Animator.ResizeHeight_Limit = 50D;
            this.slideFrom_Animator.ResizeWidth_Begin = 10D;
            this.slideFrom_Animator.ResizeWidth_Limit = 50D;
            // 
            // Pizaro_SlideFrom_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.groupBox1);
            this.Name = "Pizaro_SlideFrom_UserControl";
            this.Size = new System.Drawing.Size(686, 190);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideFrom_EndY_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideFrom_StartY_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideFrom_EndX_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideFrom_StartX_Numeric)).EndInit();
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
        /// The slide from end y numeric
        /// </summary>
        public System.Windows.Forms.NumericUpDown slideFrom_EndY_Numeric;
        /// <summary>
        /// The label4
        /// </summary>
        private System.Windows.Forms.Label label4;
        /// <summary>
        /// The slide from start y numeric
        /// </summary>
        public System.Windows.Forms.NumericUpDown slideFrom_StartY_Numeric;
        /// <summary>
        /// The label1
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// The slide from end x numeric
        /// </summary>
        public System.Windows.Forms.NumericUpDown slideFrom_EndX_Numeric;
        /// <summary>
        /// The label3
        /// </summary>
        private System.Windows.Forms.Label label3;
        /// <summary>
        /// The slide from start x numeric
        /// </summary>
        public System.Windows.Forms.NumericUpDown slideFrom_StartX_Numeric;
        /// <summary>
        /// The slide from preview BTN
        /// </summary>
        public System.Windows.Forms.Button slideFrom_Preview_btn;
        /// <summary>
        /// The slide from rotating cube
        /// </summary>
        public Transitions._HelpingControls.Rotating3DCube.RotatingCube slideFrom_Rotating_Cube;
        /// <summary>
        /// The slide from animator
        /// </summary>
        public ZeroitPizaroAnimator.ZeroitPizaroAnim slideFrom_Animator;
    }
}
