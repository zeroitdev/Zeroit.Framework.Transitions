// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="AtomicAnimatorDialog.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Windows.Forms;
using Zeroit.Framework.Transitions.AtomicAnimator;

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    /// Class AtomicAnimatorDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AtomicAnimatorDialog : System.Windows.Forms.Form
    {

        #region Constants

        /// <summary>
        /// The back color atomic
        /// </summary>
        private const int BackColor_Atomic = 0;
        /// <summary>
        /// The fore color atomic
        /// </summary>
        private const int ForeColor_Atomic = 1;
        /// <summary>
        /// The location atomic
        /// </summary>
        private const int Location_Atomic = 2;
        /// <summary>
        /// The size atomic
        /// </summary>
        private const int Size_Atomic = 3;
        /// <summary>
        /// The none atomic
        /// </summary>
        private const int None_Atomic = 4;

        /// <summary>
        /// The no
        /// </summary>
        private const int No = 0;
        /// <summary>
        /// The yes
        /// </summary>
        private const int Yes = 1;

        /// <summary>
        /// The default
        /// </summary>
        private const int Default = 0;
        /// <summary>
        /// The ease in
        /// </summary>
        private const int EaseIn = 1;
        /// <summary>
        /// The ease out
        /// </summary>
        private const int EaseOut = 2;
        /// <summary>
        /// The ease in ease out
        /// </summary>
        private const int EaseInEaseOut = 3;
        /// <summary>
        /// The linear
        /// </summary>
        private const int Linear = 4;
        /// <summary>
        /// The custom animation2 points
        /// </summary>
        private const int CustomAnimation2Points = 5;
        /// <summary>
        /// The custom animation3 points
        /// </summary>
        private const int CustomAnimation3Points = 6;
        /// <summary>
        /// The custom animation4 points
        /// </summary>
        private const int CustomAnimation4Points = 7;


        #endregion

        #region Public Properties

        /// <summary>
        /// The atomic animator input
        /// </summary>
        private AtomicAnimatorInput atomicAnimatorInput;

        /// <summary>
        /// Gets the atomic animator input.
        /// </summary>
        /// <value>The atomic animator input.</value>
        public AtomicAnimatorInput AtomicAnimatorInput
        {
            get { return atomicAnimatorInput; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// at the default window position.
        /// </summary>
        public AtomicAnimatorDialog() : this(AtomicAnimatorInput.Empty())
        {
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// at the default window position.
        /// </summary>
        /// <param name="atomicAnimatorInput">The atomic animator input.</param>
        /// <exception cref="ArgumentNullException">atomicAnimatorInput</exception>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="peaceInput" /> is null.</exception>
        public AtomicAnimatorDialog(AtomicAnimatorInput atomicAnimatorInput)
        {
            if (atomicAnimatorInput == null)
            {
                throw new ArgumentNullException("atomicAnimatorInput");
            }

            
            InitializeComponent();


            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            

            AdjustDialogSize();
            SetInitial_Values(atomicAnimatorInput);
            SetControl_BackColor_To_Initial_Values(atomicAnimatorInput);
            SetControl_ForeColor_To_Initial_Values(atomicAnimatorInput);
            SetControl_Size_To_Initial_Values(atomicAnimatorInput);
            SetControl_Location_To_Initial_Values(atomicAnimatorInput);
            

        }


        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        public AtomicAnimatorDialog(Control c) : this(AtomicAnimatorInput.Empty(), c)
        {
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="atomicAnimatorInput">The atomic animator input.</param>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="filler" /> is null.</exception>
        public AtomicAnimatorDialog(AtomicAnimatorInput atomicAnimatorInput, Control c) : this(atomicAnimatorInput)
        {
            Zeroit.Framework.Transitions.AnimationEditors.Utilities.Draw.SetStartPositionBelowControl(this, c);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Adjusts the size of the dialog.
        /// </summary>
        private void AdjustDialogSize()
        {
            // Three different possible group boxes - move them all to one coordinate
            int x = backColor_GroupBox.Location.X;
            int y = general_Container.Location.Y;

            backColor_GroupBox.Location = new Point(x, y);
            foreColor_GroupBox.Location = new Point(x, y);
            size_GroupBox.Location = new Point(x, y);
            location_GroupBox.Location = new Point(x, y);

            //formName.Location = new Point(typeGroupBox.Location.X, formName.Location.Y - 5);

            int bottomY = Math.Max(backColor_GroupBox.Bounds.Bottom,
                Math.Max(foreColor_GroupBox.Bounds.Bottom,
                    Math.Max(size_GroupBox.Bounds.Bottom,
                        Math.Max(location_GroupBox.Bounds.Bottom,

                        general_Container.Bounds.Bottom))));



            int newHeight = bottomY + general_Container.Location.Y;

            this.Size = new Size(Size.Width, Size.Height - (ClientSize.Height - newHeight));
        }

        /// <summary>
        /// Properties the type changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void PropertyTypeChanged(object sender, EventArgs e)
        {
            backColor_GroupBox.Visible = false;
            foreColor_GroupBox.Visible = false;
            size_GroupBox.Visible = false;
            location_GroupBox.Visible = false;

            if (mainControl_animationProperty_Combo.SelectedIndex == BackColor_Atomic)
            {
                backColor_GroupBox.Visible = true;

            }
            else if (mainControl_animationProperty_Combo.SelectedIndex == ForeColor_Atomic)
            {
                foreColor_GroupBox.Visible = true;
            }
            else if (mainControl_animationProperty_Combo.SelectedIndex == Size_Atomic)
            {
                size_GroupBox.Visible = true;
            }
            else if (mainControl_animationProperty_Combo.SelectedIndex == Location_Atomic)
            {
                location_GroupBox.Visible = true;
            }
            else if (mainControl_animationProperty_Combo.SelectedIndex == None_Atomic)
            {
                backColor_GroupBox.Visible = false;
                foreColor_GroupBox.Visible = false;
                size_GroupBox.Visible = false;
                location_GroupBox.Visible = false;
            }




        }

        /// <summary>
        /// Sets the initial values.
        /// </summary>
        /// <param name="atomicAnimatorInput">The atomic animator input.</param>
        private void SetInitial_Values(AtomicAnimatorInput atomicAnimatorInput)
        {

            mainControl_animationProperty_Combo.SelectedIndex = Size_Atomic;
            mainControl_Reverse_ComboBox.SelectedIndex = Yes;
            mainControl_Transition_ComboBox.SelectedIndex = EaseInEaseOut;
            mainControl_Duration_Numeric.Value = (decimal)atomicAnimatorInput.Duration;

            backColor_Point1_X_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint1X;
            backColor_Point1_Y_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint1Y;
            backColor_Point2_X_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint2X;
            backColor_Point2_Y_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint2Y;
            backColor_Point3_X_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint3X;
            backColor_Point3_Y_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint3Y;
            backColor_Point4_X_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint4X;
            backColor_Point4_Y_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint4Y;
            backColor_Color_btn.BackColor = atomicAnimatorInput.ControlBackColor;

            foreColor_Point1_X_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint1X;
            foreColor_Point1_Y_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint1Y;
            foreColor_Point2_X_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint2X;
            foreColor_Point2_Y_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint2Y;
            foreColor_Point3_X_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint3X;
            foreColor_Point3_Y_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint3Y;
            foreColor_Point4_X_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint4X;
            foreColor_Point4_Y_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint4Y;
            foreColor_Color_btn.BackColor = atomicAnimatorInput.ControlForeColor;

            size_Point1_X_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint1X;
            size_Point1_Y_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint1Y;
            size_Point2_X_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint2X;
            size_Point2_Y_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint2Y;
            size_Point3_X_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint3X;
            size_Point3_Y_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint3Y;
            size_Point4_X_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint4X;
            size_Point4_Y_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint4Y;
            size_Width_Numeric.Value = (decimal)atomicAnimatorInput.ControlAnimationSize.Width;
            size_Height_Numeric.Value = (decimal)atomicAnimatorInput.ControlAnimationSize.Height;


            location_Point1_X_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint1X;
            location_Point1_Y_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint1Y;
            location_Point2_X_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint2X;
            location_Point2_Y_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint2Y;
            location_Point3_X_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint3X;
            location_Point3_Y_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint3Y;
            location_Point4_X_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint4X;
            location_Point4_Y_Numeric.Value = (decimal)atomicAnimatorInput.CustomAnimationPoint4Y;
            location_X_Cordinate_Numeric.Value = (decimal)atomicAnimatorInput.ControlLocation.X;
            location_Y_Cordinate_Numeric.Value = (decimal)atomicAnimatorInput.ControlLocation.Y;

            foreach (var controlNames in atomicAnimatorInput.Control.FindForm().Controls)
            {
                mainControl_Control_ComboBox.Items.Add(controlNames);

            }
            mainControl_Control_ComboBox.Items.Add(atomicAnimatorInput.Control.FindForm());


            for (int i = 0; i < mainControl_Control_ComboBox.Items.Count; i++)
            {
                if (atomicAnimatorInput.Control == (Control)(mainControl_Control_ComboBox.Items[i]))
                {
                    mainControl_Control_ComboBox.SelectedIndex = i;
                }

            }
        }

        /// <summary>
        /// Sets the control back color to initial values.
        /// </summary>
        /// <param name="atomicAnimatorInput">The atomic animator input.</param>
        private void SetControl_BackColor_To_Initial_Values(AtomicAnimatorInput atomicAnimatorInput)
        {
            if (atomicAnimatorInput.AnimatedProperty == Transitions.AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.BackColor)
            {

                mainControl_animationProperty_Combo.SelectedIndex = BackColor_Atomic;
                backColor_GroupBox.Visible = true;
                

                for (int i = 0; i < mainControl_Control_ComboBox.Items.Count; i++)
                {
                    if ((Control) (mainControl_Control_ComboBox.Items[i]) == atomicAnimatorInput.Control)
                    {
                        mainControl_Control_ComboBox.SelectedIndex = i;

                    }

                }
            }

            else if (atomicAnimatorInput.AnimatedProperty == Transitions.AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.ForeColor)
            {
                foreColor_GroupBox.Visible = true;
                mainControl_animationProperty_Combo.SelectedIndex = ForeColor_Atomic;

            }

            else if (atomicAnimatorInput.AnimatedProperty == Transitions.AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.Size)
            {
                size_GroupBox.Visible = true;
                mainControl_animationProperty_Combo.SelectedIndex = Size_Atomic;
            }

            else if (atomicAnimatorInput.AnimatedProperty == Transitions.AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.Location)
            {
                mainControl_animationProperty_Combo.SelectedIndex = Location_Atomic;
                location_GroupBox.Visible = true;
            }

            else
            {
                mainControl_animationProperty_Combo.SelectedIndex = None_Atomic;
                backColor_GroupBox.Visible = false;
                foreColor_GroupBox.Visible = false;
                size_GroupBox.Visible = false;
                location_GroupBox.Visible = false;

            }
        }

        /// <summary>
        /// Sets the control back color retrieved values.
        /// </summary>
        /// <param name="atomicAnimatorInput">The atomic animator input.</param>
        private void SetControl_BackColor_Retrieved_Values(AtomicAnimatorInput atomicAnimatorInput)
        {
            
            atomicAnimatorInput.Control = (Control)mainControl_Control_ComboBox.SelectedItem;

            #region Animated Property

            if(mainControl_animationProperty_Combo.SelectedIndex == BackColor_Atomic)
            {
                atomicAnimatorInput.AnimatedProperty = AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.BackColor;

                atomicAnimatorInput.CustomAnimationPoint1X = (float)backColor_Point1_X_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint1Y = (float)backColor_Point1_Y_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint2X = (float)backColor_Point2_X_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint2Y = (float)backColor_Point2_Y_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint3X = (float)backColor_Point3_X_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint3Y = (float)backColor_Point3_Y_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint4X = (float)backColor_Point4_X_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint4Y = (float)backColor_Point4_Y_Numeric.Value;
                atomicAnimatorInput.ControlBackColor = backColor_Color_btn.BackColor;
            }

            else if (mainControl_animationProperty_Combo.SelectedIndex == ForeColor_Atomic)
            {
                atomicAnimatorInput.AnimatedProperty = AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.ForeColor;

                //atomicAnimatorInput.CustomAnimationPoint1X = (float)foreColor_Point1_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint1Y = (float)foreColor_Point1_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2X = (float)foreColor_Point2_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2Y = (float)foreColor_Point2_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3X = (float)foreColor_Point3_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3Y = (float)foreColor_Point3_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4X = (float)foreColor_Point4_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4Y = (float)foreColor_Point4_Y_Numeric.Value;
                //atomicAnimatorInput.ControlForeColor = foreColor_Color_btn.BackColor;
            }

            else if (mainControl_animationProperty_Combo.SelectedIndex == Size_Atomic)
            {
                atomicAnimatorInput.AnimatedProperty = AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.Size;

                //atomicAnimatorInput.CustomAnimationPoint1X = (float)size_Point1_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint1Y = (float)size_Point1_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2X = (float)size_Point2_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2Y = (float)size_Point2_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3X = (float)size_Point3_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3Y = (float)size_Point3_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4X = (float)size_Point4_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4Y = (float)size_Point4_Y_Numeric.Value;
            }

            else if (mainControl_animationProperty_Combo.SelectedIndex == Location_Atomic)
            {
                atomicAnimatorInput.AnimatedProperty = AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.Location;

                //atomicAnimatorInput.CustomAnimationPoint1X = (float)location_Point1_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint1Y = (float)location_Point1_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2X = (float)location_Point2_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2Y = (float)location_Point2_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3X = (float)location_Point3_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3Y = (float)location_Point3_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4X = (float)location_Point4_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4Y = (float)location_Point4_Y_Numeric.Value;
            }

            else 
            {
                atomicAnimatorInput.AnimatedProperty = AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.None;
            }

            #endregion

            #region Reverse

            if(mainControl_Reverse_ComboBox.SelectedIndex == Yes)
            {
                atomicAnimatorInput.Reverse = true;
            }
            else
            {
                atomicAnimatorInput.Reverse = false;
            }

            #endregion

            #region Transition
            if(mainControl_Transition_ComboBox.SelectedIndex == Default)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.Default;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == EaseIn)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.EaseIn;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == EaseOut)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.EaseOut;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == EaseInEaseOut)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.EaseInEaseOut;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == Linear)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.Linear;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == CustomAnimation2Points)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.CustomAnimation2Points;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == CustomAnimation3Points)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.CustomAnimation3Points;
            }
            else
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.CustomAnimation4Points;
            }
            #endregion

            #region Duration

            atomicAnimatorInput.Duration = (float)mainControl_Duration_Numeric.Value;
            
            #endregion

        }

        /// <summary>
        /// Sets the control fore color to initial values.
        /// </summary>
        /// <param name="atomicAnimatorInput">The atomic animator input.</param>
        private void SetControl_ForeColor_To_Initial_Values(AtomicAnimatorInput atomicAnimatorInput)
        {
            if (atomicAnimatorInput.AnimatedProperty == Transitions.AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.BackColor)
            {

                mainControl_animationProperty_Combo.SelectedIndex = BackColor_Atomic;
                backColor_GroupBox.Visible = true;

                                
            }

            else if (atomicAnimatorInput.AnimatedProperty == Transitions.AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.ForeColor)
            {
                foreColor_GroupBox.Visible = true;
                mainControl_animationProperty_Combo.SelectedIndex = ForeColor_Atomic;

                for (int i = 0; i < mainControl_Control_ComboBox.Items.Count; i++)
                {
                    if ((Control)(mainControl_Control_ComboBox.Items[i]) == atomicAnimatorInput.Control)
                    {
                        mainControl_Control_ComboBox.SelectedIndex = i;

                    }

                }

            }

            else if (atomicAnimatorInput.AnimatedProperty == Transitions.AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.Size)
            {
                size_GroupBox.Visible = true;
                mainControl_animationProperty_Combo.SelectedIndex = Size_Atomic;
            }

            else if (atomicAnimatorInput.AnimatedProperty == Transitions.AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.Location)
            {
                mainControl_animationProperty_Combo.SelectedIndex = Location_Atomic;
                location_GroupBox.Visible = true;
            }

            else
            {
                mainControl_animationProperty_Combo.SelectedIndex = None_Atomic;
                backColor_GroupBox.Visible = false;
                foreColor_GroupBox.Visible = false;
                size_GroupBox.Visible = false;
                location_GroupBox.Visible = false;

            }
        }

        /// <summary>
        /// Sets the control fore color retrieved values.
        /// </summary>
        /// <param name="atomicAnimatorInput">The atomic animator input.</param>
        private void SetControl_ForeColor_Retrieved_Values(AtomicAnimatorInput atomicAnimatorInput)
        {

            atomicAnimatorInput.Control = (Control)mainControl_Control_ComboBox.SelectedItem;

            #region Animated Property

            if (mainControl_animationProperty_Combo.SelectedIndex == BackColor_Atomic)
            {
                atomicAnimatorInput.AnimatedProperty = AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.BackColor;

                //atomicAnimatorInput.CustomAnimationPoint1X = (float)backColor_Point1_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint1Y = (float)backColor_Point1_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2X = (float)backColor_Point2_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2Y = (float)backColor_Point2_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3X = (float)backColor_Point3_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3Y = (float)backColor_Point3_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4X = (float)backColor_Point4_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4Y = (float)backColor_Point4_Y_Numeric.Value;
                //atomicAnimatorInput.ControlBackColor = backColor_Color_btn.BackColor;
            }

            else if (mainControl_animationProperty_Combo.SelectedIndex == ForeColor_Atomic)
            {
                atomicAnimatorInput.AnimatedProperty = AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.ForeColor;

                atomicAnimatorInput.CustomAnimationPoint1X = (float)foreColor_Point1_X_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint1Y = (float)foreColor_Point1_Y_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint2X = (float)foreColor_Point2_X_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint2Y = (float)foreColor_Point2_Y_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint3X = (float)foreColor_Point3_X_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint3Y = (float)foreColor_Point3_Y_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint4X = (float)foreColor_Point4_X_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint4Y = (float)foreColor_Point4_Y_Numeric.Value;
                atomicAnimatorInput.ControlForeColor = foreColor_Color_btn.BackColor;
            }

            else if (mainControl_animationProperty_Combo.SelectedIndex == Size_Atomic)
            {
                atomicAnimatorInput.AnimatedProperty = AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.Size;

                //atomicAnimatorInput.CustomAnimationPoint1X = (float)size_Point1_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint1Y = (float)size_Point1_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2X = (float)size_Point2_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2Y = (float)size_Point2_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3X = (float)size_Point3_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3Y = (float)size_Point3_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4X = (float)size_Point4_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4Y = (float)size_Point4_Y_Numeric.Value;
            }

            else if (mainControl_animationProperty_Combo.SelectedIndex == Location_Atomic)
            {
                atomicAnimatorInput.AnimatedProperty = AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.Location;

                //atomicAnimatorInput.CustomAnimationPoint1X = (float)location_Point1_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint1Y = (float)location_Point1_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2X = (float)location_Point2_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2Y = (float)location_Point2_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3X = (float)location_Point3_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3Y = (float)location_Point3_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4X = (float)location_Point4_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4Y = (float)location_Point4_Y_Numeric.Value;
            }

            else
            {
                atomicAnimatorInput.AnimatedProperty = AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.None;
            }

            #endregion

            #region Reverse

            if (mainControl_Reverse_ComboBox.SelectedIndex == Yes)
            {
                atomicAnimatorInput.Reverse = true;
            }
            else
            {
                atomicAnimatorInput.Reverse = false;
            }

            #endregion

            #region Transition
            if (mainControl_Transition_ComboBox.SelectedIndex == Default)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.Default;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == EaseIn)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.EaseIn;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == EaseOut)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.EaseOut;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == EaseInEaseOut)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.EaseInEaseOut;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == Linear)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.Linear;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == CustomAnimation2Points)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.CustomAnimation2Points;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == CustomAnimation3Points)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.CustomAnimation3Points;
            }
            else
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.CustomAnimation4Points;
            }
            #endregion

            #region Duration

            atomicAnimatorInput.Duration = (float)mainControl_Duration_Numeric.Value;

            #endregion

        }

        /// <summary>
        /// Sets the control size to initial values.
        /// </summary>
        /// <param name="atomicAnimatorInput">The atomic animator input.</param>
        private void SetControl_Size_To_Initial_Values(AtomicAnimatorInput atomicAnimatorInput)
        {
            if (atomicAnimatorInput.AnimatedProperty == Transitions.AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.BackColor)
            {

                mainControl_animationProperty_Combo.SelectedIndex = BackColor_Atomic;
                backColor_GroupBox.Visible = true;


            }

            else if (atomicAnimatorInput.AnimatedProperty == Transitions.AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.ForeColor)
            {
                foreColor_GroupBox.Visible = true;
                mainControl_animationProperty_Combo.SelectedIndex = ForeColor_Atomic;

                
            }

            else if (atomicAnimatorInput.AnimatedProperty == Transitions.AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.Size)
            {
                size_GroupBox.Visible = true;
                mainControl_animationProperty_Combo.SelectedIndex = Size_Atomic;

                for (int i = 0; i < mainControl_Control_ComboBox.Items.Count; i++)
                {
                    if ((Control)(mainControl_Control_ComboBox.Items[i]) == atomicAnimatorInput.Control)
                    {
                        mainControl_Control_ComboBox.SelectedIndex = i;

                    }

                }
            }

            else if (atomicAnimatorInput.AnimatedProperty == Transitions.AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.Location)
            {
                mainControl_animationProperty_Combo.SelectedIndex = Location_Atomic;
                location_GroupBox.Visible = true;
            }

            else
            {
                mainControl_animationProperty_Combo.SelectedIndex = None_Atomic;
                backColor_GroupBox.Visible = false;
                foreColor_GroupBox.Visible = false;
                size_GroupBox.Visible = false;
                location_GroupBox.Visible = false;

            }
        }

        /// <summary>
        /// Sets the control size retrieved values.
        /// </summary>
        /// <param name="atomicAnimatorInput">The atomic animator input.</param>
        private void SetControl_Size_Retrieved_Values(AtomicAnimatorInput atomicAnimatorInput)
        {

            atomicAnimatorInput.Control = (Control)mainControl_Control_ComboBox.SelectedItem;

            #region Animated Property

            if (mainControl_animationProperty_Combo.SelectedIndex == BackColor_Atomic)
            {
                atomicAnimatorInput.AnimatedProperty = AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.BackColor;

                //atomicAnimatorInput.CustomAnimationPoint1X = (float)backColor_Point1_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint1Y = (float)backColor_Point1_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2X = (float)backColor_Point2_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2Y = (float)backColor_Point2_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3X = (float)backColor_Point3_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3Y = (float)backColor_Point3_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4X = (float)backColor_Point4_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4Y = (float)backColor_Point4_Y_Numeric.Value;
                //atomicAnimatorInput.ControlBackColor = backColor_Color_btn.BackColor;
            }

            else if (mainControl_animationProperty_Combo.SelectedIndex == ForeColor_Atomic)
            {
                atomicAnimatorInput.AnimatedProperty = AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.ForeColor;

                //atomicAnimatorInput.CustomAnimationPoint1X = (float)foreColor_Point1_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint1Y = (float)foreColor_Point1_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2X = (float)foreColor_Point2_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2Y = (float)foreColor_Point2_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3X = (float)foreColor_Point3_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3Y = (float)foreColor_Point3_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4X = (float)foreColor_Point4_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4Y = (float)foreColor_Point4_Y_Numeric.Value;
                //atomicAnimatorInput.ControlForeColor = foreColor_Color_btn.BackColor;
            }

            else if (mainControl_animationProperty_Combo.SelectedIndex == Size_Atomic)
            {
                atomicAnimatorInput.AnimatedProperty = AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.Size;

                atomicAnimatorInput.CustomAnimationPoint1X = (float)size_Point1_X_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint1Y = (float)size_Point1_Y_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint2X = (float)size_Point2_X_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint2Y = (float)size_Point2_Y_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint3X = (float)size_Point3_X_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint3Y = (float)size_Point3_Y_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint4X = (float)size_Point4_X_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint4Y = (float)size_Point4_Y_Numeric.Value;
                atomicAnimatorInput.ControlAnimationSize = new Size((int)size_Width_Numeric.Value, (int)size_Height_Numeric.Value);
                size_Animator.ControlAnimationSize = new Size((int)size_Width_Numeric.Value, (int)size_Height_Numeric.Value);
            }

            else if (mainControl_animationProperty_Combo.SelectedIndex == Location_Atomic)
            {
                atomicAnimatorInput.AnimatedProperty = AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.Location;

                //atomicAnimatorInput.CustomAnimationPoint1X = (float)location_Point1_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint1Y = (float)location_Point1_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2X = (float)location_Point2_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2Y = (float)location_Point2_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3X = (float)location_Point3_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3Y = (float)location_Point3_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4X = (float)location_Point4_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4Y = (float)location_Point4_Y_Numeric.Value;
            }

            else
            {
                atomicAnimatorInput.AnimatedProperty = AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.None;
            }

            #endregion

            #region Reverse

            if (mainControl_Reverse_ComboBox.SelectedIndex == Yes)
            {
                atomicAnimatorInput.Reverse = true;
            }
            else
            {
                atomicAnimatorInput.Reverse = false;
            }

            #endregion

            #region Transition
            if (mainControl_Transition_ComboBox.SelectedIndex == Default)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.Default;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == EaseIn)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.EaseIn;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == EaseOut)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.EaseOut;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == EaseInEaseOut)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.EaseInEaseOut;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == Linear)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.Linear;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == CustomAnimation2Points)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.CustomAnimation2Points;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == CustomAnimation3Points)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.CustomAnimation3Points;
            }
            else
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.CustomAnimation4Points;
            }
            #endregion

            #region Duration

            atomicAnimatorInput.Duration = (float)mainControl_Duration_Numeric.Value;

            #endregion
        }

        /// <summary>
        /// Sets the control location to initial values.
        /// </summary>
        /// <param name="atomicAnimatorInput">The atomic animator input.</param>
        private void SetControl_Location_To_Initial_Values(AtomicAnimatorInput atomicAnimatorInput)
        {
            if (atomicAnimatorInput.AnimatedProperty == Transitions.AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.BackColor)
            {

                mainControl_animationProperty_Combo.SelectedIndex = BackColor_Atomic;
                backColor_GroupBox.Visible = true;


            }

            else if (atomicAnimatorInput.AnimatedProperty == Transitions.AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.ForeColor)
            {
                foreColor_GroupBox.Visible = true;
                mainControl_animationProperty_Combo.SelectedIndex = ForeColor_Atomic;


            }

            else if (atomicAnimatorInput.AnimatedProperty == Transitions.AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.Size)
            {
                size_GroupBox.Visible = true;
                mainControl_animationProperty_Combo.SelectedIndex = Size_Atomic;
                                
            }

            else if (atomicAnimatorInput.AnimatedProperty == Transitions.AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.Location)
            {
                mainControl_animationProperty_Combo.SelectedIndex = Location_Atomic;
                location_GroupBox.Visible = true;

                for (int i = 0; i < mainControl_Control_ComboBox.Items.Count; i++)
                {
                    if ((Control)(mainControl_Control_ComboBox.Items[i]) == atomicAnimatorInput.Control)
                    {
                        mainControl_Control_ComboBox.SelectedIndex = i;

                    }

                }
            }

            else
            {
                mainControl_animationProperty_Combo.SelectedIndex = None_Atomic;
                backColor_GroupBox.Visible = false;
                foreColor_GroupBox.Visible = false;
                size_GroupBox.Visible = false;
                location_GroupBox.Visible = false;

            }
        }

        /// <summary>
        /// Sets the control location retrieved values.
        /// </summary>
        /// <param name="atomicAnimatorInput">The atomic animator input.</param>
        private void SetControl_Location_Retrieved_Values(AtomicAnimatorInput atomicAnimatorInput)
        {

            atomicAnimatorInput.Control = (Control)mainControl_Control_ComboBox.SelectedItem;

            #region Animated Property

            if (mainControl_animationProperty_Combo.SelectedIndex == BackColor_Atomic)
            {
                atomicAnimatorInput.AnimatedProperty = AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.BackColor;

                //atomicAnimatorInput.CustomAnimationPoint1X = (float)backColor_Point1_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint1Y = (float)backColor_Point1_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2X = (float)backColor_Point2_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2Y = (float)backColor_Point2_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3X = (float)backColor_Point3_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3Y = (float)backColor_Point3_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4X = (float)backColor_Point4_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4Y = (float)backColor_Point4_Y_Numeric.Value;
                //atomicAnimatorInput.ControlBackColor = backColor_Color_btn.BackColor;
            }

            else if (mainControl_animationProperty_Combo.SelectedIndex == ForeColor_Atomic)
            {
                atomicAnimatorInput.AnimatedProperty = AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.ForeColor;

                //atomicAnimatorInput.CustomAnimationPoint1X = (float)foreColor_Point1_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint1Y = (float)foreColor_Point1_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2X = (float)foreColor_Point2_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2Y = (float)foreColor_Point2_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3X = (float)foreColor_Point3_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3Y = (float)foreColor_Point3_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4X = (float)foreColor_Point4_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4Y = (float)foreColor_Point4_Y_Numeric.Value;
                //atomicAnimatorInput.ControlForeColor = foreColor_Color_btn.BackColor;
            }

            else if (mainControl_animationProperty_Combo.SelectedIndex == Size_Atomic)
            {
                atomicAnimatorInput.AnimatedProperty = AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.Size;

                //atomicAnimatorInput.CustomAnimationPoint1X = (float)size_Point1_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint1Y = (float)size_Point1_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2X = (float)size_Point2_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint2Y = (float)size_Point2_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3X = (float)size_Point3_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint3Y = (float)size_Point3_Y_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4X = (float)size_Point4_X_Numeric.Value;
                //atomicAnimatorInput.CustomAnimationPoint4Y = (float)size_Point4_Y_Numeric.Value;
            }

            else if (mainControl_animationProperty_Combo.SelectedIndex == Location_Atomic)
            {
                atomicAnimatorInput.AnimatedProperty = AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.Location;

                atomicAnimatorInput.CustomAnimationPoint1X = (float)location_Point1_X_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint1Y = (float)location_Point1_Y_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint2X = (float)location_Point2_X_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint2Y = (float)location_Point2_Y_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint3X = (float)location_Point3_X_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint3Y = (float)location_Point3_Y_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint4X = (float)location_Point4_X_Numeric.Value;
                atomicAnimatorInput.CustomAnimationPoint4Y = (float)location_Point4_Y_Numeric.Value;
                atomicAnimatorInput.ControlLocation = new Point((int)location_X_Cordinate_Numeric.Value, (int)location_Y_Cordinate_Numeric.Value);
                location_Animator.ControlLocation = new Point((int)size_Width_Numeric.Value, (int)size_Height_Numeric.Value);
            }

            else
            {
                atomicAnimatorInput.AnimatedProperty = AtomicAnimator.ZeroitAtomEdit.PropertyAnimated.None;
            }

            #endregion

            #region Reverse

            if (mainControl_Reverse_ComboBox.SelectedIndex == Yes)
            {
                atomicAnimatorInput.Reverse = true;
            }
            else
            {
                atomicAnimatorInput.Reverse = false;
            }

            #endregion

            #region Transition
            if (mainControl_Transition_ComboBox.SelectedIndex == Default)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.Default;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == EaseIn)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.EaseIn;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == EaseOut)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.EaseOut;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == EaseInEaseOut)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.EaseInEaseOut;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == Linear)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.Linear;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == CustomAnimation2Points)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.CustomAnimation2Points;
            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == CustomAnimation3Points)
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.CustomAnimation3Points;
            }
            else
            {
                atomicAnimatorInput.Transition = AtomicAnimator.ZeroitAtomEdit.Animations.CustomAnimation4Points;
            }
            #endregion

            #region Duration

            atomicAnimatorInput.Duration = (float)mainControl_Duration_Numeric.Value;

            #endregion
        }



        #endregion

        /// <summary>
        /// Handles the Click event of the okBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (mainControl_animationProperty_Combo.SelectedIndex == BackColor_Atomic)
            {
                atomicAnimatorInput = new AtomicAnimatorInput(ZeroitAtomEdit.PropertyAnimated.BackColor,
                    0.5f,
                    0.0f,
                    0.5f,
                    1.0f,
                    0.5f,
                    0.5f,
                    1.0f,
                    0.0f,
                    Color.Orange,
                    true,
                    2f,
                    ZeroitAtomEdit.Animations.EaseInEaseOut,
                    (Control)mainControl_Control_ComboBox.SelectedItem);

                SetControl_BackColor_Retrieved_Values(atomicAnimatorInput);
            }

            else if (mainControl_animationProperty_Combo.SelectedIndex == ForeColor_Atomic)
            {
                atomicAnimatorInput = new AtomicAnimatorInput(ZeroitAtomEdit.PropertyAnimated.ForeColor,
                    0.5f,
                    0.0f,
                    0.5f,
                    1.0f,
                    0.5f,
                    0.5f,
                    1.0f,
                    0.0f,
                    Color.Black,
                    true,
                    2f,
                    ZeroitAtomEdit.Animations.EaseInEaseOut,"",
                    (Control)mainControl_Control_ComboBox.SelectedItem);

                SetControl_ForeColor_Retrieved_Values(atomicAnimatorInput);
            }

            else if (mainControl_animationProperty_Combo.SelectedIndex == Size_Atomic)
            {
                atomicAnimatorInput = new AtomicAnimatorInput(ZeroitAtomEdit.PropertyAnimated.Size,
                    0.5f,
                    0.0f,
                    0.5f,
                    1.0f,
                    0.5f,
                    0.5f,
                    1.0f,
                    0.0f,
                    new System.Drawing.Size(100, 100),
                    true,
                    2f,
                    ZeroitAtomEdit.Animations.EaseInEaseOut,
                    (Control)mainControl_Control_ComboBox.SelectedItem);

                SetControl_Size_Retrieved_Values(atomicAnimatorInput);
            }

            else
            {
                
                atomicAnimatorInput = new AtomicAnimatorInput(ZeroitAtomEdit.PropertyAnimated.Size,
                    0.5f,
                    0.0f,
                    0.5f,
                    1.0f,
                    0.5f,
                    0.5f,
                    1.0f,
                    0.0f,
                    new System.Drawing.Point(447, 356),
                    true,
                    2f,
                    ZeroitAtomEdit.Animations.EaseInEaseOut,
                    (Control)mainControl_Control_ComboBox.SelectedItem);

                SetControl_Location_Retrieved_Values(atomicAnimatorInput);
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
        /// Handles the Click event of the backColor_Color_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void backColor_Color_btn_Click(object sender, EventArgs e)
        {
            if (colorToUse.ShowDialog() == DialogResult.OK)
            {
                backColor_Color_btn.BackColor = colorToUse.Color;
                backColor_Animator.ControlBackColor = colorToUse.Color;

            }
        }


        /// <summary>
        /// Handles the Click event of the foreColor_Color_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void foreColor_Color_btn_Click(object sender, EventArgs e)
        {
            if (colorToUse.ShowDialog() == DialogResult.OK)
            {
                foreColor_Color_btn.BackColor = colorToUse.Color;
                foreColor_Animator.ControlForeColor = colorToUse.Color;
            }
        }

        /// <summary>
        /// Handles the MouseEnter event of the backColor_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void backColor_Preview_btn_MouseEnter(object sender, EventArgs e)
        {
            backColor_Preview_btn.FlatAppearance.BorderSize = 1;
            backColor_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);

        }

        /// <summary>
        /// Handles the MouseLeave event of the backColor_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void backColor_Preview_btn_MouseLeave(object sender, EventArgs e)
        {
            backColor_Preview_btn.FlatAppearance.BorderSize = 0;
            backColor_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);

        }

        /// <summary>
        /// Handles the MouseEnter event of the foreColor_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void foreColor_Preview_btn_MouseEnter(object sender, EventArgs e)
        {
            foreColor_Preview_btn.FlatAppearance.BorderSize = 1;
            foreColor_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);

        }

        /// <summary>
        /// Handles the MouseLeave event of the foreColor_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void foreColor_Preview_btn_MouseLeave(object sender, EventArgs e)
        {
            foreColor_Preview_btn.FlatAppearance.BorderSize = 0;
            foreColor_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);

        }

        /// <summary>
        /// Handles the MouseEnter event of the size_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void size_Preview_btn_MouseEnter(object sender, EventArgs e)
        {
            size_Preview_btn.FlatAppearance.BorderSize = 1;
            size_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);

        }

        /// <summary>
        /// Handles the MouseLeave event of the size_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void size_Preview_btn_MouseLeave(object sender, EventArgs e)
        {
            size_Preview_btn.FlatAppearance.BorderSize = 0;
            size_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);

        }

        /// <summary>
        /// Handles the MouseEnter event of the location_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void location_Preview_btn_MouseEnter(object sender, EventArgs e)
        {
            location_Preview_btn.FlatAppearance.BorderSize = 1;
            location_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);

        }

        /// <summary>
        /// Handles the MouseLeave event of the location_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void location_Preview_btn_MouseLeave(object sender, EventArgs e)
        {
            location_Preview_btn.FlatAppearance.BorderSize = 0;
            location_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);

        }

        /// <summary>
        /// Handles the Click event of the backColor_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void backColor_Preview_btn_Click(object sender, EventArgs e)
        {
            backColor_Animator.Activate();
            
        }

        /// <summary>
        /// Handles the Click event of the foreColor_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void foreColor_Preview_btn_Click(object sender, EventArgs e)
        {
            foreColor_Animator.Activate();
        }

        /// <summary>
        /// Handles the Click event of the size_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void size_Preview_btn_Click(object sender, EventArgs e)
        {
            size_Animator.Activate();
        }

        /// <summary>
        /// Handles the Click event of the location_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void location_Preview_btn_Click(object sender, EventArgs e)
        {
            location_Animator.Activate();
        }

        /// <summary>
        /// Handles the ValueChanged event of the backColor_Point1_X_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void backColor_Point1_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            backColor_Animator.CustomAnimationPoint1X = (float)backColor_Point1_X_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the backColor_Point2_X_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void backColor_Point2_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            backColor_Animator.CustomAnimationPoint2X = (float)backColor_Point2_X_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the backColor_Point3_X_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void backColor_Point3_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            backColor_Animator.CustomAnimationPoint3X = (float)backColor_Point3_X_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the backColor_Point4_X_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void backColor_Point4_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            backColor_Animator.CustomAnimationPoint4X = (float)backColor_Point4_X_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the backColor_Point1_Y_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void backColor_Point1_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            backColor_Animator.CustomAnimationPoint1Y = (float)backColor_Point1_Y_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the backColor_Point2_Y_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void backColor_Point2_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            backColor_Animator.CustomAnimationPoint2Y = (float)backColor_Point2_Y_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the backColor_Point3_Y_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void backColor_Point3_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            backColor_Animator.CustomAnimationPoint3Y = (float)backColor_Point3_Y_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the backColor_Point4_Y_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void backColor_Point4_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            backColor_Animator.CustomAnimationPoint4Y = (float)backColor_Point4_Y_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the foreColor_Point1_X_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void foreColor_Point1_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            foreColor_Animator.CustomAnimationPoint1X = (float)foreColor_Point1_X_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the foreColor_Point2_X_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void foreColor_Point2_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            foreColor_Animator.CustomAnimationPoint2X = (float)foreColor_Point2_X_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the foreColor_Point3_X_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void foreColor_Point3_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            foreColor_Animator.CustomAnimationPoint3X = (float)foreColor_Point3_X_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the foreColor_Point4_X_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void foreColor_Point4_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            foreColor_Animator.CustomAnimationPoint4X = (float)foreColor_Point4_X_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the foreColor_Point1_Y_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void foreColor_Point1_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            foreColor_Animator.CustomAnimationPoint1Y = (float)foreColor_Point1_Y_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the foreColor_Point2_Y_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void foreColor_Point2_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            foreColor_Animator.CustomAnimationPoint2Y = (float)foreColor_Point2_Y_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the foreColor_Point3_Y_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void foreColor_Point3_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            foreColor_Animator.CustomAnimationPoint3Y = (float)foreColor_Point3_Y_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the foreColor_Point4_Y_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void foreColor_Point4_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            foreColor_Animator.CustomAnimationPoint4Y = (float)foreColor_Point4_Y_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the size_Point1_X_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void size_Point1_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            size_Animator.CustomAnimationPoint1X = (float)size_Point1_X_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the size_Point2_X_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void size_Point2_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            size_Animator.CustomAnimationPoint2X = (float)size_Point2_X_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the size_Point3_X_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void size_Point3_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            size_Animator.CustomAnimationPoint3X = (float)size_Point3_X_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the size_Point4_X_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void size_Point4_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            size_Animator.CustomAnimationPoint4X = (float)size_Point4_X_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the size_Point1_Y_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void size_Point1_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            size_Animator.CustomAnimationPoint1Y = (float)size_Point1_Y_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the size_Point2_Y_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void size_Point2_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            size_Animator.CustomAnimationPoint2Y = (float)size_Point2_Y_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the size_Point3_Y_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void size_Point3_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            size_Animator.CustomAnimationPoint3Y = (float)size_Point3_Y_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the size_Point4_Y_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void size_Point4_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            size_Animator.CustomAnimationPoint4Y = (float)size_Point4_Y_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the location_Point1_X_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void location_Point1_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            location_Animator.CustomAnimationPoint1X = (float)location_Point1_X_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the location_Point2_X_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void location_Point2_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            location_Animator.CustomAnimationPoint2X = (float)location_Point2_X_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the location_Point3_X_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void location_Point3_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            location_Animator.CustomAnimationPoint3X = (float)location_Point3_X_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the location_Point4_X_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void location_Point4_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            location_Animator.CustomAnimationPoint4X = (float)location_Point4_X_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the location_Point1_Y_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void location_Point1_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            location_Animator.CustomAnimationPoint1Y = (float)location_Point1_Y_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the location_Point2_Y_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void location_Point2_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            location_Animator.CustomAnimationPoint2Y = (float)location_Point2_Y_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the location_Point3_Y_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void location_Point3_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            location_Animator.CustomAnimationPoint3Y = (float)location_Point3_Y_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the location_Point4_Y_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void location_Point4_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            location_Animator.CustomAnimationPoint4Y = (float)location_Point4_Y_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the mainControl_Duration_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Duration_Numeric_ValueChanged(object sender, EventArgs e)
        {
            location_Animator.Duration = (float)mainControl_Duration_Numeric.Value;
            size_Animator.Duration = (float)mainControl_Duration_Numeric.Value;
            backColor_Animator.Duration = (float)mainControl_Duration_Numeric.Value;
            foreColor_Animator.Duration = (float)mainControl_Duration_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the size_Width_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void size_Width_Numeric_ValueChanged(object sender, EventArgs e)
        {
            size_Animator.ControlAnimationSize = new Size((int)size_Width_Numeric.Value, (int)size_Height_Numeric.Value);
        }

        /// <summary>
        /// Handles the ValueChanged event of the size_Height_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void size_Height_Numeric_ValueChanged(object sender, EventArgs e)
        {
            size_Animator.ControlAnimationSize = new Size((int)size_Width_Numeric.Value, (int)size_Height_Numeric.Value);
        }

        /// <summary>
        /// Handles the ValueChanged event of the location_X_Cordinate_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void location_X_Cordinate_Numeric_ValueChanged(object sender, EventArgs e)
        {
            location_Animator.ControlLocation = new Point((int)location_X_Cordinate_Numeric.Value, (int)location_Y_Cordinate_Numeric.Value);
        }

        /// <summary>
        /// Handles the ValueChanged event of the location_Y_Cordinate_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void location_Y_Cordinate_Numeric_ValueChanged(object sender, EventArgs e)
        {
            location_Animator.ControlLocation = new Point((int)location_X_Cordinate_Numeric.Value, (int)location_Y_Cordinate_Numeric.Value);
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the mainControl_Transition_ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Transition_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(mainControl_Transition_ComboBox.SelectedIndex == Default)
            {
                backColor_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.Default;
                foreColor_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.Default;
                size_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.Default;
                location_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.Default;


            }
            else if(mainControl_Transition_ComboBox.SelectedIndex == EaseIn)
            {
                backColor_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.EaseIn;
                foreColor_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.EaseIn;
                size_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.EaseIn;
                location_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.EaseIn;

            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == EaseOut)
            {
                backColor_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.EaseOut;
                foreColor_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.EaseOut;
                size_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.EaseOut;
                location_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.EaseOut;

            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == EaseInEaseOut)
            {
                backColor_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.EaseInEaseOut;
                foreColor_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.EaseInEaseOut;
                size_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.EaseInEaseOut;
                location_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.EaseInEaseOut;

            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == Linear)
            {
                backColor_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.Linear;
                foreColor_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.Linear;
                size_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.Linear;
                location_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.Linear;

            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == CustomAnimation2Points)
            {
                backColor_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.CustomAnimation2Points;
                foreColor_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.CustomAnimation2Points;
                size_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.CustomAnimation2Points;
                location_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.CustomAnimation2Points;

            }
            else if (mainControl_Transition_ComboBox.SelectedIndex == CustomAnimation3Points)
            {
                backColor_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.CustomAnimation3Points;
                foreColor_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.CustomAnimation3Points;
                size_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.CustomAnimation3Points;
                location_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.CustomAnimation3Points;

            }
            else
            {
                backColor_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.CustomAnimation4Points;
                foreColor_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.CustomAnimation4Points;
                size_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.CustomAnimation4Points;
                location_Animator.Transition = AtomicAnimator.ZeroitAtom.Animations.CustomAnimation4Points;

            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the mainControl_Reverse_ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Reverse_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(mainControl_Reverse_ComboBox.SelectedIndex == Yes)
            {
                backColor_Animator.Reverse = true;
                foreColor_Animator.Reverse = true;
                size_Animator.Reverse = true;
                location_Animator.Reverse = true;
            }
            else
            {
                backColor_Animator.Reverse = false;
                foreColor_Animator.Reverse = false;
                size_Animator.Reverse = false;
                location_Animator.Reverse = false;
            }
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
            closeBtn.BackColor = Color.FromArgb(22,22,22);
        }
    }
}
