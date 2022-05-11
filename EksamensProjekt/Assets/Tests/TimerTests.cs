using System.Collections;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TimerTests
{
    [Test]
    public void You_can_create_a_timer()
    {
        var timerName = "Test";
        var timerCountdown = 60;

        var newTimer = new TimerClass(timerName, timerCountdown);

        Assert.AreEqual(timerName, newTimer.TimerName);
        Assert.AreEqual(timerCountdown, newTimer.TimerCount);      
    }

    [Test]
    public void You_can_add_a_timer_to_list()
    {
        var timerName = "Test";
        var timerCountdown = 60;
        var newTimer = new TimerClass(timerName, timerCountdown);

        TimerClass.Timers.Add(newTimer);

        Assert.NotNull(TimerClass.Timers);
        Assert.Contains(newTimer, TimerClass.Timers);
    }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        //[UnityTest]
        //public IEnumerator NewTestScriptWithEnumeratorPasses()
        //{
        //    // Use the Assert class to test conditions.
        //    // Use yield to skip a frame.
        //    yield return null;
        //}
}
