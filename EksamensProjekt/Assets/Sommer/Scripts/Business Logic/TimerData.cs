using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class TimerData
{
    public string timer_name;
    public int timer_count;

    public TimerData(string timerName, int timerCount)
    {
        timer_name = timerName;
        timer_count = timerCount;
    }
}
