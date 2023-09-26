using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Boundary : MonoBehaviour {

    // Use this for initialization
    public AudioSource Gameover;
    public GameObject panel;
    public int kkk, kk2, kk3;
    private GameObject lll;
    private float popppo;
    int g = 0;
    public Text finaltxt;
    int s;
    // Use this for initialization
  public void sceneLoad(int l)
    {
        ScoreText.ScoreUpdate = 0;
        SceneManager.LoadScene(l);
    }
    void Update()
    {
        if(g==1)
        {
            Gameover.Play();
            g = 2;
        }
    }


    void OnCollisionEnter2D()
    {
        if (g == 0)
        {
            g++;
            
            s = ScoreText.ScoreUpdate;
            Debug.Log("ssss  " + s);
            finalscore();
            ScoreText.ScoreUpdate = 0;
            panel.SetActive(true);
        }
    }
    void finalscore()
    {
        Debug.Log("adadad  " + s);
        finaltxt.text = s + "";
        int candies = PlayerPrefs.GetInt("NewAllGold", 5000);
        candies += s;
        PlayerPrefs.SetInt("NewAllGold", candies);
    }
}
