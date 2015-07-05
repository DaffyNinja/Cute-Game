using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreSystem : MonoBehaviour {

    public int score;

    public Text scoreText;


	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        scoreText.text = score.ToString();

        if (score >= 2)
        {
           // print("Win");
        }
	
	}
}
