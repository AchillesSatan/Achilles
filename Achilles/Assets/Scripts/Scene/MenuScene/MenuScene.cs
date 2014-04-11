using UnityEngine;
using System.Collections;

public class MenuScene : MonoBehaviour {

	void OnGUI ()
	{
		if(GUI.Button(new Rect(10,10,200,30),"Go Back"))
		{
			Application.LoadLevel("StartScene");
		}
	}
	
	void Start ()
	{
		GameDirector.Instance.getWindowSize ();
	}
}
