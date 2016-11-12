using UnityEngine;
using System.Collections;

//Class of Obstacle
public class Obstacle : MonoBehaviour {
    private static float speed = -5.0f;
	private Rigidbody2D rb;

    

	/// <summary 
    /// Use this for initialization
    /// </summary>
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
        this.increaseSpeed();
		rb.velocity = new Vector2(speed, 0);

    }

	// Update is called once per frame
	void Update () {
        if (transform.position.x < -10)
        {
            destroyObstacle();
        }
    }

	//Update speed
    private void increaseSpeed() {
        if (speed > -10f) {
            speed -= 0.05f;
        }
    }
	
	//Destroy the obstacle
    private void destroyObstacle() {
        Destroy(gameObject);
    }
}
