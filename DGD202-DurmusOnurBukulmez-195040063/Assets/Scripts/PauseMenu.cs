using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static PauseMenu instance;

    public string mainMenuName;
    public GameObject pauseScreen;
    public bool isPaused;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PuaseUnpause(); //esc ye bastýðýmýzda oyunun durmasýný ve tekrar bastýðýmýzda çalýþmasýný saðlayacak 
        }
    }

    public void PuaseUnpause()
    {
        if (isPaused)
        {
            isPaused = false;
            pauseScreen.SetActive(false);
            Time.timeScale = 1f; //Oyunumuzu normale döndercek
        }
        else
        {
            isPaused = true;
            pauseScreen.SetActive(true);
            Time.timeScale = 0f; //Oyunu dondurmamýzý saðlayacak bu sayede pause yaptýðýmýzda oyun arkaplanda hareket etmeyecek
        }
    }
   public void MainMenu()
    {
        SceneManager.LoadScene(mainMenuName); //bu fonksiyon ve butonu birlikte kullanýcaz
        Time.timeScale = 1f;//Bunu koydum çünkü pause ekranýna týklayýp menüye dönüp tekrar playe bastýðýmýzda oyun donar halde kalmasýný saðlayan bug olmuþtu. bu sayede oyun akýcý devam edicek tekrardan.
    }

}
