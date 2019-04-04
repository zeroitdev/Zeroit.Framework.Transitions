// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ZeroitAnimate_Tweener.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.TweenerAnimator
{
    /// <summary>
    /// Class ZeroitTweener.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    [ToolboxItem(true)]
    public class ZeroitTweener : Component
    {
        #region Variables
        /// <summary>
        /// The target
        /// </summary>
        private Control target;
        /// <summary>
        /// The x
        /// </summary>
        private int x = 100; // To X
        /// <summary>
        /// The y
        /// </summary>
        private int y = 100; // To X
        /// <summary>
        /// The duration
        /// </summary>
        private float duration = 5f;
        /// <summary>
        /// The delay
        /// </summary>
        private float delay = 0f;
        #endregion

        /// <summary>
        /// Expectedtargets this instance.
        /// </summary>
        public void Expectedtarget()
        {
            System.Windows.Forms.MessageBox.Show("Action Completed");
        }

        #region Properties

        /// <summary>
        /// Gets or sets the target.
        /// </summary>
        /// <value>The target.</value>
        public Control Target
        {
            get { return target; }
            set
            {
                target = value;
            }
        }

        /// <summary>
        /// Gets or sets the x.
        /// </summary>
        /// <value>The x.</value>
        public int X
        {
            get { return x; }
            set
            {
                x = target.Location.X + value;
            }
        }

        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        /// <value>The y.</value>
        public int Y
        {
            get { return y; }
            set
            {
                y = target.Location.Y + value;
            }
        }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        /// <value>The duration.</value>
        public float Duration
        {
            get { return duration; }
            set
            {
                duration = value;
            }
        }

        /// <summary>
        /// Gets or sets the delay.
        /// </summary>
        /// <value>The delay.</value>
        public float Delay
        {
            get { return delay; }
            set
            {
                delay = value;
            }
        }

        #endregion




        /// <summary>
        /// Activates the specified property name.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="valueSets">The value sets.</param>
        public void Activate(string propertyName, object valueSets)
        {
            // Get the Type object corresponding to MyClass.
            //Type myType = typeof(Control);
            // Get the PropertyInfo object by passing the property name.
            //PropertyInfo myPropInfo = myType.GetProperty(propertyName);
            

            //	This tween will move the X and Y properties of the target
            //UnglideInfo unglideInfo = new UnglideInfo(Target, myPropInfo.Name);
            
            var TweenAnimator = new Tweener();
            
            TweenAnimator.AddTween(new Tween());
            TweenAnimator.Tween(target, new { Value = 100}, duration, delay);
            //TweenAnimator.Tween(Target, unglideInfo.Value = valueSets, duration, delay);
            
            
            //TweenAnimator.Tween(target.BackgroundImage, new { X = x, Y = y }, duration, delay);
            TweenAnimator.Update(30);
            TweenAnimator.Timer(duration, delay); 

        }
    }
}
