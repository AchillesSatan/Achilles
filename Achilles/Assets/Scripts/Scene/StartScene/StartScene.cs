using UnityEngine;
using System.Collections;

public class StartScene : MonoBehaviour {

	void OnGUI ()
	{
		if(GUI.Button(new Rect(10,10,200,30),"Start Game"))
		{
			LoadScene.loadName = "MenuScene";
			Application.LoadLevel("LoadScene");
		}
	}

	void Start ()
	{
		GameDirector.Instance.getWindowSize ();
	}
}
