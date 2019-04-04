// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Flags.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.Transitions
{
    #region Flags

    /// <summary>
    /// A class collection window styles for <c><see cref="ZeroitAnimator" /></c> animator.
    /// </summary>
    public static class Flags
    {
        /// <summary>
        /// Sets the window styles for <c><see cref="ZeroitAnimator" /></c> animator.
        /// </summary>
        [Flags]
        public enum WindowStyles : uint
        {
            /// <summary>
            /// The ws overlapped
            /// </summary>
            WS_OVERLAPPED = 0x00000000,
            /// <summary>
            /// The ws popup
            /// </summary>
            WS_POPUP = 0x80000000,
            /// <summary>
            /// The ws child
            /// </summary>
            WS_CHILD = 0x40000000,
            /// <summary>
            /// The ws minimize
            /// </summary>
            WS_MINIMIZE = 0x20000000,
            /// <summary>
            /// The ws visible
            /// </summary>
            WS_VISIBLE = 0x10000000,
            /// <summary>
            /// The ws disabled
            /// </summary>
            WS_DISABLED = 0x08000000,
            /// <summary>
            /// The ws clipsiblings
            /// </summary>
            WS_CLIPSIBLINGS = 0x04000000,
            /// <summary>
            /// The ws clipchildren
            /// </summary>
            WS_CLIPCHILDREN = 0x02000000,
            /// <summary>
            /// The ws maximize
            /// </summary>
            WS_MAXIMIZE = 0x01000000,
            /// <summary>
            /// The ws border
            /// </summary>
            WS_BORDER = 0x00800000,
            /// <summary>
            /// The ws dlgframe
            /// </summary>
            WS_DLGFRAME = 0x00400000,
            /// <summary>
            /// The ws vscroll
            /// </summary>
            WS_VSCROLL = 0x00200000,
            /// <summary>
            /// The ws hscroll
            /// </summary>
            WS_HSCROLL = 0x00100000,
            /// <summary>
            /// The ws sysmenu
            /// </summary>
            WS_SYSMENU = 0x00080000,
            /// <summary>
            /// The ws thickframe
            /// </summary>
            WS_THICKFRAME = 0x00040000,
            /// <summary>
            /// The ws group
            /// </summary>
            WS_GROUP = 0x00020000,
            /// <summary>
            /// The ws tabstop
            /// </summary>
            WS_TABSTOP = 0x00010000,

            /// <summary>
            /// The ws minimizebox
            /// </summary>
            WS_MINIMIZEBOX = 0x00020000,
            /// <summary>
            /// The ws maximizebox
            /// </summary>
            WS_MAXIMIZEBOX = 0x00010000,

            /// <summary>
            /// The ws caption
            /// </summary>
            WS_CAPTION = WS_BORDER | WS_DLGFRAME,
            /// <summary>
            /// The ws tiled
            /// </summary>
            WS_TILED = WS_OVERLAPPED,
            /// <summary>
            /// The ws iconic
            /// </summary>
            WS_ICONIC = WS_MINIMIZE,
            /// <summary>
            /// The ws sizebox
            /// </summary>
            WS_SIZEBOX = WS_THICKFRAME,
            /// <summary>
            /// The ws tiledwindow
            /// </summary>
            WS_TILEDWINDOW = WS_OVERLAPPEDWINDOW,

            /// <summary>
            /// The ws overlappedwindow
            /// </summary>
            WS_OVERLAPPEDWINDOW = WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX,
            /// <summary>
            /// The ws popupwindow
            /// </summary>
            WS_POPUPWINDOW = WS_POPUP | WS_BORDER | WS_SYSMENU,
            /// <summary>
            /// The ws childwindow
            /// </summary>
            WS_CHILDWINDOW = WS_CHILD,

            //Extended Window Styles

            /// <summary>
            /// The ws ex dlgmodalframe
            /// </summary>
            WS_EX_DLGMODALFRAME = 0x00000001,
            /// <summary>
            /// The ws ex noparentnotify
            /// </summary>
            WS_EX_NOPARENTNOTIFY = 0x00000004,
            /// <summary>
            /// The ws ex topmost
            /// </summary>
            WS_EX_TOPMOST = 0x00000008,
            /// <summary>
            /// The ws ex acceptfiles
            /// </summary>
            WS_EX_ACCEPTFILES = 0x00000010,
            /// <summary>
            /// The ws ex transparent
            /// </summary>
            WS_EX_TRANSPARENT = 0x00000020,

            //#if(WINVER >= 0x0400)

            /// <summary>
            /// The ws ex mdichild
            /// </summary>
            WS_EX_MDICHILD = 0x00000040,
            /// <summary>
            /// The ws ex toolwindow
            /// </summary>
            WS_EX_TOOLWINDOW = 0x00000080,
            /// <summary>
            /// The ws ex windowedge
            /// </summary>
            WS_EX_WINDOWEDGE = 0x00000100,
            /// <summary>
            /// The ws ex clientedge
            /// </summary>
            WS_EX_CLIENTEDGE = 0x00000200,
            /// <summary>
            /// The ws ex contexthelp
            /// </summary>
            WS_EX_CONTEXTHELP = 0x00000400,

            /// <summary>
            /// The ws ex right
            /// </summary>
            WS_EX_RIGHT = 0x00001000,
            /// <summary>
            /// The ws ex left
            /// </summary>
            WS_EX_LEFT = 0x00000000,
            /// <summary>
            /// The ws ex rtlreading
            /// </summary>
            WS_EX_RTLREADING = 0x00002000,
            /// <summary>
            /// The ws ex ltrreading
            /// </summary>
            WS_EX_LTRREADING = 0x00000000,
            /// <summary>
            /// The ws ex leftscrollbar
            /// </summary>
            WS_EX_LEFTSCROLLBAR = 0x00004000,
            /// <summary>
            /// The ws ex rightscrollbar
            /// </summary>
            WS_EX_RIGHTSCROLLBAR = 0x00000000,

            /// <summary>
            /// The ws ex controlparent
            /// </summary>
            WS_EX_CONTROLPARENT = 0x00010000,
            /// <summary>
            /// The ws ex staticedge
            /// </summary>
            WS_EX_STATICEDGE = 0x00020000,
            /// <summary>
            /// The ws ex appwindow
            /// </summary>
            WS_EX_APPWINDOW = 0x00040000,

            /// <summary>
            /// The ws ex overlappedwindow
            /// </summary>
            WS_EX_OVERLAPPEDWINDOW = (WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE),
            /// <summary>
            /// The ws ex palettewindow
            /// </summary>
            WS_EX_PALETTEWINDOW = (WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST),

            //#endif /* WINVER >= 0x0400 */

            //#if(WIN32WINNT >= 0x0500)

            /// <summary>
            /// The ws ex layered
            /// </summary>
            WS_EX_LAYERED = 0x00080000,

            //#endif /* WIN32WINNT >= 0x0500 */

            //#if(WINVER >= 0x0500)

            /// <summary>
            /// The ws ex noinheritlayout
            /// </summary>
            WS_EX_NOINHERITLAYOUT = 0x00100000, // Disable inheritence of mirroring by children
            /// <summary>
            /// The ws ex layoutrtl
            /// </summary>
            WS_EX_LAYOUTRTL = 0x00400000, // Right to left mirroring

            //#endif /* WINVER >= 0x0500 */

            //#if(WIN32WINNT >= 0x0500)

            /// <summary>
            /// The ws ex composited
            /// </summary>
            WS_EX_COMPOSITED = 0x02000000,
            /// <summary>
            /// The ws ex noactivate
            /// </summary>
            WS_EX_NOACTIVATE = 0x08000000

            //#endif /* WIN32WINNT >= 0x0500 */

        }
    }
    #endregion
}
