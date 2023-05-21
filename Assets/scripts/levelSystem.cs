using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class levelSystem : MonoBehaviour
{
    public static int money;
    public int moneyData;

    public TMP_Text moneyText;


    public static float levelPersentase; // real level
    public static int levelAngka;
    public float levelPersentaseData; 
    public int levelAngkaData;
    public bool jarak100, jarak500, jarak1000, jarak10000, tanpasalah, encok10, encok50;
    [Header("head")]
    public static bool HeadBug, HeadKawaii, HeadMonster, HeadNaruto, HeadOfficial, HeadSus;


    public TMP_Text levelText;
    public Slider levelSlider;

    private void Start()
    {
        loadFile();
    }

    private void Update()
    {
        Debug.Log(HeadBug);

        savefile();


        //achievement LOAD
        jarak100 = achievement.j1;
        jarak500 = achievement.j5;
        jarak1000 = achievement.j10;
        jarak10000 = achievement.j100;
        encok10 = achievement.encok1;
        encok50 = achievement.encok5;

        //level LOAD
        levelPersentaseData = levelPersentase;
        levelAngkaData = levelAngka;

        //money LOAD
        moneyData = money;
        moneyText.text = "$ " + moneyData;

        //UI management
        levelText.text = "Lv " + levelAngka;
        levelSlider.value = levelPersentase;
        levelSlider.maxValue = 1000;

        



        //level management
        if (levelPersentase >= 1000)
        {
            FindObjectOfType<AudioManager>().play("LevelUp");
            levelPersentase = 0;
            levelAngka++;
        }



    }


    public void increaseLevel()
    {
        levelPersentase += 2;
    }

    public void savefile()
    {
        saveSystem.SaveData(this);
    }
    public void loadFile()
    {
        dataPlayer x = saveSystem.LoadData();
        if (x != null)
        {
            money = x.money;

            levelPersentase = x.levelpersentase;
            levelAngka = x.levelAngka;

            achievement.j1 = x.djarak100;
            achievement.j5 = x.djarak500;
            achievement.j10 = x.djarak1000;
            achievement.j100 = x.djarak10000;
            achievement.encok1 = x.dencok10;
            achievement.encok5 = x.dencok50 ;

            HeadBug = x.HeadBug;
            HeadKawaii = x.HeadKawaii;
            HeadNaruto = x.HeadNaruto;
            HeadSus = x.HeadSus;
            HeadOfficial = x.HeadOfficial;
            HeadMonster = x.HeadMonster;

            headManagement.Headid = x.headChose;
        }
    }
}
