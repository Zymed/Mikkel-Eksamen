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
        JsonUtility.FromJson<TimerList>(timer);
        Debug.Log(TimerList.Instance.Timers.Count);
        Debug.Log(TimerList.Instance.Timers[0].timer_name);
        Debug.Log(TimerList.Instance.Timers[0].timer_count);
    }
}


