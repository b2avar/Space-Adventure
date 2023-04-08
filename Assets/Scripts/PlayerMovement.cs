using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;

    private Vector2 _velocity;

    [SerializeField] private float speed;
    [SerializeField] private float acceleration;
    [SerializeField] private float deceleration;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        KeyboardController();
    }

    void KeyboardController()
    {
        float movementInput = Input.GetAxisRaw("Horizontal");
        Vector2 scale = transform.localScale;
        if (movementInput > 0)
        {
            _velocity.x = Mathf.MoveTowards(_velocity.x, movementInput * speed, acceleration * Time.deltaTime);
            _animator.SetBool("Walk", true);
            scale.x = 1;
        }
        
        else if (movementInput < 0)
        {
            _velocity.x = Mathf.MoveTowards(_velocity.x, movementInput * speed, acceleration * Time.deltaTime);
            _animator.SetBool("Walk", true);
            scale.x = -1;
        }

        else
        {
            _velocity.x = Mathf.MoveTowards(_velocity.x, 0, deceleration * Time.deltaTime);
            _animator.SetBool("Walk", false);
        }
        transform.localScale = scale;
        transform.Translate(_velocity * Time.deltaTime);
    }
}
