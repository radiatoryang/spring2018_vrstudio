using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PUT THIS SCRIPT ON A CONTROLLER
public class BasicSteamVRInput : MonoBehaviour {

	// this is the basic script that lets SteamVR track an object's position / rotation
	SteamVR_TrackedObject myTrackedObject;

	// reference to the actual controller in SteamVR
	SteamVR_Controller.Device myDevice { // this is a C# property, which is a var that can execute code
		get { 
			// tell SteamVR to treat the tracked object as a controller
			return SteamVR_Controller.Input( (int)myTrackedObject.index );
		}
	}

	// Use this for initialization
	void Start () {
		myTrackedObject = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void Update () {
		// is the user holding down the trigger on this controller?
		if( myDevice.GetHairTrigger() ) {
			Debug.Log( "user is holding down the trigger" );
		}

		// is the user holding down TOUCHPAD button, on this controller?
		if( myDevice.GetPress( Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad ) ) {
			Debug.Log( "user is holding down touchpad" );
		}

		// get touchpad axis position?
		if( myDevice.GetAxis( Valve.VR.EVRButtonId.k_EButton_Axis0 ).x > 0f ) {

		}
	}
}
