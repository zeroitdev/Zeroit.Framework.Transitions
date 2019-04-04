// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ZeroitTransitionEditorUITypeEditor.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using Zeroit.Framework.Transitions.ZeroitAnimateTransitionWithEditor;

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
    public class ZeroitTransitionAnimatorEditor : System.Drawing.Design.UITypeEditor
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
            if (value is ZeroitTransitionInput)
            {
                ZeroitAnimateTransitionDialog dialog = new ZeroitAnimateTransitionDialog((ZeroitTransitionInput)value);
                //dialog.Show();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.ZeroitTransitionInput;
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

            if (e.Value is ZeroitTransitionInput)
            {
                ZeroitTransitorEdit.TransitionType transitionType =
                    ((ZeroitTransitionInput) e.Value).Transitions;

                switch (transitionType)
                {
                    case ZeroitTransitorEdit.TransitionType.Accelaration:
                        e.Graphics.DrawString("AC", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Cyan),
                            new Point(1, 1));
                        break;
                    case ZeroitTransitorEdit.TransitionType.Bounce:
                        e.Graphics.DrawString("BC", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Cyan),
                            new Point(1, 1));
                        break;
                    case ZeroitTransitorEdit.TransitionType.CriticalDamping:
                        e.Graphics.DrawString("CD", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Cyan),
                            new Point(1, 1));
                        break;
                    case ZeroitTransitorEdit.TransitionType.Deceleration:
                        e.Graphics.DrawString("DC", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Cyan),
                            new Point(1, 1));
                        break;
                    case ZeroitTransitorEdit.TransitionType.EaseInEaseOut:
                        e.Graphics.DrawString("EIO", new Font("Microsoft Sans Serif", 6), new SolidBrush(Color.Cyan),
                            new Point(2, 5));
                        break;
                    case ZeroitTransitorEdit.TransitionType.Flash:
                        e.Graphics.DrawString("FL", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Cyan),
                            new Point(1, 1));
                        break;
                    case ZeroitTransitorEdit.TransitionType.Linear:
                        e.Graphics.DrawString("LN", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Cyan),
                            new Point(1, 1));
                        break;
                    case ZeroitTransitorEdit.TransitionType.Zeroit:
                        e.Graphics.DrawString("ZT", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Cyan),
                            new Point(1, 1));
                        break;
                    case ZeroitTransitorEdit.TransitionType.ThrowAndCatch:
                        e.Graphics.DrawString("TC", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Cyan),
                            new Point(1, 1));
                        break;
                }
            }
        }
    }
}
