// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="RotatingCube.cs" company="Zeroit Dev Technologies">
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
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions._HelpingControls.Rotating3DCube
{
    /// <summary>
    /// A class collection for rendering a Rotating Cube
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    [DesignerGenerated]
    [ToolboxItem(false)]
    public class RotatingCube : Control
    {

        #region Private Fields
        /// <summary>
        /// The m timer
        /// </summary>
        private Timer m_timer = new Timer();

        //private Point3D[] m_vertices = new Point3D[9];

        /// <summary>
        /// The m vertices
        /// </summary>
        private Point3D[] m_vertices = new Point3D[] { new Point3D(-1, 1, -1), new Point3D(1, 1, -1), new Point3D(1, -1, -1), new Point3D(-1, -1, -1), new Point3D(-1, 1, 1), new Point3D(1, 1, 1), new Point3D(1, -1, 1), new Point3D(-1, -1, 1) };


        /// <summary>
        /// The m faces
        /// </summary>
        private int[,] m_faces = new int[,] { { 0, 1, 2, 3 }, { 1, 5, 6, 2 }, { 5, 4, 7, 6 }, { 4, 0, 3, 7 }, { 0, 4, 5, 1 }, { 3, 2, 6, 7 } };

        //private Color[] m_colors = new Color[7];
        /// <summary>
        /// The m colors
        /// </summary>
        private Color[] m_colors = new Color[] { Color.BlueViolet, Color.Cyan, Color.Green, Color.Yellow, Color.Violet, Color.LightSkyBlue };

        /// <summary>
        /// The m brushes
        /// </summary>
        private Brush[] m_brushes = new Brush[7];

        /// <summary>
        /// The m angle
        /// </summary>
        private int m_angle;

        /// <summary>
        /// The components
        /// </summary>
        private IContainer components;

        /// <summary>
        /// The t
        /// </summary>
        Point3D[] t = new Point3D[9];
        /// <summary>
        /// The f
        /// </summary>
        int[] f = new int[5];
        /// <summary>
        /// The average z
        /// </summary>
        double[] avgZ = new double[7];
        /// <summary>
        /// The order
        /// </summary>
        int[] order = new int[7];

        /// <summary>
        /// The shrink
        /// </summary>
        private int shrink = 4;

        /// <summary>
        /// The speed adjust
        /// </summary>
        private int speedAdjust = 25;

        #endregion

        #region Public Properties

        /// <summary>
        /// Property for shrinking the Rotating Cube
        /// </summary>
        /// <value>The shrink.</value>
        /// <exception cref="System.ArgumentOutOfRangeException">Value must be more than 1</exception>
        public int Shrink
        {
            get { return shrink; }
            set
            {
                if (value < 2)
                {
                    value = 2;
                    //MessageBox.Show("Value must be more than 1");
                    throw new ArgumentOutOfRangeException("Value must be more than 1");
                }
                shrink = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Property for setting the Colors
        /// </summary>
        /// <value>The colors.</value>
        public Color[] Colors
        {
            get { return m_colors; }
            set
            {
                m_colors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Property for controlling Animation Speed
        /// </summary>
        /// <value>The speed.</value>
        public Timer Speed
        {
            get { return m_timer; }
            set
            {
                m_timer = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Property for addusting the Speed
        /// </summary>
        /// <value>The speed adjust.</value>
        public int SpeedAdjust
        {
            get { return speedAdjust; }
            set
            {
                speedAdjust = value;
                Invalidate();
            }
        }

        #endregion

        #region Include in Private Field


        /// <summary>
        /// The automatic animate
        /// </summary>
        private bool autoAnimate = true;

        #endregion

        #region Include in Public Properties

        /// <summary>
        /// Set to automatically animate the Rotating cube
        /// </summary>
        /// <value><c>true</c> if [automatic animate]; otherwise, <c>false</c>.</value>
        public bool AutoAnimate
        {
            get { return autoAnimate; }
            set
            {
                autoAnimate = value;

                if (value == true)
                {
                    m_timer.Enabled = true;
                }

                else
                {
                    m_timer.Enabled = false;
                }

                Invalidate();
            }
        }

        #endregion

        #region Event

        //private void Timer_Tick(object sender, EventArgs e)
        //{
        //    if (this.Value + 1 > this.Maximum)
        //    {
        //        this.Value = 0;
        //    }

        //    else
        //    {
        //        this.Value++;
        //        Invalidate();
        //    }
        //}

        #endregion


        /// <summary>
        /// Animations the loop.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AnimationLoop(object sender, EventArgs e)
        {
            base.Invalidate();
            this.m_angle = checked(this.m_angle + 1);
        }

        /// <summary>
        /// Create an instance of the Rotating Cube
        /// </summary>
        public RotatingCube()
        {
            
            
            //this.m_vertices = new Point3D[9];
            //this.m_faces = new int[7, 5];
            //this.m_colors = new Color[7];
            //this.m_brushes = new Brush[7];

            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //this.InitCube();

            if (!DesignMode)
            {
                //this.m_timer.Tick += new EventHandler((object a0, EventArgs a1) => this.AnimationLoop());
                m_timer.Tick += AnimationLoop;
                
                if (AutoAnimate)
                {
                    //this.m_timer = new Timer()
                    //{
                    //    Interval = 25
                    //};
                    //m_timer.Interval = 25;

                    this.m_timer.Start();
                }
            }

            if (DesignMode)
            {
                //this.m_timer.Tick += new EventHandler((object a0, EventArgs a1) => this.AnimationLoop());
                this.m_timer.Tick += this.AnimationLoop;
                if (AutoAnimate)
                {
                    //this.m_timer = new Timer()
                    //{
                    //    Interval = 25
                    //};

                    //m_timer.Interval = 25;

                    this.m_timer.Start();
                }
                
            }

            

        }

        /// <summary>
        /// Initializes the cube.
        /// </summary>
        private void InitCube()
        {
            //this.m_vertices = new Point3D[] { new Point3D(-1, 1, -1), new Point3D(1, 1, -1), new Point3D(1, -1, -1), new Point3D(-1, -1, -1), new Point3D(-1, 1, 1), new Point3D(1, 1, 1), new Point3D(1, -1, 1), new Point3D(-1, -1, 1) };
            //this.m_faces = new int[,] { { 0, 1, 2, 3 }, { 1, 5, 6, 2 }, { 5, 4, 7, 6 }, { 4, 0, 3, 7 }, { 0, 4, 5, 1 }, { 3, 2, 6, 7 } };
            //this.m_colors = new Color[] { Color.BlueViolet, Color.Cyan, Color.Green, Color.Yellow, Color.Violet, Color.LightSkyBlue };

            //int i = 0;
            //do
            //{
            //    this.m_brushes[i] = new SolidBrush(this.m_colors[i]);
            //    i++;
            //}
            //while (i <= 5);
        }

        //[DebuggerStepThrough]
        //private void InitializeComponent()
        //{
        //    ComponentResourceManager resources = new ComponentResourceManager(typeof(Main));
        //    this.picCodeNtronix = new PictureBox();
        //    ((ISupportInitialize)this.picCodeNtronix).BeginInit();
        //    base.SuspendLayout();
        //    this.picCodeNtronix.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        //    //this.picCodeNtronix.Image = (Image)resources.GetObject("picCodeNtronix.Image");
        //    this.picCodeNtronix.Location = new Point(239, 286);
        //    this.picCodeNtronix.Name = "picCodeNtronix";
        //    this.picCodeNtronix.Size = new System.Drawing.Size(202, 48);
        //    this.picCodeNtronix.TabIndex = 1;
        //    this.picCodeNtronix.TabStop = false;
        //    //base.AutoScaleDimensions = new SizeF(6f, 13f);
        //    //base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    base.ClientSize = new System.Drawing.Size(438, 333);
        //    base.Controls.Add(this.picCodeNtronix);
        //    base.Name = "Main";
        //    this.Text = "Rotating Cube (GDI+)";
        //    ((ISupportInitialize)this.picCodeNtronix).EndInit();
        //    base.ResumeLayout(false);
        //}


        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            m_timer.Interval = speedAdjust;
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            if (AllowTransparency)
            {
                MakeTransparent(this, e.Graphics);
            }

            
            int i = 0;
            int p = 0;
            int k = 0;
            int l = 0;
            int m = 0;
            int n = 0;
            int o = 0;

            do
            {
                this.m_brushes[i] = new SolidBrush(this.m_colors[i]);
                
                i++;
            }
            while (i <= 5);

            do
            {
                Brush b = new SolidBrush(Color.White);
                Point3D v = this.m_vertices[p];
                t[p] = v.RotateX(this.m_angle).RotateY(this.m_angle).RotateZ(this.m_angle);
                Point3D point3D = t[p];
                object width = base.ClientSize.Width;
                System.Drawing.Size clientSize = base.ClientSize;
                t[p] = (Point3D)point3D.Project(width, clientSize.Height, (Width/2 + Height/2), shrink);
                p++;
            }
            while (p <= 7);
            
            do
            {
                avgZ[k] = (t[this.m_faces[k, 0]].Z + t[this.m_faces[k, 1]].Z + t[this.m_faces[k, 2]].Z + t[this.m_faces[k, 3]].Z) / 4;
                order[k] = k;
                k++;
            }
            while (k <= 5);
            
            do
            {
                int iMax = l;
                for (int j = checked(l + 1); j <= 5; j++)
                {
                    if (avgZ[j] > avgZ[iMax])
                    {
                        iMax = j;
                    }
                }
                if (iMax != l)
                {
                    double tmp = avgZ[l];
                    avgZ[l] = avgZ[iMax];
                    avgZ[iMax] = tmp;
                    tmp = (double)order[l];
                    order[l] = order[iMax];
                    order[iMax] = checked((int)Math.Round(tmp));
                }
                l++;
            }
            while (l <= 4);

            do
            {
                int index = order[m];
                Point[] point = new Point[] { new Point(checked((int)Math.Round(t[this.m_faces[index, 0]].X)), checked((int)Math.Round(t[this.m_faces[index, 0]].Y))), new Point(checked((int)Math.Round(t[this.m_faces[index, 1]].X)), checked((int)Math.Round(t[this.m_faces[index, 1]].Y))), new Point(checked((int)Math.Round(t[this.m_faces[index, 2]].X)), checked((int)Math.Round(t[this.m_faces[index, 2]].Y))), new Point(checked((int)Math.Round(t[this.m_faces[index, 3]].X)), checked((int)Math.Round(t[this.m_faces[index, 3]].Y))) };
                g.FillPolygon(this.m_brushes[index], point);
                m++;
            }
            while (m <= 5);
        }




        #region Transparency


        #region Include in Paint

        private void TransInPaint(Graphics g)
        {
            if (AllowTransparency)
            {
                MakeTransparent(this, g);
            }
        }

        #endregion

        #region Include in Private Field

        private bool allowTransparency = true;

        #endregion

        #region Include in Public Properties

        public bool AllowTransparency
        {
            get { return allowTransparency; }
            set
            {
                allowTransparency = value;

                Invalidate();
            }
        }

        #endregion

        #region Method

        //-----------------------------Include in Paint--------------------------//
        //
        // if(AllowTransparency)
        //  {
        //    MakeTransparent(this,g);
        //  }
        //
        //-----------------------------Include in Paint--------------------------//

        private static void MakeTransparent(Control control, Graphics g)
        {
            var parent = control.Parent;
            if (parent == null) return;
            var bounds = control.Bounds;
            var siblings = parent.Controls;
            int index = siblings.IndexOf(control);
            Bitmap behind = null;
            for (int i = siblings.Count - 1; i > index; i--)
            {
                var c = siblings[i];
                if (!c.Bounds.IntersectsWith(bounds)) continue;
                if (behind == null)
                    behind = new Bitmap(control.Parent.ClientSize.Width, control.Parent.ClientSize.Height);
                c.DrawToBitmap(behind, c.Bounds);
            }
            if (behind == null) return;
            g.DrawImage(behind, control.ClientRectangle, bounds, GraphicsUnit.Pixel);
            behind.Dispose();
        }

        #endregion


        #endregion




    }
}
