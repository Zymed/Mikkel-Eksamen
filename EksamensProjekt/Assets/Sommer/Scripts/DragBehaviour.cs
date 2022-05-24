using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragBehaviour : MonoBehaviour, IDragHandler
{

    [SerializeField] private float smoothingSpeed = .05f;
    [SerializeField] private GameObject timerPrefab;
    private bool isDragging;

    private RectTransform draggingObject;
    private Vector3 velocity = Vector3.zero;

    private void Awake()
    {
        draggingObject =  transform as RectTransform;
    }

    public void OnDrag(PointerEventData eventData)
    {
        isDragging = eventData.dragging;
        if(RectTransformUtility.ScreenPointToWorldPointInRectangle(draggingObject, eventData.position, eventData.pressEventCamera, out var globalMousePosition))
        {
            draggingObject.position = Vector3.SmoothDamp(draggingObject.position, globalMousePosition, ref velocity, smoothingSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isDragging)
        {
            Destroy(gameObject);

            foreach(RoomData data in RoomList.Instance.Rooms.ToArray())
            {
                if(int.Parse(gameObject.name) == data.room_ID)
                {
                    Debug.Log("Deleted");
                    RoomList.Instance.Rooms.Remove(data);
                    UpdateRoomData();
                }
            }
        }
    }

    private void UpdateRoomData()
    {
        RoomData[] roomData = RoomList.Instance.Rooms.ToArray();
        for (int i = 0; i < roomData.Length; i++)
        {
            RoomList.Instance.Rooms[i].room_ID = i;
        }
    }
}
