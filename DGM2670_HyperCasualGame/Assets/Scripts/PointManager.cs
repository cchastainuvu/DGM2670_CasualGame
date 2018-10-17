using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    private int count;
    public Text Points;

    void Start()
    {
        Points = GetComponent<Text>();
        count = 0;

    }

    public void AddPoints()
    {
        
    }
}
