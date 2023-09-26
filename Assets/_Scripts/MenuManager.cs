using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    int levelno;
    float levelbarvalue;
    public Image LevelBar;
    public Text leveltext, amountext;
    float amount;
    public GameObject HomePanel,ShopPanel;
    public AudioSource bttnsound;
    public int kkk, kk2, kk3;
    private GameObject lll;
    private float popppo;

    void Start()
    {
        amount = PlayerPrefs.GetInt("NewAllGold", 5000);
        //levelno = PlayerPrefs.GetInt("Level", 1);
        //levelbarvalue = PlayerPrefs.GetFloat("LevelBar" + levelno, 0.0f);
        //leveltext.text = "" + levelno;
        //LevelBar.fillAmount = levelbarvalue;
       
    }
    private void Update()
    {
        amount = PlayerPrefs.GetInt("NewAllGold", 5000);
        amountext.text = "" + amount;
    }
    public void shopOnOff(bool value)
    {
        amount = PlayerPrefs.GetInt("NewAllGold", 5000);
        bttnsound.Play();
        ShopPanel.SetActive(value);
    }
    public void levelsactive()
    {
        HomePanel.SetActive(false);
    }
}
