using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial : MonoBehaviour
{
    public Image Target;
    public Sprite[] imageTutorial;
    public GameObject nextButton, previousButton;
    public int patokan;

    void allOffImage()
    {
        for(int i = 0; i < imageTutorial.Length; i++)
        {
            Target.sprite = null;
        }
    }

    public void toNextButton()
    {
        allOffImage();
        patokan++;

    }
    public void toPreviousButton()
    {
        allOffImage();
        patokan--;
    }

    private void Start()
    {
        patokan = 0;
    }

    void normalCondition()
    {
        previousButton.gameObject.SetActive(true);
        nextButton.gameObject.SetActive(true);
    }

    private void Update()
    {
        Target.sprite = imageTutorial[patokan];

        //button management
        if (patokan == 0)
        {
            previousButton.gameObject.SetActive(false);
            nextButton.gameObject.SetActive(true);
        }else if (patokan >= imageTutorial.Length - 1)
        {
            previousButton.gameObject.SetActive(true);
            nextButton.gameObject.SetActive(false);
        }else
        {
            normalCondition();
        }
    }

    public void normalPatokan()
    {
        patokan = 0;
    }
}
