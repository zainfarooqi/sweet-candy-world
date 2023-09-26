using UnityEngine;
using System.Collections;

public class scoreanimation : MonoBehaviour {

    public Animator scoreanim;
    public GameObject infoText;
    public static int s = 0;

    public Spawn sp;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.touchCount > 0)
        {
            sp.enabled = true;
            infoText.SetActive(false);
        }

        //if (s == 1)
        //{
        //    scoreanim.SetTrigger("score");
        //    s = 0;
        //}
       
    }
}
