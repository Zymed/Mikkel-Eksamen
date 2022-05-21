using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SavingUnityInputs : MonoBehaviour
{
    [SerializeField] private Button save;
    [SerializeField] private Button load;
    [SerializeField] private TMP_InputField timeName;
    [SerializeField] private TMP_InputField timeCount;

    public void Start()
    {
        save.onClick.AddListener(SaveStuffToList);
        load.onClick.AddListener(ReadStuffFromList);
    }

    public void SaveStuffToList()
    {
        //TimerList.Instance.Timers.Clear();
        var timerName = timeName.text;
        int timerCountdown = int.Parse(timeCount.text);
        var newTimer = new TimerData(timerName, timerCountdown);
        TimerList.Instance.Timers.Add(newTimer);
        SavingJson.SaveJsonFile();
    }

    public void ReadStuffFromList()
    {
        SavingJson.ReadJsonFile();
        Debug.Log(TimerList.Instance.Timers.Count);
    }

    private void Update()
    {

    }
}
