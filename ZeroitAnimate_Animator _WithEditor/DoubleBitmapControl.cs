// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="DoubleBitmapControl.cs" company="Zeroit Dev Technologies">
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
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.Transitions.AnimatorWithEditor
{
    #region DoubleBitmapControl
    /// <summary>
    /// Class DoubleBitmapControl.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    /// <seealso cref="Zeroit.Framework.Transitions.AnimatorWithEditor.IFakeControl" />
    [ToolboxItem(false)]
    public partial class DoubleBitmapControl : Control, IFakeControl
    {
        /// <summary>
        /// The bg BMP
        /// </summary>
        Bitmap bgBmp;
        /// <summary>
        /// The frame
        /// </summary>
        Bitmap frame;

        /// <summary>
        /// Gets or sets the bg BMP.
        /// </summary>
        /// <value>The bg BMP.</value>
        Bitmap IFakeControl.BgBmp { get { return this.bgBmp; } set { this.bgBmp = value; } }
        /// <summary>
        /// Gets or sets the frame.
        /// </summary>
        /// <value>The frame.</value>
        Bitmap IFakeControl.Frame { get { return this.frame; } set { this.frame = value; } }
        /// <summary>
        /// Occurs when [transfrom needed].
        /// </summary>
        public event EventHandler<TransfromNeededEventArg> TransfromNeeded;
        /// <summary>
        /// Occurs when [frame painted].
        /// </summary>
        public event EventHandler<PaintEventArgs> FramePainted;
        /// <summary>
        /// Occurs when [frame painting].
        /// </summary>
        public event EventHandler<PaintEventArgs> FramePainting;

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleBitmapControl"/> class.
        /// </summary>
        public DoubleBitmapControl()
        {
            InitializeComponent();

            Visible = false;
            SetStyle(ControlStyles.Selectable, false);
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            var gr = e.Graphics;

            OnFramePainting(e);

            try
            {
                gr.DrawImage(bgBmp, 0, 0);
                if (frame != null)
                {
                    var ea = new TransfromNeededEventArg() { ClientRectangle = new Rectangle(0, 0, this.Width, this.Height) };
                    ea.ClipRectangle = ea.ClientRectangle;
                    OnTransfromNeeded(ea);
                    gr.SetClip(ea.ClipRectangle);
                    gr.Transform = ea.Matrix;
                    gr.DrawImage(frame, 0, 0);
                }
            }
            catch { }

            //e.Graphics.DrawLine(Pens.Red, System.Drawing.Point.Empty, new System.Drawing.Point(Width, Height));

            OnFramePainted(e);
        }

        /// <summary>
        /// Called when [transfrom needed].
        /// </summary>
        /// <param name="ea">The ea.</param>
        private void OnTransfromNeeded(TransfromNeededEventArg ea)
        {
            if (TransfromNeeded != null)
                TransfromNeeded(this, ea);
        }



        /// <summary>
        /// Handles the <see cref="E:FramePainting" /> event.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        protected virtual void OnFramePainting(PaintEventArgs e)
        {
            if (FramePainting != null)
                FramePainting(this, e);
        }

        /// <summary>
        /// Handles the <see cref="E:FramePainted" /> event.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        protected virtual void OnFramePainted(PaintEventArgs e)
        {
            if (FramePainted != null)
                FramePainted(this, e);
        }


        /// <summary>
        /// Initializes the parent.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="padding">The padding.</param>
        public void InitParent(Control control, Padding padding)
        {
            Parent = control.Parent;
            var i = control.Parent.Controls.GetChildIndex(control);
            control.Parent.Controls.SetChildIndex(this, i);
            Bounds = new Rectangle(
                control.Left - padding.Left,
                control.Top - padding.Top,
                control.Size.Width + padding.Left + padding.Right,
                control.Size.Height + padding.Top + padding.Bottom);
        }
    }

    /// <summary>
    /// Interface IFakeControl
    /// </summary>
    public interface IFakeControl
    {
        /// <summary>
        /// Gets or sets the bg BMP.
        /// </summary>
        /// <value>The bg BMP.</value>
        Bitmap BgBmp { get; set; }
        /// <summary>
        /// Gets or sets the frame.
        /// </summary>
        /// <value>The frame.</value>
        Bitmap Frame { get; set; }
        /// <summary>
        /// Occurs when [transfrom needed].
        /// </summary>
        event EventHandler<TransfromNeededEventArg> TransfromNeeded;

        /// <summary>
        /// Occurs when [frame painting].
        /// </summary>
        event EventHandler<PaintEventArgs> FramePainting;
        /// <summary>
        /// Occurs when [frame painted].
        /// </summary>
        event EventHandler<PaintEventArgs> FramePainted;
        /// <summary>
        /// Initializes the parent.
        /// </summary>
        /// <param name="animatedControl">The animated control.</param>
        /// <param name="padding">The padding.</param>
        void InitParent(Control animatedControl, Padding padding);
    }
    #endregion
}
