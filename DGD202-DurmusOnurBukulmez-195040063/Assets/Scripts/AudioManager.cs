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

    public void PLaySfx(int soundPlay)//Bu fonksiyonu çaðýrdýðýmýzda, ses efektlerini oynatacak
    {
        soundEffects[soundPlay].Play();
        soundEffects[soundPlay].pitch = Random.Range(0.8f, 1f); // Bu kodun anlamý, birkaç coin toplarken veya birkaç ses çýkartan durum yaþanýrken (örneðin birkaç düþmandan damage yerken) ayný ses efektinin biraz tizi veya pesi çalmasýný saðlamak. Daha güzel olmasý açýsýndan
    }
}
