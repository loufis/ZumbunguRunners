﻿using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class ServerBehaviour : NetworkBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	[Command]
	public void Cmd_test(string x) {
		Debug.Log (x);
	}
}
