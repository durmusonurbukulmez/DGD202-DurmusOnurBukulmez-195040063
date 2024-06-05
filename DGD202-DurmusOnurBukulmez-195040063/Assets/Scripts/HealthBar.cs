using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI elementlerini kullancaðýmýz için bu kütüphaneye ihtiyaç var

public class HealthBar : MonoBehaviour
{


    public Slider slider; //slider kullanmamýz lazým

   
    public void SetMaxHealth(int health) //Player üzerinden canýmýz ile ilgili deðiþiklikler yapabilcez artýk
    {
        slider.maxValue = health; 
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
