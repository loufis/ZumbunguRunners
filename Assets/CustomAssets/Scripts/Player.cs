using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class Player : NetworkBehaviour {

    public GameObject GMPrefab;
    private GameObject GM = null;

    [Command]
    void CmdSpawn()
    {
        if (GM == null)
        {
            GM = Instantiate(GMPrefab) as GameObject;
            NetworkServer.SpawnWithClientAuthority(GM, base.connectionToClient);
        }
    }


    void Start()
    {
        //Debug.Log("PlayerSpawned");
        CmdSpawn();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
    [Command]
    public void CmdAnimate(string animation, float Speed, bool Ground, bool Crouch, float vSpeed)
    {

    }

    [ClientRpc]
    public void RpcAnimate(string animation, float Speed, bool Ground, bool Crouch, float vSpeed)
    {

    }
    */
}
