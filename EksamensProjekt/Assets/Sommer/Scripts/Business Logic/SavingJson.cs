using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class SavingJson : MonoBehaviour
{
    private static readonly string _fileName = "/timers.json";
    public static string filePath { get; private set; } = Application.dataPath + _fileName;
    
    public static void SaveJsonFile()
    {
        string timer = JsonUtility.ToJson(TimerList.Instance);
        File.WriteAllText(filePath, timer);
        Debug.Log("File has been saved in "+Application.dataPath);
    }
    
    public static void ReadJsonFile()
    {
        string timer = File.ReadAllText(filePath);
        TimerList list = JsonUtility.FromJson<TimerList>(timer);

        Debug.Log("ReadJsonFile executed ");

    }
}


