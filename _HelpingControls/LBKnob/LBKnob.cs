// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="LBKnob.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions._HelpingControls.LBKnob
{

    #region Knob

    #region LBKnob Renderer

    /// <summary>
    /// Base class for the renderers of the knob
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions._HelpingControls.LBKnob.ZeroitLBRendererBase" />
	public class ZeroitLBKnobRenderer : ZeroitLBRendererBase
    {
        #region (* Variables *)
        /// <summary>
        /// The draw rect
        /// </summary>
        private RectangleF drawRect;
        /// <summary>
        /// The rect scale
        /// </summary>
        private RectangleF rectScale;
        /// <summary>
        /// The rect knob
        /// </summary>
        private RectangleF rectKnob;
        /// <summary>
        /// The knob center
        /// </summary>
        private PointF knobCenter;
        /// <summary>
        /// The knob indicator position
        /// </summary>
        private PointF knobIndicatorPos;
        /// <summary>
        /// The draw ratio
        /// </summary>
        private float drawRatio;
        #endregion

        #region (* Properies *)
        /// <summary>
        /// Gets the knob.
        /// </summary>
        /// <value>The knob.</value>
        public ZeroitLBKnob Knob
        {
            get { return this.Control as ZeroitLBKnob; }
        }
        #endregion

        #region (* Overrided method *)
        /// <summary>
        /// Update the renderer
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.NullReferenceException">Invalid 'Knob' object</exception>
        public override bool Update()
        {
            // Check Button object
            if (this.Knob == null)
                throw new NullReferenceException("Invalid 'Knob' object");

            // Rectangle
            float x, y, w, h;
            x = 0;
            y = 0;
            w = this.Knob.Size.Width;
            h = this.Knob.Size.Height;

            // Calculate ratio
            drawRatio = (Math.Min(w, h)) / 200;
            if (drawRatio == 0.0)
                drawRatio = 1;

            // Draw rectangle
            drawRect.X = x;
            drawRect.Y = y;
            drawRect.Width = w - 2;
            drawRect.Height = h - 2;

            if (w < h)
                drawRect.Height = w;
            else if (w > h)
                drawRect.Width = h;

            if (drawRect.Width < 10)
                drawRect.Width = 10;
            if (drawRect.Height < 10)
                drawRect.Height = 10;

            this.rectScale = this.drawRect;
            this.rectKnob = this.drawRect;
            this.rectKnob.Inflate(-20 * this.drawRatio, -20 * this.drawRatio);

            this.knobCenter.X = this.rectKnob.Left + (this.rectKnob.Width * 0.5F);
            this.knobCenter.Y = this.rectKnob.Top + (this.rectKnob.Height * 0.5F);

            this.knobIndicatorPos = this.Knob.GetPositionFromValue(this.Knob.Value);

            this.Knob.KnobRect = this.rectKnob;
            this.Knob.KnobCenter = this.knobCenter;
            this.Knob.DrawRatio = this.drawRatio;
            return true;
        }

        /// <summary>
        /// Drawing method
        /// </summary>
        /// <param name="Gr">The gr.</param>
        /// <exception cref="System.ArgumentNullException">Gr</exception>
        /// <exception cref="System.NullReferenceException">Associated control is not valid</exception>
        public override void Draw(Graphics Gr)
        {
            if (Gr == null)
                throw new ArgumentNullException("Gr");

            ZeroitLBKnob ctrl = this.Knob;
            if (ctrl == null)
                throw new NullReferenceException("Associated control is not valid");

            this.DrawBackground(Gr, ctrl.Bounds);
            this.DrawScale(Gr, this.rectScale);
            this.DrawKnob(Gr, this.rectKnob);
            this.DrawKnobIndicator(Gr, this.rectKnob, this.knobIndicatorPos);
        }
        #endregion

        #region (* Virtual method *)
        /// <summary>
        /// Draw the background of the control
        /// </summary>
        /// <param name="Gr">The gr.</param>
        /// <param name="rc">The rc.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		public virtual bool DrawBackground(Graphics Gr, RectangleF rc)
        {
            if (this.Knob == null)
                return false;

            Color c = this.Knob.BackColor;
            SolidBrush br = new SolidBrush(c);
            Pen pen = new Pen(c);

            Rectangle _rcTmp = new Rectangle(0, 0, this.Knob.Width, this.Knob.Height);
            Gr.DrawRectangle(pen, _rcTmp);
            Gr.FillRectangle(br, rc);

            br.Dispose();
            pen.Dispose();

            return true;
        }

        /// <summary>
        /// Draw the scale of the control
        /// </summary>
        /// <param name="Gr">The gr.</param>
        /// <param name="rc">The rc.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public virtual bool DrawScale(Graphics Gr, RectangleF rc)
        {
            if (this.Knob == null)
                return false;

            Color cKnob = this.Knob.ScaleColor;
            Color cKnobDark = ZeroitLBColorManager.StepColor(cKnob, 60);

            LinearGradientBrush br = new LinearGradientBrush(rc, cKnobDark, cKnob, 45);

            Gr.FillEllipse(br, rc);

            br.Dispose();

            return true;
        }

        /// <summary>
        /// Draw the knob of the control
        /// </summary>
        /// <param name="Gr">The gr.</param>
        /// <param name="rc">The rc.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public virtual bool DrawKnob(Graphics Gr, RectangleF rc)
        {
            if (this.Knob == null)
                return false;

            Color cKnob = this.Knob.KnobColor;
            Color cKnobDark = ZeroitLBColorManager.StepColor(cKnob, 60);

            LinearGradientBrush br = new LinearGradientBrush(rc, cKnob, cKnobDark, 45);

            Gr.FillEllipse(br, rc);

            br.Dispose();

            return true;
        }

        /// <summary>
        /// Draws the knob indicator.
        /// </summary>
        /// <param name="Gr">The gr.</param>
        /// <param name="rc">The rc.</param>
        /// <param name="pos">The position.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public virtual bool DrawKnobIndicator(Graphics Gr, RectangleF rc, PointF pos)
        {
            if (this.Knob == null)
                return false;

            RectangleF _rc = rc;
            _rc.X = pos.X - 4;
            _rc.Y = pos.Y - 4;
            _rc.Width = 8;
            _rc.Height = 8;

            Color cKnob = this.Knob.IndicatorColor;
            Color cKnobDark = ZeroitLBColorManager.StepColor(cKnob, 60);

            LinearGradientBrush br = new LinearGradientBrush(_rc, cKnobDark, cKnob, 45);

            Gr.FillEllipse(br, _rc);

            br.Dispose();

            return true;
        }
        #endregion
    }

    #endregion

    #region Control
    /// <summary>
    /// Description of LBKnob.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions._HelpingControls.LBKnob.ZeroitLBIndustrialCtrlBase" />
	[ToolboxItem(false)]
	public partial class ZeroitLBKnob : ZeroitLBIndustrialCtrlBase
    {
        #region *( Enumerators *)
        /// <summary>
        /// Enum KnobStyle
        /// </summary>
        public enum KnobStyle
        {
            /// <summary>
            /// The circular
            /// </summary>
            Circular = 0,
        }
        #endregion

        #region (* Properties variables *)
        /// <summary>
        /// The minimum value
        /// </summary>
        private float minValue = 0.0F;
        /// <summary>
        /// The maximum value
        /// </summary>
        private float maxValue = 1.0F;
        /// <summary>
        /// The step value
        /// </summary>
        private float stepValue = 0.1F;
        /// <summary>
        /// The curr value
        /// </summary>
        private float currValue = 0.0F;
        /// <summary>
        /// The knob rect
        /// </summary>
        private RectangleF knobRect = RectangleF.Empty;
        /// <summary>
        /// The knob center
        /// </summary>
        private PointF knobCenter = PointF.Empty;
        /// <summary>
        /// The style
        /// </summary>
        private KnobStyle style = KnobStyle.Circular;
        /// <summary>
        /// The scale color
        /// </summary>
        private Color scaleColor = Color.Green;
        /// <summary>
        /// The knob color
        /// </summary>
        private Color knobColor = Color.Black;
        /// <summary>
        /// The indicator color
        /// </summary>
        private Color indicatorColor = Color.Red;
        /// <summary>
        /// The indicator offset
        /// </summary>
        private float indicatorOffset = 10F;
        /// <summary>
        /// The draw ratio
        /// </summary>
        private float drawRatio = 1F;
        #endregion

        #region (* Class variables *)
        /// <summary>
        /// The is knob rotating
        /// </summary>
        private bool isKnobRotating = false;
        #endregion

        #region (* Constructor *)
        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitLBKnob"/> class.
        /// </summary>
        public ZeroitLBKnob()
        {
            InitializeComponent();

            this.CalculateDimensions();
        }
        #endregion

        #region (* Properties *)
        /// <summary>
        /// Gets or sets the minimum value.
        /// </summary>
        /// <value>The minimum value.</value>
        [
            Category("Knob"),
            Description("Minimum value of the knob")
        ]
        public float MinValue
        {
            set
            {
                this.minValue = value;
                this.Invalidate();
            }
            get { return this.minValue; }
        }

        /// <summary>
        /// Gets or sets the maximum value.
        /// </summary>
        /// <value>The maximum value.</value>
        [
            Category("Knob"),
            Description("Maximum value of the knob")
        ]
        public float MaxValue
        {
            set
            {
                this.maxValue = value;
                this.Invalidate();
            }
            get { return this.maxValue; }
        }

        /// <summary>
        /// Gets or sets the step value.
        /// </summary>
        /// <value>The step value.</value>
        [
            Category("Knob"),
            Description("Step value of the knob")
        ]
        public float StepValue
        {
            set
            {
                this.stepValue = value;
                this.Invalidate();
            }
            get { return this.stepValue; }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [
            Category("Knob"),
            Description("Current value of the knob")
        ]
        public float Value
        {
            set
            {
                if (value != this.currValue)
                {
                    this.currValue = value;
                    this.CalculateDimensions();
                    this.Invalidate();

                    ZeroitLBKnobEventArgs e = new ZeroitLBKnobEventArgs();
                    e.Value = this.currValue;
                    this.OnKnobChangeValue(e);
                }
            }
            get { return this.currValue; }
        }

        /// <summary>
        /// Gets or sets the style.
        /// </summary>
        /// <value>The style.</value>
        [
            Category("Knob"),
            Description("Style of the knob")
        ]
        public KnobStyle Style
        {
            set
            {
                this.style = value;
                this.Invalidate();
            }
            get { return this.style; }
        }

        /// <summary>
        /// Gets or sets the color of the knob.
        /// </summary>
        /// <value>The color of the knob.</value>
        [
            Category("Knob"),
            Description("Color of the knob")
        ]
        public Color KnobColor
        {
            set
            {
                this.knobColor = value;
                this.Invalidate();
            }
            get { return this.knobColor; }
        }

        /// <summary>
        /// Gets or sets the color of the scale.
        /// </summary>
        /// <value>The color of the scale.</value>
        [
            Category("Knob"),
            Description("Color of the scale")
        ]
        public Color ScaleColor
        {
            set
            {
                this.scaleColor = value;
                this.Invalidate();
            }
            get { return this.scaleColor; }
        }

        /// <summary>
        /// Gets or sets the color of the indicator.
        /// </summary>
        /// <value>The color of the indicator.</value>
        [
            Category("Knob"),
            Description("Color of the indicator")
        ]
        public Color IndicatorColor
        {
            set
            {
                this.indicatorColor = value;
                this.Invalidate();
            }
            get { return this.indicatorColor; }
        }

        /// <summary>
        /// Gets or sets the indicator offset.
        /// </summary>
        /// <value>The indicator offset.</value>
        [
            Category("Knob"),
            Description("Offset of the indicator from the kob border")
        ]
        public float IndicatorOffset
        {
            set
            {
                this.indicatorOffset = value;
                this.CalculateDimensions();
                this.Invalidate();
            }
            get { return this.indicatorOffset; }
        }

        /// <summary>
        /// Gets or sets the knob center.
        /// </summary>
        /// <value>The knob center.</value>
        [Browsable(false)]
        public PointF KnobCenter
        {
            set { this.knobCenter = value; }
            get { return this.knobCenter; }
        }

        /// <summary>
        /// Gets or sets the knob rect.
        /// </summary>
        /// <value>The knob rect.</value>
        [Browsable(false)]
        public RectangleF KnobRect
        {
            set { this.knobRect = value; }
            get { return this.knobRect; }
        }

        /// <summary>
        /// Gets or sets the draw ratio.
        /// </summary>
        /// <value>The draw ratio.</value>
        [Browsable(false)]
        public float DrawRatio
        {
            set { this.drawRatio = value; }
            get { return this.drawRatio; }
        }
        #endregion

        #region (* Events delegates *)

        /// <summary>
        /// Processes the command key.
        /// </summary>
        /// <param name="msg">A <see cref="T:System.Windows.Forms.Message" />, passed by reference, that represents the window message to process.</param>
        /// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values that represents the key to process.</param>
        /// <returns>true if the character was processed by the control; otherwise, false.</returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool blResult = true;

            /// <summary>
            /// Specified WM_KEYDOWN enumeration value.
            /// </summary>
            const int WM_KEYDOWN = 0x0100;

            /// <summary>
            /// Specified WM_SYSKEYDOWN enumeration value.
            /// </summary>
            const int WM_SYSKEYDOWN = 0x0104;

            float val = this.Value;

            if ((msg.Msg == WM_KEYDOWN) || (msg.Msg == WM_SYSKEYDOWN))
            {
                switch (keyData)
                {
                    case Keys.Up:
                        val += this.StepValue;
                        if (val <= this.MaxValue)
                            this.Value = val;
                        break;

                    case Keys.Down:
                        val -= this.StepValue;
                        if (val >= this.MinValue)
                            this.Value = val;
                        break;

                    case Keys.PageUp:
                        if (val < this.MaxValue)
                        {
                            val += (this.StepValue * 10);
                            this.Value = val;
                        }
                        break;

                    case Keys.PageDown:
                        if (val > this.MinValue)
                        {
                            val -= (this.StepValue * 10);
                            this.Value = val;
                        }
                        break;

                    case Keys.Home:
                        this.Value = this.MinValue;
                        break;

                    case Keys.End:
                        this.Value = this.MaxValue;
                        break;

                    default:
                        blResult = base.ProcessCmdKey(ref msg, keyData);
                        break;
                }
            }

            return blResult;
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Click" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        [System.ComponentModel.EditorBrowsableAttribute()]
        protected override void OnClick(EventArgs e)
        {
            this.Focus();
            this.Invalidate();
            base.OnClick(e);
        }

        /// <summary>
        /// Handles the <see cref="E:MouseUp" /> event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        void OnMouseUp(object sender, MouseEventArgs e)
        {
            this.isKnobRotating = false;

            if (this.knobRect.Contains(e.Location) == false)
                return;

            float val = this.GetValueFromPosition(e.Location);
            if (val != this.Value)
            {
                this.Value = val;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Handles the <see cref="E:MouseDown" /> event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (this.knobRect.Contains(e.Location) == false)
                return;

            this.isKnobRotating = true;

            this.Focus();
        }

        /// <summary>
        /// Handles the <see cref="E:MouseMove" /> event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (this.isKnobRotating == false)
                return;

            float val = this.GetValueFromPosition(e.Location);
            if (val != this.Value)
            {
                this.Value = val;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Handles the <see cref="E:KeyDown" /> event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        void OnKeyDown(object sender, KeyEventArgs e)
        {
            float val = this.Value;

            switch (e.KeyCode)
            {
                case Keys.Up:
                    val = this.Value + this.StepValue;
                    break;

                case Keys.Down:
                    val = this.Value - this.StepValue;
                    break;
            }

            if (val < this.MinValue)
                val = this.MinValue;

            if (val > this.MaxValue)
                val = this.MaxValue;

            this.Value = val;
        }
        #endregion

        #region (* Virtual methods *)
        /// <summary>
        /// Gets the value from position.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns>System.Single.</returns>
        public virtual float GetValueFromPosition(PointF position)
        {
            float degree = 0.0F;
            float v = 0.0F;

            PointF center = this.KnobCenter;

            if (position.X <= center.X)
            {
                degree = (center.Y - position.Y) / (center.X - position.X);
                degree = (float)Math.Atan(degree);
                degree = (float)((degree) * (180F / Math.PI) + 45F);
                v = (degree * (this.MaxValue - this.MinValue) / 270F);
            }
            else
            {
                if (position.X > center.X)
                {
                    degree = (position.Y - center.Y) / (position.X - center.X);
                    degree = (float)Math.Atan(degree);
                    degree = (float)(225F + (degree) * (180F / Math.PI));
                    v = (degree * (this.MaxValue - this.MinValue) / 270F);
                }
            }

            if (v > this.MaxValue)
                v = this.MaxValue;

            if (v < this.MinValue)
                v = this.MinValue;

            return v;
        }

        /// <summary>
        /// Gets the position from value.
        /// </summary>
        /// <param name="val">The value.</param>
        /// <returns>PointF.</returns>
        public virtual PointF GetPositionFromValue(float val)
        {
            PointF pos = new PointF(0.0F, 0.0F);

            // Elimina la divisione per 0
            if ((this.MaxValue - this.MinValue) == 0)
                return pos;

            float _indicatorOffset = this.IndicatorOffset * this.drawRatio;

            float degree = 270F * val / (this.MaxValue - this.MinValue);
            degree = (degree + 135F) * (float)Math.PI / 180F;

            pos.X = (int)(Math.Cos(degree) * ((this.knobRect.Width * 0.5F) - indicatorOffset) + this.knobRect.X + (this.knobRect.Width * 0.5F));
            pos.Y = (int)(Math.Sin(degree) * ((this.knobRect.Width * 0.5F) - indicatorOffset) + this.knobRect.Y + (this.knobRect.Height * 0.5F));

            return pos;
        }
        #endregion

        #region (* Fire events *)
        /// <summary>
        /// Occurs when [knob change value].
        /// </summary>
        public event KnobChangeValue KnobChangeValue;
        /// <summary>
        /// Handles the <see cref="E:KnobChangeValue" /> event.
        /// </summary>
        /// <param name="e">The <see cref="ZeroitLBKnobEventArgs"/> instance containing the event data.</param>
        protected virtual void OnKnobChangeValue(ZeroitLBKnobEventArgs e)
        {
            if (this.KnobChangeValue != null)
                this.KnobChangeValue(this, e);
        }
        #endregion

        #region (* Overrided method *)
        /// <summary>
        /// Call from the constructor to create the default renderer
        /// </summary>
        /// <returns>ILBRenderer.</returns>
        protected override ILBRenderer CreateDefaultRenderer()
        {
            return new ZeroitLBKnobRenderer();
        }
        #endregion
    }

    #region (* Classes for event and event delagates args *)

    #region (* Event args class *)
    /// <summary>
    /// Class for events delegates
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public class ZeroitLBKnobEventArgs : EventArgs
    {
        /// <summary>
        /// The value
        /// </summary>
        private float val;

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitLBKnobEventArgs"/> class.
        /// </summary>
        public ZeroitLBKnobEventArgs()
        {
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public float Value
        {
            get { return this.val; }
            set { this.val = value; }
        }
    }
    #endregion

    #region (* Delegates *)
    /// <summary>
    /// Delegate KnobChangeValue
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="ZeroitLBKnobEventArgs"/> instance containing the event data.</param>
    public delegate void KnobChangeValue(object sender, ZeroitLBKnobEventArgs e);
    #endregion

    #endregion
    #endregion

    #region Designer
    partial class ZeroitLBKnob
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the control.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // LBKnob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "LBKnob";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.ResumeLayout(false);
        }
    }
    #endregion

    #endregion

    #region Base

    #region LBIndustrialCtrlBase
    /// <summary>
    /// Base class for the IndustrialCtrls
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    [ToolboxItem(false)]
    public partial class ZeroitLBIndustrialCtrlBase : UserControl
    {
        #region (* Constructor *)
        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitLBIndustrialCtrlBase"/> class.
        /// </summary>
        public ZeroitLBIndustrialCtrlBase()
        {
            InitializeComponent();

            // Set the styles for drawing
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.ResizeRedraw |
                ControlStyles.DoubleBuffer |
                ControlStyles.SupportsTransparentBackColor,
                true);

            // Transparent background
            this.BackColor = Color.Transparent;

            // Creation of the default renderer
            this._defaultRenderer = CreateDefaultRenderer();
            if (this._defaultRenderer != null)
                this._defaultRenderer.Control = this;
        }
        #endregion

        #region (* Properties *)
        /// <summary>
        /// Default renderer of the control
        /// </summary>
        private ILBRenderer _defaultRenderer = null;
        /// <summary>
        /// Gets the default renderer.
        /// </summary>
        /// <value>The default renderer.</value>
        [Browsable(false)]
        public ILBRenderer DefaultRenderer
        {
            get { return this._defaultRenderer; }
        }

        /// <summary>
        /// User defined renderer
        /// </summary>
        private ILBRenderer _renderer = null;
        /// <summary>
        /// Gets or sets the renderer.
        /// </summary>
        /// <value>The renderer.</value>
        [Browsable(false)]
        public ILBRenderer Renderer
        {
            set
            {
                // set the renderer
                this._renderer = value;
                if (this._renderer != null)
                {
                    // Set the control tu the renderer
                    this._renderer.Control = this;
                    // Update the renderer
                    this._renderer.Update();
                }

                // Redraw the renderer
                Invalidate();
            }
            get { return this._renderer; }
        }
        #endregion

        #region (* Events delegates *)
        /// <summary>
        /// Font change event
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        [System.ComponentModel.EditorBrowsableAttribute()]
        protected override void OnFontChanged(EventArgs e)
        {
            // Calculate dimensions
            this.CalculateDimensions();
        }
        /// <summary>
        /// SizeChanged event
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        [System.ComponentModel.EditorBrowsableAttribute()]
        protected override void OnSizeChanged(EventArgs e)
        {
            // Default
            base.OnSizeChanged(e);
            // Calculate al the data for
            // drawing the control
            this.CalculateDimensions();
            // Redraw
            this.Invalidate();
        }

        /// <summary>
        /// Resize event
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Calculate al the data for
            // drawing the control
            this.CalculateDimensions();
            // Redraw
            this.Invalidate();
        }
        /// <summary>
        /// Paint event
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        [System.ComponentModel.EditorBrowsableAttribute()]
        protected override void OnPaint(PaintEventArgs e)
        {
            
            // Rectangle of the control
            RectangleF _rc = new RectangleF(0, 0, this.Width, this.Height);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Call the default renderer if the user
            // rendere is null
            if (this.Renderer == null)
            {
                this.DefaultRenderer.Draw(e.Graphics);
                return;
            }

            // Draw with the user renderer
            this.Renderer.Draw(e.Graphics);

            if (AllowTransparency)
            {
                MakeTransparent(this, e.Graphics);
            }

        }
        #endregion

        #region (* Virtual method *)
        /// <summary>
        /// Call from the constructor to create the default renderer
        /// </summary>
        /// <returns>ILBRenderer.</returns>
        protected virtual ILBRenderer CreateDefaultRenderer()
        {
            return new ZeroitLBRendererBase();
        }

        /// <summary>
        /// Calculate the dimensions of the control
        /// </summary>
        protected virtual void CalculateDimensions()
        {
            this.DefaultRenderer.Update();

            // Update the data in the renderer
            if (this.Renderer != null)
                this.Renderer.Update();

            this.Invalidate();
        }
        #endregion





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

    /// <summary>
    /// Base class for the controls renderer
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions._HelpingControls.LBKnob.ILBRenderer" />
    public class ZeroitLBRendererBase : ILBRenderer
    {
        #region (* Constructor *)
        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitLBRendererBase"/> class.
        /// </summary>
        public ZeroitLBRendererBase()
        {
        }
        #endregion

        #region (* IDisposable implementation *)
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.OnDispose();
        }
        #endregion

        #region (* Properties *)
        /// <summary>
        /// Associated control
        /// </summary>
        protected object _control = null;
        /// <summary>
        /// Gets or sets the control.
        /// </summary>
        /// <value>The control.</value>
        public object Control
        {
            set { this._control = value; }
            get { return this._control; }
        }
        #endregion

        #region (* Virtual methods *)
        /// <summary>
        /// Dispose the resource of the object
        /// </summary>
        public virtual void OnDispose()
        {
        }

        /// <summary>
        /// Update the renderer
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public virtual bool Update()
        {
            return false;
        }

        /// <summary>
        /// Drawing method
        /// </summary>
        /// <param name="Gr">The gr.</param>
        /// <exception cref="System.ArgumentNullException">Gr</exception>
        /// <exception cref="System.NullReferenceException">Associated control is not valid</exception>
        public virtual void Draw(Graphics Gr)
        {
            // Check the graphics
            if (Gr == null)
                throw new ArgumentNullException("Gr");

            // Check the control
            Control ctrl = this.Control as Control;
            if (ctrl == null)
                throw new NullReferenceException("Associated control is not valid");

            // Default drawing
            Rectangle rc = ctrl.Bounds;

            Gr.FillRectangle(Brushes.White, ctrl.Bounds);
            Gr.DrawRectangle(Pens.Black, ctrl.Bounds);

            Gr.DrawLine(Pens.Red,
                          ctrl.Left,
                          ctrl.Top,
                          ctrl.Right,
                          ctrl.Bottom);

            Gr.DrawLine(Pens.Red,
                          ctrl.Right,
                          ctrl.Top,
                          ctrl.Left,
                          ctrl.Bottom);
        }
        #endregion
    }
    #endregion

    #region Designer Generated Code

    partial class ZeroitLBIndustrialCtrlBase
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            // Dispose the renderers
            this.DefaultRenderer.Dispose();
            if (this.Renderer != null)
                this.Renderer.Dispose();

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }

        #endregion
    }

    #endregion

    #region Renderer
    /// <summary>
    /// Renderer interface for all
    /// LBSoft.IndustrialCtrls renderer
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public interface ILBRenderer : IDisposable
    {
        /// <summary>
        /// Gets or sets the control.
        /// </summary>
        /// <value>The control.</value>
        object Control
        {
            set;
            get;
        }
        /// <summary>
        /// Updates this instance.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool Update();
        /// <summary>
        /// Draws the specified gr.
        /// </summary>
        /// <param name="Gr">The gr.</param>
        void Draw(Graphics Gr);
    }
    #endregion

    #endregion

    #region Utils

    #region Color Manager

    /// <summary>
    /// Manager for color
    /// </summary>
    public class ZeroitLBColorManager : Object
    {
        /// <summary>
        /// Blends the colour.
        /// </summary>
        /// <param name="fg">The fg.</param>
        /// <param name="bg">The bg.</param>
        /// <param name="alpha">The alpha.</param>
        /// <returns>System.Double.</returns>
        public static double BlendColour(double fg, double bg, double alpha)
        {
            double result = bg + (alpha * (fg - bg));
            if (result < 0.0)
                result = 0.0;
            if (result > 255)
                result = 255;
            return result;
        }

        /// <summary>
        /// Steps the color.
        /// </summary>
        /// <param name="clr">The color.</param>
        /// <param name="alpha">The alpha.</param>
        /// <returns>Color.</returns>
        public static Color StepColor(Color clr, int alpha)
        {
            if (alpha == 100)
                return clr;

            byte a = clr.A;
            byte r = clr.R;
            byte g = clr.G;
            byte b = clr.B;
            float bg = 0;

            int _alpha = Math.Min(alpha, 200);
            _alpha = Math.Max(alpha, 0);
            double ialpha = ((double)(_alpha - 100.0)) / 100.0;

            if (ialpha > 100)
            {
                // blend with white
                bg = 255.0F;
                ialpha = 1.0F - ialpha;  // 0 = transparent fg; 1 = opaque fg
            }
            else
            {
                // blend with black
                bg = 0.0F;
                ialpha = 1.0F + ialpha;  // 0 = transparent fg; 1 = opaque fg
            }

            r = (byte)(ZeroitLBColorManager.BlendColour(r, bg, ialpha));
            g = (byte)(ZeroitLBColorManager.BlendColour(g, bg, ialpha));
            b = (byte)(ZeroitLBColorManager.BlendColour(b, bg, ialpha));

            return Color.FromArgb(a, r, g, b);
        }
    };

    #endregion

    #region Math Functions

    /// <summary>
    /// Mathematic Functions
    /// </summary>
    public class ZeroitLBMath : Object
    {
        /// <summary>
        /// Gets the radian.
        /// </summary>
        /// <param name="val">The value.</param>
        /// <returns>System.Single.</returns>
        public static float GetRadian(float val)
        {
            return (float)(val * Math.PI / 180);
        }
    }

    #endregion

    #endregion
    

}
