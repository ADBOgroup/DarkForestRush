using UnityEngine;
using System.Collections;

//Class of Button
public class Button : MonoBehaviour {
	
	//Play Button
	public void playButton(){
		Application.LoadLevel ("Play");
	}
	//No Button
	public void noButton(){
		Application.LoadLevel ("Menu");
	}
	//Exit Button
	public void exit(){
		Application.Quit();
	}
}
