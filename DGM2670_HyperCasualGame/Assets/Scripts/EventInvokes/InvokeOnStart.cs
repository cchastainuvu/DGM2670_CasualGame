using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InvokeOnStart : MonoBehaviour
{

    public UnityEvent OnStart;
    
    public void Start()
    {
        OnStart.Invoke();
    }
}
