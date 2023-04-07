using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float speed;
    private float acceleration;
    private float maximumSpeed;

    private bool _movement;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.5f;
        acceleration = 0.5f;
        maximumSpeed = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        MoveCamera();
    }

    void MoveCamera()
    {
        transform.position += transform.up * speed * Time.deltaTime;
        speed += acceleration * Time.deltaTime;
        if (speed > maximumSpeed)
        {
            speed = maximumSpeed;
        }
    }
}