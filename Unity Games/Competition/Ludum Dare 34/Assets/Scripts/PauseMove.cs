using UnityEngine;
using System.Collections;

public class PauseMove : MonoBehaviour {

    public PlayerMovement player;
    public float newSpeed;
    public bool goUp;
    public float newJump;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D()
    {
        player.speed = newSpeed;
        player.jumpHeight = newJump;
    }
}
