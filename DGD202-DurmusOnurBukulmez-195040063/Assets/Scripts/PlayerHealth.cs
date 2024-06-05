using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int currentHealth;
    public int maxHealth;

    public static PlayerHealth instance;

    public HealthBar healthbar;

    public float immortalTime;
    private float immortalCounter;

    private SpriteRenderer sr;

    private Vector2 checkPoint;


   

    private void Awake()
    {
        instance = this;   
    }


    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);

        checkPoint=transform.position;
    }

  
    void Update()
    {
        if(immortalCounter > 0)
        {
            immortalCounter -= Time.deltaTime;
            if(immortalCounter <= 0)
            {
                sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 1f);
            }   
        } 
    }

    public void DealDamage()
    {
        if(immortalCounter <= 0)
        {
            currentHealth--; 
            healthbar.SetHealth(currentHealth);

            if (currentHealth <= 0) //damage aldýðýmýzda ve canýmýz 0 dan az olduðunda playerýmýz diactivated olmalý yani ölmeli.
            {
                Die();
            }
            else
            {
                immortalCounter = immortalTime;
                sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 0.5f);
            }
        }

        
    }

    public void UpdatedCheckpoint(Vector2 pos)
    {
        checkPoint = pos;
    }
    void Die()
    {
        Respawn();
    }

    void Respawn()
    {

        currentHealth = maxHealth;
        healthbar.SetHealth(currentHealth);

        transform.position = checkPoint;
    }
}
