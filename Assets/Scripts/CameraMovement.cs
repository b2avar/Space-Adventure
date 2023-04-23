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
    private void Start()
    {
        if (Options.GetEasyValue() == 1)
        {
            speed = 0.3f;
            acceleration = 0.03f;
            maximumSpeed = 1.5f;
        }

        if (Options.GetMediumValue() == 1)
        {
            speed = 0.8f;
            acceleration = 0.08f;
            maximumSpeed = 2.5f;
        }
        
        if (Options.GetHardValue() == 1)
        {
            speed = 1f;
            acceleration = 0.05f;
            maximumSpeed = 2.0f;
        }
        
        
    }
    
    private void Update()
    {
        MoveCamera();
    }

    private void MoveCamera()
    {
        transform.position += transform.up * speed * Time.deltaTime;
        speed += acceleration * Time.deltaTime;
        if (speed > maximumSpeed)
        {
            speed = maximumSpeed;
        }
    }
}
