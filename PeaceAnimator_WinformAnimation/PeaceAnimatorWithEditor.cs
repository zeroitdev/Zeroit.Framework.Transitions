// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="PeaceAnimatorWithEditor.cs" company="Zeroit Dev Technologies">
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
using Zeroit.Framework.Transitions.WinFormAnimation;
using System.Drawing;
using Zeroit.Framework.Transitions.AnimationEditors;
using Zeroit.Framework.Transitions.ZeroitPeaceAnimator_WinformAnimation;

namespace Zeroit.Framework.Transitions.WinformAnimation
{

    /// <summary>
    /// A class collection that provides animation functionality.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    public partial class ZeroitPeaceAnimEdit : Component
    {

        #region Private Fields


        /// <summary>
        /// The peace input
        /// </summary>
        public PeaceInput peaceInput = new PeaceInput(
            animationMode.OneD, false, false, 0, 100, 5000, 0,
            KnownAnimationFunctions.CircularEaseIn, "Value",
            Animator.KnownProperties.Value, true, new Animator(new Path(0, 100, 5000, 0)), 
            new Control()
            );

        /// <summary>
        /// The current status
        /// </summary>
        private AnimatorStatus currentStatus = AnimatorStatus.Playing;

        #endregion

        //#region Public Properties

        //public PeaceInput PeaceInput
        //{
        //    get
        //    {
        //        return peaceInput;

        //    }
        //    set
        //    {
        //        peaceInput = value;
        //        peaceInput.Control.Invalidate();
        //    }
        //}

        //public Control Control
        //{
        //    get { return peaceInput.control; }
        //    set { peaceInput.control = value; }
        //}

        //#region 1D Public Properties
        //[Category("1D Animation")]
        //public float StartValue
        //{
        //    get { return peaceInput.StartValue; }
        //    set
        //    {
        //        peaceInput.StartValue = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("1D Animation")]
        //public float EndValue
        //{
        //    get { return peaceInput.EndValue; }
        //    set
        //    {
        //        peaceInput.EndValue = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("1D Animation")]
        //public ulong DurationValue
        //{
        //    get { return peaceInput.DurationValue; }
        //    set
        //    {
        //        peaceInput.DurationValue = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("1D Animation")]
        //public ulong DelayValue
        //{
        //    get { return peaceInput.DelayValue; }
        //    set
        //    {
        //        peaceInput.DelayValue = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("1D Animation")]
        //public KnownAnimationFunctions OneD_Path_Easing
        //{
        //    get { return peaceInput.OneD_Path_Easing; }
        //    set
        //    {
        //        peaceInput.OneD_Path_Easing = value;
        //    }
        //}

        //[Category("1D Animation")]
        //public string PropertyName
        //{
        //    get { return peaceInput.PropertyName; }
        //    set
        //    {
        //        peaceInput.PropertyName = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("1D Animation")]
        //public Animator.KnownProperties OneDProperty
        //{
        //    get { return peaceInput.OneDProperty; }
        //    set
        //    {
        //        peaceInput.OneDProperty = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("1D Animation")]
        //public bool OneD_Continue
        //{
        //    get { return peaceInput.OneD_Continue; }
        //    set
        //    {
        //        peaceInput.OneD_Continue = value;
        //        //Control.Invalidate();
        //    }
        //}
        //#endregion


        //#region 2D Public Properties
        //[Category("2D Animation")]
        //public float Path2D_start_1
        //{
        //    get { return peaceInput.Path2D_start_1; }
        //    set
        //    {
        //        peaceInput.Path2D_start_1 = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("2D Animation")]
        //public float Path2D_end_1
        //{
        //    get { return peaceInput.Path2D_end_1; }
        //    set
        //    {
        //        peaceInput.Path2D_end_1 = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("2D Animation")]
        //public ulong Path2D_duration_1
        //{
        //    get { return peaceInput.Path2D_duration_1; }
        //    set
        //    {
        //        peaceInput.Path2D_duration_1 = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("2D Animation")]
        //public ulong Path2D_delay_1
        //{
        //    get { return peaceInput.Path2D_delay_1; }
        //    set
        //    {
        //        peaceInput.Path2D_delay_1 = value;
        //        //Control.Invalidate();
        //    }
        //}


        //[Category("2D Animation")]
        //public float Path2D_start_2
        //{
        //    get { return peaceInput.Path2D_start_2; }
        //    set
        //    {
        //        peaceInput.Path2D_start_2 = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("2D Animation")]
        //public float Path2D_end_2
        //{
        //    get { return peaceInput.Path2D_end_2; }
        //    set
        //    {
        //        peaceInput.Path2D_end_2 = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("2D Animation")]
        //public ulong Path2D_duration_2
        //{
        //    get { return peaceInput.Path2D_duration_2; }
        //    set
        //    {
        //        peaceInput.Path2D_duration_2 = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("2D Animation")]
        //public ulong Path2D_delay_2
        //{
        //    get { return peaceInput.Path2D_delay_2; }
        //    set
        //    {
        //        peaceInput.Path2D_delay_2 = value;
        //        //Control.Invalidate();
        //    }
        //}



        //[Category("2D Animation")]
        //public float Continued_path2D_start_1
        //{
        //    get { return peaceInput.Continued_path2D_start_1; }
        //    set
        //    {
        //        peaceInput.Continued_path2D_start_1 = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("2D Animation")]
        //public float Continued_path2D_end_1
        //{
        //    get { return peaceInput.Continued_path2D_end_1; }
        //    set
        //    {
        //        peaceInput.Continued_path2D_end_1 = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("2D Animation")]
        //public ulong Continued_path2D_duration_1
        //{
        //    get { return peaceInput.Continued_path2D_duration_1; }
        //    set
        //    {
        //        peaceInput.Continued_path2D_duration_1 = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("2D Animation")]
        //public ulong Continued_path2D_delay_1
        //{
        //    get { return peaceInput.Continued_path2D_delay_1; }
        //    set
        //    {
        //        peaceInput.Continued_path2D_delay_1 = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("2D Animation")]
        //public float Continued_path2D_start_2
        //{
        //    get { return peaceInput.Continued_path2D_start_2; }
        //    set
        //    {
        //        peaceInput.Continued_path2D_start_2 = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("2D Animation")]
        //public float Continued_path2D_end_2
        //{
        //    get { return peaceInput.Continued_path2D_end_2; }
        //    set
        //    {
        //        peaceInput.Continued_path2D_end_2 = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("2D Animation")]
        //public ulong Continued_path2D_duration_2
        //{
        //    get { return peaceInput.Continued_path2D_duration_2; }
        //    set
        //    {
        //        peaceInput.Continued_path2D_duration_2 = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("2D Animation")]
        //public ulong Continued_path2D_delay_2
        //{
        //    get { return peaceInput.Continued_path2D_delay_2; }
        //    set
        //    {
        //        peaceInput.Continued_path2D_delay_2 = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("2D Animation")]
        //public KnownAnimationFunctions Path_Easing
        //{
        //    get { return peaceInput.Path_Easing; }
        //    set
        //    {
        //        peaceInput.Path_Easing = value;
        //    }
        //}


        ////public KnownAnimationFunctions Path2_Easing
        ////{
        ////    get { return path2_easingFunction; }
        ////    set
        ////    {
        ////        path2_easingFunction = value;
        ////    }
        ////}

        //[Category("2D Animation")]
        //public KnownAnimationFunctions Continued_Path_Easing
        //{
        //    get { return peaceInput.Continued_Path_Easing; }
        //    set
        //    {
        //        peaceInput.Continued_Path_Easing = value;
        //    }
        //}

        ////public KnownAnimationFunctions Continued_Path2_Easing
        ////{
        ////    get { return continued_path2_easingFunction; }
        ////    set
        ////    {
        ////        continued_path2_easingFunction = value;
        ////    }
        ////}

        //[Category("2D Animation")]
        //public Animator2D.KnownProperties TwoDProperty
        //{
        //    get { return peaceInput.TwoDProperty; }
        //    set
        //    {
        //        peaceInput.TwoDProperty = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("2D Animation")]
        //public bool TwoDContinue
        //{
        //    get { return peaceInput.TwoDContinue; }
        //    set
        //    {
        //        peaceInput.TwoDContinue = value;
        //        //Control.Invalidate();
        //    }
        //}

        //#endregion


        //#region 3D Public Properties
        //[Category("3D Animation")]
        //public Color StartColor
        //{
        //    get { return peaceInput.StartColor; }
        //    set
        //    {
        //        peaceInput.StartColor = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("3D Animation")]
        //public Color EndColor
        //{
        //    get { return peaceInput.EndColor; }
        //    set
        //    {
        //        peaceInput.EndColor = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("3D Animation")]
        //public Animator3D.KnownProperties ThreeDProperty
        //{
        //    get { return peaceInput.ThreeDProperty; }
        //    set
        //    {
        //        peaceInput.ThreeDProperty = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("3D Animation")]
        //public bool ThreeDContinue
        //{
        //    get { return peaceInput.ThreeDContinue; }
        //    set
        //    {
        //        peaceInput.ThreeDContinue = value;
        //        Control.Invalidate();
        //    }
        //}

        //[Category("3D Animation")]
        //public ulong Path3_Duration
        //{
        //    get { return peaceInput.Path3_Duration; }
        //    set
        //    {
        //        peaceInput.Path3_Duration = value;
        //        Control.Invalidate();
        //    }
        //}

        //[Category("3D Animation")]
        //public ulong Path3_Delay
        //{
        //    get { return peaceInput.Path3_Delay; }
        //    set
        //    {
        //        peaceInput.Path3_Delay = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("3D Animation")]
        //public KnownAnimationFunctions Path3_Easing
        //{
        //    get { return peaceInput.Path3_Easing; }
        //    set
        //    {
        //        peaceInput.Path3_Easing = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("3D Animation")]
        //public string ColorPropertyName
        //{
        //    get { return peaceInput.ColorPropertyName; }
        //    set
        //    {
        //        peaceInput.ColorPropertyName = value;
        //        //Control.Invalidate();
        //    }
        //}

        //#endregion


        //#region General Animation

        ////[Category("General Animation")]
        ////public Control Control
        ////{
        ////    get { return peaceInput.Control; }
        ////    set
        ////    {

        ////        control = value;
        ////        control.Invalidate();
        ////    }
        ////}

        ////[Category("General Animation")]
        ////public Control Control
        ////{
        ////    get { return peaceInput.Control; }
        ////    set
        ////    {

        ////        peaceInput.Control = value;
        ////        peaceInput.Control.Invalidate();
        ////    }
        ////}

        //[Category("General Animation")]
        //public animationMode AnimationMode
        //{
        //    get { return peaceInput.AnimationMode; }
        //    set
        //    {
        //        peaceInput.AnimationMode = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("General Animation")]
        //public bool Repeat
        //{
        //    get { return peaceInput.Repeat; }
        //    set
        //    {
        //        //if (value == true)
        //        //{
        //        //    peaceInput.Animator.Repeat = true;
        //        //    peaceInput.Animator2D.Repeat = true;
        //        //    peaceInput.Animator3D.Repeat = true;
        //        //}
        //        //else
        //        //{
        //        //    peaceInput.Animator.Repeat = false;
        //        //    peaceInput.Animator2D.Repeat = false;
        //        //    peaceInput.Animator3D.Repeat = false;

        //        //}
        //        peaceInput.Repeat = value;
        //        //Control.Invalidate();
        //    }
        //}

        //[Category("General Animation")]
        //public bool Reverse
        //{
        //    get { return peaceInput.Reverse; }
        //    set
        //    {

        //        //if (value == true)
        //        //{
        //        //    peaceInput.Animator.ReverseRepeat = true;
        //        //    peaceInput.Animator2D.ReverseRepeat = true;
        //        //    peaceInput.Animator3D.ReverseRepeat = true;
        //        //}
        //        //else
        //        //{
        //        //    peaceInput.Animator.ReverseRepeat = false;
        //        //    peaceInput.Animator2D.ReverseRepeat = false;
        //        //    peaceInput.Animator3D.ReverseRepeat = false;
        //        //}

        //        peaceInput.Reverse = value;
        //        //Control.Invalidate();
        //    }
        //}

        //#endregion

        //#endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the values in the animation editor. Make sure a control is selected.
        /// </summary>
        /// <value>The peace input.</value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PeaceInput PeaceInput
        {
            get
            {
                return peaceInput;

            }
            set
            {
                peaceInput = value;
                
                peaceInput.Control.Invalidate();
            }
        }


        #region 1D Public Properties
        /// <summary>
        /// Gets or sets the start value.
        /// </summary>
        /// <value>The start value.</value>
        [Category("1D Animation")]
        public float StartValue
        {
            get { return peaceInput.path1_start; }
            set
            {
                peaceInput.path1_start = value;
                peaceInput.Control.Invalidate();

                
            }
        }

        /// <summary>
        /// Gets or sets the end value.
        /// </summary>
        /// <value>The end value.</value>
        [Category("1D Animation")]
        public float EndValue
        {
            get { return peaceInput.path1_end; }
            set
            {
                peaceInput.path1_end = value;
                peaceInput.Control.Invalidate();
                
            }
        }
        /// <summary>
        /// Gets or sets the duration value.
        /// </summary>
        /// <value>The duration value.</value>
        [Category("1D Animation")]
        public ulong DurationValue
        {
            get { return peaceInput.path1_duration; }
            set
            {
                peaceInput.path1_duration = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the delay value.
        /// </summary>
        /// <value>The delay value.</value>
        [Category("1D Animation")]
        public ulong DelayValue
        {
            get { return peaceInput.path1_delay; }
            set
            {
                peaceInput.path1_delay = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 1D path easing.
        /// </summary>
        /// <value>The 1D path easing.</value>
        [Category("1D Animation")]
        public KnownAnimationFunctions OneD_Path_Easing
        {
            get { return peaceInput.oneD_path_easingFunction; }
            set
            {
                peaceInput.oneD_path_easingFunction = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the name of the property.
        /// </summary>
        /// <value>The name of the property.</value>
        [Category("1D Animation")]
        public string PropertyName
        {
            get { return peaceInput.propertyName; }
            set
            {
                peaceInput.propertyName = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 1D property.
        /// </summary>
        /// <value>The one d property.</value>
        [Category("1D Animation")]
        public Animator.KnownProperties OneDProperty
        {
            get { return peaceInput.oneDProperty; }
            set
            {
                peaceInput.oneDProperty = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to continue 1D animation.
        /// </summary>
        /// <value><c>true</c> if 1D continue; otherwise, <c>false</c>.</value>
        [Category("1D Animation")]
        public bool OneD_Continue
        {
            get { return peaceInput.oneDContinue; }
            set
            {
                peaceInput.oneDContinue = value;
                peaceInput.Control.Invalidate();
                
            }
        }
        #endregion


        #region 2D Public Properties
        /// <summary>
        /// Gets or sets the 2D start Path.
        /// </summary>
        /// <value>The 2D start 1 Path.</value>
        [Category("2D Animation")]
        public float Path2D_start_1
        {
            get { return peaceInput.path2D_start_1; }
            set
            {
                peaceInput.path2D_start_1 = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 2D end Path.
        /// </summary>
        /// <value>The 2D end 1 Path.</value>
        [Category("2D Animation")]
        public float Path2D_end_1
        {
            get { return peaceInput.path2D_end_1; }
            set
            {
                peaceInput.path2D_end_1 = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 2D duration.
        /// </summary>
        /// <value>The 2D duration 1.</value>
        [Category("2D Animation")]
        public ulong Path2D_duration_1
        {
            get { return peaceInput.path2D_duration_1; }
            set
            {
                peaceInput.path2D_duration_1 = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 2D delay.
        /// </summary>
        /// <value>The 2D delay 1.</value>
        [Category("2D Animation")]
        public ulong Path2D_delay_1
        {
            get { return peaceInput.path2D_delay_1; }
            set
            {
                peaceInput.path2D_delay_1 = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 2D start Path.
        /// </summary>
        /// <value>The 2D start 2 Path.</value>
        [Category("2D Animation")]
        public float Path2D_start_2
        {
            get { return peaceInput.path2D_start_2; }
            set
            {
                peaceInput.path2D_start_2 = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 2D end Path.
        /// </summary>
        /// <value>The 2D end 2 Path.</value>
        [Category("2D Animation")]
        public float Path2D_end_2
        {
            get { return peaceInput.path2D_end_2; }
            set
            {
                peaceInput.path2D_end_2 = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 2D duration Path.
        /// </summary>
        /// <value>The 2D duration 2 Path.</value>
        [Category("2D Animation")]
        public ulong Path2D_duration_2
        {
            get { return peaceInput.path2D_duration_2; }
            set
            {
                peaceInput.path2D_duration_2 = value;
                peaceInput.Control.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the 2D delay Path.
        /// </summary>
        /// <value>The 2D delay 2 Path.</value>
        [Category("2D Animation")]
        public ulong Path2D_delay_2
        {
            get { return peaceInput.path2D_delay_2; }
            set
            {
                peaceInput.path2D_delay_2 = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 2D continued start Path.
        /// </summary>
        /// <value>The 2D continued start 1 Path.</value>
        [Category("2D Animation")]
        public float Continued_path2D_start_1
        {
            get { return peaceInput.continued_path2D_start_1; }
            set
            {
                peaceInput.continued_path2D_start_1 = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 2D continued end Path.
        /// </summary>
        /// <value>The 2D continued end 1 Path.</value>
        [Category("2D Animation")]
        public float Continued_path2D_end_1
        {
            get { return peaceInput.continued_path2D_end_1; }
            set
            {
                peaceInput.continued_path2D_end_1 = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 2D continued duration Path.
        /// </summary>
        /// <value>The 2D continued duration 1 Path.</value>
        [Category("2D Animation")]
        public ulong Continued_path2D_duration_1
        {
            get { return peaceInput.continued_path2D_duration_1; }
            set
            {
                peaceInput.continued_path2D_duration_1 = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 2D continued delay Path.
        /// </summary>
        /// <value>The 2D continued delay 1 Path.</value>
        [Category("2D Animation")]
        public ulong Continued_path2D_delay_1
        {
            get { return peaceInput.continued_path2D_delay_1; }
            set
            {
                peaceInput.continued_path2D_delay_1 = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 2D continued start Path.
        /// </summary>
        /// <value>The 2D continued start 2 Path.</value>
        [Category("2D Animation")]
        public float Continued_path2D_start_2
        {
            get { return peaceInput.continued_path2D_start_2; }
            set
            {
                peaceInput.continued_path2D_start_2 = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 2D continued end Path.
        /// </summary>
        /// <value>The 2D continued end 2 Path.</value>
        [Category("2D Animation")]
        public float Continued_path2D_end_2
        {
            get { return peaceInput.continued_path2D_end_2; }
            set
            {
                peaceInput.continued_path2D_end_2 = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 2D continued duration Path.
        /// </summary>
        /// <value>The 2D continued duration 2 Path.</value>
        [Category("2D Animation")]
        public ulong Continued_path2D_duration_2
        {
            get { return peaceInput.continued_path2D_duration_2; }
            set
            {
                peaceInput.continued_path2D_duration_2 = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 2D continued delay Path.
        /// </summary>
        /// <value>The 2D continued delay 2 Path.</value>
        [Category("2D Animation")]
        public ulong Continued_path2D_delay_2
        {
            get { return peaceInput.continued_path2D_delay_2; }
            set
            {
                peaceInput.continued_path2D_delay_2 = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets Path Easing.
        /// </summary>
        /// <value>The Path Easing.</value>
        [Category("2D Animation")]
        public KnownAnimationFunctions Path_Easing
        {
            get { return peaceInput.path_easingFunction; }
            set
            {
                peaceInput.path_easingFunction = value;
                peaceInput.Control.Invalidate();
                
            }
        }


        //public KnownAnimationFunctions Path2_Easing
        //{
        //    get { return path2_easingFunction; }
        //    set
        //    {
        //        path2_easingFunction = value;
        //    }
        //}

        /// <summary>
        /// Gets or sets the continued path easing.
        /// </summary>
        /// <value>The continued path easing.</value>
        [Category("2D Animation")]
        public KnownAnimationFunctions Continued_Path_Easing
        {
            get { return peaceInput.continued_path_easingFunction; }
            set
            {
                peaceInput.continued_path_easingFunction = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        //public KnownAnimationFunctions Continued_Path2_Easing
        //{
        //    get { return continued_path2_easingFunction; }
        //    set
        //    {
        //        continued_path2_easingFunction = value;
        //    }
        //}

        /// <summary>
        /// Gets or sets the 2D property.
        /// </summary>
        /// <value>The 2D property.</value>
        [Category("2D Animation")]
        public Animator2D.KnownProperties TwoDProperty
        {
            get { return peaceInput.twoDProperty; }
            set
            {
                peaceInput.twoDProperty = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to continue 2D animation.
        /// </summary>
        /// <value><c>true</c> if 2D continue; otherwise, <c>false</c>.</value>
        [Category("2D Animation")]
        public bool TwoDContinue
        {
            get { return peaceInput.twoDContinue; }
            set
            {
                peaceInput.twoDContinue = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        #endregion


        #region 3D Public Properties
        /// <summary>
        /// Gets or sets the 3D start color.
        /// </summary>
        /// <value>The 3D start color.</value>
        [Category("3D Animation")]
        public Color StartColor
        {
            get { return peaceInput.startColor; }
            set
            {
                peaceInput.startColor = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 3D end color.
        /// </summary>
        /// <value>The 3D end color.</value>
        [Category("3D Animation")]
        public Color EndColor
        {
            get { return peaceInput.endColor; }
            set
            {
                peaceInput.endColor = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 3D property.
        /// </summary>
        /// <value>The 3D property.</value>
        [Category("3D Animation")]
        public Animator3D.KnownProperties ThreeDProperty
        {
            get { return peaceInput.threeDProperty; }
            set
            {
                peaceInput.threeDProperty = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to continue 3D animation.
        /// </summary>
        /// <value><c>true</c> if 3D continue; otherwise, <c>false</c>.</value>
        [Category("3D Animation")]
        public bool ThreeDContinue
        {
            get { return peaceInput.threeDContinue; }
            set
            {
                peaceInput.threeDContinue = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 3D path animation duration.
        /// </summary>
        /// <value>The 3D path animation duration.</value>
        [Category("3D Animation")]
        public ulong Path3_Duration
        {
            get { return peaceInput.path3_duration; }
            set
            {
                peaceInput.path3_duration = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 3D path animation delay.
        /// </summary>
        /// <value>The 3D path animation delay.</value>
        [Category("3D Animation")]
        public ulong Path3_Delay
        {
            get { return peaceInput.path3_delay; }
            set
            {
                peaceInput.path3_delay = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the 3D path easing function.
        /// </summary>
        /// <value>The 3D path easing function.</value>
        [Category("3D Animation")]
        public KnownAnimationFunctions Path3_Easing
        {
            get { return peaceInput.threeD_path_easingFunction; }
            set
            {
                peaceInput.threeD_path_easingFunction = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets the name of the 3D color property.
        /// </summary>
        /// <value>The name of the 3D color property.</value>
        [Category("3D Animation")]
        public string ColorPropertyName
        {
            get { return peaceInput.colorPropertyName; }
            set
            {
                peaceInput.colorPropertyName = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        #endregion


        #region General Animation
        /// <summary>
        /// Gets or sets the control to use for the animation.
        /// </summary>
        /// <value>The control to use.</value>
        [Category("General Animation")]
        public Control Control
        {
            get { return peaceInput.Control; }
            set
            {
                peaceInput.Control = value;
                peaceInput.Control.Invalidate();
            }
        }

        //private Control control = new Control();

        //[Category("General Animation")]
        //public Control Control
        //{
        //    get { return control; }
        //    set
        //    {
        //        control = value;
        //        control.Invalidate();
        //    }
        //}

        /// <summary>
        /// Gets or sets the animation mode.
        /// </summary>
        /// <value>The animation mode.</value>
        [Category("General Animation")]
        public animationMode AnimationMode
        {
            get { return peaceInput._animationMode; }
            set
            {
                peaceInput._animationMode = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the animation should repeat or not.
        /// </summary>
        /// <value>The repeat.</value>
        [Category("General Animation")]
        public bool Repeat
        {
            get { return peaceInput.repeat; }
            set
            {
                if (value == true)
                {
                    peaceInput._animator.Repeat = true;
                    peaceInput._animator2D.Repeat = true;
                    peaceInput._animator3D.Repeat = true;
                }
                else
                {
                    peaceInput._animator.Repeat = false;
                    peaceInput._animator2D.Repeat = false;
                    peaceInput._animator3D.Repeat = false;

                }
                peaceInput.repeat = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the animation should reverse or not.
        /// </summary>
        /// <value>The reverse.</value>
        [Category("General Animation")]
        public bool Reverse
        {
            get { return peaceInput.reverse; }
            set
            {

                if (value == true)
                {
                    peaceInput._animator.ReverseRepeat = true;
                    peaceInput._animator2D.ReverseRepeat = true;
                    peaceInput._animator3D.ReverseRepeat = true;
                }
                else
                {
                    peaceInput._animator.ReverseRepeat = false;
                    peaceInput._animator2D.ReverseRepeat = false;
                    peaceInput._animator3D.ReverseRepeat = false;
                }

                peaceInput.reverse = value;
                peaceInput.Control.Invalidate();
                
            }
        }

        #endregion


        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitPeaceAnimEdit" /> class.
        /// </summary>
        public ZeroitPeaceAnimEdit()
        {
            peaceInput._animator = new Animator(new Path(peaceInput.StartValue, peaceInput.EndValue, peaceInput.DurationValue, peaceInput.DelayValue));

            
            
        }

        #endregion

        #region Code
        //public void SetsColor(Color color)
        //{
        //    color = peaceInput.StartColor;

        //    peaceInput.Control.BackColor = Color.FromArgb(alpha, color);

        //}


        #endregion

        #region Private Methods

        /// <summary>
        /// Starts the animation.
        /// </summary>
        public void StartFast()
        {
            
            StartFastAnimation.StartFast(
                peaceInput.AnimationMode,
                peaceInput.Control,
                this, peaceInput,
                peaceInput._animator,
                peaceInput._animator2D,
                peaceInput._animator3D);
        }

        /// <summary>
        /// Starts the animation. Performs faster animation.
        /// </summary>
        public void StartFaster()
        {
            StartFasterAnimation.StartFaster(
                peaceInput.AnimationMode,
                peaceInput.Control,
                this, peaceInput,
                peaceInput._animator,
                peaceInput._animator2D,
                peaceInput._animator3D);
        }


        #endregion

    }


}
