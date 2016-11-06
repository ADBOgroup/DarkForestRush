using UnityEngine;
using System.Collections;

//kelas untuk nge scroll background
public class Background : MonoBehaviour {

	//kecepatan awal dari background
	private float speed = 0.11f;

	// To do -> nge scroll background
	// background akan bergerak dengan kecepatan yang terus bertambah
	void Update () {
        Vector2 offset = new Vector2(Time.time * speed, 0);
        if (speed < 0.25f)
        {
            speed += 0.00000001f;
        }
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }

    private void increaseBGSpeed()
    {
        
    }

    private void renderBG()
    {
        
    }
}
