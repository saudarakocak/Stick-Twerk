    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class achievement : MonoBehaviour
{
    //100, 500, 1000, 10000, 100000, 1000(tanpa salah), 10 encok dalam 1 match, 50 encok dalam 1 match, 
    public GameObject jarak100, jarak500, jarak1000, jarak10000, encok10, encok50;
    public static bool j1, j5, j10, j100, encok1, encok5;

    private void Update()
    {
        if (j1 == true)
        {
            jarak100.gameObject.SetActive(true);
        }
        else
        {
            jarak100.gameObject.SetActive(false);
        }
        

        if (j5 == true)
        {
            jarak500.gameObject.SetActive(true);
        }
        else 
        {
            jarak500.gameObject.SetActive(false);
        }


        if (j10 == true)
        {
            jarak1000.gameObject.SetActive(true);
        }
        else
        {
            jarak1000.gameObject.SetActive(false);
        }


        if (j100 == true)
        {
            jarak10000.gameObject.SetActive(true);
        }
        else
        {
            jarak10000.gameObject.SetActive(false);
        }


        if (encok1 == true)
        {
            encok10.gameObject.SetActive(true);
        }
        else
        {
            encok10.gameObject.SetActive(false);
        }

        if (encok5 == true)
        {
            encok50.gameObject.SetActive(true);
        }
        else
        {
            encok50.gameObject.SetActive(false);
        }
    }
}
