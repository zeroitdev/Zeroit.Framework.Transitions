// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="TransitionChain.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System.Collections.Generic;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.Transitions
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
        public TransitionChain(params ZeroitTransitor[] transitions)
        {
            // We store the list of transitions...
            foreach (ZeroitTransitor transition in transitions)
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
            ZeroitTransitor nextTransition = m_listTransitions.First.Value;
            nextTransition.TransitionCompletedEvent += onTransitionCompleted;
            nextTransition.run();
        }

        /// <summary>
        /// Called when the transition we have just run has completed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void onTransitionCompleted(object sender, ZeroitTransitor.Args e)
        {
            // We unregister from the completed event...
            ZeroitTransitor transition = (ZeroitTransitor)sender;
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
        private LinkedList<ZeroitTransitor> m_listTransitions = new LinkedList<ZeroitTransitor>();

        #endregion
    }
    #endregion
}
