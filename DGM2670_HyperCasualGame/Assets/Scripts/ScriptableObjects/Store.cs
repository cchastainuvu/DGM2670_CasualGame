using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Store", menuName = "Store/StoreFront")]
public class Store : ScriptableObject
{

    public Objects Available;
    public Objects Purchased;
    
    public void MakePurchase(Object obj)
    {
        //Checks if the object has already been purchased.
        foreach (var availableObject in Available.ObjectList)
        {
            if (availableObject == obj)
            {
                Purchased.ObjectList.Add(obj);
                Available.ObjectList.Remove(availableObject);
            }
        }
    }

}
