using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour {

    public Rigidbody cameraRigidbody;
    public float Speed = 2;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            cameraRigidbody.transform.Translate(new Vector2(Speed * Time.deltaTime , 0));
        }
    }

}
