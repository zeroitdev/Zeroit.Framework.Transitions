// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ObjectAnimatorUITypeEditor.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
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
    public class ObjectInputEditor : System.Drawing.Design.UITypeEditor
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
            if (value is ObjectAnimatorInput)
            {
                ObjectAnimatorDialog dialog = new ObjectAnimatorDialog((ObjectAnimatorInput)value);
                //dialog.Show();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.ObjectAnimatorInput;
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

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;


            if (e.Value is ObjectAnimatorInput)
            {
                ZeroitOJAnimEdit.ZeroitObjectAnimationMode animationMode =
                    ((ObjectAnimatorInput)e.Value).AnimationMode;

                ZeroitOJAnimEdit.ZeroitObjectColorAnimation colorAnimationMode =
                    ((ObjectAnimatorInput)e.Value).ColorAnimation;

                ZeroitOJAnimEdit.ZeroitObjectFormAnimation formAnimationMode =
                    ((ObjectAnimatorInput)e.Value).FormAnimation;

                ZeroitOJAnimEdit.ZeroitObjectStandardAnimation standardAnimationMode =
                    ((ObjectAnimatorInput)e.Value).StandardAnimation;

                

                switch (animationMode)
                {
                    
                    case ZeroitOJAnimEdit.ZeroitObjectAnimationMode.ColorAnimation:
                        switch (colorAnimationMode)
                        {
                            case ZeroitOJAnimEdit.ZeroitObjectColorAnimation.FillEllipse:
                                e.Graphics.FillEllipse(new SolidBrush(((ObjectAnimatorInput)e.Value).ColorToAnimate),
                                    new RectangleF(3,2,e.Bounds.Width-4, e.Bounds.Height-4));
                                //e.Graphics.DrawString("FE", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Cyan),
                                //    new Point(1, 1));
                                break;
                            case ZeroitOJAnimEdit.ZeroitObjectColorAnimation.FillSquare:
                                e.Graphics.FillRectangle(new SolidBrush(((ObjectAnimatorInput)e.Value).ColorToAnimate),
                                    new RectangleF(3, 2, e.Bounds.Width - 4, e.Bounds.Height - 4));
                                //e.Graphics.DrawString("FS", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Cyan),
                                //    new Point(1, 1));
                                break;
                            case ZeroitOJAnimEdit.ZeroitObjectColorAnimation.SlideFill:
                                e.Graphics.DrawString("➲", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                                    new Point(1, 0));
                                break;
                            case ZeroitOJAnimEdit.ZeroitObjectColorAnimation.StripeFill:
                                e.Graphics.DrawString("⇚", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                                    new Point(3, 0));
                                break;
                            case ZeroitOJAnimEdit.ZeroitObjectColorAnimation.SplitFill:
                                e.Graphics.DrawString("Ξ", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                                    new Point(3, 0));
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                        break;
                    case ZeroitOJAnimEdit.ZeroitObjectAnimationMode.FormAnimation:
                        switch (formAnimationMode)
                        {
                            case ZeroitOJAnimEdit.ZeroitObjectFormAnimation.FadeIn:
                                e.Graphics.DrawString("↩", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                                    new Point(3, 1));
                                break;
                            case ZeroitOJAnimEdit.ZeroitObjectFormAnimation.FadeOut:
                                e.Graphics.DrawString("↪", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                                    new Point(3, 1));
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                        break;
                    case ZeroitOJAnimEdit.ZeroitObjectAnimationMode.StandardAnimation:
                        switch (standardAnimationMode)
                        {
                            case ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.SlideUp:
                                e.Graphics.DrawString("↥", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                                    new Point(4, 1));
                                break;
                            case ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.SlideDown:
                                e.Graphics.DrawString("↧", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                                    new Point(4, 1));
                                break;
                            case ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.SlideLeft:
                                e.Graphics.DrawString("↤", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                                    new Point(3, 1));
                                break;
                            case ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.SlideRight:
                                e.Graphics.DrawString("↦", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                                    new Point(3, 1));
                                break;
                            case ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.SlugRight:
                                e.Graphics.DrawString("⤞", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                                    new Point(3, 0));
                                break;
                            case ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.SlugLeft:
                                e.Graphics.DrawString("⤝", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                                    new Point(3, 0));
                                break;
                            case ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.Hop:
                                e.Graphics.DrawString("⥉", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                                    new Point(4, 0));
                                break;
                            case ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.ShootRight:
                                e.Graphics.DrawString("↣", new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                                    new Point(3, 1));
                                break;
                            case ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.ShootLeft:
                                e.Graphics.DrawString(Reverse("↢"), new Font("Microsoft Sans Serif", 12), new SolidBrush(Color.Cyan),
                                    new Point(3, 1));
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                        break;
                }

                

            }

        }

        public static string Reverse(string input)
        {
            char[] c = input.ToCharArray();
            Array.Reverse(c);
            return new string(c);
        }
    }

}
