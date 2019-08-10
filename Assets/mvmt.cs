using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mvmt : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 6.0f;
    private float xvel = 0.0f;
    private float yvel = 0.0f;
    private bool right = false;
    private bool left = false;
    private bool up = false;
    private bool down = false;
    Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocity = new Vector2(0.0f, 0.0f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            yvel = speed;
            up = true;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow) && !down)
        {
            yvel = 0.0f;
            up = false;
        }else if (Input.GetKeyUp(KeyCode.UpArrow)) { 
            up = false; 
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            yvel = -speed;
            down = true;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow) && !up)
        {
            yvel = 0.0f;
            down = false;
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            down = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            xvel = -speed;
            left = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) && !right)
        {
            xvel = 0.0f;
            left = false;
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            left = false;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            xvel = speed;
            right = true;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && !left)
        {
            xvel = 0.0f;
            right = false;

        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            right = false;
        }
        velocity = new Vector2(xvel, yvel);
        rb.velocity = velocity;
    }
    private void FixedUpdate()
    {

       
    }
}
