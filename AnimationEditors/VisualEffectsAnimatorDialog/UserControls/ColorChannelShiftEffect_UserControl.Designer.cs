// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 11-17-2018
// ***********************************************************************
// <copyright file="ColorChannelShiftEffect_UserControl.Designer.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    partial class ColorChannelShiftEffect_UserControl
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
            this.colorChannelShift_Preview_Btn = new System.Windows.Forms.Button();
            this.colorChannelShift_RotatingCube = new Transitions._HelpingControls.Rotating3DCube.RotatingCube();
            this.colorChannelShift_Animator = new Zeroit.Framework.Transitions.ZeroitVisAnim();
            this.colorChann_RotatingCube_Animator = new Zeroit.Framework.Transitions.ZeroitVisAnim();
            this.noFlickerPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // noFlickerPanel1
            // 
            this.noFlickerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noFlickerPanel1.Controls.Add(this.colorChannelShift_Preview_Btn);
            this.noFlickerPanel1.Controls.Add(this.colorChannelShift_RotatingCube);
            this.noFlickerPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noFlickerPanel1.Location = new System.Drawing.Point(0, 0);
            this.noFlickerPanel1.Name = "noFlickerPanel1";
            this.noFlickerPanel1.Size = new System.Drawing.Size(593, 222);
            this.noFlickerPanel1.TabIndex = 60;
            // 
            // colorChannelShift_Preview_Btn
            // 
            this.colorChannelShift_Preview_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.colorChannelShift_Preview_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorChannelShift_Preview_Btn.FlatAppearance.BorderSize = 0;
            this.colorChannelShift_Preview_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorChannelShift_Preview_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.colorChannelShift_Preview_Btn.Location = new System.Drawing.Point(496, 8);
            this.colorChannelShift_Preview_Btn.Name = "colorChannelShift_Preview_Btn";
            this.colorChannelShift_Preview_Btn.Size = new System.Drawing.Size(80, 27);
            this.colorChannelShift_Preview_Btn.TabIndex = 61;
            this.colorChannelShift_Preview_Btn.Text = "Preview";
            this.colorChannelShift_Preview_Btn.UseVisualStyleBackColor = false;
            this.colorChannelShift_Preview_Btn.Click += new System.EventHandler(this.colorChannelShift_Preview_Btn_Click);
            this.colorChannelShift_Preview_Btn.MouseEnter += new System.EventHandler(this.colorChannelShift_Preview_Btn_MouseEnter);
            this.colorChannelShift_Preview_Btn.MouseLeave += new System.EventHandler(this.colorChannelShift_Preview_Btn_MouseLeave);
            // 
            // colorChannelShift_RotatingCube
            // 
            this.colorChannelShift_RotatingCube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorChannelShift_RotatingCube.AutoAnimate = true;
            this.colorChannelShift_RotatingCube.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.colorChannelShift_RotatingCube.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.BlueViolet,
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Green,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Violet,
        System.Drawing.Color.LightSkyBlue};
            this.colorChannelShift_RotatingCube.Location = new System.Drawing.Point(231, 35);
            this.colorChannelShift_RotatingCube.Name = "colorChannelShift_RotatingCube";
            this.colorChannelShift_RotatingCube.Shrink = 4;
            this.colorChannelShift_RotatingCube.Size = new System.Drawing.Size(118, 124);
            this.colorChannelShift_RotatingCube.SpeedAdjust = 5;
            this.colorChannelShift_RotatingCube.TabIndex = 59;
            this.colorChannelShift_RotatingCube.Text = "rotatingCube1";
            // 
            // colorChannelShift_Animator
            // 
            this.colorChannelShift_Animator.AnimationType = Zeroit.Framework.Transitions.ZeroitVisAnim.GetAnimationType.ColorChannelShiftEffect;
            this.colorChannelShift_Animator.Delay = 0;
            this.colorChannelShift_Animator.Duration = 2000;
            this.colorChannelShift_Animator.EasingType = Zeroit.Framework.Transitions.ZeroitVisAnim.EasingFunctionTypes.BackEaseIn;
            this.colorChannelShift_Animator.Loops = 1;
            this.colorChannelShift_Animator.Reverse = true;
            this.colorChannelShift_Animator.Target = this;
            this.colorChannelShift_Animator.ValueToReach = 255;
            // 
            // colorChann_RotatingCube_Animator
            // 
            this.colorChann_RotatingCube_Animator.AnimationType = Zeroit.Framework.Transitions.ZeroitVisAnim.GetAnimationType.ColorChannelShiftEffect;
            this.colorChann_RotatingCube_Animator.Delay = 0;
            this.colorChann_RotatingCube_Animator.Duration = 2000;
            this.colorChann_RotatingCube_Animator.EasingType = Zeroit.Framework.Transitions.ZeroitVisAnim.EasingFunctionTypes.BackEaseIn;
            this.colorChann_RotatingCube_Animator.Loops = 1;
            this.colorChann_RotatingCube_Animator.Reverse = true;
            this.colorChann_RotatingCube_Animator.Target = this.colorChannelShift_RotatingCube;
            this.colorChann_RotatingCube_Animator.ValueToReach = 255;
            // 
            // ColorChannelShiftEffect_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.noFlickerPanel1);
            this.Name = "ColorChannelShiftEffect_UserControl";
            this.Size = new System.Drawing.Size(593, 222);
            this.noFlickerPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NoFlickerPanel noFlickerPanel1;
        private Transitions._HelpingControls.Rotating3DCube.RotatingCube colorChannelShift_RotatingCube;
        public System.Windows.Forms.Button colorChannelShift_Preview_Btn;
        public ZeroitVisAnim colorChannelShift_Animator;
        public ZeroitVisAnim colorChann_RotatingCube_Animator;
    }
}
