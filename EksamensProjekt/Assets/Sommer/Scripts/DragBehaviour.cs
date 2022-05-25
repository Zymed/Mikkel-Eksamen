using UnityEngine;
using UnityEngine.EventSystems;

//This script is made from via. the YouTuber SamYam in the following video: https://www.youtube.com/watch?v=XCoDKZqa-PE&ab_channel=samyam
public class DragBehaviour : MonoBehaviour, IDragHandler
{

    [SerializeField] private float smoothingSpeed = .05f;
    [SerializeField] private GameObject timerPrefab;
    public static bool IS_DRAGGING;

    private RectTransform draggingObject;
    private Vector3 velocity = Vector3.zero;

    private void Awake()
    {
        draggingObject =  transform as RectTransform;
    }

    /// <summary>
    /// Sets the Static boolean true when the object is dragged.
    /// 
    /// </summary>
    public void OnDrag(PointerEventData eventData)
    {
        IS_DRAGGING = eventData.dragging;
        if(RectTransformUtility.ScreenPointToWorldPointInRectangle(draggingObject, eventData.position, eventData.pressEventCamera, out var globalMousePosition))
        {
            draggingObject.position = Vector3.SmoothDamp(draggingObject.position, globalMousePosition, ref velocity, smoothingSpeed);
        }
    }
}
