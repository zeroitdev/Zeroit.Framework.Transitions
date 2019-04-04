// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Themes.cs" company="Zeroit Dev Technologies">
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
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace Zeroit.Framework.Transitions.ThemeManagers
{


    #region Theme Base



    //---------------ThemeContainer
    /// <summary>
    /// Class ThemeContainer.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.ContainerControl" />
    public abstract class ThemeContainer : ContainerControl
    {

        #region " Initialization "

        /// <summary>
        /// The g
        /// </summary>
        protected Graphics G;

        /// <summary>
        /// The b
        /// </summary>
        protected Bitmap B;
        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeContainer"/> class.
        /// </summary>
        public ThemeContainer()
        {
            SetStyle((ControlStyles)139270, true);

            _ImageSize = Size.Empty;
            Font = new Font("Verdana", 8);

            MeasureBitmap = new Bitmap(1, 1);
            MeasureGraphics = Graphics.FromImage(MeasureBitmap);

            DrawRadialPath = new GraphicsPath();

            InvalidateCustimization();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.HandleCreated" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override sealed void OnHandleCreated(EventArgs e)
        {
            if (DoneCreation)
                InitializeMessages();

            InvalidateCustimization();
            ColorHook();

            if (!(_LockWidth == 0))
                Width = _LockWidth;
            if (!(_LockHeight == 0))
                Height = _LockHeight;
            if (!_ControlMode)
                base.Dock = DockStyle.Fill;

            Transparent = _Transparent;
            if (_Transparent && _BackColor)
                BackColor = Color.Transparent;

            base.OnHandleCreated(e);
        }

        /// <summary>
        /// The done creation
        /// </summary>
        private bool DoneCreation;
        /// <summary>
        /// Handles the <see cref="E:ParentChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override sealed void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);

            if (Parent == null)
                return;
            _IsParentForm = Parent is Form;

            if (!_ControlMode)
            {
                InitializeMessages();

                if (_IsParentForm)
                {
                    ParentForm.FormBorderStyle = _BorderStyle;
                    ParentForm.TransparencyKey = _TransparencyKey;

                    if (!DesignMode)
                    {
                        ParentForm.Shown += FormShown;
                    }
                }

                Parent.BackColor = BackColor;
            }

            OnCreation();
            DoneCreation = true;
            InvalidateTimer();
        }

        #endregion

        /// <summary>
        /// Does the animation.
        /// </summary>
        /// <param name="i">if set to <c>true</c> [i].</param>
        private void DoAnimation(bool i)
        {
            OnAnimation();
            if (i)
                Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        protected override sealed void OnPaint(PaintEventArgs e)
        {
            if (Width == 0 || Height == 0)
                return;

            if (_Transparent && _ControlMode)
            {
                PaintHook(e);
                e.Graphics.DrawImage(B, 0, 0);
            }
            else
            {
                G = e.Graphics;
                PaintHook(e);
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.HandleDestroyed" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnHandleDestroyed(EventArgs e)
        {
            ThemeShare.RemoveAnimationCallback(DoAnimation);
            base.OnHandleDestroyed(e);
        }

        /// <summary>
        /// The has shown
        /// </summary>
        private bool HasShown;
        /// <summary>
        /// Forms the shown.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FormShown(object sender, EventArgs e)
        {
            if (_ControlMode || HasShown)
                return;

            if (_StartPosition == FormStartPosition.CenterParent || _StartPosition == FormStartPosition.CenterScreen)
            {
                Rectangle SB = Screen.PrimaryScreen.Bounds;
                Rectangle CB = ParentForm.Bounds;
                ParentForm.Location = new Point(SB.Width / 2 - CB.Width / 2, SB.Height / 2 - CB.Width / 2);
            }

            HasShown = true;
        }


        #region " Size Handling "

        /// <summary>
        /// The frame
        /// </summary>
        private Rectangle Frame;
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.SizeChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override sealed void OnSizeChanged(EventArgs e)
        {
            if (_Movable && !_ControlMode)
            {
                Frame = new Rectangle(7, 7, Width - 14, _Header - 7);
            }

            InvalidateBitmap();
            Invalidate();

            base.OnSizeChanged(e);
        }

        /// <summary>
        /// Performs the work of setting the specified bounds of this control.
        /// </summary>
        /// <param name="x">The new <see cref="P:System.Windows.Forms.Control.Left" /> property value of the control.</param>
        /// <param name="y">The new <see cref="P:System.Windows.Forms.Control.Top" /> property value of the control.</param>
        /// <param name="width">The new <see cref="P:System.Windows.Forms.Control.Width" /> property value of the control.</param>
        /// <param name="height">The new <see cref="P:System.Windows.Forms.Control.Height" /> property value of the control.</param>
        /// <param name="specified">A bitwise combination of the <see cref="T:System.Windows.Forms.BoundsSpecified" /> values.</param>
        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            if (!(_LockWidth == 0))
                width = _LockWidth;
            if (!(_LockHeight == 0))
                height = _LockHeight;
            base.SetBoundsCore(x, y, width, height, specified);
        }

        #endregion

        #region " State Handling "

        /// <summary>
        /// The state
        /// </summary>
        protected MouseState State;
        /// <summary>
        /// Sets the state.
        /// </summary>
        /// <param name="current">The current.</param>
        private void SetState(MouseState current)
        {
            State = current;
            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseMove" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (!(_IsParentForm && ParentForm.WindowState == FormWindowState.Maximized))
            {
                if (_Sizable && !_ControlMode)
                    InvalidateMouse();
            }

            base.OnMouseMove(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.EnabledChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnEnabledChanged(EventArgs e)
        {
            if (Enabled)
                SetState(MouseState.None);
            else
                SetState(MouseState.Block);
            base.OnEnabledChanged(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseEnter" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnMouseEnter(EventArgs e)
        {
            SetState(MouseState.Over);
            base.OnMouseEnter(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseUp" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            SetState(MouseState.Over);
            base.OnMouseUp(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseLeave" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnMouseLeave(EventArgs e)
        {
            SetState(MouseState.None);

            if (GetChildAtPoint(PointToClient(MousePosition)) != null)
            {
                if (_Sizable && !_ControlMode)
                {
                    Cursor = Cursors.Default;
                    Previous = 0;
                }
            }

            base.OnMouseLeave(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseDown" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                SetState(MouseState.Down);

            if (!(_IsParentForm && ParentForm.WindowState == FormWindowState.Maximized || _ControlMode))
            {
                if (_Movable && Frame.Contains(e.Location))
                {
                    Capture = false;
                    WM_LMBUTTONDOWN = true;
                    DefWndProc(ref Messages[0]);
                }
                else if (_Sizable && !(Previous == 0))
                {
                    Capture = false;
                    WM_LMBUTTONDOWN = true;
                    DefWndProc(ref Messages[Previous]);
                }
            }

            base.OnMouseDown(e);
        }

        /// <summary>
        /// The wm lmbuttondown
        /// </summary>
        private bool WM_LMBUTTONDOWN;
        /// <summary>
        /// Processes Windows messages.
        /// </summary>
        /// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (WM_LMBUTTONDOWN && m.Msg == 513)
            {
                WM_LMBUTTONDOWN = false;

                SetState(MouseState.Over);
                if (!_SmartBounds)
                    return;

                if (IsParentMdi)
                {
                    CorrectBounds(new Rectangle(Point.Empty, Parent.Parent.Size));
                }
                else
                {
                    CorrectBounds(Screen.FromControl(Parent).WorkingArea);
                }
            }
        }

        /// <summary>
        /// The get index point
        /// </summary>
        private Point GetIndexPoint;
        /// <summary>
        /// The b1
        /// </summary>
        private bool B1;
        /// <summary>
        /// The b2
        /// </summary>
        private bool B2;
        /// <summary>
        /// The b3
        /// </summary>
        private bool B3;
        /// <summary>
        /// The b4
        /// </summary>
        private bool B4;
        /// <summary>
        /// Gets the index.
        /// </summary>
        /// <returns>System.Int32.</returns>
        private int GetIndex()
        {
            GetIndexPoint = PointToClient(MousePosition);
            B1 = GetIndexPoint.X < 7;
            B2 = GetIndexPoint.X > Width - 7;
            B3 = GetIndexPoint.Y < 7;
            B4 = GetIndexPoint.Y > Height - 7;

            if (B1 && B3)
                return 4;
            if (B1 && B4)
                return 7;
            if (B2 && B3)
                return 5;
            if (B2 && B4)
                return 8;
            if (B1)
                return 1;
            if (B2)
                return 2;
            if (B3)
                return 3;
            if (B4)
                return 6;
            return 0;
        }

        /// <summary>
        /// The current
        /// </summary>
        private int Current;
        /// <summary>
        /// The previous
        /// </summary>
        private int Previous;
        /// <summary>
        /// Invalidates the mouse.
        /// </summary>
        private void InvalidateMouse()
        {
            Current = GetIndex();
            if (Current == Previous)
                return;

            Previous = Current;
            switch (Previous)
            {
                case 0:
                    Cursor = Cursors.Default;
                    break;
                case 1:
                case 2:
                    Cursor = Cursors.SizeWE;
                    break;
                case 3:
                case 6:
                    Cursor = Cursors.SizeNS;
                    break;
                case 4:
                case 8:
                    Cursor = Cursors.SizeNWSE;
                    break;
                case 5:
                case 7:
                    Cursor = Cursors.SizeNESW;
                    break;
            }
        }

        /// <summary>
        /// The messages
        /// </summary>
        private Message[] Messages = new Message[9];
        /// <summary>
        /// Initializes the messages.
        /// </summary>
        private void InitializeMessages()
        {
            Messages[0] = Message.Create(Parent.Handle, 161, new IntPtr(2), IntPtr.Zero);
            for (int I = 1; I <= 8; I++)
            {
                Messages[I] = Message.Create(Parent.Handle, 161, new IntPtr(I + 9), IntPtr.Zero);
            }
        }

        /// <summary>
        /// Corrects the bounds.
        /// </summary>
        /// <param name="bounds">The bounds.</param>
        private void CorrectBounds(Rectangle bounds)
        {
            if (Parent.Width > bounds.Width)
                Parent.Width = bounds.Width;
            if (Parent.Height > bounds.Height)
                Parent.Height = bounds.Height;

            int X = Parent.Location.X;
            int Y = Parent.Location.Y;

            if (X < bounds.X)
                X = bounds.X;
            if (Y < bounds.Y)
                Y = bounds.Y;

            int Width = bounds.X + bounds.Width;
            int Height = bounds.Y + bounds.Height;

            if (X + Parent.Width > Width)
                X = Width - Parent.Width;
            if (Y + Parent.Height > Height)
                Y = Height - Parent.Height;

            Parent.Location = new Point(X, Y);
        }

        #endregion

        #region " Base Properties "

        /// <summary>
        /// Gets or sets which control borders are docked to its parent control and determines how a control is resized with its parent.
        /// </summary>
        /// <value>The dock.</value>
        public override DockStyle Dock
        {
            get { return base.Dock; }
            set
            {
                if (!_ControlMode)
                    return;
                base.Dock = value;
            }
        }

        /// <summary>
        /// The back color
        /// </summary>
        private bool _BackColor;
        /// <summary>
        /// Gets or sets the background color for the control.
        /// </summary>
        /// <value>The color of the back.</value>
        [Category("Misc")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                if (value == base.BackColor)
                    return;

                if (!IsHandleCreated && _ControlMode && value == Color.Transparent)
                {
                    _BackColor = true;
                    return;
                }

                base.BackColor = value;
                if (Parent != null)
                {
                    if (!_ControlMode)
                        Parent.BackColor = value;
                    ColorHook();
                }
            }
        }

        /// <summary>
        /// Gets or sets the size that is the lower limit that <see cref="M:System.Windows.Forms.Control.GetPreferredSize(System.Drawing.Size)" /> can specify.
        /// </summary>
        /// <value>The minimum size.</value>
        public override Size MinimumSize
        {
            get { return base.MinimumSize; }
            set
            {
                base.MinimumSize = value;
                if (Parent != null)
                    Parent.MinimumSize = value;
            }
        }

        /// <summary>
        /// Gets or sets the size that is the upper limit that <see cref="M:System.Windows.Forms.Control.GetPreferredSize(System.Drawing.Size)" /> can specify.
        /// </summary>
        /// <value>The maximum size.</value>
        public override Size MaximumSize
        {
            get { return base.MaximumSize; }
            set
            {
                base.MaximumSize = value;
                if (Parent != null)
                    Parent.MaximumSize = value;
            }
        }

        /// <summary>
        /// Gets or sets the text associated with this control.
        /// </summary>
        /// <value>The text.</value>
        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the font of the text displayed by the control.
        /// </summary>
        /// <value>The font.</value>
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                Invalidate();
            }
        }

        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public override Color ForeColor
        //{
        //    get { return Color.Empty; }
        //    set { }
        //}
        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public override Image BackgroundImage
        //{
        //    get { return null; }
        //    set { }
        //}
        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public override ImageLayout BackgroundImageLayout
        //{
        //    get { return ImageLayout.None; }
        //    set { }
        //}

        #endregion

        #region " Public Properties "

        /// <summary>
        /// The smart bounds
        /// </summary>
        private bool _SmartBounds = true;
        /// <summary>
        /// Gets or sets a value indicating whether [smart bounds].
        /// </summary>
        /// <value><c>true</c> if [smart bounds]; otherwise, <c>false</c>.</value>
        public bool SmartBounds
        {
            get { return _SmartBounds; }
            set { _SmartBounds = value; }
        }

        /// <summary>
        /// The movable
        /// </summary>
        private bool _Movable = true;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ThemeContainer"/> is movable.
        /// </summary>
        /// <value><c>true</c> if movable; otherwise, <c>false</c>.</value>
        public bool Movable
        {
            get { return _Movable; }
            set { _Movable = value; }
        }

        /// <summary>
        /// The sizable
        /// </summary>
        private bool _Sizable = true;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ThemeContainer"/> is sizable.
        /// </summary>
        /// <value><c>true</c> if sizable; otherwise, <c>false</c>.</value>
        public bool Sizable
        {
            get { return _Sizable; }
            set { _Sizable = value; }
        }

        /// <summary>
        /// The transparency key
        /// </summary>
        private Color _TransparencyKey;
        /// <summary>
        /// Gets or sets the transparency key.
        /// </summary>
        /// <value>The transparency key.</value>
        public Color TransparencyKey
        {
            get
            {
                if (_IsParentForm && !_ControlMode)
                    return ParentForm.TransparencyKey;
                else
                    return _TransparencyKey;
            }
            set
            {
                if (value == _TransparencyKey)
                    return;
                _TransparencyKey = value;

                if (_IsParentForm && !_ControlMode)
                {
                    ParentForm.TransparencyKey = value;
                    ColorHook();
                }
            }
        }

        /// <summary>
        /// The border style
        /// </summary>
        private FormBorderStyle _BorderStyle;
        /// <summary>
        /// Gets or sets the border style.
        /// </summary>
        /// <value>The border style.</value>
        public FormBorderStyle BorderStyle
        {
            get
            {
                if (_IsParentForm && !_ControlMode)
                    return ParentForm.FormBorderStyle;
                else
                    return _BorderStyle;
            }
            set
            {
                _BorderStyle = value;

                if (_IsParentForm && !_ControlMode)
                {
                    ParentForm.FormBorderStyle = value;

                    if (!(value == FormBorderStyle.None))
                    {
                        Movable = false;
                        Sizable = false;
                    }
                }
            }
        }

        /// <summary>
        /// The start position
        /// </summary>
        private FormStartPosition _StartPosition;
        /// <summary>
        /// Gets or sets the start position.
        /// </summary>
        /// <value>The start position.</value>
        public FormStartPosition StartPosition
        {
            get
            {
                if (_IsParentForm && !_ControlMode)
                    return ParentForm.StartPosition;
                else
                    return _StartPosition;
            }
            set
            {
                _StartPosition = value;

                if (_IsParentForm && !_ControlMode)
                {
                    ParentForm.StartPosition = value;
                }
            }
        }

        /// <summary>
        /// The no rounding
        /// </summary>
        private bool _NoRounding;
        /// <summary>
        /// Gets or sets a value indicating whether [no rounding].
        /// </summary>
        /// <value><c>true</c> if [no rounding]; otherwise, <c>false</c>.</value>
        public bool NoRounding
        {
            get { return _NoRounding; }
            set
            {
                _NoRounding = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The image
        /// </summary>
        private Image _Image;
        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>The image.</value>
        public Image Image
        {
            get { return _Image; }
            set
            {
                if (value == null)
                    _ImageSize = Size.Empty;
                else
                    _ImageSize = value.Size;

                _Image = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The items
        /// </summary>
        private Dictionary<string, Color> Items = new Dictionary<string, Color>();
        /// <summary>
        /// Gets or sets the colors.
        /// </summary>
        /// <value>The colors.</value>
        public Bloom[] Colors
        {
            get
            {
                List<Bloom> T = new List<Bloom>();
                Dictionary<string, Color>.Enumerator E = Items.GetEnumerator();

                while (E.MoveNext())
                {
                    T.Add(new Bloom(E.Current.Key, E.Current.Value));
                }

                return T.ToArray();
            }
            set
            {
                foreach (Bloom B in value)
                {
                    if (Items.ContainsKey(B.Name))
                        Items[B.Name] = B.Value;
                }

                InvalidateCustimization();
                ColorHook();
                Invalidate();
            }
        }

        /// <summary>
        /// The customization
        /// </summary>
        private string _Customization;
        /// <summary>
        /// Gets or sets the customization.
        /// </summary>
        /// <value>The customization.</value>
        public string Customization
        {
            get { return _Customization; }
            set
            {
                if (value == _Customization)
                    return;

                byte[] Data = null;
                Bloom[] Items = Colors;

                try
                {
                    Data = Convert.FromBase64String(value);
                    for (int I = 0; I <= Items.Length - 1; I++)
                    {
                        Items[I].Value = Color.FromArgb(BitConverter.ToInt32(Data, I * 4));
                    }
                }
                catch
                {
                    return;
                }

                _Customization = value;

                Colors = Items;
                ColorHook();
                Invalidate();
            }
        }

        /// <summary>
        /// The transparent
        /// </summary>
        private bool _Transparent;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ThemeContainer"/> is transparent.
        /// </summary>
        /// <value><c>true</c> if transparent; otherwise, <c>false</c>.</value>
        /// <exception cref="System.Exception">Unable to change value to false while a transparent BackColor is in use.</exception>
        public bool Transparent
        {
            get { return _Transparent; }
            set
            {
                _Transparent = value;
                if (!(IsHandleCreated || _ControlMode))
                    return;

                if (!value && !(BackColor.A == 255))
                {
                    throw new Exception("Unable to change value to false while a transparent BackColor is in use.");
                }

                SetStyle(ControlStyles.Opaque, !value);
                SetStyle(ControlStyles.SupportsTransparentBackColor, value);

                InvalidateBitmap();
                Invalidate();
            }
        }

        #endregion

        #region " Private Properties "

        /// <summary>
        /// The image size
        /// </summary>
        private Size _ImageSize;
        /// <summary>
        /// Gets the size of the image.
        /// </summary>
        /// <value>The size of the image.</value>
        protected Size ImageSize
        {
            get { return _ImageSize; }
        }

        /// <summary>
        /// The is parent form
        /// </summary>
        private bool _IsParentForm;
        /// <summary>
        /// Gets a value indicating whether this instance is parent form.
        /// </summary>
        /// <value><c>true</c> if this instance is parent form; otherwise, <c>false</c>.</value>
        protected bool IsParentForm
        {
            get { return _IsParentForm; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is parent MDI.
        /// </summary>
        /// <value><c>true</c> if this instance is parent MDI; otherwise, <c>false</c>.</value>
        protected bool IsParentMdi
        {
            get
            {
                if (Parent == null)
                    return false;
                return Parent.Parent != null;
            }
        }

        /// <summary>
        /// The lock width
        /// </summary>
        private int _LockWidth;
        /// <summary>
        /// Gets or sets the width of the lock.
        /// </summary>
        /// <value>The width of the lock.</value>
        protected int LockWidth
        {
            get { return _LockWidth; }
            set
            {
                _LockWidth = value;
                if (!(LockWidth == 0) && IsHandleCreated)
                    Width = LockWidth;
            }
        }

        /// <summary>
        /// The lock height
        /// </summary>
        private int _LockHeight;
        /// <summary>
        /// Gets or sets the height of the lock.
        /// </summary>
        /// <value>The height of the lock.</value>
        protected int LockHeight
        {
            get { return _LockHeight; }
            set
            {
                _LockHeight = value;
                if (!(LockHeight == 0) && IsHandleCreated)
                    Height = LockHeight;
            }
        }

        /// <summary>
        /// The header
        /// </summary>
        private int _Header = 24;
        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        /// <value>The header.</value>
        protected int Header
        {
            get { return _Header; }
            set
            {
                _Header = value;

                if (!_ControlMode)
                {
                    Frame = new Rectangle(7, 7, Width - 14, value - 7);
                    Invalidate();
                }
            }
        }

        /// <summary>
        /// The control mode
        /// </summary>
        private bool _ControlMode;
        /// <summary>
        /// Gets or sets a value indicating whether [control mode].
        /// </summary>
        /// <value><c>true</c> if [control mode]; otherwise, <c>false</c>.</value>
        protected bool ControlMode
        {
            get { return _ControlMode; }
            set
            {
                _ControlMode = value;

                Transparent = _Transparent;
                if (_Transparent && _BackColor)
                    BackColor = Color.Transparent;

                InvalidateBitmap();
                Invalidate();
            }
        }

        /// <summary>
        /// The is animated
        /// </summary>
        private bool _IsAnimated;
        /// <summary>
        /// Gets or sets a value indicating whether this instance is animated.
        /// </summary>
        /// <value><c>true</c> if this instance is animated; otherwise, <c>false</c>.</value>
        protected bool IsAnimated
        {
            get { return _IsAnimated; }
            set
            {
                _IsAnimated = value;
                InvalidateTimer();
            }
        }

        #endregion

        #region " Property Helpers "

        /// <summary>
        /// Gets the pen.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Pen.</returns>
        protected Pen GetPen(string name)
        {
            return new Pen(Items[name]);
        }
        /// <summary>
        /// Gets the pen.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="width">The width.</param>
        /// <returns>Pen.</returns>
        protected Pen GetPen(string name, float width)
        {
            return new Pen(Items[name], width);
        }

        /// <summary>
        /// Gets the brush.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>SolidBrush.</returns>
        protected SolidBrush GetBrush(string name)
        {
            return new SolidBrush(Items[name]);
        }

        /// <summary>
        /// Gets the color.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Color.</returns>
        protected Color GetColor(string name)
        {
            return Items[name];
        }

        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        protected void SetColor(string name, Color value)
        {
            if (Items.ContainsKey(name))
                Items[name] = value;
            else
                Items.Add(name, value);
        }
        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="r">The r.</param>
        /// <param name="g">The g.</param>
        /// <param name="b">The b.</param>
        protected void SetColor(string name, byte r, byte g, byte b)
        {
            SetColor(name, Color.FromArgb(r, g, b));
        }
        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="a">a.</param>
        /// <param name="r">The r.</param>
        /// <param name="g">The g.</param>
        /// <param name="b">The b.</param>
        protected void SetColor(string name, byte a, byte r, byte g, byte b)
        {
            SetColor(name, Color.FromArgb(a, r, g, b));
        }
        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="a">a.</param>
        /// <param name="value">The value.</param>
        protected void SetColor(string name, byte a, Color value)
        {
            SetColor(name, Color.FromArgb(a, value));
        }

        /// <summary>
        /// Invalidates the bitmap.
        /// </summary>
        private void InvalidateBitmap()
        {
            if (_Transparent && _ControlMode)
            {
                if (Width == 0 || Height == 0)
                    return;
                B = new Bitmap(Width, Height, PixelFormat.Format32bppPArgb);
                G = Graphics.FromImage(B);
            }
            else
            {
                G = null;
                B = null;
            }
        }

        /// <summary>
        /// Invalidates the custimization.
        /// </summary>
        private void InvalidateCustimization()
        {
            MemoryStream M = new MemoryStream(Items.Count * 4);

            foreach (Bloom B in Colors)
            {
                M.Write(BitConverter.GetBytes(B.Value.ToArgb()), 0, 4);
            }

            M.Close();
            _Customization = Convert.ToBase64String(M.ToArray());
        }

        /// <summary>
        /// Invalidates the timer.
        /// </summary>
        private void InvalidateTimer()
        {
            if (DesignMode || !DoneCreation)
                return;

            if (_IsAnimated)
            {
                ThemeShare.AddAnimationCallback(DoAnimation);
            }
            else
            {
                ThemeShare.RemoveAnimationCallback(DoAnimation);
            }
        }

        #endregion

        #region " User Hooks "

        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected abstract void ColorHook();
        /// <summary>
        /// Paints the hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        protected abstract void PaintHook(PaintEventArgs e);

        /// <summary>
        /// Called when [creation].
        /// </summary>
        protected virtual void OnCreation()
        {
        }

        /// <summary>
        /// Called when [animation].
        /// </summary>
        protected virtual void OnAnimation()
        {
        }

        #endregion

        #region " Offset "

        /// <summary>
        /// The offset return rectangle
        /// </summary>
        private Rectangle OffsetReturnRectangle;
        /// <summary>
        /// Offsets the specified r.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="amount">The amount.</param>
        /// <returns>Rectangle.</returns>
        protected Rectangle Offset(Rectangle r, int amount)
        {
            OffsetReturnRectangle = new Rectangle(r.X + amount, r.Y + amount, r.Width - (amount * 2), r.Height - (amount * 2));
            return OffsetReturnRectangle;
        }

        /// <summary>
        /// The offset return size
        /// </summary>
        private Size OffsetReturnSize;
        /// <summary>
        /// Offsets the specified s.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="amount">The amount.</param>
        /// <returns>Size.</returns>
        protected Size Offset(Size s, int amount)
        {
            OffsetReturnSize = new Size(s.Width + amount, s.Height + amount);
            return OffsetReturnSize;
        }

        /// <summary>
        /// The offset return point
        /// </summary>
        private Point OffsetReturnPoint;
        /// <summary>
        /// Offsets the specified p.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="amount">The amount.</param>
        /// <returns>Point.</returns>
        protected Point Offset(Point p, int amount)
        {
            OffsetReturnPoint = new Point(p.X + amount, p.Y + amount);
            return OffsetReturnPoint;
        }

        #endregion

        #region " Center "


        /// <summary>
        /// The center return
        /// </summary>
        private Point CenterReturn;
        /// <summary>
        /// Centers the specified p.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="c">The c.</param>
        /// <returns>Point.</returns>
        protected Point Center(Rectangle p, Rectangle c)
        {
            CenterReturn = new Point((p.Width / 2 - c.Width / 2) + p.X + c.X, (p.Height / 2 - c.Height / 2) + p.Y + c.Y);
            return CenterReturn;
        }
        /// <summary>
        /// Centers the specified p.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="c">The c.</param>
        /// <returns>Point.</returns>
        protected Point Center(Rectangle p, Size c)
        {
            CenterReturn = new Point((p.Width / 2 - c.Width / 2) + p.X, (p.Height / 2 - c.Height / 2) + p.Y);
            return CenterReturn;
        }

        /// <summary>
        /// Centers the specified child.
        /// </summary>
        /// <param name="child">The child.</param>
        /// <returns>Point.</returns>
        protected Point Center(Rectangle child)
        {
            return Center(Width, Height, child.Width, child.Height);
        }
        /// <summary>
        /// Centers the specified child.
        /// </summary>
        /// <param name="child">The child.</param>
        /// <returns>Point.</returns>
        protected Point Center(Size child)
        {
            return Center(Width, Height, child.Width, child.Height);
        }
        /// <summary>
        /// Centers the specified child width.
        /// </summary>
        /// <param name="childWidth">Width of the child.</param>
        /// <param name="childHeight">Height of the child.</param>
        /// <returns>Point.</returns>
        protected Point Center(int childWidth, int childHeight)
        {
            return Center(Width, Height, childWidth, childHeight);
        }

        /// <summary>
        /// Centers the specified p.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="c">The c.</param>
        /// <returns>Point.</returns>
        protected Point Center(Size p, Size c)
        {
            return Center(p.Width, p.Height, c.Width, c.Height);
        }

        /// <summary>
        /// Centers the specified p width.
        /// </summary>
        /// <param name="pWidth">Width of the p.</param>
        /// <param name="pHeight">Height of the p.</param>
        /// <param name="cWidth">Width of the c.</param>
        /// <param name="cHeight">Height of the c.</param>
        /// <returns>Point.</returns>
        protected Point Center(int pWidth, int pHeight, int cWidth, int cHeight)
        {
            CenterReturn = new Point(pWidth / 2 - cWidth / 2, pHeight / 2 - cHeight / 2);
            return CenterReturn;
        }

        #endregion

        #region " Measure "

        /// <summary>
        /// The measure bitmap
        /// </summary>
        private Bitmap MeasureBitmap;

        /// <summary>
        /// The measure graphics
        /// </summary>
        private Graphics MeasureGraphics;
        /// <summary>
        /// Measures this instance.
        /// </summary>
        /// <returns>Size.</returns>
        protected Size Measure()
        {
            lock (MeasureGraphics)
            {
                return MeasureGraphics.MeasureString(Text, Font, Width).ToSize();
            }
        }
        /// <summary>
        /// Measures the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>Size.</returns>
        protected Size Measure(string text)
        {
            lock (MeasureGraphics)
            {
                return MeasureGraphics.MeasureString(text, Font, Width).ToSize();
            }
        }

        #endregion

        #region " DrawPixel "


        /// <summary>
        /// The draw pixel brush
        /// </summary>
        private SolidBrush DrawPixelBrush;
        /// <summary>
        /// Draws the pixel.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawPixel(Color c1, int x, int y)
        {
            if (_Transparent)
            {
                B.SetPixel(x, y, c1);
            }
            else
            {
                DrawPixelBrush = new SolidBrush(c1);
                G.FillRectangle(DrawPixelBrush, x, y, 1, 1);
            }
        }

        #endregion

        #region " DrawCorners "


        /// <summary>
        /// The draw corners brush
        /// </summary>
        private SolidBrush DrawCornersBrush;
        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawCorners(Color c1, int offset)
        {
            DrawCorners(c1, 0, 0, Width, Height, offset);
        }
        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="r1">The r1.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawCorners(Color c1, Rectangle r1, int offset)
        {
            DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height, offset);
        }
        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawCorners(Color c1, int x, int y, int width, int height, int offset)
        {
            DrawCorners(c1, x + offset, y + offset, width - (offset * 2), height - (offset * 2));
        }

        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        protected void DrawCorners(Color c1)
        {
            DrawCorners(c1, 0, 0, Width, Height);
        }
        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="r1">The r1.</param>
        protected void DrawCorners(Color c1, Rectangle r1)
        {
            DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height);
        }
        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawCorners(Color c1, int x, int y, int width, int height)
        {
            if (_NoRounding)
                return;

            if (_Transparent)
            {
                B.SetPixel(x, y, c1);
                B.SetPixel(x + (width - 1), y, c1);
                B.SetPixel(x, y + (height - 1), c1);
                B.SetPixel(x + (width - 1), y + (height - 1), c1);
            }
            else
            {
                DrawCornersBrush = new SolidBrush(c1);
                G.FillRectangle(DrawCornersBrush, x, y, 1, 1);
                G.FillRectangle(DrawCornersBrush, x + (width - 1), y, 1, 1);
                G.FillRectangle(DrawCornersBrush, x, y + (height - 1), 1, 1);
                G.FillRectangle(DrawCornersBrush, x + (width - 1), y + (height - 1), 1, 1);
            }
        }

        #endregion

        #region " DrawBorders "

        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Pen p1, int offset)
        {
            DrawBorders(p1, 0, 0, Width, Height, offset);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="r">The r.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Pen p1, Rectangle r, int offset)
        {
            DrawBorders(p1, r.X, r.Y, r.Width, r.Height, offset);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Pen p1, int x, int y, int width, int height, int offset)
        {
            DrawBorders(p1, x + offset, y + offset, width - (offset * 2), height - (offset * 2));
        }

        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        protected void DrawBorders(Pen p1)
        {
            DrawBorders(p1, 0, 0, Width, Height);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="r">The r.</param>
        protected void DrawBorders(Pen p1, Rectangle r)
        {
            DrawBorders(p1, r.X, r.Y, r.Width, r.Height);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawBorders(Pen p1, int x, int y, int width, int height)
        {
            G.DrawRectangle(p1, x, y, width - 1, height - 1);
        }

        #endregion

        #region " DrawText "

        /// <summary>
        /// The draw text point
        /// </summary>
        private Point DrawTextPoint;

        /// <summary>
        /// The draw text size
        /// </summary>
        private Size DrawTextSize;
        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="a">a.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawText(Brush b1, HorizontalAlignment a, int x, int y)
        {
            DrawText(b1, Text, a, x, y);
        }
        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="text">The text.</param>
        /// <param name="a">a.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawText(Brush b1, string text, HorizontalAlignment a, int x, int y)
        {
            if (text.Length == 0)
                return;

            DrawTextSize = Measure(text);
            DrawTextPoint = new Point(Width / 2 - DrawTextSize.Width / 2, Header / 2 - DrawTextSize.Height / 2);

            switch (a)
            {
                case HorizontalAlignment.Left:
                    G.DrawString(text, Font, b1, x, DrawTextPoint.Y + y);
                    break;
                case HorizontalAlignment.Center:
                    G.DrawString(text, Font, b1, DrawTextPoint.X + x, DrawTextPoint.Y + y);
                    break;
                case HorizontalAlignment.Right:
                    G.DrawString(text, Font, b1, Width - DrawTextSize.Width - x, DrawTextPoint.Y + y);
                    break;
            }
        }

        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="p1">The p1.</param>
        protected void DrawText(Brush b1, Point p1)
        {
            if (Text.Length == 0)
                return;
            G.DrawString(Text, Font, b1, p1);
        }
        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawText(Brush b1, int x, int y)
        {
            if (Text.Length == 0)
                return;
            G.DrawString(Text, Font, b1, x, y);
        }

        #endregion

        #region " DrawImage "


        /// <summary>
        /// The draw image point
        /// </summary>
        private Point DrawImagePoint;
        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawImage(HorizontalAlignment a, int x, int y)
        {
            DrawImage(_Image, a, x, y);
        }
        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="a">a.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawImage(Image image, HorizontalAlignment a, int x, int y)
        {
            if (image == null)
                return;
            DrawImagePoint = new Point(Width / 2 - image.Width / 2, Header / 2 - image.Height / 2);

            switch (a)
            {
                case HorizontalAlignment.Left:
                    G.DrawImage(image, x, DrawImagePoint.Y + y, image.Width, image.Height);
                    break;
                case HorizontalAlignment.Center:
                    G.DrawImage(image, DrawImagePoint.X + x, DrawImagePoint.Y + y, image.Width, image.Height);
                    break;
                case HorizontalAlignment.Right:
                    G.DrawImage(image, Width - image.Width - x, DrawImagePoint.Y + y, image.Width, image.Height);
                    break;
            }
        }

        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="p1">The p1.</param>
        protected void DrawImage(Point p1)
        {
            DrawImage(_Image, p1.X, p1.Y);
        }
        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawImage(int x, int y)
        {
            DrawImage(_Image, x, y);
        }

        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="p1">The p1.</param>
        protected void DrawImage(Image image, Point p1)
        {
            DrawImage(image, p1.X, p1.Y);
        }
        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawImage(Image image, int x, int y)
        {
            if (image == null)
                return;
            G.DrawImage(image, x, y, image.Width, image.Height);
        }

        #endregion

        #region " DrawGradient "

        /// <summary>
        /// The draw gradient brush
        /// </summary>
        private LinearGradientBrush DrawGradientBrush;

        /// <summary>
        /// The draw gradient rectangle
        /// </summary>
        private Rectangle DrawGradientRectangle;
        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawGradient(ColorBlend blend, int x, int y, int width, int height)
        {
            DrawGradientRectangle = new Rectangle(x, y, width, height);
            DrawGradient(blend, DrawGradientRectangle);
        }
        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawGradient(ColorBlend blend, int x, int y, int width, int height, float angle)
        {
            DrawGradientRectangle = new Rectangle(x, y, width, height);
            DrawGradient(blend, DrawGradientRectangle, angle);
        }

        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="r">The r.</param>
        protected void DrawGradient(ColorBlend blend, Rectangle r)
        {
            DrawGradientBrush = new LinearGradientBrush(r, Color.Empty, Color.Empty, 90f);
            DrawGradientBrush.InterpolationColors = blend;
            G.FillRectangle(DrawGradientBrush, r);
        }
        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="r">The r.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawGradient(ColorBlend blend, Rectangle r, float angle)
        {
            DrawGradientBrush = new LinearGradientBrush(r, Color.Empty, Color.Empty, angle);
            DrawGradientBrush.InterpolationColors = blend;
            G.FillRectangle(DrawGradientBrush, r);
        }


        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawGradient(Color c1, Color c2, int x, int y, int width, int height)
        {
            DrawGradientRectangle = new Rectangle(x, y, width, height);
            DrawGradient(c1, c2, DrawGradientRectangle);
        }
        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawGradient(Color c1, Color c2, int x, int y, int width, int height, float angle)
        {
            DrawGradientRectangle = new Rectangle(x, y, width, height);
            DrawGradient(c1, c2, DrawGradientRectangle, angle);
        }

        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="r">The r.</param>
        protected void DrawGradient(Color c1, Color c2, Rectangle r)
        {
            DrawGradientBrush = new LinearGradientBrush(r, c1, c2, 90f);
            G.FillRectangle(DrawGradientBrush, r);
        }
        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="r">The r.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawGradient(Color c1, Color c2, Rectangle r, float angle)
        {
            DrawGradientBrush = new LinearGradientBrush(r, c1, c2, angle);
            G.FillRectangle(DrawGradientBrush, r);
        }

        #endregion

        #region " DrawRadial "

        /// <summary>
        /// The draw radial path
        /// </summary>
        private GraphicsPath DrawRadialPath;
        /// <summary>
        /// The draw radial brush1
        /// </summary>
        private PathGradientBrush DrawRadialBrush1;
        /// <summary>
        /// The draw radial brush2
        /// </summary>
        private LinearGradientBrush DrawRadialBrush2;

        /// <summary>
        /// The draw radial rectangle
        /// </summary>
        private Rectangle DrawRadialRectangle;
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public void DrawRadial(ColorBlend blend, int x, int y, int width, int height)
        {
            DrawRadialRectangle = new Rectangle(x, y, width, height);
            DrawRadial(blend, DrawRadialRectangle, width / 2, height / 2);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="center">The center.</param>
        public void DrawRadial(ColorBlend blend, int x, int y, int width, int height, Point center)
        {
            DrawRadialRectangle = new Rectangle(x, y, width, height);
            DrawRadial(blend, DrawRadialRectangle, center.X, center.Y);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="cx">The cx.</param>
        /// <param name="cy">The cy.</param>
        public void DrawRadial(ColorBlend blend, int x, int y, int width, int height, int cx, int cy)
        {
            DrawRadialRectangle = new Rectangle(x, y, width, height);
            DrawRadial(blend, DrawRadialRectangle, cx, cy);
        }

        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="r">The r.</param>
        public void DrawRadial(ColorBlend blend, Rectangle r)
        {
            DrawRadial(blend, r, r.Width / 2, r.Height / 2);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="r">The r.</param>
        /// <param name="center">The center.</param>
        public void DrawRadial(ColorBlend blend, Rectangle r, Point center)
        {
            DrawRadial(blend, r, center.X, center.Y);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="r">The r.</param>
        /// <param name="cx">The cx.</param>
        /// <param name="cy">The cy.</param>
        public void DrawRadial(ColorBlend blend, Rectangle r, int cx, int cy)
        {
            DrawRadialPath.Reset();
            DrawRadialPath.AddEllipse(r.X, r.Y, r.Width - 1, r.Height - 1);

            DrawRadialBrush1 = new PathGradientBrush(DrawRadialPath);
            DrawRadialBrush1.CenterPoint = new Point(r.X + cx, r.Y + cy);
            DrawRadialBrush1.InterpolationColors = blend;

            if (G.SmoothingMode == SmoothingMode.AntiAlias)
            {
                G.FillEllipse(DrawRadialBrush1, r.X + 1, r.Y + 1, r.Width - 3, r.Height - 3);
            }
            else
            {
                G.FillEllipse(DrawRadialBrush1, r);
            }
        }


        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawRadial(Color c1, Color c2, int x, int y, int width, int height)
        {
            DrawRadialRectangle = new Rectangle(x, y, width, height);
            DrawRadial(c1, c2, DrawGradientRectangle);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawRadial(Color c1, Color c2, int x, int y, int width, int height, float angle)
        {
            DrawRadialRectangle = new Rectangle(x, y, width, height);
            DrawRadial(c1, c2, DrawGradientRectangle, angle);
        }

        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="r">The r.</param>
        protected void DrawRadial(Color c1, Color c2, Rectangle r)
        {
            DrawRadialBrush2 = new LinearGradientBrush(r, c1, c2, 90f);
            G.FillRectangle(DrawGradientBrush, r);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="r">The r.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawRadial(Color c1, Color c2, Rectangle r, float angle)
        {
            DrawRadialBrush2 = new LinearGradientBrush(r, c1, c2, angle);
            G.FillEllipse(DrawGradientBrush, r);
        }

        #endregion

        #region " CreateRound "

        /// <summary>
        /// The create round path
        /// </summary>
        private GraphicsPath CreateRoundPath;

        /// <summary>
        /// The create round rectangle
        /// </summary>
        private Rectangle CreateRoundRectangle;
        /// <summary>
        /// Creates the round.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="slope">The slope.</param>
        /// <returns>GraphicsPath.</returns>
        public GraphicsPath CreateRound(int x, int y, int width, int height, int slope)
        {
            CreateRoundRectangle = new Rectangle(x, y, width, height);
            return CreateRound(CreateRoundRectangle, slope);
        }

        /// <summary>
        /// Creates the round.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="slope">The slope.</param>
        /// <returns>GraphicsPath.</returns>
        public GraphicsPath CreateRound(Rectangle r, int slope)
        {
            CreateRoundPath = new GraphicsPath(FillMode.Winding);
            CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180f, 90f);
            CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270f, 90f);
            CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0f, 90f);
            CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90f, 90f);
            CreateRoundPath.CloseFigure();
            return CreateRoundPath;
        }

        #endregion

    }

    //---------------ThemeControl
    /// <summary>
    /// Class ThemeControl.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public abstract class ThemeControl : Control
    {


        #region " Initialization "

        /// <summary>
        /// The g
        /// </summary>
        protected Graphics G;

        /// <summary>
        /// The b
        /// </summary>
        protected Bitmap B;
        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeControl"/> class.
        /// </summary>
        public ThemeControl()
        {
            SetStyle((ControlStyles)139270, true);

            _ImageSize = Size.Empty;
            Font = new Font("Verdana", 8);

            MeasureBitmap = new Bitmap(1, 1);
            MeasureGraphics = Graphics.FromImage(MeasureBitmap);

            DrawRadialPath = new GraphicsPath();

            InvalidateCustimization();
            //Remove?
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.HandleCreated" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override sealed void OnHandleCreated(EventArgs e)
        {
            InvalidateCustimization();
            ColorHook();

            if (!(_LockWidth == 0))
                Width = _LockWidth;
            if (!(_LockHeight == 0))
                Height = _LockHeight;

            Transparent = _Transparent;
            if (_Transparent && _BackColor)
                BackColor = Color.Transparent;

            base.OnHandleCreated(e);
        }

        /// <summary>
        /// The done creation
        /// </summary>
        private bool DoneCreation;
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.ParentChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override sealed void OnParentChanged(EventArgs e)
        {
            if (Parent != null)
            {
                OnCreation();
                DoneCreation = true;
                InvalidateTimer();
            }

            base.OnParentChanged(e);
        }

        #endregion

        /// <summary>
        /// Does the animation.
        /// </summary>
        /// <param name="i">if set to <c>true</c> [i].</param>
        private void DoAnimation(bool i)
        {
            OnAnimation();
            if (i)
                Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            if (Width == 0 || Height == 0)
                return;

            if (_Transparent)
            {
                PaintHook(e);
                e.Graphics.DrawImage(B, 0, 0);
            }
            else
            {
                G = e.Graphics;
                PaintHook(e);
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.HandleDestroyed" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnHandleDestroyed(EventArgs e)
        {
            ThemeShare.RemoveAnimationCallback(DoAnimation);
            base.OnHandleDestroyed(e);
        }

        #region " Size Handling "

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.SizeChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override sealed void OnSizeChanged(EventArgs e)
        {
            if (_Transparent)
            {
                InvalidateBitmap();
            }

            Invalidate();
            base.OnSizeChanged(e);
        }

        /// <summary>
        /// Performs the work of setting the specified bounds of this control.
        /// </summary>
        /// <param name="x">The new <see cref="P:System.Windows.Forms.Control.Left" /> property value of the control.</param>
        /// <param name="y">The new <see cref="P:System.Windows.Forms.Control.Top" /> property value of the control.</param>
        /// <param name="width">The new <see cref="P:System.Windows.Forms.Control.Width" /> property value of the control.</param>
        /// <param name="height">The new <see cref="P:System.Windows.Forms.Control.Height" /> property value of the control.</param>
        /// <param name="specified">A bitwise combination of the <see cref="T:System.Windows.Forms.BoundsSpecified" /> values.</param>
        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            if (!(_LockWidth == 0))
                width = _LockWidth;
            if (!(_LockHeight == 0))
                height = _LockHeight;
            base.SetBoundsCore(x, y, width, height, specified);
        }

        #endregion

        #region " State Handling "

        /// <summary>
        /// The in position
        /// </summary>
        private bool InPosition;

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseEnter" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnMouseEnter(EventArgs e)
        {
            InPosition = true;
            SetState(MouseState.Over);
            base.OnMouseEnter(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseUp" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (InPosition)
                SetState(MouseState.Over);
            base.OnMouseUp(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseDown" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                SetState(MouseState.Down);
            base.OnMouseDown(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseLeave" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnMouseLeave(EventArgs e)
        {
            InPosition = false;
            SetState(MouseState.None);
            base.OnMouseLeave(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.EnabledChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnEnabledChanged(EventArgs e)
        {
            if (Enabled)
                SetState(MouseState.None);
            else
                SetState(MouseState.Block);
            base.OnEnabledChanged(e);
        }

        /// <summary>
        /// The state
        /// </summary>
        protected MouseState State;
        /// <summary>
        /// Sets the state.
        /// </summary>
        /// <param name="current">The current.</param>
        private void SetState(MouseState current)
        {
            State = current;
            Invalidate();
        }

        #endregion


        #region " Base Properties "

        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public override Color ForeColor
        //{
        //    get { return Color.Empty; }
        //    set { }
        //}
        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public override Image BackgroundImage
        //{
        //    get { return null; }
        //    set { }
        //}
        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public override ImageLayout BackgroundImageLayout
        //{
        //    get { return ImageLayout.None; }
        //    set { }
        //}

        /// <summary>
        /// Gets or sets the text associated with this control.
        /// </summary>
        /// <value>The text.</value>
        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }
        /// <summary>
        /// Gets or sets the font of the text displayed by the control.
        /// </summary>
        /// <value>The font.</value>
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The back color
        /// </summary>
        private bool _BackColor;
        /// <summary>
        /// Gets or sets the background color for the control.
        /// </summary>
        /// <value>The color of the back.</value>
        [Category("Misc")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                if (!IsHandleCreated && value == Color.Transparent)
                {
                    _BackColor = true;
                    return;
                }

                base.BackColor = value;
                if (Parent != null)
                    ColorHook();
            }
        }

        #endregion

        #region " Public Properties "

        /// <summary>
        /// The no rounding
        /// </summary>
        private bool _NoRounding;
        /// <summary>
        /// Gets or sets a value indicating whether [no rounding].
        /// </summary>
        /// <value><c>true</c> if [no rounding]; otherwise, <c>false</c>.</value>
        public bool NoRounding
        {
            get { return _NoRounding; }
            set
            {
                _NoRounding = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The image
        /// </summary>
        private Image _Image;
        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>The image.</value>
        public Image Image
        {
            get { return _Image; }
            set
            {
                if (value == null)
                {
                    _ImageSize = Size.Empty;
                }
                else
                {
                    _ImageSize = value.Size;
                }

                _Image = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The transparent
        /// </summary>
        private bool _Transparent;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ThemeControl"/> is transparent.
        /// </summary>
        /// <value><c>true</c> if transparent; otherwise, <c>false</c>.</value>
        /// <exception cref="System.Exception">Unable to change value to false while a transparent BackColor is in use.</exception>
        public bool Transparent
        {
            get { return _Transparent; }
            set
            {
                _Transparent = value;
                if (!IsHandleCreated)
                    return;

                if (!value && !(BackColor.A == 255))
                {
                    throw new Exception("Unable to change value to false while a transparent BackColor is in use.");
                }

                SetStyle(ControlStyles.Opaque, !value);
                SetStyle(ControlStyles.SupportsTransparentBackColor, value);

                if (value)
                    InvalidateBitmap();
                else
                    B = null;
                Invalidate();
            }
        }

        /// <summary>
        /// The items
        /// </summary>
        private Dictionary<string, Color> Items = new Dictionary<string, Color>();
        /// <summary>
        /// Gets or sets the colors.
        /// </summary>
        /// <value>The colors.</value>
        public Bloom[] Colors
        {
            get
            {
                List<Bloom> T = new List<Bloom>();
                Dictionary<string, Color>.Enumerator E = Items.GetEnumerator();

                while (E.MoveNext())
                {
                    T.Add(new Bloom(E.Current.Key, E.Current.Value));
                }

                return T.ToArray();
            }
            set
            {
                foreach (Bloom B in value)
                {
                    if (Items.ContainsKey(B.Name))
                        Items[B.Name] = B.Value;
                }

                InvalidateCustimization();
                ColorHook();
                Invalidate();
            }
        }

        /// <summary>
        /// The customization
        /// </summary>
        private string _Customization;
        /// <summary>
        /// Gets or sets the customization.
        /// </summary>
        /// <value>The customization.</value>
        public string Customization
        {
            get { return _Customization; }
            set
            {
                if (value == _Customization)
                    return;

                byte[] Data = null;
                Bloom[] Items = Colors;

                try
                {
                    Data = Convert.FromBase64String(value);
                    for (int I = 0; I <= Items.Length - 1; I++)
                    {
                        Items[I].Value = Color.FromArgb(BitConverter.ToInt32(Data, I * 4));
                    }
                }
                catch
                {
                    return;
                }

                _Customization = value;

                Colors = Items;
                ColorHook();
                Invalidate();
            }
        }

        #endregion

        #region " Private Properties "

        /// <summary>
        /// The image size
        /// </summary>
        private Size _ImageSize;
        /// <summary>
        /// Gets the size of the image.
        /// </summary>
        /// <value>The size of the image.</value>
        protected Size ImageSize
        {
            get { return _ImageSize; }
        }

        /// <summary>
        /// The lock width
        /// </summary>
        private int _LockWidth;
        /// <summary>
        /// Gets or sets the width of the lock.
        /// </summary>
        /// <value>The width of the lock.</value>
        protected int LockWidth
        {
            get { return _LockWidth; }
            set
            {
                _LockWidth = value;
                if (!(LockWidth == 0) && IsHandleCreated)
                    Width = LockWidth;
            }
        }

        /// <summary>
        /// The lock height
        /// </summary>
        private int _LockHeight;
        /// <summary>
        /// Gets or sets the height of the lock.
        /// </summary>
        /// <value>The height of the lock.</value>
        protected int LockHeight
        {
            get { return _LockHeight; }
            set
            {
                _LockHeight = value;
                if (!(LockHeight == 0) && IsHandleCreated)
                    Height = LockHeight;
            }
        }

        /// <summary>
        /// The is animated
        /// </summary>
        private bool _IsAnimated;
        /// <summary>
        /// Gets or sets a value indicating whether this instance is animated.
        /// </summary>
        /// <value><c>true</c> if this instance is animated; otherwise, <c>false</c>.</value>
        protected bool IsAnimated
        {
            get { return _IsAnimated; }
            set
            {
                _IsAnimated = value;
                InvalidateTimer();
            }
        }

        #endregion

        #region " Property Helpers "

        /// <summary>
        /// Gets the pen.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Pen.</returns>
        protected Pen GetPen(string name)
        {
            return new Pen(Items[name]);
        }
        /// <summary>
        /// Gets the pen.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="width">The width.</param>
        /// <returns>Pen.</returns>
        protected Pen GetPen(string name, float width)
        {
            return new Pen(Items[name], width);
        }

        /// <summary>
        /// Gets the brush.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>SolidBrush.</returns>
        protected SolidBrush GetBrush(string name)
        {
            return new SolidBrush(Items[name]);
        }

        /// <summary>
        /// Gets the color.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Color.</returns>
        protected Color GetColor(string name)
        {
            return Items[name];
        }

        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        protected void SetColor(string name, Color value)
        {
            if (Items.ContainsKey(name))
                Items[name] = value;
            else
                Items.Add(name, value);
        }
        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="r">The r.</param>
        /// <param name="g">The g.</param>
        /// <param name="b">The b.</param>
        protected void SetColor(string name, byte r, byte g, byte b)
        {
            SetColor(name, Color.FromArgb(r, g, b));
        }
        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="a">a.</param>
        /// <param name="r">The r.</param>
        /// <param name="g">The g.</param>
        /// <param name="b">The b.</param>
        protected void SetColor(string name, byte a, byte r, byte g, byte b)
        {
            SetColor(name, Color.FromArgb(a, r, g, b));
        }
        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="a">a.</param>
        /// <param name="value">The value.</param>
        protected void SetColor(string name, byte a, Color value)
        {
            SetColor(name, Color.FromArgb(a, value));
        }

        /// <summary>
        /// Invalidates the bitmap.
        /// </summary>
        private void InvalidateBitmap()
        {
            if (Width == 0 || Height == 0)
                return;
            B = new Bitmap(Width, Height, PixelFormat.Format32bppPArgb);
            G = Graphics.FromImage(B);
        }

        /// <summary>
        /// Invalidates the custimization.
        /// </summary>
        private void InvalidateCustimization()
        {
            MemoryStream M = new MemoryStream(Items.Count * 4);

            foreach (Bloom B in Colors)
            {
                M.Write(BitConverter.GetBytes(B.Value.ToArgb()), 0, 4);
            }

            M.Close();
            _Customization = Convert.ToBase64String(M.ToArray());
        }

        /// <summary>
        /// Invalidates the timer.
        /// </summary>
        private void InvalidateTimer()
        {
            if (DesignMode || !DoneCreation)
                return;

            if (_IsAnimated)
            {
                ThemeShare.AddAnimationCallback(DoAnimation);
            }
            else
            {
                ThemeShare.RemoveAnimationCallback(DoAnimation);
            }
        }
        #endregion

        #region " User Hooks "

        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected abstract void ColorHook();

        /// <summary>
        /// Paints the hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        protected abstract void PaintHook(PaintEventArgs e);

        /// <summary>
        /// Called when [creation].
        /// </summary>
        protected virtual void OnCreation()
        {
        }

        /// <summary>
        /// Called when [animation].
        /// </summary>
        protected virtual void OnAnimation()
        {
        }

        #endregion

        #region " Offset "

        /// <summary>
        /// The offset return rectangle
        /// </summary>
        private Rectangle OffsetReturnRectangle;
        /// <summary>
        /// Offsets the specified r.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="amount">The amount.</param>
        /// <returns>Rectangle.</returns>
        protected Rectangle Offset(Rectangle r, int amount)
        {
            OffsetReturnRectangle = new Rectangle(r.X + amount, r.Y + amount, r.Width - (amount * 2), r.Height - (amount * 2));
            return OffsetReturnRectangle;
        }

        /// <summary>
        /// The offset return size
        /// </summary>
        private Size OffsetReturnSize;
        /// <summary>
        /// Offsets the specified s.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="amount">The amount.</param>
        /// <returns>Size.</returns>
        protected Size Offset(Size s, int amount)
        {
            OffsetReturnSize = new Size(s.Width + amount, s.Height + amount);
            return OffsetReturnSize;
        }

        /// <summary>
        /// The offset return point
        /// </summary>
        private Point OffsetReturnPoint;
        /// <summary>
        /// Offsets the specified p.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="amount">The amount.</param>
        /// <returns>Point.</returns>
        protected Point Offset(Point p, int amount)
        {
            OffsetReturnPoint = new Point(p.X + amount, p.Y + amount);
            return OffsetReturnPoint;
        }

        #endregion

        #region " Center "


        /// <summary>
        /// The center return
        /// </summary>
        private Point CenterReturn;
        /// <summary>
        /// Centers the specified p.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="c">The c.</param>
        /// <returns>Point.</returns>
        protected Point Center(Rectangle p, Rectangle c)
        {
            CenterReturn = new Point((p.Width / 2 - c.Width / 2) + p.X + c.X, (p.Height / 2 - c.Height / 2) + p.Y + c.Y);
            return CenterReturn;
        }
        /// <summary>
        /// Centers the specified p.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="c">The c.</param>
        /// <returns>Point.</returns>
        protected Point Center(Rectangle p, Size c)
        {
            CenterReturn = new Point((p.Width / 2 - c.Width / 2) + p.X, (p.Height / 2 - c.Height / 2) + p.Y);
            return CenterReturn;
        }

        /// <summary>
        /// Centers the specified child.
        /// </summary>
        /// <param name="child">The child.</param>
        /// <returns>Point.</returns>
        protected Point Center(Rectangle child)
        {
            return Center(Width, Height, child.Width, child.Height);
        }
        /// <summary>
        /// Centers the specified child.
        /// </summary>
        /// <param name="child">The child.</param>
        /// <returns>Point.</returns>
        protected Point Center(Size child)
        {
            return Center(Width, Height, child.Width, child.Height);
        }
        /// <summary>
        /// Centers the specified child width.
        /// </summary>
        /// <param name="childWidth">Width of the child.</param>
        /// <param name="childHeight">Height of the child.</param>
        /// <returns>Point.</returns>
        protected Point Center(int childWidth, int childHeight)
        {
            return Center(Width, Height, childWidth, childHeight);
        }

        /// <summary>
        /// Centers the specified p.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="c">The c.</param>
        /// <returns>Point.</returns>
        protected Point Center(Size p, Size c)
        {
            return Center(p.Width, p.Height, c.Width, c.Height);
        }

        /// <summary>
        /// Centers the specified p width.
        /// </summary>
        /// <param name="pWidth">Width of the p.</param>
        /// <param name="pHeight">Height of the p.</param>
        /// <param name="cWidth">Width of the c.</param>
        /// <param name="cHeight">Height of the c.</param>
        /// <returns>Point.</returns>
        protected Point Center(int pWidth, int pHeight, int cWidth, int cHeight)
        {
            CenterReturn = new Point(pWidth / 2 - cWidth / 2, pHeight / 2 - cHeight / 2);
            return CenterReturn;
        }

        #endregion

        #region " Measure "

        /// <summary>
        /// The measure bitmap
        /// </summary>
        private Bitmap MeasureBitmap;
        //TODO: Potential issues during multi-threading.
        /// <summary>
        /// The measure graphics
        /// </summary>
        private Graphics MeasureGraphics;

        /// <summary>
        /// Measures this instance.
        /// </summary>
        /// <returns>Size.</returns>
        protected Size Measure()
        {
            return MeasureGraphics.MeasureString(Text, Font, Width).ToSize();
        }
        /// <summary>
        /// Measures the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>Size.</returns>
        protected Size Measure(string text)
        {
            return MeasureGraphics.MeasureString(text, Font, Width).ToSize();
        }

        #endregion

        #region " DrawPixel "


        /// <summary>
        /// The draw pixel brush
        /// </summary>
        private SolidBrush DrawPixelBrush;
        /// <summary>
        /// Draws the pixel.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawPixel(Color c1, int x, int y)
        {
            if (_Transparent)
            {
                B.SetPixel(x, y, c1);
            }
            else
            {
                DrawPixelBrush = new SolidBrush(c1);
                G.FillRectangle(DrawPixelBrush, x, y, 1, 1);
            }
        }

        #endregion

        #region " DrawCorners "


        /// <summary>
        /// The draw corners brush
        /// </summary>
        private SolidBrush DrawCornersBrush;
        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawCorners(Color c1, int offset)
        {
            DrawCorners(c1, 0, 0, Width, Height, offset);
        }
        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="r1">The r1.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawCorners(Color c1, Rectangle r1, int offset)
        {
            DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height, offset);
        }
        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawCorners(Color c1, int x, int y, int width, int height, int offset)
        {
            DrawCorners(c1, x + offset, y + offset, width - (offset * 2), height - (offset * 2));
        }

        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        protected void DrawCorners(Color c1)
        {
            DrawCorners(c1, 0, 0, Width, Height);
        }
        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="r1">The r1.</param>
        protected void DrawCorners(Color c1, Rectangle r1)
        {
            DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height);
        }
        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawCorners(Color c1, int x, int y, int width, int height)
        {
            if (_NoRounding)
                return;

            if (_Transparent)
            {
                B.SetPixel(x, y, c1);
                B.SetPixel(x + (width - 1), y, c1);
                B.SetPixel(x, y + (height - 1), c1);
                B.SetPixel(x + (width - 1), y + (height - 1), c1);
            }
            else
            {
                DrawCornersBrush = new SolidBrush(c1);
                G.FillRectangle(DrawCornersBrush, x, y, 1, 1);
                G.FillRectangle(DrawCornersBrush, x + (width - 1), y, 1, 1);
                G.FillRectangle(DrawCornersBrush, x, y + (height - 1), 1, 1);
                G.FillRectangle(DrawCornersBrush, x + (width - 1), y + (height - 1), 1, 1);
            }
        }

        #endregion

        #region " DrawBorders "

        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Pen p1, int offset)
        {
            DrawBorders(p1, 0, 0, Width, Height, offset);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="r">The r.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Pen p1, Rectangle r, int offset)
        {
            DrawBorders(p1, r.X, r.Y, r.Width, r.Height, offset);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Pen p1, int x, int y, int width, int height, int offset)
        {
            DrawBorders(p1, x + offset, y + offset, width - (offset * 2), height - (offset * 2));
        }

        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        protected void DrawBorders(Pen p1)
        {
            DrawBorders(p1, 0, 0, Width, Height);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="r">The r.</param>
        protected void DrawBorders(Pen p1, Rectangle r)
        {
            DrawBorders(p1, r.X, r.Y, r.Width, r.Height);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawBorders(Pen p1, int x, int y, int width, int height)
        {
            G.DrawRectangle(p1, x, y, width - 1, height - 1);
        }

        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="p2">The p2.</param>
        /// <param name="rect">The rect.</param>
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="p2">The p2.</param>
        /// <param name="rect">The rect.</param>
        protected void DrawBorders(Pen p1, Pen p2, Rectangle rect)
        {
            G.DrawRectangle(p1, rect.X, rect.Y, rect.Width - 1, rect.Height - 1);
            G.DrawRectangle(p2, rect.X + 1, rect.Y + 1, rect.Width - 3, rect.Height - 3);
        }
        #endregion

        #region " DrawText "

        /// <summary>
        /// The draw text point
        /// </summary>
        private Point DrawTextPoint;

        /// <summary>
        /// The draw text size
        /// </summary>
        private Size DrawTextSize;
        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="a">a.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawText(Brush b1, HorizontalAlignment a, int x, int y)
        {
            DrawText(b1, Text, a, x, y);
        }
        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="text">The text.</param>
        /// <param name="a">a.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawText(Brush b1, string text, HorizontalAlignment a, int x, int y)
        {
            if (text.Length == 0)
                return;

            DrawTextSize = Measure(text);
            DrawTextPoint = Center(DrawTextSize);

            switch (a)
            {
                case HorizontalAlignment.Left:
                    G.DrawString(text, Font, b1, x, DrawTextPoint.Y + y);
                    break;
                case HorizontalAlignment.Center:
                    G.DrawString(text, Font, b1, DrawTextPoint.X + x, DrawTextPoint.Y + y);
                    break;
                case HorizontalAlignment.Right:
                    G.DrawString(text, Font, b1, Width - DrawTextSize.Width - x, DrawTextPoint.Y + y);
                    break;
            }
        }

        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="p1">The p1.</param>
        protected void DrawText(Brush b1, Point p1)
        {
            if (Text.Length == 0)
                return;
            G.DrawString(Text, Font, b1, p1);
        }
        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawText(Brush b1, int x, int y)
        {
            if (Text.Length == 0)
                return;
            G.DrawString(Text, Font, b1, x, y);
        }

        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="c">The c.</param>
        /// <param name="x">The x.</param>
        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="c">The c.</param>
        /// <param name="x">The x.</param>
        protected void DrawText(HorizontalAlignment a, Color c, int x)
        {
            DrawText(a, c, x, 0);
        }

        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="c">The c.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="c">The c.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawText(HorizontalAlignment a, Color c, int x, int y)
        {
            if (string.IsNullOrEmpty(Text))
                return;
            Size _Size = G.MeasureString(Text, Font).ToSize();
            SolidBrush _Brush = new SolidBrush(c);

            switch (a)
            {
                case HorizontalAlignment.Left:
                    G.DrawString(Text, Font, _Brush, x, Height / 2 - _Size.Height / 2 + y);
                    break;
                case HorizontalAlignment.Right:
                    G.DrawString(Text, Font, _Brush, Width - _Size.Width - x, Height / 2 - _Size.Height / 2 + y);
                    break;
                case HorizontalAlignment.Center:
                    G.DrawString(Text, Font, _Brush, Width / 2 - _Size.Width / 2 + x, Height / 2 - _Size.Height / 2 + y);
                    break;
            }
        }


        #endregion

        #region " DrawImage "


        /// <summary>
        /// The draw image point
        /// </summary>
        private Point DrawImagePoint;
        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawImage(HorizontalAlignment a, int x, int y)
        {
            DrawImage(_Image, a, x, y);
        }
        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="a">a.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawImage(Image image, HorizontalAlignment a, int x, int y)
        {
            if (image == null)
                return;
            DrawImagePoint = Center(image.Size);

            switch (a)
            {
                case HorizontalAlignment.Left:
                    G.DrawImage(image, x, DrawImagePoint.Y + y, image.Width, image.Height);
                    break;
                case HorizontalAlignment.Center:
                    G.DrawImage(image, DrawImagePoint.X + x, DrawImagePoint.Y + y, image.Width, image.Height);
                    break;
                case HorizontalAlignment.Right:
                    G.DrawImage(image, Width - image.Width - x, DrawImagePoint.Y + y, image.Width, image.Height);
                    break;
            }
        }

        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="p1">The p1.</param>
        protected void DrawImage(Point p1)
        {
            DrawImage(_Image, p1.X, p1.Y);
        }
        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawImage(int x, int y)
        {
            DrawImage(_Image, x, y);
        }

        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="p1">The p1.</param>
        protected void DrawImage(Image image, Point p1)
        {
            DrawImage(image, p1.X, p1.Y);
        }
        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawImage(Image image, int x, int y)
        {
            if (image == null)
                return;
            G.DrawImage(image, x, y, image.Width, image.Height);
        }

        #endregion

        #region " DrawGradient "

        /// <summary>
        /// The draw gradient brush
        /// </summary>
        private LinearGradientBrush DrawGradientBrush;

        /// <summary>
        /// The draw gradient rectangle
        /// </summary>
        private Rectangle DrawGradientRectangle;
        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawGradient(ColorBlend blend, int x, int y, int width, int height)
        {
            DrawGradientRectangle = new Rectangle(x, y, width, height);
            DrawGradient(blend, DrawGradientRectangle);
        }
        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawGradient(ColorBlend blend, int x, int y, int width, int height, float angle)
        {
            DrawGradientRectangle = new Rectangle(x, y, width, height);
            DrawGradient(blend, DrawGradientRectangle, angle);
        }

        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="r">The r.</param>
        protected void DrawGradient(ColorBlend blend, Rectangle r)
        {
            DrawGradientBrush = new LinearGradientBrush(r, Color.Empty, Color.Empty, 90f);
            DrawGradientBrush.InterpolationColors = blend;
            G.FillRectangle(DrawGradientBrush, r);
        }
        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="r">The r.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawGradient(ColorBlend blend, Rectangle r, float angle)
        {
            DrawGradientBrush = new LinearGradientBrush(r, Color.Empty, Color.Empty, angle);
            DrawGradientBrush.InterpolationColors = blend;
            G.FillRectangle(DrawGradientBrush, r);
        }


        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawGradient(Color c1, Color c2, int x, int y, int width, int height)
        {
            DrawGradientRectangle = new Rectangle(x, y, width, height);
            DrawGradient(c1, c2, DrawGradientRectangle);
        }
        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawGradient(Color c1, Color c2, int x, int y, int width, int height, float angle)
        {
            DrawGradientRectangle = new Rectangle(x, y, width, height);
            DrawGradient(c1, c2, DrawGradientRectangle, angle);
        }

        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="r">The r.</param>
        protected void DrawGradient(Color c1, Color c2, Rectangle r)
        {
            DrawGradientBrush = new LinearGradientBrush(r, c1, c2, 90f);
            G.FillRectangle(DrawGradientBrush, r);
        }
        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="r">The r.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawGradient(Color c1, Color c2, Rectangle r, float angle)
        {
            DrawGradientBrush = new LinearGradientBrush(r, c1, c2, angle);
            G.FillRectangle(DrawGradientBrush, r);
        }

        #endregion

        #region " DrawRadial "

        /// <summary>
        /// The draw radial path
        /// </summary>
        private GraphicsPath DrawRadialPath;
        /// <summary>
        /// The draw radial brush1
        /// </summary>
        private PathGradientBrush DrawRadialBrush1;
        /// <summary>
        /// The draw radial brush2
        /// </summary>
        private LinearGradientBrush DrawRadialBrush2;

        /// <summary>
        /// The draw radial rectangle
        /// </summary>
        private Rectangle DrawRadialRectangle;
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public void DrawRadial(ColorBlend blend, int x, int y, int width, int height)
        {
            DrawRadialRectangle = new Rectangle(x, y, width, height);
            DrawRadial(blend, DrawRadialRectangle, width / 2, height / 2);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="center">The center.</param>
        public void DrawRadial(ColorBlend blend, int x, int y, int width, int height, Point center)
        {
            DrawRadialRectangle = new Rectangle(x, y, width, height);
            DrawRadial(blend, DrawRadialRectangle, center.X, center.Y);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="cx">The cx.</param>
        /// <param name="cy">The cy.</param>
        public void DrawRadial(ColorBlend blend, int x, int y, int width, int height, int cx, int cy)
        {
            DrawRadialRectangle = new Rectangle(x, y, width, height);
            DrawRadial(blend, DrawRadialRectangle, cx, cy);
        }

        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="r">The r.</param>
        public void DrawRadial(ColorBlend blend, Rectangle r)
        {
            DrawRadial(blend, r, r.Width / 2, r.Height / 2);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="r">The r.</param>
        /// <param name="center">The center.</param>
        public void DrawRadial(ColorBlend blend, Rectangle r, Point center)
        {
            DrawRadial(blend, r, center.X, center.Y);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="r">The r.</param>
        /// <param name="cx">The cx.</param>
        /// <param name="cy">The cy.</param>
        public void DrawRadial(ColorBlend blend, Rectangle r, int cx, int cy)
        {
            DrawRadialPath.Reset();
            DrawRadialPath.AddEllipse(r.X, r.Y, r.Width - 1, r.Height - 1);

            DrawRadialBrush1 = new PathGradientBrush(DrawRadialPath);
            DrawRadialBrush1.CenterPoint = new Point(r.X + cx, r.Y + cy);
            DrawRadialBrush1.InterpolationColors = blend;

            if (G.SmoothingMode == SmoothingMode.AntiAlias)
            {
                G.FillEllipse(DrawRadialBrush1, r.X + 1, r.Y + 1, r.Width - 3, r.Height - 3);
            }
            else
            {
                G.FillEllipse(DrawRadialBrush1, r);
            }
        }


        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawRadial(Color c1, Color c2, int x, int y, int width, int height)
        {
            DrawRadialRectangle = new Rectangle(x, y, width, height);
            DrawRadial(c1, c2, DrawRadialRectangle);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawRadial(Color c1, Color c2, int x, int y, int width, int height, float angle)
        {
            DrawRadialRectangle = new Rectangle(x, y, width, height);
            DrawRadial(c1, c2, DrawRadialRectangle, angle);
        }

        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="r">The r.</param>
        protected void DrawRadial(Color c1, Color c2, Rectangle r)
        {
            DrawRadialBrush2 = new LinearGradientBrush(r, c1, c2, 90f);
            G.FillEllipse(DrawRadialBrush2, r);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="r">The r.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawRadial(Color c1, Color c2, Rectangle r, float angle)
        {
            DrawRadialBrush2 = new LinearGradientBrush(r, c1, c2, angle);
            G.FillEllipse(DrawRadialBrush2, r);
        }

        #endregion

        #region " CreateRound "

        /// <summary>
        /// The create round path
        /// </summary>
        private GraphicsPath CreateRoundPath;

        /// <summary>
        /// The create round rectangle
        /// </summary>
        private Rectangle CreateRoundRectangle;
        /// <summary>
        /// Creates the round.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="slope">The slope.</param>
        /// <returns>GraphicsPath.</returns>
        public GraphicsPath CreateRound(int x, int y, int width, int height, int slope)
        {
            CreateRoundRectangle = new Rectangle(x, y, width, height);
            return CreateRound(CreateRoundRectangle, slope);
        }

        /// <summary>
        /// Creates the round.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="slope">The slope.</param>
        /// <returns>GraphicsPath.</returns>
        public GraphicsPath CreateRound(Rectangle r, int slope)
        {
            CreateRoundPath = new GraphicsPath(FillMode.Winding);
            CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180f, 90f);
            CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270f, 90f);
            CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0f, 90f);
            CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90f, 90f);
            CreateRoundPath.CloseFigure();
            return CreateRoundPath;
        }

        #endregion

    }

    /// <summary>
    /// Class ThemeShare.
    /// </summary>
    static class ThemeShare
    {

        #region " Animation "

        /// <summary>
        /// The frames
        /// </summary>
        private static int Frames;
        /// <summary>
        /// The invalidate
        /// </summary>
        private static bool Invalidate;

        /// <summary>
        /// The theme timer
        /// </summary>
        public static PrecisionTimer ThemeTimer = new PrecisionTimer();
        //1000 / 50 = 20 FPS
        /// <summary>
        /// The FPS
        /// </summary>
        private const int FPS = 50;

        /// <summary>
        /// The rate
        /// </summary>
        private const int Rate = 10;
        /// <summary>
        /// Delegate AnimationDelegate
        /// </summary>
        /// <param name="invalidate">if set to <c>true</c> [invalidate].</param>
        public delegate void AnimationDelegate(bool invalidate);


        /// <summary>
        /// The callbacks
        /// </summary>
        private static List<AnimationDelegate> Callbacks = new List<AnimationDelegate>();
        /// <summary>
        /// Handles the callbacks.
        /// </summary>
        /// <param name="state">The state.</param>
        /// <param name="reserve">if set to <c>true</c> [reserve].</param>
        private static void HandleCallbacks(IntPtr state, bool reserve)
        {
            Invalidate = (Frames >= FPS);
            if (Invalidate)
                Frames = 0;

            lock (Callbacks)
            {
                for (int I = 0; I <= Callbacks.Count - 1; I++)
                {
                    Callbacks[I].Invoke(Invalidate);
                }
            }

            Frames += Rate;
        }

        /// <summary>
        /// Invalidates the theme timer.
        /// </summary>
        private static void InvalidateThemeTimer()
        {
            if (Callbacks.Count == 0)
            {
                ThemeTimer.Delete();
            }
            else
            {
                ThemeTimer.Create(0, Rate, HandleCallbacks);
            }
        }

        /// <summary>
        /// Adds the animation callback.
        /// </summary>
        /// <param name="callback">The callback.</param>
        public static void AddAnimationCallback(AnimationDelegate callback)
        {
            lock (Callbacks)
            {
                if (Callbacks.Contains(callback))
                    return;

                Callbacks.Add(callback);
                InvalidateThemeTimer();
            }
        }

        /// <summary>
        /// Removes the animation callback.
        /// </summary>
        /// <param name="callback">The callback.</param>
        public static void RemoveAnimationCallback(AnimationDelegate callback)
        {
            lock (Callbacks)
            {
                if (!Callbacks.Contains(callback))
                    return;

                Callbacks.Remove(callback);
                InvalidateThemeTimer();
            }
        }

        #endregion

    }

    /// <summary>
    /// Enum MouseState
    /// </summary>
    public enum MouseState : byte
    {
        /// <summary>
        /// The none
        /// </summary>
        None = 0,
        /// <summary>
        /// The over
        /// </summary>
        Over = 1,
        /// <summary>
        /// Down
        /// </summary>
        Down = 2,
        /// <summary>
        /// The block
        /// </summary>
        Block = 3
    }

    /// <summary>
    /// Struct Bloom
    /// </summary>
    public struct Bloom
    {
        /// <summary>
        /// The pen
        /// </summary>
        private Pen _Pen;
        /// <summary>
        /// Gets or sets the pen.
        /// </summary>
        /// <value>The pen.</value>
        public Pen Pen
        {
            get { return _Pen; }
            set { _Pen = value; }
        }

        /// <summary>
        /// The brush
        /// </summary>
        private Brush _Brush;
        /// <summary>
        /// Gets or sets the brush.
        /// </summary>
        /// <value>The brush.</value>
        public Brush Brush
        {
            get { return _Brush; }
            set { _Brush = value; }
        }

        /// <summary>
        /// The name
        /// </summary>
        public string _Name;
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get { return _Name; }
        }

        /// <summary>
        /// The value
        /// </summary>
        private Color _Value;
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public Color Value
        {
            get { return _Value; }
            set { _Value = value; }
        }

        /// <summary>
        /// Gets or sets the value hexadecimal.
        /// </summary>
        /// <value>The value hexadecimal.</value>
        public string ValueHex
        {
            get { return string.Concat("#", _Value.R.ToString("X2", null), _Value.G.ToString("X2", null), _Value.B.ToString("X2", null)); }
            set
            {
                try
                {
                    _Value = ColorTranslator.FromHtml(value);
                }
                catch
                {
                    return;
                }
            }
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Bloom"/> struct.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public Bloom(string name, Color value)
        {
            _Name = name;
            _Value = value;
            _Pen = new Pen(value);
            _Brush = new SolidBrush(value);
        }
    }


    /// <summary>
    /// Class PrecisionTimer.
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public class PrecisionTimer : IDisposable
    {

        /// <summary>
        /// The enabled
        /// </summary>
        private bool _Enabled;
        /// <summary>
        /// Gets a value indicating whether this <see cref="PrecisionTimer"/> is enabled.
        /// </summary>
        /// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
        public bool Enabled
        {
            get { return _Enabled; }
        }

        /// <summary>
        /// The handle
        /// </summary>
        private IntPtr Handle;

        /// <summary>
        /// The timer callback
        /// </summary>
        private TimerDelegate TimerCallback;
        /// <summary>
        /// Creates the timer queue timer.
        /// </summary>
        /// <param name="handle">The handle.</param>
        /// <param name="queue">The queue.</param>
        /// <param name="callback">The callback.</param>
        /// <param name="state">The state.</param>
        /// <param name="dueTime">The due time.</param>
        /// <param name="period">The period.</param>
        /// <param name="flags">The flags.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [DllImport("kernel32.dll", EntryPoint = "CreateTimerQueueTimer")]
        private static extern bool CreateTimerQueueTimer(ref IntPtr handle, IntPtr queue, TimerDelegate callback, IntPtr state, uint dueTime, uint period, uint flags);

        /// <summary>
        /// Deletes the timer queue timer.
        /// </summary>
        /// <param name="queue">The queue.</param>
        /// <param name="handle">The handle.</param>
        /// <param name="callback">The callback.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [DllImport("kernel32.dll", EntryPoint = "DeleteTimerQueueTimer")]
        private static extern bool DeleteTimerQueueTimer(IntPtr queue, IntPtr handle, IntPtr callback);

        /// <summary>
        /// Delegate TimerDelegate
        /// </summary>
        /// <param name="r1">The r1.</param>
        /// <param name="r2">if set to <c>true</c> [r2].</param>
        public delegate void TimerDelegate(IntPtr r1, bool r2);

        /// <summary>
        /// Creates the specified due time.
        /// </summary>
        /// <param name="dueTime">The due time.</param>
        /// <param name="period">The period.</param>
        /// <param name="callback">The callback.</param>
        public void Create(uint dueTime, uint period, TimerDelegate callback)
        {
            if (_Enabled)
                return;

            TimerCallback = callback;
            bool Success = CreateTimerQueueTimer(ref Handle, IntPtr.Zero, TimerCallback, IntPtr.Zero, dueTime, period, 0);

            if (!Success)
                ThrowNewException("CreateTimerQueueTimer");
            _Enabled = Success;
        }

        /// <summary>
        /// Deletes this instance.
        /// </summary>
        public void Delete()
        {
            if (!_Enabled)
                return;
            bool Success = DeleteTimerQueueTimer(IntPtr.Zero, Handle, IntPtr.Zero);

            if (!Success && !(Marshal.GetLastWin32Error() == 997))
            {
                ThrowNewException("DeleteTimerQueueTimer");
            }

            _Enabled = !Success;
        }

        /// <summary>
        /// Throws the new exception.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <exception cref="System.Exception"></exception>
        private void ThrowNewException(string name)
        {
            throw new Exception(string.Format("{0} failed. Win32Error: {1}", name, Marshal.GetLastWin32Error()));
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Delete();
        }
    }

    /// <summary>
    /// Class DesignFunctions.
    /// </summary>
    static class DesignFunctions
    {
        /// <summary>
        /// To the brush.
        /// </summary>
        /// <param name="A">a.</param>
        /// <param name="R">The r.</param>
        /// <param name="G">The g.</param>
        /// <param name="B">The b.</param>
        /// <returns>Brush.</returns>
        public static Brush ToBrush(int A, int R, int G, int B)
        {
            return ToBrush(Color.FromArgb(A, R, G, B));
        }
        /// <summary>
        /// To the brush.
        /// </summary>
        /// <param name="R">The r.</param>
        /// <param name="G">The g.</param>
        /// <param name="B">The b.</param>
        /// <returns>Brush.</returns>
        public static Brush ToBrush(int R, int G, int B)
        {
            return ToBrush(Color.FromArgb(R, G, B));
        }
        /// <summary>
        /// To the brush.
        /// </summary>
        /// <param name="A">a.</param>
        /// <param name="C">The c.</param>
        /// <returns>Brush.</returns>
        public static Brush ToBrush(int A, Color C)
        {
            return ToBrush(Color.FromArgb(A, C));
        }
        /// <summary>
        /// To the brush.
        /// </summary>
        /// <param name="Pen">The pen.</param>
        /// <returns>Brush.</returns>
        public static Brush ToBrush(Pen Pen)
        {
            return ToBrush(Pen.Color);
        }
        /// <summary>
        /// To the brush.
        /// </summary>
        /// <param name="Color">The color.</param>
        /// <returns>Brush.</returns>
        public static Brush ToBrush(Color Color)
        {
            return new SolidBrush(Color);
        }
        /// <summary>
        /// To the pen.
        /// </summary>
        /// <param name="A">a.</param>
        /// <param name="R">The r.</param>
        /// <param name="G">The g.</param>
        /// <param name="B">The b.</param>
        /// <returns>Pen.</returns>
        public static Pen ToPen(int A, int R, int G, int B)
        {
            return ToPen(Color.FromArgb(A, R, G, B));
        }
        /// <summary>
        /// To the pen.
        /// </summary>
        /// <param name="R">The r.</param>
        /// <param name="G">The g.</param>
        /// <param name="B">The b.</param>
        /// <returns>Pen.</returns>
        public static Pen ToPen(int R, int G, int B)
        {
            return ToPen(Color.FromArgb(R, G, B));
        }
        /// <summary>
        /// To the pen.
        /// </summary>
        /// <param name="A">a.</param>
        /// <param name="C">The c.</param>
        /// <returns>Pen.</returns>
        public static Pen ToPen(int A, Color C)
        {
            return ToPen(Color.FromArgb(A, C));
        }
        /// <summary>
        /// To the pen.
        /// </summary>
        /// <param name="Color">The color.</param>
        /// <returns>Pen.</returns>
        public static Pen ToPen(Color Color)
        {
            return ToPen(new SolidBrush(Color));
        }
        /// <summary>
        /// To the pen.
        /// </summary>
        /// <param name="Brush">The brush.</param>
        /// <returns>Pen.</returns>
        public static Pen ToPen(SolidBrush Brush)
        {
            return new Pen(Brush);
        }

        /// <summary>
        /// Class CornerStyle.
        /// </summary>
        public class CornerStyle
        {
            /// <summary>
            /// The top left
            /// </summary>
            public bool TopLeft;
            /// <summary>
            /// The top right
            /// </summary>
            public bool TopRight;
            /// <summary>
            /// The bottom left
            /// </summary>
            public bool BottomLeft;
            /// <summary>
            /// The bottom right
            /// </summary>
            public bool BottomRight;
        }

        /// <summary>
        /// Advs the rect.
        /// </summary>
        /// <param name="Rectangle">The rectangle.</param>
        /// <param name="CornerStyle">The corner style.</param>
        /// <param name="Curve">The curve.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath AdvRect(Rectangle Rectangle, CornerStyle CornerStyle, int Curve)
        {
            GraphicsPath functionReturnValue = default(GraphicsPath);
            functionReturnValue = new GraphicsPath();
            int ArcRectangleWidth = Curve * 2;

            if (CornerStyle.TopLeft)
            {
                functionReturnValue.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90);
            }
            else
            {
                functionReturnValue.AddLine(Rectangle.X, Rectangle.Y, Rectangle.X + ArcRectangleWidth, Rectangle.Y);
            }

            if (CornerStyle.TopRight)
            {
                functionReturnValue.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90);
            }
            else
            {
                functionReturnValue.AddLine(Rectangle.X + Rectangle.Width, Rectangle.Y, Rectangle.X + Rectangle.Width, Rectangle.Y + ArcRectangleWidth);
            }

            if (CornerStyle.BottomRight)
            {
                functionReturnValue.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90);
            }
            else
            {
                functionReturnValue.AddLine(Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height, Rectangle.X + Rectangle.Width - ArcRectangleWidth, Rectangle.Y + Rectangle.Height);
            }

            if (CornerStyle.BottomLeft)
            {
                functionReturnValue.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90);
            }
            else
            {
                functionReturnValue.AddLine(Rectangle.X, Rectangle.Y + Rectangle.Height, Rectangle.X, Rectangle.Y + Rectangle.Height - ArcRectangleWidth);
            }

            functionReturnValue.CloseAllFigures();

            return functionReturnValue;
            return functionReturnValue;
        }

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="Rectangle">The rectangle.</param>
        /// <param name="Curve">The curve.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath RoundRect(Rectangle Rectangle, int Curve)
        {
            GraphicsPath functionReturnValue = default(GraphicsPath);
            functionReturnValue = new GraphicsPath();
            int ArcRectangleWidth = Curve * 2;
            functionReturnValue.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90);
            functionReturnValue.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90);
            functionReturnValue.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90);
            functionReturnValue.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90);
            functionReturnValue.AddLine(new Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), new Point(Rectangle.X, ArcRectangleWidth + Rectangle.Y));
            functionReturnValue.CloseAllFigures();
            return functionReturnValue;
            return functionReturnValue;
        }

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="X">The x.</param>
        /// <param name="Y">The y.</param>
        /// <param name="Width">The width.</param>
        /// <param name="Height">The height.</param>
        /// <param name="Curve">The curve.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath RoundRect(int X, int Y, int Width, int Height, int Curve)
        {
            return RoundRect(new Rectangle(X, Y, Width, Height), Curve);
        }

        /// <summary>
        /// Class PillStyle.
        /// </summary>
        public class PillStyle
        {
            /// <summary>
            /// The left
            /// </summary>
            public bool Left;
            /// <summary>
            /// The right
            /// </summary>
            public bool Right;
        }

        #region Trying to add
        //public enum Styles { Left, Right }
        //private static Styles styles = Styles.Left;

        //public static GraphicsPath Pill(Rectangle Rectangle, bool left, bool right)
        //{
        //    GraphicsPath functionReturnValue = default(GraphicsPath);
        //    functionReturnValue = new GraphicsPath();

        //    DesignFunctions.PillStyle pillstyle = new DesignFunctions.PillStyle();

        //    switch (styles)
        //    {
        //        case Styles.Left:
        //            pillstyle.Left = true;
        //            if (pillstyle.Left)
        //            {
        //                functionReturnValue.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, Rectangle.Height, Rectangle.Height), -270, 180);
        //            }
        //            else
        //            {
        //                functionReturnValue.AddLine(Rectangle.X, Rectangle.Y + Rectangle.Height, Rectangle.X, Rectangle.Y);
        //            }
        //            break;
        //        case Styles.Right:
        //            pillstyle.Right = true;
        //            if (pillstyle.Right)
        //            {
        //                functionReturnValue.AddArc(new Rectangle(Rectangle.X + Rectangle.Width - Rectangle.Height, Rectangle.Y, Rectangle.Height, Rectangle.Height), -90, 180);
        //            }
        //            else
        //            {
        //                functionReturnValue.AddLine(Rectangle.X + Rectangle.Width, Rectangle.Y, Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height);
        //            }
        //            break;
        //        default:
        //            break;
        //    }

        //    functionReturnValue.CloseAllFigures();

        //    return functionReturnValue;
        //    return functionReturnValue;
        //} 
        #endregion

        /// <summary>
        /// Pills the specified rectangle.
        /// </summary>
        /// <param name="Rectangle">The rectangle.</param>
        /// <param name="PillStyle">The pill style.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath Pill(Rectangle Rectangle, PillStyle PillStyle)
        {
            GraphicsPath functionReturnValue = default(GraphicsPath);
            functionReturnValue = new GraphicsPath();

            if (PillStyle.Left)
            {
                functionReturnValue.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, Rectangle.Height, Rectangle.Height), -270, 180);
            }
            else
            {
                functionReturnValue.AddLine(Rectangle.X, Rectangle.Y + Rectangle.Height, Rectangle.X, Rectangle.Y);
            }

            if (PillStyle.Right)
            {
                functionReturnValue.AddArc(new Rectangle(Rectangle.X + Rectangle.Width - Rectangle.Height, Rectangle.Y, Rectangle.Height, Rectangle.Height), -90, 180);
            }
            else
            {
                functionReturnValue.AddLine(Rectangle.X + Rectangle.Width, Rectangle.Y, Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height);
            }

            functionReturnValue.CloseAllFigures();

            //return Pill(new Rectangle(Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height), PillStyle);
            return functionReturnValue;
            //return functionReturnValue;
        }

        /// <summary>
        /// Pills the specified x.
        /// </summary>
        /// <param name="X">The x.</param>
        /// <param name="Y">The y.</param>
        /// <param name="Width">The width.</param>
        /// <param name="Height">The height.</param>
        /// <param name="PillStyle">The pill style.</param>
        /// <returns>System.Object.</returns>
        public static object Pill(int X, int Y, int Width, int Height, PillStyle PillStyle)
        {
            return Pill(new Rectangle(X, Y, Width, Height), PillStyle);
        }

    }

    /// <summary>
    /// Class Helper.
    /// </summary>
    static class Helper
    {

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="R">The r.</param>
        /// <param name="radius">The radius.</param>
        /// <returns>GraphicsPath.</returns>
        static internal GraphicsPath RoundRect(Rectangle R, int radius)
        {
            GraphicsPath GP = new GraphicsPath();
            GP.AddArc(R.X, R.Y, radius, radius, 180, 90);
            GP.AddArc(R.Right - radius, R.Y, radius, radius, 270, 90);
            GP.AddArc(R.Right - radius, R.Bottom - radius, radius, radius, 0, 90);
            GP.AddArc(R.X, R.Bottom - radius, radius, radius, 90, 90);
            GP.CloseFigure();
            return GP;
        }

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="R">The r.</param>
        /// <param name="UpperLeftCurve">The upper left curve.</param>
        /// <param name="UpperRightCurve">The upper right curve.</param>
        /// <param name="DownLeftCurve">Down left curve.</param>
        /// <param name="DownRightCurve">Down right curve.</param>
        /// <returns>GraphicsPath.</returns>
        static internal GraphicsPath RoundRect(Rectangle R, int UpperLeftCurve, int UpperRightCurve, int DownLeftCurve, int DownRightCurve)
        {
            //Curve = curve;
            //GraphicsPath P = new GraphicsPath();
            int UpperLeftCorner = UpperLeftCurve * 2;
            int UpperRightCorner = UpperRightCurve * 2;
            int DownLeftCorner = DownLeftCurve * 2;
            int DownRightCorner = DownRightCurve * 2;

            //P.AddArc(new Rectangle(R.X, R.Y, UpperLeftCorner, UpperLeftCorner), -180, 90);
            //P.AddArc(new Rectangle(R.Width - UpperRightCorner + R.X, R.Y, UpperRightCorner, UpperRightCorner), -90, 90);
            //P.AddArc(new Rectangle(R.Width - DownRightCorner + R.X, R.Height - DownRightCorner + R.Y, DownRightCorner, DownRightCorner), 0, 90);
            //P.AddArc(new Rectangle(R.X, R.Height - DownLeftCorner + R.Y, DownLeftCorner, DownLeftCorner), 90, 90);
            //P.CloseAllFigures();

            GraphicsPath GP = new GraphicsPath();
            GP.AddArc(R.X, R.Y, UpperLeftCorner, UpperLeftCorner, 180, 90);
            GP.AddArc(R.Right - UpperRightCorner, R.Y, UpperRightCorner, UpperRightCorner, 270, 90);
            GP.AddArc(R.Right - DownRightCorner, R.Bottom - DownRightCorner, DownRightCorner, DownRightCorner, 0, 90);
            GP.AddArc(R.X, R.Bottom - DownLeftCorner, DownLeftCorner, DownLeftCorner, 90, 90);
            GP.CloseFigure();
            return GP;
        }

        /// <summary>
        /// Greys the color.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <returns>Color.</returns>
        public static Color GreyColor(uint G)
        {
            //return Color.FromArgb(211, 211, 211);

            return SystemColors.ButtonFace;
        }

        /// <summary>
        /// Centers the string.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="T">The t.</param>
        /// <param name="F">The f.</param>
        /// <param name="C">The c.</param>
        /// <param name="R">The r.</param>
        public static void CenterString(Graphics G, string T, Font F, Color C, Rectangle R)
        {
            SizeF TS = G.MeasureString(T, F);

            using (SolidBrush B = new SolidBrush(C))
            {
                G.DrawString(T, F, B, new Point((int)R.Width / 2 - (int)(TS.Width / 2), (int)R.Height / 2 - (int)(TS.Height / 2)));
            }
        }

        /// <summary>
        /// Centers the string tab.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="text">The text.</param>
        /// <param name="font">The font.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="rect">The rect.</param>
        /// <param name="shadow">if set to <c>true</c> [shadow].</param>
        /// <param name="yOffset">The y offset.</param>
        public static void CenterStringTab(Graphics G, string text, Font font, Brush brush, Rectangle rect, bool shadow = false, int yOffset = 0)
        {
            SizeF textSize = G.MeasureString(text, font);
            int textX = rect.X + (int)(rect.Width / 2) - (int)(textSize.Width / 2);
            int textY = rect.Y + (int)(rect.Height / 2) - (int)(textSize.Height / 2) + yOffset;

            if (shadow)
                G.DrawString(text, font, Brushes.Black, textX + 1, textY + 1);
            G.DrawString(text, font, brush, textX, textY + 1);

        }


    }

    /// <summary>
    /// Class Draw.
    /// </summary>
    static class Draw
    {
        /// <summary>
        /// The near sf
        /// </summary>
        static internal StringFormat NearSF = new StringFormat
        {
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Near
        };

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="Rectangle">The rectangle.</param>
        /// <param name="Curve">The curve.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath RoundRect(Rectangle Rectangle, int Curve)
        {
            GraphicsPath P = new GraphicsPath();
            int ArcRectangleWidth = Curve * 2;
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90);
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90);
            P.AddLine(new Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), new Point(Rectangle.X, Curve + Rectangle.Y));
            return P;
        }

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="X">The x.</param>
        /// <param name="Y">The y.</param>
        /// <param name="Width">The width.</param>
        /// <param name="Height">The height.</param>
        /// <param name="Curve">The curve.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath RoundRect(int X, int Y, int Width, int Height, int Curve)
        {
            Rectangle Rectangle = new Rectangle(X, Y, Width, Height);
            GraphicsPath P = new GraphicsPath();
            int ArcRectangleWidth = Curve * 2;
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90);
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90);
            P.AddLine(new Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), new Point(Rectangle.X, Curve + Rectangle.Y));
            return P;
        }

        //Special Thanks to Aeonhack for RoundRect Functions... ;)
        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="rectangle">The rectangle.</param>
        /// <param name="curve">The curve.</param>
        /// <param name="dummy">if set to <c>true</c> [dummy].</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath RoundRect(Rectangle rectangle, int curve, bool dummy = true)
        {
            GraphicsPath p = new GraphicsPath();
            int arcRectangleWidth = curve * 2;
            p.AddArc(new Rectangle(rectangle.X, rectangle.Y, arcRectangleWidth, arcRectangleWidth), -180, 90);
            p.AddArc(new Rectangle(rectangle.Width - arcRectangleWidth + rectangle.X, rectangle.Y, arcRectangleWidth, arcRectangleWidth), -90, 90);
            p.AddArc(new Rectangle(rectangle.Width - arcRectangleWidth + rectangle.X, rectangle.Height - arcRectangleWidth + rectangle.Y, arcRectangleWidth, arcRectangleWidth), 0, 90);
            p.AddArc(new Rectangle(rectangle.X, rectangle.Height - arcRectangleWidth + rectangle.Y, arcRectangleWidth, arcRectangleWidth), 90, 90);
            p.AddLine(new Point(rectangle.X, rectangle.Height - arcRectangleWidth + rectangle.Y), new Point(rectangle.X, curve + rectangle.Y));
            return p;
        }

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="curve">The curve.</param>
        /// <param name="dummy">if set to <c>true</c> [dummy].</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath RoundRect(int x, int y, int width, int height, int curve, bool dummy = true)
        {
            Rectangle rectangle = new Rectangle(x, y, width, height);
            GraphicsPath p = new GraphicsPath();
            int arcRectangleWidth = curve * 2;
            p.AddArc(new Rectangle(rectangle.X, rectangle.Y, arcRectangleWidth, arcRectangleWidth), -180, 90);
            p.AddArc(new Rectangle(rectangle.Width - arcRectangleWidth + rectangle.X, rectangle.Y, arcRectangleWidth, arcRectangleWidth), -90, 90);
            p.AddArc(new Rectangle(rectangle.Width - arcRectangleWidth + rectangle.X, rectangle.Height - arcRectangleWidth + rectangle.Y, arcRectangleWidth, arcRectangleWidth), 0, 90);
            p.AddArc(new Rectangle(rectangle.X, rectangle.Height - arcRectangleWidth + rectangle.Y, arcRectangleWidth, arcRectangleWidth), 90, 90);
            p.AddLine(new Point(rectangle.X, rectangle.Height - arcRectangleWidth + rectangle.Y), new Point(rectangle.X, curve + rectangle.Y));
            return p;
        }


        /// <summary>
        /// Creates the round.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="slope">The slope.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath CreateRound(int x, int y, int width, int height, int slope)
        {
            Rectangle CreateRoundRectangle = new Rectangle(x, y, width, height);
            return CreateRound(CreateRoundRectangle, slope);
        }

        /// <summary>
        /// Creates the round.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="slope">The slope.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath CreateRound(Rectangle r, int slope)
        {
            GraphicsPath CreateRoundPath = new GraphicsPath(FillMode.Winding);
            CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180f, 90f);
            CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270f, 90f);
            CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0f, 90f);
            CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90f, 90f);
            CreateRoundPath.CloseFigure();
            return CreateRoundPath;
        }

        #region "Functions"


        /// <summary>
        /// Rounds the record.
        /// </summary>
        /// <param name="Rectangle">The rectangle.</param>
        /// <param name="Curve">The curve.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath RoundRec(Rectangle Rectangle, int Curve)
        {
            GraphicsPath P = new GraphicsPath();
            int ArcRectangleWidth = Curve * 2;
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90);
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90);
            P.AddLine(new Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), new Point(Rectangle.X, Curve + Rectangle.Y));
            return P;
        }

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="w">The w.</param>
        /// <param name="h">The h.</param>
        /// <param name="r">The r.</param>
        /// <param name="TL">if set to <c>true</c> [tl].</param>
        /// <param name="TR">if set to <c>true</c> [tr].</param>
        /// <param name="BR">if set to <c>true</c> [br].</param>
        /// <param name="BL">if set to <c>true</c> [bl].</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath RoundRect(dynamic x, dynamic y, dynamic w, dynamic h, dynamic r, bool TL = true, bool TR = true, bool BR = true, bool BL = true)
        {
            r = 0.3;

            GraphicsPath functionReturnValue = default(GraphicsPath);
            dynamic d = Math.Min(w, h) * r;
            dynamic xw = x + w;
            dynamic yh = y + h;
            functionReturnValue = new GraphicsPath();

            var _with1 = functionReturnValue;
            if (TL)
                _with1.AddArc(x, y, d, d, 180, 90);
            else
                _with1.AddLine(x, y, x, y);
            if (TR)
                _with1.AddArc(xw - d, y, d, d, 270, 90);
            else
                _with1.AddLine(xw, y, xw, y);
            if (BR)
                _with1.AddArc(xw - d, yh - d, d, d, 0, 90);
            else
                _with1.AddLine(xw, yh, xw, yh);
            if (BL)
                _with1.AddArc(x, yh - d, d, d, 90, 90);
            else
                _with1.AddLine(x, yh, x, yh);

            _with1.CloseFigure();
            return functionReturnValue;
        }


        #endregion

        /// <summary>
        /// Fulls the rectangle.
        /// </summary>
        /// <param name="S">The s.</param>
        /// <param name="Subtract">if set to <c>true</c> [subtract].</param>
        /// <returns>Rectangle.</returns>
        public static Rectangle FullRectangle(Size S, bool Subtract)
        {
            if (Subtract)
            {
                return new Rectangle(0, 0, S.Width - 1, S.Height - 1);
            }
            else
            {
                return new Rectangle(0, 0, S.Width, S.Height);
            }
        }

        /// <summary>
        /// Greys the color.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <returns>Color.</returns>
        public static Color GreyColor(uint G)
        {
            //return Color.FromArgb(211, 211, 211);

            return SystemColors.ButtonFace;
        }

        /// <summary>
        /// Centers the string.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="T">The t.</param>
        /// <param name="F">The f.</param>
        /// <param name="C">The c.</param>
        /// <param name="R">The r.</param>
        public static void CenterString(Graphics G, string T, Font F, Color C, Rectangle R)
        {
            SizeF TS = G.MeasureString(T, F);

            using (SolidBrush B = new SolidBrush(C))
            {
                G.DrawString(T, F, B, new Point((int)R.Width / 2 - (int)(TS.Width / 2), (int)R.Height / 2 - (int)(TS.Height / 2)));
            }
        }
        // Get more free themes at ThemesVB.NET

        /// <summary>
        /// Fills the round rect.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="R">The r.</param>
        /// <param name="Curve">The curve.</param>
        /// <param name="C">The c.</param>
        public static void FillRoundRect(Graphics G, Rectangle R, int Curve, Color C)
        {
            using (SolidBrush B = new SolidBrush(C))
            {
                G.FillPie(B, R.X, R.Y, Curve, Curve, 180, 90);
                G.FillPie(B, R.X + R.Width - Curve, R.Y, Curve, Curve, 270, 90);
                G.FillPie(B, R.X, R.Y + R.Height - Curve, Curve, Curve, 90, 90);
                G.FillPie(B, R.X + R.Width - Curve, R.Y + R.Height - Curve, Curve, Curve, 0, 90);
                G.FillRectangle(B, Convert.ToInt32(R.X + Curve / 2), R.Y, R.Width - Curve, Convert.ToInt32(Curve / 2));
                G.FillRectangle(B, R.X, Convert.ToInt32(R.Y + Curve / 2), R.Width, R.Height - Curve);
                G.FillRectangle(B, Convert.ToInt32(R.X + Curve / 2), Convert.ToInt32(R.Y + R.Height - Curve / 2), R.Width - Curve, Convert.ToInt32(Curve / 2));
            }

        }


        /// <summary>
        /// Draws the round rect.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="R">The r.</param>
        /// <param name="Curve">The curve.</param>
        /// <param name="C">The c.</param>
        public static void DrawRoundRect(Graphics G, Rectangle R, int Curve, Color C)
        {
            using (Pen P = new Pen(C))
            {
                G.DrawArc(P, R.X, R.Y, Curve, Curve, 180, 90);
                G.DrawLine(P, Convert.ToInt32(R.X + Curve / 2), R.Y, Convert.ToInt32(R.X + R.Width - Curve / 2), R.Y);
                G.DrawArc(P, R.X + R.Width - Curve, R.Y, Curve, Curve, 270, 90);
                G.DrawLine(P, R.X, Convert.ToInt32(R.Y + Curve / 2), R.X, Convert.ToInt32(R.Y + R.Height - Curve / 2));
                G.DrawLine(P, Convert.ToInt32(R.X + R.Width), Convert.ToInt32(R.Y + Curve / 2), Convert.ToInt32(R.X + R.Width), Convert.ToInt32(R.Y + R.Height - Curve / 2));
                G.DrawLine(P, Convert.ToInt32(R.X + Curve / 2), Convert.ToInt32(R.Y + R.Height), Convert.ToInt32(R.X + R.Width - Curve / 2), Convert.ToInt32(R.Y + R.Height));
                G.DrawArc(P, R.X, R.Y + R.Height - Curve, Curve, Curve, 90, 90);
                G.DrawArc(P, R.X + R.Width - Curve, R.Y + R.Height - Curve, Curve, Curve, 0, 90);
            }

        }


        /// <summary>
        /// Centers the string tab.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="text">The text.</param>
        /// <param name="font">The font.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="rect">The rect.</param>
        /// <param name="shadow">if set to <c>true</c> [shadow].</param>
        /// <param name="yOffset">The y offset.</param>
        public static void CenterStringTab(Graphics G, string text, Font font, Brush brush, Rectangle rect, bool shadow = false, int yOffset = 0)
        {
            SizeF textSize = G.MeasureString(text, font);
            int textX = rect.X + (int)(rect.Width / 2) - (int)(textSize.Width / 2);
            int textY = rect.Y + (int)(rect.Height / 2) - (int)(textSize.Height / 2) + yOffset;

            if (shadow)
                G.DrawString(text, font, Brushes.Black, textX + 1, textY + 1);
            G.DrawString(text, font, brush, textX, textY + 1);

        }

        /// <summary>
        /// Tops the round rect.
        /// </summary>
        /// <param name="rect">The rect.</param>
        /// <param name="slope">The slope.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath TopRoundRect(Rectangle rect, int slope)
        {
            GraphicsPath gp = new GraphicsPath();
            int arcWidth = slope * 2;
            gp.AddArc(new Rectangle(rect.X, rect.Y, arcWidth, arcWidth), -180, 90);
            gp.AddArc(new Rectangle(rect.Width - arcWidth + rect.X, rect.Y, arcWidth, arcWidth), -90, 90);
            gp.AddLine(new Point(rect.X + rect.Width, rect.Y + arcWidth), new Point(rect.X + rect.Width, rect.Y + rect.Height));
            gp.AddLine(new Point(rect.X + rect.Width, rect.Y + rect.Height), new Point(rect.X, rect.Y + rect.Height));
            gp.AddLine(new Point(rect.X, rect.Y + rect.Height), new Point(rect.X, rect.Y + arcWidth));
            gp.CloseAllFigures();
            return gp;
        }

        /// <summary>
        /// Lefts the round rect.
        /// </summary>
        /// <param name="rect">The rect.</param>
        /// <param name="slope">The slope.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath LeftRoundRect(Rectangle rect, int slope)
        {
            GraphicsPath gp = new GraphicsPath();
            int arcWidth = slope * 2;
            gp.AddArc(new Rectangle(rect.X, rect.Y, arcWidth, arcWidth), -180, 90);
            gp.AddLine(new Point(rect.X + arcWidth, rect.Y), new Point(rect.Width, rect.Y));
            gp.AddLine(new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
            gp.AddLine(new Point(rect.X + rect.Width, rect.Y + rect.Height), new Point(rect.X + arcWidth, rect.Y + rect.Height));
            gp.AddArc(new Rectangle(rect.X, rect.Height - arcWidth + rect.Y, arcWidth, arcWidth), 90, 90);
            gp.CloseAllFigures();
            return gp;
        }

        /// <summary>
        /// Roundeds the rectangle.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="cornerwidth">The cornerwidth.</param>
        /// <param name="PenWidth">Width of the pen.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath RoundedRectangle(int x, int y, int width, int height, int cornerwidth, int PenWidth)
        {
            GraphicsPath p = new GraphicsPath();
            p.StartFigure();
            p.AddArc(new Rectangle(x, y, cornerwidth, cornerwidth), 180, 90);
            p.AddLine(cornerwidth, y, width - cornerwidth - PenWidth, y);

            p.AddArc(new Rectangle(width - cornerwidth - PenWidth, y, cornerwidth, cornerwidth), -90, 90);
            p.AddLine(width - PenWidth, cornerwidth, width - PenWidth, height - cornerwidth - PenWidth);

            p.AddArc(new Rectangle(width - cornerwidth - PenWidth, height - cornerwidth - PenWidth, cornerwidth, cornerwidth), 0, 90);
            p.AddLine(width - cornerwidth - PenWidth, height - PenWidth, cornerwidth, height - PenWidth);

            p.AddArc(new Rectangle(x, height - cornerwidth - PenWidth, cornerwidth, cornerwidth), 90, 90);
            p.CloseFigure();

            return p;
        }

        /// <summary>
        /// Draws the rounded rectangle.
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="r">The r.</param>
        /// <param name="d">The d.</param>
        /// <param name="p">The p.</param>
        public static void DrawRoundedRectangle(Graphics g, Rectangle r, int d, Pen p)
        {
            SmoothingMode mode = g.SmoothingMode;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.DrawArc(p, r.X, r.Y, d, d, 180, 90);
            g.DrawLine(p, Convert.ToInt32(r.X + d / 2), r.Y, Convert.ToInt32(r.X + r.Width - d / 2), r.Y);
            g.DrawArc(p, r.X + r.Width - d, r.Y, d, d, 270, 90);
            g.DrawLine(p, r.X, Convert.ToInt32(r.Y + d / 2), r.X, Convert.ToInt32(r.Y + r.Height - d / 2));
            g.DrawLine(p, Convert.ToInt32(r.X + r.Width), Convert.ToInt32(r.Y + d / 2), Convert.ToInt32(r.X + r.Width), Convert.ToInt32(r.Y + r.Height - d / 2));
            g.DrawLine(p, Convert.ToInt32(r.X + d / 2), Convert.ToInt32(r.Y + r.Height), Convert.ToInt32(r.X + r.Width - d / 2), Convert.ToInt32(r.Y + r.Height));
            g.DrawArc(p, r.X, r.Y + r.Height - d, d, d, 90, 90);
            g.DrawArc(p, r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            g.SmoothingMode = mode;
        }

        //Special Thanks to Mephobia's for NoiseBrush Functions...
        /// <summary>
        /// Noises the brush.
        /// </summary>
        /// <param name="colors">The colors.</param>
        /// <returns>TextureBrush.</returns>
        public static TextureBrush NoiseBrush(Color[] colors)
        {
            Bitmap b = new Bitmap(128, 128);
            Random r = new Random(128);
            for (int x = 0; x <= b.Width - 1; x++)
            {
                for (int y = 0; y <= b.Height - 1; y++)
                {
                    b.SetPixel(x, y, colors[r.Next(colors.Length)]);
                }
            }
            TextureBrush T = new TextureBrush(b);
            b.Dispose();
            return T;
        }

        /// <summary>
        /// Gradients the specified g.
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public static void Gradient(Graphics g, Color c1, Color c2, int x, int y, int width, int height)
        {
            Rectangle R = new Rectangle(x, y, width, height);
            using (LinearGradientBrush T = new LinearGradientBrush(R, c1, c2, LinearGradientMode.Vertical))
            {
                g.FillRectangle(T, R);
            }
        }

        /// <summary>
        /// Gradients the specified g.
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="r">The r.</param>
        public static void Gradient(Graphics g, Color c1, Color c2, Rectangle r)
        {
            using (LinearGradientBrush T = new LinearGradientBrush(r, c1, c2, LinearGradientMode.Vertical))
            {
                g.FillRectangle(T, r);
            }
        }

        /// <summary>
        /// Blends the specified g.
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="c3">The c3.</param>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public static void Blend(Graphics g, Color c1, Color c2, Color c3, float c, int d, int x, int y, int width, int height)
        {
            ColorBlend v = new ColorBlend(3);
            v.Colors = new Color[] {
            c1,
            c2,
            c3
        };
            v.Positions = new float[] {
            0,
            c,
            1
        };
            Rectangle R = new Rectangle(x, y, width, height);
            using (LinearGradientBrush T = new LinearGradientBrush(R, c1, c1, (LinearGradientMode)d))
            {
                T.InterpolationColors = v;
                g.FillRectangle(T, R);
            }
        }

        /// <summary>
        /// Backs the ground.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="G">The g.</param>
        public static void BackGround(int width, int height, Graphics G)
        {
            Color P1 = Color.FromArgb(29, 25, 22);
            Color P2 = Color.FromArgb(35, 31, 28);

            for (int y = 0; y <= height; y += 4)
            {
                for (int x = 0; x <= width; x += 4)
                {
                    G.FillRectangle(new SolidBrush(P1), new Rectangle(x, y, 1, 1));
                    G.FillRectangle(new SolidBrush(P2), new Rectangle(x, y + 1, 1, 1));
                    try
                    {
                        G.FillRectangle(new SolidBrush(P1), new Rectangle(x + 2, y + 2, 1, 1));
                        G.FillRectangle(new SolidBrush(P2), new Rectangle(x + 2, y + 3, 1, 1));
                    }
                    catch
                    {
                    }
                }
            }
        }

        /// <summary>
        /// Tabs the control rect.
        /// </summary>
        /// <param name="rect">The rect.</param>
        /// <param name="slope">The slope.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath TabControlRect(Rectangle rect, int slope)
        {
            GraphicsPath gp = new GraphicsPath();
            int arcWidth = slope * 2;
            gp.AddLine(new Point(rect.X, rect.Y), new Point(rect.X, rect.Y));
            gp.AddArc(new Rectangle(rect.Width - arcWidth + rect.X, rect.Y, arcWidth, arcWidth), -90, 90);
            gp.AddArc(new Rectangle(rect.Width - arcWidth + rect.X, rect.Height - arcWidth + rect.Y, arcWidth, arcWidth), 0, 90);
            gp.AddArc(new Rectangle(rect.X, rect.Height - arcWidth + rect.Y, arcWidth, arcWidth), 90, 90);
            gp.CloseAllFigures();
            return gp;
        }

        /// <summary>
        /// Shadoweds the string.
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="s">The s.</param>
        /// <param name="font">The font.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="pos">The position.</param>
        public static void ShadowedString(Graphics g, string s, Font font, Brush brush, Point pos)
        {
            g.DrawString(s, font, Brushes.Black, new Point(pos.X + 1, pos.Y + 1));
            g.DrawString(s, font, brush, pos);
        }

        /// <summary>
        /// Gets the smaller rect.
        /// </summary>
        /// <param name="rect">The rect.</param>
        /// <param name="value">The value.</param>
        /// <returns>Rectangle.</returns>
        public static Rectangle getSmallerRect(Rectangle rect, int value)
        {
            return new Rectangle(rect.X + value, rect.Y + value, rect.Width - (value * 2), rect.Height - (value * 2));
        }

        /// <summary>
        /// Alters the color.
        /// </summary>
        /// <param name="original">The original.</param>
        /// <param name="amount">The amount.</param>
        /// <returns>Color.</returns>
        public static Color AlterColor(Color original, int amount = -20)
        {
            Color c = original;
            int a = amount;
            int r = 0;
            int g = 0;
            int b = 0;
            if (c.R + a < 0)
            {
                r = 0;
            }
            else if (c.R + a > 255)
            {
                r = 255;
            }
            else
            {
                r = c.R + a;
            }
            if (c.G + a < 0)
            {
                g = 0;
            }
            else if (c.G + a > 255)
            {
                g = 255;
            }
            else
            {
                g = c.G + a;
            }
            if (c.B + a < 0)
            {
                b = 0;
            }
            else if (c.B + a > 255)
            {
                b = 255;
            }
            else
            {
                b = c.B + a;
            }
            return Color.FromArgb(r, g, b);
        }

        /// <summary>
        /// The center sf
        /// </summary>
        static internal StringFormat CenterSF = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center

        };

        /// <summary>
        /// The flat color
        /// </summary>
        static internal Color _FlatColor = Color.FromArgb(35, 168, 109);

        /// <summary>
        /// Rounds up.
        /// </summary>
        /// <param name="d">The d.</param>
        /// <returns>System.Int32.</returns>
        public static int RoundUp(double d)
        {
            if (d.ToString().Contains(","))
            {
                return Convert.ToInt32(d.ToString().Split(Convert.ToChar((",")), ((char)0))) + 1;
            }
            else
            {
                return Convert.ToInt32(d);
            }
        }

        /// <summary>
        /// Codes to image.
        /// </summary>
        /// <param name="Code">The code.</param>
        /// <returns>Image.</returns>
        public static Image CodeToImage(string Code)
        {
            return Image.FromStream(new System.IO.MemoryStream(Convert.FromBase64String(Code)));
        }

        /// <summary>
        /// Gets the brush.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>SolidBrush.</returns>
        public static SolidBrush GetBrush(Color c)
        {
            return new SolidBrush(c);
        }
        /// <summary>
        /// Gets the pen.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>Pen.</returns>
        public static Pen GetPen(Color c)
        {
            return new Pen(new SolidBrush(c));
        }

        /// <summary>
        /// Converts to brush.
        /// </summary>
        /// <param name="R">The r.</param>
        /// <param name="G">The g.</param>
        /// <param name="B">The b.</param>
        /// <returns>Brush.</returns>
        public static Brush ConvertToBrush(int R, int G, int B)
        {
            return new SolidBrush(Color.FromArgb(R, G, B));
        }

        /// <summary>
        /// Converts to brush.
        /// </summary>
        /// <param name="Pen">The pen.</param>
        /// <returns>Brush.</returns>
        public static Brush ConvertToBrush(Pen Pen)
        {
            return new SolidBrush(Pen.Color);
        }

        /// <summary>
        /// Converts to brush.
        /// </summary>
        /// <param name="Color">The color.</param>
        /// <returns>Brush.</returns>
        public static Brush ConvertToBrush(Color Color)
        {
            return new SolidBrush(Color);
        }

        /// <summary>
        /// Converts to pen.
        /// </summary>
        /// <param name="R">The r.</param>
        /// <param name="G">The g.</param>
        /// <param name="B">The b.</param>
        /// <returns>Pen.</returns>
        public static Pen ConvertToPen(int R, int G, int B)
        {
            return new Pen(new SolidBrush(Color.FromArgb(R, G, B)));
        }

        /// <summary>
        /// Converts to pen.
        /// </summary>
        /// <param name="Brush">The brush.</param>
        /// <returns>Pen.</returns>
        public static Pen ConvertToPen(SolidBrush Brush)
        {
            return new Pen(Brush);
        }

        /// <summary>
        /// Converts to pen.
        /// </summary>
        /// <param name="Color">The color.</param>
        /// <returns>Pen.</returns>
        public static Pen ConvertToPen(Color Color)
        {
            return new Pen(new SolidBrush(Color));
        }

        /// <summary>
        /// Inners the glow.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="Rectangle">The rectangle.</param>
        /// <param name="Colors">The colors.</param>
        public static void InnerGlow(Graphics G, Rectangle Rectangle, Color[] Colors)
        {
            int SubtractTwo = 1;
            int AddOne = 0;
            foreach (Color c_loopVariable in Colors)
            {
                Color c = c_loopVariable;
                G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(c.R, c.B, c.G))), Rectangle.X + AddOne, Rectangle.Y + AddOne, Rectangle.Width - SubtractTwo, Rectangle.Height - SubtractTwo);
                SubtractTwo += 2;
                AddOne += 1;
            }
        }

        /// <summary>
        /// Inners the glow rounded.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="Rectangle">The rectangle.</param>
        /// <param name="Degree">The degree.</param>
        /// <param name="Colors">The colors.</param>
        public static void InnerGlowRounded(Graphics G, Rectangle Rectangle, int Degree, Color[] Colors)
        {
            int SubtractTwo = 1;
            int AddOne = 0;
            foreach (Color c_loopVariable in Colors)
            {
                Color c = c_loopVariable;
                G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(c.R, c.B, c.G))), Draw.RoundRect(Rectangle.X + AddOne, Rectangle.Y + AddOne, Rectangle.Width - SubtractTwo, Rectangle.Height - SubtractTwo, Degree));
                SubtractTwo += 2;
                AddOne += 1;
            }
        }

        /// <summary>
        /// Images from code.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>Image.</returns>
        public static Image ImageFromCode(ref String str)
        {
            byte[] imageBytes = Convert.FromBase64String(str);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image i = Image.FromStream(ms, true);
            return i;
        }
        /// <summary>
        /// Tileds the texture from code.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>TextureBrush.</returns>
        public static TextureBrush TiledTextureFromCode(string str)
        {
            return new TextureBrush(Draw.ImageFromCode(ref str), WrapMode.Tile);
        }

        /// <summary>
        /// Draws the arrow.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="flip">if set to <c>true</c> [flip].</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath DrawArrow(int x, int y, bool flip, int width, int height)
        {
            GraphicsPath GP = new GraphicsPath();

            int W = width;//12
            int H = height;//6

            if (flip)
            {
                GP.AddLine(x + 1, y, x + W + 1, y);
                GP.AddLine(x + W, y, x + H, y + H - 1);
            }
            else
            {
                GP.AddLine(x, y + H, x + W, y + H);
                GP.AddLine(x + W, y + H, x + H, y);
            }

            GP.CloseFigure();
            return GP;
        }
    }


    #endregion

    /// <summary>
    /// Class ColorConverter.
    /// </summary>
    public static class ColorConverter
    {
        /// <summary>
        /// Hexadecimals to red.
        /// </summary>
        /// <param name="HexString">The hexadecimal string.</param>
        /// <returns>System.Int32.</returns>
        public static int HexToRed(string HexString)
        {
            return HexToColor(HexString).R;
        }
        /// <summary>
        /// Hexadecimals to green.
        /// </summary>
        /// <param name="HexString">The hexadecimal string.</param>
        /// <returns>System.Int32.</returns>
        public static int HexToGreen(string HexString)
        {
            return HexToColor(HexString).G;
        }
        /// <summary>
        /// Hexadecimals to blue.
        /// </summary>
        /// <param name="HexString">The hexadecimal string.</param>
        /// <returns>System.Int32.</returns>
        public static int HexToBlue(string HexString)
        {
            return HexToColor(HexString).B;
        }
        /// <summary>
        /// Colors to hexadecimal.
        /// </summary>
        /// <param name="Color">The color.</param>
        /// <returns>System.String.</returns>
        public static string ColorToHex(Color Color)
        {
            return string.Format("#{0}{1}{2}", Color.R.ToString("X2"), Color.G.ToString("X2"), Color.B.ToString("X2"));
        }
        /// <summary>
        /// Hexadecimals to RGB.
        /// </summary>
        /// <param name="HexString">The hexadecimal string.</param>
        /// <returns>System.String[].</returns>
        public static string[] HexToRGB(string HexString)
        {
            Color tmpColor = ColorTranslator.FromHtml(HexString);
            string[] rgbArray = new string[4];
            rgbArray[0] = tmpColor.R.ToString();
            rgbArray[1] = tmpColor.G.ToString();
            rgbArray[2] = tmpColor.B.ToString();
            return rgbArray;
        }
        /// <summary>
        /// Hexadecimals to color.
        /// </summary>
        /// <param name="HexString">The hexadecimal string.</param>
        /// <returns>Color.</returns>
        public static Color HexToColor(string HexString)
        {
            return ColorTranslator.FromHtml(HexString);
        }
    }

    /// <summary>
    /// Class ImageToCodeClass.
    /// </summary>
    public class ImageToCodeClass
    {
        /// <summary>
        /// Images to code.
        /// </summary>
        /// <param name="Img">The img.</param>
        /// <returns>System.String.</returns>
        public string ImageToCode(Bitmap Img)
        {
            return Convert.ToBase64String((byte[])System.ComponentModel.TypeDescriptor.GetConverter(Img).ConvertTo(Img, typeof(byte[])));
        }

        /// <summary>
        /// Codes to image.
        /// </summary>
        /// <param name="Code">The code.</param>
        /// <returns>Image.</returns>
        public Image CodeToImage(string Code)
        {
            return Image.FromStream(new System.IO.MemoryStream(Convert.FromBase64String(Code)));
        }
    }

}
