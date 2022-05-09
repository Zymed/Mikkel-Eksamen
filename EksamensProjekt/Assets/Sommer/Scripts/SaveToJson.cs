using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class SaveToJson
{
    private readonly string _fileName = "/timers.json";

    public void WriteTimersToJson()
    {
        var jsonData = JsonUtility.ToJson(TimerClass.Timers);
        File.WriteAllText(Application.persistentDataPath + _fileName, jsonData);
        Debug.Log("File has been saved as json file at: " + Application.persistentDataPath);
        Debug.Log("File has been saved with "+TimerClass.Timers.Count+" amount of numbers in the list.");
        Debug.Log("The content of the list is: " + jsonData);
    }

    public void ReadTimersFromJson()
    {
        var inputString = File.ReadAllText(_fileName);
    }
}
