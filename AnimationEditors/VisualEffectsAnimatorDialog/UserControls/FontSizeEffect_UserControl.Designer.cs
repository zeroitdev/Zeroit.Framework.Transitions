// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 11-17-2018
// ***********************************************************************
// <copyright file="FontSizeEffect_UserControl.Designer.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    partial class FontSizeEffect_UserControl
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
            this.fontSize_Preview_Btn = new System.Windows.Forms.Button();
            this.noFlickerPanel1 = new Zeroit.Framework.Transitions.AnimationEditors.NoFlickerPanel();
            this.fontsizeEffect_Label = new System.Windows.Forms.Label();
            this.fontSize_Animator = new Zeroit.Framework.Transitions.ZeroitVisAnim();
            this.noFlickerPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontSize_Preview_Btn
            // 
            this.fontSize_Preview_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.fontSize_Preview_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fontSize_Preview_Btn.FlatAppearance.BorderSize = 0;
            this.fontSize_Preview_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fontSize_Preview_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fontSize_Preview_Btn.Location = new System.Drawing.Point(496, 8);
            this.fontSize_Preview_Btn.Name = "fontSize_Preview_Btn";
            this.fontSize_Preview_Btn.Size = new System.Drawing.Size(80, 27);
            this.fontSize_Preview_Btn.TabIndex = 61;
            this.fontSize_Preview_Btn.Text = "Preview";
            this.fontSize_Preview_Btn.UseVisualStyleBackColor = false;
            this.fontSize_Preview_Btn.Click += new System.EventHandler(this.fontSize_Preview_Btn_Click);
            this.fontSize_Preview_Btn.MouseEnter += new System.EventHandler(this.fontSize_Preview_Btn_MouseEnter);
            this.fontSize_Preview_Btn.MouseLeave += new System.EventHandler(this.fontSize_Preview_Btn_MouseLeave);
            // 
            // noFlickerPanel1
            // 
            this.noFlickerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noFlickerPanel1.Controls.Add(this.fontsizeEffect_Label);
            this.noFlickerPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noFlickerPanel1.Location = new System.Drawing.Point(0, 0);
            this.noFlickerPanel1.Name = "noFlickerPanel1";
            this.noFlickerPanel1.Size = new System.Drawing.Size(593, 222);
            this.noFlickerPanel1.TabIndex = 60;
            // 
            // fontsizeEffect_Label
            // 
            this.fontsizeEffect_Label.AutoSize = true;
            this.fontsizeEffect_Label.Font = new System.Drawing.Font("Curlz MT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontsizeEffect_Label.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.fontsizeEffect_Label.Location = new System.Drawing.Point(120, 73);
            this.fontsizeEffect_Label.Name = "fontsizeEffect_Label";
            this.fontsizeEffect_Label.Size = new System.Drawing.Size(347, 62);
            this.fontsizeEffect_Label.TabIndex = 0;
            this.fontsizeEffect_Label.Text = "FONT SIZE EFFECT";
            this.fontsizeEffect_Label.UseCompatibleTextRendering = true;
            // 
            // fontSize_Animator
            // 
            this.fontSize_Animator.AnimationType = Zeroit.Framework.Transitions.ZeroitVisAnim.GetAnimationType.FontSizeEffect;
            this.fontSize_Animator.Delay = 0;
            this.fontSize_Animator.Duration = 400;
            this.fontSize_Animator.EasingType = Zeroit.Framework.Transitions.ZeroitVisAnim.EasingFunctionTypes.BackEaseIn;
            this.fontSize_Animator.Loops = 1;
            this.fontSize_Animator.Reverse = true;
            this.fontSize_Animator.Target = this.fontsizeEffect_Label;
            this.fontSize_Animator.ValueToReach = 60;
            // 
            // FontSizeEffect_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.fontSize_Preview_Btn);
            this.Controls.Add(this.noFlickerPanel1);
            this.Name = "FontSizeEffect_UserControl";
            this.Size = new System.Drawing.Size(593, 222);
            this.noFlickerPanel1.ResumeLayout(false);
            this.noFlickerPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NoFlickerPanel noFlickerPanel1;
        public System.Windows.Forms.Button fontSize_Preview_Btn;
        private System.Windows.Forms.Label fontsizeEffect_Label;
        public ZeroitVisAnim fontSize_Animator;
    }
}
