using UnityEngine;
using System.Collections;

public class MoveFood : MonoBehaviour {

    public float foodSpeed;

    SpawnFood sFood;

	// Use this for initialization
	void Start () 
    {
        sFood = GameObject.Find("Game Manager").GetComponent<SpawnFood>();
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (sFood.isLeft == true)
        {
            transform.Translate(Vector2.right * foodSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector2.right * foodSpeed * Time.deltaTime);
        }
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Destroy Wall")
        {
            Destroy(this.gameObject);

           // print("Destroyed");
        }
    }
}
