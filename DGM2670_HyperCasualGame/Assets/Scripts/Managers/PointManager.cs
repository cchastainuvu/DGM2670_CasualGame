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

    public FloatData WinScore;
    public float Wallet;

    public UnityEvent OnWin;

    void Start()
    {
        count = 0;
        Wallet = 0;
        Points.text = count.ToString(CultureInfo.InvariantCulture) + " / " + WinScore.Value.ToString(CultureInfo.InvariantCulture);
    }

    public void AddPoints()
    {
        count = count + 10;
        Points.text = count.ToString(CultureInfo.InvariantCulture) + " / " + WinScore.Value;

        Win();

    }

    public void TakePoints()
    {
        count = count - 10;
        Points.text = count.ToString(CultureInfo.InvariantCulture) + " / " + WinScore.Value;
    }

    private void Win()
    {
        if (count >= WinScore.Value)
        {
            Wallet = Wallet + WinScore.Value;
            //Would like this to add points to the player's "wallet" after they solve the level.

            OnWin.Invoke();
            //This works fine.
        }

    }
    
}
