// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="IListener.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Zeroit.Framework.Transitions.DBTweener
{
    // the listener class is used in CDBTweener and CTween to listen for finished tweens.
    /// <summary>
    /// Class IListener.
    /// </summary>
    public abstract class IListener
    {
        /// <summary>
        /// Disposes this instance.
        /// </summary>
        public virtual void Dispose()
        {
        }
        /// <summary>
        /// Ons the tween finished.
        /// </summary>
        /// <param name="pTween">The p tween.</param>
        public abstract void onTweenFinished(CTween pTween);
    }



}
