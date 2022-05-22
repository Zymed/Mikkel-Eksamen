using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RoomList
{
    private RoomList()
    {

    }

    public List<RoomData> Rooms = new List<RoomData>();

    private static RoomList _roomLists;
    public static RoomList Instance
    {
        get
        {
            if (_roomLists == null)
                _roomLists = new RoomList();

            return _roomLists;
        }
    }
}
