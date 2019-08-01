// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FormAnimator.cs" company="Zeroit Dev Technologies">
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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;

namespace Zeroit.Framework.Transitions.ZeroitFormAnimator
{
    /// <summary>
    /// Class ZeroitFormAnimator.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    public partial class ZeroitFormAnimator : Component
    {

        #region Private Fields

        /// <summary>
        /// The form
        /// </summary>
        System.Windows.Forms.Form form;

        /// <summary>
        /// The animation
        /// </summary>
        private FormAnimationTypes animation = FormAnimationTypes.LeftToRight;

        /// <summary>
        /// The time
        /// </summary>
        Timer time = new Timer();

        /// <summary>
        /// The positions
        /// </summary>
        Positions positions = new Positions();

        /// <summary>
        /// The opacity
        /// </summary>
        Opacity opacity = new Opacity();

        /// <summary>
        /// The grow
        /// </summary>
        Grow grow = new Grow();

        /// <summary>
        /// The move to point
        /// </summary>
        private bool moveToPoint = false;

        /// <summary>
        /// The move
        /// </summary>
        private Move move = new Move();

        /// <summary>
        /// The locations
        /// </summary>
        Locations locations = new Locations();

        /// <summary>
        /// The shake
        /// </summary>
        Shake shake = new Shake();
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>The time.</value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Category("Timer")]
        public Timer Time
        {
            get { return time; }
            set
            {
                time = value;
            }
        }

        /// <summary>
        /// Gets or sets the positions.
        /// </summary>
        /// <value>The positions.</value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Category("Positions")]
        public Positions Positions
        {
            get { return positions; }
            set
            {
                positions = value;
            }
        }

        /// <summary>
        /// Gets or sets the opacity.
        /// </summary>
        /// <value>The opacity.</value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Category("Opacity")]
        public Opacity Opacity
        {
            get { return opacity; }
            set
            {
                opacity = value;
            }
        }

        /// <summary>
        /// Gets or sets the grow.
        /// </summary>
        /// <value>The grow.</value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Category("Grow")]
        public Grow Grow
        {
            get { return grow; }
            set
            {
                grow = value;
            }
        }

        /// <summary>
        /// Gets or sets the move.
        /// </summary>
        /// <value>The move.</value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Category("Move")]
        public Move Move
        {
            get { return move; }
            set
            {
                move = value;
            }
        }


        /// <summary>
        /// Gets or sets the locations.
        /// </summary>
        /// <value>The locations.</value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Category("Locations")]
        public Locations Locations
        {
            get { return locations; }
            set
            {
                locations = value;
            }
        }

        /// <summary>
        /// Gets or sets the shake.
        /// </summary>
        /// <value>The shake.</value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Category("Shake")]
        public Shake Shake
        {
            get { return shake; }
            set
            {
                shake = value;
            }
        }

