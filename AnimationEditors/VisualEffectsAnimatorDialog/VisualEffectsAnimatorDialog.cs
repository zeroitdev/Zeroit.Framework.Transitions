// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="VisualEffectsAnimatorDialog.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Windows.Forms;
using Zeroit.Framework.Transitions._HelpingControls.LBKnob;

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    /// Class VisualEffectsAnimatorDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class VisualEffectsAnimatorDialog : System.Windows.Forms.Form
    {

        #region Constants

        //Animation Type Constants

        /// <summary>
        /// The bottom anchored height effect
        /// </summary>
        private const int BottomAnchoredHeightEffect = 0;
        /// <summary>
        /// The color channel shift effect
        /// </summary>
        private const int ColorChannelShiftEffect = 1;
        /// <summary>
        /// The color shift effect
        /// </summary>
        private const int ColorShiftEffect = 2;
        /// <summary>
        /// The control fade effect
        /// </summary>
        private const int ControlFadeEffect = 3;
        /// <summary>
        /// The control fade effect2
        /// </summary>
        private const int ControlFadeEffect2 = 4;
        /// <summary>
        /// The fold effect
        /// </summary>
        private const int FoldEffect = 5;
        /// <summary>
        /// The font size effect
        /// </summary>
        private const int FontSizeEffect = 6;
        /// <summary>
        /// The form fade effect
        /// </summary>
        private const int FormFadeEffect = 7;
        /// <summary>
        /// The horizontal fold effect
        /// </summary>
        private const int HorizontalFoldEffect = 8;
        /// <summary>
        /// The left anchored width effect
        /// </summary>
        private const int LeftAnchoredWidthEffect = 9;
        /// <summary>
        /// The right anchored width effect
        /// </summary>
        private const int RightAnchoredWidthEffect = 10;
        /// <summary>
        /// The top anchored height effect
        /// </summary>
        private const int TopAnchoredHeightEffect = 11;
        /// <summary>
        /// The vertical fold effect
        /// </summary>
        private const int VerticalFoldEffect = 12;
        /// <summary>
        /// The x location effect
        /// </summary>
        private const int XLocationEffect = 13;
        /// <summary>
        /// The y location effect
        /// </summary>
        private const int YLocationEffect = 14;

        #region Empty AnimationType IF Else

        //if (mainControl_AnimationType_ComboBox.SelectedIndex == BottomAnchoredHeightEffect)
        //{
        //    
        //}
        //else if (mainControl_AnimationType_ComboBox.SelectedIndex == ColorChannelShiftEffect)
        //{

        //}
        //else if (mainControl_AnimationType_ComboBox.SelectedIndex == ColorShiftEffect)
        //{

        //}
        //else if (mainControl_AnimationType_ComboBox.SelectedIndex == ControlFadeEffect)
        //{

        //}
        //else if (mainControl_AnimationType_ComboBox.SelectedIndex == ControlFadeEffect2)
        //{

        //}
        //else if (mainControl_AnimationType_ComboBox.SelectedIndex == FoldEffect)
        //{

        //}
        //else if (mainControl_AnimationType_ComboBox.SelectedIndex == FontSizeEffect)
        //{

        //}
        //else if (mainControl_AnimationType_ComboBox.SelectedIndex == FormFadeEffect)
        //{

        //}
        //else if (mainControl_AnimationType_ComboBox.SelectedIndex == HorizontalFoldEffect)
        //{

        //}
        //else if (mainControl_AnimationType_ComboBox.SelectedIndex == LeftAnchoredWidthEffect)
        //{

        //}
        //else if (mainControl_AnimationType_ComboBox.SelectedIndex == RightAnchoredWidthEffect)
        //{

        //}
        //else if (mainControl_AnimationType_ComboBox.SelectedIndex == TopAnchoredHeightEffect)
        //{

        //}
        //else if (mainControl_AnimationType_ComboBox.SelectedIndex == VerticalFoldEffect)
        //{

        //}
        //else if (mainControl_AnimationType_ComboBox.SelectedIndex == XLocationEffect)
        //{

        //}
        //else if (mainControl_AnimationType_ComboBox.SelectedIndex == YLocationEffect)
        //{

        //}

        #endregion

        //Easing Constants
        //private const int BackEaseIn = 0;
        //private const int BackEaseInOut = 1;
        //private const int BackEaseOut = 2;
        //private const int BackEaseOutIn = 3;
        //private const int BounceEaseIn = 4;
        //private const int BounceEaseInOut = 5;
        //private const int BounceEaseOut = 6;
        //private const int BounceEaseOutIn = 7;
        //private const int CircEaseIn = 8;
        //private const int CircEaseInOut = 9;
        //private const int CircEaseOut = 10;
        //private const int CircEaseOutIn = 11;
        //private const int CubicEaseIn = 12;
        //private const int CubicEaseInOut = 13;
        //private const int CubicEaseOut = 14;
        //private const int CubicEaseOutIn = 15;
        //private const int ElasticEaseIn = 16;
        //private const int ElasticEaseInOut = 17;
        //private const int ElasticEaseOut = 18;
        //private const int ElasticEaseOutIn = 19;
        //private const int ExpoEaseIn = 20;
        //private const int ExpoEaseInOut = 21;
        //private const int ExpoEaseOut = 22;
        //private const int ExpoEaseOutIn = 23;
        //private const int Linear = 24;
        //private const int QuadEaseIn = 25;
        //private const int QuadEaseInOut = 26;
        //private const int QuadEaseOut = 27;
        //private const int QuadEaseOutIn = 28;
        //private const int QuartEaseIn = 29;
        //private const int QuartEaseInOut = 30;
        //private const int QuartEaseOut = 31;
        //private const int QuartEaseOutIn = 32;
        //private const int QuintEaseIn = 33;
        //private const int QuintEaseInOut = 34;
        //private const int QuintEaseOut = 35;
        //private const int QuintEaseOutIn = 36;
        //private const int SineEaseIn = 37;
        //private const int SineEaseInOut = 38;
        //private const int SineEaseOut = 39;
        //private const int SineEaseOutIn = 40;

        #region Empty Easing IF Else

        //if (mainControl_Easing_ComboBox.SelectedIndex == BackEaseIn)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == BackEaseInOut)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == BackEaseOut)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == BackEaseOutIn)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == BounceEaseIn)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == BounceEaseInOut)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == BounceEaseOut)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == BounceEaseOutIn)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == CircEaseIn)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == CircEaseInOut)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == CircEaseOut)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == CircEaseOutIn)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == CubicEaseIn)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == CubicEaseInOut)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == CubicEaseOut)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == CubicEaseOutIn)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == ElasticEaseIn)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == ElasticEaseInOut)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == ElasticEaseOut)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == ElasticEaseOutIn)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == ExpoEaseIn)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == ExpoEaseInOut)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == ExpoEaseOut)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == ExpoEaseOutIn)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == QuadEaseIn)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == QuadEaseInOut)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == QuadEaseOut)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == QuadEaseOutIn)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == QuartEaseIn)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == QuartEaseInOut)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == QuartEaseOut)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == QuartEaseOutIn)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == QuintEaseIn)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == QuintEaseInOut)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == QuintEaseOut)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == QuintEaseOutIn)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == SineEaseIn)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == SineEaseInOut)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == SineEaseOut)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == SineEaseOutIn)
        //{

        //}

        //else if (mainControl_Easing_ComboBox.SelectedIndex == Linear)
        //{

        //}

        #endregion



        #endregion

        #region Private Fields

        /// <summary>
        /// The knob1
        /// </summary>
        private ZeroitLBKnob knob1 = new ZeroitLBKnob();
        /// <summary>
        /// The knob2
        /// </summary>
        private ZeroitLBKnob knob2 = new ZeroitLBKnob();
        /// <summary>
        /// The knob3
        /// </summary>
        private ZeroitLBKnob knob3 = new ZeroitLBKnob();
        /// <summary>
        /// The knob4
        /// </summary>
        private ZeroitLBKnob knob4 = new ZeroitLBKnob();

        /// <summary>
        /// The knob1 animator
        /// </summary>
        private ZeroitAnimator knob1Animator = new ZeroitAnimator();
        /// <summary>
        /// The knob2 animator
        /// </summary>
        private ZeroitAnimator knob2Animator = new ZeroitAnimator();
        /// <summary>
        /// The knob3 animator
        /// </summary>
        private ZeroitAnimator knob3Animator = new ZeroitAnimator();
        /// <summary>
        /// The knob4 animator
        /// </summary>
        private ZeroitAnimator knob4Animator = new ZeroitAnimator();

        /// <summary>
        /// The warning label
        /// </summary>
        private System.Windows.Forms.Label warning_Label  = new System.Windows.Forms.Label();
        /// <summary>
        /// The animation warning
        /// </summary>
        private ZeroitVisAnim animationWarning =  new Zeroit.Framework.Transitions.ZeroitVisAnim();


        #region UserControls Declarations
        /// <summary>
        /// The bottom anchored height effect user control
        /// </summary>
        private BottomAnchoredHeightEffect_UserControl bottomAnchoredHeightEffect_UserControl =
            new BottomAnchoredHeightEffect_UserControl();

        /// <summary>
        /// The color channel shift effect user control
        /// </summary>
        private ColorChannelShiftEffect_UserControl colorChannelShiftEffect_UserControl =
            new ColorChannelShiftEffect_UserControl();

        /// <summary>
        /// The color shift effect user control
        /// </summary>
        private ColorShiftEffect_UserControl colorShiftEffect_UserControl = new ColorShiftEffect_UserControl();

        /// <summary>
        /// The control fade effect user control
        /// </summary>
        private ControlFadeEffect_UserControl controlFadeEffect_UserControl = new ControlFadeEffect_UserControl();

        /// <summary>
        /// The control fade effect2 user control
        /// </summary>
        private ControlFadeEffect2_UserControl controlFadeEffect2_UserControl = new ControlFadeEffect2_UserControl();

        /// <summary>
        /// The fold effect user control
        /// </summary>
        private FoldEffect_UserControl foldEffect_UserControl = new FoldEffect_UserControl();

        /// <summary>
        /// The font size effect user control
        /// </summary>
        private FontSizeEffect_UserControl fontSizeEffect_UserControl = new FontSizeEffect_UserControl();

        /// <summary>
        /// The form fade effect user control
        /// </summary>
        private FormFadeEffect_UserControl formFadeEffect_UserControl = new FormFadeEffect_UserControl();

        /// <summary>
        /// The horizontal fold effect user control
        /// </summary>
        private HorizontalFoldEffect_UserControl horizontalFoldEffect_UserControl = new HorizontalFoldEffect_UserControl();

        /// <summary>
        /// The left anchored width effect user control
        /// </summary>
        private LeftAnchoredWidthEffect_UserControl leftAnchoredWidthEffect_UserControl = new LeftAnchoredWidthEffect_UserControl();

        /// <summary>
        /// The right anchored width effect user control
        /// </summary>
        private RightAnchoredWidthEffect_UserControl rightAnchoredWidthEffect_UserControl = new RightAnchoredWidthEffect_UserControl();

        /// <summary>
        /// The top anchored height effect user control
        /// </summary>
        private TopAnchoredHeightEffect_UserControl topAnchoredHeightEffect_UserControl = new TopAnchoredHeightEffect_UserControl();

        /// <summary>
        /// The vertical fold effect user control
        /// </summary>
        private VerticalFoldEffect_UserControl verticalFoldEffect_UserControl = new VerticalFoldEffect_UserControl();

        /// <summary>
        /// The x location user control
        /// </summary>
        private XLocation_UserControl xLocation_UserControl = new XLocation_UserControl();

        /// <summary>
        /// The y location user control
        /// </summary>
        private YLocation_UserControl yLocation_UserControl = new YLocation_UserControl();

        #endregion


        #endregion

        #region Public Properties

        /// <summary>
        /// The visual effects input
        /// </summary>
        private VisualEffectsInput visualEffectsInput;

        /// <summary>
        /// Gets the visual effects input.
        /// </summary>
        /// <value>The visual effects input.</value>
        public VisualEffectsInput VisualEffectsInput
        {
            get { return visualEffectsInput; }
        }


        #endregion

        #region Private Methods

        #region Item Creation

        /// <summary>
        /// Warnings the label created.
        /// </summary>
        private void WarningLabelCreated()
        {
            // 
            // warning_Label
            // 
            this.warning_Label.AutoSize = true;
            this.warning_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.warning_Label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.warning_Label.ForeColor = System.Drawing.Color.Crimson;
            this.warning_Label.Location = new System.Drawing.Point(447, 428);
            this.warning_Label.Name = "warning_Label";
            this.warning_Label.Size = new System.Drawing.Size(455, 27);
            this.warning_Label.TabIndex = 83;
            this.warning_Label.Text = "! Do not Preview Control Fade Effect 2 in the Animation Editor";
            this.warning_Label.UseCompatibleTextRendering = true;
            this.warning_Label.Visible = true;

            this.thematic1501.Controls.Add(this.warning_Label);
            AnimationWarningCreated();

            this.animationWarning.Activate();

        }

        /// <summary>
        /// Warnings the label removed.
        /// </summary>
        private void WarningLabelRemoved()
        {
            warning_Label.Visible = false;
            //warning_Label.Enabled = false;
            warning_Label.SendToBack();
            animationWarning.Dispose();
            //this.thematic1501.Controls.Remove(this.warning_Label);
            //animationWarning.Target = null;
            
        }

        /// <summary>
        /// Animations the warning created.
        /// </summary>
        private void AnimationWarningCreated()
        {
            // 
            // animationWarning
            // 
            this.animationWarning.AnimationType = Zeroit.Framework.Transitions.ZeroitVisAnim.GetAnimationType.ControlFadeEffect;
            this.animationWarning.Delay = 500;
            this.animationWarning.Duration = 1000;
            this.animationWarning.EasingType = Zeroit.Framework.Transitions.ZeroitVisAnim.EasingFunctionTypes.BackEaseIn;
            this.animationWarning.Loops = 2;
            this.animationWarning.Reverse = true;
            this.animationWarning.Target = this.warning_Label;
            this.animationWarning.ValueToReach = 10;

            
        }

        /// <summary>
        /// Knob1s the animator created.
        /// </summary>
        private void Knob1AnimatorCreated()
        {
            knob1Animator.Target = knob1;
            knob1Animator.AnimationType = AnimationType.Mosaic;
            knob1Animator.TargetHeight = 121;
            knob1Animator.TargetWidth = 118;
            knob1Animator.Interval = 10;
            knob1Animator.MaxAnimationTime = 1500;
            knob1Animator.TimeStep = 0.02f;
        }

        /// <summary>
        /// Knob2s the animator created.
        /// </summary>
        private void Knob2AnimatorCreated()
        {
            knob2Animator.Target = knob2;
            knob2Animator.AnimationType = AnimationType.Mosaic;
            knob2Animator.TargetHeight = 121;
            knob2Animator.TargetWidth = 118;
            knob2Animator.Interval = 10;
            knob2Animator.MaxAnimationTime = 1500;
            knob2Animator.TimeStep = 0.02f;
        }

        /// <summary>
        /// Knob3s the animator created.
        /// </summary>
        private void Knob3AnimatorCreated()
        {
            knob3Animator.Target = knob3;
            knob3Animator.AnimationType = AnimationType.Mosaic;
            knob3Animator.TargetHeight = 121;
            knob3Animator.TargetWidth = 118;
            knob3Animator.Interval = 10;
            knob3Animator.MaxAnimationTime = 1500;
            knob3Animator.TimeStep = 0.02f;
        }

        /// <summary>
        /// Knob4s the animator created.
        /// </summary>
        private void Knob4AnimatorCreated()
        {
            knob4Animator.Target = knob4;
            knob4Animator.AnimationType = AnimationType.Mosaic;
            knob4Animator.TargetHeight = 121;
            knob4Animator.TargetWidth = 118;
            knob4Animator.Interval = 10;
            knob4Animator.MaxAnimationTime = 1500;
            knob4Animator.TimeStep = 0.02f;
        }

        /// <summary>
        /// Knob1s the created.
        /// </summary>
        private void Knob1Created()
        {
            this.knob1.BackColor = System.Drawing.Color.Transparent;
            this.knob1.DrawRatio = 0.59F;
            this.knob1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.knob1.IndicatorOffset = 10F;
            this.knob1.KnobColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.knob1.Location = new System.Drawing.Point(388, 118);
            this.knob1.MaxValue = (float)mainControl_Duration_Numeric.Maximum;
            this.knob1.MinValue = (float)mainControl_Duration_Numeric.Minimum;
            this.knob1.Renderer = null;
            this.knob1.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.knob1.Size = new System.Drawing.Size(118, 121);
            this.knob1.StepValue = (float)mainControl_Duration_Numeric.Increment;
            this.knob1.Style = Zeroit.Framework.Transitions._HelpingControls.LBKnob.ZeroitLBKnob.KnobStyle.Circular;
            this.knob1.Value = (float)mainControl_Duration_Numeric.Value;
            this.knob1.Visible = true;
            

            thematic1501.Controls.Add(knob1);
            knob1.KnobChangeValue += Knob1_KnobChangeValue;
        }
        /// <summary>
        /// Knob1s the remove.
        /// </summary>
        private void Knob1Remove()
        {
            knob1.Visible = false;
            thematic1501.Controls.Remove(knob1);
        }

        /// <summary>
        /// Knob2s the created.
        /// </summary>
        private void Knob2Created()
        {
            this.knob2.BackColor = System.Drawing.Color.Transparent;
            this.knob2.DrawRatio = 0.59F;
            this.knob2.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.knob2.IndicatorOffset = 10F;
            this.knob2.KnobColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.knob2.Location = new System.Drawing.Point(388, 167);
            this.knob2.MaxValue = (float)mainControl_Delay_Numeric.Maximum;
            this.knob2.MinValue = (float)mainControl_Delay_Numeric.Minimum;
            this.knob2.Renderer = null;
            this.knob2.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.knob2.Size = new System.Drawing.Size(118, 121);
            this.knob2.StepValue = (float)mainControl_Delay_Numeric.Increment;
            this.knob2.Style = Zeroit.Framework.Transitions._HelpingControls.LBKnob.ZeroitLBKnob.KnobStyle.Circular;
            this.knob2.Value = (float)mainControl_Delay_Numeric.Value;
            this.knob2.Visible = true;
            this.knob2.BringToFront();

            thematic1501.Controls.Add(knob2);
            knob2.KnobChangeValue += Knob2_KnobChangeValue;
        }
        /// <summary>
        /// Knob2s the remove.
        /// </summary>
        private void Knob2Remove()
        {
            thematic1501.Controls.Remove(knob2);
            knob2.Visible = false;
        }

        /// <summary>
        /// Knob3s the created.
        /// </summary>
        private void Knob3Created()
        {
            this.knob3.BackColor = System.Drawing.Color.Transparent;
            this.knob3.DrawRatio = 0.59F;
            this.knob3.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.knob3.IndicatorOffset = 10F;
            this.knob3.KnobColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.knob3.Location = new System.Drawing.Point(388, 227);
            this.knob3.MaxValue = (float)mainControl_Loops_Numeric.Maximum;
            this.knob3.MinValue = (float)mainControl_Loops_Numeric.Minimum;
            this.knob3.Renderer = null;
            this.knob3.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.knob3.Size = new System.Drawing.Size(118, 121);
            this.knob3.StepValue = (float)mainControl_Loops_Numeric.Increment;
            this.knob3.Style = Zeroit.Framework.Transitions._HelpingControls.LBKnob.ZeroitLBKnob.KnobStyle.Circular;
            this.knob3.Value = (float)mainControl_Loops_Numeric.Value;
            this.knob3.Visible = true;
            this.knob3.BringToFront();

            thematic1501.Controls.Add(knob3);
            knob3.KnobChangeValue += Knob3_KnobChangeValue;
        }
        /// <summary>
        /// Knob3s the remove.
        /// </summary>
        private void Knob3Remove()
        {
            thematic1501.Controls.Remove(knob3);
            knob3.Visible = false;
        }

        /// <summary>
        /// Knob4s the created.
        /// </summary>
        private void Knob4Created()
        {
            this.knob4.BackColor = System.Drawing.Color.Transparent;
            this.knob4.DrawRatio = 0.59F;
            this.knob4.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.knob4.IndicatorOffset = 10F;
            this.knob4.KnobColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.knob4.Location = new System.Drawing.Point(388, 279);
            this.knob4.MaxValue = (float)mainControl_ValueToReach_Numeric.Maximum;
            this.knob4.MinValue = (float)mainControl_ValueToReach_Numeric.Minimum;
            this.knob4.Renderer = null;
            this.knob4.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.knob4.Size = new System.Drawing.Size(118, 121);
            this.knob4.StepValue = (float)mainControl_ValueToReach_Numeric.Increment;
            this.knob4.Style = Zeroit.Framework.Transitions._HelpingControls.LBKnob.ZeroitLBKnob.KnobStyle.Circular;
            this.knob4.Value = (float)mainControl_ValueToReach_Numeric.Value;
            this.knob4.Visible = true;
            this.knob4.BringToFront();

            thematic1501.Controls.Add(knob4);
            knob4.KnobChangeValue += Knob4_KnobChangeValue;
        }
        /// <summary>
        /// Knob4s the remove.
        /// </summary>
        private void Knob4Remove()
        {
            thematic1501.Controls.Remove(knob4);
            knob4.Visible = false;
        }


        /// <summary>
        /// Handles the Click event of the showKnob1_Duration_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob1_Duration_Btn_Click(object sender, EventArgs e)
        {

            Knob1Created();
            Knob2Remove();
            Knob3Remove();
            Knob4Remove();

            this.knob1.BringToFront();
            knob1Animator.Activate();


        }


        /// <summary>
        /// Handles the Click event of the showKnob2_Delay_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob2_Delay_Btn_Click(object sender, EventArgs e)
        {
            Knob2Created();
            Knob3Remove();
            Knob4Remove();
            Knob1Remove();
            this.knob2.BringToFront();
            knob2Animator.Activate();
        }

        /// <summary>
        /// Handles the Click event of the showKnob3_Loops_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob3_Loops_Btn_Click(object sender, EventArgs e)
        {
            Knob3Created();
            Knob4Remove();
            Knob1Remove();
            Knob2Remove();

            this.knob3.BringToFront();
            knob3Animator.Activate();
        }

        /// <summary>
        /// Handles the Click event of the showKnob4_ValueToReach_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob4_ValueToReach_Btn_Click(object sender, EventArgs e)
        {
            Knob4Created();
            Knob1Remove();
            Knob2Remove();
            Knob3Remove();

            this.knob4.BringToFront();

            knob4Animator.Activate();

        }
        /// <summary>
        /// Handles the KnobChangeValue event of the Knob1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ZeroitLBKnobEventArgs"/> instance containing the event data.</param>
        private void Knob1_KnobChangeValue(object sender, ZeroitLBKnobEventArgs e)
        {
            mainControl_Duration_Numeric.Value = Convert.ToInt32(knob1.Value);
        }

        /// <summary>
        /// Handles the KnobChangeValue event of the Knob2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ZeroitLBKnobEventArgs"/> instance containing the event data.</param>
        private void Knob2_KnobChangeValue(object sender, ZeroitLBKnobEventArgs e)
        {
            mainControl_Delay_Numeric.Value = Convert.ToInt32(knob2.Value);
        }

        /// <summary>
        /// Handles the KnobChangeValue event of the Knob3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ZeroitLBKnobEventArgs"/> instance containing the event data.</param>
        private void Knob3_KnobChangeValue(object sender, ZeroitLBKnobEventArgs e)
        {
            mainControl_Loops_Numeric.Value = Convert.ToInt32(knob3.Value);
        }

        /// <summary>
        /// Handles the KnobChangeValue event of the Knob4 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ZeroitLBKnobEventArgs"/> instance containing the event data.</param>
        private void Knob4_KnobChangeValue(object sender, ZeroitLBKnobEventArgs e)
        {
            mainControl_ValueToReach_Numeric.Value = Convert.ToInt32(knob4.Value);
        }

        #endregion

        /// <summary>
        /// Sets the initial values.
        /// </summary>
        /// <param name="visualEffectsInput">The visual effects input.</param>
        private void Set_Initial_Values(VisualEffectsInput visualEffectsInput)
        {
            #region AnimationType Easing

            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string animationNames in Enum.GetNames(typeof(ZeroitVisAnimEdit.GetAnimationType)))
            {
                mainControl_AnimationType_ComboBox.Items.Add(animationNames);

            }

            for (int j = 0; j < mainControl_AnimationType_ComboBox.Items.Count; j++)
            {
                if (visualEffectsInput.AnimationType== (ZeroitVisAnimEdit.GetAnimationType)Enum.Parse(typeof(ZeroitVisAnimEdit.GetAnimationType), 
                    mainControl_AnimationType_ComboBox.Items[j].ToString()))
                {
                    mainControl_AnimationType_ComboBox.SelectedIndex = j;

                }

            }


            #region Old Code
            //try
            //{
            //    if (visualEffectsInput.AnimationType == ZeroitVisAnimEdit.GetAnimationType
            //                .BottomAnchoredHeightEffect)
            //    {
            //        mainControl_AnimationType_ComboBox.SelectedIndex = BottomAnchoredHeightEffect;
            //    }
            //    else if (visualEffectsInput.AnimationType == ZeroitVisAnimEdit.GetAnimationType
            //                 .ColorChannelShiftEffect)
            //    {
            //        mainControl_AnimationType_ComboBox.SelectedIndex = ColorChannelShiftEffect;
            //    }
            //    else if (visualEffectsInput.AnimationType == ZeroitVisAnimEdit.GetAnimationType
            //                 .ColorShiftEffect)
            //    {
            //        mainControl_AnimationType_ComboBox.SelectedIndex = ColorShiftEffect;
            //    }
            //    else if (visualEffectsInput.AnimationType == ZeroitVisAnimEdit.GetAnimationType
            //                 .ControlFadeEffect)
            //    {
            //        mainControl_AnimationType_ComboBox.SelectedIndex = ControlFadeEffect;
            //    }
            //    else if (visualEffectsInput.AnimationType == ZeroitVisAnimEdit.GetAnimationType
            //                 .ControlFadeEffect2)
            //    {
            //        mainControl_AnimationType_ComboBox.SelectedIndex = ControlFadeEffect2;
            //    }
            //    else if (visualEffectsInput.AnimationType == ZeroitVisAnimEdit.GetAnimationType
            //                 .FoldEffect)
            //    {
            //        mainControl_AnimationType_ComboBox.SelectedIndex = FoldEffect;
            //    }
            //    else if (visualEffectsInput.AnimationType == ZeroitVisAnimEdit.GetAnimationType
            //                 .FontSizeEffect)
            //    {
            //        mainControl_AnimationType_ComboBox.SelectedIndex = FontSizeEffect;
            //    }
            //    else if (visualEffectsInput.AnimationType == ZeroitVisAnimEdit.GetAnimationType
            //                 .FormFadeEffect)
            //    {
            //        mainControl_AnimationType_ComboBox.SelectedIndex = FormFadeEffect;
            //    }
            //    else if (visualEffectsInput.AnimationType == ZeroitVisAnimEdit.GetAnimationType
            //                 .HorizontalFoldEffect)
            //    {
            //        mainControl_AnimationType_ComboBox.SelectedIndex = HorizontalFoldEffect;
            //    }
            //    else if (visualEffectsInput.AnimationType == ZeroitVisAnimEdit.GetAnimationType
            //                 .LeftAnchoredWidthEffect)
            //    {
            //        mainControl_AnimationType_ComboBox.SelectedIndex = LeftAnchoredWidthEffect;
            //    }
            //    else if (visualEffectsInput.AnimationType == ZeroitVisAnimEdit.GetAnimationType
            //                 .RightAnchoredWidthEffect)
            //    {
            //        mainControl_AnimationType_ComboBox.SelectedIndex = RightAnchoredWidthEffect;
            //    }
            //    else if (visualEffectsInput.AnimationType == ZeroitVisAnimEdit.GetAnimationType
            //                 .TopAnchoredHeightEffect)
            //    {
            //        mainControl_AnimationType_ComboBox.SelectedIndex = TopAnchoredHeightEffect;
            //    }
            //    else if (visualEffectsInput.AnimationType == ZeroitVisAnimEdit.GetAnimationType
            //                 .VerticalFoldEffect)
            //    {
            //        mainControl_AnimationType_ComboBox.SelectedIndex = VerticalFoldEffect;
            //    }
            //    else if (visualEffectsInput.AnimationType == ZeroitVisAnimEdit.GetAnimationType
            //                 .XLocationEffect)
            //    {
            //        mainControl_AnimationType_ComboBox.SelectedIndex = XLocationEffect;
            //    }
            //    else if (visualEffectsInput.AnimationType == ZeroitVisAnimEdit.GetAnimationType
            //                 .YLocationEffect)
            //    {
            //        mainControl_AnimationType_ComboBox.SelectedIndex = YLocationEffect;
            //    }
            //}
            //catch (Exception e)
            //{

            //    MessageBox.Show(e.Message);
            //} 
            #endregion

            #endregion

            #region Add Easing Enum to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string easingNames in Enum.GetNames(typeof(ZeroitVisAnimEdit.EasingFunctionTypes)))
            {
                mainControl_Easing_ComboBox.Items.Add(easingNames);

            }

            for (int i = 0; i < mainControl_Easing_ComboBox.Items.Count; i++)
            {
                if (visualEffectsInput.EasingType == (ZeroitVisAnimEdit.EasingFunctionTypes)Enum.Parse(typeof(ZeroitVisAnimEdit.EasingFunctionTypes), mainControl_Easing_ComboBox.Items[i].ToString()))
                {
                    mainControl_Easing_ComboBox.SelectedIndex = i;

                    

                }

            }
            #endregion

            #region Control

            foreach (Control controlNames in visualEffectsInput.Target.FindForm().Controls)
            {
                mainControl_Control_ComboBox.Items.Add(controlNames);

            }
            
            mainControl_Control_ComboBox.Items.Add(visualEffectsInput.Target.FindForm());


            for (int i = 0; i < mainControl_Control_ComboBox.Items.Count; i++)
            {
                if (visualEffectsInput.Target == (Control)(mainControl_Control_ComboBox.Items[i]))
                {
                    mainControl_Control_ComboBox.SelectedIndex = i;

                }

            }

            #endregion

            
            mainControl_Duration_Numeric.Value = visualEffectsInput.Duration;
            mainControl_Delay_Numeric.Value = visualEffectsInput.Delay;
            mainControl_Loops_Numeric.Value = visualEffectsInput.Loops;
            mainControl_ValueToReach_Numeric.Value = visualEffectsInput.ValueToReach;
            
            foldEffect_UserControl.fold_MaxWidth_Numeric.Value = visualEffectsInput.FoldSizes.MaximumSize.Width;
            foldEffect_UserControl.fold_MaxHeight_Numeric.Value = visualEffectsInput.FoldSizes.MaximumSize.Height;
            foldEffect_UserControl.fold_MinWidth_Numeric.Value = visualEffectsInput.FoldSizes.MinimumSize.Width;
            foldEffect_UserControl.fold_MinHeight_Numeric.Value = visualEffectsInput.FoldSizes.MinimumSize.Height;

            foldEffect_UserControl.fold_Animator.FoldSizes.MaximumSize = new Size(
                (int) visualEffectsInput.FoldSizes.MaximumSize.Width,
                (int) visualEffectsInput.FoldSizes.MaximumSize.Height);

            foldEffect_UserControl.fold_Animator.FoldSizes.MinimumSize = new Size(
                (int)visualEffectsInput.FoldSizes.MinimumSize.Width,
                (int)visualEffectsInput.FoldSizes.MinimumSize.Height);

            
            if (visualEffectsInput.Reverse == true)
            {
                mainControl_Reverse_Yes_RadioBtn.Checked = true;
                mainControl_Reverse_No_RadioBtn.Checked = false;
            }
            else
            {
                mainControl_Reverse_Yes_RadioBtn.Checked = false;
                mainControl_Reverse_No_RadioBtn.Checked = true;

            }

            #region Added Code for Various Animators

            #region Easing Values Retrievals

            bottomAnchoredHeightEffect_UserControl.bottomAnchored_Animator.EasingType = (ZeroitVisAnim.EasingFunctionTypes)visualEffectsInput.EasingType;
            colorChannelShiftEffect_UserControl.colorChannelShift_Animator.EasingType = (ZeroitVisAnim.EasingFunctionTypes)visualEffectsInput.EasingType;
            colorShiftEffect_UserControl.colorShift_Animator.EasingType = (ZeroitVisAnim.EasingFunctionTypes)visualEffectsInput.EasingType;
            controlFadeEffect_UserControl.controlFade_Animator.EasingType = (ZeroitVisAnim.EasingFunctionTypes)visualEffectsInput.EasingType;
            controlFadeEffect2_UserControl.controlFade2_Animator.EasingType = (ZeroitVisAnim.EasingFunctionTypes)visualEffectsInput.EasingType;
            foldEffect_UserControl.fold_Animator.EasingType = (ZeroitVisAnim.EasingFunctionTypes)visualEffectsInput.EasingType;
            fontSizeEffect_UserControl.fontSize_Animator.EasingType = (ZeroitVisAnim.EasingFunctionTypes)visualEffectsInput.EasingType;
            formFadeEffect_UserControl.formFade_Animator.EasingType = (ZeroitVisAnim.EasingFunctionTypes)visualEffectsInput.EasingType;
            horizontalFoldEffect_UserControl.horizontalFold_Animator.EasingType = (ZeroitVisAnim.EasingFunctionTypes)visualEffectsInput.EasingType;
            leftAnchoredWidthEffect_UserControl.leftAnchoredWidth_Animator.EasingType = (ZeroitVisAnim.EasingFunctionTypes)visualEffectsInput.EasingType;
            rightAnchoredWidthEffect_UserControl.rightAnchoredWidth_Animator.EasingType = (ZeroitVisAnim.EasingFunctionTypes)visualEffectsInput.EasingType;
            topAnchoredHeightEffect_UserControl.topAnchoredHeight_Animator.EasingType = (ZeroitVisAnim.EasingFunctionTypes)visualEffectsInput.EasingType;
            verticalFoldEffect_UserControl.verticalFold_Animator.EasingType = (ZeroitVisAnim.EasingFunctionTypes)visualEffectsInput.EasingType;
            xLocation_UserControl.xLocation_Animator.EasingType = (ZeroitVisAnim.EasingFunctionTypes)visualEffectsInput.EasingType;
            yLocation_UserControl.yLocation_Animator.EasingType = (ZeroitVisAnim.EasingFunctionTypes)visualEffectsInput.EasingType;


            colorChannelShiftEffect_UserControl.colorChann_RotatingCube_Animator.EasingType = (ZeroitVisAnim.EasingFunctionTypes)visualEffectsInput.EasingType;
            colorShiftEffect_UserControl.colorShift_rotatingCubeAnimator.EasingType = (ZeroitVisAnim.EasingFunctionTypes)visualEffectsInput.EasingType;

            #endregion

            #region Duration Values Retrievals

            bottomAnchoredHeightEffect_UserControl.bottomAnchored_Animator.Duration = visualEffectsInput.Duration;
            colorChannelShiftEffect_UserControl.colorChannelShift_Animator.Duration = visualEffectsInput.Duration;
            colorShiftEffect_UserControl.colorShift_Animator.Duration = visualEffectsInput.Duration;
            controlFadeEffect_UserControl.controlFade_Animator.Duration = visualEffectsInput.Duration;
            controlFadeEffect2_UserControl.controlFade2_Animator.Duration = visualEffectsInput.Duration;
            foldEffect_UserControl.fold_Animator.Duration = visualEffectsInput.Duration;
            fontSizeEffect_UserControl.fontSize_Animator.Duration = visualEffectsInput.Duration;
            formFadeEffect_UserControl.formFade_Animator.Duration = visualEffectsInput.Duration;
            horizontalFoldEffect_UserControl.horizontalFold_Animator.Duration = visualEffectsInput.Duration;
            leftAnchoredWidthEffect_UserControl.leftAnchoredWidth_Animator.Duration = visualEffectsInput.Duration;
            rightAnchoredWidthEffect_UserControl.rightAnchoredWidth_Animator.Duration = visualEffectsInput.Duration;
            topAnchoredHeightEffect_UserControl.topAnchoredHeight_Animator.Duration = visualEffectsInput.Duration;
            verticalFoldEffect_UserControl.verticalFold_Animator.Duration = visualEffectsInput.Duration;
            xLocation_UserControl.xLocation_Animator.Duration = visualEffectsInput.Duration;
            yLocation_UserControl.yLocation_Animator.Duration = visualEffectsInput.Duration;

            colorChannelShiftEffect_UserControl.colorChann_RotatingCube_Animator.Duration = visualEffectsInput.Duration;
            colorShiftEffect_UserControl.colorShift_rotatingCubeAnimator.Duration = visualEffectsInput.Duration;

            #endregion

            #region Delay Values Retrievals

            bottomAnchoredHeightEffect_UserControl.bottomAnchored_Animator.Delay = visualEffectsInput.Delay;
            colorChannelShiftEffect_UserControl.colorChannelShift_Animator.Delay = visualEffectsInput.Delay;
            colorShiftEffect_UserControl.colorShift_Animator.Delay = visualEffectsInput.Delay;
            controlFadeEffect_UserControl.controlFade_Animator.Delay = visualEffectsInput.Delay;
            controlFadeEffect2_UserControl.controlFade2_Animator.Delay = visualEffectsInput.Delay;
            foldEffect_UserControl.fold_Animator.Delay = visualEffectsInput.Delay;
            fontSizeEffect_UserControl.fontSize_Animator.Delay = visualEffectsInput.Delay;
            formFadeEffect_UserControl.formFade_Animator.Delay = visualEffectsInput.Delay;
            horizontalFoldEffect_UserControl.horizontalFold_Animator.Delay = visualEffectsInput.Delay;
            leftAnchoredWidthEffect_UserControl.leftAnchoredWidth_Animator.Delay = visualEffectsInput.Delay;
            rightAnchoredWidthEffect_UserControl.rightAnchoredWidth_Animator.Delay = visualEffectsInput.Delay;
            topAnchoredHeightEffect_UserControl.topAnchoredHeight_Animator.Delay = visualEffectsInput.Delay;
            verticalFoldEffect_UserControl.verticalFold_Animator.Delay = visualEffectsInput.Delay;
            xLocation_UserControl.xLocation_Animator.Delay = visualEffectsInput.Delay;
            yLocation_UserControl.yLocation_Animator.Delay = visualEffectsInput.Delay;


            colorChannelShiftEffect_UserControl.colorChann_RotatingCube_Animator.Delay = visualEffectsInput.Delay;
            colorShiftEffect_UserControl.colorShift_rotatingCubeAnimator.Delay = visualEffectsInput.Delay;

            #endregion

            #region Loops Values Retrievals

            bottomAnchoredHeightEffect_UserControl.bottomAnchored_Animator.Loops = visualEffectsInput.Loops;
            colorChannelShiftEffect_UserControl.colorChannelShift_Animator.Loops = visualEffectsInput.Loops;
            colorShiftEffect_UserControl.colorShift_Animator.Loops = visualEffectsInput.Loops;
            controlFadeEffect_UserControl.controlFade_Animator.Loops = visualEffectsInput.Loops;
            controlFadeEffect2_UserControl.controlFade2_Animator.Loops = visualEffectsInput.Loops;
            foldEffect_UserControl.fold_Animator.Loops = visualEffectsInput.Loops;
            fontSizeEffect_UserControl.fontSize_Animator.Loops = visualEffectsInput.Loops;
            formFadeEffect_UserControl.formFade_Animator.Loops = visualEffectsInput.Loops;
            horizontalFoldEffect_UserControl.horizontalFold_Animator.Loops = visualEffectsInput.Loops;
            leftAnchoredWidthEffect_UserControl.leftAnchoredWidth_Animator.Loops = visualEffectsInput.Loops;
            rightAnchoredWidthEffect_UserControl.rightAnchoredWidth_Animator.Loops = visualEffectsInput.Loops;
            topAnchoredHeightEffect_UserControl.topAnchoredHeight_Animator.Loops = visualEffectsInput.Loops;
            verticalFoldEffect_UserControl.verticalFold_Animator.Loops = visualEffectsInput.Loops;
            xLocation_UserControl.xLocation_Animator.Loops = visualEffectsInput.Loops;
            yLocation_UserControl.yLocation_Animator.Loops = visualEffectsInput.Loops;

            colorChannelShiftEffect_UserControl.colorChann_RotatingCube_Animator.Loops = visualEffectsInput.Loops;
            colorShiftEffect_UserControl.colorShift_rotatingCubeAnimator.Loops = visualEffectsInput.Loops;


            #endregion

            #region ValueToReach Values Retrievals

            bottomAnchoredHeightEffect_UserControl.bottomAnchored_Animator.ValueToReach = visualEffectsInput.ValueToReach;
            colorChannelShiftEffect_UserControl.colorChannelShift_Animator.ValueToReach = visualEffectsInput.ValueToReach;
            colorShiftEffect_UserControl.colorShift_Animator.ValueToReach = visualEffectsInput.ValueToReach;
            controlFadeEffect_UserControl.controlFade_Animator.ValueToReach = visualEffectsInput.ValueToReach;
            controlFadeEffect2_UserControl.controlFade2_Animator.ValueToReach = visualEffectsInput.ValueToReach;
            foldEffect_UserControl.fold_Animator.ValueToReach = visualEffectsInput.ValueToReach;
            fontSizeEffect_UserControl.fontSize_Animator.ValueToReach = visualEffectsInput.ValueToReach;
            formFadeEffect_UserControl.formFade_Animator.ValueToReach = visualEffectsInput.ValueToReach;
            horizontalFoldEffect_UserControl.horizontalFold_Animator.ValueToReach = visualEffectsInput.ValueToReach;
            leftAnchoredWidthEffect_UserControl.leftAnchoredWidth_Animator.ValueToReach = visualEffectsInput.ValueToReach;
            rightAnchoredWidthEffect_UserControl.rightAnchoredWidth_Animator.ValueToReach = visualEffectsInput.ValueToReach;
            topAnchoredHeightEffect_UserControl.topAnchoredHeight_Animator.ValueToReach = visualEffectsInput.ValueToReach;
            verticalFoldEffect_UserControl.verticalFold_Animator.ValueToReach = visualEffectsInput.ValueToReach;
            xLocation_UserControl.xLocation_Animator.ValueToReach = visualEffectsInput.ValueToReach;
            yLocation_UserControl.yLocation_Animator.ValueToReach = visualEffectsInput.ValueToReach;

            colorChannelShiftEffect_UserControl.colorChann_RotatingCube_Animator.ValueToReach = visualEffectsInput.ValueToReach;
            colorShiftEffect_UserControl.colorShift_rotatingCubeAnimator.ValueToReach = visualEffectsInput.ValueToReach;


            #endregion

            #region Reverse Values Retrievals

            bottomAnchoredHeightEffect_UserControl.bottomAnchored_Animator.Reverse = visualEffectsInput.Reverse;
            colorChannelShiftEffect_UserControl.colorChannelShift_Animator.Reverse = visualEffectsInput.Reverse;
            colorShiftEffect_UserControl.colorShift_Animator.Reverse = visualEffectsInput.Reverse;
            controlFadeEffect_UserControl.controlFade_Animator.Reverse = visualEffectsInput.Reverse;
            controlFadeEffect2_UserControl.controlFade2_Animator.Reverse = visualEffectsInput.Reverse;
            foldEffect_UserControl.fold_Animator.Reverse = visualEffectsInput.Reverse;
            fontSizeEffect_UserControl.fontSize_Animator.Reverse = visualEffectsInput.Reverse;
            formFadeEffect_UserControl.formFade_Animator.Reverse = visualEffectsInput.Reverse;
            horizontalFoldEffect_UserControl.horizontalFold_Animator.Reverse = visualEffectsInput.Reverse;
            leftAnchoredWidthEffect_UserControl.leftAnchoredWidth_Animator.Reverse = visualEffectsInput.Reverse;
            rightAnchoredWidthEffect_UserControl.rightAnchoredWidth_Animator.Reverse = visualEffectsInput.Reverse;
            topAnchoredHeightEffect_UserControl.topAnchoredHeight_Animator.Reverse = visualEffectsInput.Reverse;
            verticalFoldEffect_UserControl.verticalFold_Animator.Reverse = visualEffectsInput.Reverse;
            xLocation_UserControl.xLocation_Animator.Reverse = visualEffectsInput.Reverse;
            yLocation_UserControl.yLocation_Animator.Reverse = visualEffectsInput.Reverse;

            colorChannelShiftEffect_UserControl.colorChann_RotatingCube_Animator.Reverse = visualEffectsInput.Reverse;
            colorShiftEffect_UserControl.colorShift_rotatingCubeAnimator.Reverse = visualEffectsInput.Reverse;


            #endregion

            #endregion


        }


        /// <summary>
        /// Sets the bottom anchored height effect retrieved values.
        /// </summary>
        /// <param name="visualEffectsInput">The visual effects input.</param>
        private void Set_BottomAnchoredHeightEffect_Retrieved_Values(VisualEffectsInput visualEffectsInput)
        {
            visualEffectsInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;
            visualEffectsInput.EasingType = (ZeroitVisAnimEdit.EasingFunctionTypes)Enum.Parse(typeof(ZeroitVisAnimEdit.EasingFunctionTypes), mainControl_Easing_ComboBox.SelectedItem.ToString());

            visualEffectsInput.AnimationType =
                (ZeroitVisAnimEdit.GetAnimationType) Enum.Parse(
                    typeof(ZeroitVisAnimEdit.GetAnimationType),
                    mainControl_AnimationType_ComboBox.SelectedItem.ToString());

            visualEffectsInput.Duration = (int)mainControl_Duration_Numeric.Value;
            visualEffectsInput.Delay = (int)mainControl_Delay_Numeric.Value;
            visualEffectsInput.Loops = (int)mainControl_Loops_Numeric.Value;
            visualEffectsInput.ValueToReach = (int)mainControl_ValueToReach_Numeric.Value;

            if (mainControl_Reverse_Yes_RadioBtn.Checked)
            {
                visualEffectsInput.Reverse = true;
            }
            else
            {
                visualEffectsInput.Reverse = false;
            }

        }

        /// <summary>
        /// Sets the color channel shift effect retrieved values.
        /// </summary>
        /// <param name="visualEffectsInput">The visual effects input.</param>
        private void Set_ColorChannelShiftEffect_Retrieved_Values(VisualEffectsInput visualEffectsInput)
        {
            visualEffectsInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            visualEffectsInput.EasingType = (ZeroitVisAnimEdit.EasingFunctionTypes)Enum.Parse(typeof(ZeroitVisAnimEdit.EasingFunctionTypes), mainControl_Easing_ComboBox.SelectedItem.ToString());

            visualEffectsInput.AnimationType =
                (ZeroitVisAnimEdit.GetAnimationType)Enum.Parse(
                    typeof(ZeroitVisAnimEdit.GetAnimationType),
                    mainControl_AnimationType_ComboBox.SelectedItem.ToString());

            visualEffectsInput.Duration = (int)mainControl_Duration_Numeric.Value;
            visualEffectsInput.Delay = (int)mainControl_Delay_Numeric.Value;
            visualEffectsInput.Loops = (int)mainControl_Loops_Numeric.Value;
            visualEffectsInput.ValueToReach = (int)mainControl_ValueToReach_Numeric.Value;

            if (mainControl_Reverse_Yes_RadioBtn.Checked)
            {
                visualEffectsInput.Reverse = true;
            }
            else
            {
                visualEffectsInput.Reverse = false;
            }
        }

        /// <summary>
        /// Sets the color shift effect retrieved values.
        /// </summary>
        /// <param name="visualEffectsInput">The visual effects input.</param>
        private void Set_ColorShiftEffect_Retrieved_Values(VisualEffectsInput visualEffectsInput)
        {
            visualEffectsInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            visualEffectsInput.EasingType = (ZeroitVisAnimEdit.EasingFunctionTypes)Enum.Parse(typeof(ZeroitVisAnimEdit.EasingFunctionTypes), mainControl_Easing_ComboBox.SelectedItem.ToString());

            visualEffectsInput.AnimationType =
                (ZeroitVisAnimEdit.GetAnimationType)Enum.Parse(
                    typeof(ZeroitVisAnimEdit.GetAnimationType),
                    mainControl_AnimationType_ComboBox.SelectedItem.ToString());

            visualEffectsInput.Duration = (int)mainControl_Duration_Numeric.Value;
            visualEffectsInput.Delay = (int)mainControl_Delay_Numeric.Value;
            visualEffectsInput.Loops = (int)mainControl_Loops_Numeric.Value;
            visualEffectsInput.ValueToReach = (int)mainControl_ValueToReach_Numeric.Value;

            if (mainControl_Reverse_Yes_RadioBtn.Checked)
            {
                visualEffectsInput.Reverse = true;
            }
            else
            {
                visualEffectsInput.Reverse = false;
            }

        }

        /// <summary>
        /// Sets the control fade effect retrieved values.
        /// </summary>
        /// <param name="visualEffectsInput">The visual effects input.</param>
        private void Set_ControlFadeEffect_Retrieved_Values(VisualEffectsInput visualEffectsInput)
        {
            visualEffectsInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            visualEffectsInput.EasingType = (ZeroitVisAnimEdit.EasingFunctionTypes)Enum.Parse(typeof(ZeroitVisAnimEdit.EasingFunctionTypes), mainControl_Easing_ComboBox.SelectedItem.ToString());

            visualEffectsInput.AnimationType =
                (ZeroitVisAnimEdit.GetAnimationType)Enum.Parse(
                    typeof(ZeroitVisAnimEdit.GetAnimationType),
                    mainControl_AnimationType_ComboBox.SelectedItem.ToString());

            visualEffectsInput.Duration = (int)mainControl_Duration_Numeric.Value;
            visualEffectsInput.Delay = (int)mainControl_Delay_Numeric.Value;
            visualEffectsInput.Loops = (int)mainControl_Loops_Numeric.Value;
            visualEffectsInput.ValueToReach = (int)mainControl_ValueToReach_Numeric.Value;

            if (mainControl_Reverse_Yes_RadioBtn.Checked)
            {
                visualEffectsInput.Reverse = true;
            }
            else
            {
                visualEffectsInput.Reverse = false;
            }
        }

        /// <summary>
        /// Sets the control fade effect2 retrieved values.
        /// </summary>
        /// <param name="visualEffectsInput">The visual effects input.</param>
        private void Set_ControlFadeEffect2_Retrieved_Values(VisualEffectsInput visualEffectsInput)
        {
            visualEffectsInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            visualEffectsInput.EasingType = (ZeroitVisAnimEdit.EasingFunctionTypes)Enum.Parse(typeof(ZeroitVisAnimEdit.EasingFunctionTypes), mainControl_Easing_ComboBox.SelectedItem.ToString());

            visualEffectsInput.AnimationType =
                (ZeroitVisAnimEdit.GetAnimationType)Enum.Parse(
                    typeof(ZeroitVisAnimEdit.GetAnimationType),
                    mainControl_AnimationType_ComboBox.SelectedItem.ToString());

            visualEffectsInput.Duration = (int)mainControl_Duration_Numeric.Value;
            visualEffectsInput.Delay = (int)mainControl_Delay_Numeric.Value;
            visualEffectsInput.Loops = (int)mainControl_Loops_Numeric.Value;
            visualEffectsInput.ValueToReach = (int)mainControl_ValueToReach_Numeric.Value;

            if (mainControl_Reverse_Yes_RadioBtn.Checked)
            {
                visualEffectsInput.Reverse = true;
            }
            else
            {
                visualEffectsInput.Reverse = false;
            }
        }

        /// <summary>
        /// Sets the form fade effect retrieved values.
        /// </summary>
        /// <param name="visualEffectsInput">The visual effects input.</param>
        private void Set_FormFadeEffect_Retrieved_Values(VisualEffectsInput visualEffectsInput)
        {
            visualEffectsInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            visualEffectsInput.EasingType = (ZeroitVisAnimEdit.EasingFunctionTypes)Enum.Parse(typeof(ZeroitVisAnimEdit.EasingFunctionTypes), mainControl_Easing_ComboBox.SelectedItem.ToString());

            visualEffectsInput.AnimationType =
                (ZeroitVisAnimEdit.GetAnimationType)Enum.Parse(
                    typeof(ZeroitVisAnimEdit.GetAnimationType),
                    mainControl_AnimationType_ComboBox.SelectedItem.ToString());

            visualEffectsInput.Duration = (int)mainControl_Duration_Numeric.Value;
            visualEffectsInput.Delay = (int)mainControl_Delay_Numeric.Value;
            visualEffectsInput.Loops = (int)mainControl_Loops_Numeric.Value;
            visualEffectsInput.ValueToReach = (int)mainControl_ValueToReach_Numeric.Value;

            if (mainControl_Reverse_Yes_RadioBtn.Checked)
            {
                visualEffectsInput.Reverse = true;
            }
            else
            {
                visualEffectsInput.Reverse = false;
            }
        }

        /// <summary>
        /// Sets the font size effect retrieved values.
        /// </summary>
        /// <param name="visualEffectsInput">The visual effects input.</param>
        private void Set_FontSizeEffect_Retrieved_Values(VisualEffectsInput visualEffectsInput)
        {
            visualEffectsInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            visualEffectsInput.EasingType = (ZeroitVisAnimEdit.EasingFunctionTypes)Enum.Parse(typeof(ZeroitVisAnimEdit.EasingFunctionTypes), mainControl_Easing_ComboBox.SelectedItem.ToString());

            visualEffectsInput.AnimationType =
                (ZeroitVisAnimEdit.GetAnimationType)Enum.Parse(
                    typeof(ZeroitVisAnimEdit.GetAnimationType),
                    mainControl_AnimationType_ComboBox.SelectedItem.ToString());

            visualEffectsInput.Duration = (int)mainControl_Duration_Numeric.Value;
            visualEffectsInput.Delay = (int)mainControl_Delay_Numeric.Value;
            visualEffectsInput.Loops = (int)mainControl_Loops_Numeric.Value;
            visualEffectsInput.ValueToReach = (int)mainControl_ValueToReach_Numeric.Value;

            if (mainControl_Reverse_Yes_RadioBtn.Checked)
            {
                visualEffectsInput.Reverse = true;
            }
            else
            {
                visualEffectsInput.Reverse = false;
            }
        }

        /// <summary>
        /// Sets the fold effect retrieved values.
        /// </summary>
        /// <param name="visualEffectsInput">The visual effects input.</param>
        private void Set_FoldEffect_Retrieved_Values(VisualEffectsInput visualEffectsInput)
        {
            visualEffectsInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            visualEffectsInput.EasingType = (ZeroitVisAnimEdit.EasingFunctionTypes)Enum.Parse(typeof(ZeroitVisAnimEdit.EasingFunctionTypes), mainControl_Easing_ComboBox.SelectedItem.ToString());

            visualEffectsInput.AnimationType =
                (ZeroitVisAnimEdit.GetAnimationType)Enum.Parse(
                    typeof(ZeroitVisAnimEdit.GetAnimationType),
                    mainControl_AnimationType_ComboBox.SelectedItem.ToString());

            visualEffectsInput.Duration = (int)mainControl_Duration_Numeric.Value;
            visualEffectsInput.Delay = (int)mainControl_Delay_Numeric.Value;
            visualEffectsInput.Loops = (int)mainControl_Loops_Numeric.Value;
            visualEffectsInput.ValueToReach = (int)mainControl_ValueToReach_Numeric.Value;

            visualEffectsInput.FoldSizes.MaximumSize = new Size(
                (int) foldEffect_UserControl.fold_MaxWidth_Numeric.Value,
                (int) foldEffect_UserControl.fold_MaxHeight_Numeric.Value);

            visualEffectsInput.FoldSizes.MinimumSize = new Size(
                (int)foldEffect_UserControl.fold_MinWidth_Numeric.Value,
                (int)foldEffect_UserControl.fold_MinHeight_Numeric.Value);


            if (mainControl_Reverse_Yes_RadioBtn.Checked)
            {
                visualEffectsInput.Reverse = true;
            }

            else
            {
                visualEffectsInput.Reverse = false;
            }

        }

        /// <summary>
        /// Sets the horizontal fold effect retrieved values.
        /// </summary>
        /// <param name="visualEffectsInput">The visual effects input.</param>
        private void Set_HorizontalFoldEffect_Retrieved_Values(VisualEffectsInput visualEffectsInput)
        {
            visualEffectsInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            visualEffectsInput.EasingType = (ZeroitVisAnimEdit.EasingFunctionTypes)Enum.Parse(typeof(ZeroitVisAnimEdit.EasingFunctionTypes), mainControl_Easing_ComboBox.SelectedItem.ToString());

            visualEffectsInput.AnimationType =
                (ZeroitVisAnimEdit.GetAnimationType)Enum.Parse(
                    typeof(ZeroitVisAnimEdit.GetAnimationType),
                    mainControl_AnimationType_ComboBox.SelectedItem.ToString());

            visualEffectsInput.Duration = (int)mainControl_Duration_Numeric.Value;
            visualEffectsInput.Delay = (int)mainControl_Delay_Numeric.Value;
            visualEffectsInput.Loops = (int)mainControl_Loops_Numeric.Value;
            visualEffectsInput.ValueToReach = (int)mainControl_ValueToReach_Numeric.Value;

            if (mainControl_Reverse_Yes_RadioBtn.Checked)
            {
                visualEffectsInput.Reverse = true;
            }
            else
            {
                visualEffectsInput.Reverse = false;
            }

        }

        /// <summary>
        /// Sets the left anchored width effect retrieved values.
        /// </summary>
        /// <param name="visualEffectsInput">The visual effects input.</param>
        private void Set_LeftAnchoredWidthEffect_Retrieved_Values(VisualEffectsInput visualEffectsInput)
        {
            visualEffectsInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            visualEffectsInput.EasingType = (ZeroitVisAnimEdit.EasingFunctionTypes)Enum.Parse(typeof(ZeroitVisAnimEdit.EasingFunctionTypes), mainControl_Easing_ComboBox.SelectedItem.ToString());

            visualEffectsInput.AnimationType =
                (ZeroitVisAnimEdit.GetAnimationType)Enum.Parse(
                    typeof(ZeroitVisAnimEdit.GetAnimationType),
                    mainControl_AnimationType_ComboBox.SelectedItem.ToString());

            visualEffectsInput.Duration = (int)mainControl_Duration_Numeric.Value;
            visualEffectsInput.Delay = (int)mainControl_Delay_Numeric.Value;
            visualEffectsInput.Loops = (int)mainControl_Loops_Numeric.Value;
            visualEffectsInput.ValueToReach = (int)mainControl_ValueToReach_Numeric.Value;

            if (mainControl_Reverse_Yes_RadioBtn.Checked)
            {
                visualEffectsInput.Reverse = true;
            }
            else
            {
                visualEffectsInput.Reverse = false;
            }
        }

        /// <summary>
        /// Sets the right anchored width effect retrieved values.
        /// </summary>
        /// <param name="visualEffectsInput">The visual effects input.</param>
        private void Set_RightAnchoredWidthEffect_Retrieved_Values(VisualEffectsInput visualEffectsInput)
        {
            visualEffectsInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            visualEffectsInput.EasingType = (ZeroitVisAnimEdit.EasingFunctionTypes)Enum.Parse(typeof(ZeroitVisAnimEdit.EasingFunctionTypes), mainControl_Easing_ComboBox.SelectedItem.ToString());

            visualEffectsInput.AnimationType =
                (ZeroitVisAnimEdit.GetAnimationType)Enum.Parse(
                    typeof(ZeroitVisAnimEdit.GetAnimationType),
                    mainControl_AnimationType_ComboBox.SelectedItem.ToString());

            visualEffectsInput.Duration = (int)mainControl_Duration_Numeric.Value;
            visualEffectsInput.Delay = (int)mainControl_Delay_Numeric.Value;
            visualEffectsInput.Loops = (int)mainControl_Loops_Numeric.Value;
            visualEffectsInput.ValueToReach = (int)mainControl_ValueToReach_Numeric.Value;

            if (mainControl_Reverse_Yes_RadioBtn.Checked)
            {
                visualEffectsInput.Reverse = true;
            }
            else
            {
                visualEffectsInput.Reverse = false;
            }
        }

        /// <summary>
        /// Sets the top anchored height effect retrieved values.
        /// </summary>
        /// <param name="visualEffectsInput">The visual effects input.</param>
        private void Set_TopAnchoredHeightEffect_Retrieved_Values(VisualEffectsInput visualEffectsInput)
        {
            visualEffectsInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            visualEffectsInput.EasingType = (ZeroitVisAnimEdit.EasingFunctionTypes)Enum.Parse(typeof(ZeroitVisAnimEdit.EasingFunctionTypes), mainControl_Easing_ComboBox.SelectedItem.ToString());

            visualEffectsInput.AnimationType =
                (ZeroitVisAnimEdit.GetAnimationType)Enum.Parse(
                    typeof(ZeroitVisAnimEdit.GetAnimationType),
                    mainControl_AnimationType_ComboBox.SelectedItem.ToString());

            visualEffectsInput.Duration = (int)mainControl_Duration_Numeric.Value;
            visualEffectsInput.Delay = (int)mainControl_Delay_Numeric.Value;
            visualEffectsInput.Loops = (int)mainControl_Loops_Numeric.Value;
            visualEffectsInput.ValueToReach = (int)mainControl_ValueToReach_Numeric.Value;

            if (mainControl_Reverse_Yes_RadioBtn.Checked)
            {
                visualEffectsInput.Reverse = true;
            }
            else
            {
                visualEffectsInput.Reverse = false;
            }
        }

        /// <summary>
        /// Sets the vertical fold effect retrieved values.
        /// </summary>
        /// <param name="visualEffectsInput">The visual effects input.</param>
        private void Set_VerticalFoldEffect_Retrieved_Values(VisualEffectsInput visualEffectsInput)
        {
            visualEffectsInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            visualEffectsInput.EasingType = (ZeroitVisAnimEdit.EasingFunctionTypes)Enum.Parse(typeof(ZeroitVisAnimEdit.EasingFunctionTypes), mainControl_Easing_ComboBox.SelectedItem.ToString());

            visualEffectsInput.AnimationType =
                (ZeroitVisAnimEdit.GetAnimationType)Enum.Parse(
                    typeof(ZeroitVisAnimEdit.GetAnimationType),
                    mainControl_AnimationType_ComboBox.SelectedItem.ToString());

            visualEffectsInput.Duration = (int)mainControl_Duration_Numeric.Value;
            visualEffectsInput.Delay = (int)mainControl_Delay_Numeric.Value;
            visualEffectsInput.Loops = (int)mainControl_Loops_Numeric.Value;
            visualEffectsInput.ValueToReach = (int)mainControl_ValueToReach_Numeric.Value;

            if (mainControl_Reverse_Yes_RadioBtn.Checked)
            {
                visualEffectsInput.Reverse = true;
            }
            else
            {
                visualEffectsInput.Reverse = false;
            }
        }

        /// <summary>
        /// Sets the x location effect retrieved values.
        /// </summary>
        /// <param name="visualEffectsInput">The visual effects input.</param>
        private void Set_XLocationEffect_Retrieved_Values(VisualEffectsInput visualEffectsInput)
        {
            visualEffectsInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            visualEffectsInput.EasingType = (ZeroitVisAnimEdit.EasingFunctionTypes)Enum.Parse(typeof(ZeroitVisAnimEdit.EasingFunctionTypes), mainControl_Easing_ComboBox.SelectedItem.ToString());

            visualEffectsInput.AnimationType =
                (ZeroitVisAnimEdit.GetAnimationType)Enum.Parse(
                    typeof(ZeroitVisAnimEdit.GetAnimationType),
                    mainControl_AnimationType_ComboBox.SelectedItem.ToString());

            visualEffectsInput.Duration = (int)mainControl_Duration_Numeric.Value;
            visualEffectsInput.Delay = (int)mainControl_Delay_Numeric.Value;
            visualEffectsInput.Loops = (int)mainControl_Loops_Numeric.Value;
            visualEffectsInput.ValueToReach = (int)mainControl_ValueToReach_Numeric.Value;

            if (mainControl_Reverse_Yes_RadioBtn.Checked)
            {
                visualEffectsInput.Reverse = true;
            }
            else
            {
                visualEffectsInput.Reverse = false;
            }
        }

        /// <summary>
        /// Sets the y location effect retrieved values.
        /// </summary>
        /// <param name="visualEffectsInput">The visual effects input.</param>
        private void Set_YLocationEffect_Retrieved_Values(VisualEffectsInput visualEffectsInput)
        {
            visualEffectsInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            visualEffectsInput.EasingType = (ZeroitVisAnimEdit.EasingFunctionTypes)Enum.Parse(typeof(ZeroitVisAnimEdit.EasingFunctionTypes), mainControl_Easing_ComboBox.SelectedItem.ToString());

            visualEffectsInput.AnimationType =
                (ZeroitVisAnimEdit.GetAnimationType)Enum.Parse(
                    typeof(ZeroitVisAnimEdit.GetAnimationType),
                    mainControl_AnimationType_ComboBox.SelectedItem.ToString());

            visualEffectsInput.Duration = (int)mainControl_Duration_Numeric.Value;
            visualEffectsInput.Delay = (int)mainControl_Delay_Numeric.Value;
            visualEffectsInput.Loops = (int)mainControl_Loops_Numeric.Value;
            visualEffectsInput.ValueToReach = (int)mainControl_ValueToReach_Numeric.Value;

            if (mainControl_Reverse_Yes_RadioBtn.Checked)
            {
                visualEffectsInput.Reverse = true;
            }
            else
            {
                visualEffectsInput.Reverse = false;
            }
        }


        #endregion

        #region Private Events

        /// <summary>
        /// Animations the property changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AnimationPropertyChanged(object sender, EventArgs e)
        {

            
            thematic1501.Controls.Add(bottomAnchoredHeightEffect_UserControl);
            thematic1501.Controls.Add(colorChannelShiftEffect_UserControl);
            thematic1501.Controls.Add(colorShiftEffect_UserControl);
            thematic1501.Controls.Add(controlFadeEffect_UserControl);
            thematic1501.Controls.Add(controlFadeEffect2_UserControl);
            thematic1501.Controls.Add(foldEffect_UserControl);
            thematic1501.Controls.Add(fontSizeEffect_UserControl);
            thematic1501.Controls.Add(formFadeEffect_UserControl);
            thematic1501.Controls.Add(horizontalFoldEffect_UserControl);
            thematic1501.Controls.Add(leftAnchoredWidthEffect_UserControl);
            thematic1501.Controls.Add(rightAnchoredWidthEffect_UserControl);
            thematic1501.Controls.Add(topAnchoredHeightEffect_UserControl);
            thematic1501.Controls.Add(verticalFoldEffect_UserControl);
            thematic1501.Controls.Add(xLocation_UserControl);
            thematic1501.Controls.Add(yLocation_UserControl);

            bottomAnchoredHeightEffect_UserControl.Visible = false;
            colorChannelShiftEffect_UserControl.Visible = false;
            colorShiftEffect_UserControl.Visible = false;
            controlFadeEffect_UserControl.Visible = false;
            controlFadeEffect2_UserControl.Visible = false;
            foldEffect_UserControl.Visible = false;
            fontSizeEffect_UserControl.Visible = false;
            formFadeEffect_UserControl.Visible = false;
            horizontalFoldEffect_UserControl.Visible = false;
            leftAnchoredWidthEffect_UserControl.Visible = false;
            rightAnchoredWidthEffect_UserControl.Visible = false;
            topAnchoredHeightEffect_UserControl.Visible = false;
            verticalFoldEffect_UserControl.Visible = false;
            xLocation_UserControl.Visible = false;
            yLocation_UserControl.Visible = false;

            bottomAnchoredHeightEffect_UserControl.Hide();
            colorChannelShiftEffect_UserControl.Hide();
            colorShiftEffect_UserControl.Hide();
            controlFadeEffect_UserControl.Hide();
            controlFadeEffect2_UserControl.Hide();
            foldEffect_UserControl.Hide();
            fontSizeEffect_UserControl.Hide();
            formFadeEffect_UserControl.Hide();
            horizontalFoldEffect_UserControl.Hide();
            leftAnchoredWidthEffect_UserControl.Hide();
            rightAnchoredWidthEffect_UserControl.Hide();
            topAnchoredHeightEffect_UserControl.Hide();
            verticalFoldEffect_UserControl.Hide();
            xLocation_UserControl.Hide();
            yLocation_UserControl.Hide();

            warning_Label.Visible = false;

            animationName_Label.Text = mainControl_AnimationType_ComboBox.SelectedItem.ToString() + " Animation";


            if (mainControl_AnimationType_ComboBox.SelectedIndex ==
                (int)ZeroitVisAnimEdit.GetAnimationType.BottomAnchoredHeightEffect)
            {
                bottomAnchoredHeightEffect_UserControl.Visible = true;
                bottomAnchoredHeightEffect_UserControl.Location = new Point(449, 59);

                bottomAnchoredHeightEffect_UserControl.SendToBack();

                WarningLabelRemoved();
            }

            else if (mainControl_AnimationType_ComboBox.SelectedIndex ==
                     (int) ZeroitVisAnimEdit.GetAnimationType.ColorChannelShiftEffect)
            {
                colorChannelShiftEffect_UserControl.Visible = true;
                colorChannelShiftEffect_UserControl.Location = new Point(449, 59);

                mainControl_ValueToReach_Numeric.Maximum = 255;
                mainControl_ValueToReach_Numeric.Minimum = 0;

                info.ToolTipTitle = "ColorChannel Maximum and Minimum ";
                info.Show("Maximum = 255 and Minimum = 0 . Setting values above and below will raise an exception",
                    mainControl_ValueToReach_Numeric);
                info.ToolTipIcon = ToolTipIcon.Warning;


            }


            else if (mainControl_AnimationType_ComboBox.SelectedIndex ==
                     (int)ZeroitVisAnimEdit.GetAnimationType.ColorShiftEffect)
            {
                colorShiftEffect_UserControl.Visible = true;
                colorShiftEffect_UserControl.Location = new Point(449, 59);

                mainControl_ValueToReach_Numeric.Maximum = -1;
                mainControl_ValueToReach_Numeric.Minimum = -255;

                info.ToolTipTitle = "ColorShift Maximum and Minimum ";
                info.Show("Maximum = -1 and Minimum = -255 . Setting values above and below will raise an exception",
                    mainControl_ValueToReach_Numeric);
                info.ToolTipIcon = ToolTipIcon.Warning;

            }


            else if (mainControl_AnimationType_ComboBox.SelectedIndex ==
                     (int)ZeroitVisAnimEdit.GetAnimationType.ControlFadeEffect)
            {
                controlFadeEffect_UserControl.Visible = true;
                controlFadeEffect_UserControl.Location = new Point(449, 59);

                mainControl_ValueToReach_Numeric.Maximum = 100;
                mainControl_ValueToReach_Numeric.Minimum = 0;

                info.ToolTipTitle = "ControlFade Maximum and Minimum ";
                info.Show("Maximum = 100 and Minimum = 0 . Setting values above and below will raise an exception",
                    mainControl_ValueToReach_Numeric);
                info.ToolTipIcon = ToolTipIcon.Warning;
            }


            else if (mainControl_AnimationType_ComboBox.SelectedIndex ==
                     (int)ZeroitVisAnimEdit.GetAnimationType.ControlFadeEffect2)
            {
                controlFadeEffect2_UserControl.Visible = true;
                controlFadeEffect2_UserControl.Location = new Point(449, 59);

                mainControl_ValueToReach_Numeric.Maximum = 100;
                mainControl_ValueToReach_Numeric.Minimum = 0;

                info.ToolTipTitle = "ControlFade2 Maximum and Minimum ";
                info.Show("Maximum = 100 and Minimum = 0 . Setting values above and below will raise an exception",
                    mainControl_ValueToReach_Numeric);
                info.ToolTipIcon = ToolTipIcon.Warning;

                WarningLabelCreated();
            }


            else if (mainControl_AnimationType_ComboBox.SelectedIndex ==
                     (int)ZeroitVisAnimEdit.GetAnimationType.FoldEffect)
            {
                foldEffect_UserControl.Visible = true;
                foldEffect_UserControl.Location = new Point(449, 59);

                mainControl_ValueToReach_Numeric.Maximum = 100000;
                mainControl_ValueToReach_Numeric.Minimum = 10000;

                info.ToolTipTitle = "Fold Maximum and Minimum ";
                info.Show("Maximum = 100000 and Minimum = 10000 . Setting values above and below will raise an exception",
                    mainControl_ValueToReach_Numeric);

            }


            else if (mainControl_AnimationType_ComboBox.SelectedIndex ==
                     (int)ZeroitVisAnimEdit.GetAnimationType.FontSizeEffect)
            {
                fontSizeEffect_UserControl.Visible = true;
                fontSizeEffect_UserControl.Location = new Point(449, 59);

                mainControl_ValueToReach_Numeric.Minimum = 0;
            }


            else if (mainControl_AnimationType_ComboBox.SelectedIndex ==
                     (int)ZeroitVisAnimEdit.GetAnimationType.FormFadeEffect)
            {
                formFadeEffect_UserControl.Visible = true;
                formFadeEffect_UserControl.Location = new Point(449, 59);

                mainControl_ValueToReach_Numeric.Minimum = 0;
            }


            else if (mainControl_AnimationType_ComboBox.SelectedIndex ==
                     (int)ZeroitVisAnimEdit.GetAnimationType.HorizontalFoldEffect)
            {
                horizontalFoldEffect_UserControl.Visible = true;
                horizontalFoldEffect_UserControl.Location = new Point(449, 59);

                mainControl_ValueToReach_Numeric.Minimum = 0;
            }


            else if (mainControl_AnimationType_ComboBox.SelectedIndex ==
                     (int)ZeroitVisAnimEdit.GetAnimationType.LeftAnchoredWidthEffect)
            {
                leftAnchoredWidthEffect_UserControl.Visible = true;
                leftAnchoredWidthEffect_UserControl.Location = new Point(449, 59);

                mainControl_ValueToReach_Numeric.Minimum = 0;
            }

            else if (mainControl_AnimationType_ComboBox.SelectedIndex ==
                     (int)ZeroitVisAnimEdit.GetAnimationType.RightAnchoredWidthEffect)
            {
                rightAnchoredWidthEffect_UserControl.Visible = true;
                rightAnchoredWidthEffect_UserControl.Location = new Point(449, 59);

                mainControl_ValueToReach_Numeric.Minimum = 0;
            }

            else if (mainControl_AnimationType_ComboBox.SelectedIndex ==
                     (int)ZeroitVisAnimEdit.GetAnimationType.TopAnchoredHeightEffect)
            {
                topAnchoredHeightEffect_UserControl.Visible = true;
                topAnchoredHeightEffect_UserControl.Location = new Point(449, 59);

                mainControl_ValueToReach_Numeric.Minimum = 0;
            }

            else if (mainControl_AnimationType_ComboBox.SelectedIndex ==
                     (int)ZeroitVisAnimEdit.GetAnimationType.VerticalFoldEffect)
            {
                verticalFoldEffect_UserControl.Visible = true;
                verticalFoldEffect_UserControl.Location = new Point(449, 59);

                mainControl_ValueToReach_Numeric.Minimum = 0;
            }

            else if (mainControl_AnimationType_ComboBox.SelectedIndex ==
                     (int)ZeroitVisAnimEdit.GetAnimationType.XLocationEffect)
            {
                xLocation_UserControl.Visible = true;
                xLocation_UserControl.Location = new Point(449, 59);

                mainControl_ValueToReach_Numeric.Minimum = 0;
            }

            else if (mainControl_AnimationType_ComboBox.SelectedIndex ==
                     (int)ZeroitVisAnimEdit.GetAnimationType.YLocationEffect)
            {
                yLocation_UserControl.Visible = true;
                yLocation_UserControl.Location = new Point(449, 59);

                mainControl_ValueToReach_Numeric.Minimum = 0;
            }


            #region Old Code

            //if (mainControl_AnimationType_ComboBox.SelectedIndex == BottomAnchoredHeightEffect)
            //{

            //    bottomAnchoredHeightEffect_UserControl.Visible = true;
            //    bottomAnchoredHeightEffect_UserControl.Location = new Point(449, 59);

            //    bottomAnchoredHeightEffect_UserControl.SendToBack();

            //    WarningLabelRemoved();

            //}

            //else if (mainControl_AnimationType_ComboBox.SelectedIndex == ColorChannelShiftEffect)
            //{
            //    colorChannelShiftEffect_UserControl.Visible = true;
            //    colorChannelShiftEffect_UserControl.Location = new Point(449, 59);

            //    mainControl_ValueToReach_Numeric.Maximum = 255;
            //    mainControl_ValueToReach_Numeric.Minimum = 0;

            //    info.ToolTipTitle = "ColorChannel Maximum and Minimum ";
            //    info.Show("Maximum = 255 and Minimum = 0 . Setting values above and below will raise an exception",
            //        mainControl_ValueToReach_Numeric);
            //    info.ToolTipIcon = ToolTipIcon.Warning;


            //}

            //else if (mainControl_AnimationType_ComboBox.SelectedIndex == ColorShiftEffect)
            //{
            //    colorShiftEffect_UserControl.Visible = true;
            //    colorShiftEffect_UserControl.Location = new Point(449, 59);

            //    mainControl_ValueToReach_Numeric.Maximum = -1;
            //    mainControl_ValueToReach_Numeric.Minimum = -255;

            //    info.ToolTipTitle = "ColorShift Maximum and Minimum ";
            //    info.Show("Maximum = -1 and Minimum = -255 . Setting values above and below will raise an exception",
            //        mainControl_ValueToReach_Numeric);
            //    info.ToolTipIcon = ToolTipIcon.Warning;


            //}

            //else if (mainControl_AnimationType_ComboBox.SelectedIndex == ControlFadeEffect)
            //{
            //    controlFadeEffect_UserControl.Visible = true;
            //    controlFadeEffect_UserControl.Location = new Point(449, 59);

            //    mainControl_ValueToReach_Numeric.Maximum = 100;
            //    mainControl_ValueToReach_Numeric.Minimum = 0;

            //    info.ToolTipTitle = "ControlFade Maximum and Minimum ";
            //    info.Show("Maximum = 100 and Minimum = 0 . Setting values above and below will raise an exception",
            //        mainControl_ValueToReach_Numeric);
            //    info.ToolTipIcon = ToolTipIcon.Warning;


            //}

            //else if (mainControl_AnimationType_ComboBox.SelectedIndex == ControlFadeEffect2)
            //{
            //    controlFadeEffect2_UserControl.Visible = true;
            //    controlFadeEffect2_UserControl.Location = new Point(449, 59);

            //    mainControl_ValueToReach_Numeric.Maximum = 100;
            //    mainControl_ValueToReach_Numeric.Minimum = 0;

            //    info.ToolTipTitle = "ControlFade2 Maximum and Minimum ";
            //    info.Show("Maximum = 100 and Minimum = 0 . Setting values above and below will raise an exception",
            //        mainControl_ValueToReach_Numeric);
            //    info.ToolTipIcon = ToolTipIcon.Warning;

            //    WarningLabelCreated();

            //}

            //else if (mainControl_AnimationType_ComboBox.SelectedIndex == FoldEffect)
            //{

            //    foldEffect_UserControl.Visible = true;
            //    foldEffect_UserControl.Location = new Point(449, 59);

            //}

            //else if (mainControl_AnimationType_ComboBox.SelectedIndex == FontSizeEffect)
            //{
            //    fontSizeEffect_UserControl.Visible = true;
            //    fontSizeEffect_UserControl.Location = new Point(449, 59);


            //}

            //else if (mainControl_AnimationType_ComboBox.SelectedIndex == FormFadeEffect)
            //{
            //    formFadeEffect_UserControl.Visible = true;
            //    formFadeEffect_UserControl.Location = new Point(449, 59);


            //}

            //else if (mainControl_AnimationType_ComboBox.SelectedIndex == HorizontalFoldEffect)
            //{
            //    horizontalFoldEffect_UserControl.Visible = true;
            //    horizontalFoldEffect_UserControl.Location = new Point(449, 59);


            //}

            //else if (mainControl_AnimationType_ComboBox.SelectedIndex == LeftAnchoredWidthEffect)
            //{
            //    leftAnchoredWidthEffect_UserControl.Visible = true;
            //    leftAnchoredWidthEffect_UserControl.Location = new Point(449, 59);


            //}

            //else if (mainControl_AnimationType_ComboBox.SelectedIndex == RightAnchoredWidthEffect)
            //{
            //    rightAnchoredWidthEffect_UserControl.Visible = true;
            //    rightAnchoredWidthEffect_UserControl.Location = new Point(449, 59);


            //}

            //else if (mainControl_AnimationType_ComboBox.SelectedIndex == TopAnchoredHeightEffect)
            //{
            //    topAnchoredHeightEffect_UserControl.Visible = true;
            //    topAnchoredHeightEffect_UserControl.Location = new Point(449, 59);


            //}

            //else if (mainControl_AnimationType_ComboBox.SelectedIndex == VerticalFoldEffect)
            //{
            //    verticalFoldEffect_UserControl.Visible = true;
            //    verticalFoldEffect_UserControl.Location = new Point(449, 59);


            //}

            //else if (mainControl_AnimationType_ComboBox.SelectedIndex == XLocationEffect)
            //{
            //    xLocation_UserControl.Visible = true;
            //    xLocation_UserControl.Location = new Point(449, 59);


            //}

            //else
            //{
            //    yLocation_UserControl.Visible = true;
            //    yLocation_UserControl.Location = new Point(449, 59);


            //} 
            #endregion

        }

        /// <summary>
        /// Easings the property changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EasingPropertyChanged(object sender, EventArgs e)
        {
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// at the default window position.
        /// </summary>
        public VisualEffectsAnimatorDialog() : this(VisualEffectsInput.Empty())
        {
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        public VisualEffectsAnimatorDialog(Control c) : this(VisualEffectsInput.Empty(), c)
        {
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="visualEffectsInput">The visual effects input.</param>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="filler" /> is null.</exception>
        public VisualEffectsAnimatorDialog(VisualEffectsInput visualEffectsInput, Control c) : this(visualEffectsInput)
        {
            Zeroit.Framework.Transitions.AnimationEditors.Utilities.Draw.SetStartPositionBelowControl(this, c);
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// at the default window position.
        /// </summary>
        /// <param name="visualEffectsInput">The visual effects input.</param>
        /// <exception cref="ArgumentNullException">visualEffectsInput</exception>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="peaceInput" /> is null.</exception>
        public VisualEffectsAnimatorDialog(VisualEffectsInput visualEffectsInput)
        {
            if (visualEffectsInput == null)
            {
                throw new ArgumentNullException("visualEffectsInput");
            }


            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

           
            Set_Initial_Values(visualEffectsInput);

            Knob1AnimatorCreated();
            Knob2AnimatorCreated();
            Knob3AnimatorCreated();
            Knob4AnimatorCreated();

            this.warning_Label.Visible = false;

            //AdjustDialogSize();
            //SetInitial_Values(pizaroAnimatorInput);

        }


        #endregion



        /// <summary>
        /// Handles the Click event of the thematic1501 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void thematic1501_Click(object sender, EventArgs e)
        {
            Knob1Remove();
            Knob2Remove();
            Knob3Remove();
            Knob4Remove();
        }

        /// <summary>
        /// Handles the Click event of the closeBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the mainControl_AnimationType_ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_AnimationType_ComboBox_Click(object sender, EventArgs e)
        {
            Knob1Remove();
            Knob2Remove();
            Knob3Remove();
            Knob4Remove();
        }

        /// <summary>
        /// Handles the Click event of the mainControl_Easing_ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Easing_ComboBox_Click(object sender, EventArgs e)
        {
            Knob1Remove();
            Knob2Remove();
            Knob3Remove();
            Knob4Remove();
        }

        /// <summary>
        /// Handles the Click event of the mainControl_Control_ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Control_ComboBox_Click(object sender, EventArgs e)
        {
            Knob1Remove();
            Knob2Remove();
            Knob3Remove();
            Knob4Remove();
        }

        /// <summary>
        /// Handles the Click event of the mainControl_Reverse_Yes_RadioBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Reverse_Yes_RadioBtn_Click(object sender, EventArgs e)
        {
            Knob1Remove();
            Knob2Remove();
            Knob3Remove();
            Knob4Remove();
        }

        /// <summary>
        /// Handles the Click event of the mainControl_Reverse_No_RadioBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Reverse_No_RadioBtn_Click(object sender, EventArgs e)
        {
            Knob1Remove();
            Knob2Remove();
            Knob3Remove();
            Knob4Remove();
        }

        /// <summary>
        /// Handles the Click event of the mainControl_Duration_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Duration_Numeric_Click(object sender, EventArgs e)
        {
            knob1.ScaleColor = Color.FromArgb(15, 15, 15);
            Knob2Remove();
            Knob3Remove();
            Knob4Remove();
        }

        /// <summary>
        /// Handles the Click event of the mainControl_Delay_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Delay_Numeric_Click(object sender, EventArgs e)
        {
            knob2.ScaleColor = Color.FromArgb(15, 15, 15);

            Knob1Remove();
            Knob3Remove();
            Knob4Remove();
        }

        /// <summary>
        /// Handles the Click event of the mainControl_Loops_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Loops_Numeric_Click(object sender, EventArgs e)
        {
            knob3.ScaleColor = Color.FromArgb(15, 15, 15);

            Knob1Remove();
            Knob2Remove();
            Knob4Remove();
        }

        /// <summary>
        /// Handles the Click event of the mainControl_ValueToReach_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_ValueToReach_Numeric_Click(object sender, EventArgs e)
        {
            knob4.ScaleColor = Color.FromArgb(15, 15, 15);

            Knob1Remove();
            Knob2Remove();
            Knob3Remove();
            
        }

        /// <summary>
        /// Handles the MouseEnter event of the showKnob1_Duration_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob1_Duration_Btn_MouseEnter(object sender, EventArgs e)
        {
            showKnob1_Duration_Btn.FlatAppearance.BorderSize = 1;
            showKnob1_Duration_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the showKnob1_Duration_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob1_Duration_Btn_MouseLeave(object sender, EventArgs e)
        {
            showKnob1_Duration_Btn.FlatAppearance.BorderSize = 0;
            showKnob1_Duration_Btn.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
        }

        /// <summary>
        /// Handles the MouseEnter event of the showKnob2_Delay_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob2_Delay_Btn_MouseEnter(object sender, EventArgs e)
        {
            showKnob2_Delay_Btn.FlatAppearance.BorderSize = 1;
            showKnob2_Delay_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the showKnob2_Delay_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob2_Delay_Btn_MouseLeave(object sender, EventArgs e)
        {
            showKnob2_Delay_Btn.FlatAppearance.BorderSize = 0;
            showKnob2_Delay_Btn.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
        }

        /// <summary>
        /// Handles the MouseEnter event of the showKnob3_Loops_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob3_Loops_Btn_MouseEnter(object sender, EventArgs e)
        {
            showKnob3_Loops_Btn.FlatAppearance.BorderSize = 1;
            showKnob3_Loops_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the showKnob3_Loops_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob3_Loops_Btn_MouseLeave(object sender, EventArgs e)
        {
            showKnob3_Loops_Btn.FlatAppearance.BorderSize = 0;
            showKnob3_Loops_Btn.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
        }

        /// <summary>
        /// Handles the MouseEnter event of the showKnob4_ValueToReach_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob4_ValueToReach_Btn_MouseEnter(object sender, EventArgs e)
        {
            showKnob4_ValueToReach_Btn.FlatAppearance.BorderSize = 1;
            showKnob4_ValueToReach_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the showKnob4_ValueToReach_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob4_ValueToReach_Btn_MouseLeave(object sender, EventArgs e)
        {
            showKnob4_ValueToReach_Btn.FlatAppearance.BorderSize = 0;
            showKnob4_ValueToReach_Btn.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
        }

        /// <summary>
        /// Handles the ValueChanged event of the mainControl_Duration_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Duration_Numeric_ValueChanged(object sender, EventArgs e)
        {
            knob1.ScaleColor = Color.Cyan;

            bottomAnchoredHeightEffect_UserControl.bottomAnchored_Animator.Duration =
                (int)mainControl_Duration_Numeric.Value;

            colorChannelShiftEffect_UserControl.colorChannelShift_Animator.Duration =
                (int)mainControl_Duration_Numeric.Value;

            colorShiftEffect_UserControl.colorShift_Animator.Duration =
                (int)mainControl_Duration_Numeric.Value;
            

            controlFadeEffect_UserControl.controlFade_Animator.Duration =
                (int)mainControl_Duration_Numeric.Value;

            controlFadeEffect2_UserControl.controlFade2_Animator.Duration =
                (int)mainControl_Duration_Numeric.Value;

            foldEffect_UserControl.fold_Animator.Duration =
                (int)mainControl_Duration_Numeric.Value;

            fontSizeEffect_UserControl.fontSize_Animator.Duration =
                (int)mainControl_Duration_Numeric.Value;

            formFadeEffect_UserControl.formFade_Animator.Duration =
                (int)mainControl_Duration_Numeric.Value;

            horizontalFoldEffect_UserControl.horizontalFold_Animator.Duration =
                (int)mainControl_Duration_Numeric.Value;

            leftAnchoredWidthEffect_UserControl.leftAnchoredWidth_Animator.Duration =
                (int)mainControl_Duration_Numeric.Value;

            rightAnchoredWidthEffect_UserControl.rightAnchoredWidth_Animator.Duration =
                (int)mainControl_Duration_Numeric.Value;

            topAnchoredHeightEffect_UserControl.topAnchoredHeight_Animator.Duration =
                (int)mainControl_Duration_Numeric.Value;

            verticalFoldEffect_UserControl.verticalFold_Animator.Duration =
                (int)mainControl_Duration_Numeric.Value;

            xLocation_UserControl.xLocation_Animator.Duration =
                (int)mainControl_Duration_Numeric.Value;

            yLocation_UserControl.yLocation_Animator.Duration =
                (int)mainControl_Duration_Numeric.Value;



            colorChannelShiftEffect_UserControl.colorChann_RotatingCube_Animator.Duration =
                (int)mainControl_Duration_Numeric.Value;
            colorShiftEffect_UserControl.colorShift_rotatingCubeAnimator.Duration =
                (int)mainControl_Duration_Numeric.Value;


        }

        /// <summary>
        /// Handles the ValueChanged event of the mainControl_Delay_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Delay_Numeric_ValueChanged(object sender, EventArgs e)
        {
            knob2.ScaleColor = Color.Cyan;

            bottomAnchoredHeightEffect_UserControl.bottomAnchored_Animator.Delay =
                (int)mainControl_Delay_Numeric.Value;

            colorChannelShiftEffect_UserControl.colorChannelShift_Animator.Delay =
                (int)mainControl_Delay_Numeric.Value;

            colorShiftEffect_UserControl.colorShift_Animator.Delay =
                (int)mainControl_Delay_Numeric.Value;

            controlFadeEffect_UserControl.controlFade_Animator.Delay =
                (int)mainControl_Delay_Numeric.Value;

            controlFadeEffect2_UserControl.controlFade2_Animator.Delay =
                (int)mainControl_Delay_Numeric.Value;

            foldEffect_UserControl.fold_Animator.Delay =
                (int)mainControl_Delay_Numeric.Value;

            fontSizeEffect_UserControl.fontSize_Animator.Delay =
                (int)mainControl_Delay_Numeric.Value;

            formFadeEffect_UserControl.formFade_Animator.Delay =
                (int)mainControl_Delay_Numeric.Value;

            horizontalFoldEffect_UserControl.horizontalFold_Animator.Delay =
                (int)mainControl_Delay_Numeric.Value;

            leftAnchoredWidthEffect_UserControl.leftAnchoredWidth_Animator.Delay =
                (int)mainControl_Delay_Numeric.Value;

            rightAnchoredWidthEffect_UserControl.rightAnchoredWidth_Animator.Delay =
                (int)mainControl_Delay_Numeric.Value;

            topAnchoredHeightEffect_UserControl.topAnchoredHeight_Animator.Delay =
                (int)mainControl_Delay_Numeric.Value;

            verticalFoldEffect_UserControl.verticalFold_Animator.Delay =
                (int)mainControl_Delay_Numeric.Value;

            xLocation_UserControl.xLocation_Animator.Delay =
                (int)mainControl_Delay_Numeric.Value;

            yLocation_UserControl.yLocation_Animator.Delay =
                (int)mainControl_Delay_Numeric.Value;



            colorChannelShiftEffect_UserControl.colorChann_RotatingCube_Animator.Delay =
                (int)mainControl_Delay_Numeric.Value;
            colorShiftEffect_UserControl.colorShift_rotatingCubeAnimator.Delay =
                (int)mainControl_Delay_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the mainControl_Loops_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Loops_Numeric_ValueChanged(object sender, EventArgs e)
        {
            knob3.ScaleColor = Color.Cyan;

            bottomAnchoredHeightEffect_UserControl.bottomAnchored_Animator.Loops =
                (int)mainControl_Loops_Numeric.Value;

            colorChannelShiftEffect_UserControl.colorChannelShift_Animator.Loops =
                (int)mainControl_Loops_Numeric.Value;

            colorShiftEffect_UserControl.colorShift_Animator.Loops =
                (int)mainControl_Loops_Numeric.Value;

            controlFadeEffect_UserControl.controlFade_Animator.Loops =
                (int)mainControl_Loops_Numeric.Value;

            controlFadeEffect2_UserControl.controlFade2_Animator.Loops =
                (int)mainControl_Loops_Numeric.Value;

            foldEffect_UserControl.fold_Animator.Loops =
                (int)mainControl_Loops_Numeric.Value;

            fontSizeEffect_UserControl.fontSize_Animator.Loops =
                (int)mainControl_Loops_Numeric.Value;

            formFadeEffect_UserControl.formFade_Animator.Loops =
                (int)mainControl_Loops_Numeric.Value;

            horizontalFoldEffect_UserControl.horizontalFold_Animator.Loops =
                (int)mainControl_Loops_Numeric.Value;

            leftAnchoredWidthEffect_UserControl.leftAnchoredWidth_Animator.Loops =
                (int)mainControl_Loops_Numeric.Value;

            rightAnchoredWidthEffect_UserControl.rightAnchoredWidth_Animator.Loops =
                (int)mainControl_Loops_Numeric.Value;

            topAnchoredHeightEffect_UserControl.topAnchoredHeight_Animator.Loops =
                (int)mainControl_Loops_Numeric.Value;

            verticalFoldEffect_UserControl.verticalFold_Animator.Loops =
                (int)mainControl_Loops_Numeric.Value;

            xLocation_UserControl.xLocation_Animator.Loops =
                (int)mainControl_Loops_Numeric.Value;

            yLocation_UserControl.yLocation_Animator.Loops =
                (int)mainControl_Loops_Numeric.Value;


            colorChannelShiftEffect_UserControl.colorChann_RotatingCube_Animator.Loops =
                (int)mainControl_Loops_Numeric.Value;
            colorShiftEffect_UserControl.colorShift_rotatingCubeAnimator.Loops =
                (int)mainControl_Loops_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the mainControl_ValueToReach_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_ValueToReach_Numeric_ValueChanged(object sender, EventArgs e)
        {
            knob4.ScaleColor = Color.Cyan;

            bottomAnchoredHeightEffect_UserControl.bottomAnchored_Animator.ValueToReach =
                (int)mainControl_ValueToReach_Numeric.Value;

            colorChannelShiftEffect_UserControl.colorChannelShift_Animator.ValueToReach =
                (int)mainControl_ValueToReach_Numeric.Value;

            colorShiftEffect_UserControl.colorShift_Animator.ValueToReach =
                (int)mainControl_ValueToReach_Numeric.Value;

            controlFadeEffect_UserControl.controlFade_Animator.ValueToReach =
                (int)mainControl_ValueToReach_Numeric.Value;

            controlFadeEffect2_UserControl.controlFade2_Animator.ValueToReach =
                (int)mainControl_ValueToReach_Numeric.Value;

            foldEffect_UserControl.fold_Animator.ValueToReach =
                (int)mainControl_ValueToReach_Numeric.Value;

            fontSizeEffect_UserControl.fontSize_Animator.ValueToReach =
                (int)mainControl_ValueToReach_Numeric.Value;

            formFadeEffect_UserControl.formFade_Animator.ValueToReach =
                (int)mainControl_ValueToReach_Numeric.Value;

            horizontalFoldEffect_UserControl.horizontalFold_Animator.ValueToReach =
                (int)mainControl_ValueToReach_Numeric.Value;

            leftAnchoredWidthEffect_UserControl.leftAnchoredWidth_Animator.ValueToReach =
                (int)mainControl_ValueToReach_Numeric.Value;

            rightAnchoredWidthEffect_UserControl.rightAnchoredWidth_Animator.ValueToReach =
                (int)mainControl_ValueToReach_Numeric.Value;

            topAnchoredHeightEffect_UserControl.topAnchoredHeight_Animator.ValueToReach =
                (int)mainControl_ValueToReach_Numeric.Value;

            verticalFoldEffect_UserControl.verticalFold_Animator.ValueToReach =
                (int)mainControl_ValueToReach_Numeric.Value;

            xLocation_UserControl.xLocation_Animator.ValueToReach =
                (int)mainControl_ValueToReach_Numeric.Value;

            yLocation_UserControl.yLocation_Animator.ValueToReach =
                (int)mainControl_ValueToReach_Numeric.Value;


            colorChannelShiftEffect_UserControl.colorChann_RotatingCube_Animator.ValueToReach =
                (int)mainControl_ValueToReach_Numeric.Value;
            colorShiftEffect_UserControl.colorShift_rotatingCubeAnimator.ValueToReach =
                (int)mainControl_ValueToReach_Numeric.Value;


            //if (mainControl_AnimationType_ComboBox.SelectedIndex ==
            //    (int) colorShiftEffect_UserControl.colorShift_Animator.AnimationType)
            //{
            //    info.ToolTipTitle = "ColorShift Maximum and Minimum ";
            //    info.Show("Maximum = 0 and Minimum = -255 . Setting values above and below will raise an exception",
            //        mainControl_ValueToReach_Numeric);
            //    info.ToolTipIcon = ToolTipIcon.Warning;
            //}
        }

        /// <summary>
        /// Handles the Click event of the okBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void okBtn_Click(object sender, EventArgs e)
        {
            #region Empty AnimationType IF Else

            if (mainControl_AnimationType_ComboBox.SelectedIndex == BottomAnchoredHeightEffect)
            {
                visualEffectsInput = new VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType.BottomAnchoredHeightEffect,
                    ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                    0, 2, 20, 10, 321, 2000, 0, false, 1, new Control(), 1);

                Set_BottomAnchoredHeightEffect_Retrieved_Values(visualEffectsInput);

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == ColorChannelShiftEffect)
            {
                visualEffectsInput = new VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType.ColorChannelShiftEffect,
                    ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                    0, 2, 20, 10, 321, 2000, 0, false, 1, new Control(), 1,1);

                Set_ColorChannelShiftEffect_Retrieved_Values(visualEffectsInput);

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == ColorShiftEffect)
            {
                visualEffectsInput = new VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType.ColorShiftEffect,
                    ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                    0, 2, 20, 10, 321, 2000, 0, false, 1, new Control(), 1f);

                Set_ColorShiftEffect_Retrieved_Values(visualEffectsInput);

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == ControlFadeEffect)
            {
                visualEffectsInput = new VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType.ControlFadeEffect,
                    ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                    0, 2, 20, 10, 321, 2000, 0, false, 1, new Control(), 1f, "");

                Set_ControlFadeEffect_Retrieved_Values(visualEffectsInput);

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == ControlFadeEffect2)
            {
                visualEffectsInput = new VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType.ControlFadeEffect2,
                    ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                    0, 2, 20, 10, 321, 2000, 0, false, 1, new Control(), "", 1f);

                Set_ControlFadeEffect2_Retrieved_Values(visualEffectsInput);

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == FoldEffect)
            {
                visualEffectsInput = new VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType.FoldEffect,
                    ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                    0, 2, 20, 10, 321, 2000, 0, false, 1, new Control(), "", 1);

                Set_FormFadeEffect_Retrieved_Values(visualEffectsInput);

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == FontSizeEffect)
            {
                visualEffectsInput = new VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType.FontSizeEffect,
                    ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                    0, 2, 20, 10, 321, 2000, 0, false, 1, new Control(), 1, "");

                Set_FontSizeEffect_Retrieved_Values(visualEffectsInput);

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == FormFadeEffect)
            {
                visualEffectsInput = new VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType.FormFadeEffect,
                    ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                    0, 2, 20, 10, 321, 2000, 0, false, 1, new Control(), 1, 1f);

                Set_FoldEffect_Retrieved_Values(visualEffectsInput);

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == HorizontalFoldEffect)
            {
                visualEffectsInput = new VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType.HorizontalFoldEffect,
                    ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                    0, 2, 20, 10, 321, 2000, 0, false, 1, new Control(), 1f, 1);

                Set_HorizontalFoldEffect_Retrieved_Values(visualEffectsInput);

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == LeftAnchoredWidthEffect)
            {
                visualEffectsInput = new VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType.LeftAnchoredWidthEffect,
                    ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                    0, 2, 20, 10, 321, 2000, 0, false, 1, new Control(), 1D);

                Set_LeftAnchoredWidthEffect_Retrieved_Values(visualEffectsInput);

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == RightAnchoredWidthEffect)
            {
                visualEffectsInput = new VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType.RightAnchoredWidthEffect,
                    ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                    0, 2, 20, 10, 321, 2000, 0, false, 1, new Control(), 1D, 1D);

                Set_RightAnchoredWidthEffect_Retrieved_Values(visualEffectsInput);

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == TopAnchoredHeightEffect)
            {
                visualEffectsInput = new VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType.TopAnchoredHeightEffect,
                    ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                    0, 2, 20, 10, 321, 2000, 0, false, 1, new Control(), 1D, 1);

                Set_TopAnchoredHeightEffect_Retrieved_Values(visualEffectsInput);

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == VerticalFoldEffect)
            {
                visualEffectsInput = new VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType.VerticalFoldEffect,
                    ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                    0, 2, 20, 10, 321, 2000, 0, false, 1, new Control(), 1, 1D);

                Set_VerticalFoldEffect_Retrieved_Values(visualEffectsInput);

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == XLocationEffect)
            {
                visualEffectsInput = new VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType.XLocationEffect,
                    ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                    0, 2, 20, 10, 321, 2000, 0, false, 1, new Control(), "");

                Set_XLocationEffect_Retrieved_Values(visualEffectsInput);

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == YLocationEffect)
            {
                visualEffectsInput = new VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType.YLocationEffect,
                    ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                    0, 2, 20, 10, 321, 2000, 0, false, 1, new Control(), "", "");

                Set_YLocationEffect_Retrieved_Values(visualEffectsInput);

            }

            #endregion


            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles the Click event of the cancelBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Handles the MouseEnter event of the closeBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.Red;
            closeBtn.FlatAppearance.BorderSize = 0;
        }

        /// <summary>
        /// Handles the MouseLeave event of the closeBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.FlatAppearance.BorderSize = 1;
            closeBtn.BackColor = Color.FromArgb(16, 16, 16);
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the mainControl_Easing_ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Easing_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bottomAnchoredHeightEffect_UserControl.bottomAnchored_Animator.EasingType = 
                (ZeroitVisAnim.EasingFunctionTypes)Enum.Parse(
                    typeof(ZeroitVisAnim.EasingFunctionTypes), 
                    mainControl_Easing_ComboBox.SelectedItem.ToString());

            colorChannelShiftEffect_UserControl.colorChannelShift_Animator.EasingType =
                (ZeroitVisAnim.EasingFunctionTypes) Enum.Parse(
                    typeof(ZeroitVisAnim.EasingFunctionTypes),
                    mainControl_Easing_ComboBox.SelectedItem.ToString());

            colorShiftEffect_UserControl.colorShift_Animator.EasingType =
                (ZeroitVisAnim.EasingFunctionTypes)Enum.Parse(
                    typeof(ZeroitVisAnim.EasingFunctionTypes),
                    mainControl_Easing_ComboBox.SelectedItem.ToString());

            controlFadeEffect_UserControl.controlFade_Animator.EasingType =
                (ZeroitVisAnim.EasingFunctionTypes)Enum.Parse(
                    typeof(ZeroitVisAnim.EasingFunctionTypes),
                    mainControl_Easing_ComboBox.SelectedItem.ToString());

            controlFadeEffect2_UserControl.controlFade2_Animator.EasingType =
                (ZeroitVisAnim.EasingFunctionTypes)Enum.Parse(
                    typeof(ZeroitVisAnim.EasingFunctionTypes),
                    mainControl_Easing_ComboBox.SelectedItem.ToString());

            foldEffect_UserControl.fold_Animator.EasingType =
                (ZeroitVisAnim.EasingFunctionTypes)Enum.Parse(
                    typeof(ZeroitVisAnim.EasingFunctionTypes),
                    mainControl_Easing_ComboBox.SelectedItem.ToString());

            fontSizeEffect_UserControl.fontSize_Animator.EasingType =
                (ZeroitVisAnim.EasingFunctionTypes)Enum.Parse(
                    typeof(ZeroitVisAnim.EasingFunctionTypes),
                    mainControl_Easing_ComboBox.SelectedItem.ToString());

            formFadeEffect_UserControl.formFade_Animator.EasingType =
                (ZeroitVisAnim.EasingFunctionTypes)Enum.Parse(
                    typeof(ZeroitVisAnim.EasingFunctionTypes),
                    mainControl_Easing_ComboBox.SelectedItem.ToString());

            horizontalFoldEffect_UserControl.horizontalFold_Animator.EasingType =
                (ZeroitVisAnim.EasingFunctionTypes)Enum.Parse(
                    typeof(ZeroitVisAnim.EasingFunctionTypes),
                    mainControl_Easing_ComboBox.SelectedItem.ToString());

            leftAnchoredWidthEffect_UserControl.leftAnchoredWidth_Animator.EasingType =
                (ZeroitVisAnim.EasingFunctionTypes)Enum.Parse(
                    typeof(ZeroitVisAnim.EasingFunctionTypes),
                    mainControl_Easing_ComboBox.SelectedItem.ToString());

            rightAnchoredWidthEffect_UserControl.rightAnchoredWidth_Animator.EasingType =
                (ZeroitVisAnim.EasingFunctionTypes)Enum.Parse(
                    typeof(ZeroitVisAnim.EasingFunctionTypes),
                    mainControl_Easing_ComboBox.SelectedItem.ToString());

            topAnchoredHeightEffect_UserControl.topAnchoredHeight_Animator.EasingType =
                (ZeroitVisAnim.EasingFunctionTypes)Enum.Parse(
                    typeof(ZeroitVisAnim.EasingFunctionTypes),
                    mainControl_Easing_ComboBox.SelectedItem.ToString());

            verticalFoldEffect_UserControl.verticalFold_Animator.EasingType =
                (ZeroitVisAnim.EasingFunctionTypes)Enum.Parse(
                    typeof(ZeroitVisAnim.EasingFunctionTypes),
                    mainControl_Easing_ComboBox.SelectedItem.ToString());

            xLocation_UserControl.xLocation_Animator.EasingType =
                (ZeroitVisAnim.EasingFunctionTypes)Enum.Parse(
                    typeof(ZeroitVisAnim.EasingFunctionTypes),
                    mainControl_Easing_ComboBox.SelectedItem.ToString());

            yLocation_UserControl.yLocation_Animator.EasingType =
                (ZeroitVisAnim.EasingFunctionTypes)Enum.Parse(
                    typeof(ZeroitVisAnim.EasingFunctionTypes),
                    mainControl_Easing_ComboBox.SelectedItem.ToString());




        }

        /// <summary>
        /// Handles the CheckedChanged event of the mainControl_Reverse_Yes_RadioBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Reverse_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (mainControl_Reverse_Yes_RadioBtn.Checked)
            {
                bottomAnchoredHeightEffect_UserControl.bottomAnchored_Animator.Reverse = true;
                colorChannelShiftEffect_UserControl.colorChannelShift_Animator.Reverse = true;
                colorShiftEffect_UserControl.colorShift_Animator.Reverse = true;
                controlFadeEffect_UserControl.controlFade_Animator.Reverse = true;
                controlFadeEffect2_UserControl.controlFade2_Animator.Reverse = true;
                foldEffect_UserControl.fold_Animator.Reverse = true;
                fontSizeEffect_UserControl.fontSize_Animator.Reverse = true;
                formFadeEffect_UserControl.formFade_Animator.Reverse = true;
                horizontalFoldEffect_UserControl.horizontalFold_Animator.Reverse = true;
                leftAnchoredWidthEffect_UserControl.leftAnchoredWidth_Animator.Reverse = true;
                rightAnchoredWidthEffect_UserControl.rightAnchoredWidth_Animator.Reverse = true;
                topAnchoredHeightEffect_UserControl.topAnchoredHeight_Animator.Reverse = true;
                verticalFoldEffect_UserControl.verticalFold_Animator.Reverse = true;
                xLocation_UserControl.xLocation_Animator.Reverse = true;
                yLocation_UserControl.yLocation_Animator.Reverse = true;

                colorChannelShiftEffect_UserControl.colorChann_RotatingCube_Animator.Reverse = true;
                colorShiftEffect_UserControl.colorShift_rotatingCubeAnimator.Reverse = true;
            }
            else
            {
                bottomAnchoredHeightEffect_UserControl.bottomAnchored_Animator.Reverse = false;

                bottomAnchoredHeightEffect_UserControl.bottomAnchored_Animator.Reverse = false;
                colorChannelShiftEffect_UserControl.colorChannelShift_Animator.Reverse = false;
                colorShiftEffect_UserControl.colorShift_Animator.Reverse = false;
                controlFadeEffect_UserControl.controlFade_Animator.Reverse = false;
                controlFadeEffect2_UserControl.controlFade2_Animator.Reverse = false;
                foldEffect_UserControl.fold_Animator.Reverse = false;
                fontSizeEffect_UserControl.fontSize_Animator.Reverse = false;
                formFadeEffect_UserControl.formFade_Animator.Reverse = false;
                horizontalFoldEffect_UserControl.horizontalFold_Animator.Reverse = false;
                leftAnchoredWidthEffect_UserControl.leftAnchoredWidth_Animator.Reverse = false;
                rightAnchoredWidthEffect_UserControl.rightAnchoredWidth_Animator.Reverse = false;
                topAnchoredHeightEffect_UserControl.topAnchoredHeight_Animator.Reverse = false;
                verticalFoldEffect_UserControl.verticalFold_Animator.Reverse = false;
                xLocation_UserControl.xLocation_Animator.Reverse = false;
                yLocation_UserControl.yLocation_Animator.Reverse = false;

                colorChannelShiftEffect_UserControl.colorChann_RotatingCube_Animator.Reverse = false;
                colorShiftEffect_UserControl.colorShift_rotatingCubeAnimator.Reverse = false;
            }
        }

        /// <summary>
        /// Handles the Enter event of the mainControl_Loops_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Loops_Numeric_Enter(object sender, EventArgs e)
        {
            info.ToolTipTitle = "Infinity";
            info.Show("Setting the Loop value to 0 will set the animation to infinity", mainControl_Loops_Numeric);
            
        }

        /// <summary>
        /// Handles the Click event of the mainControl_Fold_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Fold_Btn_Click(object sender, EventArgs e)
        {
            foldAnimator.Activate();
        }
    }
}
