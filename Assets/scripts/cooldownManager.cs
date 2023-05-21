using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cooldownManager : MonoBehaviour
{
    public float cooldownValue, theIncreament;
    public Slider slider;
    public score Score;
    public encok encok;
    public GameObject loseBorder;
    public GameObject encokFx;

    public static bool pause;

    private void Start()
    {
        encokFx.gameObject.SetActive(false);
        loseBorder.gameObject.SetActive(false);

        theIncreament = 3;
        slider.maxValue = 100;
        cooldownValue = 100;
    }
    int nilaiRand;
    private void Update()
    {
        if (!pause)
        {
            cooldownValue -= (Time.deltaTime) * theIncreament;
        }
        increment();

        //slider conf
        slider.value = cooldownValue;

        //lose
        if (cooldownValue <= 0)
        {
            loseBorder.gameObject.SetActive(true);
            pause = true;
        }

        nilaiRand = Random.Range(0, 2);
    }

    public void tap()
    {
        if (cooldownValue > 50)
        {
            encok.encokLevel++;
            encokFx.gameObject.SetActive(true);
        }

        cooldownValue = 100;
        Score.Score++;
        levelSystem.money += nilaiRand;

        
    }

    private void increment()
    {

        if (Score.Score >= 10 && Score.Score < 20)
        {
            theIncreament = 10;
        }else if (Score.Score >= 20 && Score.Score < 30)
        {
            theIncreament = 20;
        }
        else if (Score.Score >= 30 && Score.Score < 40)
        {
            theIncreament = 30;
        }
        else if (Score.Score >= 40 && Score.Score < 50)
        {
            theIncreament = 40;
        }
        else if (Score.Score >= 50 && Score.Score < 60)
        {
            theIncreament = 50;
        }
        else if (Score.Score >= 60 && Score.Score < 70)
        {
            theIncreament = 60;
        }
        else if (Score.Score >= 70 && Score.Score < 80)
        {
            theIncreament = 70;
        }
        else if (Score.Score >= 80 && Score.Score < 90)
        {
            theIncreament = 90;
        }
        else if (Score.Score >= 90 && Score.Score < 100)
        {
            theIncreament = 100;
        }
        else if (Score.Score >= 100 && Score.Score < 110)
        {
            theIncreament = 130;
        }
        else if (Score.Score >= 110 && Score.Score < 120)
        {
            theIncreament = 160;
        }
        else if (Score.Score >= 120 && Score.Score < 130)
        {
            theIncreament = 190;
        }
        else if (Score.Score >= 130 && Score.Score < 140)
        {
            theIncreament = 250;
        }
        else if (Score.Score >= 140 && Score.Score < 150)
        {
            theIncreament = 300;
        }
        else if (Score.Score >= 150 && Score.Score < 160)
        {
            theIncreament = 350;
        }
        else if (Score.Score >= 160 && Score.Score < 170)
        {
            theIncreament = 400;
        }
        else if (Score.Score >= 170 && Score.Score < 180)
        {
            theIncreament = 500;
        }
        else if (Score.Score >= 180 && Score.Score < 190)
        {
            theIncreament = 600;
        }
        else if (Score.Score >= 190 && Score.Score < 200)
        {
            theIncreament = 800;
        }
    }
}
