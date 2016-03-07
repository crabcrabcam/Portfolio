using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public int speed;
    public float jumpHeight;
    public float jumpHeightSave;
    public float jumpHeight2;




    public Sprite Player_Forward;
    public Sprite Player_Move;

    // Use this for initialization
    void Start () {
        
    }

    void FixedUpdate()
    {

    }

    // Update is called once per frame
    void Update () {
        Movement();
	}

    void Movement()
    {

        if (Input.GetAxisRaw("Horizontal") > 0.5f)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Player_Move;
            transform.eulerAngles = new Vector2(0, 0);
        }
       else if (Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Player_Move;
            transform.eulerAngles = new Vector2(0, 180);

        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Player_Forward;
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }
    }
    
       
    
}
