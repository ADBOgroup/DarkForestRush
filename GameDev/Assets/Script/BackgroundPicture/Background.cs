using UnityEngine;
using System.Collections;

//kelas untuk nge scroll background
public class Background : MonoBehaviour {

	//kecepatan awal dari background
	private float speed = 0.11f;

	/// <summary>
    /// method yang digunakan untuk menggerakan background (scroll background) yang dijalankan
    /// dalam bentuk frame per second 
    /// </summary>
	void Update () { 
        if (speed < 0.25f)
        {
            increaseBGSpeed();
        }
        renderBG();
    }
    /// <summary>
    /// method yang digunakan untuk mengubah kecepatan scroll background
    /// </summary>
    private void increaseBGSpeed()
    {
        speed += 0.00000001f;
    }
    /// <summary>
    /// method yang digunakan untuk merender(menampilkan) background
    /// </summary>
    private void renderBG()
    {
        Vector2 offset = new Vector2(Time.time * speed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
