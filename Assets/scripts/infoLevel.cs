using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class infoLevel : MonoBehaviour
{
    public TMP_Text levelValueText, levelangkaText;
    public Slider sliderLevel;


    private void Update()
    {
        levelValueText.text = levelSystem.levelPersentase.ToString() + " / 1000";
        levelangkaText.text = levelSystem.levelAngka.ToString();


        //slider management
        sliderLevel.value = levelSystem.levelPersentase;
        sliderLevel.maxValue = 1000;
    }
}
