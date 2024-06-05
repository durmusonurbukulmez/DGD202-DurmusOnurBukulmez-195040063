using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //scenemanagement �zerinde �al��ca��m�z k�t�phane laz�m

public class MainMenu : MonoBehaviour
{
    public string sceneName;
   
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    //iki butonumuz var bu y�zden iki fonksiyon kodluyoruz

    public void StartGame()
    {
        SceneManager.LoadScene(sceneName); 
    }


    public void QuickGame()
    {
        Application.Quit();
        Debug.Log("leaving game");
    }
}
