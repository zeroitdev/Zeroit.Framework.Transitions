﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ZeroitTrackBar.cs" company="Zeroit Dev Technologies">
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

namespace Zeroit.Framework.Transitions._HelpingControls.TrackBar
{
    #region TrackBar
    /// <summary>
    /// Class ZeroitTrackBar.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    [DefaultEvent("ValueChanged")]
    [Designer(typeof(ZeroitTrackBarDesigner))]
    [ToolboxItem(false)]
    public class ZeroitTrackBar : Control
    {

        #region Enums

        /// <summary>
        /// Enum ValueDivisor
        /// </summary>
        public enum ValueDivisor
        {
            /// <summary>
            /// The by1
            /// </summary>
            By1 = 1,
            /// <summary>
            /// The by10
            /// </summary>
            By10 = 10,
            /// <summary>
            /// The by100
            /// </summary>
            By100 = 100,
            /// <summary>
            /// The by1000
            /// </summary>
            By1000 = 1000
        }


        #region Brush Enum
        /// <summary>
        /// The background
        /// </summary>
        private Background background = Background.White;
        /// <summary>
        /// Enum Background
        /// </summary>
        public enum Background
        {
            /// <summary>
            /// The alice blue
            /// </summary>
            AliceBlue,
            /// <summary>
            /// The antique white
            /// </summary>
            AntiqueWhite,
            /// <summary>
            /// The aqua
            /// </summary>
            Aqua,
            /// <summary>
            /// The aquamarine
            /// </summary>
            Aquamarine,
            /// <summary>
            /// The azure
            /// </summary>
            Azure,
            /// <summary>
            /// The beige
            /// </summary>
            Beige,
            /// <summary>
            /// The bisque
            /// </summary>
            Bisque,
            /// <summary>
            /// The black
            /// </summary>
            Black,
            /// <summary>
            /// The blanched almond
            /// </summary>
            BlanchedAlmond,
            /// <summary>
            /// The blue
            /// </summary>
            Blue,
            /// <summary>
            /// The blue violet
            /// </summary>
            BlueViolet,
            /// <summary>
            /// The brown
            /// </summary>
            Brown,
            /// <summary>
            /// The burly wood
            /// </summary>
            BurlyWood,
            /// <summary>
            /// The cadet blue
            /// </summary>
            CadetBlue,
            /// <summary>
            /// The chartreuse
            /// </summary>
            Chartreuse,
            /// <summary>
            /// The chocolate
            /// </summary>
            Chocolate,
            /// <summary>
            /// The coral
            /// </summary>
            Coral,
            /// <summary>
            /// The cornflower blue
            /// </summary>
            CornflowerBlue,
            /// <summary>
            /// The cornsilk
            /// </summary>
            Cornsilk,
            /// <summary>
            /// The crimson
            /// </summary>
            Crimson,
            /// <summary>
            /// The cyan
            /// </summary>
            Cyan,
            /// <summary>
            /// The dark blue
            /// </summary>
            DarkBlue,
            /// <summary>
            /// The dark cyan
            /// </summary>
            DarkCyan,
            /// <summary>
            /// The dark goldenrod
            /// </summary>
            DarkGoldenrod,
            /// <summary>
            /// The dark gray
            /// </summary>
            DarkGray,
            /// <summary>
            /// The dark green
            /// </summary>
            DarkGreen,
            /// <summary>
            /// The dark khaki
            /// </summary>
            DarkKhaki,
            /// <summary>
            /// The dark magenta
            /// </summary>
            DarkMagenta,
            /// <summary>
            /// The dark olive green
            /// </summary>
            DarkOliveGreen,
            /// <summary>
            /// The dark orange
            /// </summary>
            DarkOrange,
            /// <summary>
            /// The dark orchid
            /// </summary>
            DarkOrchid,
            /// <summary>
            /// The dark red
            /// </summary>
            DarkRed,
            /// <summary>
            /// The dark salmon
            /// </summary>
            DarkSalmon,
            /// <summary>
            /// The dark sea green
            /// </summary>
            DarkSeaGreen,
            /// <summary>
            /// The dark slate blue
            /// </summary>
            DarkSlateBlue,
            /// <summary>
            /// The dark slate gray
            /// </summary>
            DarkSlateGray,
            /// <summary>
            /// The dark turquoise
            /// </summary>
            DarkTurquoise,
            /// <summary>
            /// The dark violet
            /// </summary>
            DarkViolet,
            /// <summary>
            /// The deep pink
            /// </summary>
            DeepPink,
            /// <summary>
            /// The deep sky blue
            /// </summary>
            DeepSkyBlue,
            /// <summary>
            /// The dim gray
            /// </summary>
            DimGray,
            /// <summary>
            /// The dodger blue
            /// </summary>
            DodgerBlue,
            /// <summary>
            /// The firebrick
            /// </summary>
            Firebrick,
            /// <summary>
            /// The floral white
            /// </summary>
            FloralWhite,
            /// <summary>
            /// The forest green
            /// </summary>
            ForestGreen,
            /// <summary>
            /// The fuchsia
            /// </summary>
            Fuchsia,
            /// <summary>
            /// The gainsboro
            /// </summary>
            Gainsboro,
            /// <summary>
            /// The ghost white
            /// </summary>
            GhostWhite,
            /// <summary>
            /// The gold
            /// </summary>
            Gold,
            /// <summary>
            /// The goldenrod
            /// </summary>
            Goldenrod,
            /// <summary>
            /// The gray
            /// </summary>
            Gray,
            /// <summary>
            /// The green
            /// </summary>
            Green,
            /// <summary>
            /// The green yellow
            /// </summary>
            GreenYellow,
            /// <summary>
            /// The honeydew
            /// </summary>
            Honeydew,
            /// <summary>
            /// The hot pink
            /// </summary>
            HotPink,
            /// <summary>
            /// The indian red
            /// </summary>
            IndianRed,
            /// <summary>
            /// The indigo
            /// </summary>
            Indigo,
            /// <summary>
            /// The ivory
            /// </summary>
            Ivory,
            /// <summary>
            /// The khaki
            /// </summary>
            Khaki,
            /// <summary>
            /// The lavender
            /// </summary>
            Lavender,
            /// <summary>
            /// The lavender blush
            /// </summary>
            LavenderBlush,
            /// <summary>
            /// The lawn green
            /// </summary>
            LawnGreen,
            /// <summary>
            /// The lemon chiffon
            /// </summary>
            LemonChiffon,
            /// <summary>
            /// The light blue
            /// </summary>
            LightBlue,
            /// <summary>
            /// The light coral
            /// </summary>
            LightCoral,
            /// <summary>
            /// The light cyan
            /// </summary>
            LightCyan,
            /// <summary>
            /// The light goldenrod yellow
            /// </summary>
            LightGoldenrodYellow,
            /// <summary>
            /// The light gray
            /// </summary>
            LightGray,
            /// <summary>
            /// The light green
            /// </summary>
            LightGreen,
            /// <summary>
            /// The light pink
            /// </summary>
            LightPink,
            /// <summary>
            /// The light salmon
            /// </summary>
            LightSalmon,
            /// <summary>
            /// The light sea green
            /// </summary>
            LightSeaGreen,
            /// <summary>
            /// The light sky blue
            /// </summary>
            LightSkyBlue,
            /// <summary>
            /// The light slate gray
            /// </summary>
            LightSlateGray,
            /// <summary>
            /// The light steel blue
            /// </summary>
            LightSteelBlue,
            /// <summary>
            /// The light yellow
            /// </summary>
            LightYellow,
            /// <summary>
            /// The lime
            /// </summary>
            Lime,
            /// <summary>
            /// The lime green
            /// </summary>
            LimeGreen,
            /// <summary>
            /// The linen
            /// </summary>
            Linen,
            /// <summary>
            /// The magenta
            /// </summary>
            Magenta,
            /// <summary>
            /// The maroon
            /// </summary>
            Maroon,
            /// <summary>
            /// The medium aquamarine
            /// </summary>
            MediumAquamarine,
            /// <summary>
            /// The medium blue
            /// </summary>
            MediumBlue,
            /// <summary>
            /// The medium orchid
            /// </summary>
            MediumOrchid,
            /// <summary>
            /// The medium purple
            /// </summary>
            MediumPurple,
            /// <summary>
            /// The medium sea green
            /// </summary>
            MediumSeaGreen,
            /// <summary>
            /// The medium slate blue
            /// </summary>
            MediumSlateBlue,
            /// <summary>
            /// The medium spring green
            /// </summary>
            MediumSpringGreen,
            /// <summary>
            /// The medium turquoise
            /// </summary>
            MediumTurquoise,
            /// <summary>
            /// The medium violet red
            /// </summary>
            MediumVioletRed,
            /// <summary>
            /// The midnight blue
            /// </summary>
            MidnightBlue,
            /// <summary>
            /// The mint cream
            /// </summary>
            MintCream,
            /// <summary>
            /// The misty rose
            /// </summary>
            MistyRose,
            /// <summary>
            /// The moccasin
            /// </summary>
            Moccasin,
            /// <summary>
            /// The navajo white
            /// </summary>
            NavajoWhite,
            /// <summary>
            /// The navy
            /// </summary>
            Navy,
            /// <summary>
            /// The old lace
            /// </summary>
            OldLace,
            /// <summary>
            /// The olive
            /// </summary>
            Olive,
            /// <summary>
            /// The olive drab
            /// </summary>
            OliveDrab,
            /// <summary>
            /// The orange
            /// </summary>
            Orange,
            /// <summary>
            /// The orange red
            /// </summary>
            OrangeRed,
            /// <summary>
            /// The orchid
            /// </summary>
            Orchid,
            /// <summary>
            /// The pale goldenrod
            /// </summary>
            PaleGoldenrod,
            /// <summary>
            /// The pale green
            /// </summary>
            PaleGreen,
            /// <summary>
            /// The pale turquoise
            /// </summary>
            PaleTurquoise,
            /// <summary>
            /// The pale violet red
            /// </summary>
            PaleVioletRed,
            /// <summary>
            /// The papaya whip
            /// </summary>
            PapayaWhip,
            /// <summary>
            /// The peach puff
            /// </summary>
            PeachPuff,
            /// <summary>
            /// The peru
            /// </summary>
            Peru,
            /// <summary>
            /// The pink
            /// </summary>
            Pink,
            /// <summary>
            /// The plum
            /// </summary>
            Plum,
            /// <summary>
            /// The powder blue
            /// </summary>
            PowderBlue,
            /// <summary>
            /// The purple
            /// </summary>
            Purple,
            /// <summary>
            /// The red
            /// </summary>
            Red,
            /// <summary>
            /// The rosy brown
            /// </summary>
            RosyBrown,
            /// <summary>
            /// The royal blue
            /// </summary>
            RoyalBlue,
            /// <summary>
            /// The saddle brown
            /// </summary>
            SaddleBrown,
            /// <summary>
            /// The salmon
            /// </summary>
            Salmon,
            /// <summary>
            /// The sandy brown
            /// </summary>
            SandyBrown,
            /// <summary>
            /// The sea green
            /// </summary>
            SeaGreen,
            /// <summary>
            /// The sea shell
            /// </summary>
            SeaShell,
            /// <summary>
            /// The sienna
            /// </summary>
            Sienna,
            /// <summary>
            /// The silver
            /// </summary>
            Silver,
            /// <summary>
            /// The sky blue
            /// </summary>
            SkyBlue,
            /// <summary>
            /// The slate blue
            /// </summary>
            SlateBlue,
            /// <summary>
            /// The slate gray
            /// </summary>
            SlateGray,
            /// <summary>
            /// The snow
            /// </summary>
            Snow,
            /// <summary>
            /// The spring green
            /// </summary>
            SpringGreen,
            /// <summary>
            /// The steel blue
            /// </summary>
            SteelBlue,
            /// <summary>
            /// The tan
            /// </summary>
            Tan,
            /// <summary>
            /// The teal
            /// </summary>
            Teal,
            /// <summary>
            /// The thistle
            /// </summary>
            Thistle,
            /// <summary>
            /// The tomato
            /// </summary>
            Tomato,
            /// <summary>
            /// The transparent
            /// </summary>
            Transparent,
            /// <summary>
            /// The turquoise
            /// </summary>
            Turquoise,
            /// <summary>
            /// The violet
            /// </summary>
            Violet,
            /// <summary>
            /// The wheat
            /// </summary>
            Wheat,
            /// <summary>
            /// The white
            /// </summary>
            White,
            /// <summary>
            /// The white smoke
            /// </summary>
            WhiteSmoke,
            /// <summary>
            /// The yellow green
            /// </summary>
            YellowGreen
        }

