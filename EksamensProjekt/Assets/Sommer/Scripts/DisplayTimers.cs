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
        RoomList.Instance.Rooms.Add(new RoomData("Yoko"));
        RoomList.Instance.Rooms.Add(new RoomData("Jakamoko"));
        RoomList.Instance.Rooms.Add(new RoomData("Toto"));
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
