using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PickUps : MonoBehaviour
{

    public TMP_Text scoreText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            Scoring.totalScore++;

            scoreText.text = "SCORE: " + Scoring.totalScore;

            AudioManager.instance.PLaySfx(0); //coin ses elementimizi �a��rmak istiyoruz ve onun indeksi 0 oldu�u i�in 0 yazd�m. AudioManagerdeki s�ras�.

            collision.gameObject.SetActive(false);
        }
    }

}
