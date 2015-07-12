using UnityEngine;
using System.Collections;

public class SpawnFood : MonoBehaviour
{


    public float attackTime;

    public GameObject[] foodOBJS;

    public Transform[] spawnPos;

    float timer;

    public bool isLeft;

    GameObject foodParent;

    // Use this for initialization
    void Start()
    {
        foodParent = GameObject.Find("Food OBJS");


    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        

        if (timer >= attackTime)
        {
           
            for (int i = 0; i < foodOBJS.Length; i++)
            {
              

                Quaternion foodRo = foodOBJS[i].transform.rotation;

                float spawnY = Random.Range(0, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);

                int ranNum = Random.Range(0, 2);
                
                spawnPos[i] = spawnPos[ranNum];

                if (spawnPos[i].gameObject.tag == "Right Spawn")
                {
                    isLeft = false;
                    //print("RIGHT");
                    Vector2 spawnPosition = new Vector2(Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x, spawnY);
                    spawnPos[i].transform.position = spawnPosition;
                }
                else if(spawnPos[i].gameObject.tag == "Left Spawn")
                {
                    isLeft = true;
                   // print("LEFT");
                    Vector2 spawnPosition = new Vector2(Camera.main.ScreenToWorldPoint(new Vector2(-Screen.width, 0)).x, spawnY);
                    spawnPos[i].transform.position = spawnPosition;
                }

                GameObject foodOBJ = Instantiate(foodOBJS[i], spawnPos[i].position, foodRo) as GameObject;

                foodOBJ.transform.parent = foodParent.transform;

                //if (foodOBJ.GetComponent<Ren == true)
                //{
                //    Debug.Log("Visible");
                //}
                //else
                //{
                //    Debug.Log("Not visible");
                //}


                timer = 0;

                //print(ranNum.ToString());
            }
        }



    }
}