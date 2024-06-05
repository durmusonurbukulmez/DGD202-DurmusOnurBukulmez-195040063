using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //leveller aras� ge�i� yapabilmek i�in bu k�t�phaneye ihtiyac�m�z var

public class LevelExit : MonoBehaviour
{
    // 
    void Start()
    {
        
    }

    // 
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player") //ne zaman oyuncumuz collider a trigger olunca
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex; // Hangi scene de oldu�umuzu hesaplar. sorna bu bilgiyi correntSceneIndexe verir
            SceneManager.LoadScene(currentSceneIndex + 1); // +1 yazd�k ��nk� her level da tekrar yazmak istemiyoruz. 
        
        }
    }
}
