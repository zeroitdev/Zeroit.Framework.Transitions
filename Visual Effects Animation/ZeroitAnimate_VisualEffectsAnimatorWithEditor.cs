// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ZeroitAnimate_VisualEffectsAnimatorWithEditor.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using Zeroit.Framework.Transitions.AnimationEditors;

#endregion

namespace Zeroit.Framework.Transitions
{
    #region ZeroitVisAnim

    /// <summary>
    /// A class collection that provides animation functionality.
    /// <para>This animator comes with a built in editor</para>
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    public class ZeroitVisAnimEdit : Component
    {
        /// <summary>
        /// The visual effects input
        /// </summary>
        private VisualEffectsInput visualEffectsInput = new VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType.XLocationEffect,
            ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
            0, 2, 20, 10, 321, 2000, 0, true, 1, new Control(),"");

        #region Variables
        //private Control _Target;
        /// <summary>
        /// The animation type
        /// </summary>
        private IEffect _AnimationType = new XLocationEffect();
        //private double Easing_currentTime = 0;
        //private double Easing_minValue = 2;
        //private double Easing_maxValue = 20;
        //private double Easing_duration = 10;
        //private double easingFunctions;
        //private int _ValueToReach = 321;
        //private int _Duration = 2000;
        //private int _Delay = 0;
        //private bool _Reverse = false;
        //private int _Loops = 1;
        //public GetAnimationType _GetAnimationType;
        //private EasingFunctionTypes _EasingFunctionTypes;

        /// <summary>
        /// The fold show
        /// </summary>
        private FoldMethod foldShow = FoldMethod.Show;
        //private FoldSizes foldSizes = new FoldSizes();

        #endregion

        #region Properties            
        /// <summary>
        /// Gets or sets the visual effects input. This provides an editor for setting the values.
        /// </summary>
        /// <value>The visual effects input.</value>
        public VisualEffectsInput Editor
        {
            get { return visualEffectsInput; }
            set
            {
                visualEffectsInput = value;
            }
        }

        /// <summary>
        /// Sets the type of easing for the <c><see cref="ZeroitVisAnimEdit" /></c> animator.
        /// </summary>
        public enum EasingFunctionTypes
        {
            #region EasingFunctions
            /// <summary>
            /// The back ease in
            /// </summary>
            BackEaseIn,
            /// <summary>
            /// The back ease in out
            /// </summary>
            BackEaseInOut,
            /// <summary>
            /// The back ease out
            /// </summary>
            BackEaseOut,
            /// <summary>
            /// The back ease out in
            /// </summary>
            BackEaseOutIn,
            /// <summary>
            /// The bounce ease in
            /// </summary>
            BounceEaseIn,
            /// <summary>
            /// The bounce ease in out
            /// </summary>
            BounceEaseInOut,
            /// <summary>
            /// The bounce ease out
            /// </summary>
            BounceEaseOut,
            /// <summary>
            /// The bounce ease out in
            /// </summary>
            BounceEaseOutIn,
            /// <summary>
            /// The circ ease in
            /// </summary>
            CircEaseIn,
            /// <summary>
            /// The circ ease in out
            /// </summary>
            CircEaseInOut,
            /// <summary>
            /// The circ ease out
            /// </summary>
            CircEaseOut,
            /// <summary>
            /// The circ ease out in
            /// </summary>
            CircEaseOutIn,
            /// <summary>
            /// The cubic ease in
            /// </summary>
            CubicEaseIn,
            /// <summary>
            /// The cubic ease in out
            /// </summary>
            CubicEaseInOut,
            /// <summary>
            /// The cubic ease out
            /// </summary>
            CubicEaseOut,
            /// <summary>
            /// The cubic ease out in
            /// </summary>
            CubicEaseOutIn,
            /// <summary>
            /// The elastic ease in
            /// </summary>
            ElasticEaseIn,
            /// <summary>
            /// The elastic ease in out
            /// </summary>
            ElasticEaseInOut,
            /// <summary>
            /// The elastic ease out
            /// </summary>
            ElasticEaseOut,
            /// <summary>
            /// The elastic ease out in
            /// </summary>
            ElasticEaseOutIn,
            /// <summary>
            /// The expo ease in
            /// </summary>
            ExpoEaseIn,
            /// <summary>
            /// The expo ease in out
            /// </summary>
            ExpoEaseInOut,
            /// <summary>
            /// The expo ease out
            /// </summary>
            ExpoEaseOut,
            /// <summary>
            /// The expo ease out in
            /// </summary>
            ExpoEaseOutIn,
            /// <summary>
            /// The linear
            /// </summary>
            Linear,
            /// <summary>
            /// The quad ease in
            /// </summary>
            QuadEaseIn,
            /// <summary>
            /// The quad ease in out
            /// </summary>
            QuadEaseInOut,
            /// <summary>
            /// The quad ease out
            /// </summary>
            QuadEaseOut,
            /// <summary>
            /// The quad ease out in
            /// </summary>
            QuadEaseOutIn,
            /// <summary>
            /// The quart ease in
            /// </summary>
            QuartEaseIn,
            /// <summary>
            /// The quart ease in out
            /// </summary>
            QuartEaseInOut,
            /// <summary>
            /// The quart ease out
            /// </summary>
            QuartEaseOut,
            /// <summary>
            /// The quart ease out in
            /// </summary>
            QuartEaseOutIn,
            /// <summary>
            /// The quint ease in
            /// </summary>
            QuintEaseIn,
            /// <summary>
            /// The quint ease in out
            /// </summary>
            QuintEaseInOut,
            /// <summary>
            /// The quint ease out
            /// </summary>
            QuintEaseOut,
            /// <summary>
            /// The quint ease out in
            /// </summary>
            QuintEaseOutIn,
            /// <summary>
            /// The sine ease in
            /// </summary>
            SineEaseIn,
            /// <summary>
            /// The sine ease in out
            /// </summary>
            SineEaseInOut,
            /// <summary>
            /// The sine ease out
            /// </summary>
            SineEaseOut,
            /// <summary>
            /// The sine ease out in
            /// </summary>
            SineEaseOutIn
            #endregion

        }

