using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private PolygonCollider2D _polygonCollider2D;
    private float randomSpeed;
    private bool _isMovement = true;

    public bool IsMovement
    {
        get { return _isMovement; }
        set { _isMovement = value; }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        _polygonCollider2D = GetComponent<PolygonCollider2D>();
        randomSpeed = Random.Range(0.5f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (_isMovement)
        {
            float pingPongX = Mathf.PingPong(Time.time * randomSpeed, 3.0f);
            Vector2 pingPong = new Vector2(pingPongX, transform.position.y);
            transform.position = pingPong;
        }
    }
}
