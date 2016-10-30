using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
	public Vector2 velocity = new Vector2 (Time.time * 0.1f, 0);
	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = velocity;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -10) {
			Destroy (gameObject);
		}
	}
}
