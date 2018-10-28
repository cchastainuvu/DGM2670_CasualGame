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
    public int TotalValue = 160;
    //20 less than the 2 locked levels total
    //Doesn't need to be an Int/FloatData, because only the Store needs to know.

    public UnityEvent MadePurchase;

    public void MakePurchase(PurchasableObject obj)
    {
        for (var i = 0; i <Available.ObjectList.Count; i++)
        {
            //Casting (as + name of Object you would like your Object to behave as.)
            PurchasableObject availableObject = Available.ObjectList[i] as PurchasableObject;

            if (availableObject == obj && Cash.Value >= availableObject.Value)
            {
                //Unsure why this is throwing an error, our FloatData scripts are the same. Same occurs with IntData.
                Cash.Value -= availableObject.Value;
                Purchased.ObjectList.Add(obj);
                Available.ObjectList.Remove(availableObject);
                MadePurchase.Invoke();
            }
        }
    }

    public void PurchaseAll()
    {
        if (Cash.Value >= TotalValue)
        {
            foreach (var item in Available.ObjectList)
            {
                Cash.Value -= TotalValue;
                Purchased.ObjectList.Add(item);
                Available.ObjectList.Remove(item);
            }
        }
    }
}

