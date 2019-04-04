// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 11-17-2018
// ***********************************************************************
// <copyright file="ScaleAndHorizSlide_UserControl.Designer.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    partial class ScaleAndHorizSlide_UserControl
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
            Zeroit.Framework.Transitions.ZeroitAnimate_Animation zeroitAnimate_Animation1 = new Zeroit.Framework.Transitions.ZeroitAnimate_Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScaleAndHorizSlide_UserControl));
            this.zeroitAnimate_Animator1 = new Zeroit.Framework.Transitions.ZeroitAnimator(this.components);
            this.scaleAndHorizSlide_RotatingCube = new Transitions._HelpingControls.Rotating3DCube.RotatingCube();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scaleAndHorizSlide_Preview_Btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zeroitAnimate_Animator1
            // 
            this.zeroitAnimate_Animator1.AnimationType = Zeroit.Framework.Transitions.AnimationType.ScaleAndHorizSlide;
            this.zeroitAnimate_Animator1.Cursor = null;
            zeroitAnimate_Animation1.AnimateOnlyDifferences = true;
            zeroitAnimate_Animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation1.BlindCoeff")));
            zeroitAnimate_Animation1.LeafCoeff = 0F;
            zeroitAnimate_Animation1.MaxTime = 1F;
            zeroitAnimate_Animation1.MinTime = 0F;
            zeroitAnimate_Animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation1.MosaicCoeff")));
            zeroitAnimate_Animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation1.MosaicShift")));
            zeroitAnimate_Animation1.MosaicSize = 0;
            zeroitAnimate_Animation1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            zeroitAnimate_Animation1.RotateCoeff = 0F;
            zeroitAnimate_Animation1.RotateLimit = 0F;
            zeroitAnimate_Animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation1.ScaleCoeff")));
            zeroitAnimate_Animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation1.SlideCoeff")));
            zeroitAnimate_Animation1.TimeCoeff = 0F;
            zeroitAnimate_Animation1.TransparencyCoeff = 0F;
            this.zeroitAnimate_Animator1.DefaultAnimation = zeroitAnimate_Animation1;
            this.zeroitAnimate_Animator1.Target = this.scaleAndHorizSlide_RotatingCube;
            this.zeroitAnimate_Animator1.TargetHeight = 124;
            this.zeroitAnimate_Animator1.TargetWidth = 118;
            // 
            // scaleAndHorizSlide_RotatingCube
            // 
            this.scaleAndHorizSlide_RotatingCube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleAndHorizSlide_RotatingCube.AutoAnimate = true;
            this.scaleAndHorizSlide_RotatingCube.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.scaleAndHorizSlide_RotatingCube.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.BlueViolet,
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Green,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Violet,
        System.Drawing.Color.LightSkyBlue};
            this.zeroitAnimate_Animator1.SetDecoration(this.scaleAndHorizSlide_RotatingCube, Zeroit.Framework.Transitions.DecorationType.None);
            this.scaleAndHorizSlide_RotatingCube.Location = new System.Drawing.Point(202, 35);
            this.scaleAndHorizSlide_RotatingCube.Name = "scaleAndHorizSlide_RotatingCube";
            this.scaleAndHorizSlide_RotatingCube.Shrink = 4;
            this.scaleAndHorizSlide_RotatingCube.Size = new System.Drawing.Size(118, 124);
            this.scaleAndHorizSlide_RotatingCube.SpeedAdjust = 5;
            this.scaleAndHorizSlide_RotatingCube.TabIndex = 63;
            this.scaleAndHorizSlide_RotatingCube.Text = "rotatingCube1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.zeroitAnimate_Animator1.SetDecoration(this.groupBox1, Zeroit.Framework.Transitions.DecorationType.None);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scale and Horiz Slide";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.scaleAndHorizSlide_RotatingCube);
            this.panel1.Controls.Add(this.scaleAndHorizSlide_Preview_Btn);
            this.zeroitAnimate_Animator1.SetDecoration(this.panel1, Zeroit.Framework.Transitions.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 198);
            this.panel1.TabIndex = 63;
            // 
            // scaleAndHorizSlide_Preview_Btn
            // 
            this.scaleAndHorizSlide_Preview_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleAndHorizSlide_Preview_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.scaleAndHorizSlide_Preview_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zeroitAnimate_Animator1.SetDecoration(this.scaleAndHorizSlide_Preview_Btn, Zeroit.Framework.Transitions.DecorationType.None);
            this.scaleAndHorizSlide_Preview_Btn.FlatAppearance.BorderSize = 0;
            this.scaleAndHorizSlide_Preview_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scaleAndHorizSlide_Preview_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.scaleAndHorizSlide_Preview_Btn.Location = new System.Drawing.Point(467, 8);
            this.scaleAndHorizSlide_Preview_Btn.Name = "scaleAndHorizSlide_Preview_Btn";
            this.scaleAndHorizSlide_Preview_Btn.Size = new System.Drawing.Size(80, 27);
            this.scaleAndHorizSlide_Preview_Btn.TabIndex = 62;
            this.scaleAndHorizSlide_Preview_Btn.Text = "Preview";
            this.scaleAndHorizSlide_Preview_Btn.UseVisualStyleBackColor = false;
            this.scaleAndHorizSlide_Preview_Btn.Click += new System.EventHandler(this.scaleAndHorizSlide_Preview_Btn_Click);
            this.scaleAndHorizSlide_Preview_Btn.MouseEnter += new System.EventHandler(this.scaleAndHorizSlide_Preview_Btn_MouseEnter);
            this.scaleAndHorizSlide_Preview_Btn.MouseLeave += new System.EventHandler(this.scaleAndHorizSlide_Preview_Btn_MouseLeave);
            // 
            // ScaleAndHorizSlide_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.groupBox1);
            this.zeroitAnimate_Animator1.SetDecoration(this, Zeroit.Framework.Transitions.DecorationType.None);
            this.Name = "ScaleAndHorizSlide_UserControl";
            this.Size = new System.Drawing.Size(568, 222);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button scaleAndHorizSlide_Preview_Btn;
        public ZeroitAnimator zeroitAnimate_Animator1;
        public Transitions._HelpingControls.Rotating3DCube.RotatingCube scaleAndHorizSlide_RotatingCube;
    }
}
