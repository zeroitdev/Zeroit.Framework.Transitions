// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ManagedType_Double.cs" company="Zeroit Dev Technologies">
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
    #region ManagedType_Double
    /// <summary>
    /// Manages transitions for double properties.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.FormSpark.GoogleTransition.IManagedType" />
    internal class ManagedType_Double : IManagedType
    {
        #region IManagedType Members

        /// <summary>
        /// Returns the type managed by this class.
        /// </summary>
        /// <returns>Type.</returns>
        public Type getManagedType()
        {
            return typeof(double);
        }

        /// <summary>
        /// Returns a copy of the double passed in.
        /// </summary>
        /// <param name="o">The o.</param>
        /// <returns>System.Object.</returns>
        public object copy(object o)
        {
            double d = (double)o;
            return d;
        }

        /// <summary>
        /// Returns the value between start and end for the percentage passed in.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <param name="dPercentage">The d percentage.</param>
        /// <returns>System.Object.</returns>
        public object getIntermediateValue(object start, object end, double dPercentage)
        {
            double dStart = (double)start;
            double dEnd = (double)end;
            return Utility.interpolate(dStart, dEnd, dPercentage);
        }

        #endregion
    }
    #endregion
}
