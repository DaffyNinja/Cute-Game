using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour
{

    public float gameTime;

    public Text timerText;

    public bool gameGoing = true;

    SpawnFood sFood;

    ScoreSystem scoreSYS;

 

    // Use this for initialization
    void Start()
    {
        sFood = GameObject.Find("Game Manager").GetComponent<SpawnFood>();

        scoreSYS = GameObject.Find("Game Manager").GetComponent<ScoreSystem>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (scoreSYS.hasWon == false)
        {
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
            else
            {
                //sFood.enabled = false;

                gameTime = 20;

                gameGoing = true;
            }

            timerText.text = gameTime.ToString("F2");
        }
        else
        {
            print("Next Scene");

            sFood.enabled = false;
        }
    }


}
