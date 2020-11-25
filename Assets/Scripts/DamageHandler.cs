using System.Collections;
using System.Collections.Generic;
using diag = System.Diagnostics;
using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    public int health = 1;
    public AudioClip death;
    public AudioSource sfx;



    public float invulnPeriod = 0;
    float invulnTimer = 0;
    int correctLayer;

    void Start()
    {
        sfx = GetComponent<AudioSource>();
        correctLayer = gameObject.layer;
    }

    void OnTriggerEnter2D() {
        //Debug.Log("Dead!");

        health--;
        invulnTimer = 0.50f;

        

        gameObject.layer = 10;
        sfx.PlayOneShot(death, 1.4f);
        ScoreScript.scoreValue += 1;



        //}
    }
        void Update() {
        invulnTimer -= Time.deltaTime;
        if(invulnTimer <= 0) {
            gameObject.layer = correctLayer;
            
        }

      

        if(health <= 0)
        {
            
            Die();
        }
    }

    void Die() {
        
        Destroy(gameObject, 0.1f);

    }
}
