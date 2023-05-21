using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject menuButton, menuPage;
    public GameObject transisi;
    public Animator animasi, animasiButton;

    private void Start()
    {
        transisi.gameObject.SetActive(false);
        menuButton.gameObject.SetActive(true);
        menuPage.gameObject.SetActive(false);
    }

    public void klikMenuButton()
    {
        cooldownManager.pause = true;
        animasiButton.SetBool("isClick", true);
        menuPage.gameObject.SetActive(true);
    }

    public void resume()
    {
        cooldownManager.pause = false;
        animasi.SetBool("klik", true);
    }
    public void exit()
    {
        cooldownManager.pause = false;
        transisi.gameObject.SetActive(true);
        Invoke("toMainMenu", 1);
    }
    public void restart()
    {
        cooldownManager.pause = false;
        transisi.gameObject.SetActive(true);
        Invoke("RestartGame", 1);
    }
    private void RestartGame()

    { 
        cooldownManager.pause = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void toMainMenu()
    {
        SceneManager.LoadScene("mainmenu");
        cooldownManager.pause = false;
    }
}
