using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement; // lets me use SceneManager functions

public class RestartButton : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		// if you press [R] on keyboard, then reload the scene
		if( Input.GetKeyDown( KeyCode.R ) ) {
			// to actually restart the game, just reload the current scene
			SceneManager.LoadScene( SceneManager.GetActiveScene().name );
			// IMPORTANT: don't forget to go to Window > Lighting > Settings, and uncheck the
			// "Autogenerate Lighting" checkbox at the bottom, or else your scene will
			// go "dark" when you reload the scene
		}
	}
}
