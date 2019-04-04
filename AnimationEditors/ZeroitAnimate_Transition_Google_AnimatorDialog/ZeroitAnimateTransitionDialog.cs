// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ZeroitAnimateTransitionDialog.cs" company="Zeroit Dev Technologies">
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
using Zeroit.Framework.Transitions.ZeroitAnimateTransitionWithEditor;
using Zeroit.Framework.Transitions._HelpingControls.LBKnob;

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    /// Class ZeroitAnimateTransitionDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ZeroitAnimateTransitionDialog : System.Windows.Forms.Form
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// at the default window position.
        /// </summary>
        public ZeroitAnimateTransitionDialog() : this(ZeroitTransitionInput.Empty())
        {
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        public ZeroitAnimateTransitionDialog(Control c) : this(ZeroitTransitionInput.Empty(), c)
        {
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="zeroitTransitionInput">The zeroit transition input.</param>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="filler" /> is null.</exception>
        public ZeroitAnimateTransitionDialog(ZeroitTransitionInput zeroitTransitionInput, Control c) : this(zeroitTransitionInput)
        {
            Zeroit.Framework.Transitions.AnimationEditors.Utilities.Draw.SetStartPositionBelowControl(this, c);
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// at the default window position.
        /// </summary>
        /// <param name="zeroitTransitionInput">The zeroit transition input.</param>
        /// <exception cref="ArgumentNullException">zeroitTransitionInput</exception>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="peaceInput" /> is null.</exception>
        public ZeroitAnimateTransitionDialog(ZeroitTransitionInput zeroitTransitionInput)
        {
            if (zeroitTransitionInput == null)
            {
                throw new ArgumentNullException("zeroitTransitionInput");
            }


            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            Knob1AnimatorCreated();
            Knob2AnimatorCreated();
            Knob3AnimatorCreated();


            Set_Initial_Values(zeroitTransitionInput);


            //AdjustDialogSize();
            //SetInitial_Values(pizaroAnimatorInput);

        }


        #endregion

        #region Private Fields

        /// <summary>
        /// The zeroit transition input
        /// </summary>
        private ZeroitTransitionInput zeroitTransitionInput;


        #endregion

        #region Public Properties


        /// <summary>
        /// Gets or sets the zeroit transition input.
        /// </summary>
        /// <value>The zeroit transition input.</value>
        public ZeroitTransitionInput ZeroitTransitionInput
        {
            get { return zeroitTransitionInput; }
            set
            {
                zeroitTransitionInput = value;
            }
        }

        #endregion

        #region KnobAnimators Creation

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

        #endregion

        #region Private Methods
        /// <summary>
        /// Knob1s the animator created.
        /// </summary>
        private void Knob1AnimatorCreated()
        {
            knob1Animator.Target = knob1;
            knob1Animator.AnimationType = AnimationType.Transparent;
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
            knob2Animator.AnimationType = AnimationType.Transparent;
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
            knob3Animator.AnimationType = AnimationType.Transparent;
            knob3Animator.TargetHeight = 121;
            knob3Animator.TargetWidth = 118;
            knob3Animator.Interval = 10;
            knob3Animator.MaxAnimationTime = 1500;
            knob3Animator.TimeStep = 0.02f;
        }




        #endregion

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
            this.knob1.Location = new System.Drawing.Point(331, 154);
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
            this.knob2.Location = new System.Drawing.Point(331, 217);
            this.knob2.MaxValue = (float)mainControl_Destination_Numeric.Maximum;
            this.knob2.MinValue = (float)mainControl_Destination_Numeric.Minimum;
            this.knob2.Renderer = null;
            //this.knob2.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.knob2.ScaleColor = Color.FromArgb(50, 50, 50);
            this.knob2.Size = new System.Drawing.Size(118, 121);
            this.knob2.StepValue = (float)mainControl_Destination_Numeric.Increment;
            this.knob2.Style = Zeroit.Framework.Transitions._HelpingControls.LBKnob.ZeroitLBKnob.KnobStyle.Circular;
            this.knob2.Value = (float)mainControl_Destination_Numeric.Value;
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
            this.knob3.Location = new System.Drawing.Point(331, 281);
            this.knob3.MaxValue = (float)mainControl_NoOfFlashes_Numeric.Maximum;
            this.knob3.MinValue = (float)mainControl_NoOfFlashes_Numeric.Minimum;
            this.knob3.Renderer = null;
            //this.knob3.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.knob3.ScaleColor = Color.FromArgb(50, 50, 50);
            this.knob3.Size = new System.Drawing.Size(118, 121);
            this.knob3.StepValue = (float)mainControl_NoOfFlashes_Numeric.Increment;
            this.knob3.Style = Zeroit.Framework.Transitions._HelpingControls.LBKnob.ZeroitLBKnob.KnobStyle.Circular;
            this.knob3.Value = (float)mainControl_NoOfFlashes_Numeric.Value;
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


        #endregion

        #region Knob Events
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
            mainControl_Destination_Numeric.Value = Convert.ToInt32(knob2.Value);
        }

        /// <summary>
        /// Handles the KnobChangeValue event of the Knob3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ZeroitLBKnobEventArgs"/> instance containing the event data.</param>
        private void Knob3_KnobChangeValue(object sender, ZeroitLBKnobEventArgs e)
        {
            mainControl_NoOfFlashes_Numeric.Value = Convert.ToInt32(knob3.Value);
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
            
            this.knob1.BringToFront();
            knob1Animator.Activate();


        }

        /// <summary>
        /// Handles the Click event of the showKnob2_Destination_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob2_Destination_Btn_Click(object sender, EventArgs e)
        {
            Knob2Created();
            Knob3Remove();
            Knob1Remove();
            this.knob2.BringToFront();
            knob2Animator.Activate();
        }

        /// <summary>
        /// Handles the Click event of the showKnob3_NoOfFlashes_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob3_NoOfFlashes_Btn_Click(object sender, EventArgs e)
        {
            Knob3Created();
            Knob1Remove();
            Knob2Remove();
            

            this.knob3.BringToFront();
            knob3Animator.Activate();
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
        /// Handles the MouseEnter event of the showKnob2_Destination_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob2_Destination_Btn_MouseEnter(object sender, EventArgs e)
        {
            showKnob2_Destination_Btn.FlatAppearance.BorderSize = 1;
            showKnob2_Destination_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the showKnob2_Destination_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob2_Destination_Btn_MouseLeave(object sender, EventArgs e)
        {
            showKnob2_Destination_Btn.FlatAppearance.BorderSize = 0;
            showKnob2_Destination_Btn.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
        }

        /// <summary>
        /// Handles the MouseEnter event of the showKnob3_NoOfFlashes_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob3_NoOfFlashes_Btn_MouseEnter(object sender, EventArgs e)
        {
            showKnob3_NoOfFlashes_Btn.FlatAppearance.BorderSize = 1;
            showKnob3_NoOfFlashes_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the showKnob3_NoOfFlashes_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void showKnob3_NoOfFlashes_Btn_MouseLeave(object sender, EventArgs e)
        {
            showKnob3_NoOfFlashes_Btn.FlatAppearance.BorderSize = 0;
            showKnob3_NoOfFlashes_Btn.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
        }


        #endregion

        /// <summary>
        /// Sets the initial values.
        /// </summary>
        /// <param name="zeroitTransitionInput">The zeroit transition input.</param>
        private void Set_Initial_Values(ZeroitTransitionInput zeroitTransitionInput)
        {


            #region Control

            foreach (var controlNames in zeroitTransitionInput.Target.FindForm().Controls)
            {
                mainControl_Control_ComboBox.Items.Add(controlNames);

            }
            mainControl_Control_ComboBox.Items.Add(zeroitTransitionInput.Target.FindForm());


            for (int i = 0; i < mainControl_Control_ComboBox.Items.Count; i++)
            {
                if (zeroitTransitionInput.Target == (Control)(mainControl_Control_ComboBox.Items[i]))
                {
                    mainControl_Control_ComboBox.SelectedIndex = i;

                }

            }
            #endregion
            
            #region Add Transitions to mainControl_Transition_ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string volume in Enum.GetNames(typeof(ZeroitTransitorEdit.TransitionType)))
            {
                mainControl_Transition_ComboBox.Items.Add(volume);

            }

            for (int i = 0; i < mainControl_Transition_ComboBox.Items.Count; i++)
            {
                if (zeroitTransitionInput.Transitions == 
                    (ZeroitTransitorEdit.TransitionType)Enum.Parse(typeof(ZeroitTransitorEdit.TransitionType), mainControl_Transition_ComboBox.Items[i].ToString()))
                {
                    mainControl_Transition_ComboBox.SelectedIndex = i;
                    
                }

            }
            #endregion

            #region Add Position to mainControl_Transition_ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string volume in Enum.GetNames(typeof(ZeroitTransitorEdit.Positions)))
            {
                mainControl_Position_ComboBox.Items.Add(volume);

                
            }

            for (int i = 0; i < mainControl_Position_ComboBox.Items.Count; i++)
            {
                if (zeroitTransitionInput.Position ==
                    (ZeroitTransitorEdit.Positions)Enum.Parse(typeof(ZeroitTransitorEdit.Positions), mainControl_Position_ComboBox.Items[i].ToString()))
                {
                    mainControl_Position_ComboBox.SelectedIndex = i;
                    
                }

            }
            #endregion

            mainControl_Duration_Numeric.Value = (int) zeroitTransitionInput.TransitionTime;

            mainControl_Destination_Numeric.Value = (int)zeroitTransitionInput.Destination;

            mainControl_NoOfFlashes_Numeric.Value = (int)zeroitTransitionInput.No_Of_Flashes;


            #region Animation Previewer

            transitionAnimator.TransitionTime = zeroitTransitionInput.TransitionTime;

            transitionAnimator.Destination = zeroitTransitionInput.Destination/2;

            transitionAnimator.No_Of_Flashes = zeroitTransitionInput.No_Of_Flashes;

            

            #endregion

        }

        /// <summary>
        /// Sets the retrieved values.
        /// </summary>
        /// <param name="zeroitTransitionInput">The zeroit transition input.</param>
        private void Set_Retrieved_Values(ZeroitTransitionInput zeroitTransitionInput)
        {
            zeroitTransitionInput.Target = (Control) mainControl_Control_ComboBox.SelectedItem;

            zeroitTransitionInput.Transitions = (ZeroitTransitorEdit.TransitionType) Enum.Parse(
                typeof(ZeroitTransitorEdit.TransitionType),
                mainControl_Transition_ComboBox.SelectedItem.ToString());

            zeroitTransitionInput.Position = (ZeroitTransitorEdit.Positions)Enum.Parse(
                typeof(ZeroitTransitorEdit.Positions),
                mainControl_Position_ComboBox.SelectedItem.ToString());

            zeroitTransitionInput.TransitionTime = (int)mainControl_Duration_Numeric.Value;

            zeroitTransitionInput.Destination = (int)mainControl_Destination_Numeric.Value;

            zeroitTransitionInput.No_Of_Flashes = (int)mainControl_NoOfFlashes_Numeric.Value;
            
        }


        /// <summary>
        /// Transitions the changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TransitionChanged(object sender, EventArgs e)
        {
            //transitionAnimator.Transitions = (ZeroitTransitor.TransitionType)Enum.Parse(
            //    typeof(ZeroitTransitor.Positions),
            //    mainControl_Transition_ComboBox.SelectedItem.ToString());

            transitionAnimator.Transitions = (ZeroitTransitor.TransitionType)mainControl_Transition_ComboBox.SelectedIndex;

            animation_GroupBox.Text = mainControl_Transition_ComboBox.SelectedItem.ToString() + " Animation";

            Knob1Remove();
            Knob2Remove();
            Knob3Remove();
        }

        /// <summary>
        /// Positions the changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void PositionChanged(object sender, EventArgs e)
        {
            //transitionAnimator.Position = (ZeroitTransitor.Positions) Enum.Parse(
            //    typeof(ZeroitTransitor.Positions),
            //    mainControl_Position_ComboBox.SelectedItem.ToString());

            transitionAnimator.Position = (ZeroitTransitor.Positions)mainControl_Position_ComboBox.SelectedIndex;

            Knob1Remove();
            Knob2Remove();
            Knob3Remove();
        }

        /// <summary>
        /// Handles the Click event of the okBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (mainControl_Transition_ComboBox.SelectedIndex == (int)ZeroitTransitorEdit.TransitionType.Accelaration)
            {

                zeroitTransitionInput = new ZeroitTransitionInput(
                    ZeroitTransitorEdit.TransitionType.Accelaration, 100,
                    ZeroitTransitorEdit.Positions.Left, 2000, 1, new Control(), 1);

                Set_Retrieved_Values(zeroitTransitionInput);

            }
            else if (mainControl_Transition_ComboBox.SelectedIndex ==
                     (int) ZeroitTransitorEdit.TransitionType.Bounce)
            {
                zeroitTransitionInput = new ZeroitTransitionInput(
                    ZeroitTransitorEdit.TransitionType.Bounce, 100,
                    ZeroitTransitorEdit.Positions.Left, 2000, 1, new Control(), 1f);

                Set_Retrieved_Values(zeroitTransitionInput);
            }

            else if (mainControl_Transition_ComboBox.SelectedIndex ==
                     (int)ZeroitTransitorEdit.TransitionType.CriticalDamping)
            {
                zeroitTransitionInput = new ZeroitTransitionInput(
                    ZeroitTransitorEdit.TransitionType.CriticalDamping, 100,
                    ZeroitTransitorEdit.Positions.Left, 2000, 1, new Control(), 1D);

                Set_Retrieved_Values(zeroitTransitionInput);
            }

            else if (mainControl_Transition_ComboBox.SelectedIndex ==
                     (int)ZeroitTransitorEdit.TransitionType.Deceleration)
            {
                zeroitTransitionInput = new ZeroitTransitionInput(
                    ZeroitTransitorEdit.TransitionType.Deceleration, 100,
                    ZeroitTransitorEdit.Positions.Left, 2000, 1, new Control(), (decimal)1);

                Set_Retrieved_Values(zeroitTransitionInput);
            }

            else if (mainControl_Transition_ComboBox.SelectedIndex ==
                     (int)ZeroitTransitorEdit.TransitionType.EaseInEaseOut)
            {
                zeroitTransitionInput = new ZeroitTransitionInput(
                    ZeroitTransitorEdit.TransitionType.EaseInEaseOut, 100,
                    ZeroitTransitorEdit.Positions.Left, 2000, 1, new Control(), (long)1);

                Set_Retrieved_Values(zeroitTransitionInput);
            }

            else if (mainControl_Transition_ComboBox.SelectedIndex ==
                     (int)ZeroitTransitorEdit.TransitionType.Flash)
            {
                zeroitTransitionInput = new ZeroitTransitionInput(
                    ZeroitTransitorEdit.TransitionType.Flash, 100,
                    ZeroitTransitorEdit.Positions.Left, 2000, 1, new Control(), "");

                Set_Retrieved_Values(zeroitTransitionInput);
            }

            else if (mainControl_Transition_ComboBox.SelectedIndex ==
                     (int)ZeroitTransitorEdit.TransitionType.Linear)
            {
                zeroitTransitionInput = new ZeroitTransitionInput(
                    ZeroitTransitorEdit.TransitionType.Linear, 100,
                    ZeroitTransitorEdit.Positions.Left, 2000, 1, new Control(), false);

                Set_Retrieved_Values(zeroitTransitionInput);
            }

            else if (mainControl_Transition_ComboBox.SelectedIndex ==
                     (int)ZeroitTransitorEdit.TransitionType.ThrowAndCatch)
            {
                zeroitTransitionInput = new ZeroitTransitionInput(
                    ZeroitTransitorEdit.TransitionType.ThrowAndCatch, 100,
                    ZeroitTransitorEdit.Positions.Left, 2000, 1, new Control(), 1,1);

                Set_Retrieved_Values(zeroitTransitionInput);
            }

            else if (mainControl_Transition_ComboBox.SelectedIndex ==
                     (int)ZeroitTransitorEdit.TransitionType.Zeroit)
            {
                zeroitTransitionInput = new ZeroitTransitionInput(
                    ZeroitTransitorEdit.TransitionType.Zeroit, 100,
                    ZeroitTransitorEdit.Positions.Left, 2000, 1, new Control(), 1, 1f);

                Set_Retrieved_Values(zeroitTransitionInput);
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
        /// Handles the Click event of the closeBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }

        /// <summary>
        /// Handles the Click event of the mainControl_Destination_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Destination_Numeric_Click(object sender, EventArgs e)
        {
            knob2.ScaleColor = Color.FromArgb(50, 50, 50);

            Knob1Remove();
            Knob3Remove();
        }

        /// <summary>
        /// Handles the Click event of the mainControl_NoOfFlashes_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_NoOfFlashes_Numeric_Click(object sender, EventArgs e)
        {
            knob3.ScaleColor = Color.FromArgb(50, 50, 50);

            Knob1Remove();
            Knob2Remove();
            
        }

        /// <summary>
        /// Handles the Enter event of the animation_GroupBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void animation_GroupBox_Enter(object sender, EventArgs e)
        {
            Knob1Remove();
            Knob2Remove();
            Knob3Remove();
        }

        /// <summary>
        /// Handles the Click event of the animation_Preview_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void animation_Preview_Btn_Click(object sender, EventArgs e)
        {
            Knob1Remove();
            Knob2Remove();
            Knob3Remove();

            transitionAnimator.Activate();
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
            animation_Preview_Btn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
        }

        /// <summary>
        /// Handles the ValueChanged event of the mainControl_Duration_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Duration_Numeric_ValueChanged(object sender, EventArgs e)
        {
            knob1.ScaleColor = Color.Cyan;

            transitionAnimator.TransitionTime = (int)mainControl_Duration_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the mainControl_Destination_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Destination_Numeric_ValueChanged(object sender, EventArgs e)
        {
            knob2.ScaleColor = Color.Cyan;

            transitionAnimator.Destination = (int)mainControl_Destination_Numeric.Value/2;
        }

        /// <summary>
        /// Handles the ValueChanged event of the mainControl_NoOfFlashes_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_NoOfFlashes_Numeric_ValueChanged(object sender, EventArgs e)
        {
            knob3.ScaleColor = Color.Cyan;

            transitionAnimator.No_Of_Flashes = (int)mainControl_NoOfFlashes_Numeric.Value;
        }
        
    }
}
