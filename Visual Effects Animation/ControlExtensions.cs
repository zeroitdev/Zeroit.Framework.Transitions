// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ControlExtensions.cs" company="Zeroit Dev Technologies">
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
#region Imports

using System.Drawing;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.Transitions
{
    #region ControlExtensions
    /// <summary>
    /// Class ControlExtensions.
    /// </summary>
    public static class ControlExtensions
    {
        /// <summary>
        /// Selects the next control.
        /// </summary>
        /// <param name="initialControl">The initial control.</param>
        public static void SelectNextControl(this Control initialControl)
        {
            if (initialControl != null)
            {
                var ctrlSelected = initialControl.SelectNextControl(initialControl, true, true, false, false);
                if (!ctrlSelected)
                    SelectNextControl(initialControl.Parent);
            }
        }

        /// <summary>
        /// Gets the snapshot.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>Bitmap.</returns>
        public static Bitmap GetSnapshot(this Control control)
        {
            if (control.Width <= 0 || control.Height <= 0)
                return null;

            Bitmap image = new Bitmap(control.Width, control.Height);
            Rectangle targetBounds = new Rectangle(0, 0, control.Width, control.Height);

            control.DrawToBitmap(image, targetBounds);
            return image;
        }

        /// <summary>
        /// Gets the form borderless snapshot.
        /// </summary>
        /// <param name="window">The window.</param>
        /// <returns>Bitmap.</returns>
        public static Bitmap GetFormBorderlessSnapshot(this System.Windows.Forms.Form window)
        {
            using (var bmp = new Bitmap(window.Width, window.Height))
            {
                window.DrawToBitmap(bmp, new Rectangle(0, 0, window.Width, window.Height));

                System.Drawing.Point point = window.PointToScreen(System.Drawing.Point.Empty);

                Bitmap target = new Bitmap(window.ClientSize.Width, window.ClientSize.Height);
                using (Graphics g = Graphics.FromImage(target))
                {
                    var srcRect = new Rectangle(point.X - window.Location.X,
                        point.Y - window.Location.Y, target.Width, target.Height);

                    g.DrawImage(bmp, 0, 0, srcRect, GraphicsUnit.Pixel);
                }

                return target;
            }
        }
    }
    #endregion
}
