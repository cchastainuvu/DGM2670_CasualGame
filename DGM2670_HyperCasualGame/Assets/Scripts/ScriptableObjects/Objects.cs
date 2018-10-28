using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Object", menuName = "Store/Objects")]
public class Objects : ScriptableObject
{
    public List<Object> ObjectList;
    //Object is a generic term in Unity meaning it will take any object.
}
