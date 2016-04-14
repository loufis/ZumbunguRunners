using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class ObstacleMovement : NetworkBehaviour {

    private Vector2 currentVelocity;
    private Rigidbody2D rigidBody;
    public void setVelocity(Vector2 newVelocity)
    {
        currentVelocity = newVelocity;
    }

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        currentVelocity = new Vector2(-5, 0);
    }
	// Use this for initialization
	void Start () {
        rigidBody.velocity = currentVelocity;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
