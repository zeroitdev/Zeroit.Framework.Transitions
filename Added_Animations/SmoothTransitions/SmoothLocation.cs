// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 11-16-2018
// ***********************************************************************
// <copyright file="SmoothTransition.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;
using System.Windows.Forms;


namespace Zeroit.Framework.Transitions.SmoothTransitions
{

    
    /// <summary>
    /// Class Animation.
    /// </summary>
    public class LocationAnimation
    {
        /// <summary>
        /// The type
        /// </summary>
        AnimationTypes type;
        /// <summary>
        /// The target
        /// </summary>
        object target;
        /// <summary>
        /// The offset
        /// </summary>
        float offset;
        /// <summary>
        /// The handler
        /// </summary>
        AnimationFinishedHandler handler;
        /// <summary>
        /// The start
        /// </summary>
        float start;
        /// <summary>
        /// The end
        /// </summary>
        float end;
        /// <summary>
        /// The interval
        /// </summary>
        int interval = 10;
        /// <summary>
        /// The duration
        /// </summary>
        int duration;
        /// <summary>
        /// The time passed
        /// </summary>
        int timePassed = 0;

        /// <summary>
        /// The reversed duration
        /// </summary>
        int reversed_duration;
        /// <summary>
        /// The reversed time passed
        /// </summary>
        int reversed_timePassed = 0;

        /// <summary>
        /// The cancellation pending
        /// </summary>
        bool cancellationPending = false;
        /// <summary>
        /// The callback
        /// </summary>
        AnimationCallback callback;

