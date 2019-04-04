// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ManagedType_Int.cs" company="Zeroit Dev Technologies">
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

    #region ManagedType_Int
    /// <summary>
    /// Manages transitions for int properties.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.ZeroitAnimateTransitionWithEditor.IManagedType" />
    internal class ManagedType_Int : IManagedType
    {
        #region IManagedType Members

        /// <summary>
        /// Returns the type we are managing.
        /// </summary>
        /// <returns>Type.</returns>
        public Type getManagedType()
        {
            return typeof(int);
        }

        /// <summary>
        /// Returns a copy of the int passed in.
        /// </summary>
        /// <param name="o">The o.</param>
        /// <returns>System.Object.</returns>
        public object copy(object o)
        {
            int value = (int)o;
            return value;
        }

        /// <summary>
        /// Returns the value between the start and end for the percentage passed in.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <param name="dPercentage">The d percentage.</param>
        /// <returns>System.Object.</returns>
        public object getIntermediateValue(object start, object end, double dPercentage)
        {
            int iStart = (int)start;
            int iEnd = (int)end;
            return Utility.interpolate(iStart, iEnd, dPercentage);
        }

        #endregion
    }
    #endregion


}
