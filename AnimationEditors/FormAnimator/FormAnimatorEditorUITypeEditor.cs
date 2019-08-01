// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="VisualEffectsEditorUITypeEditor.cs" company="Zeroit Dev Technologies">
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
using System.Drawing.Design;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    ///     The <c>UITypeEditor</c> derived class which indicates how a <c>Filler</c>
    ///     object can be edited directly from Visual Studio Designer.
    /// </summary>
    /// <remarks>
    ///     Note that this class is <b>NOT</b> meant to be invoked directly
    /// </remarks>
    /// <summary>
    ///     The <c>UITypeEditor</c> derived class which indicates how a <c>Filler</c>
    ///     object can be edited directly from Visual Studio Designer.
    /// </summary>
    /// <remarks>
    ///     Note that this class is <b>NOT</b> meant to be invoked directly
    /// </remarks>
    public class FormAnimatorEditor : System.Drawing.Design.UITypeEditor
    {
        /// <summary>
        ///     Gets the editor style used by the <c>EditValue</c> method.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that can be used to gain additional context information.</param>
        /// <returns><c>UITypeEditorEditStyle.Modal</c></returns>
        public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        /// <summary>
        ///     Creates and displays a <c>FillerEditorDialog</c> dialog if <c>value</c> is a <c>Filler</c>.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that can be used to gain additional context information.</param>
        /// <param name="provider">An IServiceProvider through which editing services may be obtained.</param>
        /// <param name="value">An instance of <c>Filler</c> being edited.</param>
        /// <returns>The new value of the <c>Filler</c> being edited.</returns>
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context,
            System.IServiceProvider provider,
            object value)
        {
            if (value is FormAnimatorInput)
            {
                FormAnimatorDialog dialog = new FormAnimatorDialog((FormAnimatorInput)value);
                //dialog.Show();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.FormAnimatorInput;
                }
            }
            return value;
        }

        /// <summary>
        ///     Indicates that painting is supported.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that can be used to gain additional context information.</param>
        /// <returns><c>true</c>.</returns>
        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        /// <summary>
        ///     Paint a representation of the simple filler (usually in designer).
        /// </summary>
        /// <param name="e">A <c>PaintValueEventArgs</c> that indicates what to paint and where to paint it.</param>
        public override void PaintValue(PaintValueEventArgs e)
        {

            //e.Graphics.FillRectangle(new SolidBrush(Color.Blue), e.Bounds /*r*/);

            ////if (e.Value is Filler)
            ////{
            ////    Brush br = ((Filler)e.Value).GetUITypeEditorBrush(e.Bounds);
            ////    if (br != null)
            ////    {
            ////        e.Graphics.FillRectangle(br, e.Bounds /*r*/);
            ////    }
            ////}


            //------------------Uncomment------------------//
            //if (e.Value is FormAnimatorInput)
            //{
            //    ZeroitVisAnimEdit.GetAnimationType animationType = ((FormAnimatorInput)e.Value).AnimationType;
            //    Brush br = ((FormAnimatorInput)e.Value).GetUITypeEditorBrush(e.Bounds);
            //    Pen pn = ((FormAnimatorInput)e.Value).GetUITypeEditorPen(e.Bounds);




            //    if (br != null && pn != null)
            //    {

            //        switch (animationType)
            //        {
            //            case ZeroitVisAnimEdit.GetAnimationType.BottomAnchoredHeightEffect:
            //                e.Graphics.DrawString("BA", new Font("Segoe UI", 8), br,
            //                    new RectangleF(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 3,
            //                        e.Bounds.Height - 3));
            //                break;
            //            case ZeroitVisAnimEdit.GetAnimationType.ColorChannelShiftEffect:
            //                e.Graphics.DrawString("CC", new Font("Segoe UI", 8), br,
            //                    new RectangleF(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 3,
            //                        e.Bounds.Height - 3));
            //                break;
            //            case ZeroitVisAnimEdit.GetAnimationType.ColorShiftEffect:
            //                e.Graphics.DrawString("CS", new Font("Segoe UI", 8), br,
            //                    new RectangleF(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 3,
            //                        e.Bounds.Height - 3));
            //                break;
            //            case ZeroitVisAnimEdit.GetAnimationType.ControlFadeEffect:
            //                e.Graphics.DrawString("CF", new Font("Segoe UI", 8), br,
            //                    new RectangleF(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 3,
            //                        e.Bounds.Height - 3));
            //                break;
            //            case ZeroitVisAnimEdit.GetAnimationType.ControlFadeEffect2:
            //                e.Graphics.DrawString("CF2", new Font("Segoe UI", 6), br,
            //                    new RectangleF(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 3,
            //                        e.Bounds.Height - 3));
            //                break;
            //            case ZeroitVisAnimEdit.GetAnimationType.FormFadeEffect:
            //                e.Graphics.DrawString("FF", new Font("Segoe UI", 8), br,
            //                    new RectangleF(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 3,
            //                        e.Bounds.Height - 3));
            //                break;
            //            case ZeroitVisAnimEdit.GetAnimationType.FontSizeEffect:
            //                e.Graphics.DrawString("FS", new Font("Segoe UI", 8), br,
            //                    new RectangleF(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 3,
            //                        e.Bounds.Height - 3));
            //                break;
            //            case ZeroitVisAnimEdit.GetAnimationType.FoldEffect:
            //                e.Graphics.DrawString("FD", new Font("Segoe UI", 8), br,
            //                    new RectangleF(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 3,
            //                        e.Bounds.Height - 3));
            //                break;
            //            case ZeroitVisAnimEdit.GetAnimationType.HorizontalFoldEffect:
            //                e.Graphics.DrawString("HF", new Font("Segoe UI", 8), br,
            //                    new RectangleF(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 3,
            //                        e.Bounds.Height - 3));
            //                break;
            //            case ZeroitVisAnimEdit.GetAnimationType.LeftAnchoredWidthEffect:
            //                e.Graphics.DrawString("LA", new Font("Segoe UI", 8), br,
            //                    new RectangleF(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 3,
            //                        e.Bounds.Height - 3));
            //                break;
            //            case ZeroitVisAnimEdit.GetAnimationType.RightAnchoredWidthEffect:
            //                e.Graphics.DrawString("RA", new Font("Segoe UI", 7), br,
            //                    new RectangleF(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 3,
            //                        e.Bounds.Height - 3));
            //                break;
            //            case ZeroitVisAnimEdit.GetAnimationType.TopAnchoredHeightEffect:
            //                e.Graphics.DrawString("TA", new Font("Segoe UI", 8), br,
            //                    new RectangleF(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 3,
            //                        e.Bounds.Height - 3));
            //                break;
            //            case ZeroitVisAnimEdit.GetAnimationType.VerticalFoldEffect:
            //                e.Graphics.DrawString("VF", new Font("Segoe UI", 8), br,
            //                    new RectangleF(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 3,
            //                        e.Bounds.Height - 3));
            //                break;
            //            case ZeroitVisAnimEdit.GetAnimationType.XLocationEffect:
            //                e.Graphics.DrawString("XL", new Font("Segoe UI", 8), br,
            //                    new RectangleF(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 3,
            //                        e.Bounds.Height - 3));
            //                break;
            //            case ZeroitVisAnimEdit.GetAnimationType.YLocationEffect:
            //                e.Graphics.DrawString("YL", new Font("Segoe UI", 8), br,
            //                    new RectangleF(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 3,
            //                        e.Bounds.Height - 3));
            //                break;
            //            default:
            //                throw new ArgumentOutOfRangeException();
            //        }

            //    }
            //}





        }
    }
}
