// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="MainThreadCallerWPFControl.xaml.cs" company="Zeroit Dev Technologies">
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

using System.Windows.Controls;
using System.Threading;


namespace Zeroit.Framework.Transitions.AtomicAnimator
{
    /// <summary>
    /// The main thread dispatcher to be used in WPF applications.
    /// </summary>
    /// <remarks>
    /// This control MUST be added to the main application window, or some other
    /// control that lives for the duration of the application.
    /// </remarks>
    /// <seealso cref="IMainThreadDispatcher"/>
    internal partial class MainThreadCallerWPFControl : Control, IMainThreadDispatcher
    {
        /// <summary>
        /// Initializes the object instance.
        /// </summary>
        public MainThreadCallerWPFControl()
        {
            InitializeComponent();
            Dispatch.MainThreadDispatcher = this;
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
            return this.Dispatcher.Thread != Thread.CurrentThread;
        }

        /// <summary>
        /// Requests that an entity be called called back on the main thread.
        /// </summary>
        /// <param name="entity">The entity that is to be called back.</param>
        /// <param name="arg">The (optional) argument to pass to the entity.</param>
        public void RequestMainThreadCallback(IMainThreadEntity entity, object arg)
        {
            this.Dispatcher.Invoke(new MainThreadCallbackDelegate(this.doCallback), entity, arg);
        }

        #endregion
    }

    internal partial class MainThreadCallerWPFControl : System.Windows.Controls.Control, System.Windows.Markup.IComponentConnector
    {

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FormSpark;component/mainthreadcallerwpfcontrol.xaml", System.UriKind.Relative);

#line 1 "..\..\MainThreadCallerWPFControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }
    }
}
