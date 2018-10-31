using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    private float count;
    public Text Points;
//    public Text WinText;
    
    public FloatData WinScore;

    public UnityEvent OnWin;

    void Start()
    {
        count = 0;
        Points.text = count.ToString(CultureInfo.InvariantCulture);
        
//        WinText.GetComponent<Text>().enabled = false;
        
    }

    public void AddPoints()
    {
        count = count + 10;
        Points.text = count.ToString(CultureInfo.InvariantCulture);

        Win();

    }

    public void TakePoints()
    {
        count = count - 10;
        Points.text = count.ToString(CultureInfo.InvariantCulture);
    }

    private void Win()
    {
        if (count >= WinScore.Value)
        {

            OnWin.Invoke();
//            WinText.GetComponent<Text>().enabled = true;
//            //STILL A WORK IN PROGRESS.

        }
    }
}
