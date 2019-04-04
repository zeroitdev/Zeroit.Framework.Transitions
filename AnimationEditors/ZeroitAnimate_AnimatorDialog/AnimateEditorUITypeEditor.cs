// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="AnimateEditorUITypeEditor.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
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
    public class AnimatorEditor : System.Drawing.Design.UITypeEditor
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
            if (value is AnimateInput)
            {
                ZeroitAnimateAnimatorDialog dialog = new ZeroitAnimateAnimatorDialog((AnimateInput)value);
                //dialog.Show();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.AnimateInput;
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

            if (e.Value is AnimateInput)
            {
                Zeroit.Framework.Transitions.AnimatorWithEditor.AnimationType animationType = ((AnimateInput) e.Value).AnimationType;

                switch (animationType)
                {
                    case AnimatorWithEditor.AnimationType.Custom:
                        e.Graphics.DrawString("CU", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Cyan),
                            new Point(1, 1));
                        break;
                    case AnimatorWithEditor.AnimationType.Rotate:
                        e.Graphics.DrawString("RT", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Cyan),
                            new Point(1, 1));
                        break;
                    case AnimatorWithEditor.AnimationType.HorizSlide:
                        e.Graphics.DrawString("HS", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Cyan),
                            new Point(1, 1));
                        break;
                    case AnimatorWithEditor.AnimationType.VertSlide:
                        e.Graphics.DrawString("VS", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Cyan),
                            new Point(1, 1));
                        break;
                    case AnimatorWithEditor.AnimationType.Scale:
                        e.Graphics.DrawString("SC", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Cyan),
                            new Point(1, 1));
                        break;
                    case AnimatorWithEditor.AnimationType.ScaleAndRotate:
                        e.Graphics.DrawString("SCR", new Font("Microsoft Sans Serif", 6), new SolidBrush(Color.Cyan),
                            new Point(2, 5));
                        break;
                    case AnimatorWithEditor.AnimationType.HorizSlideAndRotate:
                        e.Graphics.DrawString("HSR", new Font("Microsoft Sans Serif", 6), new SolidBrush(Color.Cyan),
                            new Point(2, 5));
                        break;
                    case AnimatorWithEditor.AnimationType.ScaleAndHorizSlide:
                        e.Graphics.DrawString("SHS", new Font("Microsoft Sans Serif", 6), new SolidBrush(Color.Cyan),
                            new Point(2, 5));
                        break;
                    case AnimatorWithEditor.AnimationType.Transparent:
                        e.Graphics.DrawString("TT", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Cyan),
                            new Point(1, 1));
                        break;
                    case AnimatorWithEditor.AnimationType.Leaf:
                        e.Graphics.DrawString("LF", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Cyan),
                            new Point(1, 1));
                        break;
                    case AnimatorWithEditor.AnimationType.Mosaic:
                        e.Graphics.DrawString("MS", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Cyan),
                            new Point(1, 1));
                        break;
                    case AnimatorWithEditor.AnimationType.Particles:
                        e.Graphics.DrawString("PTC", new Font("Microsoft Sans Serif", 6), new SolidBrush(Color.Cyan),
                            new Point(2, 5));
                        break;
                    case AnimatorWithEditor.AnimationType.VertBlind:
                        e.Graphics.DrawString("VB", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Cyan),
                            new Point(1, 1));
                        break;
                    case AnimatorWithEditor.AnimationType.HorizBlind:
                        e.Graphics.DrawString("HB", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Cyan),
                            new Point(1, 1));
                        break;
                }
            }
        }
    }
}
