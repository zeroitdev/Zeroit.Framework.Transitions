﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="TransitionWithEditor.cs" company="Zeroit Dev Technologies">
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Diagnostics;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using Zeroit.Framework.Transitions.AnimationEditors;

#endregion

namespace Zeroit.Framework.Transitions.ZeroitAnimateTransitionWithEditor
{
    #region Transition
    /// <summary>
    /// Lets you perform animated transitions of properties on arbitrary objects. These
    /// will often be transitions of UI properties, for example an animated fade-in of
    /// a UI object, or an animated move of a UI object from one position to another.
    /// <para>
    /// Each transition can simulataneously change multiple properties, including properties
    /// across multiple objects.
    /// </para><para><b><u><i>Transition methods</i></u></b><br></br>
    /// TransitionMethod objects specify how the transition is made. Examples include
    /// linear transition, ease-in-ease-out and so on. Different transition methods may
    /// need different parameters.
    /// </para><example><code>
    /// Transition t = new Transition(new TransitionMethod_Linear(500)); //Creates a new transition. You specify the transition method.
    /// t.add(form1, "Width", 500);  //Set the destination values of the properties you are animating.
    /// t.add(form1, "BackColor", Color.Red); //Set the destination values of the properties you are animating.
    /// t.run(); //Starts the transition.
    /// </code></example>
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    public class ZeroitTransitorEdit : Component
    {

        #region Variables
        //private Control _Target;
        //private int _destination = 0;
        //private Positions Position = Positions.Left;
        //private int _TransitionTime = 2000;
        //private int _No_Of_Flashes = 1;
        //private TransitionType _Transitions;

        /// <summary>
        /// The zeroit transition input
        /// </summary>
        private ZeroitTransitionInput zeroitTransitionInput =
            new ZeroitTransitionInput(TransitionType.Accelaration, 0, Positions.Left, 2000, 1);

        #region Initial Idea
        //TransitionType_Acceleration _Accelaration = new TransitionType_Acceleration(Duration);
        //TransitionType_Bounce _Bounce = new TransitionType_Bounce(Duration);
        //TransitionType_CriticalDamping _CriticalDamping = new TransitionType_CriticalDamping(Duration);
        //TransitionType_Deceleration _Deceleration = new TransitionType_Deceleration(Duration);
        //TransitionType_EaseInEaseOut _EaseInEaseOut = new TransitionType_EaseInEaseOut(Duration);
        //TransitionType_Flash _Flash = new TransitionType_Flash(No_Of_Flashes, Duration);
        //TransitionType_Linear _Linear = new TransitionType_Linear(Duration);
        //TransitionType_ThrowAndCatch _ThrowAndCatch = new TransitionType_ThrowAndCatch(Duration);
        #endregion

        #endregion

        /// <summary>
        /// Enum representing transition type.
        /// </summary>
        public enum TransitionType
        {
            /// <summary>
            /// The accelaration
            /// </summary>
            Accelaration,
            /// <summary>
            /// The bounce
            /// </summary>
            Bounce,
            /// <summary>
            /// The critical damping
            /// </summary>
            CriticalDamping,
            /// <summary>
            /// The deceleration
            /// </summary>
            Deceleration,
            /// <summary>
            /// The ease in ease out
            /// </summary>
            EaseInEaseOut,
            /// <summary>
            /// The flash
            /// </summary>
            Flash,
            /// <summary>
            /// The linear
            /// </summary>
            Linear,
            /// <summary>
            /// The zeroit
            /// </summary>
            Zeroit,
            /// <summary>
            /// The throw and catch
            /// </summary>
            ThrowAndCatch
        }

        /// <summary>
        /// Enum representing the postions for the <c><see cref="ZeroitTransitorEdit" /></c>
        /// </summary>
        public enum Positions
        {
            /// <summary>
            /// The left
            /// </summary>
            Left,
            /// <summary>
            /// The top
            /// </summary>
            Top
        }



        #region Public Properties

        /// <summary>
        /// Gets or sets the editor for getting and setting values for <c><see cref="ZeroitTransitorEdit" /></c>.
        /// </summary>
        /// <value>The editor.</value>
        public ZeroitTransitionInput Editor
        {
            get { return zeroitTransitionInput; }
            set
            {
                zeroitTransitionInput = value;
            }
        }

        /// <summary>
        /// Gets or sets the type of transitions.
        /// </summary>
        /// <value>The transitions.</value>
        public TransitionType Transitions
        {
            get { return zeroitTransitionInput.Transitions; }
            set
            {
                zeroitTransitionInput.Transitions = value;
            }
        }

        /// <summary>
        /// Gets or sets the control to use for the animation.
        /// </summary>
        /// <value>The target.</value>
        public Control Target
        {
            get { return zeroitTransitionInput.Target; }
            set
            {
                zeroitTransitionInput.Target = value;

            }
        }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>The position.</value>
        public Positions Position
        {
            get { return zeroitTransitionInput.Position; }
            set
            {
                zeroitTransitionInput.Position = value;
            }
        }

        /// <summary>
        /// Gets or sets the destination.
        /// </summary>
        /// <value>The destination.</value>
        public Int32 Destination
        {
            get { return zeroitTransitionInput.Destination; }
            set
            {
                zeroitTransitionInput.Destination = value;
            }
        }

        /// <summary>
        /// Gets or sets the duration of the animation.
        /// </summary>
        /// <value>The duration.</value>
        public Int32 Duration
        {
            get { return zeroitTransitionInput.TransitionTime; }
            set
            {
                zeroitTransitionInput.TransitionTime = value;
            }
        }

        /// <summary>
        /// Gets or sets the no of swings.
        /// </summary>
        /// <value>The no of swings.</value>
        public Int32 No_Of_Flashes
        {
            get { return zeroitTransitionInput.No_Of_Flashes; }
            set
            {
                zeroitTransitionInput.No_Of_Flashes = value;
            }
        }

        #endregion

        #region Default Constructor        
        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitTransitorEdit" /> class.
        /// </summary>
        public ZeroitTransitorEdit()
        {

        }

        #endregion

        #region Registration

        /// <summary>
        /// You should register all managed-types here.
        /// </summary>
        static ZeroitTransitorEdit()
        {
            registerType(new ManagedType_Int());
            registerType(new ManagedType_Float());
            registerType(new ManagedType_Double());
            registerType(new ManagedType_Color());
            registerType(new ManagedType_String());
        }

        #endregion

        #region Events

        /// <summary>
        /// Args passed with the TransitionCompletedEvent.
        /// </summary>
        /// <seealso cref="System.EventArgs" />
        public class Args : EventArgs
        {
        }

        /// <summary>
        /// Event raised when the transition hass completed.
        /// </summary>
        public event EventHandler<Args> TransitionCompletedEvent;

        #endregion

        #region Public static methods

        /// <summary>
        /// Creates and immediately runs a transition on the property passed in.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="strPropertyName">Name of the string property.</param>
        /// <param name="destinationValue">The destination value.</param>
        /// <param name="transitionMethod">The transition method.</param>
        public static void run(object target, string strPropertyName, object destinationValue, ITransitionType transitionMethod)
        {
            ZeroitTransitorEdit t = new ZeroitTransitorEdit(transitionMethod);
            t.add(target, strPropertyName, destinationValue);
            t.run();
        }

        /// <summary>
        /// Sets the property passed in to the initial value passed in, then creates and
        /// immediately runs a transition on it.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="strPropertyName">Name of the string property.</param>
        /// <param name="initialValue">The initial value.</param>
        /// <param name="destinationValue">The destination value.</param>
        /// <param name="transitionMethod">The transition method.</param>
        public static void run(object target, string strPropertyName, object initialValue, object destinationValue, ITransitionType transitionMethod)
        {
            Utility.setValue(target, strPropertyName, initialValue);
            run(target, strPropertyName, destinationValue, transitionMethod);
        }

        /// <summary>
        /// Creates a TransitionChain and runs it.
        /// </summary>
        /// <param name="transitions">The transitions.</param>
        public static void runChain(params ZeroitTransitorEdit[] transitions)
        {
            TransitionChain chain = new TransitionChain(transitions);
        }

        /// <summary>
        /// Starts the animation.
        /// </summary>
        public void Activate()
        {
            int x = Duration;
            int flashes = No_Of_Flashes;
            switch (Transitions)
            {
                case TransitionType.Accelaration:
                    ZeroitTransitorEdit accelerate = new ZeroitTransitorEdit(new TransitionType_Acceleration(x));
                    accelerate.add(Target, Position.ToString(), Destination);
                    accelerate.run();
                    break;
                case TransitionType.Bounce:
                    ZeroitTransitorEdit bounce = new ZeroitTransitorEdit(new TransitionType_Bounce(x));
                    bounce.add(Target, Position.ToString(), Destination);
                    bounce.run();
                    break;
                case TransitionType.CriticalDamping:
                    ZeroitTransitorEdit criticalDumping = new ZeroitTransitorEdit(new TransitionType_CriticalDamping(x));
                    criticalDumping.add(Target, Position.ToString(), Destination);
                    criticalDumping.run();
                    break;
                case TransitionType.Deceleration:
                    ZeroitTransitorEdit deceleration = new ZeroitTransitorEdit(new TransitionType_Deceleration(x));
                    deceleration.add(Target, Position.ToString(), Destination);
                    deceleration.run();
                    break;
                case TransitionType.EaseInEaseOut:
                    ZeroitTransitorEdit easeInEaseOut = new ZeroitTransitorEdit(new TransitionType_EaseInEaseOut(x));
                    easeInEaseOut.add(Target, Position.ToString(), Destination);
                    easeInEaseOut.run();
                    break;
                case TransitionType.Flash:
                    ZeroitTransitorEdit flash = new ZeroitTransitorEdit(new TransitionType_Flash(flashes, x));
                    flash.add(Target, Position.ToString(), Destination);
                    flash.run();
                    break;
                case TransitionType.Linear:
                    ZeroitTransitorEdit linear = new ZeroitTransitorEdit(new TransitionType_Linear(x));
                    linear.add(Target, Position.ToString(), Destination);
                    linear.run();
                    break;
                case TransitionType.ThrowAndCatch:
                    ZeroitTransitorEdit throwAndCatch = new ZeroitTransitorEdit(new TransitionType_ThrowAndCatch(x));
                    throwAndCatch.add(Target, Position.ToString(), Destination);
                    throwAndCatch.run();
                    break;

                case TransitionType.Zeroit:
                    ZeroitTransitorEdit zeroit = new ZeroitTransitorEdit(new TransitionType_Zeroit(x));
                    zeroit.add(Target, Position.ToString(), Destination);
                    zeroit.run();
                    break;
                default:
                    break;
            }

        }

        #endregion

        #region Public methods

        /// <summary>
        /// Constructor. You pass in the object that holds the properties
        /// that you are performing transitions on.
        /// </summary>
        /// <param name="transitionMethod">The transition method.</param>
        public ZeroitTransitorEdit(ITransitionType transitionMethod)
        {
            m_TransitionMethod = transitionMethod;
        }

        /// <summary>
        /// Adds a property that should be animated as part of this transition.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="strPropertyName">Name of the string property.</param>
        /// <param name="destinationValue">The destination value.</param>
        /// <exception cref="System.Exception">
        /// Object: " + target.ToString() + " does not have the property: " + strPropertyName
        /// or
        /// Transition does not handle properties of type: " + propertyType.ToString()
        /// or
        /// Property is not both getable and setable: " + strPropertyName
        /// </exception>
        public void add(object target, string strPropertyName, object destinationValue)
        {
            // We get the property info...
            Type targetType = target.GetType();
            PropertyInfo propertyInfo = targetType.GetProperty(strPropertyName);
            if (propertyInfo == null)
            {
                throw new Exception("Object: " + target.ToString() + " does not have the property: " + strPropertyName);
            }

            // We check that we support the property type...
            Type propertyType = propertyInfo.PropertyType;
            if (m_mapManagedTypes.ContainsKey(propertyType) == false)
            {
                throw new Exception("Transition does not handle properties of type: " + propertyType.ToString());
            }

            // We can only transition properties that are both getable and setable...
            if (propertyInfo.CanRead == false || propertyInfo.CanWrite == false)
            {
                throw new Exception("Property is not both getable and setable: " + strPropertyName);
            }

            IManagedType managedType = m_mapManagedTypes[propertyType];

            // We can manage this type, so we store the information for the
            // transition of this property...
            TransitionedPropertyInfo info = new TransitionedPropertyInfo();
            info.endValue = destinationValue;
            info.target = target;
            info.propertyInfo = propertyInfo;
            info.managedType = managedType;

            lock (m_Lock)
            {
                m_listTransitionedProperties.Add(info);
            }
        }

        /// <summary>
        /// Starts the transition.
        /// </summary>
        public void run()
        {
            // We find the current start values for the properties we 
            // are animating...
            foreach (TransitionedPropertyInfo info in m_listTransitionedProperties)
            {
                object value = info.propertyInfo.GetValue(info.target, null);
                info.startValue = info.managedType.copy(value);
            }

            // We start the stopwatch. We use this when the timer ticks to measure 
            // how long the transition has been runnning for...
            m_Stopwatch.Reset();
            m_Stopwatch.Start();

            // We register this transition with the transition manager...
            TransitionManager.getInstance().register(this);
        }

        #endregion

        #region Internal methods

        /// <summary>
        /// Property that returns a list of information about each property managed
        /// by this transition.
        /// </summary>
        /// <value>The transitioned properties.</value>
        internal IList<TransitionedPropertyInfo> TransitionedProperties
        {
            get { return m_listTransitionedProperties; }
        }

        /// <summary>
        /// We remove the property with the info passed in from the transition.
        /// </summary>
        /// <param name="info">The information.</param>
        internal void removeProperty(TransitionedPropertyInfo info)
        {
            lock (m_Lock)
            {
                m_listTransitionedProperties.Remove(info);
            }
        }

        /// <summary>
        /// Called when the transition timer ticks.
        /// </summary>
        internal void onTimer()
        {
            // When the timer ticks we:
            // a. Find the elapsed time since the transition started.
            // b. Work out the percentage movement for the properties we're managing.
            // c. Find the actual values of each property, and set them.

            // a.
            int iElapsedTime = (int)m_Stopwatch.ElapsedMilliseconds;

            // b.
            double dPercentage;
            bool bCompleted;
            m_TransitionMethod.onTimer(iElapsedTime, out dPercentage, out bCompleted);

            // We take a copy of the list of properties we are transitioning, as
            // they can be changed by another thread while this method is running...
            IList<TransitionedPropertyInfo> listTransitionedProperties = new List<TransitionedPropertyInfo>();
            lock (m_Lock)
            {
                foreach (TransitionedPropertyInfo info in m_listTransitionedProperties)
                {
                    listTransitionedProperties.Add(info.copy());
                }
            }

            // c. 
            foreach (TransitionedPropertyInfo info in listTransitionedProperties)
            {
                // We get the current value for this property...
                object value = info.managedType.getIntermediateValue(info.startValue, info.endValue, dPercentage);

                // We set it...
                PropertyUpdateArgs args = new PropertyUpdateArgs(info.target, info.propertyInfo, value);
                setProperty(this, args);
            }

            // Has the transition completed?
            if (bCompleted == true)
            {
                // We stop the stopwatch and the timer...
                m_Stopwatch.Stop();

                // We raise an event to notify any observers that the transition has completed...
                Utility.raiseEvent(TransitionCompletedEvent, this, new Args());
            }
        }

        #endregion

        #region Private functions

        /// <summary>
        /// Sets a property on the object passed in to the value passed in. This method
        /// invokes itself on the GUI thread if the property is being invoked on a GUI
        /// object.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The arguments.</param>
        private void setProperty(object sender, PropertyUpdateArgs args)
        {
            try
            {
                // If the target is a control that has been disposed then we don't 
                // try to update its properties. This can happen if the control is
                // on a form that has been closed while the transition is running...
                if (isDisposed(args.target) == true)
                {
                    return;
                }

                ISynchronizeInvoke invokeTarget = args.target as ISynchronizeInvoke;
                if (invokeTarget != null && invokeTarget.InvokeRequired)
                {
                    // There is some history behind the next two lines, which is worth
                    // going through to understand why they are the way they are.

                    // Initially we used BeginInvoke without the subsequent WaitOne for
                    // the result. A transition could involve a large number of updates
                    // to a property, and as this call was asynchronous it would send a 
                    // large number of updates to the UI thread. These would queue up at
                    // the GUI thread and mean that the UI could be some way behind where
                    // the transition was.

                    // The line was then changed to the blocking Invoke call instead. This 
                    // meant that the transition only proceded at the pace that the GUI 
                    // could process it, and the UI was not overloaded with "old" updates.

                    // However, in some circumstances Invoke could block and lock up the
                    // Transitions background thread. In particular, this can happen if the
                    // control that we are trying to update is in the process of being 
                    // disposed - for example, it is on a form that is being closed. See
                    // here for details: 
                    // http://social.msdn.microsoft.com/Forums/en-US/winforms/thread/7d2c941a-0016-431a-abba-67c5d5dac6a5

                    // To solve this, we use a combination of the two earlier approaches. 
                    // We use BeginInvoke as this does not block and lock up, even if the
                    // underlying object is being disposed. But we do want to wait to give
                    // the UI a chance to process the update. So what we do is to do the
                    // asynchronous BeginInvoke, but then wait (with a short timeout) for
                    // it to complete.
                    IAsyncResult asyncResult = invokeTarget.BeginInvoke(new EventHandler<PropertyUpdateArgs>(setProperty), new object[] { sender, args });
                    asyncResult.AsyncWaitHandle.WaitOne(50);
                }
                else
                {
                    // We are on the correct thread, so we update the property...
                    args.propertyInfo.SetValue(args.target, args.value, null);
                }
            }
            catch (Exception)
            {
                // We silently catch any exceptions. These could be things like 
                // bounds exceptions when setting properties.
            }
        }

        /// <summary>
        /// Returns true if the object passed in is a Control and is disposed
        /// or in the process of disposing. (If this is the case, we don't want
        /// to make any changes to its properties.)
        /// </summary>
        /// <param name="target">The target.</param>
        /// <returns><c>true</c> if the specified target is disposed; otherwise, <c>false</c>.</returns>
        private bool isDisposed(object target)
        {
            // Is the object passed in a Control?
            Control controlTarget = target as Control;
            if (controlTarget == null)
            {
                return false;
            }

            // Is it disposed or disposing?
            if (controlTarget.IsDisposed == true || controlTarget.Disposing)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Private static functions

        /// <summary>
        /// Registers a transition-type. We hold them in a map.
        /// </summary>
        /// <param name="transitionType">Type of the transition.</param>
        private static void registerType(IManagedType transitionType)
        {
            Type type = transitionType.getManagedType();
            m_mapManagedTypes[type] = transitionType;
        }

        #endregion

        #region Private static data

        // A map of Type info to IManagedType objects. These are all the types that we
        // know how to perform transitions on...
        /// <summary>
        /// The m map managed types
        /// </summary>
        private static IDictionary<Type, IManagedType> m_mapManagedTypes = new Dictionary<Type, IManagedType>();

        #endregion

        #region Private data

        // The transition method used by this transition...
        /// <summary>
        /// The m transition method
        /// </summary>
        private ITransitionType m_TransitionMethod = null;

        // Holds information about one property on one taregt object that we are performing
        // a transition on...
        /// <summary>
        /// Class TransitionedPropertyInfo.
        /// </summary>
        internal class TransitionedPropertyInfo
        {
            /// <summary>
            /// The start value
            /// </summary>
            public object startValue;
            /// <summary>
            /// The end value
            /// </summary>
            public object endValue;
            /// <summary>
            /// The target
            /// </summary>
            public object target;
            /// <summary>
            /// The property information
            /// </summary>
            public PropertyInfo propertyInfo;
            /// <summary>
            /// The managed type
            /// </summary>
            public IManagedType managedType;

            /// <summary>
            /// Copies this instance.
            /// </summary>
            /// <returns>TransitionedPropertyInfo.</returns>
            public TransitionedPropertyInfo copy()
            {
                TransitionedPropertyInfo info = new TransitionedPropertyInfo();
                info.startValue = startValue;
                info.endValue = endValue;
                info.target = target;
                info.propertyInfo = propertyInfo;
                info.managedType = managedType;
                return info;
            }
        }

        // The collection of properties that the current transition is animating...
        /// <summary>
        /// The m list transitioned properties
        /// </summary>
        private IList<TransitionedPropertyInfo> m_listTransitionedProperties = new List<TransitionedPropertyInfo>();

        // Helps us find the time interval from the time the transition starts to each timer tick...
        /// <summary>
        /// The m stopwatch
        /// </summary>
        private Stopwatch m_Stopwatch = new Stopwatch();

        // Event args used for the event we raise when updating a property...
        /// <summary>
        /// Class PropertyUpdateArgs.
        /// </summary>
        /// <seealso cref="System.EventArgs" />
        private class PropertyUpdateArgs : EventArgs
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="PropertyUpdateArgs"/> class.
            /// </summary>
            /// <param name="t">The t.</param>
            /// <param name="pi">The pi.</param>
            /// <param name="v">The v.</param>
            public PropertyUpdateArgs(object t, PropertyInfo pi, object v)
            {
                target = t;
                propertyInfo = pi;
                value = v;
            }
            /// <summary>
            /// The target
            /// </summary>
            public object target;
            /// <summary>
            /// The property information
            /// </summary>
            public PropertyInfo propertyInfo;
            /// <summary>
            /// The value
            /// </summary>
            public object value;
        }

        // An object used to lock the list of transitioned properties, as it can be 
        // accessed by multiple threads...
        /// <summary>
        /// The m lock
        /// </summary>
        private object m_Lock = new object();

        #endregion
    }
    
    #endregion
}
