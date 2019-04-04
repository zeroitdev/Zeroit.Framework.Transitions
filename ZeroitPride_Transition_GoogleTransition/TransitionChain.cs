// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="TransitionChain.cs" company="Zeroit Dev Technologies">
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

using System.Collections.Generic;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.Transitions.FormSpark.GoogleTransition
{
    #region TransitionChain
    /// <summary>
    /// Class TransitionChain.
    /// </summary>
    internal class TransitionChain
    {
        #region Public methods

        /// <summary>
        /// Initializes a new instance of the <see cref="TransitionChain"/> class.
        /// </summary>
        /// <param name="transitions">The transitions.</param>
        public TransitionChain(params ZeroitPrideAnim[] transitions)
        {
            // We store the list of transitions...
            foreach (ZeroitPrideAnim transition in transitions)
            {
                m_listTransitions.AddLast(transition);
            }

            // We start running them...
            runNextTransition();
        }

        #endregion

        #region Private functions

        /// <summary>
        /// Runs the next transition in the list.
        /// </summary>
        private void runNextTransition()
        {
            if (m_listTransitions.Count == 0)
            {
                return;
            }

            // We find the next transition and run it. We also register
            // for its completed event, so that we can start the next transition
            // when this one completes...
            ZeroitPrideAnim nextTransition = m_listTransitions.First.Value;
            nextTransition.TransitionCompletedEvent += onTransitionCompleted;
            nextTransition.run();
        }

        /// <summary>
        /// Called when the transition we have just run has completed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void onTransitionCompleted(object sender, ZeroitPrideAnim.Args e)
        {
            // We unregister from the completed event...
            ZeroitPrideAnim transition = (ZeroitPrideAnim)sender;
            transition.TransitionCompletedEvent -= onTransitionCompleted;

            // We remove the completed transition from our collection, and
            // run the next one...
            m_listTransitions.RemoveFirst();
            runNextTransition();
        }

        #endregion

        #region Private data

        // The list of transitions in the chain...
        /// <summary>
        /// The m list transitions
        /// </summary>
        private LinkedList<ZeroitPrideAnim> m_listTransitions = new LinkedList<ZeroitPrideAnim>();

        #endregion
    }
    #endregion
}
