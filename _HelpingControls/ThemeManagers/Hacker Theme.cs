// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Hacker Theme.cs" company="Zeroit Dev Technologies">
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
    /// Class Hacker.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.ThemeManagers.ThemeContainer" />
    [ToolboxItem(false)]
    public class Hacker : ThemeContainer
    {

        /// <summary>
        /// The border
        /// </summary>
        Color Border = Color.Black;

        /// <summary>
        /// The text brush
        /// </summary>
        Color TextBrush = Color.Lime;
        /// <summary>
        /// Initializes a new instance of the <see cref="Hacker"/> class.
        /// </summary>
        public Hacker()
        {
            TransparencyKey = Color.Fuchsia;
            BackColor = Color.Black;
            Font = new Font("Arial", 9);
            
        }

        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {
            
        }

        /// <summary>
        /// Paints the hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        protected override void PaintHook(PaintEventArgs e)
        {
            G = e.Graphics;
            G.Clear(Color.Black);
            G.SmoothingMode = SmoothingMode.HighQuality;
            //Form Border
            HatchBrush HB = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(255, 16, 16, 16), Color.FromArgb(255, 14, 14, 14));
            G.FillRectangle(HB, new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawRectangle(new Pen(Border), 0, 0, Width - 1, Height - 1);
            //Form Interior
            HatchBrush HB2 = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(120, 80, 80, 80), Color.FromArgb(120, 64, 64, 64));
            G.FillRectangle(HB2, new Rectangle(6, 25, Width - 11, Height - 30));
            //Title Box
            HatchBrush HB3 = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(255, 20, 20, 20), Color.FromArgb(255, 12, 12, 12));
            Point[] p = {
            new Point(3, 15),
            new Point(20, 3),
            new Point(230, 3),
            new Point(230, 15),
            new Point(200, 35),
            new Point(3, 35)
        };
            G.FillPolygon(HB3, p);
            G.DrawPolygon(Pens.Black, p);
            //Icon and Form Title
            G.DrawString(Text, Font, new SolidBrush(TextBrush), new Point(40, 12));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(20, 12, 16, 16));
            //Draw Border
            DrawBorders(Pens.Black, 0);
        }
    }
        

}


