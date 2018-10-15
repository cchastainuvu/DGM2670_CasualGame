using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour {

    public void Invoke (SpriteRenderer obj)
    {
        GetComponent<SpriteRenderer>().sprite = obj.sprite;
    }
}
