using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using Assets.Sommer.BL;

public class SavingJson : MonoBehaviour
{

    public static void SaveJsonFile()
    {
        string timer = JsonUtility.ToJson(TimerList.Instance);
        File.WriteAllText(Application.dataPath + "/timer.json", timer);
        Debug.Log("File has been saved in "+Application.dataPath);
        TimerList.Instance.Timers.Clear();
        Debug.Log("TimerList Cleared");
    }
    
    public static void ReadJsonFile()
    {
        string timer = File.ReadAllText(Application.dataPath + "/timer.json");
        TimerList list = JsonUtility.FromJson<TimerList>(timer);
        Debug.Log(list.Timers[0].timer_name);
    }
}


