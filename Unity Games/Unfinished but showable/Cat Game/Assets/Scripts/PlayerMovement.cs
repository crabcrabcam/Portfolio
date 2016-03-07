using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public int speed;
    public float jumpHeight;
    public float jumpHeightSave;
    public float jumpHeight2;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

    public Transform trampCheck;
    public float trampCheckRadius;
    public LayerMask whatIsTramp;
    private bool tramped;

    // Use this for initialization
    void Start () {
        
    }

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        tramped = Physics2D.OverlapCircle(trampCheck.position, trampCheckRadius, whatIsTramp);
    }

    // Update is called once per frame
    void Update () {
        Movement();
	}

    void Movement()
    {
        if (tramped)
        {
            jumpHeight = jumpHeight2;
        }
        else
        {
            jumpHeight = jumpHeightSave;
        }

        if (Input.GetAxisRaw("Horizontal") > 0.5f)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }
        //Left on A
        if (Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 180);
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f && grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }
    }
    
       
    
}