        /// <summary>
        /// This provides the kind of fold animation for the <c><see cref="ZeroitVisAnimEdit" /></c> animator.
        /// </summary>
        public enum FoldMethod
        {
            /// <summary>
            /// The show
            /// </summary>
            Show,
            /// <summary>
            /// The hide
            /// </summary>
            Hide
        }

        /// <summary>
        /// Gets or sets the fold maximum and minimum sizes.
        /// </summary>
        /// <value>The fold sizes.</value>
        public FoldSizes FoldSizes
        {
            get { return visualEffectsInput.FoldSizes; }
            set
            {
                visualEffectsInput.FoldSizes = value;
            }
        }

        /// <summary>
        /// Gets or sets the fold style.
        /// </summary>
        /// <value>The fold style.</value>
        public FoldMethod FoldStyle
        {
            get { return foldShow; }
            set
            {
                foldShow = value;

            }
        }

        /// <summary>
        /// Sets the type of animation for the <c><see cref="ZeroitVisAnimEdit" /></c> animator.
        /// </summary>
        public enum GetAnimationType
        {

            /// <summary>
            /// The bottom anchored height effect
            /// </summary>
            BottomAnchoredHeightEffect,
            /// <summary>
            /// The color channel shift effect
            /// </summary>
            ColorChannelShiftEffect,
            /// <summary>
            /// The color shift effect
            /// </summary>
            ColorShiftEffect,
            /// <summary>
            /// The control fade effect
            /// </summary>
            ControlFadeEffect,
            /// <summary>
            /// The control fade effect2
            /// </summary>
            ControlFadeEffect2,
            /// <summary>
            /// The form fade effect
            /// </summary>
            FormFadeEffect,
            /// <summary>
            /// The font size effect
            /// </summary>
            FontSizeEffect,
            /// <summary>
            /// The fold effect
            /// </summary>
            FoldEffect,
            /// <summary>
            /// The horizontal fold effect
            /// </summary>
            HorizontalFoldEffect,
            /// <summary>
            /// The left anchored width effect
            /// </summary>
            LeftAnchoredWidthEffect,
            /// <summary>
            /// The right anchored width effect
            /// </summary>
            RightAnchoredWidthEffect,
            /// <summary>
            /// The top anchored height effect
            /// </summary>
            TopAnchoredHeightEffect,
            /// <summary>
            /// The vertical fold effect
            /// </summary>
            VerticalFoldEffect,
            /// <summary>
            /// This moves the control in horizontal position
            /// </summary>
            XLocationEffect,
            /// <summary>
            /// This moves the control in vertical position
            /// </summary>
            YLocationEffect
        }

