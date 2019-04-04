// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 11-17-2018
// ***********************************************************************
// <copyright file="ControlFadeEffect_UserControl.Designer.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    partial class ControlFadeEffect_UserControl
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
            this.controlFade_Preview_Btn = new System.Windows.Forms.Button();
            this.noFlickerPanel1 = new Zeroit.Framework.Transitions.AnimationEditors.NoFlickerPanel();
            this.controlFade_Animator = new Zeroit.Framework.Transitions.ZeroitVisAnim();
            this.SuspendLayout();
            // 
            // controlFade_Preview_Btn
            // 
            this.controlFade_Preview_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.controlFade_Preview_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlFade_Preview_Btn.FlatAppearance.BorderSize = 0;
            this.controlFade_Preview_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlFade_Preview_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.controlFade_Preview_Btn.Location = new System.Drawing.Point(510, 3);
            this.controlFade_Preview_Btn.Name = "controlFade_Preview_Btn";
            this.controlFade_Preview_Btn.Size = new System.Drawing.Size(80, 27);
            this.controlFade_Preview_Btn.TabIndex = 62;
            this.controlFade_Preview_Btn.Text = "Preview";
            this.controlFade_Preview_Btn.UseVisualStyleBackColor = false;
            this.controlFade_Preview_Btn.Click += new System.EventHandler(this.controlFade_Preview_Btn_Click);
            this.controlFade_Preview_Btn.MouseEnter += new System.EventHandler(this.controlFade_Preview_Btn_MouseEnter);
            this.controlFade_Preview_Btn.MouseLeave += new System.EventHandler(this.controlFade_Preview_Btn_MouseLeave);
            // 
            // noFlickerPanel1
            // 
            this.noFlickerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noFlickerPanel1.Location = new System.Drawing.Point(0, 36);
            this.noFlickerPanel1.Name = "noFlickerPanel1";
            this.noFlickerPanel1.Size = new System.Drawing.Size(593, 186);
            this.noFlickerPanel1.TabIndex = 60;
            // 
            // controlFade_Animator
            // 
            this.controlFade_Animator.AnimationType = Zeroit.Framework.Transitions.ZeroitVisAnim.GetAnimationType.ControlFadeEffect;
            this.controlFade_Animator.Delay = 0;
            this.controlFade_Animator.Duration = 2000;
            this.controlFade_Animator.EasingType = Zeroit.Framework.Transitions.ZeroitVisAnim.EasingFunctionTypes.BounceEaseOutIn;
            this.controlFade_Animator.Loops = 1;
            this.controlFade_Animator.Reverse = true;
            this.controlFade_Animator.Target = this.noFlickerPanel1;
            this.controlFade_Animator.ValueToReach = 0;
            // 
            // ControlFadeEffect_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.controlFade_Preview_Btn);
            this.Controls.Add(this.noFlickerPanel1);
            this.Name = "ControlFadeEffect_UserControl";
            this.Size = new System.Drawing.Size(593, 222);
            this.ResumeLayout(false);

        }

        #endregion

        private NoFlickerPanel noFlickerPanel1;
        public ZeroitVisAnim controlFade_Animator;
        public System.Windows.Forms.Button controlFade_Preview_Btn;
    }
}
