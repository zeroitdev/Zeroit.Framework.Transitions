// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ZeroitObjectAnimatorWithEditor.cs" company="Zeroit Dev Technologies">
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
#region Imports

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Zeroit.Framework.Transitions.AnimationEditors;

#endregion

namespace Zeroit.Framework.Transitions
{
    /// <summary>
    /// A class collection for providing animation functionality.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    public class ZeroitOJAnimEdit : Component
    {

        #region Private Fields

        /// <summary>
        /// The date time
        /// </summary>
        DateTime dateTime;
        /// <summary>
        /// The object animator input
        /// </summary>
        private ObjectAnimatorInput objectAnimatorInput = new ObjectAnimatorInput(

            ZeroitOJAnimEdit.ZeroitObjectAnimationMode.ColorAnimation,
            ZeroitOJAnimEdit.ZeroitObjectColorAnimation.FillEllipse,
            1, 10, 1, 200, 10,
            new Control(),
            Color.Orange, false);

        /// <summary>
        /// <c><see cref="ZeroitOJAnimEdit" /></c> : Sets the type of color animation.
        /// </summary>
        public enum ZeroitObjectColorAnimation
        {
            /// <summary>
            /// Set the color animation to FillEllipse.
            /// </summary>
            FillEllipse,
            /// <summary>
            /// Set the color animation to FillSquare.
            /// </summary>
            FillSquare,
            /// <summary>
            /// Set the color animation to SlideFill.
            /// </summary>
            SlideFill,
            /// <summary>
            /// Set the color animation to StripeFill.
            /// </summary>
            StripeFill,
            /// <summary>
            /// Set the color animation to SplitFill.
            /// </summary>
            SplitFill
        };

        /// <summary>
        /// <c><see cref="ZeroitOJAnimEdit" /></c> : Sets the type of form animation.
        /// </summary>
        public enum ZeroitObjectFormAnimation
        {
            /// <summary>
            /// Set the form animation to FadeIn.
            /// </summary>
            FadeIn,
            /// <summary>
            /// Set the form animation to FadeOut.
            /// </summary>
            FadeOut
        }

        /// <summary>
        /// <c><see cref="ZeroitOJAnimEdit" /></c> : Sets the type of standard animation.
        /// </summary>
        public enum ZeroitObjectStandardAnimation
        {
            /// <summary>
            /// Set the standard animation to SlideUp.
            /// </summary>
            SlideUp,
            /// <summary>
            /// Set the standard animation to SlideDown.
            /// </summary>
            SlideDown,
            /// <summary>
            /// Set the standard animation to SlideLeft.
            /// </summary>
            SlideLeft,
            /// <summary>
            /// Set the standard animation to SlideRight.
            /// </summary>
            SlideRight,
            /// <summary>
            /// Set the standard animation to SlugRight.
            /// </summary>
            SlugRight,
            /// <summary>
            /// Set the standard animation to SlugLeft.
            /// </summary>
            SlugLeft,
            /// <summary>
            /// Set the standard animation to Hop.
            /// </summary>
            Hop,
            /// <summary>
            /// Set the standard animation to ShootRight.
            /// </summary>
            ShootRight,
            /// <summary>
            /// Set the standard animation to ShootLeft.
            /// </summary>
            ShootLeft
        }

        /// <summary>
        /// <c><see cref="ZeroitOJAnimEdit" /></c> : Sets the animation mode.
        /// </summary>
        public enum ZeroitObjectAnimationMode
        {
            /// <summary>
            /// Set the animation mode to ColorAnimation.
            /// </summary>
            ColorAnimation,
            /// <summary>
            /// Set the animation mode to FormAnimation.
            /// </summary>
            FormAnimation,
            /// <summary>
            /// Set the animation mode to StandardAnimation.
            /// </summary>
            StandardAnimation
        }


        /// <summary>
        /// The location
        /// </summary>
        Point location;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the values to use in the animation editor.
        /// </summary>
        /// <value>The object animator input.</value>
        public ObjectAnimatorInput ObjectAnimatorInput
        {
            get { return objectAnimatorInput; }
            set
            {
                objectAnimatorInput = value;
                Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the standard animation shoot delay.
        /// </summary>
        /// <value>The standard shoot delay.</value>

        [Category("Animation Delays"),
         Description("Sets the Standard animation hop Delay")]
        public int StandardShootDelay
        {
            get { return objectAnimatorInput.StandardShootDelay; }
            set
            {
                objectAnimatorInput.StandardShootDelay = value;
                //Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the standard hop delay.
        /// </summary>
        /// <value>The standard hop delay.</value>
        [Category("Animation Delays"),
         Description("Sets the Standard animation hop Delay")]
        public int StandardHopDelay
        {
            get { return objectAnimatorInput.StandardHopDelay; }
            set
            {
                objectAnimatorInput.StandardHopDelay = value;
                Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the standard animation slug delay.
        /// </summary>
        /// <value>The standard animation slug delay.</value>
        [Category("Animation Delays"),
         Description("Sets the Standard animation slug Delay")]
        public int[] StandardSlugDelay
        {
            get { return objectAnimatorInput.StandardSlugDelay; }
            set
            {
                objectAnimatorInput.StandardSlugDelay = value;
                Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the standard animation slide delay.
        /// </summary>
        /// <value>The standard animation slide delay.</value>
        [Category("Animation Delays"),
         Description("Sets the Standard animation slide Delay")]
        public int StandardSlideDelay
        {
            get { return objectAnimatorInput.StandardSlideDelay; }
            set
            {
                objectAnimatorInput.StandardSlideDelay = value;
                Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color animation delay.
        /// </summary>
        /// <value>The color animation delay.</value>
        [Category("Animation Delays"),
         Description("Sets the Color animation Delay")]
        public int ColorAnimationDelay
        {
            get { return objectAnimatorInput.ColorAnimationDelay; }
            set
            {
                objectAnimatorInput.ColorAnimationDelay = value;
                Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the form animation delay.
        /// </summary>
        /// <value>The form animation delay.</value>
        [Category("Animation Delays"),
         Description("Sets the Form animation Delay")]
        public int FormAnimationDelay
        {
            get { return objectAnimatorInput.FormAnimationDelay; }
            set
            {
                objectAnimatorInput.FormAnimationDelay = value;
                Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the upper speed limit.
        /// </summary>
        /// <value>The upper speed limit.</value>

        [Category("General Animation"),
         Description("Sets the Upper Speed Limit")]
        public int UpperSpeedLimit
        {
            get { return objectAnimatorInput.UpperSpeedLimit; }
            set
            {
                objectAnimatorInput.UpperSpeedLimit = value;
                Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the lower speed limit.
        /// </summary>
        /// <value>The lower speed limit.</value>
        [Category("General Animation"),
         Description("Sets the Lower Speed Limit")]
        public int LowerSpeedLimit
        {
            get { return objectAnimatorInput.LowerSpeedLimit; }
            set
            {
                objectAnimatorInput.LowerSpeedLimit = value;
                Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the animation mode.
        /// </summary>
        /// <value>The animation mode.</value>
        [Category("General Animation"),
         Description("Sets the Animation Mode")]
        public ZeroitObjectAnimationMode AnimationMode
        {
            get { return objectAnimatorInput.AnimationMode; }
            set
            {
                objectAnimatorInput.AnimationMode = value;
                Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color animation.
        /// </summary>
        /// <value>The color animation.</value>
        [Category("General Animation"),
         Description("Sets the Color Animation")]
        public ZeroitObjectColorAnimation ColorAnimation
        {
            get { return objectAnimatorInput.ColorAnimation; }
            set
            {
                objectAnimatorInput.ColorAnimation = value;
                Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the form animation.
        /// </summary>
        /// <value>The form animation.</value>
        [Category("General Animation"),
         Description("Sets the Form Animation")]
        public ZeroitObjectFormAnimation FormAnimation
        {
            get { return objectAnimatorInput.FormAnimation; }
            set
            {
                objectAnimatorInput.FormAnimation = value;
                Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the standard animation.
        /// </summary>
        /// <value>The standard animation.</value>
        [Category("General Animation"),
         Description("Sets the Standard Animation")]
        public ZeroitObjectStandardAnimation StandardAnimation
        {
            get { return objectAnimatorInput.StandardAnimation; }
            set
            {
                objectAnimatorInput.StandardAnimation = value;
                Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the animation delay.
        /// </summary>
        /// <value>The delay.</value>
        [Category("General Animation"),
         Description("Sets the Delay")]
        public int Delay
        {
            get { return objectAnimatorInput.Delay; }
            set
            {
                objectAnimatorInput.Delay = value;
                Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the animation speed.
        /// </summary>
        /// <value>The animation speed.</value>
        /// <exception cref="ArgumentOutOfRangeException">Value must be greater than 1
        /// or
        /// Value must be less than 10</exception>
        [Category("General Animation"),
         Description("Sets the Animation Speed")]
        public int AnimationSpeed
        {
            get { return objectAnimatorInput.AnimationSpeed; }
            set
            {
                if (value < objectAnimatorInput.LowerSpeedLimit)
                {
                    value = 1;
                    throw new ArgumentOutOfRangeException("Value must be greater than 1");
                }

                if (value > objectAnimatorInput.UpperSpeedLimit)
                {
                    value = 10;
                    throw new ArgumentOutOfRangeException("Value must be less than 10");
                }

                objectAnimatorInput.AnimationSpeed = value;
                Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to keep color after animation.
        /// </summary>
        /// <value><c>true</c> if keep color; otherwise, <c>false</c>.</value>
        [Category("General Animation"),
         Description("Set to maintain color")]
        public bool KeepColor
        {
            get { return objectAnimatorInput.KeepColor; }
            set
            {
                objectAnimatorInput.KeepColor = value;
                Control.Invalidate();

            }
        }

        /// <summary>
        /// Gets or sets the color to animate.
        /// </summary>
        /// <value>The color to animate.</value>
        [Category("General Animation"),
         Description("Sets the Color to animate")]
        public Color ColorToAnimate
        {
            get { return objectAnimatorInput.ColorToAnimate; }
            set
            {
                objectAnimatorInput.ColorToAnimate = value;
                Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the control.
        /// </summary>
        /// <value>The control.</value>
        [Category("General Animation"),
         Description("Sets the Control to animated")]
        public Control Control
        {
            get { return objectAnimatorInput.Control; }
            set
            {
                objectAnimatorInput.Control = value;
                Control.Invalidate();
            }
        }
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitOJAnim" /> class.
        /// </summary>
        public ZeroitOJAnimEdit()
        {
        }

        /// <summary>
        /// Colors the animate.
        /// </summary>
        public void ColorAnimate()
        {

            Graphics graphic = Control.CreateGraphics();

            #region Old Code
            //object animationObject = Control;
            //
            //         //Control = animationObject as Control;

            //         if (AnimationSpeed < 1)
            //{
            //	AnimationSpeed = 1;
            //}
            //if (AnimationSpeed > 10)
            //{
            //	AnimationSpeed = 10;
            //}

            //if (AnimationSpeed < 1)
            //{
            //	AnimationSpeed = 1;
            //}
            //if (AnimationSpeed > 10)
            //{
            //	AnimationSpeed = 10;
            //}

            //         if (animation == ZeroitOJAnim.ColorAnimation.FillEllipse)
            //{
            //             int num = 1;
            //             int width = Control.Width;
            //             if (Control.Height > Control.Width)
            //             {
            //                 width = Control.Height;
            //             }
            //             width = width + 200 + 10 * AnimationSpeed;
            //             while (num < width)
            //             {
            //                 graphic.FillEllipse(new SolidBrush(ColorToAnimate), Control.Width / 2 - num / 2, Control.Height / 2 - num / 2, num, num);
            //                 this.WaitAnimation(10);
            //                 num = num + 10 * AnimationSpeed;
            //             }
            //         }
            //if (animation == ZeroitOJAnim.ColorAnimation.FillSquare)
            //{
            //	int num1 = 1;
            //	int height = Control.Width;
            //	if (Control.Height > Control.Width)
            //	{
            //		height = Control.Height;
            //	}
            //	height = height + 200;
            //	while (num1 < height)
            //	{
            //		graphic.FillRectangle(new SolidBrush(ColorToAnimate), Control.Width / 2 - num1 / 2, Control.Height / 2 - num1 / 2, num1, num1);
            //		this.WaitAnimation(10);
            //		num1 = num1 + 10 * AnimationSpeed;
            //	}
            //}
            //if (animation == ZeroitOJAnim.ColorAnimation.SlideFill)
            //{
            //	for (int i = 10; i < Control.Width + 10 * AnimationSpeed; i = i + 10 * AnimationSpeed)
            //	{
            //		graphic.FillRectangle(new SolidBrush(ColorToAnimate), 0, 0, i, Control.Height);
            //		this.WaitAnimation(10);
            //	}
            //}
            //if (animation == ZeroitOJAnim.ColorAnimation.StripeFill)
            //{
            //	int num2 = 10;
            //	int height1 = Control.Height / 10 + 5;
            //	while (num2 < Control.Width + 10 * AnimationSpeed)
            //	{
            //		graphic.FillRectangle(new SolidBrush(ColorToAnimate), 0, 0, num2, height1);
            //		graphic.FillRectangle(new SolidBrush(ColorToAnimate), Control.Width - num2, height1, num2, height1);
            //		graphic.FillRectangle(new SolidBrush(ColorToAnimate), 0, height1 * 2, num2, height1);
            //		graphic.FillRectangle(new SolidBrush(ColorToAnimate), Control.Width - num2, height1 * 3, num2, height1);
            //		graphic.FillRectangle(new SolidBrush(ColorToAnimate), 0, height1 * 4, num2, height1);
            //		graphic.FillRectangle(new SolidBrush(ColorToAnimate), Control.Width - num2, height1 * 5, num2, height1);
            //		graphic.FillRectangle(new SolidBrush(ColorToAnimate), 0, height1 * 6, num2, height1);
            //		graphic.FillRectangle(new SolidBrush(ColorToAnimate), Control.Width - num2, height1 * 7, num2, height1);
            //		graphic.FillRectangle(new SolidBrush(ColorToAnimate), 0, height1 * 8, num2, height1);
            //		graphic.FillRectangle(new SolidBrush(ColorToAnimate), Control.Width - num2, height1 * 9, num2, height1);
            //		graphic.FillRectangle(new SolidBrush(ColorToAnimate), 0, height1 * 10, num2, height1);
            //		this.WaitAnimation(10);
            //		num2 = num2 + 10 * AnimationSpeed;
            //	}
            //}
            //if (animation == ZeroitOJAnim.ColorAnimation.SplitFill)
            //{
            //	int num3 = 10;
            //	int width1 = Control.Width + 10 * AnimationSpeed;
            //	while (num3 < width1)
            //	{
            //		graphic.FillRectangle(new SolidBrush(ColorToAnimate), 0, Control.Height / 2 - num3 / 2, Control.Width, num3);
            //		this.WaitAnimation(10);
            //		num3 = num3 + 10 * AnimationSpeed;
            //	}
            //} 
            #endregion

            switch (ColorAnimation)
            {
                case ZeroitObjectColorAnimation.FillEllipse:
                    int num = 1;
                    int width = Control.Width;
                    if (Control.Height > Control.Width)
                    {
                        width = Control.Height;
                    }
                    width = width + 200 + 10 * AnimationSpeed;
                    while (num < width)
                    {
                        graphic.FillEllipse(new SolidBrush(ColorToAnimate), Control.Width / 2 - num / 2, Control.Height / 2 - num / 2, num, num);
                        this.WaitAnimation(ColorAnimationDelay);
                        num = num + 10 * AnimationSpeed;
                    }
                    break;
                case ZeroitObjectColorAnimation.FillSquare:
                    int num1 = 1;
                    int height = Control.Width;
                    if (Control.Height > Control.Width)
                    {
                        height = Control.Height;
                    }
                    height = height + 200;
                    while (num1 < height)
                    {
                        graphic.FillRectangle(new SolidBrush(ColorToAnimate), Control.Width / 2 - num1 / 2, Control.Height / 2 - num1 / 2, num1, num1);
                        this.WaitAnimation(ColorAnimationDelay);
                        num1 = num1 + 10 * AnimationSpeed;
                    }
                    break;
                case ZeroitObjectColorAnimation.SlideFill:
                    for (int i = 10; i < Control.Width + 10 * AnimationSpeed; i = i + 10 * AnimationSpeed)
                    {
                        graphic.FillRectangle(new SolidBrush(ColorToAnimate), 0, 0, i, Control.Height);
                        this.WaitAnimation(ColorAnimationDelay);
                    }
                    break;
                case ZeroitObjectColorAnimation.StripeFill:
                    int num2 = 10;
                    int height1 = Control.Height / 10 + 5;
                    while (num2 < Control.Width + 10 * AnimationSpeed)
                    {
                        graphic.FillRectangle(new SolidBrush(ColorToAnimate), 0, 0, num2, height1);
                        graphic.FillRectangle(new SolidBrush(ColorToAnimate), Control.Width - num2, height1, num2, height1);
                        graphic.FillRectangle(new SolidBrush(ColorToAnimate), 0, height1 * 2, num2, height1);
                        graphic.FillRectangle(new SolidBrush(ColorToAnimate), Control.Width - num2, height1 * 3, num2, height1);
                        graphic.FillRectangle(new SolidBrush(ColorToAnimate), 0, height1 * 4, num2, height1);
                        graphic.FillRectangle(new SolidBrush(ColorToAnimate), Control.Width - num2, height1 * 5, num2, height1);
                        graphic.FillRectangle(new SolidBrush(ColorToAnimate), 0, height1 * 6, num2, height1);
                        graphic.FillRectangle(new SolidBrush(ColorToAnimate), Control.Width - num2, height1 * 7, num2, height1);
                        graphic.FillRectangle(new SolidBrush(ColorToAnimate), 0, height1 * 8, num2, height1);
                        graphic.FillRectangle(new SolidBrush(ColorToAnimate), Control.Width - num2, height1 * 9, num2, height1);
                        graphic.FillRectangle(new SolidBrush(ColorToAnimate), 0, height1 * 10, num2, height1);
                        this.WaitAnimation(ColorAnimationDelay);
                        num2 = num2 + 10 * AnimationSpeed;
                    }
                    break;
                case ZeroitObjectColorAnimation.SplitFill:
                    int num3 = 10;
                    int width1 = Control.Width + 10 * AnimationSpeed;
                    while (num3 < width1)
                    {
                        graphic.FillRectangle(new SolidBrush(ColorToAnimate), 0, Control.Height / 2 - num3 / 2, Control.Width, num3);
                        this.WaitAnimation(ColorAnimationDelay);
                        num3 = num3 + 10 * AnimationSpeed;
                    }
                    break;
                default:
                    break;
            }

            this.WaitAnimation(Delay);
            graphic.Dispose();
            if (KeepColor)
            {
                Control.BackColor = ColorToAnimate;
            }
            Control.Refresh();
        }

        /// <summary>
        /// Forms the animate.
        /// </summary>
        public void FormAnimate()
        {

            System.Windows.Forms.Form animationForm = Control.FindForm();

            #region Old Code
            //if (AnimationSpeed < 1)
            //{
            //	AnimationSpeed = 1;
            //}
            //if (AnimationSpeed > 10)
            //{
            //	AnimationSpeed = 10;
            //}

            //if (animation == ZeroitOJAnim.formAnimation.FadeIn)
            //{
            //	animationForm.Opacity = 0;
            //	while (animationForm.Opacity < 100)
            //	{
            //		animationForm.Opacity = 0.01 * (double)AnimationSpeed + animationForm.Opacity;
            //		this.WaitAnimation(50);
            //	}
            //}
            //if (animation == ZeroitOJAnim.formAnimation.FadeOut)
            //{
            //	animationForm.Opacity = 1;
            //	while (animationForm.Opacity > 0.1)
            //	{
            //		animationForm.Opacity = animationForm.Opacity - 0.01 * (double)AnimationSpeed;
            //		this.WaitAnimation(50);
            //	}
            //} 
            #endregion

            switch (FormAnimation)
            {
                case ZeroitObjectFormAnimation.FadeIn:
                    animationForm.Opacity = 0;
                    while (animationForm.Opacity < 100)
                    {
                        animationForm.Opacity = 0.01 * (double)AnimationSpeed + animationForm.Opacity;
                        this.WaitAnimation(FormAnimationDelay);
                    }
                    Control.Refresh();
                    break;
                case ZeroitObjectFormAnimation.FadeOut:
                    animationForm.Opacity = 1;
                    while (animationForm.Opacity > 0.1)
                    {
                        animationForm.Opacity = animationForm.Opacity - 0.01 * (double)AnimationSpeed;
                        this.WaitAnimation(FormAnimationDelay);
                    }
                    Control.Refresh();
                    break;
                default:
                    break;
            }

            
        }

        /// <summary>
        /// Standards the animate.
        /// </summary>
        public void StandardAnimate()
        {

            #region Old Code
            //Control point = animationObject as Control;
            //Control point = Control;
            //if (AnimationSpeed < 1)
            //{
            //	AnimationSpeed = 1;
            //}
            //if (AnimationSpeed > 10)
            //{
            //	AnimationSpeed = 10;
            //}
            //if (animation == ZeroitOJAnim.standardAnimation.SlideRight)
            //{
            //	int x = Control.Location.X;
            //	int width = 0 - Control.Width;
            //	location = Control.Location;
            //	Control.Location = new Point(width, location.Y);
            //	Control.Refresh();
            //	while (Control.Location.X < x / 2)
            //	{
            //		location = Control.Location;
            //		int num = location.X + 10 * AnimationSpeed;
            //		location = Control.Location;
            //		Control.Location = new Point(num, location.Y);
            //		Control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (Control.Location.X < x / 4)
            //	{
            //		location = Control.Location;
            //		int x1 = location.X + 7 * AnimationSpeed;
            //		location = Control.Location;
            //		Control.Location = new Point(x1, location.Y);
            //		Control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (Control.Location.X < x / 8)
            //	{
            //		location = Control.Location;
            //		int num1 = location.X + 5 * AnimationSpeed;
            //		location = Control.Location;
            //		Control.Location = new Point(num1, location.Y);
            //		Control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (Control.Location.X < x)
            //	{
            //		location = Control.Location;
            //		int x2 = location.X + 2 * AnimationSpeed;
            //		location = Control.Location;
            //		Control.Location = new Point(x2, location.Y);
            //		Control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	location = Control.Location;
            //	Control.Location = new Point(x, location.Y);
            //}
            //if (animation == ZeroitOJAnim.standardAnimation.SlideLeft)
            //{
            //	int num2 = Control.Location.X;
            //	int width1 = Control.Parent.Width + Control.Width;
            //	location = Control.Location;
            //	Control.Location = new Point(width1, location.Y);
            //	Control.Refresh();
            //	while (Control.Location.X > num2 + Control.Width / 2)
            //	{
            //		location = Control.Location;
            //		int x3 = location.X - 10 * AnimationSpeed;
            //		location = Control.Location;
            //		Control.Location = new Point(x3, location.Y);
            //		Control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (Control.Location.X > num2 + Control.Width / 4)
            //	{
            //		location = Control.Location;
            //		int num3 = location.X - 7 * AnimationSpeed;
            //		location = Control.Location;
            //		Control.Location = new Point(num3, location.Y);
            //		Control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (Control.Location.X > num2 + Control.Width / 8)
            //	{
            //		location = Control.Location;
            //		int x4 = location.X - 5 * AnimationSpeed;
            //		location = Control.Location;
            //		Control.Location = new Point(x4, location.Y);
            //		Control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (Control.Location.X > num2)
            //	{
            //		location = Control.Location;
            //		int num4 = location.X - 2 * AnimationSpeed;
            //		location = Control.Location;
            //		Control.Location = new Point(num4, location.Y);
            //		Control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	location = Control.Location;
            //	Control.Location = new Point(num2, location.Y);
            //}
            //if (animation == ZeroitOJAnim.standardAnimation.SlideDown)
            //{
            //	int y = Control.Location.Y;
            //	location = Control.Location;
            //	Control.Location = new Point(location.X, 0 - Control.Height);
            //	Control.Refresh();
            //	while (Control.Location.Y < y / 2)
            //	{
            //		int x5 = Control.Location.X;
            //		location = Control.Location;
            //		Control.Location = new Point(x5, location.Y + 10 * AnimationSpeed);
            //		Control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (Control.Location.Y < y / 4)
            //	{
            //		int num5 = Control.Location.X;
            //		location = Control.Location;
            //		Control.Location = new Point(num5, location.Y + 7 * AnimationSpeed);
            //		Control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (Control.Location.Y < y / 8)
            //	{
            //		int x6 = Control.Location.X;
            //		location = Control.Location;
            //		Control.Location = new Point(x6, location.Y + 5 * AnimationSpeed);
            //		Control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (Control.Location.Y < y)
            //	{
            //		int num6 = Control.Location.X;
            //		location = Control.Location;
            //		Control.Location = new Point(num6, location.Y + 2 * AnimationSpeed);
            //		Control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	location = Control.Location;
            //	Control.Location = new Point(location.X, y);
            //}
            //if (animation == ZeroitOJAnim.standardAnimation.SlideUp)
            //{
            //	int y1 = Control.Location.Y;
            //	location = Control.Location;
            //	Control.Location = new Point(location.X, Control.Parent.Height + Control.Height);
            //	Control.Refresh();
            //	while (Control.Location.Y > y1 + Control.Height / 2)
            //	{
            //		int x7 = Control.Location.X;
            //		location = Control.Location;
            //		Control.Location = new Point(x7, location.Y - 10 * AnimationSpeed);
            //		Control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (Control.Location.Y > y1 + Control.Height / 4)
            //	{
            //		int num7 = Control.Location.X;
            //		location = Control.Location;
            //		Control.Location = new Point(num7, location.Y - 7 * AnimationSpeed);
            //		Control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (Control.Location.Y > y1 + Control.Height / 8)
            //	{
            //		int x8 = Control.Location.X;
            //		location = Control.Location;
            //		Control.Location = new Point(x8, location.Y - 5 * AnimationSpeed);
            //		Control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (Control.Location.Y > y1)
            //	{
            //		int num8 = Control.Location.X;
            //		location = Control.Location;
            //		Control.Location = new Point(num8, location.Y - 2 * AnimationSpeed);
            //		Control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	location = Control.Location;
            //	Control.Location = new Point(location.X, y1);
            //}
            //if (animation == ZeroitOJAnim.standardAnimation.SlugRight)
            //{
            //	int x9 = Control.Location.X;
            //	int width2 = Control.Width;
            //	int width3 = 0 - Control.Width;
            //	location = Control.Location;
            //	Control.Location = new Point(width3, location.Y);
            //	Control.Refresh();
            //	while (Control.Location.X < x9)
            //	{
            //		location = Control.Location;
            //		int num9 = location.X + 8 * AnimationSpeed;
            //		location = Control.Location;
            //		Control.Location = new Point(num9, location.Y);
            //		Control.Refresh();
            //		Control.Refresh();
            //		this.WaitAnimation(100 / AnimationSpeed);
            //		while (Control.Width > width2 / 2)
            //		{
            //			Control.Width = Control.Width - 3 * AnimationSpeed;
            //			Control.Refresh();
            //			this.WaitAnimation(50 / AnimationSpeed);
            //		}
            //		while (Control.Width < width2)
            //		{
            //			Control.Width = Control.Width + 3 * AnimationSpeed;
            //			Control.Refresh();
            //			this.WaitAnimation(50 / AnimationSpeed);
            //		}
            //	}
            //	location = Control.Location;
            //	Control.Location = new Point(x9, location.Y);
            //	Control.Width = width2;
            //	Control.Refresh();
            //}
            //if (animation == ZeroitOJAnim.standardAnimation.SlugLeft)
            //{
            //	int x10 = Control.Location.X;
            //	int width4 = Control.Width;
            //	int width5 = Control.Parent.Width + Control.Width;
            //	location = Control.Location;
            //	Control.Location = new Point(width5, location.Y);
            //	Control.Refresh();
            //	while (Control.Location.X > x10)
            //	{
            //		location = Control.Location;
            //		int num10 = location.X - 8 * AnimationSpeed;
            //		location = Control.Location;
            //		Control.Location = new Point(num10, location.Y);
            //		Control.Refresh();
            //		Control.Refresh();
            //		this.WaitAnimation(100 / AnimationSpeed);
            //		while (Control.Width > width4 / 2)
            //		{
            //			Control.Width = Control.Width - 3 * AnimationSpeed;
            //			Control.Refresh();
            //			this.WaitAnimation(50 / AnimationSpeed);
            //		}
            //		while (Control.Width < width4)
            //		{
            //			Control.Width = Control.Width + 3 * AnimationSpeed;
            //			Control.Refresh();
            //			this.WaitAnimation(50 / AnimationSpeed);
            //		}
            //	}
            //	location = Control.Location;
            //	Control.Location = new Point(x10, location.Y);
            //	Control.Width = width4;
            //	Control.Refresh();
            //}
            //if (animation == ZeroitOJAnim.standardAnimation.Hop)
            //{
            //	int y2 = Control.Location.Y;
            //	while (Control.Location.Y > y2 - 20)
            //	{
            //		while (Control.Location.Y > y2 - 10)
            //		{
            //			int x11 = Control.Location.X;
            //			location = Control.Location;
            //			Control.Location = new Point(x11, location.Y - 5);
            //			Control.Refresh();
            //			this.WaitAnimation(100 / AnimationSpeed);
            //		}
            //		while (Control.Location.Y > y2 - 18)
            //		{
            //			int num11 = Control.Location.X;
            //			location = Control.Location;
            //			Control.Location = new Point(num11, location.Y - 4);
            //			Control.Refresh();
            //			this.WaitAnimation(100 / AnimationSpeed);
            //		}
            //		while (Control.Location.Y > y2 - 20)
            //		{
            //			int x12 = Control.Location.X;
            //			location = Control.Location;
            //			Control.Location = new Point(x12, location.Y - 2);
            //			Control.Refresh();
            //			this.WaitAnimation(100 / AnimationSpeed);
            //		}
            //	}
            //	while (Control.Location.Y < y2)
            //	{
            //		while (Control.Location.Y < y2 - 18)
            //		{
            //			int num12 = Control.Location.X;
            //			location = Control.Location;
            //			Control.Location = new Point(num12, location.Y + 2);
            //			Control.Refresh();
            //			this.WaitAnimation(100 / AnimationSpeed);
            //		}
            //		while (Control.Location.Y < y2 - 20)
            //		{
            //			int x13 = Control.Location.X;
            //			location = Control.Location;
            //			Control.Location = new Point(x13, location.Y + 6);
            //			Control.Refresh();
            //			this.WaitAnimation(100 / AnimationSpeed);
            //		}
            //		location = Control.Location;
            //		Control.Location = new Point(location.X, y2);
            //	}
            //}
            //if (animation == ZeroitOJAnim.standardAnimation.ShootRight)
            //{
            //	int num13 = Control.Location.X;
            //	int y3 = Control.Location.Y;
            //	Size size = Control.Size;
            //	Control.Size = new Size(Control.Width, 6);
            //	Control.Refresh();
            //	int width6 = 0 - Control.Width;
            //	location = Control.Location;
            //	Control.Location = new Point(width6, location.Y + size.Height / 2 - 3);
            //	Control.Refresh();
            //	while (Control.Width - size.Width < num13 + size.Width)
            //	{
            //		Control.Size = new Size(Control.Width + 50, Control.Height);
            //		Control.Refresh();
            //		this.WaitAnimation(50 / AnimationSpeed);
            //	}
            //	Control.Size = new Size(num13 + size.Width * 2, Control.Height);
            //	Control.Refresh();
            //	while (Control.Location.X < num13)
            //	{
            //		location = Control.Location;
            //		int x14 = location.X + 25;
            //		location = Control.Location;
            //		Control.Location = new Point(x14, location.Y);
            //		Control.Size = new Size(Control.Width - 25, Control.Height);
            //		Control.Refresh();
            //		this.WaitAnimation(50 / AnimationSpeed);
            //	}
            //	Control.Size = size;
            //	Control.Location = new Point(num13, y3);
            //	Control.Refresh();
            //}
            //if (animation == ZeroitOJAnim.standardAnimation.ShootLeft)
            //{
            //	int num14 = Control.Location.X;
            //	int y4 = Control.Location.Y;
            //	Size size1 = Control.Size;
            //	Control.Size = new Size(Control.Width, 6);
            //	Control.Refresh();
            //	int width7 = Control.Parent.Width + Control.Width;
            //	location = Control.Location;
            //	Control.Location = new Point(width7, location.Y + size1.Height / 2 - 3);
            //	Control.Refresh();
            //	while (Control.Location.X > num14)
            //	{
            //		Control.Size = new Size(Control.Width + 50, Control.Height);
            //		location = Control.Location;
            //		int x15 = location.X - 50;
            //		location = Control.Location;
            //		Control.Location = new Point(x15, location.Y);
            //		Control.Refresh();
            //		this.WaitAnimation(50 / AnimationSpeed);
            //	}
            //	Control.Size = new Size(num14 + size1.Width * 2, Control.Height);
            //	Control.Refresh();
            //	while (Control.Location.X + Control.Width > size1.Width)
            //	{
            //		Control.Size = new Size(Control.Width - 25, Control.Height);
            //		Control.Refresh();
            //		this.WaitAnimation(50 / AnimationSpeed);
            //	}
            //	Control.Size = size1;
            //	Control.Location = new Point(num14, y4);
            //	Control.Refresh();
            //} 
            #endregion


            switch (StandardAnimation)
            {
                case ZeroitObjectStandardAnimation.SlideUp:
                    int y1 = Control.Location.Y;
                    location = Control.Location;
                    if (Control == Control.FindForm())
                    {
                        Control.Location = new Point(location.X, Control.Height + Control.Height);
                    }
                    else
                    {
                        Control.Location = new Point(location.X, Control.Parent.Height + Control.Height);
                    }

                    Control.Refresh();
                    while (Control.Location.Y > y1 + Control.Height / 2)
                    {
                        int x7 = Control.Location.X;
                        location = Control.Location;
                        Control.Location = new Point(x7, location.Y - 10 * AnimationSpeed);
                        Control.Refresh();
                        this.WaitAnimation(StandardSlideDelay);
                    }
                    while (Control.Location.Y > y1 + Control.Height / 4)
                    {
                        int num7 = Control.Location.X;
                        location = Control.Location;
                        Control.Location = new Point(num7, location.Y - 7 * AnimationSpeed);
                        Control.Refresh();
                        this.WaitAnimation(StandardSlideDelay);
                    }
                    while (Control.Location.Y > y1 + Control.Height / 8)
                    {
                        int x8 = Control.Location.X;
                        location = Control.Location;
                        Control.Location = new Point(x8, location.Y - 5 * AnimationSpeed);
                        Control.Refresh();
                        this.WaitAnimation(StandardSlideDelay);
                    }
                    while (Control.Location.Y > y1)
                    {
                        int num8 = Control.Location.X;
                        location = Control.Location;
                        Control.Location = new Point(num8, location.Y - 2 * AnimationSpeed);
                        Control.Refresh();
                        this.WaitAnimation(StandardSlideDelay);
                    }
                    location = Control.Location;
                    Control.Location = new Point(location.X, y1);
                    break;
                case ZeroitObjectStandardAnimation.SlideDown:
                    int y = Control.Location.Y;
                    location = Control.Location;
                    Control.Location = new Point(location.X, 0 - Control.Height);
                    Control.Refresh();
                    while (Control.Location.Y < y / 2)
                    {
                        int x5 = Control.Location.X;
                        location = Control.Location;
                        Control.Location = new Point(x5, location.Y + 10 * AnimationSpeed);
                        Control.Refresh();
                        this.WaitAnimation(StandardSlideDelay);
                    }
                    while (Control.Location.Y < y / 4)
                    {
                        int num5 = Control.Location.X;
                        location = Control.Location;
                        Control.Location = new Point(num5, location.Y + 7 * AnimationSpeed);
                        Control.Refresh();
                        this.WaitAnimation(StandardSlideDelay);
                    }
                    while (Control.Location.Y < y / 8)
                    {
                        int x6 = Control.Location.X;
                        location = Control.Location;
                        Control.Location = new Point(x6, location.Y + 5 * AnimationSpeed);
                        Control.Refresh();
                        this.WaitAnimation(StandardSlideDelay);
                    }
                    while (Control.Location.Y < y)
                    {
                        int num6 = Control.Location.X;
                        location = Control.Location;
                        Control.Location = new Point(num6, location.Y + 2 * AnimationSpeed);
                        Control.Refresh();
                        this.WaitAnimation(StandardSlideDelay);
                    }
                    location = Control.Location;
                    Control.Location = new Point(location.X, y);
                    break;
                case ZeroitObjectStandardAnimation.SlideLeft:
                    int num2 = Control.Location.X;
                    int width1;
                    if (Control == Control.FindForm())
                    {
                        width1 = Control.Width + Control.Width;
                    }
                    else
                    {
                        width1 = Control.Parent.Width + Control.Width;
                    }

                    location = Control.Location;
                    Control.Location = new Point(width1, location.Y);
                    Control.Refresh();
                    while (Control.Location.X > num2 + Control.Width / 2)
                    {
                        location = Control.Location;
                        int x3 = location.X - 10 * AnimationSpeed;
                        location = Control.Location;
                        Control.Location = new Point(x3, location.Y);
                        Control.Refresh();
                        this.WaitAnimation(StandardSlideDelay);
                    }
                    while (Control.Location.X > num2 + Control.Width / 4)
                    {
                        location = Control.Location;
                        int num3 = location.X - 7 * AnimationSpeed;
                        location = Control.Location;
                        Control.Location = new Point(num3, location.Y);
                        Control.Refresh();
                        this.WaitAnimation(StandardSlideDelay);
                    }
                    while (Control.Location.X > num2 + Control.Width / 8)
                    {
                        location = Control.Location;
                        int x4 = location.X - 5 * AnimationSpeed;
                        location = Control.Location;
                        Control.Location = new Point(x4, location.Y);
                        Control.Refresh();
                        this.WaitAnimation(StandardSlideDelay);
                    }
                    while (Control.Location.X > num2)
                    {
                        location = Control.Location;
                        int num4 = location.X - 2 * AnimationSpeed;
                        location = Control.Location;
                        Control.Location = new Point(num4, location.Y);
                        Control.Refresh();
                        this.WaitAnimation(StandardSlideDelay);
                    }
                    location = Control.Location;
                    Control.Location = new Point(num2, location.Y);
                    break;
                case ZeroitObjectStandardAnimation.SlideRight:
                    int x = Control.Location.X;
                    int width = 0 - Control.Width;
                    location = Control.Location;
                    Control.Location = new Point(width, location.Y);
                    Control.Refresh();
                    while (Control.Location.X < x / 2)
                    {
                        location = Control.Location;
                        int num = location.X + 10 * AnimationSpeed;
                        location = Control.Location;
                        Control.Location = new Point(num, location.Y);
                        Control.Refresh();
                        this.WaitAnimation(StandardSlideDelay);
                    }
                    while (Control.Location.X < x / 4)
                    {
                        location = Control.Location;
                        int x1 = location.X + 7 * AnimationSpeed;
                        location = Control.Location;
                        Control.Location = new Point(x1, location.Y);
                        Control.Refresh();
                        this.WaitAnimation(StandardSlideDelay);
                    }
                    while (Control.Location.X < x / 8)
                    {
                        location = Control.Location;
                        int num1 = location.X + 5 * AnimationSpeed;
                        location = Control.Location;
                        Control.Location = new Point(num1, location.Y);
                        Control.Refresh();
                        this.WaitAnimation(StandardSlideDelay);
                    }
                    while (Control.Location.X < x)
                    {
                        location = Control.Location;
                        int x2 = location.X + 2 * AnimationSpeed;
                        location = Control.Location;
                        Control.Location = new Point(x2, location.Y);
                        Control.Refresh();
                        this.WaitAnimation(StandardSlideDelay);
                    }
                    location = Control.Location;
                    Control.Location = new Point(x, location.Y);
                    break;
                case ZeroitObjectStandardAnimation.SlugRight:
                    int x9 = Control.Location.X;
                    int width2 = Control.Width;
                    int width3 = 0 - Control.Width;
                    location = Control.Location;
                    Control.Location = new Point(width3, location.Y);
                    Control.Refresh();
                    while (Control.Location.X < x9)
                    {
                        location = Control.Location;
                        int num9 = location.X + 8 * AnimationSpeed;
                        location = Control.Location;
                        Control.Location = new Point(num9, location.Y);
                        Control.Refresh();
                        Control.Refresh();
                        this.WaitAnimation(StandardSlugDelay[0] / AnimationSpeed);
                        while (Control.Width > width2 / 2)
                        {
                            Control.Width = Control.Width - 3 * AnimationSpeed;
                            Control.Refresh();
                            this.WaitAnimation(StandardSlugDelay[1] / AnimationSpeed);
                        }
                        while (Control.Width < width2)
                        {
                            Control.Width = Control.Width + 3 * AnimationSpeed;
                            Control.Refresh();
                            this.WaitAnimation(StandardSlugDelay[1] / AnimationSpeed);
                        }
                    }
                    location = Control.Location;
                    Control.Location = new Point(x9, location.Y);
                    Control.Width = width2;
                    Control.Refresh();
                    break;
                case ZeroitObjectStandardAnimation.SlugLeft:
                    int x10 = Control.Location.X;
                    int width4 = Control.Width;
                    int width5;
                    if (Control == Control.FindForm())
                    {
                        width5 = Control.Width + Control.Width / 3;
                    }
                    else
                    {
                        width5 = Control.Parent.Width + Control.Width;
                    }

                    location = Control.Location;
                    Control.Location = new Point(width5, location.Y);
                    Control.Refresh();
                    while (Control.Location.X > x10)
                    {
                        location = Control.Location;
                        int num10 = location.X - 8 * AnimationSpeed;
                        location = Control.Location;
                        Control.Location = new Point(num10, location.Y);
                        Control.Refresh();
                        Control.Refresh();
                        this.WaitAnimation(StandardSlugDelay[0] / AnimationSpeed);
                        while (Control.Width > width4 / 2)
                        {
                            Control.Width = Control.Width - 3 * AnimationSpeed;
                            Control.Refresh();
                            this.WaitAnimation(StandardSlugDelay[1] / AnimationSpeed);
                        }
                        while (Control.Width < width4)
                        {
                            Control.Width = Control.Width + 3 * AnimationSpeed;
                            Control.Refresh();
                            this.WaitAnimation(StandardSlugDelay[1] / AnimationSpeed);
                        }
                    }
                    location = Control.Location;
                    Control.Location = new Point(x10, location.Y);
                    Control.Width = width4;
                    Control.Refresh();
                    break;
                case ZeroitObjectStandardAnimation.Hop:
                    int y2 = Control.Location.Y;
                    while (Control.Location.Y > y2 - 20)
                    {
                        while (Control.Location.Y > y2 - 10)
                        {
                            int x11 = Control.Location.X;
                            location = Control.Location;
                            Control.Location = new Point(x11, location.Y - 5);
                            Control.Refresh();
                            this.WaitAnimation(StandardHopDelay / AnimationSpeed);
                        }
                        while (Control.Location.Y > y2 - 18)
                        {
                            int num11 = Control.Location.X;
                            location = Control.Location;
                            Control.Location = new Point(num11, location.Y - 4);
                            Control.Refresh();
                            this.WaitAnimation(StandardHopDelay / AnimationSpeed);
                        }
                        while (Control.Location.Y > y2 - 20)
                        {
                            int x12 = Control.Location.X;
                            location = Control.Location;
                            Control.Location = new Point(x12, location.Y - 2);
                            Control.Refresh();
                            this.WaitAnimation(StandardHopDelay / AnimationSpeed);
                        }
                    }
                    while (Control.Location.Y < y2)
                    {
                        while (Control.Location.Y < y2 - 18)
                        {
                            int num12 = Control.Location.X;
                            location = Control.Location;
                            Control.Location = new Point(num12, location.Y + 2);
                            Control.Refresh();
                            this.WaitAnimation(StandardHopDelay / AnimationSpeed);
                        }
                        while (Control.Location.Y < y2 - 20)
                        {
                            int x13 = Control.Location.X;
                            location = Control.Location;
                            Control.Location = new Point(x13, location.Y + 6);
                            Control.Refresh();
                            this.WaitAnimation(StandardHopDelay / AnimationSpeed);
                        }
                        location = Control.Location;
                        Control.Location = new Point(location.X, y2);
                    }
                    break;
                case ZeroitObjectStandardAnimation.ShootRight:
                    int num13 = Control.Location.X;
                    int y3 = Control.Location.Y;
                    Size size = Control.Size;
                    Control.Size = new Size(Control.Width, 6);
                    Control.Refresh();
                    int width6 = 0 - Control.Width;
                    location = Control.Location;
                    Control.Location = new Point(width6, location.Y + size.Height / 2 - 3);
                    Control.Refresh();
                    while (Control.Width - size.Width < num13 + size.Width)
                    {
                        Control.Size = new Size(Control.Width + 50, Control.Height);
                        Control.Refresh();
                        this.WaitAnimation(StandardShootDelay / AnimationSpeed);
                    }
                    Control.Size = new Size(num13 + size.Width * 2, Control.Height);
                    Control.Refresh();
                    while (Control.Location.X < num13)
                    {
                        location = Control.Location;
                        int x14 = location.X + 25;
                        location = Control.Location;
                        Control.Location = new Point(x14, location.Y);
                        Control.Size = new Size(Control.Width - 25, Control.Height);
                        Control.Refresh();
                        this.WaitAnimation(StandardShootDelay / AnimationSpeed);
                    }
                    Control.Size = size;
                    Control.Location = new Point(num13, y3);
                    Control.Refresh();
                    break;
                case ZeroitObjectStandardAnimation.ShootLeft:
                    int num14 = Control.Location.X;
                    int y4 = Control.Location.Y;
                    Size size1 = Control.Size;
                    Control.Size = new Size(Control.Width, 6);
                    Control.Refresh();
                    int width7;
                    if (Control == Control.FindForm())
                    {
                        width7 = Control.Width + Control.Width;
                    }
                    else
                    {
                        width7 = Control.Parent.Width + Control.Width;
                    }

                    location = Control.Location;
                    Control.Location = new Point(width7, location.Y + size1.Height / 2 - 3);
                    Control.Refresh();
                    while (Control.Location.X > num14)
                    {
                        Control.Size = new Size(Control.Width + 50, Control.Height);
                        location = Control.Location;
                        int x15 = location.X - 50;
                        location = Control.Location;
                        Control.Location = new Point(x15, location.Y);
                        Control.Refresh();
                        this.WaitAnimation(StandardShootDelay / AnimationSpeed);
                    }
                    Control.Size = new Size(num14 + size1.Width * 2, Control.Height);
                    Control.Refresh();
                    while (Control.Location.X + Control.Width > size1.Width)
                    {
                        Control.Size = new Size(Control.Width - 25, Control.Height);
                        Control.Refresh();
                        this.WaitAnimation(StandardShootDelay / AnimationSpeed);
                    }
                    Control.Size = size1;
                    Control.Location = new Point(num14, y4);
                    Control.Refresh();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Waits the animation.
        /// </summary>
        /// <param name="milliseconds">The milliseconds.</param>
        public void WaitAnimation(int milliseconds)
        {
            dateTime = DateTime.Now.AddMilliseconds((double)milliseconds);


            while (DateTime.Now < dateTime)
            {
                Application.DoEvents();

            }

        }

        /// <summary>
        /// Starts the animation.
        /// </summary>
        public void Start()
        {
            switch (AnimationMode)
            {
                case ZeroitObjectAnimationMode.ColorAnimation:
                    ColorAnimate();
                    break;
                case ZeroitObjectAnimationMode.FormAnimation:
                    FormAnimate();
                    break;
                case ZeroitObjectAnimationMode.StandardAnimation:
                    StandardAnimate();
                    break;
                default:
                    break;
            }
        }






                
          
          
        
    }
}
