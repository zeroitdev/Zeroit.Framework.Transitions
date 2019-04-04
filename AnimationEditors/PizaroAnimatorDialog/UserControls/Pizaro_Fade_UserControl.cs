// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Pizaro_Fade_UserControl.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    /// Class Pizaro_Fade_UserControl.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    [ToolboxItem(false)]
    public partial class Pizaro_Fade_UserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pizaro_Fade_UserControl"/> class.
        /// </summary>
        public Pizaro_Fade_UserControl()
        {

            InitializeComponent();


            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            
        }

        /// <summary>
        /// Handles the MouseEnter event of the fade_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void fade_Preview_btn_MouseEnter(object sender, EventArgs e)
        {
            fade_Preview_btn.FlatAppearance.BorderSize = 1;
            fade_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the fade_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void fade_Preview_btn_MouseLeave(object sender, EventArgs e)
        {
            fade_Preview_btn.FlatAppearance.BorderSize = 0;
            fade_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
        }
    }
}
