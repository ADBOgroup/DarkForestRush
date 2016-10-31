﻿using UnityEngine;
using System.Collections;

//kelas untuk mengatur pergerakan dari karakter pemain

public class MainCharacter : MonoBehaviour {
	//tinggi lompatan karakter
	public Vector2 jumpPower = new Vector2(0,200);

	//fungsi boolean untuk memeriksa posisi karakter
	//true jika karakter tidak sedang lompat
	public bool grounded = true;

	public Rigidbody2D rb;


	void start(){
		rb = GetComponent<Rigidbody2D> ();
	}

	//method untuk memeriksa collision dari karakter
	//jika karakter collision dengan ground, grounded = true
	//jika karakter collision dengan obstacle, 
	//INI APAAN WOI TAKUT SALAH
	//@Override
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "ground"){
			this.grounded = true;
		}
		if (coll.gameObject.name == "Obstacle") {
			Time.timeScale = 0;
		}
	}


	// Update is called once per frame
	void Update () {
		//jika karakter menyentuh tanah, karakter lompat 1x
		if (Input.GetKeyDown ("up") && this.grounded) {
			rb.AddForce (jumpPower);
			this.grounded = false;
			rb.gravityScale = 1f;
			transform.localScale = new Vector2 (3f, 3f);
		}
		//Pencet "down"
		if(Input.GetKeyDown("down")){
			//waktu di udara karakter turun dengan cepat
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
		//karakter mengecil untuk menghindari obstacle terbang
		if(Input.GetKeyUp("down")){
				rb.gravityScale = 1f;
				transform.localScale = new Vector2(3f,3f);
			}

	}
}