        #endregion


        #region HatchBrush

        /// <summary>
        /// The hatch brushgradient1
        /// </summary>
        private Color hatchBrushgradient1 = Color.Black;
        /// <summary>
        /// The hatch brushgradient2
        /// </summary>
        private Color hatchBrushgradient2 = Color.Transparent;

        /// <summary>
        /// The hatch brush type
        /// </summary>
        private HatchBrushType hatchBrushType = HatchBrushType.ForwardDiagonal;

        /// <summary>
        /// Enum HatchBrushType
        /// </summary>
        public enum HatchBrushType
        {
            /// <summary>
            /// The backward diagonal
            /// </summary>
            BackwardDiagonal,
            /// <summary>
            /// The cross
            /// </summary>
            Cross,
            /// <summary>
            /// The dark downward diagonal
            /// </summary>
            DarkDownwardDiagonal,
            /// <summary>
            /// The dark horizontal
            /// </summary>
            DarkHorizontal,
            /// <summary>
            /// The dark upward diagonal
            /// </summary>
            DarkUpwardDiagonal,
            /// <summary>
            /// The dark vertical
            /// </summary>
            DarkVertical,
            /// <summary>
            /// The dashed downward diagonal
            /// </summary>
            DashedDownwardDiagonal,
            /// <summary>
            /// The dashed horizontal
            /// </summary>
            DashedHorizontal,
            /// <summary>
            /// The dashed upward diagonal
            /// </summary>
            DashedUpwardDiagonal,
            /// <summary>
            /// The dashed vertical
            /// </summary>
            DashedVertical,
            /// <summary>
            /// The diagonal brick
            /// </summary>
            DiagonalBrick,
            /// <summary>
            /// The diagonal cross
            /// </summary>
            DiagonalCross,
            /// <summary>
            /// The divot
            /// </summary>
            Divot,
            /// <summary>
            /// The dotted diamond
            /// </summary>
            DottedDiamond,
            /// <summary>
            /// The dotted grid
            /// </summary>
            DottedGrid,
            /// <summary>
            /// The forward diagonal
            /// </summary>
            ForwardDiagonal,
            /// <summary>
            /// The horizontal
            /// </summary>
            Horizontal,
            /// <summary>
            /// The horizontal brick
            /// </summary>
            HorizontalBrick,
            /// <summary>
            /// The large checker board
            /// </summary>
            LargeCheckerBoard,
            /// <summary>
            /// The large confetti
            /// </summary>
            LargeConfetti,
            /// <summary>
            /// The large grid
            /// </summary>
            LargeGrid,
            /// <summary>
            /// The light downward diagonal
            /// </summary>
            LightDownwardDiagonal,
            /// <summary>
            /// The light horizontal
            /// </summary>
            LightHorizontal,
            /// <summary>
            /// The light upward diagonal
            /// </summary>
            LightUpwardDiagonal,
            /// <summary>
            /// The light vertical
            /// </summary>
            LightVertical,
            /// <summary>
            /// The maximum
            /// </summary>
            Max,
            /// <summary>
            /// The minimum
            /// </summary>
            Min,
            /// <summary>
            /// The narrow horizontal
            /// </summary>
            NarrowHorizontal,
            /// <summary>
            /// The narrow vertical
            /// </summary>
            NarrowVertical,
            /// <summary>
            /// The outlined diamond
            /// </summary>
            OutlinedDiamond,
            /// <summary>
            /// The percent05
            /// </summary>
            Percent05,
            /// <summary>
            /// The percent10
            /// </summary>
            Percent10,
            /// <summary>
            /// The percent20
            /// </summary>
            Percent20,
            /// <summary>
            /// The percent25
            /// </summary>
            Percent25,
            /// <summary>
            /// The percent30
            /// </summary>
            Percent30,
            /// <summary>
            /// The percent40
            /// </summary>
            Percent40,
            /// <summary>
            /// The percent50
            /// </summary>
            Percent50,
            /// <summary>
            /// The percent60
            /// </summary>
            Percent60,
            /// <summary>
            /// The percent70
            /// </summary>
            Percent70,
            /// <summary>
            /// The percent75
            /// </summary>
            Percent75,
            /// <summary>
            /// The percent80
            /// </summary>
            Percent80,
            /// <summary>
            /// The percent90
            /// </summary>
            Percent90,
            /// <summary>
            /// The plaid
            /// </summary>
            Plaid,
            /// <summary>
            /// The shingle
            /// </summary>
            Shingle,
            /// <summary>
            /// The small checker board
            /// </summary>
            SmallCheckerBoard,
            /// <summary>
            /// The small confetti
            /// </summary>
            SmallConfetti,
            /// <summary>
            /// The small grid
            /// </summary>
            SmallGrid,
            /// <summary>
            /// The solid diamond
            /// </summary>
            SolidDiamond,
            /// <summary>
            /// The sphere
            /// </summary>
            Sphere,
            /// <summary>
            /// The trellis
            /// </summary>
            Trellis,
            /// <summary>
            /// The vertical
            /// </summary>
            Vertical,
            /// <summary>
            /// The wave
            /// </summary>
            Wave,
            /// <summary>
            /// The weave
            /// </summary>
            Weave,
            /// <summary>
            /// The wide downward diagonal
            /// </summary>
            WideDownwardDiagonal,
            /// <summary>
            /// The wide upward diagonal
            /// </summary>
            WideUpwardDiagonal,
            /// <summary>
            /// The zig zag
            /// </summary>
            ZigZag
        }
        #endregion


