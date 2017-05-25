﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.CrossPlatformInput;


public class Player : NetworkBehaviour {

	private Vector3 inputValue;
	
	// Update is called once per frame
	void Update () {

		if (!isLocalPlayer) {
			return;
		}
		inputValue.x = CrossPlatformInputManager.GetAxis ("Horizontal");
		inputValue.y = 0f;
		inputValue.z = CrossPlatformInputManager.GetAxis ("Vertical");

		transform.Translate(inputValue);
	}

	public override void OnStartLocalPlayer() {
		GetComponentInChildren<Camera>().enabled = true;
	}
}
