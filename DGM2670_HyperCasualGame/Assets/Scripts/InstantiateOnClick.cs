using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InstantiateOnClick : MonoBehaviour
{

    public Transform Fill;
    public Transform Space;

    public void OnMouseDown()
    {
        Instantiate(Fill,Space.transform.position,Space.transform.rotation);
    }

}