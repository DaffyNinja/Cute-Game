using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreSystem : MonoBehaviour {

    public int score;

    public int scoreToBeat;


    public Text scoreText;


    public bool hasWon;


    GameTimer gTimer;


	// Use this for initialization
	void Start () 
    {
        gTimer = GameObject.Find("Game Manager").GetComponent<GameTimer>();
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        scoreText.text = score.ToString();

        if (gTimer.gameGoing == false)
        {
            if (score >= scoreToBeat)
            {
                print("Win");

                hasWon = true;
            }
            else 
            {
                print("Lose");

                hasWon = false;

                score = 0;

                //gTimer.gameTime = 0;

                //gTimer.gameGoing = true;
            }
        }

   
        
	
	}
}
