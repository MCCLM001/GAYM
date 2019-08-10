using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Reset : MonoBehaviour
{
    public int health;
    public int enemhealth;
    public GameObject player;
    public GameObject boss;
    public bool gameOverScreen;
    public bool winScreen;
    public GameObject canvas;
    public GameObject wins;
    // Start is called before the first frame update
    void Start()
    {
        gameOverScreen = false;
        Time.timeScale = 1f;
        
    }

    // Update is called once per frame
    void Update()
    {
        health = player.GetComponent<healthbar>().health;
        enemhealth = boss.GetComponent<healthbar>().health;
        if(health <= 0 && enemhealth >= 1)
        {
            gameOverScreen = true;
            Time.timeScale = 0;
        }
        if(enemhealth <= 0 && health >=1){
            winScreen = true;
            Time.timeScale = 0;
        }
        //Debug.Log(health);
        if(gameOverScreen == true){
            canvas.SetActive(true);
        }
        else{
            canvas.SetActive(false);
        }
        if(winScreen == true){
            wins.SetActive(true);
        }
        else{
            wins.SetActive(false);
        }
    }
    public void Reload()
    {
        //Application.LoadLevel(Application.loadedLevel);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverScreen = false;
        canvas.SetActive(false);
    }
}
