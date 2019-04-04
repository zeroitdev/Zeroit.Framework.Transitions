// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ExampleFoldAnimation.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
