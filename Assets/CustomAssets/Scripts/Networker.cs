using UnityEngine;
using UnityEngine.Networking;
using System.Collections.Generic;

public class Networker : NetworkManager {

    public List<GameObject> Player1Spawners;
    public List<GameObject> Player2Spawners;
    public GameObject Obstacle;
	bool initiatedSpawnSequence;
    private void spawnObstacles()
    {
        NetworkServer.Spawn(Instantiate(Obstacle, Player1Spawners[1].transform.position, Quaternion.identity) as GameObject);
        NetworkServer.Spawn(Instantiate(Obstacle, Player2Spawners[0].transform.position, Quaternion.identity) as GameObject);
        Invoke("spawnObstacles", 2);
    }
	// Use this for initialization
	void Start () {
		initiatedSpawnSequence = false;
	}

	public override void OnServerConnect(NetworkConnection conn)
	{
		Debug.Log (conn.address);

		if (NetworkServer.active && !initiatedSpawnSequence)
        {
			initiatedSpawnSequence = true;
            Debug.Log("Starting The Spawn Sequence");
            spawnObstacles();
        }
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




}
