using UnityEngine;
using System.Collections;

public class NinjaStar : MonoBehaviour {

    public float ninjaSpeed;

    public PlayerMovement player;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerMovement>();

        if (player.travel == "left")
        {
            ninjaSpeed = -ninjaSpeed;
        }

	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(ninjaSpeed, GetComponent<Rigidbody2D>().velocity.y);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Block")
        {
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}
