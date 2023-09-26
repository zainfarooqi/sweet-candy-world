using UnityEngine;
using UnityEngine.UI;
public class ScoreText : MonoBehaviour {
    public Text scoretext;
    public int score = 0;
    public static int ScoreUpdate;
    public int highscore = 0;
    public int highlevel = 0;
    string highScoreKey = "HighScore";
    string highLevelKey = "HighLevel";
    public Text h;
    public Text hl;
    public Text levelcleared;
    int level;
    public Animator levelanim;
    public static int l = 0;


    // Use this for initialization
    void Start()
    {
        Application.targetFrameRate = 60;
        highscore = PlayerPrefs.GetInt(highScoreKey, 0);
        PlayerPrefs.Save();
        score = PlayerPrefs.GetInt("Score");

        highlevel = PlayerPrefs.GetInt(highLevelKey, 0);
        PlayerPrefs.Save();
         
    }

    // Update is called once per frame
    void Update()
    {
        if(ScoreUpdate==120&&l==0)
        {
            level = 1;
            levelanim.SetTrigger("level");
            l = 1;
        }

        if (ScoreUpdate == 240 && l == 0)
        {
            levelanim.SetTrigger("level");
            level = 2;
            l = 1;
        }
        if (ScoreUpdate == 360 && l == 0)
        {
            levelanim.SetTrigger("level");
            level = 3;
            l = 1;
        }
        if (ScoreUpdate == 480 && l == 0)
        {
            levelanim.SetTrigger("level");
            level = 4;
            l = 1;
        }
        if (ScoreUpdate == 600 && l == 0)
        {
            levelanim.SetTrigger("level");
            level = 5;
            l = 1;
        }
        if (ScoreUpdate == 720 && l == 0)
        {

            levelanim.SetTrigger("level");
            level = 6;
            l = 1;
        }
        if (ScoreUpdate == 840 && l == 0)
        {

            levelanim.SetTrigger("level");
            level = 7;
            l = 1;
        }
        if (ScoreUpdate == 1000 && l == 0)
        {

            levelanim.SetTrigger("level");
            level = 8;
            l = 1;
        }
        if (ScoreUpdate == 1150 && l == 0)
        {

            levelanim.SetTrigger("level");
            level = 9;
            l = 1;
        }
        if (ScoreUpdate == 1300 && l == 0)
        {

            levelanim.SetTrigger("level");
            level = 10;
            l = 1;
        }


        if (ScoreUpdate > highscore)
        {
            PlayerPrefs.SetInt(highScoreKey, ScoreUpdate);
            highscore = PlayerPrefs.GetInt(highScoreKey, ScoreUpdate);
            PlayerPrefs.Save();
        }
        if (level > highlevel)
        {
            PlayerPrefs.SetInt(highLevelKey, level);
            highlevel = PlayerPrefs.GetInt(highLevelKey, level);
            PlayerPrefs.Save();
        }


        score = PlayerPrefs.GetInt("Score");
        ScoreUpdate += score;

        scoretext.text = "" + ScoreUpdate;

        PlayerPrefs.SetInt("Score", 0);

     //   h.text = "High Score " + highscore;
      //  hl.text = "Highest level " + highlevel;

        levelcleared.text = "Level " + level + " cleared";

    }
}
