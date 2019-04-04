﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Animation.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System.ComponentModel;
using System.Drawing;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.Transitions.AnimatorWithEditor
{
    #region Animation
    /// <summary>
    /// Settings of animation
    /// </summary>
    public class ZeroitAnimate_Animation
    {
        /// <summary>
        /// Gets or sets the slide coeff.
        /// </summary>
        /// <value>The slide coeff.</value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Advanced), TypeConverter(typeof(PointFConverter))]
        public PointF SlideCoeff { get; set; }

        /// <summary>
        /// Gets or sets the rotate coeff.
        /// </summary>
        /// <value>The rotate coeff.</value>
        public float RotateCoeff { get; set; }
        /// <summary>
        /// Gets or sets the rotate limit.
        /// </summary>
        /// <value>The rotate limit.</value>
        public float RotateLimit { get; set; }

        /// <summary>
        /// Gets or sets the scale coeff.
        /// </summary>
        /// <value>The scale coeff.</value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Advanced), TypeConverter(typeof(PointFConverter))]
        public PointF ScaleCoeff { get; set; }

        /// <summary>
        /// Gets or sets the transparency coeff.
        /// </summary>
        /// <value>The transparency coeff.</value>
        public float TransparencyCoeff { get; set; }
        /// <summary>
        /// Gets or sets the leaf coeff.
        /// </summary>
        /// <value>The leaf coeff.</value>
        public float LeafCoeff { get; set; }

        /// <summary>
        /// Gets or sets the mosaic shift.
        /// </summary>
        /// <value>The mosaic shift.</value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Advanced), TypeConverter(typeof(PointFConverter))]
        public PointF MosaicShift { get; set; }

        /// <summary>
        /// Gets or sets the mosaic coeff.
        /// </summary>
        /// <value>The mosaic coeff.</value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Advanced), TypeConverter(typeof(PointFConverter))]
        public PointF MosaicCoeff { get; set; }

        /// <summary>
        /// Gets or sets the size of the mosaic.
        /// </summary>
        /// <value>The size of the mosaic.</value>
        public int MosaicSize { get; set; }

        /// <summary>
        /// Gets or sets the blind coeff.
        /// </summary>
        /// <value>The blind coeff.</value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Advanced), TypeConverter(typeof(PointFConverter))]
        public PointF BlindCoeff { get; set; }

        /// <summary>
        /// Gets or sets the time coeff.
        /// </summary>
        /// <value>The time coeff.</value>
        public float TimeCoeff { get; set; }
        /// <summary>
        /// Gets or sets the minimum time.
        /// </summary>
        /// <value>The minimum time.</value>
        public float MinTime { get; set; }
        /// <summary>
        /// Gets or sets the maximum time.
        /// </summary>
        /// <value>The maximum time.</value>
        public float MaxTime { get; set; }
        /// <summary>
        /// Gets or sets the padding.
        /// </summary>
        /// <value>The padding.</value>
        public Padding Padding { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [animate only differences].
        /// </summary>
        /// <value><c>true</c> if [animate only differences]; otherwise, <c>false</c>.</value>
        public bool AnimateOnlyDifferences { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance is non linear transform needed.
        /// </summary>
        /// <value><c>true</c> if this instance is non linear transform needed; otherwise, <c>false</c>.</value>
        public bool IsNonLinearTransformNeeded
        {
            get
            {
                if (BlindCoeff == PointF.Empty)
                    if (MosaicCoeff == PointF.Empty || MosaicSize == 0)
                        if (TransparencyCoeff == 0f)
                            if (LeafCoeff == 0f)
                                return false;

                return true;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitAnimate_Animation"/> class.
        /// </summary>
        public ZeroitAnimate_Animation()
        {
            MinTime = 0f;
            MaxTime = 1f;
            AnimateOnlyDifferences = true;
        }


        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>ZeroitAnimate_Animation.</returns>
        public ZeroitAnimate_Animation Clone()
        {
            return (ZeroitAnimate_Animation)MemberwiseClone();
        }


        /// <summary>
        /// Gets the rotate.
        /// </summary>
        /// <value>The rotate.</value>
        public static ZeroitAnimate_Animation Rotate { get { return new ZeroitAnimate_Animation { RotateCoeff = 1f, TransparencyCoeff = 1, Padding = new Padding(50, 50, 50, 50) }; } }
        /// <summary>
        /// Gets the horiz slide.
        /// </summary>
        /// <value>The horiz slide.</value>
        public static ZeroitAnimate_Animation HorizSlide { get { return new ZeroitAnimate_Animation { SlideCoeff = new PointF(1, 0) }; } }
        /// <summary>
        /// Gets the vert slide.
        /// </summary>
        /// <value>The vert slide.</value>
        public static ZeroitAnimate_Animation VertSlide { get { return new ZeroitAnimate_Animation { SlideCoeff = new PointF(0, 1) }; } }
        /// <summary>
        /// Gets the scale.
        /// </summary>
        /// <value>The scale.</value>
        public static ZeroitAnimate_Animation Scale { get { return new ZeroitAnimate_Animation { ScaleCoeff = new PointF(1, 1) }; } }
        /// <summary>
        /// Gets the scale and rotate.
        /// </summary>
        /// <value>The scale and rotate.</value>
        public static ZeroitAnimate_Animation ScaleAndRotate { get { return new ZeroitAnimate_Animation { ScaleCoeff = new PointF(1, 1), RotateCoeff = 0.5f, RotateLimit = 0.2f, Padding = new Padding(30, 30, 30, 30) }; } }
        /// <summary>
        /// Gets the horiz slide and rotate.
        /// </summary>
        /// <value>The horiz slide and rotate.</value>
        public static ZeroitAnimate_Animation HorizSlideAndRotate { get { return new ZeroitAnimate_Animation { SlideCoeff = new PointF(1, 0), RotateCoeff = 0.3f, RotateLimit = 0.2f, Padding = new Padding(50, 50, 50, 50) }; } }
        /// <summary>
        /// Gets the scale and horiz slide.
        /// </summary>
        /// <value>The scale and horiz slide.</value>
        public static ZeroitAnimate_Animation ScaleAndHorizSlide { get { return new ZeroitAnimate_Animation { ScaleCoeff = new PointF(1, 1), SlideCoeff = new PointF(1, 0), Padding = new Padding(30, 0, 0, 0) }; } }
        /// <summary>
        /// Gets the transparent.
        /// </summary>
        /// <value>The transparent.</value>
        public static ZeroitAnimate_Animation Transparent { get { return new ZeroitAnimate_Animation { TransparencyCoeff = 1 }; } }
        /// <summary>
        /// Gets the leaf.
        /// </summary>
        /// <value>The leaf.</value>
        public static ZeroitAnimate_Animation Leaf { get { return new ZeroitAnimate_Animation { LeafCoeff = 1 }; } }
        /// <summary>
        /// Gets the mosaic.
        /// </summary>
        /// <value>The mosaic.</value>
        public static ZeroitAnimate_Animation Mosaic { get { return new ZeroitAnimate_Animation { MosaicCoeff = new PointF(100f, 100f), MosaicSize = 20, Padding = new Padding(30, 30, 30, 30) }; } }
        /// <summary>
        /// Gets the particles.
        /// </summary>
        /// <value>The particles.</value>
        public static ZeroitAnimate_Animation Particles { get { return new ZeroitAnimate_Animation { MosaicCoeff = new PointF(200, 200), MosaicSize = 1, MosaicShift = new PointF(0, 0.5f), Padding = new Padding(100, 50, 100, 150), TimeCoeff = 2 }; } }
        /// <summary>
        /// Gets the vert blind.
        /// </summary>
        /// <value>The vert blind.</value>
        public static ZeroitAnimate_Animation VertBlind { get { return new ZeroitAnimate_Animation { BlindCoeff = new PointF(0f, 1f) }; } }
        /// <summary>
        /// Gets the horiz blind.
        /// </summary>
        /// <value>The horiz blind.</value>
        public static ZeroitAnimate_Animation HorizBlind { get { return new ZeroitAnimate_Animation { BlindCoeff = new PointF(1f, 0f) }; } }



        /// <summary>
        /// Adds the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        public void Add(ZeroitAnimate_Animation a)
        {
            SlideCoeff = new PointF(SlideCoeff.X + a.SlideCoeff.X, SlideCoeff.Y + a.SlideCoeff.Y);
            RotateCoeff += a.RotateCoeff;
            RotateLimit += a.RotateLimit;
            ScaleCoeff = new PointF(ScaleCoeff.X + a.ScaleCoeff.X, ScaleCoeff.Y + a.ScaleCoeff.Y);
            TransparencyCoeff += a.TransparencyCoeff;
            LeafCoeff += a.LeafCoeff;
            MosaicShift = new PointF(MosaicShift.X + a.MosaicShift.X, MosaicShift.Y + a.MosaicShift.Y);
            MosaicCoeff = new PointF(MosaicCoeff.X + a.MosaicCoeff.X, MosaicCoeff.Y + a.MosaicCoeff.Y);
            MosaicSize += a.MosaicSize;
            BlindCoeff = new PointF(BlindCoeff.X + a.BlindCoeff.X, BlindCoeff.Y + a.BlindCoeff.Y);
            TimeCoeff += a.TimeCoeff;
            Padding += a.Padding;
        }
    }

    /// <summary>
    /// Sets the animation type for <c><see cref="ZeroitAnimatorEdit" /></c> animator.
    /// </summary>
    public enum AnimationType
    {
        /// <summary>
        /// The custom
        /// </summary>
        Custom = 0,
        /// <summary>
        /// The rotate
        /// </summary>
        Rotate,
        /// <summary>
        /// The horiz slide
        /// </summary>
        HorizSlide,
        /// <summary>
        /// The vert slide
        /// </summary>
        VertSlide,
        /// <summary>
        /// The scale
        /// </summary>
        Scale,
        /// <summary>
        /// The scale and rotate
        /// </summary>
        ScaleAndRotate,
        /// <summary>
        /// The horiz slide and rotate
        /// </summary>
        HorizSlideAndRotate,
        /// <summary>
        /// The scale and horiz slide
        /// </summary>
        ScaleAndHorizSlide,
        /// <summary>
        /// The transparent
        /// </summary>
        Transparent,
        /// <summary>
        /// The leaf
        /// </summary>
        Leaf,
        /// <summary>
        /// The mosaic
        /// </summary>
        Mosaic,
        /// <summary>
        /// The particles
        /// </summary>
        Particles,
        /// <summary>
        /// The vert blind
        /// </summary>
        VertBlind,
        /// <summary>
        /// The horiz blind
        /// </summary>
        HorizBlind
    }
    #endregion
}