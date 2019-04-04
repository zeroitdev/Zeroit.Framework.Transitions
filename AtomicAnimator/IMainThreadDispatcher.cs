﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="IMainThreadDispatcher.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Zeroit.Framework.Transitions.AtomicAnimator
{
    /// <summary>
    /// Called by the main thread dispatcher on the main application thread.
    /// </summary>
    /// <param name="entity">The entity that requested the callback.</param>
    /// <param name="arg">An (optional) argument that is to be passed to the entity.</param>
    internal delegate void MainThreadCallbackDelegate(IMainThreadEntity entity, object arg);

    #region IMainThreadEntity

    /// <summary>
    /// Describes an entity that can be called back on the main thread.
    /// </summary>
    /// <seealso cref="IMainThreadDispatcher"/>
    internal interface IMainThreadEntity
    {
        /// <summary>
        /// Called on the main thread by the main thread dispatcher.
        /// </summary>
        /// <param name="arg">An (optional) argument for user data.</param>
        void MainThreadCallback(object arg);
    }

    #endregion

    #region IMainThreadDispatcher

    /// <summary>
    /// Describes a "main thread dispatcher." Main thread dispatchers allow |IMainThreadEntity|s
    /// to request that they have their |MainThreadCallback| method be called back on the main
    /// thread.
    /// </summary>
    /// <seealso cref="Dispatch"/>
    /// <seealso cref="IMainThreadEntity"/>
    /// <seealso cref="MainThreadCallerControl"/>
    /// <seealso cref="MainThreadCallerWPFControl"/>
    internal interface IMainThreadDispatcher
    {
        /// <summary>
        /// Determines if a dispatch is needed (a dispatch is not needed if the caller is executing
        /// on the main thread already).
        /// </summary>
        /// <returns>True if the caller is not executing on the main thread, false otherwise.</returns>
        bool GetNeedsDispatch();

        /// <summary>
        /// Requests that an entity be called called back on the main thread.
        /// </summary>
        /// <param name="entity">The entity that is to be called back.</param>
        /// <param name="arg">The (optional) argument to pass to the entity.</param>
        void RequestMainThreadCallback(IMainThreadEntity entity, object arg);
    }

    #endregion
}
