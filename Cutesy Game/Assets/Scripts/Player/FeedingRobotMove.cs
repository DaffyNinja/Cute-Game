using UnityEngine;
using System.Collections;

public class FeedingRobotMove : MonoBehaviour {

    public float speed;


    GameObject foodPickup;

    Rigidbody2D rig2D;

	// Use this for initialization
	void Start () 
    {
        rig2D = this.gameObject.GetComponent<Rigidbody2D>();
	
	}

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");

        float moveY = Input.GetAxis("Vertical");

        rig2D.velocity = new Vector2(moveX * speed, moveY * speed);

        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    rig2D.velocity = new Vector2(0, speed);
        //}
        //else if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    rig2D.velocity = new Vector2(0, -speed);
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    rig2D.velocity = new Vector2(speed, 0);
        //}
        //else if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    rig2D.velocity = new Vector2(-speed, 0);
        //}

        foodPickup.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 3f);

        //PickUp();
    }

	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void PickUp()
    {
        foodPickup.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 5f);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Food")
        {
          //  print("Food");

            foodPickup = col.gameObject;

            foodPickup.GetComponent<MoveFood>().enabled = false;
        }
    }
}
