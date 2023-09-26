using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public AudioSource bs;
    public void LoadNewScene(int l)
    {
        bs.Play();
        SceneManager.LoadScene(l);
    }
}
