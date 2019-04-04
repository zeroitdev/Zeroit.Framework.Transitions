// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 07-02-2018
// ***********************************************************************
// <copyright file="Pizaro_Fade_UserControl.Designer.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    /// Class Pizaro_Fade_UserControl.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    partial class Pizaro_Fade_UserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.fade_Limit_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.fade_Begin_Numeric = new System.Windows.Forms.NumericUpDown();
            this.fade_Preview_btn = new System.Windows.Forms.Button();
            this.fade_Rotating_Cube = new Transitions._HelpingControls.Rotating3DCube.RotatingCube();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fade_Limit_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fade_Begin_Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fade_Limit_Numeric);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fade_Begin_Numeric);
            this.groupBox1.Controls.Add(this.fade_Preview_btn);
            this.groupBox1.Controls.Add(this.fade_Rotating_Cube);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 190);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fade Animation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(18, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Limit";
            // 
            // fade_Limit_Numeric
            // 
            this.fade_Limit_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.fade_Limit_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fade_Limit_Numeric.DecimalPlaces = 2;
            this.fade_Limit_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fade_Limit_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.fade_Limit_Numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.fade_Limit_Numeric.Location = new System.Drawing.Point(161, 109);
            this.fade_Limit_Numeric.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.fade_Limit_Numeric.Name = "fade_Limit_Numeric";
            this.fade_Limit_Numeric.Size = new System.Drawing.Size(76, 29);
            this.fade_Limit_Numeric.TabIndex = 39;
            this.fade_Limit_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fade_Limit_Numeric.Value = new decimal(new int[] {
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
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 38;
            this.label3.Text = "Begin";
            // 
            // fade_Begin_Numeric
            // 
            this.fade_Begin_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.fade_Begin_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fade_Begin_Numeric.DecimalPlaces = 2;
            this.fade_Begin_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fade_Begin_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.fade_Begin_Numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.fade_Begin_Numeric.Location = new System.Drawing.Point(161, 37);
            this.fade_Begin_Numeric.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.fade_Begin_Numeric.Name = "fade_Begin_Numeric";
            this.fade_Begin_Numeric.Size = new System.Drawing.Size(76, 29);
            this.fade_Begin_Numeric.TabIndex = 37;
            this.fade_Begin_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fade_Begin_Numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fade_Preview_btn
            // 
            this.fade_Preview_btn.FlatAppearance.BorderSize = 0;
            this.fade_Preview_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fade_Preview_btn.Font = new System.Drawing.Font("Verdana", 10F);
            this.fade_Preview_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fade_Preview_btn.Location = new System.Drawing.Point(561, 25);
            this.fade_Preview_btn.Name = "fade_Preview_btn";
            this.fade_Preview_btn.Size = new System.Drawing.Size(104, 28);
            this.fade_Preview_btn.TabIndex = 36;
            this.fade_Preview_btn.Text = "Preview";
            this.fade_Preview_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fade_Preview_btn.UseVisualStyleBackColor = false;
            this.fade_Preview_btn.Visible = false;
            this.fade_Preview_btn.MouseEnter += new System.EventHandler(this.fade_Preview_btn_MouseEnter);
            this.fade_Preview_btn.MouseLeave += new System.EventHandler(this.fade_Preview_btn_MouseLeave);
            // 
            // fade_Rotating_Cube
            // 
            this.fade_Rotating_Cube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fade_Rotating_Cube.AutoAnimate = true;
            this.fade_Rotating_Cube.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.BlueViolet,
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Green,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Violet,
        System.Drawing.Color.LightSkyBlue};
            this.fade_Rotating_Cube.Location = new System.Drawing.Point(574, 66);
            this.fade_Rotating_Cube.Name = "fade_Rotating_Cube";
            this.fade_Rotating_Cube.Shrink = 4;
            this.fade_Rotating_Cube.Size = new System.Drawing.Size(84, 86);
            this.fade_Rotating_Cube.SpeedAdjust = 10;
            this.fade_Rotating_Cube.TabIndex = 0;
            this.fade_Rotating_Cube.Text = "rotatingCube1";
            // 
            // Pizaro_Fade_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.groupBox1);
            this.Name = "Pizaro_Fade_UserControl";
            this.Size = new System.Drawing.Size(686, 190);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fade_Limit_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fade_Begin_Numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The group box1
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox1;
        /// <summary>
        /// The fade preview BTN
        /// </summary>
        public System.Windows.Forms.Button fade_Preview_btn;
        /// <summary>
        /// The fade begin numeric
        /// </summary>
        public System.Windows.Forms.NumericUpDown fade_Begin_Numeric;
        /// <summary>
        /// The label1
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// The fade limit numeric
        /// </summary>
        public System.Windows.Forms.NumericUpDown fade_Limit_Numeric;
        /// <summary>
        /// The label3
        /// </summary>
        private System.Windows.Forms.Label label3;
        /// <summary>
        /// The fade rotating cube
        /// </summary>
        public Transitions._HelpingControls.Rotating3DCube.RotatingCube fade_Rotating_Cube;
    }
}
