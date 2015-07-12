using UnityEngine;
using System.Collections;

public class FeedingRobotMove : MonoBehaviour
{

    public float speed;


    public GameObject foodPickup;

    Rigidbody2D rig2D;

    // Use this for initialization
    void Start()
    {
        rig2D = this.gameObject.GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");

        float moveY = Input.GetAxis("Vertical");

        rig2D.velocity = new Vector2(moveX * speed, moveY * speed);

        if (foodPickup != null)
        {
            foodPickup.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 5f);
        }
        else
        {
            foodPickup = null;
        }

        //PickUp();
    }


    // Update is called once per frame
    void Update()
    {

    }

    //void PickUp()
    //{
    //    foodPickup.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 5f);
    //}

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