        /// <summary>
        /// Gets or sets the type of the animation.
        /// </summary>
        /// <value>The type of the animation.</value>
        public GetAnimationType AnimationType
        {
            get { return visualEffectsInput.AnimationType; }
            set
            {
                visualEffectsInput.AnimationType = value;
            }
        }

        /// <summary>
        /// Handles the <see cref="E:Invalidated" /> event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="InvalidateEventArgs"/> instance containing the event data.</param>
        public static void OnInvalidated(object sender, InvalidateEventArgs e)
        {

        }

        /// <summary>
        /// Gets or sets the type of the easing.
        /// </summary>
        /// <value>The type of the easing.</value>
        public EasingFunctionTypes EasingType
        {
            get { return visualEffectsInput.EasingType; }
            set
            {
                #region switch (EasingType)
                //switch (EasingType)
                //{
                //    case EasingFunctionTypes.BackEaseIn:
                //        easingFunctions = EasingFunctions.BackEaseIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        //Target.Animate(_AnimationType, EasingFunctions.BackEaseIn, ValueToReach, Duration, Delay, Reverse, Loops);
                //        break;
                //    case EasingFunctionTypes.BackEaseInOut:
                //        //easingFunctions = EasingFunctions.BackEaseInOut(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.BackEaseOut:
                //        easingFunctions = EasingFunctions.BackEaseOut(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.BackEaseOutIn:
                //        easingFunctions = EasingFunctions.BackEaseOutIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.BounceEaseIn:
                //        easingFunctions = EasingFunctions.BounceEaseIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.BounceEaseInOut:
                //        easingFunctions = EasingFunctions.BounceEaseInOut(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.BounceEaseOut:
                //        easingFunctions = EasingFunctions.BounceEaseOut(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.BounceEaseOutIn:
                //        easingFunctions = EasingFunctions.BounceEaseOutIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.CircEaseIn:
                //        easingFunctions = EasingFunctions.CircEaseIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.CircEaseInOut:
                //        easingFunctions = EasingFunctions.CircEaseInOut(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.CircEaseOut:
                //        easingFunctions = EasingFunctions.CircEaseOut(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.CircEaseOutIn:
                //        easingFunctions = EasingFunctions.CircEaseOutIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.CubicEaseIn:
                //        easingFunctions = EasingFunctions.CubicEaseIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.CubicEaseInOut:
                //        easingFunctions = EasingFunctions.CubicEaseInOut(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.CubicEaseOut:
                //        easingFunctions = EasingFunctions.CubicEaseOut(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.CubicEaseOutIn:
                //        easingFunctions = EasingFunctions.CubicEaseOutIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.ElasticEaseIn:
                //        easingFunctions = EasingFunctions.ElasticEaseIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.ElasticEaseInOut:
                //        easingFunctions = EasingFunctions.ElasticEaseInOut(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.ElasticEaseOut:
                //        easingFunctions = EasingFunctions.ElasticEaseOut(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.ElasticEaseOutIn:
                //        easingFunctions = EasingFunctions.ElasticEaseOutIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.ExpoEaseIn:
                //        easingFunctions = EasingFunctions.ExpoEaseIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.ExpoEaseInOut:
                //        easingFunctions = EasingFunctions.ExpoEaseInOut(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.ExpoEaseOut:
                //        easingFunctions = EasingFunctions.ExpoEaseOut(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.ExpoEaseOutIn:
                //        easingFunctions = EasingFunctions.ExpoEaseOutIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.Linear:
                //        easingFunctions = EasingFunctions.Linear(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.QuadEaseIn:
                //        easingFunctions = EasingFunctions.QuadEaseIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.QuadEaseInOut:
                //        easingFunctions = EasingFunctions.QuadEaseInOut(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.QuadEaseOut:
                //        easingFunctions = EasingFunctions.QuadEaseOut(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.QuadEaseOutIn:
                //        easingFunctions = EasingFunctions.QuadEaseOutIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.QuartEaseIn:
                //        easingFunctions = EasingFunctions.QuartEaseIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.QuartEaseInOut:
                //        easingFunctions = EasingFunctions.QuartEaseInOut(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.QuartEaseOut:
                //        easingFunctions = EasingFunctions.QuartEaseOut(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.QuartEaseOutIn:
                //        easingFunctions = EasingFunctions.QuartEaseOutIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.QuintEaseIn:
                //        easingFunctions = EasingFunctions.QuintEaseIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.QuintEaseInOut:
                //        easingFunctions = EasingFunctions.QuintEaseInOut(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.QuintEaseOut:
                //        easingFunctions = EasingFunctions.QuintEaseOut(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.QuintEaseOutIn:
                //        easingFunctions = EasingFunctions.QuintEaseOutIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.SineEaseIn:
                //        easingFunctions = EasingFunctions.SineEaseIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.SineEaseInOut:
                //        easingFunctions = EasingFunctions.SineEaseInOut(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.SineEaseOut:
                //        easingFunctions = EasingFunctions.SineEaseOut(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    case EasingFunctionTypes.SineEaseOutIn:
                //        easingFunctions = EasingFunctions.SineEaseOutIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        break;
                //    default:
                //        break;
                //}

                #endregion

                visualEffectsInput.EasingType = value;

            }
        }

