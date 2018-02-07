using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR; // IMPORTANT: you need this line to use XR functions

// put this on your Main Camera
public class FallbackMouseLook : MonoBehaviour {

	void Start () {
		// if VR is NOT working, then move the camera up to 1.6m
		// (but if VR *is* working, then the camera will automatically move up because of motion tracking)
		if( XRSettings.isDeviceActive == false ) {
			transform.Translate( 0f, 1.6f, 0f ); // move upwards 1.6m to simulate a person's height
		}

		// optional: set tracking space to be Room Scale, even if we're using an Oculus in standing mode
		XRDevice.SetTrackingSpaceType( TrackingSpaceType.RoomScale ); // makes it more consistent in Oculus vs Vive

		// optional: if your game was running too slow, one easy way to make it faster is to make it more pixelated / less detailed
		XRSettings.renderViewportScale = 0.9f; // for example, render at 90% of normal resolution
	}

	void Update () {
		// fallback mouse look behavior if not connected to an HMD
		// (so you can test stuff on your laptop or dev machine, without going into VR)
		if( XRSettings.isDeviceActive == false ) {
			// 1. get mouse input values
			float mouseX = Input.GetAxis( "Mouse X" ); // horizontal mouse movement... if not moving, == 0f
			float mouseY = Input.GetAxis( "Mouse Y" ); // vertical mouse movement... if not moving, == 0f

			// 2. rotate the camera based on mouse values
			transform.Rotate( -mouseY * 300f * Time.deltaTime, mouseX * 300f * Time.deltaTime, 0f );

			// 3. unroll the camera, because it can still roll even tho Z-angle was 0.0f
			// transform.localEulerAngles.z = 0f; // UNITY C# WILL NOT LET YOU DO THIS
			transform.localEulerAngles = new Vector3( transform.localEulerAngles.x, transform.localEulerAngles.y, 0f );
		}

	} // end Update()
}
