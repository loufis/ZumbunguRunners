using UnityEngine;
using UnityEngine.Networking;
using System.Collections;


public class GameManager : NetworkBehaviour {

	public GameObject testPrefab;
    private GameObject player = null;

    [Command]
    void CmdSpawn()
    {
        if (player == null)
        {
            player = Instantiate(testPrefab) as GameObject;
            NetworkServer.SpawnWithClientAuthority(player, base.connectionToClient);
        }
    }


	void Start () {
        //Debug.Log("PlayerSpawned");
        CmdSpawn();
    }
		
	// Update is called once per frame
	void Update () {

	}
}
