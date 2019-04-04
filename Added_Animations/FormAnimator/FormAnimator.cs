// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FormAnimator.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
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
                        formAnimation.Move(Move.RandomLocations.ToArray());
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
                case FormAnimationTypes.ShakeFOut:
                    
                    System.Threading.Thread shakeFOutt1 = new System.Threading.Thread(new System.Threading.ThreadStart(Shk));
                    System.Threading.Thread shakeFOutt2 = new System.Threading.Thread(new System.Threading.ThreadStart(FOut));
                    shakeFOutt1.Start();
                    shakeFOutt2.Start();
                    shakeFOutt1.Join();
                    shakeFOutt2.Join();
                    System.Threading.Thread.Sleep(500);
                    Form.Opacity = 1;
                    
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
                    
                    System.Threading.Thread t1 = new System.Threading.Thread(new System.Threading.ThreadStart(L2R));
                    System.Threading.Thread t2 = new System.Threading.Thread(new System.Threading.ThreadStart(GrowV));
                    t1.Start();
                    t2.Start();
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

    /// <summary>
    /// Class Timer.
    /// </summary>
    public class Timer
    {
        /// <summary>
        /// The time
        /// </summary>
        private int time = 20;

        /// <summary>
        /// The step x
        /// </summary>
        private int stepX = 5;

        /// <summary>
        /// The step y
        /// </summary>
        private int stepY = 5;

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>The time.</value>
        public int Time
        {
            get { return time; }
            set
            {
                time = value;
            }
        }

        /// <summary>
        /// Gets or sets the step x.
        /// </summary>
        /// <value>The step x.</value>
        public int StepX
        {
            get { return stepX; }
            set
            {
                stepX = value;
            }
        }

        /// <summary>
        /// Gets or sets the step y.
        /// </summary>
        /// <value>The step y.</value>
        public int StepY
        {
            get { return stepY; }
            set
            {
                stepY = value;
            }
        }
    }

    /// <summary>
    /// Class Positions.
    /// </summary>
    public class Positions
    {
        /// <summary>
        /// The start
        /// </summary>
        private int start = 0;
        /// <summary>
        /// The end
        /// </summary>
        private int end = 100;
        /// <summary>
        /// The start point
        /// </summary>
        private Point startPoint = new Point(0, 0);
        /// <summary>
        /// The end point
        /// </summary>
        private Point endPoint = new Point(100, 100);

        /// <summary>
        /// The size
        /// </summary>
        private Size size = new Size(200, 200);
        /// <summary>
        /// The recalculate
        /// </summary>
        private bool recalculate = true;

        /// <summary>
        /// Gets or sets the start.
        /// </summary>
        /// <value>The start.</value>
        public int Start { get => start; set => start = value;}
        /// <summary>
        /// Gets or sets the end.
        /// </summary>
        /// <value>The end.</value>
        public int End { get => end; set => end = value; }
        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>The size.</value>
        public Size Size { get => size; set => size = value; }
        /// <summary>
        /// Gets or sets the start point.
        /// </summary>
        /// <value>The start point.</value>
        public Point StartPoint { get => startPoint; set => startPoint = value; }
        /// <summary>
        /// Gets or sets the end point.
        /// </summary>
        /// <value>The end point.</value>
        public Point EndPoint { get => endPoint; set => endPoint = value; }
        /// <summary>
        /// Gets or sets a value indicating whether [shrink to center].
        /// </summary>
        /// <value><c>true</c> if [shrink to center]; otherwise, <c>false</c>.</value>
        public bool ShrinkToCenter { get => recalculate; set => recalculate = value; }
    }

    /// <summary>
    /// Class Opacity.
    /// </summary>
    public class Opacity
    {
        /// <summary>
        /// The start
        /// </summary>
        double start = 0.5;

        /// <summary>
        /// The step
        /// </summary>
        int step = 1;

        /// <summary>
        /// Gets or sets the start.
        /// </summary>
        /// <value>The start.</value>
        public double Start
        {
            get { return start; }
            set
            {
                if(value > 100)
                {
                    value = 100;
                }
                start = value;
            }
        }
        /// <summary>
        /// Gets or sets the step.
        /// </summary>
        /// <value>The step.</value>
        public int Step { get => step; set => step = value; }
    }

    /// <summary>
    /// Class Grow.
    /// </summary>
    public class Grow
    {
        /// <summary>
        /// The start
        /// </summary>
        private int start = 0;
        /// <summary>
        /// The end
        /// </summary>
        private int end = 100;

        /// <summary>
        /// The start point
        /// </summary>
        private Point startPoint = new Point(0,0);
        /// <summary>
        /// The end point
        /// </summary>
        private Point endPoint = new Point(100,100);

        /// <summary>
        /// The size
        /// </summary>
        private Size size = new Size(100, 00);
        /// <summary>
        /// The recalculate
        /// </summary>
        private bool recalculate = true;

        /// <summary>
        /// The fix window when grown
        /// </summary>
        private bool fixWindowWhenGrown = true;

        /// <summary>
        /// Gets or sets the start.
        /// </summary>
        /// <value>The start.</value>
        public int Start { get => start; set => start = value; }
        /// <summary>
        /// Gets or sets the end.
        /// </summary>
        /// <value>The end.</value>
        public int End { get => end; set => end = value; }
        /// <summary>
        /// Gets or sets a value indicating whether [fix window when grown].
        /// </summary>
        /// <value><c>true</c> if [fix window when grown]; otherwise, <c>false</c>.</value>
        public bool FixWindowWhenGrown { get => fixWindowWhenGrown; set => fixWindowWhenGrown = value; }
        /// <summary>
        /// Gets or sets the start point.
        /// </summary>
        /// <value>The start point.</value>
        public Point StartPoint { get => startPoint; set => startPoint = value; }
        /// <summary>
        /// Gets or sets the end point.
        /// </summary>
        /// <value>The end point.</value>
        public Point EndPoint { get => endPoint; set => endPoint = value; }
        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>The size.</value>
        public Size Size { get => size; set => size = value; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Grow"/> is recalculate.
        /// </summary>
        /// <value><c>true</c> if recalculate; otherwise, <c>false</c>.</value>
        public bool Recalculate { get => recalculate; set => recalculate = value; }
    }

    /// <summary>
    /// Class Move.
    /// </summary>
    public class Move
    {
        /// <summary>
        /// The random locations
        /// </summary>
        private List<Point> randomLocations = new List<Point>()
        {
            new Point(10, 10),
            new Point(50,50),
            new Point(100, 100),
            new Point(50, 50),
            new Point(10, 10)

        };

        /// <summary>
        /// The start point
        /// </summary>
        private Point startPoint = new Point(0, 0);
        /// <summary>
        /// The end point
        /// </summary>
        private Point endPoint = new Point(100, 100);
        /// <summary>
        /// The direct trajectory
        /// </summary>
        private bool directTrajectory = true;


        /// <summary>
        /// Gets or sets the random locations.
        /// </summary>
        /// <value>The random locations.</value>
        public List<Point> RandomLocations { get => randomLocations; set => randomLocations = value; }
        /// <summary>
        /// Gets or sets the start point.
        /// </summary>
        /// <value>The start point.</value>
        public Point StartPoint { get => startPoint; set => startPoint = value; }
        /// <summary>
        /// Gets or sets the end point.
        /// </summary>
        /// <value>The end point.</value>
        public Point EndPoint { get => endPoint; set => endPoint = value; }
        /// <summary>
        /// Gets or sets a value indicating whether [direct trajectory].
        /// </summary>
        /// <value><c>true</c> if [direct trajectory]; otherwise, <c>false</c>.</value>
        public bool DirectTrajectory { get => directTrajectory; set => directTrajectory = value; }
    }

    /// <summary>
    /// Class Locations.
    /// </summary>
    public class Locations
    {
        /// <summary>
        /// The form locations
        /// </summary>
        private FormLocations formLocations = FormLocations.TopLeft;

        /// <summary>
        /// Gets or sets the form locations.
        /// </summary>
        /// <value>The form locations.</value>
        public FormLocations FormLocations { get => formLocations; set => formLocations = value; }
    }

    /// <summary>
    /// Class Shake.
    /// </summary>
    public class Shake
    {
        /// <summary>
        /// The shake distance
        /// </summary>
        private int shakeDistance = 30;
        /// <summary>
        /// The shake speed
        /// </summary>
        private int shakeSpeed = 20;
        /// <summary>
        /// The shake type
        /// </summary>
        private ShakeType shakeType = ShakeType.Horizontal;

        /// <summary>
        /// Gets or sets the shake distance.
        /// </summary>
        /// <value>The shake distance.</value>
        public int ShakeDistance { get => shakeDistance; set => shakeDistance = value; }
        /// <summary>
        /// Gets or sets the shake speed.
        /// </summary>
        /// <value>The shake speed.</value>
        public int ShakeSpeed { get => shakeSpeed; set => shakeSpeed = value; }
        /// <summary>
        /// Gets or sets the type of the shake.
        /// </summary>
        /// <value>The type of the shake.</value>
        public ShakeType ShakeType { get => shakeType; set => shakeType = value; }
    }

}
