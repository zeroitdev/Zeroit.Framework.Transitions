// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="MainThreadCallerControl.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.AtomicAnimator
{
    /// <summary>
    /// The main thread dispatcher to be used in Windows Forms applications.
    /// </summary>
    /// <remarks>
    /// This control MUST be added to the main application window, or some other
    /// control that lives for the duration of the application.
    /// </remarks>
    /// <seealso cref="IMainThreadDispatcher"/>
    internal class MainThreadCallerControl : Control, IMainThreadDispatcher
    {
        /// <summary>
        /// Initializes the object instance.
        /// </summary>
        public MainThreadCallerControl()
        {
            Dispatch.MainThreadDispatcher = this;

            this.Size = Size.Empty;
            this.Location = Point.Empty;
        }

        /// <summary>
        /// Performs the main thread callback.
        /// </summary>
        /// <param name="entity">The entity that requested the callback.</param>
        /// <param name="arg">The argument to be sent to th entity.</param>
        private void doCallback(IMainThreadEntity entity, object arg)
        {
            entity.MainThreadCallback(arg);
        }

        #region IMainThreadDispatcher Members

        /// <summary>
        /// Determines if a dispatch is needed (a dispatch is not needed if the caller is executing
        /// on the main thread already).
        /// </summary>
        /// <returns>True if the caller is not executing on the main thread, false otherwise.</returns>
        public bool GetNeedsDispatch()
        {
            return this.InvokeRequired;
        }

        /// <summary>
        /// Requests that an entity be called called back on the main thread.
        /// </summary>
        /// <param name="entity">The entity that is to be called back.</param>
        /// <param name="arg">The (optional) argument to pass to the entity.</param>
        public void RequestMainThreadCallback(IMainThreadEntity entity, object arg)
        {
            this.Invoke(new MainThreadCallbackDelegate(this.doCallback), entity, arg);
        }

        #endregion
    }
}
