using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) //bu fonksiyon özel bir fonksiyon. playerýmýz veya game object collider'ýmýz triggerlandýðýnda yani dokunulduðunda
    {
        if (collision.tag == "Player") //eðer bir þey oyuncuya saldýrýrsa veya canýný azaltacak bir þey olursa
        {
           
            PlayerHealth.instance.DealDamage();//Burasý çalýþcak zaten canýný azalttýðýmýz kýsým buranýn içinde açýklýyorum.
            AudioManager.instance.PLaySfx(2); // Damage aldýðýmýzda çýkan ses efektinin indeksi 2 , Audio managerdan çaðýrýyoruz.
        } 

    }

}
