// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 08-25-2017
// ***********************************************************************
// <copyright file="FPSLimiterKnownValues.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Zeroit.Framework.Transitions.WinFormAnimation
{
    /// <summary>
    ///     FPS limiter known values
    /// </summary>
    public enum FPSLimiterKnownValues
    {
        /// <summary>
        ///     Limits maximum frames per second to 10fps
        /// </summary>
        LimitTen = 10,

        /// <summary>
        ///     Limits maximum frames per second to 20fps
        /// </summary>
        LimitTwenty = 20,

        /// <summary>
        ///     Limits maximum frames per second to 30fps
        /// </summary>
        LimitThirty = 30,

        /// <summary>
        ///     Limits maximum frames per second to 60fps
        /// </summary>
        LimitSixty = 60,

        /// <summary>
        ///     Limits maximum frames per second to 100fps
        /// </summary>
        LimitOneHundred = 100,

        /// <summary>
        ///     Limits maximum frames per second to 200fps
        /// </summary>
        LimitTwoHundred = 200,

        /// <summary>
        ///     Adds no limit to the number of frames per second
        /// </summary>
        NoFPSLimit = -1
    }
}