using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headManagement : MonoBehaviour
{
    public GameObject[] HeadCollection;
    public static int Headid;

    void allHeadHide()
    {
        for (int i = 0; i < HeadCollection.Length; i++)
        {
            HeadCollection[i].gameObject.SetActive(false);
        }
    }
        
    private void Start()
    {
        allHeadHide();
    }
    private void Update()
    {
        switch (Headid)
        {
            case 0:
                HeadCollection[0].gameObject.SetActive(true);
                break;
            case 1:
                HeadCollection[1].gameObject.SetActive(true);
                break;
            case 2:
                HeadCollection[2].gameObject.SetActive(true);
                break;
            case 3:
                HeadCollection[3].gameObject.SetActive(true);
                break;
            case 4:
                HeadCollection[4].gameObject.SetActive(true);
                break;
            case 5:
                HeadCollection[5].gameObject.SetActive(true);
                break;
            case 6:
                HeadCollection[6].gameObject.SetActive(true);
                break;
        } 
    }
}
