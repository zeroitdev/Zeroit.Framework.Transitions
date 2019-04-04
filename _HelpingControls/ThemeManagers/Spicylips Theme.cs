// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Spicylips Theme.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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