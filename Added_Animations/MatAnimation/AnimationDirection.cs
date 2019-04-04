// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 05-05-2018
// ***********************************************************************
// <copyright file="AnimationDirection.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Zeroit.Framework.Transitions
{
    /// <summary>
    /// Enum for representing MatAnimation Direction
    /// </summary>
    public enum MatAnimationDirection
    {
        /// <summary>
        /// The in
        /// </summary>
        In, //In. Stops if finished.
        /// <summary>
        /// The out
        /// </summary>
        Out, //Out. Stops if finished.
        /// <summary>
        /// The in out in
        /// </summary>
        InOutIn, //Same as In, but changes to InOutOut if finished.
        /// <summary>
        /// The in out out
        /// </summary>
        InOutOut, //Same as Out.
        /// <summary>
        /// The in out repeating in
        /// </summary>
        InOutRepeatingIn, // Same as In, but changes to InOutRepeatingOut if finished.
        /// <summary>
        /// The in out repeating out
        /// </summary>
        InOutRepeatingOut // Same as Out, but changes to InOutRepeatingIn if finished.

    }
}
