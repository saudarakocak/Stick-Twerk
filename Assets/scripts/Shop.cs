using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{
    public int patokan;
    public Head[] Heads;
    public Image headImage, headImage2;
    public TMP_Text namaHead;
    public TMP_Text hargaHead;

    [Header("tombol")]
    public GameObject panahKanan;
    public GameObject panahKiri;

    [Header("condition Buy")]
    public GameObject ownedB;
    public GameObject usedB;
    public GameObject buyB;

    void belumbeli()
    {
        ownedB.gameObject.SetActive(false);
        usedB.gameObject.SetActive(false);
        buyB.gameObject.SetActive(true);
    }
    void sudahbeli()
    {
        ownedB.gameObject.SetActive(true);
        usedB.gameObject.SetActive(false);
        buyB.gameObject.SetActive(false);
    }
    void dipakai()
    {
        ownedB.gameObject.SetActive(false);
        usedB.gameObject.SetActive(true);
        buyB.gameObject.SetActive(false);
    }

    private void Start()
    {
        loadBuyedHistory();
        tidakCukupText.gameObject.SetActive(false);
        headImage.gameObject.SetActive(false);
    }

    private void Update()
    {
        ChangeGenerator();
        
        //harga ilang kalau sudah beli
        if (Heads[patokan].buyed)
        {
            hargaHead.gameObject.SetActive(false);
        }else
        {
            hargaHead.gameObject.SetActive(true);
        }

        //owned system
        if (headManagement.Headid == patokan)
        {
            dipakai();
        }else
        {
            if (Heads[patokan].buyed)
            {
                sudahbeli();
            }else
            {
                belumbeli();
            }
        }


        headImage.sprite = Heads[patokan].HeadImage;
        headImage2.sprite = Heads[patokan].HeadImage;

        //tombol kanan hilang
        if (patokan == Heads.Length - 1)
        {
            panahKanan.gameObject.SetActive(false);
        } else
        {
            panahKanan.gameObject.SetActive(true);
        }

        //tombol kiri hilang
        if (patokan == 0)
        {
            panahKiri.gameObject.SetActive(false);
        }else
        {
            panahKiri.gameObject.SetActive(true);
        }
    }

    //loadBuyedHistory
    void loadBuyedHistory()
    {
        for(int i = 0; i < Heads.Length; i++)
        {
            switch (i) {
                case 1:
                    Heads[i].buyed = levelSystem.HeadBug;
                    break;
                case 2:
                    Heads[i].buyed = levelSystem.HeadKawaii;
                    break;
                case 3:
                    Heads[i].buyed = levelSystem.HeadMonster;
                    break;
                case 4:
                    Heads[i].buyed = levelSystem.HeadNaruto;
                    break;
                case 5:
                    Heads[i].buyed = levelSystem.HeadOfficial;
                    break;
                case 6:
                    Heads[i].buyed = levelSystem.HeadSus;
                    break;
            }
        }
    }


    [Header("Effect")]
    public GameObject tidakCukupText;

    //beli system
    public void beliGunakan()
    {
        if (!Heads[patokan].buyed)
        {
            if (levelSystem.money >= Heads[patokan].harga)
            {
                levelSystem.money -= Heads[patokan].harga;
                Heads[patokan].buyed = true;
                buySaved();
            }
            else
            {
                tidakCukupText.gameObject.SetActive(true);
                FindObjectOfType<AudioManager>().play("NotEnoughMoney");
            }
        }else
        {
            headManagement.Headid = patokan;
        }
    }

    //void save data buy
    void buySaved()
    {
        switch (patokan)
        {
            case 1:
                levelSystem.HeadBug = true;
                break;
            case 2:
                levelSystem.HeadKawaii = true;
                break;
            case 3:
                levelSystem.HeadMonster = true;
                break;
            case 4:
                levelSystem.HeadNaruto = true;
                break;
            case 5:
                levelSystem.HeadOfficial = true;
                break;
            case 6:
                levelSystem.HeadSus = true;
                break;
        }

        FindObjectOfType<AudioManager>().play("Buy");
    }


    //button eksekusi


    public void tombolPanahKanan()
    {
        ilangGbr();
        Invoke("munculGbr1", 0.05f);
        patokan++;
    }
    public void tombolPanahKiri()
    {
        ilangGbr();
        Invoke("munculGbr2", 0.05f);
        patokan--;
    }

    void munculGbr1()
    {
        headImage.gameObject.SetActive(true);
    }
    void munculGbr2()
    {
        headImage2.gameObject.SetActive(true);
    }
    void ilangGbr()
    {
        headImage.gameObject.SetActive(false);
        headImage2.gameObject.SetActive(false);
    }


    void ChangeGenerator()
    {
        switch (patokan)
        {
            case 0:
                namaHead.text = "Default Head";
                hargaHead.text = "-";
                break;
            case 1:
                namaHead.text = "Bug Head";
                hargaHead.text = "$35";
                break;
            case 2:
                namaHead.text = "Kawaii Head";
                hargaHead.text = "$35";
                break;
            case 3:
                namaHead.text = "Monster Head";
                hargaHead.text = "$55";
                break;
            case 4:
                namaHead.text = "Nartoo Head";
                hargaHead.text = "$70";
                break;
            case 5:
                namaHead.text = "Saudara Kocak";
                hargaHead.text = "$75";
                break;
            case 6:
                namaHead.text = "Sus";
                hargaHead.text = "$95";
                break;
        }
    }

    public void normalCondition()
    {
        patokan = 0;
    }
}
