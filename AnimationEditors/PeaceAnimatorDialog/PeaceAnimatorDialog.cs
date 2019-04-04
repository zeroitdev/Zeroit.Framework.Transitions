// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="PeaceAnimatorDialog.cs" company="Zeroit Dev Technologies">
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
using System.Threading;
using System.Windows.Forms;
using Zeroit.Framework.Transitions.WinformAnimation;
using Zeroit.Framework.Transitions.WinFormAnimation;

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    /// Class ZeroitPeaceAnimatorDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ZeroitPeaceAnimatorDialog : System.Windows.Forms.Form
    {

        #region Private Fields

        #region Constants
        /// <summary>
        /// The no
        /// </summary>
        private const int No = 0;
        /// <summary>
        /// The yes
        /// </summary>
        private const int Yes = 1;

        /// <summary>
        /// The one d
        /// </summary>
        private const int OneD = 0;
        /// <summary>
        /// The two d
        /// </summary>
        private const int TwoD = 1;
        /// <summary>
        /// The three d
        /// </summary>
        private const int ThreeD = 2;
        /// <summary>
        /// The default
        /// </summary>
        private const int Default = 3;

        /// <summary>
        /// The bounce ease in
        /// </summary>
        private const int BounceEaseIn = 0;
        /// <summary>
        /// The bounce ease in out
        /// </summary>
        private const int BounceEaseInOut = 1;
        /// <summary>
        /// The bounce ease out
        /// </summary>
        private const int BounceEaseOut = 2;
        /// <summary>
        /// The bounce ease out in
        /// </summary>
        private const int BounceEaseOutIn = 3;
        /// <summary>
        /// The circular ease in
        /// </summary>
        private const int CircularEaseIn = 4;
        /// <summary>
        /// The circular ease in out
        /// </summary>
        private const int CircularEaseInOut = 4;
        /// <summary>
        /// The circular ease out
        /// </summary>
        private const int CircularEaseOut = 5;
        /// <summary>
        /// The cubic ease in
        /// </summary>
        private const int CubicEaseIn = 6;
        /// <summary>
        /// The cubic ease in out
        /// </summary>
        private const int CubicEaseInOut = 7;
        /// <summary>
        /// The cubic ease out
        /// </summary>
        private const int CubicEaseOut = 8;
        /// <summary>
        /// The exponential ease in
        /// </summary>
        private const int ExponentialEaseIn = 9;
        /// <summary>
        /// The exponential ease in out
        /// </summary>
        private const int ExponentialEaseInOut = 10;
        /// <summary>
        /// The exponential ease out
        /// </summary>
        private const int ExponentialEaseOut = 11;
        /// <summary>
        /// The liner
        /// </summary>
        private const int Liner = 12;
        /// <summary>
        /// The none
        /// </summary>
        private const int None = 13;
        /// <summary>
        /// The quadratic ease in
        /// </summary>
        private const int QuadraticEaseIn = 14;
        /// <summary>
        /// The quadratic ease in out
        /// </summary>
        private const int QuadraticEaseInOut = 15;
        /// <summary>
        /// The quadratic ease out
        /// </summary>
        private const int QuadraticEaseOut = 16;
        /// <summary>
        /// The quartic ease in
        /// </summary>
        private const int QuarticEaseIn = 17;
        /// <summary>
        /// The quartic ease in out
        /// </summary>
        private const int QuarticEaseInOut = 18;
        /// <summary>
        /// The quartic ease out
        /// </summary>
        private const int QuarticEaseOut = 19;
        /// <summary>
        /// The quintic ease in
        /// </summary>
        private const int QuinticEaseIn = 20;
        /// <summary>
        /// The quintic ease in out
        /// </summary>
        private const int QuinticEaseInOut = 21;
        /// <summary>
        /// The quintic ease out
        /// </summary>
        private const int QuinticEaseOut = 22;
        /// <summary>
        /// The sinusoidal ease in
        /// </summary>
        private const int SinusoidalEaseIn = 23;
        /// <summary>
        /// The sinusoidal ease in out
        /// </summary>
        private const int SinusoidalEaseInOut = 24;
        /// <summary>
        /// The sinusoidal ease out
        /// </summary>
        private const int SinusoidalEaseOut = 25;

        /// <summary>
        /// The one d property custom
        /// </summary>
        private const int OneD_Property_Custom = 0;
        /// <summary>
        /// The one d property height
        /// </summary>
        private const int OneD_Property_Height = 1;
        /// <summary>
        /// The one d property opacity
        /// </summary>
        private const int OneD_Property_Opacity = 2;
        /// <summary>
        /// The one d property value
        /// </summary>
        private const int OneD_Property_Value = 3;
        /// <summary>
        /// The one d property width
        /// </summary>
        private const int OneD_Property_Width = 4;

        /// <summary>
        /// The two d property location
        /// </summary>
        private const int TwoD_Property_Location = 0;
        /// <summary>
        /// The two d property size
        /// </summary>
        private const int TwoD_Property_Size = 1;

        /// <summary>
        /// The three d property back color
        /// </summary>
        private const int ThreeD_Property_BackColor = 0;
        /// <summary>
        /// The three d property custom
        /// </summary>
        private const int ThreeD_Property_Custom = 1;
        /// <summary>
        /// The three d property fore color
        /// </summary>
        private const int ThreeD_Property_ForeColor = 2;
        #endregion

        #region Private Fields

        /// <summary>
        /// The animation mode
        /// </summary>
        private animationMode animationMode = animationMode.OneD;

        //------------------1D Retrieval Values-------------//
        /// <summary>
        /// The alpha
        /// </summary>
        private int alpha = 10;
        /// <summary>
        /// The repeat
        /// </summary>
        private bool repeat = false;
        /// <summary>
        /// The reverse
        /// </summary>
        private bool reverse = false;
        /// <summary>
        /// The path1 start
        /// </summary>
        private float path1_start = 0;
        /// <summary>
        /// The path1 end
        /// </summary>
        private float path1_end = 100;
        /// <summary>
        /// The path1 duration
        /// </summary>
        private ulong path1_duration = 5000;
        /// <summary>
        /// The path1 delay
        /// </summary>
        private ulong path1_delay = 0;
        /// <summary>
        /// The property name
        /// </summary>
        private string propertyName = "Value";
        /// <summary>
        /// The one d property
        /// </summary>
        private Animator.KnownProperties oneDProperty = Animator.KnownProperties.Value;
        /// <summary>
        /// The one d path easing function
        /// </summary>
        private KnownAnimationFunctions oneD_path_easingFunction = KnownAnimationFunctions.CircularEaseIn;
        /// <summary>
        /// The one d continue
        /// </summary>
        private bool oneDContinue = true;
        //------------------1D Retrieval Values-------------//



        //------------------2D Retrieval Values-------------//
        /// <summary>
        /// The path2 d start 1
        /// </summary>
        private float path2D_start_1 = 70;
        /// <summary>
        /// The path2 d end 1
        /// </summary>
        private float path2D_end_1 = 320;
        /// <summary>
        /// The path2 d duration 1
        /// </summary>
        private ulong path2D_duration_1 = 2000;
        /// <summary>
        /// The path2 d delay 1
        /// </summary>
        private ulong path2D_delay_1 = 0;
        /// <summary>
        /// The path2 d start 2
        /// </summary>
        private float path2D_start_2 = 5;
        /// <summary>
        /// The path2 d end 2
        /// </summary>
        private float path2D_end_2 = 100;
        /// <summary>
        /// The path2 d duration 2
        /// </summary>
        private ulong path2D_duration_2 = 2000;
        /// <summary>
        /// The path2 d delay 2
        /// </summary>
        private ulong path2D_delay_2 = 0;
        /// <summary>
        /// The continued path2 d start 1
        /// </summary>
        private float continued_path2D_start_1 = 320;
        /// <summary>
        /// The continued path2 d end 1
        /// </summary>
        private float continued_path2D_end_1 = 70;
        /// <summary>
        /// The continued path2 d duration 1
        /// </summary>
        private ulong continued_path2D_duration_1 = 2000;
        /// <summary>
        /// The continued path2 d delay 1
        /// </summary>
        private ulong continued_path2D_delay_1 = 300;
        /// <summary>
        /// The continued path2 d start 2
        /// </summary>
        private float continued_path2D_start_2 = 100;
        /// <summary>
        /// The continued path2 d end 2
        /// </summary>
        private float continued_path2D_end_2 = 5;
        /// <summary>
        /// The continued path2 d duration 2
        /// </summary>
        private ulong continued_path2D_duration_2 = 1700;
        /// <summary>
        /// The continued path2 d delay 2
        /// </summary>
        private ulong continued_path2D_delay_2 = 600;
        /// <summary>
        /// The two d property
        /// </summary>
        private Animator2D.KnownProperties twoDProperty = Animator2D.KnownProperties.Location;
        /// <summary>
        /// The path easing function
        /// </summary>
        private KnownAnimationFunctions path_easingFunction = KnownAnimationFunctions.CircularEaseIn;
        /// <summary>
        /// The continued path easing function
        /// </summary>
        private KnownAnimationFunctions continued_path_easingFunction = KnownAnimationFunctions.ExponentialEaseInOut;
        /// <summary>
        /// The two d continue
        /// </summary>
        private bool twoDContinue = true;
        //------------------2D Retrieval Values-------------//


        //------------------3D Retrieval Values-------------//

        /// <summary>
        /// The path3 d start 1
        /// </summary>
        private float path3D_start_1 = 70;
        /// <summary>
        /// The path3 d end 1
        /// </summary>
        private float path3D_end_1 = 320;
        /// <summary>
        /// The path3 duration
        /// </summary>
        private ulong path3_duration = 3000;
        /// <summary>
        /// The path3 delay
        /// </summary>
        private ulong path3_delay = 0;
        /// <summary>
        /// The start color
        /// </summary>
        private Color startColor = Color.DarkSlateGray;
        /// <summary>
        /// The end color
        /// </summary>
        private Color endColor = Color.Orange;
        /// <summary>
        /// The three d property
        /// </summary>
        private Animator3D.KnownProperties threeDProperty = Animator3D.KnownProperties.BackColor;
        /// <summary>
        /// The three d path easing function
        /// </summary>
        private KnownAnimationFunctions threeD_path_easingFunction = KnownAnimationFunctions.CircularEaseIn;
        /// <summary>
        /// The three d continue
        /// </summary>
        private bool threeDContinue = true;
        /// <summary>
        /// The color property name
        /// </summary>
        private string colorPropertyName = "BackColor";

        //------------------3D Retrieval Values-------------//


        /// <summary>
        /// The one d preview start animation
        /// </summary>
        bool oneD_Preview_startAnimation = false;
        /// <summary>
        /// The two d preview start animation
        /// </summary>
        bool twoD_Preview_startAnimation = false;

        #endregion


        #endregion

        #region Public Properties

        /// <summary>
        /// The peace input
        /// </summary>
        private PeaceInput peaceInput;

        /// <summary>
        /// Gets the peace input.
        /// </summary>
        /// <value>The peace input.</value>
        public PeaceInput PeaceInput
        {
            get { return peaceInput; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// at the default window position.
        /// </summary>
        public ZeroitPeaceAnimatorDialog() : this(PeaceInput.Empty())
        {
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// at the default window position.
        /// </summary>
        /// <param name="peaceInput">Existing <c>Filler</c> object.</param>
        /// <exception cref="ArgumentNullException">peaceInput</exception>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="peaceInput" /> is null.</exception>
        public ZeroitPeaceAnimatorDialog(PeaceInput peaceInput)
        {
            if (peaceInput == null)
            {
                throw new ArgumentNullException("peaceInput");
            }


            InitializeComponent();
            //FillGradientComboBox();
            AdjustDialogSize();
            SetInitial_Values(peaceInput);
            SetControl_OneD_To_Initial_Values(peaceInput);
            SetControl_TwoD_To_Initial_Values(peaceInput);
            SetControl_ThreeD_To_Initial_Values(peaceInput);




        }


        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        public ZeroitPeaceAnimatorDialog(Control c) : this(PeaceInput.Empty(), c)
        {
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="peaceInput">The peace input.</param>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="filler" /> is null.</exception>
        public ZeroitPeaceAnimatorDialog(PeaceInput peaceInput, Control c) : this(peaceInput)
        {
            Transitions.AnimationEditors.Utilities.Draw.SetStartPositionBelowControl(this, c);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Adjusts the size of the dialog.
        /// </summary>
        private void AdjustDialogSize()
        {
            // Three different possible group boxes - move them all to one coordinate
            int x = oneD_GroupBox.Location.X;
            int y = general_Container.Location.Y;

            oneD_GroupBox.Location = new Point(x, y);
            twoD_GroupBox.Location = new Point(x, y);
            threeD_GroupBox.Location = new Point(x, y);

            //formName.Location = new Point(typeGroupBox.Location.X, formName.Location.Y - 5);

            int bottomY = Math.Max(oneD_GroupBox.Bounds.Bottom,
                Math.Max(twoD_GroupBox.Bounds.Bottom,
                    Math.Max(threeD_GroupBox.Bounds.Bottom,

                        general_Container.Bounds.Bottom)));



            int newHeight = bottomY + general_Container.Location.Y;

            this.Size = new Size(Size.Width, Size.Height - (ClientSize.Height - newHeight));
        }

        /// <summary>
        /// Shapes the type changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ShapeTypeChanged(object sender, EventArgs e)
        {
            oneD_GroupBox.Visible = false;
            twoD_GroupBox.Visible = false;
            threeD_GroupBox.Visible = false;

            if (mainControl_animationMode_Combo.SelectedIndex == OneD)
            {
                oneD_GroupBox.Visible = true;
                
            }
            else if (mainControl_animationMode_Combo.SelectedIndex == TwoD)
            {
                twoD_GroupBox.Visible = true;
            }
            else if (mainControl_animationMode_Combo.SelectedIndex == ThreeD)
            {
                threeD_GroupBox.Visible = true;
            }
            else if(mainControl_animationMode_Combo.SelectedIndex == Default)
            {
                oneD_GroupBox.Visible = false;
                twoD_GroupBox.Visible = false;
                threeD_GroupBox.Visible = false;
            }




        }


        /// <summary>
        /// Sets the initial values.
        /// </summary>
        /// <param name="peaceInput">The peace input.</param>
        private void SetInitial_Values(PeaceInput peaceInput)
        {
            mainControl_animationMode_Combo.SelectedIndex = Default;
            oneD_Custom_Property_Name_TextBox.Text = propertyName;
            oneD_Property_ComboBox.SelectedIndex = OneD_Property_Custom;
            twoD_Property_ComboBox.SelectedIndex = TwoD_Property_Location;
            twoD_Continued_Easing_ComboBox.SelectedIndex = ExponentialEaseInOut;
            twoD_Easing_ComboBox.SelectedIndex = CircularEaseIn;
            threeD_Property_ComboBox.SelectedIndex = ThreeD_Property_BackColor;
            threeD_Easing_ComboBox.SelectedIndex = QuadraticEaseIn;

            mainControl_Path_Continue_ComboBox.SelectedIndex = Yes;
            mainControl_Repeat_ComboBox.SelectedIndex = Yes;
            mainControl_Reverse_ComboBox.SelectedIndex = Yes;
            //mainControl_Easing_ComboBox.SelectedIndex = BounceEaseIn;

            //peaceInput.Control = FindForm();
            
            foreach(var controlNames in peaceInput.Control.FindForm().Controls)
            {
                control_ComboBox.Items.Add(controlNames);
                
            }
            control_ComboBox.Items.Add(peaceInput.Control.FindForm());


            for (int i = 0; i < control_ComboBox.Items.Count; i++)
                {
                    if (peaceInput.Control == (Control)(control_ComboBox.Items[i]))
                    {
                        control_ComboBox.SelectedIndex = i;
                    }
                    
                }
            

            #region Animation Mode Retrieval
            if (peaceInput.AnimationMode == animationMode.Default)
            {
                mainControl_animationMode_Combo.SelectedIndex = Default;
            }
            else if (peaceInput.AnimationMode == animationMode.OneD)
            {
                mainControl_animationMode_Combo.SelectedIndex = OneD;
            }
            else if (peaceInput.AnimationMode == animationMode.TwoD)
            {
                mainControl_animationMode_Combo.SelectedIndex = TwoD;
            }
            else
            {
                mainControl_animationMode_Combo.SelectedIndex = ThreeD;
            }
            #endregion

            #region Path Continue Retrieval

            if (peaceInput.OneD_Continue && peaceInput.TwoDContinue && peaceInput.ThreeDContinue == true)
            {
                mainControl_Path_Continue_ComboBox.SelectedIndex = Yes;

            }
            else
            {
                mainControl_Path_Continue_ComboBox.SelectedIndex = No;
            }

            #endregion

            #region Repeat Retrieval

            if (peaceInput.Repeat == true)
            {
                mainControl_Repeat_ComboBox.SelectedIndex = Yes;
            }
            else
            {
                mainControl_Repeat_ComboBox.SelectedIndex = No;
            }

            #endregion

            #region Reverse Retrieval

            if (peaceInput.Reverse == true)
            {
                mainControl_Reverse_ComboBox.SelectedIndex = Yes;
            }
            else
            {
                mainControl_Reverse_ComboBox.SelectedIndex = No;
            }

            #endregion
        }

        #region One D Value Sets

        /// <summary>
        /// Sets the control one d to initial values.
        /// </summary>
        /// <param name="peaceInput">The peace input.</param>
        private void SetControl_OneD_To_Initial_Values(PeaceInput peaceInput)
        {
            
            
            if (mainControl_animationMode_Combo.SelectedIndex == OneD)
            {
                for (int i = 0; i < control_ComboBox.Items.Count; i++)
                {
                    if ((Control)(control_ComboBox.Items[i]) == peaceInput.Control)
                    {
                        control_ComboBox.SelectedIndex = i;
                        
                    }

                }

                oneD_GroupBox.Visible = true;
                oneD_Custom_Property_Name_TextBox.Text = peaceInput.PropertyName;
                oneDProperty = peaceInput.OneDProperty;


                if (peaceInput.OneDProperty == Animator.KnownProperties.Custom)
                {
                    oneD_Property_ComboBox.SelectedIndex = OneD_Property_Custom;

                }
                else if (peaceInput.OneDProperty == Animator.KnownProperties.Height)
                {
                    oneD_Property_ComboBox.SelectedIndex = OneD_Property_Height;
                }
                else if (peaceInput.OneDProperty == Animator.KnownProperties.Opacity)
                {
                    oneD_Property_ComboBox.SelectedIndex = OneD_Property_Opacity;
                }
                else if (peaceInput.OneDProperty == Animator.KnownProperties.Value)
                {
                    oneD_Property_ComboBox.SelectedIndex = OneD_Property_Value;
                }
                else
                {
                    oneD_Property_ComboBox.SelectedIndex = OneD_Property_Value;
                }

                #region Easing Retrieval

                if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.BounceEaseIn)
                {
                    oneD_Easing_ComboBox.SelectedIndex = BounceEaseIn;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.BounceEaseInOut)
                {
                    oneD_Easing_ComboBox.SelectedIndex = BounceEaseInOut;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.BounceEaseOut)
                {
                    oneD_Easing_ComboBox.SelectedIndex = BounceEaseOut;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.BounceEaseOutIn)
                {
                    oneD_Easing_ComboBox.SelectedIndex = BounceEaseOutIn;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.CircularEaseIn)
                {
                    oneD_Easing_ComboBox.SelectedIndex = CircularEaseIn;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.CircularEaseInOut)
                {
                    oneD_Easing_ComboBox.SelectedIndex = CircularEaseInOut;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.CircularEaseOut)
                {
                    oneD_Easing_ComboBox.SelectedIndex = CircularEaseOut;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.CubicEaseIn)
                {
                    oneD_Easing_ComboBox.SelectedIndex = CubicEaseIn;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.CubicEaseInOut)
                {
                    oneD_Easing_ComboBox.SelectedIndex = CubicEaseInOut;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.CubicEaseOut)
                {
                    oneD_Easing_ComboBox.SelectedIndex = CubicEaseOut;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.ExponentialEaseIn)
                {
                    oneD_Easing_ComboBox.SelectedIndex = ExponentialEaseIn;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.ExponentialEaseInOut)
                {
                    oneD_Easing_ComboBox.SelectedIndex = ExponentialEaseInOut;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.ExponentialEaseOut)
                {
                    oneD_Easing_ComboBox.SelectedIndex = ExponentialEaseOut;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.Liner)
                {
                    oneD_Easing_ComboBox.SelectedIndex = Liner;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.None)
                {
                    oneD_Easing_ComboBox.SelectedIndex = None;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.QuadraticEaseIn)
                {
                    oneD_Easing_ComboBox.SelectedIndex = QuadraticEaseIn;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.QuadraticEaseInOut)
                {
                    oneD_Easing_ComboBox.SelectedIndex = QuadraticEaseInOut;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.QuadraticEaseOut)
                {
                    oneD_Easing_ComboBox.SelectedIndex = QuadraticEaseOut;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.QuarticEaseIn)
                {
                    oneD_Easing_ComboBox.SelectedIndex = QuarticEaseIn;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.QuarticEaseInOut)
                {
                    oneD_Easing_ComboBox.SelectedIndex = QuarticEaseInOut;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.QuarticEaseOut)
                {
                    oneD_Easing_ComboBox.SelectedIndex = QuarticEaseOut;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.QuinticEaseIn)
                {
                    oneD_Easing_ComboBox.SelectedIndex = QuinticEaseIn;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.QuinticEaseInOut)
                {
                    oneD_Easing_ComboBox.SelectedIndex = QuinticEaseInOut;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.QuinticEaseOut)
                {
                    oneD_Easing_ComboBox.SelectedIndex = QuinticEaseOut;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.SinusoidalEaseIn)
                {
                    oneD_Easing_ComboBox.SelectedIndex = SinusoidalEaseIn;
                }
                else if (peaceInput.OneD_Path_Easing == KnownAnimationFunctions.SinusoidalEaseInOut)
                {
                    oneD_Easing_ComboBox.SelectedIndex = SinusoidalEaseInOut;
                }
                else
                {
                    oneD_Easing_ComboBox.SelectedIndex = SinusoidalEaseOut;
                }





                #endregion

                #region Numerics

                oneD_Start_Numeric.Value = (decimal)peaceInput.StartValue;

                oneD_End_Numeric.Value = (decimal)peaceInput.EndValue;

                oneD_Delay_Numeric.Value = (decimal)peaceInput.DelayValue;

                oneD_Duration_Numeric.Value = (decimal)peaceInput.DurationValue;

                #endregion

            }

            else if (peaceInput.AnimationMode == Transitions.WinformAnimation.animationMode.TwoD)
            {
                mainControl_animationMode_Combo.SelectedIndex = TwoD;
                twoD_GroupBox.Visible = true;

            }
            else if (peaceInput.AnimationMode == Transitions.WinformAnimation.animationMode.ThreeD)
            {
                mainControl_animationMode_Combo.SelectedIndex = ThreeD;
                threeD_GroupBox.Visible = true;

            }

            else
            {
                mainControl_animationMode_Combo.SelectedIndex = Default;
                oneD_GroupBox.Visible = false;
                twoD_GroupBox.Visible = false;
                threeD_GroupBox.Visible = false;
            }



        }

        /// <summary>
        /// Sets the control one d to retrieval values.
        /// </summary>
        /// <param name="peaceInput">The peace input.</param>
        private void SetControl_OneD_To_Retrieval_Values(PeaceInput peaceInput)
        {
            peaceInput.PropertyName = propertyName;

            peaceInput.Control = (Control) control_ComboBox.SelectedItem;

            #region Property Retrieved
            if (oneD_Property_ComboBox.SelectedIndex == OneD_Property_Custom)
            {
                peaceInput.OneDProperty = Animator.KnownProperties.Custom;

                oneD_Width_Animator.OneDProperty = Animator.KnownProperties.Custom;
                oneD_Height_Animator.OneDProperty = Animator.KnownProperties.Custom;
                oneD_Opacity_Animator.OneDProperty = Animator.KnownProperties.Custom;
                oneD_Value_Animator.OneDProperty = Animator.KnownProperties.Custom;
            }
            else if (oneD_Property_ComboBox.SelectedIndex == OneD_Property_Height)
            {
                peaceInput.OneDProperty = Animator.KnownProperties.Height;

                oneD_Width_Animator.OneDProperty = Animator.KnownProperties.Height;
                oneD_Height_Animator.OneDProperty = Animator.KnownProperties.Height;
                oneD_Opacity_Animator.OneDProperty = Animator.KnownProperties.Height;
                oneD_Value_Animator.OneDProperty = Animator.KnownProperties.Height;
            }
            else if (oneD_Property_ComboBox.SelectedIndex == OneD_Property_Width)
            {
                peaceInput.OneDProperty = Animator.KnownProperties.Width;

                oneD_Width_Animator.OneDProperty = Animator.KnownProperties.Width;
                oneD_Height_Animator.OneDProperty = Animator.KnownProperties.Width;
                oneD_Opacity_Animator.OneDProperty = Animator.KnownProperties.Width;
                oneD_Value_Animator.OneDProperty = Animator.KnownProperties.Width;
            }
            else if (oneD_Property_ComboBox.SelectedIndex == OneD_Property_Value)
            {
                peaceInput.OneDProperty = Animator.KnownProperties.Value;

                oneD_Width_Animator.OneDProperty = Animator.KnownProperties.Value;
                oneD_Height_Animator.OneDProperty = Animator.KnownProperties.Value;
                oneD_Opacity_Animator.OneDProperty = Animator.KnownProperties.Value;
                oneD_Value_Animator.OneDProperty = Animator.KnownProperties.Value;
            }
            else
            {
                peaceInput.OneDProperty = Animator.KnownProperties.Opacity;

                oneD_Width_Animator.OneDProperty = Animator.KnownProperties.Opacity;
                oneD_Height_Animator.OneDProperty = Animator.KnownProperties.Opacity;
                oneD_Opacity_Animator.OneDProperty = Animator.KnownProperties.Opacity;
                oneD_Value_Animator.OneDProperty = Animator.KnownProperties.Opacity;
            }
            #endregion

            #region Easing Retrieval

            if (oneD_Easing_ComboBox.SelectedIndex == BounceEaseIn)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.BounceEaseIn;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.BounceEaseIn;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.BounceEaseIn;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.BounceEaseIn;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.BounceEaseIn;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == BounceEaseInOut)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.BounceEaseInOut;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.BounceEaseInOut;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.BounceEaseInOut;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.BounceEaseInOut;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.BounceEaseInOut;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == BounceEaseOut)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.BounceEaseOut;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.BounceEaseOut;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.BounceEaseOut;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.BounceEaseOut;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.BounceEaseOut;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == BounceEaseOutIn)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.BounceEaseOutIn;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.BounceEaseOutIn;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.BounceEaseOutIn;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.BounceEaseOutIn;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.BounceEaseOutIn;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == CircularEaseIn)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.CircularEaseIn;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.CircularEaseIn;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.CircularEaseIn;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.CircularEaseIn;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.CircularEaseIn;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == CircularEaseInOut)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.CircularEaseInOut;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.CircularEaseInOut;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.CircularEaseInOut;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.CircularEaseInOut;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.CircularEaseInOut;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == CircularEaseOut)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.CircularEaseOut;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.CircularEaseOut;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.CircularEaseOut;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.CircularEaseOut;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.CircularEaseOut;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == CubicEaseIn)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.CubicEaseIn;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.CubicEaseIn;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.CubicEaseIn;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.CubicEaseIn;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.CubicEaseIn;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == CubicEaseInOut)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.CubicEaseInOut;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.CubicEaseInOut;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.CubicEaseInOut;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.CubicEaseInOut;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.CubicEaseInOut;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == CubicEaseOut)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.CubicEaseOut;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.CubicEaseOut;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.CubicEaseOut;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.CubicEaseOut;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.CubicEaseOut;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == ExponentialEaseIn)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.ExponentialEaseIn;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.ExponentialEaseIn;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.ExponentialEaseIn;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.ExponentialEaseIn;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.ExponentialEaseIn;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == ExponentialEaseInOut)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.ExponentialEaseInOut;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.ExponentialEaseInOut;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.ExponentialEaseInOut;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.ExponentialEaseInOut;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.ExponentialEaseInOut;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == ExponentialEaseOut)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.ExponentialEaseOut;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.ExponentialEaseOut;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.ExponentialEaseOut;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.ExponentialEaseOut;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.ExponentialEaseOut;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == Liner)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.Liner;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.Liner;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.Liner;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.Liner;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.Liner;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == None)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.None;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.None;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.None;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.None;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.None;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == QuadraticEaseIn)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.QuadraticEaseIn;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuadraticEaseIn;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuadraticEaseIn;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuadraticEaseIn;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuadraticEaseIn;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == QuadraticEaseInOut)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.QuadraticEaseInOut;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuadraticEaseInOut;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuadraticEaseInOut;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuadraticEaseInOut;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuadraticEaseInOut;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == QuadraticEaseOut)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.QuadraticEaseOut;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuadraticEaseOut;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuadraticEaseOut;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuadraticEaseOut;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuadraticEaseOut;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == QuarticEaseIn)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.QuarticEaseIn;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuarticEaseIn;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuarticEaseIn;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuarticEaseIn;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuarticEaseIn;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == QuarticEaseInOut)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.QuarticEaseInOut;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuarticEaseInOut;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuarticEaseInOut;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuarticEaseInOut;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuarticEaseInOut;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == QuarticEaseOut)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.QuarticEaseOut;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuarticEaseOut;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuarticEaseOut;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuarticEaseOut;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuarticEaseOut;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == QuinticEaseIn)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.QuinticEaseIn;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuinticEaseIn;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuinticEaseIn;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuinticEaseIn;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuinticEaseIn;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == QuinticEaseInOut)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.QuinticEaseInOut;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuinticEaseInOut;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuinticEaseInOut;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuinticEaseInOut;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuinticEaseInOut;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == QuinticEaseOut)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.QuinticEaseOut;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuinticEaseOut;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuinticEaseOut;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuinticEaseOut;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.QuinticEaseOut;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == SinusoidalEaseIn)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.SinusoidalEaseIn;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.SinusoidalEaseIn;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.SinusoidalEaseIn;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.SinusoidalEaseIn;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.SinusoidalEaseIn;

            }
            else if (oneD_Easing_ComboBox.SelectedIndex == SinusoidalEaseInOut)
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.SinusoidalEaseInOut;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.SinusoidalEaseInOut;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.SinusoidalEaseInOut;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.SinusoidalEaseInOut;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.SinusoidalEaseInOut;

            }
            else
            {
                peaceInput.OneD_Path_Easing = KnownAnimationFunctions.SinusoidalEaseOut;

                oneD_Width_Animator.OneD_Path_Easing = KnownAnimationFunctions.SinusoidalEaseOut;
                oneD_Height_Animator.OneD_Path_Easing = KnownAnimationFunctions.SinusoidalEaseOut;
                oneD_Opacity_Animator.OneD_Path_Easing = KnownAnimationFunctions.SinusoidalEaseOut;
                oneD_Value_Animator.OneD_Path_Easing = KnownAnimationFunctions.SinusoidalEaseOut;

            }





            #endregion


            peaceInput.StartValue = (float)oneD_Start_Numeric.Value;

            oneD_Width_Animator.StartValue = (float)oneD_Start_Numeric.Value;
            oneD_Height_Animator.StartValue = (float)oneD_Start_Numeric.Value;
            oneD_Opacity_Animator.StartValue = (float)oneD_Start_Numeric.Value;
            oneD_Value_Animator.StartValue = (float)oneD_Start_Numeric.Value;


            peaceInput.EndValue = (float)oneD_End_Numeric.Value;

            oneD_Width_Animator.EndValue = (float)oneD_End_Numeric.Value;
            oneD_Height_Animator.EndValue = (float)oneD_End_Numeric.Value;
            oneD_Opacity_Animator.EndValue = (float)oneD_End_Numeric.Value;
            oneD_Value_Animator.EndValue = (float)oneD_End_Numeric.Value;


            peaceInput.DurationValue = (ulong)oneD_Duration_Numeric.Value;

            oneD_Width_Animator.DurationValue = (ulong)oneD_Duration_Numeric.Value;
            oneD_Height_Animator.DurationValue = (ulong)oneD_Duration_Numeric.Value;
            oneD_Opacity_Animator.DurationValue = (ulong)oneD_Duration_Numeric.Value;
            oneD_Value_Animator.DurationValue = (ulong)oneD_Duration_Numeric.Value;

            peaceInput.DelayValue = (ulong)oneD_Delay_Numeric.Value;

            oneD_Width_Animator.DelayValue = (ulong)oneD_Delay_Numeric.Value;
            oneD_Height_Animator.DelayValue = (ulong)oneD_Delay_Numeric.Value;
            oneD_Opacity_Animator.DelayValue = (ulong)oneD_Delay_Numeric.Value;
            oneD_Value_Animator.DelayValue = (ulong)oneD_Delay_Numeric.Value;

        }


        #endregion

        #region Two D Value Sets

        /// <summary>
        /// Sets the control two d to initial values.
        /// </summary>
        /// <param name="peaceInput">The peace input.</param>
        private void SetControl_TwoD_To_Initial_Values(PeaceInput peaceInput)
        {


            if (mainControl_animationMode_Combo.SelectedIndex == OneD)
            {
                mainControl_animationMode_Combo.SelectedIndex = OneD;
                oneD_GroupBox.Visible = true;
                
            }

            else if (peaceInput.AnimationMode == Transitions.WinformAnimation.animationMode.TwoD)
            {
                for (int i = 0; i < control_ComboBox.Items.Count; i++)
                {
                    if ((Control)(control_ComboBox.Items[i]) == peaceInput.Control)
                    {
                        control_ComboBox.SelectedIndex = i;

                    }

                }

                mainControl_animationMode_Combo.SelectedIndex = TwoD;
                twoD_GroupBox.Visible = true;

                #region Property Retrieval
                if (peaceInput.TwoDProperty == Animator2D.KnownProperties.Location)
                {
                    twoD_Property_ComboBox.SelectedIndex = TwoD_Property_Location;

                }
                else
                {
                    twoD_Property_ComboBox.SelectedIndex = TwoD_Property_Size;
                }

                #endregion

                #region Easing Retrieval

                if (peaceInput.Path_Easing == KnownAnimationFunctions.BounceEaseIn)
                {
                    twoD_Easing_ComboBox.SelectedIndex = BounceEaseIn;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.BounceEaseInOut)
                {
                    twoD_Easing_ComboBox.SelectedIndex = BounceEaseInOut;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.BounceEaseOut)
                {
                    twoD_Easing_ComboBox.SelectedIndex = BounceEaseOut;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.BounceEaseOutIn)
                {
                    twoD_Easing_ComboBox.SelectedIndex = BounceEaseOutIn;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.CircularEaseIn)
                {
                    twoD_Easing_ComboBox.SelectedIndex = CircularEaseIn;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.CircularEaseInOut)
                {
                    twoD_Easing_ComboBox.SelectedIndex = CircularEaseInOut;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.CircularEaseOut)
                {
                    twoD_Easing_ComboBox.SelectedIndex = CircularEaseOut;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.CubicEaseIn)
                {
                    twoD_Easing_ComboBox.SelectedIndex = CubicEaseIn;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.CubicEaseInOut)
                {
                    twoD_Easing_ComboBox.SelectedIndex = CubicEaseInOut;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.CubicEaseOut)
                {
                    twoD_Easing_ComboBox.SelectedIndex = CubicEaseOut;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.ExponentialEaseIn)
                {
                    twoD_Easing_ComboBox.SelectedIndex = ExponentialEaseIn;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.ExponentialEaseInOut)
                {
                    twoD_Easing_ComboBox.SelectedIndex = ExponentialEaseInOut;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.ExponentialEaseOut)
                {
                    twoD_Easing_ComboBox.SelectedIndex = ExponentialEaseOut;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.Liner)
                {
                    twoD_Easing_ComboBox.SelectedIndex = Liner;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.None)
                {
                    twoD_Easing_ComboBox.SelectedIndex = None;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.QuadraticEaseIn)
                {
                    twoD_Easing_ComboBox.SelectedIndex = QuadraticEaseIn;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.QuadraticEaseInOut)
                {
                    twoD_Easing_ComboBox.SelectedIndex = QuadraticEaseInOut;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.QuadraticEaseOut)
                {
                    twoD_Easing_ComboBox.SelectedIndex = QuadraticEaseOut;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.QuarticEaseIn)
                {
                    twoD_Easing_ComboBox.SelectedIndex = QuarticEaseIn;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.QuarticEaseInOut)
                {
                    twoD_Easing_ComboBox.SelectedIndex = QuarticEaseInOut;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.QuarticEaseOut)
                {
                    twoD_Easing_ComboBox.SelectedIndex = QuarticEaseOut;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.QuinticEaseIn)
                {
                    twoD_Easing_ComboBox.SelectedIndex = QuinticEaseIn;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.QuinticEaseInOut)
                {
                    twoD_Easing_ComboBox.SelectedIndex = QuinticEaseInOut;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.QuinticEaseOut)
                {
                    twoD_Easing_ComboBox.SelectedIndex = QuinticEaseOut;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.SinusoidalEaseIn)
                {
                    twoD_Easing_ComboBox.SelectedIndex = SinusoidalEaseIn;
                }
                else if (peaceInput.Path_Easing == KnownAnimationFunctions.SinusoidalEaseInOut)
                {
                    twoD_Easing_ComboBox.SelectedIndex = SinusoidalEaseInOut;
                }
                else
                {
                    twoD_Easing_ComboBox.SelectedIndex = SinusoidalEaseOut;
                }





                #endregion

                #region Continued Easing Retrieval

                if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.BounceEaseIn)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = BounceEaseIn;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.BounceEaseInOut)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = BounceEaseInOut;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.BounceEaseOut)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = BounceEaseOut;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.BounceEaseOutIn)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = BounceEaseOutIn;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.CircularEaseIn)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = CircularEaseIn;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.CircularEaseInOut)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = CircularEaseInOut;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.CircularEaseOut)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = CircularEaseOut;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.CubicEaseIn)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = CubicEaseIn;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.CubicEaseInOut)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = CubicEaseInOut;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.CubicEaseOut)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = CubicEaseOut;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.ExponentialEaseIn)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = ExponentialEaseIn;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.ExponentialEaseInOut)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = ExponentialEaseInOut;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.ExponentialEaseOut)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = ExponentialEaseOut;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.Liner)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = Liner;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.None)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = None;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.QuadraticEaseIn)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = QuadraticEaseIn;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.QuadraticEaseInOut)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = QuadraticEaseInOut;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.QuadraticEaseOut)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = QuadraticEaseOut;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.QuarticEaseIn)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = QuarticEaseIn;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.QuarticEaseInOut)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = QuarticEaseInOut;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.QuarticEaseOut)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = QuarticEaseOut;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.QuinticEaseIn)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = QuinticEaseIn;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.QuinticEaseInOut)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = QuinticEaseInOut;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.QuinticEaseOut)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = QuinticEaseOut;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.SinusoidalEaseIn)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = SinusoidalEaseIn;
                }
                else if (peaceInput.Continued_Path_Easing == KnownAnimationFunctions.SinusoidalEaseInOut)
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = SinusoidalEaseInOut;
                }
                else
                {
                    twoD_Continued_Easing_ComboBox.SelectedIndex = SinusoidalEaseOut;
                }





                #endregion

                #region Numerics

                twoD_Start1_Numeric.Value = (decimal)peaceInput.Path2D_start_1;
                twoD_Start2_Numeric.Value = (decimal) peaceInput.Path2D_start_2;

                twoD_End1_Numeric.Value = (decimal) peaceInput.Path2D_end_1;
                twoD_End2_Numeric.Value = (decimal)peaceInput.Path2D_end_2;

                twoD_Duration1_Numeric.Value = (decimal)peaceInput.Path2D_duration_1;
                twoD_Duration2_Numeric.Value = (decimal)peaceInput.Path2D_duration_2;

                twoD_Delay1_Numeric.Value = (decimal)peaceInput.Path2D_delay_1;
                twoD_Delay2_Numeric.Value = (decimal)peaceInput.Path2D_delay_2;

                twoD_Continued_Start1_Numeric.Value = (decimal) peaceInput.Continued_path2D_start_1;
                twoD_Continued_Start2_Numeric.Value = (decimal)peaceInput.Continued_path2D_start_2;

                twoD_Continued_End1_Numeric.Value = (decimal)peaceInput.Continued_path2D_end_1;
                twoD_Continued_End2_Numeric.Value = (decimal)peaceInput.Continued_path2D_end_2;

                twoD_Continued_Duration1_Numeric.Value = (decimal)peaceInput.Continued_path2D_duration_1;
                twoD_Continued_Duration2_Numeric.Value = (decimal)peaceInput.Continued_path2D_duration_2;

                twoD_Continued_Delay1_Numeric.Value = (decimal)peaceInput.Continued_path2D_delay_1;
                twoD_Continued_Delay2_Numeric.Value = (decimal)peaceInput.Continued_path2D_delay_2;




                #endregion

            }
            else if (peaceInput.AnimationMode == Transitions.WinformAnimation.animationMode.ThreeD)
            {
                mainControl_animationMode_Combo.SelectedIndex = ThreeD;
                threeD_GroupBox.Visible = true;

            }

            else
            {
                mainControl_animationMode_Combo.SelectedIndex = Default;
                oneD_GroupBox.Visible = false;
                twoD_GroupBox.Visible = false;
                threeD_GroupBox.Visible = false;
            }



        }

        /// <summary>
        /// Sets the control two d to retrieval values.
        /// </summary>
        /// <param name="peaceInput">The peace input.</param>
        private void SetControl_TwoD_To_Retrieval_Values(PeaceInput peaceInput)
        {
            peaceInput.Control = (Control)control_ComboBox.SelectedItem;

            #region Property Retrieved
            if (twoD_Property_ComboBox.SelectedIndex == TwoD_Property_Location)
            {
                peaceInput.TwoDProperty = Animator2D.KnownProperties.Location;

                twoD_Size_Animator.TwoDProperty = Animator2D.KnownProperties.Location;
            }
            else
            {
                peaceInput.TwoDProperty = Animator2D.KnownProperties.Size;

                twoD_Size_Animator.TwoDProperty = Animator2D.KnownProperties.Size;
            }
            
            #endregion

            #region Easing Retrieved

            if (twoD_Easing_ComboBox.SelectedIndex == BounceEaseIn)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.BounceEaseIn;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.BounceEaseIn;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.BounceEaseIn;


            }
            else if (twoD_Easing_ComboBox.SelectedIndex == BounceEaseInOut)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.BounceEaseInOut;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.BounceEaseInOut;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.BounceEaseInOut;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == BounceEaseOut)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.BounceEaseOut;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.BounceEaseOut;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.BounceEaseOut;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == BounceEaseOutIn)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.BounceEaseOutIn;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.BounceEaseOutIn;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.BounceEaseOutIn;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == CircularEaseIn)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.CircularEaseIn;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.CircularEaseIn;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.CircularEaseIn;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == CircularEaseInOut)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.CircularEaseInOut;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.CircularEaseInOut;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.CircularEaseInOut;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == CircularEaseOut)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.CircularEaseOut;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.CircularEaseOut;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.CircularEaseOut;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == CubicEaseIn)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.CubicEaseIn;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.CubicEaseIn;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.CubicEaseIn;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == CubicEaseInOut)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.CubicEaseInOut;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.CubicEaseInOut;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.CubicEaseInOut;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == CubicEaseOut)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.CubicEaseOut;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.CubicEaseOut;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.CubicEaseOut;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == ExponentialEaseIn)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.ExponentialEaseIn;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.ExponentialEaseIn;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.ExponentialEaseIn;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == ExponentialEaseInOut)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.ExponentialEaseInOut;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.ExponentialEaseInOut;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.ExponentialEaseInOut;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == ExponentialEaseOut)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.ExponentialEaseOut;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.ExponentialEaseOut;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.ExponentialEaseOut;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == Liner)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.Liner;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.Liner;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.Liner;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == None)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.None;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.None;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.None;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == QuadraticEaseIn)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.QuadraticEaseIn;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.QuadraticEaseIn;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.QuadraticEaseIn;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == QuadraticEaseInOut)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.QuadraticEaseInOut;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.QuadraticEaseInOut;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.QuadraticEaseInOut;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == QuadraticEaseOut)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.QuadraticEaseOut;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.QuadraticEaseOut;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.QuadraticEaseOut;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == QuarticEaseIn)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.QuarticEaseIn;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.QuarticEaseIn;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.QuarticEaseIn;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == QuarticEaseInOut)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.QuarticEaseInOut;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.QuarticEaseInOut;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.QuarticEaseInOut;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == QuarticEaseOut)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.QuarticEaseOut;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.QuarticEaseOut;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.QuarticEaseOut;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == QuinticEaseIn)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.QuinticEaseIn;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.QuinticEaseIn;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.QuinticEaseIn;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == QuinticEaseInOut)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.QuinticEaseInOut;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.QuinticEaseInOut;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.QuinticEaseInOut;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == QuinticEaseOut)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.QuinticEaseOut;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.QuinticEaseOut;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.QuinticEaseOut;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == SinusoidalEaseIn)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.SinusoidalEaseIn;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.SinusoidalEaseIn;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.SinusoidalEaseIn;

            }
            else if (twoD_Easing_ComboBox.SelectedIndex == SinusoidalEaseInOut)
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.SinusoidalEaseInOut;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.SinusoidalEaseInOut;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.SinusoidalEaseInOut;

            }
            else
            {
                peaceInput.Path_Easing = KnownAnimationFunctions.SinusoidalEaseOut;

                twoD_Size_Animator.Path_Easing = KnownAnimationFunctions.SinusoidalEaseOut;
                twoD_Location_Animator.Path_Easing = KnownAnimationFunctions.SinusoidalEaseOut;

            }





            #endregion

            #region Continued Easing Retrieved

            if (twoD_Continued_Easing_ComboBox.SelectedIndex == BounceEaseIn)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.BounceEaseIn;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.BounceEaseIn;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.BounceEaseIn;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == BounceEaseInOut)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.BounceEaseInOut;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.BounceEaseInOut;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.BounceEaseInOut;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == BounceEaseOut)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.BounceEaseOut;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.BounceEaseOut;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.BounceEaseOut;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == BounceEaseOutIn)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.BounceEaseOutIn;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.BounceEaseOutIn;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.BounceEaseOutIn;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == CircularEaseIn)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.CircularEaseIn;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.CircularEaseIn;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.CircularEaseIn;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == CircularEaseInOut)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.CircularEaseInOut;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.CircularEaseInOut;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.CircularEaseInOut;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == CircularEaseOut)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.CircularEaseOut;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.CircularEaseOut;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.CircularEaseOut;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == CubicEaseIn)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.CubicEaseIn;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.CubicEaseIn;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.CubicEaseIn;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == CubicEaseInOut)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.CubicEaseInOut;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.CubicEaseInOut;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.CubicEaseInOut;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == CubicEaseOut)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.CubicEaseOut;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.CubicEaseOut;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.CubicEaseOut;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == ExponentialEaseIn)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.ExponentialEaseIn;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.ExponentialEaseIn;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.ExponentialEaseIn;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == ExponentialEaseInOut)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.ExponentialEaseInOut;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.ExponentialEaseInOut;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.ExponentialEaseInOut;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == ExponentialEaseOut)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.ExponentialEaseOut;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.ExponentialEaseOut;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.ExponentialEaseOut;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == Liner)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.Liner;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.Liner;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.Liner;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == None)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.None;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.None;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.None;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == QuadraticEaseIn)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.QuadraticEaseIn;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.QuadraticEaseIn;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.QuadraticEaseIn;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == QuadraticEaseInOut)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.QuadraticEaseInOut;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.QuadraticEaseInOut;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.QuadraticEaseInOut;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == QuadraticEaseOut)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.QuadraticEaseOut;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.QuadraticEaseOut;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.QuadraticEaseOut;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == QuarticEaseIn)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.QuarticEaseIn;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.QuarticEaseIn;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.QuarticEaseIn;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == QuarticEaseInOut)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.QuarticEaseInOut;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.QuarticEaseInOut;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.QuarticEaseInOut;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == QuarticEaseOut)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.QuarticEaseOut;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.QuarticEaseOut;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.QuarticEaseOut;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == QuinticEaseIn)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.QuinticEaseIn;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.QuinticEaseIn;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.QuinticEaseIn;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == QuinticEaseInOut)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.QuinticEaseInOut;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.QuinticEaseInOut;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.QuinticEaseInOut;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == QuinticEaseOut)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.QuinticEaseOut;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.QuinticEaseOut;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.QuinticEaseOut;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == SinusoidalEaseIn)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.SinusoidalEaseIn;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.SinusoidalEaseIn;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.SinusoidalEaseIn;

            }
            else if (twoD_Continued_Easing_ComboBox.SelectedIndex == SinusoidalEaseInOut)
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.SinusoidalEaseInOut;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.SinusoidalEaseInOut;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.SinusoidalEaseInOut;

            }
            else
            {
                peaceInput.Continued_Path_Easing = KnownAnimationFunctions.SinusoidalEaseOut;

                twoD_Size_Animator.Continued_Path_Easing = KnownAnimationFunctions.SinusoidalEaseOut;
                twoD_Location_Animator.Continued_Path_Easing = KnownAnimationFunctions.SinusoidalEaseOut;

            }





            #endregion

            #region Numerics

            peaceInput.Path2D_start_1 = (int)twoD_Start1_Numeric.Value;
            twoD_Location_Animator.Path2D_start_1 = (int)twoD_Start1_Numeric.Value;
            twoD_Size_Animator.Path2D_start_1 = (int)twoD_Start1_Numeric.Value;


            peaceInput.Path2D_start_2 = (int)twoD_Start2_Numeric.Value;
            twoD_Location_Animator.Path2D_start_2 = (int)twoD_Start2_Numeric.Value;
            twoD_Size_Animator.Path2D_start_2 = (int)twoD_Start2_Numeric.Value;


            peaceInput.Path2D_end_1 = (int)twoD_End1_Numeric.Value;
            twoD_Location_Animator.Path2D_end_1 = (int)twoD_End1_Numeric.Value;
            twoD_Size_Animator.Path2D_end_1 = (int)twoD_End1_Numeric.Value;


            peaceInput.Path2D_end_2 = (int)twoD_End2_Numeric.Value;
            twoD_Location_Animator.Path2D_end_2 = (int)twoD_End2_Numeric.Value;
            twoD_Size_Animator.Path2D_end_2 = (int)twoD_End2_Numeric.Value;


            peaceInput.Path2D_duration_1 = (ulong)twoD_Duration1_Numeric.Value;
            twoD_Location_Animator.Path2D_duration_1 = (ulong)twoD_Duration1_Numeric.Value;
            twoD_Size_Animator.Path2D_duration_1 = (ulong)twoD_Duration1_Numeric.Value;


            peaceInput.Path2D_duration_2 = (ulong)twoD_Duration2_Numeric.Value;
            twoD_Location_Animator.Path2D_duration_2 = (ulong)twoD_Duration2_Numeric.Value;
            twoD_Size_Animator.Path2D_duration_2 = (ulong)twoD_Duration2_Numeric.Value;

            peaceInput.Path2D_delay_1 = (ulong)twoD_Delay1_Numeric.Value;
            twoD_Location_Animator.Path2D_delay_1 = (ulong)twoD_Delay1_Numeric.Value;
            twoD_Size_Animator.Path2D_delay_1 = (ulong)twoD_Delay1_Numeric.Value;


            peaceInput.Path2D_delay_2 = (ulong)twoD_Delay2_Numeric.Value;
            twoD_Location_Animator.Path2D_delay_2 = (ulong)twoD_Delay2_Numeric.Value;
            twoD_Size_Animator.Path2D_delay_2 = (ulong)twoD_Delay2_Numeric.Value;


            peaceInput.Continued_path2D_start_1 = (int)twoD_Continued_Start1_Numeric.Value;
            twoD_Location_Animator.Continued_path2D_start_1 = (int)twoD_Continued_Start1_Numeric.Value;
            twoD_Size_Animator.Continued_path2D_start_1 = (int)twoD_Continued_Start1_Numeric.Value;


            peaceInput.Continued_path2D_start_2 = (int)twoD_Continued_Start2_Numeric.Value;
            twoD_Location_Animator.Continued_path2D_start_2 = (int)twoD_Continued_Start2_Numeric.Value;
            twoD_Size_Animator.Continued_path2D_start_2 = (int)twoD_Continued_Start2_Numeric.Value;



            peaceInput.Continued_path2D_end_1 = (int)twoD_Continued_End1_Numeric.Value;
            twoD_Location_Animator.Continued_path2D_end_1 = (int)twoD_Continued_End1_Numeric.Value;
            twoD_Size_Animator.Continued_path2D_end_1 = (int)twoD_Continued_End1_Numeric.Value;



            peaceInput.Continued_path2D_end_2 = (int)twoD_Continued_End2_Numeric.Value;
            twoD_Location_Animator.Continued_path2D_end_2 = (int)twoD_Continued_End2_Numeric.Value;
            twoD_Size_Animator.Continued_path2D_end_2 = (int)twoD_Continued_End2_Numeric.Value;


            peaceInput.Continued_path2D_duration_1 = (ulong)twoD_Continued_Duration1_Numeric.Value;
            twoD_Location_Animator.Continued_path2D_duration_1 = (ulong)twoD_Continued_Duration1_Numeric.Value;
            twoD_Size_Animator.Continued_path2D_duration_1 = (ulong)twoD_Continued_Duration1_Numeric.Value;



            peaceInput.Continued_path2D_duration_2 = (ulong)twoD_Continued_Duration2_Numeric.Value;
            twoD_Location_Animator.Continued_path2D_duration_2 = (ulong)twoD_Continued_Duration2_Numeric.Value;
            twoD_Size_Animator.Continued_path2D_duration_2 = (ulong)twoD_Continued_Duration2_Numeric.Value;


            peaceInput.Continued_path2D_delay_1 = (ulong)twoD_Continued_Delay1_Numeric.Value;
            twoD_Location_Animator.Continued_path2D_delay_1 = (ulong)twoD_Continued_Delay1_Numeric.Value;
            twoD_Size_Animator.Continued_path2D_delay_1 = (ulong)twoD_Continued_Delay1_Numeric.Value;



            peaceInput.Continued_path2D_delay_2 = (ulong)twoD_Continued_Delay2_Numeric.Value;
            twoD_Location_Animator.Continued_path2D_delay_2 = (ulong)twoD_Continued_Delay2_Numeric.Value;
            twoD_Size_Animator.Continued_path2D_delay_2 = (ulong)twoD_Continued_Delay2_Numeric.Value;



            #endregion

        }

        #endregion

        #region Three D Value Sets

        /// <summary>
        /// Sets the control three d to initial values.
        /// </summary>
        /// <param name="peaceInput">The peace input.</param>
        private void SetControl_ThreeD_To_Initial_Values(PeaceInput peaceInput)
        {


            if (mainControl_animationMode_Combo.SelectedIndex == OneD)
            {
                mainControl_animationMode_Combo.SelectedIndex = OneD;
                oneD_GroupBox.Visible = true;
                
            }

            else if (peaceInput.AnimationMode == Transitions.WinformAnimation.animationMode.TwoD)
            {
                mainControl_animationMode_Combo.SelectedIndex = TwoD;
                twoD_GroupBox.Visible = true;

            }
            else if (peaceInput.AnimationMode == Transitions.WinformAnimation.animationMode.ThreeD)
            {
                for (int i = 0; i < control_ComboBox.Items.Count; i++)
                {
                    if ((Control)(control_ComboBox.Items[i]) == peaceInput.Control)
                    {
                        control_ComboBox.SelectedIndex = i;

                    }

                }

                mainControl_animationMode_Combo.SelectedIndex = ThreeD;
                threeD_GroupBox.Visible = true;

                threeD_Color_Property_Name_TextBox.Text = peaceInput.ColorPropertyName;

                if (peaceInput.ThreeDProperty == Animator3D.KnownProperties.BackColor)
                {
                    threeD_Property_ComboBox.SelectedIndex = ThreeD_Property_BackColor;

                }
                else if (peaceInput.ThreeDProperty == Animator3D.KnownProperties.ForeColor)
                {
                    threeD_Property_ComboBox.SelectedIndex = ThreeD_Property_ForeColor;
                }
                else 
                {
                    threeD_Property_ComboBox.SelectedIndex = ThreeD_Property_Custom;
                }
                


                #region Easing Retrieval

                if (peaceInput.Path3_Easing == KnownAnimationFunctions.BounceEaseIn)
                {
                    threeD_Easing_ComboBox.SelectedIndex = BounceEaseIn;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.BounceEaseInOut)
                {
                    threeD_Easing_ComboBox.SelectedIndex = BounceEaseInOut;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.BounceEaseOut)
                {
                    threeD_Easing_ComboBox.SelectedIndex = BounceEaseOut;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.BounceEaseOutIn)
                {
                    threeD_Easing_ComboBox.SelectedIndex = BounceEaseOutIn;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.CircularEaseIn)
                {
                    threeD_Easing_ComboBox.SelectedIndex = CircularEaseIn;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.CircularEaseInOut)
                {
                    threeD_Easing_ComboBox.SelectedIndex = CircularEaseInOut;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.CircularEaseOut)
                {
                    threeD_Easing_ComboBox.SelectedIndex = CircularEaseOut;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.CubicEaseIn)
                {
                    threeD_Easing_ComboBox.SelectedIndex = CubicEaseIn;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.CubicEaseInOut)
                {
                    threeD_Easing_ComboBox.SelectedIndex = CubicEaseInOut;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.CubicEaseOut)
                {
                    threeD_Easing_ComboBox.SelectedIndex = CubicEaseOut;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.ExponentialEaseIn)
                {
                    threeD_Easing_ComboBox.SelectedIndex = ExponentialEaseIn;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.ExponentialEaseInOut)
                {
                    threeD_Easing_ComboBox.SelectedIndex = ExponentialEaseInOut;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.ExponentialEaseOut)
                {
                    threeD_Easing_ComboBox.SelectedIndex = ExponentialEaseOut;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.Liner)
                {
                    threeD_Easing_ComboBox.SelectedIndex = Liner;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.None)
                {
                    threeD_Easing_ComboBox.SelectedIndex = None;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.QuadraticEaseIn)
                {
                    threeD_Easing_ComboBox.SelectedIndex = QuadraticEaseIn;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.QuadraticEaseInOut)
                {
                    threeD_Easing_ComboBox.SelectedIndex = QuadraticEaseInOut;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.QuadraticEaseOut)
                {
                    threeD_Easing_ComboBox.SelectedIndex = QuadraticEaseOut;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.QuarticEaseIn)
                {
                    threeD_Easing_ComboBox.SelectedIndex = QuarticEaseIn;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.QuarticEaseInOut)
                {
                    threeD_Easing_ComboBox.SelectedIndex = QuarticEaseInOut;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.QuarticEaseOut)
                {
                    threeD_Easing_ComboBox.SelectedIndex = QuarticEaseOut;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.QuinticEaseIn)
                {
                    threeD_Easing_ComboBox.SelectedIndex = QuinticEaseIn;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.QuinticEaseInOut)
                {
                    threeD_Easing_ComboBox.SelectedIndex = QuinticEaseInOut;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.QuinticEaseOut)
                {
                    threeD_Easing_ComboBox.SelectedIndex = QuinticEaseOut;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.SinusoidalEaseIn)
                {
                    threeD_Easing_ComboBox.SelectedIndex = SinusoidalEaseIn;
                }
                else if (peaceInput.Path3_Easing == KnownAnimationFunctions.SinusoidalEaseInOut)
                {
                    threeD_Easing_ComboBox.SelectedIndex = SinusoidalEaseInOut;
                }
                else
                {
                    threeD_Easing_ComboBox.SelectedIndex = SinusoidalEaseOut;
                }





                #endregion

                #region Numerics and Color

                threeD_Start_Color_Button.BackColor = peaceInput.StartColor;

                threeD_End_Color_Button.BackColor = peaceInput.EndColor;

                threeD_Delay_Numeric.Value = (ulong)peaceInput.Path3_Delay;

                threeD_Duration_Numeric.Value = (decimal)peaceInput.Path3_Duration;

                #endregion

            }

            else
            {
                mainControl_animationMode_Combo.SelectedIndex = Default;
                oneD_GroupBox.Visible = false;
                twoD_GroupBox.Visible = false;
                threeD_GroupBox.Visible = false;
            }



        }

        /// <summary>
        /// Sets the control three d to retrieval values.
        /// </summary>
        /// <param name="peaceInput">The peace input.</param>
        private void SetControl_ThreeD_To_Retrieval_Values(PeaceInput peaceInput)
        {
            peaceInput.Control = (Control)control_ComboBox.SelectedItem;

            peaceInput.ColorPropertyName = threeD_Color_Property_Name_TextBox.Text;

            #region Property Retrieved
            if (threeD_Property_ComboBox.SelectedIndex == ThreeD_Property_BackColor)
            {
                peaceInput.ThreeDProperty = Animator3D.KnownProperties.BackColor;
            }
            else if (threeD_Property_ComboBox.SelectedIndex == ThreeD_Property_ForeColor)
            {
                peaceInput.ThreeDProperty = Animator3D.KnownProperties.ForeColor;
            }
            else
            {
                peaceInput.ThreeDProperty = Animator3D.KnownProperties.Custom;
            }
            
            #endregion

            #region Easing Retrieval

            if (threeD_Easing_ComboBox.SelectedIndex == BounceEaseIn)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.BounceEaseIn;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == BounceEaseInOut)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.BounceEaseInOut;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == BounceEaseOut)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.BounceEaseOut;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == BounceEaseOutIn)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.BounceEaseOutIn;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == CircularEaseIn)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.CircularEaseIn;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == CircularEaseInOut)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.CircularEaseInOut;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == CircularEaseOut)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.CircularEaseOut;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == CubicEaseIn)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.CubicEaseIn;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == CubicEaseInOut)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.CubicEaseInOut;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == CubicEaseOut)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.CubicEaseOut;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == ExponentialEaseIn)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.ExponentialEaseIn;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == ExponentialEaseInOut)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.ExponentialEaseInOut;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == ExponentialEaseOut)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.ExponentialEaseOut;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == Liner)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.Liner;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == None)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.None;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == QuadraticEaseIn)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.QuadraticEaseIn;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == QuadraticEaseInOut)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.QuadraticEaseInOut;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == QuadraticEaseOut)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.QuadraticEaseOut;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == QuarticEaseIn)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.QuarticEaseIn;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == QuarticEaseInOut)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.QuarticEaseInOut;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == QuarticEaseOut)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.QuarticEaseOut;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == QuinticEaseIn)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.QuinticEaseIn;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == QuinticEaseInOut)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.QuinticEaseInOut;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == QuinticEaseOut)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.QuinticEaseOut;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == SinusoidalEaseIn)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.SinusoidalEaseIn;

            }
            else if (threeD_Easing_ComboBox.SelectedIndex == SinusoidalEaseInOut)
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.SinusoidalEaseInOut;

            }
            else
            {
                peaceInput.Path3_Easing = KnownAnimationFunctions.SinusoidalEaseOut;

            }





            #endregion

            #region Numerics and Color

            peaceInput.StartColor = startColor;

            peaceInput.EndColor = endColor;

            peaceInput.Path3_Delay = (ulong)threeD_Delay_Numeric.Value;

            peaceInput.Path3_Duration = (ulong)threeD_Duration_Numeric.Value;

            #endregion

        }


        #endregion


        #endregion


        /// <summary>
        /// Handles the Click event of the closeBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
            closeBtn.BackColor = Color.FromArgb(49, 49, 49);
        }

        /// <summary>
        /// Handles the Click event of the okBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (mainControl_animationMode_Combo.SelectedIndex == OneD)
            {
                peaceInput = new PeaceInput(animationMode.OneD, false, false, 0, 100, 5000,
                    0,
                    KnownAnimationFunctions.CircularEaseIn, "Value",
                    Animator.KnownProperties.Value, true, new Animator(new Path(0,100,5000,0)),
                    (Control)control_ComboBox.SelectedItem
                    );

                SetControl_OneD_To_Retrieval_Values(peaceInput);
            }
            else if (mainControl_animationMode_Combo.SelectedIndex == TwoD)
            {
                peaceInput = new PeaceInput(animationMode.TwoD, false, false, 70, 320, 2000,
                    0,5,100,2000,0, 320,70,2000,300,100,5,1700,600,Animator2D.KnownProperties.Location,
                    KnownAnimationFunctions.CircularEaseIn,KnownAnimationFunctions.ExponentialEaseInOut,true, new Animator2D(),
                    (Control)control_ComboBox.SelectedItem
                    );

                SetControl_TwoD_To_Retrieval_Values(peaceInput);
            }
            else if (mainControl_animationMode_Combo.SelectedIndex == ThreeD)
            {
                peaceInput = new PeaceInput(animationMode.ThreeD, false, false, 3000,0, Animator3D.KnownProperties.BackColor,
                    KnownAnimationFunctions.CircularEaseIn,
                    Color.DarkSlateGray,
                    Color.Orange,
                    "BackColor",true, new Animator3D(), 
                    (Control)control_ComboBox.SelectedItem
                    );

                SetControl_ThreeD_To_Retrieval_Values(peaceInput);
            }

            else
            {
                peaceInput = new PeaceInput(
                    animationMode.Default, 
                    (Control)control_ComboBox.SelectedItem
                    );
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
        /// Handles the SelectedIndexChanged event of the oneD_Property_ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void oneD_Property_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Handles the TextChanged event of the oneD_Custom_Property_Name_TextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void oneD_Custom_Property_Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            propertyName = oneD_Custom_Property_Name_TextBox.Text;

            oneD_Custom_Animator.PropertyName = propertyName;
        }

        /// <summary>
        /// Handles the Click event of the threeD_Start_Color_Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void threeD_Start_Color_Button_Click(object sender, EventArgs e)
        {
            

            if (colorChanger.ShowDialog() == DialogResult.OK)
            {
                threeD_Start_Color_Button.BackColor = colorChanger.Color;
                startColor = colorChanger.Color;

            }
        }

        /// <summary>
        /// Handles the Click event of the threeD_End_Color_Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void threeD_End_Color_Button_Click(object sender, EventArgs e)
        {
            

            if (colorChanger.ShowDialog() == DialogResult.OK)
            {
                threeD_End_Color_Button.BackColor = colorChanger.Color;
                endColor = colorChanger.Color;

            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the oneD_Easing_ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void oneD_Easing_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the MouseEnter event of the oneD_Preview control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void oneD_Preview_MouseEnter(object sender, EventArgs e)
        {
            oneD_Preview.FlatAppearance.BorderSize = 1;
            oneD_Preview.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the oneD_Preview control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void oneD_Preview_MouseLeave(object sender, EventArgs e)
        {
            oneD_Preview.FlatAppearance.BorderSize = 0;
            oneD_Preview.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);
        }

        /// <summary>
        /// Handles the MouseEnter event of the twoD_Preview control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_Preview_MouseEnter(object sender, EventArgs e)
        {
            twoD_Preview.FlatAppearance.BorderSize = 1;
            twoD_Preview.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the twoD_Preview control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_Preview_MouseLeave(object sender, EventArgs e)
        {
            twoD_Preview.FlatAppearance.BorderSize = 0;
            twoD_Preview.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);
        }

        /// <summary>
        /// Handles the MouseEnter event of the threeD_Preview control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void threeD_Preview_MouseEnter(object sender, EventArgs e)
        {
            threeD_Preview.FlatAppearance.BorderSize = 1;
            threeD_Preview.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the threeD_Preview control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void threeD_Preview_MouseLeave(object sender, EventArgs e)
        {
            threeD_Preview.FlatAppearance.BorderSize = 0;
            threeD_Preview.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);
        }

        /// <summary>
        /// Handles the Click event of the oneD_Preview control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void oneD_Preview_Click(object sender, EventArgs e)
        {
            
            if (oneD_Preview_startAnimation == false)
            {
                

                if (oneD_Property_ComboBox.SelectedIndex == OneD_Property_Custom)
                {
                    oneD_Value_Animator.Stop();
                }
                else if (oneD_Property_ComboBox.SelectedIndex == OneD_Property_Height)
                {
                    oneD_Height_Animator.Stop();
                }
                else if (oneD_Property_ComboBox.SelectedIndex == OneD_Property_Width)
                {
                    oneD_Width_Animator.Stop();
                }
                else
                {
                    oneD_Opacity_Animator.Stop();
                }
                
            }
            else if (oneD_Preview_startAnimation == true)
            {
                

                if (oneD_Property_ComboBox.SelectedIndex == OneD_Property_Custom)
                {
                    oneD_Value_Animator.Start();
                }
                else if (oneD_Property_ComboBox.SelectedIndex == OneD_Property_Height)
                {
                    oneD_Height_Animator.Start();
                }
                else if (oneD_Property_ComboBox.SelectedIndex == OneD_Property_Width)
                {
                    oneD_Width_Animator.Start();
                }
                else
                {
                    oneD_Opacity_Animator.Start();
                }
                
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the mainControl_Repeat_ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Repeat_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainControl_Repeat_ComboBox.SelectedIndex == Yes)
            {
                oneD_Width_Animator.Repeat = true;
                oneD_Height_Animator.Repeat = true;
                oneD_Opacity_Animator.Repeat = true;
                oneD_Value_Animator.Repeat = true;
                oneD_Custom_Animator.Repeat = true;

                twoD_Location_Animator.Repeat = true;
                twoD_Size_Animator.Repeat = true;

            }
            else
            {
                oneD_Width_Animator.Repeat = false;
                oneD_Height_Animator.Repeat = false;
                oneD_Opacity_Animator.Repeat = false;
                oneD_Value_Animator.Repeat = false;
                oneD_Custom_Animator.Repeat = false;

                twoD_Location_Animator.Repeat = false;
                twoD_Size_Animator.Repeat = false;
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the mainControl_Reverse_ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_Reverse_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainControl_Reverse_ComboBox.SelectedIndex == Yes)
            {
                oneD_Width_Animator.Reverse = true;
                oneD_Height_Animator.Reverse = true;
                oneD_Opacity_Animator.Reverse = true;
                oneD_Value_Animator.Reverse = true;
                oneD_Custom_Animator.Reverse = true;

                twoD_Location_Animator.Reverse = true;
                twoD_Size_Animator.Reverse = true;
            }
            else
            {
                oneD_Width_Animator.Reverse = false;
                oneD_Height_Animator.Reverse = false;
                oneD_Opacity_Animator.Reverse = false;
                oneD_Value_Animator.Reverse = false;
                oneD_Custom_Animator.Reverse = false;

                twoD_Location_Animator.Reverse = false;
                twoD_Size_Animator.Reverse = false;
            }
        }

        /// <summary>
        /// Handles the MouseDown event of the oneD_Preview control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void oneD_Preview_MouseDown(object sender, MouseEventArgs e)
        {
            oneD_Preview_startAnimation = true;
            
        }

        /// <summary>
        /// Handles the ValueChanged event of the oneD_Start_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void oneD_Start_Numeric_ValueChanged(object sender, EventArgs e)
        {
            oneD_Custom_Animator.StartValue = (int)oneD_Start_Numeric.Value;
            oneD_Width_Animator.StartValue = (int)oneD_Start_Numeric.Value;
            oneD_Height_Animator.StartValue = (int)oneD_Start_Numeric.Value;
            oneD_Opacity_Animator.StartValue = (int)oneD_Start_Numeric.Value;
            oneD_Value_Animator.StartValue = (int)oneD_Start_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the oneD_End_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void oneD_End_Numeric_ValueChanged(object sender, EventArgs e)
        {
            oneD_Custom_Animator.EndValue = (int)oneD_End_Numeric.Value;
            oneD_Width_Animator.EndValue = (int)oneD_End_Numeric.Value;
            oneD_Height_Animator.EndValue = (int)oneD_End_Numeric.Value;
            oneD_Opacity_Animator.EndValue = (int)oneD_End_Numeric.Value;
            oneD_Value_Animator.EndValue = (int)oneD_End_Numeric.Value;
        }

        /// <summary>
        /// Handles the Click event of the twoD_Preview control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_Preview_Click(object sender, EventArgs e)
        {
            

            if (twoD_Preview_startAnimation == false)
            {


                if (twoD_Property_ComboBox.SelectedIndex == TwoD_Property_Location)
                {
                    twoD_Location_Animator.Stop();
                }
                else 
                {
                    twoD_Size_Animator.Stop();
                }
                

            }
            else if (twoD_Preview_startAnimation == true)
            {


                if (twoD_Property_ComboBox.SelectedIndex == TwoD_Property_Location)
                {
                    twoD_Location_Animator.Start();

                    twoD_Property_ComboBox.Visible = false;
                    twoD_Continued_Easing_ComboBox.Visible = false;
                    twoD_Easing_ComboBox.Visible = false;
                    twoD_Start1_Numeric.Visible = false;
                    twoD_End1_Numeric.Visible = false;
                    twoD_Duration1_Numeric.Visible = false;
                    twoD_Delay1_Numeric.Visible = false;
                    twoD_Start2_Numeric.Visible = false;
                    twoD_End2_Numeric.Visible = false;
                    twoD_Duration2_Numeric.Visible = false;
                    twoD_Delay2_Numeric.Visible = false;
                    twoD_Continued_Start1_Numeric.Visible = false;
                    twoD_Continued_End1_Numeric.Visible = false;
                    twoD_Continued_Start2_Numeric.Visible = false;
                    twoD_Continued_End2_Numeric.Visible = false;
                    twoD_Continued_Duration2_Numeric.Visible = false;
                    twoD_Continued_Delay2_Numeric.Visible = false;
                    twoD_Continued_Duration1_Numeric.Visible = false;
                    twoD_Continued_Delay1_Numeric.Visible = false;

                    twoD_Property_Label.Visible = false;
                    twoD_Continued_Easing_Label.Visible = false;
                    twoD_Easing_Label.Visible = false;
                    twoD_Start1_Label.Visible = false;
                    twoD_End1_Label.Visible = false;
                    twoD_Duration1_Label.Visible = false;
                    twoD_Delay1_Label.Visible = false;
                    twoD_Start2_Label.Visible = false;
                    twoD_End2_Label.Visible = false;
                    twoD_Duration2_Label.Visible = false;
                    twoD_Delay2_Label.Visible = false;
                    twoD_Continued_Start1_Label.Visible = false;
                    twoD_Continued_End1_Label.Visible = false;
                    twoD_Continued_Start2_Label.Visible = false;
                    twoD_Continued_End2_Label.Visible = false;
                    twoD_Continued_Duration2_Label.Visible = false;
                    twoD_Continued_Delay2_Label.Visible = false;
                    twoD_Continued_Duration1_Label.Visible = false;
                    twoD_Continued_Delay1_Label.Visible = false;
                }
                else
                {
                    twoD_Size_Animator.Start();

                    twoD_Property_ComboBox.Visible = true;
                    twoD_Continued_Easing_ComboBox.Visible = true;
                    twoD_Easing_ComboBox.Visible = true;
                    twoD_Start1_Numeric.Visible = true;
                    twoD_End1_Numeric.Visible = true;
                    twoD_Duration1_Numeric.Visible = true;
                    twoD_Delay1_Numeric.Visible = true;
                    twoD_Start2_Numeric.Visible = true;
                    twoD_End2_Numeric.Visible = true;
                    twoD_Duration2_Numeric.Visible = true;
                    twoD_Delay2_Numeric.Visible = true;
                    twoD_Continued_Start1_Numeric.Visible = true;
                    twoD_Continued_End1_Numeric.Visible = true;
                    twoD_Continued_Start2_Numeric.Visible = true;
                    twoD_Continued_End2_Numeric.Visible = true;
                    twoD_Continued_Duration2_Numeric.Visible = true;
                    twoD_Continued_Delay2_Numeric.Visible = true;
                    twoD_Continued_Duration1_Numeric.Visible = true;
                    twoD_Continued_Delay1_Numeric.Visible = true;

                    twoD_Property_Label.Visible = true;
                    twoD_Continued_Easing_Label.Visible = true;
                    twoD_Easing_Label.Visible = true;
                    twoD_Start1_Label.Visible = true;
                    twoD_End1_Label.Visible = true;
                    twoD_Duration1_Label.Visible = true;
                    twoD_Delay1_Label.Visible = true;
                    twoD_Start2_Label.Visible = true;
                    twoD_End2_Label.Visible = true;
                    twoD_Duration2_Label.Visible = true;
                    twoD_Delay2_Label.Visible = true;
                    twoD_Continued_Start1_Label.Visible = true;
                    twoD_Continued_End1_Label.Visible = true;
                    twoD_Continued_Start2_Label.Visible = true;
                    twoD_Continued_End2_Label.Visible = true;
                    twoD_Continued_Duration2_Label.Visible = true;
                    twoD_Continued_Delay2_Label.Visible = true;
                    twoD_Continued_Duration1_Label.Visible = true;
                    twoD_Continued_Delay1_Label.Visible = true;
                }

                twoD_Preview.SendToBack();
                twoD_Reset_btn.BringToFront();

                

            }

            
            

        }

        /// <summary>
        /// Handles the MouseDown event of the twoD_Preview control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void twoD_Preview_MouseDown(object sender, MouseEventArgs e)
        {
            twoD_Preview_startAnimation = true;
        }
        
        /// <summary>
        /// Handles the Click event of the twoD_Reset_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_Reset_btn_Click(object sender, EventArgs e)
        {
            
            if (twoD_Preview_startAnimation == false)
            {
                twoD_RotatingCube.Location = new Point(638, 75);
                
                twoD_Preview.BringToFront();
                twoD_Reset_btn.SendToBack();

                twoD_Property_ComboBox.Visible = true;
                twoD_Continued_Easing_ComboBox.Visible = true;
                twoD_Easing_ComboBox.Visible = true;
                twoD_Start1_Numeric.Visible = true;
                twoD_End1_Numeric.Visible = true;
                twoD_Duration1_Numeric.Visible = true;
                twoD_Delay1_Numeric.Visible = true;
                twoD_Start2_Numeric.Visible = true;
                twoD_End2_Numeric.Visible = true;
                twoD_Duration2_Numeric.Visible = true;
                twoD_Delay2_Numeric.Visible = true;
                twoD_Continued_Start1_Numeric.Visible = true;
                twoD_Continued_End1_Numeric.Visible = true;
                twoD_Continued_Start2_Numeric.Visible = true;
                twoD_Continued_End2_Numeric.Visible = true;
                twoD_Continued_Duration2_Numeric.Visible = true;
                twoD_Continued_Delay2_Numeric.Visible = true;
                twoD_Continued_Duration1_Numeric.Visible = true;
                twoD_Continued_Delay1_Numeric.Visible = true;

                twoD_Property_Label.Visible = true;
                twoD_Continued_Easing_Label.Visible = true;
                twoD_Easing_Label.Visible = true;
                twoD_Start1_Label.Visible = true;
                twoD_End1_Label.Visible = true;
                twoD_Duration1_Label.Visible = true;
                twoD_Delay1_Label.Visible = true;
                twoD_Start2_Label.Visible = true;
                twoD_End2_Label.Visible = true;
                twoD_Duration2_Label.Visible = true;
                twoD_Delay2_Label.Visible = true;
                twoD_Continued_Start1_Label.Visible = true;
                twoD_Continued_End1_Label.Visible = true;
                twoD_Continued_Start2_Label.Visible = true;
                twoD_Continued_End2_Label.Visible = true;
                twoD_Continued_Duration2_Label.Visible = true;
                twoD_Continued_Delay2_Label.Visible = true;
                twoD_Continued_Duration1_Label.Visible = true;
                twoD_Continued_Delay1_Label.Visible = true;

                mainControl_Repeat_ComboBox.SelectedIndex = No;
                mainControl_Reverse_ComboBox.SelectedIndex = No;

                
            }
            
        }

        /// <summary>
        /// Handles the MouseEnter event of the twoD_Reset_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_Reset_btn_MouseEnter(object sender, EventArgs e)
        {
            twoD_Reset_btn.FlatAppearance.BorderSize = 1;
            twoD_Reset_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the twoD_Reset_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_Reset_btn_MouseLeave(object sender, EventArgs e)
        {
            twoD_Reset_btn.FlatAppearance.BorderSize = 0;
            twoD_Reset_btn.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);
        }

        /// <summary>
        /// Handles the MouseDown event of the twoD_Reset_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void twoD_Reset_btn_MouseDown(object sender, MouseEventArgs e)
        {
            twoD_Preview_startAnimation = false;
        }

        /// <summary>
        /// Handles the Click event of the threeD_Preview control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void threeD_Preview_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Handles the ValueChanged event of the twoD_Start1_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_Start1_Numeric_ValueChanged(object sender, EventArgs e)
        {
            twoD_Location_Animator.Path2D_start_1 = (ulong)twoD_Start1_Numeric.Value;
            twoD_Size_Animator.Path2D_start_1 = (ulong)twoD_Start1_Numeric.Value;


        }

        /// <summary>
        /// Handles the ValueChanged event of the twoD_End1_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_End1_Numeric_ValueChanged(object sender, EventArgs e)
        {
            twoD_Location_Animator.Path2D_end_1 = (ulong)twoD_End1_Numeric.Value;
            twoD_Size_Animator.Path2D_end_1 = (ulong)twoD_End1_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the twoD_Duration1_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_Duration1_Numeric_ValueChanged(object sender, EventArgs e)
        {
            twoD_Location_Animator.Path2D_duration_1 = (ulong) twoD_Duration1_Numeric.Value;
            twoD_Size_Animator.Path2D_duration_1 = (ulong)twoD_Duration1_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the twoD_Delay1_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_Delay1_Numeric_ValueChanged(object sender, EventArgs e)
        {
            twoD_Location_Animator.Path2D_delay_1 = (ulong) twoD_Delay1_Numeric.Value;
            twoD_Size_Animator.Path2D_delay_1 = (ulong)twoD_Delay1_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the twoD_Start2_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_Start2_Numeric_ValueChanged(object sender, EventArgs e)
        {
            twoD_Location_Animator.Path2D_start_2 = (ulong)twoD_Start2_Numeric.Value;
            twoD_Size_Animator.Path2D_start_2 = (ulong)twoD_Start2_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the twoD_End2_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_End2_Numeric_ValueChanged(object sender, EventArgs e)
        {
            twoD_Location_Animator.Path2D_end_2 = (ulong)twoD_End2_Numeric.Value;
            twoD_Size_Animator.Path2D_end_2 = (ulong)twoD_End2_Numeric.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of the twoD_Duration2_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_Duration2_Numeric_ValueChanged(object sender, EventArgs e)
        {
            twoD_Location_Animator.Path2D_duration_2 = (ulong)twoD_Duration2_Numeric.Value;
            twoD_Size_Animator.Path2D_duration_2 = (ulong)twoD_Duration2_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the twoD_Delay2_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_Delay2_Numeric_ValueChanged(object sender, EventArgs e)
        {
            twoD_Location_Animator.Path2D_delay_2 = (ulong)twoD_Delay2_Numeric.Value;
            twoD_Size_Animator.Path2D_delay_2 = (ulong)twoD_Delay2_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the twoD_Continued_Start1_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_Continued_Start1_Numeric_ValueChanged(object sender, EventArgs e)
        {
            twoD_Location_Animator.Continued_path2D_start_1 = (ulong)twoD_Continued_Start1_Numeric.Value;
            twoD_Size_Animator.Continued_path2D_start_1 = (ulong)twoD_Continued_Start1_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the twoD_Continued_End1_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_Continued_End1_Numeric_ValueChanged(object sender, EventArgs e)
        {
            twoD_Location_Animator.Continued_path2D_end_1 = (ulong)twoD_Continued_End1_Numeric.Value;
            twoD_Size_Animator.Continued_path2D_end_1 = (ulong)twoD_Continued_End1_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the twoD_Continued_Start2_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_Continued_Start2_Numeric_ValueChanged(object sender, EventArgs e)
        {
            twoD_Location_Animator.Continued_path2D_start_2 = (ulong)twoD_Continued_Start2_Numeric.Value;
            twoD_Size_Animator.Continued_path2D_start_2 = (ulong)twoD_Continued_Start2_Numeric.Value;


        }

        /// <summary>
        /// Handles the ValueChanged event of the twoD_Continued_End2_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_Continued_End2_Numeric_ValueChanged(object sender, EventArgs e)
        {
            twoD_Location_Animator.Continued_path2D_end_2 = (ulong)twoD_Continued_End2_Numeric.Value;
            twoD_Size_Animator.Continued_path2D_end_2 = (ulong)twoD_Continued_End2_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the twoD_Continued_Duration2_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_Continued_Duration2_Numeric_ValueChanged(object sender, EventArgs e)
        {
            twoD_Location_Animator.Continued_path2D_duration_2 = (ulong)twoD_Continued_Duration2_Numeric.Value;
            twoD_Size_Animator.Continued_path2D_duration_2 = (ulong)twoD_Continued_Duration2_Numeric.Value;


        }

        /// <summary>
        /// Handles the ValueChanged event of the twoD_Continued_Delay2_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_Continued_Delay2_Numeric_ValueChanged(object sender, EventArgs e)
        {
            twoD_Location_Animator.Continued_path2D_delay_2 = (ulong)twoD_Continued_Delay2_Numeric.Value;
            twoD_Size_Animator.Continued_path2D_delay_2 = (ulong)twoD_Continued_Delay2_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the twoD_Continued_Duration1_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_Continued_Duration1_Numeric_ValueChanged(object sender, EventArgs e)
        {
            twoD_Location_Animator.Continued_path2D_duration_1 = (ulong)twoD_Continued_Duration1_Numeric.Value;
            twoD_Size_Animator.Continued_path2D_duration_1 = (ulong)twoD_Continued_Duration1_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the twoD_Continued_Delay1_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void twoD_Continued_Delay1_Numeric_ValueChanged(object sender, EventArgs e)
        {
            twoD_Location_Animator.Continued_path2D_delay_1 = (ulong)twoD_Continued_Delay1_Numeric.Value;
            twoD_Size_Animator.Continued_path2D_delay_1 = (ulong)twoD_Continued_Delay1_Numeric.Value;


        }
    }
}
