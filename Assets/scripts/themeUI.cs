using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class themeUI : MonoBehaviour
{
    public GameObject[] ceklis;


    private void Update()
    {
        check_ceklis();
    }

    void unCeklis()
    {
        for (int i = 0; i < ceklis.Length; i++)
        {
            ceklis[i].gameObject.SetActive(false);
        }
    }
    void check_ceklis()
    {
        if (backgroundSetting.color1)
        {
            unCeklis();
            ceklis[0].gameObject.SetActive(true);
        }
        if (backgroundSetting.color2)
        {
            unCeklis();
            ceklis[1].gameObject.SetActive(true);
        }
        if (backgroundSetting.color3)
        {
            unCeklis();
            ceklis[2].gameObject.SetActive(true);
        }
        if (backgroundSetting.color4)
        {
            unCeklis();
            ceklis[3].gameObject.SetActive(true);
        }
        if (backgroundSetting.color5)
        {
            unCeklis();
            ceklis[4].gameObject.SetActive(true);
        }
        if (backgroundSetting.color6)
        {
            unCeklis();
            ceklis[5].gameObject.SetActive(true);
        }
    }
}
