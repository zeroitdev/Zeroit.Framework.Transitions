﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Pizaro_FadeOut_UserControl.cs" company="Zeroit Dev Technologies">
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
    /// Class Pizaro_FadeOut_UserControl.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    [ToolboxItem(false)]
    public partial class Pizaro_FadeOut_UserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pizaro_FadeOut_UserControl"/> class.
        /// </summary>
        public Pizaro_FadeOut_UserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the MouseEnter event of the fadeOut_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void fadeOut_Preview_btn_MouseEnter(object sender, EventArgs e)
        {
            fadeOut_Preview_btn.FlatAppearance.BorderSize = 1;
            fadeOut_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        /// <summary>
        /// Handles the MouseLeave event of the fadeOut_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void fadeOut_Preview_btn_MouseLeave(object sender, EventArgs e)
        {
            fadeOut_Preview_btn.FlatAppearance.BorderSize = 0;
            fadeOut_Preview_btn.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
        }

        /// <summary>
        /// Handles the Click event of the fadeOut_Preview_btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void fadeOut_Preview_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
