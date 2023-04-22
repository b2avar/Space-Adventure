using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenCalculator : MonoBehaviour
{
    public static ScreenCalculator Instance;

    public float Height { get; private set; }
    public float Width { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        Height = Camera.main.orthographicSize;
        //Debug.Log(Camera.main.aspect);
        Width = Height * Camera.main.aspect;
    }
    
}
