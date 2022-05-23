using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerPrefsSaver : MonoBehaviour
{
    [SerializeField] private Button save;
    [SerializeField] private Button load;
    [SerializeField] private TMP_InputField _roomName;
    [SerializeField] private TMP_InputField _roomID;

    //public string timerName;
    //public int timerCount;
    void Start()
    {
        save.onClick.AddListener(SavePlayerPrefs);
        load.onClick.AddListener(LoadPlayerPrefs);
    }

    void Update()
    {
        
    }

    public void SavePlayerPrefs()
    {
        string roomName = _roomName.text;
        int roomID = int.Parse(_roomID.text);
        PlayerPrefs.SetString("RoomName", roomName);
        PlayerPrefs.SetInt("RoomID", roomID);
        RoomList.Instance.Rooms.Add(new RoomData(PlayerPrefs.GetString("RoomName"),PlayerPrefs.GetInt("RoomID")));
        Debug.Log(RoomList.Instance.Rooms.Count);

    }

    public void LoadPlayerPrefs()
    {
        //string roomName = PlayerPrefs.GetString("RoomName");
        //RoomList.Instance.Rooms.Add(new RoomData(roomName));
        //Debug.Log(RoomList.Instance.Rooms.Count);
        SceneChangeManager.LoadRoomScene();
    }
}
