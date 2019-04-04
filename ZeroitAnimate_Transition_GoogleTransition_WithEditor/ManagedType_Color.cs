// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ManagedType_Color.cs" company="Zeroit Dev Technologies">
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

using System;
using System.Drawing;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.Transitions.ZeroitAnimateTransitionWithEditor
{
    #region ManagedType_Color
    /// <summary>
    /// Class that manages transitions for Color properties. For these we
    /// need to transition the R, G, B and A sub-properties independently.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.ZeroitAnimateTransitionWithEditor.IManagedType" />
    internal class ManagedType_Color : IManagedType
    {
        #region IManagedType Members

        /// <summary>
        /// Returns the type we are managing.
        /// </summary>
        /// <returns>Type.</returns>
        public Type getManagedType()
        {
            return typeof(Color);
        }

        /// <summary>
        /// Returns a copy of the color object passed in.
        /// </summary>
        /// <param name="o">The o.</param>
        /// <returns>System.Object.</returns>
        public object copy(object o)
        {
            Color c = (Color)o;
            Color result = Color.FromArgb(c.ToArgb());
            return result;
        }

        /// <summary>
        /// Creates an intermediate value for the colors depending on the percentage passed in.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <param name="dPercentage">The d percentage.</param>
        /// <returns>System.Object.</returns>
        public object getIntermediateValue(object start, object end, double dPercentage)
        {
            Color startColor = (Color)start;
            Color endColor = (Color)end;

            // We interpolate the R, G, B and A components separately...
            int iStart_R = startColor.R;
            int iStart_G = startColor.G;
            int iStart_B = startColor.B;
            int iStart_A = startColor.A;

            int iEnd_R = endColor.R;
            int iEnd_G = endColor.G;
            int iEnd_B = endColor.B;
            int iEnd_A = endColor.A;

            int new_R = Utility.interpolate(iStart_R, iEnd_R, dPercentage);
            int new_G = Utility.interpolate(iStart_G, iEnd_G, dPercentage);
            int new_B = Utility.interpolate(iStart_B, iEnd_B, dPercentage);
            int new_A = Utility.interpolate(iStart_A, iEnd_A, dPercentage);

            return Color.FromArgb(new_A, new_R, new_G, new_B);
        }

        #endregion
    }
    #endregion
}
