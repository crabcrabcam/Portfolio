using UnityEngine;
using System.Collections;

public class PlayerFreeMove : MonoBehaviour
{

    public int speed = 5;
    public int jumpHeight = 5;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0.5f)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }
        //Left on A
        if (Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 180);
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (Input.GetAxisRaw("Vertical") > -0.5f)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }
}