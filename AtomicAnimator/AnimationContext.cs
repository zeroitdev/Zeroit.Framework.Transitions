// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 08-17-2017
// ***********************************************************************
// <copyright file="AnimationContext.cs" company="Zeroit Dev Technologies">
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

using System;
using System.Collections.Generic;
using System.Reflection;

using Zeroit.Framework.Transitions.AtomicAnimator.AnimationCurves;

namespace Zeroit.Framework.Transitions.AtomicAnimator
{
    /// <summary>
    /// Describes a list of animations on object properties.
    /// </summary>
    public class AnimationContext
    {
        /// <summary>
        /// The default value for animations requring that the property be set on the main thread.
        /// </summary>
        public static bool DefaultRequiresMainThread = true;

        /// <summary>
        /// An animation context has completed all animations.
        /// </summary>
        /// <param name="context">The animation context that completed.</param>
        public delegate void AnimationContextCompletedDelegate(AnimationContext context);

        #region InvalidPropertyException

        /// <summary>
        /// Thrown when the specified property to animate doesn't exist or doesn't have
        /// the correct type.
        /// </summary>
        /// <seealso cref="System.ArgumentException" />
        /// <seealso cref="ArgumentException" />
        public class InvalidPropertyException : ArgumentException
        {
            /// <summary>
            /// The m name
            /// </summary>
            private string m_name;

            /// <summary>
            /// Initiaizes the exception.
            /// </summary>
            /// <param name="propName">The name of the invalid property.</param>
            public InvalidPropertyException(string propName)
                : base("An invalid property was specified (does not exist or has wrong type).", propName)
            {
                this.m_name = propName;
            }

            /// <summary>
            /// The name of the invalid property.
            /// </summary>
            /// <value>The name of the property.</value>
            public string PropertyName
            {
                get
                {
                    return this.m_name;
                }
            }
        }

        #endregion

        #region DescriptorKey

        /// <summary>
        /// Class DescriptorKey.
        /// </summary>
        /// <typeparam name="For">The type of for.</typeparam>
        /// <typeparam name="T"></typeparam>
        internal class DescriptorKey<For, T>
        {
            /// <summary>
            /// The m object
            /// </summary>
            private object m_obj;
            /// <summary>
            /// The m name
            /// </summary>
            private string m_name;

            /// <summary>
            /// Initializes a new instance of the <see cref="DescriptorKey{For, T}"/> class.
            /// </summary>
            /// <param name="obj">The object.</param>
            /// <param name="name">The name.</param>
            /// <exception cref="ArgumentNullException">
            /// obj
            /// or
            /// name
            /// </exception>
            public DescriptorKey(object obj, string name)
            {
                if (obj == null)
                {
                    throw new ArgumentNullException("obj");
                }
                else if (name == null)
                {
                    throw new ArgumentNullException("name");
                }

                this.m_obj = obj;
                this.m_name = name;
            }

            /// <summary>
            /// Gets the name of the property.
            /// </summary>
            /// <value>The name of the property.</value>
            public string PropertyName
            {
                get
                {
                    return this.m_name;
                }
            }

            /// <summary>
            /// Gets the type of the object.
            /// </summary>
            /// <value>The type of the object.</value>
            public Type ObjectType
            {
                get
                {
                    return typeof(For);
                }
            }

            /// <summary>
            /// Gets the type of the property.
            /// </summary>
            /// <value>The type of the property.</value>
            public Type PropertyType
            {
                get
                {
                    return typeof(ValueType);
                }
            }

            /// <summary>
            /// Returns a hash code for this instance.
            /// </summary>
            /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
            public override int GetHashCode()
            {
                return this.m_obj.GetHashCode() ^ this.ObjectType.GetHashCode() ^ this.ObjectType.GetHashCode() ^ this.m_name.GetHashCode();
            }
        }

        #endregion

        #region IDescriptor

        /// <summary>
        /// Interface IDescriptor
        /// </summary>
        internal interface IDescriptor
        {
            /// <summary>
            /// Interpolates the specified amount.
            /// </summary>
            /// <param name="amount">The amount.</param>
            void Interpolate(float amount);
        }

        #endregion

        #region Descriptor

