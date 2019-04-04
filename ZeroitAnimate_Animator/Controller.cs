// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Controller.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
using System.Drawing;
using System.Drawing.Imaging;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.Transitions
{
    #region Controller
    /// <summary>
    /// DoubleBitmap displays animation
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// Gets or sets the bg BMP.
        /// </summary>
        /// <value>The bg BMP.</value>
        protected Bitmap BgBmp { get { return (DoubleBitmap as IFakeControl).BgBmp; } set { (DoubleBitmap as IFakeControl).BgBmp = value; } }
        /// <summary>
        /// Gets or sets the frame.
        /// </summary>
        /// <value>The frame.</value>
        public Bitmap Frame { get { return (DoubleBitmap as IFakeControl).Frame; } set { (DoubleBitmap as IFakeControl).Frame = value; } }
        /// <summary>
        /// The control BMP
        /// </summary>
        protected Bitmap ctrlBmp;
        /// <summary>
        /// Gets the current time.
        /// </summary>
        /// <value>The current time.</value>
        public float CurrentTime { get; private set; }
        /// <summary>
        /// Gets the time step.
        /// </summary>
        /// <value>The time step.</value>
        protected float TimeStep { get; private set; }

        /// <summary>
        /// Occurs when [transfrom needed].
        /// </summary>
        public event EventHandler<TransfromNeededEventArg> TransfromNeeded;
        /// <summary>
        /// Occurs when [non linear transfrom needed].
        /// </summary>
        public event EventHandler<NonLinearTransfromNeededEventArg> NonLinearTransfromNeeded;
        /// <summary>
        /// Occurs when [frame painting].
        /// </summary>
        public event EventHandler<PaintEventArgs> FramePainting;
        /// <summary>
        /// Occurs when [frame painted].
        /// </summary>
        public event EventHandler<PaintEventArgs> FramePainted;
        /// <summary>
        /// Occurs when [mouse down].
        /// </summary>
        public event EventHandler<MouseEventArgs> MouseDown;

        /// <summary>
        /// Gets the double bitmap.
        /// </summary>
        /// <value>The double bitmap.</value>
        public Control DoubleBitmap { get; private set; }
        /// <summary>
        /// Gets or sets the animated control.
        /// </summary>
        /// <value>The animated control.</value>
        public Control AnimatedControl { get; set; }
        /// <summary>
        /// The buffer
        /// </summary>
        System.Drawing.Point[] buffer;
        /// <summary>
        /// The pixels buffer
        /// </summary>
        byte[] pixelsBuffer;
        /// <summary>
        /// The custom clip rect
        /// </summary>
        protected Rectangle CustomClipRect;

        /// <summary>
        /// The mode
        /// </summary>
        AnimateMode mode;
        /// <summary>
        /// The animation
        /// </summary>
        ZeroitAnimate_Animation animation;

        /// <summary>
        /// Disposes this instance.
        /// </summary>
        public void Dispose()
        {
            if (ctrlBmp != null)
                BgBmp.Dispose();
            if (ctrlBmp != null)
                ctrlBmp.Dispose();
            if (Frame != null)
                Frame.Dispose();
            AnimatedControl = null;

            Hide();
        }

        /// <summary>
        /// Hides this instance.
        /// </summary>
        public void Hide()
        {
            if (DoubleBitmap != null)
                try
                {
                    DoubleBitmap.BeginInvoke(new MethodInvoker(() =>
                    {
                        if (DoubleBitmap.Visible) DoubleBitmap.Hide();
                        DoubleBitmap.Parent = null;
                        //DoubleBitmap.Dispose();
                    }));
                }
                catch { }
        }

        /// <summary>
        /// Gets the bounds.
        /// </summary>
        /// <returns>Rectangle.</returns>
        protected virtual Rectangle GetBounds()
        {
            return new Rectangle(
                AnimatedControl.Left - animation.Padding.Left,
                AnimatedControl.Top - animation.Padding.Top,
                AnimatedControl.Size.Width + animation.Padding.Left + animation.Padding.Right,
                AnimatedControl.Size.Height + animation.Padding.Top + animation.Padding.Bottom);
        }

        /// <summary>
        /// Controls the rect to my rect.
        /// </summary>
        /// <param name="rect">The rect.</param>
        /// <returns>Rectangle.</returns>
        protected virtual Rectangle ControlRectToMyRect(Rectangle rect)
        {
            return new Rectangle(
                animation.Padding.Left + rect.Left,
                animation.Padding.Top + rect.Top,
                rect.Width + animation.Padding.Left + animation.Padding.Right,
                rect.Height + animation.Padding.Top + animation.Padding.Bottom);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Controller"/> class.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="mode">The mode.</param>
        /// <param name="animation">The animation.</param>
        /// <param name="timeStep">The time step.</param>
        /// <param name="controlClipRect">The control clip rect.</param>
        public Controller(Control control, AnimateMode mode, ZeroitAnimate_Animation animation, float timeStep, Rectangle controlClipRect)
        {
            if (control is System.Windows.Forms.Form)
                DoubleBitmap = new DoubleBitmapForm();
            else
                DoubleBitmap = new DoubleBitmapControl();

            (DoubleBitmap as IFakeControl).FramePainting += OnFramePainting;
            (DoubleBitmap as IFakeControl).FramePainted += OnFramePainting;
            (DoubleBitmap as IFakeControl).TransfromNeeded += OnTransfromNeeded;
            DoubleBitmap.MouseDown += OnMouseDown;

            this.animation = animation;
            this.AnimatedControl = control;
            this.mode = mode;

            this.CustomClipRect = controlClipRect;

            if (mode == AnimateMode.Show || mode == AnimateMode.BeginUpdate)
                timeStep = -timeStep;

            this.TimeStep = timeStep * (animation.TimeCoeff == 0f ? 1f : animation.TimeCoeff);
            if (this.TimeStep == 0f)
                timeStep = 0.01f;

            try
            {
                switch (mode)
                {
                    case AnimateMode.Hide:
                    {
                        BgBmp = GetBackground(control);
                        (DoubleBitmap as IFakeControl).InitParent(control, animation.Padding);
                        ctrlBmp = GetForeground(control);
                        DoubleBitmap.Visible = true;
                        control.Visible = false;
                    }
                        break;

                    case AnimateMode.Show:
                    {
                        BgBmp = GetBackground(control);
                        (DoubleBitmap as IFakeControl).InitParent(control, animation.Padding);
                        DoubleBitmap.Visible = true;
                        DoubleBitmap.Refresh();
                        control.Visible = true;
                        ctrlBmp = GetForeground(control);
                    }
                        break;

                    case AnimateMode.BeginUpdate:
                    case AnimateMode.Update:
                    {
                        (DoubleBitmap as IFakeControl).InitParent(control, animation.Padding);
                        BgBmp = GetBackground(control, true);
                        DoubleBitmap.Visible = true;

                    }
                        break;
                }
            }
            catch
            {
                Dispose();
            }
#if debug
            BgBmp.Save("c:\\bgBmp.png");
            if (ctrlBmp != null)
                ctrlBmp.Save("c:\\ctrlBmp.png");
#endif

            CurrentTime = timeStep > 0 ? animation.MinTime : animation.MaxTime;
        }

        /// <summary>
        /// Handles the <see cref="E:MouseDown" /> event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        protected virtual void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (MouseDown != null)
                MouseDown(this, e);
        }

        /// <summary>
        /// Handles the <see cref="E:FramePainting" /> event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        protected virtual void OnFramePainting(object sender, PaintEventArgs e)
        {
            var oldFrame = Frame;
            Frame = null;

            if (mode == AnimateMode.BeginUpdate)
                return;

            Frame = OnNonLinearTransfromNeeded();

            if (oldFrame != Frame && oldFrame != null)
                oldFrame.Dispose();

            var time = CurrentTime + TimeStep;
            if (time > animation.MaxTime) time = animation.MaxTime;
            if (time < animation.MinTime) time = animation.MinTime;
            CurrentTime = time;

            if (FramePainting != null)
                FramePainting(this, e);
        }

        /// <summary>
        /// Handles the <see cref="E:FramePainted" /> event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        protected virtual void OnFramePainted(object sender, PaintEventArgs e)
        {
            if (FramePainted != null)
                FramePainted(this, e);
        }

        /// <summary>
        /// Gets the background.
        /// </summary>
        /// <param name="ctrl">The control.</param>
        /// <param name="includeForeground">if set to <c>true</c> [include foreground].</param>
        /// <param name="clip">if set to <c>true</c> [clip].</param>
        /// <returns>Bitmap.</returns>
        protected virtual Bitmap GetBackground(Control ctrl, bool includeForeground = false, bool clip = false)
        {
            if (ctrl is System.Windows.Forms.Form)
                return GetScreenBackground(ctrl, includeForeground, clip);

            var bounds = GetBounds();
            var w = bounds.Width;
            var h = bounds.Height;
            if (w == 0) w = 1;
            if (h == 1) h = 1;
            Bitmap bmp = new Bitmap(w, h);

            var clientRect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            PaintEventArgs ea = new PaintEventArgs(Graphics.FromImage(bmp), clientRect);
            if (clip)
            {
                if (CustomClipRect == default(Rectangle))
                    ea.Graphics.SetClip(new Rectangle(0, 0, w, h));
                else
                    ea.Graphics.SetClip(CustomClipRect);
            }

            for (int i = ctrl.Parent.Controls.Count - 1; i >= 0; i--)
            {
                var c = ctrl.Parent.Controls[i];
                if (c == ctrl && !includeForeground) break;
                if (c.Visible && !c.IsDisposed)
                    if (c.Bounds.IntersectsWith(bounds))
                    {
                        using (Bitmap cb = new Bitmap(c.Width, c.Height))
                        {
                            c.DrawToBitmap(cb, new Rectangle(0, 0, c.Width, c.Height));
                            /*if (c == ctrl)
                                ea.Graphics.SetClip(clipRect);*/
                            ea.Graphics.DrawImage(cb, c.Left - bounds.Left, c.Top - bounds.Top, c.Width, c.Height);
                        }
                    }
                if (c == ctrl) break;
            }

            ea.Graphics.Dispose();

            return bmp;
        }


        /// <summary>
        /// Gets the screen background.
        /// </summary>
        /// <param name="ctrl">The control.</param>
        /// <param name="includeForeground">if set to <c>true</c> [include foreground].</param>
        /// <param name="clip">if set to <c>true</c> [clip].</param>
        /// <returns>Bitmap.</returns>
        private Bitmap GetScreenBackground(Control ctrl, bool includeForeground, bool clip)
        {
            var size = Screen.PrimaryScreen.Bounds.Size;
            Graphics temp = DoubleBitmap.CreateGraphics();//???
            var bmp = new Bitmap(size.Width, size.Height, temp);
            Graphics gr = Graphics.FromImage(bmp);
            gr.CopyFromScreen(0, 0, 0, 0, size);
            return bmp;
        }

        /*
        private Bitmap GetScreenBackground(Control ctrl, bool includeForeground, bool clip)
        {
            var size = GetBounds().Size;
            Graphics temp = FakeControl.CreateGraphics();//???
            var bmp = new Bitmap(size.Width, size.Height, temp);
            Graphics gr = Graphics.FromImage(bmp);
            var p = ctrl.Parent == null? ctrl.Location : ctrl.Parent.PointToScreen(ctrl.Location);
            gr.CopyFromScreen(p.X - animation.Padding.Left, p.Y - animation.Padding.Top, 0, 0, size);
            return bmp;
        }*/

        /// <summary>
        /// Gets the foreground.
        /// </summary>
        /// <param name="ctrl">The control.</param>
        /// <returns>Bitmap.</returns>
        protected virtual Bitmap GetForeground(Control ctrl)
        {
            Bitmap bmp = null;

            if (!ctrl.IsDisposed)
            {
                if (ctrl.Parent == null)
                {
                    bmp = new Bitmap(ctrl.Width + animation.Padding.Horizontal, ctrl.Height + animation.Padding.Vertical);
                    ctrl.DrawToBitmap(bmp, new Rectangle(animation.Padding.Left, animation.Padding.Top, ctrl.Width, ctrl.Height));
                }
                else
                {
                    bmp = new Bitmap(DoubleBitmap.Width, DoubleBitmap.Height);
                    ctrl.DrawToBitmap(bmp, new Rectangle(ctrl.Left - DoubleBitmap.Left, ctrl.Top - DoubleBitmap.Top, ctrl.Width, ctrl.Height));
#if debug
            using (var gr = Graphics.FromImage(bmp))
                gr.DrawLine(Pens.Red, 0, 0, DoubleBitmap.Width, DoubleBitmap.Height);
#endif
                }
            }


            return bmp;
        }

        /// <summary>
        /// Called when [transfrom needed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        protected virtual void OnTransfromNeeded(object sender, TransfromNeededEventArg e)
        {
            try
            {
                if (CustomClipRect != default(Rectangle))
                    e.ClipRectangle = ControlRectToMyRect(CustomClipRect);

                e.CurrentTime = CurrentTime;

                if (TransfromNeeded != null)
                    TransfromNeeded(this, e);
                else
                    e.UseDefaultMatrix = true;

                if (e.UseDefaultMatrix)
                {
                    TransfromHelper.DoScale(e, animation);
                    TransfromHelper.DoRotate(e, animation);
                    TransfromHelper.DoSlide(e, animation);
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// Called when [non linear transfrom needed].
        /// </summary>
        /// <returns>Bitmap.</returns>
        protected virtual Bitmap OnNonLinearTransfromNeeded()
        {
            Bitmap bmp = null;
            if (ctrlBmp == null)
                return null;

            if (NonLinearTransfromNeeded == null)
                if (!animation.IsNonLinearTransformNeeded)
                    return ctrlBmp;

            try
            {
                bmp = (Bitmap)ctrlBmp.Clone();

                const int bytesPerPixel = 4;
                PixelFormat pxf = PixelFormat.Format32bppArgb;
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, pxf);
                IntPtr ptr = bmpData.Scan0;
                int numBytes = bmp.Width * bmp.Height * bytesPerPixel;
                byte[] argbValues = new byte[numBytes];

                System.Runtime.InteropServices.Marshal.Copy(ptr, argbValues, 0, numBytes);

                var e = new NonLinearTransfromNeededEventArg() { CurrentTime = CurrentTime, ClientRectangle = DoubleBitmap.ClientRectangle, Pixels = argbValues, Stride = bmpData.Stride };

                if (NonLinearTransfromNeeded != null)
                    NonLinearTransfromNeeded(this, e);
                else
                    e.UseDefaultTransform = true;

                if (e.UseDefaultTransform)
                {
                    TransfromHelper.DoBlind(e, animation);
                    TransfromHelper.DoMosaic(e, animation, ref buffer, ref pixelsBuffer);

                    TransfromHelper.DoTransparent(e, animation);
                    TransfromHelper.DoLeaf(e, animation);
                }

                System.Runtime.InteropServices.Marshal.Copy(argbValues, 0, ptr, numBytes);
                bmp.UnlockBits(bmpData);
            }
            catch
            {
            }

            return bmp;
        }

        /// <summary>
        /// Ends the update.
        /// </summary>
        public void EndUpdate()
        {
            var bmp = GetBackground(AnimatedControl, true, true);
#if debug
            bmp.Save("c:\\bmp.png");
#endif
            if (animation.AnimateOnlyDifferences)
                TransfromHelper.CalcDifference(bmp, BgBmp);

            ctrlBmp = bmp;
            mode = AnimateMode.Update;
#if debug
            ctrlBmp.Save("c:\\ctrlBmp.png");
#endif
        }

        /// <summary>
        /// Gets a value indicating whether this instance is completed.
        /// </summary>
        /// <value><c>true</c> if this instance is completed; otherwise, <c>false</c>.</value>
        public bool IsCompleted
        {
            get { return (TimeStep >= 0f && CurrentTime >= animation.MaxTime) || (TimeStep <= 0f && CurrentTime <= animation.MinTime); }
        }

        /// <summary>
        /// Builds the next frame.
        /// </summary>
        internal void BuildNextFrame()
        {
            if (mode == AnimateMode.BeginUpdate)
                return;
            DoubleBitmap.Invalidate();
        }
    }
    #endregion
}
