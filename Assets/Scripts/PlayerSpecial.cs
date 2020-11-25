using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpecial : MonoBehaviour {

    public GameObject bulletPrefab;

    public float fireDelay = 0.25f;
    float cooldownTimer = 0;

    // Start is called before the first frame update
    void Update() {
        cooldownTimer -= Time.deltaTime;

        if(Input.GetButton("Fire2") && cooldownTimer <= 0 ) {
            //SHOOT!
            cooldownTimer = fireDelay;

            Instantiate(bulletPrefab, transform.position, transform.rotation);

        }
        
    }

}
