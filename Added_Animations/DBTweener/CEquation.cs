// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="CEquation.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Zeroit.Framework.Transitions.DBTweener
{
    // base class for creating tweening equations. ease functions should 
    // return the current position given the arguments:
    // t: current time
    // b: begin position
    // c: change position (end position - begin position)
    // d: duration
    /// <summary>
    /// Class CEquation.
    /// </summary>
    public abstract class CEquation
    {
        /// <summary>
        /// Disposes this instance.
        /// </summary>
        public virtual void Dispose()
        {
        }
        /// <summary>
        /// Eases the in.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        /// <returns>System.Single.</returns>
        public abstract float easeIn(float t, float b, float c, float d);
        /// <summary>
        /// Eases the out.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        /// <returns>System.Single.</returns>
        public abstract float easeOut(float t, float b, float c, float d);
        /// <summary>
        /// Eases the in out.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        /// <returns>System.Single.</returns>
        public abstract float easeInOut(float t, float b, float c, float d);
    }
}
