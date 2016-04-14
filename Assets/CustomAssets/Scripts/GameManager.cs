using UnityEngine;
using UnityEngine.Networking;
using System.Collections;


public class GameManager : NetworkBehaviour {

	public GameObject testPrefab;

	void Start () {
		GameObject player = Instantiate(testPrefab) as GameObject;
		NetworkServer.SpawnWithClientAuthority(player, base.connectionToClient);
	}
		
	// Update is called once per frame
	void Update () {

	}
}
