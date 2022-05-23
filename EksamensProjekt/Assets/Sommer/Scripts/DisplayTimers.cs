using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Assets.Sommer.BL;
using TMPro;


public class DisplayTimers : MonoBehaviour
{
    [SerializeField] private GameObject timerPrefab;

    public void Awake()
    {
        RoomList.Instance.Rooms.Add(new RoomData("Yoko",1));
        RoomList.Instance.Rooms.Add(new RoomData("Jakamoko",2));
        RoomList.Instance.Rooms.Add(new RoomData("Toto",3));
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(RoomList.Instance.Rooms.Count);
        foreach (var room in RoomList.Instance.Rooms)
        {
            GameObject roomPrefab = Instantiate(timerPrefab, transform);
            roomPrefab.GetComponentInChildren<TextMeshProUGUI>().text = room.room_name;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
