using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Valve.VR.InteractionSystem; // you need this to code InteractionSystem scripts

[RequireComponent(typeof(Interactable))] // forces us to have an Interactable script next to this script
public class MyButton : MonoBehaviour {

	// fires every frame as long as a hand (mouse or VR controller) is next to it
	void HandHoverUpdate( Hand myHand ) {
		// GetStandardInteractionButton == mouse click if in fallback mode, or trigger if in VR
		if( myHand.GetStandardInteractionButtonDown() ) {
			Debug.Log( "players clicked or triggered on me!" );
			Debug.Log( myHand.transform.position );
		}
	}

}
