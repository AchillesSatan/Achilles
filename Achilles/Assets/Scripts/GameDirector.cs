using UnityEngine;
using System.Collections;

public class GameDirector {

	private static GameDirector _singleton = null;

	GameDirector(){}

	~GameDirector() {
				_singleton = null;
				Debug.Log ("Destroy");
		}

	public static GameDirector Instance {
		get {
			if ( _singleton == null ) 
			{
				Debug.Log ("Create the GameDirector.");
				_singleton = new GameDirector ();
			}
			Debug.Log ("Get the GameDirector.");

			return _singleton;
		}
	}

	public void setWindowSize(int width, int height, bool isFullScreen) {
		Screen.SetResolution (width, height, isFullScreen);
	}

	public Vector2 getWindowSize() {
		Vector2 mWindowSize = new Vector2 (Screen.width, Screen.height);
		return mWindowSize;
	}
}
