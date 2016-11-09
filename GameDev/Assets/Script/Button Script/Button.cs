using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{

    /// <summary>
    /// method yang digunakan untuk menjalankan tombol play
    /// </summary>
	public void playButton()
    {
        Application.LoadLevel("Play");
    }
    /// <summary>
    /// method yang digunakan untuk menjalankan tombol Menu
    /// </summary>
	public void noButton()
    {
        Application.LoadLevel("Menu");
    }
    /// <summary>
    /// method yang digunakan untuk keluar dari game
    /// </summary>
	public void exit()
    {
        Application.Quit();
    }
}
