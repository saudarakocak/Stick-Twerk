using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class buttonTheme : MonoBehaviour
{
    public static int uiTheme = 0;
    public Image[] button;
    public TMP_Text[] text;


    public void buttonChoseUI(int x)
    {
        uiTheme = x;
    }

    private void Update()
    {
        colorChange();
        
    }

    void colorChange()
    {
        switch (uiTheme)
        {
            case 0:
                changer(
                    new Color32(255, 188, 81, 255),
                    new Color32(101, 255, 76, 255),
                    new Color32(8, 144, 0, 255),
                    new Color32(0, 162, 190, 255),
                    new Color32(50, 50, 50, 255),
                    new Color32(50, 50, 50, 255)
                    );
                break;
            case 1:
                changer(
                    new Color32(255, 251, 105, 255),
                    new Color32(255, 255, 255, 255),
                    new Color32(4, 58, 0, 255),
                    new Color32(255, 255, 255, 255),
                    new Color32(50, 50, 50, 255),
                    new Color32(50, 50, 50, 255)
                    );
                break;
            case 2:
                changer(
                    new Color32(0, 0, 0, 255),
                    new Color32(255, 255, 255, 255),
                    new Color32(0, 0, 0, 255),
                    new Color32(0, 0, 0, 255),
                    new Color32(255, 255, 255, 255),
                    new Color32(0, 0, 0, 255)
                    );
                break;
        }
    }

    private void changer(
        Color32 mainColor,
        Color32 secondColor, 
        Color32 maincolorText, 
        Color32 secondcolorText,
        Color32 textButtonColor1,
        Color32 textButtonColor2
        )
    {
        button[0].color = mainColor;
        button[1].color = mainColor;
        button[2].color = secondColor;

        text[0].color = maincolorText;
        text[1].color = secondcolorText;

        text[2].color = textButtonColor1;
        text[3].color = textButtonColor1;
        text[4].color = textButtonColor2;
    }
}
