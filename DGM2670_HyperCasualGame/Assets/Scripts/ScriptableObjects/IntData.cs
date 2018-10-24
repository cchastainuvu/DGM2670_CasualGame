using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntData : ScriptableObject 
{

    public int value;
    
    public virtual int Value
    {
        get {return value;}
    }
    
}
