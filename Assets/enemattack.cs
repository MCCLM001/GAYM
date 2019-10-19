using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemattack : MonoBehaviour
{
	public GameObject bulet;
	public float playerHealth;
	public float cooldown;
    private float cooldown1;
    // Start is called before the first frame update
    void Start()
    {
        cooldown1 = cooldown;
    }

    // Update is called once per frame
    void Update()
    {
    	cooldown1 -= Time.deltaTime;
        if(playerHealth >= 0){
        	if(cooldown1 <= 0){
        		Instantiate(bulet, transform.position, Quaternion.identity);
        		cooldown1 = cooldown;
        	}
        	
        }
    }
}
