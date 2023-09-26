using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundcontroller : MonoBehaviour {

    public GameObject soundimageOn,soundimageOff;
    public int  soundcontrol;
    public GameObject sounds;
    public string ANDROID_RATE_URL = "market://details?id=com.Focus.SeeSharp";
    public AudioSource bttnsound;

    void Start()
    {
        if (PlayerPrefs.HasKey("Sound"))
        {
            soundcontrol = PlayerPrefs.GetInt("Sound");
        }
       
        if (soundcontrol == 1)
        {
            soundimageOn.SetActive(true);
            soundimageOff.SetActive(false);
            sounds.SetActive(false);
            musicnotdestroy.bgOn = 0;

        }
        else
        {
            soundimageOn.SetActive(false);
            soundimageOff.SetActive(true);
            musicnotdestroy.bgOn = 1;

        }
    }
    public void soundOnOff()
    {
        soundcontrol++;
        Debug.Log("h");
        if (soundcontrol == 1)
        {
            soundimageOn.SetActive(true);
            soundimageOff.SetActive(false);
            sounds.SetActive(false);
            PlayerPrefs.SetInt("Sound", 1);
            musicnotdestroy.bgOn = 0;
        }
        else
        {
            soundcontrol = 0;
            soundimageOn.SetActive(false);
            soundimageOff.SetActive(true);
            sounds.SetActive(true);
            PlayerPrefs.SetInt("Sound", 0);
            musicnotdestroy.bgOn = 1;
        }
    }
    public void rateus()
    {
        Application.OpenURL(ANDROID_RATE_URL);
    }
}