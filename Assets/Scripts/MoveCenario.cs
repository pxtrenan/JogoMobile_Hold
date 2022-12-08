using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCenario : MonoBehaviour {

    private float speed;
    public float x;





    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {


        speed = -3.15f;
        x = transform.position.x;

        x += speed * Time.deltaTime;

        transform.position = new Vector3(x, transform.position.y, transform.position.z);

        if (x <= -9)
        {

            Destroy(transform.gameObject);
        }

    }


}
