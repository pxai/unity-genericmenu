using UnityEngine;
using System.Collections;

public class SceneChangeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void loadScene (string name) {
		Debug.Log ("Loading level " + name);
		Application.LoadLevel(name);
	}
}
