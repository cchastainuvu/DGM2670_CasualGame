using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnMouseExitEvent : MonoBehaviour
{

    public UnityEvent Event;

    private void OnMouseExit()
    {
        Event.Invoke();
    }
}
