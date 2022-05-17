using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TimerList
{
    private TimerList()
    {

    }

    public List<TimerData> Timers = new List<TimerData>();

    private static TimerList _timerLists;
    public static TimerList Instance
    {
        get
        {
            if (_timerLists == null)
                _timerLists = new TimerList();

            return _timerLists;
        }
    }
}
