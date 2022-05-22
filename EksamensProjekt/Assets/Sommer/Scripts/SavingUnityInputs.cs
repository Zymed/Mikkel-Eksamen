using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SavingUnityInputs : MonoBehaviour
{
    [SerializeField] private Button save;
    [SerializeField] private Button load;
    [SerializeField] private TMP_InputField _roomName;
    //[SerializeField] private TMP_InputField _roomCount;

    public void Start()
    {
        save.onClick.AddListener(SaveStuffToList);
        load.onClick.AddListener(ReadStuffFromList);
    }

    public void SaveStuffToList()
    {
        //TimerList.Instance.Timers.Clear();
        var roomName = _roomName.text;
        var newRoom = new RoomData(roomName);
        RoomList.Instance.Rooms.Add(newRoom);
        SavingJson.SaveJsonFile();
    }

    public void ReadStuffFromList()
    {
        SavingJson.ReadJsonFile();
        Debug.Log(RoomList.Instance.Rooms.Count);
    }

    private void Update()
    {

    }
}
