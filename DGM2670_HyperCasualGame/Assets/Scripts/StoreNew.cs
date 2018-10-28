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
//    public int TotalValue = 3000;

    public UnityEvent MadePurchase;

    public void MakePurchase(PurchasableObject obj)
    {
        for (var i = 0; i <Available.ObjectList.Count; i++)
        {
            //Casting (as + name of Object you would like your Object to behave as.)
            PurchasableObject availableObject = Available.ObjectList[i] as PurchasableObject;

            if (availableObject == obj && Cash.Value >= availableObject.Value)
            {
                Cash.Value -= availableObject.Value;
                Purchased.ObjectList.Add(obj);
                Available.ObjectList.Remove(availableObject);
                MadePurchase.Invoke();
            }
        }
    }
}

