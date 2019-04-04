// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="CRelay.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;

namespace Zeroit.Framework.Transitions.DBTweener
{


    /// <summary>
    /// Class CRelay.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.DBTweener.IListener" />
    public class CRelay : IListener
    {
        /// <summary>
        /// Ons the tween finished.
        /// </summary>
        /// <param name="pTween">The p tween.</param>
        public override void onTweenFinished(CTween pTween)
        {
            for (HashSet<IListener>.Enumerator i = m_sListeners.GetEnumerator(); i.MoveNext();)
            {
                IListener pListener = i.Current;
                pListener.onTweenFinished(pTween);
            }
        }
        /// <summary>
        /// The m s listeners
        /// </summary>
        public HashSet<IListener> m_sListeners = new HashSet<IListener>();
    }

}
