// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 11-17-2018
// ***********************************************************************
// <copyright file="ZeroitAnimateAnimatorDialog.Designer.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    /// Class ZeroitAnimateAnimatorDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class ZeroitAnimateAnimatorDialog
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
            Zeroit.Framework.Transitions.ZeroitAnimate_Animation zeroitAnimate_Animation2 = new Zeroit.Framework.Transitions.ZeroitAnimate_Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZeroitAnimateAnimatorDialog));
            this.thematic1501 = new ThemeManagers.NYX();
            this.animationProgress_Label = new System.Windows.Forms.Label();
            this.animationType_Label = new System.Windows.Forms.Label();
            this.animation_RotatingCube = new Transitions._HelpingControls.Rotating3DCube.RotatingCube();
            this.animation_Preview_Btn = new System.Windows.Forms.Button();
            this.animation_GroupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.testingLabel = new System.Windows.Forms.Label();
            this.zeroitLBKnob1 = new Zeroit.Framework.Transitions._HelpingControls.LBKnob.ZeroitLBKnob();
            this.showKnob5_TimeStep_Btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.mainControl_TimeStep_Numeric = new System.Windows.Forms.NumericUpDown();
            this.closeBtn = new System.Windows.Forms.Button();
            this.showKnob4_TargetHeight_Btn = new System.Windows.Forms.Button();
            this.showKnob3_TargetWidth_Btn = new System.Windows.Forms.Button();
            this.showKnob2_Interval_Btn = new System.Windows.Forms.Button();
            this.showKnob1_Duration_Btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.mainControl_TargetHeight_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.mainControl_TargetWidth_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.mainControl_Interval_Numeric = new System.Windows.Forms.NumericUpDown();
            this.mainControl_Control_ComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mainControl_Duration_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.mainControl_AnimationType_ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.animatorPreview = new Zeroit.Framework.Transitions.ZeroitAnimator(this.components);
            this.thematic1501.SuspendLayout();
            this.animation_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl_TimeStep_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl_TargetHeight_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl_TargetWidth_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl_Interval_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl_Duration_Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // thematic1501
            // 
            
            this.thematic1501.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.thematic1501.Controls.Add(this.animationProgress_Label);
            this.thematic1501.Controls.Add(this.animationType_Label);
            this.thematic1501.Controls.Add(this.animation_RotatingCube);
            this.thematic1501.Controls.Add(this.animation_Preview_Btn);
            this.thematic1501.Controls.Add(this.animation_GroupBox);
            this.thematic1501.Controls.Add(this.showKnob5_TimeStep_Btn);
            this.thematic1501.Controls.Add(this.label7);
            this.thematic1501.Controls.Add(this.mainControl_TimeStep_Numeric);
            this.thematic1501.Controls.Add(this.closeBtn);
            this.thematic1501.Controls.Add(this.showKnob4_TargetHeight_Btn);
            this.thematic1501.Controls.Add(this.showKnob3_TargetWidth_Btn);
            this.thematic1501.Controls.Add(this.showKnob2_Interval_Btn);
            this.thematic1501.Controls.Add(this.showKnob1_Duration_Btn);
            this.thematic1501.Controls.Add(this.label6);
            this.thematic1501.Controls.Add(this.mainControl_TargetHeight_Numeric);
            this.thematic1501.Controls.Add(this.label5);
            this.thematic1501.Controls.Add(this.mainControl_TargetWidth_Numeric);
            this.thematic1501.Controls.Add(this.label4);
            this.thematic1501.Controls.Add(this.mainControl_Interval_Numeric);
            this.thematic1501.Controls.Add(this.mainControl_Control_ComboBox);
            this.thematic1501.Controls.Add(this.label3);
            this.thematic1501.Controls.Add(this.mainControl_Duration_Numeric);
            this.thematic1501.Controls.Add(this.label1);
            this.thematic1501.Controls.Add(this.mainControl_AnimationType_ComboBox);
            this.thematic1501.Controls.Add(this.label2);
            this.thematic1501.Controls.Add(this.okBtn);
            this.thematic1501.Controls.Add(this.cancelBtn);
            this.thematic1501.Customization = "";
            this.animatorPreview.SetDecoration(this.thematic1501, Zeroit.Framework.Transitions.DecorationType.None);
            this.thematic1501.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thematic1501.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.thematic1501.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.thematic1501.Image = null;
            this.thematic1501.Location = new System.Drawing.Point(0, 0);
            this.thematic1501.Movable = true;
            this.thematic1501.Name = "thematic1501";
            this.thematic1501.NoRounding = false;
            this.thematic1501.Sizable = false;
            this.thematic1501.Size = new System.Drawing.Size(1243, 524);
            this.thematic1501.SmartBounds = true;
            this.thematic1501.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.thematic1501.TabIndex = 0;
            this.thematic1501.Text = "ZeroitAnimate Animator";
            this.thematic1501.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.thematic1501.Transparent = false;
            this.thematic1501.Click += new System.EventHandler(this.thematic1501_Click);
            // 
            // animationProgress_Label
            // 
            this.animationProgress_Label.AutoSize = true;
            this.animatorPreview.SetDecoration(this.animationProgress_Label, Zeroit.Framework.Transitions.DecorationType.None);
            this.animationProgress_Label.Location = new System.Drawing.Point(30, 489);
            this.animationProgress_Label.Name = "animationProgress_Label";
            this.animationProgress_Label.Size = new System.Drawing.Size(143, 19);
            this.animationProgress_Label.TabIndex = 98;
            this.animationProgress_Label.Text = "Status : No Animation";
            // 
            // animationType_Label
            // 
            this.animationType_Label.AutoSize = true;
            this.animatorPreview.SetDecoration(this.animationType_Label, Zeroit.Framework.Transitions.DecorationType.None);
            this.animationType_Label.Location = new System.Drawing.Point(561, 45);
            this.animationType_Label.Name = "animationType_Label";
            this.animationType_Label.Size = new System.Drawing.Size(104, 19);
            this.animationType_Label.TabIndex = 95;
            this.animationType_Label.Text = "Animation Type";
            this.animationType_Label.Visible = false;
            // 
            // animation_RotatingCube
            // 
            this.animation_RotatingCube.AutoAnimate = true;
            this.animation_RotatingCube.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.BlueViolet,
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Green,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Violet,
        System.Drawing.Color.LightSkyBlue};
            this.animatorPreview.SetDecoration(this.animation_RotatingCube, Zeroit.Framework.Transitions.DecorationType.None);
            this.animation_RotatingCube.Location = new System.Drawing.Point(643, 128);
            this.animation_RotatingCube.Name = "animation_RotatingCube";
            this.animation_RotatingCube.Shrink = 4;
            this.animation_RotatingCube.Size = new System.Drawing.Size(141, 141);
            this.animation_RotatingCube.SpeedAdjust = 10;
            this.animation_RotatingCube.TabIndex = 96;
            this.animation_RotatingCube.Text = "rotatingCube1";
            // 
            // animation_Preview_Btn
            // 
            this.animation_Preview_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.animation_Preview_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.animation_Preview_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPreview.SetDecoration(this.animation_Preview_Btn, Zeroit.Framework.Transitions.DecorationType.None);
            this.animation_Preview_Btn.FlatAppearance.BorderSize = 0;
            this.animation_Preview_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.animation_Preview_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.animation_Preview_Btn.Location = new System.Drawing.Point(1111, 40);
            this.animation_Preview_Btn.Name = "animation_Preview_Btn";
            this.animation_Preview_Btn.Size = new System.Drawing.Size(105, 48);
            this.animation_Preview_Btn.TabIndex = 97;
            this.animation_Preview_Btn.Text = "Preview";
            this.animation_Preview_Btn.UseVisualStyleBackColor = false;
            this.animation_Preview_Btn.Click += new System.EventHandler(this.animation_Preview_Btn_Click);
            this.animation_Preview_Btn.MouseEnter += new System.EventHandler(this.animation_Preview_Btn_MouseEnter);
            this.animation_Preview_Btn.MouseLeave += new System.EventHandler(this.animation_Preview_Btn_MouseLeave);
            // 
            // animation_GroupBox
            // 
            this.animation_GroupBox.Controls.Add(this.label8);
            this.animation_GroupBox.Controls.Add(this.testingLabel);
            this.animation_GroupBox.Controls.Add(this.zeroitLBKnob1);
            this.animatorPreview.SetDecoration(this.animation_GroupBox, Zeroit.Framework.Transitions.DecorationType.None);
            this.animation_GroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.animation_GroupBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.animation_GroupBox.Location = new System.Drawing.Point(451, 345);
            this.animation_GroupBox.Name = "animation_GroupBox";
            this.animation_GroupBox.Size = new System.Drawing.Size(306, 163);
            this.animation_GroupBox.TabIndex = 95;
            this.animation_GroupBox.TabStop = false;
            this.animation_GroupBox.Text = "ToolBox";
            this.animation_GroupBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.animatorPreview.SetDecoration(this.label8, Zeroit.Framework.Transitions.DecorationType.None);
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 21);
            this.label8.TabIndex = 94;
            this.label8.Text = "Size : 660, 255";
            this.label8.Visible = false;
            // 
            // testingLabel
            // 
            this.testingLabel.AutoSize = true;
            this.animatorPreview.SetDecoration(this.testingLabel, Zeroit.Framework.Transitions.DecorationType.None);
            this.testingLabel.Location = new System.Drawing.Point(6, 124);
            this.testingLabel.Name = "testingLabel";
            this.testingLabel.Size = new System.Drawing.Size(132, 21);
            this.testingLabel.TabIndex = 90;
            this.testingLabel.Text = "Location : 505, 50";
            this.testingLabel.Visible = false;
            // 
            // zeroitLBKnob1
            // 
            this.zeroitLBKnob1.BackColor = System.Drawing.Color.Transparent;
            this.animatorPreview.SetDecoration(this.zeroitLBKnob1, Zeroit.Framework.Transitions.DecorationType.None);
            this.zeroitLBKnob1.DrawRatio = 0.59F;
            this.zeroitLBKnob1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.zeroitLBKnob1.IndicatorOffset = 10F;
            this.zeroitLBKnob1.KnobCenter = ((System.Drawing.PointF)(resources.GetObject("zeroitLBKnob1.KnobCenter")));
            this.zeroitLBKnob1.KnobColor = System.Drawing.Color.Silver;
            this.zeroitLBKnob1.KnobRect = ((System.Drawing.RectangleF)(resources.GetObject("zeroitLBKnob1.KnobRect")));
            this.zeroitLBKnob1.Location = new System.Drawing.Point(172, 24);
            this.zeroitLBKnob1.MaxValue = 100F;
            this.zeroitLBKnob1.MinValue = 0F;
            this.zeroitLBKnob1.Name = "zeroitLBKnob1";
            this.zeroitLBKnob1.Renderer = null;
            this.zeroitLBKnob1.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.zeroitLBKnob1.Size = new System.Drawing.Size(118, 121);
            this.zeroitLBKnob1.StepValue = 0.1F;
            this.zeroitLBKnob1.Style = Zeroit.Framework.Transitions._HelpingControls.LBKnob.ZeroitLBKnob.KnobStyle.Circular;
            this.zeroitLBKnob1.TabIndex = 74;
            this.zeroitLBKnob1.Value = 0F;
            this.zeroitLBKnob1.Visible = false;
            // 
            // showKnob5_TimeStep_Btn
            // 
            this.showKnob5_TimeStep_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.showKnob5_TimeStep_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPreview.SetDecoration(this.showKnob5_TimeStep_Btn, Zeroit.Framework.Transitions.DecorationType.None);
            this.showKnob5_TimeStep_Btn.FlatAppearance.BorderSize = 0;
            this.showKnob5_TimeStep_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showKnob5_TimeStep_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showKnob5_TimeStep_Btn.Image = global::Zeroit.Framework.Transitions.Properties.Resources.knob_16x16;
            this.showKnob5_TimeStep_Btn.Location = new System.Drawing.Point(351, 348);
            this.showKnob5_TimeStep_Btn.Name = "showKnob5_TimeStep_Btn";
            this.showKnob5_TimeStep_Btn.Size = new System.Drawing.Size(28, 26);
            this.showKnob5_TimeStep_Btn.TabIndex = 93;
            this.showKnob5_TimeStep_Btn.UseVisualStyleBackColor = false;
            this.showKnob5_TimeStep_Btn.Click += new System.EventHandler(this.showKnob5_TimeStep_Btn_Click);
            this.showKnob5_TimeStep_Btn.MouseEnter += new System.EventHandler(this.showKnob5_TimeStep_Btn_MouseEnter);
            this.showKnob5_TimeStep_Btn.MouseLeave += new System.EventHandler(this.showKnob5_TimeStep_Btn_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.animatorPreview.SetDecoration(this.label7, Zeroit.Framework.Transitions.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(30, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 21);
            this.label7.TabIndex = 92;
            this.label7.Text = "Time Step";
            // 
            // mainControl_TimeStep_Numeric
            // 
            this.mainControl_TimeStep_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.mainControl_TimeStep_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainControl_TimeStep_Numeric.DecimalPlaces = 2;
            this.animatorPreview.SetDecoration(this.mainControl_TimeStep_Numeric, Zeroit.Framework.Transitions.DecorationType.None);
            this.mainControl_TimeStep_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainControl_TimeStep_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.mainControl_TimeStep_Numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.mainControl_TimeStep_Numeric.Location = new System.Drawing.Point(211, 347);
            this.mainControl_TimeStep_Numeric.Name = "mainControl_TimeStep_Numeric";
            this.mainControl_TimeStep_Numeric.Size = new System.Drawing.Size(134, 29);
            this.mainControl_TimeStep_Numeric.TabIndex = 91;
            this.mainControl_TimeStep_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainControl_TimeStep_Numeric.ValueChanged += new System.EventHandler(this.mainControl_TimeStep_Numeric_ValueChanged);
            this.mainControl_TimeStep_Numeric.Click += new System.EventHandler(this.mainControl_TimeStep_Numeric_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPreview.SetDecoration(this.closeBtn, Zeroit.Framework.Transitions.DecorationType.None);
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.closeBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.closeBtn.Location = new System.Drawing.Point(1224, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(16, 16);
            this.closeBtn.TabIndex = 89;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // showKnob4_TargetHeight_Btn
            // 
            this.showKnob4_TargetHeight_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.showKnob4_TargetHeight_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPreview.SetDecoration(this.showKnob4_TargetHeight_Btn, Zeroit.Framework.Transitions.DecorationType.None);
            this.showKnob4_TargetHeight_Btn.FlatAppearance.BorderSize = 0;
            this.showKnob4_TargetHeight_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showKnob4_TargetHeight_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showKnob4_TargetHeight_Btn.Image = global::Zeroit.Framework.Transitions.Properties.Resources.knob_16x16;
            this.showKnob4_TargetHeight_Btn.Location = new System.Drawing.Point(351, 292);
            this.showKnob4_TargetHeight_Btn.Name = "showKnob4_TargetHeight_Btn";
            this.showKnob4_TargetHeight_Btn.Size = new System.Drawing.Size(28, 26);
            this.showKnob4_TargetHeight_Btn.TabIndex = 88;
            this.showKnob4_TargetHeight_Btn.UseVisualStyleBackColor = false;
            this.showKnob4_TargetHeight_Btn.Click += new System.EventHandler(this.showKnob4_TargetHeight_Btn_Click);
            this.showKnob4_TargetHeight_Btn.MouseEnter += new System.EventHandler(this.showKnob4_TargetHeight_Btn_MouseEnter);
            this.showKnob4_TargetHeight_Btn.MouseLeave += new System.EventHandler(this.showKnob4_TargetHeight_Btn_MouseLeave);
            // 
            // showKnob3_TargetWidth_Btn
            // 
            this.showKnob3_TargetWidth_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.showKnob3_TargetWidth_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPreview.SetDecoration(this.showKnob3_TargetWidth_Btn, Zeroit.Framework.Transitions.DecorationType.None);
            this.showKnob3_TargetWidth_Btn.FlatAppearance.BorderSize = 0;
            this.showKnob3_TargetWidth_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showKnob3_TargetWidth_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showKnob3_TargetWidth_Btn.Image = global::Zeroit.Framework.Transitions.Properties.Resources.knob_16x16;
            this.showKnob3_TargetWidth_Btn.Location = new System.Drawing.Point(351, 234);
            this.showKnob3_TargetWidth_Btn.Name = "showKnob3_TargetWidth_Btn";
            this.showKnob3_TargetWidth_Btn.Size = new System.Drawing.Size(28, 26);
            this.showKnob3_TargetWidth_Btn.TabIndex = 87;
            this.showKnob3_TargetWidth_Btn.UseVisualStyleBackColor = false;
            this.showKnob3_TargetWidth_Btn.Click += new System.EventHandler(this.showKnob3_TargetWidth_Btn_Click);
            this.showKnob3_TargetWidth_Btn.MouseEnter += new System.EventHandler(this.showKnob3_TargetWidth_Btn_MouseEnter);
            this.showKnob3_TargetWidth_Btn.MouseLeave += new System.EventHandler(this.showKnob3_TargetWidth_Btn_MouseLeave);
            // 
            // showKnob2_Interval_Btn
            // 
            this.showKnob2_Interval_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.showKnob2_Interval_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPreview.SetDecoration(this.showKnob2_Interval_Btn, Zeroit.Framework.Transitions.DecorationType.None);
            this.showKnob2_Interval_Btn.FlatAppearance.BorderSize = 0;
            this.showKnob2_Interval_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showKnob2_Interval_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showKnob2_Interval_Btn.Image = global::Zeroit.Framework.Transitions.Properties.Resources.knob_16x16;
            this.showKnob2_Interval_Btn.Location = new System.Drawing.Point(351, 174);
            this.showKnob2_Interval_Btn.Name = "showKnob2_Interval_Btn";
            this.showKnob2_Interval_Btn.Size = new System.Drawing.Size(28, 26);
            this.showKnob2_Interval_Btn.TabIndex = 86;
            this.showKnob2_Interval_Btn.UseVisualStyleBackColor = false;
            this.showKnob2_Interval_Btn.Click += new System.EventHandler(this.showKnob2_Interval_Btn_Click);
            this.showKnob2_Interval_Btn.MouseEnter += new System.EventHandler(this.showKnob2_Interval_Btn_MouseEnter);
            this.showKnob2_Interval_Btn.MouseLeave += new System.EventHandler(this.showKnob2_Interval_Btn_MouseLeave);
            // 
            // showKnob1_Duration_Btn
            // 
            this.showKnob1_Duration_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.showKnob1_Duration_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPreview.SetDecoration(this.showKnob1_Duration_Btn, Zeroit.Framework.Transitions.DecorationType.None);
            this.showKnob1_Duration_Btn.FlatAppearance.BorderSize = 0;
            this.showKnob1_Duration_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showKnob1_Duration_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showKnob1_Duration_Btn.Image = global::Zeroit.Framework.Transitions.Properties.Resources.knob_16x16;
            this.showKnob1_Duration_Btn.Location = new System.Drawing.Point(351, 116);
            this.showKnob1_Duration_Btn.Name = "showKnob1_Duration_Btn";
            this.showKnob1_Duration_Btn.Size = new System.Drawing.Size(28, 26);
            this.showKnob1_Duration_Btn.TabIndex = 85;
            this.showKnob1_Duration_Btn.UseVisualStyleBackColor = false;
            this.showKnob1_Duration_Btn.Click += new System.EventHandler(this.showKnob1_Duration_Btn_Click);
            this.showKnob1_Duration_Btn.MouseEnter += new System.EventHandler(this.showKnob1_Duration_Btn_MouseEnter);
            this.showKnob1_Duration_Btn.MouseLeave += new System.EventHandler(this.showKnob1_Duration_Btn_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.animatorPreview.SetDecoration(this.label6, Zeroit.Framework.Transitions.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(30, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 21);
            this.label6.TabIndex = 83;
            this.label6.Text = "Target Height";
            // 
            // mainControl_TargetHeight_Numeric
            // 
            this.mainControl_TargetHeight_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.mainControl_TargetHeight_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animatorPreview.SetDecoration(this.mainControl_TargetHeight_Numeric, Zeroit.Framework.Transitions.DecorationType.None);
            this.mainControl_TargetHeight_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainControl_TargetHeight_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.mainControl_TargetHeight_Numeric.Location = new System.Drawing.Point(211, 290);
            this.mainControl_TargetHeight_Numeric.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.mainControl_TargetHeight_Numeric.Name = "mainControl_TargetHeight_Numeric";
            this.mainControl_TargetHeight_Numeric.Size = new System.Drawing.Size(134, 29);
            this.mainControl_TargetHeight_Numeric.TabIndex = 82;
            this.mainControl_TargetHeight_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainControl_TargetHeight_Numeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mainControl_TargetHeight_Numeric.ValueChanged += new System.EventHandler(this.mainControl_TargetHeight_Numeric_ValueChanged);
            this.mainControl_TargetHeight_Numeric.Click += new System.EventHandler(this.mainControl_TargetHeight_Numeric_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.animatorPreview.SetDecoration(this.label5, Zeroit.Framework.Transitions.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(30, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 21);
            this.label5.TabIndex = 81;
            this.label5.Text = "Target Width";
            // 
            // mainControl_TargetWidth_Numeric
            // 
            this.mainControl_TargetWidth_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.mainControl_TargetWidth_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animatorPreview.SetDecoration(this.mainControl_TargetWidth_Numeric, Zeroit.Framework.Transitions.DecorationType.None);
            this.mainControl_TargetWidth_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainControl_TargetWidth_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.mainControl_TargetWidth_Numeric.Location = new System.Drawing.Point(211, 231);
            this.mainControl_TargetWidth_Numeric.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.mainControl_TargetWidth_Numeric.Name = "mainControl_TargetWidth_Numeric";
            this.mainControl_TargetWidth_Numeric.Size = new System.Drawing.Size(134, 29);
            this.mainControl_TargetWidth_Numeric.TabIndex = 80;
            this.mainControl_TargetWidth_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainControl_TargetWidth_Numeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mainControl_TargetWidth_Numeric.ValueChanged += new System.EventHandler(this.mainControl_TargetWidth_Numeric_ValueChanged);
            this.mainControl_TargetWidth_Numeric.Click += new System.EventHandler(this.mainControl_TargetWidth_Numeric_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.animatorPreview.SetDecoration(this.label4, Zeroit.Framework.Transitions.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(30, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 79;
            this.label4.Text = "Interval";
            // 
            // mainControl_Interval_Numeric
            // 
            this.mainControl_Interval_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.mainControl_Interval_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animatorPreview.SetDecoration(this.mainControl_Interval_Numeric, Zeroit.Framework.Transitions.DecorationType.None);
            this.mainControl_Interval_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainControl_Interval_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.mainControl_Interval_Numeric.Location = new System.Drawing.Point(211, 172);
            this.mainControl_Interval_Numeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mainControl_Interval_Numeric.Name = "mainControl_Interval_Numeric";
            this.mainControl_Interval_Numeric.Size = new System.Drawing.Size(134, 29);
            this.mainControl_Interval_Numeric.TabIndex = 78;
            this.mainControl_Interval_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainControl_Interval_Numeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mainControl_Interval_Numeric.ValueChanged += new System.EventHandler(this.mainControl_Interval_Numeric_ValueChanged);
            this.mainControl_Interval_Numeric.Click += new System.EventHandler(this.mainControl_Interval_Numeric_Click);
            // 
            // mainControl_Control_ComboBox
            // 
            this.mainControl_Control_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.animatorPreview.SetDecoration(this.mainControl_Control_ComboBox, Zeroit.Framework.Transitions.DecorationType.None);
            this.mainControl_Control_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainControl_Control_ComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainControl_Control_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mainControl_Control_ComboBox.FormattingEnabled = true;
            this.mainControl_Control_ComboBox.Location = new System.Drawing.Point(211, 419);
            this.mainControl_Control_ComboBox.Name = "mainControl_Control_ComboBox";
            this.mainControl_Control_ComboBox.Size = new System.Drawing.Size(134, 29);
            this.mainControl_Control_ComboBox.TabIndex = 77;
            this.mainControl_Control_ComboBox.Click += new System.EventHandler(this.mainControl_Control_Numeric_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.animatorPreview.SetDecoration(this.label3, Zeroit.Framework.Transitions.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(30, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 76;
            this.label3.Text = "Duration";
            // 
            // mainControl_Duration_Numeric
            // 
            this.mainControl_Duration_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.mainControl_Duration_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animatorPreview.SetDecoration(this.mainControl_Duration_Numeric, Zeroit.Framework.Transitions.DecorationType.None);
            this.mainControl_Duration_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainControl_Duration_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.mainControl_Duration_Numeric.Location = new System.Drawing.Point(211, 113);
            this.mainControl_Duration_Numeric.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.mainControl_Duration_Numeric.Name = "mainControl_Duration_Numeric";
            this.mainControl_Duration_Numeric.Size = new System.Drawing.Size(134, 29);
            this.mainControl_Duration_Numeric.TabIndex = 75;
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
            this.animatorPreview.SetDecoration(this.label1, Zeroit.Framework.Transitions.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 72;
            this.label1.Text = "Animation Type";
            // 
            // mainControl_AnimationType_ComboBox
            // 
            this.mainControl_AnimationType_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.animatorPreview.SetDecoration(this.mainControl_AnimationType_ComboBox, Zeroit.Framework.Transitions.DecorationType.None);
            this.mainControl_AnimationType_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainControl_AnimationType_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainControl_AnimationType_ComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainControl_AnimationType_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mainControl_AnimationType_ComboBox.FormattingEnabled = true;
            this.mainControl_AnimationType_ComboBox.Location = new System.Drawing.Point(211, 53);
            this.mainControl_AnimationType_ComboBox.Name = "mainControl_AnimationType_ComboBox";
            this.mainControl_AnimationType_ComboBox.Size = new System.Drawing.Size(134, 29);
            this.mainControl_AnimationType_ComboBox.TabIndex = 73;
            this.mainControl_AnimationType_ComboBox.SelectedIndexChanged += new System.EventHandler(this.AnimationPropertyChanged);
            this.mainControl_AnimationType_ComboBox.Click += new System.EventHandler(this.mainControl_AnimationType_ComboBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.animatorPreview.SetDecoration(this.label2, Zeroit.Framework.Transitions.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(30, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 70;
            this.label2.Text = "Control";
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPreview.SetDecoration(this.okBtn, Zeroit.Framework.Transitions.DecorationType.None);
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.okBtn.Location = new System.Drawing.Point(1031, 469);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(95, 39);
            this.okBtn.TabIndex = 68;
            this.okBtn.Text = "&OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPreview.SetDecoration(this.cancelBtn, Zeroit.Framework.Transitions.DecorationType.None);
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancelBtn.Location = new System.Drawing.Point(1132, 469);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(95, 39);
            this.cancelBtn.TabIndex = 69;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // animatorPreview
            // 
            this.animatorPreview.AnimationType = Zeroit.Framework.Transitions.AnimationType.VertSlide;
            this.animatorPreview.Cursor = null;
            zeroitAnimate_Animation2.AnimateOnlyDifferences = true;
            zeroitAnimate_Animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation2.BlindCoeff")));
            zeroitAnimate_Animation2.LeafCoeff = 0F;
            zeroitAnimate_Animation2.MaxTime = 1F;
            zeroitAnimate_Animation2.MinTime = 0F;
            zeroitAnimate_Animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation2.MosaicCoeff")));
            zeroitAnimate_Animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation2.MosaicShift")));
            zeroitAnimate_Animation2.MosaicSize = 0;
            zeroitAnimate_Animation2.Padding = new System.Windows.Forms.Padding(0);
            zeroitAnimate_Animation2.RotateCoeff = 0F;
            zeroitAnimate_Animation2.RotateLimit = 0F;
            zeroitAnimate_Animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation2.ScaleCoeff")));
            zeroitAnimate_Animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation2.SlideCoeff")));
            zeroitAnimate_Animation2.TimeCoeff = 0F;
            zeroitAnimate_Animation2.TransparencyCoeff = 0F;
            this.animatorPreview.DefaultAnimation = zeroitAnimate_Animation2;
            this.animatorPreview.Target = this.animation_RotatingCube;
            this.animatorPreview.TargetHeight = 200;
            this.animatorPreview.TargetWidth = 200;
            this.animatorPreview.AnimationCompleted += new System.EventHandler<Zeroit.Framework.Transitions.AnimationCompletedEventArg>(this.animatorPreview_AnimationCompleted);
            // 
            // ZeroitAnimateAnimatorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1243, 524);
            this.Controls.Add(this.thematic1501);
            this.animatorPreview.SetDecoration(this, Zeroit.Framework.Transitions.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZeroitAnimateAnimatorDialog";
            this.Text = "ZeroitAnimateAnimatorDialog";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.thematic1501.ResumeLayout(false);
            this.thematic1501.PerformLayout();
            this.animation_GroupBox.ResumeLayout(false);
            this.animation_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl_TimeStep_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl_TargetHeight_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl_TargetWidth_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl_Interval_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl_Duration_Numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The thematic1501
        /// </summary>
        private ThemeManagers.NYX thematic1501;
        /// <summary>
        /// The label5
        /// </summary>
        private System.Windows.Forms.Label label5;
        /// <summary>
        /// The main control target width numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown mainControl_TargetWidth_Numeric;
        /// <summary>
        /// The label4
        /// </summary>
        private System.Windows.Forms.Label label4;
        /// <summary>
        /// The main control interval numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown mainControl_Interval_Numeric;
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
        /// The zeroit lb knob1
        /// </summary>
        private _HelpingControls.LBKnob.ZeroitLBKnob zeroitLBKnob1;
        /// <summary>
        /// The label1
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// The main control animation type ComboBox
        /// </summary>
        private System.Windows.Forms.ComboBox mainControl_AnimationType_ComboBox;
        /// <summary>
        /// The label2
        /// </summary>
        private System.Windows.Forms.Label label2;
        /// <summary>
        /// The ok BTN
        /// </summary>
        public System.Windows.Forms.Button okBtn;
        /// <summary>
        /// The cancel BTN
        /// </summary>
        public System.Windows.Forms.Button cancelBtn;
        /// <summary>
        /// The label6
        /// </summary>
        private System.Windows.Forms.Label label6;
        /// <summary>
        /// The main control target height numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown mainControl_TargetHeight_Numeric;
        /// <summary>
        /// The show knob4 target height BTN
        /// </summary>
        public System.Windows.Forms.Button showKnob4_TargetHeight_Btn;
        /// <summary>
        /// The show knob3 target width BTN
        /// </summary>
        public System.Windows.Forms.Button showKnob3_TargetWidth_Btn;
        /// <summary>
        /// The show knob2 interval BTN
        /// </summary>
        public System.Windows.Forms.Button showKnob2_Interval_Btn;
        /// <summary>
        /// The show knob1 duration BTN
        /// </summary>
        public System.Windows.Forms.Button showKnob1_Duration_Btn;
        /// <summary>
        /// The close BTN
        /// </summary>
        private System.Windows.Forms.Button closeBtn;
        /// <summary>
        /// The testing label
        /// </summary>
        private System.Windows.Forms.Label testingLabel;
        /// <summary>
        /// The label7
        /// </summary>
        private System.Windows.Forms.Label label7;
        /// <summary>
        /// The main control time step numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown mainControl_TimeStep_Numeric;
        /// <summary>
        /// The show knob5 time step BTN
        /// </summary>
        public System.Windows.Forms.Button showKnob5_TimeStep_Btn;
        /// <summary>
        /// The animation group box
        /// </summary>
        private System.Windows.Forms.GroupBox animation_GroupBox;
        /// <summary>
        /// The label8
        /// </summary>
        private System.Windows.Forms.Label label8;
        /// <summary>
        /// The animator preview
        /// </summary>
        private ZeroitAnimator animatorPreview;
        /// <summary>
        /// The animation type label
        /// </summary>
        private System.Windows.Forms.Label animationType_Label;
        /// <summary>
        /// The animation rotating cube
        /// </summary>
        private Transitions._HelpingControls.Rotating3DCube.RotatingCube animation_RotatingCube;
        /// <summary>
        /// The animation preview BTN
        /// </summary>
        public System.Windows.Forms.Button animation_Preview_Btn;
        /// <summary>
        /// The animation progress label
        /// </summary>
        private System.Windows.Forms.Label animationProgress_Label;
    }
}