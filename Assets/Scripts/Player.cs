using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{

    float maxSpeed = 3f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        // Returns a FLOAT from -1.0 to +1.0


        Vector3 pos = transform.position;
        //
        pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;

        transform.position = pos;
        //
        pos.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;

        transform.position = pos;



    }
}
