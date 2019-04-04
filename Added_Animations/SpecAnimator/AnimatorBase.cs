// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-25-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-25-2018
// ***********************************************************************
// <copyright file="AnimatorBase.cs" company="Zeroit Dev Technologies">
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
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.SpecAnimator
{
    /// <summary>
    /// Class ZeroitSpecAnimatorBase.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    /// <seealso cref="System.ComponentModel.ISupportInitialize" />
    public abstract class ZeroitSpecAnimatorBase : Component, ISupportInitialize
  {
        /// <summary>
        /// The components
        /// </summary>
        private Container components = (Container) null;
        /// <summary>
        /// The step size
        /// </summary>
        private double _stepSize = 2.0;
        /// <summary>
        /// The loop mode
        /// </summary>
        private ZeroitSpecLoopMode _loopMode = ZeroitSpecLoopMode.None;
        /// <summary>
        /// The never ending timer
        /// </summary>
        private bool _neverEndingTimer = false;
        /// <summary>
        /// The synchronize mode
        /// </summary>
        private ZeroitSpecSynchronizationMode _syncMode = ZeroitSpecSynchronizationMode.None;
        /// <summary>
        /// The is initializing
        /// </summary>
        private bool _isInitializing = false;
        /// <summary>
        /// The child animators
        /// </summary>
        private ArrayList _childAnimators = new ArrayList();
        /// <summary>
        /// The setting current value
        /// </summary>
        private bool _settingCurrentValue = false;
        /// <summary>
        /// The default step size
        /// </summary>
        public const double DEFAULT_STEP_SIZE = 2.0;
        /// <summary>
        /// The default intervall
        /// </summary>
        public const int DEFAULT_INTERVALL = 10;
        /// <summary>
        /// The default loop animation
        /// </summary>
        public const ZeroitSpecLoopMode DEFAULT_LOOP_ANIMATION = ZeroitSpecLoopMode.None;
        /// <summary>
        /// The default never ending timer
        /// </summary>
        private const bool DEFAULT_NEVER_ENDING_TIMER = false;
        /// <summary>
        /// The default synchronization mode
        /// </summary>
        private const ZeroitSpecSynchronizationMode DEFAULT_SYNCHRONIZATION_MODE = ZeroitSpecSynchronizationMode.None;
        /// <summary>
        /// The set property with parent animator error message
        /// </summary>
        private const string SET_PROP_WITH_PARENT_ANIMATOR_ERROR_MESSAGE = "Property cannot be set while ParentAnimator is set to anything other than null.";
        /// <summary>
        /// The timer
        /// </summary>
        private Timer _timer;
        /// <summary>
        /// The current step
        /// </summary>
        private double _currentStep;
        /// <summary>
        /// The parent animator
        /// </summary>
        private ZeroitSpecAnimatorBase _parentAnimator;
        /// <summary>
        /// The trigger animator
        /// </summary>
        private ZeroitSpecAnimatorBase _triggerAnimator;

        /// <summary>
        /// Occurs when [animation started].
        /// </summary>
        public event EventHandler AnimationStarted;

        /// <summary>
        /// Occurs when [animation stopped].
        /// </summary>
        public event EventHandler AnimationStopped;

        /// <summary>
        /// Occurs when [animation continued].
        /// </summary>
        public event EventHandler AnimationContinued;

        /// <summary>
        /// Occurs when [animation finished].
        /// </summary>
        public event EventHandler AnimationFinished;

        /// <summary>
        /// Occurs when [step size changed].
        /// </summary>
        public event EventHandler StepSizeChanged;

        /// <summary>
        /// Occurs when [intervall changed].
        /// </summary>
        public event EventHandler IntervallChanged;

        /// <summary>
        /// Occurs when [current step changed].
        /// </summary>
        public event EventHandler CurrentStepChanged;

        /// <summary>
        /// Occurs when [loop animation changed].
        /// </summary>
        public event EventHandler LoopAnimationChanged;

        /// <summary>
        /// Occurs when [start value changed].
        /// </summary>
        public event EventHandler StartValueChanged;

        /// <summary>
        /// Occurs when [end value changed].
        /// </summary>
        public event EventHandler EndValueChanged;

        /// <summary>
        /// Occurs when [synchronization mode changed].
        /// </summary>
        public event EventHandler SynchronizationModeChanged;

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitSpecAnimatorBase"/> class.
        /// </summary>
        /// <param name="container">The container.</param>
        public ZeroitSpecAnimatorBase(IContainer container)
    {
      container.Add((IComponent) this);
      this.InitializeComponent();
      this.Initialize();
    }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitSpecAnimatorBase"/> class.
        /// </summary>
        public ZeroitSpecAnimatorBase()
    {
      this.InitializeComponent();
      this.Initialize();
    }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        private void Initialize()
    {
      this._timer.Interval = 10;
    }

        /// <summary>
        /// Initializes the component.
        /// </summary>
        private void InitializeComponent()
    {
      this._timer = new Timer();
      this._timer.Tick += new EventHandler(this.OnTimerElapsed);
    }

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="T:System.ComponentModel.Component" /> and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
    {
      this.ParentAnimator = (ZeroitSpecAnimatorBase) null;
      this._childAnimators.Clear();
      this.TriggerAnimator = (ZeroitSpecAnimatorBase) null;
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

        /// <summary>
        /// Gets or sets the start value.
        /// </summary>
        /// <value>The start value.</value>
        [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public abstract object StartValue { get; set; }

        /// <summary>
        /// Gets or sets the end value.
        /// </summary>
        /// <value>The end value.</value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public abstract object EndValue { get; set; }

        /// <summary>
        /// Gets or sets the current value.
        /// </summary>
        /// <value>The current value.</value>
        /// <exception cref="System.InvalidOperationException"></exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public object CurrentValue
    {
      get
      {
        return this.CurrentValueInternal;
      }
      set
      {
        if (this._settingCurrentValue)
          throw new InvalidOperationException();
        try
        {
          this._settingCurrentValue = true;
          this.CurrentValueInternal = value;
        }
        finally
        {
          this._settingCurrentValue = false;
        }
      }
    }

        /// <summary>
        /// Gets or sets the trigger animator.
        /// </summary>
        /// <value>The trigger animator.</value>
        /// <exception cref="System.InvalidOperationException">Cannot set itself as TriggerAnimator.</exception>
        [Description("Gets or sets the ZeroitSpecAnimatorBase which should trigger the animation of this instance when it has finished animating.")]
    [Category("Behavior")]
    [Browsable(true)]
    [DefaultValue(null)]
    public ZeroitSpecAnimatorBase TriggerAnimator
    {
      get
      {
        return this._triggerAnimator;
      }
      set
      {
        if (this._triggerAnimator == value)
          return;
        if (this._triggerAnimator == this)
          throw new InvalidOperationException("Cannot set itself as TriggerAnimator.");
        if (this._triggerAnimator != null)
          this._triggerAnimator.AnimationFinished -= new EventHandler(this.OnTriggerAnimatorAnimationFinished);
        this._triggerAnimator = value;
        if (this._triggerAnimator == null)
          return;
        this._triggerAnimator.AnimationFinished += new EventHandler(this.OnTriggerAnimatorAnimationFinished);
      }
    }

        /// <summary>
        /// Gets or sets the parent animator.
        /// </summary>
        /// <value>The parent animator.</value>
        /// <exception cref="System.InvalidOperationException">Cannot set itself as ParentAnimator.</exception>
        [RefreshProperties(RefreshProperties.Repaint)]
    [Browsable(true)]
    [DefaultValue(null)]
    [Category("Behavior")]
    public ZeroitSpecAnimatorBase ParentAnimator
    {
      get
      {
        return this._parentAnimator;
      }
      set
      {
        if (this._parentAnimator == value)
          return;
        if (this._parentAnimator == this)
          throw new InvalidOperationException("Cannot set itself as ParentAnimator.");
        if (this._parentAnimator != null)
          this._parentAnimator.RemoveChildAnimator(this);
        this._parentAnimator = value;
        if (this._parentAnimator == null)
          return;
        this._parentAnimator.AddChildAnimator(this);
      }
    }

        /// <summary>
        /// Gets or sets the zeroit spec synchronization mode.
        /// </summary>
        /// <value>The zeroit spec synchronization mode.</value>
        [Description("Gets or sets the mode of design time synchronization.")]
    [Browsable(true)]
    [Category("Design")]
    [RefreshProperties(RefreshProperties.Repaint)]
    public ZeroitSpecSynchronizationMode ZeroitSpecSynchronizationMode
    {
      get
      {
        return this._syncMode;
      }
      set
      {
        this.SetSynchronizationMode(value, true);
      }
    }

        /// <summary>
        /// Gets or sets the intervall.
        /// </summary>
        /// <value>The intervall.</value>
        [DefaultValue(10)]
    [Description("Gets or sets the intervall (in milliseconds) between updates to the animation.")]
    [Category("Behavior")]
    [Browsable(true)]
    public int Intervall
    {
      get
      {
        return this._timer.Interval;
      }
      set
      {
        this.SetIntervall(value, true);
      }
    }

        /// <summary>
        /// Gets or sets the size of the step.
        /// </summary>
        /// <value>The size of the step.</value>
        [Description("Gets or sets the size of each step (in %) when updating the animation.")]
    [DefaultValue(2.0)]
    [Browsable(true)]
    [Category("Behavior")]
    public double StepSize
    {
      get
      {
        return this._stepSize;
      }
      set
      {
        this.SetStepSize(value, true);
      }
    }

        /// <summary>
        /// Gets or sets the zeroit spec loop mode.
        /// </summary>
        /// <value>The zeroit spec loop mode.</value>
        [DefaultValue(ZeroitSpecLoopMode.None)]
    [Category("Behavior")]
    [Description("Gets or sets whether the animation should loop between StartValue and EndValue until Stop() is called.")]
    [Browsable(true)]
    public ZeroitSpecLoopMode ZeroitSpecLoopMode
    {
      get
      {
        return this._loopMode;
      }
      set
      {
        this.SetLoopMode(value, true);
      }
    }

        /// <summary>
        /// Gets or sets the current step.
        /// </summary>
        /// <value>The current step.</value>
        [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public double CurrentStep
    {
      get
      {
        return this._currentStep;
      }
      set
      {
        if (this._currentStep == value)
          return;
        this._currentStep = value;
        if (this._currentStep > 100.0)
          this._currentStep = 100.0;
        else if (this._currentStep < 0.0)
          this._currentStep = 0.0;
        this.CurrentValue = this.GetValueForStep(this._currentStep);
        foreach (ZeroitSpecAnimatorBase childAnimator in this._childAnimators)
          childAnimator.CurrentStep = this._currentStep;
        this.OnCurrentStepChanged(EventArgs.Empty);
      }
    }

        /// <summary>
        /// Gets a value indicating whether this instance is running.
        /// </summary>
        /// <value><c>true</c> if this instance is running; otherwise, <c>false</c>.</value>
        [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsRunning
    {
      get
      {
        if (this._parentAnimator != null)
          return this._parentAnimator.IsRunning;
        return this._timer.Enabled;
      }
    }

        /// <summary>
        /// Gets or sets a value indicating whether [never ending timer].
        /// </summary>
        /// <value><c>true</c> if [never ending timer]; otherwise, <c>false</c>.</value>
        [Description("Gets or sets whether the internal timer should always continue running even if the animation has reached its end")]
    [DefaultValue(false)]
    [Category("Behavior")]
    [Browsable(true)]
    public bool NeverEndingTimer
    {
      get
      {
        return this._neverEndingTimer;
      }
      set
      {
        this._neverEndingTimer = value;
      }
    }

        /// <summary>
        /// Continues this instance.
        /// </summary>
        public void Continue()
    {
      this._timer.Start();
      this.OnAnimationContinued(EventArgs.Empty);
    }

        /// <summary>
        /// Starts the specified end value.
        /// </summary>
        /// <param name="endValue">The end value.</param>
        /// <exception cref="System.InvalidOperationException">Function cannot be called when ChildAnimators are set.</exception>
        public void Start(object endValue)
    {
      if (this._childAnimators.Count > 0)
        throw new InvalidOperationException("Function cannot be called when ChildAnimators are set.");
      this.EndValue = endValue;
      this.Start(true);
    }

        /// <summary>
        /// Starts this instance.
        /// </summary>
        public void Start()
    {
      this.Start(true);
    }

        /// <summary>
        /// Starts the specified set start values to current values.
        /// </summary>
        /// <param name="setStartValuesToCurrentValues">if set to <c>true</c> [set start values to current values].</param>
        public void Start(bool setStartValuesToCurrentValues)
    {
      if (setStartValuesToCurrentValues)
        this.SetStartValuesToCurrentValue();
      this.CurrentStep = 0.0;
      if (!this._timer.Enabled)
        this._timer.Start();
      this.OnAnimationStarted(EventArgs.Empty);
    }

        /// <summary>
        /// Sets the current values to start values.
        /// </summary>
        public void SetCurrentValuesToStartValues()
    {
      this.CurrentValue = this.StartValue;
      foreach (ZeroitSpecAnimatorBase childAnimator in this._childAnimators)
        childAnimator.SetCurrentValuesToStartValues();
    }

        /// <summary>
        /// Sets the start values to current value.
        /// </summary>
        public void SetStartValuesToCurrentValue()
    {
      this.StartValue = this.CurrentValue;
      foreach (ZeroitSpecAnimatorBase childAnimator in this._childAnimators)
        childAnimator.SetStartValuesToCurrentValue();
    }

        /// <summary>
        /// Switches the start end values.
        /// </summary>
        public void SwitchStartEndValues()
    {
      object startValue = this.StartValue;
      this.StartValue = this.EndValue;
      this.EndValue = startValue;
      foreach (ZeroitSpecAnimatorBase childAnimator in this._childAnimators)
        childAnimator.SwitchStartEndValues();
    }

        /// <summary>
        /// Stops this instance.
        /// </summary>
        public void Stop()
    {
      if (!this._timer.Enabled)
        return;
      this._timer.Stop();
      this.OnAnimationStopped(EventArgs.Empty);
    }

        /// <summary>
        /// Synchronizes to source.
        /// </summary>
        protected void SynchronizeToSource()
    {
      if (!this.DesignMode)
        return;
      switch (this._syncMode)
      {
        case ZeroitSpecSynchronizationMode.Start:
          this.CurrentValue = this.StartValue;
          break;
        case ZeroitSpecSynchronizationMode.End:
          this.CurrentValue = this.EndValue;
          break;
      }
    }

        /// <summary>
        /// Synchronizes from source.
        /// </summary>
        protected void SynchronizeFromSource()
    {
      if (!this.DesignMode)
        return;
      switch (this._syncMode)
      {
        case ZeroitSpecSynchronizationMode.Start:
          this.StartValue = this.CurrentValue;
          break;
        case ZeroitSpecSynchronizationMode.End:
          this.EndValue = this.CurrentValue;
          break;
      }
    }

        /// <summary>
        /// Resets the values.
        /// </summary>
        protected void ResetValues()
    {
      if (this._isInitializing)
        return;
      this.StartValue = this.CurrentValue;
      this.EndValue = this.CurrentValue;
    }

        /// <summary>
        /// Handles the <see cref="E:AnimationStarted" /> event.
        /// </summary>
        /// <param name="eventArgs">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnAnimationStarted(EventArgs eventArgs)
    {
      if (this.AnimationStarted == null)
        return;
      this.AnimationStarted((object) this, eventArgs);
    }

        /// <summary>
        /// Handles the <see cref="E:AnimationContinued" /> event.
        /// </summary>
        /// <param name="eventArgs">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnAnimationContinued(EventArgs eventArgs)
    {
      if (this.AnimationContinued == null)
        return;
      this.AnimationContinued((object) this, eventArgs);
    }

        /// <summary>
        /// Handles the <see cref="E:AnimationStopped" /> event.
        /// </summary>
        /// <param name="eventArgs">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnAnimationStopped(EventArgs eventArgs)
    {
      if (this.AnimationStopped == null)
        return;
      this.AnimationStopped((object) this, eventArgs);
    }

        /// <summary>
        /// Handles the <see cref="E:AnimationFinished" /> event.
        /// </summary>
        /// <param name="eventArgs">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnAnimationFinished(EventArgs eventArgs)
    {
      if (this.AnimationFinished == null)
        return;
      this.AnimationFinished((object) this, eventArgs);
    }

        /// <summary>
        /// Handles the <see cref="E:LoopAnimationChanged" /> event.
        /// </summary>
        /// <param name="eventArgs">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnLoopAnimationChanged(EventArgs eventArgs)
    {
      if (this.LoopAnimationChanged == null)
        return;
      this.LoopAnimationChanged((object) this, eventArgs);
    }

        /// <summary>
        /// Handles the <see cref="E:StepSizeChanged" /> event.
        /// </summary>
        /// <param name="eventArgs">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnStepSizeChanged(EventArgs eventArgs)
    {
      if (this.StepSizeChanged == null)
        return;
      this.StepSizeChanged((object) this, eventArgs);
    }

        /// <summary>
        /// Handles the <see cref="E:IntervallChanged" /> event.
        /// </summary>
        /// <param name="eventArgs">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnIntervallChanged(EventArgs eventArgs)
    {
      if (this.IntervallChanged == null)
        return;
      this.IntervallChanged((object) this, eventArgs);
    }

        /// <summary>
        /// Handles the <see cref="E:SynchronizationModeChanged" /> event.
        /// </summary>
        /// <param name="eventArgs">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void OnSynchronizationModeChanged(EventArgs eventArgs)
    {
      if (this.SynchronizationModeChanged == null)
        return;
      this.SynchronizationModeChanged((object) this, eventArgs);
    }

        /// <summary>
        /// Handles the <see cref="E:CurrentStepChanged" /> event.
        /// </summary>
        /// <param name="eventArgs">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnCurrentStepChanged(EventArgs eventArgs)
    {
      if (this.CurrentStepChanged == null)
        return;
      this.CurrentStepChanged((object) this, eventArgs);
    }

        /// <summary>
        /// Handles the <see cref="E:StartValueChanged" /> event.
        /// </summary>
        /// <param name="eventArgs">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnStartValueChanged(EventArgs eventArgs)
    {
      if (this._syncMode == ZeroitSpecSynchronizationMode.Start)
        this.CurrentValue = this.StartValue;
      if (this.StartValueChanged == null)
        return;
      this.StartValueChanged((object) this, eventArgs);
    }

        /// <summary>
        /// Handles the <see cref="E:EndValueChanged" /> event.
        /// </summary>
        /// <param name="eventArgs">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnEndValueChanged(EventArgs eventArgs)
    {
      if (this._syncMode == ZeroitSpecSynchronizationMode.End)
        this.CurrentValue = this.EndValue;
      if (this.EndValueChanged == null)
        return;
      this.EndValueChanged((object) this, eventArgs);
    }

        /// <summary>
        /// Gets or sets the current value internal.
        /// </summary>
        /// <value>The current value internal.</value>
        protected abstract object CurrentValueInternal { get; set; }

        /// <summary>
        /// Gets a value indicating whether [setting current value].
        /// </summary>
        /// <value><c>true</c> if [setting current value]; otherwise, <c>false</c>.</value>
        protected bool SettingCurrentValue
    {
      get
      {
        return this._settingCurrentValue;
      }
    }

        /// <summary>
        /// Gets the value for step.
        /// </summary>
        /// <param name="step">The step.</param>
        /// <returns>System.Object.</returns>
        protected abstract object GetValueForStep(double step);

        /// <summary>
        /// Adds the child animator.
        /// </summary>
        /// <param name="animator">The animator.</param>
        /// <exception cref="System.ArgumentNullException">animator</exception>
        protected void AddChildAnimator(ZeroitSpecAnimatorBase animator)
    {
      if (animator == null)
        throw new ArgumentNullException(nameof (animator));
      if (!this._childAnimators.Contains((object) animator))
        this._childAnimators.Add((object) animator);
      animator.SetIntervall(this.Intervall, false);
      animator.SetStepSize(this.StepSize, false);
      animator.SetLoopMode(this.ZeroitSpecLoopMode, false);
      animator.SetSynchronizationMode(this.ZeroitSpecSynchronizationMode, false);
    }

        /// <summary>
        /// Removes the child animator.
        /// </summary>
        /// <param name="animator">The animator.</param>
        /// <exception cref="System.ArgumentNullException">animator</exception>
        protected void RemoveChildAnimator(ZeroitSpecAnimatorBase animator)
    {
      if (animator == null)
        throw new ArgumentNullException(nameof (animator));
      if (!this._childAnimators.Contains((object) animator))
        return;
      this._childAnimators.Remove((object) animator);
    }

        /// <summary>
        /// Gets a value indicating whether this instance is initializing.
        /// </summary>
        /// <value><c>true</c> if this instance is initializing; otherwise, <c>false</c>.</value>
        protected bool IsInitializing
    {
      get
      {
        return this._isInitializing;
      }
    }

        /// <summary>
        /// Shoulds the serialize synchronization mode.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        protected virtual bool ShouldSerializeSynchronizationMode()
    {
      return false;
    }

        /// <summary>
        /// Handles the <see cref="E:CurrentValueChanged" /> event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnCurrentValueChanged(object sender, EventArgs e)
    {
      if (this.SettingCurrentValue)
        return;
      this.SynchronizeFromSource();
    }

        /// <summary>
        /// Sets the synchronization mode.
        /// </summary>
        /// <param name="ZeroitSpecSynchronizationMode">The zeroit spec synchronization mode.</param>
        /// <param name="checkParentAnimator">if set to <c>true</c> [check parent animator].</param>
        /// <exception cref="System.InvalidOperationException">Property cannot be set while ParentAnimator is set to anything other than null.</exception>
        private void SetSynchronizationMode(ZeroitSpecSynchronizationMode ZeroitSpecSynchronizationMode, bool checkParentAnimator)
    {
      if (this._syncMode == ZeroitSpecSynchronizationMode)
        return;
      if (ZeroitSpecSynchronizationMode == ZeroitSpecSynchronizationMode.ResetToCurrent)
      {
        if (!this.DesignMode)
          return;
        this.ResetValues();
      }
      else
      {
        if (this._parentAnimator != null && checkParentAnimator && !this._isInitializing)
          throw new InvalidOperationException("Property cannot be set while ParentAnimator is set to anything other than null.");
        this._syncMode = ZeroitSpecSynchronizationMode;
        this.SynchronizeToSource();
        foreach (ZeroitSpecAnimatorBase childAnimator in this._childAnimators)
          childAnimator.SetSynchronizationMode(ZeroitSpecSynchronizationMode, false);
        this.OnSynchronizationModeChanged(EventArgs.Empty);
      }
    }

        /// <summary>
        /// Sets the intervall.
        /// </summary>
        /// <param name="intervall">The intervall.</param>
        /// <param name="checkParentAnimator">if set to <c>true</c> [check parent animator].</param>
        /// <exception cref="System.InvalidOperationException">Property cannot be set while ParentAnimator is set to anything other than null.</exception>
        private void SetIntervall(int intervall, bool checkParentAnimator)
    {
      if (this._timer.Interval == intervall)
        return;
      if (this._parentAnimator != null && checkParentAnimator && !this._isInitializing)
        throw new InvalidOperationException("Property cannot be set while ParentAnimator is set to anything other than null.");
      this._timer.Interval = intervall;
      foreach (ZeroitSpecAnimatorBase childAnimator in this._childAnimators)
        childAnimator.SetIntervall(intervall, false);
      this.OnIntervallChanged(EventArgs.Empty);
    }

        /// <summary>
        /// Sets the size of the step.
        /// </summary>
        /// <param name="stepSize">Size of the step.</param>
        /// <param name="checkParentAnimator">if set to <c>true</c> [check parent animator].</param>
        /// <exception cref="System.InvalidOperationException">Property cannot be set while ParentAnimator is set to anything other than null.</exception>
        private void SetStepSize(double stepSize, bool checkParentAnimator)
    {
      if (this._stepSize == stepSize)
        return;
      if (this._parentAnimator != null && checkParentAnimator && !this._isInitializing)
        throw new InvalidOperationException("Property cannot be set while ParentAnimator is set to anything other than null.");
      this._stepSize = stepSize;
      foreach (ZeroitSpecAnimatorBase childAnimator in this._childAnimators)
        childAnimator.SetStepSize(stepSize, false);
      this.OnStepSizeChanged(EventArgs.Empty);
    }

        /// <summary>
        /// Sets the loop mode.
        /// </summary>
        /// <param name="loopAnimation">The loop animation.</param>
        /// <param name="checkParentAnimator">if set to <c>true</c> [check parent animator].</param>
        /// <exception cref="System.InvalidOperationException">Property cannot be set while ParentAnimator is set to anything other than null.</exception>
        private void SetLoopMode(ZeroitSpecLoopMode loopAnimation, bool checkParentAnimator)
    {
      if (this._loopMode == loopAnimation)
        return;
      if (this._parentAnimator != null && checkParentAnimator && !this._isInitializing)
        throw new InvalidOperationException("Property cannot be set while ParentAnimator is set to anything other than null.");
      this._loopMode = loopAnimation;
      foreach (ZeroitSpecAnimatorBase childAnimator in this._childAnimators)
        childAnimator.SetLoopMode(loopAnimation, false);
      this.OnLoopAnimationChanged(EventArgs.Empty);
    }

        /// <summary>
        /// Handles the <see cref="E:TimerElapsed" /> event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnTimerElapsed(object sender, EventArgs e)
    {
      this.CurrentStep += this._stepSize;
      if (this.CurrentStep < 100.0)
        return;
      bool enabled = this._timer.Enabled;
      if (this._timer.Enabled && !this._neverEndingTimer && this._loopMode == ZeroitSpecLoopMode.None)
        this._timer.Stop();
      this.OnAnimationFinished(EventArgs.Empty);
      if (!enabled)
        return;
      if (this._loopMode == ZeroitSpecLoopMode.Repeat)
      {
        this.CurrentStep -= 100.0;
      }
      else
      {
        if (this._loopMode != ZeroitSpecLoopMode.Bidirectional)
          return;
        this.SwitchStartEndValues();
        this.Start();
      }
    }

        /// <summary>
        /// Handles the <see cref="E:TriggerAnimatorAnimationFinished" /> event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnTriggerAnimatorAnimationFinished(object sender, EventArgs e)
    {
      this.Start();
    }

        /// <summary>
        /// Interpolates the colors.
        /// </summary>
        /// <param name="color1">The color1.</param>
        /// <param name="color2">The color2.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Color.</returns>
        public static Color InterpolateColors(Color color1, Color color2, double percent)
    {
      return Color.FromArgb(ZeroitSpecAnimatorBase.InterpolateIntegerValues((int) color1.A, (int) color2.A, percent), ZeroitSpecAnimatorBase.InterpolateIntegerValues((int) color1.R, (int) color2.R, percent), ZeroitSpecAnimatorBase.InterpolateIntegerValues((int) color1.G, (int) color2.G, percent), ZeroitSpecAnimatorBase.InterpolateIntegerValues((int) color1.B, (int) color2.B, percent));
    }

        /// <summary>
        /// Interpolates the rectangles.
        /// </summary>
        /// <param name="rectangle1">The rectangle1.</param>
        /// <param name="rectangle2">The rectangle2.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Rectangle.</returns>
        public static Rectangle InterpolateRectangles(Rectangle rectangle1, Rectangle rectangle2, double percent)
    {
      return new Rectangle(ZeroitSpecAnimatorBase.InterpolatePoints(rectangle1.Location, rectangle2.Location, percent), ZeroitSpecAnimatorBase.InterpolateSizes(rectangle1.Size, rectangle2.Size, percent));
    }

        /// <summary>
        /// Interpolates the points.
        /// </summary>
        /// <param name="point1">The point1.</param>
        /// <param name="point2">The point2.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Point.</returns>
        public static Point InterpolatePoints(Point point1, Point point2, double percent)
    {
      return new Point(ZeroitSpecAnimatorBase.InterpolateIntegerValues(point1.X, point2.X, percent), ZeroitSpecAnimatorBase.InterpolateIntegerValues(point1.Y, point2.Y, percent));
    }

        /// <summary>
        /// Interpolates the sizes.
        /// </summary>
        /// <param name="size1">The size1.</param>
        /// <param name="size2">The size2.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Size.</returns>
        public static Size InterpolateSizes(Size size1, Size size2, double percent)
    {
      return new Size(ZeroitSpecAnimatorBase.InterpolateIntegerValues(size1.Width, size2.Width, percent), ZeroitSpecAnimatorBase.InterpolateIntegerValues(size1.Height, size2.Height, percent));
    }

        /// <summary>
        /// Interpolates the double values.
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>System.Double.</returns>
        /// <exception cref="System.ArgumentException">Value must be between 0 and 100. - percent</exception>
        public static double InterpolateDoubleValues(double value1, double value2, double percent)
    {
      if (percent < 0.0 || percent > 100.0)
        throw new ArgumentException("Value must be between 0 and 100.", nameof (percent));
      return percent * (value2 - value1) / 100.0 + value1;
    }

        /// <summary>
        /// Interpolates the integer values.
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="System.ArgumentException">Value must be between 0 and 100. - percent</exception>
        public static int InterpolateIntegerValues(int value1, int value2, double percent)
    {
      if (percent < 0.0 || percent > 100.0)
        throw new ArgumentException("Value must be between 0 and 100.", nameof (percent));
      return Convert.ToInt32(percent * (double) (value2 - value1) / 100.0 + (double) value1);
    }

        /// <summary>
        /// Signals the object that initialization is starting.
        /// </summary>
        public void BeginInit()
    {
      this._isInitializing = true;
    }

        /// <summary>
        /// Signals the object that initialization is complete.
        /// </summary>
        public void EndInit()
    {
      this._isInitializing = false;
    }
  }
}
