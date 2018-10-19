using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeSprite : MonoBehaviour
{

    public UnityEvent OnStart;
    
    public void Start()
    {
        OnStart.Invoke();
    }
    
    public void Invoke (SpriteRenderer obj)
    {
        GetComponent<SpriteRenderer>().sprite = obj.sprite;
    }
}
