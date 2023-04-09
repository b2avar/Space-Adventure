using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private PolygonCollider2D _polygonCollider2D;
    private float _randomSpeed;
    private bool _isMovement;

    private float _min, _max;

    public bool IsMovement
    {
        get { return _isMovement; }
        set { _isMovement = value; }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        _polygonCollider2D = GetComponent<PolygonCollider2D>();
        _randomSpeed = Random.Range(0.5f, 1.0f);
        
        float objectWidth = _polygonCollider2D.bounds.size.x / 2;
        
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

    // Update is called once per frame
    void Update()
    {
        if (_isMovement)
        {
            float pingPongX = Mathf.PingPong(Time.time * _randomSpeed, _max - _min) + _min;
            Vector2 pingPong = new Vector2(pingPongX, transform.position.y);
            transform.position = pingPong;
        }
    }
}
