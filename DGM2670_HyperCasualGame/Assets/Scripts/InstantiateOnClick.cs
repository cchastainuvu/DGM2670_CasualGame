using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InstantiateOnClick : MonoBehaviour
{

    public Transform Fill;
    public Transform Space;
    public bool Filled;

    public void OnMouseDown()
    {

        if (!Filled)
        {
           Instantiate(Fill,Space.transform.position,Space.transform.rotation);
            Filled = true;
        }
    }
}
