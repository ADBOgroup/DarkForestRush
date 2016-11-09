using UnityEngine;
using System.Collections;

//kelas untuk meng-generate obstacle baru
/**
 *
 *
 *
 */
public class ObstaclesGenerator : MonoBehaviour {
	public GameObject[] obstacles;

	
	public float speedMax = 7.5f;
	
	public float speedMin = 5.5f;

    /// <summary>
    /// method untuk menjalankan method generateObstacles()
    /// </summary>
    void Start () {
		generateObstacles ();
	}

    /// <summary>
    /// method yang digunakan untuk meng-generate obstacles
    ///sesuai dengan kecepatan yang tetap dan posisi yang dirandom pada background picture
    /// </summary>
    public void generateObstacles (){
		GameObject clone = (GameObject)Instantiate (
			                   obstacles [Random.Range (0, obstacles.Length)],
			                   transform.position,
			                   Quaternion.identity
		                   );
		clone.name = "Obstacle";
		float obstacleRandomRange = Random.Range (speedMin, speedMax);
		Invoke ("generateObstacles",obstacleRandomRange);
	}
}
