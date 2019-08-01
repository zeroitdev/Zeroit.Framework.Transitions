// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="MainThreadCallerControl.cs" company="Zeroit Dev Technologies">
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

using System.ComponentModel;
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
    [ToolboxItem(false)]
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
