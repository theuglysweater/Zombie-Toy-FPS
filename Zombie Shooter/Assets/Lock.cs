using UnityEngine;
using System.Collections;

public class Lock : MonoBehaviour {

	bool Paused = false;

	void Start ()
	{
		Screen.lockCursor = true;
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Pause ();
		}
	}

	bool Pause ()
	{
		if (Paused = false) {
			Screen.lockCursor = false;
			Paused = true;
			Debug.Log(Paused);
		} else
		{
s			Screen.lockCursor = true;
			Paused = false;
			Debug.Log(Paused);
		}
		return Paused;
	}
}