using UnityEngine;
using System.Collections;

public class SpeedUp : MonoBehaviour {

    public static int soundcaller=0;
    float speed=0.005f;
    
	// Use this for initialization
	void Start () {
        speed = 0.0f;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        //if(soundcaller==1)
        //{
        //    GetComponent<AudioSource>().Play();
        //    soundcaller = 0;
        //}



        transform.Translate(0, speed, 0);

        if(ScoreText.ScoreUpdate>=12)
        {
            speed = 0.01f;
        }
        if (ScoreText.ScoreUpdate >= 24)
        {
            speed = 0.02f;
        }
        if (ScoreText.ScoreUpdate >= 36)
        {
            speed = 0.03f;
        }
        if (ScoreText.ScoreUpdate >= 60)
        {
            speed = 0.04f;
        }
        if (ScoreText.ScoreUpdate >= 72)
        {
            speed = 0.065f;
        }
        if (ScoreText.ScoreUpdate >= 88)
        {
            speed = 0.08f;
        }
        if (ScoreText.ScoreUpdate >= 100)
        {
            speed = 0.1f;
        }
        if (ScoreText.ScoreUpdate >= 1200)
        {
            speed = 0.12f;
        }

    }
}
