﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 11-17-2018
// ***********************************************************************
// <copyright file="HorizontalFoldEffect_UserControl.Designer.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    partial class HorizontalFoldEffect_UserControl
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
            this.noFlickerPanel1 = new Zeroit.Framework.Transitions.AnimationEditors.NoFlickerPanel();
            this.horizontalFold_Preview_Btn = new System.Windows.Forms.Button();
            this.rotatingCube1 = new Transitions._HelpingControls.Rotating3DCube.RotatingCube();
            this.horizontalFold_Animator = new Zeroit.Framework.Transitions.ZeroitVisAnim();
            this.noFlickerPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // noFlickerPanel1
            // 
            this.noFlickerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noFlickerPanel1.Controls.Add(this.horizontalFold_Preview_Btn);
            this.noFlickerPanel1.Controls.Add(this.rotatingCube1);
            this.noFlickerPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noFlickerPanel1.Location = new System.Drawing.Point(0, 0);
            this.noFlickerPanel1.Name = "noFlickerPanel1";
            this.noFlickerPanel1.Size = new System.Drawing.Size(593, 222);
            this.noFlickerPanel1.TabIndex = 60;
            // 
            // horizontalFold_Preview_Btn
            // 
            this.horizontalFold_Preview_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.horizontalFold_Preview_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.horizontalFold_Preview_Btn.FlatAppearance.BorderSize = 0;
            this.horizontalFold_Preview_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.horizontalFold_Preview_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.horizontalFold_Preview_Btn.Location = new System.Drawing.Point(496, 8);
            this.horizontalFold_Preview_Btn.Name = "horizontalFold_Preview_Btn";
            this.horizontalFold_Preview_Btn.Size = new System.Drawing.Size(80, 27);
            this.horizontalFold_Preview_Btn.TabIndex = 61;
            this.horizontalFold_Preview_Btn.Text = "Preview";
            this.horizontalFold_Preview_Btn.UseVisualStyleBackColor = false;
            this.horizontalFold_Preview_Btn.Click += new System.EventHandler(this.horizontalFold_Preview_Btn_Click);
            this.horizontalFold_Preview_Btn.MouseEnter += new System.EventHandler(this.horizontalFold_Preview_Btn_MouseEnter);
            this.horizontalFold_Preview_Btn.MouseLeave += new System.EventHandler(this.horizontalFold_Preview_Btn_MouseLeave);
            // 
            // rotatingCube1
            // 
            this.rotatingCube1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rotatingCube1.AutoAnimate = true;
            this.rotatingCube1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
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
            this.rotatingCube1.SpeedAdjust = 5;
            this.rotatingCube1.TabIndex = 59;
            this.rotatingCube1.Text = "rotatingCube1";
            // 
            // horizontalFold_Animator
            // 
            this.horizontalFold_Animator.AnimationType = Zeroit.Framework.Transitions.ZeroitVisAnim.GetAnimationType.HorizontalFoldEffect;
            this.horizontalFold_Animator.Delay = 0;
            this.horizontalFold_Animator.Duration = 2000;
            this.horizontalFold_Animator.EasingType = Zeroit.Framework.Transitions.ZeroitVisAnim.EasingFunctionTypes.BounceEaseOutIn;
            this.horizontalFold_Animator.Loops = 1;
            this.horizontalFold_Animator.Reverse = true;
            this.horizontalFold_Animator.Target = this;
            this.horizontalFold_Animator.ValueToReach = 200;
            // 
            // HorizontalFoldEffect_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.noFlickerPanel1);
            this.Name = "HorizontalFoldEffect_UserControl";
            this.Size = new System.Drawing.Size(593, 222);
            this.noFlickerPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NoFlickerPanel noFlickerPanel1;
        private Transitions._HelpingControls.Rotating3DCube.RotatingCube rotatingCube1;
        public System.Windows.Forms.Button horizontalFold_Preview_Btn;
        public ZeroitVisAnim horizontalFold_Animator;
    }
}
