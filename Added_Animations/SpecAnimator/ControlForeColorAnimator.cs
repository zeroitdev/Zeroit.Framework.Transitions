// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-25-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-25-2018
// ***********************************************************************
// <copyright file="ControlForeColorAnimator.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.SpecAnimator
{
    /// <summary>
    /// Class ZeroitSpecForeColorAnimator.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecAnimatorBase" />
    public class ZeroitSpecForeColorAnimator : ZeroitSpecAnimatorBase
  {
        /// <summary>
        /// The control
        /// </summary>
        private Control _control;
        /// <summary>
        /// The start color
        /// </summary>
        private Color _startColor;
        /// <summary>
        /// The end color
        /// </summary>
        private Color _endColor;

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitSpecForeColorAnimator"/> class.
        /// </summary>
        /// <param name="container">The container.</param>
        public ZeroitSpecForeColorAnimator(IContainer container)
      : base(container)
    {
      this.Initialize();
    }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitSpecForeColorAnimator"/> class.
        /// </summary>
        public ZeroitSpecForeColorAnimator()
    {
      this.Initialize();
    }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        private void Initialize()
    {
      this._startColor = this.DefaultStartColor;
      this._endColor = this.DefaultEndColor;
    }

        /// <summary>
        /// Gets or sets the start color.
        /// </summary>
        /// <value>The start color.</value>
        [Description("Gets or sets the starting color for the animation.")]
    [Browsable(true)]
    [Category("Appearance")]
    public Color StartColor
    {
      get
      {
        return this._startColor;
      }
      set
      {
        if (this._startColor == value)
          return;
        this._startColor = value;
        this.OnStartValueChanged(EventArgs.Empty);
      }
    }

        /// <summary>
        /// Gets or sets the end color.
        /// </summary>
        /// <value>The end color.</value>
        [Category("Appearance")]
    [Browsable(true)]
    [Description("Gets or sets the ending Color for the animation.")]
    public Color EndColor
    {
      get
      {
        return this._endColor;
      }
      set
      {
        if (this._endColor == value)
          return;
        this._endColor = value;
        this.OnEndValueChanged(EventArgs.Empty);
      }
    }

        /// <summary>
        /// Gets or sets the control.
        /// </summary>
        /// <value>The control.</value>
        [Category("Behavior")]
    [RefreshProperties(RefreshProperties.Repaint)]
    [Description("Gets or sets which Control should be animated.")]
    [Browsable(true)]
    [DefaultValue(null)]
    public Control Control
    {
      get
      {
        return this._control;
      }
      set
      {
        if (this._control == value)
          return;
        if (this._control != null)
          this._control.ForeColorChanged -= OnCurrentValueChanged/*new EventHandler(((ZeroitSpecAnimatorBase) this).OnCurrentValueChanged)*/;
        this._control = value;
        if (this._control != null)
          this._control.ForeColorChanged += OnCurrentValueChanged /*new EventHandler(((ZeroitSpecAnimatorBase) this).OnCurrentValueChanged)*/;
        this.ResetValues();
      }
    }

        /// <summary>
        /// Gets or sets the current value internal.
        /// </summary>
        /// <value>The current value internal.</value>
        protected override object CurrentValueInternal
    {
      get
      {
        return (object) (this._control == null ? Color.Empty : this._control.ForeColor);
      }
      set
      {
        if (this._control == null)
          return;
        this._control.ForeColor = (Color) value;
      }
    }

        /// <summary>
        /// Gets or sets the start value.
        /// </summary>
        /// <value>The start value.</value>
        public override object StartValue
    {
      get
      {
        return (object) this.StartColor;
      }
      set
      {
        this.StartColor = (Color) value;
      }
    }

        /// <summary>
        /// Gets or sets the end value.
        /// </summary>
        /// <value>The end value.</value>
        public override object EndValue
    {
      get
      {
        return (object) this.EndColor;
      }
      set
      {
        this.EndColor = (Color) value;
      }
    }

        /// <summary>
        /// Gets the value for step.
        /// </summary>
        /// <param name="step">The step.</param>
        /// <returns>System.Object.</returns>
        protected override object GetValueForStep(double step)
    {
      if (this._startColor == Color.Empty || this._endColor == Color.Empty)
        return this.CurrentValue;
      return (object) ZeroitSpecAnimatorBase.InterpolateColors(this._startColor, this._endColor, step);
    }

        /// <summary>
        /// Gets the default color of the start.
        /// </summary>
        /// <value>The default color of the start.</value>
        protected virtual Color DefaultStartColor
    {
      get
      {
        return Color.Empty;
      }
    }

        /// <summary>
        /// Gets the default color of the end.
        /// </summary>
        /// <value>The default color of the end.</value>
        protected virtual Color DefaultEndColor
    {
      get
      {
        return Color.Empty;
      }
    }

        /// <summary>
        /// Shoulds the start color of the serialize.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        protected virtual bool ShouldSerializeStartColor()
    {
      return this._startColor != this.DefaultStartColor;
    }

        /// <summary>
        /// Shoulds the end color of the serialize.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        protected virtual bool ShouldSerializeEndColor()
    {
      return this._endColor != this.DefaultEndColor;
    }
  }
}
