using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource[] soundEffects;
    public static AudioManager instance;

    public AudioSource bgmmusic;

    private void Awake()
    {
        instance = this;    
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void PLaySfx(int soundPlay)//Bu fonksiyonu �a��rd���m�zda, ses efektlerini oynatacak
    {
        soundEffects[soundPlay].Play();
        soundEffects[soundPlay].pitch = Random.Range(0.8f, 1f); // Bu kodun anlam�, birka� coin toplarken veya birka� ses ��kartan durum ya�an�rken (�rne�in birka� d��mandan damage yerken) ayn� ses efektinin biraz tizi veya pesi �almas�n� sa�lamak. Daha g�zel olmas� a��s�ndan
    }
}
