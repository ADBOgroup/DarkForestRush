using UnityEngine;
using System.Collections;

//Class of Background
//
public class Background : MonoBehaviour {

	//kecepatan awal dari background
	private float speed = 0.11f;

	/// <summary>
    /// menambahkan kecepatan background jika speed lebih kecil dari 0.25
    /// </summary>
	void Update () { 
        if (speed < 0.25f)
        {
            increaseBGSpeed();
        }
        renderBG();
    }

	/// <summary>
    /// menambahkan variable speed
    /// </summary>
    private void increaseBGSpeed()
    {
        speed += 0.00000001f;
    }
	
	/// <summary>
    /// merender background
    /// </summary>
    private void renderBG()
    {
        Vector2 offset = new Vector2(Time.time * speed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
