using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class BaloonController : MonoBehaviour
{
 
    public Animator anim;
    private Rigidbody2D rb;
    private GameObject temp;
    public GameObject Spawnpoint;
    public GameObject obj;
    public int kkk, kk2, kk3;
    private GameObject lll;
    private float popppo;
    // Use this for initialization
    void Start()
    {
        anim.SetBool("basket", false);
        
        //  AudioSource audio = GetComponent<AudioSource>();
        PlayerPrefs.SetInt("Score", 0);
        
    }

    // Update is called once per frame
    void Update()
    {
//        rb.gravityScale = -0.2f;
        //transform.Translate(0, 0.1f, 0);


    }

   
    
        void OnMouseDown()
    {
        temp = Instantiate(obj, Spawnpoint.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        Destroy(temp, 4);

        anim.SetTrigger("Move");
        scoreanimation.s = 1;
       // anim.SetBool("basket", true);
        SpeedUp.soundcaller = 1;
        


        PlayerPrefs.SetInt("Score",1);
        Destroy(gameObject);
        
    }
}
