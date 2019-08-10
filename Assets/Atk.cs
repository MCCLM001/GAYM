using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atk : MonoBehaviour
{
    public GameObject bullet;
    private float cooldown;
    // Start is called before the first frame update
    void Start()
    {
        cooldown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (cooldown <= 0)
            {
                Instantiate(bullet, transform.position, Quaternion.identity);
                cooldown = 0.5f;
            }

        }

    }
}
