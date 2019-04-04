// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ValueAnimator.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using Zeroit.Framework.Transitions.AtomicAnimator.ValueHandlers;

namespace Zeroit.Framework.Transitions.AtomicAnimator
{
    /// <summary>
    /// A utility class used to manage value handlers.
    /// </summary>
    /// <remarks>
    /// Currently sets up built-in value handlers for:
    ///   * int
    ///   * long
    ///   * float
    ///   * double
    ///   * System.DateTime
    ///   * System.Drawing.Color
    ///   * System.Drawing.Point
    ///   * System.Drawing.PointF
    ///   * System.Drawing.Size
    ///   * System.Drawing.SizeF
    ///   * System.Drawing.Rectangle
    ///   * System.Drawing.RectangleF
    ///   * System.Windows.Media.Color
    /// 
    /// Any additional value handlers MUST be registed with this class.
    /// </remarks>
    /// <seealso cref="IValueHandler"/>
    public class ValueAnimator
    {
        /// <summary>
        /// The shared instance for the FormSpark API.
        /// </summary>
        public static readonly ValueAnimator Shared = new ValueAnimator();

        private Dictionary<Type, object> m_valueHandlers = new Dictionary<Type, object>();

        /// <summary>
        /// Initializes the object instance.
        /// </summary>
        public ValueAnimator()
        {
            // setup default value handlers
            this.RegisterValueHandler<int>(new IntValueHandler());
            this.RegisterValueHandler<long>(new LongValueHandler());
            this.RegisterValueHandler<float>(new FloatValueHandler());
            this.RegisterValueHandler<double>(new DoubleValueHandler());
            this.RegisterValueHandler<DateTime>(new DateTimeValueHandler());

            // setup the default WinForms value handlers
            this.RegisterValueHandler<System.Drawing.Color>(new ColorValueHandler());
            this.RegisterValueHandler<System.Drawing.Point>(new PointValueHandler());
            this.RegisterValueHandler<System.Drawing.Size>(new SizeValueHandler());
            this.RegisterValueHandler<System.Drawing.Rectangle>(new RectangleValueHandler());
            this.RegisterValueHandler<System.Drawing.PointF>(new PointFValueHandler());
            this.RegisterValueHandler<System.Drawing.SizeF>(new SizeFValueHandler());
            this.RegisterValueHandler<System.Drawing.RectangleF>(new RectangleFValueHandler());

            // setup the default WPF value handlers
            this.RegisterValueHandler<System.Windows.Media.Color>(new WPFColorValueHandler());
        }

        /// <summary>
        /// Registers a value handler.
        /// </summary>
        /// <typeparam name="T">The type the value handler manages.</typeparam>
        /// <param name="handler">The value handler.</param>
        public void RegisterValueHandler<T>(IValueHandler<T> handler)
        {
            this.m_valueHandlers[typeof(T)] = handler;
        }

        /// <summary>
        /// Gets a registered value handler for a specified type.
        /// </summary>
        /// <typeparam name="T">The managed type.</typeparam>
        /// <returns>
        /// The registered value handler for the type or null if no value handler is registered
        /// for the specified type.
        /// </returns>
        public IValueHandler<T> GetRegisteredValueHandler<T>()
        {
            Type t = typeof(T);

            if (!this.m_valueHandlers.ContainsKey(t))
            {
                return null;
            }

            return (IValueHandler<T>)this.m_valueHandlers[t];
        }

        /// <summary>
        /// Interpolates two values.
        /// </summary>
        /// <typeparam name="T">The type of the value to interpolate.</typeparam>
        /// <param name="from">The from value.</param>
        /// <param name="to">The to value.</param>
        /// <param name="amount">The interpolation amount.</param>
        /// <returns>
        /// The interpolated value or the default value for T if no value handler is registered
        /// for the specified type.
        /// </returns>
        /// <seealso cref="IValueHandler"/>
        /// <remarks>
        /// Internally this method uses |T| to lookup the proper value handler then
        /// calls the value handlers |Interpolate| method.
        /// </remarks>
        public T Interpolate<T>(T from, T to, float amount)
        {
            IValueHandler<T> handler = this.GetRegisteredValueHandler<T>();

            if (handler == null)
            {
                return default(T);
            }

            return handler.Interpolate(from, to, amount);
        }
    }
}
