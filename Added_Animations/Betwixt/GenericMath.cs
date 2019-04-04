// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2017
// ***********************************************************************
// <copyright file="GenericMath.cs" company="Zeroit Dev Technologies">
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
using System.Linq.Expressions;

namespace Zeroit.Framework.Transitions.Betwixt
{
    /// <summary>
    /// Generic math handlers for performing basic operations on unknown types
    /// </summary>
    /// <remarks>
    /// This is really bad but surprisingly not as slow as it could be, once they're used once for a specific
    /// type they're compiled and are fairly efficient. These functions are only used if the user does not
    /// specify their own lerp function.
    /// </remarks>
    internal static class GenericMath
    {
        /// <summary>
        /// Add two generics together
        /// </summary>
        /// <typeparam name="T">Type of elements</typeparam>
        /// <param name="a">First element</param>
        /// <param name="b">Second element</param>
        /// <returns>a + b</returns>
        public static T Add<T>(T a, T b)
        {
            ParameterExpression paramA = Expression.Parameter(typeof(T), "a");
            ParameterExpression paramB = Expression.Parameter(typeof(T), "b");

            BinaryExpression body = Expression.Add(paramA, paramB);

            Func<T, T, T> add = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();

            return add(a, b);
        }

        /// <summary>
        /// Subtract a generic from a generic
        /// </summary>
        /// <typeparam name="T">Type of elements</typeparam>
        /// <param name="a">First element</param>
        /// <param name="b">Second element</param>
        /// <returns>a - b</returns>
        public static T Subtract<T>(T a, T b)
        {
            ParameterExpression paramA = Expression.Parameter(typeof(T), "a");
            ParameterExpression paramB = Expression.Parameter(typeof(T), "b");

            BinaryExpression body = Expression.Subtract(paramA, paramB);

            Func<T, T, T> subtract = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();

            return subtract(a, b);
        }

        /// <summary>
        /// Multiply a generic with a float
        /// </summary>
        /// <typeparam name="T">Type of generic</typeparam>
        /// <param name="a">Generic element</param>
        /// <param name="b">Float element</param>
        /// <returns>a * b</returns>
        public static T Multiply<T>(T a, float b)
        {
            ParameterExpression paramA = Expression.Parameter(typeof(T), "a");
            ParameterExpression paramB = Expression.Parameter(typeof(float), "b");

            BinaryExpression body = Expression.Multiply(paramA, paramB);

            Func<T, float, T> multiply = Expression.Lambda<Func<T, float, T>>(body, paramA, paramB).Compile();

            return multiply(a, b);
        }
    }
}
