using UnityEngine;
using System.Collections;

//kelas untuk meng-update posisi dari obstacle
public class Obstacle : MonoBehaviour {
	// ini buat apa , kenapa 0,0 ????
	public Vector2 velocity = new Vector2 (0, 0);
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
