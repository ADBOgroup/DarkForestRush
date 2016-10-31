using UnityEngine;
using System.Collections;

//kelas untuk nge scroll background
public class Background : MonoBehaviour {

	//kecepatan awal dari background
	public float speed = 1.5f;
	
	// To do -> nge scroll background 
	// background akan bergerak dengan kecepatan yang terus bertambah
	void Update () {
		Vector2 offset = new Vector2 (Time.time * speed, 0);
		if(speed < 0.5f){
			speed += 0.00002f;
		}
		GetComponent<Renderer> ().material.mainTextureOffset = offset;
	}
}
