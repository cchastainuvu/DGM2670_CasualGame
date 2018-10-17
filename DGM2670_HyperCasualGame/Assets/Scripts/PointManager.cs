﻿using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    private float count;
    public Text Points;
    public Text WinText;
    public FloatData WinScore;

    void Start()
    {
        count = 0;
        Points.text = count.ToString(CultureInfo.InvariantCulture);
        
        WinText.GetComponent<Text>().enabled = false;
    }

    public void AddPoints()
    {
        count = count + 10;
        Points.text = count.ToString(CultureInfo.InvariantCulture);
        
    }

    public void TakePoints()
    {
        count = count - 10;
        Points.text = count.ToString(CultureInfo.InvariantCulture);
    }

//    public void Win()
//    {
//        if (count >= WinScore.value)
//        {
//            WinText.GetComponent<Text>().enabled = true;
//        }
//    }
}
