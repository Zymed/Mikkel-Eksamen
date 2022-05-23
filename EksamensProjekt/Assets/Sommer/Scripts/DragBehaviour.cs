using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragBehaviour : MonoBehaviour, IDragHandler
{

    [SerializeField] private float smoothingSpeed = .05f;

    private RectTransform draggingObject;
    private Vector3 velocity = Vector3.zero;

    private void Awake()
    {
        draggingObject =  transform as RectTransform;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if(RectTransformUtility.ScreenPointToWorldPointInRectangle(draggingObject, eventData.position, eventData.pressEventCamera, out var globalMousePosition))
        {
            draggingObject.position = Vector3.SmoothDamp(draggingObject.position, globalMousePosition, ref velocity, smoothingSpeed);
        }
    }
}
