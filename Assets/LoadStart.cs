using UnityEngine;
using System.Collections;

public class LoadStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("3 seconds to start");
		Invoke ("loadStart", 3);
	}

	public void loadStart () {
		Debug.Log ("Loading start level");
		Application.LoadLevel("StartScene");
	}
}
