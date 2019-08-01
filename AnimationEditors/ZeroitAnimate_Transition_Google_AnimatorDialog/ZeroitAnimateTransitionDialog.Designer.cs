// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 11-17-2018
// ***********************************************************************
// <copyright file="ZeroitAnimateTransitionDialog.Designer.cs" company="Zeroit Dev Technologies">
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
    /// <summary>
    /// Class ZeroitAnimateTransitionDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class ZeroitAnimateTransitionDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZeroitAnimateTransitionDialog));
            this.thematic1501 = new Zeroit.Framework.Transitions.ThemeManagers.Orains();
            this.zeroitLBKnob1 = new Zeroit.Framework.Transitions._HelpingControls.LBKnob.ZeroitLBKnob();
            this.zeroitSimpleLine24 = new Zeroit.Framework.Transitions._HelpingControls.LineSimple2();
            this.zeroitSimpleLine23 = new Zeroit.Framework.Transitions._HelpingControls.LineSimple2();
            this.zeroitSimpleLine22 = new Zeroit.Framework.Transitions._HelpingControls.LineSimple2();
            this.zeroitSimpleLine21 = new Zeroit.Framework.Transitions._HelpingControls.LineSimple2();
            this.label7 = new System.Windows.Forms.Label();
            this.mainControl_Position_ComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.animation_GroupBox = new System.Windows.Forms.GroupBox();
            this.animation_RotatingCube = new Zeroit.Framework.Transitions._HelpingControls.Rotating3DCube.RotatingCube();
            this.animation_Preview_Btn = new System.Windows.Forms.Button();
            this.animationProgress_Label = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.showKnob3_NoOfFlashes_Btn = new System.Windows.Forms.Button();
            this.showKnob2_Destination_Btn = new System.Windows.Forms.Button();
            this.showKnob1_Duration_Btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mainControl_NoOfFlashes_Numeric = new System.Windows.Forms.NumericUpDown();
            this.mainControl_Destination_Numeric = new System.Windows.Forms.NumericUpDown();
            this.mainControl_Control_ComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mainControl_Duration_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.mainControl_Transition_ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.transitionAnimator = new Zeroit.Framework.Transitions.ZeroitTransitor();
            this.thematic1501.SuspendLayout();
            this.animation_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl_NoOfFlashes_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl_Destination_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl_Duration_Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // thematic1501
            // 
            this.thematic1501.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.thematic1501.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.thematic1501.Colors = new Zeroit.Framework.Transitions.ThemeManagers.Bloom[0];
            this.thematic1501.Controls.Add(this.zeroitLBKnob1);
            this.thematic1501.Controls.Add(this.zeroitSimpleLine24);
            this.thematic1501.Controls.Add(this.zeroitSimpleLine23);
            this.thematic1501.Controls.Add(this.zeroitSimpleLine22);
            this.thematic1501.Controls.Add(this.zeroitSimpleLine21);
            this.thematic1501.Controls.Add(this.label7);
            this.thematic1501.Controls.Add(this.mainControl_Position_ComboBox);
            this.thematic1501.Controls.Add(this.label4);
            this.thematic1501.Controls.Add(this.animation_GroupBox);
            this.thematic1501.Controls.Add(this.animationProgress_Label);
            this.thematic1501.Controls.Add(this.closeBtn);
            this.thematic1501.Controls.Add(this.okBtn);
            this.thematic1501.Controls.Add(this.cancelBtn);
            this.thematic1501.Controls.Add(this.showKnob3_NoOfFlashes_Btn);
            this.thematic1501.Controls.Add(this.showKnob2_Destination_Btn);
            this.thematic1501.Controls.Add(this.showKnob1_Duration_Btn);
            this.thematic1501.Controls.Add(this.label5);
            this.thematic1501.Controls.Add(this.mainControl_NoOfFlashes_Numeric);
            this.thematic1501.Controls.Add(this.mainControl_Destination_Numeric);
            this.thematic1501.Controls.Add(this.mainControl_Control_ComboBox);
            this.thematic1501.Controls.Add(this.label3);
            this.thematic1501.Controls.Add(this.mainControl_Duration_Numeric);
            this.thematic1501.Controls.Add(this.label1);
            this.thematic1501.Controls.Add(this.mainControl_Transition_ComboBox);
            this.thematic1501.Controls.Add(this.label2);
            this.thematic1501.Customization = "";
            this.thematic1501.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thematic1501.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.thematic1501.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.thematic1501.Image = null;
            this.thematic1501.Location = new System.Drawing.Point(0, 0);
            this.thematic1501.Movable = true;
            this.thematic1501.Name = "thematic1501";
            this.thematic1501.NoRounding = false;
            this.thematic1501.Sizable = true;
            this.thematic1501.Size = new System.Drawing.Size(1292, 556);
            this.thematic1501.SmartBounds = true;
            this.thematic1501.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.thematic1501.TabIndex = 0;
            this.thematic1501.TransparencyKey = System.Drawing.Color.Empty;
            this.thematic1501.Transparent = false;
            this.thematic1501.Click += new System.EventHandler(this.thematic1501_Click);
            // 
            // zeroitLBKnob1
            // 
            this.zeroitLBKnob1.AllowTransparency = true;
            this.zeroitLBKnob1.BackColor = System.Drawing.Color.Transparent;
            this.zeroitLBKnob1.DrawRatio = 0.59F;
            this.zeroitLBKnob1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.zeroitLBKnob1.IndicatorOffset = 10F;
            this.zeroitLBKnob1.KnobCenter = ((System.Drawing.PointF)(resources.GetObject("zeroitLBKnob1.KnobCenter")));
            this.zeroitLBKnob1.KnobColor = System.Drawing.Color.Silver;
            this.zeroitLBKnob1.KnobRect = ((System.Drawing.RectangleF)(resources.GetObject("zeroitLBKnob1.KnobRect")));
            this.zeroitLBKnob1.Location = new System.Drawing.Point(331, 281);
            this.zeroitLBKnob1.MaxValue = 100F;
            this.zeroitLBKnob1.MinValue = 0F;
            this.zeroitLBKnob1.Name = "zeroitLBKnob1";
            this.zeroitLBKnob1.Renderer = null;
            this.zeroitLBKnob1.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.zeroitLBKnob1.Size = new System.Drawing.Size(118, 121);
            this.zeroitLBKnob1.StepValue = 0.1F;
            this.zeroitLBKnob1.Style = Zeroit.Framework.Transitions._HelpingControls.LBKnob.ZeroitLBKnob.KnobStyle.Circular;
            this.zeroitLBKnob1.TabIndex = 126;
            this.zeroitLBKnob1.Value = 0F;
            this.zeroitLBKnob1.Visible = false;
            // 
            // zeroitSimpleLine24
            // 
            this.zeroitSimpleLine24.Angle = 40F;
            this.zeroitSimpleLine24.AngleIncrement = 10F;
            this.zeroitSimpleLine24.AngleLimit = 360F;
            this.zeroitSimpleLine24.AutoAnimate = true;
            this.zeroitSimpleLine24.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.zeroitSimpleLine24.FitToParent = false;
            this.zeroitSimpleLine24.Gradient = System.Drawing.Color.Orange;
            this.zeroitSimpleLine24.GradientAngle = Zeroit.Framework.Transitions._HelpingControls.ZeroitSimpleLine2GradientDirection.Horizontal;
            this.zeroitSimpleLine24.LineColor = System.Drawing.Color.Black;
            this.zeroitSimpleLine24.LineWidth = 1;
            this.zeroitSimpleLine24.Location = new System.Drawing.Point(20, 49);
            this.zeroitSimpleLine24.Name = "zeroitSimpleLine24";
            this.zeroitSimpleLine24.Size = new System.Drawing.Size(1, 398);
            this.zeroitSimpleLine24.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.zeroitSimpleLine24.Style = Zeroit.Framework.Transitions._HelpingControls.ZeroitSimpleLine2LineStyle.Vertical;
            this.zeroitSimpleLine24.TabIndex = 125;
            this.zeroitSimpleLine24.Text = "zeroitSimpleLine24";
            this.zeroitSimpleLine24.TimerInterVal = 10;
            this.zeroitSimpleLine24.UseGradient = true;
            // 
            // zeroitSimpleLine23
            // 
            this.zeroitSimpleLine23.Angle = 50F;
            this.zeroitSimpleLine23.AngleIncrement = 50F;
            this.zeroitSimpleLine23.AngleLimit = 360F;
            this.zeroitSimpleLine23.AutoAnimate = true;
            this.zeroitSimpleLine23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.zeroitSimpleLine23.FillColor = System.Drawing.Color.Cyan;
            this.zeroitSimpleLine23.FitToParent = false;
            this.zeroitSimpleLine23.Gradient = System.Drawing.Color.Orange;
            this.zeroitSimpleLine23.GradientAngle = Zeroit.Framework.Transitions._HelpingControls.ZeroitSimpleLine2GradientDirection.Vertical;
            this.zeroitSimpleLine23.LineColor = System.Drawing.Color.Black;
            this.zeroitSimpleLine23.LineWidth = 1;
            this.zeroitSimpleLine23.Location = new System.Drawing.Point(20, 49);
            this.zeroitSimpleLine23.Name = "zeroitSimpleLine23";
            this.zeroitSimpleLine23.Size = new System.Drawing.Size(436, 1);
            this.zeroitSimpleLine23.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.zeroitSimpleLine23.Style = Zeroit.Framework.Transitions._HelpingControls.ZeroitSimpleLine2LineStyle.Horizontal;
            this.zeroitSimpleLine23.TabIndex = 124;
            this.zeroitSimpleLine23.Text = "zeroitSimpleLine23";
            this.zeroitSimpleLine23.TimerInterVal = 70;
            this.zeroitSimpleLine23.UseGradient = true;
            // 
            // zeroitSimpleLine22
            // 
            this.zeroitSimpleLine22.Angle = 0F;
            this.zeroitSimpleLine22.AngleIncrement = 50F;
            this.zeroitSimpleLine22.AngleLimit = 360F;
            this.zeroitSimpleLine22.AutoAnimate = true;
            this.zeroitSimpleLine22.FillColor = System.Drawing.Color.Cyan;
            this.zeroitSimpleLine22.FitToParent = false;
            this.zeroitSimpleLine22.Gradient = System.Drawing.Color.Orange;
            this.zeroitSimpleLine22.GradientAngle = Zeroit.Framework.Transitions._HelpingControls.ZeroitSimpleLine2GradientDirection.Vertical;
            this.zeroitSimpleLine22.LineColor = System.Drawing.Color.Black;
            this.zeroitSimpleLine22.LineWidth = 1;
            this.zeroitSimpleLine22.Location = new System.Drawing.Point(20, 446);
            this.zeroitSimpleLine22.Name = "zeroitSimpleLine22";
            this.zeroitSimpleLine22.Size = new System.Drawing.Size(436, 1);
            this.zeroitSimpleLine22.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.zeroitSimpleLine22.Style = Zeroit.Framework.Transitions._HelpingControls.ZeroitSimpleLine2LineStyle.Horizontal;
            this.zeroitSimpleLine22.TabIndex = 123;
            this.zeroitSimpleLine22.Text = "zeroitSimpleLine22";
            this.zeroitSimpleLine22.TimerInterVal = 70;
            this.zeroitSimpleLine22.UseGradient = true;
            // 
            // zeroitSimpleLine21
            // 
            this.zeroitSimpleLine21.Angle = 0F;
            this.zeroitSimpleLine21.AngleIncrement = 10F;
            this.zeroitSimpleLine21.AngleLimit = 360F;
            this.zeroitSimpleLine21.AutoAnimate = true;
            this.zeroitSimpleLine21.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.zeroitSimpleLine21.FitToParent = false;
            this.zeroitSimpleLine21.Gradient = System.Drawing.Color.Orange;
            this.zeroitSimpleLine21.GradientAngle = Zeroit.Framework.Transitions._HelpingControls.ZeroitSimpleLine2GradientDirection.Horizontal;
            this.zeroitSimpleLine21.LineColor = System.Drawing.Color.Black;
            this.zeroitSimpleLine21.LineWidth = 1;
            this.zeroitSimpleLine21.Location = new System.Drawing.Point(455, 49);
            this.zeroitSimpleLine21.Name = "zeroitSimpleLine21";
            this.zeroitSimpleLine21.Size = new System.Drawing.Size(1, 398);
            this.zeroitSimpleLine21.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.zeroitSimpleLine21.Style = Zeroit.Framework.Transitions._HelpingControls.ZeroitSimpleLine2LineStyle.Vertical;
            this.zeroitSimpleLine21.TabIndex = 122;
            this.zeroitSimpleLine21.Text = "zeroitSimpleLine21";
            this.zeroitSimpleLine21.TimerInterVal = 10;
            this.zeroitSimpleLine21.UseGradient = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(36, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 120;
            this.label7.Text = "Position";
            // 
            // mainControl_Position_ComboBox
            // 
            this.mainControl_Position_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.mainControl_Position_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainControl_Position_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainControl_Position_ComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainControl_Position_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mainControl_Position_ComboBox.FormattingEnabled = true;
            this.mainControl_Position_ComboBox.Location = new System.Drawing.Point(157, 133);
            this.mainControl_Position_ComboBox.Name = "mainControl_Position_ComboBox";
            this.mainControl_Position_ComboBox.Size = new System.Drawing.Size(134, 29);
            this.mainControl_Position_ComboBox.TabIndex = 121;
            this.mainControl_Position_ComboBox.SelectedIndexChanged += new System.EventHandler(this.PositionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(36, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 119;
            this.label4.Text = "Destination";
            // 
            // animation_GroupBox
            // 
            this.animation_GroupBox.Controls.Add(this.animation_RotatingCube);
            this.animation_GroupBox.Controls.Add(this.animation_Preview_Btn);
            this.animation_GroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.animation_GroupBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.animation_GroupBox.Location = new System.Drawing.Point(508, 38);
            this.animation_GroupBox.Name = "animation_GroupBox";
            this.animation_GroupBox.Size = new System.Drawing.Size(765, 409);
            this.animation_GroupBox.TabIndex = 118;
            this.animation_GroupBox.TabStop = false;
            this.animation_GroupBox.Text = "Animation";
            this.animation_GroupBox.Enter += new System.EventHandler(this.animation_GroupBox_Enter);
            // 
            // animation_RotatingCube
            // 
            this.animation_RotatingCube.AllowTransparency = true;
            this.animation_RotatingCube.AutoAnimate = true;
            this.animation_RotatingCube.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.BlueViolet,
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Green,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Violet,
        System.Drawing.Color.LightSkyBlue};
            this.animation_RotatingCube.Location = new System.Drawing.Point(313, 126);
            this.animation_RotatingCube.Name = "animation_RotatingCube";
            this.animation_RotatingCube.Shrink = 4;
            this.animation_RotatingCube.Size = new System.Drawing.Size(141, 141);
            this.animation_RotatingCube.SpeedAdjust = 10;
            this.animation_RotatingCube.TabIndex = 115;
            this.animation_RotatingCube.Text = "rotatingCube1";
            // 
            // animation_Preview_Btn
            // 
            this.animation_Preview_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.animation_Preview_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.animation_Preview_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animation_Preview_Btn.FlatAppearance.BorderSize = 0;
            this.animation_Preview_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.animation_Preview_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.animation_Preview_Btn.Location = new System.Drawing.Point(654, 24);
            this.animation_Preview_Btn.Name = "animation_Preview_Btn";
            this.animation_Preview_Btn.Size = new System.Drawing.Size(105, 48);
            this.animation_Preview_Btn.TabIndex = 116;
            this.animation_Preview_Btn.Text = "Preview";
            this.animation_Preview_Btn.UseVisualStyleBackColor = false;
            this.animation_Preview_Btn.Click += new System.EventHandler(this.animation_Preview_Btn_Click);
            this.animation_Preview_Btn.MouseEnter += new System.EventHandler(this.animation_Preview_Btn_MouseEnter);
            this.animation_Preview_Btn.MouseLeave += new System.EventHandler(this.animation_Preview_Btn_MouseLeave);
            // 
            // animationProgress_Label
            // 
            this.animationProgress_Label.AutoSize = true;
            this.animationProgress_Label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.animationProgress_Label.Location = new System.Drawing.Point(23, 520);
            this.animationProgress_Label.Name = "animationProgress_Label";
            this.animationProgress_Label.Size = new System.Drawing.Size(143, 19);
            this.animationProgress_Label.TabIndex = 117;
            this.animationProgress_Label.Text = "Status : No Animation";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.closeBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.closeBtn.Location = new System.Drawing.Point(1265, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(23, 23);
            this.closeBtn.TabIndex = 114;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.okBtn.Location = new System.Drawing.Point(1077, 496);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(95, 39);
            this.okBtn.TabIndex = 112;
            this.okBtn.Text = "&OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancelBtn.Location = new System.Drawing.Point(1178, 496);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(95, 39);
            this.cancelBtn.TabIndex = 113;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // showKnob3_NoOfFlashes_Btn
            // 
            this.showKnob3_NoOfFlashes_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.showKnob3_NoOfFlashes_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showKnob3_NoOfFlashes_Btn.FlatAppearance.BorderSize = 0;
            this.showKnob3_NoOfFlashes_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showKnob3_NoOfFlashes_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showKnob3_NoOfFlashes_Btn.Image = global::Zeroit.Framework.Transitions.Properties.Resources.knob_16x16;
            this.showKnob3_NoOfFlashes_Btn.Location = new System.Drawing.Point(297, 329);
            this.showKnob3_NoOfFlashes_Btn.Name = "showKnob3_NoOfFlashes_Btn";
            this.showKnob3_NoOfFlashes_Btn.Size = new System.Drawing.Size(28, 26);
            this.showKnob3_NoOfFlashes_Btn.TabIndex = 107;
            this.showKnob3_NoOfFlashes_Btn.UseVisualStyleBackColor = false;
            this.showKnob3_NoOfFlashes_Btn.Click += new System.EventHandler(this.showKnob3_NoOfFlashes_Btn_Click);
            this.showKnob3_NoOfFlashes_Btn.MouseEnter += new System.EventHandler(this.showKnob3_NoOfFlashes_Btn_MouseEnter);
            this.showKnob3_NoOfFlashes_Btn.MouseLeave += new System.EventHandler(this.showKnob3_NoOfFlashes_Btn_MouseLeave);
            // 
            // showKnob2_Destination_Btn
            // 
            this.showKnob2_Destination_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.showKnob2_Destination_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showKnob2_Destination_Btn.FlatAppearance.BorderSize = 0;
            this.showKnob2_Destination_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showKnob2_Destination_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showKnob2_Destination_Btn.Image = global::Zeroit.Framework.Transitions.Properties.Resources.knob_16x16;
            this.showKnob2_Destination_Btn.Location = new System.Drawing.Point(297, 265);
            this.showKnob2_Destination_Btn.Name = "showKnob2_Destination_Btn";
            this.showKnob2_Destination_Btn.Size = new System.Drawing.Size(28, 26);
            this.showKnob2_Destination_Btn.TabIndex = 106;
            this.showKnob2_Destination_Btn.UseVisualStyleBackColor = false;
            this.showKnob2_Destination_Btn.Click += new System.EventHandler(this.showKnob2_Destination_Btn_Click);
            this.showKnob2_Destination_Btn.MouseEnter += new System.EventHandler(this.showKnob2_Destination_Btn_MouseEnter);
            this.showKnob2_Destination_Btn.MouseLeave += new System.EventHandler(this.showKnob2_Destination_Btn_MouseLeave);
            // 
            // showKnob1_Duration_Btn
            // 
            this.showKnob1_Duration_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.showKnob1_Duration_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showKnob1_Duration_Btn.FlatAppearance.BorderSize = 0;
            this.showKnob1_Duration_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showKnob1_Duration_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showKnob1_Duration_Btn.Image = global::Zeroit.Framework.Transitions.Properties.Resources.knob_16x16;
            this.showKnob1_Duration_Btn.Location = new System.Drawing.Point(297, 201);
            this.showKnob1_Duration_Btn.Name = "showKnob1_Duration_Btn";
            this.showKnob1_Duration_Btn.Size = new System.Drawing.Size(28, 26);
            this.showKnob1_Duration_Btn.TabIndex = 105;
            this.showKnob1_Duration_Btn.UseVisualStyleBackColor = false;
            this.showKnob1_Duration_Btn.Click += new System.EventHandler(this.showKnob1_Duration_Btn_Click);
            this.showKnob1_Duration_Btn.MouseEnter += new System.EventHandler(this.showKnob1_Duration_Btn_MouseEnter);
            this.showKnob1_Duration_Btn.MouseLeave += new System.EventHandler(this.showKnob1_Duration_Btn_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(36, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 102;
            this.label5.Text = "No of Flashes";
            // 
            // mainControl_NoOfFlashes_Numeric
            // 
            this.mainControl_NoOfFlashes_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.mainControl_NoOfFlashes_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainControl_NoOfFlashes_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainControl_NoOfFlashes_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.mainControl_NoOfFlashes_Numeric.Location = new System.Drawing.Point(157, 328);
            this.mainControl_NoOfFlashes_Numeric.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.mainControl_NoOfFlashes_Numeric.Name = "mainControl_NoOfFlashes_Numeric";
            this.mainControl_NoOfFlashes_Numeric.Size = new System.Drawing.Size(134, 29);
            this.mainControl_NoOfFlashes_Numeric.TabIndex = 101;
            this.mainControl_NoOfFlashes_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainControl_NoOfFlashes_Numeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mainControl_NoOfFlashes_Numeric.ValueChanged += new System.EventHandler(this.mainControl_NoOfFlashes_Numeric_ValueChanged);
            this.mainControl_NoOfFlashes_Numeric.Click += new System.EventHandler(this.mainControl_NoOfFlashes_Numeric_Click);
            // 
            // mainControl_Destination_Numeric
            // 
            this.mainControl_Destination_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.mainControl_Destination_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainControl_Destination_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainControl_Destination_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.mainControl_Destination_Numeric.Location = new System.Drawing.Point(157, 263);
            this.mainControl_Destination_Numeric.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.mainControl_Destination_Numeric.Name = "mainControl_Destination_Numeric";
            this.mainControl_Destination_Numeric.Size = new System.Drawing.Size(134, 29);
            this.mainControl_Destination_Numeric.TabIndex = 100;
            this.mainControl_Destination_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainControl_Destination_Numeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mainControl_Destination_Numeric.ValueChanged += new System.EventHandler(this.mainControl_Destination_Numeric_ValueChanged);
            this.mainControl_Destination_Numeric.Click += new System.EventHandler(this.mainControl_Destination_Numeric_Click);
            // 
            // mainControl_Control_ComboBox
            // 
            this.mainControl_Control_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.mainControl_Control_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainControl_Control_ComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainControl_Control_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mainControl_Control_ComboBox.FormattingEnabled = true;
            this.mainControl_Control_ComboBox.Location = new System.Drawing.Point(157, 393);
            this.mainControl_Control_ComboBox.Name = "mainControl_Control_ComboBox";
            this.mainControl_Control_ComboBox.Size = new System.Drawing.Size(134, 29);
            this.mainControl_Control_ComboBox.TabIndex = 99;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(36, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 98;
            this.label3.Text = "Duration";
            // 
            // mainControl_Duration_Numeric
            // 
            this.mainControl_Duration_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.mainControl_Duration_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainControl_Duration_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainControl_Duration_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.mainControl_Duration_Numeric.Location = new System.Drawing.Point(157, 198);
            this.mainControl_Duration_Numeric.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.mainControl_Duration_Numeric.Name = "mainControl_Duration_Numeric";
            this.mainControl_Duration_Numeric.Size = new System.Drawing.Size(134, 29);
            this.mainControl_Duration_Numeric.TabIndex = 97;
            this.mainControl_Duration_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainControl_Duration_Numeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mainControl_Duration_Numeric.ValueChanged += new System.EventHandler(this.mainControl_Duration_Numeric_ValueChanged);
            this.mainControl_Duration_Numeric.Click += new System.EventHandler(this.mainControl_Duration_Numeric_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(36, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 95;
            this.label1.Text = "Transition";
            // 
            // mainControl_Transition_ComboBox
            // 
            this.mainControl_Transition_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.mainControl_Transition_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainControl_Transition_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainControl_Transition_ComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainControl_Transition_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mainControl_Transition_ComboBox.FormattingEnabled = true;
            this.mainControl_Transition_ComboBox.Location = new System.Drawing.Point(157, 68);
            this.mainControl_Transition_ComboBox.Name = "mainControl_Transition_ComboBox";
            this.mainControl_Transition_ComboBox.Size = new System.Drawing.Size(134, 29);
            this.mainControl_Transition_ComboBox.TabIndex = 96;
            this.mainControl_Transition_ComboBox.SelectedIndexChanged += new System.EventHandler(this.TransitionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(36, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 94;
            this.label2.Text = "Control";
            // 
            // transitionAnimator
            // 
            this.transitionAnimator.Destination = 0;
            this.transitionAnimator.No_Of_Flashes = 1;
            this.transitionAnimator.Position = Zeroit.Framework.Transitions.ZeroitTransitor.Positions.Left;
            this.transitionAnimator.Target = this.animation_RotatingCube;
            this.transitionAnimator.Transitions = Zeroit.Framework.Transitions.ZeroitTransitor.TransitionType.Accelaration;
            this.transitionAnimator.TransitionTime = 2000;
            // 
            // ZeroitAnimateTransitionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 556);
            this.Controls.Add(this.thematic1501);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZeroitAnimateTransitionDialog";
            this.ShowInTaskbar = false;
            this.Text = "Zeroit Transition Animator";
            this.thematic1501.ResumeLayout(false);
            this.thematic1501.PerformLayout();
            this.animation_GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainControl_NoOfFlashes_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl_Destination_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl_Duration_Numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The thematic1501
        /// </summary>
        private ThemeManagers.Orains thematic1501;
        /// <summary>
        /// The show knob3 no of flashes BTN
        /// </summary>
        public System.Windows.Forms.Button showKnob3_NoOfFlashes_Btn;
        /// <summary>
        /// The show knob2 destination BTN
        /// </summary>
        public System.Windows.Forms.Button showKnob2_Destination_Btn;
        /// <summary>
        /// The show knob1 duration BTN
        /// </summary>
        public System.Windows.Forms.Button showKnob1_Duration_Btn;
        /// <summary>
        /// The label5
        /// </summary>
        private System.Windows.Forms.Label label5;
        /// <summary>
        /// The main control no of flashes numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown mainControl_NoOfFlashes_Numeric;
        /// <summary>
        /// The main control destination numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown mainControl_Destination_Numeric;
        /// <summary>
        /// The main control control ComboBox
        /// </summary>
        private System.Windows.Forms.ComboBox mainControl_Control_ComboBox;
        /// <summary>
        /// The label3
        /// </summary>
        private System.Windows.Forms.Label label3;
        /// <summary>
        /// The main control duration numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown mainControl_Duration_Numeric;
        /// <summary>
        /// The label1
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// The main control transition ComboBox
        /// </summary>
        private System.Windows.Forms.ComboBox mainControl_Transition_ComboBox;
        /// <summary>
        /// The label2
        /// </summary>
        private System.Windows.Forms.Label label2;
        /// <summary>
        /// The label7
        /// </summary>
        private System.Windows.Forms.Label label7;
        /// <summary>
        /// The main control position ComboBox
        /// </summary>
        private System.Windows.Forms.ComboBox mainControl_Position_ComboBox;
        /// <summary>
        /// The label4
        /// </summary>
        private System.Windows.Forms.Label label4;
        /// <summary>
        /// The animation group box
        /// </summary>
        private System.Windows.Forms.GroupBox animation_GroupBox;
        /// <summary>
        /// The animation preview BTN
        /// </summary>
        public System.Windows.Forms.Button animation_Preview_Btn;
        /// <summary>
        /// The animation rotating cube
        /// </summary>
        private Transitions._HelpingControls.Rotating3DCube.RotatingCube animation_RotatingCube;
        /// <summary>
        /// The animation progress label
        /// </summary>
        private System.Windows.Forms.Label animationProgress_Label;
        /// <summary>
        /// The close BTN
        /// </summary>
        private System.Windows.Forms.Button closeBtn;
        /// <summary>
        /// The ok BTN
        /// </summary>
        public System.Windows.Forms.Button okBtn;
        /// <summary>
        /// The cancel BTN
        /// </summary>
        public System.Windows.Forms.Button cancelBtn;
        /// <summary>
        /// The zeroit simple line24
        /// </summary>
        private _HelpingControls.LineSimple2 zeroitSimpleLine24;
        /// <summary>
        /// The zeroit simple line23
        /// </summary>
        private _HelpingControls.LineSimple2 zeroitSimpleLine23;
        /// <summary>
        /// The zeroit simple line22
        /// </summary>
        private _HelpingControls.LineSimple2 zeroitSimpleLine22;
        /// <summary>
        /// The zeroit simple line21
        /// </summary>
        private _HelpingControls.LineSimple2 zeroitSimpleLine21;
        /// <summary>
        /// The zeroit lb knob1
        /// </summary>
        private _HelpingControls.LBKnob.ZeroitLBKnob zeroitLBKnob1;
        /// <summary>
        /// The transition animator
        /// </summary>
        private ZeroitTransitor transitionAnimator;
    }
}