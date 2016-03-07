using UnityEngine;
using System.Collections;
using System.Threading;
using System;

public class PlayerMovement : MonoBehaviour {



    public Transform firePointRight;
    public Transform firePointLeft;
    public GameObject ninjaStar;

    public float speed;
    public float jumpHeight;
    public string travel;
    public bool flight;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

    public Sprite Player_Right_Shoot;
    public Sprite Player_Right;
    public Sprite Player_Left_Shoot;
    public Sprite Player_Left;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxisRaw("Vertical") > 0.5f && grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (travel == "right")
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Player_Right_Shoot;
                Instantiate(ninjaStar, firePointRight.position, firePointRight.rotation);
            }
            if(travel == "left")
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Player_Left_Shoot;
                Instantiate(ninjaStar, firePointLeft.position, firePointLeft.rotation);
            }
            else
            {
                Debug.Log("Check spelling you dick");
            }

            if (flight)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5);
            }


        }
        
    }

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        if (travel == "right")
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Player_Right;
        }
        if (travel == "left")
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Player_Left;
        }
        
    }

}
