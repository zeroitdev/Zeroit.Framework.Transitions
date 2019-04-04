// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="MainForm.cs" company="Zeroit Dev Technologies">
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
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions._HelpingControls.Rotating3DCube
{
    /// <summary>
    /// Class Main.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    [DesignerGenerated]

    public class Main : System.Windows.Forms.Form
    {
        /// <summary>
        /// The m timer
        /// </summary>
        protected Timer m_timer;

        /// <summary>
        /// The m vertices
        /// </summary>
        protected Point3D[] m_vertices;

        /// <summary>
        /// The m faces
        /// </summary>
        protected int[,] m_faces;

        /// <summary>
        /// The m colors
        /// </summary>
        protected Color[] m_colors;

        /// <summary>
        /// The m brushes
        /// </summary>
        protected Brush[] m_brushes;

        /// <summary>
        /// The m angle
        /// </summary>
        protected int m_angle;

        /// <summary>
        /// The components
        /// </summary>
        private IContainer components;

        /// <summary>
        /// Gets or sets the pic code ntronix.
        /// </summary>
        /// <value>The pic code ntronix.</value>
        internal virtual PictureBox picCodeNtronix
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Main"/> class.
        /// </summary>
        public Main()
        {
            base.Load += new EventHandler(this.Main_Load);
            base.Paint += new PaintEventHandler(this.Main_Paint);
            this.m_vertices = new Point3D[9];
            this.m_faces = new int[7, 5];
            this.m_colors = new Color[7];
            this.m_brushes = new Brush[7];
            this.InitializeComponent();
        }

        /// <summary>
        /// Animations the loop.
        /// </summary>
        private void AnimationLoop()
        {
            base.Invalidate();
            this.m_angle = checked(this.m_angle + 1);
        }

        /// <summary>
        /// Disposes of the resources (other than memory) used by the <see cref="T:System.Windows.Forms.Form" />.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if ((!disposing ? false : this.components != null))
                {
                    this.components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        /// <summary>
        /// Initializes the cube.
        /// </summary>
        private void InitCube()
        {
            this.m_vertices = new Point3D[] { new Point3D(-1, 1, -1), new Point3D(1, 1, -1), new Point3D(1, -1, -1), new Point3D(-1, -1, -1), new Point3D(-1, 1, 1), new Point3D(1, 1, 1), new Point3D(1, -1, 1), new Point3D(-1, -1, 1) };
            this.m_faces = new int[,] { { 0, 1, 2, 3 }, { 1, 5, 6, 2 }, { 5, 4, 7, 6 }, { 4, 0, 3, 7 }, { 0, 4, 5, 1 }, { 3, 2, 6, 7 } };
            this.m_colors = new Color[] { Color.BlueViolet, Color.Cyan, Color.Green, Color.Yellow, Color.Violet, Color.LightSkyBlue };
            int i = 0;
            do
            {
                this.m_brushes[i] = new SolidBrush(this.m_colors[i]);
                i++;
            }
            while (i <= 5);
        }

        /// <summary>
        /// Initializes the component.
        /// </summary>
        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Main));
            this.picCodeNtronix = new PictureBox();
            ((ISupportInitialize)this.picCodeNtronix).BeginInit();
            base.SuspendLayout();
            this.picCodeNtronix.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            //this.picCodeNtronix.Image = (Image)resources.GetObject("picCodeNtronix.Image");
            this.picCodeNtronix.Location = new Point(239, 286);
            this.picCodeNtronix.Name = "picCodeNtronix";
            this.picCodeNtronix.Size = new System.Drawing.Size(202, 48);
            this.picCodeNtronix.TabIndex = 1;
            this.picCodeNtronix.TabStop = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new System.Drawing.Size(438, 333);
            base.Controls.Add(this.picCodeNtronix);
            base.Name = "Main";
            this.Text = "Rotating Cube (GDI+)";
            ((ISupportInitialize)this.picCodeNtronix).EndInit();
            base.ResumeLayout(false);
        }

        /// <summary>
        /// Handles the Load event of the Main control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Main_Load(object sender, EventArgs e)
        {
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.InitCube();
            this.m_timer = new Timer()
            {
                Interval = 25
            };
            this.m_timer.Tick += new EventHandler((object a0, EventArgs a1) => this.AnimationLoop());
            this.m_timer.Start();
        }

        /// <summary>
        /// Handles the Paint event of the Main control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void Main_Paint(object sender, PaintEventArgs e)
        {
            Point3D[] t = new Point3D[9];
            int[] f = new int[5];
            double[] avgZ = new double[7];
            int[] order = new int[7];
            e.Graphics.Clear(Color.LightBlue);
            int i = 0;
            do
            {
                Brush b = new SolidBrush(Color.White);
                Point3D v = this.m_vertices[i];
                t[i] = v.RotateX(this.m_angle).RotateY(this.m_angle).RotateZ(this.m_angle);
                Point3D point3D = t[i];
                object width = base.ClientSize.Width;
                System.Drawing.Size clientSize = base.ClientSize;
                t[i] = (Point3D)point3D.Project(width, clientSize.Height, 256, 4);
                i++;
            }
            while (i <= 7);
            do
            {
                avgZ[i] = (t[this.m_faces[i, 0]].Z + t[this.m_faces[i, 1]].Z + t[this.m_faces[i, 2]].Z + t[this.m_faces[i, 3]].Z) / 4;
                order[i] = i;
                i++;
            }
            while (i <= 5);
            do
            {
                int iMax = i;
                for (int j = checked(i + 1); j <= 5; j++)
                {
                    if (avgZ[j] > avgZ[iMax])
                    {
                        iMax = j;
                    }
                }
                if (iMax != i)
                {
                    double tmp = avgZ[i];
                    avgZ[i] = avgZ[iMax];
                    avgZ[iMax] = tmp;
                    tmp = (double)order[i];
                    order[i] = order[iMax];
                    order[iMax] = checked((int)Math.Round(tmp));
                }
                i++;
            }
            while (i <= 4);
            do
            {
                int index = order[i];
                Point[] point = new Point[] { new Point(checked((int)Math.Round(t[this.m_faces[index, 0]].X)), checked((int)Math.Round(t[this.m_faces[index, 0]].Y))), new Point(checked((int)Math.Round(t[this.m_faces[index, 1]].X)), checked((int)Math.Round(t[this.m_faces[index, 1]].Y))), new Point(checked((int)Math.Round(t[this.m_faces[index, 2]].X)), checked((int)Math.Round(t[this.m_faces[index, 2]].Y))), new Point(checked((int)Math.Round(t[this.m_faces[index, 3]].X)), checked((int)Math.Round(t[this.m_faces[index, 3]].Y))) };
                e.Graphics.FillPolygon(this.m_brushes[index], point);
                i++;
            }
            while (i <= 5);
        }
    }
}
