using UnityEngine;
using System.Collections;

//kelas untuk nge scroll background
public class Background : MonoBehaviour {

	//kecepatan awal dari background
	private float speed = 0.11f;

	// To do -> nge scroll background
	// background akan bergerak dengan kecepatan yang terus bertambah
	void Update () { 
        if (speed < 0.25f)
        {
            increaseBGSpeed();
        }
        renderBG();
    }

    private void increaseBGSpeed()
    {
        speed += 0.00000001f;
    }

    private void renderBG()
    {
        Vector2 offset = new Vector2(Time.time * speed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
