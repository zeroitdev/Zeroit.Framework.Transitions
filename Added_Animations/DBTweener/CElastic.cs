﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="CElastic.cs" company="Zeroit Dev Technologies">
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
