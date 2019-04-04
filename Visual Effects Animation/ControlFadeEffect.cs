// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ControlFadeEffect.cs" company="Zeroit Dev Technologies">
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
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.Transitions
{
    #region ControlFadeEffect
    /// <summary>
    /// Class ControlFadeEffect.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.IEffect" />
    public class ControlFadeEffect : IEffect
    {
        /// <summary>
        /// The maximum opacity
        /// </summary>
        public const int MAX_OPACITY = 100;
        /// <summary>
        /// The minimum opacity
        /// </summary>
        public const int MIN_OPACITY = 0;

        /// <summary>
        /// Class State.
        /// </summary>
        private class State
        {
            /// <summary>
            /// Gets or sets the opacity.
            /// </summary>
            /// <value>The opacity.</value>
            public int Opacity { get; set; }
            /// <summary>
            /// Gets or sets the parent graphics.
            /// </summary>
            /// <value>The parent graphics.</value>
            public Graphics ParentGraphics { get; set; }
            /// <summary>
            /// Gets or sets the previous bounds.
            /// </summary>
            /// <value>The previous bounds.</value>
            public Rectangle PreviousBounds { get; set; }
            /// <summary>
            /// Gets or sets the snapshot.
            /// </summary>
            /// <value>The snapshot.</value>
            public Bitmap Snapshot { get; set; }
        }

        /// <summary>
        /// The control cache
        /// </summary>
        private static Dictionary<Control, State> _controlCache
            = new Dictionary<Control, State>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlFadeEffect"/> class.
        /// </summary>
        /// <param name="control">The control.</param>
        public ControlFadeEffect(Control control)
        {
            if (!_controlCache.ContainsKey(control))
            {
                var parentGraphics = control.Parent.CreateGraphics();
                parentGraphics.CompositingQuality = CompositingQuality.HighSpeed;

                var state = new State()
                {
                    ParentGraphics = parentGraphics,
                    Opacity = control.Visible ? MAX_OPACITY : MIN_OPACITY,
                };

                _controlCache.Add(control, state);
            }
        }

        /// <summary>
        /// Gets the current value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>System.Int32.</returns>
        public int GetCurrentValue(Control control)
        {
            return _controlCache[control].Opacity;
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="originalValue">The original value.</param>
        /// <param name="valueToReach">The value to reach.</param>
        /// <param name="newValue">The new value.</param>
        public void SetValue(Control control, int originalValue, int valueToReach, int newValue)
        {
            Console.WriteLine(newValue);
            var state = _controlCache[control];

            //invalidate region no more in use
            var region = new Region(state.PreviousBounds);
            region.Exclude(control.Bounds);
            control.Parent.Invalidate(region);

            //I get real-time snapshot (no cache) so i can mix animations
            var snapshot = control.GetSnapshot();
            if (snapshot != null)
            {
                snapshot = (Bitmap)snapshot.ChangeOpacity(newValue);
                //avoid refresh and thus flickering: blend parent's background with snapshot
                var bgBlendedSnapshot = BlendWithBgColor(snapshot, control.Parent.BackColor);
                state.Snapshot = bgBlendedSnapshot;
            }
            state.PreviousBounds = control.Bounds;

            if (newValue == MAX_OPACITY)
            {
                control.Visible = true;
                return;
            }

            control.Visible = false;
            state.Opacity = newValue;

            if (newValue > 0)
            {
                var rect = control.Parent.RectangleToClient(
                    control.RectangleToScreen(control.ClientRectangle));

                if (state.Snapshot != null)
                    state.ParentGraphics.DrawImage(state.Snapshot, rect);
            }
            else
            {
                control.Parent.Invalidate();
            }
        }

        /// <summary>
        /// Gets the minimum value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>System.Int32.</returns>
        public int GetMinimumValue(Control control)
        {
            return MIN_OPACITY;
        }

        /// <summary>
        /// Gets the maximum value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>System.Int32.</returns>
        public int GetMaximumValue(Control control)
        {
            return MAX_OPACITY;
        }

        /// <summary>
        /// Gets the interaction.
        /// </summary>
        /// <value>The interaction.</value>
        public EffectInteractions Interaction
        {
            get { return EffectInteractions.TRANSPARENCY; }
        }

        /// <summary>
        /// Blends the color of the with bg.
        /// </summary>
        /// <param name="image1">The image1.</param>
        /// <param name="bgColor">Color of the bg.</param>
        /// <returns>Bitmap.</returns>
        private Bitmap BlendWithBgColor(Image image1, Color bgColor)
        {
            var finalImage = new Bitmap(image1.Width, image1.Height);
            using (Graphics g = Graphics.FromImage(finalImage))
            {
                g.Clear(Color.Black);

                g.FillRectangle(new SolidBrush(bgColor), new Rectangle(0, 0, image1.Width, image1.Height));
                g.DrawImage(image1, new Rectangle(0, 0, image1.Width, image1.Height));
            }

            return finalImage;
        }
    }

    /// <summary>
    /// tries to merge form snapshot and control snapshot
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.IEffect" />
    public class ControlFadeEffect2 : IEffect
    {
        /// <summary>
        /// The maximum opacity
        /// </summary>
        public const int MAX_OPACITY = 100;
        /// <summary>
        /// The minimum opacity
        /// </summary>
        public const int MIN_OPACITY = 0;

        /// <summary>
        /// Class State.
        /// </summary>
        private class State
        {
            /// <summary>
            /// Gets or sets the opacity.
            /// </summary>
            /// <value>The opacity.</value>
            public int Opacity { get; set; }
            /// <summary>
            /// Gets or sets the parent graphics.
            /// </summary>
            /// <value>The parent graphics.</value>
            public Graphics ParentGraphics { get; set; }
            /// <summary>
            /// Gets or sets the previous bounds.
            /// </summary>
            /// <value>The previous bounds.</value>
            public Rectangle PreviousBounds { get; set; }
            /// <summary>
            /// Gets or sets the snapshot.
            /// </summary>
            /// <value>The snapshot.</value>
            public Bitmap Snapshot { get; set; }
        }

        /// <summary>
        /// The control cache
        /// </summary>
        private static Dictionary<Control, State> _controlCache
            = new Dictionary<Control, State>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlFadeEffect2"/> class.
        /// </summary>
        /// <param name="control">The control.</param>
        public ControlFadeEffect2(Control control)
        {
            if (!_controlCache.ContainsKey(control))
            {
                var parentGraphics = control.Parent.CreateGraphics();
                parentGraphics.CompositingQuality = CompositingQuality.HighSpeed;

                var state = new State()
                {
                    ParentGraphics = parentGraphics,
                    Opacity = control.Visible ? MAX_OPACITY : MIN_OPACITY,
                };

                _controlCache.Add(control, state);
            }
        }

        /// <summary>
        /// Gets the current value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>System.Int32.</returns>
        public int GetCurrentValue(Control control)
        {
            return _controlCache[control].Opacity;
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="originalValue">The original value.</param>
        /// <param name="valueToReach">The value to reach.</param>
        /// <param name="newValue">The new value.</param>
        public void SetValue(Control control, int originalValue, int valueToReach, int newValue)
        {
            var state = _controlCache[control];

            //invalidate region no more in use
            var region = new Region(state.PreviousBounds);
            region.Exclude(control.Bounds);
            control.Parent.Invalidate(region);

            var form = control.FindForm();
            var formRelativeCoords = form.RectangleToClient(control.RectangleToScreen(control.ClientRectangle));

            //I get real-time snapshot (no cache) so i can mix animations
            var controlSnapshot = control.GetSnapshot();
            if (controlSnapshot != null)
            {
                controlSnapshot = (Bitmap)controlSnapshot.ChangeOpacity(newValue);


                var formSnapshot = form.GetFormBorderlessSnapshot().Clone(formRelativeCoords, PixelFormat.DontCare);

                //avoid refresh and thus flickering: blend parent form snapshot with control snapshot
                var bgBlendedSnapshot = this.BlendImages(formSnapshot, controlSnapshot);
                //bgBlendedSnapshot.Save( @"C:\Users\Sampietro.Mauro\Documents\_root\bmp" + newValue + ".bmp" );
                state.Snapshot = bgBlendedSnapshot;
            }
            state.PreviousBounds = control.Bounds;

            if (newValue == MAX_OPACITY)
            {
                control.Visible = true;
                return;
            }

            control.Visible = false;
            state.Opacity = newValue;

            if (newValue > 0)
            {
                //var rect = control.Parent.RectangleToClient(
                //    control.RectangleToScreen( control.ClientRectangle ) );

                form.CreateGraphics().DrawImage(state.Snapshot, formRelativeCoords);
                //if( state.Snapshot != null )
                //    state.ParentGraphics.DrawImage( state.Snapshot, rect );
            }
            else
            {
                control.Parent.Invalidate();
            }
        }

        /// <summary>
        /// Gets the minimum value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>System.Int32.</returns>
        public int GetMinimumValue(Control control)
        {
            return MIN_OPACITY;
        }

        /// <summary>
        /// Gets the maximum value.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns>System.Int32.</returns>
        public int GetMaximumValue(Control control)
        {
            return MAX_OPACITY;
        }

        /// <summary>
        /// Gets the interaction.
        /// </summary>
        /// <value>The interaction.</value>
        public EffectInteractions Interaction
        {
            get { return EffectInteractions.TRANSPARENCY; }
        }

        /// <summary>
        /// Blends the images.
        /// </summary>
        /// <param name="image1">The image1.</param>
        /// <param name="image2">The image2.</param>
        /// <returns>Bitmap.</returns>
        private Bitmap BlendImages(Image image1, Image image2)
        {
            var finalImage = new Bitmap(image1.Width, image1.Height);
            using (Graphics g = Graphics.FromImage(finalImage))
            {
                g.Clear(Color.Black);

                g.DrawImage(image1, new Rectangle(0, 0, image1.Width, image1.Height));
                g.DrawImage(image2, new Rectangle(0, 0, image1.Width, image1.Height));
            }

            return finalImage;
        }
    }
    #endregion
}
