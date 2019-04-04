// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 11-17-2018
// ***********************************************************************
// <copyright file="XLocation_UserControl.Designer.cs" company="Zeroit Dev Technologies">
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
    partial class XLocation_UserControl
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
            this.xLocation_Preview_Btn = new System.Windows.Forms.Button();
            this.rotatingCube1 = new Transitions._HelpingControls.Rotating3DCube.RotatingCube();
            this.xLocation_Animator = new Zeroit.Framework.Transitions.ZeroitVisAnim();
            this.noFlickerPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // noFlickerPanel1
            // 
            this.noFlickerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noFlickerPanel1.Controls.Add(this.xLocation_Preview_Btn);
            this.noFlickerPanel1.Controls.Add(this.rotatingCube1);
            this.noFlickerPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noFlickerPanel1.Location = new System.Drawing.Point(0, 0);
            this.noFlickerPanel1.Name = "noFlickerPanel1";
            this.noFlickerPanel1.Size = new System.Drawing.Size(593, 222);
            this.noFlickerPanel1.TabIndex = 60;
            // 
            // xLocation_Preview_Btn
            // 
            this.xLocation_Preview_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.xLocation_Preview_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xLocation_Preview_Btn.FlatAppearance.BorderSize = 0;
            this.xLocation_Preview_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xLocation_Preview_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.xLocation_Preview_Btn.Location = new System.Drawing.Point(496, 8);
            this.xLocation_Preview_Btn.Name = "xLocation_Preview_Btn";
            this.xLocation_Preview_Btn.Size = new System.Drawing.Size(80, 27);
            this.xLocation_Preview_Btn.TabIndex = 61;
            this.xLocation_Preview_Btn.Text = "Preview";
            this.xLocation_Preview_Btn.UseVisualStyleBackColor = false;
            this.xLocation_Preview_Btn.Click += new System.EventHandler(this.xLocation_Preview_Btn_Click);
            this.xLocation_Preview_Btn.MouseEnter += new System.EventHandler(this.xLocation_Preview_Btn_MouseEnter);
            this.xLocation_Preview_Btn.MouseLeave += new System.EventHandler(this.xLocation_Preview_Btn_MouseLeave);
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
            // xLocation_Animator
            // 
            this.xLocation_Animator.AnimationType = Zeroit.Framework.Transitions.ZeroitVisAnim.GetAnimationType.XLocationEffect;
            this.xLocation_Animator.Delay = 0;
            this.xLocation_Animator.Duration = 2000;
            this.xLocation_Animator.EasingType = Zeroit.Framework.Transitions.ZeroitVisAnim.EasingFunctionTypes.BounceEaseOutIn;
            this.xLocation_Animator.Loops = 1;
            this.xLocation_Animator.Reverse = true;
            this.xLocation_Animator.Target = this;
            this.xLocation_Animator.ValueToReach = 350;
            // 
            // XLocation_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.noFlickerPanel1);
            this.Name = "XLocation_UserControl";
            this.Size = new System.Drawing.Size(593, 222);
            this.noFlickerPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NoFlickerPanel noFlickerPanel1;
        private Transitions._HelpingControls.Rotating3DCube.RotatingCube rotatingCube1;
        public System.Windows.Forms.Button xLocation_Preview_Btn;
        public ZeroitVisAnim xLocation_Animator;
    }
}
