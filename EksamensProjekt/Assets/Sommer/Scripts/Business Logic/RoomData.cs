using System.Collections;
using System.Collections.Generic;

/// <summary>
/// This script serves as a constructor for Data a Room MUST have.
/// </summary>

[System.Serializable]
public class RoomData
{
    public string room_name;
    public int room_ID;

    public RoomData(string roomName, int roomID)
    {
        room_name = roomName;
        room_ID = roomID;
    }
}
