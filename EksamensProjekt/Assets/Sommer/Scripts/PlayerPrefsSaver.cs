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
    
    void Start()
    {
        save.onClick.AddListener(SavePlayerPrefs);
        load.onClick.AddListener(LoadRoomPage);
    }

    /// <summary>
    /// The inputfield is saved to PlayerPrefs String
    /// A PlayerPrefs Int is also saved as the rooms ID
    /// Finally it adds new RoomData with the PlayerPrefs String and Int to the RoomList.Instance.Rooms.
    /// </summary>
    public void SavePlayerPrefs()
    {
        string roomName = _roomName.text;
        PlayerPrefs.SetString("RoomName", roomName);
        PlayerPrefs.SetInt("RoomID", RoomList.Instance.Rooms.Count + 1);
        RoomList.Instance.Rooms.Add(new RoomData(PlayerPrefs.GetString("RoomName"),PlayerPrefs.GetInt("RoomID")));
    }

    public void LoadRoomPage()
    {
        SceneChangeManager.LoadRoomScene();
    }
}
