using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class DeadlyPlatform : MonoBehaviour
{
    private BoxCollider2D _boxCollider2D;
    private float _randomSpeed;

    private float _min, _max;

    public bool IsMovement { get; set; }

    private void Start()
    {
        _boxCollider2D = GetComponent<BoxCollider2D>();
        _randomSpeed = Random.Range(0.5f, 1.0f);
        
        var objectWidth = _boxCollider2D.bounds.size.x / 2;
        
        if (transform.position.x > 0)
        {
            _min = objectWidth;
            _max = ScreenCalculator.Instance.Width - objectWidth;
        }

        else
        {
            _min = -ScreenCalculator.Instance.Width + objectWidth;
            _max = -objectWidth;
        }
    }

    private void Update()
    {
        if (!IsMovement) return;
        var pingPongX = Mathf.PingPong(Time.time * _randomSpeed, _max - _min) + _min;
        var pingPong = new Vector2(pingPongX, transform.position.y);
        transform.position = pingPong;
    }
}
