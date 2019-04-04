// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="MetroAnimator.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions
{
    /// <summary>
    /// A class collection for rendering click animation.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    [Description("Sets a click animator on a control.")]
	[DesignerCategory("Code")]
	[ToolboxBitmap(typeof(ZeroitClickAnimator))]
	public class ZeroitClickAnimator : Component
	{

        #region Private Field
        /// <summary>
        /// The click control
        /// </summary>
        private Control _ClickControl;

        /// <summary>
        /// The effect timer
        /// </summary>
        [AccessedThroughProperty("effectTimer")]
        private System.Windows.Forms.Timer _effectTimer;

        /// <summary>
        /// The step
        /// </summary>
        private int _Step;

        /// <summary>
        /// The speed
        /// </summary>
        private int _Speed;

        /// <summary>
        /// The start point
        /// </summary>
        private Point startPoint;

        /// <summary>
        /// The animation color
        /// </summary>
        private Color _AnimationColor;

        /// <summary>
        /// The draw mode
        /// </summary>
        private drawMode _drawMode = drawMode.Circle;

        /// <summary>
        /// The sides
        /// </summary>
        private int sides = 3;
        /// <summary>
        /// The radius
        /// </summary>
        private int radius = 9;
        /// <summary>
        /// The starting angle
        /// </summary>
        private int startingAngle = 90;
        /// <summary>
        /// The center width
        /// </summary>
        private int centerWidth = 18;
        /// <summary>
        /// The center
        /// </summary>
        Point center;
        #endregion

        #region Public Properties

        /// <summary>
        /// Enum for rendering either a circle or rectangular type.
        /// </summary>
        public enum drawMode
        {
            /// <summary>
            /// Sets the mode to circle.
            /// </summary>
            Circle,
            /// <summary>
            /// Sets the mode to rectangle.
            /// </summary>
            Rectangle
        }


        /// <summary>
        /// Gets or sets the animation shape.
        /// </summary>
        /// <value>The shape.</value>
        [Browsable(true)]
        [DefaultValue(typeof(drawMode), "Rectangle")]
        [Description("Sets the animation shape.")]
        public drawMode Shape
        {
            get { return _drawMode; }
            set
            {
                _drawMode = value;

            }
        }

        /// <summary>
        /// Gets or sets the color of the animation.
        /// </summary>
        /// <value>The color of the animation.</value>
        [Browsable(true)]
        [DefaultValue(typeof(Color), "120, 255, 255, 255")]
        [Description("Sets the animation color.")]
        public Color AnimationColor
        {
            get
            {
                return this._AnimationColor;
            }
            set
            {
                this._AnimationColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the control to use.
        /// </summary>
        /// <value>The control to use.</value>
        [Browsable(true)]
        [DefaultValue(null)]
        [Description("Sets the control to use.")]
        public Control ClickControl
        {
            get
            {
                return this._ClickControl;
            }
            set
            {
                this.UnRegisterControl();
                this._ClickControl = value;
                this.RegisterControl();
                if (this._ClickControl != null)
                {
                    this._Speed = checked((int)Math.Round((double)this._ClickControl.Width / 10));
                }
            }
        }


        /// <summary>
        /// Gets or sets the timer.
        /// </summary>
        /// <value>The timer.</value>
        public System.Windows.Forms.Timer Timer
        {
            [DebuggerNonUserCode]
            get
            {
                return this._effectTimer;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                ZeroitClickAnimator metroAnimator = this;
                EventHandler eventHandler = new EventHandler(metroAnimator.effectTimer_Tick);
                if (this._effectTimer != null)
                {
                    this._effectTimer.Tick -= eventHandler;
                }
                this._effectTimer = value;
                if (this._effectTimer != null)
                {
                    this._effectTimer.Tick += eventHandler;
                }
            }
        }

        /// <summary>
        /// Gets or sets the speed of the animation.
        /// </summary>
        /// <value>The speed.</value>
        [Browsable(true)]
        [DefaultValue(10)]
        [Description("Sets the speed of the animation.")]
        public int Speed
        {
            get
            {
                return this._Speed;
            }
            set
            {
                this._Speed = value;
            }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitClickAnimator" /> class.
        /// </summary>
        public ZeroitClickAnimator()
        {
            this.Timer = new System.Windows.Forms.Timer()
            {
                Interval = 10
            };
            this._Step = 0;
            this._Speed = 10;
            this.startPoint = new Point();
            this._AnimationColor = Color.FromArgb(120, 255, 255, 255);
        }

        #endregion

        #region Methods and Overrides

        /// <summary>
        /// Handles the Click event of the control control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void control_Click(object sender, EventArgs e)
        {
            this.Timer.Enabled = true;
            this.startPoint = this._ClickControl.PointToClient(Cursor.Position);
            this._Step = 0;
        }

        /// <summary>
        /// Handles the Paint event of the control control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void control_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            using (SolidBrush solidBrush = new SolidBrush(this._AnimationColor))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rectangle = new Rectangle(checked((int)Math.Round((double)this.startPoint.X - (double)this._Step * ((double)this._Speed / 2))), checked((int)Math.Round((double)this.startPoint.Y - (double)this._Step * ((double)this._Speed / 2))), checked(this._Step * this._Speed), checked(this._Step * this._Speed));

                center = new Point(100 / 2, 100 / 2);
                radius = _ClickControl.Width / 4;
                Point[] PolyGon1 = GetPolygonPoints(sides, radius, startingAngle, center);


                switch (_drawMode)
                {
                    case drawMode.Circle:
                        graphics.FillEllipse(solidBrush, rectangle);
                        break;
                    case drawMode.Rectangle:
                        graphics.FillRectangle(solidBrush, rectangle);
                        break;

                }


            }
            graphics = null;
        }

        /// <summary>
        /// Handles the Tick event of the effectTimer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void effectTimer_Tick(object sender, EventArgs e)
        {
            this._Step = checked(this._Step + 1);
            if (this._ClickControl != null)
            {
                this._ClickControl.Invalidate();
            }
            if (((double)this.startPoint.X >= (double)this._Step * ((double)this._Speed / 2) || (double)this.startPoint.Y >= (double)this._Step * ((double)this._Speed / 2) || (double)(checked(this._ClickControl.Width + this._Speed)) >= (double)this._Step * ((double)this._Speed / 2) || (double)(checked(this._ClickControl.Height + this._Speed)) >= (double)this._Step * ((double)this._Speed / 2) ? false : true))
            {
                this.Timer.Enabled = false;
                this._Step = 0;
            }
        }

        /// <summary>
        /// Registers the control.
        /// </summary>
        private void RegisterControl()
        {
            if (this._ClickControl != null)
            {
                ZeroitClickAnimator metroAnimator = this;
                this._ClickControl.Paint += new PaintEventHandler(metroAnimator.control_Paint);
                ZeroitClickAnimator metroAnimator1 = this;
                this._ClickControl.Click += new EventHandler(metroAnimator1.control_Click);
                this.SetDoubleBuffered(this._ClickControl);
            }
        }

        /// <summary>
        /// Sets the double buffered.
        /// </summary>
        /// <param name="ctrl">The control.</param>
        private void SetDoubleBuffered(Control ctrl)
        {
            if (!SystemInformation.TerminalServerSession)
            {
                PropertyInfo property = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
                property.SetValue(ctrl, true, null);
            }
        }

        /// <summary>
        /// Uns the register control.
        /// </summary>
        private void UnRegisterControl()
        {
            if (this._ClickControl != null)
            {
                ZeroitClickAnimator metroAnimator = this;
                this._ClickControl.Paint -= new PaintEventHandler(metroAnimator.control_Paint);
                ZeroitClickAnimator metroAnimator1 = this;
                this._ClickControl.Click -= new EventHandler(metroAnimator1.control_Click);
            }
        }

        /// <summary>
        /// Return an array of 10 points to be used in a Draw- or FillPolygon method
        /// </summary>
        /// <param name="sides">The sides.</param>
        /// <param name="radius">The radius.</param>
        /// <param name="startingAngle">The starting angle.</param>
        /// <param name="center">The center.</param>
        /// <returns>Array of 10 PointF structures</returns>
        /// <exception cref="ArgumentException">Polygon must have 3 sides or more.</exception>
        public static Point[] GetPolygonPoints(int sides, int radius, int startingAngle, Point center)
        {


            if (sides < 3)
                throw new ArgumentException("Polygon must have 3 sides or more.");

            List<Point> points = new List<Point>();
            float step = 360.0f / sides;

            float angle = startingAngle; //starting angle
            for (double i = startingAngle; i < startingAngle + 360.0; i += step) //go in a circle
            {
                points.Add(DegreesToXY(angle, radius, center));
                angle += step;
            }

            return points.ToArray();
        }

        /// <summary>
        /// Degreeses to xy.
        /// </summary>
        /// <param name="degrees">The degrees.</param>
        /// <param name="radius">The radius.</param>
        /// <param name="origin">The origin.</param>
        /// <returns>Point.</returns>
        public static Point DegreesToXY(float degrees, float radius, Point origin)
        {
            Point xy = new Point();
            double radians = degrees * Math.PI / 180.0;

            xy.X = (int)(Math.Cos(radians) * radius + origin.X);
            xy.Y = (int)(Math.Sin(-radians) * radius + origin.Y);

            return xy;
        }
        /**/
        #endregion


    }
    


}