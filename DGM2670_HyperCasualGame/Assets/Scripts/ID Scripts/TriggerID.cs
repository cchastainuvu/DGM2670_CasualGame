﻿using UnityEngine;
using UnityEngine.Events;

public class TriggerID : MonoBehaviour
{
    public NameID ID;
    public UnityEvent OnMatch;


    private void OnTriggerEnter(Collider obj)
    {
        if (ID == obj.GetComponent<ObjectID>().ID)
        {
            OnMatch.Invoke();
        }
    }

    //NEW RENDITION//
//    private void Invoke (Collider obj)
//    {
//        if ((ID == obj.GetComponent<ObjectID>().ID))
//        {
//            OnMatch.Invoke();
//            print("Match");
//        }
//        if (ID != obj.GetComponent<ObjectID>().ID)
//        {
//            print("No!");
//        }
//    }
}