using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemhealth : MonoBehaviour
{
    public float health;
    public int damage;
    public int bigDamage;
    // Start is called before the first frame update
    void Start()
    {
}

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ouch")
        {
            health -= damage;
            Destroy(other.gameObject);
        }
        if (other.tag == "bigouch"){
            health -= bigDamage;
            Destroy(other.gameObject);
        }
    }
}