        /// <summary>
        /// Class Descriptor.
        /// </summary>
        /// <typeparam name="For">The type of for.</typeparam>
        /// <typeparam name="T"></typeparam>
        /// <seealso cref="Zeroit.Framework.Transitions.AtomicAnimator.AnimationContext.IDescriptor" />
        /// <seealso cref="Zeroit.Framework.Transitions.AtomicAnimator.IMainThreadEntity" />
        internal class Descriptor<For, T> : IDescriptor, IMainThreadEntity
        {
            /// <summary>
            /// The m from
            /// </summary>
            private T m_from;
            /// <summary>
            /// The m to
            /// </summary>
            private T m_to;
            /// <summary>
            /// The m current
            /// </summary>
            private T m_current;
            /// <summary>
            /// The m name
            /// </summary>
            private string m_name;
            /// <summary>
            /// The m automatic get
            /// </summary>
            private bool m_autoGet;
            /// <summary>
            /// The m requires main thread
            /// </summary>
            private bool m_requiresMainThread;
            /// <summary>
            /// The m error
            /// </summary>
            private bool m_error;

            /// <summary>
            /// The m object
            /// </summary>
            private For m_obj;
            /// <summary>
            /// The m information
            /// </summary>
            private PropertyInfo m_info;

            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            /// <value>The name.</value>
            /// <exception cref="ArgumentException">
            /// The specified property must be writable. - (Property Name)
            /// or
            /// The specified property must be readable. - (Property Name)
            /// </exception>
            internal string Name
            {
                get
                {
                    return this.m_name;
                }
                set
                {
                    this.m_name = value;

                    this.m_info = typeof(For).GetProperty(this.m_name, typeof(T));

                    if (this.m_info == null)
                    {
                        this.m_error = true;

                        if (Dispatch.MainThreadDispatcher != null)
                        {
                            Dispatch.MainThreadDispatcher.RequestMainThreadCallback(this, null);
                            return;
                        }
                    }

                    if (!this.m_info.CanWrite)
                    {
                        throw new ArgumentException("The specified property must be writable.", "(Property Name)");
                    }

                    if (this.m_autoGet)
                    {
                        if (!this.m_info.CanRead)
                        {
                            throw new ArgumentException("The specified property must be readable.", "(Property Name)");
                        }

                        this.m_from = (T)this.m_info.GetValue(this.m_obj, null);
                        this.m_current = this.m_from;
                    }
                }
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="Descriptor{For, T}"/> class.
            /// </summary>
            /// <param name="obj">The object.</param>
            /// <param name="from">From.</param>
            /// <param name="to">To.</param>
            /// <exception cref="ArgumentNullException">obj</exception>
            public Descriptor(For obj, T from, T to)
            {
                this.m_from = from;
                this.m_to = to;
                this.m_current = m_from;

                if (obj == null)
                {
                    throw new ArgumentNullException("obj");
                }

                this.m_obj = obj;
                this.m_autoGet = false;
                this.m_requiresMainThread = AnimationContext.DefaultRequiresMainThread;
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="Descriptor{For, T}"/> class.
            /// </summary>
            /// <param name="obj">The object.</param>
            /// <param name="to">To.</param>
            public Descriptor(For obj, T to)
                : this(obj, default(T), to)
            {
                this.m_autoGet = true;
            }

            /// <summary>
            /// Gets or sets a value indicating whether [requires main thread].
            /// </summary>
            /// <value><c>true</c> if [requires main thread]; otherwise, <c>false</c>.</value>
            public bool RequiresMainThread
            {
                get
                {
                    return this.m_requiresMainThread;
                }
                set
                {
                    this.m_requiresMainThread = value;
                }
            }

            /// <summary>
            /// Interpolates the specified amount.
            /// </summary>
            /// <param name="amount">The amount.</param>
            public void Interpolate(float amount)
            {
                this.m_current = ValueAnimator.Shared.Interpolate<T>(this.m_from, this.m_to, amount);

                if (this.m_requiresMainThread)
                {
                    if (Dispatch.MainThreadDispatcher != null)
                    {
                        if (Dispatch.MainThreadDispatcher.GetNeedsDispatch())
                        {
                            Dispatch.MainThreadDispatcher.RequestMainThreadCallback(this, null);
                        }
                        else
                        {
                            this.m_info.SetValue(this.m_obj, this.m_current, null);
                        }
                    }
                }
                else
                {
                    this.m_info.SetValue(this.m_obj, this.m_current, null);
                }
            }

            /// <summary>
            /// Called on the main thread by the main thread dispatcher.
            /// </summary>
            /// <param name="arg">An (optional) argument for user data.</param>
            /// <exception cref="Zeroit.Framework.Transitions.AtomicAnimator.AnimationContext.InvalidPropertyException"></exception>
            public void MainThreadCallback(object arg)
            {
                if (this.m_error)
                {
                    throw new InvalidPropertyException(this.m_name);
                }

                this.m_info.SetValue(this.m_obj, this.m_current, null);
            }
        }

        #endregion

        /// <summary>
        /// The m descriptors
        /// </summary>
        private Dictionary<object, IDescriptor> m_descriptors = new Dictionary<object, IDescriptor>();
        /// <summary>
        /// The m curve
        /// </summary>
        private IAnimationCurve m_curve;
        /// <summary>
        /// The m keep after completed
        /// </summary>
        private bool m_keepAfterCompleted = false;
        /// <summary>
        /// The m loops
        /// </summary>
        private bool m_loops = false;
        /// <summary>
        /// The m reverses
        /// </summary>
        private bool m_reverses = false;
        /// <summary>
        /// The m increasing
        /// </summary>
        private bool m_increasing = true;
        /// <summary>
        /// The m completed
        /// </summary>
        private bool m_completed = false;
        /// <summary>
        /// The m segment completed
        /// </summary>
        private bool m_segmentCompleted = false;

        /// <summary>
        /// Fired when all animations in this context have completed.
        /// </summary>
        /// <remarks>There is no guarantee as to which thread this will be called from.</remarks>
        public event AnimationContextCompletedDelegate AnimationContextCompleted;

        #region Constructors

        /// <summary>
        /// Initializes the animation context with the default animation curve
        /// |AnimationCurve.Default|.
        /// </summary>
        public AnimationContext()
        {
            this.m_curve = AnimationCurve.Default;
        }

        /// <summary>
        /// Initializes the animation context with the specified
        /// animation curve.
        /// </summary>
        /// <param name="curve">The animation curve</param>
        /// <exception cref="ArgumentNullException">Thrown if |curve| is null.</exception>
        public AnimationContext(IAnimationCurve curve)
        {
            if (curve == null)
            {
                throw new ArgumentNullException("curve");
            }

            this.m_curve = curve;
        }

        #endregion

        #region AddDescriptor

        /// <summary>
        /// Adds an animation descriptor.
        /// </summary>
        /// <typeparam name="For">The type of the object that we are animating.</typeparam>
        /// <typeparam name="T">The type of the property that we are animating.</typeparam>
        /// <param name="key">The descriptor key.</param>
        /// <param name="desc">The animation descriptor.</param>
        /// <exception cref="ArgumentNullException">Thrown if either |key| or |desc| are null.</exception>
        internal void AddDescriptor<For, T>(DescriptorKey<For, T> key, Descriptor<For, T> desc)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key");
            }
            else if (desc == null)
            {
                throw new ArgumentNullException("desc");
            }

