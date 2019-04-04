// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2017
// ***********************************************************************
// <copyright file="GenericEaseImpl.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

using Zeroit.Framework.Transitions.Betwixt.Annotations;

namespace Zeroit.Framework.Transitions.Betwixt
{
    /// <summary>
    /// Generic Implementation to help create IEase function sets, and pipes ease functions to eachother automatically
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.Betwixt.IEase" />
    [UsedImplicitly]
    internal class GenericEaseImpl : IEase
    {
        /// <summary>
        /// The ease in function
        /// </summary>
        private readonly EaseFunc _easeInFunc;
        /// <summary>
        /// The ease out function
        /// </summary>
        private readonly EaseFunc _easeOutFunc;
        /// <summary>
        /// The ease in out function
        /// </summary>
        private readonly EaseFunc _easeInOutFunc;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericEaseImpl"/> class.
        /// </summary>
        /// <param name="easeInFunc">The ease in function.</param>
        /// <param name="easeOutFunc">The ease out function.</param>
        /// <param name="easeInOutFunc">The ease in out function.</param>
        /// <exception cref="Exception">Both in and out arguments none, this should not happen! This is bad.</exception>
        private GenericEaseImpl(EaseFunc easeInFunc, EaseFunc easeOutFunc, EaseFunc easeInOutFunc)
        {
            if (easeInFunc == null && easeOutFunc == null)
            {
                throw new Exception("Both in and out arguments none, this should not happen! This is bad.");
            }

            // If there's no In function, create one generically (from Out)
            _easeInFunc    = easeInFunc    ?? GenericIn;

            // If there's no Out function, create one generically (from In)
            _easeOutFunc   = easeOutFunc   ?? GenericOut;

            // If there's no InOut function, create one generically (from Out)
            _easeInOutFunc = easeInOutFunc ?? GenericInOut;
        }

        /// <summary>
        /// Create a new Generic Implementation set from an Out ease, and an optional InOut ease.
        /// </summary>
        /// <param name="easeOutFunc">Out ease function</param>
        /// <param name="easeInOutFunc">Optional InOut ease function</param>
        /// <returns>A new Generic Ease Set</returns>
        public static GenericEaseImpl FromOut(EaseFunc easeOutFunc, EaseFunc easeInOutFunc = null)
        {
            return new GenericEaseImpl(null, easeOutFunc, easeInOutFunc);
        }

        /// <summary>
        /// Create a new Generic Implementation set from an In ease, and an optional InOut ease.
        /// </summary>
        /// <param name="easeInFunc">In ease function</param>
        /// <param name="easeInOutFunc">Optional InOut ease function</param>
        /// <returns>A new Generic Ease Set</returns>
        public static GenericEaseImpl FromIn(EaseFunc easeInFunc, EaseFunc easeInOutFunc = null)
        {
            return new GenericEaseImpl(easeInFunc, null, easeInOutFunc);
        }

        /// <summary>
        /// Create a new Generic Implementation set from a full set of ease functions, and an optional InOut ease.
        /// </summary>
        /// <param name="easeInFunc">In ease function</param>
        /// <param name="easeOutFunc">Out ease function</param>
        /// <param name="easeInOutFunc">Optional InOut ease function</param>
        /// <returns>A new Generic Ease Set</returns>
        public static GenericEaseImpl From(EaseFunc easeInFunc, EaseFunc easeOutFunc, EaseFunc easeInOutFunc = null)
        {
            return new GenericEaseImpl(easeInFunc, easeOutFunc, easeInOutFunc);
        }

        #region Generic Non-Specified Functions
        /// <summary>
        /// Create an In ease from an Out ease
        /// </summary>
        /// <param name="percent">The percent.</param>
        /// <returns>System.Single.</returns>
        private float GenericIn(float percent)
        {
            return Ease.Generic.Reverse(percent, Out);
        }

        /// <summary>
        /// Create an Out ease from an In ease
        /// </summary>
        /// <param name="percent">The percent.</param>
        /// <returns>System.Single.</returns>
        private float GenericOut(float percent)
        {
            return Ease.Generic.Reverse(percent, In);
        }

        /// <summary>
        /// Create an InOut ease from an Out ease
        /// </summary>
        /// <param name="percent">The percent.</param>
        /// <returns>System.Single.</returns>
        private float GenericInOut(float percent)
        {
            return Ease.Generic.InOut(percent, Out);
        }
        #endregion

        /// <summary>
        /// Call the stored Ease In function
        /// </summary>
        /// <param name="percent">Progress along ease function where 0-1 is 0%-100%</param>
        /// <returns>Eased percent value</returns>
        public float In(float percent)
        {
            return _easeInFunc(percent);
        }

        /// <summary>
        /// Call the stored Ease Out function
        /// </summary>
        /// <param name="percent">Progress along ease function where 0-1 is 0%-100%</param>
        /// <returns>Eased percent value</returns>
        public float Out(float percent)
        {
            return _easeOutFunc(percent);
        }

        /// <summary>
        /// Call the stored Ease InOut function
        /// </summary>
        /// <param name="percent">Progress along ease function where 0-1 is 0%-100%</param>
        /// <returns>Eased percent value</returns>
        public float InOut(float percent)
        {
            return _easeInOutFunc(percent);
        }
    }
}