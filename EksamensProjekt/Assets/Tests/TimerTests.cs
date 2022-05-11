using System.Collections;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Assets.Sommer.BL;

public class TimerTests
{
    [Test]
    public void You_can_create_a_timer()
    {
        //Arrange
        var timerName = "Test";
        var timerCountdown = 60;

        //Act
        var newTimer = new TimerClass(timerName, timerCountdown);

        //Assert
        Assert.AreEqual(timerName, newTimer.TimerName);
        Assert.AreEqual(timerCountdown, newTimer.TimerCount);      
    }

    [Test]
    public void You_can_add_a_timer_to_list()
    {
        TimerClasses.Instance.Timers.Clear();
        var timerName = "Test";
        var timerCountdown = 60;
        var newTimer = new TimerClass(timerName, timerCountdown);

        TimerClasses.Instance.Timers.Add(newTimer);

        Assert.NotNull(TimerClasses.Instance.Timers);
        Assert.IsNotEmpty(TimerClasses.Instance.Timers);
        Assert.Contains(newTimer, TimerClasses.Instance.Timers);
        Assert.IsTrue(TimerClasses.Instance.Timers.Count == 1);
    }

    [Test]
    public void You_can_save_timers_to_json()
    {
        TimerClasses.Instance.Timers.Clear();
        var timerName = "Test";
        var timerCountdown = 60;
        var newTimer = new TimerClass(timerName, timerCountdown);
        TimerClasses.Instance.Timers.Add(newTimer);

        SaveToJson.WriteTimersToJson();

        var fileInfo = new FileInfo(SaveToJson.FilePath);
        var fileContent = File.ReadAllText(SaveToJson.FilePath);
        Assert.True(fileInfo.Exists);
        Assert.True(fileInfo.Length > 0);
        Assert.AreNotEqual("{}", fileContent);
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
