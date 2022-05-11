using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace Assets.Sommer.BL
{
    [Serializable]
    public class TimerClass
    {
        private readonly int _maxTimer = 60;
        private readonly int _minTimer = 1;
        public string TimerName;
        public int TimerCount;

        public TimerClass(string timerName, int timerCount)
        {
            TimerName = timerName;

            SetTimer(timerCount);
        }

        /*public TimerClass(string timerName)
        {
            TimerName = timerName;
            TimerCount = 0;
        }*/

        public void SetTimer(int newTimerCount)
        {
            if (newTimerCount > _maxTimer)
                throw new ArgumentException("TimerCount must be less than " + _maxTimer);
            if (newTimerCount < _minTimer)
                throw new ArgumentException("TimerCount must be more than " + _minTimer);
            TimerCount = newTimerCount;
        }

    }
}