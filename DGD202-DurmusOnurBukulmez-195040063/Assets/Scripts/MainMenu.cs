using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //scenemanagement üzerinde çalýþcaðýmýz kütüphane lazým

public class MainMenu : MonoBehaviour
{
    public string sceneName;
   
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    //iki butonumuz var bu yüzden iki fonksiyon kodluyoruz

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
