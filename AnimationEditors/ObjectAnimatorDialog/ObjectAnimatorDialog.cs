// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ObjectAnimatorDialog.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    /// Class ObjectAnimatorDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ObjectAnimatorDialog : System.Windows.Forms.Form
    {

        #region Constants

        /// <summary>
        /// The color animation
        /// </summary>
        private const int ColorAnimation = 0;
        /// <summary>
        /// The form animation
        /// </summary>
        private const int FormAnimation = 1;
        /// <summary>
        /// The standard animation
        /// </summary>
        private const int StandardAnimation = 2;

        /// <summary>
        /// The fill ellipse
        /// </summary>
        private const int FillEllipse = 0;
        /// <summary>
        /// The fill square
        /// </summary>
        private const int FillSquare = 1;
        /// <summary>
        /// The slide fill
        /// </summary>
        private const int SlideFill = 2;
        /// <summary>
        /// The stripe fill
        /// </summary>
        private const int StripeFill = 3;
        /// <summary>
        /// The split fill
        /// </summary>
        private const int SplitFill = 4;

        /// <summary>
        /// The fade in
        /// </summary>
        private const int FadeIn = 0;
        /// <summary>
        /// The fade out
        /// </summary>
        private const int FadeOut = 1;

        /// <summary>
        /// The hop
        /// </summary>
        private const int Hop = 0;
        /// <summary>
        /// The shoot left
        /// </summary>
        private const int ShootLeft = 1;
        /// <summary>
        /// The shoot right
        /// </summary>
        private const int ShootRight = 2;
        /// <summary>
        /// The slide up
        /// </summary>
        private const int SlideUp = 3;
        /// <summary>
        /// The slide down
        /// </summary>
        private const int SlideDown = 4;
        /// <summary>
        /// The slide left
        /// </summary>
        private const int SlideLeft = 5;
        /// <summary>
        /// The slide right
        /// </summary>
        private const int SlideRight = 6;
        /// <summary>
        /// The slug left
        /// </summary>
        private const int SlugLeft = 7;
        /// <summary>
        /// The slug right
        /// </summary>
        private const int SlugRight = 8;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// at the default window position.
        /// </summary>
        public ObjectAnimatorDialog() : this(ObjectAnimatorInput.Empty())
        {
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// at the default window position.
        /// </summary>
        /// <param name="objectAnimatorInput">The object animator input.</param>
        /// <exception cref="ArgumentNullException">objectAnimatorInput</exception>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="peaceInput" /> is null.</exception>
        public ObjectAnimatorDialog(ObjectAnimatorInput objectAnimatorInput)
        {
            if (objectAnimatorInput == null)
            {
                throw new ArgumentNullException("objectAnimatorInput");
            }


            InitializeComponent();


            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);


            AdjustDialogSize();
            SetInitial_Values(objectAnimatorInput);
            SetControl_ColorAnimation_To_Initial_Values(objectAnimatorInput);
            SetControl_FormAnimation_To_Initial_Values(objectAnimatorInput);
            SetControl_StandardAnimation_To_Initial_Values(objectAnimatorInput);
            
        }


        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        public ObjectAnimatorDialog(Control c) : this(ObjectAnimatorInput.Empty(), c)
        {
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="objectAnimatorInput">The object animator input.</param>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="filler" /> is null.</exception>
        public ObjectAnimatorDialog(ObjectAnimatorInput objectAnimatorInput, Control c) : this(objectAnimatorInput)
        {
            Zeroit.Framework.Transitions.AnimationEditors.Utilities.Draw.SetStartPositionBelowControl(this, c);
        }

        #endregion

        #region Public Properties
        /// <summary>
        /// The object animator input
        /// </summary>
        private ObjectAnimatorInput objectAnimatorInput;

        /// <summary>
        /// Gets the object animator input.
        /// </summary>
        /// <value>The object animator input.</value>
        public ObjectAnimatorInput ObjectAnimatorInput
        {
            get { return objectAnimatorInput; }
        }
        #endregion

        #region Private Methods

        /// <summary>
        /// Adjusts the size of the dialog.
        /// </summary>
        private void AdjustDialogSize()
        {
            // Three different possible group boxes - move them all to one coordinate
            int x = color_GroupBox.Location.X;
            int y = general_Container.Location.Y;

            color_GroupBox.Location = new Point(x, y);
            form_GroupBox.Location = new Point(x, y);
            standard_GroupBox.Location = new Point(x, y);
            

            //formName.Location = new Point(typeGroupBox.Location.X, formName.Location.Y - 5);

            int bottomY = Math.Max(color_GroupBox.Bounds.Bottom,
                Math.Max(form_GroupBox.Bounds.Bottom,
                    Math.Max(standard_GroupBox.Bounds.Bottom,
                        general_Container.Bounds.Bottom)));



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
            color_GroupBox.Visible = false;
            form_GroupBox.Visible = false;
            standard_GroupBox.Visible = false;
            

            if (generalContainer_Mode_ComboBox.SelectedIndex == ColorAnimation)
            {
                color_GroupBox.Visible = true;

            }
            else if (generalContainer_Mode_ComboBox.SelectedIndex == FormAnimation)
            {
                form_GroupBox.Visible = true;
            }
            else if (generalContainer_Mode_ComboBox.SelectedIndex == StandardAnimation)
            {
                standard_GroupBox.Visible = true;
            }
            
            else
            {
                color_GroupBox.Visible = false;
                form_GroupBox.Visible = false;
                standard_GroupBox.Visible = false;
            }




        }

        /// <summary>
        /// Sets the initial values.
        /// </summary>
        /// <param name="objectAnimatorInput">The object animator input.</param>
        private void SetInitial_Values(ObjectAnimatorInput objectAnimatorInput)
        {

            #region Animation Mode
            
            if(objectAnimatorInput.AnimationMode == ZeroitOJAnimEdit.ZeroitObjectAnimationMode.ColorAnimation)
            {
                generalContainer_Mode_ComboBox.SelectedIndex = ColorAnimation;
            }
            else if (objectAnimatorInput.AnimationMode == ZeroitOJAnimEdit.ZeroitObjectAnimationMode.FormAnimation)
            {
                generalContainer_Mode_ComboBox.SelectedIndex = FormAnimation;
            }
            else
            {
                generalContainer_Mode_ComboBox.SelectedIndex = StandardAnimation;
            }

            #endregion

            #region Control

            foreach (var controlNames in objectAnimatorInput.Control.FindForm().Controls)
            {
                generalContainer_Control_ComboBox.Items.Add(controlNames);

            }
            generalContainer_Control_ComboBox.Items.Add(objectAnimatorInput.Control.FindForm());


            for (int i = 0; i < generalContainer_Control_ComboBox.Items.Count; i++)
            {
                if (objectAnimatorInput.Control == (Control)(generalContainer_Control_ComboBox.Items[i]))
                {
                    generalContainer_Control_ComboBox.SelectedIndex = i;
                }

            }
            #endregion

            #region Color Animation

            if(objectAnimatorInput.ColorAnimation == ZeroitOJAnimEdit.ZeroitObjectColorAnimation.FillEllipse)
            {
                color_Animation_ComboBox.SelectedIndex = FillEllipse;
            }
            else if (objectAnimatorInput.ColorAnimation == ZeroitOJAnimEdit.ZeroitObjectColorAnimation.FillSquare)
            {
                color_Animation_ComboBox.SelectedIndex = FillSquare;
            }
            else if (objectAnimatorInput.ColorAnimation == ZeroitOJAnimEdit.ZeroitObjectColorAnimation.SlideFill)
            {
                color_Animation_ComboBox.SelectedIndex = SlideFill;
            }
            else if (objectAnimatorInput.ColorAnimation == ZeroitOJAnimEdit.ZeroitObjectColorAnimation.SplitFill)
            {
                color_Animation_ComboBox.SelectedIndex = SplitFill;
            }
            else
            {
                color_Animation_ComboBox.SelectedIndex = StripeFill;
            }


            #endregion

            #region Form Animation

            if(objectAnimatorInput.FormAnimation == ZeroitOJAnimEdit.ZeroitObjectFormAnimation.FadeIn)
            {
                form_Animation_ComboBox.SelectedIndex = FadeIn;
            }
            else
            {
                form_Animation_ComboBox.SelectedIndex = FadeOut;
            }

            #endregion

            #region Standard Animation

            if(objectAnimatorInput.StandardAnimation == ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.Hop)
            {
                standard_Animation_ComboBox.SelectedIndex = Hop;
            }

            else if (objectAnimatorInput.StandardAnimation == ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.ShootLeft)
            {
                standard_Animation_ComboBox.SelectedIndex = ShootLeft;
            }

            else if (objectAnimatorInput.StandardAnimation == ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.ShootRight)
            {
                standard_Animation_ComboBox.SelectedIndex = ShootRight;
            }

            else if (objectAnimatorInput.StandardAnimation == ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.SlideDown)
            {
                standard_Animation_ComboBox.SelectedIndex = SlideDown;
            }

            else if (objectAnimatorInput.StandardAnimation == ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.SlideLeft)
            {
                standard_Animation_ComboBox.SelectedIndex = SlideLeft;
            }

            else if (objectAnimatorInput.StandardAnimation == ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.SlideRight)
            {
                standard_Animation_ComboBox.SelectedIndex = SlideRight;
            }

            else if (objectAnimatorInput.StandardAnimation == ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.SlideUp)
            {
                standard_Animation_ComboBox.SelectedIndex = SlideUp;
            }

            else if (objectAnimatorInput.StandardAnimation == ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.SlugLeft)
            {
                standard_Animation_ComboBox.SelectedIndex = SlugLeft;
            }
                        
            else
            {
                standard_Animation_ComboBox.SelectedIndex = SlugRight;
            }

            #endregion

            #region Values

            generalContainer_Speed_Numeric.Value = (decimal)objectAnimatorInput.AnimationSpeed;
            generalContainer_UpSpeed_Numeric.Value = (decimal)objectAnimatorInput.UpperSpeedLimit;
            generalContainer_LowSpeed_Numeric.Value = (decimal)objectAnimatorInput.LowerSpeedLimit;

            color_Color_btn.BackColor = objectAnimatorInput.ColorToAnimate;
            color_Delay_Numeric.Value = (decimal)objectAnimatorInput.ColorAnimationDelay;
            color_Preview_Panel.BackColor = objectAnimatorInput.ColorToAnimate;


            if (objectAnimatorInput.KeepColor)
            {
                color_Yes_RadioBtn.Checked = true;
            }
            else
            {
                color_No_RadioBtn.Checked = true;
            }

            form_Delay_Numeric.Value = (decimal)objectAnimatorInput.FormAnimationDelay;

            standard_HopDelay_Numeric.Value = (decimal)objectAnimatorInput.StandardHopDelay;
            standard_ShootDelay_Numeric.Value = (decimal)objectAnimatorInput.StandardShootDelay;
            standard_SlideDelay_Numeric.Value = (decimal)objectAnimatorInput.StandardSlideDelay;
            standard_SlugDelay0_Numeric.Value = (decimal)objectAnimatorInput.StandardSlugDelay[0];
            standard_SlugDelay1_Numeric.Value = (decimal)objectAnimatorInput.StandardSlugDelay[1];


            #endregion
        }

        /// <summary>
        /// Sets the control color animation to initial values.
        /// </summary>
        /// <param name="objectAnimatorInput">The object animator input.</param>
        private void SetControl_ColorAnimation_To_Initial_Values(ObjectAnimatorInput objectAnimatorInput)
        {
            if (objectAnimatorInput.AnimationMode == ZeroitOJAnimEdit.ZeroitObjectAnimationMode.ColorAnimation)
            {

                generalContainer_Mode_ComboBox.SelectedIndex = ColorAnimation;
                color_GroupBox.Visible = true;


                for (int i = 0; i < generalContainer_Control_ComboBox.Items.Count; i++)
                {
                    if (objectAnimatorInput.Control == (Control)(generalContainer_Control_ComboBox.Items[i]))
                    {
                        generalContainer_Control_ComboBox.SelectedIndex = i;
                    }

                }
            }

            else if (objectAnimatorInput.AnimationMode == ZeroitOJAnimEdit.ZeroitObjectAnimationMode.FormAnimation)
            {
                generalContainer_Mode_ComboBox.SelectedIndex = FormAnimation;
                form_GroupBox.Visible = true;

            }
                        
            else if (objectAnimatorInput.AnimationMode == ZeroitOJAnimEdit.ZeroitObjectAnimationMode.StandardAnimation)
            {
                generalContainer_Mode_ComboBox.SelectedIndex = StandardAnimation;
                standard_GroupBox.Visible = true;
            }

            else
            {
                //mainControl_animationProperty_Combo.SelectedIndex = None_Atomic;
                color_GroupBox.Visible = true;
                form_GroupBox.Visible = false;
                standard_GroupBox.Visible = false;

            }
        }

        /// <summary>
        /// Sets the control color animation to retrieved values.
        /// </summary>
        /// <param name="objectAnimatorInput">The object animator input.</param>
        private void SetControl_ColorAnimation_To_Retrieved_Values(ObjectAnimatorInput objectAnimatorInput)
        {
            objectAnimatorInput.Control = (Control)generalContainer_Control_ComboBox.SelectedItem;

            #region Main Container

            if (generalContainer_Mode_ComboBox.SelectedIndex == ColorAnimation)
            {
                objectAnimatorInput.AnimationMode = ZeroitOJAnimEdit.ZeroitObjectAnimationMode.ColorAnimation;

            }

            else if (generalContainer_Mode_ComboBox.SelectedIndex == FormAnimation)
            {
                objectAnimatorInput.AnimationMode = ZeroitOJAnimEdit.ZeroitObjectAnimationMode.FormAnimation;

            }

            else
            {
                objectAnimatorInput.AnimationMode = ZeroitOJAnimEdit.ZeroitObjectAnimationMode.StandardAnimation;

            } 
            #endregion

            #region Color Animation

            if (color_Animation_ComboBox.SelectedIndex == FillEllipse)
            {
                objectAnimatorInput.ColorAnimation = ZeroitOJAnimEdit.ZeroitObjectColorAnimation.FillEllipse;
                color_Animator.ColorAnimation = ZeroitOJAnim.ZeroitObjectColorAnimation.FillEllipse;

            }
            else if (color_Animation_ComboBox.SelectedIndex == FillSquare)
            {
                objectAnimatorInput.ColorAnimation = ZeroitOJAnimEdit.ZeroitObjectColorAnimation.FillSquare;
                color_Animator.ColorAnimation = ZeroitOJAnim.ZeroitObjectColorAnimation.FillSquare;
            }
            else if (color_Animation_ComboBox.SelectedIndex == SlideFill)
            {
                objectAnimatorInput.ColorAnimation = ZeroitOJAnimEdit.ZeroitObjectColorAnimation.SlideFill;
                color_Animator.ColorAnimation = ZeroitOJAnim.ZeroitObjectColorAnimation.SlideFill;
            }
            else if (color_Animation_ComboBox.SelectedIndex == SplitFill)
            {
                objectAnimatorInput.ColorAnimation = ZeroitOJAnimEdit.ZeroitObjectColorAnimation.SplitFill;
                color_Animator.ColorAnimation = ZeroitOJAnim.ZeroitObjectColorAnimation.SplitFill;
            }
            else
            {
                objectAnimatorInput.ColorAnimation = ZeroitOJAnimEdit.ZeroitObjectColorAnimation.StripeFill;
                color_Animator.ColorAnimation = ZeroitOJAnim.ZeroitObjectColorAnimation.StripeFill;
            }


            #endregion

            #region Values

            objectAnimatorInput.AnimationSpeed = (int)generalContainer_Speed_Numeric.Value;
            objectAnimatorInput.UpperSpeedLimit = (int)generalContainer_UpSpeed_Numeric.Value;
            objectAnimatorInput.LowerSpeedLimit = (int)generalContainer_LowSpeed_Numeric.Value;

            objectAnimatorInput.ColorToAnimate = color_Color_btn.BackColor;
            objectAnimatorInput.ColorAnimationDelay = (int)color_Delay_Numeric.Value;

            if (color_Yes_RadioBtn.Checked)
            {
                objectAnimatorInput.KeepColor = true;

            }
            else if (color_No_RadioBtn.Checked)
            {
                objectAnimatorInput.KeepColor = false;
            }



            #endregion

        }

        /// <summary>
        /// Sets the control form animation to initial values.
        /// </summary>
        /// <param name="objectAnimatorInput">The object animator input.</param>
        private void SetControl_FormAnimation_To_Initial_Values(ObjectAnimatorInput objectAnimatorInput)
        {
            if (objectAnimatorInput.AnimationMode == ZeroitOJAnimEdit.ZeroitObjectAnimationMode.ColorAnimation)
            {

                generalContainer_Mode_ComboBox.SelectedIndex = ColorAnimation;
                color_GroupBox.Visible = true;

                                
            }

            else if (objectAnimatorInput.AnimationMode == ZeroitOJAnimEdit.ZeroitObjectAnimationMode.FormAnimation)
            {
                generalContainer_Mode_ComboBox.SelectedIndex = FormAnimation;
                form_GroupBox.Visible = true;

                for (int i = 0; i < generalContainer_Control_ComboBox.Items.Count; i++)
                {
                    if (objectAnimatorInput.Control == (Control)(generalContainer_Control_ComboBox.Items[i]))
                    {
                        generalContainer_Control_ComboBox.SelectedIndex = i;
                    }

                }

            }

            else if (objectAnimatorInput.AnimationMode == ZeroitOJAnimEdit.ZeroitObjectAnimationMode.StandardAnimation)
            {
                generalContainer_Mode_ComboBox.SelectedIndex = StandardAnimation;
                standard_GroupBox.Visible = true;
            }

            else
            {
                //mainControl_animationProperty_Combo.SelectedIndex = None_Atomic;
                color_GroupBox.Visible = true;
                form_GroupBox.Visible = false;
                standard_GroupBox.Visible = false;

            }
        }

        /// <summary>
        /// Sets the control form animation to retrieved values.
        /// </summary>
        /// <param name="objectAnimatorInput">The object animator input.</param>
        private void SetControl_FormAnimation_To_Retrieved_Values(ObjectAnimatorInput objectAnimatorInput)
        {
            objectAnimatorInput.Control = (Control)generalContainer_Control_ComboBox.SelectedItem;

            #region General Container

            if (generalContainer_Mode_ComboBox.SelectedIndex == ColorAnimation)
            {
                objectAnimatorInput.AnimationMode = ZeroitOJAnimEdit.ZeroitObjectAnimationMode.ColorAnimation;

            }

            else if (generalContainer_Mode_ComboBox.SelectedIndex == FormAnimation)
            {
                objectAnimatorInput.AnimationMode = ZeroitOJAnimEdit.ZeroitObjectAnimationMode.FormAnimation;

            }

            else
            {
                objectAnimatorInput.AnimationMode = ZeroitOJAnimEdit.ZeroitObjectAnimationMode.StandardAnimation;

            }
            #endregion

            #region Form Animation

            if (form_Animation_ComboBox.SelectedIndex == FadeIn)
            {
                objectAnimatorInput.FormAnimation = ZeroitOJAnimEdit.ZeroitObjectFormAnimation.FadeIn;
                form_Animator.FormAnimation = ZeroitOJAnim.ZeroitObjectFormAnimation.FadeIn;

            }
            else
            {
                objectAnimatorInput.FormAnimation = ZeroitOJAnimEdit.ZeroitObjectFormAnimation.FadeOut;
                form_Animator.FormAnimation = ZeroitOJAnim.ZeroitObjectFormAnimation.FadeOut;
            }



            #endregion

            #region Values

            objectAnimatorInput.AnimationSpeed = (int)generalContainer_Speed_Numeric.Value;
            objectAnimatorInput.UpperSpeedLimit = (int)generalContainer_UpSpeed_Numeric.Value;
            objectAnimatorInput.LowerSpeedLimit = (int)generalContainer_LowSpeed_Numeric.Value;

            objectAnimatorInput.FormAnimationDelay = (int)form_Delay_Numeric.Value;


            #endregion

        }


        /// <summary>
        /// Sets the control standard animation to initial values.
        /// </summary>
        /// <param name="objectAnimatorInput">The object animator input.</param>
        private void SetControl_StandardAnimation_To_Initial_Values(ObjectAnimatorInput objectAnimatorInput)
        {
            if (objectAnimatorInput.AnimationMode == ZeroitOJAnimEdit.ZeroitObjectAnimationMode.ColorAnimation)
            {

                generalContainer_Mode_ComboBox.SelectedIndex = ColorAnimation;
                color_GroupBox.Visible = true;


            }

            else if (objectAnimatorInput.AnimationMode == ZeroitOJAnimEdit.ZeroitObjectAnimationMode.FormAnimation)
            {
                generalContainer_Mode_ComboBox.SelectedIndex = FormAnimation;
                form_GroupBox.Visible = true;
                
            }

            else if (objectAnimatorInput.AnimationMode == ZeroitOJAnimEdit.ZeroitObjectAnimationMode.StandardAnimation)
            {
                generalContainer_Mode_ComboBox.SelectedIndex = StandardAnimation;
                standard_GroupBox.Visible = true;

                for (int i = 0; i < generalContainer_Control_ComboBox.Items.Count; i++)
                {
                    if (objectAnimatorInput.Control == (Control)(generalContainer_Control_ComboBox.Items[i]))
                    {
                        generalContainer_Control_ComboBox.SelectedIndex = i;
                    }

                }
            }

            else
            {
                //mainControl_animationProperty_Combo.SelectedIndex = None_Atomic;
                color_GroupBox.Visible = true;
                form_GroupBox.Visible = false;
                standard_GroupBox.Visible = false;

            }
        }

        /// <summary>
        /// Sets the control standard animation to retrieved values.
        /// </summary>
        /// <param name="objectAnimatorInput">The object animator input.</param>
        private void SetControl_StandardAnimation_To_Retrieved_Values(ObjectAnimatorInput objectAnimatorInput)
        {
            objectAnimatorInput.Control = (Control)generalContainer_Control_ComboBox.SelectedItem;

            #region General Container

            if (generalContainer_Mode_ComboBox.SelectedIndex == ColorAnimation)
            {
                objectAnimatorInput.AnimationMode = ZeroitOJAnimEdit.ZeroitObjectAnimationMode.ColorAnimation;

            }

            else if (generalContainer_Mode_ComboBox.SelectedIndex == FormAnimation)
            {
                objectAnimatorInput.AnimationMode = ZeroitOJAnimEdit.ZeroitObjectAnimationMode.FormAnimation;

            }

            else
            {
                objectAnimatorInput.AnimationMode = ZeroitOJAnimEdit.ZeroitObjectAnimationMode.StandardAnimation;

            }
            #endregion

            #region Standard Animation

            if (standard_Animation_ComboBox.SelectedIndex == Hop)
            {
                objectAnimatorInput.StandardAnimation = ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.Hop;

                standard_Animator.StandardAnimation = ZeroitOJAnim.ZeroitObjectStandardAnimation.Hop;
            }

            else if (standard_Animation_ComboBox.SelectedIndex == ShootLeft)
            {
                objectAnimatorInput.StandardAnimation = ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.ShootLeft;
                standard_Animator.StandardAnimation = ZeroitOJAnim.ZeroitObjectStandardAnimation.ShootLeft;
            }

            else if (standard_Animation_ComboBox.SelectedIndex == ShootRight)
            {
                objectAnimatorInput.StandardAnimation = ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.ShootRight;
                standard_Animator.StandardAnimation = ZeroitOJAnim.ZeroitObjectStandardAnimation.ShootRight;
            }

            else if (standard_Animation_ComboBox.SelectedIndex == SlideDown)
            {
                objectAnimatorInput.StandardAnimation = ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.SlideDown;
                standard_Animator.StandardAnimation = ZeroitOJAnim.ZeroitObjectStandardAnimation.SlideDown;
            }

            else if (standard_Animation_ComboBox.SelectedIndex == SlideLeft)
            {
                objectAnimatorInput.StandardAnimation = ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.SlideLeft;
                standard_Animator.StandardAnimation = ZeroitOJAnim.ZeroitObjectStandardAnimation.SlideLeft;
            }

            else if (standard_Animation_ComboBox.SelectedIndex == SlideRight)
            {
                objectAnimatorInput.StandardAnimation = ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.SlideRight;
                standard_Animator.StandardAnimation = ZeroitOJAnim.ZeroitObjectStandardAnimation.SlideRight;
            }

            else if (standard_Animation_ComboBox.SelectedIndex == SlideUp)
            {
                objectAnimatorInput.StandardAnimation = ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.SlideUp;
                standard_Animator.StandardAnimation = ZeroitOJAnim.ZeroitObjectStandardAnimation.SlideUp;
            }

            else if (standard_Animation_ComboBox.SelectedIndex == SlugLeft)
            {
                objectAnimatorInput.StandardAnimation = ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.SlugLeft;
                standard_Animator.StandardAnimation = ZeroitOJAnim.ZeroitObjectStandardAnimation.SlugLeft;
            }

            else
            {
                objectAnimatorInput.StandardAnimation = ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.SlugRight;
                standard_Animator.StandardAnimation = ZeroitOJAnim.ZeroitObjectStandardAnimation.SlugRight;
            }

            #endregion

            #region Values

            objectAnimatorInput.AnimationSpeed = (int)generalContainer_Speed_Numeric.Value;
            objectAnimatorInput.UpperSpeedLimit = (int)generalContainer_UpSpeed_Numeric.Value;
            objectAnimatorInput.LowerSpeedLimit = (int)generalContainer_LowSpeed_Numeric.Value;

            objectAnimatorInput.StandardHopDelay = (int)standard_HopDelay_Numeric.Value;
            objectAnimatorInput.StandardShootDelay = (int)standard_ShootDelay_Numeric.Value;
            objectAnimatorInput.StandardSlideDelay = (int)standard_SlideDelay_Numeric.Value;
            objectAnimatorInput.StandardSlugDelay[0]= (int)standard_SlugDelay0_Numeric.Value;
            objectAnimatorInput.StandardSlugDelay[1] = (int)standard_SlugDelay1_Numeric.Value;

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
            if(generalContainer_Mode_ComboBox.SelectedIndex == ColorAnimation)
            {
                objectAnimatorInput = new ObjectAnimatorInput(
                    ZeroitOJAnimEdit.ZeroitObjectAnimationMode.ColorAnimation, 
                    ZeroitOJAnimEdit.ZeroitObjectColorAnimation.FillEllipse,
                    1,10,1,200,40, 
                    (Control)generalContainer_Control_ComboBox.SelectedItem, 
                    Color.AliceBlue,false);

                SetControl_ColorAnimation_To_Retrieved_Values(objectAnimatorInput);
            }
            else if(generalContainer_Mode_ComboBox.SelectedIndex == FormAnimation)
            {
                objectAnimatorInput = new ObjectAnimatorInput(
                    ZeroitOJAnimEdit.ZeroitObjectAnimationMode.FormAnimation,
                    ZeroitOJAnimEdit.ZeroitObjectFormAnimation.FadeIn,
                    1, 10, 1, 200, 50,
                    (Control)generalContainer_Control_ComboBox.SelectedItem);

                SetControl_FormAnimation_To_Retrieved_Values(objectAnimatorInput);
            }
            else
            {
                objectAnimatorInput = new ObjectAnimatorInput(
                    ZeroitOJAnimEdit.ZeroitObjectAnimationMode.StandardAnimation,
                    ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.Hop,
                    1, 10, 1, 200,(Control)generalContainer_Control_ComboBox.SelectedItem,
                    40, new int[]{100,50},100,50);

                SetControl_StandardAnimation_To_Retrieved_Values(objectAnimatorInput);
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
        /// Handles the Click event of the color_Color_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void color_Color_btn_Click(object sender, EventArgs e)
        {
            if(colorToUse.ShowDialog() == DialogResult.OK)
            {
                color_Color_btn.BackColor = colorToUse.Color;
                //color_Preview_Panel.BackColor = colorToUse.Color;

                color_Animator.ColorToAnimate = colorToUse.Color;
            }
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
            closeBtn.BackColor = Color.FromArgb(25, 25, 25);
        }

        /// <summary>
        /// Handles the MouseEnter event of the color_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void color_Preview_btn_MouseEnter(object sender, EventArgs e)
        {
            color_Preview_btn.FlatAppearance.BorderSize = 1;
            color_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the color_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void color_Preview_btn_MouseLeave(object sender, EventArgs e)
        {
            color_Preview_btn.FlatAppearance.BorderSize = 0;
            color_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 25);
        }

        /// <summary>
        /// Handles the MouseEnter event of the form_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void form_Preview_btn_MouseEnter(object sender, EventArgs e)
        {
            form_Preview_btn.FlatAppearance.BorderSize = 1;
            form_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the form_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void form_Preview_btn_MouseLeave(object sender, EventArgs e)
        {
            form_Preview_btn.FlatAppearance.BorderSize = 0;
            form_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 25);
        }

        /// <summary>
        /// Handles the MouseEnter event of the standard_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void standard_Preview_btn_MouseEnter(object sender, EventArgs e)
        {
            standard_Preview_btn.FlatAppearance.BorderSize = 1;
            standard_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the standard_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void standard_Preview_btn_MouseLeave(object sender, EventArgs e)
        {
            standard_Preview_btn.FlatAppearance.BorderSize = 0;
            standard_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 25);
        }

        /// <summary>
        /// Handles the Click event of the color_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void color_Preview_btn_Click(object sender, EventArgs e)
        {
            color_Animator.Start();
        }

        /// <summary>
        /// Handles the Click event of the form_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void form_Preview_btn_Click(object sender, EventArgs e)
        {
            form_Animator.Start();
        }

        /// <summary>
        /// Handles the Click event of the standard_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void standard_Preview_btn_Click(object sender, EventArgs e)
        {
            standard_Animator.Start();
        }

        /// <summary>
        /// Handles the ValueChanged event of the generalContainer_Speed_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void generalContainer_Speed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            color_Animator.AnimationSpeed = (int)generalContainer_Speed_Numeric.Value;
            form_Animator.AnimationSpeed = (int)generalContainer_Speed_Numeric.Value;
            standard_Animator.AnimationSpeed = (int)generalContainer_Speed_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the generalContainer_UpSpeed_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void generalContainer_UpSpeed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            color_Animator.UpperSpeedLimit = (int)generalContainer_UpSpeed_Numeric.Value;
            form_Animator.UpperSpeedLimit = (int)generalContainer_UpSpeed_Numeric.Value;
            standard_Animator.UpperSpeedLimit = (int)generalContainer_UpSpeed_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the generalContainer_LowSpeed_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void generalContainer_LowSpeed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            color_Animator.LowerSpeedLimit = (int)generalContainer_LowSpeed_Numeric.Value;
            form_Animator.LowerSpeedLimit = (int)generalContainer_LowSpeed_Numeric.Value;
            standard_Animator.LowerSpeedLimit = (int)generalContainer_LowSpeed_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the color_Delay_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void color_Delay_Numeric_ValueChanged(object sender, EventArgs e)
        {
            color_Animator.ColorAnimationDelay = (int)color_Delay_Numeric.Value;
        }

        /// <summary>
        /// Handles the CheckedChanged event of the color_Yes_RadioBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void color_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(color_Yes_RadioBtn.Checked)
            {
                color_Animator.KeepColor = true;
            }
            else
            {
                color_Animator.KeepColor = false;
            }
            
        }

        /// <summary>
        /// Handles the CheckedChanged event of the color_No_RadioBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void color_No_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (color_No_RadioBtn.Checked)
            {
                color_Animator.KeepColor = false;
            }
            else
            {
                color_Animator.KeepColor = true;
            }
        }

        /// <summary>
        /// Handles the ValueChanged event of the form_Delay_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void form_Delay_Numeric_ValueChanged(object sender, EventArgs e)
        {
            form_Animator.FormAnimationDelay = (int)form_Delay_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the standard_HopDelay_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void standard_HopDelay_Numeric_ValueChanged(object sender, EventArgs e)
        {
            standard_Animator.StandardHopDelay = (int)standard_HopDelay_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the standard_ShootDelay_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void standard_ShootDelay_Numeric_ValueChanged(object sender, EventArgs e)
        {
            standard_Animator.StandardShootDelay = (int)standard_ShootDelay_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the standard_SlideDelay_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void standard_SlideDelay_Numeric_ValueChanged(object sender, EventArgs e)
        {
            standard_Animator.StandardSlideDelay = (int)standard_SlideDelay_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the standard_SlugDelay0_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void standard_SlugDelay0_Numeric_ValueChanged(object sender, EventArgs e)
        {
            standard_Animator.StandardSlugDelay[0] = (int)standard_SlugDelay0_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the standard_SlugDelay1_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void standard_SlugDelay1_Numeric_ValueChanged(object sender, EventArgs e)
        {
            standard_Animator.StandardSlugDelay[1] = (int)standard_SlugDelay1_Numeric.Value;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the color_Animation_ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void color_Animation_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Color Animation

            if (color_Animation_ComboBox.SelectedIndex == FillEllipse)
            {
                color_Animator.ColorAnimation = ZeroitOJAnim.ZeroitObjectColorAnimation.FillEllipse;

            }
            else if (color_Animation_ComboBox.SelectedIndex == FillSquare)
            {
                color_Animator.ColorAnimation = ZeroitOJAnim.ZeroitObjectColorAnimation.FillSquare;
            }
            else if (color_Animation_ComboBox.SelectedIndex == SlideFill)
            {
                color_Animator.ColorAnimation = ZeroitOJAnim.ZeroitObjectColorAnimation.SlideFill;
            }
            else if (color_Animation_ComboBox.SelectedIndex == SplitFill)
            {
                color_Animator.ColorAnimation = ZeroitOJAnim.ZeroitObjectColorAnimation.SplitFill;
            }
            else
            {
                color_Animator.ColorAnimation = ZeroitOJAnim.ZeroitObjectColorAnimation.StripeFill;
            }


            #endregion
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the form_Animation_ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void form_Animation_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Form Animation

            if (form_Animation_ComboBox.SelectedIndex == FadeIn)
            {
                form_Animator.FormAnimation = ZeroitOJAnim.ZeroitObjectFormAnimation.FadeIn;

            }
            else
            {
                form_Animator.FormAnimation = ZeroitOJAnim.ZeroitObjectFormAnimation.FadeOut;
            }



            #endregion
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the standard_Animation_ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void standard_Animation_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Standard Animation

            if (standard_Animation_ComboBox.SelectedIndex == Hop)
            {
                standard_Animator.StandardAnimation = ZeroitOJAnim.ZeroitObjectStandardAnimation.Hop;
            }

            else if (standard_Animation_ComboBox.SelectedIndex == ShootLeft)
            {
                try
                {
                    standard_Animator.StandardAnimation = ZeroitOJAnim.ZeroitObjectStandardAnimation.ShootLeft;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }

            else if (standard_Animation_ComboBox.SelectedIndex == ShootRight)
            {
                standard_Animator.StandardAnimation = ZeroitOJAnim.ZeroitObjectStandardAnimation.ShootRight;
            }

            else if (standard_Animation_ComboBox.SelectedIndex == SlideDown)
            {
                standard_Animator.StandardAnimation = ZeroitOJAnim.ZeroitObjectStandardAnimation.SlideDown;
            }

            else if (standard_Animation_ComboBox.SelectedIndex == SlideLeft)
            {
                standard_Animator.StandardAnimation = ZeroitOJAnim.ZeroitObjectStandardAnimation.SlideLeft;
            }

            else if (standard_Animation_ComboBox.SelectedIndex == SlideRight)
            {
                standard_Animator.StandardAnimation = ZeroitOJAnim.ZeroitObjectStandardAnimation.SlideRight;
            }

            else if (standard_Animation_ComboBox.SelectedIndex == SlideUp)
            {
                standard_Animator.StandardAnimation = ZeroitOJAnim.ZeroitObjectStandardAnimation.SlideUp;
            }

            else if (standard_Animation_ComboBox.SelectedIndex == SlugLeft)
            {
                standard_Animator.StandardAnimation = ZeroitOJAnim.ZeroitObjectStandardAnimation.SlugLeft;
            }

            else
            {
                standard_Animator.StandardAnimation = ZeroitOJAnim.ZeroitObjectStandardAnimation.SlugRight;
            }

            #endregion
        }

        
    }
}
