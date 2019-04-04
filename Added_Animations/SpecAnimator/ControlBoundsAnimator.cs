// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-25-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-25-2018
// ***********************************************************************
// <copyright file="ControlBoundsAnimator.cs" company="Zeroit Dev Technologies">
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
    /// Class ZeroitSpecBoundsAnimator.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecAnimatorBase" />
    public class ZeroitSpecBoundsAnimator : ZeroitSpecAnimatorBase
  {
        /// <summary>
        /// The animate x
        /// </summary>
        private bool _animateX = true;
        /// <summary>
        /// The animate y
        /// </summary>
        private bool _animateY = true;
        /// <summary>
        /// The animate width
        /// </summary>
        private bool _animateWidth = true;
        /// <summary>
        /// The animate height
        /// </summary>
        private bool _animateHeight = true;
        /// <summary>
        /// The default animate
        /// </summary>
        private const bool DEFAULT_ANIMATE = true;
        /// <summary>
        /// The control
        /// </summary>
        private Control _control;
        /// <summary>
        /// The start bounds
        /// </summary>
        private Rectangle _startBounds;
        /// <summary>
        /// The end bounds
        /// </summary>
        private Rectangle _endBounds;

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitSpecBoundsAnimator"/> class.
        /// </summary>
        /// <param name="container">The container.</param>
        public ZeroitSpecBoundsAnimator(IContainer container)
      : base(container)
    {
      this.Initialize();
    }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitSpecBoundsAnimator"/> class.
        /// </summary>
        public ZeroitSpecBoundsAnimator()
    {
      this.Initialize();
    }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        private void Initialize()
    {
      this._startBounds = this.DefaultStartBounds;
      this._endBounds = this.DefaultEndBounds;
    }

        /// <summary>
        /// Gets or sets the start bounds.
        /// </summary>
        /// <value>The start bounds.</value>
        [Description("Gets or sets the starting bounds for the animation.")]
    [Browsable(true)]
    [Category("Appearance")]
    public Rectangle StartBounds
    {
      get
      {
        return this._startBounds;
      }
      set
      {
        if (this._startBounds == value)
          return;
        this._startBounds = value;
        this.CheckBounds();
        this.OnStartValueChanged(EventArgs.Empty);
      }
    }

        /// <summary>
        /// Gets or sets the end bounds.
        /// </summary>
        /// <value>The end bounds.</value>
        [Description("Gets or sets the ending bounds for the animation.")]
    [Category("Appearance")]
    [Browsable(true)]
    public Rectangle EndBounds
    {
      get
      {
        return this._endBounds;
      }
      set
      {
        if (this._endBounds == value)
          return;
        this._endBounds = value;
        this.CheckBounds();
        this.OnEndValueChanged(EventArgs.Empty);
      }
    }

        /// <summary>
        /// Gets or sets a value indicating whether [animate x].
        /// </summary>
        /// <value><c>true</c> if [animate x]; otherwise, <c>false</c>.</value>
        [Category("Behavior")]
    [DefaultValue(true)]
    [Description("Gets or sets whether the Left property of the control should be animated.")]
    [Browsable(true)]
    public bool AnimateX
    {
      get
      {
        return this._animateX;
      }
      set
      {
        this._animateX = value;
        this.CheckBounds();
      }
    }

        /// <summary>
        /// Gets or sets a value indicating whether [animate y].
        /// </summary>
        /// <value><c>true</c> if [animate y]; otherwise, <c>false</c>.</value>
        [Description("Gets or sets whether the Top property of the control should be animated.")]
    [DefaultValue(true)]
    [Browsable(true)]
    [Category("Behavior")]
    public bool AnimateY
    {
      get
      {
        return this._animateY;
      }
      set
      {
        this._animateY = value;
        this.CheckBounds();
      }
    }

        /// <summary>
        /// Gets or sets a value indicating whether [animate width].
        /// </summary>
        /// <value><c>true</c> if [animate width]; otherwise, <c>false</c>.</value>
        [Description("Gets or sets whether the Width property of the control should be animated.")]
    [DefaultValue(true)]
    [Browsable(true)]
    [Category("Behavior")]
    public bool AnimateWidth
    {
      get
      {
        return this._animateWidth;
      }
      set
      {
        this._animateWidth = value;
        this.CheckBounds();
      }
    }

        /// <summary>
        /// Gets or sets a value indicating whether [animate height].
        /// </summary>
        /// <value><c>true</c> if [animate height]; otherwise, <c>false</c>.</value>
        [Browsable(true)]
    [Description("Gets or sets whether the Height property of the control should be animated.")]
    [Category("Behavior")]
    [DefaultValue(true)]
    public bool AnimateHeight
    {
      get
      {
        return this._animateHeight;
      }
      set
      {
        this._animateHeight = value;
        this.CheckBounds();
      }
    }

        /// <summary>
        /// Gets or sets the control.
        /// </summary>
        /// <value>The control.</value>
        [Category("Behavior")]
    [Browsable(true)]
    [RefreshProperties(RefreshProperties.Repaint)]
    [DefaultValue(null)]
    [Description("Gets or sets which Control should be animated.")]
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
        {
          this._control.LocationChanged -= OnCurrentValueChanged/*new EventHandler(((ZeroitSpecAnimatorBase) this).OnCurrentValueChanged)*/;
          this._control.SizeChanged -= OnCurrentValueChanged/*new EventHandler(((ZeroitSpecAnimatorBase) this).OnCurrentValueChanged)*/;
        }
        this._control = value;
        if (this._control != null)
        {
          this._control.LocationChanged += OnCurrentValueChanged/*new EventHandler(((ZeroitSpecAnimatorBase) this).OnCurrentValueChanged)*/;
          this._control.SizeChanged += OnCurrentValueChanged/*new EventHandler(((ZeroitSpecAnimatorBase) this).OnCurrentValueChanged)*/;
        }
        this.ResetValues();
      }
    }

        /// <summary>
        /// Gets the default start bounds.
        /// </summary>
        /// <value>The default start bounds.</value>
        protected virtual Rectangle DefaultStartBounds
    {
      get
      {
        return Rectangle.Empty;
      }
    }

        /// <summary>
        /// Gets the default end bounds.
        /// </summary>
        /// <value>The default end bounds.</value>
        protected virtual Rectangle DefaultEndBounds
    {
      get
      {
        return Rectangle.Empty;
      }
    }

        /// <summary>
        /// Shoulds the serialize start bounds.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        protected virtual bool ShouldSerializeStartBounds()
    {
      return this._startBounds != this.DefaultStartBounds;
    }

        /// <summary>
        /// Shoulds the serialize end bounds.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        protected virtual bool ShouldSerializeEndBounds()
    {
      return this._endBounds != this.DefaultEndBounds;
    }

        /// <summary>
        /// Gets or sets the current value internal.
        /// </summary>
        /// <value>The current value internal.</value>
        protected override object CurrentValueInternal
    {
      get
      {
        return (object) (this._control == null ? Rectangle.Empty : this._control.Bounds);
      }
      set
      {
        if (this._control == null || !(this._control.Bounds != (Rectangle) value))
          return;
        this._control.Bounds = (Rectangle) value;
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
        return (object) this.StartBounds;
      }
      set
      {
        this.StartBounds = (Rectangle) value;
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
        return (object) this.EndBounds;
      }
      set
      {
        this.EndBounds = (Rectangle) value;
      }
    }

        /// <summary>
        /// Gets the value for step.
        /// </summary>
        /// <param name="step">The step.</param>
        /// <returns>System.Object.</returns>
        protected override object GetValueForStep(double step)
    {
      return (object) ZeroitSpecAnimatorBase.InterpolateRectangles(this._startBounds, this._endBounds, step);
    }

        /// <summary>
        /// Handles the <see cref="E:CurrentValueChanged" /> event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        protected override void OnCurrentValueChanged(object sender, EventArgs e)
    {
      base.OnCurrentValueChanged(sender, e);
      this.CheckBounds();
    }

        /// <summary>
        /// Checks the bounds.
        /// </summary>
        /// <param name="bounds">The bounds.</param>
        private void CheckBounds(ref Rectangle bounds)
    {
      if (this._control == null)
        return;
      Rectangle bounds1;
      if (!this._animateX)
      {
        ref Rectangle local = ref bounds;
        bounds1 = this._control.Bounds;
        int x = bounds1.X;
        local.X = x;
      }
      if (!this._animateY)
      {
        ref Rectangle local = ref bounds;
        bounds1 = this._control.Bounds;
        int y = bounds1.Y;
        local.Y = y;
      }
      if (!this._animateWidth)
      {
        ref Rectangle local = ref bounds;
        bounds1 = this._control.Bounds;
        int width = bounds1.Width;
        local.Width = width;
      }
      if (this._animateHeight)
        return;
      ref Rectangle local1 = ref bounds;
      bounds1 = this._control.Bounds;
      int height = bounds1.Height;
      local1.Height = height;
    }

        /// <summary>
        /// Checks the bounds.
        /// </summary>
        private void CheckBounds()
    {
      this.CheckBounds(ref this._startBounds);
      this.CheckBounds(ref this._endBounds);
    }
  }
}
