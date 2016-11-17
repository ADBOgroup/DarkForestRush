using UnityEngine;
using System.Collections;

//Class of ObstaclesGenerator
//function to create Obstacle
public class ObstaclesGenerator : MonoBehaviour {
	public GameObject[] obstacles;

	//Maximum Speed from obstacle
	public float speedMax = 7.5f;
	//Minimum Speed from Obstacle
	public float speedMin = 5.5f;
	// Use this for initialization
	void Start () {
		generateObstacles ();
	}

	/// <summary>
    /// menggenerate obstacle  dengan kecepatan yang ditentukan dan posisi yang ditentukan
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
