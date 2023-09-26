using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject Spawnpoint;
    public GameObject[] obj;
    private GameObject temp;
    float t = 0;
   public float SpawnTime;
    public int GetScore;
   public int Temp;
    public AudioSource complete,popsound;
    // Use this for initialization
    void Start()
    {
        Temp = 0;
        SpawnTime = 2f;
    }
	
	// Update is called once per frame
	void Update () {

        if (ScoreText.ScoreUpdate > GetScore)
        {
            GetScore = ScoreText.ScoreUpdate;
            popsound.Play();
            Temp= + 1;
        }

        if (Temp >= 1)
        {

            if (GetScore % 4 == 0)
            {
                complete.Play();
                Temp = 0;
                ScoreText.l = 0;
            }
        }


        t += Time.deltaTime;

        if (t > SpawnTime)
        {
            temp = Instantiate(obj[Random.Range(0, obj.GetLength(0))], Spawnpoint.transform.GetChild(Random.Range(0,3)).position, Quaternion.Euler(0, 0, 0)) as GameObject;
            t = 0;
            Destroy(temp, 6);
            if (SpawnTime > 1.7f)
            {
                SpawnTime = SpawnTime - 0.1f;
            }
            }


            //  Invoke("InstantiateObjects", 6);

        }
    void SpawnBasket()
    {
        temp = Instantiate(obj[Random.Range(0, obj.GetLength(0))], Spawnpoint.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        Destroy(temp, 6);
    }
}
