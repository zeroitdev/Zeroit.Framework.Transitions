// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="CQuintic.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Zeroit.Framework.Transitions.DBTweener
{
    /// <summary>
    /// Class CQuintic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.DBTweener.CEquation" />
    public class CQuintic : CEquation
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
            t /= d;
            return c * t * t * t * t * t + b;
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
            t /= d;
            t--;
            return c * (t * t * t * t * t + 1.0f) + b;
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
            t /= d / 2.0f;
            if (t < 1.0f)
            {
                return c / 2.0f * t * t * t * t * t + b;
            }
            t -= 2.0f;
            return c / 2.0f * (t * t * t * t * t + 2.0f) + b;
        }
    }
}
