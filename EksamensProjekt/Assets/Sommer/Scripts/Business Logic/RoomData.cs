using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class RoomData
{
    public string room_name;
    //public int room_ID;

    public RoomData(string roomName)
    {
        room_name = roomName;
    }
}