        /// <summary>
        /// The animation is running
        /// </summary>
        bool animationIsRunning = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="Animation"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="target">The target.</param>
        /// <param name="offset">The offset.</param>
        /// <param name="handler">The handler.</param>
        public LocationAnimation(AnimationTypes type, object target, float offset, AnimationFinishedHandler handler)
            : this(type, target, offset, handler, 0, null, 0, 10, 0, 0, 0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Animation"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="target">The target.</param>
        /// <param name="offset">The offset.</param>
        /// <param name="handler">The handler.</param>
        /// <param name="duration">The duration.</param>
        public LocationAnimation(AnimationTypes type, object target, float offset, AnimationFinishedHandler handler, int duration)
            : this(type, target, offset, handler, 0, null, 0, 10,0,0,0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Animation"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="target">The target.</param>
        /// <param name="offset">The offset.</param>
        /// <param name="handler">The handler.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="callback">The callback.</param>
        /// <param name="startValue">The start value.</param>
        /// <param name="timerInterval">The timer interval.</param>
        /// <param name="timePassed">The time passed.</param>
        /// <param name="reversed_duration">Duration of the reversed.</param>
        /// <param name="reversed_timePassed">The reversed time passed.</param>
        public LocationAnimation(AnimationTypes type, object target, float offset, AnimationFinishedHandler handler, int duration, AnimationCallback callback, int startValue, int timerInterval, int timePassed, int reversed_duration, int reversed_timePassed)
        {
            this.type = type;
            this.target = target;
            this.offset = offset;
            this.handler = handler;
            this.duration = duration;
            this.reversed_duration = reversed_duration;

            // timings in ms
            this.interval = timerInterval;
            this.timePassed = timePassed;
            this.reversed_timePassed = reversed_timePassed;

            Control c;
            System.Windows.Forms.Form f;

            switch (type)
            {
                case AnimationTypes.MoveHorizontal:
                    c = target as Control;
                    if (c == null) return;
                    start = c.Location.X;
                    end = start + offset;
                    if (this.duration == 0) this.duration = 150;

                    break;

                case AnimationTypes.MoveVertical:
                    c = target as Control;
                    if (c == null) return;
                    start = c.Location.Y;
                    end = start + offset;
                    if (this.duration == 0) this.duration = 150;
                    break;
                                    
                case AnimationTypes.Callback:
                    if (callback == null) return;
                    start = startValue;
                    end = start + offset;
                    if (this.duration == 0) this.duration = 1000;
                    this.callback = callback;
                    break;
                default:
                    return;
            }

            Next();
            //Reversed();
        }

        /// <summary>
        /// Cancels this instance.
        /// </summary>
        public void Cancel()
        {
            cancellationPending = true;

            //DelayedCall.DisposeAll();
        }

        /// <summary>
        /// Makes the curve.
        /// </summary>
        /// <returns>System.Double.</returns>
        private double MakeCurve()
        {
            double timePercent = (double)timePassed / (double)duration;

            // we use the sine function from 3pi/2 to 5pi/2
            // scale down linear time percentage from 0...1 to 3pi/2 to 5pi/2
            double curve = Math.Sin(1.5 * Math.PI + timePercent * Math.PI);
            // translate sine output from -1...1 to 0...1
            curve = (curve + 1) / 2;
            // DEBUG: don't use curve but linear progress instead
            //curve = timePercent;

            return curve;
        }

        /// <summary>
        /// Nexts this instance.
        /// </summary>
        public void Next()
        {
            
            if (cancellationPending) return;   // and don't come back

            timePassed += interval + interval;
            if (timePassed > duration)
            {
                if (handler != null) handler(target);
                return;
            }

            try
            {
                Control c;
                System.Windows.Forms.Form f;
                Rectangle wa;
                switch (type)
                {
                    case AnimationTypes.MoveVertical:
                        c = target as Control;
                        c.Location = new Point(c.Location.X,(int)start + (int)((end - start) * MakeCurve()));
                        wa = Screen.FromControl(c).WorkingArea;
                        if (c is System.Windows.Forms.Form && c.Location.Y > wa.Y)
                        {
                            
                            //int Y = c.Location.Y;
                            int Y = (int)start + (int)((end - start) * MakeCurve());
                            Y -= c.Location.Y - wa.Y;
                            //c.Location= new Point(c.Location.X, Y) ;
                            //if (c.Top < wa.Top)
                            //{
                            //    c.Top = wa.Top;
                            //}
                        }
                        break;
                    
                    case AnimationTypes.MoveHorizontal:
                        c = target as Control;
                        c.Location = new Point((int)start + (int)((end - start) * MakeCurve()),c.Location.Y);
                        wa = Screen.FromControl(c).WorkingArea;
                        if (c is System.Windows.Forms.Form && c.Location.X > wa.X)
                        {
                            //int X = c.Location.X;
                            int X = (int)start + (int)((end - start) * MakeCurve());
                            X -= c.Location.X - wa.X;

                            //c.Location = new Point(X, c.Location.Y);
                            //if (c.Left < wa.Left)
                            //{
                            //    c.Left = wa.Left ;
                            //}
                        }
                        break;
                    
                    case AnimationTypes.FadeIn:
                        f = target as System.Windows.Forms.Form;
                        f.Opacity = (float)(start  * MakeCurve()) / 100;
                        break;
                    case AnimationTypes.FadeOut:
                        f = target as System.Windows.Forms.Form;
                        f.Opacity = (float)(start + ((end - start) * MakeCurve())) / 100;
                        break;
                    case AnimationTypes.Callback:
                        callback(target, (int)start + (int)((end - start) * MakeCurve()));
                        break;
                }

                DelayedCall.Start(Next, interval);


                
            }
            catch (Exception e)
            {
                
                // Control is gone, stop here
            }
            
        }

        /// <summary>
        /// Reverseds this instance.
        /// </summary>
        public void Reversed()
        {
            
            
            timePassed += interval-interval + 2;
                        
            try
            {
                Control c;
                System.Windows.Forms.Form f;
                Rectangle wa;
                switch (type)
                {
                    case AnimationTypes.MoveVertical:
                        c = target as Control;   
                        c.Location = new Point(c.Location.X, (int)start + (int)((end - start) * MakeCurve()));
                        wa = Screen.FromControl(c).WorkingArea;
                        if (c is System.Windows.Forms.Form && c.Bottom < wa.Bottom)
                        {
                            //int Y = c.Location.Y;
                            int Y = (int)start + (int)((end - start) * MakeCurve());
                            Y += c.Location.Y + wa.Y;
                            //c.Location = new Point(c.Location.X, Y);
                            
                            //if (c.Top > wa.Top)
                            //{
                            //    c.Top = wa.Top;
                            //}
                                                       

                        }
                        break;
                    case AnimationTypes.MoveHorizontal:
                        c = target as Control; 
                        c.Location = new Point((int)start + (int)((end - start) * MakeCurve()), c.Location.Y);
                        wa = Screen.FromControl(c).WorkingArea;
                        if (c is System.Windows.Forms.Form && c.Right < wa.Right)
                        {
                            //int X = c.Location.X;
                            int X = (int)start + (int)((end - start) * MakeCurve());
                            X += c.Location.X + wa.X;

                            //c.Location = new Point(X, c.Location.Y);
                            //if (c.Left > wa.Left)
                            //{
                            //    c.Left = wa.Left;
                            //}
                        }
                        break;
                    case AnimationTypes.FadeIn:
                        f = target as System.Windows.Forms.Form;
                        f.Opacity = (float)(end + ((start - end) * MakeCurve())) / 100;
                        break;
                    case AnimationTypes.FadeOut:
                        f = target as System.Windows.Forms.Form;
                        f.Opacity = (float)(end + ((start - end)* MakeCurve())) / 100;
                        break;
                    case AnimationTypes.Callback:
                        callback(target, (int)end + (int)((start - end) * MakeCurve()));
                        break;
                }

                

                DelayedCall.Start(Reversed, interval);
                
            }
            catch (ObjectDisposedException e)
            {

                MessageBox.Show(e.Message);
            }
        }

        
    }
}