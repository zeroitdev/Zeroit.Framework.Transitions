// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="SValue.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;


namespace Zeroit.Framework.Transitions.DBTweener
{
    // representation of a single value 'to be tweened'. this is always a float pointer.
    // these values are used in CTween.
    /// <summary>
    /// Class SValue.
    /// </summary>
    public class SValue
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SValue"/> class.
        /// </summary>
        /// <param name="fpValue">The fp value.</param>
        /// <param name="fTarget">The f target.</param>
        public SValue(ref float fpValue, float fTarget)
        {
            m_fpValue = fpValue;
            m_fTarget = fTarget;

            // the start value is only initialized at the very last moment to make sure
            // we're not working on an old value if the tweens where prepared before
            // starting.
            m_fStart = 0.0f;
        }
        //C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent for pointers to value types:
        //ORIGINAL LINE: float *m_fpValue;
        /// <summary>
        /// The m fp value
        /// </summary>
        public float m_fpValue;
        /// <summary>
        /// The m f target
        /// </summary>
        public float m_fTarget;
        /// <summary>
        /// The m f start
        /// </summary>
        public float m_fStart;

        /// <summary>
        /// The object
        /// </summary>
        SValue obj;
        /// <summary>
        /// Disposes this instance.
        /// </summary>
        public void Dispose()
        {
            
            try
            {
                obj = new SValue(ref m_fpValue, m_fTarget);
            }
            finally
            {
                if (obj != null)
                {
                    ((IDisposable)obj).Dispose();
                }
            }
        }

    }
}
