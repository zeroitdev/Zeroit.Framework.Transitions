// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Utility.cs" company="Zeroit Dev Technologies">
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
#region Imports

using System;
using System.ComponentModel;
using System.Reflection;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.Transitions
{
    #region Utility
    /// <summary>
    /// A class holding static utility functions.
    /// </summary>
    internal class Utility
    {
        /// <summary>
        /// Returns the value of the property passed in.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="strPropertyName">Name of the string property.</param>
        /// <returns>System.Object.</returns>
        /// <exception cref="Exception">Object: " + target.ToString() + " does not have the property: " + strPropertyName</exception>
        public static object getValue(object target, string strPropertyName)
        {
            Type targetType = target.GetType();
            PropertyInfo propertyInfo = targetType.GetProperty(strPropertyName);
            if (propertyInfo == null)
            {
                throw new Exception("Object: " + target.ToString() + " does not have the property: " + strPropertyName);
            }
            return propertyInfo.GetValue(target, null);
        }

        /// <summary>
        /// Sets the value of the property passed in.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="strPropertyName">Name of the string property.</param>
        /// <param name="value">The value.</param>
        /// <exception cref="Exception">Object: " + target.ToString() + " does not have the property: " + strPropertyName</exception>
        public static void setValue(object target, string strPropertyName, object value)
        {
            Type targetType = target.GetType();
            PropertyInfo propertyInfo = targetType.GetProperty(strPropertyName);
            if (propertyInfo == null)
            {
                throw new Exception("Object: " + target.ToString() + " does not have the property: " + strPropertyName);
            }
            propertyInfo.SetValue(target, value, null);
        }

        /// <summary>
        /// Returns a value between d1 and d2 for the percentage passed in.
        /// </summary>
        /// <param name="d1">The d1.</param>
        /// <param name="d2">The d2.</param>
        /// <param name="dPercentage">The d percentage.</param>
        /// <returns>System.Double.</returns>
        public static double interpolate(double d1, double d2, double dPercentage)
        {
            double dDifference = d2 - d1;
            double dDistance = dDifference * dPercentage;
            double dResult = d1 + dDistance;
            return dResult;
        }

        /// <summary>
        /// Returns a value betweeen i1 and i2 for the percentage passed in.
        /// </summary>
        /// <param name="i1">The i1.</param>
        /// <param name="i2">The i2.</param>
        /// <param name="dPercentage">The d percentage.</param>
        /// <returns>System.Int32.</returns>
        public static int interpolate(int i1, int i2, double dPercentage)
        {
            return (int)interpolate((double)i1, (double)i2, dPercentage);
        }

        /// <summary>
        /// Returns a value betweeen f1 and f2 for the percentage passed in.
        /// </summary>
        /// <param name="f1">The f1.</param>
        /// <param name="f2">The f2.</param>
        /// <param name="dPercentage">The d percentage.</param>
        /// <returns>System.Single.</returns>
        public static float interpolate(float f1, float f2, double dPercentage)
        {
            return (float)interpolate((double)f1, (double)f2, dPercentage);
        }

        /// <summary>
        /// Converts a fraction representing linear time to a fraction representing
        /// the distance traveled under an ease-in-ease-out transition.
        /// </summary>
        /// <param name="dElapsed">The d elapsed.</param>
        /// <returns>System.Double.</returns>
        public static double convertLinearToEaseInEaseOut(double dElapsed)
        {
            // The distance traveled is made up of two parts: the initial acceleration,
            // and then the subsequent deceleration...
            double dFirstHalfTime = (dElapsed > 0.5) ? 0.5 : dElapsed;
            double dSecondHalfTime = (dElapsed > 0.5) ? dElapsed - 0.5 : 0.0;
            double dResult = 2 * dFirstHalfTime * dFirstHalfTime + 2 * dSecondHalfTime * (1.0 - dSecondHalfTime);
            return dResult;
        }

        /// <summary>
        /// Converts a fraction representing linear time to a fraction representing
        /// the distance traveled under a constant acceleration transition.
        /// </summary>
        /// <param name="dElapsed">The d elapsed.</param>
        /// <returns>System.Double.</returns>
        public static double convertLinearToAcceleration(double dElapsed)
        {
            return dElapsed * dElapsed;
        }

        /// <summary>
        /// Converts a fraction representing linear time to a fraction representing
        /// the distance traveled under a constant deceleration transition.
        /// </summary>
        /// <param name="dElapsed">The d elapsed.</param>
        /// <returns>System.Double.</returns>
        public static double convertLinearToDeceleration(double dElapsed)
        {
            return dElapsed * (2.0 - dElapsed);
        }

        /// <summary>
        /// Fires the event passed in in a thread-safe way.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="theEvent">The event.</param>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The arguments.</param>
        /// <remarks>This method loops through the targets of the event and invokes each in turn. If the
        /// target supports ISychronizeInvoke (such as forms or controls) and is set to run
        /// on a different thread, then we call BeginInvoke to marshal the event to the target
        /// thread. If the target does not support this interface (such as most non-form classes)
        /// or we are on the same thread as the target, then the event is fired on the same
        /// thread as this is called from.</remarks>
        public static void raiseEvent<T>(EventHandler<T> theEvent, object sender, T args) where T : System.EventArgs
        {
            // Is the event set up?
            if (theEvent == null)
            {
                return;
            }

            // We loop through each of the delegate handlers for this event. For each of 
            // them we need to decide whether to invoke it on the current thread or to
            // make a cross-thread invocation...
            foreach (EventHandler<T> handler in theEvent.GetInvocationList())
            {
                try
                {
                    ISynchronizeInvoke target = handler.Target as ISynchronizeInvoke;
                    if (target == null || target.InvokeRequired == false)
                    {
                        // Either the target is not a form or control, or we are already
                        // on the right thread for it. Either way we can just fire the
                        // event as normal...
                        handler(sender, args);
                    }
                    else
                    {
                        // The target is most likely a form or control that needs the
                        // handler to be invoked on its own thread...
                        target.BeginInvoke(handler, new object[] { sender, args });
                    }
                }
                catch (Exception)
                {
                    // The event handler may have been detached while processing the events.
                    // We just ignore this and invoke the remaining handlers.
                }
            }
        }

    }
    #endregion
}
