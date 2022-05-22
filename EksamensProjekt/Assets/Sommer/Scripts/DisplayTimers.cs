using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Assets.Sommer.BL;
using TMPro;


public class DisplayTimers : MonoBehaviour
{
    [SerializeField] private GameObject timerPrefab;
    [SerializeField] private TMP_Text _roomName;
    public void Awake()
    {
        RoomList.Instance.Rooms.Add(new RoomData("Gizmo"));
        RoomList.Instance.Rooms.Add(new RoomData("Frokost"));
        RoomList.Instance.Rooms.Add(new RoomData("Gozby"));
        //SavingJson.ReadJsonFile();
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(RoomList.Instance.Rooms.Count);
        foreach (var room in RoomList.Instance.Rooms)
        {
            //var room = RoomList.Instance.Rooms.Count;
            _roomName.text = "Gizmo";
            Instantiate(timerPrefab, transform);
            Debug.Log("Instantiation executed ");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
