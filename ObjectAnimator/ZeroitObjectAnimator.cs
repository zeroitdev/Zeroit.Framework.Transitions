// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ZeroitObjectAnimator.cs" company="Zeroit Dev Technologies">
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

#endregion

namespace Zeroit.Framework.Transitions
{
    /// <summary>
    /// A class collection for providing animation functionality.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    public class ZeroitOJAnim : Component
    {

        #region Private Fields

        private Control control = new Control();

        /// <summary>
        /// <c><see cref="ZeroitOJAnim"/></c> : Sets the type of color animation.
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
        /// <c><see cref="ZeroitOJAnim"/></c> : Sets the type of form animation.
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
        /// <c><see cref="ZeroitOJAnim"/></c> : Sets the type of standard animation.
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
        /// <c><see cref="ZeroitOJAnim"/></c> : Sets the animation mode.
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

        private ZeroitObjectColorAnimation _colorAnimation = ZeroitObjectColorAnimation.FillEllipse;
        private ZeroitObjectFormAnimation _formAnimation = ZeroitObjectFormAnimation.FadeIn;
        private ZeroitObjectStandardAnimation _standardAnimation = ZeroitObjectStandardAnimation.Hop;
        private ZeroitObjectAnimationMode _animationMode = ZeroitObjectAnimationMode.StandardAnimation;
        Point location;
        private Color color = Color.Orange;
        bool keepColor = true;
        int animationSpeed = 1;
        int upperSpeedLimit = 10;
        int lowerSpeedLimit = 1;

        int delay = 200;
        int colorDelay = 10;
        int formDelay = 50;

        int standardSlideDelay = 40;
        int[] standardSlugDelay = new int[] { 100, 50 };
        int standardHopDelay = 100;
        int standardShootDelay = 50;
        #endregion

        #region Public Properties


        /// <summary>
        /// Gets or sets the standard animation shoot delay.
        /// </summary>
        /// <value>The standard shoot delay.</value>
        [Category("Animation Delays"),
         Description("Sets the Standard animation shoot delay")]
        public int StandardShootDelay
        {
            get { return standardShootDelay; }
            set
            {
                standardShootDelay = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the standard hop delay.
        /// </summary>
        /// <value>The standard hop delay.</value>
        [Category("Animation Delays"),
         Description("Sets the Standard animation hop delay")]
        public int StandardHopDelay
        {
            get { return standardHopDelay; }
            set
            {
                standardHopDelay = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the standard animation slug delay.
        /// </summary>
        /// <value>The standard animation slug delay.</value>
        [Category("Animation Delays"),
         Description("Sets the Standard animation slug delay")]
        public int[] StandardSlugDelay
        {
            get { return standardSlugDelay; }
            set
            {
                standardSlugDelay = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the standard animation slide delay.
        /// </summary>
        /// <value>The standard animation slide delay.</value>
        [Category("Animation Delays"),
         Description("Sets the Standard animation slide delay")]
        public int StandardSlideDelay
        {
            get { return standardSlideDelay; }
            set
            {
                standardSlideDelay = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color animation delay.
        /// </summary>
        /// <value>The color animation delay.</value>
        [Category("Animation Delays"),
         Description("Sets the Color animation delay")]
        public int ColorAnimationDelay
        {
            get { return colorDelay; }
            set
            {
                colorDelay = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the form animation delay.
        /// </summary>
        /// <value>The form animation delay.</value>
        [Category("Animation Delays"),
         Description("Sets the Form animation delay")]
        public int FormAnimationDelay
        {
            get { return formDelay; }
            set
            {
                formDelay = value;
                control.Invalidate();
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
            get { return upperSpeedLimit; }
            set
            {
                upperSpeedLimit = value;
                control.Invalidate();
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
            get { return lowerSpeedLimit; }
            set
            {
                lowerSpeedLimit = value;
                control.Invalidate();
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
            get { return _animationMode; }
            set
            {
                _animationMode = value;
                control.Invalidate();
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
            get { return _colorAnimation; }
            set
            {
                _colorAnimation = value;
                control.Invalidate();
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
            get { return _formAnimation; }
            set
            {
                _formAnimation = value;
                control.Invalidate();
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
            get { return _standardAnimation; }
            set
            {
                _standardAnimation = value;
                control.Invalidate();
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
            get { return delay; }
            set
            {
                delay = value;
                control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the animation speed.
        /// </summary>
        /// <value>The animation speed.</value>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Value must be greater than 1
        /// or
        /// Value must be less than 10
        /// </exception>
        [Category("General Animation"),
         Description("Sets the Animation Speed")]
        public int AnimationSpeed
        {
            get { return animationSpeed; }
            set
            {
                if (value < lowerSpeedLimit)
                {
                    value = 1;
                    throw new ArgumentOutOfRangeException("Value must be greater than 1");
                }

                if (value > upperSpeedLimit)
                {
                    value = 10;
                    throw new ArgumentOutOfRangeException("Value must be less than 10");
                }

                animationSpeed = value;
                control.Invalidate();
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
            get { return keepColor; }
            set
            {
                keepColor = value;
                control.Invalidate();

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
            get { return color; }
            set
            {
                color = value;
                control.Invalidate();
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
            get { return control; }
            set
            {
                control = value;
                control.Invalidate();
            }
        }
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitOJAnim"/> class.
        /// </summary>
        public ZeroitOJAnim()
        {
        }

        public void ColorAnimate()
        {

            Graphics graphic = control.CreateGraphics();

            #region Old Code
            //object animationObject = control;
            //
            //         //control = animationObject as Control;

            //         if (animationSpeed < 1)
            //{
            //	animationSpeed = 1;
            //}
            //if (animationSpeed > 10)
            //{
            //	animationSpeed = 10;
            //}

            //if (animationSpeed < 1)
            //{
            //	animationSpeed = 1;
            //}
            //if (animationSpeed > 10)
            //{
            //	animationSpeed = 10;
            //}

            //         if (animation == ZeroitOJAnim.ColorAnimation.FillEllipse)
            //{
            //             int num = 1;
            //             int width = control.Width;
            //             if (control.Height > control.Width)
            //             {
            //                 width = control.Height;
            //             }
            //             width = width + 200 + 10 * animationSpeed;
            //             while (num < width)
            //             {
            //                 graphic.FillEllipse(new SolidBrush(color), control.Width / 2 - num / 2, control.Height / 2 - num / 2, num, num);
            //                 this.WaitAnimation(10);
            //                 num = num + 10 * animationSpeed;
            //             }
            //         }
            //if (animation == ZeroitOJAnim.ColorAnimation.FillSquare)
            //{
            //	int num1 = 1;
            //	int height = control.Width;
            //	if (control.Height > control.Width)
            //	{
            //		height = control.Height;
            //	}
            //	height = height + 200;
            //	while (num1 < height)
            //	{
            //		graphic.FillRectangle(new SolidBrush(color), control.Width / 2 - num1 / 2, control.Height / 2 - num1 / 2, num1, num1);
            //		this.WaitAnimation(10);
            //		num1 = num1 + 10 * animationSpeed;
            //	}
            //}
            //if (animation == ZeroitOJAnim.ColorAnimation.SlideFill)
            //{
            //	for (int i = 10; i < control.Width + 10 * animationSpeed; i = i + 10 * animationSpeed)
            //	{
            //		graphic.FillRectangle(new SolidBrush(color), 0, 0, i, control.Height);
            //		this.WaitAnimation(10);
            //	}
            //}
            //if (animation == ZeroitOJAnim.ColorAnimation.StripeFill)
            //{
            //	int num2 = 10;
            //	int height1 = control.Height / 10 + 5;
            //	while (num2 < control.Width + 10 * animationSpeed)
            //	{
            //		graphic.FillRectangle(new SolidBrush(color), 0, 0, num2, height1);
            //		graphic.FillRectangle(new SolidBrush(color), control.Width - num2, height1, num2, height1);
            //		graphic.FillRectangle(new SolidBrush(color), 0, height1 * 2, num2, height1);
            //		graphic.FillRectangle(new SolidBrush(color), control.Width - num2, height1 * 3, num2, height1);
            //		graphic.FillRectangle(new SolidBrush(color), 0, height1 * 4, num2, height1);
            //		graphic.FillRectangle(new SolidBrush(color), control.Width - num2, height1 * 5, num2, height1);
            //		graphic.FillRectangle(new SolidBrush(color), 0, height1 * 6, num2, height1);
            //		graphic.FillRectangle(new SolidBrush(color), control.Width - num2, height1 * 7, num2, height1);
            //		graphic.FillRectangle(new SolidBrush(color), 0, height1 * 8, num2, height1);
            //		graphic.FillRectangle(new SolidBrush(color), control.Width - num2, height1 * 9, num2, height1);
            //		graphic.FillRectangle(new SolidBrush(color), 0, height1 * 10, num2, height1);
            //		this.WaitAnimation(10);
            //		num2 = num2 + 10 * animationSpeed;
            //	}
            //}
            //if (animation == ZeroitOJAnim.ColorAnimation.SplitFill)
            //{
            //	int num3 = 10;
            //	int width1 = control.Width + 10 * animationSpeed;
            //	while (num3 < width1)
            //	{
            //		graphic.FillRectangle(new SolidBrush(color), 0, control.Height / 2 - num3 / 2, control.Width, num3);
            //		this.WaitAnimation(10);
            //		num3 = num3 + 10 * animationSpeed;
            //	}
            //} 
            #endregion

            switch (_colorAnimation)
            {
                case ZeroitObjectColorAnimation.FillEllipse:
                    int num = 1;
                    int width = control.Width;
                    if (control.Height > control.Width)
                    {
                        width = control.Height;
                    }
                    width = width + 200 + 10 * animationSpeed;
                    while (num < width)
                    {
                        graphic.FillEllipse(new SolidBrush(color), control.Width / 2 - num / 2, control.Height / 2 - num / 2, num, num);
                        this.WaitAnimation(colorDelay);
                        num = num + 10 * animationSpeed;
                    }
                    break;
                case ZeroitObjectColorAnimation.FillSquare:
                    int num1 = 1;
                    int height = control.Width;
                    if (control.Height > control.Width)
                    {
                        height = control.Height;
                    }
                    height = height + 200;
                    while (num1 < height)
                    {
                        graphic.FillRectangle(new SolidBrush(color), control.Width / 2 - num1 / 2, control.Height / 2 - num1 / 2, num1, num1);
                        this.WaitAnimation(colorDelay);
                        num1 = num1 + 10 * animationSpeed;
                    }
                    break;
                case ZeroitObjectColorAnimation.SlideFill:
                    for (int i = 10; i < control.Width + 10 * animationSpeed; i = i + 10 * animationSpeed)
                    {
                        graphic.FillRectangle(new SolidBrush(color), 0, 0, i, control.Height);
                        this.WaitAnimation(colorDelay);
                    }
                    break;
                case ZeroitObjectColorAnimation.StripeFill:
                    int num2 = 10;
                    int height1 = control.Height / 10 + 5;
                    while (num2 < control.Width + 10 * animationSpeed)
                    {
                        graphic.FillRectangle(new SolidBrush(color), 0, 0, num2, height1);
                        graphic.FillRectangle(new SolidBrush(color), control.Width - num2, height1, num2, height1);
                        graphic.FillRectangle(new SolidBrush(color), 0, height1 * 2, num2, height1);
                        graphic.FillRectangle(new SolidBrush(color), control.Width - num2, height1 * 3, num2, height1);
                        graphic.FillRectangle(new SolidBrush(color), 0, height1 * 4, num2, height1);
                        graphic.FillRectangle(new SolidBrush(color), control.Width - num2, height1 * 5, num2, height1);
                        graphic.FillRectangle(new SolidBrush(color), 0, height1 * 6, num2, height1);
                        graphic.FillRectangle(new SolidBrush(color), control.Width - num2, height1 * 7, num2, height1);
                        graphic.FillRectangle(new SolidBrush(color), 0, height1 * 8, num2, height1);
                        graphic.FillRectangle(new SolidBrush(color), control.Width - num2, height1 * 9, num2, height1);
                        graphic.FillRectangle(new SolidBrush(color), 0, height1 * 10, num2, height1);
                        this.WaitAnimation(colorDelay);
                        num2 = num2 + 10 * animationSpeed;
                    }
                    break;
                case ZeroitObjectColorAnimation.SplitFill:
                    int num3 = 10;
                    int width1 = control.Width + 10 * animationSpeed;
                    while (num3 < width1)
                    {
                        graphic.FillRectangle(new SolidBrush(color), 0, control.Height / 2 - num3 / 2, control.Width, num3);
                        this.WaitAnimation(colorDelay);
                        num3 = num3 + 10 * animationSpeed;
                    }
                    break;
                default:
                    break;
            }

            this.WaitAnimation(delay);
            graphic.Dispose();
            if (keepColor)
            {
                control.BackColor = color;
            }
            control.Refresh();
        }

        public void FormAnimate()
        {

            System.Windows.Forms.Form animationForm = control.FindForm();

            #region Old Code
            //if (animationSpeed < 1)
            //{
            //	animationSpeed = 1;
            //}
            //if (animationSpeed > 10)
            //{
            //	animationSpeed = 10;
            //}

            //if (animation == ZeroitOJAnim.formAnimation.FadeIn)
            //{
            //	animationForm.Opacity = 0;
            //	while (animationForm.Opacity < 100)
            //	{
            //		animationForm.Opacity = 0.01 * (double)animationSpeed + animationForm.Opacity;
            //		this.WaitAnimation(50);
            //	}
            //}
            //if (animation == ZeroitOJAnim.formAnimation.FadeOut)
            //{
            //	animationForm.Opacity = 1;
            //	while (animationForm.Opacity > 0.1)
            //	{
            //		animationForm.Opacity = animationForm.Opacity - 0.01 * (double)animationSpeed;
            //		this.WaitAnimation(50);
            //	}
            //} 
            #endregion

            switch (_formAnimation)
            {
                case ZeroitObjectFormAnimation.FadeIn:
                    animationForm.Opacity = 0;
                    while (animationForm.Opacity < 100)
                    {
                        animationForm.Opacity = 0.01 * (double)animationSpeed + animationForm.Opacity;
                        this.WaitAnimation(formDelay);

                        animationForm.Invalidate();
                    }
                    break;
                case ZeroitObjectFormAnimation.FadeOut:
                    animationForm.Opacity = 1;
                    while (animationForm.Opacity > 0.1)
                    {
                        animationForm.Opacity = animationForm.Opacity - 0.01 * (double)animationSpeed;
                        this.WaitAnimation(formDelay);

                        animationForm.Invalidate();
                    }
                    break;
                default:
                    break;
            }

            
        }

        public void StandardAnimate()
        {

            #region Old Code
            //Control point = animationObject as Control;
            //Control point = control;
            //if (animationSpeed < 1)
            //{
            //	animationSpeed = 1;
            //}
            //if (animationSpeed > 10)
            //{
            //	animationSpeed = 10;
            //}
            //if (animation == ZeroitOJAnim.standardAnimation.SlideRight)
            //{
            //	int x = control.Location.X;
            //	int width = 0 - control.Width;
            //	location = control.Location;
            //	control.Location = new Point(width, location.Y);
            //	control.Refresh();
            //	while (control.Location.X < x / 2)
            //	{
            //		location = control.Location;
            //		int num = location.X + 10 * animationSpeed;
            //		location = control.Location;
            //		control.Location = new Point(num, location.Y);
            //		control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (control.Location.X < x / 4)
            //	{
            //		location = control.Location;
            //		int x1 = location.X + 7 * animationSpeed;
            //		location = control.Location;
            //		control.Location = new Point(x1, location.Y);
            //		control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (control.Location.X < x / 8)
            //	{
            //		location = control.Location;
            //		int num1 = location.X + 5 * animationSpeed;
            //		location = control.Location;
            //		control.Location = new Point(num1, location.Y);
            //		control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (control.Location.X < x)
            //	{
            //		location = control.Location;
            //		int x2 = location.X + 2 * animationSpeed;
            //		location = control.Location;
            //		control.Location = new Point(x2, location.Y);
            //		control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	location = control.Location;
            //	control.Location = new Point(x, location.Y);
            //}
            //if (animation == ZeroitOJAnim.standardAnimation.SlideLeft)
            //{
            //	int num2 = control.Location.X;
            //	int width1 = control.Parent.Width + control.Width;
            //	location = control.Location;
            //	control.Location = new Point(width1, location.Y);
            //	control.Refresh();
            //	while (control.Location.X > num2 + control.Width / 2)
            //	{
            //		location = control.Location;
            //		int x3 = location.X - 10 * animationSpeed;
            //		location = control.Location;
            //		control.Location = new Point(x3, location.Y);
            //		control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (control.Location.X > num2 + control.Width / 4)
            //	{
            //		location = control.Location;
            //		int num3 = location.X - 7 * animationSpeed;
            //		location = control.Location;
            //		control.Location = new Point(num3, location.Y);
            //		control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (control.Location.X > num2 + control.Width / 8)
            //	{
            //		location = control.Location;
            //		int x4 = location.X - 5 * animationSpeed;
            //		location = control.Location;
            //		control.Location = new Point(x4, location.Y);
            //		control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (control.Location.X > num2)
            //	{
            //		location = control.Location;
            //		int num4 = location.X - 2 * animationSpeed;
            //		location = control.Location;
            //		control.Location = new Point(num4, location.Y);
            //		control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	location = control.Location;
            //	control.Location = new Point(num2, location.Y);
            //}
            //if (animation == ZeroitOJAnim.standardAnimation.SlideDown)
            //{
            //	int y = control.Location.Y;
            //	location = control.Location;
            //	control.Location = new Point(location.X, 0 - control.Height);
            //	control.Refresh();
            //	while (control.Location.Y < y / 2)
            //	{
            //		int x5 = control.Location.X;
            //		location = control.Location;
            //		control.Location = new Point(x5, location.Y + 10 * animationSpeed);
            //		control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (control.Location.Y < y / 4)
            //	{
            //		int num5 = control.Location.X;
            //		location = control.Location;
            //		control.Location = new Point(num5, location.Y + 7 * animationSpeed);
            //		control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (control.Location.Y < y / 8)
            //	{
            //		int x6 = control.Location.X;
            //		location = control.Location;
            //		control.Location = new Point(x6, location.Y + 5 * animationSpeed);
            //		control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (control.Location.Y < y)
            //	{
            //		int num6 = control.Location.X;
            //		location = control.Location;
            //		control.Location = new Point(num6, location.Y + 2 * animationSpeed);
            //		control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	location = control.Location;
            //	control.Location = new Point(location.X, y);
            //}
            //if (animation == ZeroitOJAnim.standardAnimation.SlideUp)
            //{
            //	int y1 = control.Location.Y;
            //	location = control.Location;
            //	control.Location = new Point(location.X, control.Parent.Height + control.Height);
            //	control.Refresh();
            //	while (control.Location.Y > y1 + control.Height / 2)
            //	{
            //		int x7 = control.Location.X;
            //		location = control.Location;
            //		control.Location = new Point(x7, location.Y - 10 * animationSpeed);
            //		control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (control.Location.Y > y1 + control.Height / 4)
            //	{
            //		int num7 = control.Location.X;
            //		location = control.Location;
            //		control.Location = new Point(num7, location.Y - 7 * animationSpeed);
            //		control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (control.Location.Y > y1 + control.Height / 8)
            //	{
            //		int x8 = control.Location.X;
            //		location = control.Location;
            //		control.Location = new Point(x8, location.Y - 5 * animationSpeed);
            //		control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	while (control.Location.Y > y1)
            //	{
            //		int num8 = control.Location.X;
            //		location = control.Location;
            //		control.Location = new Point(num8, location.Y - 2 * animationSpeed);
            //		control.Refresh();
            //		this.WaitAnimation(40);
            //	}
            //	location = control.Location;
            //	control.Location = new Point(location.X, y1);
            //}
            //if (animation == ZeroitOJAnim.standardAnimation.SlugRight)
            //{
            //	int x9 = control.Location.X;
            //	int width2 = control.Width;
            //	int width3 = 0 - control.Width;
            //	location = control.Location;
            //	control.Location = new Point(width3, location.Y);
            //	control.Refresh();
            //	while (control.Location.X < x9)
            //	{
            //		location = control.Location;
            //		int num9 = location.X + 8 * animationSpeed;
            //		location = control.Location;
            //		control.Location = new Point(num9, location.Y);
            //		control.Refresh();
            //		control.Refresh();
            //		this.WaitAnimation(100 / animationSpeed);
            //		while (control.Width > width2 / 2)
            //		{
            //			control.Width = control.Width - 3 * animationSpeed;
            //			control.Refresh();
            //			this.WaitAnimation(50 / animationSpeed);
            //		}
            //		while (control.Width < width2)
            //		{
            //			control.Width = control.Width + 3 * animationSpeed;
            //			control.Refresh();
            //			this.WaitAnimation(50 / animationSpeed);
            //		}
            //	}
            //	location = control.Location;
            //	control.Location = new Point(x9, location.Y);
            //	control.Width = width2;
            //	control.Refresh();
            //}
            //if (animation == ZeroitOJAnim.standardAnimation.SlugLeft)
            //{
            //	int x10 = control.Location.X;
            //	int width4 = control.Width;
            //	int width5 = control.Parent.Width + control.Width;
            //	location = control.Location;
            //	control.Location = new Point(width5, location.Y);
            //	control.Refresh();
            //	while (control.Location.X > x10)
            //	{
            //		location = control.Location;
            //		int num10 = location.X - 8 * animationSpeed;
            //		location = control.Location;
            //		control.Location = new Point(num10, location.Y);
            //		control.Refresh();
            //		control.Refresh();
            //		this.WaitAnimation(100 / animationSpeed);
            //		while (control.Width > width4 / 2)
            //		{
            //			control.Width = control.Width - 3 * animationSpeed;
            //			control.Refresh();
            //			this.WaitAnimation(50 / animationSpeed);
            //		}
            //		while (control.Width < width4)
            //		{
            //			control.Width = control.Width + 3 * animationSpeed;
            //			control.Refresh();
            //			this.WaitAnimation(50 / animationSpeed);
            //		}
            //	}
            //	location = control.Location;
            //	control.Location = new Point(x10, location.Y);
            //	control.Width = width4;
            //	control.Refresh();
            //}
            //if (animation == ZeroitOJAnim.standardAnimation.Hop)
            //{
            //	int y2 = control.Location.Y;
            //	while (control.Location.Y > y2 - 20)
            //	{
            //		while (control.Location.Y > y2 - 10)
            //		{
            //			int x11 = control.Location.X;
            //			location = control.Location;
            //			control.Location = new Point(x11, location.Y - 5);
            //			control.Refresh();
            //			this.WaitAnimation(100 / animationSpeed);
            //		}
            //		while (control.Location.Y > y2 - 18)
            //		{
            //			int num11 = control.Location.X;
            //			location = control.Location;
            //			control.Location = new Point(num11, location.Y - 4);
            //			control.Refresh();
            //			this.WaitAnimation(100 / animationSpeed);
            //		}
            //		while (control.Location.Y > y2 - 20)
            //		{
            //			int x12 = control.Location.X;
            //			location = control.Location;
            //			control.Location = new Point(x12, location.Y - 2);
            //			control.Refresh();
            //			this.WaitAnimation(100 / animationSpeed);
            //		}
            //	}
            //	while (control.Location.Y < y2)
            //	{
            //		while (control.Location.Y < y2 - 18)
            //		{
            //			int num12 = control.Location.X;
            //			location = control.Location;
            //			control.Location = new Point(num12, location.Y + 2);
            //			control.Refresh();
            //			this.WaitAnimation(100 / animationSpeed);
            //		}
            //		while (control.Location.Y < y2 - 20)
            //		{
            //			int x13 = control.Location.X;
            //			location = control.Location;
            //			control.Location = new Point(x13, location.Y + 6);
            //			control.Refresh();
            //			this.WaitAnimation(100 / animationSpeed);
            //		}
            //		location = control.Location;
            //		control.Location = new Point(location.X, y2);
            //	}
            //}
            //if (animation == ZeroitOJAnim.standardAnimation.ShootRight)
            //{
            //	int num13 = control.Location.X;
            //	int y3 = control.Location.Y;
            //	Size size = control.Size;
            //	control.Size = new Size(control.Width, 6);
            //	control.Refresh();
            //	int width6 = 0 - control.Width;
            //	location = control.Location;
            //	control.Location = new Point(width6, location.Y + size.Height / 2 - 3);
            //	control.Refresh();
            //	while (control.Width - size.Width < num13 + size.Width)
            //	{
            //		control.Size = new Size(control.Width + 50, control.Height);
            //		control.Refresh();
            //		this.WaitAnimation(50 / animationSpeed);
            //	}
            //	control.Size = new Size(num13 + size.Width * 2, control.Height);
            //	control.Refresh();
            //	while (control.Location.X < num13)
            //	{
            //		location = control.Location;
            //		int x14 = location.X + 25;
            //		location = control.Location;
            //		control.Location = new Point(x14, location.Y);
            //		control.Size = new Size(control.Width - 25, control.Height);
            //		control.Refresh();
            //		this.WaitAnimation(50 / animationSpeed);
            //	}
            //	control.Size = size;
            //	control.Location = new Point(num13, y3);
            //	control.Refresh();
            //}
            //if (animation == ZeroitOJAnim.standardAnimation.ShootLeft)
            //{
            //	int num14 = control.Location.X;
            //	int y4 = control.Location.Y;
            //	Size size1 = control.Size;
            //	control.Size = new Size(control.Width, 6);
            //	control.Refresh();
            //	int width7 = control.Parent.Width + control.Width;
            //	location = control.Location;
            //	control.Location = new Point(width7, location.Y + size1.Height / 2 - 3);
            //	control.Refresh();
            //	while (control.Location.X > num14)
            //	{
            //		control.Size = new Size(control.Width + 50, control.Height);
            //		location = control.Location;
            //		int x15 = location.X - 50;
            //		location = control.Location;
            //		control.Location = new Point(x15, location.Y);
            //		control.Refresh();
            //		this.WaitAnimation(50 / animationSpeed);
            //	}
            //	control.Size = new Size(num14 + size1.Width * 2, control.Height);
            //	control.Refresh();
            //	while (control.Location.X + control.Width > size1.Width)
            //	{
            //		control.Size = new Size(control.Width - 25, control.Height);
            //		control.Refresh();
            //		this.WaitAnimation(50 / animationSpeed);
            //	}
            //	control.Size = size1;
            //	control.Location = new Point(num14, y4);
            //	control.Refresh();
            //} 
            #endregion


            switch (_standardAnimation)
            {
                case ZeroitObjectStandardAnimation.SlideUp:
                    int y1 = control.Location.Y;
                    location = control.Location;
                    if (control == control.FindForm())
                    {
                        control.Location = new Point(location.X, control.Height + control.Height);
                    }
                    else
                    {
                        control.Location = new Point(location.X, control.Parent.Height + control.Height);
                    }

                    control.Refresh();
                    while (control.Location.Y > y1 + control.Height / 2)
                    {
                        int x7 = control.Location.X;
                        location = control.Location;
                        control.Location = new Point(x7, location.Y - 10 * animationSpeed);
                        control.Refresh();
                        this.WaitAnimation(standardSlideDelay);
                    }
                    while (control.Location.Y > y1 + control.Height / 4)
                    {
                        int num7 = control.Location.X;
                        location = control.Location;
                        control.Location = new Point(num7, location.Y - 7 * animationSpeed);
                        control.Refresh();
                        this.WaitAnimation(standardSlideDelay);
                    }
                    while (control.Location.Y > y1 + control.Height / 8)
                    {
                        int x8 = control.Location.X;
                        location = control.Location;
                        control.Location = new Point(x8, location.Y - 5 * animationSpeed);
                        control.Refresh();
                        this.WaitAnimation(standardSlideDelay);
                    }
                    while (control.Location.Y > y1)
                    {
                        int num8 = control.Location.X;
                        location = control.Location;
                        control.Location = new Point(num8, location.Y - 2 * animationSpeed);
                        control.Refresh();
                        this.WaitAnimation(standardSlideDelay);
                    }
                    location = control.Location;
                    control.Location = new Point(location.X, y1);
                    break;
                case ZeroitObjectStandardAnimation.SlideDown:
                    int y = control.Location.Y;
                    location = control.Location;
                    control.Location = new Point(location.X, 0 - control.Height);
                    control.Refresh();
                    while (control.Location.Y < y / 2)
                    {
                        int x5 = control.Location.X;
                        location = control.Location;
                        control.Location = new Point(x5, location.Y + 10 * animationSpeed);
                        control.Refresh();
                        this.WaitAnimation(standardSlideDelay);
                    }
                    while (control.Location.Y < y / 4)
                    {
                        int num5 = control.Location.X;
                        location = control.Location;
                        control.Location = new Point(num5, location.Y + 7 * animationSpeed);
                        control.Refresh();
                        this.WaitAnimation(standardSlideDelay);
                    }
                    while (control.Location.Y < y / 8)
                    {
                        int x6 = control.Location.X;
                        location = control.Location;
                        control.Location = new Point(x6, location.Y + 5 * animationSpeed);
                        control.Refresh();
                        this.WaitAnimation(standardSlideDelay);
                    }
                    while (control.Location.Y < y)
                    {
                        int num6 = control.Location.X;
                        location = control.Location;
                        control.Location = new Point(num6, location.Y + 2 * animationSpeed);
                        control.Refresh();
                        this.WaitAnimation(standardSlideDelay);
                    }
                    location = control.Location;
                    control.Location = new Point(location.X, y);
                    break;
                case ZeroitObjectStandardAnimation.SlideLeft:
                    int num2 = control.Location.X;
                    int width1;
                    if (control == control.FindForm())
                    {
                        width1 = control.Width + control.Width;
                    }
                    else
                    {
                        width1 = control.Parent.Width + control.Width;
                    }

                    location = control.Location;
                    control.Location = new Point(width1, location.Y);
                    control.Refresh();
                    while (control.Location.X > num2 + control.Width / 2)
                    {
                        location = control.Location;
                        int x3 = location.X - 10 * animationSpeed;
                        location = control.Location;
                        control.Location = new Point(x3, location.Y);
                        control.Refresh();
                        this.WaitAnimation(standardSlideDelay);
                    }
                    while (control.Location.X > num2 + control.Width / 4)
                    {
                        location = control.Location;
                        int num3 = location.X - 7 * animationSpeed;
                        location = control.Location;
                        control.Location = new Point(num3, location.Y);
                        control.Refresh();
                        this.WaitAnimation(standardSlideDelay);
                    }
                    while (control.Location.X > num2 + control.Width / 8)
                    {
                        location = control.Location;
                        int x4 = location.X - 5 * animationSpeed;
                        location = control.Location;
                        control.Location = new Point(x4, location.Y);
                        control.Refresh();
                        this.WaitAnimation(standardSlideDelay);
                    }
                    while (control.Location.X > num2)
                    {
                        location = control.Location;
                        int num4 = location.X - 2 * animationSpeed;
                        location = control.Location;
                        control.Location = new Point(num4, location.Y);
                        control.Refresh();
                        this.WaitAnimation(standardSlideDelay);
                    }
                    location = control.Location;
                    control.Location = new Point(num2, location.Y);
                    break;
                case ZeroitObjectStandardAnimation.SlideRight:
                    int x = control.Location.X;
                    int width = 0 - control.Width;
                    location = control.Location;
                    control.Location = new Point(width, location.Y);
                    control.Refresh();
                    while (control.Location.X < x / 2)
                    {
                        location = control.Location;
                        int num = location.X + 10 * animationSpeed;
                        location = control.Location;
                        control.Location = new Point(num, location.Y);
                        control.Refresh();
                        this.WaitAnimation(standardSlideDelay);
                    }
                    while (control.Location.X < x / 4)
                    {
                        location = control.Location;
                        int x1 = location.X + 7 * animationSpeed;
                        location = control.Location;
                        control.Location = new Point(x1, location.Y);
                        control.Refresh();
                        this.WaitAnimation(standardSlideDelay);
                    }
                    while (control.Location.X < x / 8)
                    {
                        location = control.Location;
                        int num1 = location.X + 5 * animationSpeed;
                        location = control.Location;
                        control.Location = new Point(num1, location.Y);
                        control.Refresh();
                        this.WaitAnimation(standardSlideDelay);
                    }
                    while (control.Location.X < x)
                    {
                        location = control.Location;
                        int x2 = location.X + 2 * animationSpeed;
                        location = control.Location;
                        control.Location = new Point(x2, location.Y);
                        control.Refresh();
                        this.WaitAnimation(standardSlideDelay);
                    }
                    location = control.Location;
                    control.Location = new Point(x, location.Y);
                    break;
                case ZeroitObjectStandardAnimation.SlugRight:
                    int x9 = control.Location.X;
                    int width2 = control.Width;
                    int width3 = 0 - control.Width;
                    location = control.Location;
                    control.Location = new Point(width3, location.Y);
                    control.Refresh();
                    while (control.Location.X < x9)
                    {
                        location = control.Location;
                        int num9 = location.X + 8 * animationSpeed;
                        location = control.Location;
                        control.Location = new Point(num9, location.Y);
                        control.Refresh();
                        control.Refresh();
                        this.WaitAnimation(standardSlugDelay[0] / animationSpeed);
                        while (control.Width > width2 / 2)
                        {
                            control.Width = control.Width - 3 * animationSpeed;
                            control.Refresh();
                            this.WaitAnimation(standardSlugDelay[1] / animationSpeed);
                        }
                        while (control.Width < width2)
                        {
                            control.Width = control.Width + 3 * animationSpeed;
                            control.Refresh();
                            this.WaitAnimation(standardSlugDelay[1] / animationSpeed);
                        }
                    }
                    location = control.Location;
                    control.Location = new Point(x9, location.Y);
                    control.Width = width2;
                    control.Refresh();
                    break;
                case ZeroitObjectStandardAnimation.SlugLeft:
                    int x10 = control.Location.X;
                    int width4 = control.Width;
                    int width5;
                    if (control == control.FindForm())
                    {
                        width5 = control.Width + control.Width / 3;
                    }
                    else
                    {
                        width5 = control.Parent.Width + control.Width;
                    }

                    location = control.Location;
                    control.Location = new Point(width5, location.Y);
                    control.Refresh();
                    while (control.Location.X > x10)
                    {
                        location = control.Location;
                        int num10 = location.X - 8 * animationSpeed;
                        location = control.Location;
                        control.Location = new Point(num10, location.Y);
                        control.Refresh();
                        control.Refresh();
                        this.WaitAnimation(standardSlugDelay[0] / animationSpeed);
                        while (control.Width > width4 / 2)
                        {
                            control.Width = control.Width - 3 * animationSpeed;
                            control.Refresh();
                            this.WaitAnimation(standardSlugDelay[1] / animationSpeed);
                        }
                        while (control.Width < width4)
                        {
                            control.Width = control.Width + 3 * animationSpeed;
                            control.Refresh();
                            this.WaitAnimation(standardSlugDelay[1] / animationSpeed);
                        }
                    }
                    location = control.Location;
                    control.Location = new Point(x10, location.Y);
                    control.Width = width4;
                    control.Refresh();
                    break;
                case ZeroitObjectStandardAnimation.Hop:
                    int y2 = control.Location.Y;
                    while (control.Location.Y > y2 - 20)
                    {
                        while (control.Location.Y > y2 - 10)
                        {
                            int x11 = control.Location.X;
                            location = control.Location;
                            control.Location = new Point(x11, location.Y - 5);
                            control.Refresh();
                            this.WaitAnimation(standardHopDelay / animationSpeed);
                        }
                        while (control.Location.Y > y2 - 18)
                        {
                            int num11 = control.Location.X;
                            location = control.Location;
                            control.Location = new Point(num11, location.Y - 4);
                            control.Refresh();
                            this.WaitAnimation(standardHopDelay / animationSpeed);
                        }
                        while (control.Location.Y > y2 - 20)
                        {
                            int x12 = control.Location.X;
                            location = control.Location;
                            control.Location = new Point(x12, location.Y - 2);
                            control.Refresh();
                            this.WaitAnimation(standardHopDelay / animationSpeed);
                        }
                    }
                    while (control.Location.Y < y2)
                    {
                        while (control.Location.Y < y2 - 18)
                        {
                            int num12 = control.Location.X;
                            location = control.Location;
                            control.Location = new Point(num12, location.Y + 2);
                            control.Refresh();
                            this.WaitAnimation(standardHopDelay / animationSpeed);
                        }
                        while (control.Location.Y < y2 - 20)
                        {
                            int x13 = control.Location.X;
                            location = control.Location;
                            control.Location = new Point(x13, location.Y + 6);
                            control.Refresh();
                            this.WaitAnimation(standardHopDelay / animationSpeed);
                        }
                        location = control.Location;
                        control.Location = new Point(location.X, y2);
                    }
                    break;
                case ZeroitObjectStandardAnimation.ShootRight:
                    int num13 = control.Location.X;
                    int y3 = control.Location.Y;
                    Size size = control.Size;
                    control.Size = new Size(control.Width, 6);
                    control.Refresh();
                    int width6 = 0 - control.Width;
                    location = control.Location;
                    control.Location = new Point(width6, location.Y + size.Height / 2 - 3);
                    control.Refresh();
                    while (control.Width - size.Width < num13 + size.Width)
                    {
                        control.Size = new Size(control.Width + 50, control.Height);
                        control.Refresh();
                        this.WaitAnimation(standardShootDelay / animationSpeed);
                    }
                    control.Size = new Size(num13 + size.Width * 2, control.Height);
                    control.Refresh();
                    while (control.Location.X < num13)
                    {
                        location = control.Location;
                        int x14 = location.X + 25;
                        location = control.Location;
                        control.Location = new Point(x14, location.Y);
                        control.Size = new Size(control.Width - 25, control.Height);
                        control.Refresh();
                        this.WaitAnimation(standardShootDelay / animationSpeed);
                    }
                    control.Size = size;
                    control.Location = new Point(num13, y3);
                    control.Refresh();
                    break;
                case ZeroitObjectStandardAnimation.ShootLeft:
                    int num14 = control.Location.X;
                    int y4 = control.Location.Y;
                    Size size1 = control.Size;
                    control.Size = new Size(control.Width, 6);
                    control.Refresh();
                    int width7;
                    if (control == control.FindForm())
                    {
                        width7 = control.Width + control.Width;
                    }
                    else
                    {
                        width7 = control.Parent.Width + control.Width;
                    }

                    location = control.Location;
                    control.Location = new Point(width7, location.Y + size1.Height / 2 - 3);
                    control.Refresh();
                    while (control.Location.X > num14)
                    {
                        control.Size = new Size(control.Width + 50, control.Height);
                        location = control.Location;
                        int x15 = location.X - 50;
                        location = control.Location;
                        control.Location = new Point(x15, location.Y);
                        control.Refresh();
                        this.WaitAnimation(standardShootDelay / animationSpeed);
                    }
                    control.Size = new Size(num14 + size1.Width * 2, control.Height);
                    control.Refresh();
                    while (control.Location.X + control.Width > size1.Width)
                    {
                        control.Size = new Size(control.Width - 25, control.Height);
                        control.Refresh();
                        this.WaitAnimation(standardShootDelay / animationSpeed);
                    }
                    control.Size = size1;
                    control.Location = new Point(num14, y4);
                    control.Refresh();
                    break;
                default:
                    break;
            }
        }

        private void WaitAnimation(int milliseconds)
        {
            DateTime dateTime = DateTime.Now.AddMilliseconds((double)milliseconds);

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
            switch (_animationMode)
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
