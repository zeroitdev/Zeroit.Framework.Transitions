// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="SValue.cs" company="Zeroit Dev Technologies">
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
