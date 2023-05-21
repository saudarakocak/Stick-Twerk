using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class info_game_over : MonoBehaviour
{
    public int moneyTempComp, moneyTemp;
    public float levelTempComp, levelTemp;
    public TMP_Text levelText, moneyText;

    private void Start()
    {
        Invoke("delay", 0.5f);
    }

    void delay()
    {
        levelTemp = 0;
        moneyTemp = 0;
        levelTempComp = levelSystem.levelPersentase;
        moneyTempComp = levelSystem.money;
    }

    private void Update()
    {
        levelTemp = levelTempComp - levelSystem.levelPersentase;
        moneyTemp = moneyTempComp - levelSystem.money;

        levelText.text = "+" + Mathf.Abs(levelTemp).ToString();
        moneyText.text = "+" + Mathf.Abs(moneyTemp).ToString();
    }



}
