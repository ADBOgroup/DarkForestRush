using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public void playButton(){
		Application.LoadLevel ("Play");
	}
	public void noButton(){
		Application.LoadLevel ("Menu");
	}
	public void exit(){
		Application.Quit();
	}
}
