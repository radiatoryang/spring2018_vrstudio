using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// make cube move towards sphere...
// put this script on the cube!
public class MoveTowards : MonoBehaviour {

	public Transform sphere; // "public" = exposes in inspector, and to other scripts

	// Update is called once per frame
	void Update () {
		// calculate the vector from cube's current position to the sphere
		Vector3 a = transform.position; // cube's position
		Vector3 b = sphere.position; // sphere's position
		Vector3 fromAtoB = b - a; // vector from a > b = b - a;

		// normalize the vector so that it doesn't instantly move
		if ( fromAtoB.magnitude > 1f ) { // but only if it's far away
			fromAtoB = fromAtoB.normalized;
			// fromAtoB = fromAtoB.Normalize(); // this does the same thing
			// fromAtoB = fromAtoB / fromAtoB.magnitude; // this does the same thing too
		}

		// move the cube towards the sphere
		transform.Translate( fromAtoB * Time.deltaTime, Space.World ); // "Translate" = move... Space.world = use worldspace
	}
}
