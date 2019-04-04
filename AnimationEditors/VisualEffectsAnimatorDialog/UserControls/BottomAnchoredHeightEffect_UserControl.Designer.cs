﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 11-17-2018
// ***********************************************************************
// <copyright file="BottomAnchoredHeightEffect_UserControl.Designer.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    partial class BottomAnchoredHeightEffect_UserControl
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
            this.noFlickerPanel1 = new Zeroit.Framework.Transitions.AnimationEditors.NoFlickerPanel();
            this.bottomAnchored_Preview_Btn = new System.Windows.Forms.Button();
            this.bottomAnchored_RotatingCube = new Transitions._HelpingControls.Rotating3DCube.RotatingCube();
            this.bottomAnchored_Animator = new Zeroit.Framework.Transitions.ZeroitVisAnim();
            this.noFlickerPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // noFlickerPanel1
            // 
            this.noFlickerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noFlickerPanel1.Controls.Add(this.bottomAnchored_Preview_Btn);
            this.noFlickerPanel1.Controls.Add(this.bottomAnchored_RotatingCube);
            this.noFlickerPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noFlickerPanel1.Location = new System.Drawing.Point(0, 0);
            this.noFlickerPanel1.Name = "noFlickerPanel1";
            this.noFlickerPanel1.Size = new System.Drawing.Size(593, 222);
            this.noFlickerPanel1.TabIndex = 59;
            // 
            // bottomAnchored_Preview_Btn
            // 
            this.bottomAnchored_Preview_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.bottomAnchored_Preview_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bottomAnchored_Preview_Btn.FlatAppearance.BorderSize = 0;
            this.bottomAnchored_Preview_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottomAnchored_Preview_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bottomAnchored_Preview_Btn.Location = new System.Drawing.Point(496, 8);
            this.bottomAnchored_Preview_Btn.Name = "bottomAnchored_Preview_Btn";
            this.bottomAnchored_Preview_Btn.Size = new System.Drawing.Size(80, 27);
            this.bottomAnchored_Preview_Btn.TabIndex = 60;
            this.bottomAnchored_Preview_Btn.Text = "Preview";
            this.bottomAnchored_Preview_Btn.UseVisualStyleBackColor = false;
            this.bottomAnchored_Preview_Btn.Click += new System.EventHandler(this.bottomAnchored_Preview_Btn_Click);
            this.bottomAnchored_Preview_Btn.MouseEnter += new System.EventHandler(this.bottomAnchored_Preview_MouseEnter);
            this.bottomAnchored_Preview_Btn.MouseLeave += new System.EventHandler(this.bottomAnchored_Preview_Btn_MouseLeave);
            // 
            // bottomAnchored_RotatingCube
            // 
            this.bottomAnchored_RotatingCube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomAnchored_RotatingCube.AutoAnimate = true;
            this.bottomAnchored_RotatingCube.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.bottomAnchored_RotatingCube.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.BlueViolet,
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Green,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Violet,
        System.Drawing.Color.LightSkyBlue};
            this.bottomAnchored_RotatingCube.Location = new System.Drawing.Point(231, 35);
            this.bottomAnchored_RotatingCube.Name = "bottomAnchored_RotatingCube";
            this.bottomAnchored_RotatingCube.Shrink = 4;
            this.bottomAnchored_RotatingCube.Size = new System.Drawing.Size(118, 124);
            this.bottomAnchored_RotatingCube.SpeedAdjust = 5;
            this.bottomAnchored_RotatingCube.TabIndex = 59;
            this.bottomAnchored_RotatingCube.Text = "rotatingCube1";
            // 
            // bottomAnchored_Animator
            // 
            this.bottomAnchored_Animator.AnimationType = Zeroit.Framework.Transitions.ZeroitVisAnim.GetAnimationType.BottomAnchoredHeightEffect;
            this.bottomAnchored_Animator.Delay = 0;
            this.bottomAnchored_Animator.Duration = 2000;
            this.bottomAnchored_Animator.EasingType = Zeroit.Framework.Transitions.ZeroitVisAnim.EasingFunctionTypes.BounceEaseOutIn;
            this.bottomAnchored_Animator.Loops = 1;
            this.bottomAnchored_Animator.Reverse = true;
            this.bottomAnchored_Animator.Target = this.bottomAnchored_RotatingCube;
            this.bottomAnchored_Animator.ValueToReach = 350;
            // 
            // BottomAnchoredHeightEffect_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.noFlickerPanel1);
            this.Name = "BottomAnchoredHeightEffect_UserControl";
            this.Size = new System.Drawing.Size(593, 222);
            this.noFlickerPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NoFlickerPanel noFlickerPanel1;
        private Transitions._HelpingControls.Rotating3DCube.RotatingCube bottomAnchored_RotatingCube;
        public System.Windows.Forms.Button bottomAnchored_Preview_Btn;
        public ZeroitVisAnim bottomAnchored_Animator;
    }
}
