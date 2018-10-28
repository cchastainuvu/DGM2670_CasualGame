using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu (fileName = "StoreNew", menuName = "StoreNew/NewStoreFront")]
public class StoreNew : ScriptableObject
{

    public Objects Available;
    public Objects Purchased;
    public FloatData Cash;
    public int TotalValue = 3000;

    public void MakePurchase(Object obj)
    {
        for (var i = 0; i <Available.ObjectList.Count; i++)
        {
            var availableObject = Available.ObjectList[i];

            if (availableObject == obj)
            {
                Purchased.ObjectList.Add(obj);
                Available.ObjectList.Remove(availableObject);
            }
        }
    }
}

