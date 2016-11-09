using UnityEngine;
using System.Collections;

//kelas untuk meng-update posisi dari obstacle
public class Obstacle : MonoBehaviour {
    private static float speed = -5.0f;
	private Rigidbody2D rb;

    

	/// <summary >
    /// method yang digunakan untuk menjalankan method increased speed dan membuat vector
    /// </summary>
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
        this.increaseSpeed();
		rb.velocity = new Vector2(speed, 0);

    }
    
    /// <summary>
    /// method yang digunakan untuk memanggil destroyObcstacle() ketika koordinat x lebih kecil dari -10
    /// </summary>
	void Update () {
        if (transform.position.x < -10)
        {
            destroyObstacle();
        }
    }
    /// <summary>
    /// method yang digunakan untuk menambahkan kecepatan obsctacle
    /// </summary>
    private void increaseSpeed() {
        if (speed > -10f) {
            speed -= 0.05f;
        }
    }
    /// <summary>
    /// method yang digunakan untuk menghancurkan obstacle ketika sudah tidak digunakan
    /// </summary>
    private void destroyObstacle() {
        Destroy(gameObject);
    }
}
