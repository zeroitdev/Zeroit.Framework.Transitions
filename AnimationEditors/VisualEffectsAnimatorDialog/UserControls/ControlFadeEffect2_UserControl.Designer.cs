﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 11-17-2018
// ***********************************************************************
// <copyright file="ControlFadeEffect2_UserControl.Designer.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    partial class ControlFadeEffect2_UserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlFade2_Animator = new Zeroit.Framework.Transitions.ZeroitVisAnim();
            this.controlFadeEffect2_Preview_Btn = new System.Windows.Forms.Button();
            this.bottomAnchored_RotatingCube = new Transitions._HelpingControls.Rotating3DCube.RotatingCube();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bottomAnchored_RotatingCube);
            this.panel1.Controls.Add(this.controlFadeEffect2_Preview_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 222);
            this.panel1.TabIndex = 62;
            // 
            // controlFade2_Animator
            // 
            this.controlFade2_Animator.AnimationType = Zeroit.Framework.Transitions.ZeroitVisAnim.GetAnimationType.ControlFadeEffect2;
            this.controlFade2_Animator.Delay = 0;
            this.controlFade2_Animator.Duration = 2000;
            this.controlFade2_Animator.EasingType = Zeroit.Framework.Transitions.ZeroitVisAnim.EasingFunctionTypes.BounceEaseOutIn;
            this.controlFade2_Animator.Loops = 1;
            this.controlFade2_Animator.Reverse = true;
            this.controlFade2_Animator.Target = this.panel1;
            this.controlFade2_Animator.ValueToReach = 10;
            // 
            // controlFadeEffect2_Preview_Btn
            // 
            this.controlFadeEffect2_Preview_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.controlFadeEffect2_Preview_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlFadeEffect2_Preview_Btn.FlatAppearance.BorderSize = 0;
            this.controlFadeEffect2_Preview_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlFadeEffect2_Preview_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.controlFadeEffect2_Preview_Btn.Location = new System.Drawing.Point(496, 8);
            this.controlFadeEffect2_Preview_Btn.Name = "controlFadeEffect2_Preview_Btn";
            this.controlFadeEffect2_Preview_Btn.Size = new System.Drawing.Size(80, 27);
            this.controlFadeEffect2_Preview_Btn.TabIndex = 62;
            this.controlFadeEffect2_Preview_Btn.Text = "Preview";
            this.controlFadeEffect2_Preview_Btn.UseVisualStyleBackColor = false;
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
            this.bottomAnchored_RotatingCube.TabIndex = 63;
            this.bottomAnchored_RotatingCube.Text = "rotatingCube1";
            // 
            // ControlFadeEffect2_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.panel1);
            this.Name = "ControlFadeEffect2_UserControl";
            this.Size = new System.Drawing.Size(593, 222);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public ZeroitVisAnim controlFade2_Animator;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button controlFadeEffect2_Preview_Btn;
        private Transitions._HelpingControls.Rotating3DCube.RotatingCube bottomAnchored_RotatingCube;
    }
}