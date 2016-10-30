using UnityEngine;
using System.Collections;

public class MainCharacter : MonoBehaviour {
	public Vector2 jumpPower = new Vector2(0,200);
	public bool grounded = true;
	public Rigidbody2D rb;

	void start(){
		rb = GetComponent<Rigidbody2D> ();
	}


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
		//Loncat 1x jika di tanah
		if (Input.GetKeyDown ("up") && this.grounded) {
			rb.AddForce (jumpPower);
			this.grounded = false;
			rb.gravityScale = 1f;
			transform.localScale = new Vector2 (3f, 3f);
		}
		//Pencet "down"
		if(Input.GetKeyDown("down")){
			//waktu di udara
			if(!this.grounded){
				rb.gravityScale = 6;
				transform.localScale = new Vector2(1.8f,1.8f);
			}
			//waktu di tanah
			else{
				rb.gravityScale = 1f;
				transform.localScale = new Vector2(1.8f,1.8f);
			}
		}
		if(Input.GetKeyUp("down")){
				rb.gravityScale = 1f;
				transform.localScale = new Vector2(3f,3f);
			}

	}
}
