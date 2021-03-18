using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIElementDragger : EventTrigger
{

    private bool dragging;
    private Vector2 offset;

    public void Update()
    {
        if (dragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y) + offset;
        }
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        dragging = true;
        offset = transform.position - new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        transform.SetAsLastSibling();
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        dragging = false;
    }
}

