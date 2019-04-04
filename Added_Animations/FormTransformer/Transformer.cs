// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Transformer.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions
{
    /// <summary>
    /// Class FormTransform.
    /// </summary>
    class FormTransform
    {
        /// <summary>
        /// The f ps
        /// </summary>
        private double fPS = 300;
        /// <summary>
        /// The step
        /// </summary>
        private int step = 10;

        /// <summary>
        /// Gets or sets the FPS.
        /// </summary>
        /// <value>The FPS.</value>
        public double FPS { get => fPS; set => fPS = value; }
        /// <summary>
        /// Gets or sets the step.
        /// </summary>
        /// <value>The step.</value>
        public int Step { get => step; set => step = value; }

        /// <summary>
        /// Transforms the size.
        /// </summary>
        /// <param name="frm">The FRM.</param>
        /// <param name="newWidth">The new width.</param>
        /// <param name="newHeight">The new height.</param>
        public void TransformSize(System.Windows.Forms.Form frm, int newWidth, int newHeight)
        {
            TransformSize(frm, new Size(newWidth, newHeight));
        }

        /// <summary>
        /// Transforms the size.
        /// </summary>
        /// <param name="frm">The FRM.</param>
        /// <param name="newSize">The new size.</param>
        public void TransformSize(System.Windows.Forms.Form frm, Size newSize)
        {
            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(RunTransformation);
            
            Thread transformThread = new Thread(threadStart);

            transformThread.Start(new object[] { frm, newSize });
        }

        /// <summary>
        /// Delegate RunTransformationDelegate
        /// </summary>
        /// <param name="paramaters">The paramaters.</param>
        private delegate void RunTransformationDelegate(object paramaters);

        /// <summary>
        /// Runs the transformation.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        private void RunTransformation(object parameters)
        {
            System.Windows.Forms.Form frm = (System.Windows.Forms.Form)((object[])parameters)[0];
            if (frm.InvokeRequired)
            {
                RunTransformationDelegate del = new RunTransformationDelegate(RunTransformation);
                frm.Invoke(del, parameters);
            }
            else
            {
                //Animation variables
                //double FPS = 300.0;


                long interval = (long)(Stopwatch.Frequency / FPS);
                long ticks1 = 0;
                long ticks2 = 0;

                //Dimension transform variables
                Size size = (Size)((object[])parameters)[1];

                int xDiff = Math.Abs(frm.Width - size.Width);
                int yDiff = Math.Abs(frm.Height - size.Height);

                //int step = 10;
                int step = Step;

                int xDirection = frm.Width < size.Width ? 1 : -1;
                int yDirection = frm.Height < size.Height ? 1 : -1;

                int xStep = step * xDirection;
                int yStep = step * yDirection;

                bool widthOff = IsWidthOff(frm.Width, size.Width, xStep);
                bool heightOff = IsHeightOff(frm.Height, size.Height, yStep);


                while (widthOff || heightOff)
                {
                    //Get current timestamp
                    ticks2 = Stopwatch.GetTimestamp();

                    if (ticks2 >= ticks1 + interval) //only run logic if enough time has passed "between frames"
                    {
                        //Adjust the Form dimensions
                        if (widthOff)
                            frm.Width += xStep;

                        if (heightOff)
                            frm.Height += yStep;

                        widthOff = IsWidthOff(frm.Width, size.Width, xStep);
                        heightOff = IsHeightOff(frm.Height, size.Height, yStep);

                        //Allows the Form to refresh
                        Application.DoEvents();

                        //Save current timestamp
                        ticks1 = Stopwatch.GetTimestamp();
                    }

                    Thread.Sleep(1);
                }

            }
        }

        /// <summary>
        /// Determines whether [is width off] [the specified current width].
        /// </summary>
        /// <param name="currentWidth">Width of the current.</param>
        /// <param name="targetWidth">Width of the target.</param>
        /// <param name="step">The step.</param>
        /// <returns><c>true</c> if [is width off] [the specified current width]; otherwise, <c>false</c>.</returns>
        private static bool IsWidthOff(int currentWidth, int targetWidth, int step)
        {
            //Do avoid uneven jumps, do not change the width if it is
            //within the step amount
            if (Math.Abs(currentWidth - targetWidth) <= Math.Abs(step)) return false;

            return (step > 0 && currentWidth < targetWidth) || //increasing direction - keep going if still too small
                   (step < 0 && currentWidth > targetWidth); //decreasing direction - keep going if still too large
        }

        /// <summary>
        /// Determines whether [is height off] [the specified current height].
        /// </summary>
        /// <param name="currentHeight">Height of the current.</param>
        /// <param name="targetHeight">Height of the target.</param>
        /// <param name="step">The step.</param>
        /// <returns><c>true</c> if [is height off] [the specified current height]; otherwise, <c>false</c>.</returns>
        private static bool IsHeightOff(int currentHeight, int targetHeight, int step)
        {
            //Do avoid uneven jumps, do not change the height if it is
            //within the step amount
            if (Math.Abs(currentHeight - targetHeight) <= Math.Abs(step)) return false;

            return (step > 0 && currentHeight < targetHeight) || //increasing direction - keep going if still too small
                   (step < 0 && currentHeight > targetHeight); //decreasing direction - keep going if still too large
        }

        /// <summary>
        /// Gets the FPS.
        /// </summary>
        /// <param name="FPS">The FPS.</param>
        /// <returns>System.Double.</returns>
        public static double GetFPS(double FPS)
        {
            return FPS;
        }
    }
}
