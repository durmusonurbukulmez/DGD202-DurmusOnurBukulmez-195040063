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

            AudioManager.instance.PLaySfx(0); //coin ses elementimizi çaðýrmak istiyoruz ve onun indeksi 0 olduðu için 0 yazdým. AudioManagerdeki sýrasý.

            collision.gameObject.SetActive(false);
        }
    }

}
