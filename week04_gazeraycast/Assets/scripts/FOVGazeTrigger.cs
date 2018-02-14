using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// FOV = "field of view"
// put this script on the object to be looked at
// and this script will ask itself, "am I being looked at?"
public class FOVGazeTrigger : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		// 1. am I within the Camera's field of view? / middle of the screen?

		// get vector from camera to object
		Vector3 fromCameraToMe = transform.position - Camera.main.transform.position;

		// compare that vector to camera's forward direction, and measure the angle
		float angle = Vector3.Angle( Camera.main.transform.forward, fromCameraToMe.normalized );

		// if that angle is less than X, then that object is within the vision cone
		if( angle < 10f ) { // if within 10 degrees of middle of screen, then... etc etc
			transform.Rotate( 0f, 90f * Time.deltaTime, 0f ); // test: rotate

			// if you wanted to make sure there's nothing blocking our view,
			// you would add a raycast check here, between Camera.main and this.transform
			// (see GazeRaycast.cs for that kind of stuff)
		}
		
	}
}
