// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ZeroitAnimate_VisualEffectsAnimator.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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

#endregion

namespace Zeroit.Framework.Transitions
{
    #region ZeroitVisAnim

    /// <summary>
    /// A class collection that provides animation functionality.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    public class ZeroitVisAnim : Component
    {

        #region Variables
        /// <summary>
        /// The target
        /// </summary>
        private Control _Target;
        /// <summary>
        /// The animation type
        /// </summary>
        private IEffect _AnimationType = new XLocationEffect();
        /// <summary>
        /// The easing current time
        /// </summary>
        private double Easing_currentTime = 0;
        /// <summary>
        /// The easing minimum value
        /// </summary>
        private double Easing_minValue = 2;
        /// <summary>
        /// The easing maximum value
        /// </summary>
        private double Easing_maxValue = 20;
        /// <summary>
        /// The easing duration
        /// </summary>
        private double Easing_duration = 10;
        /// <summary>
        /// The easing functions
        /// </summary>
        private double easingFunctions;
        /// <summary>
        /// The value to reach
        /// </summary>
        private int _ValueToReach = 321;
        /// <summary>
        /// The duration
        /// </summary>
        private int _Duration = 2000;
        /// <summary>
        /// The delay
        /// </summary>
        private int _Delay = 0;
        /// <summary>
        /// The reverse
        /// </summary>
        private bool _Reverse = false;
        /// <summary>
        /// The loops
        /// </summary>
        private int _Loops = 1;
        /// <summary>
        /// The get animation type
        /// </summary>
        public GetAnimationType _GetAnimationType;
        /// <summary>
        /// The easing function types
        /// </summary>
        private EasingFunctionTypes _EasingFunctionTypes;


        /// <summary>
        /// The fold show
        /// </summary>
        private FoldMethod foldShow = FoldMethod.Show;
        /// <summary>
        /// The fold sizes
        /// </summary>
        private FoldSizes foldSizes = new FoldSizes();

        #endregion

        #region Properties

        /// <summary>
        /// This provides the kind of fold animation for the <c><see cref="ZeroitVisAnim" /></c> animator.
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
            get { return foldSizes; }
            set
            {
                foldSizes = value;
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
        /// Sets the type of easing for the <c><see cref="ZeroitVisAnim" /></c> animator.
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
        /// Sets the type of animation for the <c><see cref="ZeroitVisAnim" /></c> animator.
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
            get { return _GetAnimationType; }
            set
            {
                _GetAnimationType = value;
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
            get { return _EasingFunctionTypes; }
            set
            {
                #region switch (_EasingFunctionTypes)
                //switch (_EasingFunctionTypes)
                //{
                //    case EasingFunctionTypes.BackEaseIn:
                //        easingFunctions = EasingFunctions.BackEaseIn(Easing_currentTime, Easing_minValue, Easing_maxValue, Easing_duration);
                //        //_Target.Animate(_AnimationType, EasingFunctions.BackEaseIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
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

                _EasingFunctionTypes = value;

            }
        }

        /// <summary>
        /// Gets or sets the target control to use for the animation.
        /// </summary>
        /// <value>The target.</value>
        public Control Target
        {
            get { return _Target; }
            set
            {
                _Target = value;
            }
        }

        /// <summary>
        /// Gets or sets the value to reach.
        /// </summary>
        /// <value>The value to reach.</value>
        public Int32 ValueToReach
        {
            get { return _ValueToReach; }
            set
            {
                _ValueToReach = value;
            }
        }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        /// <value>The duration.</value>
        public Int32 Duration
        {
            get { return _Duration; }
            set
            {
                _Duration = value;
            }
        }

        /// <summary>
        /// Gets or sets the delay.
        /// </summary>
        /// <value>The delay.</value>
        public Int32 Delay
        {
            get { return _Delay; }
            set
            {
                _Delay = value;
            }
        }

        /// <summary>
        /// Gets or sets the no of times to loop the animation.
        /// </summary>
        /// <value>The loops.</value>
        public Int32 Loops
        {
            get { return _Loops; }
            set
            {
                _Loops = value;
            }
        }

        /// <summary>
        /// A value indicating whether to reverse the animation or not.
        /// </summary>
        /// <value>The reverse.</value>
        public Boolean Reverse
        {
            get { return _Reverse; }
            set
            {
                _Reverse = value;
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitVisAnim" /> class.
        /// </summary>
        public ZeroitVisAnim()
        {

        }

        /// <summary>
        /// Starts the animation.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void Activate()
        {
            switch (_GetAnimationType)
            {
                case GetAnimationType.XLocationEffect:
                    _AnimationType = new XLocationEffect();
                    break;
                case GetAnimationType.BottomAnchoredHeightEffect:
                    _AnimationType = new BottomAnchoredHeightEffect();
                    break;
                case GetAnimationType.FoldEffect:
                    
                    _AnimationType = new FoldEffect(Target);

                    //FoldEffect fold = new FoldEffect(Target, Duration, Delay, true, EasingType, EasingType); ;
                    //fold.MaxSize = Target.MinimumSize;
                    //fold.MinSize = Target.MaximumSize;
                    //fold.Show(EasingType, EasingType);

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
                    _AnimationType = new ControlFadeEffect(_Target);
                    break;
                case GetAnimationType.ControlFadeEffect2:
                    _AnimationType = new ControlFadeEffect2(_Target);
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

            switch (_EasingFunctionTypes)
            {
                case EasingFunctionTypes.BackEaseIn:
                    _Target.Animate(_AnimationType, EasingFunctions.BackEaseIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.BackEaseInOut:
                    _Target.Animate(_AnimationType, EasingFunctions.BackEaseInOut, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.BackEaseOut:
                    _Target.Animate(_AnimationType, EasingFunctions.BackEaseOut, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.BackEaseOutIn:
                    _Target.Animate(_AnimationType, EasingFunctions.BackEaseOutIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.BounceEaseIn:
                    _Target.Animate(_AnimationType, EasingFunctions.BounceEaseIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.BounceEaseInOut:
                    _Target.Animate(_AnimationType, EasingFunctions.BounceEaseInOut, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.BounceEaseOut:
                    _Target.Animate(_AnimationType, EasingFunctions.BounceEaseOut, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.BounceEaseOutIn:
                    _Target.Animate(_AnimationType, EasingFunctions.BounceEaseOutIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.CircEaseIn:
                    _Target.Animate(_AnimationType, EasingFunctions.CircEaseIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.CircEaseInOut:
                    _Target.Animate(_AnimationType, EasingFunctions.CircEaseInOut, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.CircEaseOut:
                    _Target.Animate(_AnimationType, EasingFunctions.CircEaseOut, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.CircEaseOutIn:
                    _Target.Animate(_AnimationType, EasingFunctions.CircEaseOutIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.CubicEaseIn:
                    _Target.Animate(_AnimationType, EasingFunctions.CubicEaseIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.CubicEaseInOut:
                    _Target.Animate(_AnimationType, EasingFunctions.CubicEaseInOut, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.CubicEaseOut:
                    _Target.Animate(_AnimationType, EasingFunctions.CubicEaseOut, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.CubicEaseOutIn:
                    _Target.Animate(_AnimationType, EasingFunctions.CubicEaseOutIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.ElasticEaseIn:
                    _Target.Animate(_AnimationType, EasingFunctions.ElasticEaseIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.ElasticEaseInOut:
                    _Target.Animate(_AnimationType, EasingFunctions.ElasticEaseInOut, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.ElasticEaseOut:
                    _Target.Animate(_AnimationType, EasingFunctions.ElasticEaseOut, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.ElasticEaseOutIn:
                    _Target.Animate(_AnimationType, EasingFunctions.ElasticEaseOutIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.ExpoEaseIn:
                    _Target.Animate(_AnimationType, EasingFunctions.ExpoEaseIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.ExpoEaseInOut:
                    _Target.Animate(_AnimationType, EasingFunctions.ExpoEaseInOut, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.ExpoEaseOut:
                    _Target.Animate(_AnimationType, EasingFunctions.ExpoEaseOut, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.ExpoEaseOutIn:
                    _Target.Animate(_AnimationType, EasingFunctions.ExpoEaseOutIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.Linear:
                    _Target.Animate(_AnimationType, EasingFunctions.Linear, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.QuadEaseIn:
                    _Target.Animate(_AnimationType, EasingFunctions.QuadEaseIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.QuadEaseInOut:
                    _Target.Animate(_AnimationType, EasingFunctions.QuadEaseInOut, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.QuadEaseOut:
                    _Target.Animate(_AnimationType, EasingFunctions.QuadEaseOut, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.QuadEaseOutIn:
                    _Target.Animate(_AnimationType, EasingFunctions.QuadEaseOutIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.QuartEaseIn:
                    _Target.Animate(_AnimationType, EasingFunctions.QuartEaseIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.QuartEaseInOut:
                    _Target.Animate(_AnimationType, EasingFunctions.QuartEaseInOut, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.QuartEaseOut:
                    _Target.Animate(_AnimationType, EasingFunctions.QuartEaseOut, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.QuartEaseOutIn:
                    _Target.Animate(_AnimationType, EasingFunctions.QuartEaseOutIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.QuintEaseIn:
                    _Target.Animate(_AnimationType, EasingFunctions.QuintEaseIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.QuintEaseInOut:
                    _Target.Animate(_AnimationType, EasingFunctions.QuintEaseInOut, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.QuintEaseOut:
                    _Target.Animate(_AnimationType, EasingFunctions.QuintEaseOut, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.QuintEaseOutIn:
                    _Target.Animate(_AnimationType, EasingFunctions.QuintEaseOutIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.SineEaseIn:
                    _Target.Animate(_AnimationType, EasingFunctions.SineEaseIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.SineEaseInOut:
                    _Target.Animate(_AnimationType, EasingFunctions.SineEaseInOut, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.SineEaseOut:
                    _Target.Animate(_AnimationType, EasingFunctions.SineEaseOut, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
                    break;
                case EasingFunctionTypes.SineEaseOutIn:
                    _Target.Animate(_AnimationType, EasingFunctions.SineEaseOutIn, _ValueToReach, _Duration, _Delay, _Reverse, _Loops);
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

    /// <summary>
    /// A class collection for <c><see cref="ZeroitVisAnim" /></c>
    /// that sets the Maximum and minimum size.
    /// </summary>
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class FoldSizes
    {
        /// <summary>
        /// Gets or sets the maximum size.
        /// </summary>
        /// <value>The maximum size.</value>
        public System.Drawing.Size MaximumSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the minimum size.
        /// </summary>
        /// <value>The minimum size.</value>
        public System.Drawing.Size MinimumSize
        {
            get;
            set;
        }
    }
    #endregion
}
