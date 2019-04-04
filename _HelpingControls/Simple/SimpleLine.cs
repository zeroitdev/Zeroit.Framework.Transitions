// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="SimpleLine.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions._HelpingControls
{

    #region Simple Line 1 !!!!!!!!!!!!!!!!!!!!!!!!! Default !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


    #region E N U M S    
    /// <summary>
    /// Enum for retrieving the Line style for <c><see cref="LineSimple" /></c>;
    /// </summary>
    public enum ZeroitSimpleLineLineStyle
    {
        /// <summary>
        /// The none
        /// </summary>
        None = 0,
        /// <summary>
        /// The vertical
        /// </summary>
        Vertical = 1,
        /// <summary>
        /// The horizontal
        /// </summary>
        Horizontal = 2,
        /// <summary>
        /// The box
        /// </summary>
        Box = 3
    }

    /// <summary>
    /// Enum for setting the line gradient direction of  <c><see cref="LineSimple" /></c>;
    /// </summary>
    public enum ZeroitSimpleLineGradientDirection
    {
        /// <summary>
        /// The horizontal
        /// </summary>
        Horizontal = 1,
        /// <summary>
        /// The vertical
        /// </summary>
        Vertical = 2
    }

    #endregion

    /// <summary>
    /// A class collection for rendering a line.
    /// <br></br>
    /// Features include :
    /// <ul><li>Vertical</li><li>Horizontal</li><li>Box</li></ul>
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    [Designer(typeof(ZeroitSimpleLineDesigner))]
    [ToolboxItem(false)]
    public class LineSimple : System.Windows.Forms.UserControl
    {

        #region D E C L A R A T I O N S

        /// <summary>
        /// The color
        /// </summary>
        private System.Drawing.Color _color = System.Drawing.Color.Black;
        /// <summary>
        /// The fill color
        /// </summary>
        private System.Drawing.Color _fillColor = System.Drawing.Color.Transparent;
        /// <summary>
        /// The line width
        /// </summary>
        private int _lineWidth = 1;
        /// <summary>
        /// The line style
        /// </summary>
        private ZeroitSimpleLineLineStyle _lineStyle;
        /// <summary>
        /// The fit to parent
        /// </summary>
        private bool _fitToParent = false;
        /// <summary>
        /// The gradient
        /// </summary>
        private System.Drawing.Color _Gradient = System.Drawing.Color.Transparent;
        /// <summary>
        /// The use gradient
        /// </summary>
        private bool _useGradient = false;
        /// <summary>
        /// The gradient angle
        /// </summary>
        private ZeroitSimpleLineGradientDirection _gradientAngle = ZeroitSimpleLineGradientDirection.Horizontal;
        /// <summary>
        /// The angle
        /// </summary>
        private float angle = 0f;

        // Added AfterPaint event, which will be raised after the control paints itself
        /// <summary>
        /// Occurs when [after paint].
        /// </summary>
        public event PaintEventHandler AfterPaint;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        #endregion

        #region C O N S T R U C T O R
        /// <summary>
        /// Initializes a new instance of the <see cref="LineSimple"/> class.
        /// </summary>
        public LineSimple()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            DrawLine();

            // TODO: Add any initialization after the InitComponent call
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region P R O P E R T I E S

        /// <summary>
        /// Gets and sets the line gradient angle.
        /// </summary>
        /// <value>The gradient angle.</value>
        [Category("Custom")]
        public ZeroitSimpleLineGradientDirection GradientAngle
        {
            get { return _gradientAngle; }
            set
            {
                _gradientAngle = value;
                DrawLine();
            }
        }

        /// <summary>
        /// For lines, this will scale the line to fit right-to-left, or top-to-bottom
        /// </summary>
        /// <value><c>true</c> if [fit to parent]; otherwise, <c>false</c>.</value>
        [Category("Custom")]
        public bool FitToParent
        {
            get { return _fitToParent; }
            set
            {
                _fitToParent = value;
                DrawLine();
            }
        }

        /// <summary>
        /// If set to true, gradient will draw with FillColor and Gradient color
        /// </summary>
        /// <value><c>true</c> if [use gradient]; otherwise, <c>false</c>.</value>
        [Category("Custom")]
        public bool UseGradient
        {
            get { return _useGradient; }
            set
            {
                if (FillColor == Color.Transparent && Gradient == Color.Transparent)
                {
                    Gradient = Color.Teal;
                    FillColor = Color.Orange;
                    //MessageBox.Show("Please Choose colors for the Gradient and FillColor");
                }
                _useGradient = value;
                DrawLine();
            }
        }

        /// <summary>
        /// Gets or sets the color of the fill.
        /// </summary>
        /// <value>The color of the fill.</value>
        [Category("Custom")]
        public System.Drawing.Color FillColor
        {
            get { return _fillColor; }
            set
            {
                _fillColor = value;
                DrawLine();
            }
        }

        /// <summary>
        /// Gets or sets the gradient color.
        /// </summary>
        /// <value>The gradient.</value>
        [Category("Custom")]
        public System.Drawing.Color Gradient
        {
            get { return _Gradient; }
            set
            {
                _Gradient = value;
                DrawLine();
            }
        }

        /// <summary>
        /// Gets or sets the color of the line.
        /// </summary>
        /// <value>The color of the line.</value>
        [Category("Custom")]
        public System.Drawing.Color LineColor
        {
            get
            {
                if (_color == Color.Transparent) { _color = Parent.BackColor; }
                return _color;

            }
            set
            {
                _color = value;
                DrawLine();
            }
        }

        /// <summary>
        /// Gets or sets the width of the line.
        /// </summary>
        /// <value>The width of the line.</value>
        [Category("Custom")]
        public int LineWidth
        {
            get { return _lineWidth; }
            set
            {
                _lineWidth = value;
                DrawLine();
            }
        }

        /// <summary>
        /// Gets or sets the value whether the line is horizontal, vertical, or box.
        /// </summary>
        /// <value>The style.</value>
        [Category("Custom")]
        public ZeroitSimpleLineLineStyle Style
        {
            get { return _lineStyle; }
            set
            {
                _lineStyle = value;
                if (value == ZeroitSimpleLineLineStyle.Vertical && Height <= LineWidth) { Height = 50; Width = LineWidth; }
                if (value == ZeroitSimpleLineLineStyle.Horizontal && Width <= LineWidth) { Width = 50; Height = LineWidth; }
                if ((value == ZeroitSimpleLineLineStyle.Box) && ((Width <= LineWidth) || (Height <= LineWidth)))
                {
                    Height = 50;
                    Width = 50;
                }
                DrawLine();
            }
        }
        #endregion

        #region E V E N T S

        /// <summary>
        /// Called after the control has been added to another container.
        /// </summary>
        protected override void InitLayout()
        {
            DrawLine();
        }


        #endregion

        #region M E T H O D S

        /// <summary>
        /// Draws the line.
        /// </summary>
        public void DrawLine()
        {
            if (this.Parent == null) { return; } //we don't want the control to draw on itself at design time

            if (this.Style == ZeroitSimpleLineLineStyle.None) //default to Horizontal line, when placed on a parent
            {
                _lineStyle = ZeroitSimpleLineLineStyle.Horizontal;
                _lineWidth = 1;
                this.Left = (Parent.Width / 2) - this.Width / 2;
                this.Top = Parent.Height / 2;
            }

            Graphics g = this.CreateGraphics(); //create the graphics object
            g.Clear(Parent.BackColor);
            Pen pn;
            if (this.Style == ZeroitSimpleLineLineStyle.Vertical || this.Style == ZeroitSimpleLineLineStyle.Horizontal)
                pn = new Pen(LineColor, LineWidth * 2);
            else
                pn = new Pen(LineColor, LineWidth);

            Point pt1 = new Point(0, 0);
            Point pt2;
            if (this.Style == ZeroitSimpleLineLineStyle.Horizontal)
            {
                if (FitToParent == true)
                {
                    this.Left = 0;
                    this.Width = Parent.ClientRectangle.Width;
                }

                this.Height = LineWidth;
                if (this.Height < 1) { this.Height = 1; }

                pt2 = new Point(Width, 0);
                if (UseGradient == false)
                {
                    g.DrawLine(pn, pt1, pt2);

                }
                else
                {
                    Rectangle rect = new Rectangle(new Point(0, 0), new Size(this.ClientRectangle.Width, LineWidth));
                    if (FillColor == Color.Transparent) { FillColor = Parent.BackColor; }
                    {
                        LinearGradientBrush lgb = new LinearGradientBrush(rect, FillColor, Gradient, 0, false);
                        g.FillRectangle(lgb, 0, 0, this.Width, LineWidth);
                    }
                }
            }
            else if (this.Style == ZeroitSimpleLineLineStyle.Vertical)
            {
                if (FitToParent == true)
                {
                    this.Top = 0;
                    this.Height = Parent.Height;
                }

                this.Width = LineWidth;
                if (this.Width < 1) { this.Width = 1; }

                pt2 = new Point(0, Height);
                if (UseGradient == false)
                {
                    g.DrawLine(pn, pt1, pt2);
                }
                else
                {
                    Rectangle rect = new Rectangle(new Point(0, 0), new Size(LineWidth, this.Height));
                    if (FillColor == Color.Transparent) { FillColor = Parent.BackColor; }
                    {
                        LinearGradientBrush lgb = new LinearGradientBrush(rect, FillColor, Gradient, 90, false);
                        g.FillRectangle(lgb, 0, 0, LineWidth, this.Height);

                    }
                }
            }
            else if (this.Style == ZeroitSimpleLineLineStyle.Box)
            {
                if (FitToParent == true)
                {
                    this.Top = 0;
                    this.Left = 0;
                    this.Width = Parent.Width;
                    this.Height = Parent.Height;
                }

                Rectangle rect = new Rectangle(new Point(0, 0), new Size(this.Width, this.Height));
                if (FillColor == Color.Transparent) { FillColor = Parent.BackColor; }
                if (UseGradient)
                {
                    LinearGradientBrush lgb = new LinearGradientBrush(rect, FillColor, Gradient, GradientAngle == ZeroitSimpleLineGradientDirection.Horizontal ? 0 : 90, false);
                    g.FillRectangle(lgb, 0, 0, this.Width - LineWidth, this.Height - LineWidth);

                }
                else
                {
                    SolidBrush sb = new SolidBrush(FillColor);
                    g.FillRectangle(sb, 0, 0, this.Width - LineWidth, this.Height - LineWidth);

                }

                decimal mod = Decimal.Remainder((decimal)LineWidth, (decimal)2);
                int offset = 0;
                if (mod != 0 && LineWidth != 1) { offset = 1; }

                rect.Offset(LineWidth / 2, LineWidth / 2);
                rect.Height = rect.Height - LineWidth + offset - 1;
                rect.Width = rect.Width - LineWidth + offset - 1;
                if (LineWidth > 0) { g.DrawRectangle(pn, rect); }
            }

            g.Dispose();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            OnResize(EventArgs.Empty);

            // Added AfterPaint event, which will be raised after the control paints itself
            if (AfterPaint != null)
                AfterPaint(this, e);
        }

        /// <summary>
        /// Handles the <see cref="E:Resize" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnResize(EventArgs e)
        {

            DrawLine();
            base.OnResize(e);
        }



        #endregion

        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // 
            // simpleLine
            // 
            this.Name = "simpleLine";
            this.Size = new System.Drawing.Size(96, 32);

        }
        #endregion
    }


    #region Smart Tag Code

    #region Cut and Paste it on top of the component class

    //--------------- [Designer(typeof(ZeroitSimpleLineDesigner))] --------------------//
    #endregion

    #region ControlDesigner
    /// <summary>
    /// Class ZeroitSimpleLineDesigner.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Design.ControlDesigner" />
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class ZeroitSimpleLineDesigner : System.Windows.Forms.Design.ControlDesigner
    {
        /// <summary>
        /// The action lists
        /// </summary>
        private DesignerActionListCollection actionLists;

        // Use pull model to populate smart tag menu.
        /// <summary>
        /// Gets the design-time action lists supported by the component associated with the designer.
        /// </summary>
        /// <value>The action lists.</value>
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (null == actionLists)
                {
                    actionLists = new DesignerActionListCollection();
                    actionLists.Add(new ZeroitSimpleLineSmartTagActionList(this.Component));
                }
                return actionLists;
            }
        }
    }

    #endregion

    #region SmartTagActionList
    /// <summary>
    /// Class ZeroitSimpleLineSmartTagActionList.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Design.DesignerActionList" />
    public class ZeroitSimpleLineSmartTagActionList : System.ComponentModel.Design.DesignerActionList
    {
        //Replace SmartTag with the Component Class Name. In this case the component class name is SmartTag
        /// <summary>
        /// The col user control
        /// </summary>
        private LineSimple colUserControl;


        /// <summary>
        /// The designer action UI SVC
        /// </summary>
        private DesignerActionUIService designerActionUISvc = null;


        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitSimpleLineSmartTagActionList"/> class.
        /// </summary>
        /// <param name="component">A component related to the <see cref="T:System.ComponentModel.Design.DesignerActionList" />.</param>
        public ZeroitSimpleLineSmartTagActionList(IComponent component) : base(component)
        {
            this.colUserControl = component as LineSimple;

            // Cache a reference to DesignerActionUIService, so the 
            // DesigneractionList can be refreshed. 
            this.designerActionUISvc = GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
        }

        // Helper method to retrieve control properties. Use of GetProperties enables undo and menu updates to work properly.
        /// <summary>
        /// Gets the name of the property by.
        /// </summary>
        /// <param name="propName">Name of the property.</param>
        /// <returns>PropertyDescriptor.</returns>
        /// <exception cref="System.ArgumentException">Matching ColorLabel property not found!</exception>
        private PropertyDescriptor GetPropertyByName(String propName)
        {
            PropertyDescriptor prop;
            prop = TypeDescriptor.GetProperties(colUserControl)[propName];
            if (null == prop)
                throw new ArgumentException("Matching ColorLabel property not found!", propName);
            else
                return prop;
        }

        #region Properties that are targets of DesignerActionPropertyItem entries.

        /// <summary>
        /// Gets or sets the color of the back.
        /// </summary>
        /// <value>The color of the back.</value>
        public Color BackColor
        {
            get
            {
                return colUserControl.BackColor;
            }
            set
            {
                GetPropertyByName("BackColor").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the color of the fore.
        /// </summary>
        /// <value>The color of the fore.</value>
        public Color ForeColor
        {
            get
            {
                return colUserControl.ForeColor;
            }
            set
            {
                GetPropertyByName("ForeColor").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the gradient angle.
        /// </summary>
        /// <value>The gradient angle.</value>
        public ZeroitSimpleLineGradientDirection GradientAngle
        {
            get
            {
                return colUserControl.GradientAngle;
            }
            set
            {
                GetPropertyByName("GradientAngle").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [fit to parent].
        /// </summary>
        /// <value><c>true</c> if [fit to parent]; otherwise, <c>false</c>.</value>
        public bool FitToParent
        {
            get
            {
                return colUserControl.FitToParent;
            }
            set
            {
                GetPropertyByName("FitToParent").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [use gradient].
        /// </summary>
        /// <value><c>true</c> if [use gradient]; otherwise, <c>false</c>.</value>
        public bool UseGradient
        {
            get
            {
                return colUserControl.UseGradient;
            }
            set
            {
                GetPropertyByName("UseGradient").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the color of the fill.
        /// </summary>
        /// <value>The color of the fill.</value>
        public Color FillColor
        {
            get
            {
                return colUserControl.FillColor;
            }
            set
            {
                GetPropertyByName("FillColor").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the gradient.
        /// </summary>
        /// <value>The gradient.</value>
        public Color Gradient
        {
            get
            {
                return colUserControl.Gradient;
            }
            set
            {
                GetPropertyByName("Gradient").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the color of the line.
        /// </summary>
        /// <value>The color of the line.</value>
        public Color LineColor
        {
            get
            {
                return colUserControl.LineColor;
            }
            set
            {
                GetPropertyByName("LineColor").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the width of the line.
        /// </summary>
        /// <value>The width of the line.</value>
        public int LineWidth
        {
            get
            {
                return colUserControl.LineWidth;
            }
            set
            {
                GetPropertyByName("LineWidth").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the style.
        /// </summary>
        /// <value>The style.</value>
        public ZeroitSimpleLineLineStyle Style
        {
            get
            {
                return colUserControl.Style;
            }
            set
            {
                GetPropertyByName("Style").SetValue(colUserControl, value);
            }
        }

        #endregion

        #region DesignerActionItemCollection

        /// <summary>
        /// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem" /> objects contained in the list.
        /// </summary>
        /// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem" /> array that contains the items in this list.</returns>
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();

            //Define static section header entries.
            items.Add(new DesignerActionHeaderItem("Appearance"));

            items.Add(new DesignerActionPropertyItem("BackColor",
                                 "Back Color", "Appearance",
                                 "Selects the background color."));

            items.Add(new DesignerActionPropertyItem("ForeColor",
                                 "Fore Color", "Appearance",
                                 "Selects the foreground color."));

            items.Add(new DesignerActionPropertyItem("GradientAngle",
                                 "Gradient Angle", "Appearance",
                                 "Type few characters to filter Cities."));

            items.Add(new DesignerActionPropertyItem("FitToParent",
                                 "Fit To Parent", "Appearance",
                                 "Type few characters to filter Cities."));

            items.Add(new DesignerActionPropertyItem("UseGradient",
                                 "Use Gradient", "Appearance",
                                 "Selects the background color."));

            items.Add(new DesignerActionPropertyItem("FillColor",
                                 "Fill Color", "Appearance",
                                 "Selects the foreground color."));

            items.Add(new DesignerActionPropertyItem("Gradient",
                                 "Gradient", "Appearance",
                                 "Type few characters to filter Cities."));

            items.Add(new DesignerActionPropertyItem("LineColor",
                                 "Line Color", "Appearance",
                                 "Type few characters to filter Cities."));

            items.Add(new DesignerActionPropertyItem("LineWidth",
                                 "Line Width", "Appearance",
                                 "Type few characters to filter Cities."));

            items.Add(new DesignerActionPropertyItem("Style",
                                 "Style", "Appearance",
                                 "Type few characters to filter Cities."));

            //Create entries for static Information section.
            StringBuilder location = new StringBuilder("Product: ");
            location.Append(colUserControl.ProductName);
            StringBuilder size = new StringBuilder("Version: ");
            size.Append(colUserControl.ProductVersion);
            items.Add(new DesignerActionTextItem(location.ToString(),
                             "Information"));
            items.Add(new DesignerActionTextItem(size.ToString(),
                             "Information"));

            return items;
        }

        #endregion




    }

    #endregion

    #endregion


    #endregion
}
