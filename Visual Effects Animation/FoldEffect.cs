// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FoldEffect.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
using System.Collections.Generic;
using System.Linq;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.Transitions
{
    #region FoldEffect
    /// <summary>
    /// Class FoldEffect.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.IEffect" />
    public class FoldEffect : IEffect
    {
        /// <summary>
        /// Gets the interaction.
        /// </summary>
        /// <value>The interaction.</value>
        public EffectInteractions Interaction
        {
            get { return EffectInteractions.BOUNDS; }
        }

        /// <summary>
        /// Gets the current value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>System.Int32.</returns>
        public int GetCurrentValue(System.Windows.Forms.Control control)
        {
            return control.Width * control.Height;
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="originalValue">The original value.</param>
        /// <param name="valueToReach">The value to reach.</param>
        /// <param name="newValue">The new value.</param>
        public void SetValue(System.Windows.Forms.Control control, int originalValue, int valueToReach, int newValue)
        {
            int actualValueChange = Math.Abs(originalValue - valueToReach);
            int currentValue = this.GetCurrentValue(control);

            double absoluteChangePerc = ((double)((originalValue - newValue) * 100)) / actualValueChange;
            absoluteChangePerc = Math.Abs(absoluteChangePerc);

            if (absoluteChangePerc > 100.0f)
                return;
        }

        /// <summary>
        /// Gets the minimum value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>System.Int32.</returns>
        public int GetMinimumValue(System.Windows.Forms.Control control)
        {
            if (control.MinimumSize.IsEmpty)
                return 0;

            return control.MinimumSize.Width * control.MinimumSize.Height;
        }

        /// <summary>
        /// Gets the maximum value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>System.Int32.</returns>
        public int GetMaximumValue(System.Windows.Forms.Control control)
        {
            if (control.MaximumSize.IsEmpty)
                return Int32.MaxValue;

            return control.MaximumSize.Width * control.MaximumSize.Height;
        }

        /// <summary>
        /// The cancellation tokens
        /// </summary>
        private List<Zeroit.Framework.Transitions.AnimationStatus> _cancellationTokens;

        /// <summary>
        /// Gets or sets the control.
        /// </summary>
        /// <value>The control.</value>
        public Control Control { get; set; }

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
        /// Initializes a new instance of the <see cref="FoldEffect"/> class.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="delay">The delay.</param>
        /// <param name="show">if set to <c>true</c> [show].</param>
        /// <param name="horizontal">The horizontal.</param>
        /// <param name="vertical">The vertical.</param>
        public FoldEffect(Control control, int duration, int delay , bool show,
            ZeroitVisAnim.EasingFunctionTypes horizontal, 
            ZeroitVisAnim.EasingFunctionTypes vertical
            )
        {
            _cancellationTokens = new List<Zeroit.Framework.Transitions.AnimationStatus>();

            this.Control = control;
            this.MaxSize = control.Size;
            this.MinSize = control.MinimumSize;
            this.Duration = duration;
            this.Delay = delay;

            if (show)
            {
                Show(horizontal,vertical);
            }
            else
            {
                Hide(horizontal, vertical);
            }
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FoldEffect"/> class.
        /// </summary>
        /// <param name="control">The control.</param>
        public FoldEffect(Control control)
        {
            _cancellationTokens = new List<Zeroit.Framework.Transitions.AnimationStatus>();

            this.Control = control;
            this.MaxSize = Control.Size;
            this.MinSize = Control.MinimumSize;
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
        /// Shows the specified horizontal.
        /// </summary>
        /// <param name="horizontal">The horizontal.</param>
        /// <param name="vertical">The vertical.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// horizontal - null
        /// or
        /// horizontal - null
        /// </exception>
        public void Show(ZeroitVisAnim.EasingFunctionTypes horizontal, ZeroitVisAnim.EasingFunctionTypes vertical)
        {
            int duration = this.Duration;
            if (_cancellationTokens.Any(animation => !animation.IsCompleted))
            {
                var token = _cancellationTokens.First(animation => !animation.IsCompleted);
                duration = (int)(token.ElapsedMilliseconds);
            }

            //cancel hide animation if in progress
            this.Cancel();

            switch (horizontal)
            {
                case ZeroitVisAnim.EasingFunctionTypes.BackEaseIn:
                    var cH1 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.BackEaseIn, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH1);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BackEaseInOut:
                    var cH2 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.BackEaseInOut, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH2);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BackEaseOut:
                    var cH3 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.BackEaseOut, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH3);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BackEaseOutIn:
                    var cH4 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.BackEaseOutIn, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH4);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BounceEaseIn:
                    var cH5 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.BounceEaseIn, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH5);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BounceEaseInOut:
                    var cH6 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.BounceEaseInOut, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH6);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BounceEaseOut:
                    var cH7 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.BounceEaseOut, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH7);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BounceEaseOutIn:
                    var cH8 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.BounceEaseOutIn, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH8);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CircEaseIn:
                    var cH9 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.CircEaseIn, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH9);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CircEaseInOut:
                    var cH10 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.CircEaseInOut, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH10);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CircEaseOut:
                    var cH11 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.CircEaseOut, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH11);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CircEaseOutIn:
                    var cH12 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.CircEaseOutIn, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH12);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CubicEaseIn:
                    var cH13 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.CubicEaseIn, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH13);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CubicEaseInOut:
                    var cH14 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.CubicEaseInOut, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH14);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CubicEaseOut:
                    var cH15 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.CubicEaseOut, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH15);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CubicEaseOutIn:
                    var cH16 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.CubicEaseOutIn, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH16);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ElasticEaseIn:
                    var cH17 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.ElasticEaseIn, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH17);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ElasticEaseInOut:
                    var cH18 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.ElasticEaseInOut, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH18);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ElasticEaseOut:
                    var cH19 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.ElasticEaseOut, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH19);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ElasticEaseOutIn:
                    var cH20 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.ElasticEaseOutIn, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH20);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ExpoEaseIn:
                    var cH21 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.ExpoEaseIn, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH21);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ExpoEaseInOut:
                    var cH22 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.ExpoEaseInOut, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH22);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ExpoEaseOut:
                    var cH23 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.ExpoEaseOut, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH23);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ExpoEaseOutIn:
                    var cH24 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.ExpoEaseOutIn, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH24);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.Linear:
                    var cH25 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.Linear, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH25);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuadEaseIn:
                    var cH26 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuadEaseIn, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH26);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuadEaseInOut:
                    var cH27 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuadEaseInOut, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH27);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuadEaseOut:
                    var cH28 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuadEaseOut, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH28);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuadEaseOutIn:
                    var cH29 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuadEaseOutIn, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH29);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuartEaseIn:
                    var cH30 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuartEaseIn, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH30);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuartEaseInOut:
                    var cH31 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuartEaseInOut, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH31);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuartEaseOut:
                    var cH32 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuartEaseOut, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH32);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuartEaseOutIn:
                    var cH33 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuartEaseOutIn, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH33);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuintEaseIn:
                    var cH34 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuintEaseIn, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH34);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuintEaseInOut:
                    var cH35 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuintEaseInOut, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH35);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuintEaseOut:
                    var cH36 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuintEaseOut, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH36);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuintEaseOutIn:
                    var cH37 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuintEaseOutIn, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH37);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.SineEaseIn:
                    var cH38 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.SineEaseIn, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH38);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.SineEaseInOut:
                    var cH39 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.SineEaseInOut, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH39);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.SineEaseOut:
                    var cH40 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.SineEaseOut, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH40);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.SineEaseOutIn:
                    var cH41 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.SineEaseOutIn, this.MaxSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH41);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(horizontal), horizontal, null);
            }

            switch (vertical)
            {
                case ZeroitVisAnim.EasingFunctionTypes.BackEaseIn:
                    var cH1 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.BackEaseIn, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH1);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BackEaseInOut:
                    var cH2 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.BackEaseInOut, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH2);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BackEaseOut:
                    var cH3 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.BackEaseOut, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH3);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BackEaseOutIn:
                    var cH4 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.BackEaseOutIn, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH4);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BounceEaseIn:
                    var cH5 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.BounceEaseIn, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH5);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BounceEaseInOut:
                    var cH6 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.BounceEaseInOut, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH6);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BounceEaseOut:
                    var cH7 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.BounceEaseOut, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH7);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BounceEaseOutIn:
                    var cH8 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.BounceEaseOutIn, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH8);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CircEaseIn:
                    var cH9 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.CircEaseIn, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH9);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CircEaseInOut:
                    var cH10 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.CircEaseInOut, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH10);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CircEaseOut:
                    var cH11 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.CircEaseOut, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH11);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CircEaseOutIn:
                    var cH12 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.CircEaseOutIn, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH12);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CubicEaseIn:
                    var cH13 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.CubicEaseIn, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH13);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CubicEaseInOut:
                    var cH14 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.CubicEaseInOut, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH14);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CubicEaseOut:
                    var cH15 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.CubicEaseOut, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH15);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CubicEaseOutIn:
                    var cH16 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.CubicEaseOutIn, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH16);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ElasticEaseIn:
                    var cH17 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.ElasticEaseIn, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH17);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ElasticEaseInOut:
                    var cH18 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.ElasticEaseInOut, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH18);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ElasticEaseOut:
                    var cH19 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.ElasticEaseOut, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH19);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ElasticEaseOutIn:
                    var cH20 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.ElasticEaseOutIn, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH20);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ExpoEaseIn:
                    var cH21 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.ExpoEaseIn, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH21);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ExpoEaseInOut:
                    var cH22 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.ExpoEaseInOut, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH22);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ExpoEaseOut:
                    var cH23 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.ExpoEaseOut, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH23);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ExpoEaseOutIn:
                    var cH24 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.ExpoEaseOutIn, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH24);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.Linear:
                    var cH25 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.Linear, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH25);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuadEaseIn:
                    var cH26 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuadEaseIn, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH26);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuadEaseInOut:
                    var cH27 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuadEaseInOut, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH27);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuadEaseOut:
                    var cH28 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuadEaseOut, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH28);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuadEaseOutIn:
                    var cH29 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuadEaseOutIn, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH29);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuartEaseIn:
                    var cH30 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuartEaseIn, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH30);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuartEaseInOut:
                    var cH31 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuartEaseInOut, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH31);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuartEaseOut:
                    var cH32 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuartEaseOut, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH32);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuartEaseOutIn:
                    var cH33 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuartEaseOutIn, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH33);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuintEaseIn:
                    var cH34 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuintEaseIn, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH34);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuintEaseInOut:
                    var cH35 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuintEaseInOut, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH35);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuintEaseOut:
                    var cH36 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuintEaseOut, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH36);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuintEaseOutIn:
                    var cH37 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuintEaseOutIn, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH37);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.SineEaseIn:
                    var cH38 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.SineEaseIn, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH38);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.SineEaseInOut:
                    var cH39 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.SineEaseInOut, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH39);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.SineEaseOut:
                    var cH40 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.SineEaseOut, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH40);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.SineEaseOutIn:
                    var cH41 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.SineEaseOutIn, this.MaxSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH41);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(horizontal), horizontal, null);
            }


            //var cT1 = this.Control.Animate(new HorizontalFoldEffect(),
            //    EasingFunctions.CircEaseIn, this.MaxSize.Height, duration, this.Delay);

            //var cT2 = this.Control.Animate(new VerticalFoldEffect(),
            //    EasingFunctions.CircEaseOut, this.MaxSize.Width, duration, this.Delay);

            //_cancellationTokens.Add(cT1);
            //_cancellationTokens.Add(cT2);
        }

        /// <summary>
        /// Hides the specified horizontal.
        /// </summary>
        /// <param name="horizontal">The horizontal.</param>
        /// <param name="vertical">The vertical.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// horizontal - null
        /// or
        /// horizontal - null
        /// </exception>
        public void Hide(ZeroitVisAnim.EasingFunctionTypes horizontal, ZeroitVisAnim.EasingFunctionTypes vertical)
        {
            int duration = this.Duration;

            if (_cancellationTokens.Any(animation => !animation.IsCompleted))
            {
                var token = _cancellationTokens.First(animation => !animation.IsCompleted);
                duration = (int)(token.ElapsedMilliseconds);
            }

            //cancel show animation if in progress
            this.Cancel();

            switch (horizontal)
            {
                case ZeroitVisAnim.EasingFunctionTypes.BackEaseIn:
                    var cH1 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.BackEaseIn, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH1);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BackEaseInOut:
                    var cH2 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.BackEaseInOut, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH2);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BackEaseOut:
                    var cH3 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.BackEaseOut, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH3);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BackEaseOutIn:
                    var cH4 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.BackEaseOutIn, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH4);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BounceEaseIn:
                    var cH5 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.BounceEaseIn, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH5);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BounceEaseInOut:
                    var cH6 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.BounceEaseInOut, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH6);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BounceEaseOut:
                    var cH7 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.BounceEaseOut, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH7);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BounceEaseOutIn:
                    var cH8 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.BounceEaseOutIn, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH8);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CircEaseIn:
                    var cH9 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.CircEaseIn, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH9);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CircEaseInOut:
                    var cH10 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.CircEaseInOut, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH10);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CircEaseOut:
                    var cH11 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.CircEaseOut, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH11);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CircEaseOutIn:
                    var cH12 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.CircEaseOutIn, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH12);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CubicEaseIn:
                    var cH13 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.CubicEaseIn, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH13);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CubicEaseInOut:
                    var cH14 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.CubicEaseInOut, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH14);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CubicEaseOut:
                    var cH15 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.CubicEaseOut, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH15);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CubicEaseOutIn:
                    var cH16 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.CubicEaseOutIn, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH16);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ElasticEaseIn:
                    var cH17 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.ElasticEaseIn, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH17);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ElasticEaseInOut:
                    var cH18 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.ElasticEaseInOut, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH18);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ElasticEaseOut:
                    var cH19 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.ElasticEaseOut, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH19);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ElasticEaseOutIn:
                    var cH20 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.ElasticEaseOutIn, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH20);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ExpoEaseIn:
                    var cH21 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.ExpoEaseIn, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH21);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ExpoEaseInOut:
                    var cH22 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.ExpoEaseInOut, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH22);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ExpoEaseOut:
                    var cH23 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.ExpoEaseOut, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH23);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ExpoEaseOutIn:
                    var cH24 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.ExpoEaseOutIn, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH24);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.Linear:
                    var cH25 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.Linear, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH25);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuadEaseIn:
                    var cH26 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuadEaseIn, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH26);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuadEaseInOut:
                    var cH27 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuadEaseInOut, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH27);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuadEaseOut:
                    var cH28 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuadEaseOut, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH28);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuadEaseOutIn:
                    var cH29 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuadEaseOutIn, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH29);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuartEaseIn:
                    var cH30 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuartEaseIn, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH30);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuartEaseInOut:
                    var cH31 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuartEaseInOut, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH31);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuartEaseOut:
                    var cH32 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuartEaseOut, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH32);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuartEaseOutIn:
                    var cH33 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuartEaseOutIn, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH33);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuintEaseIn:
                    var cH34 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuintEaseIn, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH34);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuintEaseInOut:
                    var cH35 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuintEaseInOut, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH35);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuintEaseOut:
                    var cH36 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuintEaseOut, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH36);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuintEaseOutIn:
                    var cH37 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.QuintEaseOutIn, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH37);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.SineEaseIn:
                    var cH38 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.SineEaseIn, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH38);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.SineEaseInOut:
                    var cH39 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.SineEaseInOut, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH39);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.SineEaseOut:
                    var cH40 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.SineEaseOut, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH40);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.SineEaseOutIn:
                    var cH41 = this.Control.Animate(new HorizontalFoldEffect(),
                        EasingFunctions.SineEaseOutIn, this.MinSize.Height, duration, this.Delay);
                    _cancellationTokens.Add(cH41);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(horizontal), horizontal, null);
            }

            switch (vertical)
            {
                case ZeroitVisAnim.EasingFunctionTypes.BackEaseIn:
                    var cH1 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.BackEaseIn, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH1);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BackEaseInOut:
                    var cH2 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.BackEaseInOut, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH2);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BackEaseOut:
                    var cH3 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.BackEaseOut, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH3);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BackEaseOutIn:
                    var cH4 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.BackEaseOutIn, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH4);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BounceEaseIn:
                    var cH5 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.BounceEaseIn, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH5);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BounceEaseInOut:
                    var cH6 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.BounceEaseInOut, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH6);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BounceEaseOut:
                    var cH7 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.BounceEaseOut, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH7);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.BounceEaseOutIn:
                    var cH8 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.BounceEaseOutIn, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH8);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CircEaseIn:
                    var cH9 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.CircEaseIn, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH9);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CircEaseInOut:
                    var cH10 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.CircEaseInOut, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH10);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CircEaseOut:
                    var cH11 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.CircEaseOut, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH11);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CircEaseOutIn:
                    var cH12 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.CircEaseOutIn, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH12);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CubicEaseIn:
                    var cH13 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.CubicEaseIn, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH13);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CubicEaseInOut:
                    var cH14 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.CubicEaseInOut, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH14);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CubicEaseOut:
                    var cH15 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.CubicEaseOut, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH15);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.CubicEaseOutIn:
                    var cH16 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.CubicEaseOutIn, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH16);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ElasticEaseIn:
                    var cH17 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.ElasticEaseIn, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH17);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ElasticEaseInOut:
                    var cH18 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.ElasticEaseInOut, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH18);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ElasticEaseOut:
                    var cH19 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.ElasticEaseOut, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH19);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ElasticEaseOutIn:
                    var cH20 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.ElasticEaseOutIn, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH20);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ExpoEaseIn:
                    var cH21 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.ExpoEaseIn, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH21);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ExpoEaseInOut:
                    var cH22 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.ExpoEaseInOut, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH22);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ExpoEaseOut:
                    var cH23 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.ExpoEaseOut, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH23);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.ExpoEaseOutIn:
                    var cH24 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.ExpoEaseOutIn, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH24);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.Linear:
                    var cH25 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.Linear, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH25);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuadEaseIn:
                    var cH26 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuadEaseIn, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH26);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuadEaseInOut:
                    var cH27 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuadEaseInOut, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH27);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuadEaseOut:
                    var cH28 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuadEaseOut, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH28);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuadEaseOutIn:
                    var cH29 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuadEaseOutIn, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH29);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuartEaseIn:
                    var cH30 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuartEaseIn, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH30);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuartEaseInOut:
                    var cH31 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuartEaseInOut, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH31);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuartEaseOut:
                    var cH32 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuartEaseOut, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH32);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuartEaseOutIn:
                    var cH33 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuartEaseOutIn, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH33);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuintEaseIn:
                    var cH34 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuintEaseIn, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH34);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuintEaseInOut:
                    var cH35 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuintEaseInOut, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH35);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuintEaseOut:
                    var cH36 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuintEaseOut, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH36);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.QuintEaseOutIn:
                    var cH37 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.QuintEaseOutIn, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH37);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.SineEaseIn:
                    var cH38 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.SineEaseIn, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH38);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.SineEaseInOut:
                    var cH39 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.SineEaseInOut, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH39);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.SineEaseOut:
                    var cH40 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.SineEaseOut, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH40);
                    break;
                case ZeroitVisAnim.EasingFunctionTypes.SineEaseOutIn:
                    var cH41 = this.Control.Animate(new VerticalFoldEffect(),
                        EasingFunctions.SineEaseOutIn, this.MinSize.Width, duration, this.Delay);
                    _cancellationTokens.Add(cH41);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(horizontal), horizontal, null);
            }




            //var cT1 = this.Control.Animate(new HorizontalFoldEffect(),
            //    EasingFunctions.CircEaseOut, this.MinSize.Height, duration, this.Delay);

            //var cT2 = this.Control.Animate(new VerticalFoldEffect(),
            //    EasingFunctions.CircEaseIn, this.MinSize.Width, duration, this.Delay);

            //_cancellationTokens.Add(cT1);
            //_cancellationTokens.Add(cT2);
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
