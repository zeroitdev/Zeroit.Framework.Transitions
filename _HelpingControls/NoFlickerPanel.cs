// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="NoFlickerPanel.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Windows.Forms;
using System.ComponentModel;

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    /// <summary>
    /// Class NoFlickerPanel.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Panel" />
    [ToolboxItem(false)]
    public class NoFlickerPanel:Panel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoFlickerPanel"/> class.
        /// </summary>
        public NoFlickerPanel()
        {

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            
        }
    }
}
