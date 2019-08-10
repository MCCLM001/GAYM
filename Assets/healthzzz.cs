using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthzzz : MonoBehaviour
{
    public GameObject entity;
    private int health;
    public string title;
    // Start is called before the first frame update
    void Start()
    {
        health =entity.GetComponent<healthbar>().health;
    }

    // Update is called once per frame
    void Update()
    {
       health =entity.GetComponent<healthbar>().health;
        GetComponent<Text>().text = title + " " + health;
    }
}