        #endregion
        #region Variables

        /// <summary>
        /// The pipe border
        /// </summary>
        private GraphicsPath PipeBorder;
        /// <summary>
        /// The track bar handle
        /// </summary>
        private GraphicsPath TrackBarHandle;
        /// <summary>
        /// The track bar handle rect
        /// </summary>
        private Rectangle TrackBarHandleRect;
        /// <summary>
        /// The value rect
        /// </summary>
        private Rectangle ValueRect;
        /// <summary>
        /// The vlaue LGB
        /// </summary>
        private LinearGradientBrush VlaueLGB;
        /// <summary>
        /// The track bar handle LGB
        /// </summary>
        private LinearGradientBrush TrackBarHandleLGB;
        /// <summary>
        /// The cap
        /// </summary>
        private bool Cap;

        /// <summary>
        /// The value drawer
        /// </summary>
        private int ValueDrawer;
        /// <summary>
        /// The minimum
        /// </summary>
        private int _Minimum = 0;
        /// <summary>
        /// The maximum
        /// </summary>
        private int _Maximum = 10;
        /// <summary>
        /// The value
        /// </summary>
        private int _Value = 0;
        /// <summary>
        /// The value colour1
        /// </summary>
        private Color _ValueColour1 = Color.FromArgb(224, 224, 224);
        /// <summary>
        /// The value colour2
        /// </summary>
        private Color _ValueColour2 = Color.FromArgb(224, 224, 224);
        /// <summary>
        /// The border
        /// </summary>
        private Color _border = Color.FromArgb(180, 180, 180);
        /// <summary>
        /// The draw hatch
        /// </summary>
        private bool _DrawHatch = true;
        /// <summary>
        /// The draw value string
        /// </summary>
        private bool _DrawValueString = false;
        /// <summary>
        /// The jump to mouse
        /// </summary>
        private bool _JumpToMouse = false;
        /// <summary>
        /// The divided value
        /// </summary>
        private ValueDivisor DividedValue = ValueDivisor.By1;
        /// <summary>
        /// The string position
        /// </summary>
        private float stringPosition = 0f;

        /// <summary>
        /// The track bar handle color1
        /// </summary>
        private Color trackBarHandleColor1 = SystemColors.Control;
        /// <summary>
        /// The track bar handle color2
        /// </summary>
        private Color trackBarHandleColor2 = SystemColors.Control;
        /// <summary>
        /// The track bar handle border
        /// </summary>
        private Color trackBarHandleBorder = Color.Gray;
        /// <summary>
        /// The percent symbol
        /// </summary>
        private string percentSymbol = "%";

