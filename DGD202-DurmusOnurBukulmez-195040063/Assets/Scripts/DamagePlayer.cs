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

    private void OnTriggerEnter2D(Collider2D collision) //bu fonksiyon �zel bir fonksiyon. player�m�z veya game object collider'�m�z triggerland���nda yani dokunuldu�unda
    {
        if (collision.tag == "Player") //e�er bir �ey oyuncuya sald�r�rsa veya can�n� azaltacak bir �ey olursa
        {
           
            PlayerHealth.instance.DealDamage();//Buras� �al��cak zaten can�n� azaltt���m�z k�s�m buran�n i�inde a��kl�yorum.
            AudioManager.instance.PLaySfx(2); // Damage ald���m�zda ��kan ses efektinin indeksi 2 , Audio managerdan �a��r�yoruz.
        } 

    }

}
