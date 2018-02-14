using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script will detect if you're looking at something
// by shooting a raycast out the front of the camera
// ... so put this script on your camera?
public class GazeRaycast : MonoBehaviour {

	float timeLookedAt;
	
	// Update is called once per frame
	void Update () {
		// SHOOTING A RAYCAST
		// 1. construct a "Ray" object, to shoot out in front of camera
		Ray myRay = new Ray( transform.position, transform.forward );

		// 2. declare a RaycastHit object, to store the raycast hit info
		RaycastHit myRayHit = new RaycastHit(); // this is a blank variable, will fill with data later

		// 3. visualize the raycast in the editor
		Debug.DrawRay( myRay.origin, myRay.direction * 100f, Color.yellow);

		// 4. actually shoot the raycast now!
		if( Physics.Raycast( myRay, out myRayHit, 100f ) ) {
			timeLookedAt += Time.deltaTime; // after 1 second of looking, timeLookedAt == 1.0f

			// once we hit something, we should spin it, to show that we're looking at it
			if( timeLookedAt > 1f ) {
				// myRayHit.transform = the thing the raycast hit
				myRayHit.transform.Rotate( 0f, 90f * Time.deltaTime, 0f ); 
			}
		} else {
			timeLookedAt = 0f; // reset the lookTimer if we're not looking at anything
		}
	}

}
