// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Spicylips Theme.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Windows.Forms;


namespace Zeroit.Framework.Transitions.ThemeManagers
{

    /// <summary>
    /// Class SpicyLips.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.ThemeManagers.ThemeContainer" />
    [ToolboxItem(false)]
    public class SpicyLips : ThemeContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpicyLips"/> class.
        /// </summary>
        public SpicyLips()
        {
            TransparencyKey = Color.Fuchsia;
            Height = 30;
            BackColor = Color.FromArgb(20, 20, 20);
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
            G.Clear(Color.FromArgb(20, 20, 20));

            HatchBrush T = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(9, 9, 9), Color.FromArgb(15, 15, 15));
            G.FillRectangle(T, ClientRectangle);
            G.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.White)), ClientRectangle);
            DrawBorders(new Pen(Color.FromArgb(7, 7, 7)), 0, 0, Width, Height);

            G.FillRectangle(new SolidBrush(Color.FromArgb(20, 20, 20)), 12, 22, Width - 24, Height - 27);
            DrawBorders(new Pen(Color.FromArgb(7, 7, 7)), 12, 22, Width - 24, Height - 27);

            DrawText(new SolidBrush(Color.White), HorizontalAlignment.Center, 0, 1);
            DrawCorners(TransparencyKey);

        }
    }

    

}