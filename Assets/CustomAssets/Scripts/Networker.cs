using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class Networker : NetworkManager {

	// Use this for initialization
	void Start () {
		
	}

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
		}
	}

	[Command]
	void CmdSpawn()
	{
		var go = (GameObject)Instantiate(otherPrefab, transform.position + new Vector3(0,1,0), Quaternion.identity);
		NetworkServer.SpawnWithClientAuthority(go, base.connectionToClient);
	}

}
