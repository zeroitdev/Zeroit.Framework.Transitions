// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ManagedType_String.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.Transitions.FormSpark.GoogleTransition
{
    #region ManagedType_String
    /// <summary>
    /// Manages transitions for strings. This doesn't make as much sense as transitions
    /// on other types, but I like the way it looks!
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.FormSpark.GoogleTransition.IManagedType" />
    internal class ManagedType_String : IManagedType
    {
        #region IManagedType Members

        /// <summary>
        /// Returns the type we're managing.
        /// </summary>
        /// <returns>Type.</returns>
        public Type getManagedType()
        {
            return typeof(string);
        }

        /// <summary>
        /// Returns a copy of the string passed in.
        /// </summary>
        /// <param name="o">The o.</param>
        /// <returns>System.Object.</returns>
        public object copy(object o)
        {
            string s = (string)o;
            return new string(s.ToCharArray());
        }

        /// <summary>
        /// Returns an "interpolated" string.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <param name="dPercentage">The d percentage.</param>
        /// <returns>System.Object.</returns>
        public object getIntermediateValue(object start, object end, double dPercentage)
        {
            string strStart = (string)start;
            string strEnd = (string)end;

            // We find the length of the interpolated string...
            int iStartLength = strStart.Length;
            int iEndLength = strEnd.Length;
            int iLength = Utility.interpolate(iStartLength, iEndLength, dPercentage);
            char[] result = new char[iLength];

            // Now we assign the letters of the results by interpolating the
            // letters from the start and end strings...
            for (int i = 0; i < iLength; ++i)
            {
                // We get the start and end chars at this position...
                char cStart = 'a';
                if (i < iStartLength)
                {
                    cStart = strStart[i];
                }
                char cEnd = 'a';
                if (i < iEndLength)
                {
                    cEnd = strEnd[i];
                }

                // We interpolate them...
                char cInterpolated;
                if (cEnd == ' ')
                {
                    // If the end character is a space we just show a space 
                    // regardless of interpolation. It looks better this way...
                    cInterpolated = ' ';
                }
                else
                {
                    // The end character is not a space, so we interpolate...
                    int iStart = Convert.ToInt32(cStart);
                    int iEnd = Convert.ToInt32(cEnd);
                    int iInterpolated = Utility.interpolate(iStart, iEnd, dPercentage);
                    cInterpolated = Convert.ToChar(iInterpolated);
                }

                result[i] = cInterpolated;
            }

            return new string(result);
        }

        #endregion
    }
    #endregion
}
