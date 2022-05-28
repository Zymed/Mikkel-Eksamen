using UnityEngine;
using UnityEngine.EventSystems;

//This script is made from via. the YouTuber SamYam in the following video: https://www.youtube.com/watch?v=XCoDKZqa-PE&ab_channel=samyam
public class DragBehaviour : MonoBehaviour, IDragHandler
{

    [SerializeField] private float smoothingSpeed = .05f;
    [SerializeField] private GameObject roomPrefab;
    public static bool IS_DRAGGING;

    private RectTransform draggingObject;
    private Vector3 velocity = Vector3.zero;


    //Gets the RectTransform of the object this script is attached to.
    private void Awake()
    {
        draggingObject =  transform as RectTransform;
    }

    /// <summary>
    /// Sets the Static boolean true when the object is dragged.
    /// RectTransformUtility.ScreenTo... turns a screen space point into to a position in world space, 
    /// that is on a plane (canvas) of a given rect transform.
    /// This method is copy pasted from the tutorial mentioned above in this script by SamYam.
    /// </summary>
    public void OnDrag(PointerEventData eventData)
    {
        IS_DRAGGING = eventData.dragging;
        if(RectTransformUtility.ScreenPointToWorldPointInRectangle
            (draggingObject, eventData.position, eventData.pressEventCamera, out var globalMousePosition))
        {
            draggingObject.position = Vector3.SmoothDamp(draggingObject.position, globalMousePosition, ref velocity, smoothingSpeed);
        }
    }
}