        #endregion
        #region Custom Properties
        /// <summary>
        /// Gets or sets the color value colour1.
        /// </summary>
        /// <value>The color value colour1.</value>
        public Color ColorValueColour1
        {
            get { return _ValueColour1; }
            set
            {
                _ValueColour1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color value colour2.
        /// </summary>
        /// <value>The color value colour2.</value>
        public Color ColorValueColour2
        {
            get { return _ValueColour2; }
            set
            {
                _ValueColour2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color border.
        /// </summary>
        /// <value>The color border.</value>
        public Color ColorBorder
        {
            get { return _border; }
            set
            {
                _border = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color track bar handle color1.
        /// </summary>
        /// <value>The color track bar handle color1.</value>
        public Color ColorTrackBarHandleColor1
        {
            get { return trackBarHandleColor1; }
            set
            {
                trackBarHandleColor1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color track bar handle color2.
        /// </summary>
        /// <value>The color track bar handle color2.</value>
        public Color ColorTrackBarHandleColor2
        {
            get { return trackBarHandleColor2; }
            set
            {
                trackBarHandleColor2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color track bar handle border.
        /// </summary>
        /// <value>The color track bar handle border.</value>
        public Color ColorTrackBarHandleBorder
        {
            get { return trackBarHandleBorder; }
            set
            {
                trackBarHandleBorder = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color text.
        /// </summary>
        /// <value>The color text.</value>
        public Background ColorText
        {
            get { return background; }
            set
            {
                background = value;
                Invalidate();
            }
        }


        #region HatchBrush Property

        /// <summary>
        /// Gets or sets the color hatch brushgradient1.
        /// </summary>
        /// <value>The color hatch brushgradient1.</value>
        public Color ColorHatchBrushgradient1
        {
            get { return hatchBrushgradient1; }
            set
            {
                hatchBrushgradient1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color hatch brushgradient2.
        /// </summary>
        /// <value>The color hatch brushgradient2.</value>
        public Color ColorHatchBrushgradient2
        {
            get { return hatchBrushgradient2; }
            set
            {
                hatchBrushgradient2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the hatch brush.
        /// </summary>
        /// <value>The hatch brush.</value>
        public HatchBrushType HatchBrush
        {
            get
            {
                return hatchBrushType;
            }

            set
            {
                hatchBrushType = value;
                Invalidate();
            }
        }
        #endregion

        /// <summary>
        /// Gets or sets the string postion.
        /// </summary>
        /// <value>The string postion.</value>
        public float StringPostion
        {
            get { return stringPosition; }
            set
            {
                stringPosition = value;
                Invalidate();
            }
        }
        /// <summary>
        /// Gets or sets the minimum.
        /// </summary>
        /// <value>The minimum.</value>
        public int Minimum
        {
            get { return _Minimum; }

            set
            {
                if (value >= _Maximum)
                    value = _Maximum - 10;
                if (_Value < value)
                    _Value = value;

                _Minimum = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the maximum.
        /// </summary>
        /// <value>The maximum.</value>
        public int Maximum
        {
            get { return _Maximum; }

            set
            {
                if (value <= _Minimum)
                    value = _Minimum + 10;
                if (_Value > value)
                    _Value = value;

                _Maximum = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Occurs when [value changed].
        /// </summary>
        public event ValueChangedEventHandler ValueChanged;
        /// <summary>
        /// Delegate ValueChangedEventHandler
        /// </summary>
        public delegate void ValueChangedEventHandler();
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public int Value
        {
            get { return _Value; }
            set
            {
                if (_Value != value)
                {
                    if (value < _Minimum)
                    {
                        _Value = _Minimum;
                    }
                    else
                    {
                        if (value > _Maximum)
                        {
                            _Value = _Maximum;
                        }
                        else
                        {
                            _Value = value;
                        }
                    }
                    Invalidate();
                    if (ValueChanged != null)
                    {
                        ValueChanged();
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets the value divison.
        /// </summary>
        /// <value>The value divison.</value>
        public ValueDivisor ValueDivison
        {
            get
            {
                return this.DividedValue;
            }
            set
            {
                this.DividedValue = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the value to set.
        /// </summary>
        /// <value>The value to set.</value>
        [Browsable(false)]
        public float ValueToSet
        {
            get
            {
                return (float)(((double)this._Value) / ((double)this.DividedValue));
            }
            set
            {
                this.Value = (int)Math.Round((double)(value * ((float)this.DividedValue)));
            }
        }


        /// <summary>
        /// Gets or sets a value indicating whether [draw hatch].
        /// </summary>
        /// <value><c>true</c> if [draw hatch]; otherwise, <c>false</c>.</value>
        public bool DrawHatch
        {
            get { return _DrawHatch; }
            set
            {
                _DrawHatch = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [draw value string].
        /// </summary>
        /// <value><c>true</c> if [draw value string]; otherwise, <c>false</c>.</value>
        public bool DrawValueString
        {
            get { return _DrawValueString; }
            set
            {
                _DrawValueString = value;
                if (_DrawValueString == true)
                {
                    Height = 40;

                }
                else
                {
                    Height = 22;
                }
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [jump to mouse].
        /// </summary>
        /// <value><c>true</c> if [jump to mouse]; otherwise, <c>false</c>.</value>
        public bool JumpToMouse
        {
            get
            {
                return this._JumpToMouse;
            }
            set
            {
                this._JumpToMouse = value;
            }
        }

        /// <summary>
        /// Gets or sets the percent symbol.
        /// </summary>
        /// <value>The percent symbol.</value>
        public String PercentSymbol
        {
            get { return percentSymbol; }
            set
            {
                percentSymbol = value;
                Invalidate();
            }
        }

        #endregion
        #region EventArgs

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseMove" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if ((this.Cap && (e.X > -1)) && (e.X < (this.Width + 1)))
            {
                this.Value = this._Minimum + ((int)Math.Round((double)((this._Maximum - this._Minimum) * (((double)e.X) / ((double)this.Width)))));
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseDown" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.ValueDrawer = (int)Math.Round((double)((((double)(this._Value - this._Minimum)) / ((double)(this._Maximum - this._Minimum))) * (this.Width - 11)));
                this.TrackBarHandleRect = new Rectangle(this.ValueDrawer, 0, 10, 20);
                this.Cap = this.TrackBarHandleRect.Contains(e.Location);
                if (this._JumpToMouse)
                {
                    this.Value = this._Minimum + ((int)Math.Round((double)((this._Maximum - this._Minimum) * (((double)e.X) / ((double)this.Width)))));
                }
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseUp" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            this.Cap = false;
        }


        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitTrackBar"/> class.
        /// </summary>
        public ZeroitTrackBar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            _DrawHatch = true;
            Size = new Size(80, 22);
            MinimumSize = new Size(37, 22);

        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Resize" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (_DrawValueString == true)
            {
                Height = 40;
            }
            else
            {
                Height = 22;
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics G = e.Graphics;
            HatchBrush Hatch = new HatchBrush(HatchStyle.WideDownwardDiagonal, Color.FromArgb(20, Color.Black), Color.Transparent);
            //G.Clear(Parent.BackColor);
            G.SmoothingMode = SmoothingMode.HighQuality;
            checked
            {
                this.PipeBorder = RoundRectangle.RoundRect(1, 6, this.Width - 3, 8, 3);
                try
                {
                    this.ValueDrawer = (int)Math.Round(unchecked(checked((double)(this._Value - this._Minimum) / (double)(this._Maximum - this._Minimum)) * (double)checked(this.Width - 11)));
                }
                catch (Exception)
                {
                }
                this.TrackBarHandleRect = new Rectangle(this.ValueDrawer, 0, 10, 20);
                G.SetClip(this.PipeBorder);
                this.ValueRect = new Rectangle(1, 7, this.TrackBarHandleRect.X + this.TrackBarHandleRect.Width - 2, 7);
                this.VlaueLGB = new LinearGradientBrush(this.ValueRect, this._ValueColour1, this._ValueColour2, 90f);
                G.FillRectangle(this.VlaueLGB, this.ValueRect);

                if (_DrawHatch == true)
                {

                    #region HatchBrush Paint
                    switch (hatchBrushType)
                    {
                        case HatchBrushType.BackwardDiagonal:
                            HatchBrush HB = new HatchBrush(HatchStyle.BackwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB, this.ValueRect);
                            break;
                        case HatchBrushType.Cross:
                            HatchBrush HB1 = new HatchBrush(HatchStyle.Cross, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB1, this.ValueRect);
                            break;
                        case HatchBrushType.DarkDownwardDiagonal:
                            HatchBrush HB2 = new HatchBrush(HatchStyle.DarkDownwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB2, this.ValueRect);
                            break;
                        case HatchBrushType.DarkHorizontal:
                            HatchBrush HB3 = new HatchBrush(HatchStyle.DarkHorizontal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB3, this.ValueRect);
                            break;
                        case HatchBrushType.DarkUpwardDiagonal:
                            HatchBrush HB4 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB4, this.ValueRect);
                            break;
                        case HatchBrushType.DarkVertical:
                            HatchBrush HB5 = new HatchBrush(HatchStyle.DarkVertical, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB5, this.ValueRect);
                            break;
                        case HatchBrushType.DashedDownwardDiagonal:
                            HatchBrush HB6 = new HatchBrush(HatchStyle.DashedDownwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB6, this.ValueRect);
                            break;
                        case HatchBrushType.DashedHorizontal:
                            HatchBrush HB7 = new HatchBrush(HatchStyle.DashedHorizontal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB7, this.ValueRect);
                            break;
                        case HatchBrushType.DashedUpwardDiagonal:
                            HatchBrush HB8 = new HatchBrush(HatchStyle.DashedUpwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB8, this.ValueRect);
                            break;
                        case HatchBrushType.DashedVertical:
                            HatchBrush HB9 = new HatchBrush(HatchStyle.DashedVertical, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB9, this.ValueRect);
                            break;
                        case HatchBrushType.DiagonalBrick:
                            HatchBrush HBA = new HatchBrush(HatchStyle.DiagonalBrick, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBA, this.ValueRect);
                            break;
                        case HatchBrushType.DiagonalCross:
                            HatchBrush HBB = new HatchBrush(HatchStyle.DiagonalCross, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBB, this.ValueRect);
                            break;
                        case HatchBrushType.Divot:
                            HatchBrush HBC = new HatchBrush(HatchStyle.Divot, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBC, this.ValueRect);
                            break;
                        case HatchBrushType.DottedDiamond:
                            HatchBrush HBD = new HatchBrush(HatchStyle.DottedDiamond, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBD, this.ValueRect);
                            break;
                        case HatchBrushType.DottedGrid:
                            HatchBrush HBE = new HatchBrush(HatchStyle.DottedGrid, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBE, this.ValueRect);
                            break;
                        case HatchBrushType.ForwardDiagonal:
                            HatchBrush HBF = new HatchBrush(HatchStyle.ForwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBF, this.ValueRect);
                            break;
                        case HatchBrushType.Horizontal:
                            HatchBrush HBG = new HatchBrush(HatchStyle.Horizontal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBG, this.ValueRect);
                            break;
                        case HatchBrushType.HorizontalBrick:
                            HatchBrush HBH = new HatchBrush(HatchStyle.HorizontalBrick, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBH, this.ValueRect);
                            break;
                        case HatchBrushType.LargeCheckerBoard:
                            HatchBrush HBI = new HatchBrush(HatchStyle.LargeCheckerBoard, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBI, this.ValueRect);
                            break;
                        case HatchBrushType.LargeConfetti:
                            HatchBrush HBJ = new HatchBrush(HatchStyle.LargeConfetti, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBJ, this.ValueRect);
                            break;
                        case HatchBrushType.LargeGrid:
                            HatchBrush HBK = new HatchBrush(HatchStyle.LargeGrid, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBK, this.ValueRect);
                            break;
                        case HatchBrushType.LightDownwardDiagonal:
                            HatchBrush HBL = new HatchBrush(HatchStyle.LightDownwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBL, this.ValueRect);
                            break;
                        case HatchBrushType.LightHorizontal:
                            HatchBrush HBM = new HatchBrush(HatchStyle.LightHorizontal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBM, this.ValueRect);
                            break;
                        case HatchBrushType.LightUpwardDiagonal:
                            HatchBrush HBN = new HatchBrush(HatchStyle.LightUpwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBN, this.ValueRect);
                            break;
                        case HatchBrushType.LightVertical:
                            HatchBrush HBO = new HatchBrush(HatchStyle.LightVertical, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBO, this.ValueRect);
                            break;
                        case HatchBrushType.Max:
                            HatchBrush HBP = new HatchBrush(HatchStyle.Max, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBP, this.ValueRect);
                            break;
                        case HatchBrushType.Min:
                            HatchBrush HBQ = new HatchBrush(HatchStyle.Min, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBQ, this.ValueRect);
                            break;
                        case HatchBrushType.NarrowHorizontal:
                            HatchBrush HBR = new HatchBrush(HatchStyle.NarrowHorizontal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBR, this.ValueRect);
                            break;
                        case HatchBrushType.NarrowVertical:
                            HatchBrush HBS = new HatchBrush(HatchStyle.NarrowVertical, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBS, this.ValueRect);
                            break;
                        case HatchBrushType.OutlinedDiamond:
                            HatchBrush HBT = new HatchBrush(HatchStyle.OutlinedDiamond, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBT, this.ValueRect);
                            break;
                        case HatchBrushType.Percent05:
                            HatchBrush HBU = new HatchBrush(HatchStyle.Percent05, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBU, this.ValueRect);
                            break;
                        case HatchBrushType.Percent10:
                            HatchBrush HBV = new HatchBrush(HatchStyle.Percent10, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBV, this.ValueRect);
                            break;
                        case HatchBrushType.Percent20:
                            HatchBrush HBW = new HatchBrush(HatchStyle.Percent20, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBW, this.ValueRect);
                            break;
                        case HatchBrushType.Percent25:
                            HatchBrush HBX = new HatchBrush(HatchStyle.Percent25, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBX, this.ValueRect);
                            break;
                        case HatchBrushType.Percent30:
                            HatchBrush HBY = new HatchBrush(HatchStyle.Percent30, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBY, this.ValueRect);
                            break;
                        case HatchBrushType.Percent40:
                            HatchBrush HBZ = new HatchBrush(HatchStyle.Percent40, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBZ, this.ValueRect);
                            break;
                        case HatchBrushType.Percent50:
                            HatchBrush HB10 = new HatchBrush(HatchStyle.Percent50, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB10, this.ValueRect);
                            break;
                        case HatchBrushType.Percent60:
                            HatchBrush HB11 = new HatchBrush(HatchStyle.Percent60, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB11, this.ValueRect);
                            break;
                        case HatchBrushType.Percent70:
                            HatchBrush HB12 = new HatchBrush(HatchStyle.Percent70, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB12, this.ValueRect);
                            break;
                        case HatchBrushType.Percent75:
                            HatchBrush HB13 = new HatchBrush(HatchStyle.Percent75, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB13, this.ValueRect);
                            break;
                        case HatchBrushType.Percent80:
                            HatchBrush HB14 = new HatchBrush(HatchStyle.Percent80, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB14, this.ValueRect);
                            break;
                        case HatchBrushType.Percent90:
                            HatchBrush HB15 = new HatchBrush(HatchStyle.Percent90, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB15, this.ValueRect);
                            break;
                        case HatchBrushType.Plaid:
                            HatchBrush HB16 = new HatchBrush(HatchStyle.Plaid, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB16, this.ValueRect);
                            break;
                        case HatchBrushType.Shingle:
                            HatchBrush HB17 = new HatchBrush(HatchStyle.Shingle, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB17, this.ValueRect);
                            break;
                        case HatchBrushType.SmallCheckerBoard:
                            HatchBrush HB18 = new HatchBrush(HatchStyle.SmallCheckerBoard, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB18, this.ValueRect);
                            break;
                        case HatchBrushType.SmallConfetti:
                            HatchBrush HB19 = new HatchBrush(HatchStyle.SmallConfetti, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB19, this.ValueRect);
                            break;
                        case HatchBrushType.SmallGrid:
                            HatchBrush HB20 = new HatchBrush(HatchStyle.SmallGrid, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB20, this.ValueRect);
                            break;
                        case HatchBrushType.SolidDiamond:
                            HatchBrush HB21 = new HatchBrush(HatchStyle.SolidDiamond, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB21, this.ValueRect);
                            break;
                        case HatchBrushType.Sphere:
                            HatchBrush HB22 = new HatchBrush(HatchStyle.Sphere, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB22, this.ValueRect);
                            break;
                        case HatchBrushType.Trellis:
                            HatchBrush HB23 = new HatchBrush(HatchStyle.Trellis, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB23, this.ValueRect);
                            break;
                        case HatchBrushType.Vertical:
                            HatchBrush HB24 = new HatchBrush(HatchStyle.Vertical, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB24, this.ValueRect);
                            break;
                        case HatchBrushType.Wave:
                            HatchBrush HB25 = new HatchBrush(HatchStyle.Wave, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB25, this.ValueRect);
                            break;
                        case HatchBrushType.Weave:
                            HatchBrush HB26 = new HatchBrush(HatchStyle.Weave, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB26, this.ValueRect);
                            break;
                        case HatchBrushType.WideDownwardDiagonal:
                            HatchBrush HB27 = new HatchBrush(HatchStyle.WideDownwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB27, this.ValueRect);
                            break;
                        case HatchBrushType.WideUpwardDiagonal:
                            HatchBrush HB28 = new HatchBrush(HatchStyle.WideUpwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB28, this.ValueRect);
                            break;
                        case HatchBrushType.ZigZag:
                            HatchBrush HB29 = new HatchBrush(HatchStyle.ZigZag, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB29, this.ValueRect);
                            break;
                        default:
                            break;
                    }
                    #endregion

                    //G.FillRectangle(Hatch, this.ValueRect);
                }

                G.ResetClip();
                G.SmoothingMode = SmoothingMode.AntiAlias;
                G.DrawPath(new Pen(_border), this.PipeBorder);

                this.TrackBarHandle = RoundRectangle.RoundRect(this.TrackBarHandleRect, 3);
                this.TrackBarHandleLGB = new LinearGradientBrush(this.ClientRectangle, trackBarHandleColor1, trackBarHandleColor2, 90f);
                G.FillPath(this.TrackBarHandleLGB, this.TrackBarHandle);
                G.DrawPath(new Pen(trackBarHandleBorder), this.TrackBarHandle);

                if (_DrawValueString == true)
                {

                    #region Brushes Paint
                    switch (background)
                    {
                        case Background.AliceBlue:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.AliceBlue, stringPosition, 25);
                            break;
                        case Background.AntiqueWhite:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.AntiqueWhite, stringPosition, 25);
                            break;
                        case Background.Aqua:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Aqua, stringPosition, 25);
                            break;
                        case Background.Aquamarine:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Aquamarine, stringPosition, 25);
                            break;
                        case Background.Azure:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Azure, stringPosition, 25);
                            break;
                        case Background.Beige:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Beige, stringPosition, 25);
                            break;
                        case Background.Bisque:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Bisque, stringPosition, 25);
                            break;
                        case Background.Black:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Black, stringPosition, 25);
                            break;
                        case Background.BlanchedAlmond:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.BlanchedAlmond, stringPosition, 25);
                            break;
                        case Background.Blue:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Blue, stringPosition, 25);
                            break;
                        case Background.BlueViolet:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.BlueViolet, stringPosition, 25);
                            break;
                        case Background.Brown:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Brown, stringPosition, 25);
                            break;
                        case Background.BurlyWood:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.BurlyWood, stringPosition, 25);
                            break;
                        case Background.CadetBlue:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.CadetBlue, stringPosition, 25);
                            break;
                        case Background.Chartreuse:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Chartreuse, stringPosition, 25);
                            break;
                        case Background.Chocolate:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Chocolate, stringPosition, 25);
                            break;
                        case Background.Coral:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Coral, stringPosition, 25);
                            break;
                        case Background.CornflowerBlue:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.CornflowerBlue, stringPosition, 25);
                            break;
                        case Background.Cornsilk:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Cornsilk, stringPosition, 25);
                            break;
                        case Background.Crimson:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Crimson, stringPosition, 25);
                            break;
                        case Background.Cyan:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Cyan, stringPosition, 25);
                            break;
                        case Background.DarkBlue:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DarkBlue, stringPosition, 25);
                            break;
                        case Background.DarkCyan:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DarkCyan, stringPosition, 25);
                            break;
                        case Background.DarkGoldenrod:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DarkGoldenrod, stringPosition, 25);
                            break;
                        case Background.DarkGray:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DarkGray, stringPosition, 25);
                            break;
                        case Background.DarkGreen:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DarkGreen, stringPosition, 25);
                            break;
                        case Background.DarkKhaki:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DarkKhaki, stringPosition, 25);
                            break;
                        case Background.DarkMagenta:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DarkMagenta, stringPosition, 25);
                            break;
                        case Background.DarkOliveGreen:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DarkOliveGreen, stringPosition, 25);
                            break;
                        case Background.DarkOrange:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DarkOrange, stringPosition, 25);
                            break;
                        case Background.DarkOrchid:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DarkOrchid, stringPosition, 25);
                            break;
                        case Background.DarkRed:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DarkRed, stringPosition, 25);
                            break;
                        case Background.DarkSalmon:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DarkSalmon, stringPosition, 25);
                            break;
                        case Background.DarkSeaGreen:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DarkSeaGreen, stringPosition, 25);
                            break;
                        case Background.DarkSlateBlue:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DarkSlateBlue, stringPosition, 25);
                            break;
                        case Background.DarkSlateGray:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DarkSlateGray, stringPosition, 25);
                            break;
                        case Background.DarkTurquoise:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DarkTurquoise, stringPosition, 25);
                            break;
                        case Background.DarkViolet:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DarkViolet, stringPosition, 25);
                            break;
                        case Background.DeepPink:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DeepPink, stringPosition, 25);
                            break;
                        case Background.DeepSkyBlue:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DeepSkyBlue, stringPosition, 25);
                            break;
                        case Background.DimGray:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DimGray, stringPosition, 25);
                            break;
                        case Background.DodgerBlue:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.DodgerBlue, stringPosition, 25);
                            break;
                        case Background.Firebrick:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Firebrick, stringPosition, 25);
                            break;
                        case Background.FloralWhite:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.FloralWhite, stringPosition, 25);
                            break;
                        case Background.ForestGreen:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.ForestGreen, stringPosition, 25);
                            break;
                        case Background.Fuchsia:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Fuchsia, stringPosition, 25);
                            break;
                        case Background.Gainsboro:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Gainsboro, stringPosition, 25);
                            break;
                        case Background.GhostWhite:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.GhostWhite, stringPosition, 25);
                            break;
                        case Background.Gold:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Gold, stringPosition, 25);
                            break;
                        case Background.Goldenrod:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Goldenrod, stringPosition, 25);
                            break;
                        case Background.Gray:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Gray, stringPosition, 25);
                            break;
                        case Background.Green:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Green, stringPosition, 25);
                            break;
                        case Background.GreenYellow:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.GreenYellow, stringPosition, 25);
                            break;
                        case Background.Honeydew:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Honeydew, stringPosition, 25);
                            break;
                        case Background.HotPink:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.HotPink, stringPosition, 25);
                            break;
                        case Background.IndianRed:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.IndianRed, stringPosition, 25);
                            break;
                        case Background.Indigo:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Indigo, stringPosition, 25);
                            break;
                        case Background.Ivory:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Ivory, stringPosition, 25);
                            break;
                        case Background.Khaki:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Khaki, stringPosition, 25);
                            break;
                        case Background.Lavender:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Lavender, stringPosition, 25);
                            break;
                        case Background.LavenderBlush:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.LavenderBlush, stringPosition, 25);
                            break;
                        case Background.LawnGreen:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.LawnGreen, stringPosition, 25);
                            break;
                        case Background.LemonChiffon:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.LemonChiffon, stringPosition, 25);
                            break;
                        case Background.LightBlue:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.LightBlue, stringPosition, 25);
                            break;
                        case Background.LightCoral:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.LightCoral, stringPosition, 25);
                            break;
                        case Background.LightCyan:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.LightCyan, stringPosition, 25);
                            break;
                        case Background.LightGoldenrodYellow:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.LightGoldenrodYellow, stringPosition, 25);
                            break;
                        case Background.LightGray:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.LightGray, stringPosition, 25);
                            break;
                        case Background.LightGreen:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.LightGreen, stringPosition, 25);
                            break;
                        case Background.LightPink:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.LightPink, stringPosition, 25);
                            break;
                        case Background.LightSalmon:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.LightSalmon, stringPosition, 25);
                            break;
                        case Background.LightSeaGreen:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.LightSeaGreen, stringPosition, 25);
                            break;
                        case Background.LightSkyBlue:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.LightSkyBlue, stringPosition, 25);
                            break;
                        case Background.LightSlateGray:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.LightSlateGray, stringPosition, 25);
                            break;
                        case Background.LightSteelBlue:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.LightSteelBlue, stringPosition, 25);
                            break;
                        case Background.LightYellow:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.LightYellow, stringPosition, 25);
                            break;
                        case Background.Lime:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Lime, stringPosition, 25);
                            break;
                        case Background.LimeGreen:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.LimeGreen, stringPosition, 25);
                            break;
                        case Background.Linen:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Linen, stringPosition, 25);
                            break;
                        case Background.Magenta:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Magenta, stringPosition, 25);
                            break;
                        case Background.Maroon:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Maroon, stringPosition, 25);
                            break;
                        case Background.MediumAquamarine:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.MediumAquamarine, stringPosition, 25);
                            break;
                        case Background.MediumBlue:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.MediumBlue, stringPosition, 25);
                            break;
                        case Background.MediumOrchid:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.MediumOrchid, stringPosition, 25);
                            break;
                        case Background.MediumPurple:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.MediumPurple, stringPosition, 25);
                            break;
                        case Background.MediumSeaGreen:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.MediumSeaGreen, stringPosition, 25);
                            break;
                        case Background.MediumSlateBlue:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.MediumSlateBlue, stringPosition, 25);
                            break;
                        case Background.MediumSpringGreen:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.MediumSpringGreen, stringPosition, 25);
                            break;
                        case Background.MediumTurquoise:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.MediumTurquoise, stringPosition, 25);
                            break;
                        case Background.MediumVioletRed:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.MediumVioletRed, stringPosition, 25);
                            break;
                        case Background.MidnightBlue:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.MidnightBlue, stringPosition, 25);
                            break;
                        case Background.MintCream:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.MintCream, stringPosition, 25);
                            break;
                        case Background.MistyRose:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.MistyRose, stringPosition, 25);
                            break;
                        case Background.Moccasin:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Moccasin, stringPosition, 25);
                            break;
                        case Background.NavajoWhite:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.NavajoWhite, stringPosition, 25);
                            break;
                        case Background.Navy:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Navy, stringPosition, 25);
                            break;
                        case Background.OldLace:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.OldLace, stringPosition, 25);
                            break;
                        case Background.Olive:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Olive, stringPosition, 25);
                            break;
                        case Background.OliveDrab:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.OliveDrab, stringPosition, 25);
                            break;
                        case Background.Orange:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Orange, stringPosition, 25);
                            break;
                        case Background.OrangeRed:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.OrangeRed, stringPosition, 25);
                            break;
                        case Background.Orchid:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Orchid, stringPosition, 25);
                            break;
                        case Background.PaleGoldenrod:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.PaleGoldenrod, stringPosition, 25);
                            break;
                        case Background.PaleGreen:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.PaleGreen, stringPosition, 25);
                            break;
                        case Background.PaleTurquoise:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.PaleTurquoise, stringPosition, 25);
                            break;
                        case Background.PaleVioletRed:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.PaleVioletRed, stringPosition, 25);
                            break;
                        case Background.PapayaWhip:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.PapayaWhip, stringPosition, 25);
                            break;
                        case Background.PeachPuff:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.PeachPuff, stringPosition, 25);
                            break;
                        case Background.Peru:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Peru, stringPosition, 25);
                            break;
                        case Background.Pink:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Pink, stringPosition, 25);
                            break;
                        case Background.Plum:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Plum, stringPosition, 25);
                            break;
                        case Background.PowderBlue:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.PowderBlue, stringPosition, 25);
                            break;
                        case Background.Purple:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Purple, stringPosition, 25);
                            break;
                        case Background.Red:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Red, stringPosition, 25);
                            break;
                        case Background.RosyBrown:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.RosyBrown, stringPosition, 25);
                            break;
                        case Background.RoyalBlue:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.RoyalBlue, stringPosition, 25);
                            break;
                        case Background.SaddleBrown:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.SaddleBrown, stringPosition, 25);
                            break;
                        case Background.Salmon:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Salmon, stringPosition, 25);
                            break;
                        case Background.SandyBrown:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.SandyBrown, stringPosition, 25);
                            break;
                        case Background.SeaGreen:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.SeaGreen, stringPosition, 25);
                            break;
                        case Background.SeaShell:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.SeaShell, stringPosition, 25);
                            break;
                        case Background.Sienna:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Sienna, stringPosition, 25);
                            break;
                        case Background.Silver:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Silver, stringPosition, 25);
                            break;
                        case Background.SkyBlue:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.SkyBlue, stringPosition, 25);
                            break;
                        case Background.SlateBlue:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.SlateBlue, stringPosition, 25);
                            break;
                        case Background.SlateGray:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.SlateGray, stringPosition, 25);
                            break;
                        case Background.Snow:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Snow, stringPosition, 25);
                            break;
                        case Background.SpringGreen:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.SpringGreen, stringPosition, 25);
                            break;
                        case Background.SteelBlue:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.SteelBlue, stringPosition, 25);
                            break;
                        case Background.Tan:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Tan, stringPosition, 25);
                            break;
                        case Background.Teal:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Teal, stringPosition, 25);
                            break;
                        case Background.Thistle:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Thistle, stringPosition, 25);
                            break;
                        case Background.Tomato:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Tomato, stringPosition, 25);
                            break;
                        case Background.Transparent:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Transparent, stringPosition, 25);
                            break;
                        case Background.Turquoise:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Turquoise, stringPosition, 25);
                            break;
                        case Background.Violet:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Violet, stringPosition, 25);
                            break;
                        case Background.Wheat:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.Wheat, stringPosition, 25);
                            break;
                        case Background.White:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.White, stringPosition, 25);
                            break;
                        case Background.WhiteSmoke:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.WhiteSmoke, stringPosition, 25);
                            break;
                        case Background.YellowGreen:
                            G.DrawString(System.Convert.ToString(ValueToSet + percentSymbol), Font, Brushes.YellowGreen, stringPosition, 25);
                            break;
                        default:
                            break;
                    }

                    #endregion


                }
            }
        }
    }


    #region Smart Tag Code

    #region Cut and Paste it on top of the component class

    //--------------- [Designer(typeof(myControlDesigner))] --------------------//
    #endregion

    #region ControlDesigner
    /// <summary>
    /// Class ZeroitTrackBarDesigner.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Design.ControlDesigner" />
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class ZeroitTrackBarDesigner : System.Windows.Forms.Design.ControlDesigner
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
                    actionLists.Add(new ZeroitTrackBarSmartTagActionList(this.Component));
                }
                return actionLists;
            }
        }
    }

    #endregion

    #region SmartTagActionList
    /// <summary>
    /// Class ZeroitTrackBarSmartTagActionList.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Design.DesignerActionList" />
    public class ZeroitTrackBarSmartTagActionList : System.ComponentModel.Design.DesignerActionList
    {
        //Replace SmartTag with the Component Class Name. In this case the component class name is SmartTag
        /// <summary>
        /// The col user control
        /// </summary>
        private ZeroitTrackBar colUserControl;


        /// <summary>
        /// The designer action UI SVC
        /// </summary>
        private DesignerActionUIService designerActionUISvc = null;


        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitTrackBarSmartTagActionList"/> class.
        /// </summary>
        /// <param name="component">A component related to the <see cref="T:System.ComponentModel.Design.DesignerActionList" />.</param>
        public ZeroitTrackBarSmartTagActionList(IComponent component) : base(component)
        {
            this.colUserControl = component as ZeroitTrackBar;

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
        /// Gets or sets the color hatch brushgradient1.
        /// </summary>
        /// <value>The color hatch brushgradient1.</value>
        public Color ColorHatchBrushgradient1
        {
            get
            {
                return colUserControl.ColorHatchBrushgradient1;
            }
            set
            {
                GetPropertyByName("ColorHatchBrushgradient1").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the color hatch brushgradient2.
        /// </summary>
        /// <value>The color hatch brushgradient2.</value>
        public Color ColorHatchBrushgradient2
        {
            get
            {
                return colUserControl.ColorHatchBrushgradient2;
            }
            set
            {
                GetPropertyByName("ColorHatchBrushgradient2").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the color value colour1.
        /// </summary>
        /// <value>The color value colour1.</value>
        public Color ColorValueColour1
        {
            get
            {
                return colUserControl.ColorValueColour1;
            }
            set
            {
                GetPropertyByName("ColorValueColour1").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the color value colour2.
        /// </summary>
        /// <value>The color value colour2.</value>
        public Color ColorValueColour2
        {
            get
            {
                return colUserControl.ColorValueColour2;
            }
            set
            {
                GetPropertyByName("ColorValueColour2").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the color border.
        /// </summary>
        /// <value>The color border.</value>
        public Color ColorBorder
        {
            get
            {
                return colUserControl.ColorBorder;
            }
            set
            {
                GetPropertyByName("ColorBorder").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the color track bar handle color1.
        /// </summary>
        /// <value>The color track bar handle color1.</value>
        public Color ColorTrackBarHandleColor1
        {
            get
            {
                return colUserControl.ColorTrackBarHandleColor1;
            }
            set
            {
                GetPropertyByName("ColorTrackBarHandleColor1").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the color track bar handle color2.
        /// </summary>
        /// <value>The color track bar handle color2.</value>
        public Color ColorTrackBarHandleColor2
        {
            get
            {
                return colUserControl.ColorTrackBarHandleColor2;
            }
            set
            {
                GetPropertyByName("ColorTrackBarHandleColor2").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the color track bar handle border.
        /// </summary>
        /// <value>The color track bar handle border.</value>
        public Color ColorTrackBarHandleBorder
        {
            get
            {
                return colUserControl.ColorTrackBarHandleBorder;
            }
            set
            {
                GetPropertyByName("ColorTrackBarHandleBorder").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the color text.
        /// </summary>
        /// <value>The color text.</value>
        public ZeroitTrackBar.Background ColorText
        {
            get
            {
                return colUserControl.ColorText;
            }
            set
            {
                GetPropertyByName("ColorText").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the hatch brush.
        /// </summary>
        /// <value>The hatch brush.</value>
        public ZeroitTrackBar.HatchBrushType HatchBrush
        {
            get
            {
                return colUserControl.HatchBrush;
            }
            set
            {
                GetPropertyByName("HatchBrush").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the minimum.
        /// </summary>
        /// <value>The minimum.</value>
        public int Minimum
        {
            get
            {
                return colUserControl.Minimum;
            }
            set
            {
                GetPropertyByName("Minimum").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the maximum.
        /// </summary>
        /// <value>The maximum.</value>
        public int Maximum
        {
            get
            {
                return colUserControl.Maximum;
            }
            set
            {
                GetPropertyByName("Maximum").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public int Value
        {
            get
            {
                return colUserControl.Value;
            }
            set
            {
                GetPropertyByName("Value").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the value divison.
        /// </summary>
        /// <value>The value divison.</value>
        public ZeroitTrackBar.ValueDivisor ValueDivison
        {
            get
            {
                return colUserControl.ValueDivison;
            }
            set
            {
                GetPropertyByName("ValueDivison").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the value to set.
        /// </summary>
        /// <value>The value to set.</value>
        public float ValueToSet
        {
            get
            {
                return colUserControl.ValueToSet;
            }
            set
            {
                GetPropertyByName("ValueToSet").SetValue(colUserControl, value);
            }
        }


        /// <summary>
        /// Gets or sets a value indicating whether [draw hatch].
        /// </summary>
        /// <value><c>true</c> if [draw hatch]; otherwise, <c>false</c>.</value>
        public bool DrawHatch
        {
            get
            {
                return colUserControl.DrawHatch;
            }
            set
            {
                GetPropertyByName("DrawHatch").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [draw value string].
        /// </summary>
        /// <value><c>true</c> if [draw value string]; otherwise, <c>false</c>.</value>
        public bool DrawValueString
        {
            get
            {
                return colUserControl.DrawValueString;
            }
            set
            {
                GetPropertyByName("DrawValueString").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets the percent symbol.
        /// </summary>
        /// <value>The percent symbol.</value>
        public String PercentSymbol
        {
            get
            {
                return colUserControl.PercentSymbol;
            }
            set
            {
                GetPropertyByName("PercentSymbol").SetValue(colUserControl, value);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [jump to mouse].
        /// </summary>
        /// <value><c>true</c> if [jump to mouse]; otherwise, <c>false</c>.</value>
        public bool JumpToMouse
        {
            get
            {
                return colUserControl.JumpToMouse;
            }
            set
            {
                GetPropertyByName("JumpToMouse").SetValue(colUserControl, value);
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

            items.Add(new DesignerActionPropertyItem("ColorHatchBrushgradient1",
                                 "Color Hatch Brush gradient1", "Appearance",
                                 "Selects the background color."));

            items.Add(new DesignerActionPropertyItem("ColorHatchBrushgradient2",
                                 "Color Hatch Brush gradient2", "Appearance",
                                 "Selects the foreground color."));

            items.Add(new DesignerActionPropertyItem("ColorText",
                                 "Text Color", "Appearance",
                                 "Selects the foreground color."));

            items.Add(new DesignerActionPropertyItem("ColorValueColour1",
                                 "Color ValueColour1", "Appearance",
                                 "Type few characters to filter Cities."));

            items.Add(new DesignerActionPropertyItem("ColorValueColour2",
                                 "Color ValueColour2", "Appearance",
                                 "Sets the background color when the hatchbrush is deselected."));

            items.Add(new DesignerActionPropertyItem("ColorBorder",
                                 "ColorBorder", "Appearance",
                                 "Sets the border color of the control."));

            items.Add(new DesignerActionPropertyItem("ColorTrackBarHandleColor1",
                                 "Color TrackBarHandle Color1", "Appearance",
                                 "Sets the background colour of the handle."));

            items.Add(new DesignerActionPropertyItem("ColorTrackBarHandleColor2",
                                 "Color TrackBarHandle Color2", "Appearance",
                                 "Sets the background colour of the handle."));

            items.Add(new DesignerActionPropertyItem("ColorTrackBarHandleBorder",
                                 "Color TrackBarHandle Border", "Appearance",
                                 "Sets the border colour of the handle."));

            items.Add(new DesignerActionPropertyItem("HatchBrush",
                                 "Hatch Brush", "Appearance",
                                 "Choose the type of hatcbrush to use."));

            items.Add(new DesignerActionPropertyItem("Minimum",
                                 "Minimum", "Appearance",
                                 "Sets the minimum value."));

            items.Add(new DesignerActionPropertyItem("Maximum",
                                 "Maximum", "Appearance",
                                 "Sets the maximum value."));

            items.Add(new DesignerActionPropertyItem("Value",
                                 "Value", "Appearance",
                                 "Sets the value of the control."));

            items.Add(new DesignerActionPropertyItem("PercentSymbol",
                                 "Percent Symbol", "Appearance",
                                 "Sets the symbol for the percentage of the control."));

            items.Add(new DesignerActionPropertyItem("ValueDivison",
                                 "Value Divison", "Appearance",
                                 "Sets how the value should be divided by."));

            //items.Add(new DesignerActionPropertyItem("ValueToSet",
            //                     "Value To Set", "Appearance",
            //                     "Type few characters to filter Cities."));


            items.Add(new DesignerActionPropertyItem("DrawHatch",
                                 "Draw Hatch", "Appearance",
                                 "Set to use either the hatch or a solid brush."));

            items.Add(new DesignerActionPropertyItem("DrawValueString",
                                 "Draw Value String", "Appearance",
                                 "Set to show the progress numbers."));

            items.Add(new DesignerActionPropertyItem("JumpToMouse",
                                 "Jump To Mouse", "Appearance",
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
