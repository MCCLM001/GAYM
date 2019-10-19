using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthzzz : MonoBehaviour
{
    public GameObject entity;
    private float health;
    public string title;
    // Start is called before the first frame update
    void Start()
    {
        if(entity.name == "gunner"){
            health =entity.GetComponent<healthbar>().health;
        }else{
            health =entity.GetComponent<enemhealth>().health;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(entity.name == "gunner"){
            health =entity.GetComponent<healthbar>().health;
            GetComponent<Text>().text = title + " " + health;
        }else{
            health =entity.GetComponent<enemhealth>().health;
            GetComponent<Text>().text = title + " " + health;
        }
    }
}
