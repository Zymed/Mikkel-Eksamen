using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Diagnostics;
using Assets.Sommer.BL;
using System.IO;

public class SaveInputs : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private TMP_InputField countInput;
    [SerializeField] private Button button;
    [SerializeField] private Button timer;
    [SerializeField] private Button instanitate;

    public Stopwatch timerWatch;

    SaveToJson saveJson = new SaveToJson();

    public void Start()
    {
        button.onClick.AddListener(SaveInput);
        instanitate.onClick.AddListener(CreateTimer);
    }

    public void SaveInput()
    {
        var timeName = nameInput.text;
        var timeNumber = int.Parse(countInput.text);

        TimerClasses.Instance.Timers.Add(new TimerClass(timeName, timeNumber));
        SaveToJson.WriteTimersToJson();
    }
        private void CreateTimer()
    {
        Instantiate(timer, transform.parent);
        timer.GetComponentInChildren<Text>().text = TimerClasses.Instance.Timers[0].TimerCount.ToString();
        UnityEngine.Debug.Log("Timer name is: " + TimerClasses.Instance.Timers[0].TimerName);
        UnityEngine.Debug.Log("Timer has been set to: "+ TimerClasses.Instance.Timers[0].TimerCount.ToString()+" seconds");
    }
}