        /// <summary>
        /// Gets or sets the animation.
        /// </summary>
        /// <value>The animation.</value>
        [Category("Animation")]
        public FormAnimationTypes Animation
        {
            get { return animation; }
            set
            {
                animation = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [move to point].
        /// </summary>
        /// <value><c>true</c> if [move to point]; otherwise, <c>false</c>.</value>
        [Category("Move")]
        public bool MoveToPoint { get => moveToPoint; set => moveToPoint = value; }
                
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitFormAnimator"/> class.
        /// </summary>
        /// <param name="form">The form.</param>
        public ZeroitFormAnimator(System.Windows.Forms.Form form)
        {
            //this.form = form;
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitFormAnimator"/> class.
        /// </summary>
        /// <param name="container">The container.</param>
        public ZeroitFormAnimator(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Starts the specified form.
        /// </summary>
        /// <param name="Form">The form.</param>
        public void Start(System.Windows.Forms.Form Form)
        {
            form = Form;
            FormAnimations formAnimation = new FormAnimations(Form, Time.Time, Time.StepX, Time.StepY);
            switch (Animation)
            {
                case FormAnimationTypes.LeftToRight:
                    formAnimation.Left2Right(Positions.Start, Positions.End);
                    break;
                case FormAnimationTypes.RightToLeft:
                    formAnimation.Right2Left(Positions.Start, Positions.End);
                    break;
                case FormAnimationTypes.TopToBottom:
                    formAnimation.Top2Bottom(Positions.Start, Positions.End);
                    break;
                case FormAnimationTypes.BottomToTop:
                    formAnimation.Bottom2Top(Positions.Start, Positions.End);
                    break;
                case FormAnimationTypes.FadeIn:
                    formAnimation.FadeIn(Opacity.Start, Opacity.Step);
                    break;
                case FormAnimationTypes.FadeOut:
                    formAnimation.FadeOut(Opacity.Start, Opacity.Step);
                    Form.Opacity = 1;
                    break;
                case FormAnimationTypes.HideControls:
                    FormAnimations.HideControls(Form,Time.Time,false);
                    break;
                case FormAnimationTypes.ShowControls:
                    FormAnimations.ShowControls(Form, Time.Time, false);
                    break;
                case FormAnimationTypes.GrowHorizontal:
                    formAnimation.GrowHorizontal(Grow.Start,Grow.End,Grow.FixWindowWhenGrown);
                    System.Threading.Thread.Sleep(1000);
                    break;
                case FormAnimationTypes.GrowVertical:
                    formAnimation.GrowVertical(Grow.Start, Grow.End, Grow.FixWindowWhenGrown);
                    System.Threading.Thread.Sleep(1000);
                    break;
                case FormAnimationTypes.GrowXY:
                    formAnimation.GrowXY(Grow.StartPoint, Grow.EndPoint, Grow.FixWindowWhenGrown);
                    System.Threading.Thread.Sleep(1000);
                    break;
                case FormAnimationTypes.ShrinkHorizontal:
                    formAnimation.ShrinkHorizontal(Positions.Start, Positions.End);
                    System.Threading.Thread.Sleep(1000);
                    break;
                case FormAnimationTypes.ShrinkVertical:
                    formAnimation.ShrinkVertical(Positions.Start, Positions.End);
                    System.Threading.Thread.Sleep(1000);
                    break;
                case FormAnimationTypes.ShrinkXY:
                    formAnimation.ShrinkXY(Positions.StartPoint, Positions.EndPoint);
                    System.Threading.Thread.Sleep(1000);
                    break;
                case FormAnimationTypes.Move:

                    if(MoveToPoint)
                    {
                        formAnimation.Move(Move.RandomLocations, Move.DirectTrajectory);
                        System.Threading.Thread.Sleep(1000);
                    }
                    else
                    {
                        formAnimation.Move(Move.StartPoint, Move.EndPoint, Move.DirectTrajectory);
                        System.Threading.Thread.Sleep(1000);
                    }
                       
                    break;
                case FormAnimationTypes.GrowMoveXY:
                    formAnimation.GrowMoveXY(Grow.StartPoint, Grow.Size, Grow.Recalculate);
                    System.Threading.Thread.Sleep(2000);
                    break;
                case FormAnimationTypes.ShrinkMoveXY:
                    formAnimation.ShrinkMoveXY(Positions.StartPoint, Positions.Size, Positions.ShrinkToCenter);
                    System.Threading.Thread.Sleep(2000);
                    break;
                case FormAnimationTypes.Shake:

                    switch (Shake.ShakeType)
                    {
                        case ShakeType.Horizontal:
                            formAnimation.ShakeIt(Form.Location, new Point(Form.Location.X + Shake.ShakeDistance, Form.Location.Y), Time.Time * Shake.ShakeSpeed);
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case ShakeType.Vertical:
                            formAnimation.ShakeIt(Form.Location, new Point(Form.Location.X, Form.Location.Y + Shake.ShakeDistance), Time.Time * Shake.ShakeSpeed);
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case ShakeType.Both:
                            formAnimation.ShakeIt(Time.Time * Shake.ShakeSpeed/2);
                            System.Threading.Thread.Sleep(1000);
                            break;
                        default:
                            break;
                    }

                    
                    break;
                case FormAnimationTypes.ShrinkFadeOut:
                    
                    //System.Threading.Thread shakeFOutt1 = new System.Threading.Thread(new System.Threading.ThreadStart(Shk));
                    //System.Threading.Thread shakeFOutt2 = new System.Threading.Thread(new System.Threading.ThreadStart(FOut));
                    //shakeFOutt1.Start();
                    //shakeFOutt2.Start();
                    //shakeFOutt1.Join();
                    //shakeFOutt2.Join();
                    //System.Threading.Thread.Sleep(500);
                    //Form.Opacity = 1;

                    formAnimation = new FormAnimations(Form, 15);
                    formAnimation.ShrinkXY();
                    System.Threading.Thread.Sleep(50);
                    formAnimation = new FormAnimations(Form, 50);
                    formAnimation.FadeOut(101, 3);
                    System.Threading.Thread.Sleep(500);
                    Form.Opacity = 1;
                    System.Threading.Thread.Sleep(1000);
                    break;
                case FormAnimationTypes.DeterminerPosition:

                    switch (Locations.FormLocations)
                    {
                        case FormLocations.TopLeft:
                            Form.Location = formAnimation.DeterminarPos(Constantes.TopLeft);
                            System.Threading.Thread.Sleep(300);
                            break;
                        case FormLocations.TopRight:
                            Form.Location = formAnimation.DeterminarPos(Constantes.TopRight);
                            System.Threading.Thread.Sleep(300);
                            break;
                        case FormLocations.BottomLeft:
                            Form.Location = formAnimation.DeterminarPos(Constantes.BottomLeft);
                            System.Threading.Thread.Sleep(300);
                            break;
                        case FormLocations.BottomRight:
                            Form.Location = formAnimation.DeterminarPos(Constantes.BottomRight);
                            System.Threading.Thread.Sleep(300);
                            break;
                        case FormLocations.TopCenter:
                            Form.Location = formAnimation.DeterminarPos(Constantes.TopCenter);
                            System.Threading.Thread.Sleep(300);
                            break;
                        case FormLocations.BottomCenter:
                            Form.Location = formAnimation.DeterminarPos(Constantes.BottomCenter);
                            System.Threading.Thread.Sleep(300);
                            break;
                        case FormLocations.LeftCenter:
                            Form.Location = formAnimation.DeterminarPos(Constantes.LeftCenter);
                            System.Threading.Thread.Sleep(300);
                            break;
                        case FormLocations.RightCenter:
                            Form.Location = formAnimation.DeterminarPos(Constantes.RightCenter);
                            System.Threading.Thread.Sleep(300);
                            break;
                        case FormLocations.RandomPoint:
                            Form.Location = formAnimation.DeterminarPos(Constantes.RndPoint);
                            System.Threading.Thread.Sleep(300);
                            break;
                        case FormLocations.CenterScreen:
                            Form.Location = formAnimation.DeterminarPos(Constantes.CenterScreen);
                            System.Threading.Thread.Sleep(300);
                            break;
                    }

                    break;
                case FormAnimationTypes.LeftToRightVertical:

                    //System.Threading.Thread t1 = new System.Threading.Thread(new System.Threading.ThreadStart(L2R));
                    //System.Threading.Thread t2 = new System.Threading.Thread(new System.Threading.ThreadStart(GrowV));
                    //t1.Start();
                    //t2.Start();

                    formAnimation.Left2Right(0, formAnimation.DeterminarPos(Constantes.CenterScreen).X);
                    formAnimation.GrowVertical(0, form.Height, false);
                    break;
            }
        }

        /// <summary>
        /// L2s the r.
        /// </summary>
        private void L2R()
        {
            FormAnimations fanim = new FormAnimations(form);
            fanim.Left2Right(0, fanim.DeterminarPos(Constantes.CenterScreen).X);
        }

        /// <summary>
        /// Grows the v.
        /// </summary>
        private void GrowV()
        {
            FormAnimations fanim = new FormAnimations(form);
            fanim.GrowVertical(0, form.Height, false);
        }

        /// <summary>
        /// SHKs this instance.
        /// </summary>
        private void Shk()
        {
            FormAnimations fanim = new FormAnimations(form, 15);
            fanim.ShrinkXY();
        }

        /// <summary>
        /// fs the out.
        /// </summary>
        private void FOut()
        {
            FormAnimations fanim = new FormAnimations(form, 50);
            fanim.FadeOut(101, 3);
        }

        /// <summary>
        /// Delegate crossReference
        /// </summary>
        /// <param name="form">The form.</param>
        public delegate void crossReference(System.Windows.Forms.Form form);

        #endregion

    }
    

}
