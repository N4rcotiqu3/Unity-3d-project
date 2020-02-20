using UnityEngine;
using UnityEngine.EventSystems;

public class JoyStick_IDK : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    [HideInInspector]
    protected bool Pressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }
}
