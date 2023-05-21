using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorUImanagement : MonoBehaviour
{
    public GameObject Selected1, Selected2, Selected3;

    void allUnselectSelect()
    {
        Selected1.gameObject.SetActive(false);
        Selected2.gameObject.SetActive(false);
        Selected3.gameObject.SetActive(false);
    }

    private void Update()
    {
        switch (buttonTheme.uiTheme)
        {
            case 0:
                allUnselectSelect();
                Selected1.gameObject.SetActive(true);
                break;
            case 1:
                allUnselectSelect();
                Selected2.gameObject.SetActive(true);
                break;
            case 2:
                allUnselectSelect();
                Selected3.gameObject.SetActive(true);
                break;
        }
    }
}
