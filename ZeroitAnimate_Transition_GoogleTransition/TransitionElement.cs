// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="TransitionElement.cs" company="Zeroit Dev Technologies">
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

//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.Transitions
{

    #region TransitionElement    
    /// <summary>
    /// An enumeration for setting the interpolation method <c><see cref="ZeroitTransitor" /></c> animator.
    /// </summary>
    public enum InterpolationMethod
    {
        /// <summary>
        /// The linear
        /// </summary>
        Linear,
        /// <summary>
        /// The accleration
        /// </summary>
        Accleration,
        /// <summary>
        /// The deceleration
        /// </summary>
        Deceleration,
        /// <summary>
        /// The ease in ease out
        /// </summary>
        EaseInEaseOut
    }

    /// <summary>
    /// Class TransitionElement.
    /// </summary>
    public class TransitionElement
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="endTime">The end time.</param>
        /// <param name="endValue">The end value.</param>
        /// <param name="interpolationMethod">The interpolation method.</param>
        public TransitionElement(double endTime, double endValue, InterpolationMethod interpolationMethod)
        {
            EndTime = endTime;
            EndValue = endValue;
            InterpolationMethod = interpolationMethod;
        }

        /// <summary>
        /// The percentage of elapsed time, expressed as (for example) 75 for 75%.
        /// </summary>
        /// <value>The end time.</value>
        public double EndTime { get; set; }

        /// <summary>
        /// The value of the animated properties at the EndTime. This is the percentage
        /// movement of the properties between their start and end values. This should
        /// be expressed as (for example) 75 for 75%.
        /// </summary>
        /// <value>The end value.</value>
        public double EndValue { get; set; }

        /// <summary>
        /// The interpolation method to use when moving between the previous value
        /// and the current one.
        /// </summary>
        /// <value>The interpolation method.</value>
        public InterpolationMethod InterpolationMethod { get; set; }
    }
    #endregion
}
