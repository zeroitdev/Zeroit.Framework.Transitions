// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="PizaroAnimatorDialog.cs" company="Zeroit Dev Technologies">
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
using static Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnimEdit;

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    /// Class ZeroitPizaroAnimatorDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ZeroitPizaroAnimatorDialog : System.Windows.Forms.Form
    {

        #region Imported User Controls

        /// <summary>
        /// The pizaro fade user control
        /// </summary>
        Pizaro_Fade_UserControl pizaro_Fade_UserControl = new Pizaro_Fade_UserControl();
        /// <summary>
        /// The pizaro fade in user control
        /// </summary>
        Pizaro_FadeIn_UserControl pizaro_FadeIn_UserControl = new Pizaro_FadeIn_UserControl();
        /// <summary>
        /// The pizaro fade in and show user control
        /// </summary>
        Pizaro_FadeInAndShow_UserControl pizaro_FadeInAndShow_UserControl = new Pizaro_FadeInAndShow_UserControl();
        /// <summary>
        /// The pizaro fade out user control
        /// </summary>
        Pizaro_FadeOut_UserControl pizaro_FadeOut_UserControl = new Pizaro_FadeOut_UserControl();
        /// <summary>
        /// The pizaro fade outand hide user control
        /// </summary>
        Pizaro_FadeOutandHide_UserControl pizaro_FadeOutandHide_UserControl = new Pizaro_FadeOutandHide_UserControl();
        /// <summary>
        /// The pizaro resize user control
        /// </summary>
        Pizaro_Resize_UserControl pizaro_Resize_UserControl = new Pizaro_Resize_UserControl();
        /// <summary>
        /// The pizaro resize height user control
        /// </summary>
        Pizaro_ResizeHeight_UserControl pizaro_ResizeHeight_UserControl = new Pizaro_ResizeHeight_UserControl();
        /// <summary>
        /// The pizaro resize width user control
        /// </summary>
        Pizaro_ResizeWidth_UserControl pizaro_ResizeWidth_UserControl = new Pizaro_ResizeWidth_UserControl();
        /// <summary>
        /// The pizaro slide user control
        /// </summary>
        Pizaro_Slide_UserControl pizaro_Slide_UserControl = new Pizaro_Slide_UserControl();
        /// <summary>
        /// The pizaro slide from user control
        /// </summary>
        Pizaro_SlideFrom_UserControl pizaro_SlideFrom_UserControl = new Pizaro_SlideFrom_UserControl();

        #endregion

        #region Private Fields


        #region Constants

        /// <summary>
        /// The pizaro fade
        /// </summary>
        private const int Pizaro_Fade = 0;
        /// <summary>
        /// The pizaro fade in
        /// </summary>
        private const int Pizaro_FadeIn = 1;
        /// <summary>
        /// The pizaro fade in and show
        /// </summary>
        private const int Pizaro_FadeInAndShow = 2;
        /// <summary>
        /// The pizaro fade out
        /// </summary>
        private const int Pizaro_FadeOut = 3;
        /// <summary>
        /// The pizaro fade outand hide
        /// </summary>
        private const int Pizaro_FadeOutandHide = 4;
        /// <summary>
        /// The pizaro resize
        /// </summary>
        private const int Pizaro_Resize = 5;
        /// <summary>
        /// The pizaro resize height
        /// </summary>
        private const int Pizaro_ResizeHeight = 6;
        /// <summary>
        /// The pizaro resize width
        /// </summary>
        private const int Pizaro_ResizeWidth = 7;
        /// <summary>
        /// The pizaro slide
        /// </summary>
        private const int Pizaro_Slide = 8;
        /// <summary>
        /// The pizaro slide from
        /// </summary>
        private const int Pizaro_SlideFrom = 9;
        /// <summary>
        /// The pizaro none
        /// </summary>
        private const int Pizaro_None = 10;

        /// <summary>
        /// The back ease in
        /// </summary>
        private const int BackEaseIn = 0;
        /// <summary>
        /// The back ease in out
        /// </summary>
        private const int BackEaseInOut = 1;
        /// <summary>
        /// The back ease out
        /// </summary>
        private const int BackEaseOut = 2;
        /// <summary>
        /// The back ease out in
        /// </summary>
        private const int BackEaseOutIn = 3;
        /// <summary>
        /// The bounce ease in
        /// </summary>
        private const int BounceEaseIn = 4;
        /// <summary>
        /// The bounce ease in out
        /// </summary>
        private const int BounceEaseInOut = 5;
        /// <summary>
        /// The bounce ease out
        /// </summary>
        private const int BounceEaseOut = 6;
        /// <summary>
        /// The bounce ease out in
        /// </summary>
        private const int BounceEaseOutIn = 7;
        /// <summary>
        /// The ease in
        /// </summary>
        private const int EaseIn = 8;
        /// <summary>
        /// The ease in and out
        /// </summary>
        private const int EaseInAndOut = 9;
        /// <summary>
        /// The ease in circ
        /// </summary>
        private const int EaseInCirc = 10;
        /// <summary>
        /// The ease in cubic
        /// </summary>
        private const int EaseInCubic = 11;
        /// <summary>
        /// The ease in expo
        /// </summary>
        private const int EaseInExpo = 12;
        /// <summary>
        /// The ease in out circ
        /// </summary>
        private const int EaseInOutCirc = 13;
        /// <summary>
        /// The ease in out cubic
        /// </summary>
        private const int EaseInOutCubic = 14;
        /// <summary>
        /// The ease in out expo
        /// </summary>
        private const int EaseInOutExpo = 15;
        /// <summary>
        /// The ease in out quad
        /// </summary>
        private const int EaseInOutQuad = 16;
        /// <summary>
        /// The ease in out quart
        /// </summary>
        private const int EaseInOutQuart = 17;
        /// <summary>
        /// The ease in out quint
        /// </summary>
        private const int EaseInOutQuint = 18;
        /// <summary>
        /// The ease in out sine
        /// </summary>
        private const int EaseInOutSine = 19;
        /// <summary>
        /// The ease in quad
        /// </summary>
        private const int EaseInQuad = 20;
        /// <summary>
        /// The ease in quart
        /// </summary>
        private const int EaseInQuart = 21;
        /// <summary>
        /// The ease in quint
        /// </summary>
        private const int EaseInQuint = 22;
        /// <summary>
        /// The ease in sine
        /// </summary>
        private const int EaseInSine = 23;
        /// <summary>
        /// The ease out
        /// </summary>
        private const int EaseOut = 24;
        /// <summary>
        /// The ease out circ
        /// </summary>
        private const int EaseOutCirc = 25;
        /// <summary>
        /// The ease out cubic
        /// </summary>
        private const int EaseOutCubic = 26;
        /// <summary>
        /// The ease out expo
        /// </summary>
        private const int EaseOutExpo = 27;
        /// <summary>
        /// The ease out quad
        /// </summary>
        private const int EaseOutQuad = 28;
        /// <summary>
        /// The ease out quart
        /// </summary>
        private const int EaseOutQuart = 29;
        /// <summary>
        /// The ease out quint
        /// </summary>
        private const int EaseOutQuint = 30;
        /// <summary>
        /// The ease out sine
        /// </summary>
        private const int EaseOutSine = 31;
        /// <summary>
        /// The elastic ease in
        /// </summary>
        private const int ElasticEaseIn = 32;
        /// <summary>
        /// The elastic ease in out
        /// </summary>
        private const int ElasticEaseInOut = 33;
        /// <summary>
        /// The elastic ease out
        /// </summary>
        private const int ElasticEaseOut = 34;
        /// <summary>
        /// The elastic ease out in
        /// </summary>
        private const int ElasticEaseOutIn = 35;
        /// <summary>
        /// The linear
        /// </summary>
        private const int Linear = 36;
        /// <summary>
        /// The linear tween
        /// </summary>
        private const int LinearTween = 37;

        #region Easing Ifs
        //if(generalContainer_Easing_ComboBox.SelectedIndex == BackEaseIn)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == BackEaseInOut)
        //{

        //}
        //if (generalContainer_Easing_ComboBox.SelectedIndex == BackEaseOut)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == BackEaseOutIn)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == BounceEaseIn)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == BounceEaseInOut)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == BounceEaseOut)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == BounceEaseOutIn)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseIn)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInAndOut)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInCirc)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInCubic)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInExpo)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutCirc)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutCubic)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutExpo)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutQuad)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutQuart)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutQuint)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutSine)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInQuad)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInQuart)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInQuint)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInSine)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOut)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutCirc)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutCubic)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutExpo)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutQuad)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutQuart)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutQuint)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutSine)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == ElasticEaseIn)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == ElasticEaseInOut)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == ElasticEaseOut)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == ElasticEaseOutIn)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == Linear)
        //{

        //}
        //else if (generalContainer_Easing_ComboBox.SelectedIndex == LinearTween)
        //{

        //} 
        #endregion

        #endregion

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// at the default window position.
        /// </summary>
        public ZeroitPizaroAnimatorDialog() : this(ZeroitPizaroAnimatorInput.Empty())
        {
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// at the default window position.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        /// <exception cref="ArgumentNullException">pizaroAnimatorInput</exception>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="peaceInput" /> is null.</exception>
        public ZeroitPizaroAnimatorDialog(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            if (pizaroAnimatorInput == null)
            {
                throw new ArgumentNullException("pizaroAnimatorInput");
            }


            InitializeComponent();


            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            //SetControl_FormAnimation_To_Initial_Values(pizaroAnimatorInput);
            //SetControl_StandardAnimation_To_Initial_Values(pizaroAnimatorInput);

            //AdjustDialogSize();
            SetInitial_Values(pizaroAnimatorInput);


            Set_Fade_Initial_Values(pizaroAnimatorInput);
            Set_FadeIn_Initial_Values(pizaroAnimatorInput);
            Set_FadeInAndShow_Initial_Values(pizaroAnimatorInput);
            Set_FadeOut_Initial_Values(pizaroAnimatorInput);
            Set_FadeOutandHide_Initial_Values(pizaroAnimatorInput);

            Set_Resize_Initial_Values(pizaroAnimatorInput);
            Set_ResizeWidth_Initial_Values(pizaroAnimatorInput);
            Set_ResizeHeight_Initial_Values(pizaroAnimatorInput);

            Set_Slide_Initial_Values(pizaroAnimatorInput);
            Set_SlideFrom_Initial_Values(pizaroAnimatorInput);


        }


        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        public ZeroitPizaroAnimatorDialog(Control c) : this(ZeroitPizaroAnimatorInput.Empty(), c)
        {
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="filler" /> is null.</exception>
        public ZeroitPizaroAnimatorDialog(ZeroitPizaroAnimatorInput pizaroAnimatorInput, Control c) : this(pizaroAnimatorInput)
        {
            Zeroit.Framework.Transitions.AnimationEditors.Utilities.Draw.SetStartPositionBelowControl(this, c);
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// The pizaro animator input
        /// </summary>
        private ZeroitPizaroAnimatorInput pizaroAnimatorInput;

        /// <summary>
        /// Gets the zeroit pizaro animator input.
        /// </summary>
        /// <value>The zeroit pizaro animator input.</value>
        public ZeroitPizaroAnimatorInput ZeroitPizaroAnimatorInput
        {
            get { return pizaroAnimatorInput; }
        }


        #endregion

        #region Private Methods

        /// <summary>
        /// Mains the container value sets.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void MainContainerValueSets(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            generalContainer_Control_Name_Label.Text = pizaroAnimatorInput.Control.Name;
            
            #region Easing


            if (pizaroAnimatorInput.EasingNames == easingNames.BackEaseIn)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = BackEaseIn;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.BackEaseInOut)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = BackEaseInOut;
            }
            if (pizaroAnimatorInput.EasingNames == easingNames.BackEaseOut)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = BackEaseOut;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.BackEaseOutIn)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = BackEaseOutIn;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.BounceEaseIn)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = BounceEaseIn;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.BounceEaseInOut)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = BounceEaseInOut;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.BounceEaseOut)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = BounceEaseOut;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.BounceEaseOutIn)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = BounceEaseOutIn;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseIn)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseIn;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseInAndOut)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseInAndOut;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseInCirc)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseInCirc;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseInCubic)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseInCubic;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseInExpo)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseInExpo;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseInOutCirc)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseInOutCirc;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseInOutCubic)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseInOutCubic;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseInOutExpo)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseInOutExpo;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseInOutQuad)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseInOutQuad;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseInOutQuart)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseInOutQuart;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseInOutQuint)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseInOutQuint;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseInOutSine)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseInOutSine;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseInQuad)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseInQuad;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseInQuart)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseInQuart;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseInQuint)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseInQuint;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseInSine)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseInSine;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseOut)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseOut;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseOutCirc)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseOutCirc;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseOutCubic)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseOutCubic;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseOutExpo)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseOutExpo;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseOutQuad)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseOutQuad;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseOutQuart)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseOutQuart;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseOutQuint)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseOutQuint;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.EaseOutSine)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = EaseOutSine;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.ElasticEaseIn)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = ElasticEaseIn;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.ElasticEaseInOut)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = ElasticEaseInOut;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.ElasticEaseOut)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = ElasticEaseOut;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.ElasticEaseOutIn)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = ElasticEaseOutIn;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.Linear)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = Linear;
            }
            else if (pizaroAnimatorInput.EasingNames == easingNames.LinearTween)
            {
                generalContainer_Easing_ComboBox.SelectedIndex = LinearTween;
            }
            #endregion

            #region Control

            //foreach (var controlNames in pizaroAnimatorInput.Control.FindForm().Controls)
            //{
            //    generalContainer_Control_ComboBox.Items.Add(controlNames);

            //}
            //generalContainer_Control_ComboBox.Items.Add(pizaroAnimatorInput.Control.FindForm());


            //for (int i = 0; i < generalContainer_Control_ComboBox.Items.Count; i++)
            //{
            //    if (pizaroAnimatorInput.Control == (Control)(generalContainer_Control_ComboBox.Items[i]))
            //    {
            //        generalContainer_Control_ComboBox.SelectedIndex = i;
                    
            //    }

            //}
            #endregion

            #region Animation Type

            if (pizaroAnimatorInput.AnimationType == animationType.Fade)
            {

                generalContainer_AnimationType_ComboBox.SelectedIndex = Pizaro_Fade;

                

            }
            else if (pizaroAnimatorInput.AnimationType == animationType.FadeIn)
            {
                generalContainer_AnimationType_ComboBox.SelectedIndex = Pizaro_FadeIn;

                

            }
            else if (pizaroAnimatorInput.AnimationType == animationType.FadeInAndShow)
            {
                generalContainer_AnimationType_ComboBox.SelectedIndex = Pizaro_FadeInAndShow;

                

            }
            else if (pizaroAnimatorInput.AnimationType == animationType.FadeOut)
            {
                generalContainer_AnimationType_ComboBox.SelectedIndex = Pizaro_FadeOut;

                

            }
            else if (pizaroAnimatorInput.AnimationType == animationType.FadeOutandHide)
            {
                generalContainer_AnimationType_ComboBox.SelectedIndex = Pizaro_FadeOutandHide;

                

            }
            else if (pizaroAnimatorInput.AnimationType == animationType.Resize)
            {
                generalContainer_AnimationType_ComboBox.SelectedIndex = Pizaro_Resize;

            }
            else if (pizaroAnimatorInput.AnimationType == animationType.ResizeWidth)
            {
                generalContainer_AnimationType_ComboBox.SelectedIndex = Pizaro_ResizeWidth;

            }
            else if (pizaroAnimatorInput.AnimationType == animationType.ResizeHeight)
            {
                generalContainer_AnimationType_ComboBox.SelectedIndex = Pizaro_ResizeHeight;

            }
            else if (pizaroAnimatorInput.AnimationType == animationType.Slide)
            {
                generalContainer_AnimationType_ComboBox.SelectedIndex = Pizaro_Slide;

            }
            else
            {
                pizaroAnimatorInput.AnimationType = animationType.SlideFrom;
            }
            #endregion

            #region Values

            generalContainer_EasingStart_Numeric.Value = (decimal)pizaroAnimatorInput.EasingStart;
            generalContainer_EasingEnd_Numeric.Value = (decimal)pizaroAnimatorInput.EasingEnd;
            generalContainer_Acceleration_Numeric.Value = (decimal)pizaroAnimatorInput.Acceleration;
            generalContainer_Duration_Numeric.Value = (decimal)pizaroAnimatorInput.Duration;
            #endregion
        }

        /// <summary>
        /// Mains the container value retrieved.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void MainContainer_ValueRetrieved(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            pizaroAnimatorInput.Control = (Control)generalContainer_Control_ComboBox.SelectedItem;

            #region Easing
            //generalContainer_Easing_ComboBox.SelectedIndex == BackEaseIn

            if (generalContainer_Easing_ComboBox.SelectedIndex == BackEaseIn)
            {
                pizaroAnimatorInput.EasingNames = easingNames.BackEaseIn;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == BackEaseInOut)
            {
                pizaroAnimatorInput.EasingNames = easingNames.BackEaseInOut;
            }
            if (generalContainer_Easing_ComboBox.SelectedIndex == BackEaseOut)
            {
                pizaroAnimatorInput.EasingNames = easingNames.BackEaseOut;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == BackEaseOutIn)
            {
                pizaroAnimatorInput.EasingNames = easingNames.BackEaseOutIn;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == BounceEaseIn)
            {
                pizaroAnimatorInput.EasingNames = easingNames.BounceEaseIn;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == BounceEaseInOut)
            {
                pizaroAnimatorInput.EasingNames = easingNames.BackEaseIn;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == BounceEaseOut)
            {
                pizaroAnimatorInput.EasingNames = easingNames.BounceEaseOut;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == BounceEaseOutIn)
            {
                pizaroAnimatorInput.EasingNames = easingNames.BounceEaseOutIn;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseIn)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseIn;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInAndOut)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseInAndOut;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInCirc)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseInCirc;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInCubic)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseInCubic;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInExpo)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseInExpo;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutCirc)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseInOutCirc;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutCubic)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseInOutCubic;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutExpo)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseInOutExpo;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutQuad)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseInOutQuad;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutQuart)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseInOutQuart;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutQuint)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseInOutQuint;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutSine)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseInOutSine;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInQuad)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseInQuad;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInQuart)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseInQuart;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInQuint)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseInQuint;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInSine)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseInSine;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOut)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseOut;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutCirc)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseOutCirc;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutCubic)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseOutCubic;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutExpo)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseOutExpo;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutQuad)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseOutQuad;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutQuart)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseOutQuart;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutQuint)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseOutQuint;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutSine)
            {
                pizaroAnimatorInput.EasingNames = easingNames.EaseOutSine;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == ElasticEaseIn)
            {
                pizaroAnimatorInput.EasingNames = easingNames.ElasticEaseIn;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == ElasticEaseInOut)
            {
                pizaroAnimatorInput.EasingNames = easingNames.ElasticEaseInOut;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == ElasticEaseOut)
            {
                pizaroAnimatorInput.EasingNames = easingNames.ElasticEaseOut;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == ElasticEaseOutIn)
            {
                pizaroAnimatorInput.EasingNames = easingNames.ElasticEaseOutIn;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == Linear)
            {
                pizaroAnimatorInput.EasingNames = easingNames.Linear;
            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == LinearTween)
            {
                pizaroAnimatorInput.EasingNames = easingNames.LinearTween;
            }
            #endregion

            #region Values

            pizaroAnimatorInput.EasingStart = (float)generalContainer_EasingStart_Numeric.Value;
            pizaroAnimatorInput.EasingEnd = (float)generalContainer_EasingEnd_Numeric.Value;
            pizaroAnimatorInput.Acceleration = (float)generalContainer_Acceleration_Numeric.Value;
            pizaroAnimatorInput.Duration = (int)generalContainer_Duration_Numeric.Value;

            #endregion
        }

        /// <summary>
        /// Properties the type changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void PropertyTypeChanged(object sender, EventArgs e)
        {

            thematic1501.Controls.Add(pizaro_Fade_UserControl);
            thematic1501.Controls.Add(pizaro_FadeIn_UserControl);
            thematic1501.Controls.Add(pizaro_FadeInAndShow_UserControl);
            thematic1501.Controls.Add(pizaro_FadeOut_UserControl);
            thematic1501.Controls.Add(pizaro_FadeOutandHide_UserControl);
            thematic1501.Controls.Add(pizaro_Resize_UserControl);
            thematic1501.Controls.Add(pizaro_ResizeHeight_UserControl);
            thematic1501.Controls.Add(pizaro_ResizeWidth_UserControl);
            thematic1501.Controls.Add(pizaro_Slide_UserControl);
            thematic1501.Controls.Add(pizaro_SlideFrom_UserControl);

            pizaro_Fade_UserControl.Visible = false;
            pizaro_FadeIn_UserControl.Visible = false;
            pizaro_FadeInAndShow_UserControl.Visible = false;
            pizaro_FadeOut_UserControl.Visible = false;
            pizaro_FadeOutandHide_UserControl.Visible = false;
            pizaro_Resize_UserControl.Visible = false;
            pizaro_ResizeHeight_UserControl.Visible = false;
            pizaro_ResizeWidth_UserControl.Visible = false;
            pizaro_Slide_UserControl.Visible = false;
            pizaro_SlideFrom_UserControl.Visible = false;

            pizaro_Fade_UserControl.Hide();
            pizaro_FadeIn_UserControl.Hide();
            pizaro_FadeInAndShow_UserControl.Hide();
            pizaro_FadeOut_UserControl.Hide();
            pizaro_FadeOutandHide_UserControl.Hide();
            pizaro_Resize_UserControl.Hide();
            pizaro_ResizeHeight_UserControl.Hide();
            pizaro_ResizeWidth_UserControl.Hide();
            pizaro_Slide_UserControl.Hide();
            pizaro_SlideFrom_UserControl.Hide();

            fade_preview_Panel.Visible = false;
            fade_Preview_btn.Visible = false;

            if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Fade)
            {

                
                pizaro_Fade_UserControl.Visible = true;
                pizaro_Fade_UserControl.Location = new Point(383, 24);                
                pizaro_Fade_UserControl.BringToFront();
                pizaro_Fade_UserControl.Show();

                fade_preview_Panel.Visible = true;
                fade_Preview_btn.Visible = true;


            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeIn)
            {
                
                pizaro_FadeIn_UserControl.Visible = true;
                pizaro_FadeIn_UserControl.Location = new Point(383, 24);                
                pizaro_FadeIn_UserControl.Show();

                fade_preview_Panel.Visible = true;
                fade_Preview_btn.Visible = true;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeInAndShow)
            {
                
                pizaro_FadeInAndShow_UserControl.Visible = true;
                pizaro_FadeInAndShow_UserControl.Location = new Point(383, 24);
                //pizaro_FadeInAndShow_UserControl.Size = new Size(799, 260);
                pizaro_FadeInAndShow_UserControl.Show();

                fade_preview_Panel.Visible = true;
                fade_Preview_btn.Visible = true;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOut)
            {
                
                pizaro_FadeOut_UserControl.Visible = true;
                pizaro_FadeOut_UserControl.Location = new Point(383, 24);
                //pizaro_FadeOut_UserControl.Size = new Size(799, 260);
                pizaro_FadeOut_UserControl.Show();

                fade_preview_Panel.Visible = true;

                fade_Preview_btn.Visible = true;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOutandHide)
            {
                pizaro_FadeOutandHide_UserControl.Visible = true;
                pizaro_FadeOutandHide_UserControl.Location = new Point(383, 24);
                //pizaro_FadeOutandHide_UserControl.Size = new Size(799, 260);
                pizaro_FadeOutandHide_UserControl.Show();

                fade_preview_Panel.Visible = true;
                fade_Preview_btn.Visible = true;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Resize)
            {
                pizaro_Resize_UserControl.Visible = true;
                pizaro_Resize_UserControl.Location = new Point(383, 24);
                //pizaro_Resize_UserControl.Size = new Size(799, 260);
                pizaro_Resize_UserControl.Show();

                
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeWidth)
            {
                pizaro_ResizeWidth_UserControl.Visible = true;
                pizaro_ResizeWidth_UserControl.Location = new Point(383, 24);
                //pizaro_ResizeWidth_UserControl.Size = new Size(799, 260);
                pizaro_ResizeWidth_UserControl.Show();
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeHeight)
            {
                pizaro_ResizeHeight_UserControl.Visible = true;
                pizaro_ResizeHeight_UserControl.Location = new Point(383, 24);
                //pizaro_ResizeHeight_UserControl.Size = new Size(799, 260);
                pizaro_ResizeHeight_UserControl.Show();
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Slide)
            {
                pizaro_Slide_UserControl.Visible = true;
                pizaro_Slide_UserControl.Location = new Point(383, 24);
                //pizaro_Slide_UserControl.Size = new Size(799, 260);
                pizaro_Slide_UserControl.Show();
            }
            else if(generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_SlideFrom)
            {
                pizaro_SlideFrom_UserControl.Visible = true;
                pizaro_SlideFrom_UserControl.Location = new Point(383, 24);
                //pizaro_SlideFrom_UserControl.Size = new Size(799, 260);
                pizaro_SlideFrom_UserControl.Show();
            }
            else 
            {
                pizaro_Fade_UserControl.Visible = false;
                pizaro_FadeIn_UserControl.Visible = false;
                pizaro_FadeInAndShow_UserControl.Visible = false;
                pizaro_FadeOut_UserControl.Visible = false;
                pizaro_FadeOutandHide_UserControl.Visible = false;
                pizaro_Resize_UserControl.Visible = false;
                pizaro_ResizeHeight_UserControl.Visible = false;
                pizaro_ResizeWidth_UserControl.Visible = false;
                pizaro_Slide_UserControl.Visible = false;
                pizaro_SlideFrom_UserControl.Visible = false;

                pizaro_Fade_UserControl.Hide();
                pizaro_FadeIn_UserControl.Hide();
                pizaro_FadeInAndShow_UserControl.Hide();
                pizaro_FadeOut_UserControl.Hide();
                pizaro_FadeOutandHide_UserControl.Hide();
                pizaro_Resize_UserControl.Hide();
                pizaro_ResizeHeight_UserControl.Hide();
                pizaro_ResizeWidth_UserControl.Hide();
                pizaro_Slide_UserControl.Hide();
                pizaro_SlideFrom_UserControl.Hide();

                fade_preview_Panel.Visible = false;
                fade_Preview_btn.Visible = false;
            }
        }

        /// <summary>
        /// Sets the initial values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void SetInitial_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            generalContainer_AnimationType_ComboBox.SelectedIndex = (int)pizaroAnimatorInput.AnimationType;
            generalContainer_Easing_ComboBox.SelectedIndex = (int)pizaroAnimatorInput.EasingNames;

            generalContainer_Control_Name_Label.Text = pizaroAnimatorInput.Control.Name;


            #region Animationtype


            generalContainer_AnimationType_ComboBox.SelectedIndex = 0;
            for (int i = 0; i < generalContainer_AnimationType_ComboBox.Items.Count; i++)
            {
                if (pizaroAnimatorInput.AnimationType.ToString() == (string)(generalContainer_AnimationType_ComboBox.Items[i]))
                {
                    generalContainer_AnimationType_ComboBox.SelectedIndex = i;
                }

            }
            #endregion

            #region Control

            foreach (var controlNames in pizaroAnimatorInput.Control.FindForm().Controls)
            {
                generalContainer_Control_ComboBox.Items.Add(controlNames);

            }
            generalContainer_Control_ComboBox.Items.Add(pizaroAnimatorInput.Control.FindForm());


            for (int i = 0; i < generalContainer_Control_ComboBox.Items.Count; i++)
            {
                if (pizaroAnimatorInput.Control == (Control)(generalContainer_Control_ComboBox.Items[i]))
                {
                    generalContainer_Control_ComboBox.SelectedIndex = i;
                    
                }

            }
            #endregion

            #region Easing

            //generalContainer_Easing_ComboBox.SelectedIndex = 0;
            //for (int i = 0; i < generalContainer_Easing_ComboBox.Items.Count; i++)
            //{
            //    if (pizaroAnimatorInput.EasingNames.ToString() == (string)(generalContainer_Easing_ComboBox.Items[i]))
            //    {
            //        generalContainer_Easing_ComboBox.SelectedIndex = i;
            //    }

            //}
            #endregion

            #region Value Sets
            pizaro_Fade_UserControl.fade_Begin_Numeric.Value = (decimal)pizaroAnimatorInput.Fade_Begin;
            pizaro_Fade_UserControl.fade_Limit_Numeric.Value = (decimal)pizaroAnimatorInput.Fade_Limit;

            fade_Animator.Fade_Begin = pizaroAnimatorInput.Fade_Begin;
            fade_Animator.Fade_Limit = pizaroAnimatorInput.Fade_Limit;

            pizaro_FadeIn_UserControl.fadeIn_Begin_Numeric.Value = (decimal)pizaroAnimatorInput.Fade_Begin;
            pizaro_FadeIn_UserControl.fadeIn_Limit_Numeric.Value = (decimal)pizaroAnimatorInput.Fade_Limit;

            fadeIn_Animator.Fade_Begin = pizaroAnimatorInput.Fade_Begin;
            fadeIn_Animator.Fade_Limit = pizaroAnimatorInput.Fade_Limit;
            

            pizaro_FadeInAndShow_UserControl.fadeInAndShow_Begin_Numeric.Value = (decimal)pizaroAnimatorInput.Fade_Begin;
            pizaro_FadeInAndShow_UserControl.fadeInAndShow_Limit_Numeric.Value = (decimal)pizaroAnimatorInput.Fade_Limit;

            fadeInAndShow_Animator.Fade_Begin = pizaroAnimatorInput.Fade_Begin;
            fadeInAndShow_Animator.Fade_Limit = pizaroAnimatorInput.Fade_Limit;

            pizaro_FadeOut_UserControl.fadeOut_Begin_Numeric.Value = (decimal)pizaroAnimatorInput.Fade_Begin;
            pizaro_FadeOut_UserControl.fadeOut_Limit_Numeric.Value = (decimal)pizaroAnimatorInput.Fade_Limit;

            fadeOut_Animator.Fade_Begin = pizaroAnimatorInput.Fade_Begin;
            fadeOut_Animator.Fade_Limit = pizaroAnimatorInput.Fade_Limit;

            pizaro_FadeOutandHide_UserControl.fadeOutandHide_Begin_Numeric.Value = (decimal)pizaroAnimatorInput.Fade_Begin;
            pizaro_FadeOutandHide_UserControl.fadeOutandHide_Limit_Numeric.Value = (decimal)pizaroAnimatorInput.Fade_Limit;

            fadeOutAndHide_Animator.Fade_Begin = pizaroAnimatorInput.Fade_Begin;
            fadeOutAndHide_Animator.Fade_Limit = pizaroAnimatorInput.Fade_Limit;

            pizaro_Resize_UserControl.resize_StartX_Numeric.Value = (decimal)pizaroAnimatorInput.CordinateStart_X;
            pizaro_Resize_UserControl.resize_StartY_Numeric.Value = (decimal)pizaroAnimatorInput.CordinateStart_Y;
            pizaro_Resize_UserControl.resize_EndX_Numeric.Value = (decimal)pizaroAnimatorInput.CordinateEnd_X;
            pizaro_Resize_UserControl.resize_EndY_Numeric.Value = (decimal)pizaroAnimatorInput.CordinateEnd_Y;

            pizaro_Resize_UserControl.resize_Animator.CordinateStart_X = (float)pizaroAnimatorInput.CordinateStart_X;
            pizaro_Resize_UserControl.resize_Animator.CordinateStart_Y = (float)pizaroAnimatorInput.CordinateStart_Y;
            pizaro_Resize_UserControl.resize_Animator.CordinateEnd_X = (float)pizaroAnimatorInput.CordinateEnd_X;
            pizaro_Resize_UserControl.resize_Animator.CordinateEnd_X = (float)pizaroAnimatorInput.CordinateEnd_Y;

            pizaro_ResizeWidth_UserControl.resizeWidth_Begin_Numeric.Value = (decimal)pizaroAnimatorInput.ResizeWidth_Begin;
            pizaro_ResizeWidth_UserControl.resizeWidth_Limit_Numeric.Value = (decimal)pizaroAnimatorInput.ResizeWidth_Limit;

            pizaro_ResizeWidth_UserControl.resizeWidth_Animator.ResizeWidth_Begin = (float)pizaroAnimatorInput.ResizeWidth_Begin;
            pizaro_ResizeWidth_UserControl.resizeWidth_Animator.ResizeWidth_Begin = (float)pizaroAnimatorInput.ResizeWidth_Limit;

            pizaro_ResizeHeight_UserControl.resizeHeight_Begin_Numeric.Value = (decimal)pizaroAnimatorInput.ResizeHeight_Begin;
            pizaro_ResizeHeight_UserControl.resizeHeight_Limit_Numeric.Value = (decimal)pizaroAnimatorInput.ResizeHeight_Limit;

            pizaro_ResizeHeight_UserControl.resizeHeight_Animator.ResizeHeight_Begin = (float)pizaroAnimatorInput.ResizeHeight_Begin;
            pizaro_ResizeHeight_UserControl.resizeHeight_Animator.ResizeHeight_Begin = (float)pizaroAnimatorInput.ResizeHeight_Limit;


            pizaro_Slide_UserControl.slide_StartX_Numeric.Value = (decimal)pizaroAnimatorInput.CordinateStart_X;
            pizaro_Slide_UserControl.slide_StartY_Numeric.Value = (decimal)pizaroAnimatorInput.CordinateStart_Y;
            pizaro_Slide_UserControl.slide_EndX_Numeric.Value = (decimal)pizaroAnimatorInput.CordinateEnd_X;
            pizaro_Slide_UserControl.slide_EndY_Numeric.Value = (decimal)pizaroAnimatorInput.CordinateEnd_Y;

            pizaro_Slide_UserControl.slide_Animator.CordinateStart_X = (float)pizaroAnimatorInput.CordinateStart_X;
            pizaro_Slide_UserControl.slide_Animator.CordinateStart_Y = (float)pizaroAnimatorInput.CordinateStart_Y;
            pizaro_Slide_UserControl.slide_Animator.CordinateEnd_X = (float)pizaroAnimatorInput.CordinateEnd_X;
            pizaro_Slide_UserControl.slide_Animator.CordinateEnd_Y = (float)pizaroAnimatorInput.CordinateEnd_Y;

            pizaro_SlideFrom_UserControl.slideFrom_StartX_Numeric.Value = (decimal)pizaroAnimatorInput.CordinateStart_X;
            pizaro_SlideFrom_UserControl.slideFrom_StartY_Numeric.Value = (decimal)pizaroAnimatorInput.CordinateStart_Y;
            pizaro_SlideFrom_UserControl.slideFrom_EndX_Numeric.Value = (decimal)pizaroAnimatorInput.CordinateEnd_X;
            pizaro_SlideFrom_UserControl.slideFrom_EndY_Numeric.Value = (decimal)pizaroAnimatorInput.CordinateEnd_Y;

            pizaro_SlideFrom_UserControl.slideFrom_Animator.CordinateStart_X = (float)pizaroAnimatorInput.CordinateStart_X;
            pizaro_SlideFrom_UserControl.slideFrom_Animator.CordinateStart_Y = (float)pizaroAnimatorInput.CordinateStart_Y;
            pizaro_SlideFrom_UserControl.slideFrom_Animator.CordinateEnd_X = (float)pizaroAnimatorInput.CordinateEnd_X;
            pizaro_SlideFrom_UserControl.slideFrom_Animator.CordinateEnd_Y = (float)pizaroAnimatorInput.CordinateEnd_Y;

            #endregion

            #region Events

            pizaro_Fade_UserControl.fade_Begin_Numeric.ValueChanged += Fade_Begin_Numeric_ValueChanged;
            pizaro_Fade_UserControl.fade_Limit_Numeric.ValueChanged += Fade_Limit_Numeric_ValueChanged;


            pizaro_FadeIn_UserControl.fadeIn_Begin_Numeric.ValueChanged += FadeIn_Begin_Numeric_ValueChanged;
            pizaro_FadeIn_UserControl.fadeIn_Limit_Numeric.ValueChanged += FadeIn_Limit_Numeric_ValueChanged;


            pizaro_FadeInAndShow_UserControl.fadeInAndShow_Begin_Numeric.ValueChanged += FadeInAndShow_Begin_Numeric_ValueChanged;
            pizaro_FadeInAndShow_UserControl.fadeInAndShow_Limit_Numeric.ValueChanged += FadeInAndShow_Limit_Numeric_ValueChanged;


            pizaro_FadeOut_UserControl.fadeOut_Begin_Numeric.ValueChanged += FadeOut_Begin_Numeric_ValueChanged;
            pizaro_FadeOut_UserControl.fadeOut_Limit_Numeric.ValueChanged += FadeOut_Limit_Numeric_ValueChanged;


            pizaro_FadeOutandHide_UserControl.fadeOutandHide_Begin_Numeric.ValueChanged += FadeOutandHide_Begin_Numeric_ValueChanged;
            pizaro_FadeOutandHide_UserControl.fadeOutandHide_Limit_Numeric.ValueChanged += FadeOutandHide_Limit_Numeric_ValueChanged;

            pizaro_Resize_UserControl.resize_StartX_Numeric.ValueChanged += Resize_StartX_Numeric_ValueChanged;
            pizaro_Resize_UserControl.resize_StartY_Numeric.ValueChanged += Resize_StartY_Numeric_ValueChanged;
            pizaro_Resize_UserControl.resize_EndX_Numeric.ValueChanged += Resize_EndX_Numeric_ValueChanged;
            pizaro_Resize_UserControl.resize_EndY_Numeric.ValueChanged += Resize_EndY_Numeric_ValueChanged;

            pizaro_ResizeHeight_UserControl.resizeHeight_Begin_Numeric.ValueChanged += ResizeHeight_Begin_Numeric_ValueChanged;
            pizaro_ResizeHeight_UserControl.resizeHeight_Limit_Numeric.ValueChanged += ResizeHeight_Limit_Numeric_ValueChanged;

            pizaro_ResizeWidth_UserControl.resizeWidth_Begin_Numeric.ValueChanged += ResizeWidth_Begin_Numeric_ValueChanged;
            pizaro_ResizeWidth_UserControl.resizeWidth_Limit_Numeric.ValueChanged += ResizeWidth_Limit_Numeric_ValueChanged;

            pizaro_Slide_UserControl.slide_StartX_Numeric.ValueChanged += Slide_StartX_Numeric_ValueChanged;
            pizaro_Slide_UserControl.slide_StartY_Numeric.ValueChanged += Slide_StartY_Numeric_ValueChanged;
            pizaro_Slide_UserControl.slide_EndX_Numeric.ValueChanged += Slide_EndX_Numeric_ValueChanged;
            pizaro_Slide_UserControl.slide_EndY_Numeric.ValueChanged += Slide_EndY_Numeric_ValueChanged;


            pizaro_SlideFrom_UserControl.slideFrom_StartX_Numeric.ValueChanged += SlideFrom_StartX_Numeric_ValueChanged;
            pizaro_SlideFrom_UserControl.slideFrom_StartY_Numeric.ValueChanged += SlideFrom_StartY_Numeric_ValueChanged;
            pizaro_SlideFrom_UserControl.slideFrom_EndX_Numeric.ValueChanged += SlideFrom_EndX_Numeric_ValueChanged;
            pizaro_SlideFrom_UserControl.slideFrom_EndY_Numeric.ValueChanged += SlideFrom_EndY_Numeric_ValueChanged;

            #endregion

        }

        #region Triggered Events

        #region Fade Events
        /// <summary>
        /// Handles the ValueChanged event of the Fade_Begin_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Fade_Begin_Numeric_ValueChanged(object sender, EventArgs e)
        {
            fade_Animator.Fade_Begin = (float)pizaro_Fade_UserControl.fade_Begin_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the Fade_Limit_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Fade_Limit_Numeric_ValueChanged(object sender, EventArgs e)
        {
            fade_Animator.Fade_Limit = (float)pizaro_Fade_UserControl.fade_Limit_Numeric.Value;

        }
        #endregion

        #region FadeIn Events
        /// <summary>
        /// Handles the ValueChanged event of the FadeIn_Begin_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FadeIn_Begin_Numeric_ValueChanged(object sender, EventArgs e)
        {
            fadeIn_Animator.Fade_Begin = (float)pizaro_FadeIn_UserControl.fadeIn_Begin_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the FadeIn_Limit_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FadeIn_Limit_Numeric_ValueChanged(object sender, EventArgs e)
        {
            fadeIn_Animator.Fade_Limit = (float)pizaro_FadeIn_UserControl.fadeIn_Limit_Numeric.Value;

        }
        #endregion

        #region FadeInAndShow Events
        /// <summary>
        /// Handles the ValueChanged event of the FadeInAndShow_Begin_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FadeInAndShow_Begin_Numeric_ValueChanged(object sender, EventArgs e)
        {
            fadeInAndShow_Animator.Fade_Begin = (float)pizaro_FadeInAndShow_UserControl.fadeInAndShow_Begin_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the FadeInAndShow_Limit_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FadeInAndShow_Limit_Numeric_ValueChanged(object sender, EventArgs e)
        {
            fadeInAndShow_Animator.Fade_Limit = (float)pizaro_FadeInAndShow_UserControl.fadeInAndShow_Limit_Numeric.Value;

        }
        #endregion

        #region FadeOut Events
        /// <summary>
        /// Handles the ValueChanged event of the FadeOut_Begin_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FadeOut_Begin_Numeric_ValueChanged(object sender, EventArgs e)
        {
            fadeOut_Animator.Fade_Begin = (float)pizaro_FadeOut_UserControl.fadeOut_Begin_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the FadeOut_Limit_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FadeOut_Limit_Numeric_ValueChanged(object sender, EventArgs e)
        {
            fade_Animator.Fade_Limit = (float)pizaro_FadeOut_UserControl.fadeOut_Limit_Numeric.Value;

        }
        #endregion

        #region FadeOutandHide Events
        /// <summary>
        /// Handles the ValueChanged event of the FadeOutandHide_Begin_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FadeOutandHide_Begin_Numeric_ValueChanged(object sender, EventArgs e)
        {
            fadeOutAndHide_Animator.Fade_Begin = (float)pizaro_FadeOutandHide_UserControl.fadeOutandHide_Begin_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the FadeOutandHide_Limit_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FadeOutandHide_Limit_Numeric_ValueChanged(object sender, EventArgs e)
        {
            fadeOutAndHide_Animator.Fade_Limit = (float)pizaro_FadeOutandHide_UserControl.fadeOutandHide_Limit_Numeric.Value;

        }
        #endregion

        #region Resize Events
        /// <summary>
        /// Handles the ValueChanged event of the Resize_StartX_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Resize_StartX_Numeric_ValueChanged(object sender, EventArgs e)
        {
            pizaro_Resize_UserControl.resize_Animator.CordinateStart_X = (float)pizaro_Resize_UserControl.resize_StartX_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the Resize_StartY_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Resize_StartY_Numeric_ValueChanged(object sender, EventArgs e)
        {
            pizaro_Resize_UserControl.resize_Animator.CordinateStart_Y = (float)pizaro_Resize_UserControl.resize_StartY_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the Resize_EndX_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Resize_EndX_Numeric_ValueChanged(object sender, EventArgs e)
        {
            pizaro_Resize_UserControl.resize_Animator.CordinateEnd_X = (float)pizaro_Resize_UserControl.resize_EndX_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the Resize_EndY_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Resize_EndY_Numeric_ValueChanged(object sender, EventArgs e)
        {
            pizaro_Resize_UserControl.resize_Animator.CordinateEnd_Y = (float)pizaro_Resize_UserControl.resize_EndY_Numeric.Value;

        }
        #endregion

        #region ResizeHeight Events
        /// <summary>
        /// Handles the ValueChanged event of the ResizeHeight_Begin_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ResizeHeight_Begin_Numeric_ValueChanged(object sender, EventArgs e)
        {
            pizaro_ResizeHeight_UserControl.resizeHeight_Animator.ResizeHeight_Begin = (float)pizaro_ResizeHeight_UserControl.resizeHeight_Begin_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the ResizeHeight_Limit_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ResizeHeight_Limit_Numeric_ValueChanged(object sender, EventArgs e)
        {
            pizaro_ResizeHeight_UserControl.resizeHeight_Animator.ResizeHeight_Limit = (float)pizaro_ResizeHeight_UserControl.resizeHeight_Limit_Numeric.Value;

        }
        #endregion

        #region ResizeWidth Events
        /// <summary>
        /// Handles the ValueChanged event of the ResizeWidth_Begin_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ResizeWidth_Begin_Numeric_ValueChanged(object sender, EventArgs e)
        {
            pizaro_ResizeWidth_UserControl.resizeWidth_Animator.ResizeWidth_Begin = (float)pizaro_ResizeWidth_UserControl.resizeWidth_Begin_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the ResizeWidth_Limit_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ResizeWidth_Limit_Numeric_ValueChanged(object sender, EventArgs e)
        {
            pizaro_ResizeWidth_UserControl.resizeWidth_Animator.ResizeWidth_Limit = (float)pizaro_ResizeWidth_UserControl.resizeWidth_Limit_Numeric.Value;

        }
        #endregion

        #region Slide Events

        /// <summary>
        /// Handles the ValueChanged event of the Slide_StartX_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Slide_StartX_Numeric_ValueChanged(object sender, EventArgs e)
        {
            pizaro_Slide_UserControl.slide_StartX_Numeric.Value = (decimal)pizaroAnimatorInput.CordinateStart_X;

        }

        /// <summary>
        /// Handles the ValueChanged event of the Slide_StartY_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Slide_StartY_Numeric_ValueChanged(object sender, EventArgs e)
        {
            pizaro_Slide_UserControl.slide_StartY_Numeric.Value = (decimal)pizaroAnimatorInput.CordinateStart_Y;

        }

        /// <summary>
        /// Handles the ValueChanged event of the Slide_EndX_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Slide_EndX_Numeric_ValueChanged(object sender, EventArgs e)
        {
            pizaro_Slide_UserControl.slide_EndX_Numeric.Value = (decimal)pizaroAnimatorInput.CordinateEnd_X;

        }

        /// <summary>
        /// Handles the ValueChanged event of the Slide_EndY_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Slide_EndY_Numeric_ValueChanged(object sender, EventArgs e)
        {
            pizaro_Slide_UserControl.slide_EndY_Numeric.Value = (decimal)pizaroAnimatorInput.CordinateEnd_Y;

        }
        #endregion

        #region SlideFrom Events
        /// <summary>
        /// Handles the ValueChanged event of the SlideFrom_StartX_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SlideFrom_StartX_Numeric_ValueChanged(object sender, EventArgs e)
        {
            pizaro_SlideFrom_UserControl.slideFrom_Animator.CordinateStart_X = (float)pizaro_SlideFrom_UserControl.slideFrom_StartX_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the SlideFrom_StartY_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SlideFrom_StartY_Numeric_ValueChanged(object sender, EventArgs e)
        {
            pizaro_SlideFrom_UserControl.slideFrom_Animator.CordinateStart_Y = (float)pizaro_SlideFrom_UserControl.slideFrom_StartY_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the SlideFrom_EndX_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SlideFrom_EndX_Numeric_ValueChanged(object sender, EventArgs e)
        {
            pizaro_SlideFrom_UserControl.slideFrom_Animator.CordinateEnd_X = (float)pizaro_SlideFrom_UserControl.slideFrom_EndX_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the SlideFrom_EndY_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SlideFrom_EndY_Numeric_ValueChanged(object sender, EventArgs e)
        {
            pizaro_SlideFrom_UserControl.slideFrom_Animator.CordinateEnd_Y = (float)pizaro_SlideFrom_UserControl.slideFrom_EndY_Numeric.Value;

        }
        #endregion



        #endregion

        /// <summary>
        /// Sets the fade initial values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void Set_Fade_Initial_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            MainContainerValueSets(pizaroAnimatorInput);
        }

        /// <summary>
        /// Sets the fade retrieved values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void Set_Fade_Retrieved_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            MainContainer_ValueRetrieved(pizaroAnimatorInput);
            
            #region Animation Type

            if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Fade)
            {
                pizaroAnimatorInput.AnimationType = animationType.Fade;

                pizaroAnimatorInput.Fade_Begin = (float)pizaro_Fade_UserControl.fade_Begin_Numeric.Value;
                pizaroAnimatorInput.Fade_Limit = (float)pizaro_Fade_UserControl.fade_Limit_Numeric.Value;

                fadeIn_Animator.Fade_Begin = (float)pizaro_Fade_UserControl.fade_Begin_Numeric.Value;
                fadeIn_Animator.Fade_Limit = (float)pizaro_Fade_UserControl.fade_Limit_Numeric.Value;

            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeIn)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeIn;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeInAndShow)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeInAndShow;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOut)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeOut;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOutandHide)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeOutandHide;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Resize)
            {
                pizaroAnimatorInput.AnimationType = animationType.Resize;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeWidth)
            {
                pizaroAnimatorInput.AnimationType = animationType.ResizeWidth;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeHeight)
            {
                pizaroAnimatorInput.AnimationType = animationType.ResizeHeight;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Slide)
            {
                pizaroAnimatorInput.AnimationType = animationType.Slide;
            }
            else
            {
                pizaroAnimatorInput.AnimationType = animationType.SlideFrom;
            }
            #endregion

        }

        /// <summary>
        /// Sets the fade in initial values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void Set_FadeIn_Initial_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            MainContainerValueSets(pizaroAnimatorInput);
        }

        /// <summary>
        /// Sets the fade in retrieved values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void Set_FadeIn_Retrieved_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            MainContainer_ValueRetrieved(pizaroAnimatorInput);

            #region Animation Type

            if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Fade)
            {
                pizaroAnimatorInput.AnimationType = animationType.Fade;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeIn)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeIn;

                pizaroAnimatorInput.Fade_Begin = (float)pizaro_FadeIn_UserControl.fadeIn_Begin_Numeric.Value;
                pizaroAnimatorInput.Fade_Limit = (float)pizaro_FadeIn_UserControl.fadeIn_Limit_Numeric.Value;

                fadeIn_Animator.Fade_Begin = (float)pizaro_FadeIn_UserControl.fadeIn_Begin_Numeric.Value;
                fadeIn_Animator.Fade_Limit = (float)pizaro_FadeIn_UserControl.fadeIn_Limit_Numeric.Value;

            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeInAndShow)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeInAndShow;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOut)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeOut;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOutandHide)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeOutandHide;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Resize)
            {
                pizaroAnimatorInput.AnimationType = animationType.Resize;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeWidth)
            {
                pizaroAnimatorInput.AnimationType = animationType.ResizeWidth;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeHeight)
            {
                pizaroAnimatorInput.AnimationType = animationType.ResizeHeight;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Slide)
            {
                pizaroAnimatorInput.AnimationType = animationType.Slide;
            }
            else
            {
                pizaroAnimatorInput.AnimationType = animationType.SlideFrom;
            }
            #endregion
        }

        /// <summary>
        /// Sets the fade in and show initial values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void Set_FadeInAndShow_Initial_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            MainContainerValueSets(pizaroAnimatorInput);
        }

        /// <summary>
        /// Sets the fade in and show retrieved values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void Set_FadeInAndShow_Retrieved_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            MainContainer_ValueRetrieved(pizaroAnimatorInput);

            #region Animation Type

            if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Fade)
            {
                pizaroAnimatorInput.AnimationType = animationType.Fade;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeIn)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeIn;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeInAndShow)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeInAndShow;

                pizaroAnimatorInput.Fade_Begin = (float)pizaro_FadeInAndShow_UserControl.fadeInAndShow_Begin_Numeric.Value;
                pizaroAnimatorInput.Fade_Limit = (float)pizaro_FadeInAndShow_UserControl.fadeInAndShow_Limit_Numeric.Value;

                fadeInAndShow_Animator.Fade_Begin = (float)pizaro_FadeInAndShow_UserControl.fadeInAndShow_Begin_Numeric.Value;
                fadeInAndShow_Animator.Fade_Limit = (float)pizaro_FadeInAndShow_UserControl.fadeInAndShow_Limit_Numeric.Value;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOut)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeOut;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOutandHide)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeOutandHide;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Resize)
            {
                pizaroAnimatorInput.AnimationType = animationType.Resize;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeWidth)
            {
                pizaroAnimatorInput.AnimationType = animationType.ResizeWidth;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeHeight)
            {
                pizaroAnimatorInput.AnimationType = animationType.ResizeHeight;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Slide)
            {
                pizaroAnimatorInput.AnimationType = animationType.Slide;
            }
            else
            {
                pizaroAnimatorInput.AnimationType = animationType.SlideFrom;
            }
            #endregion
        }

        /// <summary>
        /// Sets the fade out initial values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void Set_FadeOut_Initial_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            MainContainerValueSets(pizaroAnimatorInput);
        }

        /// <summary>
        /// Sets the fade out retrieved values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void Set_FadeOut_Retrieved_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            MainContainer_ValueRetrieved(pizaroAnimatorInput);

            #region Animation Type

            if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Fade)
            {
                pizaroAnimatorInput.AnimationType = animationType.Fade;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeIn)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeIn;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeInAndShow)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeInAndShow;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOut)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeOut;

                pizaroAnimatorInput.Fade_Begin = (float)pizaro_FadeOut_UserControl.fadeOut_Begin_Numeric.Value;
                pizaroAnimatorInput.Fade_Limit = (float)pizaro_FadeOut_UserControl.fadeOut_Limit_Numeric.Value;

                fadeOut_Animator.Fade_Begin = (float)pizaro_FadeOut_UserControl.fadeOut_Begin_Numeric.Value;
                fadeOut_Animator.Fade_Limit = (float)pizaro_FadeOut_UserControl.fadeOut_Limit_Numeric.Value;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOutandHide)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeOutandHide;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Resize)
            {
                pizaroAnimatorInput.AnimationType = animationType.Resize;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeWidth)
            {
                pizaroAnimatorInput.AnimationType = animationType.ResizeWidth;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeHeight)
            {
                pizaroAnimatorInput.AnimationType = animationType.ResizeHeight;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Slide)
            {
                pizaroAnimatorInput.AnimationType = animationType.Slide;
            }
            else
            {
                pizaroAnimatorInput.AnimationType = animationType.SlideFrom;
            }
            #endregion
        }

        /// <summary>
        /// Sets the fade outand hide initial values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void Set_FadeOutandHide_Initial_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            MainContainerValueSets(pizaroAnimatorInput);
        }

        /// <summary>
        /// Sets the fade outand hide retrieved values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void Set_FadeOutandHide_Retrieved_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            MainContainer_ValueRetrieved(pizaroAnimatorInput);

            #region Animation Type

            if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Fade)
            {
                pizaroAnimatorInput.AnimationType = animationType.Fade;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeIn)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeIn;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeInAndShow)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeInAndShow;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOut)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeOut;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOutandHide)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeOutandHide;

                pizaroAnimatorInput.Fade_Begin= (float)pizaro_FadeOutandHide_UserControl.fadeOutandHide_Begin_Numeric.Value;
                pizaroAnimatorInput.Fade_Limit= (float)pizaro_FadeOutandHide_UserControl.fadeOutandHide_Limit_Numeric.Value;

                fadeOutAndHide_Animator.Fade_Begin = (float)pizaro_FadeOutandHide_UserControl.fadeOutandHide_Begin_Numeric.Value;
                fadeOutAndHide_Animator.Fade_Limit = (float)pizaro_FadeOutandHide_UserControl.fadeOutandHide_Limit_Numeric.Value;


            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Resize)
            {
                pizaroAnimatorInput.AnimationType = animationType.Resize;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeWidth)
            {
                pizaroAnimatorInput.AnimationType = animationType.ResizeWidth;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeHeight)
            {
                pizaroAnimatorInput.AnimationType = animationType.ResizeHeight;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Slide)
            {
                pizaroAnimatorInput.AnimationType = animationType.Slide;
            }
            else
            {
                pizaroAnimatorInput.AnimationType = animationType.SlideFrom;
            }
            #endregion
        }

        /// <summary>
        /// Sets the resize initial values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void Set_Resize_Initial_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            MainContainerValueSets(pizaroAnimatorInput);
        }

        /// <summary>
        /// Sets the resize retrieved values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void Set_Resize_Retrieved_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            MainContainer_ValueRetrieved(pizaroAnimatorInput);

            #region Animation Type

            if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Fade)
            {
                pizaroAnimatorInput.AnimationType = animationType.Fade;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeIn)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeIn;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeInAndShow)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeInAndShow;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOut)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeOut;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOutandHide)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeOutandHide;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Resize)
            {
                pizaroAnimatorInput.AnimationType = animationType.Resize;

                pizaroAnimatorInput.CordinateStart_X = (float)pizaro_Resize_UserControl.resize_StartX_Numeric.Value;
                pizaroAnimatorInput.CordinateStart_Y = (float)pizaro_Resize_UserControl.resize_StartY_Numeric.Value;
                pizaroAnimatorInput.CordinateEnd_X = (float)pizaro_Resize_UserControl.resize_EndX_Numeric.Value;
                pizaroAnimatorInput.CordinateEnd_Y = (float)pizaro_Resize_UserControl.resize_EndY_Numeric.Value;


                pizaro_Resize_UserControl.resize_Animator.CordinateStart_X = (float)pizaro_Resize_UserControl.resize_StartX_Numeric.Value;
                pizaro_Resize_UserControl.resize_Animator.CordinateStart_Y = (float)pizaro_Resize_UserControl.resize_StartY_Numeric.Value;
                pizaro_Resize_UserControl.resize_Animator.CordinateEnd_X = (float)pizaro_Resize_UserControl.resize_EndX_Numeric.Value;
                pizaro_Resize_UserControl.resize_Animator.CordinateEnd_Y = (float)pizaro_Resize_UserControl.resize_EndY_Numeric.Value;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeWidth)
            {
                pizaroAnimatorInput.AnimationType = animationType.ResizeWidth;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeHeight)
            {
                pizaroAnimatorInput.AnimationType = animationType.ResizeHeight;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Slide)
            {
                pizaroAnimatorInput.AnimationType = animationType.Slide;
            }
            else
            {
                pizaroAnimatorInput.AnimationType = animationType.SlideFrom;
            }
            #endregion
        }

        /// <summary>
        /// Sets the resize height initial values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void Set_ResizeHeight_Initial_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            MainContainerValueSets(pizaroAnimatorInput);
        }

        /// <summary>
        /// Sets the resize height retrieved values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void Set_ResizeHeight_Retrieved_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            MainContainer_ValueRetrieved(pizaroAnimatorInput);

            #region Animation Type

            if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Fade)
            {
                pizaroAnimatorInput.AnimationType = animationType.Fade;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeIn)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeIn;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeInAndShow)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeInAndShow;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOut)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeOut;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOutandHide)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeOutandHide;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Resize)
            {
                pizaroAnimatorInput.AnimationType = animationType.Resize;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeWidth)
            {
                pizaroAnimatorInput.AnimationType = animationType.ResizeWidth;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeHeight)
            {
                pizaroAnimatorInput.AnimationType = animationType.ResizeHeight;

                pizaroAnimatorInput.ResizeHeight_Begin = (float)pizaro_ResizeHeight_UserControl.resizeHeight_Begin_Numeric.Value;
                pizaroAnimatorInput.ResizeHeight_Limit = (float)pizaro_ResizeHeight_UserControl.resizeHeight_Limit_Numeric.Value;

                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.ResizeHeight_Begin = (float)pizaro_ResizeHeight_UserControl.resizeHeight_Begin_Numeric.Value;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.ResizeHeight_Limit = (float)pizaro_ResizeHeight_UserControl.resizeHeight_Limit_Numeric.Value;


            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Slide)
            {
                pizaroAnimatorInput.AnimationType = animationType.Slide;
            }
            else
            {
                pizaroAnimatorInput.AnimationType = animationType.SlideFrom;
            }
            #endregion
        }

        /// <summary>
        /// Sets the resize width initial values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void Set_ResizeWidth_Initial_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            MainContainerValueSets(pizaroAnimatorInput);
        }

        /// <summary>
        /// Sets the resize width retrieved values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void Set_ResizeWidth_Retrieved_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            MainContainer_ValueRetrieved(pizaroAnimatorInput);

            #region Animation Type

            if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Fade)
            {
                pizaroAnimatorInput.AnimationType = animationType.Fade;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeIn)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeIn;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeInAndShow)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeInAndShow;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOut)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeOut;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOutandHide)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeOutandHide;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Resize)
            {
                pizaroAnimatorInput.AnimationType = animationType.Resize;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeWidth)
            {
                pizaroAnimatorInput.AnimationType = animationType.ResizeWidth;

                pizaroAnimatorInput.ResizeWidth_Begin = (float)pizaro_ResizeWidth_UserControl.resizeWidth_Begin_Numeric.Value;
                pizaroAnimatorInput.ResizeWidth_Limit = (float)pizaro_ResizeWidth_UserControl.resizeWidth_Limit_Numeric.Value;

                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.ResizeWidth_Begin = (float)pizaro_ResizeWidth_UserControl.resizeWidth_Begin_Numeric.Value;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.ResizeWidth_Limit = (float)pizaro_ResizeWidth_UserControl.resizeWidth_Limit_Numeric.Value;


            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeHeight)
            {
                pizaroAnimatorInput.AnimationType = animationType.ResizeHeight;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Slide)
            {
                pizaroAnimatorInput.AnimationType = animationType.Slide;
            }
            else
            {
                pizaroAnimatorInput.AnimationType = animationType.SlideFrom;
            }
            #endregion
        }

        /// <summary>
        /// Sets the slide initial values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void Set_Slide_Initial_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            MainContainerValueSets(pizaroAnimatorInput);
        }

        /// <summary>
        /// Sets the slide retrieved values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void Set_Slide_Retrieved_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            MainContainer_ValueRetrieved(pizaroAnimatorInput);

            #region Animation Type

            if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Fade)
            {
                pizaroAnimatorInput.AnimationType = animationType.Fade;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeIn)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeIn;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeInAndShow)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeInAndShow;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOut)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeOut;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOutandHide)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeOutandHide;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Resize)
            {
                pizaroAnimatorInput.AnimationType = animationType.Resize;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeWidth)
            {
                pizaroAnimatorInput.AnimationType = animationType.ResizeWidth;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeHeight)
            {
                pizaroAnimatorInput.AnimationType = animationType.ResizeHeight;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Slide)
            {
                pizaroAnimatorInput.AnimationType = animationType.Slide;

                pizaroAnimatorInput.CordinateStart_X = (float)pizaro_Slide_UserControl.slide_StartX_Numeric.Value;
                pizaroAnimatorInput.CordinateStart_Y = (float)pizaro_Slide_UserControl.slide_StartY_Numeric.Value;
                pizaroAnimatorInput.CordinateEnd_X = (float)pizaro_Slide_UserControl.slide_EndX_Numeric.Value;
                pizaroAnimatorInput.CordinateEnd_Y = (float)pizaro_Slide_UserControl.slide_EndY_Numeric.Value;

                pizaro_Slide_UserControl.slide_Animator.CordinateStart_X = (float)pizaro_Slide_UserControl.slide_StartX_Numeric.Value;
                pizaro_Slide_UserControl.slide_Animator.CordinateStart_Y = (float)pizaro_Slide_UserControl.slide_StartY_Numeric.Value;
                pizaro_Slide_UserControl.slide_Animator.CordinateEnd_X = (float)pizaro_Slide_UserControl.slide_EndX_Numeric.Value;
                pizaro_Slide_UserControl.slide_Animator.CordinateEnd_Y = (float)pizaro_Slide_UserControl.slide_EndY_Numeric.Value;


            }
            else
            {
                pizaroAnimatorInput.AnimationType = animationType.SlideFrom;
            }
            #endregion
        }

        /// <summary>
        /// Sets the slide from initial values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void Set_SlideFrom_Initial_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            MainContainerValueSets(pizaroAnimatorInput);
        }

        /// <summary>
        /// Sets the slide from retrieved values.
        /// </summary>
        /// <param name="pizaroAnimatorInput">The pizaro animator input.</param>
        private void Set_SlideFrom_Retrieved_Values(ZeroitPizaroAnimatorInput pizaroAnimatorInput)
        {
            MainContainer_ValueRetrieved(pizaroAnimatorInput);

            #region Animation Type

            if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Fade)
            {
                pizaroAnimatorInput.AnimationType = animationType.Fade;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeIn)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeIn;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeInAndShow)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeInAndShow;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOut)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeOut;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOutandHide)
            {
                pizaroAnimatorInput.AnimationType = animationType.FadeOutandHide;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Resize)
            {
                pizaroAnimatorInput.AnimationType = animationType.Resize;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeWidth)
            {
                pizaroAnimatorInput.AnimationType = animationType.ResizeWidth;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeHeight)
            {
                pizaroAnimatorInput.AnimationType = animationType.ResizeHeight;
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Slide)
            {
                pizaroAnimatorInput.AnimationType = animationType.Slide;
            }
            else
            {
                pizaroAnimatorInput.AnimationType = animationType.SlideFrom;

                pizaroAnimatorInput.CordinateStart_X = (float)pizaro_SlideFrom_UserControl.slideFrom_StartX_Numeric.Value;
                pizaroAnimatorInput.CordinateStart_Y = (float)pizaro_SlideFrom_UserControl.slideFrom_StartY_Numeric.Value;
                pizaroAnimatorInput.CordinateEnd_X = (float)pizaro_SlideFrom_UserControl.slideFrom_EndX_Numeric.Value;
                pizaroAnimatorInput.CordinateEnd_Y = (float)pizaro_SlideFrom_UserControl.slideFrom_EndY_Numeric.Value;

                

            }
            #endregion
        }


        #endregion


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
        /// Handles the MouseEnter event of the fade_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void fade_Preview_btn_MouseEnter(object sender, EventArgs e)
        {
            fade_Preview_btn.FlatAppearance.BorderSize = 1;
            fade_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the fade_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void fade_Preview_btn_MouseLeave(object sender, EventArgs e)
        {
            fade_Preview_btn.FlatAppearance.BorderSize = 0;
            fade_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
        }

        /// <summary>
        /// Handles the Click event of the okBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void okBtn_Click(object sender, EventArgs e)
        {
            if(generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Fade)
            {
                pizaroAnimatorInput = new ZeroitPizaroAnimatorInput(animationType.Fade, 0, 1, (Control)generalContainer_Control_ComboBox.SelectedItem, 1000, 0.7f, 0.2f, 1);

                Set_Fade_Retrieved_Values(pizaroAnimatorInput);
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeIn)
            {
                pizaroAnimatorInput = new ZeroitPizaroAnimatorInput(animationType.FadeIn, 0, 1,true, (Control)generalContainer_Control_ComboBox.SelectedItem, 1000, 0.7f, 0.2f, 1);

                Set_FadeIn_Retrieved_Values(pizaroAnimatorInput);
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeInAndShow)
            {
                pizaroAnimatorInput = new ZeroitPizaroAnimatorInput(ZeroitPizaroAnimator.ZeroitPizaroAnimEdit.animationType.FadeInAndShow, 0, 1, true, true, (Control)generalContainer_Control_ComboBox.SelectedItem, 1000, 0.7f, 0.2f, 1);

                Set_FadeInAndShow_Retrieved_Values(pizaroAnimatorInput);
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOut)
            {
                pizaroAnimatorInput = new ZeroitPizaroAnimatorInput(ZeroitPizaroAnimator.ZeroitPizaroAnimEdit.animationType.FadeOut, 0, 1, "", (Control)generalContainer_Control_ComboBox.SelectedItem, 1000, 0.7f, 0.2f, 1);

                Set_FadeOut_Retrieved_Values(pizaroAnimatorInput);
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOutandHide)
            {
                pizaroAnimatorInput = new ZeroitPizaroAnimatorInput(ZeroitPizaroAnimator.ZeroitPizaroAnimEdit.animationType.FadeOutandHide, 0, 1, "", "", (Control)generalContainer_Control_ComboBox.SelectedItem, 1000, 0.7f, 0.2f, 1);

                Set_FadeOutandHide_Retrieved_Values(pizaroAnimatorInput);
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Resize)
            {
            
                pizaroAnimatorInput = new ZeroitPizaroAnimatorInput(ZeroitPizaroAnimator.ZeroitPizaroAnimEdit.animationType.Resize, 10, 10, 300, 300, (Control)generalContainer_Control_ComboBox.SelectedItem, 1000, 0.7f, 0.2f, 1);

                Set_Resize_Retrieved_Values(pizaroAnimatorInput);
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeWidth)
            {
                pizaroAnimatorInput = new ZeroitPizaroAnimatorInput(ZeroitPizaroAnimator.ZeroitPizaroAnimEdit.animationType.ResizeWidth, "", 10, 50, (Control)generalContainer_Control_ComboBox.SelectedItem, 1000, 0.7f, 0.2f, 1);

                Set_ResizeWidth_Retrieved_Values(pizaroAnimatorInput);
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeHeight)
            {
                pizaroAnimatorInput = new ZeroitPizaroAnimatorInput(ZeroitPizaroAnimator.ZeroitPizaroAnimEdit.animationType.ResizeHeight, true, 10, 50, (Control)generalContainer_Control_ComboBox.SelectedItem, 1000, 0.7f, 0.2f, 1);

                Set_ResizeHeight_Retrieved_Values(pizaroAnimatorInput);
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Slide)
            {
                pizaroAnimatorInput = new ZeroitPizaroAnimatorInput(ZeroitPizaroAnimator.ZeroitPizaroAnimEdit.animationType.Slide, 10, 10, 50, 50, true,(Control)generalContainer_Control_ComboBox.SelectedItem, 1000, 0.7f, 0.2f, 1);

                Set_Slide_Retrieved_Values(pizaroAnimatorInput);
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_SlideFrom)
            {
                pizaroAnimatorInput = new ZeroitPizaroAnimatorInput(ZeroitPizaroAnimator.ZeroitPizaroAnimEdit.animationType.SlideFrom, 10, 10, 50, 50, "", (Control)generalContainer_Control_ComboBox.SelectedItem, 1000, 0.7f, 0.2f, 1);

                Set_SlideFrom_Retrieved_Values(pizaroAnimatorInput);
            }

            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_None)
            {
                pizaroAnimatorInput = new ZeroitPizaroAnimatorInput(ZeroitPizaroAnimator.ZeroitPizaroAnimEdit.animationType.None, (Control)generalContainer_Control_ComboBox.SelectedItem);
                
            }

            else
            {
                pizaroAnimatorInput = new ZeroitPizaroAnimatorInput();
                
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
        /// Handles the Click event of the fade_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void fade_Preview_btn_Click(object sender, EventArgs e)
        {
            if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Fade)
            {
                fade_Animator.Activate();

                
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeIn)
            {
                fadeIn_Animator.Activate();
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeInAndShow)
            {
                fadeInAndShow_Animator.Activate();
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOut)
            {
                fadeOut_Animator.Activate();
            }
            else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_FadeOutandHide)
            {
                fadeOutAndHide_Animator.Activate();
            }
            //else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Resize)
            //{
                
            //}
            //else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeWidth)
            //{
                
            //}
            //else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_ResizeHeight)
            //{
                
            //}
            //else if (generalContainer_AnimationType_ComboBox.SelectedIndex == Pizaro_Slide)
            //{
                
            //}
            //else
            //{
                
            //}
        }

        /// <summary>
        /// Handles the Paint event of the fade_preview_Panel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void fade_preview_Panel_Paint(object sender, PaintEventArgs e)
        {

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the generalContainer_Easing_ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void generalContainer_Easing_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Easing Ifs
            if (generalContainer_Easing_ComboBox.SelectedIndex == BackEaseIn)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseIn;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseIn;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseIn;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseIn;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseIn;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseIn;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseIn;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseIn;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseIn;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseIn;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == BackEaseInOut)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseInOut;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseInOut;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseInOut;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseInOut;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseInOut;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseInOut;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseInOut;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseInOut;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseInOut;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseInOut;

            }
            if (generalContainer_Easing_ComboBox.SelectedIndex == BackEaseOut)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseOut;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseOut;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseOut;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseOut;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseOut;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseOut;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseOut;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseOut;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseOut;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseOut;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == BackEaseOutIn)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseOutIn;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseOutIn;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseOutIn;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseOutIn;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseOutIn;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseOutIn;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseOutIn;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseOutIn;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseOutIn;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BackEaseOutIn;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == BounceEaseIn)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseIn;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseIn;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseIn;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseIn;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseIn;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseIn;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseIn;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseIn;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseIn;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseIn;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == BounceEaseInOut)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseInOut;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseInOut;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseInOut;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseInOut;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseInOut;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseInOut;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseInOut;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseInOut;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseInOut;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseInOut;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == BounceEaseOut)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseOut;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseOut;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseOut;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseOut;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseOut;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseOut;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseOut;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseOut;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseOut;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseOut;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == BounceEaseOutIn)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseOutIn;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseOutIn;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseOutIn;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseOutIn;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseOutIn;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseOutIn;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseOutIn;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseOutIn;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseOutIn;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.BounceEaseOutIn;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseIn)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseIn;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseIn;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseIn;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseIn;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseIn;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseIn;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseIn;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseIn;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseIn;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseIn;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInAndOut)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInAndOut;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInAndOut;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInAndOut;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInAndOut;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInAndOut;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInAndOut;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInAndOut;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInAndOut;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInAndOut;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInAndOut;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInCirc)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInCirc;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInCirc;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInCirc;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInCirc;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInCirc;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInCirc;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInCirc;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInCirc;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInCirc;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInCirc;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInCubic)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInCubic;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInCubic;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInCubic;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInCubic;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInCubic;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInCubic;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInCubic;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInCubic;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInCubic;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInCubic;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInExpo)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInExpo;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInExpo;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInExpo;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInExpo;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInExpo;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInExpo;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInExpo;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInExpo;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInExpo;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInExpo;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutCirc)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutCirc;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutCirc;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutCirc;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutCirc;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutCirc;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutCirc;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutCirc;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutCirc;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutCirc;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutCirc;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutCubic)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutCubic;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutCubic;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutCubic;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutCubic;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutCubic;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutCubic;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutCubic;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutCubic;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutCubic;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutCubic;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutExpo)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutExpo;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutExpo;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutExpo;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutExpo;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutExpo;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutExpo;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutExpo;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutExpo;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutExpo;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutExpo;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutQuad)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuad;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuad;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuad;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuad;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuad;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuad;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuad;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuad;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuad;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuad;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutQuart)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuart;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuart;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuart;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuart;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuart;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuart;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuart;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuart;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuart;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuart;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutQuint)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuint;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuint;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuint;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuint;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuint;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuint;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuint;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuint;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuint;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutQuint;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInOutSine)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutSine;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutSine;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutSine;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutSine;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutSine;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutSine;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutSine;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutSine;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutSine;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInOutSine;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInQuad)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuad;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuad;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuad;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuad;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuad;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuad;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuad;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuad;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuad;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuad;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInQuart)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuart;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuart;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuart;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuart;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuart;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuart;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuart;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuart;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuart;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuart;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInQuint)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuint;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuint;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuint;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuint;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuint;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuint;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuint;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuint;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuint;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInQuint;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseInSine)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInSine;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInSine;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInSine;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInSine;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInSine;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInSine;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInSine;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInSine;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInSine;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseInSine;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOut)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOut;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOut;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOut;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOut;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOut;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOut;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOut;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOut;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOut;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOut;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutCirc)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutCirc;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutCirc;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutCirc;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutCirc;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutCirc;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutCirc;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutCirc;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutCirc;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutCirc;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutCirc;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutCubic)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutCubic;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutCubic;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutCubic;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutCubic;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutCubic;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutCubic;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutCubic;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutCubic;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutCubic;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutCubic;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutExpo)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutExpo;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutExpo;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutExpo;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutExpo;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutExpo;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutExpo;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutExpo;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutExpo;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutExpo;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutExpo;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutQuad)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuad;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuad;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuad;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuad;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuad;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuad;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuad;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuad;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuad;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuad;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutQuart)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuart;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuart;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuart;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuart;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuart;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuart;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuart;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuart;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuart;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuart;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutQuint)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuint;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuint;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuint;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuint;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuint;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuint;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuint;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuint;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuint;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutQuint;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == EaseOutSine)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutSine;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutSine;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutSine;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutSine;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutSine;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutSine;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutSine;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutSine;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutSine;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.EaseOutSine;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == ElasticEaseIn)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseIn;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseIn;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseIn;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseIn;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseIn;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseIn;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseIn;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseIn;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseIn;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseIn;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == ElasticEaseInOut)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseInOut;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseInOut;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseInOut;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseInOut;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseInOut;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseInOut;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseInOut;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseInOut;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseInOut;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseInOut;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == ElasticEaseOut)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseOut;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseOut;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseOut;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseOut;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseOut;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseOut;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseOut;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseOut;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseOut;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseOut;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == ElasticEaseOutIn)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseOutIn;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseOutIn;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseOutIn;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseOutIn;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseOutIn;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseOutIn;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseOutIn;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseOutIn;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseOutIn;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.ElasticEaseOutIn;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == Linear)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.Linear;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.Linear;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.Linear;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.Linear;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.Linear;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.Linear;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.Linear;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.Linear;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.Linear;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.Linear;

            }
            else if (generalContainer_Easing_ComboBox.SelectedIndex == LinearTween)
            {
                fade_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.LinearTween;
                fadeIn_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.LinearTween;
                fadeInAndShow_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.LinearTween;
                fadeOut_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.LinearTween;
                fadeOutAndHide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.LinearTween;
                pizaro_Resize_UserControl.resize_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.LinearTween;
                pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.LinearTween;
                pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.LinearTween;
                pizaro_Slide_UserControl.slide_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.LinearTween;
                pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingNames = ZeroitPizaroAnimator.ZeroitPizaroAnim.easingNames.LinearTween;

            }
            #endregion
        }

        /// <summary>
        /// Handles the ValueChanged event of the generalContainer_EasingStart_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void generalContainer_EasingStart_Numeric_ValueChanged(object sender, EventArgs e)
        {
            fade_Animator.EasingStart = (float)generalContainer_EasingStart_Numeric.Value;
            fadeIn_Animator.EasingStart = (float)generalContainer_EasingStart_Numeric.Value;
            fadeInAndShow_Animator.EasingStart = (float)generalContainer_EasingStart_Numeric.Value;
            fadeOut_Animator.EasingStart = (float)generalContainer_EasingStart_Numeric.Value;
            fadeOutAndHide_Animator.EasingStart = (float)generalContainer_EasingStart_Numeric.Value;
            pizaro_Resize_UserControl.resize_Animator.EasingStart = (float)generalContainer_EasingStart_Numeric.Value;
            pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingStart = (float)generalContainer_EasingStart_Numeric.Value;
            pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingStart = (float)generalContainer_EasingStart_Numeric.Value;
            pizaro_Slide_UserControl.slide_Animator.EasingStart = (float)generalContainer_EasingStart_Numeric.Value;
            pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingStart = (float)generalContainer_EasingStart_Numeric.Value;
            
        }

        /// <summary>
        /// Handles the ValueChanged event of the generalContainer_EasingEnd_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void generalContainer_EasingEnd_Numeric_ValueChanged(object sender, EventArgs e)
        {
            fade_Animator.EasingEnd = (float)generalContainer_EasingEnd_Numeric.Value;
            fadeIn_Animator.EasingEnd = (float)generalContainer_EasingEnd_Numeric.Value;
            fadeInAndShow_Animator.EasingEnd = (float)generalContainer_EasingEnd_Numeric.Value;
            fadeOut_Animator.EasingEnd = (float)generalContainer_EasingEnd_Numeric.Value;
            fadeOutAndHide_Animator.EasingEnd = (float)generalContainer_EasingEnd_Numeric.Value;
            pizaro_Resize_UserControl.resize_Animator.EasingEnd = (float)generalContainer_EasingEnd_Numeric.Value;
            pizaro_ResizeHeight_UserControl.resizeHeight_Animator.EasingEnd = (float)generalContainer_EasingEnd_Numeric.Value;
            pizaro_ResizeWidth_UserControl.resizeWidth_Animator.EasingEnd = (float)generalContainer_EasingEnd_Numeric.Value;
            pizaro_Slide_UserControl.slide_Animator.EasingEnd = (float)generalContainer_EasingEnd_Numeric.Value;
            pizaro_SlideFrom_UserControl.slideFrom_Animator.EasingEnd = (float)generalContainer_EasingEnd_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the generalContainer_Acceleration_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void generalContainer_Acceleration_Numeric_ValueChanged(object sender, EventArgs e)
        {
            fade_Animator.Acceleration = (float)generalContainer_Acceleration_Numeric.Value;
            fadeIn_Animator.Acceleration = (float)generalContainer_Acceleration_Numeric.Value;
            fadeInAndShow_Animator.Acceleration = (float)generalContainer_Acceleration_Numeric.Value;
            fadeOut_Animator.Acceleration = (float)generalContainer_Acceleration_Numeric.Value;
            fadeOutAndHide_Animator.Acceleration = (float)generalContainer_Acceleration_Numeric.Value;
            pizaro_Resize_UserControl.resize_Animator.Acceleration = (float)generalContainer_Acceleration_Numeric.Value;
            pizaro_ResizeHeight_UserControl.resizeHeight_Animator.Acceleration = (float)generalContainer_Acceleration_Numeric.Value;
            pizaro_ResizeWidth_UserControl.resizeWidth_Animator.Acceleration = (float)generalContainer_Acceleration_Numeric.Value;
            pizaro_Slide_UserControl.slide_Animator.Acceleration = (float)generalContainer_Acceleration_Numeric.Value;
            pizaro_SlideFrom_UserControl.slideFrom_Animator.Acceleration = (float)generalContainer_Acceleration_Numeric.Value;

        }

        /// <summary>
        /// Handles the ValueChanged event of the generalContainer_Duration_Numeric control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void generalContainer_Duration_Numeric_ValueChanged(object sender, EventArgs e)
        {
            fade_Animator.Duration = (int)generalContainer_Duration_Numeric.Value;
            fadeIn_Animator.Duration = (int)generalContainer_Duration_Numeric.Value;
            fadeInAndShow_Animator.Duration = (int)generalContainer_Duration_Numeric.Value;
            fadeOut_Animator.Duration = (int)generalContainer_Duration_Numeric.Value;
            fadeOutAndHide_Animator.Duration = (int)generalContainer_Duration_Numeric.Value;
            pizaro_Resize_UserControl.resize_Animator.Duration = (int)generalContainer_Duration_Numeric.Value;
            pizaro_ResizeHeight_UserControl.resizeHeight_Animator.Duration = (int)generalContainer_Duration_Numeric.Value;
            pizaro_ResizeWidth_UserControl.resizeWidth_Animator.Duration = (int)generalContainer_Duration_Numeric.Value;
            pizaro_Slide_UserControl.slide_Animator.Duration = (int)generalContainer_Duration_Numeric.Value;
            pizaro_SlideFrom_UserControl.slideFrom_Animator.Duration = (int)generalContainer_Duration_Numeric.Value;

        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the generalContainer_Control_ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void generalContainer_Control_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
