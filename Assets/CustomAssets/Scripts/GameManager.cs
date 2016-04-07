using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class GameManager : NetworkManager {

    private ServerBehaviour serverBehavior = null;
    private ClientBehaviour clientBehavior = null;
    public override void OnStartHost()
    {
        base.OnStartHost();
        serverBehavior = new ServerBehaviour();
    }

    public override void OnStartClient(NetworkClient client)
    {
        base.OnStartClient(client);
        clientBehavior = new ClientBehaviour();
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
			else if (Input.GetButtonDown ("Check"))
				print (NetworkServer.active);
		}
	}

}
