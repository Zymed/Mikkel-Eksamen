using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Assets.Sommer.BL;
using TMPro;
using UnityEngine.UI;
using System;

public class DisplayRooms : MonoBehaviour
{
    [SerializeField] private GameObject timerPrefab;
    [SerializeField] private Button button;

    private void Awake()
    {
        //Destroy(timerPrefab);
    }

    /// <summary>
    /// Adds a listener to change scene to the button.
    /// For each room in the roomlist it instantiates a roomPrefab as a child on the Vertical Layout Group
    /// This roomPrefrab has textfields that corresponds the RoomData in the RoomList.
    /// </summary>
    void Start()
    {
        button.onClick.AddListener(LoadAddRoomPage);
        InstantiateRooms();
    }

    public void InstantiateRooms()
    {
        foreach (var room in RoomList.Instance.Rooms)
        {
            GameObject roomPrefab = Instantiate(timerPrefab, transform);
            roomPrefab.name = room.room_ID.ToString();
            roomPrefab.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = room.room_name;
            roomPrefab.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = room.room_ID.ToString();
        }
    }

    private void LoadAddRoomPage()
    {
        SceneChangeManager.LoadAddRoomScene();
    }
}
