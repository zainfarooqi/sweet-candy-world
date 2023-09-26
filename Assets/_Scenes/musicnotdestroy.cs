using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicnotdestroy : MonoBehaviour
{
    public static int bgOn = 1;
    public AudioSource bgmusic;
    void Start()
    {
        setmusic();
    }

    void setmusic()
    {
        if(FindObjectsOfType(GetType()).Length>1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Update()
    {
        if (bgOn == 0)
        {
            bgmusic.volume = 0;
        }
        else
        {
            bgmusic.volume = 0.6f;
        }
    }
}
