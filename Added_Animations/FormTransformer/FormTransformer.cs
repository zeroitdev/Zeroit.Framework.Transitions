// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FormTransformer.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Drawing;

namespace Zeroit.Framework.Transitions
{
    /// <summary>
    /// Class ZeroitFormTransformer.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    public partial class ZeroitFormTransformer : Component
    {

        #region Private Fields

        /// <summary>
        /// The width
        /// </summary>
        private int width = 100;
        /// <summary>
        /// The height
        /// </summary>
        private int height = 100;
        /// <summary>
        /// The f ps
        /// </summary>
        private double fPS = 300;
        /// <summary>
        /// The step
        /// </summary>
        private int step = 10;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>The width.</value>
        public int Width { get => width; set => width = value; }
        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>The height.</value>
        public int Height { get => height; set => height = value; }
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

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitFormTransformer"/> class.
        /// </summary>
        public ZeroitFormTransformer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitFormTransformer"/> class.
        /// </summary>
        /// <param name="container">The container.</param>
        public ZeroitFormTransformer(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


        #endregion

        #region Methods

        /// <summary>
        /// Starts the specified form.
        /// </summary>
        /// <param name="Form">The form.</param>
        public void Start(System.Windows.Forms.Form Form)
        {
            FormTransform transformAnimation = new FormTransform();
            transformAnimation.FPS = FPS;
            transformAnimation.Step = Step;
            transformAnimation.TransformSize(Form, new Size(Width, Height));
        } 

        #endregion
    }
}
