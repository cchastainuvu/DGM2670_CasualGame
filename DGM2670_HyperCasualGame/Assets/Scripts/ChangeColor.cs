using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Changes the object's color OnTrigger.//
public class ChangeColor : MonoBehaviour 
{
    //TEST RENDITION//
    public void Invoke (SpriteRenderer obj)
    {
        GetComponent<SpriteRenderer>().color = obj.color;
    }
    
    //OLD RENDITION//
//    private void OnTriggerEnter(Collider obj)
//    {
//        GetComponent <SpriteRenderer>().color =
//            obj.GetComponent<SpriteRenderer>().color;
//    }

    
    //NEW RENDITION//
//    public void Invoke(SpriteRenderer obj)
//    {
//        GetComponent<SpriteRenderer>().color = obj.color;
//    }
    
}
