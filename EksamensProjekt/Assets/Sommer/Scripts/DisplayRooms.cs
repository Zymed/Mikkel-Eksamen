using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayRooms : MonoBehaviour
{
    [SerializeField] private GameObject timerPrefab;
    [SerializeField] private Button button;
    [SerializeField] private GameObject layoutGroup;

    private RoomList roomList;

    /// <summary>
    /// Adds a listener to change scene to the button.
    /// For each room in the roomlist it instantiates a roomPrefab as a child on the Vertical Layout Group
    /// This roomPrefrab has textfields that corresponds the RoomData in the RoomList.
    /// </summary>
    void Start()
    {
        roomList = RoomList.Instance;
        button.onClick.AddListener(LoadAddRoomPage);
        InstantiateRooms();
    }


    /// <summary>
    /// Instantiates a roomprefab for each element in the RoomList
    /// Sets the text of the first child)to equals to roomname
    /// Sets the text of the second child to its room ID
    /// </summary>
    public void InstantiateRooms()
    {
        foreach (var room in roomList.Rooms)
        {
            GameObject roomPrefab = Instantiate(timerPrefab, layoutGroup.transform);
            roomPrefab.name = room.room_ID.ToString();
            roomPrefab.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = room.room_name;
            roomPrefab.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = room.room_ID.ToString();
        }
    }

    private void LoadAddRoomPage()
    {
        SceneChangeManager.LoadAddRoomScene();
    }


    /// <summary>
    /// This script is attached to a gameobject that represents a trashbin. 
    /// If an object "isDragging" and collides with the bin, this method is called
    /// ID is set the to objects.name that collides
    /// if ID is the same as the RoomData's.room_ID it deletes the gameobject and the data in the list.
    /// Afterwards it updates the list.
    /// 
    /// It had to "ToArray" due to Unity error; Accessing list while modifying it.
    /// </summary>
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "InstantiatedObject" && DragBehaviour.IS_DRAGGING)
        {
            int id = int.Parse(collision.gameObject.name);
            foreach (RoomData data in roomList.Rooms.ToArray())
            {
                if (id == data.room_ID)
                {
                    Destroy(collision.gameObject);
                    roomList.Rooms.Remove(data);
                }
            }
            UpdateRoomData();
        }
    }

    /// <summary>
    /// Creates an array that is equal to the RoomList.Instance
    /// It goes through the list and sets the room_ID equals to its number in the array "+1" to compensate for its place in the array as it counts from 0
    /// </summary>
    private void UpdateRoomData()
    {
        RoomData[] roomData = roomList.Rooms.ToArray();
        for (int i = 0; i < roomData.Length; i++)
        {
            roomList.Rooms[i].room_ID = i+1;
        }
    }
}
