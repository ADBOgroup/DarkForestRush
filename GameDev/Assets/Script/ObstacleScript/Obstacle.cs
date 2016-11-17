using UnityEngine;
using System.Collections;

//Class of Obstacle
public class Obstacle : MonoBehaviour {
    private static float speed = -5.0f;
	private Rigidbody2D rb;

    

	/// <summary >
    /// start jika dipanggil
    /// </summary>
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
        this.increaseSpeed();
		rb.velocity = new Vector2(speed, 0);

    }

	/// <summary>
    /// menghancurkan objek jika koordinat x dibawah -10
    /// </summary>
	void Update () {
        if (transform.position.x < -10)
        {
            destroyObstacle();
        }
    }

	/// <summary>
    /// menambahkan kecepatan
    /// </summary>
    private void increaseSpeed() {
        if (speed > -10f) {
            speed -= 0.05f;
        }
    }

    /// <summary>
    /// Destroy the obstacle
    /// </summary>
    private void destroyObstacle() {
        Destroy(gameObject);
    }
}
