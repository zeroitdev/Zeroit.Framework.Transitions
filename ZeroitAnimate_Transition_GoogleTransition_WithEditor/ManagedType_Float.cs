// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ManagedType_Float.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.Transitions.ZeroitAnimateTransitionWithEditor
{
    #region ManagedType_Float
    /// <summary>
    /// Class ManagedType_Float.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.ZeroitAnimateTransitionWithEditor.IManagedType" />
    internal class ManagedType_Float : IManagedType
    {
        #region IManagedType Members

        /// <summary>
        /// Returns the type we're managing.
        /// </summary>
        /// <returns>Type.</returns>
        public Type getManagedType()
        {
            return typeof(float);
        }

        /// <summary>
        /// Returns a copy of the float passed in.
        /// </summary>
        /// <param name="o">The o.</param>
        /// <returns>System.Object.</returns>
        public object copy(object o)
        {
            float f = (float)o;
            return f;
        }

        /// <summary>
        /// Returns the interpolated value for the percentage passed in.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <param name="dPercentage">The d percentage.</param>
        /// <returns>System.Object.</returns>
        public object getIntermediateValue(object start, object end, double dPercentage)
        {
            float fStart = (float)start;
            float fEnd = (float)end;
            return Utility.interpolate(fStart, fEnd, dPercentage);
        }

        #endregion
    }
    #endregion
}
