// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="MathLookup.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace Zeroit.Framework.Transitions.DBTweener
{

    /// <summary>
    /// Class MathLookup.
    /// </summary>
    public class MathLookup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MathLookup"/> class.
        /// </summary>
        public MathLookup()
        {
            for (int i = 0; i < 1000; i++)
            {
                m_afsin[i] = (float)sin(((DefineConstants.M_PI * 2.0f) / 1000.0f) * (float)i);
            }
        }

        /// <summary>
        /// Sins the specified f RAD.
        /// </summary>
        /// <param name="fRad">The f RAD.</param>
        /// <returns>System.Single.</returns>
        public float sin(float fRad)
        {
            float fIn = mod(fRad, DefineConstants.M_PI * 2.0f);
            int iIndex = (int)(fIn * (1000.0f / (DefineConstants.M_PI * 2.0f)));
            return m_afsin[iIndex];
        }

        /// <summary>
        /// Coses the specified f RAD.
        /// </summary>
        /// <param name="fRad">The f RAD.</param>
        /// <returns>System.Single.</returns>
        public float cos(float fRad)
        {
            return (float)Math.Sin((DefineConstants.M_PI / 2.0f) - fRad);
        }

        /// <summary>
        /// Mods the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>System.Single.</returns>
        private float mod(float x, float y)
        {
            return x - y * (float)Math.Floor(x / y);
        }
        /// <summary>
        /// The m afsin
        /// </summary>
        private float[] m_afsin = new float[1000];
    }


}
