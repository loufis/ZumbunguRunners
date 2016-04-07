using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class ClientBehaviour : NetworkBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	[ClientRpc]
	Rpc_test(string x) {
		Debug.Log(x);
	}

}
