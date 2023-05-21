using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class dataPlayer
{
    public int money;
    public float levelpersentase;
    public int levelAngka;
    public bool djarak100, djarak500, djarak1000, djarak10000, dencok10, dencok50;
    public bool HeadBug, HeadKawaii, HeadMonster, HeadNaruto, HeadOfficial, HeadSus;
    public int headChose;

    public dataPlayer(levelSystem score)
    {
        money = score.moneyData;
        levelpersentase = score.levelPersentaseData;
        levelAngka = score.levelAngkaData;
        djarak100 = achievement.j1;
        djarak500 = achievement.j5;
        djarak1000 = achievement.j10;
        djarak10000 = achievement.j100;
        dencok10 = achievement.encok1;
        dencok50 = achievement.encok5;

        HeadBug = levelSystem.HeadBug;
        HeadKawaii = levelSystem.HeadKawaii;
        HeadMonster = levelSystem.HeadMonster;
        HeadNaruto = levelSystem.HeadNaruto;
        HeadOfficial = levelSystem.HeadOfficial;
        HeadSus = levelSystem.HeadSus;

        headChose = headManagement.Headid;

    }


}
