using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class encok : MonoBehaviour
{
    public GameObject buttonDoit1, buttonDoit2, buttonDoitLock;
    public GameObject[] playerEncok;
    public GameObject[] playernormal;

    public float encokLevel;
    public Slider slider;
    public score score;

    public bool fixEncok;
    private bool notTimesIncreament;

    void encokAja()
    {
        for (int i = 0; i < playerEncok.Length; i++)
        {
            playerEncok[i].gameObject.SetActive(false);
        }
    }
    void toEncok()
    {
        
        for (int i = 0; i < playerEncok.Length; i++)
        {
            playerEncok[i].gameObject.SetActive(true);
            playernormal[i].gameObject.SetActive(false);
        }
    }
    void toNormal()
    {
        for (int i = 0; i < playerEncok.Length; i++)
        {
            playerEncok[i].gameObject.SetActive(false);
            playernormal[i].gameObject.SetActive(true);
        }
    }

    private void Start()
    {
        encokAja();
        buttonDoitLock.gameObject.SetActive(false);
        encokLevel = 0;
        slider.maxValue = 10;
    }

    bool encokSound;
    private void Update()
    {
        if (!cooldownManager.pause)
        {
            //batas
            if (encokLevel <= 0)
            {
                encokLevel = 0;
            }

            //rule
            if (encokLevel >= 10)
            {
                fixEncok = true;
                encokSound = true;
            }

            if (encokSound)
            {
                FindObjectOfType<AudioManager>().play("BoneCrack");
                encokSound = false;
            }

            if (fixEncok)
            {
                

                toEncok();

                buttonDoit1.gameObject.SetActive(false);
                buttonDoit2.gameObject.SetActive(false);
                buttonDoitLock.gameObject.SetActive(true);
                if (!notTimesIncreament)
                {
                    score.BreakTimes++;
                    notTimesIncreament = true;
                }

                encokLevel -= Time.deltaTime * 3;
                if (encokLevel <= 0)
                {
                    fixEncok = false;
                    notTimesIncreament = false;
                    toNormal();

                    buttonDoit1.gameObject.SetActive(true);
                    buttonDoit2.gameObject.SetActive(false);
                    buttonDoitLock.gameObject.SetActive(false);
                }
            }
            else
            {
                encokLevel -= Time.deltaTime / 5;
            }
        }


        //slider conf
        slider.value = encokLevel;
    }
}