            desc.Name = key.PropertyName;

            lock (this.m_descriptors)
            {
                this.m_descriptors[key] = desc;
            }
        }

        #endregion

        #region AddAnimation(...)

        /// <summary>
        /// Adds an animation to the context.
        /// </summary>
        /// <typeparam name="For">The type of the object.</typeparam>
        /// <typeparam name="T">The type of the parameter.</typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="from">The from value.</param>
        /// <param name="to">The to value.</param>
        /// <param name="propName">The name of the property to animate.</param>
        /// <param name="requiresMainThread">Does the property have to be set on the main thread?</param>
        public void AddAnimation<For, T>(For obj, T from, T to, string propName, bool requiresMainThread)
        {
            DescriptorKey<For, T> key = new DescriptorKey<For, T>(obj, propName);
            Descriptor<For, T> desc = new Descriptor<For, T>(obj, from, to);
            desc.RequiresMainThread = requiresMainThread;

            this.AddDescriptor<For, T>(key, desc);
        }

        /// <summary>
        /// Adds an animation to the context.
        /// </summary>
        /// <typeparam name="For">The type of the object.</typeparam>
        /// <typeparam name="T">The type of the parameter.</typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="from">The from value.</param>
        /// <param name="to">The to value.</param>
        /// <param name="propName">The name of the property to animate.</param>
        public void AddAnimation<For, T>(For obj, T from, T to, string propName)
        {
            AddAnimation<For, T>(obj, from, to, propName, AnimationContext.DefaultRequiresMainThread);
        }

        /// <summary>
        /// Adds an animation to the context.
        /// </summary>
        /// <typeparam name="For">The type of the object.</typeparam>
        /// <typeparam name="T">The type of the parameter.</typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="to">The to value.</param>
        /// <param name="propName">The name of the property to animate.</param>
        /// <param name="requiresMainThread">Does the property have to be set on the main thread?</param>
        public void AddAnimation<For, T>(For obj, T to, string propName, bool requiresMainThread)
        {
            DescriptorKey<For, T> key = new DescriptorKey<For, T>(obj, propName);
            Descriptor<For, T> desc = new Descriptor<For, T>(obj, to);
            desc.RequiresMainThread = requiresMainThread;

            this.AddDescriptor<For, T>(key, desc);
        }

