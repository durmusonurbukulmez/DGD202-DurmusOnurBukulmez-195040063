using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI elementlerini kullanca��m�z i�in bu k�t�phaneye ihtiya� var

public class HealthBar : MonoBehaviour
{


    public Slider slider; //slider kullanmam�z laz�m

   
    public void SetMaxHealth(int health) //Player �zerinden can�m�z ile ilgili de�i�iklikler yapabilcez art�k
    {
        slider.maxValue = health; 
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
