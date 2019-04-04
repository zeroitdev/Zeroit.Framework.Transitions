// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="AnimationPreparer.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.ZeroitFormAnimator
{
    /// <summary>
    /// Descripci�n breve de AnimationPreparer.
    /// </summary>
    public class AnimationPreparer
	{
        /// <summary>
        /// The formappal
        /// </summary>
        private System.Windows.Forms.Form formappal;
        /// <summary>
        /// The time
        /// </summary>
        public int time;
        /// <summary>
        /// The step x
        /// </summary>
        public int stepX;
        /// <summary>
        /// The step y
        /// </summary>
        public int stepY;
        /// <summary>
        /// The animacion
        /// </summary>
        private Constantes Animacion;

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationPreparer"/> class.
        /// </summary>
        /// <param name="formappal">The formappal.</param>
        /// <param name="Animacion">The animacion.</param>
        public AnimationPreparer(System.Windows.Forms.Form formappal, Constantes Animacion):this(formappal, Animacion, 15, 5, 5)
		{
			
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationPreparer"/> class.
        /// </summary>
        /// <param name="formappal">The formappal.</param>
        /// <param name="Animacion">The animacion.</param>
        /// <param name="time">The time.</param>
        /// <param name="stepX">The step x.</param>
        /// <param name="stepY">The step y.</param>
        public AnimationPreparer(System.Windows.Forms.Form formappal, Constantes Animacion, int time, int stepX, int stepY)
		{
			this.formappal = formappal;
			this.time = time;
			this.stepX = stepX;
			this.stepY = stepY;
			this.Animacion = Animacion;
		}

        /// <summary>
        /// Animations the start.
        /// </summary>
        /// <param name="coolEffect">if set to <c>true</c> [cool effect].</param>
        /// <param name="parametros">The parametros.</param>
        public void AnimationStart(bool coolEffect, object[] parametros)
		{
			AnimationStart(this.Animacion, coolEffect, parametros);
		}

        /// <summary>
        /// Animations the start.
        /// </summary>
        /// <param name="Animacion">The animacion.</param>
        /// <param name="coolEffect">if set to <c>true</c> [cool effect].</param>
        /// <param name="parametros">The parametros.</param>
        public void AnimationStart(Constantes Animacion, bool coolEffect, object[] parametros)
		{
			int paramlength;
			FormAnimations fanims;
			fanims = new FormAnimations(this.formappal, this.time, this.stepX, this.stepY);
			paramlength = parametros.Length;
			formappal.Opacity = 0;
			formappal.Visible = true;
			
			switch(Animacion)
			{
				#region Left2Right
				///Parameters:
				///P[0] posini; P[1] posfin;
				///if coolEffect is true, and paramLength < 2 the form is placed at the left side of the screen
				case Constantes.Left2Right:
					if (coolEffect && paramlength >= 2)
						formappal.Opacity = 1;

					if (paramlength == 2)
						fanims.Left2Right((int)parametros[0], (int)parametros[1]);
					if (paramlength == 0)
					{
						if (!coolEffect)
							fanims.Left2Right();
						else
						{
							this.formappal.Left=-formappal.Width;
							this.formappal.Opacity = 1;
							fanims.Left2Right();
						}
					}
					if (paramlength == 1)
					{
						if (!coolEffect)
							fanims.Left2Right((int)parametros[0]);
						else
						{
							formappal.Left=-formappal.Width;
							this.formappal.Opacity = 1;
							fanims.Left2Right((int)parametros[0]);
						}
					}
				break;
				#endregion

				#region Right2Left
				///Parameters:
				///P[0] posini; P[1] posfin;
				///if coolEffect is true, and paramLength < 2 the form is placed at the right side of the screen
				case Constantes.Right2Left:
					if (coolEffect && paramlength >= 2)
						this.formappal.Opacity = 1;

					if (paramlength == 2)
						fanims.Right2Left((int)parametros[0], (int)parametros[1]);
					if (paramlength == 0)
					{
						if (!coolEffect)
							fanims.Right2Left();
						else
						{						
							this.formappal.Left=Screen.PrimaryScreen.WorkingArea.Width;
							this.formappal.Opacity = 1;
							fanims.Right2Left();
						}
					}
					if (paramlength == 1)
					{
						if (!coolEffect)
							fanims.Right2Left((int)parametros[0]);
						else
						{
							formappal.Left=Screen.PrimaryScreen.WorkingArea.Width;
							this.formappal.Opacity = 1;
							fanims.Right2Left((int)parametros[0]);
						}
					}
				break;
				#endregion

				#region Top2Bottom
				///Parameters:
				///P[0] posini; P[1] posfin;
				///if coolEffect is true, and paramLength < 2 the form is placed at the top side of the screen
				case Constantes.Top2Bottom:
					if (coolEffect && paramlength >= 2)
						this.formappal.Opacity = 1;

					if (paramlength == 2)
						fanims.Top2Bottom((int)parametros[0], (int)parametros[1]);
					if (paramlength == 0)
					{
						if (!coolEffect)
							fanims.Top2Bottom();
						else
						{
							this.formappal.Top=-formappal.Height;
							this.formappal.Opacity = 1;
							fanims.Top2Bottom();
						}
					}
					if (paramlength == 1)
					{
						if (!coolEffect)
							fanims.Top2Bottom((int)parametros[0]);
						else
						{
							this.formappal.Top=-formappal.Height;
							this.formappal.Opacity = 1;
							fanims.Top2Bottom((int)parametros[0]);
						}
					}
				break;
				#endregion 

				#region Bottom2Top
				///Parameters:
				///P[0] posini; P[1] posfin;
				///if coolEffect is true, and paramLength < 2 the form is placed at the bottom side of the screen
				case Constantes.Bottom2Top:
					if (coolEffect && paramlength >= 2)
						this.formappal.Opacity = 1;

					if (paramlength == 2)
						fanims.Bottom2Top((int)parametros[0], (int)parametros[1]);
					if (paramlength == 0)
					{
						if (!coolEffect)
							fanims.Bottom2Top();
						else
						{
							this.formappal.Top=Screen.PrimaryScreen.WorkingArea.Height;
							this.formappal.Opacity = 1;
							fanims.Bottom2Top();
						}
					}
					if (paramlength == 1)
					{
						if (!coolEffect)
							fanims.Bottom2Top((int)parametros[0]);
						else
						{
							this.formappal.Top=Screen.PrimaryScreen.WorkingArea.Height;
							this.formappal.Opacity = 1;
							fanims.Bottom2Top((int)parametros[0]);
						}
					}
					break;
					#endregion 

				#region FadeIn
				///Parameters:
				///P[0] initial transparent percentage; P[1] opacity step;
				///if coolEffect is not important for this animation.
				case Constantes.FadeIn:
					fanims = new FormAnimations(this.formappal, 50);
					//The time used for animations might be smaller but for a smooth FadeIn this time is good.
					if (paramlength == 2)
					{ 
						formappal.Opacity = (Double.Parse(parametros[0].ToString())+1)/100;
						fanims.FadeIn(Double.Parse(parametros[0].ToString()), (int)parametros[1]);
					}
					if (paramlength == 0)
					{
						formappal.Opacity = 0;
						fanims.FadeIn();
					}
					break;
				#endregion 

				#region FadeOut
				///Parameters:
				///P[0] initial transparent percentage; P[1] opacity step;
				///if coolEffect is not important for this animation.
				case Constantes.FadeOut:
					fanims = new FormAnimations(this.formappal, 50);					
					//The time used for animations might be smaller but for a smooth FadeOut this time is good.
					if (paramlength == 2)
					{ 
						formappal.Opacity = (Double.Parse(parametros[0].ToString())+1)/100;
						fanims.FadeOut(Double.Parse(parametros[0].ToString()), (int)parametros[1]);
					}
					if (paramlength == 0)
					{
						formappal.Opacity = 1;
						fanims.FadeOut();
					}
					break;
				#endregion 

			}
			this.formappal.Refresh();
		}
	}
}
