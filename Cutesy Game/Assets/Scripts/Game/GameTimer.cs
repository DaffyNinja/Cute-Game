using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour {

    public float gameTime;

    public Text timerText;

    bool gameGoing = true;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        timerText.text = gameTime.ToString();

        if (gameGoing == true)
        {

            gameTime -= Time.deltaTime;

            if (gameTime <= 0)
            {
                print("Finish");

                gameGoing = false;

                gameTime = 0;
            }
        }

	
	}
}
