using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject transisi;
    public GameObject HomePage, AchievementPage, ShopPage;

    private void Start()
    {
        transisi.gameObject.SetActive(false);
    }

    public void restartScore()
    {
        levelSystem.money = 0;
        levelSystem.levelAngka = 0;
        levelSystem.levelPersentase = 0;
        achievement.j1 = false;
        achievement.j5 = false;
        achievement.j10 = false;
        achievement.j100 = false;
        achievement.encok1 = false;
        achievement.encok5 = false;
        levelSystem.HeadBug = false;
        levelSystem.HeadKawaii = false;
        levelSystem.HeadNaruto = false;
        levelSystem.HeadSus = false;
        levelSystem.HeadOfficial = false;
        levelSystem.HeadMonster = false;

        headManagement.Headid = 0;

        Invoke("refreshScene", 0.5f);
    }

    void refreshScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void playGame()
    {
        transisi.gameObject.SetActive(true);
        Invoke("toGame", 1.5f);
    }
    private void toGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Achievement()
    {
        pindahKeAchive();
    }
    private void pindahKeAchive()
    {
        HomePage.gameObject.SetActive(false);
        AchievementPage.gameObject.SetActive(true);
    }
    public void Shop()
    {
        pindahKeShop();
    }
    private void pindahKeShop()
    {
        HomePage.gameObject.SetActive(false);
        ShopPage.gameObject.SetActive(true);
    }
}
