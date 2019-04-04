// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ZeroitAnimateAnimatorDialog.cs" company="Zeroit Dev Technologies">
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
using System;
using System.Drawing;
using System.Windows.Forms;
using Zeroit.Framework.Transitions._HelpingControls.LBKnob;

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    /// Class ZeroitAnimateAnimatorDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ZeroitAnimateAnimatorDialog : System.Windows.Forms.Form
    {

        #region Constructor

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// at the default window position.
        /// </summary>
        public ZeroitAnimateAnimatorDialog() : this(AnimateInput.Empty())
        {
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        public ZeroitAnimateAnimatorDialog(Control c) : this(AnimateInput.Empty(), c)
        {
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="animateInput">The animate input.</param>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="filler" /> is null.</exception>
        public ZeroitAnimateAnimatorDialog(AnimateInput animateInput, Control c) : this(animateInput)
        {
            Zeroit.Framework.Transitions.AnimationEditors.Utilities.Draw.SetStartPositionBelowControl(this, c);
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// at the default window position.
        /// </summary>
        /// <param name="animateInput">The animate input.</param>
        /// <exception cref="ArgumentNullException">animateInput</exception>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="peaceInput" /> is null.</exception>
        public ZeroitAnimateAnimatorDialog(AnimateInput animateInput)
        {
            if (animateInput == null)
            {
                throw new ArgumentNullException("animateInput");
            }


            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            Knob1AnimatorCreated();
            Knob2AnimatorCreated();
            Knob3AnimatorCreated();
            Knob4AnimatorCreated();
            Knob5AnimatorCreated();

            Set_Initial_Values(animateInput);
            

            //AdjustDialogSize();
            //SetInitial_Values(pizaroAnimatorInput);

        }


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
        /// The knob5
        /// </summary>
        private ZeroitLBKnob knob5 = new ZeroitLBKnob();

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
        /// The knob5 animator
        /// </summary>
        private ZeroitAnimator knob5Animator = new ZeroitAnimator();

        /// <summary>
        /// The custom user control
        /// </summary>
        private Custom_UserControl custom_UserControl = new Custom_UserControl();
        /// <summary>
        /// The horiz blind user control
        /// </summary>
        private HorizBlind_UserControl horizBlind_UserControl = new HorizBlind_UserControl();
        /// <summary>
        /// The horiz slide user control
        /// </summary>
        private HorizSlide_UserControl horizSlide_UserControl = new HorizSlide_UserControl();
        /// <summary>
        /// The horiz slide and rotate user control
        /// </summary>
        private HorizSlideAndRotate_UserControl horizSlideAndRotate_UserControl = new HorizSlideAndRotate_UserControl();
        /// <summary>
        /// The leaf user control
        /// </summary>
        private Leaf_UserControl leaf_UserControl = new Leaf_UserControl();
        /// <summary>
        /// The mosaic user control
        /// </summary>
        private Mosaic_UserControl mosaic_UserControl = new Mosaic_UserControl();
        /// <summary>
        /// The particles user control
        /// </summary>
        private Particles_UserControl particles_UserControl = new Particles_UserControl();
        /// <summary>
        /// The rotate user control
        /// </summary>
        private Rotate_UserControl rotate_UserControl = new Rotate_UserControl();
        /// <summary>
        /// The scale user control
        /// </summary>
        private Scale_UserControl scale_UserControl = new Scale_UserControl();
        /// <summary>
        /// The scale and horiz slide user control
        /// </summary>
        private ScaleAndHorizSlide_UserControl scaleAndHorizSlide_UserControl = new ScaleAndHorizSlide_UserControl();
        /// <summary>
        /// The scale and rotate user control
        /// </summary>
        private ScaleAndRotate_UserControl scaleAndRotate_UserControl = new ScaleAndRotate_UserControl();
        /// <summary>
        /// The transparent user control
        /// </summary>
        private Transparent_UserControl transparent_UserControl = new Transparent_UserControl();
        /// <summary>
        /// The vert blind user control
        /// </summary>
        private VertBlind_UserControl vertBlind_UserControl = new VertBlind_UserControl();
        /// <summary>
        /// The vert slide user control
        /// </summary>
        private VertSlide_UserControl vertSlide_UserControl = new VertSlide_UserControl();

        /// <summary>
        /// The timer
        /// </summary>
        private System.Windows.Forms.Timer timer = new Timer();


        #endregion

        #region Public Properties

        /// <summary>
        /// The animate input
        /// </summary>
        private AnimateInput animateInput;

        /// <summary>
        /// Gets the animate input.
        /// </summary>
        /// <value>The animate input.</value>
        public AnimateInput AnimateInput
        {
            get { return animateInput; }
        }


        #endregion

        #region Private Methods

        #region KnobAnimators Creation

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
        /// Knob5s the animator created.
        /// </summary>
        private void Knob5AnimatorCreated()
        {
            knob5Animator.Target = knob5;
            knob5Animator.AnimationType = AnimationType.Mosaic;
            knob5Animator.TargetHeight = 121;
            knob5Animator.TargetWidth = 118;
            knob5Animator.Interval = 10;
            knob5Animator.MaxAnimationTime = 1500;
            knob5Animator.TimeStep = 0.02f;
        }

        #endregion

        #region Knob Controls Creation
        /// <summary>
        /// Knob1s the created.
        /// </summary>
        private void Knob1Created()
        {

            this.knob1.BackColor = System.Drawing.Color.Transparent;
            this.knob1.DrawRatio = 0.59F;
            this.knob1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.knob1.IndicatorOffset = 10F;
            //this.knob1.KnobColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.knob1.KnobColor = Color.Silver;
            this.knob1.Location = new System.Drawing.Point(385, 67);
            this.knob1.MaxValue = (float)mainControl_Duration_Numeric.Maximum;
            this.knob1.MinValue = (float)mainControl_Duration_Numeric.Minimum;
            this.knob1.Renderer = null;
            //this.knob1.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.knob1.ScaleColor = Color.FromArgb(50, 50, 50);
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
            this.knob2.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.knob2.IndicatorOffset = 10F;
            //this.knob2.KnobColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.knob2.KnobColor = Color.Silver;
            this.knob2.Location = new System.Drawing.Point(385, 126);
            this.knob2.MaxValue = (float)mainControl_Interval_Numeric.Maximum;
            this.knob2.MinValue = (float)mainControl_Interval_Numeric.Minimum;
            this.knob2.Renderer = null;
            //this.knob2.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.knob2.ScaleColor = Color.FromArgb(50, 50, 50);
            this.knob2.Size = new System.Drawing.Size(118, 121);
            this.knob2.StepValue = (float)mainControl_Interval_Numeric.Increment;
            this.knob2.Style = Zeroit.Framework.Transitions._HelpingControls.LBKnob.ZeroitLBKnob.KnobStyle.Circular;
            this.knob2.Value = (float)mainControl_Interval_Numeric.Value;
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
            this.knob3.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.knob3.IndicatorOffset = 10F;
            //this.knob3.KnobColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.knob3.KnobColor = Color.Silver;
            this.knob3.Location = new System.Drawing.Point(385, 186);
            this.knob3.MaxValue = (float)mainControl_TargetWidth_Numeric.Maximum;
            this.knob3.MinValue = (float)mainControl_TargetWidth_Numeric.Minimum;
            this.knob3.Renderer = null;
            //this.knob3.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.knob3.ScaleColor = Color.FromArgb(50, 50, 50);
            this.knob3.Size = new System.Drawing.Size(118, 121);
            this.knob3.StepValue = (float)mainControl_TargetWidth_Numeric.Increment;
            this.knob3.Style = Zeroit.Framework.Transitions._HelpingControls.LBKnob.ZeroitLBKnob.KnobStyle.Circular;
            this.knob3.Value = (float)mainControl_TargetWidth_Numeric.Value;
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
            this.knob4.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.knob4.IndicatorOffset = 10F;
            //this.knob4.KnobColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.knob4.KnobColor = Color.Silver;
            this.knob4.Location = new System.Drawing.Point(385, 245);
            this.knob4.MaxValue = (float)mainControl_TargetHeight_Numeric.Maximum;
            this.knob4.MinValue = (float)mainControl_TargetHeight_Numeric.Minimum;
            this.knob4.Renderer = null;
            //this.knob4.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.knob4.ScaleColor = Color.FromArgb(50, 50, 50);
            this.knob4.Size = new System.Drawing.Size(118, 121);
            this.knob4.StepValue = (float)mainControl_TargetHeight_Numeric.Increment;
            this.knob4.Style = Zeroit.Framework.Transitions._HelpingControls.LBKnob.ZeroitLBKnob.KnobStyle.Circular;
            this.knob4.Value = (float)mainControl_TargetHeight_Numeric.Value;
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
        /// Knob5s the created.
        /// </summary>
        private void Knob5Created()
        {

            this.knob5.BackColor = System.Drawing.Color.Transparent;
            this.knob5.DrawRatio = 0.59F;
            this.knob5.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.knob5.IndicatorOffset = 10F;
            //this.knob5.KnobColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.knob5.KnobColor = Color.Silver;
            this.knob5.Location = new System.Drawing.Point(385, 301);
            this.knob5.MaxValue = (float)mainControl_TimeStep_Numeric.Maximum;
            this.knob5.MinValue = (float)mainControl_TimeStep_Numeric.Minimum;
            this.knob5.Renderer = null;
            //this.knob5.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.knob5.ScaleColor = Color.FromArgb(50,50,50);
            this.knob5.Size = new System.Drawing.Size(118, 121);
            this.knob5.StepValue = (float)mainControl_TimeStep_Numeric.Increment;
            this.knob5.Style = Zeroit.Framework.Transitions._HelpingControls.LBKnob.ZeroitLBKnob.KnobStyle.Circular;
            this.knob5.Value = (float)mainControl_TimeStep_Numeric.Value;
            this.knob5.Visible = true;
            this.knob5.BringToFront();

            thematic1501.Controls.Add(knob5);
            knob5.KnobChangeValue += Knob5_KnobChangeValue;
        }
        /// <summary>
        /// Knob5s the remove.
        /// </summary>
        private void Knob5Remove()
        {
            thematic1501.Controls.Remove(knob5);
            knob5.Visible = false;
        }
        #endregion

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
            Knob5Remove();

            this.knob1.BringToFront();
            knob1Animator.Activate();


        }

        /// <summary>
        /// Handles the Click event of the showKnob2_Interval_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob2_Interval_Btn_Click(object sender, EventArgs e)
        {
            Knob2Created();
            Knob3Remove();
            Knob4Remove();
            Knob5Remove();
            Knob1Remove();
            this.knob2.BringToFront();
            knob2Animator.Activate();
        }

        /// <summary>
        /// Handles the Click event of the showKnob3_TargetWidth_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob3_TargetWidth_Btn_Click(object sender, EventArgs e)
        {
            Knob3Created();
            Knob4Remove();
            Knob1Remove();
            Knob2Remove();
            Knob5Remove();

            this.knob3.BringToFront();
            knob3Animator.Activate();
        }

        /// <summary>
        /// Handles the Click event of the showKnob4_TargetHeight_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob4_TargetHeight_Btn_Click(object sender, EventArgs e)
        {
            Knob4Created();
            Knob1Remove();
            Knob2Remove();
            Knob3Remove();
            Knob5Remove();

            this.knob4.BringToFront();

            knob4Animator.Activate();

        }

        /// <summary>
        /// Handles the Click event of the showKnob5_TimeStep_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob5_TimeStep_Btn_Click(object sender, EventArgs e)
        {
            Knob5Created();
            Knob1Remove();
            Knob2Remove();
            Knob3Remove();
            Knob4Remove();

            this.knob5.BringToFront();

            knob5Animator.Activate();

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
        /// Handles the MouseEnter event of the showKnob2_Interval_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob2_Interval_Btn_MouseEnter(object sender, EventArgs e)
        {
            showKnob2_Interval_Btn.FlatAppearance.BorderSize = 1;
            showKnob2_Interval_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the showKnob2_Interval_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob2_Interval_Btn_MouseLeave(object sender, EventArgs e)
        {
            showKnob2_Interval_Btn.FlatAppearance.BorderSize = 0;
            showKnob2_Interval_Btn.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
        }

        /// <summary>
        /// Handles the MouseEnter event of the showKnob3_TargetWidth_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob3_TargetWidth_Btn_MouseEnter(object sender, EventArgs e)
        {
            showKnob3_TargetWidth_Btn.FlatAppearance.BorderSize = 1;
            showKnob3_TargetWidth_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the showKnob3_TargetWidth_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob3_TargetWidth_Btn_MouseLeave(object sender, EventArgs e)
        {
            showKnob3_TargetWidth_Btn.FlatAppearance.BorderSize = 0;
            showKnob3_TargetWidth_Btn.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
        }

        /// <summary>
        /// Handles the MouseEnter event of the showKnob4_TargetHeight_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob4_TargetHeight_Btn_MouseEnter(object sender, EventArgs e)
        {
            showKnob4_TargetHeight_Btn.FlatAppearance.BorderSize = 1;
            showKnob4_TargetHeight_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the showKnob4_TargetHeight_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob4_TargetHeight_Btn_MouseLeave(object sender, EventArgs e)
        {
            showKnob4_TargetHeight_Btn.FlatAppearance.BorderSize = 0;
            showKnob4_TargetHeight_Btn.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
        }

        /// <summary>
        /// Handles the MouseEnter event of the showKnob5_TimeStep_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob5_TimeStep_Btn_MouseEnter(object sender, EventArgs e)
        {
            showKnob5_TimeStep_Btn.FlatAppearance.BorderSize = 1;
            showKnob5_TimeStep_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the showKnob5_TimeStep_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob5_TimeStep_Btn_MouseLeave(object sender, EventArgs e)
        {
            showKnob5_TimeStep_Btn.FlatAppearance.BorderSize = 0;
            showKnob5_TimeStep_Btn.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
        }

        /// <summary>
        /// Handles the ValueChanged event of the mainControl_Duration_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Duration_Numeric_ValueChanged(object sender, EventArgs e)
        {
            knob1.ScaleColor = Color.Honeydew;

            animatorPreview.MaxAnimationTime = (int) mainControl_Duration_Numeric.Value;

            #region Old Code

            //custom_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
            //horizBlind_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
            //horizSlide_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
            //horizSlideAndRotate_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
            //leaf_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
            //mosaic_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
            //particles_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
            //rotate_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
            //scale_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
            //scaleAndHorizSlide_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
            //scaleAndRotate_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
            //transparent_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
            //vertBlind_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
            //vertSlide_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value; 

            #endregion

        }

        /// <summary>
        /// Handles the ValueChanged event of the mainControl_Interval_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Interval_Numeric_ValueChanged(object sender, EventArgs e)
        {
            knob2.ScaleColor = Color.Honeydew;

            animatorPreview.Interval = (int)mainControl_Interval_Numeric.Value;
            
            #region Old Code
            //custom_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
            //horizBlind_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
            //horizSlide_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
            //horizSlideAndRotate_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
            //leaf_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
            //mosaic_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
            //particles_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
            //rotate_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
            //scale_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
            //scaleAndHorizSlide_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
            //scaleAndRotate_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
            //transparent_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
            //vertBlind_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
            //vertSlide_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value; 
            #endregion


        }

        /// <summary>
        /// Handles the ValueChanged event of the mainControl_TargetWidth_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_TargetWidth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            knob3.ScaleColor = Color.Honeydew;

            animatorPreview.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value / 3;
            
            #region Old Code
            //custom_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            //horizBlind_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            //horizSlide_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            //horizSlideAndRotate_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            //leaf_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            //mosaic_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            //particles_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            //rotate_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            //scale_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            //scaleAndHorizSlide_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            //scaleAndRotate_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            //transparent_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            //vertBlind_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            //vertSlide_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value; 
            #endregion
            
        }

        /// <summary>
        /// Handles the ValueChanged event of the mainControl_TargetHeight_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_TargetHeight_Numeric_ValueChanged(object sender, EventArgs e)
        {
            knob4.ScaleColor = Color.Honeydew;

            animatorPreview.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value / 3;
            

            #region Old Code
            //custom_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            //horizBlind_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            //horizSlide_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            //horizSlideAndRotate_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            //leaf_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            //mosaic_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            //particles_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            //rotate_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            //scale_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            //scaleAndHorizSlide_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            //scaleAndRotate_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            //transparent_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            //vertBlind_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            //vertSlide_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value; 
            #endregion


        }

        /// <summary>
        /// Handles the ValueChanged event of the mainControl_TimeStep_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_TimeStep_Numeric_ValueChanged(object sender, EventArgs e)
        {
            knob5.ScaleColor = Color.Honeydew;

            //animatorPreview.TimeStep = (int)mainControl_TimeStep_Numeric.Value;


            #region Old Code
            //custom_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;
            //horizBlind_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;
            //horizSlide_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;
            //horizSlideAndRotate_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;
            //leaf_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;
            //mosaic_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;
            //particles_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;
            //rotate_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;
            //scale_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;
            //scaleAndHorizSlide_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;
            //scaleAndRotate_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;
            //transparent_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;
            //vertBlind_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;
            //vertSlide_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value; 
            #endregion


        }


        /// <summary>
        /// Handles the Click event of the mainControl_Duration_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Duration_Numeric_Click(object sender, EventArgs e)
        {
            knob1.ScaleColor = Color.FromArgb(50, 50, 50);
            Knob2Remove();
            Knob3Remove();
            Knob4Remove();
            Knob5Remove();
        }

        /// <summary>
        /// Handles the Click event of the mainControl_Interval_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Interval_Numeric_Click(object sender, EventArgs e)
        {
            knob2.ScaleColor = Color.FromArgb(50, 50, 50);

            Knob1Remove();
            Knob3Remove();
            Knob4Remove();
            Knob5Remove();
        }

        /// <summary>
        /// Handles the Click event of the mainControl_TargetWidth_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_TargetWidth_Numeric_Click(object sender, EventArgs e)
        {
            knob3.ScaleColor = Color.FromArgb(50, 50, 50);

            Knob1Remove();
            Knob2Remove();
            Knob4Remove();
            Knob5Remove();
        }

        /// <summary>
        /// Handles the Click event of the mainControl_TargetHeight_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_TargetHeight_Numeric_Click(object sender, EventArgs e)
        {
            knob4.ScaleColor = Color.FromArgb(50, 50, 50);

            Knob1Remove();
            Knob2Remove();
            Knob3Remove();
            Knob5Remove();

        }

        /// <summary>
        /// Handles the Click event of the mainControl_TimeStep_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_TimeStep_Numeric_Click(object sender, EventArgs e)
        {
            knob5.ScaleColor = Color.FromArgb(50, 50, 50);

            Knob1Remove();
            Knob2Remove();
            Knob3Remove();
            Knob4Remove();

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
            mainControl_Interval_Numeric.Value = Convert.ToInt32(knob2.Value);
        }

        /// <summary>
        /// Handles the KnobChangeValue event of the Knob3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ZeroitLBKnobEventArgs"/> instance containing the event data.</param>
        private void Knob3_KnobChangeValue(object sender, ZeroitLBKnobEventArgs e)
        {
            mainControl_TargetWidth_Numeric.Value = Convert.ToInt32(knob3.Value);
        }

        /// <summary>
        /// Handles the KnobChangeValue event of the Knob4 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ZeroitLBKnobEventArgs"/> instance containing the event data.</param>
        private void Knob4_KnobChangeValue(object sender, ZeroitLBKnobEventArgs e)
        {
            mainControl_TargetHeight_Numeric.Value = Convert.ToInt32(knob4.Value);
        }

        /// <summary>
        /// Handles the KnobChangeValue event of the Knob5 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ZeroitLBKnobEventArgs"/> instance containing the event data.</param>
        private void Knob5_KnobChangeValue(object sender, ZeroitLBKnobEventArgs e)
        {
            mainControl_TimeStep_Numeric.Value = Convert.ToDecimal(knob5.Value);
        }

        #endregion

        #region Private Events

        /// <summary>
        /// Gets the user control values.
        /// </summary>
        /// <param name="animateInput">The animate input.</param>
        private void Get_UserControlValues(AnimateInput animateInput)
        {
            
        }

        /// <summary>
        /// Sets the initial values.
        /// </summary>
        /// <param name="animateInput">The animate input.</param>
        private void Set_Initial_Values(AnimateInput animateInput)
        {


            #region Add Enum to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string animationType in Enum.GetNames(typeof(Transitions.AnimatorWithEditor.AnimationType)))
            {
                mainControl_AnimationType_ComboBox.Items.Add(animationType);

            }

            for (int i = 0; i < mainControl_AnimationType_ComboBox.Items.Count; i++)
            {
                if (animateInput.AnimationType == (Transitions.AnimatorWithEditor.AnimationType)Enum.Parse(typeof(AnimationType), mainControl_AnimationType_ComboBox.Items[i].ToString()))
                {
                    mainControl_AnimationType_ComboBox.SelectedIndex = i;

                }

            }
            #endregion


            #region Control

            foreach (var controlNames in animateInput.Target.FindForm().Controls)
            {
                mainControl_Control_ComboBox.Items.Add(controlNames);

            }
            mainControl_Control_ComboBox.Items.Add(animateInput.Target.FindForm());


            for (int i = 0; i < mainControl_Control_ComboBox.Items.Count; i++)
            {
                if (animateInput.Target == (Control)(mainControl_Control_ComboBox.Items[i]))
                {
                    mainControl_Control_ComboBox.SelectedIndex = i;

                }

            }
            #endregion

            if (animateInput.AnimationType == Transitions.AnimatorWithEditor.AnimationType.Custom)
            {
                mainControl_AnimationType_ComboBox.SelectedIndex =
                    (int)Transitions.AnimatorWithEditor.AnimationType.Custom;

                //animatorPreview.MaxAnimationTime = animateInput.Duration;
                //animatorPreview.Interval = animateInput.Interval;
                //animatorPreview.TargetWidth = animateInput.TargetWidth;
                //animatorPreview.TargetHeight = animateInput.TargetHeight;
                //animatorPreview.TimeStep = animateInput.TimeStep;

                #region Old Code
                //custom_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = animateInput.Duration;
                //custom_UserControl.zeroitAnimate_Animator1.Interval = animateInput.Interval;
                //custom_UserControl.zeroitAnimate_Animator1.TargetWidth = animateInput.TargetWidth;
                //custom_UserControl.zeroitAnimate_Animator1.TargetHeight = animateInput.TargetHeight;
                //custom_UserControl.zeroitAnimate_Animator1.TimeStep = animateInput.TimeStep; 
                #endregion
            }

            else if (animateInput.AnimationType == Transitions.AnimatorWithEditor.AnimationType.HorizBlind)
            {
                mainControl_AnimationType_ComboBox.SelectedIndex =
                    (int)Transitions.AnimatorWithEditor.AnimationType.HorizBlind;

                //animatorPreview.MaxAnimationTime = animateInput.Duration;
                //animatorPreview.Interval = animateInput.Interval;
                //animatorPreview.TargetWidth = animateInput.TargetWidth;
                //animatorPreview.TargetHeight = animateInput.TargetHeight;
                //animatorPreview.TimeStep = animateInput.TimeStep;

                #region Old Code
                //horizBlind_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = animateInput.Duration;
                //horizBlind_UserControl.zeroitAnimate_Animator1.Interval = animateInput.Interval;
                //horizBlind_UserControl.zeroitAnimate_Animator1.TargetWidth = animateInput.TargetWidth;
                //horizBlind_UserControl.zeroitAnimate_Animator1.TargetHeight = animateInput.TargetHeight;
                //horizBlind_UserControl.zeroitAnimate_Animator1.TimeStep = animateInput.TimeStep; 
                #endregion

            }
            else if (animateInput.AnimationType == Transitions.AnimatorWithEditor.AnimationType.HorizSlide)
            {
                mainControl_AnimationType_ComboBox.SelectedIndex =
                    (int)Transitions.AnimatorWithEditor.AnimationType.HorizSlide;

                //animatorPreview.MaxAnimationTime = animateInput.Duration;
                //animatorPreview.Interval = animateInput.Interval;
                //animatorPreview.TargetWidth = animateInput.TargetWidth;
                //animatorPreview.TargetHeight = animateInput.TargetHeight;
                //animatorPreview.TimeStep = animateInput.TimeStep;

                #region Old Code
                //horizSlide_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = animateInput.Duration;
                //horizSlide_UserControl.zeroitAnimate_Animator1.Interval = animateInput.Interval;
                //horizSlide_UserControl.zeroitAnimate_Animator1.TargetWidth = animateInput.TargetWidth;
                //horizSlide_UserControl.zeroitAnimate_Animator1.TargetHeight = animateInput.TargetHeight;
                //horizSlide_UserControl.zeroitAnimate_Animator1.TimeStep = animateInput.TimeStep; 
                #endregion
            }
            else if (animateInput.AnimationType == Transitions.AnimatorWithEditor.AnimationType.HorizSlideAndRotate)
            {
                mainControl_AnimationType_ComboBox.SelectedIndex =
                    (int)Transitions.AnimatorWithEditor.AnimationType.HorizSlideAndRotate;

                //animatorPreview.MaxAnimationTime = animateInput.Duration;
                //animatorPreview.Interval = animateInput.Interval;
                //animatorPreview.TargetWidth = animateInput.TargetWidth;
                //animatorPreview.TargetHeight = animateInput.TargetHeight;
                //animatorPreview.TimeStep = animateInput.TimeStep;


                #region Old Code
                //horizSlideAndRotate_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = animateInput.Duration;
                //horizSlideAndRotate_UserControl.zeroitAnimate_Animator1.Interval = animateInput.Interval;
                //horizSlideAndRotate_UserControl.zeroitAnimate_Animator1.TargetWidth = animateInput.TargetWidth;
                //horizSlideAndRotate_UserControl.zeroitAnimate_Animator1.TargetHeight = animateInput.TargetHeight;
                //horizSlideAndRotate_UserControl.zeroitAnimate_Animator1.TimeStep = animateInput.TimeStep;

                #endregion
            }
            else if (animateInput.AnimationType == Transitions.AnimatorWithEditor.AnimationType.Leaf)
            {
                mainControl_AnimationType_ComboBox.SelectedIndex =
                    (int)Transitions.AnimatorWithEditor.AnimationType.Leaf;

                //animatorPreview.MaxAnimationTime = animateInput.Duration;
                //animatorPreview.Interval = animateInput.Interval;
                //animatorPreview.TargetWidth = animateInput.TargetWidth;
                //animatorPreview.TargetHeight = animateInput.TargetHeight;
                //animatorPreview.TimeStep = animateInput.TimeStep;

                #region Old Code
                //leaf_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = animateInput.Duration;
                //leaf_UserControl.zeroitAnimate_Animator1.Interval = animateInput.Interval;
                //leaf_UserControl.zeroitAnimate_Animator1.TargetWidth = animateInput.TargetWidth;
                //leaf_UserControl.zeroitAnimate_Animator1.TargetHeight = animateInput.TargetHeight;
                //leaf_UserControl.zeroitAnimate_Animator1.TimeStep = animateInput.TimeStep; 
                #endregion
            }
            else if (animateInput.AnimationType == Transitions.AnimatorWithEditor.AnimationType.Mosaic)
            {
                mainControl_AnimationType_ComboBox.SelectedIndex =
                    (int)Transitions.AnimatorWithEditor.AnimationType.Mosaic;

                //animatorPreview.MaxAnimationTime = animateInput.Duration;
                //animatorPreview.Interval = animateInput.Interval;
                //animatorPreview.TargetWidth = animateInput.TargetWidth;
                //animatorPreview.TargetHeight = animateInput.TargetHeight;
                //animatorPreview.TimeStep = animateInput.TimeStep;

                #region Old Code
                //mosaic_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = animateInput.Duration;
                //mosaic_UserControl.zeroitAnimate_Animator1.Interval = animateInput.Interval;
                //mosaic_UserControl.zeroitAnimate_Animator1.TargetWidth = animateInput.TargetWidth;
                //mosaic_UserControl.zeroitAnimate_Animator1.TargetHeight = animateInput.TargetHeight;
                //mosaic_UserControl.zeroitAnimate_Animator1.TimeStep = animateInput.TimeStep; 
                #endregion

            }
            else if (animateInput.AnimationType == Transitions.AnimatorWithEditor.AnimationType.Particles)
            {
                mainControl_AnimationType_ComboBox.SelectedIndex =
                    (int)Transitions.AnimatorWithEditor.AnimationType.Particles;

                //animatorPreview.MaxAnimationTime = animateInput.Duration;
                //animatorPreview.Interval = animateInput.Interval;
                //animatorPreview.TargetWidth = animateInput.TargetWidth;
                //animatorPreview.TargetHeight = animateInput.TargetHeight;
                //animatorPreview.TimeStep = animateInput.TimeStep;

                #region Old Code
                //particles_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = animateInput.Duration;
                //particles_UserControl.zeroitAnimate_Animator1.Interval = animateInput.Interval;
                //particles_UserControl.zeroitAnimate_Animator1.TargetWidth = animateInput.TargetWidth;
                //particles_UserControl.zeroitAnimate_Animator1.TargetHeight = animateInput.TargetHeight;
                //particles_UserControl.zeroitAnimate_Animator1.TimeStep = animateInput.TimeStep; 
                #endregion
            }
            else if (animateInput.AnimationType == Transitions.AnimatorWithEditor.AnimationType.Rotate)
            {
                mainControl_AnimationType_ComboBox.SelectedIndex =
                    (int)Transitions.AnimatorWithEditor.AnimationType.Rotate;

                //animatorPreview.MaxAnimationTime = animateInput.Duration;
                //animatorPreview.Interval = animateInput.Interval;
                //animatorPreview.TargetWidth = animateInput.TargetWidth;
                //animatorPreview.TargetHeight = animateInput.TargetHeight;
                //animatorPreview.TimeStep = animateInput.TimeStep;

                #region Old Code
                //rotate_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = animateInput.Duration;
                //rotate_UserControl.zeroitAnimate_Animator1.Interval = animateInput.Interval;
                //rotate_UserControl.zeroitAnimate_Animator1.TargetWidth = animateInput.TargetWidth;
                //rotate_UserControl.zeroitAnimate_Animator1.TargetHeight = animateInput.TargetHeight;
                //rotate_UserControl.zeroitAnimate_Animator1.TimeStep = animateInput.TimeStep; 
                #endregion

            }
            else if (animateInput.AnimationType == Transitions.AnimatorWithEditor.AnimationType.Scale)
            {
                mainControl_AnimationType_ComboBox.SelectedIndex =
                    (int)Transitions.AnimatorWithEditor.AnimationType.Scale;

                //animatorPreview.MaxAnimationTime = animateInput.Duration;
                //animatorPreview.Interval = animateInput.Interval;
                //animatorPreview.TargetWidth = animateInput.TargetWidth;
                //animatorPreview.TargetHeight = animateInput.TargetHeight;
                //animatorPreview.TimeStep = animateInput.TimeStep;

                #region Old Code
                //scale_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = animateInput.Duration;
                //scale_UserControl.zeroitAnimate_Animator1.Interval = animateInput.Interval;
                //scale_UserControl.zeroitAnimate_Animator1.TargetWidth = animateInput.TargetWidth;
                //scale_UserControl.zeroitAnimate_Animator1.TargetHeight = animateInput.TargetHeight;
                //scale_UserControl.zeroitAnimate_Animator1.TimeStep = animateInput.TimeStep; 
                #endregion

            }
            else if (animateInput.AnimationType == Transitions.AnimatorWithEditor.AnimationType.ScaleAndHorizSlide)
            {
                mainControl_AnimationType_ComboBox.SelectedIndex =
                    (int)Transitions.AnimatorWithEditor.AnimationType.ScaleAndHorizSlide;

                //animatorPreview.MaxAnimationTime = animateInput.Duration;
                //animatorPreview.Interval = animateInput.Interval;
                //animatorPreview.TargetWidth = animateInput.TargetWidth;
                //animatorPreview.TargetHeight = animateInput.TargetHeight;
                //animatorPreview.TimeStep = animateInput.TimeStep;


                #region Old Code
                //scaleAndHorizSlide_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = animateInput.Duration;
                //scaleAndHorizSlide_UserControl.zeroitAnimate_Animator1.Interval = animateInput.Interval;
                //scaleAndHorizSlide_UserControl.zeroitAnimate_Animator1.TargetWidth = animateInput.TargetWidth;
                //scaleAndHorizSlide_UserControl.zeroitAnimate_Animator1.TargetHeight = animateInput.TargetHeight;
                //scaleAndHorizSlide_UserControl.zeroitAnimate_Animator1.TimeStep = animateInput.TimeStep;

                #endregion
            }
            else if (animateInput.AnimationType == Transitions.AnimatorWithEditor.AnimationType.ScaleAndRotate)
            {
                mainControl_AnimationType_ComboBox.SelectedIndex =
                    (int)Transitions.AnimatorWithEditor.AnimationType.ScaleAndRotate;

                //animatorPreview.MaxAnimationTime = animateInput.Duration;
                //animatorPreview.Interval = animateInput.Interval;
                //animatorPreview.TargetWidth = animateInput.TargetWidth;
                //animatorPreview.TargetHeight = animateInput.TargetHeight;
                //animatorPreview.TimeStep = animateInput.TimeStep;


                #region Old Code
                //scaleAndRotate_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = animateInput.Duration;
                //scaleAndRotate_UserControl.zeroitAnimate_Animator1.Interval = animateInput.Interval;
                //scaleAndRotate_UserControl.zeroitAnimate_Animator1.TargetWidth = animateInput.TargetWidth;
                //scaleAndRotate_UserControl.zeroitAnimate_Animator1.TargetHeight = animateInput.TargetHeight;
                //scaleAndRotate_UserControl.zeroitAnimate_Animator1.TimeStep = animateInput.TimeStep;

                #endregion

            }
            else if (animateInput.AnimationType == Transitions.AnimatorWithEditor.AnimationType.Transparent)
            {
                mainControl_AnimationType_ComboBox.SelectedIndex =
                    (int)Transitions.AnimatorWithEditor.AnimationType.Transparent;

                //animatorPreview.MaxAnimationTime = animateInput.Duration;
                //animatorPreview.Interval = animateInput.Interval;
                //animatorPreview.TargetWidth = animateInput.TargetWidth;
                //animatorPreview.TargetHeight = animateInput.TargetHeight;
                //animatorPreview.TimeStep = animateInput.TimeStep;

                #region Old Code
                //transparent_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = animateInput.Duration;
                //transparent_UserControl.zeroitAnimate_Animator1.Interval = animateInput.Interval;
                //transparent_UserControl.zeroitAnimate_Animator1.TargetWidth = animateInput.TargetWidth;
                //transparent_UserControl.zeroitAnimate_Animator1.TargetHeight = animateInput.TargetHeight;
                //transparent_UserControl.zeroitAnimate_Animator1.TimeStep = animateInput.TimeStep; 
                #endregion

            }
            else if (animateInput.AnimationType == Transitions.AnimatorWithEditor.AnimationType.VertBlind)
            {
                mainControl_AnimationType_ComboBox.SelectedIndex =
                    (int)Transitions.AnimatorWithEditor.AnimationType.VertBlind;

                //animatorPreview.MaxAnimationTime = animateInput.Duration;
                //animatorPreview.Interval = animateInput.Interval;
                //animatorPreview.TargetWidth = animateInput.TargetWidth;
                //animatorPreview.TargetHeight = animateInput.TargetHeight;
                //animatorPreview.TimeStep = animateInput.TimeStep;

                #region Old Code
                //vertBlind_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = animateInput.Duration;
                //vertBlind_UserControl.zeroitAnimate_Animator1.Interval = animateInput.Interval;
                //vertBlind_UserControl.zeroitAnimate_Animator1.TargetWidth = animateInput.TargetWidth;
                //vertBlind_UserControl.zeroitAnimate_Animator1.TargetHeight = animateInput.TargetHeight;
                //vertBlind_UserControl.zeroitAnimate_Animator1.TimeStep = animateInput.TimeStep; 
                #endregion
            }
            else
            {
                mainControl_AnimationType_ComboBox.SelectedIndex =
                    (int)Transitions.AnimatorWithEditor.AnimationType.VertSlide;

                //animatorPreview.MaxAnimationTime = animateInput.Duration;
                //animatorPreview.Interval = animateInput.Interval;
                //animatorPreview.TargetWidth = animateInput.TargetWidth;
                //animatorPreview.TargetHeight = animateInput.TargetHeight;
                //animatorPreview.TimeStep = animateInput.TimeStep;

                #region Old Code
                //vertSlide_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = animateInput.Duration;
                //vertSlide_UserControl.zeroitAnimate_Animator1.Interval = animateInput.Interval;
                //vertSlide_UserControl.zeroitAnimate_Animator1.TargetWidth = animateInput.TargetWidth;
                //vertSlide_UserControl.zeroitAnimate_Animator1.TargetHeight = animateInput.TargetHeight;
                //vertSlide_UserControl.zeroitAnimate_Animator1.TimeStep = animateInput.TimeStep; 
                #endregion

            }

            mainControl_Duration_Numeric.Value = animateInput.Duration;
            mainControl_Interval_Numeric.Value = animateInput.Interval;
            mainControl_TargetWidth_Numeric.Value = animateInput.TargetWidth;
            mainControl_TargetHeight_Numeric.Value = animateInput.TargetHeight;
            //mainControl_TimeStep_Numeric.Value = (decimal)animateInput.TimeStep;

            animatorPreview.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value / 3;
            animatorPreview.TargetHeight = (int) mainControl_TargetHeight_Numeric.Value / 3;

            
        }


        /// <summary>
        /// Animations the property changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AnimationPropertyChanged(object sender, EventArgs e)
        {
            thematic1501.Controls.Add(custom_UserControl);
            custom_UserControl.Visible = false;

            animation_RotatingCube.Visible = true;
            animationProgress_Label.Visible = true;
            animation_Preview_Btn.Visible = true;

            if (mainControl_AnimationType_ComboBox.SelectedIndex == 
                (int)Transitions.AnimatorWithEditor.AnimationType.Custom)
            {
                animationType_Label.Text = "Custom Animation";
                animatorPreview.AnimationType = AnimationType.Custom;

                animatorPreview.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
                animatorPreview.Interval = (int)mainControl_Interval_Numeric.Value;
                animatorPreview.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
                animatorPreview.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
                //animatorPreview.TimeStep = (int)mainControl_TimeStep_Numeric.Value;

                animation_RotatingCube.Visible = false;
                animationProgress_Label.Visible = false;
                animation_Preview_Btn.Visible = false;

                custom_UserControl.Visible = true;
                custom_UserControl.Location = new Point(474, 36);

                custom_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
                custom_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
                custom_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value /3;
                custom_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value / 3;


            }

            else if (mainControl_AnimationType_ComboBox.SelectedIndex == 
                (int)Transitions.AnimatorWithEditor.AnimationType.HorizBlind)
            {
                animationType_Label.Text = "HorizBlind Animation";
                animatorPreview.AnimationType = AnimationType.HorizBlind;

                //animatorPreview.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;

                //horizBlind_UserControl.Visible = true;
                //horizBlind_UserControl.Location = new Point(505, 50);

                //horizBlind_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
                //horizBlind_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
                //horizBlind_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
                //horizBlind_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
                //horizBlind_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == 
                (int)Transitions.AnimatorWithEditor.AnimationType.HorizSlide)
            {
                animationType_Label.Text = "HorizSlide Animation";
                animatorPreview.AnimationType = AnimationType.HorizSlide;

                //horizSlide_UserControl.Visible = true;
                //horizSlide_UserControl.Location = new Point(505, 50);

                //horizSlide_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
                //horizSlide_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
                //horizSlide_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
                //horizSlide_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
                //horizSlide_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;


            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == 
                (int)Transitions.AnimatorWithEditor.AnimationType.HorizSlideAndRotate)
            {
                animationType_Label.Text = "HorizSlideAndRotate Animation";
                animatorPreview.AnimationType = AnimationType.HorizSlideAndRotate;

                //horizSlideAndRotate_UserControl.Visible = true;
                //horizSlideAndRotate_UserControl.Location = new Point(505, 50);

                //horizSlideAndRotate_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
                //horizSlideAndRotate_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
                //horizSlideAndRotate_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
                //horizSlideAndRotate_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
                //horizSlideAndRotate_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == 
                (int)Transitions.AnimatorWithEditor.AnimationType.Leaf)
            {
                animationType_Label.Text = "Leaf Animation";
                animatorPreview.AnimationType = AnimationType.Leaf;

                //leaf_UserControl.Visible = true;
                //leaf_UserControl.Location = new Point(505, 50);

                //leaf_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
                //leaf_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
                //leaf_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
                //leaf_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
                //leaf_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == 
                (int)Transitions.AnimatorWithEditor.AnimationType.Mosaic)
            {
                animationType_Label.Text = "Mosaic Animation";
                animatorPreview.AnimationType = AnimationType.Mosaic;

                //mosaic_UserControl.Visible = true;
                //mosaic_UserControl.Location = new Point(505, 50);

                //mosaic_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
                //mosaic_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
                //mosaic_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
                //mosaic_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
                //mosaic_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == 
                (int)Transitions.AnimatorWithEditor.AnimationType.Particles)
            {
                animationType_Label.Text = "Particles Animation";
                animatorPreview.AnimationType = AnimationType.Particles;

                //particles_UserControl.Visible = true;
                //particles_UserControl.Location = new Point(505, 50);

                //particles_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
                //particles_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
                //particles_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
                //particles_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
                //particles_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == 
                (int)Transitions.AnimatorWithEditor.AnimationType.Rotate)
            {
                animationType_Label.Text = "Rotate Animation";
                animatorPreview.AnimationType = AnimationType.Rotate;

                //rotate_UserControl.Visible = true;
                //rotate_UserControl.Location = new Point(505, 50);

                //rotate_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
                //rotate_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
                //rotate_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
                //rotate_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
                //rotate_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == 
                (int)Transitions.AnimatorWithEditor.AnimationType.Scale)
            {
                animationType_Label.Text = "Scale Animation";
                animatorPreview.AnimationType = AnimationType.Scale;

                //scale_UserControl.Visible = true;
                //scale_UserControl.Location = new Point(505, 50);

                //scale_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
                //scale_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
                //scale_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
                //scale_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
                //scale_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == 
                (int)Transitions.AnimatorWithEditor.AnimationType.ScaleAndHorizSlide)
            {
                animationType_Label.Text = "ScaleAndHorizSlide Animation";
                animatorPreview.AnimationType = AnimationType.ScaleAndHorizSlide;

                //scaleAndHorizSlide_UserControl.Visible = true;
                //scaleAndHorizSlide_UserControl.Location = new Point(505, 50);

                //scaleAndHorizSlide_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
                //scaleAndHorizSlide_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
                //scaleAndHorizSlide_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
                //scaleAndHorizSlide_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
                //scaleAndHorizSlide_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == 
                (int)Transitions.AnimatorWithEditor.AnimationType.ScaleAndRotate)
            {
                animationType_Label.Text = "ScaleAndRotate Animation";
                animatorPreview.AnimationType = AnimationType.ScaleAndRotate;

                //scaleAndRotate_UserControl.Visible = true;
                //scaleAndRotate_UserControl.Location = new Point(505, 50);

                //scaleAndRotate_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
                //scaleAndRotate_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
                //scaleAndRotate_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
                //scaleAndRotate_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
                //scaleAndHorizSlide_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == 
                (int)Transitions.AnimatorWithEditor.AnimationType.Transparent)
            {
                animationType_Label.Text = "Transparent Animation";
                animatorPreview.AnimationType = AnimationType.Transparent;

                //transparent_UserControl.Visible = true;
                //transparent_UserControl.Location = new Point(505, 50);

                //transparent_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
                //transparent_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
                //transparent_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
                //transparent_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
                //transparent_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == 
                (int)Transitions.AnimatorWithEditor.AnimationType.VertBlind)
            {
                animationType_Label.Text = "VertBlind Animation";
                animatorPreview.AnimationType = AnimationType.VertBlind;

                //vertBlind_UserControl.Visible = true;
                //vertBlind_UserControl.Location = new Point(505, 50);

                //vertBlind_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
                //vertBlind_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
                //vertBlind_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
                //vertBlind_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
                //vertBlind_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;

            }
            else
            {
                animationType_Label.Text = "VertSlide Animation";
                animatorPreview.AnimationType = AnimationType.VertSlide;

                //vertSlide_UserControl.Visible = true;
                //vertSlide_UserControl.Location = new Point(505, 50);

                //vertSlide_UserControl.zeroitAnimate_Animator1.MaxAnimationTime = (int)mainControl_Duration_Numeric.Value;
                //vertSlide_UserControl.zeroitAnimate_Animator1.Interval = (int)mainControl_Interval_Numeric.Value;
                //vertSlide_UserControl.zeroitAnimate_Animator1.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
                //vertSlide_UserControl.zeroitAnimate_Animator1.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
                //vertSlide_UserControl.zeroitAnimate_Animator1.TimeStep = (int)mainControl_TimeStep_Numeric.Value;


            }
        }

        /// <summary>
        /// Adds the user controls.
        /// </summary>
        private void AddUserControls()
        {
            

            thematic1501.Controls.Add(custom_UserControl);
            thematic1501.Controls.Add(horizBlind_UserControl);
            thematic1501.Controls.Add(horizSlide_UserControl);
            thematic1501.Controls.Add(horizSlideAndRotate_UserControl);
            thematic1501.Controls.Add(leaf_UserControl);
            thematic1501.Controls.Add(mosaic_UserControl);
            thematic1501.Controls.Add(particles_UserControl);
            thematic1501.Controls.Add(rotate_UserControl);
            thematic1501.Controls.Add(scale_UserControl);
            thematic1501.Controls.Add(scaleAndHorizSlide_UserControl);
            thematic1501.Controls.Add(scaleAndRotate_UserControl);
            thematic1501.Controls.Add(transparent_UserControl);
            thematic1501.Controls.Add(vertBlind_UserControl);
            thematic1501.Controls.Add(vertSlide_UserControl);

            custom_UserControl.Visible = false;
            horizBlind_UserControl.Visible = false;
            horizSlide_UserControl.Visible = false;
            horizSlideAndRotate_UserControl.Visible = false;
            leaf_UserControl.Visible = false;
            mosaic_UserControl.Visible = false;
            particles_UserControl.Visible = false;
            rotate_UserControl.Visible = false;
            scale_UserControl.Visible = false;
            scaleAndHorizSlide_UserControl.Visible = false;
            scaleAndRotate_UserControl.Visible = false;
            transparent_UserControl.Visible = false;
            vertBlind_UserControl.Visible = false;
            vertSlide_UserControl.Visible = false;
            

        }


        /// <summary>
        /// Sets the custom retrieved values.
        /// </summary>
        /// <param name="animateInput">The animate input.</param>
        private void Set_Custom_Retrieved_Values(AnimateInput animateInput)
        {
            animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)Enum.Parse(typeof(AnimationType),
                mainControl_AnimationType_ComboBox.SelectedItem.ToString());

            animateInput.Target = (Control) mainControl_Control_ComboBox.SelectedItem;
            animateInput.Duration = (int)mainControl_Duration_Numeric.Value;
            animateInput.Interval = (int)mainControl_Interval_Numeric.Value;
            animateInput.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            animateInput.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            
            
            animateInput.DefaultAnimation.BlindCoeff = new PointF((int)custom_UserControl.blind_Coeff_X_Numeric.Value, (int)custom_UserControl.blind_Coeff_Y_Numeric.Value);
            animateInput.DefaultAnimation.ScaleCoeff = new PointF((int)custom_UserControl.scale_Coeff_X_Numeric.Value, (int)custom_UserControl.scale_Coeff_Y_Numeric.Value);
            animateInput.DefaultAnimation.MosaicCoeff = new PointF((int)custom_UserControl.mosaic_Coeff_X_Numeric.Value, (int)custom_UserControl.mosaic_Coeff_Y_Numeric.Value);
            animateInput.DefaultAnimation.MosaicShift = new PointF((int)custom_UserControl.mosaic_Shift_X_Numeric.Value, (int)custom_UserControl.mosaic_Shift_Y_Numeric.Value);
            animateInput.DefaultAnimation.SlideCoeff = new PointF((int)custom_UserControl.slide_Coeff_X_Numeric.Value, (int)custom_UserControl.slide_Coeff_Y_Numeric.Value);

            if (custom_UserControl.animateDiff_Yes_RadioBtn.Checked)
            {
                animateInput.DefaultAnimation.AnimateOnlyDifferences = true;
            }
            else
            {
                animateInput.DefaultAnimation.AnimateOnlyDifferences = false;
            }

            animateInput.DefaultAnimation.LeafCoeff = (float)custom_UserControl.leaf_Coeff_Numeric.Value;
            animateInput.DefaultAnimation.RotateCoeff = (float)custom_UserControl.rotate_Coeff_Numeric.Value;
            animateInput.DefaultAnimation.RotateLimit = (float)custom_UserControl.rotate_Limit_Numeric.Value;
            animateInput.DefaultAnimation.TimeCoeff = (float)custom_UserControl.time_Coeff_Numeric.Value;
            animateInput.DefaultAnimation.LeafCoeff = (float)custom_UserControl.leaf_Coeff_Numeric.Value;
            animateInput.DefaultAnimation.MosaicSize = (int)custom_UserControl.mosaic_Size_Numeric.Value;
            animateInput.DefaultAnimation.TransparencyCoeff = (float)custom_UserControl.transparency_Coeff_Numeric.Value;
            animateInput.DefaultAnimation.MaxTime = (float)custom_UserControl.max_Time_Numeric.Value;
            animateInput.DefaultAnimation.MinTime = (float)custom_UserControl.min_Time_Numeric.Value;



        }

        /// <summary>
        /// Sets the horiz blind retrieved values.
        /// </summary>
        /// <param name="animateInput">The animate input.</param>
        private void Set_HorizBlind_Retrieved_Values(AnimateInput animateInput)
        {
            animateInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;
            
            //animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)mainControl_AnimationType_ComboBox.SelectedItem;
            animateInput.Duration = (int)mainControl_Duration_Numeric.Value;
            animateInput.Interval = (int)mainControl_Interval_Numeric.Value;
            animateInput.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            animateInput.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)Enum.Parse(typeof(AnimationType),
                mainControl_AnimationType_ComboBox.SelectedItem.ToString());
        }

        /// <summary>
        /// Sets the horiz slide retrieved values.
        /// </summary>
        /// <param name="animateInput">The animate input.</param>
        private void Set_HorizSlide_Retrieved_Values(AnimateInput animateInput)
        {
            animateInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            //animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)mainControl_AnimationType_ComboBox.SelectedItem;
            animateInput.Duration = (int)mainControl_Duration_Numeric.Value;
            animateInput.Interval = (int)mainControl_Interval_Numeric.Value;
            animateInput.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            animateInput.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)Enum.Parse(typeof(AnimationType),
                mainControl_AnimationType_ComboBox.SelectedItem.ToString());
        }

        /// <summary>
        /// Sets the horiz slide and rotate retrieved values.
        /// </summary>
        /// <param name="animateInput">The animate input.</param>
        private void Set_HorizSlideAndRotate_Retrieved_Values(AnimateInput animateInput)
        {
            animateInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            //animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)mainControl_AnimationType_ComboBox.SelectedItem;
            animateInput.Duration = (int)mainControl_Duration_Numeric.Value;
            animateInput.Interval = (int)mainControl_Interval_Numeric.Value;
            animateInput.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            animateInput.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)Enum.Parse(typeof(AnimationType),
                mainControl_AnimationType_ComboBox.SelectedItem.ToString());
        }

        /// <summary>
        /// Sets the leaf retrieved values.
        /// </summary>
        /// <param name="animateInput">The animate input.</param>
        private void Set_Leaf_Retrieved_Values(AnimateInput animateInput)
        {
            animateInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            //animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)mainControl_AnimationType_ComboBox.SelectedItem;
            animateInput.Duration = (int)mainControl_Duration_Numeric.Value;
            animateInput.Interval = (int)mainControl_Interval_Numeric.Value;
            animateInput.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            animateInput.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)Enum.Parse(typeof(AnimationType),
                mainControl_AnimationType_ComboBox.SelectedItem.ToString());
        }

        /// <summary>
        /// Sets the mosaic retrieved values.
        /// </summary>
        /// <param name="animateInput">The animate input.</param>
        private void Set_Mosaic_Retrieved_Values(AnimateInput animateInput)
        {
            animateInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            //animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)mainControl_AnimationType_ComboBox.SelectedItem;
            animateInput.Duration = (int)mainControl_Duration_Numeric.Value;
            animateInput.Interval = (int)mainControl_Interval_Numeric.Value;
            animateInput.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            animateInput.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)Enum.Parse(typeof(AnimationType),
                mainControl_AnimationType_ComboBox.SelectedItem.ToString());
        }

        /// <summary>
        /// Sets the particles retrieved values.
        /// </summary>
        /// <param name="animateInput">The animate input.</param>
        private void Set_Particles_Retrieved_Values(AnimateInput animateInput)
        {
            animateInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            //animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)mainControl_AnimationType_ComboBox.SelectedItem;
            animateInput.Duration = (int)mainControl_Duration_Numeric.Value;
            animateInput.Interval = (int)mainControl_Interval_Numeric.Value;
            animateInput.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            animateInput.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)Enum.Parse(typeof(AnimationType),
                mainControl_AnimationType_ComboBox.SelectedItem.ToString());
        }

        /// <summary>
        /// Sets the rotate retrieved values.
        /// </summary>
        /// <param name="animateInput">The animate input.</param>
        private void Set_Rotate_Retrieved_Values(AnimateInput animateInput)
        {
            animateInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            //animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)mainControl_AnimationType_ComboBox.SelectedItem;
            animateInput.Duration = (int)mainControl_Duration_Numeric.Value;
            animateInput.Interval = (int)mainControl_Interval_Numeric.Value;
            animateInput.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            animateInput.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)Enum.Parse(typeof(AnimationType),
                mainControl_AnimationType_ComboBox.SelectedItem.ToString());
        }

        /// <summary>
        /// Sets the scale retrieved values.
        /// </summary>
        /// <param name="animateInput">The animate input.</param>
        private void Set_Scale_Retrieved_Values(AnimateInput animateInput)
        {
            animateInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            //animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)mainControl_AnimationType_ComboBox.SelectedItem;
            animateInput.Duration = (int)mainControl_Duration_Numeric.Value;
            animateInput.Interval = (int)mainControl_Interval_Numeric.Value;
            animateInput.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            animateInput.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)Enum.Parse(typeof(AnimationType),
                mainControl_AnimationType_ComboBox.SelectedItem.ToString());
        }

        /// <summary>
        /// Sets the scale and horiz slide retrieved values.
        /// </summary>
        /// <param name="animateInput">The animate input.</param>
        private void Set_ScaleAndHorizSlide_Retrieved_Values(AnimateInput animateInput)
        {
            animateInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            //animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)mainControl_AnimationType_ComboBox.SelectedItem;
            animateInput.Duration = (int)mainControl_Duration_Numeric.Value;
            animateInput.Interval = (int)mainControl_Interval_Numeric.Value;
            animateInput.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            animateInput.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)Enum.Parse(typeof(AnimationType),
                mainControl_AnimationType_ComboBox.SelectedItem.ToString());
        }

        /// <summary>
        /// Sets the scale and rotate retrieved values.
        /// </summary>
        /// <param name="animateInput">The animate input.</param>
        private void Set_ScaleAndRotate_Retrieved_Values(AnimateInput animateInput)
        {
            animateInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            //animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)mainControl_AnimationType_ComboBox.SelectedItem;
            animateInput.Duration = (int)mainControl_Duration_Numeric.Value;
            animateInput.Interval = (int)mainControl_Interval_Numeric.Value;
            animateInput.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            animateInput.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)Enum.Parse(typeof(AnimationType),
                mainControl_AnimationType_ComboBox.SelectedItem.ToString());
        }

        /// <summary>
        /// Sets the transparent retrieved values.
        /// </summary>
        /// <param name="animateInput">The animate input.</param>
        private void Set_Transparent_Retrieved_Values(AnimateInput animateInput)
        {
            animateInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            //animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)mainControl_AnimationType_ComboBox.SelectedItem;
            animateInput.Duration = (int)mainControl_Duration_Numeric.Value;
            animateInput.Interval = (int)mainControl_Interval_Numeric.Value;
            animateInput.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            animateInput.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)Enum.Parse(typeof(AnimationType),
                mainControl_AnimationType_ComboBox.SelectedItem.ToString());
        }

        /// <summary>
        /// Sets the vert blind retrieved values.
        /// </summary>
        /// <param name="animateInput">The animate input.</param>
        private void Set_VertBlind_Retrieved_Values(AnimateInput animateInput)
        {
            animateInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            //animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)mainControl_AnimationType_ComboBox.SelectedItem;
            animateInput.Duration = (int)mainControl_Duration_Numeric.Value;
            animateInput.Interval = (int)mainControl_Interval_Numeric.Value;
            animateInput.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            animateInput.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)Enum.Parse(typeof(AnimationType),
                mainControl_AnimationType_ComboBox.SelectedItem.ToString());
        }

        /// <summary>
        /// Sets the vert slide retrieved values.
        /// </summary>
        /// <param name="animateInput">The animate input.</param>
        private void Set_VertSlide_Retrieved_Values(AnimateInput animateInput)
        {
            animateInput.Target = (Control)mainControl_Control_ComboBox.SelectedItem;

            //animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)mainControl_AnimationType_ComboBox.SelectedItem;
            animateInput.Duration = (int)mainControl_Duration_Numeric.Value;
            animateInput.Interval = (int)mainControl_Interval_Numeric.Value;
            animateInput.TargetWidth = (int)mainControl_TargetWidth_Numeric.Value;
            animateInput.TargetHeight = (int)mainControl_TargetHeight_Numeric.Value;
            animateInput.AnimationType = (Transitions.AnimatorWithEditor.AnimationType)Enum.Parse(typeof(AnimationType),
                mainControl_AnimationType_ComboBox.SelectedItem.ToString());
        }

        #endregion

        /// <summary>
        /// Handles the Click event of the okBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (mainControl_AnimationType_ComboBox.SelectedIndex == (int)Transitions.AnimatorWithEditor.AnimationType.Custom)
            {

                animateInput = new AnimateInput(AnimatorWithEditor.AnimationType.Custom,
                    10,
                    (int) 100,
                    (int) 100, //(float) 0.02f,
                    (int) 1500,
                    new AnimatorWithEditor.ZeroitAnimate_Animation(), new Control(),1);

                Set_Custom_Retrieved_Values(animateInput);

            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == (int)Transitions.AnimatorWithEditor.AnimationType.HorizBlind)
            {
                    animateInput = new AnimateInput(AnimatorWithEditor.AnimationType.HorizBlind,
                        10,
                        (int)100,
                        (int)100, //(float)0.02f,
                        (int)1500,
                        new AnimatorWithEditor.ZeroitAnimate_Animation(), new Control(), 1f, 1D);

                Set_HorizBlind_Retrieved_Values(animateInput);
            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == (int)Transitions.AnimatorWithEditor.AnimationType.HorizSlide)
            {
                    animateInput = new AnimateInput(AnimatorWithEditor.AnimationType.HorizSlide,
                        10,
                        (int)100,
                        (int)100, //(float)0.02f,
                        (int)1500,
                    new AnimatorWithEditor.ZeroitAnimate_Animation(),
                    new Control(), 2D);

                Set_HorizSlide_Retrieved_Values(animateInput);
            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == (int)Transitions.AnimatorWithEditor.AnimationType.HorizSlideAndRotate)
            {
                animateInput = new AnimateInput(AnimatorWithEditor.AnimationType.HorizSlideAndRotate,
                    10,
                    (int)100,
                    (int)100, //(float)0.02f,
                    (int)1500,
                    new AnimatorWithEditor.ZeroitAnimate_Animation(),
                    new Control(), 1, 1f);

                Set_HorizSlideAndRotate_Retrieved_Values(animateInput);
            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == (int)Transitions.AnimatorWithEditor.AnimationType.Leaf)
            {
                animateInput = new AnimateInput(AnimatorWithEditor.AnimationType.Leaf,
                    10,
                    (int)100,
                    (int)100, //(float)0.02f,
                    (int)1500,
                    new AnimatorWithEditor.ZeroitAnimate_Animation(),
                    new Control(), 1,1L);

                Set_Leaf_Retrieved_Values(animateInput);
            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == (int)Transitions.AnimatorWithEditor.AnimationType.Mosaic)
            {
                animateInput = new AnimateInput(AnimatorWithEditor.AnimationType.Mosaic,
                    10,
                    (int)100,
                    (int)100, //(float)0.02f,
                    (int)1500,
                    new AnimatorWithEditor.ZeroitAnimate_Animation(),
                    new Control(), 1, "");

                Set_Mosaic_Retrieved_Values(animateInput);
            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == (int)Transitions.AnimatorWithEditor.AnimationType.Particles)
            {
                animateInput = new AnimateInput(AnimatorWithEditor.AnimationType.Particles,
                    10,
                    (int)100,
                    (int)100, //(float)0.02f,
                    (int)1500,
                    new AnimatorWithEditor.ZeroitAnimate_Animation(),
                    new Control(), 1f,1);

                Set_Particles_Retrieved_Values(animateInput);
            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == (int)Transitions.AnimatorWithEditor.AnimationType.Rotate)
            {
                animateInput = new AnimateInput(AnimatorWithEditor.AnimationType.Rotate,
                    10,
                    (int)100,
                    (int)100, //(float)0.02f,
                    (int)1500,
                    new AnimatorWithEditor.ZeroitAnimate_Animation(), new Control(), 2f);

                Set_Rotate_Retrieved_Values(animateInput);
            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == (int)Transitions.AnimatorWithEditor.AnimationType.Scale)
            {
                animateInput = new AnimateInput(AnimatorWithEditor.AnimationType.Scale,
                    10,
                    (int)100,
                    (int)100, //(float)0.02f,
                    (int)1500,
                    new AnimatorWithEditor.ZeroitAnimate_Animation(),
                    new Control(), 2L);

                Set_Scale_Retrieved_Values(animateInput);
            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == (int)Transitions.AnimatorWithEditor.AnimationType.ScaleAndHorizSlide)
            {
                animateInput = new AnimateInput(AnimatorWithEditor.AnimationType.ScaleAndHorizSlide,
                    10,
                    (int)100,
                    (int)100, //(float)0.02f,
                    (int)1500,
                    new AnimatorWithEditor.ZeroitAnimate_Animation(),
                    new Control(), 1, 2D);

                Set_ScaleAndHorizSlide_Retrieved_Values(animateInput);
            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == (int)Transitions.AnimatorWithEditor.AnimationType.ScaleAndRotate)
            {
                animateInput = new AnimateInput(AnimatorWithEditor.AnimationType.ScaleAndRotate,
                    10,
                    (int)100,
                    (int)100, //(float)0.02f,
                    (int)1500,
                    new AnimatorWithEditor.ZeroitAnimate_Animation(),
                    new Control(), "");

                Set_ScaleAndRotate_Retrieved_Values(animateInput);
            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == (int)Transitions.AnimatorWithEditor.AnimationType.Transparent)
            {
                animateInput = new AnimateInput(AnimatorWithEditor.AnimationType.Transparent,
                    10,
                    (int)100,
                    (int)100, //(float)0.02f,
                    (int)1500,
                    new AnimatorWithEditor.ZeroitAnimate_Animation(),
                    new Control(), 1, (decimal)1);

                Set_Transparent_Retrieved_Values(animateInput);
            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == (int)Transitions.AnimatorWithEditor.AnimationType.VertBlind)
            {
                animateInput = new AnimateInput(AnimatorWithEditor.AnimationType.VertBlind,
                    10,
                    (int)100,
                    (int)100, //(float)0.02f,
                    (int)1500,
                    new AnimatorWithEditor.ZeroitAnimate_Animation(),
                    new Control(), 1f,1f);

                Set_VertBlind_Retrieved_Values(animateInput);
            }
            else if (mainControl_AnimationType_ComboBox.SelectedIndex == (int)Transitions.AnimatorWithEditor.AnimationType.VertSlide)
            {
                animateInput = new AnimateInput(AnimatorWithEditor.AnimationType.VertSlide,
                    10,
                    (int)100,
                    (int)100, //(float)0.02f,
                    (int)1500,
                    new AnimatorWithEditor.ZeroitAnimate_Animation(),
                    new Control(), (decimal)2.0);

                Set_VertSlide_Retrieved_Values(animateInput);

            }
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
            Knob5Remove();

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
            Knob5Remove();

        }


        /// <summary>
        /// Handles the Click event of the mainControl_Control_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Control_Numeric_Click(object sender, EventArgs e)
        {
            Knob1Remove();
            Knob2Remove();
            Knob3Remove();
            Knob4Remove();
            Knob5Remove();

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
            closeBtn.BackColor = Color.FromArgb(45,45,45);
        }

        /// <summary>
        /// Handles the MouseEnter event of the animation_Preview_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void animation_Preview_Btn_MouseEnter(object sender, EventArgs e)
        {
            animation_Preview_Btn.FlatAppearance.BorderSize = 1;
            animation_Preview_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the animation_Preview_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void animation_Preview_Btn_MouseLeave(object sender, EventArgs e)
        {
            animation_Preview_Btn.FlatAppearance.BorderSize = 0;
            animation_Preview_Btn.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
        }

        /// <summary>
        /// Handles the Click event of the animation_Preview_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void animation_Preview_Btn_Click(object sender, EventArgs e)
        {
            animatorPreview.Activate();
            //animationProgress_Label.Text = "Status : Animation in Progress...";

            timer.Tick += Progress_Start;
            timer.Interval = animatorPreview.MaxAnimationTime;
            timer.Start();

            
            
        }

        /// <summary>
        /// Handles the Start event of the Progress control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Progress_Start(object sender, EventArgs e)
        {
            TimeSpan timespan = new TimeSpan(0, 0, (int)1500);

            


            if (timespan.TotalMilliseconds == 0)
            {
                animationProgress_Label.Text = "Status : No Animation in Progress";

            }
            else if (timespan.TotalMilliseconds < animatorPreview.MaxAnimationTime)
            {
                animationProgress_Label.Text = "Status : Animation in Progress";
                
            }
            else
            {
                animationProgress_Label.Text = "Status : Animation Completed";

            }

        }

        /// <summary>
        /// Animators the preview animation completed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void animatorPreview_AnimationCompleted(object sender, AnimationCompletedEventArg e)
        {
            //animationProgress_Label.Text = "Status : Animation Completed";
        }
    }
}
