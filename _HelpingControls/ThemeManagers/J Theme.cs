// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="J Theme.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.ThemeManagers
{



    /// <summary>
    /// Class Jtheme.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.ThemeManagers.ThemeContainer" />
    [ToolboxItem(false)]
    public class Jtheme : ThemeContainer
    {
        /// <summary>
        /// The color1
        /// </summary>
        Color Color1 = Color.FromArgb(20, 20, 20);
        /// <summary>
        /// The color2
        /// </summary>
        Color Color2 = Color.FromArgb(50, 50, 50);
        /// <summary>
        /// The color3
        /// </summary>
        Color Color3 = Color.FromArgb(50, 50, 50);

        /// <summary>
        /// The color4
        /// </summary>
        Color Color4 = Color.White;


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
            G.Clear(Color1);
            Rectangle rect = new Rectangle(10, 20, Width - 20, Height - 30);
            G.FillRectangle(new SolidBrush(Color2), rect);
            DrawBorders(Pens.Black, rect);
            DrawBorders(Pens.Black);
            DrawCorners(Color3);
            DrawText(new SolidBrush(Color4), HorizontalAlignment.Center, 0, 0);


        }
    }
    
}


