// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="DBTweener.cs" company="Zeroit Dev Technologies">
//    This program is for creating components to aid in Animating controls.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using Zeroit.Framework.Transitions.DBTweener;

/*****************************************************************************
  
  [DBTweener]
  ----------------

  Sirp Potijk
  http://www.deadbugprojects.com

  Inspired by Tweener and CPPTweener.
  http://code.google.com/p/tweener
  http://code.google.com/p/cpptweener

  Built-in tweener equations from Robert Penner
  Spotted at gizma.com
  http://gizma.com/easing/
  http://flashblog.robertpenner.com/

*****************************************************************************/


//#define M_PI

//// by default this uses a lookup table defined in dbtweener.cpp
//// to use a different lookup table or sin/cos functions comment
//// out the 'USE_BUILTIN_LOOKUP' macro and substitute the 'SIN_FUNC'
//// and 'COS_FUNC' macro's with the correct function with signature:
//// float sin(float radians)
//#define DB_USE_BUILTIN_LOOKUP
////C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
////ORIGINAL LINE: #define DB_SIN_FUNC(r) __g_oDBMathLookup.sin(r)
//#define DB_SIN_FUNC
////C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
////ORIGINAL LINE: #define DB_COS_FUNC(r) __g_oDBMathLookup.cos(r)
//#define DB_COS_FUNC

//// pow and sqrt functions; performance may depend on CPU architecture
//// if a faster alternative is required these macro's can be substituted.
//// by default this uses the standard math.h functions.
////C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
////ORIGINAL LINE: #define DB_POW_FUNC(x, y) powf(x, y)
//#define DB_POW_FUNC
////C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
////ORIGINAL LINE: #define DB_SQRT_FUNC(x) sqrtf(x)
//#define DB_SQRT_FUNC

//// test if two float values are the same
////C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
////ORIGINAL LINE: #define DB_FLT_EQ(a, b) (fabs(a - b) <= FLT_EPSILON)
//#define DB_FLT_EQ

//// use this class to maintain a collection of tweens and step through all of them 
//// at once. alternatively, CDBTweener::CTween can also be used 'stand-alone'.
public class CDBTweener
{
    
    public CLinear TWEQ_LINEAR = new CLinear();

    public CQuadratic TWEQ_QUADRATIC = new CQuadratic();

    public CCubic TWEQ_CUBIC = new CCubic();
    
    public CQuartic TWEQ_QUARTIC = new CQuartic();

    public CQuintic TWEQ_QUINTIC = new CQuintic();

    public CSinusoidal TWEQ_SINUSOIDAL = new CSinusoidal();

    public CExponential TWEQ_EXPONENTIAL = new CExponential();

    public CCircular TWEQ_CIRCULAR = new CCircular();

    public CBounce TWEQ_BOUNCE = new CBounce();

    public CBack TWEQ_BACK = new CBack();

    public CElastic TWEQ_ELASTIC = new CElastic();


    HashSet<CTween> m_sTweens = new HashSet<CTween>();

    

    public CDBTweener()
    {

    }

    public void Dispose()
    {
        for (HashSet<CTween>.Enumerator i = m_sTweens.GetEnumerator(); i.MoveNext();)
        {
            CTween pTween = i.Current;
            if (pTween != null)
                pTween.Dispose();
        }
    }

    public void addTween(CTween pTween)
    {
        pTween.addListener(m_oTweenRelay);
        m_sTweens.Add(pTween);
    }
    public void addTween(CEquation pEquation, EEasing eEasing, float fDuration, ref float fpValue, float fTarget)
    {
        CTween pTween = new CTween(pEquation, eEasing, fDuration, ref fpValue, fTarget);
        pTween.addListener(m_oTweenRelay);
        m_sTweens.Add(pTween);
    }
    public void removeTween(CTween pTween)
    {
        pTween.removeListener(m_oTweenRelay);
        m_sTweens.Remove(pTween);


        //HashSet<CTween>.Enumerator iterT = m_sTweens.find(pTween);
        //if (iterT != m_sTweens.end())
        //{
        //    //C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
        //    pTween = iterT.Current;
        //    if (pTween != null)
        //        pTween.Dispose();
        //    m_sTweens.Remove(iterT.Current);
        //}

        #region Imported Code for Help
        //// Check to see if the set contains an object 
        //var contains = iterT.Contains(pTween);

        //// Return the number of objects in the set 
        //var count = hashSet.Count; 
        #endregion

        //C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:

        
    }

    //C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
    //ORIGINAL LINE: const ClassicSet<CTween *> &getTweens() const
    public HashSet<CTween> getTweens()
    {
        return m_sTweens;
    }

    public void addListener(IListener pListener)
    {
        m_oTweenRelay.m_sListeners.Add(pListener);
    }
    public void removeListener(IListener pListener)
    {
        m_oTweenRelay.m_sListeners.Remove(pListener);
    }

    public void step(float fDeltaTimeSec)
    {
        for (HashSet<CTween>.Enumerator i = m_sTweens.GetEnumerator(); i.MoveNext();)
        {
            CTween pTween = i.Current;

            pTween.step(fDeltaTimeSec);

            if (pTween.isFinished())
            {
                m_sTweens.Remove(i.Current);
                if (pTween != null)
                    pTween.Dispose();

                
            }
            else
            {
                //--------Subject to deletion ++i
                i.MoveNext();
            }

        }
    }

    //C++ TO C# CONVERTER TODO TASK: C# does not allow declaring types within methods:
    //	class CRelay: public IListener
    //	{
    //	public:
    //		void onTweenFinished(CTween *pTween)
    //		{
    //			for (ClassicSetIterator<IListener *> i = m_sListeners.begin(); i != m_sListeners.end(); i++)
    //			{
    //				IListener *pListener = *i;
    //				pListener->onTweenFinished(pTween);
    //			}
    //		}
    //		ClassicSet<IListener *> m_sListeners;
    //	}
    CRelay m_oTweenRelay = new CRelay();

	
}

