// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Dispatch.cs" company="Zeroit Dev Technologies">
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

using System.Threading;

namespace Zeroit.Framework.Transitions.AtomicAnimator
{
    /// <summary>
    /// Internal utility class used for simplifying dispatching work items to the .NET thread pool.
    /// This can clean up our code since we can use Lamda expressions, allowing us to have a way
    /// to write small clean work items.
    /// </summary>
    internal static class Dispatch
    {
        /// <summary>
        /// The main thread dispatcher for this application.
        /// </summary>
        /// <seealso cref="IMainThreadDispatcher"/>
        internal static IMainThreadDispatcher MainThreadDispatcher;

        /// <summary>
        /// Delegate describing our "work items." They take no arguments and return nothing.
        /// </summary>
        public delegate void DispatchTaskDelegate();

        /// <summary>
        /// Dispatches a work item to the thread pool.
        /// </summary>
        /// <param name="del">The work item to dispatch.</param>
        public static void Run(DispatchTaskDelegate del)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(runTask), del);
        }

        /// <summary>
        /// Called by the thread pool to actually run the work item.
        /// </summary>
        /// <param name="arg">The work item to run.</param>
        private static void runTask(object arg)
        {
            DispatchTaskDelegate del = (DispatchTaskDelegate)arg;
            del();
        }
    }
}
