// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Animator.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Threading;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.Transitions
{
    #region Animator

    /// <summary>
    /// A class collection for providing animation functionality.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    /// <seealso cref="System.ComponentModel.IExtenderProvider" />
    [ProvideProperty("Decoration", typeof(Control))]
    public class ZeroitAnimator : Component, IExtenderProvider
    {
        /// <summary>
        /// The components
        /// </summary>
        IContainer components = null;
        /// <summary>
        /// The queue
        /// </summary>
        protected List<QueueItem> queue = new List<QueueItem>();
        /// <summary>
        /// The thread
        /// </summary>
        private Thread thread;
        /// <summary>
        /// The timer
        /// </summary>
        System.Windows.Forms.Timer timer;

        /// <summary>
        /// Occurs when animation of the control is completed
        /// </summary>
        public event EventHandler<AnimationCompletedEventArg> AnimationCompleted;
        /// <summary>
        /// Ocuurs when all animations are completed
        /// </summary>
        public event EventHandler AllAnimationsCompleted;
        /// <summary>
        /// Occurs when needed transform matrix
        /// </summary>
        public event EventHandler<TransfromNeededEventArg> TransfromNeeded;
        /// <summary>
        /// Occurs when needed non-linear transformation
        /// </summary>
        public event EventHandler<NonLinearTransfromNeededEventArg> NonLinearTransfromNeeded;
        /// <summary>
        /// Occurs when user click on the animated control
        /// </summary>
        public event EventHandler<MouseEventArgs> MouseDown;
        /// <summary>
        /// Occurs when frame of animation is painting
        /// </summary>
        public event EventHandler<PaintEventArgs> FramePainted;

        /// <summary>
        /// Max time of animation (ms)
        /// </summary>
        /// <value>The maximum animation time.</value>
        [DefaultValue(1500)]
        public int MaxAnimationTime { get; set; }

        /// <summary>
        /// Default animation
        /// </summary>
        /// <value>The default animation.</value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public ZeroitAnimate_Animation DefaultAnimation { get; set; }

        /// <summary>
        /// Cursor of animated control
        /// </summary>
        /// <value>The cursor.</value>
        [DefaultValue(typeof(Cursor), "Default")]
        public Cursor Cursor { get; set; }

        /// <summary>
        /// Are all animations completed?
        /// </summary>
        /// <value><c>true</c> if this instance is completed; otherwise, <c>false</c>.</value>
        public bool IsCompleted
        {
            get { lock (queue) return queue.Count == 0; }
        }

        /// <summary>
        /// Interval between frames (ms)
        /// </summary>
        /// <value>The interval.</value>
        [DefaultValue(10)]
        public int Interval
        {
            get;
            set;
        }

        /// <summary>
        /// The animation type
        /// </summary>
        AnimationType animationType;
        /// <summary>
        /// Type of built-in animation
        /// </summary>
        /// <value>The type of the animation.</value>
        public AnimationType AnimationType
        {
            get { return animationType; }
            set { animationType = value;
                InitDefaultAnimation(animationType); }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitAnimator" /> class.
        /// </summary>
        public ZeroitAnimator()
        {
            Init();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitAnimator" /> class.
        /// </summary>
        /// <param name="container">The container.</param>
        public ZeroitAnimator(IContainer container)
        {
            container.Add(this);
            Init();
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        protected virtual void Init()
        {
            AnimationType = Zeroit.Framework.Transitions.AnimationType.VertSlide;
            DefaultAnimation = new ZeroitAnimate_Animation();
            MaxAnimationTime = 1500;
            TimeStep = 0.02f;
            Interval = 10;
            _width = 200;
            _height = 200;

            Disposed += new EventHandler(Animator_Disposed);

            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1;
            timer.Start();

        }


        /// <summary>
        /// Starts this instance.
        /// </summary>
        private void Start()
        {
            //main working thread
            thread = new Thread(Work);
            thread.IsBackground = true;
            thread.Name = "Animator thread";
            thread.Start();
        }

        /// <summary>
        /// The invoker control
        /// </summary>
        Control invokerControl;

        /// <summary>
        /// Handles the Tick event of the timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            //create invoker in main UI therad
            invokerControl = new Control();
            invokerControl.CreateControl();
            //
            Start();
        }

        /// <summary>
        /// Handles the Disposed event of the Animator control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        void Animator_Disposed(object sender, EventArgs e)
        {
            ClearQueue();
            if (thread != null)
                thread.Abort();
        }

        /// <summary>
        /// Works this instance.
        /// </summary>
        void Work()
        {
            while (true)
            {
                Thread.Sleep(Interval);
                try
                {
                    var count = 0;
                    var completed = new List<QueueItem>();
                    var actived = new List<QueueItem>();

                    //find completed
                    lock (queue)
                    {
                        count = queue.Count;
                        var wasActive = false;

                        foreach (var item in queue)
                        {
                            if (item.IsActive) wasActive = true;

                            if (item.controller != null && item.controller.IsCompleted)
                                completed.Add(item);
                            else
                            {
                                if (item.IsActive)
                                {
                                    if ((DateTime.Now - item.ActivateTime).TotalMilliseconds > MaxAnimationTime)
                                        completed.Add(item);
                                    else
                                        actived.Add(item);
                                }
                            }
                        }
                        //start next animation
                        if (!wasActive)
                            foreach (var item in queue)
                                if (!item.IsActive)
                                {
                                    actived.Add(item);
                                    item.IsActive = true;
                                    break;
                                }
                    }

                    //completed
                    foreach (var item in completed)
                        OnCompleted(item);

                    //build next frame of DoubleBitmap
                    foreach (var item in actived)
                        try
                        {
                            var item2 = item;
                            //build next frame of DoubleBitmap
                            //item.control.BeginInvoke(new MethodInvoker(() => DoAnimation(item2)));
                            invokerControl.BeginInvoke(new MethodInvoker(() => DoAnimation(item2)));
                        }
                        catch
                        {
                            //we can not start animation, remove from queue
                            OnCompleted(item);
                        }

                    if (count == 0)
                    {
                        if (completed.Count > 0)
                            OnAllAnimationsCompleted();
                        CheckRequests();
                    }
                }
                catch
                {
                    //form was closed
                }
            }
        }

        /// <summary>
        /// Check result state of controls
        /// </summary>
        private void CheckRequests()
        {
            var toRemove = new List<QueueItem>();

            lock (requests)
            {
                var dict = new Dictionary<Control, QueueItem>();
                foreach (var item in requests)
                    if (item.control != null)
                    {
                        if (dict.ContainsKey(item.control))
                            toRemove.Add(dict[item.control]);
                        dict[item.control] = item;
                    }
                    else
                        toRemove.Add(item);

                foreach (var item in dict.Values)
                {
                    if (item.control != null && !IsStateOK(item.control, item.mode))
                    {
                        if (invokerControl != null)
                            RepairState(item.control, item.mode);
                    }
                    else
                        toRemove.Add(item);
                }

                foreach (var item in toRemove)
                    requests.Remove(item);
            }
        }

        /// <summary>
        /// Determines whether [is state ok] [the specified control].
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="mode">The mode.</param>
        /// <returns><c>true</c> if [is state ok] [the specified control]; otherwise, <c>false</c>.</returns>
        bool IsStateOK(Control control, AnimateMode mode)
        {
            switch (mode)
            {
                case AnimateMode.Hide: return !control.Visible;
                case AnimateMode.Show: return control.Visible;
            }

            return true;
        }

        /// <summary>
        /// Repairs the state.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="mode">The mode.</param>
        void RepairState(Control control, AnimateMode mode)
        {
            invokerControl.Invoke(new MethodInvoker(() =>
            {
                try
                {
                    switch (mode)
                    {
                        case AnimateMode.Hide:
                            control.Visible = false;
                            break;
                        case AnimateMode.Show:
                            control.Visible = true;
                            break;
                    }
                }
                catch
                {
                    //form was closed
                }
            }));
        }

        /// <summary>
        /// The counter
        /// </summary>
        int counter;

        /// <summary>
        /// Does the animation.
        /// </summary>
        /// <param name="item">The item.</param>
        private void DoAnimation(QueueItem item)
        {
            lock (item)
            {
                try
                {
                    if (item.controller == null)
                    {
                        item.controller = CreateDoubleBitmap(item.control, item.mode, item.animation,
                            item.clipRectangle);
                    }
                    if (item.controller.IsCompleted)
                        return;
                    item.controller.BuildNextFrame();
                }
                catch
                {
                    if (item.controller != null)
                        item.controller.Dispose();
                    OnCompleted(item);
                }
            }
        }

        /// <summary>
        /// Initializes the default animation.
        /// </summary>
        /// <param name="animationType">Type of the animation.</param>
        private void InitDefaultAnimation(Zeroit.Framework.Transitions.AnimationType animationType)
        {
            switch (animationType)
            {
                case AnimationType.Custom: break;
                case AnimationType.Rotate: DefaultAnimation = ZeroitAnimate_Animation.Rotate; break;
                case AnimationType.HorizSlide: DefaultAnimation = ZeroitAnimate_Animation.HorizSlide; break;
                case AnimationType.VertSlide: DefaultAnimation = ZeroitAnimate_Animation.VertSlide; break;
                case AnimationType.Scale: DefaultAnimation = ZeroitAnimate_Animation.Scale; break;
                case AnimationType.ScaleAndRotate: DefaultAnimation = ZeroitAnimate_Animation.ScaleAndRotate; break;
                case AnimationType.HorizSlideAndRotate: DefaultAnimation = ZeroitAnimate_Animation.HorizSlideAndRotate; break;
                case AnimationType.ScaleAndHorizSlide: DefaultAnimation = ZeroitAnimate_Animation.ScaleAndHorizSlide; break;
                case AnimationType.Transparent: DefaultAnimation = ZeroitAnimate_Animation.Transparent; break;
                case AnimationType.Leaf: DefaultAnimation = ZeroitAnimate_Animation.Leaf; break;
                case AnimationType.Mosaic: DefaultAnimation = ZeroitAnimate_Animation.Mosaic; break;
                case AnimationType.Particles: DefaultAnimation = ZeroitAnimate_Animation.Particles; break;
                case AnimationType.VertBlind: DefaultAnimation = ZeroitAnimate_Animation.VertBlind; break;
                case AnimationType.HorizBlind: DefaultAnimation = ZeroitAnimate_Animation.HorizBlind; break;
            }
        }

        #region Zeroit Activation

        #region Variables
        /// <summary>
        /// The target
        /// </summary>
        private Control _target;
        /// <summary>
        /// The width
        /// </summary>
        private int _width;
        /// <summary>
        /// The height
        /// </summary>
        private int _height;
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the control to use for the animation.
        /// </summary>
        /// <value>The target.</value>
        public Control Target
        {
            get { return _target; }
            set
            {
                _target = value;
            }
        }

        /// <summary>
        /// Gets or sets the width of the control to use for animation.
        /// </summary>
        /// <value>The width of the target.</value>
        public int TargetWidth
        {
            get { return _width; }
            set
            {
                _width = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of the target to use for the animation.
        /// </summary>
        /// <value>The height of the target.</value>
        public int TargetHeight
        {
            get { return _height; }
            set
            {
                _height = value;
            }
        }

        #endregion

        /// <summary>
        /// Starts the animation.
        /// </summary>
        public void Activate()
        {
            _target.Visible = false;
            _target.Width = _width;
            _target.Height = _height;
            //_target.BackColor = Color.Transparent;
            //_target.Dock = DockStyle.None;
            //_target.Location = new System.Drawing.Point(200, 300);
            //_target.Margin = new Padding(100);
            //_target.MaximumSize = new Size(200, 200);
            //_target.MinimumSize = new Size(100,100);
            //_target.Size = new Size(_target.Width, _target.Height);

            switch (animationType)
            {
                case AnimationType.Custom:
                    this.ShowSync(_target);
                    break;
                case AnimationType.Rotate:
                    this.ShowSync(_target);
                    break;
                case AnimationType.HorizSlide:
                    this.ShowSync(_target);
                    break;
                case AnimationType.VertSlide:
                    this.ShowSync(_target);
                    break;
                case AnimationType.Scale:
                    this.ShowSync(_target);
                    break;
                case AnimationType.ScaleAndRotate:
                    this.ShowSync(_target);
                    break;
                case AnimationType.HorizSlideAndRotate:
                    this.ShowSync(_target);
                    break;
                case AnimationType.ScaleAndHorizSlide:
                    this.ShowSync(_target);
                    break;
                case AnimationType.Transparent:
                    this.ShowSync(_target);
                    break;
                case AnimationType.Leaf:
                    this.ShowSync(_target);
                    break;
                case AnimationType.Mosaic:
                    this.ShowSync(_target);
                    break;
                case AnimationType.Particles:
                    this.ShowSync(_target);
                    break;
                case AnimationType.VertBlind:
                    this.ShowSync(_target);
                    break;
                case AnimationType.HorizBlind:
                    this.ShowSync(_target);
                    break;
                default:
                    break;
            }

        }
        #endregion
        /// <summary>
        /// Time step
        /// </summary>
        /// <value>The time step.</value>
        [DefaultValue(0.02f)]
        public float TimeStep { get; set; }

        /// <summary>
        /// Shows the control. As result the control will be shown with animation.
        /// </summary>
        /// <param name="control">Target control</param>
        /// <param name="parallel">Allows to animate it same time as other animations</param>
        /// <param name="animation">Personal animation</param>
        public void Show(Control control, bool parallel = false, ZeroitAnimate_Animation animation = null)
        {
            AddToQueue(control, AnimateMode.Show, parallel, animation);
        }

        /// <summary>
        /// Shows the control and waits while animation will be completed. As result the control will be shown with animation.
        /// </summary>
        /// <param name="control">Target control</param>
        /// <param name="parallel">Allows to animate it same time as other animations</param>
        /// <param name="animation">Personal animation</param>
        public void ShowSync(Control control, bool parallel = false, ZeroitAnimate_Animation animation = null)
        {
            Show(control, parallel, animation);
            WaitAnimation(control);
        }

        /// <summary>
        /// Hides the control. As result the control will be hidden with animation.
        /// </summary>
        /// <param name="control">Target control</param>
        /// <param name="parallel">Allows to animate it same time as other animations</param>
        /// <param name="animation">Personal animation</param>
        public void Hide(Control control, bool parallel = false, ZeroitAnimate_Animation animation = null)
        {
            AddToQueue(control, AnimateMode.Hide, parallel, animation);
        }

        /// <summary>
        /// Hides the control and waits while animation will be completed. As result the control will be hidden with animation.
        /// </summary>
        /// <param name="control">Target control</param>
        /// <param name="parallel">Allows to animate it same time as other animations</param>
        /// <param name="animation">Personal animation</param>
        public void HideSync(Control control, bool parallel = false, ZeroitAnimate_Animation animation = null)
        {
            Hide(control, parallel, animation);
            WaitAnimation(control);
        }

        /// <summary>
        /// It makes snapshot of the control before updating. It requires EndUpdate calling.
        /// </summary>
        /// <param name="control">Target control</param>
        /// <param name="parallel">Allows to animate it same time as other animations</param>
        /// <param name="animation">Personal animation</param>
        /// <param name="clipRectangle">Clip rectangle for animation</param>
        public void BeginUpdate(Control control, bool parallel = false, ZeroitAnimate_Animation animation = null, Rectangle clipRectangle = default(Rectangle))
        {
            AddToQueue(control, AnimateMode.BeginUpdate, parallel, animation, clipRectangle);

            bool wait = false;
            do
            {
                wait = false;
                lock (queue)
                    foreach (var item in queue)
                        if (item.control == control && item.mode == AnimateMode.BeginUpdate)
                        {
                            if (item.controller == null)
                                wait = true;
                        }

                if (wait)
                    System.Windows.Forms.Application.DoEvents();

            } while (wait);
        }

        /// <summary>
        /// Upadates control view with animation. It requires to call BeginUpdate before.
        /// </summary>
        /// <param name="control">Target control</param>
        public void EndUpdate(Control control)
        {
            lock (queue)
            {
                foreach (var item in queue)
                    if (item.control == control && item.mode == AnimateMode.BeginUpdate)
                    {
                        item.controller.EndUpdate();
                        item.mode = AnimateMode.Update;
                    }
            }
        }

        /// <summary>
        /// Upadates control view with animation and waits while animation will be completed. It requires to call BeginUpdate before.
        /// </summary>
        /// <param name="control">Target control</param>
        public void EndUpdateSync(Control control)
        {
            EndUpdate(control);
            WaitAnimation(control);
        }

        /// <summary>
        /// Waits while all animations will completed.
        /// </summary>
        public void WaitAllAnimations()
        {
            while (!IsCompleted)
                System.Windows.Forms.Application.DoEvents();
        }

        /// <summary>
        /// Waits while animation of the control will completed.
        /// </summary>
        /// <param name="animatedControl">The animated control.</param>
        public void WaitAnimation(Control animatedControl)
        {
            while (true)
            {
                bool flag = false;
                lock (queue)
                    foreach (var item in queue)
                        if (item.control == animatedControl)
                        {
                            flag = true;
                            break;
                        }

                if (!flag)
                    return;

                System.Windows.Forms.Application.DoEvents();
            }
        }

        /// <summary>
        /// The requests
        /// </summary>
        List<QueueItem> requests = new List<QueueItem>();

        /// <summary>
        /// Called when [completed].
        /// </summary>
        /// <param name="item">The item.</param>
        void OnCompleted(QueueItem item)
        {
            if (item.controller != null)
            {
                item.controller.Dispose();
            }
            lock (queue)
                queue.Remove(item);

            OnAnimationCompleted(new AnimationCompletedEventArg { Animation = item.animation, Control = item.control, Mode = item.mode });
        }

        /// <summary>
        /// Adds the contol to animation queue.
        /// </summary>
        /// <param name="control">Target control</param>
        /// <param name="mode">Animation mode</param>
        /// <param name="parallel">Allows to animate it same time as other animations</param>
        /// <param name="animation">Personal animation</param>
        /// <param name="clipRectangle">The clip rectangle.</param>
        public void AddToQueue(Control control, AnimateMode mode, bool parallel = true, ZeroitAnimate_Animation animation = null, Rectangle clipRectangle = default(Rectangle))
        {
            if (animation == null)
                animation = DefaultAnimation;

            if (control is IFakeControl)
            {
                control.Visible = false;
                return;
            }

            var item = new QueueItem() { animation = animation, control = control, IsActive = parallel, mode = mode, clipRectangle = clipRectangle };

            //check visible state
            switch (mode)
            {
                case AnimateMode.Show:
                    if (control.Visible)//already showed
                    {
                        OnCompleted(new QueueItem { control = control, mode = mode });
                        return;
                    }
                    break;
                case AnimateMode.Hide:
                    if (!control.Visible)//already hidden
                    {
                        OnCompleted(new QueueItem { control = control, mode = mode });
                        return;
                    }
                    break;
            }

            //add to queue
            lock (queue)
                queue.Add(item);
            lock (requests)
                requests.Add(item);
        }

        /// <summary>
        /// Creates the double bitmap.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="mode">The mode.</param>
        /// <param name="animation">The animation.</param>
        /// <param name="clipRect">The clip rect.</param>
        /// <returns>Controller.</returns>
        private Controller CreateDoubleBitmap(Control control, AnimateMode mode, ZeroitAnimate_Animation animation, Rectangle clipRect)
        {
            var controller = new Controller(control, mode, animation, TimeStep, clipRect);
            controller.TransfromNeeded += OnTransformNeeded;
            if (NonLinearTransfromNeeded != null)
                controller.NonLinearTransfromNeeded += OnNonLinearTransfromNeeded;
            controller.MouseDown += OnMouseDown;
            controller.DoubleBitmap.Cursor = Cursor;
            controller.FramePainted += OnFramePainted;
            return controller;
        }

        /// <summary>
        /// Handles the <see cref="E:FramePainted" /> event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void OnFramePainted(object sender, PaintEventArgs e)
        {
            if (FramePainted != null)
                FramePainted(sender, e);
        }

        /// <summary>
        /// Handles the <see cref="E:MouseDown" /> event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        protected virtual void OnMouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                //transform point to animated control's coordinates 
                var db = (Controller)sender;
                var l = e.Location;
                l.Offset(db.DoubleBitmap.Left - db.AnimatedControl.Left, db.DoubleBitmap.Top - db.AnimatedControl.Top);
                //
                if (MouseDown != null)
                    MouseDown(sender, new MouseEventArgs(e.Button, e.Clicks, l.X, l.Y, e.Delta));
            }
            catch
            {
            }
        }

        /// <summary>
        /// Called when [non linear transfrom needed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        protected virtual void OnNonLinearTransfromNeeded(object sender, NonLinearTransfromNeededEventArg e)
        {
            if (NonLinearTransfromNeeded != null)
                NonLinearTransfromNeeded(this, e);
            else
                e.UseDefaultTransform = true;
        }

        /// <summary>
        /// Called when [transform needed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        protected virtual void OnTransformNeeded(object sender, TransfromNeededEventArg e)
        {
            if (TransfromNeeded != null)
                TransfromNeeded(this, e);
            else
                e.UseDefaultMatrix = true;
        }

        /// <summary>
        /// Clears queue.
        /// </summary>
        public void ClearQueue()
        {
            List<QueueItem> items = null;
            lock (queue)
            {
                items = new List<QueueItem>(queue);
                queue.Clear();
            }


            foreach (var item in items)
            {
                if (item.control != null)
                    item.control.BeginInvoke(new MethodInvoker(() =>
                    {
                        switch (item.mode)
                        {
                            case AnimateMode.Hide: item.control.Visible = false; break;
                            case AnimateMode.Show: item.control.Visible = true; break;
                        }
                    }));
                OnAnimationCompleted(new AnimationCompletedEventArg { Animation = item.animation, Control = item.control, Mode = item.mode });
            }

            if (items.Count > 0)
                OnAllAnimationsCompleted();
        }

        /// <summary>
        /// Called when [animation completed].
        /// </summary>
        /// <param name="e">The e.</param>
        protected virtual void OnAnimationCompleted(AnimationCompletedEventArg e)
        {
            if (AnimationCompleted != null)
                AnimationCompleted(this, e);
        }

        /// <summary>
        /// Called when [all animations completed].
        /// </summary>
        protected virtual void OnAllAnimationsCompleted()
        {
            if (AllAnimationsCompleted != null)
                AllAnimationsCompleted(this, EventArgs.Empty);
        }

        #region Nested type: QueueItem

        /// <summary>
        /// Class QueueItem.
        /// </summary>
        protected class QueueItem
        {
            /// <summary>
            /// The animation
            /// </summary>
            public ZeroitAnimate_Animation animation;
            /// <summary>
            /// The controller
            /// </summary>
            public Controller controller;
            /// <summary>
            /// The control
            /// </summary>
            public Control control;
            /// <summary>
            /// Gets the activate time.
            /// </summary>
            /// <value>The activate time.</value>
            public DateTime ActivateTime { get; private set; }
            /// <summary>
            /// The mode
            /// </summary>
            public AnimateMode mode;
            /// <summary>
            /// The clip rectangle
            /// </summary>
            public Rectangle clipRectangle;

            /// <summary>
            /// The is active
            /// </summary>
            public bool isActive;
            /// <summary>
            /// Gets or sets a value indicating whether this instance is active.
            /// </summary>
            /// <value><c>true</c> if this instance is active; otherwise, <c>false</c>.</value>
            public bool IsActive
            {
                get { return isActive; }
                set
                {
                    if (isActive == value) return;
                    isActive = value;
                    if (value)
                        ActivateTime = DateTime.Now;
                }
            }

            /// <summary>
            /// Returns a <see cref="System.String" /> that represents this instance.
            /// </summary>
            /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                if (control != null)
                    sb.Append(control.GetType().Name + " ");
                sb.Append(mode);
                return sb.ToString();
            }
        }

        #endregion

        #region IExtenderProvider

        /// <summary>
        /// Gets the decoration.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>DecorationType.</returns>
        public DecorationType GetDecoration(Control control)
        {
            if (DecorationByControls.ContainsKey(control))
                return DecorationByControls[control].DecorationType;
            else
                return DecorationType.None;
        }

        /// <summary>
        /// Sets the decoration.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="decoration">The decoration.</param>
        public void SetDecoration(Control control, DecorationType decoration)
        {
            var wrapper = DecorationByControls.ContainsKey(control) ? DecorationByControls[control] : null;
            if (decoration == DecorationType.None)
            {
                if (wrapper != null)
                    wrapper.Dispose();
                DecorationByControls.Remove(control);
            }
            else
            {
                if (wrapper == null)
                    wrapper = new DecorationControl(decoration, control);
                wrapper.DecorationType = decoration;
                DecorationByControls[control] = wrapper;
            }
        }

        /// <summary>
        /// The decoration by controls
        /// </summary>
        private readonly Dictionary<Control, DecorationControl> DecorationByControls = new Dictionary<Control, DecorationControl>();

        /// <summary>
        /// Specifies whether this object can provide its extender properties to the specified object.
        /// </summary>
        /// <param name="extendee">The <see cref="T:System.Object" /> to receive the extender properties.</param>
        /// <returns>true if this object can provide extender properties to the specified object; otherwise, false.</returns>
        public bool CanExtend(object extendee)
        {
            return extendee is Control;
        }

        #endregion
    }

    /// <summary>
    /// Sets the type of decoration for <c><see cref="ZeroitAnimator" /></c> animator.
    /// </summary>
    public enum DecorationType
    {
        /// <summary>
        /// The none
        /// </summary>
        None,
        /// <summary>
        /// The bottom mirror
        /// </summary>
        BottomMirror,
        /// <summary>
        /// The custom
        /// </summary>
        Custom
    }

    /// <summary>
    /// Class AnimationCompletedEventArg.
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public class AnimationCompletedEventArg : EventArgs
    {
        /// <summary>
        /// Gets or sets the animation.
        /// </summary>
        /// <value>The animation.</value>
        public ZeroitAnimate_Animation Animation { get; set; }
        /// <summary>
        /// Gets the control.
        /// </summary>
        /// <value>The control.</value>
        public Control Control { get; internal set; }
        /// <summary>
        /// Gets the mode.
        /// </summary>
        /// <value>The mode.</value>
        public AnimateMode Mode { get; internal set; }
    }

    /// <summary>
    /// Class TransfromNeededEventArg.
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public class TransfromNeededEventArg : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransfromNeededEventArg"/> class.
        /// </summary>
        public TransfromNeededEventArg()
        {
            Matrix = new Matrix(1, 0, 0, 1, 0, 0);
        }

        /// <summary>
        /// Gets or sets the matrix.
        /// </summary>
        /// <value>The matrix.</value>
        public Matrix Matrix { get; set; }
        /// <summary>
        /// Gets the current time.
        /// </summary>
        /// <value>The current time.</value>
        public float CurrentTime { get; internal set; }
        /// <summary>
        /// Gets the client rectangle.
        /// </summary>
        /// <value>The client rectangle.</value>
        public Rectangle ClientRectangle { get; internal set; }
        /// <summary>
        /// Gets the clip rectangle.
        /// </summary>
        /// <value>The clip rectangle.</value>
        public Rectangle ClipRectangle { get; internal set; }
        /// <summary>
        /// Gets or sets the animation.
        /// </summary>
        /// <value>The animation.</value>
        public ZeroitAnimate_Animation Animation { get; set; }
        /// <summary>
        /// Gets the control.
        /// </summary>
        /// <value>The control.</value>
        public Control Control { get; internal set; }
        /// <summary>
        /// Gets the mode.
        /// </summary>
        /// <value>The mode.</value>
        public AnimateMode Mode { get; internal set; }
        /// <summary>
        /// Gets or sets a value indicating whether [use default matrix].
        /// </summary>
        /// <value><c>true</c> if [use default matrix]; otherwise, <c>false</c>.</value>
        public bool UseDefaultMatrix { get; set; }
    }

    /// <summary>
    /// Class NonLinearTransfromNeededEventArg.
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public class NonLinearTransfromNeededEventArg : EventArgs
    {
        /// <summary>
        /// Gets the current time.
        /// </summary>
        /// <value>The current time.</value>
        public float CurrentTime { get; internal set; }

        /// <summary>
        /// Gets the client rectangle.
        /// </summary>
        /// <value>The client rectangle.</value>
        public Rectangle ClientRectangle { get; internal set; }
        /// <summary>
        /// Gets the pixels.
        /// </summary>
        /// <value>The pixels.</value>
        public byte[] Pixels { get; internal set; }
        /// <summary>
        /// Gets the stride.
        /// </summary>
        /// <value>The stride.</value>
        public int Stride { get; internal set; }

        /// <summary>
        /// Gets the source client rectangle.
        /// </summary>
        /// <value>The source client rectangle.</value>
        public Rectangle SourceClientRectangle { get; internal set; }
        /// <summary>
        /// Gets the source pixels.
        /// </summary>
        /// <value>The source pixels.</value>
        public byte[] SourcePixels { get; internal set; }
        /// <summary>
        /// Gets or sets the source stride.
        /// </summary>
        /// <value>The source stride.</value>
        public int SourceStride { get; set; }

        /// <summary>
        /// Gets or sets the animation.
        /// </summary>
        /// <value>The animation.</value>
        public ZeroitAnimate_Animation Animation { get; set; }
        /// <summary>
        /// Gets the control.
        /// </summary>
        /// <value>The control.</value>
        public Control Control { get; internal set; }
        /// <summary>
        /// Gets the mode.
        /// </summary>
        /// <value>The mode.</value>
        public AnimateMode Mode { get; internal set; }
        /// <summary>
        /// Gets or sets a value indicating whether [use default transform].
        /// </summary>
        /// <value><c>true</c> if [use default transform]; otherwise, <c>false</c>.</value>
        public bool UseDefaultTransform { get; set; }
    }

    /// <summary>
    /// Set the animation mode for <c><see cref="ZeroitAnimator" /></c> animator.
    /// </summary>
    public enum AnimateMode
    {
        /// <summary>
        /// The show
        /// </summary>
        Show,
        /// <summary>
        /// The hide
        /// </summary>
        Hide,
        /// <summary>
        /// The update
        /// </summary>
        Update,
        /// <summary>
        /// The begin update
        /// </summary>
        BeginUpdate
    }
    
    #endregion
}
