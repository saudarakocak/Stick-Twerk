using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public float Score;
    public float BreakTimes;
    public TMP_Text scoreText;

    private void Update()
    {

        scoreText.text = "x " + Score;

        if (Score >= 100)
        {
            achievement.j1 = true;
        }
        if (Score >= 500)
        {
            achievement.j5 = true;
        }
        if (Score >= 1000)
        {
            achievement.j10 = true;
        }
        if (Score >= 10000)
        {
            achievement.j100 = true;
        }

        if (BreakTimes >= 10)
        {
            achievement.encok1 = true;
        }
        if (BreakTimes >= 50)
        {
            achievement.encok5 = true;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Score = 90;
        }
    }
}
