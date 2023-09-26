using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TownManager : MonoBehaviour
{
    public GameObject[] panels,Shops,prices,VFX;
    public Text candiesstxt;
    int candies,whichpanel;
    public AudioSource buildsound,bttnsound;
    void Start()
    {
        candies = PlayerPrefs.GetInt("NewAllGold", 5000);
        candiesstxt.text = "" + candies;
         whichpanel = PlayerPrefs.GetInt("Panels", 0);
        for(int i = 0; i < 4; i++)
        {
            panels[i].SetActive(false);
            Shops[i].SetActive(false);
        }
        panels[whichpanel].SetActive(true);

        for (int j = 0; j < whichpanel; j++)
        {
            Shops[j].SetActive(true);
            prices[j].SetActive(false);
        }
    }

    public void P1(int price)
    {
        if (price <= candies)
        {
            panels[0].SetActive(false);
            panels[1].SetActive(true);
            prices[0].SetActive(false);
            candies -= price;
            PlayerPrefs.SetInt("NewAllGold", candies);
            buildsound.Play();
            VFX[0].SetActive(true);
            candiesstxt.text = "" + candies;
            PlayerPrefs.SetInt("Panels", 1);
            bttnsound.Play();
            Invoke("H1", 1f);
        }
        else
        {
            panels[3].SetActive(true);
            panels[0].SetActive(false);
            bttnsound.Play();

        }
    }
    void H1()
    {
        Shops[0].SetActive(true);
    }
    public void P2(int price)
    {
        if (price <= candies)
        {
            panels[1].SetActive(false);
            panels[2].SetActive(true);
            prices[1].SetActive(false);
            candies -= price;
            PlayerPrefs.SetInt("NewAllGold", candies);
            buildsound.Play();
            VFX[1].SetActive(true);
           // Shops[1].SetActive(true);
            candiesstxt.text = "" + candies;
            PlayerPrefs.SetInt("Panels", 2);
            bttnsound.Play();
            Invoke("H2", 1f);

        }
        else
        {
            bttnsound.Play();

            panels[3].SetActive(true);
            panels[1].SetActive(false);
        }
    }
    void H2()
    {
        Shops[1].SetActive(true);
    }
    public void P3(int price)
    {
        if (price <= candies)
        {
            bttnsound.Play();
            panels[2].SetActive(false);
            panels[3].SetActive(true);
            prices[2].SetActive(false);
            candies -= price;
            PlayerPrefs.SetInt("NewAllGold", candies);
            buildsound.Play();
            VFX[2].SetActive(true);
            Shops[2].SetActive(true);
            candiesstxt.text = "" + candies;
            PlayerPrefs.SetInt("Panels", 3);
        }
        else
        {
            bttnsound.Play();

            panels[3].SetActive(true);
            panels[2].SetActive(false);
        }
    }
    public void P4(int price)
    {
        if (price <= candies)
        {
            bttnsound.Play();
            panels[3].SetActive(false);
           // panels[3].SetActive(true);
            prices[3].SetActive(false);
            candies -= price;
            PlayerPrefs.SetInt("NewAllGold", candies);
            buildsound.Play();
            Shops[3].SetActive(true);
            candiesstxt.text = "" + candies;
            PlayerPrefs.SetInt("Panels", 4);
        }
    }
}
