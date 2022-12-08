using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    public GameObject portal;
    public GameObject ball;
    //public GameObject ball2;
    //public GameObject ball3;
    //public GameObject ball4;
    //public GameObject ball5;
    //public GameObject ball6;


    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DeathMenu")
        {
            StartCoroutine(Teleport());

        }
    }

    IEnumerator Teleport()
    {
        yield return new WaitForSeconds(0);
        ball.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);
        //ball2.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);
        //ball3.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);
        //ball4.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);
        //ball5.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);
        //ball6.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);

    }
}
