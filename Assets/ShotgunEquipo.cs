using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotgunEquipo : MonoBehaviour
{
	public GameObject gun;
    public GameObject[] guns;
	public Text equipped;
    // Start is called before the first frame update
    void Start()
    {
        equipped.text = "Equipped: " + gun.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void stockEquip(){
        gun = guns[0];
        equipped.text = "Equipped: " + gun.name;
        StcokStats.dmg = 1f;
        StcokStats.reload = 1f;
    }
    public void flameEquip(){
        gun = guns[1];
        equipped.text = "Equipped: " + gun.name;
        StcokStats.dmg = 1.4f;
        StcokStats.reload = 1.6f;
    }
    public void steelEquip(){
        gun = guns[2];
        equipped.text = "Equipped: " + gun.name;
        StcokStats.dmg = 0.8f;
        StcokStats.reload = 0.7f;
    }
}
