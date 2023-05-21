using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerUsing : MonoBehaviour
{
    public Sprite[] Heads;
    public Image thisItem;

    private void Update()
    {
        switch (headManagement.Headid)
        {
            case 0:
                thisItem.sprite = Heads[0];
                break;
            case 1:
                thisItem.sprite = Heads[1];
                break;
            case 2:
                thisItem.sprite = Heads[2];
                break;
            case 3:
                thisItem.sprite = Heads[3];
                break;
            case 4:
                thisItem.sprite = Heads[4];
                break;
            case 5:
                thisItem.sprite = Heads[5];
                break;
            case 6:
                thisItem.sprite = Heads[6];
                break;
        }
    }
}
