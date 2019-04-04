// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="TransitionElement.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.Transitions.FormSpark.GoogleTransition
{
    #region TransitionElement
    /// <summary>
    /// Enum InterpolationMethod
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
