using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //leveller arasý geçiþ yapabilmek için bu kütüphaneye ihtiyacýmýz var

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
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex; // Hangi scene de olduðumuzu hesaplar. sorna bu bilgiyi correntSceneIndexe verir
            SceneManager.LoadScene(currentSceneIndex + 1); // +1 yazdýk çünkü her level da tekrar yazmak istemiyoruz. 
        
        }
    }
}
