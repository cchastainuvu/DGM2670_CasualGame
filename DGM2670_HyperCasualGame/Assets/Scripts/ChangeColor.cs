using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Changes the object's color OnTrigger.//
public class ChangeColor : MonoBehaviour 
{
    public void Invoke(SpriteRenderer obj)
    {
        GetComponent<SpriteRenderer>().color = obj.color;
    }
}
