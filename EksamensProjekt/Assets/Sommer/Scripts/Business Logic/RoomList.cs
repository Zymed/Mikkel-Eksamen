using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A list is created and uses the singleton pattern from the codejam. The list "houses" RoomData.
/// It inherits from the CodeJam singletonpattern, as it was created I made my own singleton to it.
/// </summary>

public class RoomList : SingletonPattern<RoomList>
{
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
