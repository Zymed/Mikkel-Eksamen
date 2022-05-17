using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Assets.Sommer.BL;


public class DisplayTimers : MonoBehaviour
{
    [SerializeField] private GameObject timerPrefab;
    public void Awake()
    {
        SavingJson.ReadJsonFile();
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(TimerClasses.Instance.Timers.Count);
        foreach (var timer in TimerClasses.Instance.Timers)
        {
            Instantiate(timerPrefab, transform.parent);
            Debug.Log("Instantiation executed ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
