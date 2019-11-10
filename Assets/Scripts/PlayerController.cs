using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Hello World!
    }

    // Update is called once per frame
    void Update() // 60 FPS
    {
        // transform.Translate(0, 0, 1); <- Un-needed, We got better ways of handling motion.
        transform.Translate(Vector3.forward); // does the same thing ^.
    }
}
