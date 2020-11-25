using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform GunLeft;
    public Transform GunCenter;
    public Transform GunRight;
    

    public float fireDelay = 0.25f;
    float cooldownTimer = 0;
    

    // Start is called before the first frame update
    void Update() {
        cooldownTimer -= Time.deltaTime;

        if(Input.GetButton("Fire1") && cooldownTimer <= 0 ) {

            

            
            cooldownTimer = fireDelay;

            Instantiate(bulletPrefab, GunCenter);
            Instantiate(bulletPrefab, GunRight);
            Instantiate(bulletPrefab, GunLeft);

        }
        
    }

}
