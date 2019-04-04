// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="DoubleBitmapForm.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
using System.Drawing;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.Transitions.AnimatorWithEditor
{
    #region DoubleBitmapForm
    /// <summary>
    /// Class DoubleBitmapForm.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="Zeroit.Framework.Transitions.AnimatorWithEditor.IFakeControl" />
    public partial class DoubleBitmapForm : System.Windows.Forms.Form, IFakeControl
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
        /// Occurs when [transfrom needed].
        /// </summary>
        public event EventHandler<TransfromNeededEventArg> TransfromNeeded;

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleBitmapForm"/> class.
        /// </summary>
        public DoubleBitmapForm()
        {
            InitializeComponent();
            Visible = false;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            TopMost = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            //ShowInTaskbar = false;
        }

        /// <summary>
        /// Gets the create parameters.
        /// </summary>
        /// <value>The create parameters.</value>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                unchecked
                {
                    cp.Style = (int)Flags.WindowStyles.WS_POPUP;
                }
                ;// (int)Flags.WindowStyles.WS_CHILD;
                cp.ExStyle |= (int)Flags.WindowStyles.WS_EX_NOACTIVATE | (int)Flags.WindowStyles.WS_EX_TOOLWINDOW;
                cp.X = this.Location.X;
                cp.Y = this.Location.Y;
                return cp;
            }
        }

        /// <summary>
        /// Handles the <see cref="E:Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            var gr = e.Graphics;

            OnFramePainting(e);

            try
            {
                gr.DrawImage(bgBmp, -Location.X, -Location.Y);
                /*
                if (frame == null)
                {
                    control.Focus();
                    if (control.Focused)
                    {
                        frame = new Bitmap(control.Width, control.Height);
                        //control.DrawToBitmap(frame, new Rectangle(padding.Left, padding.Top, control.Width, control.Height));
                        control.DrawToBitmap(frame, new Rectangle(0, 0, control.Width, control.Height));
                    }
                }*/

                if (frame != null)
                {
                    //var ea = new TransfromNeededEventArg(){ ClientRectangle = new Rectangle(0, 0, this.Width, this.Height) };
                    var ea = new TransfromNeededEventArg();
                    ea.ClientRectangle = ea.ClipRectangle = new Rectangle(control.Bounds.Left - padding.Left, control.Bounds.Top - padding.Top, control.Bounds.Width + padding.Horizontal, control.Bounds.Height + padding.Vertical);
                    OnTransfromNeeded(ea);
                    gr.SetClip(ea.ClipRectangle);
                    gr.Transform = ea.Matrix;
                    //var p = new System.Drawing.Point();
                    var p = control.Location;
                    //gr.Transform.Translate(p.X, p.Y);
                    gr.DrawImage(frame, p.X - padding.Left, p.Y - padding.Top);
                }

                OnFramePainted(e);
            }
            catch { }

            //e.Graphics.DrawLine(Pens.Red, System.Drawing.Point.Empty, new System.Drawing.Point(Width, Height));
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
        /// The padding
        /// </summary>
        Padding padding;
        /// <summary>
        /// The control
        /// </summary>
        Control control;

        /// <summary>
        /// Initializes the parent.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="padding">The padding.</param>
        public void InitParent(Control control, Padding padding)
        {
            //Size = new Size(control.Size.Width + padding.Left + padding.Right, control.Size.Height + padding.Top + padding.Bottom);
            //var p = control.Parent == null ? control.Location : control.Parent.PointToScreen(control.Location);
            //Location = new System.Drawing.Point(p.X - padding.Left, p.Y - padding.Top);

            this.control = control;
            /*
            if (padding.Left < 10) padding.Left = 15;
            if (padding.Right < 10) padding.Right = 15;
            if (padding.Top < 10) padding.Top = 15;
            if (padding.Bottom < 10) padding.Bottom = 15;*/

            Location = new System.Drawing.Point(0, 0);
            Size = Screen.PrimaryScreen.Bounds.Size;
            control.VisibleChanged += new EventHandler(control_VisibleChanged);
            this.padding = padding;
        }

        /// <summary>
        /// The control location
        /// </summary>
        System.Drawing.Point controlLocation;

        /// <summary>
        /// Handles the VisibleChanged event of the control control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        void control_VisibleChanged(object sender, EventArgs e)
        {
            controlLocation = (sender as Control).Location;
            var s = (sender as Control).Size;

            //this.Location = new System.Drawing.Point(p.X - padding.Left, p.Y - padding.Top);
            //this.Location = System.Drawing.Point.Empty;
            //this.Size = new Size(s.Width + padding.Left + padding.Right, s.Height + padding.Top + padding.Bottom);
        }

        /// <summary>
        /// Gets or sets the bg BMP.
        /// </summary>
        /// <value>The bg BMP.</value>
        public Bitmap BgBmp
        {
            get
            {
                return bgBmp;
            }
            set
            {
                bgBmp = value;
            }
        }

        /// <summary>
        /// Gets or sets the frame.
        /// </summary>
        /// <value>The frame.</value>
        public Bitmap Frame
        {
            get
            {
                return frame;
            }
            set
            {
                frame = value;
            }
        }

        /// <summary>
        /// Occurs when [frame painting].
        /// </summary>
        public event EventHandler<PaintEventArgs> FramePainting;

        /// <summary>
        /// Occurs when [frame painted].
        /// </summary>
        public event EventHandler<PaintEventArgs> FramePainted;
        

    }
    #endregion
}
