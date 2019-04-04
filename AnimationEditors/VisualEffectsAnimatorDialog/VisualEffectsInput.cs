// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="VisualEffectsInput.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    /// Class VisualEffectsInput.
    /// </summary>
    [TypeConverter(typeof(VisualEffectsInput.VisualEffectsConverter))]
    [Editor(typeof(VisualEffectsAnimatorEditor), typeof(System.Drawing.Design.UITypeEditor))]

    public class VisualEffectsInput
    {

        #region Variables

        /// <summary>
        /// The get animation type
        /// </summary>
        private ZeroitVisAnimEdit.GetAnimationType _GetAnimationType = ZeroitVisAnimEdit.GetAnimationType.XLocationEffect;

        /// <summary>
        /// The easing function types
        /// </summary>
        private ZeroitVisAnimEdit.EasingFunctionTypes _EasingFunctionTypes = ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn;
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
        private bool _Reverse = true;
        /// <summary>
        /// The loops
        /// </summary>
        private int _Loops = 1;
        /// <summary>
        /// The target
        /// </summary>
        private Control _Target/* = new Control()*/;

        /// <summary>
        /// The dummy int
        /// </summary>
        private int dummy_int = 1;
        /// <summary>
        /// The dummy float
        /// </summary>
        private float dummy_float = 1;
        /// <summary>
        /// The dummy double
        /// </summary>
        private double dummy_double = 1;
        /// <summary>
        /// The dummy string
        /// </summary>
        private string dummy_string = "";

        /// <summary>
        /// The fold sizes
        /// </summary>
        private FoldSizes foldSizes = new FoldSizes();

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the type of the animation.
        /// </summary>
        /// <value>The type of the animation.</value>
        public ZeroitVisAnimEdit.GetAnimationType AnimationType
        {
            get { return _GetAnimationType; }
            set
            {
                _GetAnimationType = value;
            }
        }

        /// <summary>
        /// Gets or sets the type of the easing.
        /// </summary>
        /// <value>The type of the easing.</value>
        public ZeroitVisAnimEdit.EasingFunctionTypes EasingType
        {
            get { return _EasingFunctionTypes; }
            set
            {
                
                _EasingFunctionTypes = value;

            }
        }

        /// <summary>
        /// Gets or sets the target.
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
        /// Gets or sets the loops.
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
        /// Gets or sets the reverse.
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

        /// <summary>
        /// Gets or sets the fold sizes.
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


        #endregion

        #region Constructor

        //Internal Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualEffectsInput"/> class.
        /// </summary>
        /// <param name="_GetAnimationType">Type of the get animation.</param>
        /// <param name="_EasingFunctionTypes">The easing function types.</param>
        /// <param name="Easing_currentTime">The easing current time.</param>
        /// <param name="Easing_minValue">The easing minimum value.</param>
        /// <param name="Easing_maxValue">The easing maximum value.</param>
        /// <param name="Easing_duration">Duration of the easing.</param>
        /// <param name="_ValueToReach">The value to reach.</param>
        /// <param name="_Duration">The duration.</param>
        /// <param name="_Delay">The delay.</param>
        /// <param name="_Reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="_Loops">The loops.</param>
        public VisualEffectsInput(
            ZeroitVisAnimEdit.GetAnimationType _GetAnimationType,
            ZeroitVisAnimEdit.EasingFunctionTypes _EasingFunctionTypes,
            double Easing_currentTime,
            double Easing_minValue,
            double Easing_maxValue,
            double Easing_duration,
            int _ValueToReach,
            int _Duration,
            int _Delay,
            bool _Reverse,
            int _Loops
            
            )
        {
            this._GetAnimationType = _GetAnimationType;
            this._EasingFunctionTypes = _EasingFunctionTypes;
            this.Easing_currentTime = Easing_currentTime;
            this.Easing_minValue = Easing_minValue;
            this.Easing_maxValue = Easing_maxValue;
            this.Easing_duration = Easing_duration;
            this._ValueToReach = _ValueToReach;
            this._Duration = _Duration;
            this._Delay = _Delay;
            this._Reverse = _Reverse;
            this._Loops = _Loops;
            
        }

        /// <summary>
        /// Constructor for no Input
        /// </summary>
        public VisualEffectsInput() :
            this(
                ZeroitVisAnimEdit.GetAnimationType.XLocationEffect,
                ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                0, 2, 20, 10, 321, 2000, 0, true, 1)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualEffectsInput"/> class.
        /// </summary>
        /// <param name="XLocationEffect">The x location effect.</param>
        /// <param name="_EasingFunctionTypes">The easing function types.</param>
        /// <param name="Easing_currentTime">The easing current time.</param>
        /// <param name="Easing_minValue">The easing minimum value.</param>
        /// <param name="Easing_maxValue">The easing maximum value.</param>
        /// <param name="Easing_duration">Duration of the easing.</param>
        /// <param name="_ValueToReach">The value to reach.</param>
        /// <param name="_Duration">The duration.</param>
        /// <param name="_Delay">The delay.</param>
        /// <param name="_Reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="_Loops">The loops.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        public VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType XLocationEffect,
            ZeroitVisAnimEdit.EasingFunctionTypes _EasingFunctionTypes,
            double Easing_currentTime,
            double Easing_minValue,
            double Easing_maxValue,
            double Easing_duration,
            int _ValueToReach,
            int _Duration,
            int _Delay,
            bool _Reverse,
            int _Loops,
            Control _Target,
            string dummy) : 
            this(
                ZeroitVisAnimEdit.GetAnimationType.XLocationEffect,
                ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                0,2,20,10,321,2000,0,true,1)
        {
            this._GetAnimationType = XLocationEffect;
            this._EasingFunctionTypes = _EasingFunctionTypes;
            this.Easing_currentTime = Easing_currentTime;
            this.Easing_minValue = Easing_minValue;
            this.Easing_maxValue = Easing_maxValue;
            this.Easing_duration = Easing_duration;
            this._ValueToReach = _ValueToReach;
            this._Duration = _Duration;
            this._Delay = _Delay;
            this._Reverse = _Reverse;
            this._Loops = _Loops;
            this._Target = _Target;
            this.dummy_string = dummy;
        }



        /// <summary>
        /// Initializes a new instance of the <see cref="VisualEffectsInput"/> class.
        /// </summary>
        /// <param name="YLocationEffect">The y location effect.</param>
        /// <param name="_EasingFunctionTypes">The easing function types.</param>
        /// <param name="Easing_currentTime">The easing current time.</param>
        /// <param name="Easing_minValue">The easing minimum value.</param>
        /// <param name="Easing_maxValue">The easing maximum value.</param>
        /// <param name="Easing_duration">Duration of the easing.</param>
        /// <param name="_ValueToReach">The value to reach.</param>
        /// <param name="_Duration">The duration.</param>
        /// <param name="_Delay">The delay.</param>
        /// <param name="_Reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="_Loops">The loops.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType YLocationEffect,
            ZeroitVisAnimEdit.EasingFunctionTypes _EasingFunctionTypes,
            double Easing_currentTime,
            double Easing_minValue,
            double Easing_maxValue,
            double Easing_duration,
            int _ValueToReach,
            int _Duration,
            int _Delay,
            bool _Reverse,
            int _Loops,
            Control _Target,
            string dummy, string dummy1) :
            this(
                ZeroitVisAnimEdit.GetAnimationType.YLocationEffect,
                ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                0, 2, 20, 10, 321, 2000, 0, true, 1)
        {
            this._GetAnimationType = YLocationEffect;
            this._EasingFunctionTypes = _EasingFunctionTypes;
            this.Easing_currentTime = Easing_currentTime;
            this.Easing_minValue = Easing_minValue;
            this.Easing_maxValue = Easing_maxValue;
            this.Easing_duration = Easing_duration;
            this._ValueToReach = _ValueToReach;
            this._Duration = _Duration;
            this._Delay = _Delay;
            this._Reverse = _Reverse;
            this._Loops = _Loops;
            this.Target = _Target;
            this.dummy_string = dummy;
            this.dummy_string = dummy1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualEffectsInput"/> class.
        /// </summary>
        /// <param name="BottomAnchoredHeightEffect">The bottom anchored height effect.</param>
        /// <param name="_EasingFunctionTypes">The easing function types.</param>
        /// <param name="Easing_currentTime">The easing current time.</param>
        /// <param name="Easing_minValue">The easing minimum value.</param>
        /// <param name="Easing_maxValue">The easing maximum value.</param>
        /// <param name="Easing_duration">Duration of the easing.</param>
        /// <param name="_ValueToReach">The value to reach.</param>
        /// <param name="_Duration">The duration.</param>
        /// <param name="_Delay">The delay.</param>
        /// <param name="_Reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="_Loops">The loops.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        public VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType BottomAnchoredHeightEffect,
            ZeroitVisAnimEdit.EasingFunctionTypes _EasingFunctionTypes,
            double Easing_currentTime,
            double Easing_minValue,
            double Easing_maxValue,
            double Easing_duration,
            int _ValueToReach,
            int _Duration,
            int _Delay,
            bool _Reverse,
            int _Loops,
            Control _Target,
            int dummy
            ) :
            this(
                ZeroitVisAnimEdit.GetAnimationType.BottomAnchoredHeightEffect,
                ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                0, 2, 20, 10, 321, 2000, 0, true, 1)
        {
            this._GetAnimationType = BottomAnchoredHeightEffect;
            this._EasingFunctionTypes = _EasingFunctionTypes;
            this.Easing_currentTime = Easing_currentTime;
            this.Easing_minValue = Easing_minValue;
            this.Easing_maxValue = Easing_maxValue;
            this.Easing_duration = Easing_duration;
            this._ValueToReach = _ValueToReach;
            this._Duration = _Duration;
            this._Delay = _Delay;
            this._Reverse = _Reverse;
            this._Loops = _Loops;
            this._Target = _Target;
            this.dummy_int = dummy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualEffectsInput"/> class.
        /// </summary>
        /// <param name="ColorChannelShiftEffect">The color channel shift effect.</param>
        /// <param name="_EasingFunctionTypes">The easing function types.</param>
        /// <param name="Easing_currentTime">The easing current time.</param>
        /// <param name="Easing_minValue">The easing minimum value.</param>
        /// <param name="Easing_maxValue">The easing maximum value.</param>
        /// <param name="Easing_duration">Duration of the easing.</param>
        /// <param name="_ValueToReach">The value to reach.</param>
        /// <param name="_Duration">The duration.</param>
        /// <param name="_Delay">The delay.</param>
        /// <param name="_Reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="_Loops">The loops.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType ColorChannelShiftEffect,
            ZeroitVisAnimEdit.EasingFunctionTypes _EasingFunctionTypes,
            double Easing_currentTime,
            double Easing_minValue,
            double Easing_maxValue,
            double Easing_duration,
            int _ValueToReach,
            int _Duration,
            int _Delay,
            bool _Reverse,
            int _Loops,
            Control _Target,
            int dummy, int dummy1) :
            this(
                ZeroitVisAnimEdit.GetAnimationType.ColorChannelShiftEffect,
                ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                0, 2, 20, 10, 321, 2000, 0, true, 1)
        {
            this._GetAnimationType = ColorChannelShiftEffect;
            this._EasingFunctionTypes = _EasingFunctionTypes;
            this.Easing_currentTime = Easing_currentTime;
            this.Easing_minValue = Easing_minValue;
            this.Easing_maxValue = Easing_maxValue;
            this.Easing_duration = Easing_duration;
            this._ValueToReach = _ValueToReach;
            this._Duration = _Duration;
            this._Delay = _Delay;
            this._Reverse = _Reverse;
            this._Loops = _Loops;
            this._Target = _Target;
            this.dummy_int = dummy;
            this.dummy_int = dummy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualEffectsInput"/> class.
        /// </summary>
        /// <param name="ColorShiftEffect">The color shift effect.</param>
        /// <param name="_EasingFunctionTypes">The easing function types.</param>
        /// <param name="Easing_currentTime">The easing current time.</param>
        /// <param name="Easing_minValue">The easing minimum value.</param>
        /// <param name="Easing_maxValue">The easing maximum value.</param>
        /// <param name="Easing_duration">Duration of the easing.</param>
        /// <param name="_ValueToReach">The value to reach.</param>
        /// <param name="_Duration">The duration.</param>
        /// <param name="_Delay">The delay.</param>
        /// <param name="_Reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="_Loops">The loops.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        public VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType ColorShiftEffect,
            ZeroitVisAnimEdit.EasingFunctionTypes _EasingFunctionTypes,
            double Easing_currentTime,
            double Easing_minValue,
            double Easing_maxValue,
            double Easing_duration,
            int _ValueToReach,
            int _Duration,
            int _Delay,
            bool _Reverse,
            int _Loops,
            Control _Target,
            float dummy) :
            this(
                ZeroitVisAnimEdit.GetAnimationType.ColorShiftEffect,
                ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                0, 2, 20, 10, 321, 2000, 0, true, 1)
        {
            this._GetAnimationType = ColorShiftEffect;
            this._EasingFunctionTypes = _EasingFunctionTypes;
            this.Easing_currentTime = Easing_currentTime;
            this.Easing_minValue = Easing_minValue;
            this.Easing_maxValue = Easing_maxValue;
            this.Easing_duration = Easing_duration;
            this._ValueToReach = _ValueToReach;
            this._Duration = _Duration;
            this._Delay = _Delay;
            this._Reverse = _Reverse;
            this._Loops = _Loops;
            this._Target = _Target;
            this.dummy_float = dummy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualEffectsInput"/> class.
        /// </summary>
        /// <param name="ControlFadeEffect">The control fade effect.</param>
        /// <param name="_EasingFunctionTypes">The easing function types.</param>
        /// <param name="Easing_currentTime">The easing current time.</param>
        /// <param name="Easing_minValue">The easing minimum value.</param>
        /// <param name="Easing_maxValue">The easing maximum value.</param>
        /// <param name="Easing_duration">Duration of the easing.</param>
        /// <param name="_ValueToReach">The value to reach.</param>
        /// <param name="_Duration">The duration.</param>
        /// <param name="_Delay">The delay.</param>
        /// <param name="_Reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="_Loops">The loops.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType ControlFadeEffect,
            ZeroitVisAnimEdit.EasingFunctionTypes _EasingFunctionTypes,
            double Easing_currentTime,
            double Easing_minValue,
            double Easing_maxValue,
            double Easing_duration,
            int _ValueToReach,
            int _Duration,
            int _Delay,
            bool _Reverse,
            int _Loops,
            Control _Target,
            float dummy, string dummy1) :
            this(
                ZeroitVisAnimEdit.GetAnimationType.ControlFadeEffect,
                ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                0, 2, 20, 10, 321, 2000, 0, true, 1)
        {
            this._GetAnimationType = ControlFadeEffect;
            this._EasingFunctionTypes = _EasingFunctionTypes;
            this.Easing_currentTime = Easing_currentTime;
            this.Easing_minValue = Easing_minValue;
            this.Easing_maxValue = Easing_maxValue;
            this.Easing_duration = Easing_duration;
            this._ValueToReach = _ValueToReach;
            this._Duration = _Duration;
            this._Delay = _Delay;
            this._Reverse = _Reverse;
            this._Loops = _Loops;
            this._Target = _Target;
            this.dummy_float = dummy;
            this.dummy_string = dummy1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualEffectsInput"/> class.
        /// </summary>
        /// <param name="ControlFadeEffect2">The control fade effect2.</param>
        /// <param name="_EasingFunctionTypes">The easing function types.</param>
        /// <param name="Easing_currentTime">The easing current time.</param>
        /// <param name="Easing_minValue">The easing minimum value.</param>
        /// <param name="Easing_maxValue">The easing maximum value.</param>
        /// <param name="Easing_duration">Duration of the easing.</param>
        /// <param name="_ValueToReach">The value to reach.</param>
        /// <param name="_Duration">The duration.</param>
        /// <param name="_Delay">The delay.</param>
        /// <param name="_Reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="_Loops">The loops.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType ControlFadeEffect2,
            ZeroitVisAnimEdit.EasingFunctionTypes _EasingFunctionTypes,
            double Easing_currentTime,
            double Easing_minValue,
            double Easing_maxValue,
            double Easing_duration,
            int _ValueToReach,
            int _Duration,
            int _Delay,
            bool _Reverse,
            int _Loops,
            Control _Target,
            string dummy, float dummy1) :
            this(
                ZeroitVisAnimEdit.GetAnimationType.ControlFadeEffect2,
                ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                0, 2, 20, 10, 321, 2000, 0, true, 1)
        {
            this._GetAnimationType = ControlFadeEffect2;
            this._EasingFunctionTypes = _EasingFunctionTypes;
            this.Easing_currentTime = Easing_currentTime;
            this.Easing_minValue = Easing_minValue;
            this.Easing_maxValue = Easing_maxValue;
            this.Easing_duration = Easing_duration;
            this._ValueToReach = _ValueToReach;
            this._Duration = _Duration;
            this._Delay = _Delay;
            this._Reverse = _Reverse;
            this._Loops = _Loops;
            this._Target = _Target;
            this.dummy_string = dummy;
            this.dummy_float = dummy1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualEffectsInput"/> class.
        /// </summary>
        /// <param name="FoldEffect">The fold effect.</param>
        /// <param name="_EasingFunctionTypes">The easing function types.</param>
        /// <param name="Easing_currentTime">The easing current time.</param>
        /// <param name="Easing_minValue">The easing minimum value.</param>
        /// <param name="Easing_maxValue">The easing maximum value.</param>
        /// <param name="Easing_duration">Duration of the easing.</param>
        /// <param name="_ValueToReach">The value to reach.</param>
        /// <param name="_Duration">The duration.</param>
        /// <param name="_Delay">The delay.</param>
        /// <param name="_Reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="_Loops">The loops.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType FoldEffect,
            ZeroitVisAnimEdit.EasingFunctionTypes _EasingFunctionTypes,
            double Easing_currentTime,
            double Easing_minValue,
            double Easing_maxValue,
            double Easing_duration,
            int _ValueToReach,
            int _Duration,
            int _Delay,
            bool _Reverse,
            int _Loops,
            Control _Target,
            string dummy, int dummy1
            ) :
            this(
                ZeroitVisAnimEdit.GetAnimationType.FoldEffect,
                ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                0, 2, 20, 10, 321, 2000, 0, true, 1)
        {
            this._GetAnimationType = FoldEffect;
            this._EasingFunctionTypes = _EasingFunctionTypes;
            this.Easing_currentTime = Easing_currentTime;
            this.Easing_minValue = Easing_minValue;
            this.Easing_maxValue = Easing_maxValue;
            this.Easing_duration = Easing_duration;
            this._ValueToReach = _ValueToReach;
            this._Duration = _Duration;
            this._Delay = _Delay;
            this._Reverse = _Reverse;
            this._Loops = _Loops;
            this._Target = _Target;
            this.dummy_string = dummy;
            this.dummy_int = dummy1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualEffectsInput"/> class.
        /// </summary>
        /// <param name="FontSizeEffect">The font size effect.</param>
        /// <param name="_EasingFunctionTypes">The easing function types.</param>
        /// <param name="Easing_currentTime">The easing current time.</param>
        /// <param name="Easing_minValue">The easing minimum value.</param>
        /// <param name="Easing_maxValue">The easing maximum value.</param>
        /// <param name="Easing_duration">Duration of the easing.</param>
        /// <param name="_ValueToReach">The value to reach.</param>
        /// <param name="_Duration">The duration.</param>
        /// <param name="_Delay">The delay.</param>
        /// <param name="_Reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="_Loops">The loops.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType FontSizeEffect,
            ZeroitVisAnimEdit.EasingFunctionTypes _EasingFunctionTypes,
            double Easing_currentTime,
            double Easing_minValue,
            double Easing_maxValue,
            double Easing_duration,
            int _ValueToReach,
            int _Duration,
            int _Delay,
            bool _Reverse,
            int _Loops,
            Control _Target,
            int dummy, string dummy1) :
            this(
                ZeroitVisAnimEdit.GetAnimationType.FontSizeEffect,
                ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                0, 2, 20, 10, 321, 2000, 0, true, 1)
        {
            this._GetAnimationType = FontSizeEffect;
            this._EasingFunctionTypes = _EasingFunctionTypes;
            this.Easing_currentTime = Easing_currentTime;
            this.Easing_minValue = Easing_minValue;
            this.Easing_maxValue = Easing_maxValue;
            this.Easing_duration = Easing_duration;
            this._ValueToReach = _ValueToReach;
            this._Duration = _Duration;
            this._Delay = _Delay;
            this._Reverse = _Reverse;
            this._Loops = _Loops;
            this._Target = _Target;
            this.dummy_int = dummy;
            this.dummy_string = dummy1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualEffectsInput"/> class.
        /// </summary>
        /// <param name="FormFadeEffect">The form fade effect.</param>
        /// <param name="_EasingFunctionTypes">The easing function types.</param>
        /// <param name="Easing_currentTime">The easing current time.</param>
        /// <param name="Easing_minValue">The easing minimum value.</param>
        /// <param name="Easing_maxValue">The easing maximum value.</param>
        /// <param name="Easing_duration">Duration of the easing.</param>
        /// <param name="_ValueToReach">The value to reach.</param>
        /// <param name="_Duration">The duration.</param>
        /// <param name="_Delay">The delay.</param>
        /// <param name="_Reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="_Loops">The loops.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType FormFadeEffect,
            ZeroitVisAnimEdit.EasingFunctionTypes _EasingFunctionTypes,
            double Easing_currentTime,
            double Easing_minValue,
            double Easing_maxValue,
            double Easing_duration,
            int _ValueToReach,
            int _Duration,
            int _Delay,
            bool _Reverse,
            int _Loops,
            Control _Target,
            int dummy, float dummy1) :
            this(
                ZeroitVisAnimEdit.GetAnimationType.FormFadeEffect,
                ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                0, 2, 20, 10, 321, 2000, 0, true, 1)
        {
            this._GetAnimationType = FormFadeEffect;
            this._EasingFunctionTypes = _EasingFunctionTypes;
            this.Easing_currentTime = Easing_currentTime;
            this.Easing_minValue = Easing_minValue;
            this.Easing_maxValue = Easing_maxValue;
            this.Easing_duration = Easing_duration;
            this._ValueToReach = _ValueToReach;
            this._Duration = _Duration;
            this._Delay = _Delay;
            this._Reverse = _Reverse;
            this._Loops = _Loops;
            this._Target = _Target;
            this.dummy_int = dummy;
            this.dummy_float = dummy1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualEffectsInput"/> class.
        /// </summary>
        /// <param name="HorizontalFoldEffect">The horizontal fold effect.</param>
        /// <param name="_EasingFunctionTypes">The easing function types.</param>
        /// <param name="Easing_currentTime">The easing current time.</param>
        /// <param name="Easing_minValue">The easing minimum value.</param>
        /// <param name="Easing_maxValue">The easing maximum value.</param>
        /// <param name="Easing_duration">Duration of the easing.</param>
        /// <param name="_ValueToReach">The value to reach.</param>
        /// <param name="_Duration">The duration.</param>
        /// <param name="_Delay">The delay.</param>
        /// <param name="_Reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="_Loops">The loops.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType HorizontalFoldEffect,
            ZeroitVisAnimEdit.EasingFunctionTypes _EasingFunctionTypes,
            double Easing_currentTime,
            double Easing_minValue,
            double Easing_maxValue,
            double Easing_duration,
            int _ValueToReach,
            int _Duration,
            int _Delay,
            bool _Reverse,
            int _Loops,
            Control _Target,
            float dummy, int dummy1) :
            this(
                ZeroitVisAnimEdit.GetAnimationType.HorizontalFoldEffect,
                ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                0, 2, 20, 10, 321, 2000, 0, true, 1)
        {
            this._GetAnimationType = HorizontalFoldEffect;
            this._EasingFunctionTypes = _EasingFunctionTypes;
            this.Easing_currentTime = Easing_currentTime;
            this.Easing_minValue = Easing_minValue;
            this.Easing_maxValue = Easing_maxValue;
            this.Easing_duration = Easing_duration;
            this._ValueToReach = _ValueToReach;
            this._Duration = _Duration;
            this._Delay = _Delay;
            this._Reverse = _Reverse;
            this._Loops = _Loops;
            this._Target = _Target;
            this.dummy_float = dummy;
            this.dummy_float = dummy1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualEffectsInput"/> class.
        /// </summary>
        /// <param name="LeftAnchoredWidthEffect">The left anchored width effect.</param>
        /// <param name="_EasingFunctionTypes">The easing function types.</param>
        /// <param name="Easing_currentTime">The easing current time.</param>
        /// <param name="Easing_minValue">The easing minimum value.</param>
        /// <param name="Easing_maxValue">The easing maximum value.</param>
        /// <param name="Easing_duration">Duration of the easing.</param>
        /// <param name="_ValueToReach">The value to reach.</param>
        /// <param name="_Duration">The duration.</param>
        /// <param name="_Delay">The delay.</param>
        /// <param name="_Reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="_Loops">The loops.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        public VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType LeftAnchoredWidthEffect,
            ZeroitVisAnimEdit.EasingFunctionTypes _EasingFunctionTypes,
            double Easing_currentTime,
            double Easing_minValue,
            double Easing_maxValue,
            double Easing_duration,
            int _ValueToReach,
            int _Duration,
            int _Delay,
            bool _Reverse,
            int _Loops,
            Control _Target,
            double dummy) :
            this(
                ZeroitVisAnimEdit.GetAnimationType.LeftAnchoredWidthEffect,
                ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                0, 2, 20, 10, 321, 2000, 0, true, 1)
        {
            this._GetAnimationType = LeftAnchoredWidthEffect;
            this._EasingFunctionTypes = _EasingFunctionTypes;
            this.Easing_currentTime = Easing_currentTime;
            this.Easing_minValue = Easing_minValue;
            this.Easing_maxValue = Easing_maxValue;
            this.Easing_duration = Easing_duration;
            this._ValueToReach = _ValueToReach;
            this._Duration = _Duration;
            this._Delay = _Delay;
            this._Reverse = _Reverse;
            this._Loops = _Loops;
            this._Target = _Target;
            this.dummy_double = dummy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualEffectsInput"/> class.
        /// </summary>
        /// <param name="RightAnchoredWidthEffect">The right anchored width effect.</param>
        /// <param name="_EasingFunctionTypes">The easing function types.</param>
        /// <param name="Easing_currentTime">The easing current time.</param>
        /// <param name="Easing_minValue">The easing minimum value.</param>
        /// <param name="Easing_maxValue">The easing maximum value.</param>
        /// <param name="Easing_duration">Duration of the easing.</param>
        /// <param name="_ValueToReach">The value to reach.</param>
        /// <param name="_Duration">The duration.</param>
        /// <param name="_Delay">The delay.</param>
        /// <param name="_Reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="_Loops">The loops.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType RightAnchoredWidthEffect,
            ZeroitVisAnimEdit.EasingFunctionTypes _EasingFunctionTypes,
            double Easing_currentTime,
            double Easing_minValue,
            double Easing_maxValue,
            double Easing_duration,
            int _ValueToReach,
            int _Duration,
            int _Delay,
            bool _Reverse,
            int _Loops,
            Control _Target,
            double dummy, double dummy1) :
            this(
                ZeroitVisAnimEdit.GetAnimationType.RightAnchoredWidthEffect,
                ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                0, 2, 20, 10, 321, 2000, 0, true, 1)
        {
            this._GetAnimationType = RightAnchoredWidthEffect;
            this._EasingFunctionTypes = _EasingFunctionTypes;
            this.Easing_currentTime = Easing_currentTime;
            this.Easing_minValue = Easing_minValue;
            this.Easing_maxValue = Easing_maxValue;
            this.Easing_duration = Easing_duration;
            this._ValueToReach = _ValueToReach;
            this._Duration = _Duration;
            this._Delay = _Delay;
            this._Reverse = _Reverse;
            this._Loops = _Loops;
            this._Target = _Target;
            this.dummy_double = dummy;
            this.dummy_double = dummy1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualEffectsInput"/> class.
        /// </summary>
        /// <param name="TopAnchoredHeightEffect">The top anchored height effect.</param>
        /// <param name="_EasingFunctionTypes">The easing function types.</param>
        /// <param name="Easing_currentTime">The easing current time.</param>
        /// <param name="Easing_minValue">The easing minimum value.</param>
        /// <param name="Easing_maxValue">The easing maximum value.</param>
        /// <param name="Easing_duration">Duration of the easing.</param>
        /// <param name="_ValueToReach">The value to reach.</param>
        /// <param name="_Duration">The duration.</param>
        /// <param name="_Delay">The delay.</param>
        /// <param name="_Reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="_Loops">The loops.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType TopAnchoredHeightEffect,
            ZeroitVisAnimEdit.EasingFunctionTypes _EasingFunctionTypes,
            double Easing_currentTime,
            double Easing_minValue,
            double Easing_maxValue,
            double Easing_duration,
            int _ValueToReach,
            int _Duration,
            int _Delay,
            bool _Reverse,
            int _Loops,
            Control _Target,
            double dummy, int dummy1) :
            this(
                ZeroitVisAnimEdit.GetAnimationType.TopAnchoredHeightEffect,
                ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                0, 2, 20, 10, 321, 2000, 0, true, 1)
        {
            this._GetAnimationType = TopAnchoredHeightEffect;
            this._EasingFunctionTypes = _EasingFunctionTypes;
            this.Easing_currentTime = Easing_currentTime;
            this.Easing_minValue = Easing_minValue;
            this.Easing_maxValue = Easing_maxValue;
            this.Easing_duration = Easing_duration;
            this._ValueToReach = _ValueToReach;
            this._Duration = _Duration;
            this._Delay = _Delay;
            this._Reverse = _Reverse;
            this._Loops = _Loops;
            this._Target = _Target;
            this.dummy_double = dummy;
            this.dummy_int = dummy1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualEffectsInput"/> class.
        /// </summary>
        /// <param name="VerticalFoldEffect">The vertical fold effect.</param>
        /// <param name="_EasingFunctionTypes">The easing function types.</param>
        /// <param name="Easing_currentTime">The easing current time.</param>
        /// <param name="Easing_minValue">The easing minimum value.</param>
        /// <param name="Easing_maxValue">The easing maximum value.</param>
        /// <param name="Easing_duration">Duration of the easing.</param>
        /// <param name="_ValueToReach">The value to reach.</param>
        /// <param name="_Duration">The duration.</param>
        /// <param name="_Delay">The delay.</param>
        /// <param name="_Reverse">if set to <c>true</c> [reverse].</param>
        /// <param name="_Loops">The loops.</param>
        /// <param name="_Target">The target.</param>
        /// <param name="dummy">The dummy.</param>
        /// <param name="dummy1">The dummy1.</param>
        public VisualEffectsInput(ZeroitVisAnimEdit.GetAnimationType VerticalFoldEffect,
            ZeroitVisAnimEdit.EasingFunctionTypes _EasingFunctionTypes,
            double Easing_currentTime,
            double Easing_minValue,
            double Easing_maxValue,
            double Easing_duration,
            int _ValueToReach,
            int _Duration,
            int _Delay,
            bool _Reverse,
            int _Loops,
            Control _Target,
            int dummy, double dummy1) :
            this(
                ZeroitVisAnimEdit.GetAnimationType.VerticalFoldEffect,
                ZeroitVisAnimEdit.EasingFunctionTypes.BackEaseIn,
                0, 2, 20, 10, 321, 2000, 0, true, 1)
        {
            this._GetAnimationType = VerticalFoldEffect;
            this._EasingFunctionTypes = _EasingFunctionTypes;
            this.Easing_currentTime = Easing_currentTime;
            this.Easing_minValue = Easing_minValue;
            this.Easing_maxValue = Easing_maxValue;
            this.Easing_duration = Easing_duration;
            this._ValueToReach = _ValueToReach;
            this._Duration = _Duration;
            this._Delay = _Delay;
            this._Reverse = _Reverse;
            this._Loops = _Loops;
            this._Target = _Target;
            this.dummy_int = dummy;
            this.dummy_double = dummy1;
        }


        #endregion

        #region Public Methods

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>VisualEffectsInput.</returns>
        public VisualEffectsInput Clone()
        {
            return new VisualEffectsInput(
                _GetAnimationType,
                _EasingFunctionTypes,
                Easing_currentTime,
                Easing_minValue,
                Easing_maxValue,
                Easing_duration,
                _ValueToReach,
                _Duration,
                _Delay,
                _Reverse,
                _Loops
            );
        }

        /// <summary>
        /// Empties this instance.
        /// </summary>
        /// <returns>VisualEffectsInput.</returns>
        public static VisualEffectsInput Empty()
        {
            return new VisualEffectsInput();
        }


        #endregion

        #region Converter

        /// <summary>
        /// Class VisualEffectsConverter.
        /// </summary>
        /// <seealso cref="System.ComponentModel.TypeConverter" />
        internal class VisualEffectsConverter : TypeConverter
        {

            /// <summary>
            /// Returns whether this converter can convert the object to the specified type, using the specified context.
            /// </summary>
            /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
            /// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type you want to convert to.</param>
            /// <returns>true if this converter can perform the conversion; otherwise, false.</returns>
            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            {
                if (destinationType == typeof(InstanceDescriptor)/* || destinationType == typeof(string)*/)
                {
                    return true;
                }
                return base.CanConvertTo(context, destinationType);
            }

            // This code allows the designer to generate the Shape constructor

            /// <summary>
            /// Converts the given value object to the specified type, using the specified context and culture information.
            /// </summary>
            /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
            /// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" />. If null is passed, the current culture is assumed.</param>
            /// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
            /// <param name="destinationType">The <see cref="T:System.Type" /> to convert the <paramref name="value" /> parameter to.</param>
            /// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
            public override object ConvertTo(ITypeDescriptorContext context,
                CultureInfo culture,
                object value,
                Type destinationType)
            {
                
                    if (destinationType == typeof(string))
                    {
                        // Display string in designer
                        return "(Customize)";
                    }


                    else if (destinationType == typeof(InstanceDescriptor) && value is VisualEffectsInput)
                    {
                        VisualEffectsInput visualEffectsInput = (VisualEffectsInput)value;

                        if (visualEffectsInput._GetAnimationType == ZeroitVisAnimEdit.GetAnimationType.XLocationEffect)
                        {
                            ConstructorInfo ctor = typeof(VisualEffectsInput).GetConstructor(new Type[]
                            {


                                typeof(ZeroitVisAnimEdit.GetAnimationType),
                                typeof(ZeroitVisAnimEdit.EasingFunctionTypes),
                                typeof(double),
                                typeof(double),
                                typeof(double),
                                typeof(double),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                typeof(bool),
                                typeof(int),
                                typeof(Control),
                                typeof(string)


                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {


                                visualEffectsInput._GetAnimationType,
                                visualEffectsInput._EasingFunctionTypes,
                                visualEffectsInput.Easing_currentTime,
                                visualEffectsInput.Easing_minValue,
                                visualEffectsInput.Easing_maxValue,
                                visualEffectsInput.Easing_duration,
                                visualEffectsInput._ValueToReach,
                                visualEffectsInput._Duration,
                                visualEffectsInput._Delay,
                                visualEffectsInput._Reverse,
                                visualEffectsInput._Loops,
                                visualEffectsInput._Target,
                                visualEffectsInput.dummy_string

                                });
                            }
                        }

                        else if (visualEffectsInput._GetAnimationType == ZeroitVisAnimEdit.GetAnimationType.YLocationEffect)
                        {
                            ConstructorInfo ctor = typeof(VisualEffectsInput).GetConstructor(new Type[] {
                            typeof(ZeroitVisAnimEdit.GetAnimationType),
                            typeof(ZeroitVisAnimEdit.EasingFunctionTypes),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(int),
                            typeof(int),
                            typeof(int),
                            typeof(bool),
                            typeof(int),
                            typeof(Control),
                            typeof(string),
                            typeof(string)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {
                                visualEffectsInput._GetAnimationType,
                                visualEffectsInput._EasingFunctionTypes,
                                visualEffectsInput.Easing_currentTime,
                                visualEffectsInput.Easing_minValue,
                                visualEffectsInput.Easing_maxValue,
                                visualEffectsInput.Easing_duration,
                                visualEffectsInput._ValueToReach,
                                visualEffectsInput._Duration,
                                visualEffectsInput._Delay,
                                visualEffectsInput._Reverse,
                                visualEffectsInput._Loops,
                                visualEffectsInput._Target,
                                visualEffectsInput.dummy_string,
                                visualEffectsInput.dummy_string
                                });
                            }
                        }
                        else if (visualEffectsInput._GetAnimationType == ZeroitVisAnimEdit.GetAnimationType.BottomAnchoredHeightEffect)
                        {
                            ConstructorInfo ctor = typeof(VisualEffectsInput).GetConstructor(new Type[] {


                            typeof(ZeroitVisAnimEdit.GetAnimationType),
                            typeof(ZeroitVisAnimEdit.EasingFunctionTypes),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(int),
                            typeof(int),
                            typeof(int),
                            typeof(bool),
                            typeof(int),
                            typeof(Control),
                            typeof(int)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                visualEffectsInput._GetAnimationType,
                                visualEffectsInput._EasingFunctionTypes,
                                visualEffectsInput.Easing_currentTime,
                                visualEffectsInput.Easing_minValue,
                                visualEffectsInput.Easing_maxValue,
                                visualEffectsInput.Easing_duration,
                                visualEffectsInput._ValueToReach,
                                visualEffectsInput._Duration,
                                visualEffectsInput._Delay,
                                visualEffectsInput._Reverse,
                                visualEffectsInput._Loops,
                                visualEffectsInput._Target,
                                visualEffectsInput.dummy_int

                            });
                            }
                        }

                        else if (visualEffectsInput._GetAnimationType == ZeroitVisAnimEdit.GetAnimationType.ColorChannelShiftEffect)
                        {
                            ConstructorInfo ctor = typeof(VisualEffectsInput).GetConstructor(new Type[] {


                            typeof(ZeroitVisAnimEdit.GetAnimationType),
                            typeof(ZeroitVisAnimEdit.EasingFunctionTypes),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(int),
                            typeof(int),
                            typeof(int),
                            typeof(bool),
                            typeof(int),
                            typeof(Control),
                            typeof(int),
                            typeof(int)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                visualEffectsInput._GetAnimationType,
                                visualEffectsInput._EasingFunctionTypes,
                                visualEffectsInput.Easing_currentTime,
                                visualEffectsInput.Easing_minValue,
                                visualEffectsInput.Easing_maxValue,
                                visualEffectsInput.Easing_duration,
                                visualEffectsInput._ValueToReach,
                                visualEffectsInput._Duration,
                                visualEffectsInput._Delay,
                                visualEffectsInput._Reverse,
                                visualEffectsInput._Loops,
                                visualEffectsInput._Target,
                                visualEffectsInput.dummy_int,
                                visualEffectsInput.dummy_int

                            });
                            }
                        }


                        else if (visualEffectsInput._GetAnimationType == ZeroitVisAnimEdit.GetAnimationType.ColorShiftEffect)
                        {
                            ConstructorInfo ctor = typeof(VisualEffectsInput).GetConstructor(new Type[] {


                            typeof(ZeroitVisAnimEdit.GetAnimationType),
                            typeof(ZeroitVisAnimEdit.EasingFunctionTypes),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(int),
                            typeof(int),
                            typeof(int),
                            typeof(bool),
                            typeof(int),
                            typeof(Control),
                            typeof(float)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                visualEffectsInput._GetAnimationType,
                                visualEffectsInput._EasingFunctionTypes,
                                visualEffectsInput.Easing_currentTime,
                                visualEffectsInput.Easing_minValue,
                                visualEffectsInput.Easing_maxValue,
                                visualEffectsInput.Easing_duration,
                                visualEffectsInput._ValueToReach,
                                visualEffectsInput._Duration,
                                visualEffectsInput._Delay,
                                visualEffectsInput._Reverse,
                                visualEffectsInput._Loops,
                                visualEffectsInput._Target,
                                visualEffectsInput.dummy_float

                                });
                            }
                        }

                        else if (visualEffectsInput._GetAnimationType == ZeroitVisAnimEdit.GetAnimationType.ControlFadeEffect)
                        {
                            ConstructorInfo ctor = typeof(VisualEffectsInput).GetConstructor(new Type[] {

                            typeof(ZeroitVisAnimEdit.GetAnimationType),
                            typeof(ZeroitVisAnimEdit.EasingFunctionTypes),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(int),
                            typeof(int),
                            typeof(int),
                            typeof(bool),
                            typeof(int),
                            typeof(Control),
                            typeof(float),
                            typeof(string)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                visualEffectsInput._GetAnimationType,
                                visualEffectsInput._EasingFunctionTypes,
                                visualEffectsInput.Easing_currentTime,
                                visualEffectsInput.Easing_minValue,
                                visualEffectsInput.Easing_maxValue,
                                visualEffectsInput.Easing_duration,
                                visualEffectsInput._ValueToReach,
                                visualEffectsInput._Duration,
                                visualEffectsInput._Delay,
                                visualEffectsInput._Reverse,
                                visualEffectsInput._Loops,
                                visualEffectsInput._Target,
                                visualEffectsInput.dummy_float,
                                visualEffectsInput.dummy_string

                                });
                            }
                        }

                        else if (visualEffectsInput._GetAnimationType == ZeroitVisAnimEdit.GetAnimationType.ControlFadeEffect2)
                        {
                            ConstructorInfo ctor = typeof(VisualEffectsInput).GetConstructor(new Type[] {

                            typeof(ZeroitVisAnimEdit.GetAnimationType),
                            typeof(ZeroitVisAnimEdit.EasingFunctionTypes),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(int),
                            typeof(int),
                            typeof(int),
                            typeof(bool),
                            typeof(int),
                            typeof(Control),
                            typeof(string),
                            typeof(float)


                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                visualEffectsInput._GetAnimationType,
                                visualEffectsInput._EasingFunctionTypes,
                                visualEffectsInput.Easing_currentTime,
                                visualEffectsInput.Easing_minValue,
                                visualEffectsInput.Easing_maxValue,
                                visualEffectsInput.Easing_duration,
                                visualEffectsInput._ValueToReach,
                                visualEffectsInput._Duration,
                                visualEffectsInput._Delay,
                                visualEffectsInput._Reverse,
                                visualEffectsInput._Loops,
                                visualEffectsInput._Target,
                                visualEffectsInput.dummy_string,
                                visualEffectsInput.dummy_float,


                                });
                            }
                        }

                        else if (visualEffectsInput._GetAnimationType == ZeroitVisAnimEdit.GetAnimationType.FoldEffect)
                        {
                            ConstructorInfo ctor = typeof(VisualEffectsInput).GetConstructor(new Type[] {


                            typeof(ZeroitVisAnimEdit.GetAnimationType),
                            typeof(ZeroitVisAnimEdit.EasingFunctionTypes),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(int),
                            typeof(int),
                            typeof(int),
                            typeof(bool),
                            typeof(int),
                            typeof(Control),
                            typeof(string),
                            typeof(int)


                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                visualEffectsInput._GetAnimationType,
                                visualEffectsInput._EasingFunctionTypes,
                                visualEffectsInput.Easing_currentTime,
                                visualEffectsInput.Easing_minValue,
                                visualEffectsInput.Easing_maxValue,
                                visualEffectsInput.Easing_duration,
                                visualEffectsInput._ValueToReach,
                                visualEffectsInput._Duration,
                                visualEffectsInput._Delay,
                                visualEffectsInput._Reverse,
                                visualEffectsInput._Loops,
                                visualEffectsInput._Target,
                                visualEffectsInput.dummy_string,
                                visualEffectsInput.dummy_int


                                });
                            }
                        }

                        else if (visualEffectsInput._GetAnimationType == ZeroitVisAnimEdit.GetAnimationType.FontSizeEffect)
                        {
                            ConstructorInfo ctor = typeof(VisualEffectsInput).GetConstructor(new Type[] {


                            typeof(ZeroitVisAnimEdit.GetAnimationType),
                            typeof(ZeroitVisAnimEdit.EasingFunctionTypes),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(int),
                            typeof(int),
                            typeof(int),
                            typeof(bool),
                            typeof(int),
                            typeof(Control),
                            typeof(int),
                            typeof(string)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                visualEffectsInput._GetAnimationType,
                                visualEffectsInput._EasingFunctionTypes,
                                visualEffectsInput.Easing_currentTime,
                                visualEffectsInput.Easing_minValue,
                                visualEffectsInput.Easing_maxValue,
                                visualEffectsInput.Easing_duration,
                                visualEffectsInput._ValueToReach,
                                visualEffectsInput._Duration,
                                visualEffectsInput._Delay,
                                visualEffectsInput._Reverse,
                                visualEffectsInput._Loops,
                                visualEffectsInput._Target,
                                visualEffectsInput.dummy_int,
                                visualEffectsInput.dummy_string

                                });
                            }
                        }

                        else if (visualEffectsInput._GetAnimationType == ZeroitVisAnimEdit.GetAnimationType.FormFadeEffect)
                        {
                            ConstructorInfo ctor = typeof(VisualEffectsInput).GetConstructor(new Type[] {


                            typeof(ZeroitVisAnimEdit.GetAnimationType),
                            typeof(ZeroitVisAnimEdit.EasingFunctionTypes),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(int),
                            typeof(int),
                            typeof(int),
                            typeof(bool),
                            typeof(int),
                            typeof(Control),
                            typeof(int),
                            typeof(float)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                visualEffectsInput._GetAnimationType,
                                visualEffectsInput._EasingFunctionTypes,
                                visualEffectsInput.Easing_currentTime,
                                visualEffectsInput.Easing_minValue,
                                visualEffectsInput.Easing_maxValue,
                                visualEffectsInput.Easing_duration,
                                visualEffectsInput._ValueToReach,
                                visualEffectsInput._Duration,
                                visualEffectsInput._Delay,
                                visualEffectsInput._Reverse,
                                visualEffectsInput._Loops,
                                visualEffectsInput._Target,
                                visualEffectsInput.dummy_int,
                                visualEffectsInput.dummy_float

                                });
                            }
                        }

                        else if (visualEffectsInput._GetAnimationType == ZeroitVisAnimEdit.GetAnimationType.HorizontalFoldEffect)
                        {
                            ConstructorInfo ctor = typeof(VisualEffectsInput).GetConstructor(new Type[] {


                            typeof(ZeroitVisAnimEdit.GetAnimationType),
                            typeof(ZeroitVisAnimEdit.EasingFunctionTypes),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(int),
                            typeof(int),
                            typeof(int),
                            typeof(bool),
                            typeof(int),
                            typeof(Control),
                            typeof(float),
                            typeof(int)


                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                visualEffectsInput._GetAnimationType,
                                visualEffectsInput._EasingFunctionTypes,
                                visualEffectsInput.Easing_currentTime,
                                visualEffectsInput.Easing_minValue,
                                visualEffectsInput.Easing_maxValue,
                                visualEffectsInput.Easing_duration,
                                visualEffectsInput._ValueToReach,
                                visualEffectsInput._Duration,
                                visualEffectsInput._Delay,
                                visualEffectsInput._Reverse,
                                visualEffectsInput._Loops,
                                visualEffectsInput._Target,
                                visualEffectsInput.dummy_float,
                                visualEffectsInput.dummy_int

                                });
                            }
                        }

                        else if (visualEffectsInput._GetAnimationType == ZeroitVisAnimEdit.GetAnimationType.LeftAnchoredWidthEffect)
                        {
                            ConstructorInfo ctor = typeof(VisualEffectsInput).GetConstructor(new Type[] {


                            typeof(ZeroitVisAnimEdit.GetAnimationType),
                            typeof(ZeroitVisAnimEdit.EasingFunctionTypes),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(int),
                            typeof(int),
                            typeof(int),
                            typeof(bool),
                            typeof(int),
                            typeof(Control),
                            typeof(double)

                        });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                visualEffectsInput._GetAnimationType,
                                visualEffectsInput._EasingFunctionTypes,
                                visualEffectsInput.Easing_currentTime,
                                visualEffectsInput.Easing_minValue,
                                visualEffectsInput.Easing_maxValue,
                                visualEffectsInput.Easing_duration,
                                visualEffectsInput._ValueToReach,
                                visualEffectsInput._Duration,
                                visualEffectsInput._Delay,
                                visualEffectsInput._Reverse,
                                visualEffectsInput._Loops,
                                visualEffectsInput._Target,
                                visualEffectsInput.dummy_double


                            });
                            }
                        }

                        else if (visualEffectsInput._GetAnimationType == ZeroitVisAnimEdit.GetAnimationType.RightAnchoredWidthEffect)
                        {
                            ConstructorInfo ctor = typeof(VisualEffectsInput).GetConstructor(new Type[] {


                            typeof(ZeroitVisAnimEdit.GetAnimationType),
                            typeof(ZeroitVisAnimEdit.EasingFunctionTypes),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(int),
                            typeof(int),
                            typeof(int),
                            typeof(bool),
                            typeof(int),
                            typeof(Control),
                            typeof(double),
                            typeof(double)

                        });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                visualEffectsInput._GetAnimationType,
                                visualEffectsInput._EasingFunctionTypes,
                                visualEffectsInput.Easing_currentTime,
                                visualEffectsInput.Easing_minValue,
                                visualEffectsInput.Easing_maxValue,
                                visualEffectsInput.Easing_duration,
                                visualEffectsInput._ValueToReach,
                                visualEffectsInput._Duration,
                                visualEffectsInput._Delay,
                                visualEffectsInput._Reverse,
                                visualEffectsInput._Loops,
                                visualEffectsInput._Target,
                                visualEffectsInput.dummy_double,
                                visualEffectsInput.dummy_double

                            });
                            }
                        }

                        else if (visualEffectsInput._GetAnimationType == ZeroitVisAnimEdit.GetAnimationType.TopAnchoredHeightEffect)
                        {
                            ConstructorInfo ctor = typeof(VisualEffectsInput).GetConstructor(new Type[] {

                            typeof(ZeroitVisAnimEdit.GetAnimationType),
                            typeof(ZeroitVisAnimEdit.EasingFunctionTypes),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(int),
                            typeof(int),
                            typeof(int),
                            typeof(bool),
                            typeof(int),
                            typeof(Control),
                            typeof(double),
                            typeof(int)

                        });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                visualEffectsInput._GetAnimationType,
                                visualEffectsInput._EasingFunctionTypes,
                                visualEffectsInput.Easing_currentTime,
                                visualEffectsInput.Easing_minValue,
                                visualEffectsInput.Easing_maxValue,
                                visualEffectsInput.Easing_duration,
                                visualEffectsInput._ValueToReach,
                                visualEffectsInput._Duration,
                                visualEffectsInput._Delay,
                                visualEffectsInput._Reverse,
                                visualEffectsInput._Loops,
                                visualEffectsInput._Target,
                                visualEffectsInput.dummy_double,
                                visualEffectsInput.dummy_int

                            });
                            }
                        }

                        else if (visualEffectsInput._GetAnimationType == ZeroitVisAnimEdit.GetAnimationType.VerticalFoldEffect)
                        {
                            ConstructorInfo ctor = typeof(VisualEffectsInput).GetConstructor(new Type[] {

                            typeof(ZeroitVisAnimEdit.GetAnimationType),
                            typeof(ZeroitVisAnimEdit.EasingFunctionTypes),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(double),
                            typeof(int),
                            typeof(int),
                            typeof(int),
                            typeof(bool),
                            typeof(int),
                            typeof(Control),
                            typeof(double),
                            typeof(int),
                            typeof(double)

                        });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                visualEffectsInput._GetAnimationType,
                                visualEffectsInput._EasingFunctionTypes,
                                visualEffectsInput.Easing_currentTime,
                                visualEffectsInput.Easing_minValue,
                                visualEffectsInput.Easing_maxValue,
                                visualEffectsInput.Easing_duration,
                                visualEffectsInput._ValueToReach,
                                visualEffectsInput._Duration,
                                visualEffectsInput._Delay,
                                visualEffectsInput._Reverse,
                                visualEffectsInput._Loops,
                                visualEffectsInput._Target,
                                visualEffectsInput.dummy_double,
                                visualEffectsInput.dummy_int,
                                visualEffectsInput.dummy_double

                            });
                            }
                        }



                        else
                        {
                            ConstructorInfo ctor = typeof(VisualEffectsInput).GetConstructor(Type.EmptyTypes);
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, null);
                            }
                        }
                    }
                
                return base.ConvertTo(context, culture, value, destinationType);
            }
        }

        #endregion

        #region Editor Brush

        /// <summary>
        /// Gets the UI type editor pen.
        /// </summary>
        /// <param name="bounds">The bounds.</param>
        /// <returns>Pen.</returns>
        internal Pen GetUITypeEditorPen(Rectangle bounds)
        {
            return GetPen(bounds);
        }

        /// <summary>
        /// Get <c>Brush</c> for this fill.
        /// </summary>
        /// <param name="rect">Rectangle area to which fill is to be applied.</param>
        /// <returns>Brush.</returns>
        /// <remarks>The <c>rect</c> parameter only affects the brush if <c>FillerType</c> is <c>LinearGradient</c> or <c>PathGradient</c>.
        /// <para>
        /// The caller is responsible for disposing of the returned brush.
        /// </para></remarks>
        public Pen GetPen(Rectangle rect)
        {
            return GetPen(new RectangleF(rect.X, rect.Y, rect.Width, rect.Height));
        }

        /// <summary>
        /// Get <c>Brush</c> for this fill.
        /// </summary>
        /// <param name="rect">Rectangle area to which fill is to be applied.</param>
        /// <returns>Brush.</returns>
        /// <remarks>The <c>rect</c> parameter only affects the brush if <c>FillerType</c> is <c>LinearGradient</c> or <c>PathGradient</c>.
        /// <para>
        /// The caller is responsible for disposing of the returned brush.
        /// </para></remarks>
        public Pen GetPen(RectangleF rect)
        {
            Color borderColor = Color.Pink;
            switch (AnimationType)
            {
                case ZeroitVisAnimEdit.GetAnimationType.BottomAnchoredHeightEffect:
                    return new Pen(borderColor);
                    
                case ZeroitVisAnimEdit.GetAnimationType.ColorChannelShiftEffect:
                    return new Pen(borderColor); 
                case ZeroitVisAnimEdit.GetAnimationType.ColorShiftEffect:
                    return new Pen(borderColor);
                case ZeroitVisAnimEdit.GetAnimationType.ControlFadeEffect:
                    return new Pen(borderColor);
                case ZeroitVisAnimEdit.GetAnimationType.ControlFadeEffect2:
                    return new Pen(borderColor);
                case ZeroitVisAnimEdit.GetAnimationType.FormFadeEffect:
                    return new Pen(borderColor);
                case ZeroitVisAnimEdit.GetAnimationType.FontSizeEffect:
                    return new Pen(borderColor);
                case ZeroitVisAnimEdit.GetAnimationType.FoldEffect:
                    return new Pen(borderColor);
                case ZeroitVisAnimEdit.GetAnimationType.HorizontalFoldEffect:
                    return new Pen(borderColor);
                case ZeroitVisAnimEdit.GetAnimationType.LeftAnchoredWidthEffect:
                    return new Pen(borderColor);
                case ZeroitVisAnimEdit.GetAnimationType.RightAnchoredWidthEffect:
                    return new Pen(borderColor);
                case ZeroitVisAnimEdit.GetAnimationType.TopAnchoredHeightEffect:
                    return new Pen(borderColor);
                case ZeroitVisAnimEdit.GetAnimationType.VerticalFoldEffect:
                    return new Pen(borderColor);
                case ZeroitVisAnimEdit.GetAnimationType.XLocationEffect:
                    return new Pen(borderColor);
                case ZeroitVisAnimEdit.GetAnimationType.YLocationEffect:
                    return new Pen(borderColor);
                default:
                    return new Pen(borderColor);
            }
            
        }



        /// <summary>
        /// Gets the UI type editor brush.
        /// </summary>
        /// <param name="bounds">The bounds.</param>
        /// <returns>Brush.</returns>
        internal Brush GetUITypeEditorBrush(Rectangle bounds)
        {
            return GetBrush(bounds);
        }

        /// <summary>
        /// Get <c>Brush</c> for this fill.
        /// </summary>
        /// <param name="rect">Rectangle area to which fill is to be applied.</param>
        /// <returns>Brush.</returns>
        /// <remarks>The <c>rect</c> parameter only affects the brush if <c>FillerType</c> is <c>LinearGradient</c> or <c>PathGradient</c>.
        /// <para>
        /// The caller is responsible for disposing of the returned brush.
        /// </para></remarks>
        public Brush GetBrush(Rectangle rect)
        {
            return GetBrush(new RectangleF(rect.X, rect.Y, rect.Width, rect.Height));
        }

        /// <summary>
        /// Get <c>Brush</c> for this fill.
        /// </summary>
        /// <param name="rect">Rectangle area to which fill is to be applied.</param>
        /// <returns>Brush.</returns>
        /// <remarks>The <c>rect</c> parameter only affects the brush if <c>FillerType</c> is <c>LinearGradient</c> or <c>PathGradient</c>.
        /// <para>
        /// The caller is responsible for disposing of the returned brush.
        /// </para></remarks>
        public Brush GetBrush(RectangleF rect)
        {
            Color shapeColor = Color.Aqua;

            switch (AnimationType)
            {
                case ZeroitVisAnimEdit.GetAnimationType.BottomAnchoredHeightEffect:
                    return new SolidBrush(shapeColor);
                case ZeroitVisAnimEdit.GetAnimationType.ColorChannelShiftEffect:
                    return new SolidBrush(shapeColor);
                case ZeroitVisAnimEdit.GetAnimationType.ColorShiftEffect:
                    return new SolidBrush(shapeColor);
                case ZeroitVisAnimEdit.GetAnimationType.ControlFadeEffect:
                    return new SolidBrush(shapeColor);
                case ZeroitVisAnimEdit.GetAnimationType.ControlFadeEffect2:
                    return new SolidBrush(shapeColor);
                case ZeroitVisAnimEdit.GetAnimationType.FormFadeEffect:
                    return new SolidBrush(shapeColor);
                case ZeroitVisAnimEdit.GetAnimationType.FontSizeEffect:
                    return new SolidBrush(shapeColor);
                case ZeroitVisAnimEdit.GetAnimationType.FoldEffect:
                    return new SolidBrush(shapeColor);
                case ZeroitVisAnimEdit.GetAnimationType.HorizontalFoldEffect:
                    return new SolidBrush(shapeColor);
                case ZeroitVisAnimEdit.GetAnimationType.LeftAnchoredWidthEffect:
                    return new SolidBrush(shapeColor);
                case ZeroitVisAnimEdit.GetAnimationType.RightAnchoredWidthEffect:
                    return new SolidBrush(shapeColor);
                case ZeroitVisAnimEdit.GetAnimationType.TopAnchoredHeightEffect:
                    return new SolidBrush(shapeColor);
                case ZeroitVisAnimEdit.GetAnimationType.VerticalFoldEffect:
                    return new SolidBrush(shapeColor);
                case ZeroitVisAnimEdit.GetAnimationType.XLocationEffect:
                    return new SolidBrush(shapeColor);
                case ZeroitVisAnimEdit.GetAnimationType.YLocationEffect:
                    return new SolidBrush(shapeColor);
                default:
                    return new SolidBrush(shapeColor);
            }
            
        }

        #endregion


    }
}