        /// <summary>
        /// Adds an animation to the context.
        /// </summary>
        /// <typeparam name="For">The type of the object.</typeparam>
        /// <typeparam name="T">The type of the parameter.</typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="to">The to value.</param>
        /// <param name="propName">The name of the property to animate.</param>
        public void AddAnimation<For, T>(For obj, T to, string propName)
        {
            AddAnimation<For, T>(obj, to, propName, AnimationContext.DefaultRequiresMainThread);
        }

        #endregion

        #region Update

        /// <summary>
        /// Internally used by the API to update the context.
        /// </summary>
        /// <param name="elapsed">The time delta.</param>
        internal void Update(float elapsed)
        {
            // if we have completed then there is nothing else for us to do
            if (this.Completed)
            {
                return;
            }

            float amount;

            // get the interpolation value to use from our
            // animation curve
            if (this.m_increasing)
            {
                amount = this.m_curve.Update(elapsed);
                this.m_segmentCompleted = this.m_curve.GetElapsed() >= this.m_curve.GetDuration();
            }
            else
            {
                amount = this.m_curve.Update(-elapsed);
                this.m_segmentCompleted = this.m_curve.GetElapsed() <= 0.0f;
            }

            // interpolate each of our descriptors
            lock (this.m_descriptors)
            {
                foreach (IDescriptor desc in this.m_descriptors.Values)
                {
                    desc.Interpolate(amount);
                }
            }

            // check to see if our "segment" has completed
            // a normal animation has only 1 segment (from->to)
            // an animation that reverses has 2 segments (from->to, to->from)
            // and an animation that loops has an infinite number of segments
            if (this.m_segmentCompleted)
            {
                this.m_segmentCompleted = false;

                if (this.Reverses)
                {
                    // this animation reverses so check to see if the animation
                    // loops too
                    if (!this.m_increasing && !this.m_loops)
                    {
                        // it doesn't and we just completed the second segment
                        // to this context has finished

                        this.m_completed = true;

                        if (this.AnimationContextCompleted != null)
                        {
                            this.AnimationContextCompleted(this);
                        }

                        return;
                    }
                    else
                    {
                        // switch our direction
                        this.m_increasing = !this.m_increasing;
                    }
                }
                else if (this.Loops)
                {
                    // we loop but don't reverse so start over
                    this.m_curve.SetElapsed(0.0f);
                }
                else
                {
                    // we don't loop or reverse so we have finished

                    this.m_completed = true;

                    if (this.AnimationContextCompleted != null)
                    {
                        this.AnimationContextCompleted(this);
                    }
                }
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// The animation curve that the animation context uses.
        /// </summary>
        /// <value>The curve.</value>
        /// <remarks>After the animation context has started, it is best not to call
        /// anything but this curve's getters.</remarks>
        public IAnimationCurve Curve
        {
            get
            {
                return this.m_curve;
            }
        }

        /// <summary>
        /// Has the animation context completed?
        /// </summary>
        /// <value><c>true</c> if completed; otherwise, <c>false</c>.</value>
        /// <remarks>This property is read-only.</remarks>
        public bool Completed
        {
            get
            {
                if (this.m_keepAfterCompleted)
                {
                    return false;
                }

                return this.m_completed;
            }
        }

        /// <summary>
        /// Determines if this context should be kept after completing.
        /// </summary>
        /// <value><c>true</c> if [keep after completed]; otherwise, <c>false</c>.</value>
        /// <seealso cref="Loops" />
        /// <remarks>This is automatically set to the same value as |Loops|.</remarks>
        public bool KeepAfterCompleted
        {
            get
            {
                return this.m_keepAfterCompleted;
            }
            set
            {
                this.m_keepAfterCompleted = value;
            }
        }

        /// <summary>
        /// Determines if this context loops infinitely.
        /// </summary>
        /// <value><c>true</c> if loops; otherwise, <c>false</c>.</value>
        /// <seealso cref="KeepAfterCompleted" />
        /// <remarks>The value of |KeepAfterCompleted| is set to the same value
        /// of |Loops| when |Loops| is changed.</remarks>
        public bool Loops
        {
            get
            {
                return this.m_loops;
            }
            set
            {
                this.m_loops = value;
                this.m_keepAfterCompleted = value;
            }
        }

        /// <summary>
        /// Determines if this context reverses when it finishes animating
        /// from the "from" value to the "to" value.
        /// </summary>
        /// <value><c>true</c> if reverses; otherwise, <c>false</c>.</value>
        public bool Reverses
        {
            get
            {
                return this.m_reverses;
            }
            set
            {
                this.m_reverses = value;
            }
        }

        #endregion
    }
}
