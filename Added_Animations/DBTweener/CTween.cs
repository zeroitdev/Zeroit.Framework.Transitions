// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="CTween.cs" company="Zeroit Dev Technologies">
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

using System;
using System.Collections.Generic;

namespace Zeroit.Framework.Transitions.DBTweener
{
    
    //	class IListener;

    // this is where the magic happens. this class can be used 'stand-alone' to tween a set of 
    // parameters using a single tweening equation or it can be used in an instance of CDBTweener 
    public class CTween
    {

        // declare the static equation classes
        private CLinear TWEQ_LINEAR = new CLinear();
        private CQuadratic TWEQ_QUADRATIC = new CQuadratic();
        private CCubic TWEQ_CUBIC = new CCubic();
        private CQuartic TWEQ_QUARTIC = new CQuartic();
        private CQuintic TWEQ_QUINTIC = new CQuintic();
        private CSinusoidal TWEQ_SINUSOIDAL = new CSinusoidal();
        private CExponential TWEQ_EXPONENTIAL = new CExponential();
        private CCircular TWEQ_CIRCULAR = new CCircular();
        private CBounce TWEQ_BOUNCE = new CBounce();
        private CElastic TWEQ_ELASTIC = new CElastic();
        private CBack TWEQ_BACK = new CBack();
        

        public CTween()
        {
            m_fElapsedSec = 0.0f;
            m_fDurationSec = 0.0f;
            m_pEquation = TWEQ_LINEAR;
            m_eEasing = EEasing.TWEA_IN;
            m_pUserData = null;

            


        }
        public CTween(CEquation pEquation, EEasing eEasing, float fDuration, ref float fpValue, float fTarget)
        {
            m_fElapsedSec = 0.0f;
            m_fDurationSec = fDuration;
            m_pEquation = pEquation;
            m_eEasing = eEasing;
            m_pUserData = null;
            addValue(ref fpValue, fTarget);
        }
        public void Dispose()
        {
            for (List<SValue>.Enumerator i = m_vValues.GetEnumerator(); i.MoveNext();)
            {
                
                SValue pValue = i.Current;
                if (pValue != null)
                    pValue.Dispose();
            }
        }

        public void setEquation(CEquation pEquation, EEasing eEasing, float fDuration)
        {
            m_pEquation = pEquation;
            m_eEasing = eEasing;
            m_fDurationSec = fDuration;
        }
        //C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
        //ORIGINAL LINE: CEquation *getEquation() const
        public CEquation getEquation()
        {
            return m_pEquation;
        }
        //C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
        //ORIGINAL LINE: EEasing getEasing() const
        public EEasing getEasing()
        {
            return m_eEasing;
        }
        //C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
        //ORIGINAL LINE: float getDurationSec() const
        public float getDurationSec()
        {
            return m_fDurationSec;
        }

        //C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
        //ORIGINAL LINE: bool isFinished() const
        public bool isFinished()
        {
            return m_fElapsedSec >= m_fDurationSec;
        }

        public void addValue(ref float fpValue, float fTarget)
        {
            m_vValues.Add(new SValue(ref fpValue, fTarget));
        }
        public List<SValue> getValues()
        {
            return m_vValues;
        }
        public void setElapsedSec(float fValue)
        {
            m_fElapsedSec = fValue;
        }
        //C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
        //ORIGINAL LINE: float getElapsedSec() const
        public float getElapsedSec()
        {
            return m_fElapsedSec;
        }
        public void setUserData(object pData) // Custom pointer; free to use
        {
            m_pUserData = pData;
        }
        public object getUserData()
        {
            return m_pUserData;
        }

        public void addListener(IListener pListener)
        {
            m_sListeners.Add(pListener);
        }
        public void removeListener(IListener pListener)
        {
            m_sListeners.Remove(pListener);
        }

        public void step(float fDeltaTimeSec)
        {
            // increase elapsed time
            float fBeforeStep = m_fElapsedSec;
            m_fElapsedSec += fDeltaTimeSec;

            // tween all values
            for (List<SValue>.Enumerator i = m_vValues.GetEnumerator(); i.MoveNext();)
            {
                SValue pValue = i.Current;

                // initialize the start position if no time has elapsed yet.
                if (fBeforeStep <= Double.Epsilon)
                {
                    pValue.m_fStart = pValue.m_fpValue;
                }

                //C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent for pointers to value types:
                //ORIGINAL LINE: float *fpValue = pValue->m_fpValue;
                float fpValue = pValue.m_fpValue;
                float fStart = pValue.m_fStart;
                float fChange = pValue.m_fTarget - fStart;
                switch (m_eEasing)
                {
                    
                    case EEasing.TWEA_IN:
                        fpValue = m_pEquation.easeIn(m_fElapsedSec, fStart, fChange, m_fDurationSec);
                        break;
                    case EEasing.TWEA_OUT:
                        fpValue = m_pEquation.easeOut(m_fElapsedSec, fStart, fChange, m_fDurationSec);
                        break;
                    case EEasing.TWEA_INOUT:
                        fpValue = m_pEquation.easeInOut(m_fElapsedSec, fStart, fChange, m_fDurationSec);
                        break;
                }

                if (m_fElapsedSec >= m_fDurationSec)
                {
                    fpValue = pValue.m_fTarget; // don't overshoot
                }
            }

            // if we're done, notify all listeners of the fact
            if (m_fElapsedSec >= m_fDurationSec)
            {
                for (HashSet<IListener>.Enumerator j = m_sListeners.GetEnumerator(); j.MoveNext();)
                {
                    IListener pListener = j.Current;
                    pListener.onTweenFinished(this);
                }
            }
        }

        private HashSet<IListener> m_sListeners = new HashSet<IListener>();
        private List<SValue> m_vValues = new List<SValue>();
        private CEquation m_pEquation;
        private EEasing m_eEasing;
        private float m_fElapsedSec;
        private float m_fDurationSec;
        private object m_pUserData;
    }



}
