// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="NYX Theme.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.ThemeManagers
{



    /// <summary>
    /// Class NYX.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.ThemeManagers.ThemeContainer" />
    [ToolboxItem(false)]
    public class NYX : ThemeContainer
    {
        Font titleFont = new Font("Arial", 10, FontStyle.Bold);

        private Color titleColor = Color.White;


        public Color TitleColor
        {
            get { return titleColor; }
            set
            {
                titleColor = value;
                Invalidate();
            }
        }

        public Font TitleFont
        {
            get { return titleFont; }
            set
            {
                titleFont = value;
                Invalidate();
            }
        }
        
        /// <summary>
        /// The h
        /// </summary>
        int H;
        /// <summary>
        /// The f
        /// </summary>
        bool f;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="NYX"/> is animated.
        /// </summary>
        /// <value><c>true</c> if animated; otherwise, <c>false</c>.</value>
        public bool Animated
        {
            get { return IsAnimated; }
            set
            {
                IsAnimated = value;
                Invalidate();
            }
        }

        //Coded by HΛWK
        /// <summary>
        /// Called when [animation].
        /// </summary>
        protected override void OnAnimation()
        {
            if (f == true)
            {
                H -= 1;
            }
            else
            {
                H += 1;
            }
            if (H == 25)
            {
                f = false;
            }
            if (H == Height - 8 - 75)
            {
                f = true;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NYX"/> class.
        /// </summary>
        public NYX()
        {
            Animated = true;
            H = 25;
        }

        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {
            TransparencyKey = Color.Fuchsia;
        }

        //Coded by HΛWK
        /// <summary>
        /// Paints the hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        protected override void PaintHook(PaintEventArgs e)
        {
            G = e.Graphics;

            G.Clear(Color.Fuchsia);
            //Borders
            Point[] bTopPoints = {
            new Point(0, 1),
            new Point(1, 0),
            new Point(Width - 2, 0),
            new Point(Width - 1, 1),
            new Point(Width - 1, 25),
            new Point(0, 25)
        };
            LinearGradientBrush bTopLGB = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, 25), Color.FromArgb(60, 60, 60), Color.FromArgb(35, 35, 35), 90f);
            G.FillPolygon(bTopLGB, bTopPoints);
            G.DrawPolygon(Pens.Black, bTopPoints);
            Point[] bBottomPoints = {
            new Point(0, 25),
            new Point(Width - 1, 25),
            new Point(Width - 1, Height - 2),
            new Point(Width - 2, Height - 1),
            new Point(1, Height - 1),
            new Point(0, Height - 2)
        };
            G.FillPolygon(new SolidBrush(Color.FromArgb(35, 35, 35)), bBottomPoints);
            G.DrawPolygon(Pens.Black, bBottomPoints);
            //Glow
            if (Animated == true)
            {
                ColorBlend bg_cblend = new ColorBlend(3);
                bg_cblend.Colors[0] = Color.FromArgb(35, 35, 35);
                bg_cblend.Colors[1] = Color.FromArgb(210, 0, 0);
                bg_cblend.Colors[2] = Color.FromArgb(35, 35, 35);
                bg_cblend.Positions = new float[]{
                0,
                0.6f,
                1
            };
                DrawGradient(bg_cblend, new Rectangle(1, H, Width, 75));
                //Reinforce Borders After Glow
                G.DrawPolygon(Pens.Black, bTopPoints);
                G.DrawPolygon(Pens.Black, bBottomPoints);
                G.DrawLine(Pens.Black, new Point(0, Height - 9), new Point(Width, Height - 9));
            }
            //Main
            Rectangle mainRect = new Rectangle(8, 25, Width - 17, Height - 34);
            G.FillRectangle(new SolidBrush(Color.FromArgb(22, 22, 22)), mainRect);
            G.DrawRectangle(Pens.Black, mainRect);
            //Text
            int textWidth = (int)this.CreateGraphics().MeasureString(Text, Font).Width;
            int textHeight = (int)this.CreateGraphics().MeasureString(Text, Font).Height;
            SolidBrush textShadow = new SolidBrush(Color.FromArgb(30, 0, 0));
            int m = Width / 2;
            G.DrawString(Text, titleFont, textShadow, new Point(m - (textWidth / 2) + 1, 5));
            G.DrawString(Text, titleFont, new SolidBrush(TitleColor), new Point(m - (textWidth / 2), 4));
        }
    }
    

}

