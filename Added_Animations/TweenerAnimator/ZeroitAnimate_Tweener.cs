// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ZeroitAnimate_Tweener.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
