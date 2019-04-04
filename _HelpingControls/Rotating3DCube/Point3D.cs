// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Point3D.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Microsoft.VisualBasic.CompilerServices;


namespace Zeroit.Framework.Transitions._HelpingControls.Rotating3DCube
{
    /// <summary>
    /// A class collection for generating Three Dimensional (3D) Points
    /// </summary>
    public class Point3D
    {
        /// <summary>
        /// The m x
        /// </summary>
        protected double m_x;

        /// <summary>
        /// The m y
        /// </summary>
        protected double m_y;

        /// <summary>
        /// The m z
        /// </summary>
        protected double m_z;

        /// <summary>
        /// Property for X value
        /// </summary>
        /// <value>The x.</value>
        public double X
        {
            get
            {
                return this.m_x;
            }
            set
            {
                this.m_x = value;
            }
        }

        /// <summary>
        /// Property for Y value
        /// </summary>
        /// <value>The y.</value>
        public double Y
        {
            get
            {
                return this.m_y;
            }
            set
            {
                this.m_y = value;
            }
        }

        /// <summary>
        /// Property for Z value
        /// </summary>
        /// <value>The z.</value>
        public double Z
        {
            get
            {
                return this.m_z;
            }
            set
            {
                this.m_z = value;
            }
        }

        /// <summary>
        /// Creates an instance of Point 3D
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="z">The z.</param>
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        /// <summary>
        /// For compiler services
        /// </summary>
        /// <param name="viewWidth">Set for viewing Width</param>
        /// <param name="viewHeight">Set for viewing Height</param>
        /// <param name="fov">The fov.</param>
        /// <param name="viewDistance">Set for viewing Distance</param>
        /// <returns>System.Object.</returns>
        public object Project(object viewWidth, object viewHeight, object fov, object viewDistance)
        {
            double factor = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Operators.DivideObject(fov, Operators.AddObject(viewDistance, this.Z)));
            double Xn = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Operators.AddObject(this.X * factor, Operators.DivideObject(viewWidth, 2)));
            double Yn = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Operators.AddObject(this.Y * factor, Operators.DivideObject(viewHeight, 2)));
            return new Point3D(Xn, Yn, this.Z);
        }

        /// <summary>
        /// Rotate X
        /// </summary>
        /// <param name="angle">Set angle</param>
        /// <returns>Point3D.</returns>
        public Point3D RotateX(int angle)
        {
            double rad = (double)angle * 3.14159265358979 / 180;
            double cosa = Math.Cos(rad);
            double sina = Math.Sin(rad);
            double yn = this.Y * cosa - this.Z * sina;
            double zn = this.Y * sina + this.Z * cosa;
            return new Point3D(this.X, yn, zn);
        }

        /// <summary>
        /// Rotate Y
        /// </summary>
        /// <param name="angle">Set angle</param>
        /// <returns>Point3D.</returns>
        public Point3D RotateY(int angle)
        {
            double rad = (double)angle * 3.14159265358979 / 180;
            double cosa = Math.Cos(rad);
            double sina = Math.Sin(rad);
            double Zn = this.Z * cosa - this.X * sina;
            double Xn = this.Z * sina + this.X * cosa;
            return new Point3D(Xn, this.Y, Zn);
        }

        /// <summary>
        /// Rotate Z
        /// </summary>
        /// <param name="angle">Set angle</param>
        /// <returns>Point3D.</returns>
        public Point3D RotateZ(int angle)
        {
            double rad = (double)angle * 3.14159265358979 / 180;
            double cosa = Math.Cos(rad);
            double sina = Math.Sin(rad);
            double Xn = this.X * cosa - this.Y * sina;
            double Yn = this.X * sina + this.Y * cosa;
            return new Point3D(Xn, Yn, this.Z);
        }
    }
}
