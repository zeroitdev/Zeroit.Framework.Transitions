using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeroit.Framework.Transitions.ZeroitFormAnimator;

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    public partial class FormAnimatorDialog : Form
    {
        #region Private Fields

        PreviewForm previewForm = new PreviewForm();

        #endregion

        #region Public Properties

        /// <summary>
        /// The atomic animator input
        /// </summary>
        private FormAnimatorInput formAnimatorInput;

        /// <summary>
        /// Gets the atomic animator input.
        /// </summary>
        /// <value>The atomic animator input.</value>
        public FormAnimatorInput FormAnimatorInput
        {
            get { return formAnimatorInput; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// at the default window position.
        /// </summary>
        public FormAnimatorDialog() : this(FormAnimatorInput.Empty())
        {
            Size = new Size(630, 330);
            baseTheme.Sizable = false;

            CenterScreen(this);

            location_Label.Text = string.Format("Location  ( X : {0} Y : {1} )", Location.X, Location.Y);

            size_Label.Text = string.Format("Size  ( Width : {0} , Height : {1} )", Size.Width, Size.Height);

        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// at the default window position.
        /// </summary>
        /// <param name="formAnimatorInput">The atomic animator input.</param>
        /// <exception cref="ArgumentNullException">formAnimatorInput</exception>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="peaceInput" /> is null.</exception>
        public FormAnimatorDialog(FormAnimatorInput formAnimatorInput)
        {
            if (formAnimatorInput == null)
            {
                throw new ArgumentNullException("formAnimatorInput");
            }


            InitializeComponent();


            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            Size = new Size(630, 330);
            baseTheme.Sizable = false;
            CenterScreen(this);

            location_Label.Text = string.Format("Location  ( X : {0} Y : {1} )", Location.X, Location.Y);

            size_Label.Text = string.Format("Size  ( Width : {0} , Height : {1} )", Size.Width, Size.Height);


            SetInitial_Values(formAnimatorInput);

            previewForm.startReset.Click += StartReset_Click;

            previewForm.MouseClick += PreviewForm_MouseClick;

            baseTheme.MouseClick += PreviewForm_MouseClick;

        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        public FormAnimatorDialog(Control c) : this(FormAnimatorInput.Empty(), c)
        {
            Size = new Size(630, 330);
            baseTheme.Sizable = false;
            CenterScreen(this);

            location_Label.Text = string.Format("Location  ( X : {0} Y : {1} )", Location.X, Location.Y);

            size_Label.Text = string.Format("Size  ( Width : {0} , Height : {1} )", Size.Width, Size.Height);

        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="formAnimatorInput">The atomic animator input.</param>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="filler" /> is null.</exception>
        public FormAnimatorDialog(FormAnimatorInput formAnimatorInput, Control c) : this(formAnimatorInput)
        {

            //Zeroit.Framework.Transitions.AnimationEditors.Utilities.Draw.SetStartPositionBelowControl(this, c);

            Size = new Size(630, 330);
            baseTheme.Sizable = false;
            CenterScreen(this);

            location_Label.Text = string.Format("Location  ( X : {0} Y : {1} )", Location.X, Location.Y);

            size_Label.Text = string.Format("Size  ( Width : {0} , Height : {1} )", Size.Width, Size.Height);

        }

        #endregion

        #region Set Initial Values

        private void SetInitial_Values(FormAnimatorInput formAnimatorInput)
        {

            #region Main Animation

            #region Add Enum to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string volume in Enum.GetNames(typeof(FormAnimationTypes)))
            {
                mainAnimation_ComboBox.Items.Add(volume);

            }

            for (int i = 0; i < mainAnimation_ComboBox.Items.Count; i++)
            {
                if (formAnimatorInput.Animation == (FormAnimationTypes)Enum.Parse(typeof(FormAnimationTypes), mainAnimation_ComboBox.Items[i].ToString()))
                {
                    mainAnimation_ComboBox.SelectedIndex = i;

                }

            }

            #endregion

            mainTime_Numeric.Value = formAnimatorInput.Time.Time;
            mainStep_X_Numeric.Value = formAnimatorInput.Time.StepX;
            mainStep_Y_Numeric.Value = formAnimatorInput.Time.StepY;

            #endregion

            #region Positions

            positions_Start_Numeric.Value = formAnimatorInput.Positions.Start;
            positions_End_Numeric.Value = formAnimatorInput.Positions.End;

            positions_StartPoint_X_Numeric.Value = formAnimatorInput.Positions.StartPoint.X;
            positions_StartPoint_Y_Numeric.Value = formAnimatorInput.Positions.StartPoint.Y;
            positions_EndPoint_X_Numeric.Value = formAnimatorInput.Positions.EndPoint.X;
            positions_EndPoint_Y_Numeric.Value = formAnimatorInput.Positions.EndPoint.Y;

            positions_Size_Height_Numeric.Value = formAnimatorInput.Positions.Size.Height;
            positions_Size_Width_Numeric.Value = formAnimatorInput.Positions.Size.Width;

            if (formAnimatorInput.Positions.ShrinkToCenter)
            {
                positions_ShrinkToCenter_Yes.Checked = true;
                positions_ShrinkToCenter_No.Checked = false;
            }
            else
            {
                positions_ShrinkToCenter_Yes.Checked = false;
                positions_ShrinkToCenter_No.Checked = true;
            }

            #endregion

            #region Shake

            #region Add Enum to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string volume in Enum.GetNames(typeof(ShakeType)))
            {
                shakeType_ComboBox.Items.Add(volume);

            }

            for (int i = 0; i < shakeType_ComboBox.Items.Count; i++)
            {
                if (formAnimatorInput.Shake.ShakeType == (ShakeType)Enum.Parse(typeof(ShakeType), shakeType_ComboBox.Items[i].ToString()))
                {
                    shakeType_ComboBox.SelectedIndex = i;

                }

            }
            #endregion

            shakeSpeed_Numeric.Value = formAnimatorInput.Shake.ShakeSpeed;
            shakeDistance_Numeric.Value = formAnimatorInput.Shake.ShakeDistance;

            #endregion

            #region Grow

            grow_Start_Numeric.Value = formAnimatorInput.Grow.Start;
            grow_End_Numeric.Value = formAnimatorInput.Grow.End;

            grow_StartPoint_X_Numeric.Value = formAnimatorInput.Grow.StartPoint.X;
            grow_StartPoint_Y_Numeric.Value = formAnimatorInput.Grow.StartPoint.Y;
            grow_EndPoint_X_Numeric.Value = formAnimatorInput.Grow.EndPoint.X;
            grow_EndPoint_Y_Numeric.Value = formAnimatorInput.Grow.EndPoint.Y;

            grow_Size_Height_Numeric.Value = formAnimatorInput.Positions.Size.Height;
            grow_Size_Width_Numeric.Value = formAnimatorInput.Positions.Size.Width;

            if (formAnimatorInput.Grow.FixWindowWhenGrown)
            {
                grow_FixGrown_Yes.Checked = true;
                grow_FixGrown_No.Checked = false;
            }
            else
            {
                grow_FixGrown_Yes.Checked = false;
                grow_FixGrown_No.Checked = true;
            }

            if (formAnimatorInput.Grow.Recalculate)
            {
                grow_Recalculate_Yes.Checked = true;
                grow_Recalculate_No.Checked = false;
            }
            else
            {
                grow_Recalculate_Yes.Checked = false;
                grow_Recalculate_No.Checked = true;
            }
            #endregion

            #region Locations

            switch (formAnimatorInput.Locations.FormLocations)
            {
                case FormLocations.TopLeft:
                    locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Yellow;
                    locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random1_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random2_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random3_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random4_Btn.FlatAppearance.BorderColor = Color.Cyan;


                    break;
                case FormLocations.TopRight:
                    locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Yellow;
                    locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random1_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random2_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random3_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random4_Btn.FlatAppearance.BorderColor = Color.Cyan;

                    break;
                case FormLocations.BottomLeft:
                    locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Yellow;
                    locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random1_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random2_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random3_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random4_Btn.FlatAppearance.BorderColor = Color.Cyan;

                    break;
                case FormLocations.BottomRight:
                    locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Yellow;
                    locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random1_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random2_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random3_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random4_Btn.FlatAppearance.BorderColor = Color.Cyan;

                    break;
                case FormLocations.TopCenter:
                    locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Yellow;
                    locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random1_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random2_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random3_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random4_Btn.FlatAppearance.BorderColor = Color.Cyan;

                    break;
                case FormLocations.BottomCenter:
                    locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Yellow;
                    locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random1_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random2_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random3_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random4_Btn.FlatAppearance.BorderColor = Color.Cyan;

                    break;
                case FormLocations.LeftCenter:
                    locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Yellow;
                    locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random1_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random2_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random3_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random4_Btn.FlatAppearance.BorderColor = Color.Cyan;

                    break;
                case FormLocations.RightCenter:
                    locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Yellow;
                    locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random1_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random2_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random3_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random4_Btn.FlatAppearance.BorderColor = Color.Cyan;

                    break;
                case FormLocations.RandomPoint:
                    locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random1_Btn.FlatAppearance.BorderColor = Color.Yellow;
                    locations_Random2_Btn.FlatAppearance.BorderColor = Color.Yellow;
                    locations_Random3_Btn.FlatAppearance.BorderColor = Color.Yellow;
                    locations_Random4_Btn.FlatAppearance.BorderColor = Color.Yellow;

                    break;
                case FormLocations.CenterScreen:
                    locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Yellow;
                    locations_Random1_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random2_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random3_Btn.FlatAppearance.BorderColor = Color.Cyan;
                    locations_Random4_Btn.FlatAppearance.BorderColor = Color.Cyan;

                    break;
                default:
                    break;
            }

            #endregion

            #region Move

            move_StartPoint_X_Numeric.Value = formAnimatorInput.Move.StartPoint.X;
            move_StartPoint_Y_Numeric.Value = formAnimatorInput.Move.StartPoint.Y;
            move_EndPoint_X_Numeric.Value = formAnimatorInput.Move.EndPoint.X;
            move_EndPoint_Y_Numeric.Value = formAnimatorInput.Move.EndPoint.Y;

            //Direct Trajectory
            if (formAnimatorInput.Move.DirectTrajectory)
            {
                move_DirectTrajectory_Yes.Checked = true;
                move_DirectTrajectory_No.Checked = false;
            }
            else
            {
                move_DirectTrajectory_Yes.Checked = false;
                move_DirectTrajectory_No.Checked = true;
            }

            //Move To Point
            if (formAnimatorInput.MoveToPoint)
            {
                move_MoveToPoint_Yes.Checked = true;
                move_MoveToPoint_No.Checked = false;
            }
            else
            {
                move_MoveToPoint_Yes.Checked = false;
                move_MoveToPoint_No.Checked = true;
            }

            //Random Locations
            foreach (Point var in formAnimatorInput.Move.RandomLocations)
            {
                move_ListedPoints_ListBox.Items.Add(var);
            }

            #endregion

            #region Opacity

            opacityStart_Numeric.Value = (decimal)formAnimatorInput.Opacity.Start;
            opacityStep_Numeric.Value = (decimal)formAnimatorInput.Opacity.Step;


            #endregion

            #region Show Group Box

            if (mainAnimation_ComboBox.SelectedIndex ==
                    (int)FormAnimationTypes.BottomToTop)
            {
                positionsGroupBox.Visible = true;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                positions_Start_Numeric.Enabled = true;
                positions_End_Numeric.Enabled = true;
                positions_ShrinkToCenter_Yes.Enabled = false;
                positions_ShrinkToCenter_No.Enabled = false;
                positions_StartPoint_X_Numeric.Enabled = false;
                positions_StartPoint_Y_Numeric.Enabled = false;
                positions_EndPoint_X_Numeric.Enabled = false;
                positions_EndPoint_Y_Numeric.Enabled = false;
                positions_Size_Height_Numeric.Enabled = false;
                positions_Size_Width_Numeric.Enabled = false;

            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.DeterminerPosition)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = true;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.FadeIn)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = true;
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.FadeOut)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = true;
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.GrowHorizontal)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = true;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                grow_Start_Numeric.Enabled = true;
                grow_End_Numeric.Enabled = true;
                grow_FixGrown_Yes.Enabled = true;
                grow_FixGrown_No.Enabled = true;
                grow_StartPoint_X_Numeric.Enabled = false;
                grow_StartPoint_Y_Numeric.Enabled = false;
                grow_EndPoint_X_Numeric.Enabled = false;
                grow_EndPoint_Y_Numeric.Enabled = false;
                grow_Size_Height_Numeric.Enabled = false;
                grow_Size_Width_Numeric.Enabled = false;

            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.GrowVertical)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = true;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                grow_Start_Numeric.Enabled = true;
                grow_End_Numeric.Enabled = true;
                grow_FixGrown_Yes.Enabled = true;
                grow_FixGrown_No.Enabled = true;
                grow_StartPoint_X_Numeric.Enabled = false;
                grow_StartPoint_Y_Numeric.Enabled = false;
                grow_EndPoint_X_Numeric.Enabled = false;
                grow_EndPoint_Y_Numeric.Enabled = false;
                grow_Size_Height_Numeric.Enabled = false;
                grow_Size_Width_Numeric.Enabled = false;
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.GrowXY)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = true;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                grow_Start_Numeric.Enabled = false;
                grow_End_Numeric.Enabled = false;
                grow_FixGrown_Yes.Enabled = true;
                grow_FixGrown_No.Enabled = true;
                grow_StartPoint_X_Numeric.Enabled = true;
                grow_StartPoint_Y_Numeric.Enabled = true;
                grow_EndPoint_X_Numeric.Enabled = true;
                grow_EndPoint_Y_Numeric.Enabled = true;
                grow_Size_Height_Numeric.Enabled = false;
                grow_Size_Width_Numeric.Enabled = false;
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.GrowMoveXY)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = true;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                grow_Start_Numeric.Enabled = false;
                grow_End_Numeric.Enabled = false;
                grow_FixGrown_Yes.Enabled = true;
                grow_FixGrown_No.Enabled = true;
                grow_StartPoint_X_Numeric.Enabled = true;
                grow_StartPoint_Y_Numeric.Enabled = true;
                grow_EndPoint_X_Numeric.Enabled = true;
                grow_EndPoint_Y_Numeric.Enabled = true;
                grow_Size_Height_Numeric.Enabled = true;
                grow_Size_Width_Numeric.Enabled = true;
                grow_Recalculate_Yes.Enabled = true;
                grow_Recalculate_No.Enabled = true;
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.HideControls)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.LeftToRight)
            {
                positionsGroupBox.Visible = true;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                positions_Start_Numeric.Enabled = true;
                positions_End_Numeric.Enabled = true;
                positions_ShrinkToCenter_Yes.Enabled = false;
                positions_ShrinkToCenter_No.Enabled = false;
                positions_StartPoint_X_Numeric.Enabled = false;
                positions_StartPoint_Y_Numeric.Enabled = false;
                positions_EndPoint_X_Numeric.Enabled = false;
                positions_EndPoint_Y_Numeric.Enabled = false;
                positions_Size_Height_Numeric.Enabled = false;
                positions_Size_Width_Numeric.Enabled = false;
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.LeftToRightVertical)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.Move)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = true;
                opacityGroupBox.Visible = false;



                move_StartPoint_X_Numeric.Enabled = true;
                move_StartPoint_Y_Numeric.Enabled = true;
                move_EndPoint_X_Numeric.Enabled = true;
                move_EndPoint_Y_Numeric.Enabled = true;
                move_DirectTrajectory_Yes.Enabled = true;
                move_DirectTrajectory_No.Enabled = true;
                move_MoveToPoint_Yes.Enabled = true;
                move_MoveToPoint_No.Enabled = true;

                if (move_MoveToPoint_Yes.Checked)
                {
                    move_RandPoint_X_Numeric.Enabled = true;
                    move_RandPoint_Y_Numeric.Enabled = true;
                    move_Add_Point_Btn.Enabled = true;
                    move_ListedPoints_ListBox.Enabled = true;
                }
                else
                {
                    move_RandPoint_X_Numeric.Enabled = false;
                    move_RandPoint_Y_Numeric.Enabled = false;
                    move_Add_Point_Btn.Enabled = false;
                    move_ListedPoints_ListBox.Enabled = false;
                }
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.RightToLeft)
            {
                positionsGroupBox.Visible = true;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                positions_Start_Numeric.Enabled = true;
                positions_End_Numeric.Enabled = true;
                positions_ShrinkToCenter_Yes.Enabled = false;
                positions_ShrinkToCenter_No.Enabled = false;
                positions_StartPoint_X_Numeric.Enabled = false;
                positions_StartPoint_Y_Numeric.Enabled = false;
                positions_EndPoint_X_Numeric.Enabled = false;
                positions_EndPoint_Y_Numeric.Enabled = false;
                positions_Size_Height_Numeric.Enabled = false;
                positions_Size_Width_Numeric.Enabled = false;
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.Shake)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = true;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.ShowControls)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.ShrinkFadeOut)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.ShrinkHorizontal)
            {
                positionsGroupBox.Visible = true;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                positions_Start_Numeric.Enabled = true;
                positions_End_Numeric.Enabled = true;
                positions_ShrinkToCenter_Yes.Enabled = false;
                positions_ShrinkToCenter_No.Enabled = false;
                positions_StartPoint_X_Numeric.Enabled = false;
                positions_StartPoint_Y_Numeric.Enabled = false;
                positions_EndPoint_X_Numeric.Enabled = false;
                positions_EndPoint_Y_Numeric.Enabled = false;
                positions_Size_Height_Numeric.Enabled = false;
                positions_Size_Width_Numeric.Enabled = false;
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.ShrinkMoveXY)
            {
                positionsGroupBox.Visible = true;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                positions_Start_Numeric.Enabled = false;
                positions_End_Numeric.Enabled = false;
                positions_ShrinkToCenter_Yes.Enabled = true;
                positions_ShrinkToCenter_No.Enabled = true;
                positions_StartPoint_X_Numeric.Enabled = true;
                positions_StartPoint_Y_Numeric.Enabled = true;
                positions_EndPoint_X_Numeric.Enabled = true;
                positions_EndPoint_Y_Numeric.Enabled = true;
                positions_Size_Height_Numeric.Enabled = true;
                positions_Size_Width_Numeric.Enabled = true;
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.ShrinkVertical)
            {
                positionsGroupBox.Visible = true;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                positions_Start_Numeric.Enabled = true;
                positions_End_Numeric.Enabled = true;
                positions_ShrinkToCenter_Yes.Enabled = false;
                positions_ShrinkToCenter_No.Enabled = false;
                positions_StartPoint_X_Numeric.Enabled = false;
                positions_StartPoint_Y_Numeric.Enabled = false;
                positions_EndPoint_X_Numeric.Enabled = false;
                positions_EndPoint_Y_Numeric.Enabled = false;
                positions_Size_Height_Numeric.Enabled = false;
                positions_Size_Width_Numeric.Enabled = false;
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.ShrinkXY)
            {
                positionsGroupBox.Visible = true;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                positions_Start_Numeric.Enabled = false;
                positions_End_Numeric.Enabled = false;
                positions_ShrinkToCenter_Yes.Enabled = false;
                positions_ShrinkToCenter_No.Enabled = false;
                positions_StartPoint_X_Numeric.Enabled = true;
                positions_StartPoint_Y_Numeric.Enabled = true;
                positions_EndPoint_X_Numeric.Enabled = true;
                positions_EndPoint_Y_Numeric.Enabled = true;
                positions_Size_Height_Numeric.Enabled = false;
                positions_Size_Width_Numeric.Enabled = false;
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.TopToBottom)
            {
                positionsGroupBox.Visible = true;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                positions_Start_Numeric.Enabled = true;
                positions_End_Numeric.Enabled = true;
                positions_ShrinkToCenter_Yes.Enabled = false;
                positions_ShrinkToCenter_No.Enabled = false;
                positions_StartPoint_X_Numeric.Enabled = false;
                positions_StartPoint_Y_Numeric.Enabled = false;
                positions_EndPoint_X_Numeric.Enabled = false;
                positions_EndPoint_Y_Numeric.Enabled = false;
                positions_Size_Height_Numeric.Enabled = false;
                positions_Size_Width_Numeric.Enabled = false;
            }

            else
            {

            }
            #endregion


        }

        #endregion

        #region Set Retrieved Values

        public void SetRetrievedValues(FormAnimatorInput formAnimatorInput)
        {
            #region Main Animation

            #region Enum Retrieval

            formAnimatorInput.Animation =
                (FormAnimationTypes)Enum.Parse(
                    typeof(FormAnimationTypes),
                    mainAnimation_ComboBox.SelectedItem.ToString());

            #endregion


            formAnimatorInput.Time.Time = (int)mainTime_Numeric.Value;
            formAnimatorInput.Time.StepX = (int)mainStep_X_Numeric.Value;
            formAnimatorInput.Time.StepY = (int)mainStep_Y_Numeric.Value;

            #endregion

            #region Positions

            formAnimatorInput.Positions.Start = (int)positions_Start_Numeric.Value;
            formAnimatorInput.Positions.End = (int)positions_End_Numeric.Value;

            formAnimatorInput.Positions.StartPoint = new Point((int)positions_StartPoint_X_Numeric.Value, (int)positions_StartPoint_Y_Numeric.Value);
            formAnimatorInput.Positions.EndPoint = new Point((int)positions_EndPoint_X_Numeric.Value, (int)positions_EndPoint_Y_Numeric.Value);

            formAnimatorInput.Positions.Size = new Size((int)positions_Size_Height_Numeric.Value, (int)positions_Size_Width_Numeric.Value);


            if (positions_ShrinkToCenter_Yes.Checked)
            {
                formAnimatorInput.Positions.ShrinkToCenter = true;

            }
            else
            {
                formAnimatorInput.Positions.ShrinkToCenter = false;
            }

            #endregion

            #region Shake

            #region Enum Retrieval

            formAnimatorInput.Shake.ShakeType =
                    (ShakeType)Enum.Parse(
                        typeof(ShakeType),
                        shakeType_ComboBox.SelectedItem.ToString());
            #endregion

            formAnimatorInput.Shake.ShakeSpeed = (int)shakeSpeed_Numeric.Value;
            formAnimatorInput.Shake.ShakeDistance = (int)shakeDistance_Numeric.Value;

            #endregion

            #region Grow

            formAnimatorInput.Grow.Start = (int)grow_Start_Numeric.Value;
            formAnimatorInput.Grow.End = (int)grow_End_Numeric.Value;

            formAnimatorInput.Grow.StartPoint = new Point((int)grow_StartPoint_X_Numeric.Value, (int)grow_StartPoint_Y_Numeric.Value);
            formAnimatorInput.Grow.EndPoint = new Point((int)grow_EndPoint_X_Numeric.Value, (int)grow_EndPoint_Y_Numeric.Value);

            formAnimatorInput.Positions.Size = new Size((int)grow_Size_Height_Numeric.Value, (int)grow_Size_Width_Numeric.Value);


            if (grow_FixGrown_Yes.Checked)
            {

                formAnimatorInput.Grow.FixWindowWhenGrown = true;
            }
            else
            {
                formAnimatorInput.Grow.FixWindowWhenGrown = false;
            }

            if (grow_Recalculate_Yes.Checked)
            {

                formAnimatorInput.Grow.Recalculate = true;
            }
            else
            {
                formAnimatorInput.Grow.Recalculate = false;
            }
            
            #endregion

            #region Locations

            if (locations_TopLeft_Btn.FlatAppearance.BorderColor == Color.Yellow)
            {
                formAnimatorInput.Locations.FormLocations = FormLocations.TopLeft;
            }
            else if (locations_TopRight_Btn.FlatAppearance.BorderColor == Color.Yellow)
            {
                formAnimatorInput.Locations.FormLocations = FormLocations.TopRight;
            }
            else if (locations_BottomLeft_Btn.FlatAppearance.BorderColor == Color.Yellow)
            {
                formAnimatorInput.Locations.FormLocations = FormLocations.BottomLeft;
            }
            else if (locations_BottomRight_Btn.FlatAppearance.BorderColor == Color.Yellow)
            {
                formAnimatorInput.Locations.FormLocations = FormLocations.BottomRight;
            }
            else if (locations_TopCenter_Btn.FlatAppearance.BorderColor == Color.Yellow)
            {
                formAnimatorInput.Locations.FormLocations = FormLocations.TopCenter;
            }
            else if (locations_BottomCenter_Btn.FlatAppearance.BorderColor == Color.Yellow)
            {
                formAnimatorInput.Locations.FormLocations = FormLocations.BottomCenter;
            }
            else if (locations_BottomCenter_Btn.FlatAppearance.BorderColor == Color.Yellow)
            {
                formAnimatorInput.Locations.FormLocations = FormLocations.BottomCenter;
            }
            else if (locations_LeftCenter_Btn.FlatAppearance.BorderColor == Color.Yellow)
            {
                formAnimatorInput.Locations.FormLocations = FormLocations.LeftCenter;
            }
            else if (locations_RightCenter_Btn.FlatAppearance.BorderColor == Color.Yellow)
            {
                formAnimatorInput.Locations.FormLocations = FormLocations.RightCenter;
            }
            else if (
                locations_Random1_Btn.FlatAppearance.BorderColor == Color.Yellow ||
                locations_Random2_Btn.FlatAppearance.BorderColor == Color.Yellow ||
                locations_Random3_Btn.FlatAppearance.BorderColor == Color.Yellow ||
                locations_Random4_Btn.FlatAppearance.BorderColor == Color.Yellow)
            {
                formAnimatorInput.Locations.FormLocations = FormLocations.RandomPoint;
            }
            else if (locations_CenterScreen_Btn.FlatAppearance.BorderColor == Color.Yellow)
            {
                formAnimatorInput.Locations.FormLocations = FormLocations.CenterScreen;
            }

            #endregion

            #region Move

            formAnimatorInput.Move.StartPoint = new Point((int)move_StartPoint_X_Numeric.Value,(int)move_StartPoint_Y_Numeric.Value);            
            formAnimatorInput.Move.EndPoint = new Point((int)move_EndPoint_X_Numeric.Value,(int)move_EndPoint_Y_Numeric.Value);
            

            //Direct Trajectory
            if (move_DirectTrajectory_Yes.Checked)
            {
                
                formAnimatorInput.Move.DirectTrajectory = true;
            }
            else
            {
                formAnimatorInput.Move.DirectTrajectory = false;
            }

            //Move To Point
            if (move_MoveToPoint_Yes.Checked)
            {
                 
                formAnimatorInput.MoveToPoint = true;
            }
            else
            {
                formAnimatorInput.MoveToPoint = false;
            }

            formAnimatorInput.Move.RandomLocations.Clear();

            //Random Locations
            foreach (Point var in move_ListedPoints_ListBox.Items)
            {
                formAnimatorInput.Move.RandomLocations.Add(var);
                
            }

            #endregion

            #region Opacity

            formAnimatorInput.Opacity.Start = (double)opacityStart_Numeric.Value;
            formAnimatorInput.Opacity.Step = (double)opacityStep_Numeric.Value;


            #endregion
                        
        }

        #endregion

        #region OK, Cancel and Close
        private void closeBtn_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.Cancel;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            #region SetValues

            if (mainAnimation_ComboBox.SelectedIndex ==
                    (int)FormAnimationTypes.BottomToTop)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.BottomToTop, new Positions(), new ZeroitFormAnimator.Timer(), 0D);

                SetRetrievedValues(formAnimatorInput);
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.DeterminerPosition)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.DeterminerPosition, new Locations(), new ZeroitFormAnimator.Timer());

                SetRetrievedValues(formAnimatorInput);

            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.FadeIn)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.FadeIn, new Opacity(), new ZeroitFormAnimator.Timer());

                SetRetrievedValues(formAnimatorInput);
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.FadeOut)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.FadeOut, new Opacity(), new ZeroitFormAnimator.Timer(), "");

                SetRetrievedValues(formAnimatorInput);

            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.GrowHorizontal)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.GrowHorizontal, new Grow(), new ZeroitFormAnimator.Timer());

                SetRetrievedValues(formAnimatorInput);

            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.GrowVertical)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.GrowVertical, new Grow(), new ZeroitFormAnimator.Timer(), "");

                SetRetrievedValues(formAnimatorInput);
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.GrowXY)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.GrowXY, new Grow(), new ZeroitFormAnimator.Timer(), 0);

                SetRetrievedValues(formAnimatorInput);
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.GrowMoveXY)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.GrowMoveXY, new Grow(), new ZeroitFormAnimator.Timer(), false);

                SetRetrievedValues(formAnimatorInput);
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.HideControls)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.HideControls, new ZeroitFormAnimator.Timer());

                SetRetrievedValues(formAnimatorInput);
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.LeftToRight)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.LeftToRight, new Positions(), new ZeroitFormAnimator.Timer());

                SetRetrievedValues(formAnimatorInput);
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.LeftToRightVertical)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.LeftToRightVertical, new ZeroitFormAnimator.Timer(), 0);

                SetRetrievedValues(formAnimatorInput);
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.Move)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.Move, new Move(), new ZeroitFormAnimator.Timer());

                SetRetrievedValues(formAnimatorInput);
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.RightToLeft)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.RightToLeft, new Positions(), new ZeroitFormAnimator.Timer(), "");

                SetRetrievedValues(formAnimatorInput);
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.Shake)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.Move, new Shake(), new ZeroitFormAnimator.Timer());

                SetRetrievedValues(formAnimatorInput);
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.ShowControls)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.ShowControls, new ZeroitFormAnimator.Timer(), "");

                SetRetrievedValues(formAnimatorInput);
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.ShrinkFadeOut)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.ShrinkFadeOut, new ZeroitFormAnimator.Timer(), false);

                SetRetrievedValues(formAnimatorInput);
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.ShrinkHorizontal)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.ShrinkHorizontal, new Positions(), new ZeroitFormAnimator.Timer(), 0f);

                SetRetrievedValues(formAnimatorInput);
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.ShrinkMoveXY)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.ShrinkMoveXY, new Positions(), new ZeroitFormAnimator.Timer(), false);

                SetRetrievedValues(formAnimatorInput);
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.ShrinkVertical)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.ShrinkVertical, new Positions(), new ZeroitFormAnimator.Timer(), 0L);

                SetRetrievedValues(formAnimatorInput);
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.ShrinkXY)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.ShrinkXY, new Positions(), new ZeroitFormAnimator.Timer(), (short)0);

                SetRetrievedValues(formAnimatorInput);
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.TopToBottom)
            {
                formAnimatorInput = new FormAnimatorInput(FormAnimationTypes.TopToBottom, new Positions(), new ZeroitFormAnimator.Timer(), 0);

                SetRetrievedValues(formAnimatorInput);
            }

            #endregion

            DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #endregion

        #region GroupBoxes Visibility Changed

        Point visibleLocation = new Point(269, 65);

        private void positionsGroupBox_VisibleChanged(object sender, EventArgs e)
        {
            if (positionsGroupBox.Visible)
            {
                positionsGroupBox.Location = visibleLocation;
            }
            else
            {
                positionsGroupBox.Location = new Point(345, 210);
            }
        }

        private void shakeGroupBox_VisibleChanged(object sender, EventArgs e)
        {
            if (shakeGroupBox.Visible)
            {
                shakeGroupBox.Location = visibleLocation;
            }
            else
            {
                shakeGroupBox.Location = new Point(688, 44);
            }
        }

        private void growGroupBox_VisibleChanged(object sender, EventArgs e)
        {
            if (growGroupBox.Visible)
            {
                growGroupBox.Location = visibleLocation;
            }
            else
            {
                growGroupBox.Location = new Point(381, 320);
            }
        }

        private void locationsGroupBox_VisibleChanged(object sender, EventArgs e)
        {
            if (locationsGroupBox.Visible)
            {
                locationsGroupBox.Location = visibleLocation;
            }
            else
            {
                locationsGroupBox.Location = new Point(21, 521);
            }
        }

        private void moveGroupBox_VisibleChanged(object sender, EventArgs e)
        {
            if (moveGroupBox.Visible)
            {
                moveGroupBox.Location = visibleLocation;
            }
            else
            {
                moveGroupBox.Location = new Point(324, 521);
            }
        }

        private void opacityGroupBox_VisibleChanged(object sender, EventArgs e)
        {
            if (opacityGroupBox.Visible)
            {
                opacityGroupBox.Location = visibleLocation;
            }
            else
            {
                opacityGroupBox.Location = new Point(682, 521);
            }
        }
        
        #endregion

        #region Animation Selected
        private void mainAnimation_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Show Group Box

            if (mainAnimation_ComboBox.SelectedIndex ==
                    (int)FormAnimationTypes.BottomToTop)
            {
                positionsGroupBox.Visible = true;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                positions_Start_Numeric.Enabled = true;
                positions_End_Numeric.Enabled = true;
                positions_ShrinkToCenter_Yes.Enabled = false;
                positions_ShrinkToCenter_No.Enabled = false;
                positions_StartPoint_X_Numeric.Enabled = false;
                positions_StartPoint_Y_Numeric.Enabled = false;
                positions_EndPoint_X_Numeric.Enabled = false;
                positions_EndPoint_Y_Numeric.Enabled = false;
                positions_Size_Height_Numeric.Enabled = false;
                positions_Size_Width_Numeric.Enabled = false;

            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.DeterminerPosition)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = true;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.FadeIn)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = true;
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.FadeOut)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = true;
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.GrowHorizontal)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = true;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                grow_Start_Numeric.Enabled = true;
                grow_End_Numeric.Enabled = true;
                grow_FixGrown_Yes.Enabled = true;
                grow_FixGrown_No.Enabled = true;
                grow_StartPoint_X_Numeric.Enabled = false;
                grow_StartPoint_Y_Numeric.Enabled = false;
                grow_EndPoint_X_Numeric.Enabled = false;
                grow_EndPoint_Y_Numeric.Enabled = false;
                grow_Size_Height_Numeric.Enabled = false;
                grow_Size_Width_Numeric.Enabled = false;

            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.GrowVertical)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = true;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                grow_Start_Numeric.Enabled = true;
                grow_End_Numeric.Enabled = true;
                grow_FixGrown_Yes.Enabled = true;
                grow_FixGrown_No.Enabled = true;
                grow_StartPoint_X_Numeric.Enabled = false;
                grow_StartPoint_Y_Numeric.Enabled = false;
                grow_EndPoint_X_Numeric.Enabled = false;
                grow_EndPoint_Y_Numeric.Enabled = false;
                grow_Size_Height_Numeric.Enabled = false;
                grow_Size_Width_Numeric.Enabled = false;
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.GrowXY)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = true;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                grow_Start_Numeric.Enabled = false;
                grow_End_Numeric.Enabled = false;
                grow_FixGrown_Yes.Enabled = true;
                grow_FixGrown_No.Enabled = true;
                grow_StartPoint_X_Numeric.Enabled = true;
                grow_StartPoint_Y_Numeric.Enabled = true;
                grow_EndPoint_X_Numeric.Enabled = true;
                grow_EndPoint_Y_Numeric.Enabled = true;
                grow_Size_Height_Numeric.Enabled = false;
                grow_Size_Width_Numeric.Enabled = false;
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.GrowMoveXY)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = true;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                grow_Start_Numeric.Enabled = false;
                grow_End_Numeric.Enabled = false;
                grow_FixGrown_Yes.Enabled = true;
                grow_FixGrown_No.Enabled = true;
                grow_StartPoint_X_Numeric.Enabled = true;
                grow_StartPoint_Y_Numeric.Enabled = true;
                grow_EndPoint_X_Numeric.Enabled = true;
                grow_EndPoint_Y_Numeric.Enabled = true;
                grow_Size_Height_Numeric.Enabled = true;
                grow_Size_Width_Numeric.Enabled = true;
                grow_Recalculate_Yes.Enabled = true;
                grow_Recalculate_No.Enabled = true;
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.HideControls)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.LeftToRight)
            {
                positionsGroupBox.Visible = true;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                positions_Start_Numeric.Enabled = true;
                positions_End_Numeric.Enabled = true;
                positions_ShrinkToCenter_Yes.Enabled = false;
                positions_ShrinkToCenter_No.Enabled = false;
                positions_StartPoint_X_Numeric.Enabled = false;
                positions_StartPoint_Y_Numeric.Enabled = false;
                positions_EndPoint_X_Numeric.Enabled = false;
                positions_EndPoint_Y_Numeric.Enabled = false;
                positions_Size_Height_Numeric.Enabled = false;
                positions_Size_Width_Numeric.Enabled = false;
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.LeftToRightVertical)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;
            }
            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.Move)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = true;
                opacityGroupBox.Visible = false;



                move_StartPoint_X_Numeric.Enabled = true;
                move_StartPoint_Y_Numeric.Enabled = true;
                move_EndPoint_X_Numeric.Enabled = true;
                move_EndPoint_Y_Numeric.Enabled = true;                
                move_DirectTrajectory_Yes.Enabled = true;
                move_DirectTrajectory_No.Enabled = true;
                move_MoveToPoint_Yes.Enabled = true;
                move_MoveToPoint_No.Enabled = true;

                if(move_MoveToPoint_Yes.Checked)
                {
                    move_RandPoint_X_Numeric.Enabled = true;
                    move_RandPoint_Y_Numeric.Enabled = true;
                    move_Add_Point_Btn.Enabled = true;
                    move_ListedPoints_ListBox.Enabled = true;
                }
                else
                {
                    move_RandPoint_X_Numeric.Enabled = false;
                    move_RandPoint_Y_Numeric.Enabled = false;
                    move_Add_Point_Btn.Enabled = false;
                    move_ListedPoints_ListBox.Enabled = false;
                }
                
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.RightToLeft)
            {
                positionsGroupBox.Visible = true;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                positions_Start_Numeric.Enabled = true;
                positions_End_Numeric.Enabled = true;
                positions_ShrinkToCenter_Yes.Enabled = false;
                positions_ShrinkToCenter_No.Enabled = false;
                positions_StartPoint_X_Numeric.Enabled = false;
                positions_StartPoint_Y_Numeric.Enabled = false;
                positions_EndPoint_X_Numeric.Enabled = false;
                positions_EndPoint_Y_Numeric.Enabled = false;
                positions_Size_Height_Numeric.Enabled = false;
                positions_Size_Width_Numeric.Enabled = false;
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.Shake)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = true;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.ShowControls)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.ShrinkFadeOut)
            {
                positionsGroupBox.Visible = false;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.ShrinkHorizontal)
            {
                positionsGroupBox.Visible = true;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                positions_Start_Numeric.Enabled = true;
                positions_End_Numeric.Enabled = true;
                positions_ShrinkToCenter_Yes.Enabled = false;
                positions_ShrinkToCenter_No.Enabled = false;
                positions_StartPoint_X_Numeric.Enabled = false;
                positions_StartPoint_Y_Numeric.Enabled = false;
                positions_EndPoint_X_Numeric.Enabled = false;
                positions_EndPoint_Y_Numeric.Enabled = false;
                positions_Size_Height_Numeric.Enabled = false;
                positions_Size_Width_Numeric.Enabled = false;
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.ShrinkMoveXY)
            {
                positionsGroupBox.Visible = true;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                positions_Start_Numeric.Enabled = false;
                positions_End_Numeric.Enabled = false;
                positions_ShrinkToCenter_Yes.Enabled = true;
                positions_ShrinkToCenter_No.Enabled = true;
                positions_StartPoint_X_Numeric.Enabled = true;
                positions_StartPoint_Y_Numeric.Enabled = true;
                positions_EndPoint_X_Numeric.Enabled = true;
                positions_EndPoint_Y_Numeric.Enabled = true;
                positions_Size_Height_Numeric.Enabled = true;
                positions_Size_Width_Numeric.Enabled = true;
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.ShrinkVertical)
            {
                positionsGroupBox.Visible = true;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                positions_Start_Numeric.Enabled = true;
                positions_End_Numeric.Enabled = true;
                positions_ShrinkToCenter_Yes.Enabled = false;
                positions_ShrinkToCenter_No.Enabled = false;
                positions_StartPoint_X_Numeric.Enabled = false;
                positions_StartPoint_Y_Numeric.Enabled = false;
                positions_EndPoint_X_Numeric.Enabled = false;
                positions_EndPoint_Y_Numeric.Enabled = false;
                positions_Size_Height_Numeric.Enabled = false;
                positions_Size_Width_Numeric.Enabled = false;
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.ShrinkXY)
            {
                positionsGroupBox.Visible = true;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                positions_Start_Numeric.Enabled = false;
                positions_End_Numeric.Enabled = false;
                positions_ShrinkToCenter_Yes.Enabled = false;
                positions_ShrinkToCenter_No.Enabled = false;
                positions_StartPoint_X_Numeric.Enabled = true;
                positions_StartPoint_Y_Numeric.Enabled = true;
                positions_EndPoint_X_Numeric.Enabled = true;
                positions_EndPoint_Y_Numeric.Enabled = true;
                positions_Size_Height_Numeric.Enabled = false;
                positions_Size_Width_Numeric.Enabled = false;
            }

            else if (mainAnimation_ComboBox.SelectedIndex ==
                (int)FormAnimationTypes.TopToBottom)
            {
                positionsGroupBox.Visible = true;
                shakeGroupBox.Visible = false;
                growGroupBox.Visible = false;
                locationsGroupBox.Visible = false;
                moveGroupBox.Visible = false;
                opacityGroupBox.Visible = false;

                positions_Start_Numeric.Enabled = true;
                positions_End_Numeric.Enabled = true;
                positions_ShrinkToCenter_Yes.Enabled = false;
                positions_ShrinkToCenter_No.Enabled = false;
                positions_StartPoint_X_Numeric.Enabled = false;
                positions_StartPoint_Y_Numeric.Enabled = false;
                positions_EndPoint_X_Numeric.Enabled = false;
                positions_EndPoint_Y_Numeric.Enabled = false;
                positions_Size_Height_Numeric.Enabled = false;
                positions_Size_Width_Numeric.Enabled = false;
            }

            else
            {

            }
            #endregion

            #region Preview

            previewForm.animator.Animation = 
                (FormAnimationTypes)Enum.Parse(
                    typeof(FormAnimationTypes),
                    mainAnimation_ComboBox.SelectedItem.ToString());

            #endregion
        } 
        #endregion

        #region Locations Clicked
        private void locations_TopLeft_Btn_Click(object sender, EventArgs e)
        {
            locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random1_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random2_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random3_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random4_Btn.FlatAppearance.BorderColor = Color.Cyan;

            #region Preview
            previewForm.animator.Locations.FormLocations = FormLocations.TopLeft;
            #endregion

        }

        private void locations_TopCenter_Btn_Click(object sender, EventArgs e)
        {
            locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random1_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random2_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random3_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random4_Btn.FlatAppearance.BorderColor = Color.Cyan;

            #region Preview
            previewForm.animator.Locations.FormLocations = FormLocations.TopCenter;
            #endregion
        }

        private void locations_TopRight_Btn_Click(object sender, EventArgs e)
        {
            locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random1_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random2_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random3_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random4_Btn.FlatAppearance.BorderColor = Color.Cyan;

            #region Preview
            previewForm.animator.Locations.FormLocations = FormLocations.TopRight;
            #endregion

        }

        private void locations_BottomLeft_Btn_Click(object sender, EventArgs e)
        {
            locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random1_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random2_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random3_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random4_Btn.FlatAppearance.BorderColor = Color.Cyan;

            #region Preview
            previewForm.animator.Locations.FormLocations = FormLocations.BottomLeft;
            #endregion

        }

        private void locations_BottomCenter_Btn_Click(object sender, EventArgs e)
        {
            locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random1_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random2_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random3_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random4_Btn.FlatAppearance.BorderColor = Color.Cyan;

            #region Preview
            previewForm.animator.Locations.FormLocations = FormLocations.BottomCenter;
            #endregion
        }

        private void locations_BottomRight_Btn_Click(object sender, EventArgs e)
        {
            locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random1_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random2_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random3_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random4_Btn.FlatAppearance.BorderColor = Color.Cyan;

            #region Preview
            previewForm.animator.Locations.FormLocations = FormLocations.BottomRight;
            #endregion

        }

        private void locations_LeftCenter_Btn_Click(object sender, EventArgs e)
        {
            locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random1_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random2_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random3_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random4_Btn.FlatAppearance.BorderColor = Color.Cyan;

            #region Preview
            previewForm.animator.Locations.FormLocations = FormLocations.LeftCenter;
            #endregion

        }

        private void locations_RightCenter_Btn_Click(object sender, EventArgs e)
        {
            locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random1_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random2_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random3_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random4_Btn.FlatAppearance.BorderColor = Color.Cyan;

            #region Preview
            previewForm.animator.Locations.FormLocations = FormLocations.RightCenter;
            #endregion
        }

        private void locations_CenterScreen_Btn_Click(object sender, EventArgs e)
        {
            locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_Random1_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random2_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random3_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random4_Btn.FlatAppearance.BorderColor = Color.Cyan;

            #region Preview
            previewForm.animator.Locations.FormLocations = FormLocations.CenterScreen;
            #endregion
        }

        private void locations_Random1_Btn_Click(object sender, EventArgs e)
        {
            locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random1_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_Random2_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_Random3_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_Random4_Btn.FlatAppearance.BorderColor = Color.Yellow;

            #region Preview
            previewForm.animator.Locations.FormLocations = FormLocations.RandomPoint;
            #endregion
        }

        private void locations_Random2_Btn_Click(object sender, EventArgs e)
        {
            locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random1_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_Random2_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_Random3_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_Random4_Btn.FlatAppearance.BorderColor = Color.Yellow;

            #region Preview
            previewForm.animator.Locations.FormLocations = FormLocations.RandomPoint;
            #endregion
        }

        private void locations_Random3_Btn_Click(object sender, EventArgs e)
        {
            locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random1_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_Random2_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_Random3_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_Random4_Btn.FlatAppearance.BorderColor = Color.Yellow;

            #region Preview
            previewForm.animator.Locations.FormLocations = FormLocations.RandomPoint;
            #endregion
        }

        private void locations_Random4_Btn_Click(object sender, EventArgs e)
        {
            locations_TopLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_TopRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomLeft_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_BottomRight_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_LeftCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_RightCenter_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_CenterScreen_Btn.FlatAppearance.BorderColor = Color.Cyan;
            locations_Random1_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_Random2_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_Random3_Btn.FlatAppearance.BorderColor = Color.Yellow;
            locations_Random4_Btn.FlatAppearance.BorderColor = Color.Yellow;

            #region Preview
            previewForm.animator.Locations.FormLocations = FormLocations.RandomPoint;
            #endregion

        }
        
        #endregion

        #region Preview 

        private void preview_Btn_Click(object sender, EventArgs e)
        {
            previewForm.animator.Move.RandomLocations.Clear();

            foreach(Point var in move_ListedPoints_ListBox.Items)
            {
                previewForm.animator.Move.RandomLocations.Add(var);
            }

            CenterForm(previewForm);

            if (previewForm.ShowDialog() == DialogResult.OK)
            {

            }
        }
        
        #region Main Changes

        private void mainTime_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Time.Time = (int)mainTime_Numeric.Value;
        }

        private void mainStep_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Time.StepX = (int)mainStep_X_Numeric.Value;
        }

        private void mainStep_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Time.StepY = (int)mainStep_Y_Numeric.Value;
        }
        #endregion

        #region Positions Changes
        private void positions_Start_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Positions.Start = (int)positions_Start_Numeric.Value;
        }

        private void positions_End_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Positions.End = (int)positions_End_Numeric.Value;
        }

        private void positions_StartPoint_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Positions.StartPoint = new Point((int)positions_StartPoint_X_Numeric.Value, (int)positions_StartPoint_Y_Numeric.Value);
        }

        private void positions_StartPoint_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Positions.StartPoint = new Point((int)positions_StartPoint_X_Numeric.Value, (int)positions_StartPoint_Y_Numeric.Value);
        }

        private void positions_EndPoint_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Positions.EndPoint = new Point((int)positions_EndPoint_X_Numeric.Value, (int)positions_EndPoint_Y_Numeric.Value);

        }

        private void positions_EndPoint_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Positions.EndPoint = new Point((int)positions_EndPoint_X_Numeric.Value, (int)positions_EndPoint_Y_Numeric.Value);

        }

        private void positions_Size_Height_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Positions.Size = new Size((int)positions_Size_Width_Numeric.Value, (int)positions_Size_Height_Numeric.Value);

        }

        private void positions_Size_Width_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Positions.Size = new Size((int)positions_Size_Width_Numeric.Value, (int)positions_Size_Height_Numeric.Value);

        }

        private void positions_ShrinkToCenter_Yes_CheckedChanged(object sender, EventArgs e)
        {
            previewForm.animator.Positions.ShrinkToCenter = positions_ShrinkToCenter_Yes.Checked;
        }
        #endregion

        #region Shake
        private void shakeType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            previewForm.animator.Shake.ShakeType =
                (ShakeType)Enum.Parse(
                    typeof(ShakeType),
                    shakeType_ComboBox.SelectedItem.ToString());
        }

        private void shakeSpeed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Shake.ShakeSpeed = (int)shakeSpeed_Numeric.Value;
        }

        private void shakeDistance_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Shake.ShakeDistance = (int)shakeDistance_Numeric.Value;
        }
        #endregion
        
        #region Grow Changes
        private void grow_Start_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Grow.Start = (int)grow_Start_Numeric.Value;
        }

        private void grow_End_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Grow.End = (int)grow_End_Numeric.Value;
        }

        private void grow_StartPoint_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Grow.StartPoint = new Point((int)grow_StartPoint_X_Numeric.Value, (int)grow_StartPoint_Y_Numeric.Value);
        }

        private void grow_StartPoint_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Grow.StartPoint = new Point((int)grow_StartPoint_X_Numeric.Value, (int)grow_StartPoint_Y_Numeric.Value);
        }

        private void grow_EndPoint_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Grow.EndPoint = new Point((int)grow_EndPoint_X_Numeric.Value, (int)grow_EndPoint_Y_Numeric.Value);
        }

        private void grow_EndPoint_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Grow.EndPoint = new Point((int)grow_EndPoint_X_Numeric.Value, (int)grow_EndPoint_Y_Numeric.Value);
        }

        private void grow_Size_Height_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Grow.Size = new Size((int)grow_Size_Width_Numeric.Value, (int)grow_Size_Height_Numeric.Value);
        }

        private void grow_Size_Width_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Grow.Size = new Size((int)grow_Size_Width_Numeric.Value, (int)grow_Size_Height_Numeric.Value);
        }

        private void grow_FixGrown_Yes_CheckedChanged(object sender, EventArgs e)
        {
            previewForm.animator.Grow.FixWindowWhenGrown = grow_FixGrown_Yes.Checked;
        }

        private void grow_Recalculate_Yes_CheckedChanged(object sender, EventArgs e)
        {
            previewForm.animator.Grow.Recalculate = grow_Recalculate_Yes.Checked;
        }
        #endregion

        #region Move Changes
        private void move_StartPoint_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Move.StartPoint = new Point((int)move_StartPoint_X_Numeric.Value, (int)move_StartPoint_Y_Numeric.Value);
        }

        private void move_StartPoint_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Move.StartPoint = new Point((int)move_StartPoint_X_Numeric.Value, (int)move_StartPoint_Y_Numeric.Value);
        }

        private void move_EndPoint_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Move.EndPoint = new Point((int)move_EndPoint_X_Numeric.Value, (int)move_EndPoint_Y_Numeric.Value);
        }

        private void move_EndPoint_Y_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Move.EndPoint = new Point((int)move_EndPoint_X_Numeric.Value, (int)move_EndPoint_Y_Numeric.Value);
        }

        private void move_RandPoint_X_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Move.EndPoint = new Point((int)move_EndPoint_X_Numeric.Value, (int)move_EndPoint_Y_Numeric.Value);
        }

        private void move_Add_Point_Btn_Click(object sender, EventArgs e)
        {
            move_ListedPoints_ListBox.Items.Add(new Point((int)move_RandPoint_X_Numeric.Value, (int)move_RandPoint_Y_Numeric.Value));
        }

        private void move_DirectTrajectory_Yes_CheckedChanged(object sender, EventArgs e)
        {
            previewForm.animator.Move.DirectTrajectory = move_DirectTrajectory_Yes.Checked;
        }

        private void move_MoveToPoint_Yes_CheckedChanged(object sender, EventArgs e)
        {
            if (move_MoveToPoint_Yes.Checked)
            {
                move_RandPoint_X_Numeric.Enabled = true;
                move_RandPoint_Y_Numeric.Enabled = true;
                move_Add_Point_Btn.Enabled = true;
                move_ListedPoints_ListBox.Enabled = true;
            }
            else
            {
                move_RandPoint_X_Numeric.Enabled = false;
                move_RandPoint_Y_Numeric.Enabled = false;
                move_Add_Point_Btn.Enabled = false;
                move_ListedPoints_ListBox.Enabled = false;
            }

            previewForm.animator.MoveToPoint = move_MoveToPoint_Yes.Checked;

        }
        #endregion

        #region Opacity
        private void opacityStart_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Opacity.Start = (double)opacityStart_Numeric.Value;
        }

        private void opacityStep_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewForm.animator.Opacity.Step = (double)opacityStep_Numeric.Value;
        }
        #endregion

        private void PreviewForm_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                previewForm.Reset = true;

                if (previewForm.Reset)
                {
                    CenterForm(previewForm);
                    previewForm.startReset.Text = "Start";
                }
                else
                {
                    previewForm.startReset.Text = "Reset";
                }
            }

        }

        private void StartReset_Click(object sender, EventArgs e)
        {
            previewForm.animator.Start(previewForm);

            #region Old Code

            //if (previewForm.automaticReset_CheckBox.Checked)
            //{
            //    previewForm.Reset = !previewForm.Reset;

            //    if (!previewForm.Reset)
            //    {
            //        previewForm.startReset.Text = "Reset";
            //    }
            //    else
            //    {
            //        previewForm.Size = new Size(524, 251);
            //        previewForm.startReset.Text = "Start";                    
            //        CenterForm(previewForm);

            //    }
            //}

            #endregion

            previewForm.Reset = !previewForm.Reset;

            if (!previewForm.Reset)
            {
                previewForm.startReset.Text = "Reset";
            }
            else
            {
                previewForm.Size = new Size(524, 251);
                previewForm.startReset.Text = "Start";
                CenterForm(previewForm);

            }
        }

        #endregion

        #region Private Methods

        private void CenterForm(Form form)
        {
            form.Location = new Point(this.Location.X + (form.Width / 10), this.Location.Y + (form.Height / 5));

        }

        private void CenterScreen(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - (form.Width / 2), (Screen.PrimaryScreen.Bounds.Height / 2) - (form.Height / 2));

        }




        #endregion

        private void FormAnimatorDialog_Move(object sender, EventArgs e)
        {
            location_Label.Text = string.Format("Location  ( X : {0} Y : {1} )", Location.X, Location.Y);

            size_Label.Text = string.Format("Size  ( Width : {0} , Height : {1} )", Size.Width, Size.Height);

        }

    }
}
