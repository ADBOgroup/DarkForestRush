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

	//kecepatan maksimal dari obstacle
	public float speedMax = 7.5f;
	//kecepatan minimal dari obstacle
	public float speedMin = 5.5f;
	// Use this for initialization
	void Start () {
		generateObstacles ();
	}

	//method untuk generate obstacle baru secara random
	public void generateObstacles (){
		GameObject clone = (GameObject)Instantiate (
			                   obstacles [Random.Range (0, obstacles.Length)],
			                   transform.position,
			                   Quaternion.identity
		                   );
		clone.name = "Obstacle";		
		float obstacleRandomRange = Random.Range (speedMin, speedMax);
		Invoke ("generateObstacles",obstacleRandomRange);
		if (speedMin > 1.5f) {
			speedMin -= 0.4f;
		}
		if (speedMax > 2.5f) {
			speedMax -= 0.4f;
		}
	}
}
