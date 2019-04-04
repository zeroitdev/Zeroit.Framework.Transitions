// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="AtomicAnimatorInput.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Reflection;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using Zeroit.Framework.Transitions.AtomicAnimator.AnimationCurves;
using Zeroit.Framework.Transitions.AtomicAnimator;
using System.ComponentModel.Design.Serialization;

#endregion

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    /// Class AtomicAnimatorInput.
    /// </summary>
    [TypeConverter(typeof(AtomicAnimatorInput.Converter))]
    [EditorAttribute(typeof(AtomicInputEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public class AtomicAnimatorInput
    {

        #region Private Fields

        /// <summary>
        /// The forecolor for property
        /// </summary>
        private Color forecolorForProperty = Color.Black;
        /// <summary>
        /// The backcolor for property
        /// </summary>
        private Color backcolorForProperty = Color.LightBlue;
        /// <summary>
        /// The control location
        /// </summary>
        private System.Drawing.Point controlLocation = new System.Drawing.Point(447, 356);
        /// <summary>
        /// The control
        /// </summary>
        private Control control = new Control();
        /// <summary>
        /// The animation string
        /// </summary>
        private string animationString = "";
        /// <summary>
        /// The control animation text
        /// </summary>
        private string controlAnimationText = "text";

        /// <summary>
        /// The animated property
        /// </summary>
        private ZeroitAtomEdit.PropertyAnimated animatedProperty = ZeroitAtomEdit.PropertyAnimated.Size;

        /// <summary>
        /// The animations
        /// </summary>
        private ZeroitAtomEdit.Animations animations = ZeroitAtomEdit.Animations.EaseInEaseOut;

        /// <summary>
        /// The control animation size
        /// </summary>
        private System.Drawing.Size controlAnimationSize = new System.Drawing.Size(100, 100);

        //private int controlAnimatedSize = 100;
        /// <summary>
        /// The duration
        /// </summary>
        private float duration = 2f;
        /// <summary>
        /// The reverse
        /// </summary>
        private bool reverse = true;

        //Point 1
        /// <summary>
        /// The point1 x
        /// </summary>
        private float point1X = 0.5f;
        /// <summary>
        /// The point1 y
        /// </summary>
        private float point1Y = 0.0f;

        //Point 2
        /// <summary>
        /// The point2 x
        /// </summary>
        private float point2X = 0.5f;
        /// <summary>
        /// The point2 y
        /// </summary>
        private float point2Y = 1.0f;

        //Point 3
        /// <summary>
        /// The point3 x
        /// </summary>
        private float point3X = 0.5f;
        /// <summary>
        /// The point3 y
        /// </summary>
        private float point3Y = 0.5f;

        //Point 4
        /// <summary>
        /// The point4 x
        /// </summary>
        private float point4X = 1.0f;
        /// <summary>
        /// The point4 y
        /// </summary>
        private float point4Y = 0.0f;


        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the custom animation2 points.
        /// </summary>
        /// <value>The custom animation2 points.</value>
        [Browsable(false)]
        public IAnimationCurve CustomAnimation2Points
        {
            get
            {
                return new BezierCurve(new PointF(point1X, point1Y), new PointF(point2X, point2Y));
            }

        }

        /// <summary>
        /// Gets the custom animation3 points.
        /// </summary>
        /// <value>The custom animation3 points.</value>
        [Browsable(false)]
        public IAnimationCurve CustomAnimation3Points
        {
            get
            {
                return new BezierCurve(new PointF(point1X, point1Y), new PointF(point2X, point2Y), new PointF(point3X, point3Y));
            }

        }

        /// <summary>
        /// Gets the custom animation4 points.
        /// </summary>
        /// <value>The custom animation4 points.</value>
        [Browsable(false)]
        public IAnimationCurve CustomAnimation4Points
        {
            get
            {
                return new BezierCurve(new PointF(point1X, point1Y), new PointF(point2X, point2Y), new PointF(point3X, point3Y), new PointF(point4X, point4Y));
            }

        }

        /// <summary>
        /// Gets or sets the custom animation point1 x.
        /// </summary>
        /// <value>The custom animation point1 x.</value>
        public float CustomAnimationPoint1X
        {
            get { return point1X; }
            set
            {
                point1X = value;
            }
        }

        /// <summary>
        /// Gets or sets the custom animation point1 y.
        /// </summary>
        /// <value>The custom animation point1 y.</value>
        public float CustomAnimationPoint1Y
        {
            get { return point1Y; }
            set
            {
                point1Y = value;
            }
        }

        /// <summary>
        /// Gets or sets the custom animation point2 x.
        /// </summary>
        /// <value>The custom animation point2 x.</value>
        public float CustomAnimationPoint2X
        {
            get { return point2X; }
            set
            {
                point2X = value;
            }
        }

        /// <summary>
        /// Gets or sets the custom animation point2 y.
        /// </summary>
        /// <value>The custom animation point2 y.</value>
        public float CustomAnimationPoint2Y
        {
            get { return point2Y; }
            set
            {
                point2Y = value;
            }
        }

        /// <summary>
        /// Gets or sets the custom animation point3 x.
        /// </summary>
        /// <value>The custom animation point3 x.</value>
        public float CustomAnimationPoint3X
        {
            get { return point3X; }
            set
            {
                point3X = value;
            }
        }

        /// <summary>
        /// Gets or sets the custom animation point3 y.
        /// </summary>
        /// <value>The custom animation point3 y.</value>
        public float CustomAnimationPoint3Y
        {
            get { return point3Y; }
            set
            {
                point3Y = value;
            }
        }

        /// <summary>
        /// Gets or sets the custom animation point4 x.
        /// </summary>
        /// <value>The custom animation point4 x.</value>
        public float CustomAnimationPoint4X
        {
            get { return point4X; }
            set
            {
                point4X = value;
            }
        }

        /// <summary>
        /// Gets or sets the custom animation point4 y.
        /// </summary>
        /// <value>The custom animation point4 y.</value>
        public float CustomAnimationPoint4Y
        {
            get { return point4Y; }
            set
            {
                point4Y = value;
            }
        }

        /// <summary>
        /// Gets or sets the control.
        /// </summary>
        /// <value>The control.</value>
        public Control Control
        {
            get { return control; }
            set
            {
                control = value;

            }
        }

        //public string ControlAnimationString
        //{
        //    get { return controlAnimationText; }
        //    set
        //    {

        //        controlAnimationText = value;
        //        if(DesignMode)
        //        {
        //            control.Text = controlAnimationText;
        //        }
        //    }
        //}
        /// <summary>
        /// Gets or sets the size of the control animation.
        /// </summary>
        /// <value>The size of the control animation.</value>
        public System.Drawing.Size ControlAnimationSize
        {
            get { return controlAnimationSize; }
            set
            {
                controlAnimationSize = value;
            }
        }

        /// <summary>
        /// Gets or sets the control location.
        /// </summary>
        /// <value>The control location.</value>
        public System.Drawing.Point ControlLocation
        {
            get { return controlLocation; }
            set
            {
                controlLocation = value;
            }
        }

        /// <summary>
        /// Gets or sets the color of the control fore.
        /// </summary>
        /// <value>The color of the control fore.</value>
        public Color ControlForeColor
        {
            get { return forecolorForProperty; }
            set
            {
                forecolorForProperty = value;
                

            }
        }

        /// <summary>
        /// Gets or sets the color of the control back.
        /// </summary>
        /// <value>The color of the control back.</value>
        public Color ControlBackColor
        {
            get { return backcolorForProperty; }
            set
            {
                backcolorForProperty = value;
                

            }
        }

        /// <summary>
        /// Gets or sets the animated property.
        /// </summary>
        /// <value>The animated property.</value>
        public ZeroitAtomEdit.PropertyAnimated AnimatedProperty
        {
            get { return animatedProperty; }
            set
            {
                animatedProperty = value;
            }
        }


        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="AtomicAnimatorInput"/> is reverse.
        /// </summary>
        /// <value><c>true</c> if reverse; otherwise, <c>false</c>.</value>
        public bool Reverse
        {
            get { return reverse; }
            set
            {
                reverse = value;
            }
        }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        /// <value>The duration.</value>
        public float Duration
        {
            get { return duration; }
            set
            {
                duration = value;
            }
        }

        //public int ControlAnimatedSize
        //{
        //    get { return controlAnimatedSize; }
        //    set
        //    {
        //        controlAnimatedSize = value;

        //    }
        //}

        /// <summary>
        /// Gets or sets the transition.
        /// </summary>
        /// <value>The transition.</value>
        public ZeroitAtomEdit.Animations Transition
        {
            get { return animations; }
            set
            {
                animations = value;

            }
        }

        /// <summary>
        /// Gets or sets the animation string.
        /// </summary>
        /// <value>The animation string.</value>
        public string AnimationString
        {
            get { return animationString; }
            set
            {
                animationString = value;

            }
        }

        #endregion

        #region Constructor

        // Internal constructor 
        /// <summary>
        /// Initializes a new instance of the <see cref="AtomicAnimatorInput"/> class.
        /// </summary>
        /// <param name="animatedProperty">The animated property.</param>
        /// <param name="point1X">The point1 x.</param>
        /// <param name="point1Y">The point1 y.</param>
        /// <param name="point2X">The point2 x.</param>
        /// <param name="point2Y">The point2 y.</param>
        /// <param name="point3X">The point3 x.</param>
        /// <param name="point3Y">The point3 y.</param>
        /// <param name="point4X">The point4 x.</param>
        /// <param name="point4Y">The point4 y.</param>
        /// <param name="controlAnimationText">The control animation text.</param>
        /// <param name="controlAnimationSize">Size of the control animation.</param>
        /// <param name="controlLocation">The control location.</param>
        /// <param name="forecolorForProperty">The forecolor for property.</param>
        /// <param name="backcolorForProperty">The backcolor for property.</param>
        /// <param name="reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animations">The animations.</param>
        /// <param name="animationString">The animation string.</param>
        public AtomicAnimatorInput
            (
                ZeroitAtomEdit.PropertyAnimated animatedProperty,
                float point1X,
                float point1Y,
                float point2X,
                float point2Y,
                float point3X,
                float point3Y,
                float point4X,
                float point4Y,
                string controlAnimationText,
                System.Drawing.Size controlAnimationSize,
                System.Drawing.Point controlLocation,
                Color forecolorForProperty,
                Color backcolorForProperty,
                bool reverse,
                float duration,
                ZeroitAtomEdit.Animations animations,
                string animationString
            
            )
        {
            this.point1X = point1X;
            this.point1Y = point1Y;
            this.point2X = point2X;
            this.point2Y = point2Y;
            this.point3X = point3X;
            this.point3Y = point3Y;
            this.point4X = point4X;
            this.point4Y = point4Y;
            this.controlAnimationText = controlAnimationText;
            this.controlAnimationSize = controlAnimationSize;
            this.controlLocation = controlLocation;
            this.forecolorForProperty = forecolorForProperty;
            this.backcolorForProperty = backcolorForProperty;
            this.animatedProperty = animatedProperty;
            this.reverse = reverse;
            this.duration = duration;
            this.animations = animations;
            this.animationString = animationString;
            
        }


        /// <summary>
        /// Constructor for no Input.
        /// </summary>
        public AtomicAnimatorInput(
        ) :
            this(
                ZeroitAtomEdit.PropertyAnimated.Size,
                0.5f,
                0.0f,
                0.5f,
                1.0f,
                0.5f,
                0.5f,
                1.0f,
                0.0f,
                "text",
                new System.Drawing.Size(100, 100),
                new System.Drawing.Point(447, 356),
                Color.Black,
                Color.LightBlue,
                true,
                2f,
                ZeroitAtomEdit.Animations.EaseInEaseOut,
                ""

            )
        {


        }

        /// <summary>
        /// Constructor for no Input.
        /// </summary>
        /// <param name="animatedProperty">The animated property.</param>
        /// <param name="control">The control.</param>
        public AtomicAnimatorInput(ZeroitAtomEdit.PropertyAnimated animatedProperty,
        Control control
            ) : 
            this(
                    ZeroitAtomEdit.PropertyAnimated.None,
                    0.5f,
                    0.0f,
                    0.5f,
                    1.0f,
                    0.5f,
                    0.5f,
                    1.0f,
                    0.0f,
                    "text",
                    new System.Drawing.Size(100, 100),
                    new System.Drawing.Point(447, 356),
                    Color.Black,
                    Color.LightBlue,
                    true,
                    2f,
                    ZeroitAtomEdit.Animations.EaseInEaseOut,
                    ""

        )
        {

            this.animatedProperty = animatedProperty;
            this.control = control;
        }

        /// <summary>
        /// Constructor for Size Animation.
        /// </summary>
        /// <param name="animatedProperty">The animated property.</param>
        /// <param name="point1X">The point1 x.</param>
        /// <param name="point1Y">The point1 y.</param>
        /// <param name="point2X">The point2 x.</param>
        /// <param name="point2Y">The point2 y.</param>
        /// <param name="point3X">The point3 x.</param>
        /// <param name="point3Y">The point3 y.</param>
        /// <param name="point4X">The point4 x.</param>
        /// <param name="point4Y">The point4 y.</param>
        /// <param name="controlAnimationSize">Size of the control animation.</param>
        /// <param name="reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animations">The animations.</param>
        /// <param name="control">The control.</param>
        public AtomicAnimatorInput(
            ZeroitAtomEdit.PropertyAnimated animatedProperty,
            float point1X, float point1Y,
            float point2X, float point2Y,
            float point3X, float point3Y,
            float point4X, float point4Y,
            System.Drawing.Size controlAnimationSize,
            bool reverse, float duration,
            ZeroitAtomEdit.Animations animations,
            Control control) :
            this(
                ZeroitAtomEdit.PropertyAnimated.Size,
                0.5f,
                0.0f,
                0.5f,
                1.0f,
                0.5f,
                0.5f,
                1.0f,
                0.0f,
                "text",
                new System.Drawing.Size(100, 100),
                new System.Drawing.Point(447, 356),
                Color.Black,
                Color.LightBlue,
                true,
                2f,
                ZeroitAtomEdit.Animations.EaseInEaseOut,
                ""

            )
        {
            this.point1X = point1X;
            this.point1Y = point1Y;
            this.point2X = point2X;
            this.point2Y = point2Y;
            this.point3X = point3X;
            this.point3Y = point3Y;
            this.point4X = point4X;
            this.point4Y = point4Y;

            this.controlAnimationSize = controlAnimationSize;
            this.animatedProperty = animatedProperty;
            this.reverse = reverse;
            this.duration = duration;
            this.animations = animations;
        }

        /// <summary>
        /// Constructor for Size Animation.
        /// </summary>
        /// <param name="animatedProperty">The animated property.</param>
        /// <param name="point1X">The point1 x.</param>
        /// <param name="point1Y">The point1 y.</param>
        /// <param name="point2X">The point2 x.</param>
        /// <param name="point2Y">The point2 y.</param>
        /// <param name="point3X">The point3 x.</param>
        /// <param name="point3Y">The point3 y.</param>
        /// <param name="point4X">The point4 x.</param>
        /// <param name="point4Y">The point4 y.</param>
        /// <param name="controlLocation">The control location.</param>
        /// <param name="reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animations">The animations.</param>
        /// <param name="control">The control.</param>
        public AtomicAnimatorInput(ZeroitAtomEdit.PropertyAnimated animatedProperty,
            float point1X, float point1Y,
            float point2X, float point2Y,
            float point3X, float point3Y,
            float point4X, float point4Y,
            System.Drawing.Point controlLocation,
            bool reverse, float duration,
            ZeroitAtomEdit.Animations animations,
            Control control) :
            this(
                ZeroitAtomEdit.PropertyAnimated.Location,
                0.5f,
                0.0f,
                0.5f,
                1.0f,
                0.5f,
                0.5f,
                1.0f,
                0.0f,
                "text",
                new System.Drawing.Size(100, 100),
                new System.Drawing.Point(447, 356),
                Color.Black,
                Color.LightBlue,
                true,
                2f,
                ZeroitAtomEdit.Animations.EaseInEaseOut,
                ""
                

            )
        {
            this.point1X = point1X;
            this.point1Y = point1Y;
            this.point2X = point2X;
            this.point2Y = point2Y;
            this.point3X = point3X;
            this.point3Y = point3Y;
            this.point4X = point4X;
            this.point4Y = point4Y;

            this.controlLocation = controlLocation;
            this.animatedProperty = animatedProperty;
            this.reverse = reverse;
            this.duration = duration;
            this.animations = animations;
        }

        /// <summary>
        /// Constructor for Size Animation.
        /// </summary>
        /// <param name="animatedProperty">The animated property.</param>
        /// <param name="point1X">The point1 x.</param>
        /// <param name="point1Y">The point1 y.</param>
        /// <param name="point2X">The point2 x.</param>
        /// <param name="point2Y">The point2 y.</param>
        /// <param name="point3X">The point3 x.</param>
        /// <param name="point3Y">The point3 y.</param>
        /// <param name="point4X">The point4 x.</param>
        /// <param name="point4Y">The point4 y.</param>
        /// <param name="backcolorForProperty">The backcolor for property.</param>
        /// <param name="reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animations">The animations.</param>
        /// <param name="control">The control.</param>
        public AtomicAnimatorInput(
            ZeroitAtomEdit.PropertyAnimated animatedProperty,
            float point1X, float point1Y,
            float point2X, float point2Y,
            float point3X, float point3Y,
            float point4X, float point4Y,
            System.Drawing.Color backcolorForProperty,
            bool reverse, float duration,
            ZeroitAtomEdit.Animations animations,
            Control control) :
            this(
                ZeroitAtomEdit.PropertyAnimated.BackColor,
                0.5f,
                0.0f,
                0.5f,
                1.0f,
                0.5f,
                0.5f,
                1.0f,
                0.0f,
                "text",
                new System.Drawing.Size(100, 100),
                new System.Drawing.Point(447, 356),
                Color.Black,
                Color.LightBlue,
                true,
                2f,
                ZeroitAtomEdit.Animations.EaseInEaseOut,
                ""

            )
        {
            this.point1X = point1X;
            this.point1Y = point1Y;
            this.point2X = point2X;
            this.point2Y = point2Y;
            this.point3X = point3X;
            this.point3Y = point3Y;
            this.point4X = point4X;
            this.point4Y = point4Y;

            this.backcolorForProperty = backcolorForProperty;
            this.animatedProperty = animatedProperty;
            this.reverse = reverse;
            this.duration = duration;
            this.animations = animations;
        }

        /// <summary>
        /// Constructor for Size Animation.
        /// </summary>
        /// <param name="animatedProperty">The animated property.</param>
        /// <param name="point1X">The point1 x.</param>
        /// <param name="point1Y">The point1 y.</param>
        /// <param name="point2X">The point2 x.</param>
        /// <param name="point2Y">The point2 y.</param>
        /// <param name="point3X">The point3 x.</param>
        /// <param name="point3Y">The point3 y.</param>
        /// <param name="point4X">The point4 x.</param>
        /// <param name="point4Y">The point4 y.</param>
        /// <param name="forecolorForProperty">The forecolor for property.</param>
        /// <param name="reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animations">The animations.</param>
        /// <param name="text">The text.</param>
        /// <param name="control">The control.</param>
        public AtomicAnimatorInput(ZeroitAtomEdit.PropertyAnimated animatedProperty,
            float point1X, float point1Y,
            float point2X, float point2Y,
            float point3X, float point3Y,
            float point4X, float point4Y,
            System.Drawing.Color forecolorForProperty,
            bool reverse, float duration,
            ZeroitAtomEdit.Animations animations, string text,
            Control control) :
            this(
                ZeroitAtomEdit.PropertyAnimated.ForeColor,
                0.5f,
                0.0f,
                0.5f,
                1.0f,
                0.5f,
                0.5f,
                1.0f,
                0.0f,
                "text",
                new System.Drawing.Size(100, 100),
                new System.Drawing.Point(447, 356),
                Color.Black,
                Color.LightBlue,
                true,
                2f,
                ZeroitAtomEdit.Animations.EaseInEaseOut,
                ""

            )
        {
            this.point1X = point1X;
            this.point1Y = point1Y;
            this.point2X = point2X;
            this.point2Y = point2Y;
            this.point3X = point3X;
            this.point3Y = point3Y;
            this.point4X = point4X;
            this.point4Y = point4Y;

            this.forecolorForProperty = forecolorForProperty;
            this.animatedProperty = animatedProperty;
            this.reverse = reverse;
            this.duration = duration;
            this.animations = animations;
        }

        #endregion

        #region Public Methods


        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>AtomicAnimatorInput.</returns>
        public AtomicAnimatorInput Clone()
        {
            return new AtomicAnimatorInput(
                animatedProperty,
                point1X,
                point1Y,
                point2X,
                point2Y,
                point3X,
                point3Y,
                point4X,
                point4Y,
                controlAnimationText,
                controlAnimationSize,
                controlLocation,
                forecolorForProperty,
                backcolorForProperty,
                reverse,
                duration,
                animations,
                animationString
                );
        }


        /// <summary>
        /// Empties this instance.
        /// </summary>
        /// <returns>AtomicAnimatorInput.</returns>
        public static AtomicAnimatorInput Empty()
        {
            return new AtomicAnimatorInput();
        }

        #endregion

        #region Converter

        /// <summary>
        /// Class Converter.
        /// </summary>
        /// <seealso cref="System.ComponentModel.TypeConverter" />
        internal class Converter : TypeConverter
        {

            /// <summary>
            /// Returns whether this converter can convert the object to the specified type, using the specified context.
            /// </summary>
            /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
            /// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type you want to convert to.</param>
            /// <returns>true if this converter can perform the conversion; otherwise, false.</returns>
            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            {
                if (destinationType == typeof(InstanceDescriptor)/* || destinationType == typeof(string)*/)
                {
                    return true;
                }
                return base.CanConvertTo(context, destinationType);
            }

            // This code allows the designer to generate the Shape constructor

            /// <summary>
            /// Converts the given value object to the specified type, using the specified context and culture information.
            /// </summary>
            /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
            /// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" />. If null is passed, the current culture is assumed.</param>
            /// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
            /// <param name="destinationType">The <see cref="T:System.Type" /> to convert the <paramref name="value" /> parameter to.</param>
            /// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
            public override object ConvertTo(ITypeDescriptorContext context,
                CultureInfo culture,
                object value,
                Type destinationType)
            {
                
                    if (destinationType == typeof(string))
                    {
                        // Display string in designer
                        return "(Customize)";
                    }
                    else if (destinationType == typeof(InstanceDescriptor) && value is AtomicAnimatorInput)
                    {
                        AtomicAnimatorInput atomicAnimatorInput = (AtomicAnimatorInput)value;

                        if (atomicAnimatorInput.AnimatedProperty == ZeroitAtomEdit.PropertyAnimated.BackColor)
                        {
                            ConstructorInfo ctor = typeof(AtomicAnimatorInput).GetConstructor(new Type[]
                            {

                                typeof(ZeroitAtomEdit.PropertyAnimated),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(System.Drawing.Color),
                                typeof(bool),
                                typeof(float),
                                typeof(ZeroitAtomEdit.Animations),
                                typeof(Control)


                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {
                                    atomicAnimatorInput.animatedProperty,
                                    atomicAnimatorInput.point1X,
                                    atomicAnimatorInput.point1Y,
                                    atomicAnimatorInput.point2X,
                                    atomicAnimatorInput.point2Y,
                                    atomicAnimatorInput.point3X,
                                    atomicAnimatorInput.point3Y,
                                    atomicAnimatorInput.point4X,
                                    atomicAnimatorInput.point4Y,
                                    atomicAnimatorInput.backcolorForProperty,
                                    atomicAnimatorInput.reverse,
                                    atomicAnimatorInput.duration,
                                    atomicAnimatorInput.animations,
                                    atomicAnimatorInput.control

                                });
                            }
                        }

                        else if (atomicAnimatorInput.AnimatedProperty == ZeroitAtomEdit.PropertyAnimated.ForeColor)
                        {
                            ConstructorInfo ctor = typeof(AtomicAnimatorInput).GetConstructor(new Type[] {
                                typeof(ZeroitAtomEdit.PropertyAnimated),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(System.Drawing.Color),
                                typeof(bool),
                                typeof(float),
                                typeof(ZeroitAtomEdit.Animations),
                                typeof(string),
                                typeof(Control)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                    atomicAnimatorInput.animatedProperty,
                                    atomicAnimatorInput.point1X,
                                    atomicAnimatorInput.point1Y,
                                    atomicAnimatorInput.point2X,
                                    atomicAnimatorInput.point2Y,
                                    atomicAnimatorInput.point3X,
                                    atomicAnimatorInput.point3Y,
                                    atomicAnimatorInput.point4X,
                                    atomicAnimatorInput.point4Y,
                                    atomicAnimatorInput.forecolorForProperty,
                                    atomicAnimatorInput.reverse,
                                    atomicAnimatorInput.duration,
                                    atomicAnimatorInput.animations,
                                    atomicAnimatorInput.animationString,
                                    atomicAnimatorInput.control
                                });
                            }
                        }
                        else if (atomicAnimatorInput.AnimatedProperty == ZeroitAtomEdit.PropertyAnimated.Size)
                        {
                            ConstructorInfo ctor = typeof(AtomicAnimatorInput).GetConstructor(new Type[] {
                                
                                
                                typeof(ZeroitAtomEdit.PropertyAnimated),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(System.Drawing.Size),
                                typeof(bool),
                                typeof(float),
                                typeof(ZeroitAtomEdit.Animations),
                                typeof(Control)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {
                                    
                                    atomicAnimatorInput.animatedProperty,
                                    atomicAnimatorInput.point1X,
                                    atomicAnimatorInput.point1Y,
                                    atomicAnimatorInput.point2X,
                                    atomicAnimatorInput.point2Y,
                                    atomicAnimatorInput.point3X,
                                    atomicAnimatorInput.point3Y,
                                    atomicAnimatorInput.point4X,
                                    atomicAnimatorInput.point4Y,
                                    atomicAnimatorInput.controlAnimationSize,
                                    atomicAnimatorInput.reverse,
                                    atomicAnimatorInput.duration,
                                    atomicAnimatorInput.animations,
                                    atomicAnimatorInput.control



                                });
                            }
                        }
                        
                        else if (atomicAnimatorInput.AnimatedProperty == ZeroitAtomEdit.PropertyAnimated.Location)
                        {
                            ConstructorInfo ctor = typeof(AtomicAnimatorInput).GetConstructor(new Type[] {
                                typeof(ZeroitAtomEdit.PropertyAnimated),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(float),
                                typeof(System.Drawing.Point),
                                typeof(bool),
                                typeof(float),
                                typeof(ZeroitAtomEdit.Animations),
                                typeof(Control)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {
                                    atomicAnimatorInput.animatedProperty,
                                    atomicAnimatorInput.point1X,
                                    atomicAnimatorInput.point1Y,
                                    atomicAnimatorInput.point2X,
                                    atomicAnimatorInput.point2Y,
                                    atomicAnimatorInput.point3X,
                                    atomicAnimatorInput.point3Y,
                                    atomicAnimatorInput.point4X,
                                    atomicAnimatorInput.point4Y,
                                    atomicAnimatorInput.controlLocation,
                                    atomicAnimatorInput.reverse,
                                    atomicAnimatorInput.duration,
                                    atomicAnimatorInput.animations,
                                    atomicAnimatorInput.control

                                });
                            }
                        }

                        else if (atomicAnimatorInput.AnimatedProperty == ZeroitAtomEdit.PropertyAnimated.None)
                        {
                            ConstructorInfo ctor = typeof(AtomicAnimatorInput).GetConstructor(new Type[] {
                                typeof(ZeroitAtomEdit.PropertyAnimated),
                                typeof(Control)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {
                                    atomicAnimatorInput.animatedProperty,
                                    atomicAnimatorInput.control

                                });
                            }
                        }

                        else
                        {
                            ConstructorInfo ctor = typeof(AtomicAnimatorInput).GetConstructor(Type.EmptyTypes);
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, null);
                            }
                        }
                    }
              
                return base.ConvertTo(context, culture, value, destinationType);
            }
        }

        #endregion
    }
}
