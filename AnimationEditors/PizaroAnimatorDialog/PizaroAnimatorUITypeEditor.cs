// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="PizaroAnimatorUITypeEditor.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using Zeroit.Framework.Transitions.ZeroitPizaroAnimator;

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
    public class PizaroInputEditor : System.Drawing.Design.UITypeEditor
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
            if (value is ZeroitPizaroAnimatorInput)
            {
                ZeroitPizaroAnimatorDialog dialog = new ZeroitPizaroAnimatorDialog((ZeroitPizaroAnimatorInput)value);
                //dialog.Show();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.ZeroitPizaroAnimatorInput;
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

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            if (e.Value is ZeroitPizaroAnimatorInput)
            {
                ZeroitPizaroAnimEdit.animationType animationType = ((ZeroitPizaroAnimatorInput) e.Value).AnimationType;

                switch (animationType)
                {
                    case ZeroitPizaroAnimEdit.animationType.None:
                        e.Graphics.DrawString("?", new Font("Microsoft Sans Serif", 10), new SolidBrush(Color.Cyan),
                            new Point(4, 1));
                        break;
                    case ZeroitPizaroAnimEdit.animationType.Fade:
                        e.Graphics.DrawString("⥈", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                            new Point(2, 0));
                        break;
                    case ZeroitPizaroAnimEdit.animationType.FadeIn:
                        e.Graphics.DrawString("↩", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                            new Point(3, 1));
                        break;
                    case ZeroitPizaroAnimEdit.animationType.FadeInAndShow:
                        e.Graphics.DrawString("⥩", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                            new Point(2, 0));
                        break;
                    case ZeroitPizaroAnimEdit.animationType.FadeOut:
                        e.Graphics.DrawString("↪", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                            new Point(3, 1));
                        break;
                    case ZeroitPizaroAnimEdit.animationType.FadeOutandHide:
                        e.Graphics.DrawString("⥨", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                            new Point(2, 0));
                        break;
                    case ZeroitPizaroAnimEdit.animationType.Resize:
                        e.Graphics.DrawString("⤲", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                            new Point(3, 0));
                        break;
                    case ZeroitPizaroAnimEdit.animationType.ResizeHeight:
                        e.Graphics.DrawString("↕", new Font("Microsoft Sans Serif", 10), new SolidBrush(Color.Cyan),
                            new Point(5, 0));
                        break;
                    case ZeroitPizaroAnimEdit.animationType.ResizeWidth:
                        e.Graphics.DrawString("↔", new Font("Microsoft Sans Serif", 10), new SolidBrush(Color.Cyan),
                            new Point(2, 0));
                        break;
                    case ZeroitPizaroAnimEdit.animationType.Slide:
                        e.Graphics.DrawString("↹", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                            new Point(3, 1));
                        break;
                    case ZeroitPizaroAnimEdit.animationType.SlideFrom:
                        e.Graphics.DrawString("↝", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                            new Point(3, 0));
                        break;
                }
            }

        }
    }
}
