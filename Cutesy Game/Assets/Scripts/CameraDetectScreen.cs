using UnityEngine;
using System.Collections;

public class CameraDetectScreen : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        
	
	}
	
	// Update is called once per frame
	void Update () 
    {
       //// Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
       // Vector3 viewPos = Camera.main.WorldToScreenPoint(transform.position);
       // //viewPos.x = Mathf.Clamp01(viewPos.x);
       // //viewPos.y = Mathf.Clamp01(viewPos.y);
       // transform.position = Camera.main.ViewportToWorldPoint(viewPos);

        //Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);

        //if (pos.x < 0.0) Debug.Log("I am left of the camera's view.");
        //if (1.0 < pos.x) Debug.Log("I am right of the camera's view.");
        //if (pos.y < 0.0) Debug.Log("I am below the camera's view.");
        //if (1.0 < pos.y) Debug.Log("I am above the camera's view.");

        //if (GetComponent<Renderer>().IsVisibleFrom(Camera.main)) Debug.Log("Visible");
        //else Debug.Log("Not visible");

      
	
	}
}
