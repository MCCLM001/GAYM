using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enempew : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public GameObject player;
    private Quaternion _lookrotation;
    private Vector3 _direction;
    public Vector3 location;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        location = new Vector3(player.transform.position.x, 0.0f, player.transform.position.z );
        transform.LookAt(location, Vector3.right);
        //transform.Rotate(0.0f, 0.0f, -45.0f);

        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        float step = speed * Time.deltaTime;
        transform.position += transform.forward * step;
        
        
        //transform.LookAt(player.transform);
        //Debug.Log(transform.rotation);
    }

}
