using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;


public class SaveToJson
{
    private readonly string _fileName = "/timers.json";
    //[SerializeField] private TimerClass jsonData = new TimerClass();
    public void WriteTimersToJson()
    {
        string outputJson = JsonUtility.ToJson(TimerClass.Timers);
        File.WriteAllText(Application.dataPath + _fileName, outputJson);
        Debug.Log("File has been saved as json file at: " + Application.dataPath);
        Debug.Log("File has been saved with "+TimerClass.Timers.Count+" amount of numbers in the list.");
        Debug.Log("The content of the list is: " + outputJson);
    }

    public void ReadTimersFromJson()
    {
        var inputString = File.ReadAllText(Application.dataPath + _fileName);
    }
}
