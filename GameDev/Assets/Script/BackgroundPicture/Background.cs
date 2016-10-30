using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

	public float speed = 1.5f;
	
	// To do -> nge scroll background 
	void Update () {
		Vector2 offset = new Vector2 (Time.time * speed, 0);
		if(speed < 0.5f){
			speed += 0.00002f;
		}
		GetComponent<Renderer> ().material.mainTextureOffset = offset;
	}
}
