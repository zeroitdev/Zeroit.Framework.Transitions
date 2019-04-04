// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ExampleFoldAnimation.cs" company="Zeroit Dev Technologies">
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
using System.Linq;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.Transitions
{
    #region ExampleFoldAnimation
    /// <summary>
    /// Class ExampleFoldAnimation.
    /// </summary>
    public class ExampleFoldAnimation
    {
        /// <summary>
        /// The cancellation tokens
        /// </summary>
        private List<Zeroit.Framework.Transitions.AnimationStatus> _cancellationTokens;

        /// <summary>
        /// Gets the control.
        /// </summary>
        /// <value>The control.</value>
        public Control Control { get; private set; }

        /// <summary>
        /// Gets or sets the maximum size.
        /// </summary>
        /// <value>The maximum size.</value>
        public System.Drawing.Size MaxSize { get; set; }

        /// <summary>
        /// Gets or sets the minimum size.
        /// </summary>
        /// <value>The minimum size.</value>
        public System.Drawing.Size MinSize { get; set; }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        /// <value>The duration.</value>
        public int Duration { get; set; }

        /// <summary>
        /// Gets or sets the delay.
        /// </summary>
        /// <value>The delay.</value>
        public int Delay { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleFoldAnimation"/> class.
        /// </summary>
        /// <param name="control">The control.</param>
        public ExampleFoldAnimation(Control control)
        {
            _cancellationTokens = new List<Zeroit.Framework.Transitions.AnimationStatus>();

            this.Control = control;
            this.MaxSize = control.Size;
            this.MinSize = control.MinimumSize;
            this.Duration = 1000;
            this.Delay = 0;
        }

        /// <summary>
        /// Shows this instance.
        /// </summary>
        public void Show()
        {
            int duration = this.Duration;
            if (_cancellationTokens.Any(animation => !animation.IsCompleted))
            {
                var token = _cancellationTokens.First(animation => !animation.IsCompleted);
                duration = (int)(token.ElapsedMilliseconds);
            }

            //cancel hide animation if in progress
            this.Cancel();

            var cT1 = this.Control.Animate(new HorizontalFoldEffect(),
                EasingFunctions.CircEaseIn, this.MaxSize.Height, duration, this.Delay);

            var cT2 = this.Control.Animate(new VerticalFoldEffect(),
                EasingFunctions.CircEaseOut, this.MaxSize.Width, duration, this.Delay);

            _cancellationTokens.Add(cT1);
            _cancellationTokens.Add(cT2);
        }

        /// <summary>
        /// Hides this instance.
        /// </summary>
        public void Hide()
        {
            int duration = this.Duration;

            if (_cancellationTokens.Any(animation => !animation.IsCompleted))
            {
                var token = _cancellationTokens.First(animation => !animation.IsCompleted);
                duration = (int)(token.ElapsedMilliseconds);
            }

            //cancel show animation if in progress
            this.Cancel();


            var cT1 = this.Control.Animate(new HorizontalFoldEffect(),
                EasingFunctions.CircEaseOut, this.MinSize.Height, duration, this.Delay);

            var cT2 = this.Control.Animate(new VerticalFoldEffect(),
                EasingFunctions.CircEaseIn, this.MinSize.Width, duration, this.Delay);

            _cancellationTokens.Add(cT1);
            _cancellationTokens.Add(cT2);
        }

        /// <summary>
        /// Cancels this instance.
        /// </summary>
        public void Cancel()
        {
            foreach (var token in _cancellationTokens)
                token.CancellationToken.Cancel();

            _cancellationTokens.Clear();
        }

    }
    #endregion
}
