using UnityEngine;
using System.Collections;

public class Direction : MonoBehaviour {

    public PlayerMovement player;

    public string directionToChange;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            player.travel = directionToChange;
        }

    }
}