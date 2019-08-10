using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pew : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.Rotate(new Vector3(0, 0, -90));
    }


    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0.0f, speed);
    }
}
