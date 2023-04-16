using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [HideInInspector]
    public bool isKeyPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        isKeyPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isKeyPressed = false;
    }
}
