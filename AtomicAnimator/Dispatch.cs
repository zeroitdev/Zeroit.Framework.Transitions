// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Dispatch.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
