using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Purchase", menuName = "StoreNew/Purchasable")]
public class PurchasableObject : ScriptableObject
{

    public Object Item;
    public float Value;

}
