using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenCalculator : MonoBehaviour
{
    public static ScreenCalculator Instance;

    private float _height;
    private float _width;

    public float Height { get { return _height; } }
    public float Width { get { return _width; } }
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

        _height = Camera.main.orthographicSize;
        _width = _height * Camera.main.aspect;
    }
    
}
