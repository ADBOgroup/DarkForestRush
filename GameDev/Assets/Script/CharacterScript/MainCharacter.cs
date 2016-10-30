using UnityEngine;
using System.Collections;

public class MainCharacter : MonoBehaviour {
	public Vector2 jumpPower = new Vector2(0,200);
	public bool grounded = true;
	public Rigidbody2D rb;

	void start(){
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("up") && grounded == true) {
			rb.AddForce (jumpPower);
			grounded = false;
		}

	}

	//@Override
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "ground"){
			grounded = true;
		}
	}
}
