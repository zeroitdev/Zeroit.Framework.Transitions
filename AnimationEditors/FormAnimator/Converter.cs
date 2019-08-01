using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Zeroit.Framework.Transitions.ZeroitFormAnimator;

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    #region Converter

    /// <summary>
    /// Class VisualEffectsConverter.
    /// </summary>
    /// <seealso cref="System.ComponentModel.TypeConverter" />
    class FormAnimatorConverter : TypeConverter
    {

        /// <summary>
        /// Returns whether this converter can convert the object to the specified type, using the specified context.
        /// </summary>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
        /// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type you want to convert to.</param>
        /// <returns>true if this converter can perform the conversion; otherwise, false.</returns>
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(InstanceDescriptor)/* || destinationType == typeof(string)*/)
            {
                return true;
            }
            return base.CanConvertTo(context, destinationType);
        }

        // This code allows the designer to generate the Shape constructor

        /// <summary>
        /// Converts the given value object to the specified type, using the specified context and culture information.
        /// </summary>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
        /// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" />. If null is passed, the current culture is assumed.</param>
        /// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
        /// <param name="destinationType">The <see cref="T:System.Type" /> to convert the <paramref name="value" /> parameter to.</param>
        /// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
        public override object ConvertTo(ITypeDescriptorContext context,
            CultureInfo culture,
            object value,
            Type destinationType)
        {

            if (destinationType == typeof(string))
            {
                // Display string in designer
                return "(Customize)";
            }


            else if (destinationType == typeof(InstanceDescriptor) && value is FormAnimatorInput)
            {
                FormAnimatorInput formAnimatorInput = (FormAnimatorInput)value;

                
                if (formAnimatorInput.Animation == FormAnimationTypes.LeftToRight)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(Positions),
                                typeof(ZeroitFormAnimator.Timer)


                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,
                                formAnimatorInput.Positions,
                                formAnimatorInput.Time


                                });
                    }
                }

                else if (formAnimatorInput.Animation == FormAnimationTypes.RightToLeft)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(Positions),
                                typeof(ZeroitFormAnimator.Timer),
                                typeof(string)

                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,
                                formAnimatorInput.Positions,
                                formAnimatorInput.Time,
                                formAnimatorInput.dummyString

                                });
                    }
                }

                else if (formAnimatorInput.Animation == FormAnimationTypes.TopToBottom)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(Positions),
                                typeof(ZeroitFormAnimator.Timer),
                                typeof(int)

                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,
                                formAnimatorInput.Positions,
                                formAnimatorInput.Time,
                                formAnimatorInput.dummyInt

                                });
                    }
                }

                else if (formAnimatorInput.Animation == FormAnimationTypes.BottomToTop)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(Positions),
                                typeof(ZeroitFormAnimator.Timer),
                                typeof(double)

                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,
                                formAnimatorInput.Positions,
                                formAnimatorInput.Time,
                                formAnimatorInput.dummyDouble

                                });
                    }
                }

                else if (formAnimatorInput.Animation == FormAnimationTypes.ShrinkHorizontal)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(Positions),
                                typeof(ZeroitFormAnimator.Timer),
                                typeof(float)

                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,
                                formAnimatorInput.Positions,
                                formAnimatorInput.Time,
                                formAnimatorInput.dummyFloat

                                });
                    }
                }

                else if (formAnimatorInput.Animation == FormAnimationTypes.ShrinkVertical)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(Positions),
                                typeof(ZeroitFormAnimator.Timer),
                                typeof(long)

                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,
                                formAnimatorInput.Positions,
                                formAnimatorInput.Time,
                                formAnimatorInput.dummyLong

                                });
                    }
                }

                else if (formAnimatorInput.Animation == FormAnimationTypes.ShrinkXY)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(Positions),
                                typeof(ZeroitFormAnimator.Timer),
                                typeof(short)

                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,
                                formAnimatorInput.Positions,
                                formAnimatorInput.Time,
                                formAnimatorInput.dummyShort

                                });
                    }
                }

                else if (formAnimatorInput.Animation == FormAnimationTypes.ShrinkMoveXY)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(Positions),
                                typeof(ZeroitFormAnimator.Timer),
                                typeof(bool)

                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,
                                formAnimatorInput.Positions,
                                formAnimatorInput.Time,
                                formAnimatorInput.dummyBool

                                });
                    }
                }

                else if (formAnimatorInput.Animation == FormAnimationTypes.FadeIn)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(Opacity),
                                typeof(ZeroitFormAnimator.Timer)

                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,
                                formAnimatorInput.Opacity,
                                formAnimatorInput.Time

                                });
                    }
                }

                else if (formAnimatorInput.Animation == FormAnimationTypes.FadeOut)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(Opacity),
                                typeof(ZeroitFormAnimator.Timer),
                                typeof(string)

                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,
                                formAnimatorInput.Opacity,
                                formAnimatorInput.Time,
                                formAnimatorInput.dummyString

                                });
                    }
                }

                else if (formAnimatorInput.Animation == FormAnimationTypes.HideControls)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(ZeroitFormAnimator.Timer)

                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,                                
                                formAnimatorInput.Time

                                });
                    }
                }

                else if (formAnimatorInput.Animation == FormAnimationTypes.ShowControls)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(ZeroitFormAnimator.Timer),
                                typeof(string)
                                

                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,
                                formAnimatorInput.Time,
                                formAnimatorInput.dummyString                 

                                });
                    }
                }

                else if (formAnimatorInput.Animation == FormAnimationTypes.GrowHorizontal)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(Grow),
                                typeof(ZeroitFormAnimator.Timer)


                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,
                                formAnimatorInput.Grow,
                                formAnimatorInput.Time

                                });
                    }
                }

                else if (formAnimatorInput.Animation == FormAnimationTypes.GrowVertical)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(Grow),
                                typeof(ZeroitFormAnimator.Timer),
                                typeof(string)


                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,
                                formAnimatorInput.Grow,
                                formAnimatorInput.Time,
                                formAnimatorInput.dummyString

                                });
                    }
                }

                else if (formAnimatorInput.Animation == FormAnimationTypes.GrowXY)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(Grow),
                                typeof(ZeroitFormAnimator.Timer),
                                typeof(int)


                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,
                                formAnimatorInput.Grow,
                                formAnimatorInput.Time,
                                formAnimatorInput.dummyInt

                                });
                    }
                }

                else if (formAnimatorInput.Animation == FormAnimationTypes.GrowMoveXY)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(Grow),
                                typeof(ZeroitFormAnimator.Timer),
                                typeof(bool)


                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,
                                formAnimatorInput.Grow,
                                formAnimatorInput.Time,
                                formAnimatorInput.dummyBool

                                });
                    }
                }

                else if (formAnimatorInput.Animation == FormAnimationTypes.Move)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(Move),
                                typeof(ZeroitFormAnimator.Timer)


                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,
                                formAnimatorInput.Move,
                                formAnimatorInput.Time

                                });
                    }
                }

                else if (formAnimatorInput.Animation == FormAnimationTypes.Shake)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(Shake),
                                typeof(ZeroitFormAnimator.Timer)


                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,
                                formAnimatorInput.Shake,
                                formAnimatorInput.Time

                                });
                    }
                }

                else if (formAnimatorInput.Animation == FormAnimationTypes.ShrinkFadeOut)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(ZeroitFormAnimator.Timer),
                                typeof(bool)


                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,
                                formAnimatorInput.Time,
                                formAnimatorInput.dummyBool

                                });
                    }
                }

                else if (formAnimatorInput.Animation == FormAnimationTypes.DeterminerPosition)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(ZeroitFormAnimator.Timer),
                                typeof(int)


                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,
                                formAnimatorInput.Time,
                                formAnimatorInput.dummyInt

                                });
                    }
                }

                else if (formAnimatorInput.Animation == FormAnimationTypes.Move)
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(new Type[]
                    {

                                typeof(FormAnimationTypes),
                                typeof(Locations),
                                typeof(ZeroitFormAnimator.Timer)


                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                formAnimatorInput.Animation,
                                formAnimatorInput.Locations,
                                formAnimatorInput.Time

                                });
                    }
                }
                
                else
                {
                    ConstructorInfo ctor = typeof(FormAnimatorInput).GetConstructor(Type.EmptyTypes);
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, null);
                    }
                }
                
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }

    #endregion
}
