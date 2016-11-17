using UnityEngine;
using System.Collections;

//Class of Button
public class Button : MonoBehaviour {
	
	/// <summary>
    /// play button on click
    /// </summary>
	public void playButton(){
		Application.LoadLevel ("Play");
	}
	/// <summary>
    /// no button on click
    /// </summary>
	public void noButton(){
		Application.LoadLevel ("Menu");
	}
	/// <summary>
    /// exit button on click
    /// </summary>
	public void exit(){
		Application.Quit();
	}
}
