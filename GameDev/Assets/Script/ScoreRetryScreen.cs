using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreRetryScreen : MonoBehaviour {

    private float highScoreCount;
    private float scoreCount;
    public Text highScoreText;
    public Text scoreText;
	// Use this for initialization
	void Start () {
        highScoreCount = PlayerPrefs.GetFloat("highScoreCount");
        scoreCount = PlayerPrefs.GetFloat("scoreCount", Mathf.Round(scoreCount));
        highScoreText.text= "High Score: " + Mathf.Round(highScoreCount);
        scoreText.text = "Current Score: " + Mathf.Round(scoreCount);


    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
