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
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0.0f, speed);
        //_direction = (player.transform.position - transform.position).normalized;
        //_lookrotation = Quaternion.LookRotation(_direction);
        //transform.rotation = Quaternion.Slerp(transform.rotation, _lookrotation,Time.deltaTime * 1);
        //transform.LookAt(player.transform);
        //transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 1);
    }

}
