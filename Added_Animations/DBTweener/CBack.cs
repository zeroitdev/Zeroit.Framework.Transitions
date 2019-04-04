// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="CBack.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Zeroit.Framework.Transitions.DBTweener
{
    /// <summary>
    /// Class CBack.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.DBTweener.CEquation" />
    public class CBack : CEquation
    {
        /// <summary>
        /// Eases the in.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        /// <returns>System.Single.</returns>
        public override float easeIn(float t, float b, float c, float d)
        {
            s = 1.70158f;
            return c * (t /= d) * t * ((s + 1.0f) * t - s) + b;
        }
        /// <summary>
        /// Eases the out.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        /// <returns>System.Single.</returns>
        public override float easeOut(float t, float b, float c, float d)
        {
            s = 1.70158f;
            return c * ((t = t / d - 1.0f) * t * ((s + 1.0f) * t + s) + 1.0f) + b;
        }
        /// <summary>
        /// Eases the in out.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        /// <returns>System.Single.</returns>
        public override float easeInOut(float t, float b, float c, float d)
        {
            s = 1.70158f;
            if ((t /= d / 2.0f) < 1.0f)
            {
                return c / 2.0f * (t * t * (((s *= (1.525f)) + 1.0f) * t - s)) + b;
            }
            return c / 2.0f * ((t -= 2.0f) * t * (((s *= (1.525f)) + 1.0f) * t + s) + 2.0f) + b;
        }
        /// <summary>
        /// The s
        /// </summary>
        public float s;
    }
}
