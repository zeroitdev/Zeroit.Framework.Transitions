// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-04-2018
// ***********************************************************************
// <copyright file="FormAnimations.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Zeroit.Framework.Transitions.ZeroitFormAnimator
{
    /// <summary>
    /// Descripción breve de FormAnimations.
    /// </summary>
    public class FormAnimations
	{
        /// <summary>
        /// The formappal
        /// </summary>
        private System.Windows.Forms.Form formappal; //Form that will be animated.
                                                     /// <summary>
                                                     /// Remember that the eye must see 24 frames per second for a smooth animation,
                                                     /// this means that the maximum time used must be below 1/24 x 1000 msecs =&gt; 41
                                                     /// </summary>
        private int time; //Time in ms between stepX and/or stepY
                          /// <summary>
                          /// The step x
                          /// </summary>
        private int stepX; //Number of pixels that the form will move every 'time' (ms) in the X-axis
                           /// <summary>
                           /// The step y
                           /// </summary>
        private int stepY; //Number of pixels that the form will move every 'time' (ms) in the Y-axis

        /// <summary>
        /// Initializes a new instance of the <see cref="FormAnimations"/> class.
        /// </summary>
        /// <param name="formappal">The formappal.</param>
        public FormAnimations(System.Windows.Forms.Form formappal):this(formappal, 25)
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="FormAnimations"/> class.
        /// </summary>
        /// <param name="formappal">The formappal.</param>
        /// <param name="time">The time.</param>
        public FormAnimations(System.Windows.Forms.Form formappal, int time):this(formappal, time, 5, 5)
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="FormAnimations"/> class.
        /// </summary>
        /// <param name="formappal">The formappal.</param>
        /// <param name="time">The time.</param>
        /// <param name="stepX">The step x.</param>
        /// <param name="stepY">The step y.</param>
        public FormAnimations(System.Windows.Forms.Form formappal, int time, int stepX, int stepY)
		{
			this.formappal = formappal;
			this.time = time;
			this.stepX = stepX;
			this.stepY = stepY;
		}


        #region Métodos Left2Right
        // Left2Right methods allow you to move the specified form from Left to Right.
        // 3 Methods are available.

        /// <summary>
        /// Moves the form from its current point to the right area of the screen.
        /// </summary>
        /// <remarks>This method doesn't work if the form is maximized.
        /// This method doesn't work if the final point formappal.Left&gt;posfinal</remarks>
        public void Left2Right()
		{
			Left2Right(Screen.PrimaryScreen.WorkingArea.Right-formappal.Width);
		}

        /// <summary>
        /// Moves the form from its current point to posfinal.
        /// </summary>
        /// <param name="posfinal">Final Position</param>
        /// <remarks>This method doesn't work if the form is maximized.
        /// This method doesn't work if the final point formappal.Left&gt;posfinal</remarks>
        public void Left2Right(int posfinal)
		{
			if (formappal.WindowState == FormWindowState.Maximized || formappal.WindowState == FormWindowState.Minimized)
				return;
			
			while(formappal.Left<posfinal)
			{
				formappal.Left += stepX;
				System.Threading.Thread.Sleep(time);
				formappal.Update();
			}
			if ((formappal.Left - posfinal)<stepX) 
				formappal.Left = posfinal;				

			formappal.Refresh();
		}

        /// <summary>
        /// Moves the form Left2Right, from posinicial to posfinal.
        /// </summary>
        /// <param name="posinicial">Initial position</param>
        /// <param name="posfinal">Final Position</param>
        /// <remarks>This method doesn't work if the form is maximized.
        /// This method doesn't work if the final point formappal.Left&gt;posfinal</remarks>
        public void Left2Right(int posinicial, int posfinal)
		{
			if (posfinal>=formappal.Left && posfinal>posinicial)
			{
				formappal.Left = posinicial;
				Left2Right(posfinal);
			}
		}


        #endregion

        #region Métodos Right2Left
        // Right2Left methods allow you to move the specified form from Right to Left.
        // 3 Methods are available.


        /// <summary>
        /// Right2s the left.
        /// </summary>
        public void Right2Left()
		{
			Right2Left(0);
		}

        /// <summary>
        /// Right2s the left.
        /// </summary>
        /// <param name="posfinal">The posfinal.</param>
        public void Right2Left(int posfinal)
		{
			if (formappal.WindowState == FormWindowState.Maximized || formappal.WindowState == FormWindowState.Minimized)
				return;
			
			while(formappal.Left>posfinal)
			{
				formappal.Left -= stepX;
				System.Threading.Thread.Sleep(time);
				formappal.Update();
			}
			if ((posfinal - formappal.Left)<stepX) 
				formappal.Left = posfinal;

			formappal.Refresh();
		}

        /// <summary>
        /// Right2s the left.
        /// </summary>
        /// <param name="posinicial">The posinicial.</param>
        /// <param name="posfinal">The posfinal.</param>
        public void Right2Left(int posinicial, int posfinal)
		{
			if (posfinal<posinicial && posfinal<formappal.Left)
			{
				formappal.Left = posinicial;
				Right2Left(posfinal);
			}
		}


        #endregion

        #region Métodos Top2Bottom
        // Top2Bottom methods allow you to move the specified form from Top to Bottom.
        // 3 Methods are available.	

        /// <summary>
        /// Moves the form from its current point to the bottom area of the screen.
        /// </summary>
        /// <remarks>This method doesn't work if the form is maximized.
        /// This method doesn't work if the final point formappal.Top&gt;posfinal</remarks>
        public void Top2Bottom()
		{
			Top2Bottom(Screen.PrimaryScreen.WorkingArea.Height-formappal.Height);
		}

        /// <summary>
        /// Moves the form from its current point to posfinal.
        /// </summary>
        /// <param name="posfinal">Final Position</param>
        /// <remarks>This method doesn't work if the form is maximized.
        /// This method doesn't work if the final point formappal.Top&gt;posfinal</remarks>
        public void Top2Bottom(int posfinal)
		{
			if (formappal.WindowState == FormWindowState.Maximized || formappal.WindowState == FormWindowState.Minimized)
				return;
			
			while(formappal.Top<posfinal)
			{
				formappal.Top += stepY;
				System.Threading.Thread.Sleep(time);
				formappal.Update();
			}

			if ((formappal.Top - posfinal)<stepY) 
				formappal.Top = posfinal;

			formappal.Refresh();
			
		}

        /// <summary>
        /// Moves the form Top2Bottom from posinicial to posfinal.
        /// </summary>
        /// <param name="posinicial">Initial Position</param>
        /// <param name="posfinal">Final Position</param>
        /// <remarks>This method doesn't work if the form is maximized.
        /// This method doesn't work if the final point formappal.Top&gt;posfinal</remarks>
        public void Top2Bottom(int posinicial, int posfinal)
		{
			if (posinicial<posfinal && posfinal>formappal.Top)
			{
				formappal.Top = posinicial;
				Top2Bottom(posfinal);
			}
		}


        #endregion

        #region Métodos Bottom2Top
        // Bottom2Top methods allow you to move the specified form from Bottom to Top.
        // 3 Methods are available.

        /// <summary>
        /// Bottom2s the top.
        /// </summary>
        public void Bottom2Top()
		{
			Bottom2Top(0);
		}

        /// <summary>
        /// Bottom2s the top.
        /// </summary>
        /// <param name="posfinal">The posfinal.</param>
        public void Bottom2Top(int posfinal)
		{
			if (formappal.WindowState == FormWindowState.Maximized || formappal.WindowState == FormWindowState.Minimized)
				return;
			
			while(formappal.Top>posfinal)
			{
				formappal.Top -= stepY;
				System.Threading.Thread.Sleep(time);
				formappal.Update();
			}
			if ((posfinal - formappal.Top)<stepY) 
				formappal.Top = posfinal;

			formappal.Refresh();
		}

        /// <summary>
        /// Bottom2s the top.
        /// </summary>
        /// <param name="posinicial">The posinicial.</param>
        /// <param name="posfinal">The posfinal.</param>
        public void Bottom2Top(int posinicial, int posfinal)
		{
			if (posinicial>posfinal && posfinal<formappal.Top)
			{
				formappal.Top = posinicial;
				Bottom2Top(posfinal);
			}
		}


        #endregion

        #region Métodos FadeIn
        // FadeIn methods show a (semi)transparent form turning to opaque.
        // This method could also be known as Transparent2Opaque
        // 2 Methods are available.

        /// <summary>
        /// Fades in the form from 0 oppacity to 1.
        /// </summary>
        /// <remarks>This methods only work in WinXP and Win2000</remarks>
        public void FadeIn()
		{
         	FadeIn(0, 5);
		}

        /// <summary>
        /// Fades in the form from initpercent oppacity to 1.
        /// </summary>
        /// <param name="initpercent">Form's initial opacitity</param>
        /// <param name="opacitystep">Steps between transparency to opacity</param>
        /// <remarks>This methods only work in WinXP and Win2000</remarks>
        public void FadeIn(double initpercent, int opacitystep)
		{
			if (initpercent > 95)
				return;
			
			formappal.Opacity = (double)(initpercent+1)/100;
			formappal.Update();
			while(formappal.Opacity < 1)
			{
				System.Threading.Thread.Sleep(time);
				formappal.Opacity += (double)opacitystep/100;
			}
			System.Threading.Thread.Sleep(time);
			formappal.Refresh();
		}


        #endregion

        #region Métodos FadeOut
        // FadeOut methods show an opaque form turning transparent.
        // This method could also be known as Opaque2Transparent.
        // 2 Methods are available.

        /// <summary>
        /// Fades out the form from 1 oppacity to 0.
        /// </summary>
        /// <remarks>This methods only work in WinXP and Win2000</remarks>
        public void FadeOut()
		{
			FadeOut(100, 5);
		}

        /// <summary>
        /// Fades in the form from initpercent oppacity to 1.
        /// </summary>
        /// <param name="initpercent">Form's initial opacitity</param>
        /// <param name="opacitystep">Steps between opacity to transparency</param>
        /// <remarks>This methods only work in WinXP and Win2000</remarks>
        public void FadeOut(double initpercent, int opacitystep)
		{
			if (initpercent < 5)
				return;
			
			formappal.Opacity = (double)(initpercent-1)/100;
			formappal.Update();
			while(formappal.Opacity > 0.05)
			{
				System.Threading.Thread.Sleep(time);
				formappal.Opacity -= (double)opacitystep/100;
			}
			System.Threading.Thread.Sleep(time);
			formappal.Refresh();
		}


        #endregion

        #region Métodos HideControls
        // HideControls methods allow you to hide each form control.
        // Static methods hide all the form's controls.
        // <remarks>
        // Apparently the order is controlled by the Form.Controls.Add(control);
        // The first control added to the form is the first hidden.
        // Be sure to test this method, .NET might change the index of the controls after
        // Visible property is changed.
        // </remarks>

        /// <summary>
        /// Hides the controls given by the ids int array.
        /// </summary>
        /// <param name="ids">Int array that contains the index of the controls that will be hidden.</param>
        /// <param name="timer">Time in ms taken to switch off each of the specified controls.</param>
        public void HideControls(int[] ids, int timer)
		{
			for (int i=0; i<ids.Length; i++)
			{
				formappal.Update();
				System.Threading.Thread.Sleep(timer);
				if (ids[i]<formappal.Controls.Count)
					formappal.Controls[ids[i]].Visible = false;
			}
		}


        /// <summary>
        /// Hides the controls given by the ids int array.
        /// </summary>
        /// <param name="ids">Int array that contains the index of the controls that will be hidden.</param>
        /// <remarks>This method uses the time given in the constructor.</remarks>
        public void HideControls(int[] ids)
		{
			HideControls(ids, time);
		}

        /// <summary>
        /// Hides all the controls in the form.
        /// </summary>
        /// <param name="formappal">Form with the controls.</param>
        /// <param name="timer">The timer.</param>
        public static void HideControls(System.Windows.Forms.Form formappal, int timer)
		{
			HideControls(formappal, timer, true);
		}

        /// <summary>
        /// Hides all the controls in the form.
        /// </summary>
        /// <param name="formappal">Form with the controls</param>
        /// <param name="timer">Time in ms to hide each of the form's controls.</param>
        /// <param name="Ida">If Ida=true it determinates if the hiding of the controls
        /// will start with the firts control added, if Ida=false, it will start with the last one added.</param>
        public static void HideControls(System.Windows.Forms.Form formappal, int timer, bool Ida)
		{
			if (Ida)
			{ //Starts from the first form control
				for (int i=0; i<formappal.Controls.Count; i++)
				{
					formappal.Update();
					System.Threading.Thread.Sleep(timer);
					formappal.Controls[i].Visible = false;
				}
			}
			else
			{ //Starts from the last form control
				for (int i=formappal.Controls.Count-1; i>0; i--)
				{
					formappal.Update();
					System.Threading.Thread.Sleep(timer);
					formappal.Controls[i].Visible = false;
				}
			}
		}

        #endregion

        #region Métodos ShowControls
        // ShowControls methods allow you to show each form control.
        // The form controls should be hidden first.
        // Static methods show all the form's controls.
        // <remarks>
        // Apparently the order is controlled by the Form.Controls.Add(control);
        // The first control added to the form is the first shown.
        // Be sure to test this method, .NET might change the index of the controls after
        // Visible property is changed.
        // </remarks>


        /// <summary>
        /// Shows the controls given by the ids int array.
        /// </summary>
        /// <param name="ids">Int array that contains the index of the controls that will be shown.</param>
        /// <param name="timer">Time in ms taken to switch on each of the specified controls.</param>
        public void ShowControls(int[] ids, int timer)
		{
			for (int i=0; i<ids.Length; i++)
			{
				if (ids[i]<formappal.Controls.Count)
					formappal.Controls[ids[i]].Visible = true;
				System.Threading.Thread.Sleep(timer);
				formappal.Update();
			}
		}

        /// <summary>
        /// Shows all the controls in the form.
        /// </summary>
        /// <param name="ids">The ids.</param>
        public void ShowControls(int[] ids)
		{
			ShowControls(ids, time);
		}

        /// <summary>
        /// Shows all the controls in the form.
        /// </summary>
        /// <param name="formappal">Form with the controls.</param>
        public static void ShowControls(System.Windows.Forms.Form formappal)
		{
			ShowControls(formappal, 50, true);
		}


        /// <summary>
        /// Shows all the controls in the form.
        /// </summary>
        /// <param name="formappal">Form with the controls</param>
        /// <param name="timer">Time in ms to show each of the form's controls.</param>
        /// <param name="Ida">If Ida=true it determinates if the showing of the controls
        /// will start with the firts control added, if Ida=false, it will start with the last one added.</param>
        public static void ShowControls(System.Windows.Forms.Form formappal, int timer, bool Ida)
		{
			if (Ida)
			{  //Starts from the first form control
				System.Threading.Thread.Sleep(timer);
				formappal.Controls[0].Visible = true;
				for (int i=1; i<formappal.Controls.Count; i++)
				{
					System.Threading.Thread.Sleep(timer);
					formappal.Update();
					formappal.Controls[i].Visible = true;
				}
			}
			else
			{  //Starts from the last form control
				for (int i=formappal.Controls.Count-1; i>0; i--)
				{
					formappal.Update();
					System.Threading.Thread.Sleep(timer);
					formappal.Controls[i].Visible = true;
				}
			}
		}


        #endregion

        #region Metodos GrowHorizontal
        /// <summary>
        /// GrowHorizontal methods stretch the form in the X-axis.
        /// 6 methods are available.
        /// </summary>
        /// <remarks>If Fix is used the form will limit its growth within the screen's limits.
        /// Fix default value: true;</remarks>


        public void GrowHorizontal()
		{	
			GrowHorizontal(Screen.PrimaryScreen.WorkingArea.Width);
		}

        /// <summary>
        /// Grows the horizontal.
        /// </summary>
        /// <param name="Fix">if set to <c>true</c> [fix].</param>
        public void GrowHorizontal(bool Fix)
		{	
			GrowHorizontal(Screen.PrimaryScreen.WorkingArea.Width, Fix);
		}

        /// <summary>
        /// Grows the horizontal.
        /// </summary>
        /// <param name="posfinal">The posfinal.</param>
        public void GrowHorizontal(int posfinal)
		{		
			GrowHorizontal(posfinal, true);
		}

        /// <summary>
        /// Grows the horizontal.
        /// </summary>
        /// <param name="posfinal">The posfinal.</param>
        /// <param name="Fix">if set to <c>true</c> [fix].</param>
        public void GrowHorizontal(int posfinal, bool Fix)
		{		
			int width;

			if (formappal.WindowState == FormWindowState.Maximized || formappal.WindowState == FormWindowState.Minimized)
				return;

			while(formappal.Width<posfinal)
			{
				formappal.Width += stepX;
				if (formappal.Left + formappal.Width>Screen.PrimaryScreen.WorkingArea.Width && Fix)
					formappal.Left -= stepX;

				width = formappal.Width;
				formappal.Width += stepX;
				if (width == formappal.Width)
					break;

				System.Threading.Thread.Sleep(time);
				formappal.Update();
			}
			if ((formappal.Width - posfinal) < stepX && (formappal.Width - posfinal)>0)
				formappal.Width = posfinal;

			if (Fix)
			{
				while(formappal.Left>0)
				{
					formappal.Left -= stepX;
					System.Threading.Thread.Sleep(time);
				}
				while(formappal.Left<0)
				{
					formappal.Left += stepX;
					System.Threading.Thread.Sleep(time);
				}
				formappal.Left = 0;
			}
			formappal.Refresh();
		}

        /// <summary>
        /// Grows the horizontal.
        /// </summary>
        /// <param name="posinicial">The posinicial.</param>
        /// <param name="posfinal">The posfinal.</param>
        public void GrowHorizontal(int posinicial, int posfinal)
		{
			formappal.Width = posinicial;
			GrowHorizontal(posfinal, true);
		}

        /// <summary>
        /// Grows the horizontal.
        /// </summary>
        /// <param name="posinicial">The posinicial.</param>
        /// <param name="posfinal">The posfinal.</param>
        /// <param name="Fix">if set to <c>true</c> [fix].</param>
        public void GrowHorizontal(int posinicial, int posfinal, bool Fix)
		{
			formappal.Width = posinicial;
			GrowHorizontal(posfinal, Fix);
		}


        #endregion

        #region Métodos GrowVertical
        /// <summary>
        /// GrowVertical methods stretch the form in the Y-axis.
        /// 6 methods are available.
        /// </summary>
        /// <remarks>If Fix is used the form will limit its growth within the screen's limits.
        /// Fix default value: true;</remarks>

        public void GrowVertical()
		{	
			GrowVertical(Screen.PrimaryScreen.WorkingArea.Height);
		}

        /// <summary>
        /// Grows the vertical.
        /// </summary>
        /// <param name="Fix">if set to <c>true</c> [fix].</param>
        public void GrowVertical(bool Fix)
		{	
			GrowVertical(Screen.PrimaryScreen.WorkingArea.Height, Fix);
		}

        /// <summary>
        /// Grows the vertical.
        /// </summary>
        /// <param name="posfinal">The posfinal.</param>
        public void GrowVertical(int posfinal)
		{		
			GrowVertical(posfinal, true);
		}

        /// <summary>
        /// Grows the vertical.
        /// </summary>
        /// <param name="posfinal">The posfinal.</param>
        /// <param name="Fix">if set to <c>true</c> [fix].</param>
        public void GrowVertical(int posfinal, bool Fix)
		{		
			int height;

			if (formappal.WindowState == FormWindowState.Maximized || formappal.WindowState == FormWindowState.Minimized)
				return;

			while(formappal.Height<posfinal)
			{
				if (formappal.Top + formappal.Height>Screen.PrimaryScreen.WorkingArea.Height && Fix)
					formappal.Top -= stepY;

				height = formappal.Height;
				formappal.Height += stepY;
				if (height == formappal.Height)
					break;

				System.Threading.Thread.Sleep(time);
				formappal.Update();
			}
			if ((formappal.Height - posfinal) < stepY && (formappal.Height - posfinal)>0)
				formappal.Height = posfinal;

			if (Fix)
			{
				while(formappal.Top>0)
				{
					formappal.Top -= stepY;
					System.Threading.Thread.Sleep(time);
				}
				while(formappal.Top<0)
				{
					formappal.Top += stepY;
					System.Threading.Thread.Sleep(time);
				}
				formappal.Top = 0;
			}
			formappal.Refresh();
		}

        /// <summary>
        /// Grows the vertical.
        /// </summary>
        /// <param name="posinicial">The posinicial.</param>
        /// <param name="posfinal">The posfinal.</param>
        public void GrowVertical(int posinicial, int posfinal)
		{
			formappal.Height = posinicial;
			GrowVertical(posfinal, true);
		}

        /// <summary>
        /// Grows the vertical.
        /// </summary>
        /// <param name="posinicial">The posinicial.</param>
        /// <param name="posfinal">The posfinal.</param>
        /// <param name="Fix">if set to <c>true</c> [fix].</param>
        public void GrowVertical(int posinicial, int posfinal, bool Fix)
		{
			formappal.Height = posinicial;
			GrowVertical(posfinal, Fix);
		}


        #endregion

        #region Métodos ShrinkHorizontal
        /// <summary>
        /// ShrinkHorizontal methods shrink the form in the X-axis.
        /// 3 methods are available.
        /// </summary>


        public void ShrinkHorizontal()
		{	
			ShrinkHorizontal(stepX);
		}

        /// <summary>
        /// Shrinks the horizontal.
        /// </summary>
        /// <param name="posfinal">The posfinal.</param>
        public void ShrinkHorizontal(int posfinal)
		{	
			int width;

			if (formappal.WindowState == FormWindowState.Maximized || formappal.WindowState == FormWindowState.Minimized)
				return;

			while(formappal.Width>posfinal)
			{
				width = formappal.Width;
				formappal.Width -= stepX;
				if (width == formappal.Width)
					break;
				System.Threading.Thread.Sleep(time);
				formappal.Update();
			}
			if ((posfinal - formappal.Width)<stepX)
				formappal.Width = posfinal;

			formappal.Refresh();
		}

        /// <summary>
        /// Shrinks the horizontal.
        /// </summary>
        /// <param name="posinicial">The posinicial.</param>
        /// <param name="posfinal">The posfinal.</param>
        public void ShrinkHorizontal(int posinicial, int posfinal)
		{
			formappal.Width = posinicial;
			ShrinkHorizontal(posfinal);
		}


        #endregion

        #region Métodos ShrinkVertical
        /// <summary>
        /// ShrinkVertical methods shrink the form in the Y-axis.
        /// 3 methods are available.
        /// </summary>


        public void ShrinkVertical()
		{	
			ShrinkVertical(stepY);
		}

        /// <summary>
        /// Shrinks the vertical.
        /// </summary>
        /// <param name="posfinal">The posfinal.</param>
        public void ShrinkVertical(int posfinal)
		{		
			int height;

			if (formappal.WindowState == FormWindowState.Maximized || formappal.WindowState == FormWindowState.Minimized)
				return;

			while(formappal.Height>posfinal)
			{
				height = formappal.Height;
				formappal.Height -= stepY;
				if (height == formappal.Height)
					break;

				System.Threading.Thread.Sleep(time);
				formappal.Update();
			}
			if ((posfinal - formappal.Height)<stepY)
				formappal.Height = posfinal;	

			formappal.Refresh();
		}

        /// <summary>
        /// Shrinks the vertical.
        /// </summary>
        /// <param name="posinicial">The posinicial.</param>
        /// <param name="posfinal">The posfinal.</param>
        public void ShrinkVertical(int posinicial, int posfinal)
		{
			formappal.Height = posinicial;
			ShrinkVertical(posfinal);
		}


        #endregion

        #region Métodos GrowXY
        /// <summary>
        /// Grows the xy.
        /// </summary>


        public void GrowXY()
		{	
			GrowXY(new Point (Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height));
		}

        /// <summary>
        /// Grows the xy.
        /// </summary>
        /// <param name="Fix">if set to <c>true</c> [fix].</param>
        public void GrowXY(bool Fix)
		{	
			GrowXY(new Point (Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height), Fix);
		}

        /// <summary>
        /// Grows the xy.
        /// </summary>
        /// <param name="posfinal">The posfinal.</param>
        public void GrowXY(Point posfinal)
		{	
			GrowXY(posfinal, true);
		}

        /// <summary>
        /// Grows the xy.
        /// </summary>
        /// <param name="posfinal">The posfinal.</param>
        /// <param name="Fix">if set to <c>true</c> [fix].</param>
        public void GrowXY(Point posfinal, bool Fix)
		{		
			int height;
			int width;

			if (formappal.WindowState == FormWindowState.Maximized || formappal.WindowState == FormWindowState.Minimized)
				return;

			while(formappal.Width<posfinal.X || formappal.Height<posfinal.Y)
			{
				height = formappal.Height;		
				width = formappal.Width;
				if (formappal.Height<posfinal.Y)
				{
					formappal.Height += stepY;
					if (formappal.Top + formappal.Height>Screen.PrimaryScreen.Bounds.Height && Fix)
						formappal.Top -= stepY;

					if (height == formappal.Height)
						break;
				}

				if (formappal.Width<posfinal.X)
				{
					formappal.Width += stepX;
					if (formappal.Left + formappal.Width>Screen.PrimaryScreen.Bounds.Width && Fix)
						formappal.Left -= stepX;

					if (width == formappal.Width)
						break;
				}
				System.Threading.Thread.Sleep(time);
				formappal.Update();
			}

			if ((formappal.Height - posfinal.Y) < stepY)
				formappal.Height = posfinal.Y;
			if ((formappal.Width - posfinal.X) < stepX)
				formappal.Width = posfinal.X;
			
			if (Fix)
			{
				while(formappal.Left>0 || formappal.Top>0)
				{
					if (formappal.Left>0)
						formappal.Left -= stepX;
					if (formappal.Top>0)
						formappal.Top -= stepY;
					System.Threading.Thread.Sleep(time);
				}
				while(formappal.Left<0 ||  formappal.Top<0)
				{
					if (formappal.Left<0)
						formappal.Left += stepX;
					if (formappal.Top<0)
						formappal.Top += stepY;
					System.Threading.Thread.Sleep(time);
				}
				formappal.Left = 0;
				formappal.Top = 0;
			}

			formappal.Refresh();
		}

        /// <summary>
        /// Grows the xy.
        /// </summary>
        /// <param name="posinicial">The posinicial.</param>
        /// <param name="posfinal">The posfinal.</param>
        public void GrowXY(Point posinicial, Point posfinal)
		{
			formappal.Width = posinicial.X;
			formappal.Height= posinicial.Y;
			GrowXY(posfinal, true);
		}

        /// <summary>
        /// Grows the xy.
        /// </summary>
        /// <param name="posinicial">The posinicial.</param>
        /// <param name="posfinal">The posfinal.</param>
        /// <param name="Fix">if set to <c>true</c> [fix].</param>
        public void GrowXY(Point posinicial, Point posfinal, bool Fix)
		{
			formappal.Width = posinicial.X;
			formappal.Height= posinicial.Y;
			GrowXY(posfinal, Fix);
		}


        #endregion

        #region Métodos ShrinkXY
        /// <summary>
        /// Shrinks the xy.
        /// </summary>


        public void ShrinkXY()
		{	
			ShrinkXY(new Point(stepX, stepY));
		}

        /// <summary>
        /// Shrinks the xy.
        /// </summary>
        /// <param name="posfinal">The posfinal.</param>
        public void ShrinkXY(Point posfinal)
		{		
			int height;
			int width;

			if (formappal.WindowState == FormWindowState.Maximized || formappal.WindowState == FormWindowState.Minimized)
				return;

			while(formappal.Height>posfinal.Y || formappal.Width>posfinal.X)
			{
				height = formappal.Height;
				width = formappal.Width;
				formappal.Height -= stepY;
				formappal.Width -= stepX;
				if (height == formappal.Height && width == formappal.Width)
					break;

				System.Threading.Thread.Sleep(time);
				formappal.Update();
			}
			if (formappal.Height < posfinal.Y)
				formappal.Height = posfinal.Y;
			if (formappal.Width < posfinal.X)
				formappal.Width = posfinal.X;

			formappal.Refresh();
		}

        /// <summary>
        /// Shrinks the xy.
        /// </summary>
        /// <param name="posinicial">The posinicial.</param>
        /// <param name="posfinal">The posfinal.</param>
        public void ShrinkXY(Point posinicial, Point posfinal)
		{
			formappal.Width = posinicial.X;
			formappal.Height= posinicial.Y;
			ShrinkXY(posfinal);
		}


        #endregion

        #region Métodos GrowMoveXY
        /// <summary>
        /// Grows the move xy.
        /// </summary>
        /// <param name="recalculate">if set to <c>true</c> [recalculate].</param>


        public void GrowMoveXY(bool recalculate)
		{ //For best effect place the form in center screen.
			GrowMoveXY(formappal.Location, recalculate);
		}

        /// <summary>
        /// Grows the move xy.
        /// </summary>
        /// <param name="posinicial">The posinicial.</param>
        /// <param name="recalculate">if set to <c>true</c> [recalculate].</param>
        public void GrowMoveXY(Point posinicial, bool recalculate)
		{	
			int stepW, stepH, tempo;
			if (formappal.WindowState == FormWindowState.Maximized || formappal.WindowState == FormWindowState.Minimized)
				return;

			formappal.Location = posinicial;
			//Recalculo de stepX y stepY
			if (recalculate)
			{
				stepY = 5;
				tempo = posinicial.Y/stepY;
				
				if (tempo!=0)
				{
					stepX = ((posinicial.X)/(tempo));
					stepH = (Screen.PrimaryScreen.WorkingArea.Height - (this.formappal.Top + this.formappal.Height))/(tempo);
					stepW = (Screen.PrimaryScreen.WorkingArea.Width -(this.formappal.Left + this.formappal.Width))/(tempo);
				}
				else
				{
					stepH = 1;
					stepW = 1;
				}
			}
			else
			{
				stepW = stepX/2;
				stepH = stepY/2;
			}

			while((formappal.Top)>0 && (formappal.Left)>0)
			{
				if (formappal.Top>0)
				{
					formappal.Top -= stepY;
					formappal.Height += (stepH + stepY);
				}
				if (formappal.Left>0)
				{
					formappal.Left -= stepX;
					formappal.Width += (stepW + stepX);
				}
				System.Threading.Thread.Sleep(time);
				formappal.Update();
			}

			if (recalculate)
			{
				if (stepX == 0) stepX = 5;
				GrowXY();
				formappal.Update();
			}

			formappal.Refresh();
		}

        /// <summary>
        /// Grows the move xy.
        /// </summary>
        /// <param name="posinicial">The posinicial.</param>
        /// <param name="sizeinicial">The sizeinicial.</param>
        /// <param name="recalculate">if set to <c>true</c> [recalculate].</param>
        public void GrowMoveXY(Point posinicial, Size sizeinicial, bool recalculate)
		{
			formappal.Width = sizeinicial.Width;
			formappal.Height= sizeinicial.Height;
			GrowMoveXY(posinicial, recalculate);
		}


        #endregion

        #region Métodos ShrinkMoveXY
        /// <summary>
        /// Shrinks the move xy.
        /// </summary>
        /// <param name="recalculate">if set to <c>true</c> [recalculate].</param>


        public void ShrinkMoveXY(bool recalculate)
		{ 
			ShrinkMoveXY(formappal.Location, recalculate);
		}

        /// <summary>
        /// Shrinks the move xy.
        /// </summary>
        /// <param name="posinicial">The posinicial.</param>
        /// <param name="recalculate">if set to <c>true</c> [recalculate].</param>
        public void ShrinkMoveXY(Point posinicial, bool recalculate)
		{	
			Point centerScreen = DeterminarPos(Constantes.CenterScreen);
			
			int stepW, stepH, tempo, height, width;
			if (formappal.WindowState == FormWindowState.Maximized || formappal.WindowState == FormWindowState.Minimized)
				return;

			formappal.Location = posinicial;
			//Recalculo de stepX y stepY
			if (recalculate)
			{
				stepY = 5;
				tempo = (posinicial.Y - centerScreen.Y)/stepY;
				if (formappal.Top < centerScreen.Y)
				{ //La forma esta en la mitad superior 
					tempo = -tempo;
				}
				if (tempo != 0)
				{
					stepX = ((posinicial.X - centerScreen.X)/(tempo));
					stepH = (this.formappal.Height)/(tempo);
					stepW = (this.formappal.Width)/(tempo);
				}
				else
				{
					if (formappal.Left < centerScreen.X)
						stepX = -5;
					else
						stepX = 5;

					stepH = 5;
					stepW = 5;
				}

				if (formappal.Left < centerScreen.X)
				{ //La forma esta en la mitad izquierda
					stepX = -stepX;	
				}

				while((formappal.Height)>0 && (formappal.Width)>0)
				{
					if ((formappal.Top - formappal.Height/2) < centerScreen.Y)
					{ //La forma esta en la mitad superior 
						formappal.Top += (stepY + stepH);
						height = formappal.Height;
						formappal.Height -= stepH;
						if (height == formappal.Height)
							break;
					}
					else
					{
						formappal.Top -= stepY;
						height = formappal.Height;
						formappal.Height -= stepH;
						if (height == formappal.Height)
							break;
					}
					if ((formappal.Left - formappal.Width/2) < centerScreen.X)
					{ //La forma esta en la mitad izquierda
						formappal.Left += (stepX + stepW);
						width = formappal.Width;
						formappal.Width -= stepW;
						if (width == formappal.Width)
							break;
					}
					else
					{
						formappal.Left -= stepX;
						width = formappal.Width;
						formappal.Width -= stepW;
						if (width == formappal.Width)
							break;
					}

					System.Threading.Thread.Sleep(time);
					formappal.Update();
				}
			}
			else
			{
				stepW = 2*stepX;
				stepH = 2*stepY;
				while((formappal.Height)>0 && (formappal.Width)>0)
				{
					formappal.Top += stepY;
					height = formappal.Height;
					formappal.Height -= stepH;
					if (height == formappal.Height)
						break;

					formappal.Left += stepX;
					width = formappal.Width;
					formappal.Width -= stepW;
					if (width == formappal.Width)
							break;

					System.Threading.Thread.Sleep(time);
					formappal.Update();
				}
				ShrinkXY();
			}
		}

        /// <summary>
        /// Shrinks the move xy.
        /// </summary>
        /// <param name="posinicial">The posinicial.</param>
        /// <param name="size">The size.</param>
        /// <param name="recalculate">if set to <c>true</c> [recalculate].</param>
        public void ShrinkMoveXY(Point posinicial, Size size, bool recalculate)
		{
			formappal.Width = size.Width;
			formappal.Height= size.Height;
			ShrinkMoveXY(posinicial, recalculate);
		}


        #endregion

        #region Métodos Move
        /// <summary>
        /// Move methods move the form from one point to another.
        /// </summary>
        /// <param name="posinicial">The posinicial.</param>
        /// <param name="posfinal">The posfinal.</param>
        /// <param name="direct">if set to <c>true</c> [direct].</param>
        /// <remarks>If direct is true stepX and stepY will be recalculated so that the form moves in a straight line
        /// towards its destination.
        /// If direct is false the form will move first in its X-axis and then in it's Y-axis towards
        /// its destination.</remarks>


        public void Move(Point posinicial, Point posfinal, bool direct)
		{		
			int tempo;
			if (formappal.WindowState == FormWindowState.Maximized || formappal.WindowState == FormWindowState.Minimized)
				return;

			formappal.Location = posinicial;
			//Recalculo de stepX y stepY
			if (direct)
			{
				stepY = 5;
				while(true)
				{
					tempo = (formappal.Top - posfinal.Y)/stepY;
					if (formappal.Top < posfinal.Y)
					{ //La forma esta arriba del punto final
						tempo = -tempo;
					}
					if (tempo != 0)
					{
						stepX = ((formappal.Left - posfinal.X)/(tempo));
					}
					else
					{
						if (formappal.Left < posfinal.X)
							stepX = -5;
						else
							stepX = 5;

					}

					if (formappal.Left < posfinal.X)
					{ 
						stepX = -stepX;	
					}

					if (formappal.Top <= posfinal.Y)
					{ //La forma esta en la mitad superior 
						formappal.Top += stepY;
						if (formappal.Top >= posfinal.Y && formappal.Left <= posfinal.X)
							break;
					}
					else
					{
						formappal.Top -= stepY;
						if (formappal.Top <= posfinal.Y && formappal.Left <= posfinal.X)
							break;
					}
					if (formappal.Left <= posfinal.X)
					{ //La forma esta en la mitad izquierda
						formappal.Left += stepX;
						if (formappal.Left >= posfinal.X && formappal.Top <= posfinal.Y)
							break;
					}
					else
					{
						formappal.Left -= stepX;
						if (formappal.Left <= posfinal.X && formappal.Top <= posfinal.Y)
							break;
					}
					System.Threading.Thread.Sleep(time);
					formappal.Update();
				}
			}
			else
			{
				if (formappal.Left <= posfinal.X)
					Left2Right(posinicial.X, posfinal.X);	
				else
					Right2Left(posinicial.X, posfinal.X);
					
				if (formappal.Top <= posfinal.Y)
					Top2Bottom(posinicial.Y, posfinal.Y);
				else
					Bottom2Top(posinicial.Y, posfinal.Y);
			}
			formappal.Refresh();
		}

        /// <summary>
        /// Moves the specified posfinal.
        /// </summary>
        /// <param name="posfinal">The posfinal.</param>
        /// <param name="direct">if set to <c>true</c> [direct].</param>
        public void Move(Point posfinal, bool direct)
		{
			Move(this.formappal.Location, posfinal, direct);
		}

        /// <summary>
        /// Moves the specified parray.
        /// </summary>
        /// <param name="parray">The parray.</param>
        public void Move (Point[] parray)
		{

		}


        #endregion

        #region Métodos ShakeIt
        // ShakeIt methods shake the form.
        // 3 methods are available.

        /// <summary>
        /// Shakes the form.
        /// </summary>
        /// <param name="rect">Rectangle that determinates the 4 points where the form will moved.</param>
        /// <param name="time">Time in ms that it shakes the form</param>
        public void ShakeIt(Rectangle rect, int time)
		{	
			Point poriginal;
			Point[] plados = new Point[4];
			plados[0] = rect.Location; //origen (izqsup)
			plados[1] = new Point(rect.Left, rect.Bottom); //Lado izqinf
			plados[2] = new Point(rect.Right, rect.Bottom); //Lado derinf
			plados[3] = new Point(rect.Right, rect.Top); //Lado dersup
	
			poriginal= this.formappal.Location;
			long dtNow = DateTime.Now.Ticks;
			int cont = 0;
			long dtLater = new DateTime(dtNow).AddMilliseconds(time).Ticks;
			//System.Diagnostics.Trace.WriteLine(DateTime.Now.ToString("ss:fff"));
			while (DateTime.Now.Ticks < dtLater)
			{
				this.formappal.Location = plados[cont];
				this.formappal.Update();
				System.Threading.Thread.Sleep(10);
				cont = (++cont)%4;
			}			
			//System.Diagnostics.Trace.WriteLine(DateTime.Now.ToString("ss:fff"));
			System.Threading.Thread.Sleep(10);
			this.formappal.Location = poriginal;
			formappal.Refresh();
	
		}

        /// <summary>
        /// Shakes the form back to p1 and forward to p2
        /// </summary>
        /// <param name="p1">Point 1</param>
        /// <param name="p2">Point 2</param>
        /// <param name="time">Time in ms that it shakes the form</param>
        public void ShakeIt(Point p1, Point p2, int time)
		{
			Point poriginal;
			poriginal= this.formappal.Location;

			long dtNow = DateTime.Now.Ticks;
			long dtLater = DateTime.Now.AddMilliseconds(time).Ticks;
			
			while (DateTime.Now.Ticks < dtLater)
			{
				this.formappal.Location = p1;
				this.formappal.Update();
				System.Threading.Thread.Sleep(10);
				this.formappal.Location = p2;
				this.formappal.Update();
				System.Threading.Thread.Sleep(10);
			}			
			System.Threading.Thread.Sleep(10);
			this.formappal.Location = poriginal;
			formappal.Refresh();
		}

        /// <summary>
        /// Shakes it.
        /// </summary>
        /// <param name="time">The time.</param>
        public void ShakeIt(int time)
		{
			ShakeIt(new Rectangle(this.formappal.Location, new Size(2*stepX, 2*stepY)), time);
		}

        #endregion

        #region Métodos DeterminarPos
        /// <summary>
        /// DeterminarPos method receives a constant declared by the Constantes enum,
        /// and it returns its true position in the screen.
        /// </summary>
        /// <param name="Posicion">The posicion.</param>
        /// <returns>Point.</returns>


        public Point DeterminarPos(Constantes Posicion)
		{
			return DeterminarPos(this.formappal, Posicion);
		}

        /// <summary>
        /// Determinars the position.
        /// </summary>
        /// <param name="formappal">The formappal.</param>
        /// <param name="Posicion">The posicion.</param>
        /// <returns>Point.</returns>
        public static Point DeterminarPos(System.Windows.Forms.Form formappal, Constantes Posicion)
		{
			int tempo;
			Point pos;
			pos = new Point((Screen.PrimaryScreen.WorkingArea.Width/2)-(formappal.Width/2),
				(Screen.PrimaryScreen.WorkingArea.Height/2)-(formappal.Height/2));
			switch (Posicion)
			{
				case Constantes.BottomCenter:
					pos.Y=Screen.PrimaryScreen.WorkingArea.Height-formappal.Height;
					break;
				case Constantes.BottomLeft:
					pos.X=0;
					pos.Y=Screen.PrimaryScreen.WorkingArea.Height-formappal.Height;
					break;
				case Constantes.BottomRight:
					pos.X=Screen.PrimaryScreen.WorkingArea.Width-formappal.Width;
					pos.Y=Screen.PrimaryScreen.WorkingArea.Height-formappal.Height;
					break;
				case Constantes.LeftCenter:
					pos.X=0;
					break;
				case Constantes.RightCenter:
					pos.X=Screen.PrimaryScreen.WorkingArea.Width-formappal.Width;
					break;
				case Constantes.TopCenter:
					pos.Y=0;
					break;
				case Constantes.TopLeft:
					pos.X=0;
					pos.Y=0;
					break;
				case Constantes.TopRight:
					pos.X=Screen.PrimaryScreen.WorkingArea.Width-formappal.Width;
					pos.Y=0;
					break;
				case Constantes.RndPoint:
					tempo =  new Random((int)DateTime.Now.Ticks + pos.X).Next(Screen.PrimaryScreen.WorkingArea.Height);
					pos.X=new Random((int)DateTime.Now.Ticks + tempo).Next(Screen.PrimaryScreen.WorkingArea.Width);
					pos.Y=new Random((int)DateTime.Now.Ticks + pos.X).Next(Screen.PrimaryScreen.WorkingArea.Height);
					break;
				case Constantes.CenterScreen:
				default:

					break;
			}
			return pos;
		}


		#endregion

	}
}
