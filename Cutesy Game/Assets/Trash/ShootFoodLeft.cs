using UnityEngine;
using System.Collections;

public class ShootFoodLeft : MonoBehaviour {

    //public float shootSpeed;

    //public GameObject[] foodOBJS;

    public float attackTime;

    public GameObject[] foodOBJS;

    public Transform[] spawnPos;

    float timer;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        timer += Time.deltaTime;

        if (timer >= attackTime)
        {
            for (int i = 0; i < foodOBJS.Length; i++)
            {
                Quaternion foodRo = foodOBJS[i].transform.rotation;

                float spawnY = Random.Range(0, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
                Vector2 spawnPosition = new Vector2(Camera.main.ScreenToWorldPoint(new Vector2(-Screen.width, 0)).x, spawnY);

                spawnPos[i].transform.position = spawnPosition;

                Instantiate(foodOBJS[i], spawnPos[i].position,foodRo);

                timer = 0;
            }
        }

    
	
	}
}
