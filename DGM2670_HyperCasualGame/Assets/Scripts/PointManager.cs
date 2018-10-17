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
        count = 0;
        Points.text = count.ToString();
    }

    public void AddPoints()
    {
        count = count + 10;
        Points.text = count.ToString();
        
    }

    public void TakePoints()
    {
        count = count - 10;
        Points.text = count.ToString();
    }
}
