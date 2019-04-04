﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="TransitionManager.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System.Collections.Generic;
using System.Timers;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.Transitions.ZeroitAnimateTransitionWithEditor
{

    #region TransitionManager
    /// <summary>
    /// This class is responsible for running transitions. It holds the timer that
    /// triggers transition animation.
    /// </summary>
    /// <remarks>This class is a singleton.
    /// We manage the transition timer here so that we can have a single timer
    /// across all transitions. If each transition has its own timer, this creates
    /// one thread for each transition, and this can lead to too many threads in
    /// an application.
    /// This class essentially just manages the timer for the transitions. It calls
    /// back into the running transitions, which do the actual work of the transition.</remarks>
    internal class TransitionManager
    {
        #region Public methods

        /// <summary>
        /// Singleton's getInstance method.
        /// </summary>
        /// <returns>TransitionManager.</returns>
        public static TransitionManager getInstance()
        {
            if (m_Instance == null)
            {
                m_Instance = new TransitionManager();
            }
            return m_Instance;
        }

        /// <summary>
        /// You register a transition with the manager here. This will start to run
        /// the transition as the manager's timer ticks.
        /// </summary>
        /// <param name="transition">The transition.</param>
        public void register(ZeroitTransitorEdit transition)
        {
            lock (m_Lock)
            {
                // We check to see if the properties of this transition
                // are already being animated by any existing transitions...
                removeDuplicates(transition);

                // We add the transition to the collection we manage, and 
                // observe it so that we know when it has completed...
                m_Transitions[transition] = true;
                transition.TransitionCompletedEvent += onTransitionCompleted;
            }
        }


        #endregion

        #region Private functions

        /// <summary>
        /// Checks if any existing transitions are acting on the same properties as the
        /// transition passed in. If so, we remove the duplicated properties from the
        /// older transitions.
        /// </summary>
        /// <param name="transition">The transition.</param>
        private void removeDuplicates(ZeroitTransitorEdit transition)
        {
            // We look through the set of transitions we're currently managing...
            foreach (KeyValuePair<ZeroitTransitorEdit, bool> pair in m_Transitions)
            {
                removeDuplicates(transition, pair.Key);
            }
        }

        /// <summary>
        /// Finds any properties in the old-transition that are also in the new one,
        /// and removes them from the old one.
        /// </summary>
        /// <param name="newTransition">The new transition.</param>
        /// <param name="oldTransition">The old transition.</param>
        private void removeDuplicates(ZeroitTransitorEdit newTransition, ZeroitTransitorEdit oldTransition)
        {
            // Note: This checking might be a bit more efficient if it did the checking
            //       with a set rather than looking through lists. That said, it is only done 
            //       when transitions are added (which isn't very often) rather than on the
            //       timer, so I don't think this matters too much.

            // We get the list of properties for the old and new transitions...
            IList<ZeroitTransitorEdit.TransitionedPropertyInfo> newProperties = newTransition.TransitionedProperties;
            IList<ZeroitTransitorEdit.TransitionedPropertyInfo> oldProperties = oldTransition.TransitionedProperties;

            // We loop through the old properties backwards (as we may be removing 
            // items from the list if we find a match)...
            for (int i = oldProperties.Count - 1; i >= 0; i--)
            {
                // We get one of the properties from the old transition...
                ZeroitTransitorEdit.TransitionedPropertyInfo oldProperty = oldProperties[i];

                // Is this property part of the new transition?
                foreach (ZeroitTransitorEdit.TransitionedPropertyInfo newProperty in newProperties)
                {
                    if (oldProperty.target == newProperty.target
                        &&
                        oldProperty.propertyInfo == newProperty.propertyInfo)
                    {
                        // The old transition contains the same property as the new one,
                        // so we remove it from the old transition...
                        oldTransition.removeProperty(oldProperty);
                    }
                }
            }
        }

        /// <summary>
        /// Private constructor (for singleton).
        /// </summary>
        private TransitionManager()
        {
            m_Timer = new System.Timers.Timer(15);
            m_Timer.Elapsed += onTimerElapsed;
            m_Timer.Enabled = true;
        }

        /// <summary>
        /// Called when the timer ticks.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="ElapsedEventArgs"/> instance containing the event data.</param>
        private void onTimerElapsed(object sender, ElapsedEventArgs e)
        {
            // We turn the timer off while we process the tick, in case the
            // actions take longer than the tick itself...
            if (m_Timer == null)
            {
                return;
            }
            m_Timer.Enabled = false;

            IList<ZeroitTransitorEdit> listTransitions;
            lock (m_Lock)
            {
                // We take a copy of the collection of transitions as elements 
                // might be removed as we iterate through it...
                listTransitions = new List<ZeroitTransitorEdit>();
                foreach (KeyValuePair<ZeroitTransitorEdit, bool> pair in m_Transitions)
                {
                    listTransitions.Add(pair.Key);
                }
            }

            // We tick the timer for each transition we're managing...
            foreach (ZeroitTransitorEdit transition in listTransitions)
            {
                transition.onTimer();
            }

            // We restart the timer...
            m_Timer.Enabled = true;
        }

        /// <summary>
        /// Called when a transition has completed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void onTransitionCompleted(object sender, ZeroitTransitorEdit.Args e)
        {
            // We stop observing the transition...
            ZeroitTransitorEdit transition = (ZeroitTransitorEdit)sender;
            transition.TransitionCompletedEvent -= onTransitionCompleted;

            // We remove the transition from the collection we're managing...
            lock (m_Lock)
            {
                m_Transitions.Remove(transition);
            }
        }

        #endregion

        #region Private data

        // The singleton instance...
        /// <summary>
        /// The m instance
        /// </summary>
        private static TransitionManager m_Instance = null;

        // The collection of transitions we're managing. (This should really be a set.)
        /// <summary>
        /// The m transitions
        /// </summary>
        private IDictionary<ZeroitTransitorEdit, bool> m_Transitions = new Dictionary<ZeroitTransitorEdit, bool>();

        // The timer that controls the transition animation...
        /// <summary>
        /// The m timer
        /// </summary>
        private System.Timers.Timer m_Timer = null;

        // An object to lock on. This class can be accessed by multiple threads: the 
        // user thread can add new transitions; and the timerr thread can be animating 
        // them. As they access the same collections, the methods need to be protected 
        // by a lock...
        /// <summary>
        /// The m lock
        /// </summary>
        private object m_Lock = new object();

        #endregion
    }
    #endregion

}
