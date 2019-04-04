// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-25-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-25-2018
// ***********************************************************************
// <copyright file="TrackBarValueAnimator.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.SpecAnimator
{
    /// <summary>
    /// Class ZeroitSpecValueAnimator.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecAnimatorBase" />
    public class ZeroitSpecValueAnimator : ZeroitSpecAnimatorBase
  {
        /// <summary>
        /// The start value
        /// </summary>
        private int _startValue = 0;
        /// <summary>
        /// The end value
        /// </summary>
        private int _endValue = 0;
        /// <summary>
        /// The default value
        /// </summary>
        private const int DEFAULT_VALUE = 0;
        /// <summary>
        /// The track bar
        /// </summary>
        private TrackBar _trackBar;

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitSpecValueAnimator"/> class.
        /// </summary>
        /// <param name="container">The container.</param>
        public ZeroitSpecValueAnimator(IContainer container)
      : base(container)
    {
    }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitSpecValueAnimator"/> class.
        /// </summary>
        public ZeroitSpecValueAnimator()
    {
    }

        /// <summary>
        /// Gets or sets the start track bar value.
        /// </summary>
        /// <value>The start track bar value.</value>
        [Description("Gets or sets the starting Value for the animation.")]
    [Browsable(true)]
    [DefaultValue(0)]
    [Category("Appearance")]
    public int StartTrackBarValue
    {
      get
      {
        return this._startValue;
      }
      set
      {
        if (this._startValue == value)
          return;
        this._startValue = value;
        this.CheckValues();
        this.OnStartValueChanged(EventArgs.Empty);
      }
    }

        /// <summary>
        /// Gets or sets the end track bar value.
        /// </summary>
        /// <value>The end track bar value.</value>
        [Description("Gets or sets the ending Value for the animation.")]
    [DefaultValue(0)]
    [Category("Appearance")]
    [Browsable(true)]
    public int EndTrackBarValue
    {
      get
      {
        return this._endValue;
      }
      set
      {
        if (this._endValue == value)
          return;
        this._endValue = value;
        this.CheckValues();
        this.OnEndValueChanged(EventArgs.Empty);
      }
    }

        /// <summary>
        /// Gets or sets the track bar.
        /// </summary>
        /// <value>The track bar.</value>
        [DefaultValue(null)]
    [Browsable(true)]
    [Category("Behavior")]
    [RefreshProperties(RefreshProperties.Repaint)]
    [Description("Gets or sets which TrackBar should be animated.")]
    public TrackBar TrackBar
    {
      get
      {
        return this._trackBar;
      }
      set
      {
        if (this._trackBar == value)
          return;
        if (this._trackBar != null)
          this._trackBar.ValueChanged -= /*new EventHandler(((ZeroitSpecAnimatorBase) this).OnCurrentValueChanged)*/OnCurrentValueChanged;
        this._trackBar = value;
        if (this._trackBar != null)
          this._trackBar.ValueChanged += OnCurrentValueChanged/*new EventHandler(((ZeroitSpecAnimatorBase) this).OnCurrentValueChanged)*/;
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
        return (object) (this._trackBar == null ? 0 : this._trackBar.Value);
      }
      set
      {
        if (this._trackBar == null)
          return;
        this._trackBar.Value = (int) value;
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
        return (object) this.StartTrackBarValue;
      }
      set
      {
        this.StartTrackBarValue = (int) value;
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
        return (object) this.EndTrackBarValue;
      }
      set
      {
        this.EndTrackBarValue = (int) value;
      }
    }

        /// <summary>
        /// Gets the value for step.
        /// </summary>
        /// <param name="step">The step.</param>
        /// <returns>System.Object.</returns>
        protected override object GetValueForStep(double step)
    {
      return (object) this.CheckValue(ZeroitSpecAnimatorBase.InterpolateIntegerValues(this._startValue, this._endValue, step));
    }

        /// <summary>
        /// Handles the <see cref="E:CurrentValueChanged" /> event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        protected override void OnCurrentValueChanged(object sender, EventArgs e)
    {
      base.OnCurrentValueChanged(sender, e);
      this.CheckValues();
    }

        /// <summary>
        /// Checks the values.
        /// </summary>
        private void CheckValues()
    {
      this._startValue = this.CheckValue(this._startValue);
      this._endValue = this.CheckValue(this._endValue);
    }

        /// <summary>
        /// Checks the value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.Int32.</returns>
        private int CheckValue(int value)
    {
      if (this._trackBar == null)
        return value;
      if (value < this.TrackBar.Minimum)
        value = this.TrackBar.Minimum;
      else if (value > this.TrackBar.Maximum)
        value = this.TrackBar.Maximum;
      return value;
    }
  }
}
