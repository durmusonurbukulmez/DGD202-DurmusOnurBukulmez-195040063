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
            PuaseUnpause(); //esc ye bast���m�zda oyunun durmas�n� ve tekrar bast���m�zda �al��mas�n� sa�layacak 
        }
    }

    public void PuaseUnpause()
    {
        if (isPaused)
        {
            isPaused = false;
            pauseScreen.SetActive(false);
            Time.timeScale = 1f; //Oyunumuzu normale d�ndercek
        }
        else
        {
            isPaused = true;
            pauseScreen.SetActive(true);
            Time.timeScale = 0f; //Oyunu dondurmam�z� sa�layacak bu sayede pause yapt���m�zda oyun arkaplanda hareket etmeyecek
        }
    }
   public void MainMenu()
    {
        SceneManager.LoadScene(mainMenuName); //bu fonksiyon ve butonu birlikte kullan�caz
        Time.timeScale = 1f;//Bunu koydum ��nk� pause ekran�na t�klay�p men�ye d�n�p tekrar playe bast���m�zda oyun donar halde kalmas�n� sa�layan bug olmu�tu. bu sayede oyun ak�c� devam edicek tekrardan.
    }

}
