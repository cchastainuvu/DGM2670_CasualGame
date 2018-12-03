using System.Globalization;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class NewPointManager : MonoBehaviour
{

    public float Count, Wallet;
    public Text Points;

    public FloatData WinScore;

    public UnityEvent OnWin, Unlock;

    void Start()
    {
        Count = 0;
        Wallet = 0;
        Points.text = Count.ToString(CultureInfo.InvariantCulture) + " / " +
                      WinScore.Value.ToString(CultureInfo.InvariantCulture);
    }


    //POINT ALTERATION FUNCTIONS//

    public void AddPoints()
    {
        Count = Count + 10;
        Points.text = Count.ToString(CultureInfo.InvariantCulture) + " / " + WinScore.Value;

        Win();
    }

    public void TakePoints()
    {
        Count = Count - 10;
        Points.text = Count.ToString(CultureInfo.InvariantCulture) + " / " + WinScore.Value;
    }

    private void Win()
    {
        if (Count >= WinScore.Value)
        {
            Wallet = Wallet + WinScore.Value;

            OnWin.Invoke();
        }

        if (Wallet == WinScore.Value)
        {
            Unlock.Invoke();
        }

    }
}
