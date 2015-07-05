using UnityEngine;
using System.Collections;

public class ManBin : MonoBehaviour {

    ScoreSystem scoreSys;


	// Use this for initialization
	void Start () 
    {
        scoreSys = GameObject.Find("Game Manager").GetComponent<ScoreSystem>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Food")
        {
            print("Food Hit");

            scoreSys.score++;

            Destroy(col.gameObject);
        }
    }
}
