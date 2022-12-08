using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMenu : MonoBehaviour
{
    public Rigidbody ball;
    public float speed = 1f;
    public static float globalGravity = -9.8f;
    public float gravityScale = 1.0f;
    private bool isForce = false;

    public AudioSource som;
    public AudioClip somBounce;

    

    private void Start()
    {
        ball = GetComponent<Rigidbody>();
        ball.useGravity = false;

    }

    private void FixedUpdate()
    {
        Vector3 gravity = globalGravity * gravityScale * Vector3.up;
        ball.AddForce(gravity, ForceMode.Acceleration);
        



    }

    void Force()
    {
        isForce = false;
        ball.AddForce(Vector3.up * speed, ForceMode.Impulse);
        ball.velocity = new Vector3(0, 5f, 0);

        som.PlayOneShot(somBounce);
    }

    private void Update()
    {
        if (isForce)
            Force();
    }
    private void OnCollisionEnter(Collision col)
    {
        isForce = true;
    }
}
