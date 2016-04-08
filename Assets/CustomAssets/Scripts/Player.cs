using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class Player : NetworkBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Check")) {
			//if (!NetworkServer.active)
			Rpc_test ("WHEEEEEEEEE");
		}
	}

	[Command]
	public void Cmd_test(string x) {
		Debug.Log (x);
	}

	[ClientRpc]
	public void Rpc_test(string x) {
		Debug.Log(x);
	}
}
