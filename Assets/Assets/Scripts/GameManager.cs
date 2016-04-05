using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class GameManager : NetworkManager {


	public override void OnServerConnect(NetworkConnection conn)
	{
		Debug.Log (conn.address);
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Host")) {
			StartHost ();
		}
		else {
			if (Input.GetButtonDown ("Client"))
				StartClient ();
			else if (Input.GetButtonDown ("Check"))
				print (Network.isServer);
		}
	}

}
