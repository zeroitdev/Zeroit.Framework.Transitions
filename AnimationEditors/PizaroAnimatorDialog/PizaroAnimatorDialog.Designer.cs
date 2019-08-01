// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-04-2018
// ***********************************************************************
// <copyright file="PizaroAnimatorDialog.Designer.cs" company="Zeroit Dev Technologies">
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
    /// Class ZeroitPizaroAnimatorDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class ZeroitPizaroAnimatorDialog
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
            this.thematic1501 = new Zeroit.Framework.Transitions.ThemeManagers.Jtheme();
            this.general_Container = new System.Windows.Forms.Panel();
            this.okBtn = new System.Windows.Forms.Button();
            this.fade_preview_Panel = new Zeroit.Framework.Transitions.AnimationEditors.NoFlickerPanel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.fade_Preview_btn = new System.Windows.Forms.Button();
            this.general_GroupBox = new System.Windows.Forms.GroupBox();
            this.generalContainer_Control_Name_Label = new System.Windows.Forms.Label();
            this.generalContainer_Easing_ComboBox = new System.Windows.Forms.ComboBox();
            this.generalContainer_EasingEnd_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.generalContainer_EasingStart_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.generalContainer_Duration_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.generalContainer_Acceleration_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generalContainer_Control_ComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.generalContainer_AnimationType_ComboBox = new System.Windows.Forms.ComboBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.fade_Animator = new Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim();
            this.fadeIn_Animator = new Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim();
            this.fadeInAndShow_Animator = new Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim();
            this.fadeOut_Animator = new Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim();
            this.fadeOutAndHide_Animator = new Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim();
            this.thematic1501.SuspendLayout();
            this.general_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalContainer_EasingEnd_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalContainer_EasingStart_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalContainer_Duration_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalContainer_Acceleration_Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // thematic1501
            // 
            this.thematic1501.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thematic1501.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.thematic1501.Colors = new Zeroit.Framework.Transitions.ThemeManagers.Bloom[0];
            this.thematic1501.Controls.Add(this.general_Container);
            this.thematic1501.Controls.Add(this.okBtn);
            this.thematic1501.Controls.Add(this.fade_preview_Panel);
            this.thematic1501.Controls.Add(this.cancelBtn);
            this.thematic1501.Controls.Add(this.fade_Preview_btn);
            this.thematic1501.Controls.Add(this.general_GroupBox);
            this.thematic1501.Controls.Add(this.closeBtn);
            this.thematic1501.Customization = "";
            this.thematic1501.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thematic1501.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.thematic1501.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.thematic1501.Image = null;
            this.thematic1501.Location = new System.Drawing.Point(0, 0);
            this.thematic1501.Movable = true;
            this.thematic1501.Name = "thematic1501";
            this.thematic1501.NoRounding = false;
            this.thematic1501.Padding = new System.Windows.Forms.Padding(2, 36, 2, 2);
            this.thematic1501.Sizable = false;
            this.thematic1501.Size = new System.Drawing.Size(1218, 508);
            this.thematic1501.SmartBounds = true;
            this.thematic1501.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.thematic1501.TabIndex = 0;
            this.thematic1501.Text = "Pizaro Animator";
            this.thematic1501.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.thematic1501.Transparent = false;
            // 
            // general_Container
            // 
            this.general_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.general_Container.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.general_Container.Location = new System.Drawing.Point(334, 461);
            this.general_Container.Name = "general_Container";
            this.general_Container.Size = new System.Drawing.Size(25, 24);
            this.general_Container.TabIndex = 39;
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.Crimson;
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.okBtn.Location = new System.Drawing.Point(69, 440);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(104, 45);
            this.okBtn.TabIndex = 7;
            this.okBtn.Text = "&OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // fade_preview_Panel
            // 
            this.fade_preview_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.fade_preview_Panel.Location = new System.Drawing.Point(380, 350);
            this.fade_preview_Panel.Name = "fade_preview_Panel";
            this.fade_preview_Panel.Size = new System.Drawing.Size(803, 133);
            this.fade_preview_Panel.TabIndex = 56;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.SlateGray;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancelBtn.Location = new System.Drawing.Point(181, 440);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(104, 45);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // fade_Preview_btn
            // 
            this.fade_Preview_btn.FlatAppearance.BorderSize = 0;
            this.fade_Preview_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fade_Preview_btn.Font = new System.Drawing.Font("Verdana", 10F);
            this.fade_Preview_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fade_Preview_btn.Location = new System.Drawing.Point(1077, 316);
            this.fade_Preview_btn.Name = "fade_Preview_btn";
            this.fade_Preview_btn.Size = new System.Drawing.Size(104, 28);
            this.fade_Preview_btn.TabIndex = 55;
            this.fade_Preview_btn.Text = "Preview";
            this.fade_Preview_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fade_Preview_btn.UseVisualStyleBackColor = false;
            this.fade_Preview_btn.Visible = false;
            this.fade_Preview_btn.Click += new System.EventHandler(this.fade_Preview_btn_Click);
            this.fade_Preview_btn.MouseEnter += new System.EventHandler(this.fade_Preview_btn_MouseEnter);
            this.fade_Preview_btn.MouseLeave += new System.EventHandler(this.fade_Preview_btn_MouseLeave);
            // 
            // general_GroupBox
            // 
            this.general_GroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.general_GroupBox.Controls.Add(this.generalContainer_Control_Name_Label);
            this.general_GroupBox.Controls.Add(this.generalContainer_Easing_ComboBox);
            this.general_GroupBox.Controls.Add(this.generalContainer_EasingEnd_Numeric);
            this.general_GroupBox.Controls.Add(this.label6);
            this.general_GroupBox.Controls.Add(this.generalContainer_EasingStart_Numeric);
            this.general_GroupBox.Controls.Add(this.label5);
            this.general_GroupBox.Controls.Add(this.label4);
            this.general_GroupBox.Controls.Add(this.generalContainer_Duration_Numeric);
            this.general_GroupBox.Controls.Add(this.label1);
            this.general_GroupBox.Controls.Add(this.generalContainer_Acceleration_Numeric);
            this.general_GroupBox.Controls.Add(this.label23);
            this.general_GroupBox.Controls.Add(this.label2);
            this.general_GroupBox.Controls.Add(this.generalContainer_Control_ComboBox);
            this.general_GroupBox.Controls.Add(this.label3);
            this.general_GroupBox.Controls.Add(this.generalContainer_AnimationType_ComboBox);
            this.general_GroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.general_GroupBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.general_GroupBox.Location = new System.Drawing.Point(18, 25);
            this.general_GroupBox.Name = "general_GroupBox";
            this.general_GroupBox.Size = new System.Drawing.Size(312, 400);
            this.general_GroupBox.TabIndex = 0;
            this.general_GroupBox.TabStop = false;
            this.general_GroupBox.Text = "General Parameters";
            // 
            // generalContainer_Control_Name_Label
            // 
            this.generalContainer_Control_Name_Label.AutoSize = true;
            this.generalContainer_Control_Name_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.generalContainer_Control_Name_Label.Location = new System.Drawing.Point(186, 353);
            this.generalContainer_Control_Name_Label.Name = "generalContainer_Control_Name_Label";
            this.generalContainer_Control_Name_Label.Size = new System.Drawing.Size(52, 21);
            this.generalContainer_Control_Name_Label.TabIndex = 32;
            this.generalContainer_Control_Name_Label.Text = "Name";
            this.generalContainer_Control_Name_Label.Visible = false;
            // 
            // generalContainer_Easing_ComboBox
            // 
            this.generalContainer_Easing_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.generalContainer_Easing_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generalContainer_Easing_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generalContainer_Easing_ComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.generalContainer_Easing_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.generalContainer_Easing_ComboBox.FormattingEnabled = true;
            this.generalContainer_Easing_ComboBox.Items.AddRange(new object[] {
            "BackEaseIn",
            "BackEaseInOut",
            "BackEaseOut",
            "BackEaseOutIn",
            "BounceEaseIn",
            "BounceEaseInOut",
            "BounceEaseOut",
            "BounceEaseOutIn",
            "EaseIn",
            "EaseInAndOut",
            "EaseInCirc",
            "EaseInCubic",
            "EaseInExpo",
            "EaseInOutCirc",
            "EaseInOutCubic",
            "EaseInOutExpo",
            "EaseInOutQuad",
            "EaseInOutQuart",
            "EaseInOutQuint",
            "EaseInOutSine",
            "EaseInQuad",
            "EaseInQuart",
            "EaseInQuint",
            "EaseInSine",
            "EaseOut",
            "EaseOutCirc",
            "EaseOutCubic",
            "EaseOutExpo",
            "EaseOutQuad",
            "EaseOutQuart",
            "EaseOutQuint",
            "EaseOutSine",
            "ElasticEaseIn",
            "ElasticEaseInOut",
            "ElasticEaseOut",
            "ElasticEaseOutIn",
            "Linear",
            "LinearTween"});
            this.generalContainer_Easing_ComboBox.Location = new System.Drawing.Point(154, 79);
            this.generalContainer_Easing_ComboBox.Name = "generalContainer_Easing_ComboBox";
            this.generalContainer_Easing_ComboBox.Size = new System.Drawing.Size(134, 29);
            this.generalContainer_Easing_ComboBox.TabIndex = 31;
            this.generalContainer_Easing_ComboBox.SelectedIndexChanged += new System.EventHandler(this.generalContainer_Easing_ComboBox_SelectedIndexChanged);
            // 
            // generalContainer_EasingEnd_Numeric
            // 
            this.generalContainer_EasingEnd_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.generalContainer_EasingEnd_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generalContainer_EasingEnd_Numeric.DecimalPlaces = 2;
            this.generalContainer_EasingEnd_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.generalContainer_EasingEnd_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.generalContainer_EasingEnd_Numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.generalContainer_EasingEnd_Numeric.Location = new System.Drawing.Point(154, 188);
            this.generalContainer_EasingEnd_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.generalContainer_EasingEnd_Numeric.Name = "generalContainer_EasingEnd_Numeric";
            this.generalContainer_EasingEnd_Numeric.Size = new System.Drawing.Size(134, 29);
            this.generalContainer_EasingEnd_Numeric.TabIndex = 30;
            this.generalContainer_EasingEnd_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.generalContainer_EasingEnd_Numeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.generalContainer_EasingEnd_Numeric.ValueChanged += new System.EventHandler(this.generalContainer_EasingEnd_Numeric_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(6, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Easing End";
            // 
            // generalContainer_EasingStart_Numeric
            // 
            this.generalContainer_EasingStart_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.generalContainer_EasingStart_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generalContainer_EasingStart_Numeric.DecimalPlaces = 2;
            this.generalContainer_EasingStart_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.generalContainer_EasingStart_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.generalContainer_EasingStart_Numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.generalContainer_EasingStart_Numeric.Location = new System.Drawing.Point(154, 134);
            this.generalContainer_EasingStart_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.generalContainer_EasingStart_Numeric.Name = "generalContainer_EasingStart_Numeric";
            this.generalContainer_EasingStart_Numeric.Size = new System.Drawing.Size(134, 29);
            this.generalContainer_EasingStart_Numeric.TabIndex = 28;
            this.generalContainer_EasingStart_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.generalContainer_EasingStart_Numeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.generalContainer_EasingStart_Numeric.ValueChanged += new System.EventHandler(this.generalContainer_EasingStart_Numeric_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Easing Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Easing";
            // 
            // generalContainer_Duration_Numeric
            // 
            this.generalContainer_Duration_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.generalContainer_Duration_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generalContainer_Duration_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.generalContainer_Duration_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.generalContainer_Duration_Numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.generalContainer_Duration_Numeric.Location = new System.Drawing.Point(154, 296);
            this.generalContainer_Duration_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.generalContainer_Duration_Numeric.Name = "generalContainer_Duration_Numeric";
            this.generalContainer_Duration_Numeric.Size = new System.Drawing.Size(134, 29);
            this.generalContainer_Duration_Numeric.TabIndex = 24;
            this.generalContainer_Duration_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.generalContainer_Duration_Numeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.generalContainer_Duration_Numeric.ValueChanged += new System.EventHandler(this.generalContainer_Duration_Numeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(6, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Duration";
            // 
            // generalContainer_Acceleration_Numeric
            // 
            this.generalContainer_Acceleration_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.generalContainer_Acceleration_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generalContainer_Acceleration_Numeric.DecimalPlaces = 2;
            this.generalContainer_Acceleration_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.generalContainer_Acceleration_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.generalContainer_Acceleration_Numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.generalContainer_Acceleration_Numeric.Location = new System.Drawing.Point(154, 242);
            this.generalContainer_Acceleration_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.generalContainer_Acceleration_Numeric.Name = "generalContainer_Acceleration_Numeric";
            this.generalContainer_Acceleration_Numeric.Size = new System.Drawing.Size(134, 29);
            this.generalContainer_Acceleration_Numeric.TabIndex = 22;
            this.generalContainer_Acceleration_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.generalContainer_Acceleration_Numeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.generalContainer_Acceleration_Numeric.ValueChanged += new System.EventHandler(this.generalContainer_Acceleration_Numeric_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label23.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label23.Location = new System.Drawing.Point(6, 246);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(95, 21);
            this.label23.TabIndex = 20;
            this.label23.Text = "Acceleration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(6, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Control";
            // 
            // generalContainer_Control_ComboBox
            // 
            this.generalContainer_Control_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.generalContainer_Control_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generalContainer_Control_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generalContainer_Control_ComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.generalContainer_Control_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.generalContainer_Control_ComboBox.FormattingEnabled = true;
            this.generalContainer_Control_ComboBox.Location = new System.Drawing.Point(154, 350);
            this.generalContainer_Control_ComboBox.Name = "generalContainer_Control_ComboBox";
            this.generalContainer_Control_ComboBox.Size = new System.Drawing.Size(134, 29);
            this.generalContainer_Control_ComboBox.TabIndex = 19;
            this.generalContainer_Control_ComboBox.SelectedIndexChanged += new System.EventHandler(this.generalContainer_Control_ComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Animation Type";
            // 
            // generalContainer_AnimationType_ComboBox
            // 
            this.generalContainer_AnimationType_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.generalContainer_AnimationType_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generalContainer_AnimationType_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generalContainer_AnimationType_ComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.generalContainer_AnimationType_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.generalContainer_AnimationType_ComboBox.FormattingEnabled = true;
            this.generalContainer_AnimationType_ComboBox.Items.AddRange(new object[] {
            "Fade",
            "FadeIn",
            "FadeInAndShow",
            "FadeOut",
            "FadeOutandHide",
            "Resize",
            "ResizeHeight",
            "ResizeWidth",
            "Slide",
            "SlideFrom",
            "None"});
            this.generalContainer_AnimationType_ComboBox.Location = new System.Drawing.Point(154, 26);
            this.generalContainer_AnimationType_ComboBox.Name = "generalContainer_AnimationType_ComboBox";
            this.generalContainer_AnimationType_ComboBox.Size = new System.Drawing.Size(134, 29);
            this.generalContainer_AnimationType_ComboBox.TabIndex = 3;
            this.generalContainer_AnimationType_ComboBox.SelectedIndexChanged += new System.EventHandler(this.PropertyTypeChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.closeBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.closeBtn.Location = new System.Drawing.Point(1197, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(16, 16);
            this.closeBtn.TabIndex = 53;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // fade_Animator
            // 
            this.fade_Animator.Acceleration = 0.7F;
            this.fade_Animator.AnimationType = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.animationType.Fade;
            this.fade_Animator.Control = this.fade_preview_Panel;
            this.fade_Animator.ControlStyles = System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer;
            this.fade_Animator.ControlStylesBool = false;
            this.fade_Animator.CordinateEnd_X = 50F;
            this.fade_Animator.CordinateEnd_Y = 50F;
            this.fade_Animator.CordinateStart_X = 10F;
            this.fade_Animator.CordinateStart_Y = 10F;
            this.fade_Animator.Duration = 1000;
            this.fade_Animator.EasingEnd = 1F;
            this.fade_Animator.EasingNames = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseIn;
            this.fade_Animator.EasingStart = 0.2F;
            this.fade_Animator.Fade_Begin = 0F;
            this.fade_Animator.Fade_Limit = 1F;
            this.fade_Animator.ResizeHeight_Begin = 10F;
            this.fade_Animator.ResizeHeight_Limit = 50F;
            this.fade_Animator.ResizeWidth_Begin = 10F;
            this.fade_Animator.ResizeWidth_Limit = 50F;
            // 
            // fadeIn_Animator
            // 
            this.fadeIn_Animator.Acceleration = 0.7F;
            this.fadeIn_Animator.AnimationType = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.animationType.FadeIn;
            this.fadeIn_Animator.Control = this.fade_preview_Panel;
            this.fadeIn_Animator.ControlStyles = System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer;
            this.fadeIn_Animator.ControlStylesBool = false;
            this.fadeIn_Animator.CordinateEnd_X = 50F;
            this.fadeIn_Animator.CordinateEnd_Y = 50F;
            this.fadeIn_Animator.CordinateStart_X = 10F;
            this.fadeIn_Animator.CordinateStart_Y = 10F;
            this.fadeIn_Animator.Duration = 1000;
            this.fadeIn_Animator.EasingEnd = 1F;
            this.fadeIn_Animator.EasingNames = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseIn;
            this.fadeIn_Animator.EasingStart = 0.2F;
            this.fadeIn_Animator.Fade_Begin = 0F;
            this.fadeIn_Animator.Fade_Limit = 1F;
            this.fadeIn_Animator.ResizeHeight_Begin = 10F;
            this.fadeIn_Animator.ResizeHeight_Limit = 50F;
            this.fadeIn_Animator.ResizeWidth_Begin = 10F;
            this.fadeIn_Animator.ResizeWidth_Limit = 50F;
            // 
            // fadeInAndShow_Animator
            // 
            this.fadeInAndShow_Animator.Acceleration = 0.7F;
            this.fadeInAndShow_Animator.AnimationType = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.animationType.FadeInAndShow;
            this.fadeInAndShow_Animator.Control = this.fade_preview_Panel;
            this.fadeInAndShow_Animator.ControlStyles = System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer;
            this.fadeInAndShow_Animator.ControlStylesBool = false;
            this.fadeInAndShow_Animator.CordinateEnd_X = 50F;
            this.fadeInAndShow_Animator.CordinateEnd_Y = 50F;
            this.fadeInAndShow_Animator.CordinateStart_X = 10F;
            this.fadeInAndShow_Animator.CordinateStart_Y = 10F;
            this.fadeInAndShow_Animator.Duration = 1000;
            this.fadeInAndShow_Animator.EasingEnd = 1F;
            this.fadeInAndShow_Animator.EasingNames = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseIn;
            this.fadeInAndShow_Animator.EasingStart = 0.2F;
            this.fadeInAndShow_Animator.Fade_Begin = 0F;
            this.fadeInAndShow_Animator.Fade_Limit = 1F;
            this.fadeInAndShow_Animator.ResizeHeight_Begin = 10F;
            this.fadeInAndShow_Animator.ResizeHeight_Limit = 50F;
            this.fadeInAndShow_Animator.ResizeWidth_Begin = 10F;
            this.fadeInAndShow_Animator.ResizeWidth_Limit = 50F;
            // 
            // fadeOut_Animator
            // 
            this.fadeOut_Animator.Acceleration = 0.7F;
            this.fadeOut_Animator.AnimationType = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.animationType.FadeOut;
            this.fadeOut_Animator.Control = this.fade_preview_Panel;
            this.fadeOut_Animator.ControlStyles = System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer;
            this.fadeOut_Animator.ControlStylesBool = false;
            this.fadeOut_Animator.CordinateEnd_X = 50F;
            this.fadeOut_Animator.CordinateEnd_Y = 50F;
            this.fadeOut_Animator.CordinateStart_X = 10F;
            this.fadeOut_Animator.CordinateStart_Y = 10F;
            this.fadeOut_Animator.Duration = 1000;
            this.fadeOut_Animator.EasingEnd = 1F;
            this.fadeOut_Animator.EasingNames = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseIn;
            this.fadeOut_Animator.EasingStart = 0.2F;
            this.fadeOut_Animator.Fade_Begin = 0F;
            this.fadeOut_Animator.Fade_Limit = 1F;
            this.fadeOut_Animator.ResizeHeight_Begin = 10F;
            this.fadeOut_Animator.ResizeHeight_Limit = 50F;
            this.fadeOut_Animator.ResizeWidth_Begin = 10F;
            this.fadeOut_Animator.ResizeWidth_Limit = 50F;
            // 
            // fadeOutAndHide_Animator
            // 
            this.fadeOutAndHide_Animator.Acceleration = 0.7F;
            this.fadeOutAndHide_Animator.AnimationType = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.animationType.FadeOutandHide;
            this.fadeOutAndHide_Animator.Control = this.fade_preview_Panel;
            this.fadeOutAndHide_Animator.ControlStyles = System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer;
            this.fadeOutAndHide_Animator.ControlStylesBool = false;
            this.fadeOutAndHide_Animator.CordinateEnd_X = 50F;
            this.fadeOutAndHide_Animator.CordinateEnd_Y = 50F;
            this.fadeOutAndHide_Animator.CordinateStart_X = 10F;
            this.fadeOutAndHide_Animator.CordinateStart_Y = 10F;
            this.fadeOutAndHide_Animator.Duration = 1000;
            this.fadeOutAndHide_Animator.EasingEnd = 1F;
            this.fadeOutAndHide_Animator.EasingNames = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseIn;
            this.fadeOutAndHide_Animator.EasingStart = 0.2F;
            this.fadeOutAndHide_Animator.Fade_Begin = 0F;
            this.fadeOutAndHide_Animator.Fade_Limit = 1F;
            this.fadeOutAndHide_Animator.ResizeHeight_Begin = 10F;
            this.fadeOutAndHide_Animator.ResizeHeight_Limit = 50F;
            this.fadeOutAndHide_Animator.ResizeWidth_Begin = 10F;
            this.fadeOutAndHide_Animator.ResizeWidth_Limit = 50F;
            // 
            // ZeroitPizaroAnimatorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 508);
            this.Controls.Add(this.thematic1501);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZeroitPizaroAnimatorDialog";
            this.ShowInTaskbar = false;
            this.Text = "ZeroitPizaroAnimatorDialog";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.thematic1501.ResumeLayout(false);
            this.general_GroupBox.ResumeLayout(false);
            this.general_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalContainer_EasingEnd_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalContainer_EasingStart_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalContainer_Duration_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalContainer_Acceleration_Numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The fade animator
        /// </summary>
        private ZeroitPizaroAnimator.ZeroitPizaroAnim fade_Animator;
        /// <summary>
        /// The thematic1501
        /// </summary>
        private ThemeManagers.Jtheme thematic1501;
        /// <summary>
        /// The general container
        /// </summary>
        private System.Windows.Forms.Panel general_Container;
        /// <summary>
        /// The ok BTN
        /// </summary>
        public System.Windows.Forms.Button okBtn;
        /// <summary>
        /// The cancel BTN
        /// </summary>
        public System.Windows.Forms.Button cancelBtn;
        /// <summary>
        /// The general group box
        /// </summary>
        private System.Windows.Forms.GroupBox general_GroupBox;
        /// <summary>
        /// The general container duration numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown generalContainer_Duration_Numeric;
        /// <summary>
        /// The label1
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// The general container acceleration numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown generalContainer_Acceleration_Numeric;
        /// <summary>
        /// The label23
        /// </summary>
        private System.Windows.Forms.Label label23;
        /// <summary>
        /// The label2
        /// </summary>
        private System.Windows.Forms.Label label2;
        /// <summary>
        /// The general container control ComboBox
        /// </summary>
        private System.Windows.Forms.ComboBox generalContainer_Control_ComboBox;
        /// <summary>
        /// The label3
        /// </summary>
        private System.Windows.Forms.Label label3;
        /// <summary>
        /// The general container animation type ComboBox
        /// </summary>
        private System.Windows.Forms.ComboBox generalContainer_AnimationType_ComboBox;
        /// <summary>
        /// The close BTN
        /// </summary>
        private System.Windows.Forms.Button closeBtn;
        /// <summary>
        /// The general container easing end numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown generalContainer_EasingEnd_Numeric;
        /// <summary>
        /// The label6
        /// </summary>
        private System.Windows.Forms.Label label6;
        /// <summary>
        /// The general container easing start numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown generalContainer_EasingStart_Numeric;
        /// <summary>
        /// The label5
        /// </summary>
        private System.Windows.Forms.Label label5;
        /// <summary>
        /// The label4
        /// </summary>
        private System.Windows.Forms.Label label4;
        /// <summary>
        /// The general container easing ComboBox
        /// </summary>
        private System.Windows.Forms.ComboBox generalContainer_Easing_ComboBox;
        /// <summary>
        /// The fade preview BTN
        /// </summary>
        public System.Windows.Forms.Button fade_Preview_btn;
        /// <summary>
        /// The fade in animator
        /// </summary>
        private ZeroitPizaroAnimator.ZeroitPizaroAnim fadeIn_Animator;
        /// <summary>
        /// The fade in and show animator
        /// </summary>
        private ZeroitPizaroAnimator.ZeroitPizaroAnim fadeInAndShow_Animator;
        /// <summary>
        /// The fade out animator
        /// </summary>
        private ZeroitPizaroAnimator.ZeroitPizaroAnim fadeOut_Animator;
        /// <summary>
        /// The fade out and hide animator
        /// </summary>
        private ZeroitPizaroAnimator.ZeroitPizaroAnim fadeOutAndHide_Animator;
        /// <summary>
        /// The fade preview panel
        /// </summary>
        private NoFlickerPanel fade_preview_Panel;
        /// <summary>
        /// The general container control name label
        /// </summary>
        private System.Windows.Forms.Label generalContainer_Control_Name_Label;
    }
}