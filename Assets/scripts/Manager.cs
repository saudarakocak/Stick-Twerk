using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject player, Joget, button1, button2;
    public Animator joget;

    private void Start()
    {
        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        joget.gameObject.SetActive(false);
        player.gameObject.SetActive(true);
        Invoke("playerAnimation", 4);
    }

    private void Update()
    {
        
    }

    private void playerAnimation()
    {
        player.gameObject.SetActive(false);
        Joget.gameObject.SetActive(true);
        button1.gameObject.SetActive(true);
    }

    public void Doit1()
    {
        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(true);
        joget.SetBool("Joget", true);
    }
    public void Doit2()
    {
        button1.gameObject.SetActive(true);
        button2.gameObject.SetActive(false);
        joget.SetBool("Joget", false);
    }
}
