using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemattack : MonoBehaviour
{
	public GameObject bulet;
	public float playerHealth;
	public float cooldown;
    // Start is called before the first frame update
    void Start()
    {
        cooldown = 0;
    }

    // Update is called once per frame
    void Update()
    {
    	cooldown -= Time.deltaTime;
        if(playerHealth >= 0){
        	if(cooldown <= 0){
        		Instantiate(bulet, transform.position, Quaternion.identity);
        		cooldown = 0.35f;
        	}
        	
        }
    }
}
