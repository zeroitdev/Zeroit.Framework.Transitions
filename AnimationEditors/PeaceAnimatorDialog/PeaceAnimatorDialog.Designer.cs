// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-04-2018
// ***********************************************************************
// <copyright file="PeaceAnimatorDialog.Designer.cs" company="Zeroit Dev Technologies">
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
    /// Class ZeroitPeaceAnimatorDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class ZeroitPeaceAnimatorDialog
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
            this.peaceAnimator1 = new Zeroit.Framework.Transitions.WinformAnimation.ZeroitPeaceAnim();
            this.colorChanger = new System.Windows.Forms.ColorDialog();
            this.oneD_Width_Animator = new Zeroit.Framework.Transitions.WinformAnimation.ZeroitPeaceAnim();
            this.oneD_RotatingCube = new Zeroit.Framework.Transitions._HelpingControls.Rotating3DCube.RotatingCube();
            this.oneD_Height_Animator = new Zeroit.Framework.Transitions.WinformAnimation.ZeroitPeaceAnim();
            this.oneD_Opacity_Animator = new Zeroit.Framework.Transitions.WinformAnimation.ZeroitPeaceAnim();
            this.oneD_Value_Animator = new Zeroit.Framework.Transitions.WinformAnimation.ZeroitPeaceAnim();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.threeD_RotatingCube = new Zeroit.Framework.Transitions._HelpingControls.Rotating3DCube.RotatingCube();
            this.twoD_RotatingCube = new Zeroit.Framework.Transitions._HelpingControls.Rotating3DCube.RotatingCube();
            this.oneD_Custom_Animator = new Zeroit.Framework.Transitions.WinformAnimation.ZeroitPeaceAnim();
            this.twoD_Location_Animator = new Zeroit.Framework.Transitions.WinformAnimation.ZeroitPeaceAnim();
            this.twoD_Size_Animator = new Zeroit.Framework.Transitions.WinformAnimation.ZeroitPeaceAnim();
            this.thematic1501 = new Zeroit.Framework.Transitions.ThemeManagers.NYX();
            this.closeBtn = new System.Windows.Forms.Button();
            this.general_Container = new System.Windows.Forms.Panel();
            this.zeroitSimpleLine21 = new Zeroit.Framework.Transitions._HelpingControls.LineSimple2();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.general_GroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.control_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainControl_animationMode_Combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mainControl_Path_Continue_ComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mainControl_Repeat_ComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mainControl_Reverse_ComboBox = new System.Windows.Forms.ComboBox();
            this.threeD_GroupBox = new System.Windows.Forms.GroupBox();
            this.threeD_Preview = new System.Windows.Forms.Button();
            this.threeD_Easing_ComboBox = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.threeD_End_Color_Button = new System.Windows.Forms.Button();
            this.label42 = new System.Windows.Forms.Label();
            this.threeD_Start_Color_Button = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.threeD_Delay_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.threeD_Duration_Numeric = new System.Windows.Forms.NumericUpDown();
            this.threeD_Property_ComboBox = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.threeD_Color_Property_Name_TextBox = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.twoD_GroupBox = new System.Windows.Forms.GroupBox();
            this.twoD_Preview = new System.Windows.Forms.Button();
            this.twoD_Reset_btn = new System.Windows.Forms.Button();
            this.twoD_Easing_ComboBox = new System.Windows.Forms.ComboBox();
            this.twoD_Easing_Label = new System.Windows.Forms.Label();
            this.twoD_Delay2_Label = new System.Windows.Forms.Label();
            this.twoD_Delay2_Numeric = new System.Windows.Forms.NumericUpDown();
            this.twoD_Duration2_Label = new System.Windows.Forms.Label();
            this.twoD_Duration2_Numeric = new System.Windows.Forms.NumericUpDown();
            this.twoD_End2_Label = new System.Windows.Forms.Label();
            this.twoD_End2_Numeric = new System.Windows.Forms.NumericUpDown();
            this.twoD_Start2_Label = new System.Windows.Forms.Label();
            this.twoD_Start2_Numeric = new System.Windows.Forms.NumericUpDown();
            this.twoD_Continued_Delay2_Label = new System.Windows.Forms.Label();
            this.twoD_Continued_Delay2_Numeric = new System.Windows.Forms.NumericUpDown();
            this.twoD_Continued_End2_Label = new System.Windows.Forms.Label();
            this.twoD_Continued_End2_Numeric = new System.Windows.Forms.NumericUpDown();
            this.twoD_Continued_Duration2_Label = new System.Windows.Forms.Label();
            this.twoD_Continued_Duration2_Numeric = new System.Windows.Forms.NumericUpDown();
            this.twoD_Continued_Start2_Label = new System.Windows.Forms.Label();
            this.twoD_Continued_Start2_Numeric = new System.Windows.Forms.NumericUpDown();
            this.twoD_Continued_Delay1_Label = new System.Windows.Forms.Label();
            this.twoD_Continued_Delay1_Numeric = new System.Windows.Forms.NumericUpDown();
            this.twoD_Continued_Duration1_Label = new System.Windows.Forms.Label();
            this.twoD_Continued_Duration1_Numeric = new System.Windows.Forms.NumericUpDown();
            this.twoD_Continued_End1_Label = new System.Windows.Forms.Label();
            this.twoD_Continued_End1_Numeric = new System.Windows.Forms.NumericUpDown();
            this.twoD_Continued_Start1_Label = new System.Windows.Forms.Label();
            this.twoD_Continued_Start1_Numeric = new System.Windows.Forms.NumericUpDown();
            this.twoD_Continued_Easing_ComboBox = new System.Windows.Forms.ComboBox();
            this.twoD_Continued_Easing_Label = new System.Windows.Forms.Label();
            this.twoD_Delay1_Label = new System.Windows.Forms.Label();
            this.twoD_Delay1_Numeric = new System.Windows.Forms.NumericUpDown();
            this.twoD_Duration1_Label = new System.Windows.Forms.Label();
            this.twoD_Duration1_Numeric = new System.Windows.Forms.NumericUpDown();
            this.twoD_End1_Label = new System.Windows.Forms.Label();
            this.twoD_End1_Numeric = new System.Windows.Forms.NumericUpDown();
            this.twoD_Property_ComboBox = new System.Windows.Forms.ComboBox();
            this.twoD_Property_Label = new System.Windows.Forms.Label();
            this.twoD_Start1_Label = new System.Windows.Forms.Label();
            this.twoD_Start1_Numeric = new System.Windows.Forms.NumericUpDown();
            this.oneD_GroupBox = new System.Windows.Forms.GroupBox();
            this.oneD_Preview = new System.Windows.Forms.Button();
            this.oneD_Easing_ComboBox = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.oneD_Delay_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.oneD_Duration_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.oneD_End_Numeric = new System.Windows.Forms.NumericUpDown();
            this.oneD_Property_ComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.oneD_Start_Numeric = new System.Windows.Forms.NumericUpDown();
            this.oneD_Custom_Property_Name_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.thematic1501.SuspendLayout();
            this.general_Container.SuspendLayout();
            this.general_GroupBox.SuspendLayout();
            this.threeD_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threeD_Delay_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeD_Duration_Numeric)).BeginInit();
            this.twoD_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Delay2_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Duration2_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_End2_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Start2_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Continued_Delay2_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Continued_End2_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Continued_Duration2_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Continued_Start2_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Continued_Delay1_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Continued_Duration1_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Continued_End1_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Continued_Start1_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Delay1_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Duration1_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_End1_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Start1_Numeric)).BeginInit();
            this.oneD_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oneD_Delay_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneD_Duration_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneD_End_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneD_Start_Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // peaceAnimator1
            // 
            this.peaceAnimator1.AnimationMode = Zeroit.Framework.Transitions.WinformAnimation.animationMode.OneD;
            this.peaceAnimator1.ColorPropertyName = "BackColor";
            this.peaceAnimator1.Continued_Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut;
            this.peaceAnimator1.Continued_path2D_delay_1 = ((ulong)(300ul));
            this.peaceAnimator1.Continued_path2D_delay_2 = ((ulong)(600ul));
            this.peaceAnimator1.Continued_path2D_duration_1 = ((ulong)(2000ul));
            this.peaceAnimator1.Continued_path2D_duration_2 = ((ulong)(1700ul));
            this.peaceAnimator1.Continued_path2D_end_1 = 70F;
            this.peaceAnimator1.Continued_path2D_end_2 = 5F;
            this.peaceAnimator1.Continued_path2D_start_1 = 320F;
            this.peaceAnimator1.Continued_path2D_start_2 = 100F;
            this.peaceAnimator1.DelayValue = ((ulong)(0ul));
            this.peaceAnimator1.DurationValue = ((ulong)(5000ul));
            this.peaceAnimator1.EndColor = System.Drawing.Color.Orange;
            this.peaceAnimator1.EndValue = 100F;
            this.peaceAnimator1.OneD_Continue = true;
            this.peaceAnimator1.OneD_Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.peaceAnimator1.OneDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator.KnownProperties.Value;
            this.peaceAnimator1.Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.peaceAnimator1.Path2D_delay_1 = ((ulong)(0ul));
            this.peaceAnimator1.Path2D_delay_2 = ((ulong)(0ul));
            this.peaceAnimator1.Path2D_duration_1 = ((ulong)(2000ul));
            this.peaceAnimator1.Path2D_duration_2 = ((ulong)(2000ul));
            this.peaceAnimator1.Path2D_end_1 = 320F;
            this.peaceAnimator1.Path2D_end_2 = 100F;
            this.peaceAnimator1.Path2D_start_1 = 70F;
            this.peaceAnimator1.Path2D_start_2 = 5F;
            this.peaceAnimator1.Path3_Delay = ((ulong)(0ul));
            this.peaceAnimator1.Path3_Duration = ((ulong)(3000ul));
            this.peaceAnimator1.Path3_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.peaceAnimator1.PropertyName = "Value";
            this.peaceAnimator1.Repeat = false;
            this.peaceAnimator1.Reverse = false;
            this.peaceAnimator1.StartColor = System.Drawing.Color.DarkSlateGray;
            this.peaceAnimator1.StartValue = 0F;
            this.peaceAnimator1.ThreeDContinue = true;
            this.peaceAnimator1.ThreeDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator3D.KnownProperties.BackColor;
            this.peaceAnimator1.TwoDContinue = true;
            this.peaceAnimator1.TwoDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator2D.KnownProperties.Location;
            // 
            // oneD_Width_Animator
            // 
            this.oneD_Width_Animator.AnimationMode = Zeroit.Framework.Transitions.WinformAnimation.animationMode.OneD;
            this.oneD_Width_Animator.ColorPropertyName = "BackColor";
            this.oneD_Width_Animator.Continued_Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut;
            this.oneD_Width_Animator.Continued_path2D_delay_1 = ((ulong)(300ul));
            this.oneD_Width_Animator.Continued_path2D_delay_2 = ((ulong)(600ul));
            this.oneD_Width_Animator.Continued_path2D_duration_1 = ((ulong)(2000ul));
            this.oneD_Width_Animator.Continued_path2D_duration_2 = ((ulong)(1700ul));
            this.oneD_Width_Animator.Continued_path2D_end_1 = 70F;
            this.oneD_Width_Animator.Continued_path2D_end_2 = 5F;
            this.oneD_Width_Animator.Continued_path2D_start_1 = 320F;
            this.oneD_Width_Animator.Continued_path2D_start_2 = 100F;
            this.oneD_Width_Animator.Control = this.oneD_RotatingCube;
            this.oneD_Width_Animator.DelayValue = ((ulong)(0ul));
            this.oneD_Width_Animator.DurationValue = ((ulong)(500ul));
            this.oneD_Width_Animator.EndColor = System.Drawing.Color.Orange;
            this.oneD_Width_Animator.EndValue = 135F;
            this.oneD_Width_Animator.OneD_Continue = true;
            this.oneD_Width_Animator.OneD_Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.oneD_Width_Animator.OneDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator.KnownProperties.Width;
            this.oneD_Width_Animator.Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.oneD_Width_Animator.Path2D_delay_1 = ((ulong)(0ul));
            this.oneD_Width_Animator.Path2D_delay_2 = ((ulong)(0ul));
            this.oneD_Width_Animator.Path2D_duration_1 = ((ulong)(2000ul));
            this.oneD_Width_Animator.Path2D_duration_2 = ((ulong)(2000ul));
            this.oneD_Width_Animator.Path2D_end_1 = 320F;
            this.oneD_Width_Animator.Path2D_end_2 = 100F;
            this.oneD_Width_Animator.Path2D_start_1 = 70F;
            this.oneD_Width_Animator.Path2D_start_2 = 5F;
            this.oneD_Width_Animator.Path3_Delay = ((ulong)(0ul));
            this.oneD_Width_Animator.Path3_Duration = ((ulong)(3000ul));
            this.oneD_Width_Animator.Path3_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.oneD_Width_Animator.PropertyName = "Value";
            this.oneD_Width_Animator.Repeat = false;
            this.oneD_Width_Animator.Reverse = false;
            this.oneD_Width_Animator.StartColor = System.Drawing.Color.DarkSlateGray;
            this.oneD_Width_Animator.StartValue = 116F;
            this.oneD_Width_Animator.ThreeDContinue = true;
            this.oneD_Width_Animator.ThreeDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator3D.KnownProperties.BackColor;
            this.oneD_Width_Animator.TwoDContinue = true;
            this.oneD_Width_Animator.TwoDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator2D.KnownProperties.Location;
            // 
            // oneD_RotatingCube
            // 
            this.oneD_RotatingCube.AutoAnimate = true;
            this.oneD_RotatingCube.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.BlueViolet,
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Green,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Violet,
        System.Drawing.Color.LightSkyBlue};
            this.oneD_RotatingCube.Location = new System.Drawing.Point(641, 73);
            this.oneD_RotatingCube.Name = "oneD_RotatingCube";
            this.oneD_RotatingCube.Shrink = 4;
            this.oneD_RotatingCube.Size = new System.Drawing.Size(116, 112);
            this.oneD_RotatingCube.SpeedAdjust = 25;
            this.oneD_RotatingCube.TabIndex = 0;
            this.oneD_RotatingCube.Text = "rotatingCube1";
            this.toolTip1.SetToolTip(this.oneD_RotatingCube, "Speed\r\nShrink");
            // 
            // oneD_Height_Animator
            // 
            this.oneD_Height_Animator.AnimationMode = Zeroit.Framework.Transitions.WinformAnimation.animationMode.OneD;
            this.oneD_Height_Animator.ColorPropertyName = "BackColor";
            this.oneD_Height_Animator.Continued_Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut;
            this.oneD_Height_Animator.Continued_path2D_delay_1 = ((ulong)(300ul));
            this.oneD_Height_Animator.Continued_path2D_delay_2 = ((ulong)(600ul));
            this.oneD_Height_Animator.Continued_path2D_duration_1 = ((ulong)(2000ul));
            this.oneD_Height_Animator.Continued_path2D_duration_2 = ((ulong)(1700ul));
            this.oneD_Height_Animator.Continued_path2D_end_1 = 70F;
            this.oneD_Height_Animator.Continued_path2D_end_2 = 5F;
            this.oneD_Height_Animator.Continued_path2D_start_1 = 320F;
            this.oneD_Height_Animator.Continued_path2D_start_2 = 100F;
            this.oneD_Height_Animator.Control = this.oneD_RotatingCube;
            this.oneD_Height_Animator.DelayValue = ((ulong)(0ul));
            this.oneD_Height_Animator.DurationValue = ((ulong)(500ul));
            this.oneD_Height_Animator.EndColor = System.Drawing.Color.Orange;
            this.oneD_Height_Animator.EndValue = 130F;
            this.oneD_Height_Animator.OneD_Continue = true;
            this.oneD_Height_Animator.OneD_Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.oneD_Height_Animator.OneDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator.KnownProperties.Height;
            this.oneD_Height_Animator.Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.oneD_Height_Animator.Path2D_delay_1 = ((ulong)(0ul));
            this.oneD_Height_Animator.Path2D_delay_2 = ((ulong)(0ul));
            this.oneD_Height_Animator.Path2D_duration_1 = ((ulong)(2000ul));
            this.oneD_Height_Animator.Path2D_duration_2 = ((ulong)(2000ul));
            this.oneD_Height_Animator.Path2D_end_1 = 320F;
            this.oneD_Height_Animator.Path2D_end_2 = 100F;
            this.oneD_Height_Animator.Path2D_start_1 = 70F;
            this.oneD_Height_Animator.Path2D_start_2 = 5F;
            this.oneD_Height_Animator.Path3_Delay = ((ulong)(0ul));
            this.oneD_Height_Animator.Path3_Duration = ((ulong)(3000ul));
            this.oneD_Height_Animator.Path3_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.oneD_Height_Animator.PropertyName = "Value";
            this.oneD_Height_Animator.Repeat = false;
            this.oneD_Height_Animator.Reverse = false;
            this.oneD_Height_Animator.StartColor = System.Drawing.Color.DarkSlateGray;
            this.oneD_Height_Animator.StartValue = 112F;
            this.oneD_Height_Animator.ThreeDContinue = true;
            this.oneD_Height_Animator.ThreeDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator3D.KnownProperties.BackColor;
            this.oneD_Height_Animator.TwoDContinue = true;
            this.oneD_Height_Animator.TwoDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator2D.KnownProperties.Location;
            // 
            // oneD_Opacity_Animator
            // 
            this.oneD_Opacity_Animator.AnimationMode = Zeroit.Framework.Transitions.WinformAnimation.animationMode.OneD;
            this.oneD_Opacity_Animator.ColorPropertyName = "BackColor";
            this.oneD_Opacity_Animator.Continued_Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut;
            this.oneD_Opacity_Animator.Continued_path2D_delay_1 = ((ulong)(300ul));
            this.oneD_Opacity_Animator.Continued_path2D_delay_2 = ((ulong)(600ul));
            this.oneD_Opacity_Animator.Continued_path2D_duration_1 = ((ulong)(2000ul));
            this.oneD_Opacity_Animator.Continued_path2D_duration_2 = ((ulong)(1700ul));
            this.oneD_Opacity_Animator.Continued_path2D_end_1 = 70F;
            this.oneD_Opacity_Animator.Continued_path2D_end_2 = 5F;
            this.oneD_Opacity_Animator.Continued_path2D_start_1 = 320F;
            this.oneD_Opacity_Animator.Continued_path2D_start_2 = 100F;
            this.oneD_Opacity_Animator.Control = this;
            this.oneD_Opacity_Animator.DelayValue = ((ulong)(0ul));
            this.oneD_Opacity_Animator.DurationValue = ((ulong)(500ul));
            this.oneD_Opacity_Animator.EndColor = System.Drawing.Color.Orange;
            this.oneD_Opacity_Animator.EndValue = 1F;
            this.oneD_Opacity_Animator.OneD_Continue = true;
            this.oneD_Opacity_Animator.OneD_Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.oneD_Opacity_Animator.OneDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator.KnownProperties.Opacity;
            this.oneD_Opacity_Animator.Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.oneD_Opacity_Animator.Path2D_delay_1 = ((ulong)(0ul));
            this.oneD_Opacity_Animator.Path2D_delay_2 = ((ulong)(0ul));
            this.oneD_Opacity_Animator.Path2D_duration_1 = ((ulong)(2000ul));
            this.oneD_Opacity_Animator.Path2D_duration_2 = ((ulong)(2000ul));
            this.oneD_Opacity_Animator.Path2D_end_1 = 320F;
            this.oneD_Opacity_Animator.Path2D_end_2 = 100F;
            this.oneD_Opacity_Animator.Path2D_start_1 = 70F;
            this.oneD_Opacity_Animator.Path2D_start_2 = 5F;
            this.oneD_Opacity_Animator.Path3_Delay = ((ulong)(0ul));
            this.oneD_Opacity_Animator.Path3_Duration = ((ulong)(3000ul));
            this.oneD_Opacity_Animator.Path3_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.oneD_Opacity_Animator.PropertyName = "Value";
            this.oneD_Opacity_Animator.Repeat = false;
            this.oneD_Opacity_Animator.Reverse = false;
            this.oneD_Opacity_Animator.StartColor = System.Drawing.Color.DarkSlateGray;
            this.oneD_Opacity_Animator.StartValue = 0F;
            this.oneD_Opacity_Animator.ThreeDContinue = true;
            this.oneD_Opacity_Animator.ThreeDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator3D.KnownProperties.BackColor;
            this.oneD_Opacity_Animator.TwoDContinue = true;
            this.oneD_Opacity_Animator.TwoDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator2D.KnownProperties.Location;
            // 
            // oneD_Value_Animator
            // 
            this.oneD_Value_Animator.AnimationMode = Zeroit.Framework.Transitions.WinformAnimation.animationMode.OneD;
            this.oneD_Value_Animator.ColorPropertyName = "BackColor";
            this.oneD_Value_Animator.Continued_Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut;
            this.oneD_Value_Animator.Continued_path2D_delay_1 = ((ulong)(300ul));
            this.oneD_Value_Animator.Continued_path2D_delay_2 = ((ulong)(600ul));
            this.oneD_Value_Animator.Continued_path2D_duration_1 = ((ulong)(2000ul));
            this.oneD_Value_Animator.Continued_path2D_duration_2 = ((ulong)(1700ul));
            this.oneD_Value_Animator.Continued_path2D_end_1 = 70F;
            this.oneD_Value_Animator.Continued_path2D_end_2 = 5F;
            this.oneD_Value_Animator.Continued_path2D_start_1 = 320F;
            this.oneD_Value_Animator.Continued_path2D_start_2 = 100F;
            this.oneD_Value_Animator.Control = this.oneD_RotatingCube;
            this.oneD_Value_Animator.DelayValue = ((ulong)(0ul));
            this.oneD_Value_Animator.DurationValue = ((ulong)(500ul));
            this.oneD_Value_Animator.EndColor = System.Drawing.Color.Orange;
            this.oneD_Value_Animator.EndValue = 7F;
            this.oneD_Value_Animator.OneD_Continue = true;
            this.oneD_Value_Animator.OneD_Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.oneD_Value_Animator.OneDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator.KnownProperties.Value;
            this.oneD_Value_Animator.Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.oneD_Value_Animator.Path2D_delay_1 = ((ulong)(0ul));
            this.oneD_Value_Animator.Path2D_delay_2 = ((ulong)(0ul));
            this.oneD_Value_Animator.Path2D_duration_1 = ((ulong)(2000ul));
            this.oneD_Value_Animator.Path2D_duration_2 = ((ulong)(2000ul));
            this.oneD_Value_Animator.Path2D_end_1 = 320F;
            this.oneD_Value_Animator.Path2D_end_2 = 100F;
            this.oneD_Value_Animator.Path2D_start_1 = 70F;
            this.oneD_Value_Animator.Path2D_start_2 = 5F;
            this.oneD_Value_Animator.Path3_Delay = ((ulong)(0ul));
            this.oneD_Value_Animator.Path3_Duration = ((ulong)(3000ul));
            this.oneD_Value_Animator.Path3_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.oneD_Value_Animator.PropertyName = "Shrink";
            this.oneD_Value_Animator.Repeat = false;
            this.oneD_Value_Animator.Reverse = false;
            this.oneD_Value_Animator.StartColor = System.Drawing.Color.DarkSlateGray;
            this.oneD_Value_Animator.StartValue = 4F;
            this.oneD_Value_Animator.ThreeDContinue = true;
            this.oneD_Value_Animator.ThreeDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator3D.KnownProperties.BackColor;
            this.oneD_Value_Animator.TwoDContinue = true;
            this.oneD_Value_Animator.TwoDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator2D.KnownProperties.Location;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipTitle = "Properties";
            // 
            // threeD_RotatingCube
            // 
            this.threeD_RotatingCube.AutoAnimate = true;
            this.threeD_RotatingCube.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.BlueViolet,
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Green,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Violet,
        System.Drawing.Color.LightSkyBlue};
            this.threeD_RotatingCube.Location = new System.Drawing.Point(638, 65);
            this.threeD_RotatingCube.Name = "threeD_RotatingCube";
            this.threeD_RotatingCube.Shrink = 4;
            this.threeD_RotatingCube.Size = new System.Drawing.Size(116, 112);
            this.threeD_RotatingCube.SpeedAdjust = 25;
            this.threeD_RotatingCube.TabIndex = 0;
            this.threeD_RotatingCube.Text = "rotatingCube3";
            this.toolTip1.SetToolTip(this.threeD_RotatingCube, "Speed\r\nShrink\r\n");
            // 
            // twoD_RotatingCube
            // 
            this.twoD_RotatingCube.AutoAnimate = true;
            this.twoD_RotatingCube.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.BlueViolet,
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Green,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Violet,
        System.Drawing.Color.LightSkyBlue};
            this.twoD_RotatingCube.Location = new System.Drawing.Point(638, 75);
            this.twoD_RotatingCube.Name = "twoD_RotatingCube";
            this.twoD_RotatingCube.Shrink = 4;
            this.twoD_RotatingCube.Size = new System.Drawing.Size(116, 112);
            this.twoD_RotatingCube.SpeedAdjust = 25;
            this.twoD_RotatingCube.TabIndex = 0;
            this.twoD_RotatingCube.Text = "rotatingCube2";
            this.toolTip1.SetToolTip(this.twoD_RotatingCube, "Speed\r\nShrink\r\n");
            // 
            // oneD_Custom_Animator
            // 
            this.oneD_Custom_Animator.AnimationMode = Zeroit.Framework.Transitions.WinformAnimation.animationMode.OneD;
            this.oneD_Custom_Animator.ColorPropertyName = "BackColor";
            this.oneD_Custom_Animator.Continued_Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut;
            this.oneD_Custom_Animator.Continued_path2D_delay_1 = ((ulong)(300ul));
            this.oneD_Custom_Animator.Continued_path2D_delay_2 = ((ulong)(600ul));
            this.oneD_Custom_Animator.Continued_path2D_duration_1 = ((ulong)(2000ul));
            this.oneD_Custom_Animator.Continued_path2D_duration_2 = ((ulong)(1700ul));
            this.oneD_Custom_Animator.Continued_path2D_end_1 = 70F;
            this.oneD_Custom_Animator.Continued_path2D_end_2 = 5F;
            this.oneD_Custom_Animator.Continued_path2D_start_1 = 320F;
            this.oneD_Custom_Animator.Continued_path2D_start_2 = 100F;
            this.oneD_Custom_Animator.Control = this.oneD_RotatingCube;
            this.oneD_Custom_Animator.DelayValue = ((ulong)(0ul));
            this.oneD_Custom_Animator.DurationValue = ((ulong)(500ul));
            this.oneD_Custom_Animator.EndColor = System.Drawing.Color.Orange;
            this.oneD_Custom_Animator.EndValue = 7F;
            this.oneD_Custom_Animator.OneD_Continue = true;
            this.oneD_Custom_Animator.OneD_Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.oneD_Custom_Animator.OneDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator.KnownProperties.Custom;
            this.oneD_Custom_Animator.Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.oneD_Custom_Animator.Path2D_delay_1 = ((ulong)(0ul));
            this.oneD_Custom_Animator.Path2D_delay_2 = ((ulong)(0ul));
            this.oneD_Custom_Animator.Path2D_duration_1 = ((ulong)(2000ul));
            this.oneD_Custom_Animator.Path2D_duration_2 = ((ulong)(2000ul));
            this.oneD_Custom_Animator.Path2D_end_1 = 320F;
            this.oneD_Custom_Animator.Path2D_end_2 = 100F;
            this.oneD_Custom_Animator.Path2D_start_1 = 70F;
            this.oneD_Custom_Animator.Path2D_start_2 = 5F;
            this.oneD_Custom_Animator.Path3_Delay = ((ulong)(0ul));
            this.oneD_Custom_Animator.Path3_Duration = ((ulong)(3000ul));
            this.oneD_Custom_Animator.Path3_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.oneD_Custom_Animator.PropertyName = "Shrink";
            this.oneD_Custom_Animator.Repeat = false;
            this.oneD_Custom_Animator.Reverse = false;
            this.oneD_Custom_Animator.StartColor = System.Drawing.Color.DarkSlateGray;
            this.oneD_Custom_Animator.StartValue = 2F;
            this.oneD_Custom_Animator.ThreeDContinue = true;
            this.oneD_Custom_Animator.ThreeDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator3D.KnownProperties.BackColor;
            this.oneD_Custom_Animator.TwoDContinue = true;
            this.oneD_Custom_Animator.TwoDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator2D.KnownProperties.Location;
            // 
            // twoD_Location_Animator
            // 
            this.twoD_Location_Animator.AnimationMode = Zeroit.Framework.Transitions.WinformAnimation.animationMode.TwoD;
            this.twoD_Location_Animator.ColorPropertyName = "BackColor";
            this.twoD_Location_Animator.Continued_Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut;
            this.twoD_Location_Animator.Continued_path2D_delay_1 = ((ulong)(0ul));
            this.twoD_Location_Animator.Continued_path2D_delay_2 = ((ulong)(0ul));
            this.twoD_Location_Animator.Continued_path2D_duration_1 = ((ulong)(1000ul));
            this.twoD_Location_Animator.Continued_path2D_duration_2 = ((ulong)(700ul));
            this.twoD_Location_Animator.Continued_path2D_end_1 = 100F;
            this.twoD_Location_Animator.Continued_path2D_end_2 = 74F;
            this.twoD_Location_Animator.Continued_path2D_start_1 = 74F;
            this.twoD_Location_Animator.Continued_path2D_start_2 = 100F;
            this.twoD_Location_Animator.Control = this.twoD_RotatingCube;
            this.twoD_Location_Animator.DelayValue = ((ulong)(0ul));
            this.twoD_Location_Animator.DurationValue = ((ulong)(500ul));
            this.twoD_Location_Animator.EndColor = System.Drawing.Color.Orange;
            this.twoD_Location_Animator.EndValue = 100F;
            this.twoD_Location_Animator.OneD_Continue = true;
            this.twoD_Location_Animator.OneD_Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.twoD_Location_Animator.OneDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator.KnownProperties.Value;
            this.twoD_Location_Animator.Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.twoD_Location_Animator.Path2D_delay_1 = ((ulong)(0ul));
            this.twoD_Location_Animator.Path2D_delay_2 = ((ulong)(0ul));
            this.twoD_Location_Animator.Path2D_duration_1 = ((ulong)(2000ul));
            this.twoD_Location_Animator.Path2D_duration_2 = ((ulong)(2000ul));
            this.twoD_Location_Animator.Path2D_end_1 = 20F;
            this.twoD_Location_Animator.Path2D_end_2 = 30F;
            this.twoD_Location_Animator.Path2D_start_1 = 920F;
            this.twoD_Location_Animator.Path2D_start_2 = 20F;
            this.twoD_Location_Animator.Path3_Delay = ((ulong)(0ul));
            this.twoD_Location_Animator.Path3_Duration = ((ulong)(3000ul));
            this.twoD_Location_Animator.Path3_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.twoD_Location_Animator.PropertyName = "Value";
            this.twoD_Location_Animator.Repeat = false;
            this.twoD_Location_Animator.Reverse = false;
            this.twoD_Location_Animator.StartColor = System.Drawing.Color.DarkSlateGray;
            this.twoD_Location_Animator.StartValue = 0F;
            this.twoD_Location_Animator.ThreeDContinue = true;
            this.twoD_Location_Animator.ThreeDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator3D.KnownProperties.BackColor;
            this.twoD_Location_Animator.TwoDContinue = false;
            this.twoD_Location_Animator.TwoDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator2D.KnownProperties.Location;
            // 
            // twoD_Size_Animator
            // 
            this.twoD_Size_Animator.AnimationMode = Zeroit.Framework.Transitions.WinformAnimation.animationMode.TwoD;
            this.twoD_Size_Animator.ColorPropertyName = "BackColor";
            this.twoD_Size_Animator.Continued_Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut;
            this.twoD_Size_Animator.Continued_path2D_delay_1 = ((ulong)(0ul));
            this.twoD_Size_Animator.Continued_path2D_delay_2 = ((ulong)(0ul));
            this.twoD_Size_Animator.Continued_path2D_duration_1 = ((ulong)(1000ul));
            this.twoD_Size_Animator.Continued_path2D_duration_2 = ((ulong)(700ul));
            this.twoD_Size_Animator.Continued_path2D_end_1 = 120F;
            this.twoD_Size_Animator.Continued_path2D_end_2 = 125F;
            this.twoD_Size_Animator.Continued_path2D_start_1 = 116F;
            this.twoD_Size_Animator.Continued_path2D_start_2 = 120F;
            this.twoD_Size_Animator.Control = this.twoD_RotatingCube;
            this.twoD_Size_Animator.DelayValue = ((ulong)(0ul));
            this.twoD_Size_Animator.DurationValue = ((ulong)(500ul));
            this.twoD_Size_Animator.EndColor = System.Drawing.Color.Orange;
            this.twoD_Size_Animator.EndValue = 100F;
            this.twoD_Size_Animator.OneD_Continue = true;
            this.twoD_Size_Animator.OneD_Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.twoD_Size_Animator.OneDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator.KnownProperties.Value;
            this.twoD_Size_Animator.Path_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.twoD_Size_Animator.Path2D_delay_1 = ((ulong)(0ul));
            this.twoD_Size_Animator.Path2D_delay_2 = ((ulong)(0ul));
            this.twoD_Size_Animator.Path2D_duration_1 = ((ulong)(2000ul));
            this.twoD_Size_Animator.Path2D_duration_2 = ((ulong)(2000ul));
            this.twoD_Size_Animator.Path2D_end_1 = 70F;
            this.twoD_Size_Animator.Path2D_end_2 = 100F;
            this.twoD_Size_Animator.Path2D_start_1 = 50F;
            this.twoD_Size_Animator.Path2D_start_2 = 5F;
            this.twoD_Size_Animator.Path3_Delay = ((ulong)(0ul));
            this.twoD_Size_Animator.Path3_Duration = ((ulong)(3000ul));
            this.twoD_Size_Animator.Path3_Easing = Zeroit.Framework.Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.twoD_Size_Animator.PropertyName = "Value";
            this.twoD_Size_Animator.Repeat = false;
            this.twoD_Size_Animator.Reverse = false;
            this.twoD_Size_Animator.StartColor = System.Drawing.Color.DarkSlateGray;
            this.twoD_Size_Animator.StartValue = 0F;
            this.twoD_Size_Animator.ThreeDContinue = true;
            this.twoD_Size_Animator.ThreeDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator3D.KnownProperties.BackColor;
            this.twoD_Size_Animator.TwoDContinue = true;
            this.twoD_Size_Animator.TwoDProperty = Zeroit.Framework.Transitions.WinFormAnimation.Animator2D.KnownProperties.Size;
            // 
            // thematic1501
            // 
            this.thematic1501.Animated = true;
            this.thematic1501.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.thematic1501.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.thematic1501.Colors = new Zeroit.Framework.Transitions.ThemeManagers.Bloom[0];
            this.thematic1501.Controls.Add(this.closeBtn);
            this.thematic1501.Controls.Add(this.general_Container);
            this.thematic1501.Controls.Add(this.threeD_GroupBox);
            this.thematic1501.Controls.Add(this.twoD_GroupBox);
            this.thematic1501.Controls.Add(this.oneD_GroupBox);
            this.thematic1501.Customization = "";
            this.thematic1501.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thematic1501.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.thematic1501.ForeColor = System.Drawing.SystemColors.Menu;
            this.thematic1501.Image = null;
            this.thematic1501.Location = new System.Drawing.Point(0, 0);
            this.thematic1501.Movable = true;
            this.thematic1501.Name = "thematic1501";
            this.thematic1501.NoRounding = false;
            this.thematic1501.Padding = new System.Windows.Forms.Padding(2, 36, 2, 2);
            this.thematic1501.Sizable = false;
            this.thematic1501.Size = new System.Drawing.Size(1017, 912);
            this.thematic1501.SmartBounds = true;
            this.thematic1501.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.thematic1501.TabIndex = 0;
            this.thematic1501.Text = "Peace Animation Editor";
            this.thematic1501.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.thematic1501.Transparent = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.closeBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.closeBtn.Location = new System.Drawing.Point(997, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(17, 18);
            this.closeBtn.TabIndex = 37;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // general_Container
            // 
            this.general_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.general_Container.Controls.Add(this.zeroitSimpleLine21);
            this.general_Container.Controls.Add(this.okBtn);
            this.general_Container.Controls.Add(this.cancelBtn);
            this.general_Container.Controls.Add(this.general_GroupBox);
            this.general_Container.Location = new System.Drawing.Point(19, 37);
            this.general_Container.Name = "general_Container";
            this.general_Container.Size = new System.Drawing.Size(205, 342);
            this.general_Container.TabIndex = 36;
            // 
            // zeroitSimpleLine21
            // 
            this.zeroitSimpleLine21.Angle = 100F;
            this.zeroitSimpleLine21.AngleIncrement = 10F;
            this.zeroitSimpleLine21.AngleLimit = 360F;
            this.zeroitSimpleLine21.AutoAnimate = true;
            this.zeroitSimpleLine21.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.zeroitSimpleLine21.FitToParent = false;
            this.zeroitSimpleLine21.Gradient = System.Drawing.Color.DeepPink;
            this.zeroitSimpleLine21.GradientAngle = Zeroit.Framework.Transitions._HelpingControls.ZeroitSimpleLine2GradientDirection.Horizontal;
            this.zeroitSimpleLine21.LineColor = System.Drawing.Color.Black;
            this.zeroitSimpleLine21.LineWidth = 1;
            this.zeroitSimpleLine21.Location = new System.Drawing.Point(199, 11);
            this.zeroitSimpleLine21.Name = "zeroitSimpleLine21";
            this.zeroitSimpleLine21.Size = new System.Drawing.Size(1, 326);
            this.zeroitSimpleLine21.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.zeroitSimpleLine21.Style = Zeroit.Framework.Transitions._HelpingControls.ZeroitSimpleLine2LineStyle.Vertical;
            this.zeroitSimpleLine21.TabIndex = 16;
            this.zeroitSimpleLine21.Text = "zeroitSimpleLine21";
            this.zeroitSimpleLine21.TimerInterVal = 10;
            this.zeroitSimpleLine21.UseGradient = true;
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.okBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.okBtn.Location = new System.Drawing.Point(40, 304);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(59, 33);
            this.okBtn.TabIndex = 7;
            this.okBtn.Text = "&OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.SlateGray;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancelBtn.Location = new System.Drawing.Point(104, 304);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(59, 33);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // general_GroupBox
            // 
            this.general_GroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.general_GroupBox.Controls.Add(this.label7);
            this.general_GroupBox.Controls.Add(this.control_ComboBox);
            this.general_GroupBox.Controls.Add(this.label1);
            this.general_GroupBox.Controls.Add(this.mainControl_animationMode_Combo);
            this.general_GroupBox.Controls.Add(this.label3);
            this.general_GroupBox.Controls.Add(this.mainControl_Path_Continue_ComboBox);
            this.general_GroupBox.Controls.Add(this.label5);
            this.general_GroupBox.Controls.Add(this.mainControl_Repeat_ComboBox);
            this.general_GroupBox.Controls.Add(this.label6);
            this.general_GroupBox.Controls.Add(this.mainControl_Reverse_ComboBox);
            this.general_GroupBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.general_GroupBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.general_GroupBox.Location = new System.Drawing.Point(7, 0);
            this.general_GroupBox.Name = "general_GroupBox";
            this.general_GroupBox.Size = new System.Drawing.Size(186, 298);
            this.general_GroupBox.TabIndex = 0;
            this.general_GroupBox.TabStop = false;
            this.general_GroupBox.Text = "Animation Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(6, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Control";
            // 
            // control_ComboBox
            // 
            this.control_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.control_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.control_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.control_ComboBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.control_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.control_ComboBox.FormattingEnabled = true;
            this.control_ComboBox.Location = new System.Drawing.Point(77, 260);
            this.control_ComboBox.Name = "control_ComboBox";
            this.control_ComboBox.Size = new System.Drawing.Size(95, 21);
            this.control_ComboBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Animation \r\nMode";
            // 
            // mainControl_animationMode_Combo
            // 
            this.mainControl_animationMode_Combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.mainControl_animationMode_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainControl_animationMode_Combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainControl_animationMode_Combo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.mainControl_animationMode_Combo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mainControl_animationMode_Combo.FormattingEnabled = true;
            this.mainControl_animationMode_Combo.Items.AddRange(new object[] {
            "1D",
            "2D",
            "3D",
            "Default"});
            this.mainControl_animationMode_Combo.Location = new System.Drawing.Point(77, 33);
            this.mainControl_animationMode_Combo.Name = "mainControl_animationMode_Combo";
            this.mainControl_animationMode_Combo.Size = new System.Drawing.Size(95, 21);
            this.mainControl_animationMode_Combo.TabIndex = 3;
            this.mainControl_animationMode_Combo.SelectedIndexChanged += new System.EventHandler(this.ShapeTypeChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Path \r\nContinue";
            // 
            // mainControl_Path_Continue_ComboBox
            // 
            this.mainControl_Path_Continue_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.mainControl_Path_Continue_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainControl_Path_Continue_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainControl_Path_Continue_ComboBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.mainControl_Path_Continue_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mainControl_Path_Continue_ComboBox.FormattingEnabled = true;
            this.mainControl_Path_Continue_ComboBox.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.mainControl_Path_Continue_ComboBox.Location = new System.Drawing.Point(77, 92);
            this.mainControl_Path_Continue_ComboBox.Name = "mainControl_Path_Continue_ComboBox";
            this.mainControl_Path_Continue_ComboBox.Size = new System.Drawing.Size(95, 21);
            this.mainControl_Path_Continue_ComboBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Repeat";
            // 
            // mainControl_Repeat_ComboBox
            // 
            this.mainControl_Repeat_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.mainControl_Repeat_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainControl_Repeat_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainControl_Repeat_ComboBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.mainControl_Repeat_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mainControl_Repeat_ComboBox.FormattingEnabled = true;
            this.mainControl_Repeat_ComboBox.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.mainControl_Repeat_ComboBox.Location = new System.Drawing.Point(77, 151);
            this.mainControl_Repeat_ComboBox.Name = "mainControl_Repeat_ComboBox";
            this.mainControl_Repeat_ComboBox.Size = new System.Drawing.Size(95, 21);
            this.mainControl_Repeat_ComboBox.TabIndex = 13;
            this.mainControl_Repeat_ComboBox.SelectedIndexChanged += new System.EventHandler(this.mainControl_Repeat_ComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(6, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Reverse";
            // 
            // mainControl_Reverse_ComboBox
            // 
            this.mainControl_Reverse_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.mainControl_Reverse_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainControl_Reverse_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainControl_Reverse_ComboBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.mainControl_Reverse_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mainControl_Reverse_ComboBox.FormattingEnabled = true;
            this.mainControl_Reverse_ComboBox.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.mainControl_Reverse_ComboBox.Location = new System.Drawing.Point(77, 208);
            this.mainControl_Reverse_ComboBox.Name = "mainControl_Reverse_ComboBox";
            this.mainControl_Reverse_ComboBox.Size = new System.Drawing.Size(95, 21);
            this.mainControl_Reverse_ComboBox.TabIndex = 15;
            this.mainControl_Reverse_ComboBox.SelectedIndexChanged += new System.EventHandler(this.mainControl_Reverse_ComboBox_SelectedIndexChanged);
            // 
            // threeD_GroupBox
            // 
            this.threeD_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.threeD_GroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.threeD_GroupBox.Controls.Add(this.threeD_Preview);
            this.threeD_GroupBox.Controls.Add(this.threeD_Easing_ComboBox);
            this.threeD_GroupBox.Controls.Add(this.label22);
            this.threeD_GroupBox.Controls.Add(this.threeD_End_Color_Button);
            this.threeD_GroupBox.Controls.Add(this.label42);
            this.threeD_GroupBox.Controls.Add(this.threeD_Start_Color_Button);
            this.threeD_GroupBox.Controls.Add(this.label23);
            this.threeD_GroupBox.Controls.Add(this.threeD_Delay_Numeric);
            this.threeD_GroupBox.Controls.Add(this.label24);
            this.threeD_GroupBox.Controls.Add(this.threeD_Duration_Numeric);
            this.threeD_GroupBox.Controls.Add(this.threeD_Property_ComboBox);
            this.threeD_GroupBox.Controls.Add(this.label26);
            this.threeD_GroupBox.Controls.Add(this.label28);
            this.threeD_GroupBox.Controls.Add(this.threeD_Color_Property_Name_TextBox);
            this.threeD_GroupBox.Controls.Add(this.label29);
            this.threeD_GroupBox.Controls.Add(this.threeD_RotatingCube);
            this.threeD_GroupBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.threeD_GroupBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.threeD_GroupBox.Location = new System.Drawing.Point(232, 638);
            this.threeD_GroupBox.Name = "threeD_GroupBox";
            this.threeD_GroupBox.Size = new System.Drawing.Size(769, 261);
            this.threeD_GroupBox.TabIndex = 35;
            this.threeD_GroupBox.TabStop = false;
            this.threeD_GroupBox.Text = "3D Mode";
            this.threeD_GroupBox.Visible = false;
            // 
            // threeD_Preview
            // 
            this.threeD_Preview.FlatAppearance.BorderSize = 0;
            this.threeD_Preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeD_Preview.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.threeD_Preview.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.threeD_Preview.Location = new System.Drawing.Point(643, 18);
            this.threeD_Preview.Name = "threeD_Preview";
            this.threeD_Preview.Size = new System.Drawing.Size(104, 34);
            this.threeD_Preview.TabIndex = 60;
            this.threeD_Preview.Text = "Preview";
            this.threeD_Preview.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.threeD_Preview.UseVisualStyleBackColor = false;
            this.threeD_Preview.Click += new System.EventHandler(this.threeD_Preview_Click);
            this.threeD_Preview.MouseEnter += new System.EventHandler(this.threeD_Preview_MouseEnter);
            this.threeD_Preview.MouseLeave += new System.EventHandler(this.threeD_Preview_MouseLeave);
            // 
            // threeD_Easing_ComboBox
            // 
            this.threeD_Easing_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.threeD_Easing_ComboBox.DropDownHeight = 250;
            this.threeD_Easing_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.threeD_Easing_ComboBox.DropDownWidth = 160;
            this.threeD_Easing_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeD_Easing_ComboBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.threeD_Easing_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.threeD_Easing_ComboBox.FormattingEnabled = true;
            this.threeD_Easing_ComboBox.IntegralHeight = false;
            this.threeD_Easing_ComboBox.ItemHeight = 13;
            this.threeD_Easing_ComboBox.Items.AddRange(new object[] {
            "BounceEaseIn",
            "BounceEaseInOut",
            "BounceEaseOut",
            "BounceEaseOutIn",
            "CircularEaseIn",
            "CircularEaseInOut",
            "CircularEaseOut",
            "CubicEaseIn",
            "CubicEaseInOut",
            "CubicEaseOut",
            "ExponentialEaseIn",
            "ExponentialEaseInOut",
            "ExponentialEaseOut",
            "Liner",
            "None",
            "QuadraticEaseIn",
            "QuadraticEaseInOut",
            "QuadraticEaseOut",
            "QuarticEaseIn",
            "QuarticEaseInOut",
            "QuarticEaseOut",
            "QuinticEaseIn",
            "QuinticEaseInOut",
            "QuinticEaseOut",
            "SinusoidalEaseIn",
            "SinusoidalEaseInOut",
            "SinusoidalEaseOut"});
            this.threeD_Easing_ComboBox.Location = new System.Drawing.Point(91, 217);
            this.threeD_Easing_ComboBox.Name = "threeD_Easing_ComboBox";
            this.threeD_Easing_ComboBox.Size = new System.Drawing.Size(85, 21);
            this.threeD_Easing_ComboBox.Sorted = true;
            this.threeD_Easing_ComboBox.TabIndex = 37;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label22.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label22.Location = new System.Drawing.Point(18, 220);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 36;
            this.label22.Text = "Easing";
            // 
            // threeD_End_Color_Button
            // 
            this.threeD_End_Color_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.threeD_End_Color_Button.FlatAppearance.BorderSize = 0;
            this.threeD_End_Color_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeD_End_Color_Button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.threeD_End_Color_Button.Location = new System.Drawing.Point(299, 93);
            this.threeD_End_Color_Button.Name = "threeD_End_Color_Button";
            this.threeD_End_Color_Button.Size = new System.Drawing.Size(54, 31);
            this.threeD_End_Color_Button.TabIndex = 35;
            this.threeD_End_Color_Button.UseVisualStyleBackColor = false;
            this.threeD_End_Color_Button.Click += new System.EventHandler(this.threeD_End_Color_Button_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label42.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label42.Location = new System.Drawing.Point(216, 102);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(58, 13);
            this.label42.TabIndex = 34;
            this.label42.Text = "End Color";
            // 
            // threeD_Start_Color_Button
            // 
            this.threeD_Start_Color_Button.BackColor = System.Drawing.Color.Orange;
            this.threeD_Start_Color_Button.FlatAppearance.BorderSize = 0;
            this.threeD_Start_Color_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeD_Start_Color_Button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.threeD_Start_Color_Button.Location = new System.Drawing.Point(299, 34);
            this.threeD_Start_Color_Button.Name = "threeD_Start_Color_Button";
            this.threeD_Start_Color_Button.Size = new System.Drawing.Size(54, 31);
            this.threeD_Start_Color_Button.TabIndex = 17;
            this.threeD_Start_Color_Button.UseVisualStyleBackColor = false;
            this.threeD_Start_Color_Button.Click += new System.EventHandler(this.threeD_Start_Color_Button_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label23.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label23.Location = new System.Drawing.Point(216, 220);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 13);
            this.label23.TabIndex = 32;
            this.label23.Text = "Delay (ms)";
            // 
            // threeD_Delay_Numeric
            // 
            this.threeD_Delay_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.threeD_Delay_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.threeD_Delay_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.threeD_Delay_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.threeD_Delay_Numeric.Location = new System.Drawing.Point(299, 217);
            this.threeD_Delay_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.threeD_Delay_Numeric.Name = "threeD_Delay_Numeric";
            this.threeD_Delay_Numeric.Size = new System.Drawing.Size(54, 22);
            this.threeD_Delay_Numeric.TabIndex = 31;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label24.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label24.Location = new System.Drawing.Point(216, 157);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(76, 13);
            this.label24.TabIndex = 30;
            this.label24.Text = "Duration (ms)";
            // 
            // threeD_Duration_Numeric
            // 
            this.threeD_Duration_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.threeD_Duration_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.threeD_Duration_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.threeD_Duration_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.threeD_Duration_Numeric.Location = new System.Drawing.Point(299, 155);
            this.threeD_Duration_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.threeD_Duration_Numeric.Name = "threeD_Duration_Numeric";
            this.threeD_Duration_Numeric.Size = new System.Drawing.Size(54, 22);
            this.threeD_Duration_Numeric.TabIndex = 29;
            this.threeD_Duration_Numeric.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // threeD_Property_ComboBox
            // 
            this.threeD_Property_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.threeD_Property_ComboBox.DropDownHeight = 250;
            this.threeD_Property_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.threeD_Property_ComboBox.DropDownWidth = 140;
            this.threeD_Property_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeD_Property_ComboBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.threeD_Property_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.threeD_Property_ComboBox.FormattingEnabled = true;
            this.threeD_Property_ComboBox.IntegralHeight = false;
            this.threeD_Property_ComboBox.ItemHeight = 13;
            this.threeD_Property_ComboBox.Items.AddRange(new object[] {
            "BackColor",
            "Custom",
            "ForeColor"});
            this.threeD_Property_ComboBox.Location = new System.Drawing.Point(91, 123);
            this.threeD_Property_ComboBox.Name = "threeD_Property_ComboBox";
            this.threeD_Property_ComboBox.Size = new System.Drawing.Size(85, 21);
            this.threeD_Property_ComboBox.Sorted = true;
            this.threeD_Property_ComboBox.TabIndex = 26;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label26.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label26.Location = new System.Drawing.Point(18, 128);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(50, 13);
            this.label26.TabIndex = 25;
            this.label26.Text = "Property";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label28.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label28.Location = new System.Drawing.Point(215, 44);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(62, 13);
            this.label28.TabIndex = 10;
            this.label28.Text = "Start Color";
            // 
            // threeD_Color_Property_Name_TextBox
            // 
            this.threeD_Color_Property_Name_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.threeD_Color_Property_Name_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.threeD_Color_Property_Name_TextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.threeD_Color_Property_Name_TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.threeD_Color_Property_Name_TextBox.Location = new System.Drawing.Point(91, 43);
            this.threeD_Color_Property_Name_TextBox.Name = "threeD_Color_Property_Name_TextBox";
            this.threeD_Color_Property_Name_TextBox.Size = new System.Drawing.Size(85, 22);
            this.threeD_Color_Property_Name_TextBox.TabIndex = 9;
            this.threeD_Color_Property_Name_TextBox.Text = "BackColor";
            this.threeD_Color_Property_Name_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label29.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label29.Location = new System.Drawing.Point(18, 36);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(53, 39);
            this.label29.TabIndex = 7;
            this.label29.Text = "Color \r\nProperty \r\nName";
            // 
            // twoD_GroupBox
            // 
            this.twoD_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.twoD_GroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.twoD_GroupBox.Controls.Add(this.twoD_Preview);
            this.twoD_GroupBox.Controls.Add(this.twoD_Reset_btn);
            this.twoD_GroupBox.Controls.Add(this.twoD_Easing_ComboBox);
            this.twoD_GroupBox.Controls.Add(this.twoD_Easing_Label);
            this.twoD_GroupBox.Controls.Add(this.twoD_Delay2_Label);
            this.twoD_GroupBox.Controls.Add(this.twoD_Delay2_Numeric);
            this.twoD_GroupBox.Controls.Add(this.twoD_Duration2_Label);
            this.twoD_GroupBox.Controls.Add(this.twoD_Duration2_Numeric);
            this.twoD_GroupBox.Controls.Add(this.twoD_End2_Label);
            this.twoD_GroupBox.Controls.Add(this.twoD_End2_Numeric);
            this.twoD_GroupBox.Controls.Add(this.twoD_Start2_Label);
            this.twoD_GroupBox.Controls.Add(this.twoD_Start2_Numeric);
            this.twoD_GroupBox.Controls.Add(this.twoD_Continued_Delay2_Label);
            this.twoD_GroupBox.Controls.Add(this.twoD_Continued_Delay2_Numeric);
            this.twoD_GroupBox.Controls.Add(this.twoD_Continued_End2_Label);
            this.twoD_GroupBox.Controls.Add(this.twoD_Continued_End2_Numeric);
            this.twoD_GroupBox.Controls.Add(this.twoD_Continued_Duration2_Label);
            this.twoD_GroupBox.Controls.Add(this.twoD_Continued_Duration2_Numeric);
            this.twoD_GroupBox.Controls.Add(this.twoD_Continued_Start2_Label);
            this.twoD_GroupBox.Controls.Add(this.twoD_Continued_Start2_Numeric);
            this.twoD_GroupBox.Controls.Add(this.twoD_Continued_Delay1_Label);
            this.twoD_GroupBox.Controls.Add(this.twoD_Continued_Delay1_Numeric);
            this.twoD_GroupBox.Controls.Add(this.twoD_Continued_Duration1_Label);
            this.twoD_GroupBox.Controls.Add(this.twoD_Continued_Duration1_Numeric);
            this.twoD_GroupBox.Controls.Add(this.twoD_Continued_End1_Label);
            this.twoD_GroupBox.Controls.Add(this.twoD_Continued_End1_Numeric);
            this.twoD_GroupBox.Controls.Add(this.twoD_Continued_Start1_Label);
            this.twoD_GroupBox.Controls.Add(this.twoD_Continued_Start1_Numeric);
            this.twoD_GroupBox.Controls.Add(this.twoD_Continued_Easing_ComboBox);
            this.twoD_GroupBox.Controls.Add(this.twoD_Continued_Easing_Label);
            this.twoD_GroupBox.Controls.Add(this.twoD_Delay1_Label);
            this.twoD_GroupBox.Controls.Add(this.twoD_Delay1_Numeric);
            this.twoD_GroupBox.Controls.Add(this.twoD_Duration1_Label);
            this.twoD_GroupBox.Controls.Add(this.twoD_Duration1_Numeric);
            this.twoD_GroupBox.Controls.Add(this.twoD_End1_Label);
            this.twoD_GroupBox.Controls.Add(this.twoD_End1_Numeric);
            this.twoD_GroupBox.Controls.Add(this.twoD_Property_ComboBox);
            this.twoD_GroupBox.Controls.Add(this.twoD_Property_Label);
            this.twoD_GroupBox.Controls.Add(this.twoD_Start1_Label);
            this.twoD_GroupBox.Controls.Add(this.twoD_Start1_Numeric);
            this.twoD_GroupBox.Controls.Add(this.twoD_RotatingCube);
            this.twoD_GroupBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.twoD_GroupBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.twoD_GroupBox.Location = new System.Drawing.Point(232, 274);
            this.twoD_GroupBox.Name = "twoD_GroupBox";
            this.twoD_GroupBox.Size = new System.Drawing.Size(769, 358);
            this.twoD_GroupBox.TabIndex = 34;
            this.twoD_GroupBox.TabStop = false;
            this.twoD_GroupBox.Text = "2D Mode";
            this.twoD_GroupBox.Visible = false;
            // 
            // twoD_Preview
            // 
            this.twoD_Preview.FlatAppearance.BorderSize = 0;
            this.twoD_Preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoD_Preview.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Preview.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Preview.Location = new System.Drawing.Point(644, 20);
            this.twoD_Preview.Name = "twoD_Preview";
            this.twoD_Preview.Size = new System.Drawing.Size(104, 36);
            this.twoD_Preview.TabIndex = 33;
            this.twoD_Preview.Text = "Preview";
            this.twoD_Preview.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.twoD_Preview.UseVisualStyleBackColor = false;
            this.twoD_Preview.Click += new System.EventHandler(this.twoD_Preview_Click);
            this.twoD_Preview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.twoD_Preview_MouseDown);
            this.twoD_Preview.MouseEnter += new System.EventHandler(this.twoD_Preview_MouseEnter);
            this.twoD_Preview.MouseLeave += new System.EventHandler(this.twoD_Preview_MouseLeave);
            // 
            // twoD_Reset_btn
            // 
            this.twoD_Reset_btn.FlatAppearance.BorderSize = 0;
            this.twoD_Reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoD_Reset_btn.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Reset_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Reset_btn.Location = new System.Drawing.Point(646, 20);
            this.twoD_Reset_btn.Name = "twoD_Reset_btn";
            this.twoD_Reset_btn.Size = new System.Drawing.Size(104, 36);
            this.twoD_Reset_btn.TabIndex = 60;
            this.twoD_Reset_btn.Text = "Reset";
            this.twoD_Reset_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.twoD_Reset_btn.UseVisualStyleBackColor = false;
            this.twoD_Reset_btn.Click += new System.EventHandler(this.twoD_Reset_btn_Click);
            this.twoD_Reset_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.twoD_Reset_btn_MouseDown);
            this.twoD_Reset_btn.MouseEnter += new System.EventHandler(this.twoD_Reset_btn_MouseEnter);
            this.twoD_Reset_btn.MouseLeave += new System.EventHandler(this.twoD_Reset_btn_MouseLeave);
            // 
            // twoD_Easing_ComboBox
            // 
            this.twoD_Easing_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.twoD_Easing_ComboBox.DropDownHeight = 250;
            this.twoD_Easing_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.twoD_Easing_ComboBox.DropDownWidth = 160;
            this.twoD_Easing_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoD_Easing_ComboBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Easing_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Easing_ComboBox.FormattingEnabled = true;
            this.twoD_Easing_ComboBox.IntegralHeight = false;
            this.twoD_Easing_ComboBox.ItemHeight = 13;
            this.twoD_Easing_ComboBox.Items.AddRange(new object[] {
            "BounceEaseIn",
            "BounceEaseInOut",
            "BounceEaseOut",
            "BounceEaseOutIn",
            "CircularEaseIn",
            "CircularEaseInOut",
            "CircularEaseOut",
            "CubicEaseIn",
            "CubicEaseInOut",
            "CubicEaseOut",
            "ExponentialEaseIn",
            "ExponentialEaseInOut",
            "ExponentialEaseOut",
            "Liner",
            "None",
            "QuadraticEaseIn",
            "QuadraticEaseInOut",
            "QuadraticEaseOut",
            "QuarticEaseIn",
            "QuarticEaseInOut",
            "QuarticEaseOut",
            "QuinticEaseIn",
            "QuinticEaseInOut",
            "QuinticEaseOut",
            "SinusoidalEaseIn",
            "SinusoidalEaseInOut",
            "SinusoidalEaseOut"});
            this.twoD_Easing_ComboBox.Location = new System.Drawing.Point(96, 123);
            this.twoD_Easing_ComboBox.Name = "twoD_Easing_ComboBox";
            this.twoD_Easing_ComboBox.Size = new System.Drawing.Size(80, 21);
            this.twoD_Easing_ComboBox.Sorted = true;
            this.twoD_Easing_ComboBox.TabIndex = 59;
            // 
            // twoD_Easing_Label
            // 
            this.twoD_Easing_Label.AutoSize = true;
            this.twoD_Easing_Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Easing_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Easing_Label.Location = new System.Drawing.Point(7, 126);
            this.twoD_Easing_Label.Name = "twoD_Easing_Label";
            this.twoD_Easing_Label.Size = new System.Drawing.Size(41, 13);
            this.twoD_Easing_Label.TabIndex = 58;
            this.twoD_Easing_Label.Text = "Easing";
            // 
            // twoD_Delay2_Label
            // 
            this.twoD_Delay2_Label.AutoSize = true;
            this.twoD_Delay2_Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Delay2_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Delay2_Label.Location = new System.Drawing.Point(212, 200);
            this.twoD_Delay2_Label.Name = "twoD_Delay2_Label";
            this.twoD_Delay2_Label.Size = new System.Drawing.Size(73, 13);
            this.twoD_Delay2_Label.TabIndex = 57;
            this.twoD_Delay2_Label.Text = "Height Delay";
            // 
            // twoD_Delay2_Numeric
            // 
            this.twoD_Delay2_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.twoD_Delay2_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoD_Delay2_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Delay2_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.twoD_Delay2_Numeric.Location = new System.Drawing.Point(304, 196);
            this.twoD_Delay2_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.twoD_Delay2_Numeric.Name = "twoD_Delay2_Numeric";
            this.twoD_Delay2_Numeric.Size = new System.Drawing.Size(49, 22);
            this.twoD_Delay2_Numeric.TabIndex = 56;
            this.twoD_Delay2_Numeric.ValueChanged += new System.EventHandler(this.twoD_Delay2_Numeric_ValueChanged);
            // 
            // twoD_Duration2_Label
            // 
            this.twoD_Duration2_Label.AutoSize = true;
            this.twoD_Duration2_Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Duration2_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Duration2_Label.Location = new System.Drawing.Point(212, 144);
            this.twoD_Duration2_Label.Name = "twoD_Duration2_Label";
            this.twoD_Duration2_Label.Size = new System.Drawing.Size(91, 13);
            this.twoD_Duration2_Label.TabIndex = 55;
            this.twoD_Duration2_Label.Text = "Height Duration";
            // 
            // twoD_Duration2_Numeric
            // 
            this.twoD_Duration2_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.twoD_Duration2_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoD_Duration2_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Duration2_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.twoD_Duration2_Numeric.Location = new System.Drawing.Point(304, 140);
            this.twoD_Duration2_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.twoD_Duration2_Numeric.Name = "twoD_Duration2_Numeric";
            this.twoD_Duration2_Numeric.Size = new System.Drawing.Size(49, 22);
            this.twoD_Duration2_Numeric.TabIndex = 54;
            this.twoD_Duration2_Numeric.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.twoD_Duration2_Numeric.ValueChanged += new System.EventHandler(this.twoD_Duration2_Numeric_ValueChanged);
            // 
            // twoD_End2_Label
            // 
            this.twoD_End2_Label.AutoSize = true;
            this.twoD_End2_Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_End2_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_End2_Label.Location = new System.Drawing.Point(212, 88);
            this.twoD_End2_Label.Name = "twoD_End2_Label";
            this.twoD_End2_Label.Size = new System.Drawing.Size(65, 13);
            this.twoD_End2_Label.TabIndex = 53;
            this.twoD_End2_Label.Text = "Height End";
            // 
            // twoD_End2_Numeric
            // 
            this.twoD_End2_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.twoD_End2_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoD_End2_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_End2_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.twoD_End2_Numeric.Location = new System.Drawing.Point(304, 84);
            this.twoD_End2_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.twoD_End2_Numeric.Name = "twoD_End2_Numeric";
            this.twoD_End2_Numeric.Size = new System.Drawing.Size(49, 22);
            this.twoD_End2_Numeric.TabIndex = 52;
            this.twoD_End2_Numeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.twoD_End2_Numeric.ValueChanged += new System.EventHandler(this.twoD_End2_Numeric_ValueChanged);
            // 
            // twoD_Start2_Label
            // 
            this.twoD_Start2_Label.AutoSize = true;
            this.twoD_Start2_Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Start2_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Start2_Label.Location = new System.Drawing.Point(212, 32);
            this.twoD_Start2_Label.Name = "twoD_Start2_Label";
            this.twoD_Start2_Label.Size = new System.Drawing.Size(69, 13);
            this.twoD_Start2_Label.TabIndex = 51;
            this.twoD_Start2_Label.Text = "Height Start";
            // 
            // twoD_Start2_Numeric
            // 
            this.twoD_Start2_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.twoD_Start2_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoD_Start2_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Start2_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.twoD_Start2_Numeric.Location = new System.Drawing.Point(304, 28);
            this.twoD_Start2_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.twoD_Start2_Numeric.Name = "twoD_Start2_Numeric";
            this.twoD_Start2_Numeric.Size = new System.Drawing.Size(49, 22);
            this.twoD_Start2_Numeric.TabIndex = 50;
            this.twoD_Start2_Numeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.twoD_Start2_Numeric.ValueChanged += new System.EventHandler(this.twoD_Start2_Numeric_ValueChanged);
            // 
            // twoD_Continued_Delay2_Label
            // 
            this.twoD_Continued_Delay2_Label.AutoSize = true;
            this.twoD_Continued_Delay2_Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Continued_Delay2_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Continued_Delay2_Label.Location = new System.Drawing.Point(395, 196);
            this.twoD_Continued_Delay2_Label.Name = "twoD_Continued_Delay2_Label";
            this.twoD_Continued_Delay2_Label.Size = new System.Drawing.Size(73, 26);
            this.twoD_Continued_Delay2_Label.TabIndex = 49;
            this.twoD_Continued_Delay2_Label.Text = "Continued \r\nHeight Delay";
            // 
            // twoD_Continued_Delay2_Numeric
            // 
            this.twoD_Continued_Delay2_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.twoD_Continued_Delay2_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoD_Continued_Delay2_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Continued_Delay2_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.twoD_Continued_Delay2_Numeric.Location = new System.Drawing.Point(486, 200);
            this.twoD_Continued_Delay2_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.twoD_Continued_Delay2_Numeric.Name = "twoD_Continued_Delay2_Numeric";
            this.twoD_Continued_Delay2_Numeric.Size = new System.Drawing.Size(57, 22);
            this.twoD_Continued_Delay2_Numeric.TabIndex = 48;
            this.twoD_Continued_Delay2_Numeric.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.twoD_Continued_Delay2_Numeric.ValueChanged += new System.EventHandler(this.twoD_Continued_Delay2_Numeric_ValueChanged);
            // 
            // twoD_Continued_End2_Label
            // 
            this.twoD_Continued_End2_Label.AutoSize = true;
            this.twoD_Continued_End2_Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Continued_End2_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Continued_End2_Label.Location = new System.Drawing.Point(395, 84);
            this.twoD_Continued_End2_Label.Name = "twoD_Continued_End2_Label";
            this.twoD_Continued_End2_Label.Size = new System.Drawing.Size(65, 26);
            this.twoD_Continued_End2_Label.TabIndex = 47;
            this.twoD_Continued_End2_Label.Text = "Continued \r\nHeight End";
            // 
            // twoD_Continued_End2_Numeric
            // 
            this.twoD_Continued_End2_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.twoD_Continued_End2_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoD_Continued_End2_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Continued_End2_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.twoD_Continued_End2_Numeric.Location = new System.Drawing.Point(486, 86);
            this.twoD_Continued_End2_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.twoD_Continued_End2_Numeric.Name = "twoD_Continued_End2_Numeric";
            this.twoD_Continued_End2_Numeric.Size = new System.Drawing.Size(57, 22);
            this.twoD_Continued_End2_Numeric.TabIndex = 46;
            this.twoD_Continued_End2_Numeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.twoD_Continued_End2_Numeric.ValueChanged += new System.EventHandler(this.twoD_Continued_End2_Numeric_ValueChanged);
            // 
            // twoD_Continued_Duration2_Label
            // 
            this.twoD_Continued_Duration2_Label.AutoSize = true;
            this.twoD_Continued_Duration2_Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Continued_Duration2_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Continued_Duration2_Label.Location = new System.Drawing.Point(395, 140);
            this.twoD_Continued_Duration2_Label.Name = "twoD_Continued_Duration2_Label";
            this.twoD_Continued_Duration2_Label.Size = new System.Drawing.Size(91, 26);
            this.twoD_Continued_Duration2_Label.TabIndex = 45;
            this.twoD_Continued_Duration2_Label.Text = "Continued \r\nHeight Duration";
            // 
            // twoD_Continued_Duration2_Numeric
            // 
            this.twoD_Continued_Duration2_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.twoD_Continued_Duration2_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoD_Continued_Duration2_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Continued_Duration2_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.twoD_Continued_Duration2_Numeric.Location = new System.Drawing.Point(486, 143);
            this.twoD_Continued_Duration2_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.twoD_Continued_Duration2_Numeric.Name = "twoD_Continued_Duration2_Numeric";
            this.twoD_Continued_Duration2_Numeric.Size = new System.Drawing.Size(57, 22);
            this.twoD_Continued_Duration2_Numeric.TabIndex = 44;
            this.twoD_Continued_Duration2_Numeric.Value = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            this.twoD_Continued_Duration2_Numeric.ValueChanged += new System.EventHandler(this.twoD_Continued_Duration2_Numeric_ValueChanged);
            // 
            // twoD_Continued_Start2_Label
            // 
            this.twoD_Continued_Start2_Label.AutoSize = true;
            this.twoD_Continued_Start2_Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Continued_Start2_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Continued_Start2_Label.Location = new System.Drawing.Point(395, 28);
            this.twoD_Continued_Start2_Label.Name = "twoD_Continued_Start2_Label";
            this.twoD_Continued_Start2_Label.Size = new System.Drawing.Size(69, 26);
            this.twoD_Continued_Start2_Label.TabIndex = 43;
            this.twoD_Continued_Start2_Label.Text = "Continued  \r\nHeight Start";
            // 
            // twoD_Continued_Start2_Numeric
            // 
            this.twoD_Continued_Start2_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.twoD_Continued_Start2_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoD_Continued_Start2_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Continued_Start2_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.twoD_Continued_Start2_Numeric.Location = new System.Drawing.Point(486, 29);
            this.twoD_Continued_Start2_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.twoD_Continued_Start2_Numeric.Name = "twoD_Continued_Start2_Numeric";
            this.twoD_Continued_Start2_Numeric.Size = new System.Drawing.Size(57, 22);
            this.twoD_Continued_Start2_Numeric.TabIndex = 42;
            this.twoD_Continued_Start2_Numeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.twoD_Continued_Start2_Numeric.ValueChanged += new System.EventHandler(this.twoD_Continued_Start2_Numeric_ValueChanged);
            // 
            // twoD_Continued_Delay1_Label
            // 
            this.twoD_Continued_Delay1_Label.AutoSize = true;
            this.twoD_Continued_Delay1_Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Continued_Delay1_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Continued_Delay1_Label.Location = new System.Drawing.Point(395, 308);
            this.twoD_Continued_Delay1_Label.Name = "twoD_Continued_Delay1_Label";
            this.twoD_Continued_Delay1_Label.Size = new System.Drawing.Size(70, 26);
            this.twoD_Continued_Delay1_Label.TabIndex = 41;
            this.twoD_Continued_Delay1_Label.Text = "Continued \r\nWidth Delay";
            // 
            // twoD_Continued_Delay1_Numeric
            // 
            this.twoD_Continued_Delay1_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.twoD_Continued_Delay1_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoD_Continued_Delay1_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Continued_Delay1_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.twoD_Continued_Delay1_Numeric.Location = new System.Drawing.Point(486, 314);
            this.twoD_Continued_Delay1_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.twoD_Continued_Delay1_Numeric.Name = "twoD_Continued_Delay1_Numeric";
            this.twoD_Continued_Delay1_Numeric.Size = new System.Drawing.Size(57, 22);
            this.twoD_Continued_Delay1_Numeric.TabIndex = 40;
            this.twoD_Continued_Delay1_Numeric.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.twoD_Continued_Delay1_Numeric.ValueChanged += new System.EventHandler(this.twoD_Continued_Delay1_Numeric_ValueChanged);
            // 
            // twoD_Continued_Duration1_Label
            // 
            this.twoD_Continued_Duration1_Label.AutoSize = true;
            this.twoD_Continued_Duration1_Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Continued_Duration1_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Continued_Duration1_Label.Location = new System.Drawing.Point(395, 252);
            this.twoD_Continued_Duration1_Label.Name = "twoD_Continued_Duration1_Label";
            this.twoD_Continued_Duration1_Label.Size = new System.Drawing.Size(88, 26);
            this.twoD_Continued_Duration1_Label.TabIndex = 39;
            this.twoD_Continued_Duration1_Label.Text = "Continued \r\nWidth Duration";
            // 
            // twoD_Continued_Duration1_Numeric
            // 
            this.twoD_Continued_Duration1_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.twoD_Continued_Duration1_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoD_Continued_Duration1_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Continued_Duration1_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.twoD_Continued_Duration1_Numeric.Location = new System.Drawing.Point(486, 257);
            this.twoD_Continued_Duration1_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.twoD_Continued_Duration1_Numeric.Name = "twoD_Continued_Duration1_Numeric";
            this.twoD_Continued_Duration1_Numeric.Size = new System.Drawing.Size(57, 22);
            this.twoD_Continued_Duration1_Numeric.TabIndex = 38;
            this.twoD_Continued_Duration1_Numeric.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.twoD_Continued_Duration1_Numeric.ValueChanged += new System.EventHandler(this.twoD_Continued_Duration1_Numeric_ValueChanged);
            // 
            // twoD_Continued_End1_Label
            // 
            this.twoD_Continued_End1_Label.AutoSize = true;
            this.twoD_Continued_End1_Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Continued_End1_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Continued_End1_Label.Location = new System.Drawing.Point(212, 307);
            this.twoD_Continued_End1_Label.Name = "twoD_Continued_End1_Label";
            this.twoD_Continued_End1_Label.Size = new System.Drawing.Size(65, 26);
            this.twoD_Continued_End1_Label.TabIndex = 37;
            this.twoD_Continued_End1_Label.Text = "Continued \r\nWidth End";
            // 
            // twoD_Continued_End1_Numeric
            // 
            this.twoD_Continued_End1_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.twoD_Continued_End1_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoD_Continued_End1_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Continued_End1_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.twoD_Continued_End1_Numeric.Location = new System.Drawing.Point(304, 308);
            this.twoD_Continued_End1_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.twoD_Continued_End1_Numeric.Name = "twoD_Continued_End1_Numeric";
            this.twoD_Continued_End1_Numeric.Size = new System.Drawing.Size(49, 22);
            this.twoD_Continued_End1_Numeric.TabIndex = 36;
            this.twoD_Continued_End1_Numeric.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.twoD_Continued_End1_Numeric.ValueChanged += new System.EventHandler(this.twoD_Continued_End1_Numeric_ValueChanged);
            // 
            // twoD_Continued_Start1_Label
            // 
            this.twoD_Continued_Start1_Label.AutoSize = true;
            this.twoD_Continued_Start1_Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Continued_Start1_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Continued_Start1_Label.Location = new System.Drawing.Point(212, 249);
            this.twoD_Continued_Start1_Label.Name = "twoD_Continued_Start1_Label";
            this.twoD_Continued_Start1_Label.Size = new System.Drawing.Size(66, 26);
            this.twoD_Continued_Start1_Label.TabIndex = 35;
            this.twoD_Continued_Start1_Label.Text = "Continued \r\nWidth Start";
            // 
            // twoD_Continued_Start1_Numeric
            // 
            this.twoD_Continued_Start1_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.twoD_Continued_Start1_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoD_Continued_Start1_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Continued_Start1_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.twoD_Continued_Start1_Numeric.Location = new System.Drawing.Point(304, 252);
            this.twoD_Continued_Start1_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.twoD_Continued_Start1_Numeric.Name = "twoD_Continued_Start1_Numeric";
            this.twoD_Continued_Start1_Numeric.Size = new System.Drawing.Size(49, 22);
            this.twoD_Continued_Start1_Numeric.TabIndex = 34;
            this.twoD_Continued_Start1_Numeric.Value = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.twoD_Continued_Start1_Numeric.ValueChanged += new System.EventHandler(this.twoD_Continued_Start1_Numeric_ValueChanged);
            // 
            // twoD_Continued_Easing_ComboBox
            // 
            this.twoD_Continued_Easing_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.twoD_Continued_Easing_ComboBox.DropDownHeight = 250;
            this.twoD_Continued_Easing_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.twoD_Continued_Easing_ComboBox.DropDownWidth = 140;
            this.twoD_Continued_Easing_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoD_Continued_Easing_ComboBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Continued_Easing_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Continued_Easing_ComboBox.FormattingEnabled = true;
            this.twoD_Continued_Easing_ComboBox.IntegralHeight = false;
            this.twoD_Continued_Easing_ComboBox.ItemHeight = 13;
            this.twoD_Continued_Easing_ComboBox.Items.AddRange(new object[] {
            "BounceEaseIn",
            "BounceEaseInOut",
            "BounceEaseOut",
            "BounceEaseOutIn",
            "CircularEaseIn",
            "CircularEaseInOut",
            "CircularEaseOut",
            "CubicEaseIn",
            "CubicEaseInOut",
            "CubicEaseOut",
            "ExponentialEaseIn",
            "ExponentialEaseInOut",
            "ExponentialEaseOut",
            "Liner",
            "None",
            "QuadraticEaseIn",
            "QuadraticEaseInOut",
            "QuadraticEaseOut",
            "QuarticEaseIn",
            "QuarticEaseInOut",
            "QuarticEaseOut",
            "QuinticEaseIn",
            "QuinticEaseInOut",
            "QuinticEaseOut",
            "SinusoidalEaseIn",
            "SinusoidalEaseInOut",
            "SinusoidalEaseOut"});
            this.twoD_Continued_Easing_ComboBox.Location = new System.Drawing.Point(96, 76);
            this.twoD_Continued_Easing_ComboBox.Name = "twoD_Continued_Easing_ComboBox";
            this.twoD_Continued_Easing_ComboBox.Size = new System.Drawing.Size(80, 21);
            this.twoD_Continued_Easing_ComboBox.Sorted = true;
            this.twoD_Continued_Easing_ComboBox.TabIndex = 24;
            // 
            // twoD_Continued_Easing_Label
            // 
            this.twoD_Continued_Easing_Label.AutoSize = true;
            this.twoD_Continued_Easing_Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Continued_Easing_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Continued_Easing_Label.Location = new System.Drawing.Point(7, 79);
            this.twoD_Continued_Easing_Label.Name = "twoD_Continued_Easing_Label";
            this.twoD_Continued_Easing_Label.Size = new System.Drawing.Size(65, 26);
            this.twoD_Continued_Easing_Label.TabIndex = 23;
            this.twoD_Continued_Easing_Label.Text = "Continued \r\nEasing";
            // 
            // twoD_Delay1_Label
            // 
            this.twoD_Delay1_Label.AutoSize = true;
            this.twoD_Delay1_Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Delay1_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Delay1_Label.Location = new System.Drawing.Point(6, 314);
            this.twoD_Delay1_Label.Name = "twoD_Delay1_Label";
            this.twoD_Delay1_Label.Size = new System.Drawing.Size(70, 13);
            this.twoD_Delay1_Label.TabIndex = 32;
            this.twoD_Delay1_Label.Text = "Width Delay";
            // 
            // twoD_Delay1_Numeric
            // 
            this.twoD_Delay1_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.twoD_Delay1_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoD_Delay1_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Delay1_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.twoD_Delay1_Numeric.Location = new System.Drawing.Point(96, 311);
            this.twoD_Delay1_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.twoD_Delay1_Numeric.Name = "twoD_Delay1_Numeric";
            this.twoD_Delay1_Numeric.Size = new System.Drawing.Size(80, 22);
            this.twoD_Delay1_Numeric.TabIndex = 31;
            this.twoD_Delay1_Numeric.ValueChanged += new System.EventHandler(this.twoD_Delay1_Numeric_ValueChanged);
            // 
            // twoD_Duration1_Label
            // 
            this.twoD_Duration1_Label.AutoSize = true;
            this.twoD_Duration1_Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Duration1_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Duration1_Label.Location = new System.Drawing.Point(7, 267);
            this.twoD_Duration1_Label.Name = "twoD_Duration1_Label";
            this.twoD_Duration1_Label.Size = new System.Drawing.Size(88, 13);
            this.twoD_Duration1_Label.TabIndex = 30;
            this.twoD_Duration1_Label.Text = "Width Duration";
            // 
            // twoD_Duration1_Numeric
            // 
            this.twoD_Duration1_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.twoD_Duration1_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoD_Duration1_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Duration1_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.twoD_Duration1_Numeric.Location = new System.Drawing.Point(96, 264);
            this.twoD_Duration1_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.twoD_Duration1_Numeric.Name = "twoD_Duration1_Numeric";
            this.twoD_Duration1_Numeric.Size = new System.Drawing.Size(80, 22);
            this.twoD_Duration1_Numeric.TabIndex = 29;
            this.twoD_Duration1_Numeric.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.twoD_Duration1_Numeric.ValueChanged += new System.EventHandler(this.twoD_Duration1_Numeric_ValueChanged);
            // 
            // twoD_End1_Label
            // 
            this.twoD_End1_Label.AutoSize = true;
            this.twoD_End1_Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_End1_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_End1_Label.Location = new System.Drawing.Point(7, 220);
            this.twoD_End1_Label.Name = "twoD_End1_Label";
            this.twoD_End1_Label.Size = new System.Drawing.Size(62, 13);
            this.twoD_End1_Label.TabIndex = 28;
            this.twoD_End1_Label.Text = "Width End";
            // 
            // twoD_End1_Numeric
            // 
            this.twoD_End1_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.twoD_End1_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoD_End1_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_End1_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.twoD_End1_Numeric.Location = new System.Drawing.Point(96, 217);
            this.twoD_End1_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.twoD_End1_Numeric.Name = "twoD_End1_Numeric";
            this.twoD_End1_Numeric.Size = new System.Drawing.Size(80, 22);
            this.twoD_End1_Numeric.TabIndex = 27;
            this.twoD_End1_Numeric.Value = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.twoD_End1_Numeric.ValueChanged += new System.EventHandler(this.twoD_End1_Numeric_ValueChanged);
            // 
            // twoD_Property_ComboBox
            // 
            this.twoD_Property_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.twoD_Property_ComboBox.DropDownHeight = 250;
            this.twoD_Property_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.twoD_Property_ComboBox.DropDownWidth = 140;
            this.twoD_Property_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoD_Property_ComboBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Property_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Property_ComboBox.FormattingEnabled = true;
            this.twoD_Property_ComboBox.IntegralHeight = false;
            this.twoD_Property_ComboBox.ItemHeight = 13;
            this.twoD_Property_ComboBox.Items.AddRange(new object[] {
            "Location",
            "Size"});
            this.twoD_Property_ComboBox.Location = new System.Drawing.Point(96, 29);
            this.twoD_Property_ComboBox.Name = "twoD_Property_ComboBox";
            this.twoD_Property_ComboBox.Size = new System.Drawing.Size(80, 21);
            this.twoD_Property_ComboBox.Sorted = true;
            this.twoD_Property_ComboBox.TabIndex = 26;
            // 
            // twoD_Property_Label
            // 
            this.twoD_Property_Label.AutoSize = true;
            this.twoD_Property_Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Property_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Property_Label.Location = new System.Drawing.Point(5, 32);
            this.twoD_Property_Label.Name = "twoD_Property_Label";
            this.twoD_Property_Label.Size = new System.Drawing.Size(50, 13);
            this.twoD_Property_Label.TabIndex = 25;
            this.twoD_Property_Label.Text = "Property";
            // 
            // twoD_Start1_Label
            // 
            this.twoD_Start1_Label.AutoSize = true;
            this.twoD_Start1_Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Start1_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.twoD_Start1_Label.Location = new System.Drawing.Point(7, 173);
            this.twoD_Start1_Label.Name = "twoD_Start1_Label";
            this.twoD_Start1_Label.Size = new System.Drawing.Size(66, 13);
            this.twoD_Start1_Label.TabIndex = 22;
            this.twoD_Start1_Label.Text = "Width Start";
            // 
            // twoD_Start1_Numeric
            // 
            this.twoD_Start1_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.twoD_Start1_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoD_Start1_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.twoD_Start1_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.twoD_Start1_Numeric.Location = new System.Drawing.Point(96, 170);
            this.twoD_Start1_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.twoD_Start1_Numeric.Name = "twoD_Start1_Numeric";
            this.twoD_Start1_Numeric.Size = new System.Drawing.Size(80, 22);
            this.twoD_Start1_Numeric.TabIndex = 21;
            this.twoD_Start1_Numeric.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.twoD_Start1_Numeric.ValueChanged += new System.EventHandler(this.twoD_Start1_Numeric_ValueChanged);
            // 
            // oneD_GroupBox
            // 
            this.oneD_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.oneD_GroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.oneD_GroupBox.Controls.Add(this.oneD_Preview);
            this.oneD_GroupBox.Controls.Add(this.oneD_Easing_ComboBox);
            this.oneD_GroupBox.Controls.Add(this.label21);
            this.oneD_GroupBox.Controls.Add(this.label13);
            this.oneD_GroupBox.Controls.Add(this.oneD_Delay_Numeric);
            this.oneD_GroupBox.Controls.Add(this.label12);
            this.oneD_GroupBox.Controls.Add(this.oneD_Duration_Numeric);
            this.oneD_GroupBox.Controls.Add(this.label11);
            this.oneD_GroupBox.Controls.Add(this.oneD_End_Numeric);
            this.oneD_GroupBox.Controls.Add(this.oneD_Property_ComboBox);
            this.oneD_GroupBox.Controls.Add(this.label8);
            this.oneD_GroupBox.Controls.Add(this.label9);
            this.oneD_GroupBox.Controls.Add(this.oneD_Start_Numeric);
            this.oneD_GroupBox.Controls.Add(this.oneD_Custom_Property_Name_TextBox);
            this.oneD_GroupBox.Controls.Add(this.label4);
            this.oneD_GroupBox.Controls.Add(this.oneD_RotatingCube);
            this.oneD_GroupBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.oneD_GroupBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.oneD_GroupBox.Location = new System.Drawing.Point(232, 37);
            this.oneD_GroupBox.Name = "oneD_GroupBox";
            this.oneD_GroupBox.Size = new System.Drawing.Size(769, 226);
            this.oneD_GroupBox.TabIndex = 5;
            this.oneD_GroupBox.TabStop = false;
            this.oneD_GroupBox.Text = "1D Mode";
            this.oneD_GroupBox.Visible = false;
            // 
            // oneD_Preview
            // 
            this.oneD_Preview.FlatAppearance.BorderSize = 0;
            this.oneD_Preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneD_Preview.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.oneD_Preview.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.oneD_Preview.Location = new System.Drawing.Point(644, 27);
            this.oneD_Preview.Name = "oneD_Preview";
            this.oneD_Preview.Size = new System.Drawing.Size(104, 35);
            this.oneD_Preview.TabIndex = 17;
            this.oneD_Preview.Text = "Preview";
            this.oneD_Preview.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.oneD_Preview.UseVisualStyleBackColor = false;
            this.oneD_Preview.Click += new System.EventHandler(this.oneD_Preview_Click);
            this.oneD_Preview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.oneD_Preview_MouseDown);
            this.oneD_Preview.MouseEnter += new System.EventHandler(this.oneD_Preview_MouseEnter);
            this.oneD_Preview.MouseLeave += new System.EventHandler(this.oneD_Preview_MouseLeave);
            // 
            // oneD_Easing_ComboBox
            // 
            this.oneD_Easing_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.oneD_Easing_ComboBox.DropDownHeight = 250;
            this.oneD_Easing_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oneD_Easing_ComboBox.DropDownWidth = 160;
            this.oneD_Easing_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneD_Easing_ComboBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.oneD_Easing_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.oneD_Easing_ComboBox.FormattingEnabled = true;
            this.oneD_Easing_ComboBox.IntegralHeight = false;
            this.oneD_Easing_ComboBox.ItemHeight = 13;
            this.oneD_Easing_ComboBox.Items.AddRange(new object[] {
            "BounceEaseIn",
            "BounceEaseInOut",
            "BounceEaseOut",
            "BounceEaseOutIn",
            "CircularEaseIn",
            "CircularEaseInOut",
            "CircularEaseOut",
            "CubicEaseIn",
            "CubicEaseInOut",
            "CubicEaseOut",
            "ExponentialEaseIn",
            "ExponentialEaseInOut",
            "ExponentialEaseOut",
            "Liner",
            "None",
            "QuadraticEaseIn",
            "QuadraticEaseInOut",
            "QuadraticEaseOut",
            "QuarticEaseIn",
            "QuarticEaseInOut",
            "QuarticEaseOut",
            "QuinticEaseIn",
            "QuinticEaseInOut",
            "QuinticEaseOut",
            "SinusoidalEaseIn",
            "SinusoidalEaseInOut",
            "SinusoidalEaseOut"});
            this.oneD_Easing_ComboBox.Location = new System.Drawing.Point(87, 182);
            this.oneD_Easing_ComboBox.Name = "oneD_Easing_ComboBox";
            this.oneD_Easing_ComboBox.Size = new System.Drawing.Size(80, 21);
            this.oneD_Easing_ComboBox.Sorted = true;
            this.oneD_Easing_ComboBox.TabIndex = 21;
            this.oneD_Easing_ComboBox.SelectedIndexChanged += new System.EventHandler(this.oneD_Easing_ComboBox_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label21.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label21.Location = new System.Drawing.Point(18, 182);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "Easing";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(212, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Delay (ms)";
            // 
            // oneD_Delay_Numeric
            // 
            this.oneD_Delay_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.oneD_Delay_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oneD_Delay_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.oneD_Delay_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.oneD_Delay_Numeric.Location = new System.Drawing.Point(302, 180);
            this.oneD_Delay_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.oneD_Delay_Numeric.Name = "oneD_Delay_Numeric";
            this.oneD_Delay_Numeric.Size = new System.Drawing.Size(45, 22);
            this.oneD_Delay_Numeric.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(212, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Duration (ms)";
            // 
            // oneD_Duration_Numeric
            // 
            this.oneD_Duration_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.oneD_Duration_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oneD_Duration_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.oneD_Duration_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.oneD_Duration_Numeric.Location = new System.Drawing.Point(302, 130);
            this.oneD_Duration_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.oneD_Duration_Numeric.Name = "oneD_Duration_Numeric";
            this.oneD_Duration_Numeric.Size = new System.Drawing.Size(45, 22);
            this.oneD_Duration_Numeric.TabIndex = 29;
            this.oneD_Duration_Numeric.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(211, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "End";
            // 
            // oneD_End_Numeric
            // 
            this.oneD_End_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.oneD_End_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oneD_End_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.oneD_End_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.oneD_End_Numeric.Location = new System.Drawing.Point(302, 80);
            this.oneD_End_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.oneD_End_Numeric.Name = "oneD_End_Numeric";
            this.oneD_End_Numeric.Size = new System.Drawing.Size(45, 22);
            this.oneD_End_Numeric.TabIndex = 27;
            this.oneD_End_Numeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.oneD_End_Numeric.ValueChanged += new System.EventHandler(this.oneD_End_Numeric_ValueChanged);
            // 
            // oneD_Property_ComboBox
            // 
            this.oneD_Property_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.oneD_Property_ComboBox.DropDownHeight = 250;
            this.oneD_Property_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oneD_Property_ComboBox.DropDownWidth = 140;
            this.oneD_Property_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneD_Property_ComboBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.oneD_Property_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.oneD_Property_ComboBox.FormattingEnabled = true;
            this.oneD_Property_ComboBox.IntegralHeight = false;
            this.oneD_Property_ComboBox.ItemHeight = 13;
            this.oneD_Property_ComboBox.Items.AddRange(new object[] {
            "Custom",
            "Height",
            "Opacity",
            "Value",
            "Width"});
            this.oneD_Property_ComboBox.Location = new System.Drawing.Point(87, 105);
            this.oneD_Property_ComboBox.Name = "oneD_Property_ComboBox";
            this.oneD_Property_ComboBox.Size = new System.Drawing.Size(80, 21);
            this.oneD_Property_ComboBox.Sorted = true;
            this.oneD_Property_ComboBox.TabIndex = 26;
            this.oneD_Property_ComboBox.SelectedIndexChanged += new System.EventHandler(this.oneD_Property_ComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(18, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Property";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(211, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Start";
            // 
            // oneD_Start_Numeric
            // 
            this.oneD_Start_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.oneD_Start_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oneD_Start_Numeric.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.oneD_Start_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.oneD_Start_Numeric.Location = new System.Drawing.Point(302, 30);
            this.oneD_Start_Numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.oneD_Start_Numeric.Name = "oneD_Start_Numeric";
            this.oneD_Start_Numeric.Size = new System.Drawing.Size(45, 22);
            this.oneD_Start_Numeric.TabIndex = 21;
            this.oneD_Start_Numeric.ValueChanged += new System.EventHandler(this.oneD_Start_Numeric_ValueChanged);
            // 
            // oneD_Custom_Property_Name_TextBox
            // 
            this.oneD_Custom_Property_Name_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.oneD_Custom_Property_Name_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oneD_Custom_Property_Name_TextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.oneD_Custom_Property_Name_TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.oneD_Custom_Property_Name_TextBox.Location = new System.Drawing.Point(87, 36);
            this.oneD_Custom_Property_Name_TextBox.Name = "oneD_Custom_Property_Name_TextBox";
            this.oneD_Custom_Property_Name_TextBox.Size = new System.Drawing.Size(80, 22);
            this.oneD_Custom_Property_Name_TextBox.TabIndex = 11;
            this.oneD_Custom_Property_Name_TextBox.Text = "BackColor";
            this.oneD_Custom_Property_Name_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oneD_Custom_Property_Name_TextBox.TextChanged += new System.EventHandler(this.oneD_Custom_Property_Name_TextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(15, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "Custom \r\nProperty \r\nName";
            // 
            // ZeroitPeaceAnimatorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1017, 912);
            this.Controls.Add(this.thematic1501);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZeroitPeaceAnimatorDialog";
            this.Text = "ZeroitPeaceAnimatorDialog";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.thematic1501.ResumeLayout(false);
            this.general_Container.ResumeLayout(false);
            this.general_GroupBox.ResumeLayout(false);
            this.general_GroupBox.PerformLayout();
            this.threeD_GroupBox.ResumeLayout(false);
            this.threeD_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threeD_Delay_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeD_Duration_Numeric)).EndInit();
            this.twoD_GroupBox.ResumeLayout(false);
            this.twoD_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Delay2_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Duration2_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_End2_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Start2_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Continued_Delay2_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Continued_End2_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Continued_Duration2_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Continued_Start2_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Continued_Delay1_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Continued_Duration1_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Continued_End1_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Continued_Start1_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Delay1_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Duration1_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_End1_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoD_Start1_Numeric)).EndInit();
            this.oneD_GroupBox.ResumeLayout(false);
            this.oneD_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oneD_Delay_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneD_Duration_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneD_End_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneD_Start_Numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The thematic1501
        /// </summary>
        private ThemeManagers.NYX thematic1501;
        /// <summary>
        /// The one d group box
        /// </summary>
        private System.Windows.Forms.GroupBox oneD_GroupBox;
        /// <summary>
        /// The one d rotating cube
        /// </summary>
        private Transitions._HelpingControls.Rotating3DCube.RotatingCube oneD_RotatingCube;
        /// <summary>
        /// The general group box
        /// </summary>
        private System.Windows.Forms.GroupBox general_GroupBox;
        /// <summary>
        /// The peace animator1
        /// </summary>
        private Transitions.WinformAnimation.ZeroitPeaceAnim peaceAnimator1;
        /// <summary>
        /// The label1
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// The main control path continue ComboBox
        /// </summary>
        private System.Windows.Forms.ComboBox mainControl_Path_Continue_ComboBox;
        /// <summary>
        /// The label3
        /// </summary>
        private System.Windows.Forms.Label label3;
        /// <summary>
        /// The main control animation mode combo
        /// </summary>
        private System.Windows.Forms.ComboBox mainControl_animationMode_Combo;
        /// <summary>
        /// The main control reverse ComboBox
        /// </summary>
        private System.Windows.Forms.ComboBox mainControl_Reverse_ComboBox;
        /// <summary>
        /// The label6
        /// </summary>
        private System.Windows.Forms.Label label6;
        /// <summary>
        /// The main control repeat ComboBox
        /// </summary>
        private System.Windows.Forms.ComboBox mainControl_Repeat_ComboBox;
        /// <summary>
        /// The label5
        /// </summary>
        private System.Windows.Forms.Label label5;
        /// <summary>
        /// The one d custom property name text box
        /// </summary>
        private System.Windows.Forms.TextBox oneD_Custom_Property_Name_TextBox;
        /// <summary>
        /// The label4
        /// </summary>
        private System.Windows.Forms.Label label4;
        /// <summary>
        /// The zeroit simple line21
        /// </summary>
        private _HelpingControls.LineSimple2 zeroitSimpleLine21;
        /// <summary>
        /// The label9
        /// </summary>
        private System.Windows.Forms.Label label9;
        /// <summary>
        /// The one d start numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown oneD_Start_Numeric;
        /// <summary>
        /// The two d continued easing ComboBox
        /// </summary>
        private System.Windows.Forms.ComboBox twoD_Continued_Easing_ComboBox;
        /// <summary>
        /// The two d continued easing label
        /// </summary>
        private System.Windows.Forms.Label twoD_Continued_Easing_Label;
        /// <summary>
        /// The label13
        /// </summary>
        private System.Windows.Forms.Label label13;
        /// <summary>
        /// The one d delay numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown oneD_Delay_Numeric;
        /// <summary>
        /// The label12
        /// </summary>
        private System.Windows.Forms.Label label12;
        /// <summary>
        /// The one d duration numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown oneD_Duration_Numeric;
        /// <summary>
        /// The label11
        /// </summary>
        private System.Windows.Forms.Label label11;
        /// <summary>
        /// The one d end numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown oneD_End_Numeric;
        /// <summary>
        /// The one d property ComboBox
        /// </summary>
        private System.Windows.Forms.ComboBox oneD_Property_ComboBox;
        /// <summary>
        /// The label8
        /// </summary>
        private System.Windows.Forms.Label label8;
        /// <summary>
        /// The three d group box
        /// </summary>
        private System.Windows.Forms.GroupBox threeD_GroupBox;
        /// <summary>
        /// The label23
        /// </summary>
        private System.Windows.Forms.Label label23;
        /// <summary>
        /// The three d delay numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown threeD_Delay_Numeric;
        /// <summary>
        /// The label24
        /// </summary>
        private System.Windows.Forms.Label label24;
        /// <summary>
        /// The three d duration numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown threeD_Duration_Numeric;
        /// <summary>
        /// The three d property ComboBox
        /// </summary>
        private System.Windows.Forms.ComboBox threeD_Property_ComboBox;
        /// <summary>
        /// The label26
        /// </summary>
        private System.Windows.Forms.Label label26;
        /// <summary>
        /// The label28
        /// </summary>
        private System.Windows.Forms.Label label28;
        /// <summary>
        /// The three d color property name text box
        /// </summary>
        private System.Windows.Forms.TextBox threeD_Color_Property_Name_TextBox;
        /// <summary>
        /// The label29
        /// </summary>
        private System.Windows.Forms.Label label29;
        /// <summary>
        /// The three d rotating cube
        /// </summary>
        private Transitions._HelpingControls.Rotating3DCube.RotatingCube threeD_RotatingCube;
        /// <summary>
        /// The two d group box
        /// </summary>
        private System.Windows.Forms.GroupBox twoD_GroupBox;
        /// <summary>
        /// The two d delay1 label
        /// </summary>
        private System.Windows.Forms.Label twoD_Delay1_Label;
        /// <summary>
        /// The two d delay1 numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown twoD_Delay1_Numeric;
        /// <summary>
        /// The two d duration1 label
        /// </summary>
        private System.Windows.Forms.Label twoD_Duration1_Label;
        /// <summary>
        /// The two d duration1 numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown twoD_Duration1_Numeric;
        /// <summary>
        /// The two d end1 label
        /// </summary>
        private System.Windows.Forms.Label twoD_End1_Label;
        /// <summary>
        /// The two d end1 numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown twoD_End1_Numeric;
        /// <summary>
        /// The two d property ComboBox
        /// </summary>
        private System.Windows.Forms.ComboBox twoD_Property_ComboBox;
        /// <summary>
        /// The two d property label
        /// </summary>
        private System.Windows.Forms.Label twoD_Property_Label;
        /// <summary>
        /// The two d start1 label
        /// </summary>
        private System.Windows.Forms.Label twoD_Start1_Label;
        /// <summary>
        /// The two d start1 numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown twoD_Start1_Numeric;
        /// <summary>
        /// The two d rotating cube
        /// </summary>
        private Transitions._HelpingControls.Rotating3DCube.RotatingCube twoD_RotatingCube;
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
        /// The close BTN
        /// </summary>
        private System.Windows.Forms.Button closeBtn;
        /// <summary>
        /// The two d continued delay2 label
        /// </summary>
        private System.Windows.Forms.Label twoD_Continued_Delay2_Label;
        /// <summary>
        /// The two d continued delay2 numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown twoD_Continued_Delay2_Numeric;
        /// <summary>
        /// The two d continued end2 label
        /// </summary>
        private System.Windows.Forms.Label twoD_Continued_End2_Label;
        /// <summary>
        /// The two d continued end2 numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown twoD_Continued_End2_Numeric;
        /// <summary>
        /// The two d continued duration2 label
        /// </summary>
        private System.Windows.Forms.Label twoD_Continued_Duration2_Label;
        /// <summary>
        /// The two d continued duration2 numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown twoD_Continued_Duration2_Numeric;
        /// <summary>
        /// The two d continued start2 label
        /// </summary>
        private System.Windows.Forms.Label twoD_Continued_Start2_Label;
        /// <summary>
        /// The two d continued start2 numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown twoD_Continued_Start2_Numeric;
        /// <summary>
        /// The two d continued delay1 label
        /// </summary>
        private System.Windows.Forms.Label twoD_Continued_Delay1_Label;
        /// <summary>
        /// The two d continued delay1 numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown twoD_Continued_Delay1_Numeric;
        /// <summary>
        /// The two d continued duration1 label
        /// </summary>
        private System.Windows.Forms.Label twoD_Continued_Duration1_Label;
        /// <summary>
        /// The two d continued duration1 numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown twoD_Continued_Duration1_Numeric;
        /// <summary>
        /// The two d continued end1 label
        /// </summary>
        private System.Windows.Forms.Label twoD_Continued_End1_Label;
        /// <summary>
        /// The two d continued end1 numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown twoD_Continued_End1_Numeric;
        /// <summary>
        /// The two d continued start1 label
        /// </summary>
        private System.Windows.Forms.Label twoD_Continued_Start1_Label;
        /// <summary>
        /// The two d continued start1 numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown twoD_Continued_Start1_Numeric;
        /// <summary>
        /// The two d delay2 label
        /// </summary>
        private System.Windows.Forms.Label twoD_Delay2_Label;
        /// <summary>
        /// The two d delay2 numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown twoD_Delay2_Numeric;
        /// <summary>
        /// The two d duration2 label
        /// </summary>
        private System.Windows.Forms.Label twoD_Duration2_Label;
        /// <summary>
        /// The two d duration2 numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown twoD_Duration2_Numeric;
        /// <summary>
        /// The two d end2 label
        /// </summary>
        private System.Windows.Forms.Label twoD_End2_Label;
        /// <summary>
        /// The two d end2 numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown twoD_End2_Numeric;
        /// <summary>
        /// The two d start2 label
        /// </summary>
        private System.Windows.Forms.Label twoD_Start2_Label;
        /// <summary>
        /// The two d start2 numeric
        /// </summary>
        private System.Windows.Forms.NumericUpDown twoD_Start2_Numeric;
        /// <summary>
        /// The three d end color button
        /// </summary>
        public System.Windows.Forms.Button threeD_End_Color_Button;
        /// <summary>
        /// The label42
        /// </summary>
        private System.Windows.Forms.Label label42;
        /// <summary>
        /// The three d start color button
        /// </summary>
        public System.Windows.Forms.Button threeD_Start_Color_Button;
        /// <summary>
        /// The color changer
        /// </summary>
        private System.Windows.Forms.ColorDialog colorChanger;
        /// <summary>
        /// The three d easing ComboBox
        /// </summary>
        private System.Windows.Forms.ComboBox threeD_Easing_ComboBox;
        /// <summary>
        /// The label22
        /// </summary>
        private System.Windows.Forms.Label label22;
        /// <summary>
        /// The two d easing ComboBox
        /// </summary>
        private System.Windows.Forms.ComboBox twoD_Easing_ComboBox;
        /// <summary>
        /// The two d easing label
        /// </summary>
        private System.Windows.Forms.Label twoD_Easing_Label;
        /// <summary>
        /// The one d easing ComboBox
        /// </summary>
        private System.Windows.Forms.ComboBox oneD_Easing_ComboBox;
        /// <summary>
        /// The label21
        /// </summary>
        private System.Windows.Forms.Label label21;
        /// <summary>
        /// The label7
        /// </summary>
        private System.Windows.Forms.Label label7;
        /// <summary>
        /// The control ComboBox
        /// </summary>
        private System.Windows.Forms.ComboBox control_ComboBox;
        /// <summary>
        /// The one d width animator
        /// </summary>
        private Transitions.WinformAnimation.ZeroitPeaceAnim oneD_Width_Animator;
        /// <summary>
        /// The one d height animator
        /// </summary>
        private Transitions.WinformAnimation.ZeroitPeaceAnim oneD_Height_Animator;
        /// <summary>
        /// The one d opacity animator
        /// </summary>
        private Transitions.WinformAnimation.ZeroitPeaceAnim oneD_Opacity_Animator;
        /// <summary>
        /// The one d value animator
        /// </summary>
        private Transitions.WinformAnimation.ZeroitPeaceAnim oneD_Value_Animator;
        /// <summary>
        /// The one d preview
        /// </summary>
        public System.Windows.Forms.Button oneD_Preview;
        /// <summary>
        /// The three d preview
        /// </summary>
        public System.Windows.Forms.Button threeD_Preview;
        /// <summary>
        /// The two d preview
        /// </summary>
        public System.Windows.Forms.Button twoD_Preview;
        /// <summary>
        /// The tool tip1
        /// </summary>
        private System.Windows.Forms.ToolTip toolTip1;
        /// <summary>
        /// The one d custom animator
        /// </summary>
        private Transitions.WinformAnimation.ZeroitPeaceAnim oneD_Custom_Animator;
        /// <summary>
        /// The two d location animator
        /// </summary>
        private Transitions.WinformAnimation.ZeroitPeaceAnim twoD_Location_Animator;
        /// <summary>
        /// The two d size animator
        /// </summary>
        private Transitions.WinformAnimation.ZeroitPeaceAnim twoD_Size_Animator;
        /// <summary>
        /// The two d reset BTN
        /// </summary>
        public System.Windows.Forms.Button twoD_Reset_btn;
    }
}

