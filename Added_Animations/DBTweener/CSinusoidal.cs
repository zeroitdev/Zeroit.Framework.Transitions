// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="CSinusoidal.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Zeroit.Framework.Transitions.DBTweener
{
    /// <summary>
    /// Class CSinusoidal.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.DBTweener.CEquation" />
    public class CSinusoidal : CEquation
    {
        /// <summary>
        /// The math lookup
        /// </summary>
        private MathLookup mathLookup = new MathLookup();
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
            return -c * mathLookup.cos(t / d * (DefineConstants.M_PI / 2.0f)) + c + b;
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
            return c * mathLookup.sin(t / d * (DefineConstants.M_PI / 2.0f)) + b;
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
            return -c / 2.0f * (mathLookup.cos(DefineConstants.M_PI * t / d) - 1.0f) + b;
        }
    }
}
