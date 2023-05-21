using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundSetting : MonoBehaviour
{
    public Camera kamera;

    public static bool
        color1,
        color2,
        color3,
        color4,
        color5,
        color6;
    public Color
        white,
        grey,
        green,
        purple,
        blue,
        yellow;


    private void Start()
    {
        FindObjectOfType<AudioManager>().play("backsound");
    }
    private void Update()
    {
        colorSelection();
    }

    void colorSelection()
    {
        if (color1)
        {
            kamera.backgroundColor = white;
        } else if (color2)
        {
            kamera.backgroundColor = grey;
        }
        else if (color3)
        {
            kamera.backgroundColor = green;
        }
        else if (color4)
        {
            kamera.backgroundColor = purple;
        }
        else if (color5)
        {
            kamera.backgroundColor = blue;
        }
        else if (color6)
        {
            kamera.backgroundColor = yellow;
        }
    }

    void allColorOff()
    {
        color1 = false;
        color2 = false;
        color3 = false;
        color4 = false;
        color5 = false;
        color6 = false;

    }

    public void buttonWhite()
    {
        allColorOff();
        color1 = true;
    }
    public void buttonGrey()
    {
        allColorOff();
        color2 = true;
    }
    public void buttonGreen()
    {
        allColorOff();
        color3 = true;
    }
    public void buttonPurple()
    {
        allColorOff();
        color4 = true;
    }
    public void buttonBlue()
    {
        allColorOff();
        color5 = true;
    }
    public void buttonYellow()
    {
        allColorOff();
        color6 = true;
    }
}