        /// <summary>
        /// Gets or sets the target control to use for the animation.
        /// </summary>
        /// <value>The target.</value>
        public Control Target
        {
            get { return visualEffectsInput.Target; }
            set
            {
                visualEffectsInput.Target = value;
                visualEffectsInput.Target.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the value to reach.
        /// </summary>
        /// <value>The value to reach.</value>
        public Int32 ValueToReach
        {
            get { return visualEffectsInput.ValueToReach; }
            set
            {
                visualEffectsInput.ValueToReach = value;
            }
        }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        /// <value>The duration.</value>
        public Int32 Duration
        {
            get { return visualEffectsInput.Duration; }
            set
            {
                visualEffectsInput.Duration = value;
            }
        }

        /// <summary>
        /// Gets or sets the delay.
        /// </summary>
        /// <value>The delay.</value>
        public Int32 Delay
        {
            get { return visualEffectsInput.Delay; }
            set
            {
                visualEffectsInput.Delay = value;
            }
        }

        /// <summary>
        /// Gets or sets the no of times to loop the animation.
        /// </summary>
        /// <value>The loops.</value>
        public Int32 Loops
        {
            get { return visualEffectsInput.Loops; }
            set
            {
                visualEffectsInput.Loops = value;
            }
        }

        /// <summary>
        /// A value indicating whether to reverse the animation or not.
        /// </summary>
        /// <value>The reverse.</value>
        public Boolean Reverse
        {
            get { return visualEffectsInput.Reverse; }
            set
            {
                visualEffectsInput.Reverse = value;
            }
        }

        #endregion


        #region Private Methods

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitVisAnimEdit" /> class.
        /// </summary>
        public ZeroitVisAnimEdit()
        {

        }

        /// <summary>
        /// Starts the animation.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void Activate()
        {
            switch (visualEffectsInput.AnimationType)
            {
                case GetAnimationType.XLocationEffect:
                    _AnimationType = new XLocationEffect();
                    break;
                case GetAnimationType.BottomAnchoredHeightEffect:
                    _AnimationType = new BottomAnchoredHeightEffect();
                    break;
                case GetAnimationType.FoldEffect:
                    _AnimationType = new FoldEffect(Target);

                    FoldAnimation animationFold = new FoldAnimation(Target);
                    animationFold.Duration = Duration;
                    animationFold.Delay = Delay;
                    animationFold.MaxSize = FoldSizes.MaximumSize;
                    animationFold.MinSize = FoldSizes.MinimumSize;
                    animationFold.Reverse = Reverse;

                    animationFold.Loops = Loops;

                    switch (FoldStyle)
                    {
                        case FoldMethod.Hide:
                            animationFold.Show(EasingType, EasingType);

                            //if (Reverse)
                            //{
                            //    if (Target.Size == FoldSizes.MaximumSize)
                            //    {
                            //        animationFold.Hide(EasingType, EasingType);
                            //    }
                            //}

                            break;
                        case FoldMethod.Show:
                            animationFold.Hide(EasingType, EasingType);

                            //if (Reverse)
                            //{
                            //    if (Target.Size == FoldSizes.MinimumSize)
                            //    {
                            //        animationFold.Show(EasingType, EasingType);
                            //    }
                            //}

                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }



                    break;
                case GetAnimationType.HorizontalFoldEffect:
                    _AnimationType = new HorizontalFoldEffect();
                    break;
                case GetAnimationType.LeftAnchoredWidthEffect:
                    _AnimationType = new LeftAnchoredWidthEffect();
                    break;
                case GetAnimationType.RightAnchoredWidthEffect:
                    _AnimationType = new RightAnchoredWidthEffect();
                    break;
                case GetAnimationType.TopAnchoredHeightEffect:
                    _AnimationType = new TopAnchoredHeightEffect();
                    break;
                case GetAnimationType.VerticalFoldEffect:
                    _AnimationType = new VerticalFoldEffect();
                    break;
                case GetAnimationType.YLocationEffect:
                    _AnimationType = new YLocationEffect();
                    break;
                case GetAnimationType.ColorChannelShiftEffect:
                    _AnimationType = new ColorChannelShiftEffect(ColorChannelShiftEffect.ColorChannels.R);
                    break;
                case GetAnimationType.ColorShiftEffect:
                    _AnimationType = new ColorShiftEffect();
                    break;
                case GetAnimationType.ControlFadeEffect:
                    _AnimationType = new ControlFadeEffect(Target);
                    break;
                case GetAnimationType.ControlFadeEffect2:
                    _AnimationType = new ControlFadeEffect2(Target);
                    break;
                case GetAnimationType.FormFadeEffect:
                    _AnimationType = new FormFadeEffect();
                    break;
                case GetAnimationType.FontSizeEffect:
                    _AnimationType = new FontSizeEffect();
                    break;
                default:
                    break;
            }

            switch (visualEffectsInput.EasingType)
            {
                case EasingFunctionTypes.BackEaseIn:
                    Target.Animate(_AnimationType, EasingFunctions.BackEaseIn, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.BackEaseInOut:
                    Target.Animate(_AnimationType, EasingFunctions.BackEaseInOut, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.BackEaseOut:
                    Target.Animate(_AnimationType, EasingFunctions.BackEaseOut, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.BackEaseOutIn:
                    Target.Animate(_AnimationType, EasingFunctions.BackEaseOutIn, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.BounceEaseIn:
                    Target.Animate(_AnimationType, EasingFunctions.BounceEaseIn, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.BounceEaseInOut:
                    Target.Animate(_AnimationType, EasingFunctions.BounceEaseInOut, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.BounceEaseOut:
                    Target.Animate(_AnimationType, EasingFunctions.BounceEaseOut, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.BounceEaseOutIn:
                    Target.Animate(_AnimationType, EasingFunctions.BounceEaseOutIn, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.CircEaseIn:
                    Target.Animate(_AnimationType, EasingFunctions.CircEaseIn, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.CircEaseInOut:
                    Target.Animate(_AnimationType, EasingFunctions.CircEaseInOut, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.CircEaseOut:
                    Target.Animate(_AnimationType, EasingFunctions.CircEaseOut, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.CircEaseOutIn:
                    Target.Animate(_AnimationType, EasingFunctions.CircEaseOutIn, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.CubicEaseIn:
                    Target.Animate(_AnimationType, EasingFunctions.CubicEaseIn, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.CubicEaseInOut:
                    Target.Animate(_AnimationType, EasingFunctions.CubicEaseInOut, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.CubicEaseOut:
                    Target.Animate(_AnimationType, EasingFunctions.CubicEaseOut, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.CubicEaseOutIn:
                    Target.Animate(_AnimationType, EasingFunctions.CubicEaseOutIn, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.ElasticEaseIn:
                    Target.Animate(_AnimationType, EasingFunctions.ElasticEaseIn, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.ElasticEaseInOut:
                    Target.Animate(_AnimationType, EasingFunctions.ElasticEaseInOut, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.ElasticEaseOut:
                    Target.Animate(_AnimationType, EasingFunctions.ElasticEaseOut, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.ElasticEaseOutIn:
                    Target.Animate(_AnimationType, EasingFunctions.ElasticEaseOutIn, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.ExpoEaseIn:
                    Target.Animate(_AnimationType, EasingFunctions.ExpoEaseIn, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.ExpoEaseInOut:
                    Target.Animate(_AnimationType, EasingFunctions.ExpoEaseInOut, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.ExpoEaseOut:
                    Target.Animate(_AnimationType, EasingFunctions.ExpoEaseOut, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.ExpoEaseOutIn:
                    Target.Animate(_AnimationType, EasingFunctions.ExpoEaseOutIn, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.Linear:
                    Target.Animate(_AnimationType, EasingFunctions.Linear, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.QuadEaseIn:
                    Target.Animate(_AnimationType, EasingFunctions.QuadEaseIn, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.QuadEaseInOut:
                    Target.Animate(_AnimationType, EasingFunctions.QuadEaseInOut, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.QuadEaseOut:
                    Target.Animate(_AnimationType, EasingFunctions.QuadEaseOut, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.QuadEaseOutIn:
                    Target.Animate(_AnimationType, EasingFunctions.QuadEaseOutIn, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.QuartEaseIn:
                    Target.Animate(_AnimationType, EasingFunctions.QuartEaseIn, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.QuartEaseInOut:
                    Target.Animate(_AnimationType, EasingFunctions.QuartEaseInOut, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.QuartEaseOut:
                    Target.Animate(_AnimationType, EasingFunctions.QuartEaseOut, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.QuartEaseOutIn:
                    Target.Animate(_AnimationType, EasingFunctions.QuartEaseOutIn, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.QuintEaseIn:
                    Target.Animate(_AnimationType, EasingFunctions.QuintEaseIn, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.QuintEaseInOut:
                    Target.Animate(_AnimationType, EasingFunctions.QuintEaseInOut, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.QuintEaseOut:
                    Target.Animate(_AnimationType, EasingFunctions.QuintEaseOut, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.QuintEaseOutIn:
                    Target.Animate(_AnimationType, EasingFunctions.QuintEaseOutIn, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.SineEaseIn:
                    Target.Animate(_AnimationType, EasingFunctions.SineEaseIn, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.SineEaseInOut:
                    Target.Animate(_AnimationType, EasingFunctions.SineEaseInOut, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.SineEaseOut:
                    Target.Animate(_AnimationType, EasingFunctions.SineEaseOut, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                case EasingFunctionTypes.SineEaseOutIn:
                    Target.Animate(_AnimationType, EasingFunctions.SineEaseOutIn, ValueToReach, Duration, Delay, Reverse, Loops);
                    break;
                default:
                    break;
            }


        }

        #endregion


        /*I decided to add no abstraction over animators and provide bare functionality.
         *I think nothing is better than a static method here.*/

        /// <summary>
        /// Occurs when [animated].
        /// </summary>
        public static event EventHandler<AnimationStatus> Animated;

        /// <summary>
        /// Animate a control property from its present value to a target one
        /// </summary>
        /// <param name="control">Target control</param>
        /// <param name="iEffect">Effect to apply</param>
        /// <param name="easing">Easing function to apply</param>
        /// <param name="valueToReach">Target value reached when animation completes</param>
        /// <param name="duration">Amount of time taken to reach the target value</param>
        /// <param name="delay">Amount of delay to apply before animation starts</param>
        /// <param name="reverse">If set to true, animation reaches target value and animates back to initial value. It takes 2*<paramref name="duration" /></param>
        /// <param name="loops">If reverse is set to true, indicates how many loops to perform. Negatives or zero mean infinite loop</param>
        /// <returns>AnimationStatus.</returns>

        //public static AnimationStatus Animate(Control control, IEffect iEffect,
        //    EasingDelegate easing, int valueToReach, int duration, int delay,
        //    bool reverse = false, int loops = 1)
        public static AnimationStatus Animate(Control control, IEffect iEffect,
            EasingDelegate easing, int valueToReach, int duration, int delay,
            bool reverse = false, int loops = 1)
        {
            //used to calculate animation frame based on how much time has effectively passed
            var stopwatch = new Stopwatch();

            //used to cancel animation
            var cancelTokenSource = new CancellationTokenSource();

            //used to access animation progress
            var animationStatus = new AnimationStatus(cancelTokenSource, stopwatch);

            //This timer allows delayed start. Control's state checks and evaluations are delayed too.
            new System.Threading.Timer((state) =>
            {
                //is there anything to do here?
                int originalValue = iEffect.GetCurrentValue(control);
                if (originalValue == valueToReach)
                {
                    animationStatus.IsCompleted = true;
                    return;
                }

                //upper bound check
                int maxVal = iEffect.GetMaximumValue(control);
                if (valueToReach > maxVal)
                {
                    string msg = String.Format("Value must be lesser than the maximum allowed. " +
                                               "Max: {0}, provided value: {1}", maxVal, valueToReach);

                    throw new ArgumentException(msg, "valueToReach");
                }

                //lower bound check
                int minVal = iEffect.GetMinimumValue(control);
                if (valueToReach < iEffect.GetMinimumValue(control))
                {
                    string msg = String.Format("Value must be greater than the minimum allowed. " +
                                               "Min: {0}, provided value: {1}", minVal, valueToReach);

                    throw new ArgumentException(msg, "valueToReach");
                }

                bool reversed = false;
                int performedLoops = 0;

                int actualValueChange = Math.Abs(originalValue - valueToReach);

                System.Timers.Timer animationTimer = new System.Timers.Timer();
                //adjust interval (naive, edge cases can mess up)
                animationTimer.Interval = (duration > actualValueChange) ?
                    (duration / actualValueChange) : actualValueChange;

                //because of naive interval calculation this is required
                if (iEffect.Interaction == EffectInteractions.COLOR)
                    animationTimer.Interval = 10;

                //main animation timer tick
                animationTimer.Elapsed += (o, e2) =>
                {
                    //cancellation support
                    if (cancelTokenSource.Token.IsCancellationRequested)
                    {
                        animationStatus.IsCompleted = true;
                        animationTimer.Stop();
                        stopwatch.Stop();

                        return;
                    }

                    //main logic
                    bool increasing = originalValue < valueToReach;

                    int minValue = Math.Min(originalValue, valueToReach);
                    int maxValue = Math.Abs(valueToReach - originalValue);
                    int newValue = (int)easing(stopwatch.ElapsedMilliseconds, minValue, maxValue, duration);

                    if (!increasing)
                        newValue = (originalValue + valueToReach) - newValue - 1;

                    control.BeginInvoke(new MethodInvoker(() =>
                    {
                        iEffect.SetValue(control, originalValue, valueToReach, newValue);

                        bool timeout = stopwatch.ElapsedMilliseconds >= duration;
                        if (timeout)
                        {
                            if (reverse && (!reversed || loops <= 0 || performedLoops < loops))
                            {
                                reversed = !reversed;
                                if (reversed)
                                    performedLoops++;

                                int initialValue = originalValue;
                                int finalValue = valueToReach;

                                valueToReach = valueToReach == finalValue ? initialValue : finalValue;
                                originalValue = valueToReach == finalValue ? initialValue : finalValue;

                                stopwatch.Restart();
                                animationTimer.Start();
                            }
                            else
                            {
                                animationStatus.IsCompleted = true;
                                animationTimer.Stop();
                                stopwatch.Stop();

                                if (Animated != null)
                                    Animated(control, animationStatus);
                            }
                        }
                    }));
                };

                //start
                stopwatch.Start();
                animationTimer.Start();

            }, null, delay, System.Threading.Timeout.Infinite);

            return animationStatus;
        }
    }
    #endregion
}
