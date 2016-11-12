﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//Class of MainCharacter
//Function to optimize character movement
public class MainCharacter : MonoBehaviour {
	//tinggi lompatan karakter
	public Vector2 jumpPower = new Vector2(0,200);
	public Rigidbody2D rb;


	//fungsi boolean untuk memeriksa posisi karakter
	//true jika karakter tidak sedang lompat
	public bool grounded = true;

	//Score
	private int count;
	public GameObject score;
	private Text scoreText;

	//HighScore
	private int highScoreCount;
	public GameObject highScore;
	private Text highScoreText;
	
	//Function to start the character
	void Start(){
		rb = GetComponent<Rigidbody2D> ();
		count = 0;
		scoreText = score.GetComponent<Text> ();
		highScoreText = highScore.GetComponent<Text> ();

		setScore ();
		InvokeRepeating ("incCount", 0.0f, 0.1f);
		PlayerPrefs.SetInt("highScoreCount" , highScoreCount);
		highScoreText.text = "High Score: " + highScoreCount.ToString ();


	}

	//method untuk memeriksa collision dari karakter
	//jika karakter collision dengan ground, grounded = true
	//jika karakter collision dengan obstacle maka permainan berhenti
	//@Override
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "ground"){
			this.grounded = true;
		}
		if (coll.gameObject.name == "Obstacle") {
			rb.constraints = RigidbodyConstraints2D.FreezeAll;
			Application.LoadLevel ("Retry");
		}
	}


	// Update is called once per frame
	void Update () {
		
		//jika karakter menyentuh tanah, karakter lompat 1x
		if (Input.GetKeyDown ("up") && this.grounded) {
			jump ();
		}
		//Pencet "down"
		if(Input.GetKeyDown("down")){
			crouch();
		}
		//karakter mengecil untuk menghindari obstacle terbang
		if(Input.GetKeyUp("down")){
			stand ();
		}
		setHighScore ();
		setScore ();

	}
	
	//function to set the high score
	private void setHighScore(){
		if (count > highScoreCount) {
			highScoreCount = count;
			PlayerPrefs.SetInt("highScoreCount" , highScoreCount);
			highScoreText.text = "High Score: " + highScoreCount.ToString ();
		}
	}
	
	//function to set the counter to score
	private void setScore (){
		scoreText.text = "Score: " + count.ToString ();
	}
	
	//function to increase count
	private void incCount(){
		count++;
	}
	
	//function to make character jump
	private void jump(){
		rb.AddForce (jumpPower);
		this.grounded = false;
		rb.gravityScale = 1f;
		transform.localScale = new Vector2 (3f, 3f);
	}
	
	//function to make character crouch
	private void crouch(){
				if(!this.grounded){
					rb.gravityScale = 6;
					transform.localScale = new Vector2(1.8f,1.8f);
				}
				//waktu di tanah karakter menjadi kecil untuk menghindari obstacle terbang
				else{
					rb.gravityScale = 1f;
					transform.localScale = new Vector2(1.8f,1.8f);
				}
	}
	
	//function to make character walking normally
	private void stand(){
		rb.gravityScale = 1f;
		transform.localScale = new Vector2(3f,3f);
	}
}
