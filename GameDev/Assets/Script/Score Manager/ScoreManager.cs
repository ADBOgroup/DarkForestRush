using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	//membuat score
	public Text scoreText;
	public Text highScoreText;

	public AudioSource audio;

	public float scoreCount;
	public float highScoreCount;	

	public float scorePerSecond = 1;

	public bool scoreIncreasing;

	// Use this for initialization
	void Start () {
		//highscore di simpan dan bakal di tampilkan waktu start
		audio = GetComponent<AudioSource>();
		highScoreCount  = PlayerPrefs.GetFloat("highScoreCount");
		highScoreText.text = "High Score: " + Mathf.Round(highScoreCount);
	}

	// Update is called once per frame
	void Update () {
		scoreCount += scorePerSecond * Time.deltaTime * 8;
		//score bertambah sesuai lama waktu bermain
		if (scoreCount > highScoreCount) {
			highScoreCount = scoreCount;
			highScoreText.text = "High Score: " + Mathf.Round(highScoreCount);
			PlayerPrefs.SetFloat("highScoreCount" , Mathf.Round(highScoreCount));
		}
		if(scoreText.text.Equals("100")){
			playSong();
		}
		scoreText.text = "Score: " + Mathf.Round(scoreCount);
	}
	void playSong(){
		audio.Play ();
	}
}
