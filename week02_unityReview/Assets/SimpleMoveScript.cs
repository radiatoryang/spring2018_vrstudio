using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this makes the cube rise up and spin around
// put this script on a Cube!
public class SimpleMoveScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		// move the cube upwards
		// transform.position += new Vector3( 0f, 1f, 0f ); // move cube up 1m every frame

		// better version: framerate INDEPENDENT that uses Time.deltaTime
		transform.position += new Vector3(0f, 1f, 0f) * Time.deltaTime; // move up 1m per second

		// we can make shapes spin too
		transform.Rotate( 0f, 90f * Time.deltaTime, 0f ); // rotate 90 deg per second on Y axis
	}
}
