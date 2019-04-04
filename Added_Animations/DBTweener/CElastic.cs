// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="CElastic.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace Zeroit.Framework.Transitions.DBTweener
{
    /// <summary>
    /// Class CElastic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.DBTweener.CEquation" />
    public class CElastic : CEquation
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
            if ((Math.Abs(t - 0.0f) <= Double.Epsilon))
            {
                return b;
            }
            if ((Math.Abs((t /= d) - 1.0f) <= Double.Epsilon))
            {
                return b + c;
            }

            float p = d * .3f;
            float a = c;
            float s = p / 4.0f;

            return -(a * (float)Math.Pow(2.0f, 10.0f * (t -= 1.0f)) * mathLookup.sin((t * d - s) * (2.0f * DefineConstants.M_PI) / p)) + b;
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
            if ((Math.Abs(t - 0.0f) <= Double.Epsilon))
            {
                return b;
            }
            if ((Math.Abs((t /= d) - 1.0f) <= Double.Epsilon))
            {
                return b + c;
            }

            float p = d * .3f;
            float a = c;
            float s = p / 4.0f;

            return (a * (float)Math.Pow(2.0f, -10.0f * t) * mathLookup.sin((t * d - s) * (2.0f * DefineConstants.M_PI) / p) + c + b);
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
            if ((Math.Abs(t - 0.0f) <= Double.Epsilon))
            {
                return b;
            }
            if ((Math.Abs((t /= d / 2.0f) - 2.0f) <= Double.Epsilon))
            {
                return b + c;
            }

            float p = d * (.3f * 1.5f);
            float a = c;
            float s = p / 4.0f;

            if (t < 1.0f)
            {
                return -.5f * (a * (float)Math.Pow(2.0f, 10.0f * (t -= 1.0f)) * mathLookup.sin((t * d - s) * (2.0f * DefineConstants.M_PI) / p)) + b;
            }
            return a * (float)Math.Pow(2.0f, -10.0f * (t -= 1.0f)) * mathLookup.sin((t * d - s) * (2.0f * DefineConstants.M_PI) / p) * .5f + c + b;
        }
    }


}
