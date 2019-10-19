using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGaym : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Begin(){
    	SceneManager.LoadScene("PlaySceneGaym");
        SceneManager.UnloadSceneAsync("MenuSceneGaym");
    	
    }
    public void Menu(){
        SceneManager.LoadScene("MenuSceneGaym");
        SceneManager.UnloadSceneAsync("PlaySceneGaym");
    }
    public void Equipo(){
        SceneManager.LoadScene("Equip");
        SceneManager.UnloadSceneAsync("MenuSceneGaym");
    }
    public void Menu2(){
        SceneManager.LoadScene("MenuSceneGaym");
        SceneManager.UnloadSceneAsync("Equip");
    }
}
