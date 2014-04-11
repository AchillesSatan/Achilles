using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	public static string loadName;

	AsyncOperation async;

	int progress = 0;

	void Start ()
	{
				StartCoroutine (LoadSceneAsync ());
		}

	IEnumerator LoadSceneAsync () {
				async = Application.LoadLevelAsync (LoadScene.loadName);
				yield return async;
		}

	void OnGUI () {
		}

	void Update () {
				progress = (int)(async.progress * 100);
				Debug.Log ("progress: " + progress);
		}
}
