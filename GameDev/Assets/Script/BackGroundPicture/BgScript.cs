using UnityEngine;
using System.Collections;

public class BgScript : MonoBehaviour {

	public float speed = 1.5f;
	
	// To do -> nge scroll background 
	void Update () {
		Vector2 offset = new Vector2 (Time.time * speed, 0);
		GetComponent<Renderer> ().material.mainTextureOffset = offset;
	}
}
