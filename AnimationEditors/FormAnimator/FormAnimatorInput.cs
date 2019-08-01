// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FormAnimatorInput.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using Zeroit.Framework.Transitions.ZeroitFormAnimator;

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    /// Class FormAnimatorInput.
    /// </summary>
    [TypeConverter(typeof(FormAnimatorConverter))]
    [Editor(typeof(FormAnimatorEditor), typeof(System.Drawing.Design.UITypeEditor))]

    public class FormAnimatorInput
    {

        #region Private Fields

        #region Dummies

        public string dummyString = "";
        public int dummyInt = 0;
        public float dummyFloat = 0f;
        public double dummyDouble = 0D;
        public long dummyLong = 0;
        public short dummyShort = 0;
        public bool dummyBool = false;
        #endregion

        /// <summary>
        /// The animation
        /// </summary>
        private FormAnimationTypes animation = FormAnimationTypes.LeftToRight;

        /// <summary>
        /// The time
        /// </summary>
        Zeroit.Framework.Transitions.ZeroitFormAnimator.Timer time = new Zeroit.Framework.Transitions.ZeroitFormAnimator.Timer();

        /// <summary>
        /// The positions
        /// </summary>
        Positions positions = new Positions();

        /// <summary>
        /// The opacity
        /// </summary>
        Opacity opacity = new Opacity();

        /// <summary>
        /// The grow
        /// </summary>
        Grow grow = new Grow();

        /// <summary>
        /// The move
        /// </summary>
        private Move move = new Move();

        /// <summary>
        /// The locations
        /// </summary>
        Locations locations = new Locations();

        /// <summary>
        /// The shake
        /// </summary>
        Shake shake = new Shake();

        /// <summary>
        /// The move to point
        /// </summary>
        private bool moveToPoint = false;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>The time.</value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Zeroit.Framework.Transitions.ZeroitFormAnimator.Timer Time
        {
            get { return time; }
            set
            {
                time = value;
            }
        }

        /// <summary>
        /// Gets or sets the positions.
        /// </summary>
        /// <value>The positions.</value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Positions Positions
        {
            get { return positions; }
            set
            {
                positions = value;
            }
        }

        /// <summary>
        /// Gets or sets the opacity.
        /// </summary>
        /// <value>The opacity.</value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Opacity Opacity
        {
            get { return opacity; }
            set
            {
                opacity = value;
            }
        }

        /// <summary>
        /// Gets or sets the grow.
        /// </summary>
        /// <value>The grow.</value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Grow Grow
        {
            get { return grow; }
            set
            {
                grow = value;
            }
        }

        /// <summary>
        /// Gets or sets the move.
        /// </summary>
        /// <value>The move.</value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Move Move
        {
            get { return move; }
            set
            {
                move = value;
            }
        }


        /// <summary>
        /// Gets or sets the locations.
        /// </summary>
        /// <value>The locations.</value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Locations Locations
        {
            get { return locations; }
            set
            {
                locations = value;
            }
        }

        /// <summary>
        /// Gets or sets the shake.
        /// </summary>
        /// <value>The shake.</value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Shake Shake
        {
            get { return shake; }
            set
            {
                shake = value;
            }
        }

        /// <summary>
        /// Gets or sets the animation.
        /// </summary>
        /// <value>The animation.</value>
        public FormAnimationTypes Animation
        {
            get { return animation; }
            set
            {
                animation = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [move to point].
        /// </summary>
        /// <value><c>true</c> if [move to point]; otherwise, <c>false</c>.</value>
        public bool MoveToPoint { get => moveToPoint; set => moveToPoint = value; }


        #endregion

        #region Constructor

        public FormAnimatorInput(
            FormAnimationTypes animation,
            Zeroit.Framework.Transitions.ZeroitFormAnimator.Timer time,
            Positions positions,
            Opacity opacity,
            Grow grow,
            Move move,
            Locations locations,
            Shake shake,
            bool moveToPoint
            )
        {
            this.animation = animation;
            this.time = time;
            this.positions = positions;
            this.opacity = opacity;
            this.grow = grow;
            this.move = move;
            this.locations = locations;
            this.shake = shake;
            this.moveToPoint = moveToPoint;

        }

        /// <summary>
        /// Constructor for no Input
        /// </summary>
        public FormAnimatorInput() :
            this(FormAnimationTypes.RightToLeft,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false
                )
        {

        }

        /// <summary>
        /// Initializes a new instance of the Left to Right animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes leftToRight,
            Positions positions,
            ZeroitFormAnimator.Timer time
            ) :
            this(
                FormAnimationTypes.LeftToRight,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = leftToRight;
            this.positions = positions;
            this.time = time;

        }

        /// <summary>
        /// Initializes a new instance of the Right to Left animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes rightToLeft,
            Positions positions,
            ZeroitFormAnimator.Timer time,
            string dummyRightToLeft
            ) :
            this(
                FormAnimationTypes.RightToLeft,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = rightToLeft;
            this.positions = positions;
            this.time = time;

        }

        /// <summary>
        /// Initializes a new instance of the Top to Bottom animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes topToBottom,
            Positions positions,
            ZeroitFormAnimator.Timer time,
            int dummyTopToBottom
            ) :
            this(
                FormAnimationTypes.TopToBottom,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = topToBottom;
            this.positions = positions;
            this.time = time;

        }

        /// <summary>
        /// Initializes a new instance of the Bottom to Top animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes bottomToTop,
            Positions positions,
            ZeroitFormAnimator.Timer time,
            double dummyBottomToTop
            ) :
            this(
                FormAnimationTypes.BottomToTop,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = bottomToTop;
            this.positions = positions;
            this.time = time;

        }

        /// <summary>
        /// Initializes a new instance of the Shrink Horizontal animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes shrinkHorizontal,
            Positions positions,
            ZeroitFormAnimator.Timer time,
            float dummyShrinkHorizontal
            ) :
            this(
                FormAnimationTypes.ShrinkHorizontal,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = shrinkHorizontal;
            this.positions = positions;
            this.time = time;

        }

        /// <summary>
        /// Initializes a new instance of the Shrink Vertical animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes shrinkVertical,
            Positions positions,
            ZeroitFormAnimator.Timer time,
            long dummyShrinkVertical
            ) :
            this(
                FormAnimationTypes.ShrinkHorizontal,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = shrinkVertical;
            this.positions = positions;
            this.time = time;

        }

        /// <summary>
        /// Initializes a new instance of the Shrink XY animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes shrinkXY,
            Positions positions,
            ZeroitFormAnimator.Timer time,
            short dummyShrinkXY
            ) :
            this(
                FormAnimationTypes.ShrinkHorizontal,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = shrinkXY;
            this.positions = positions;
            this.time = time;

        }

        /// <summary>
        /// Initializes a new instance of the Shrink Move XY animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes shrinkMoveXY,
            Positions positions,
            ZeroitFormAnimator.Timer time,
            bool dummyShrinkMoveXY
            ) :
            this(
                FormAnimationTypes.ShrinkHorizontal,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = shrinkMoveXY;
            this.positions = positions;
            this.time = time;

        }

        /// <summary>
        /// Initializes a new instance of the Fade In animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes fadeIn,
            Opacity opacity,
            ZeroitFormAnimator.Timer time            
            ) :
            this(
                FormAnimationTypes.FadeIn,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = fadeIn;
            this.opacity = opacity;
            this.time = time;

        }

        /// <summary>
        /// Initializes a new instance of the Fade Out animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes fadeOut,
            Opacity opacity,
            ZeroitFormAnimator.Timer time,
            string dummy
            ) :
            this(
                FormAnimationTypes.FadeOut,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = fadeOut;
            this.opacity = opacity;
            this.time = time;

        }

        /// <summary>
        /// Initializes a new instance of the Hide Controls animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes hideControls,            
            ZeroitFormAnimator.Timer time            
            ) :
            this(
                FormAnimationTypes.FadeOut,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = hideControls;            
            this.time = time;

        }

        /// <summary>
        /// Initializes a new instance of the Show Controls animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes showControls,
            ZeroitFormAnimator.Timer time,
            string dummy
            ) :
            this(
                FormAnimationTypes.FadeOut,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = showControls;
            this.time = time;

        }

        /// <summary>
        /// Initializes a new instance of the Grow Horizontal animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes growHorizontal,
            Grow grow,
            ZeroitFormAnimator.Timer time            
            ) :
            this(
                FormAnimationTypes.FadeOut,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = growHorizontal;
            this.grow = grow;
            this.time = time;

        }

        /// <summary>
        /// Initializes a new instance of the Grow Vertical animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes growVertical,
            Grow grow,
            ZeroitFormAnimator.Timer time,
            string dummy
            ) :
            this(
                FormAnimationTypes.FadeOut,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = growVertical;
            this.grow = grow;
            this.time = time;

        }

        /// <summary>
        /// Initializes a new instance of the Grow XY animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes growXY,
            Grow grow,
            ZeroitFormAnimator.Timer time,
            int dummy
            ) :
            this(
                FormAnimationTypes.GrowXY,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = growXY;
            this.grow = grow;
            this.time = time;

        }

        /// <summary>
        /// Initializes a new instance of the Grow XY animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes growMoveXY,
            Grow grow,
            ZeroitFormAnimator.Timer time,
            bool dummy
            ) :
            this(
                FormAnimationTypes.GrowMoveXY,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = growMoveXY;
            this.grow = grow;
            this.time = time;

        }

        /// <summary>
        /// Initializes a new instance of the Move animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes moveAnimation,
            Move move,
            ZeroitFormAnimator.Timer time
            ) :
            this(
                FormAnimationTypes.Move,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = moveAnimation;
            this.move = move;
            this.time = time;

        }


        /// <summary>
        /// Initializes a new instance of the Shake animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes shakeAnimation,
            Shake shake,
            ZeroitFormAnimator.Timer time
            ) :
            this(
                FormAnimationTypes.Shake,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = shakeAnimation;
            this.shake = shake;
            this.time = time;

        }

        /// <summary>
        /// Initializes a new instance of the Shrink Fade Out animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes shrinkFadeOut,            
            ZeroitFormAnimator.Timer time,
            bool dummy
            ) :
            this(
                FormAnimationTypes.Shake,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = shrinkFadeOut;            
            this.time = time;

        }

        /// <summary>
        /// Initializes a new instance of the Left To Right Vertical animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes leftToRightVertical,
            ZeroitFormAnimator.Timer time,
            int dummy
            ) :
            this(
                FormAnimationTypes.Shake,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = leftToRightVertical;
            this.time = time;

        }

        /// <summary>
        /// Initializes a new instance of the Shake animation.
        /// </summary>
        public FormAnimatorInput(
            FormAnimationTypes determinerPosition,
            Locations locations,
            ZeroitFormAnimator.Timer time
            ) :
            this(
                FormAnimationTypes.DeterminerPosition,
                new ZeroitFormAnimator.Timer(),
                new Positions(),
                new Opacity(),
                new Grow(),
                new Move(),
                new Locations(),
                new Shake(),
                false)
        {
            this.animation = determinerPosition;
            this.locations = locations;
            this.time = time;

        }
        
        #endregion

        #region Public Methods

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>FormAnimatorInput.</returns>
        public FormAnimatorInput Clone()
        {
            return new FormAnimatorInput(
                animation,
                time,
                positions,
                opacity,
                grow,
                move,
                locations,
                shake,
                moveToPoint
            );
        }

        /// <summary>
        /// Empties this instance.
        /// </summary>
        /// <returns>FormAnimatorInput.</returns>
        public static FormAnimatorInput Empty()
        {
            return new FormAnimatorInput();
        }


        #endregion
                
        #region Editor Brush

        /// <summary>
        /// Gets the UI type editor pen.
        /// </summary>
        /// <param name="bounds">The bounds.</param>
        /// <returns>Pen.</returns>
        internal Pen GetUITypeEditorPen(Rectangle bounds)
        {
            return GetPen(bounds);
        }

        /// <summary>
        /// Get <c>Brush</c> for this fill.
        /// </summary>
        /// <param name="rect">Rectangle area to which fill is to be applied.</param>
        /// <returns>Brush.</returns>
        /// <remarks>The <c>rect</c> parameter only affects the brush if <c>FillerType</c> is <c>LinearGradient</c> or <c>PathGradient</c>.
        /// <para>
        /// The caller is responsible for disposing of the returned brush.
        /// </para></remarks>
        public Pen GetPen(Rectangle rect)
        {
            return GetPen(new RectangleF(rect.X, rect.Y, rect.Width, rect.Height));
        }

        /// <summary>
        /// Get <c>Brush</c> for this fill.
        /// </summary>
        /// <param name="rect">Rectangle area to which fill is to be applied.</param>
        /// <returns>Brush.</returns>
        /// <remarks>The <c>rect</c> parameter only affects the brush if <c>FillerType</c> is <c>LinearGradient</c> or <c>PathGradient</c>.
        /// <para>
        /// The caller is responsible for disposing of the returned brush.
        /// </para></remarks>
        public Pen GetPen(RectangleF rect)
        {
            #region Uncomment
            Color borderColor = Color.Pink;
            //switch (AnimationType)
            //{
            //    case ZeroitVisAnimEdit.GetAnimationType.BottomAnchoredHeightEffect:
            //        return new Pen(borderColor);

            //    case ZeroitVisAnimEdit.GetAnimationType.ColorChannelShiftEffect:
            //        return new Pen(borderColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.ColorShiftEffect:
            //        return new Pen(borderColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.ControlFadeEffect:
            //        return new Pen(borderColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.ControlFadeEffect2:
            //        return new Pen(borderColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.FormFadeEffect:
            //        return new Pen(borderColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.FontSizeEffect:
            //        return new Pen(borderColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.FoldEffect:
            //        return new Pen(borderColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.HorizontalFoldEffect:
            //        return new Pen(borderColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.LeftAnchoredWidthEffect:
            //        return new Pen(borderColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.RightAnchoredWidthEffect:
            //        return new Pen(borderColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.TopAnchoredHeightEffect:
            //        return new Pen(borderColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.VerticalFoldEffect:
            //        return new Pen(borderColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.XLocationEffect:
            //        return new Pen(borderColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.YLocationEffect:
            //        return new Pen(borderColor);
            //    default:
                    return new Pen(borderColor);
            //} 
            #endregion

        }



        /// <summary>
        /// Gets the UI type editor brush.
        /// </summary>
        /// <param name="bounds">The bounds.</param>
        /// <returns>Brush.</returns>
        internal Brush GetUITypeEditorBrush(Rectangle bounds)
        {
            return GetBrush(bounds);
        }

        /// <summary>
        /// Get <c>Brush</c> for this fill.
        /// </summary>
        /// <param name="rect">Rectangle area to which fill is to be applied.</param>
        /// <returns>Brush.</returns>
        /// <remarks>The <c>rect</c> parameter only affects the brush if <c>FillerType</c> is <c>LinearGradient</c> or <c>PathGradient</c>.
        /// <para>
        /// The caller is responsible for disposing of the returned brush.
        /// </para></remarks>
        public Brush GetBrush(Rectangle rect)
        {
            return GetBrush(new RectangleF(rect.X, rect.Y, rect.Width, rect.Height));
        }

        /// <summary>
        /// Get <c>Brush</c> for this fill.
        /// </summary>
        /// <param name="rect">Rectangle area to which fill is to be applied.</param>
        /// <returns>Brush.</returns>
        /// <remarks>The <c>rect</c> parameter only affects the brush if <c>FillerType</c> is <c>LinearGradient</c> or <c>PathGradient</c>.
        /// <para>
        /// The caller is responsible for disposing of the returned brush.
        /// </para></remarks>
        public Brush GetBrush(RectangleF rect)
        {
            Color shapeColor = Color.Aqua;

            #region Uncomment
            //switch (AnimationType)
            //{
            //    case ZeroitVisAnimEdit.GetAnimationType.BottomAnchoredHeightEffect:
            //        return new SolidBrush(shapeColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.ColorChannelShiftEffect:
            //        return new SolidBrush(shapeColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.ColorShiftEffect:
            //        return new SolidBrush(shapeColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.ControlFadeEffect:
            //        return new SolidBrush(shapeColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.ControlFadeEffect2:
            //        return new SolidBrush(shapeColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.FormFadeEffect:
            //        return new SolidBrush(shapeColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.FontSizeEffect:
            //        return new SolidBrush(shapeColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.FoldEffect:
            //        return new SolidBrush(shapeColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.HorizontalFoldEffect:
            //        return new SolidBrush(shapeColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.LeftAnchoredWidthEffect:
            //        return new SolidBrush(shapeColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.RightAnchoredWidthEffect:
            //        return new SolidBrush(shapeColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.TopAnchoredHeightEffect:
            //        return new SolidBrush(shapeColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.VerticalFoldEffect:
            //        return new SolidBrush(shapeColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.XLocationEffect:
            //        return new SolidBrush(shapeColor);
            //    case ZeroitVisAnimEdit.GetAnimationType.YLocationEffect:
            //        return new SolidBrush(shapeColor);
            //    default:
                    return new SolidBrush(shapeColor);
            //} 
            #endregion

        }

        #endregion


    }
}
