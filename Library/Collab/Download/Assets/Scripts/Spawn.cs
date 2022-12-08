using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject ball1;
    

    private float rateSpawn;
    public float currentTime;

    private int number, temp = 0;

    private float y;

    // Start is called before the first frame update
    void Start()
    {

        currentTime = 0;

    }

    // Update is called once per frame
    void Update()
    {

        rateSpawn = 1.225f;

        currentTime += Time.deltaTime;
        if (currentTime >= rateSpawn)
        {
            currentTime = 0;

            number = Random.Range(1, 2);


            temp = number;

            if (number == 1)
            {
                GameObject tempPrefab = Instantiate(ball1) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
           

        }
    }
        
    
}
