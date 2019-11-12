using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    
    // Start is called before the first frame update
    void Start()
    {
        // Hello World!
    }

    // Update is called once per frame
    void Update() // 60 FPS
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // transform.Translate(0, 0, 1); <- Un-needed, We got better ways of handling motion. Like this:
        transform.Translate(forwardInput * speed * Time.deltaTime * Vector3.forward);
        
        if (Math.Abs(forwardInput) > 0)
        {
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        }
    }
}

