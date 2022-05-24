using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A list is created and uses the singleton pattern from the codejam. The list "houses" RoomData.
/// </summary>

[System.Serializable]
public class RoomList : SingletonPattern<RoomList>
{
    private RoomList()
    {

    }

    public List<RoomData> Rooms = new List<RoomData>();

    /*private static RoomList _roomLists;
    public static RoomList Instance
    {
        get
        {
            if (_roomLists == null)
                _roomLists = new RoomList();

            return _roomLists;
        }
    }*/
}
