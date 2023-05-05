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
    [SerializeField] private float jumpForce;
    [SerializeField] private int jumpLimit;
    [SerializeField] private int jumpCount;
    private Joystick _joystick;
    private JoystickButton _joystickButton;
    private bool isJumping;
    
    // Start is called before the first frame update
    private void Start()
    {
        _joystickButton = FindObjectOfType<JoystickButton>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _joystick = FindObjectOfType<Joystick>();
    }
    
    private void Update()
    {
#if UNITY_EDITOR
        KeyboardController();
#else
        JoystickController();
#endif
    }

    private void KeyboardController()
    {
        var movementInput = Input.GetAxisRaw("Horizontal");
        Vector2 scale = transform.localScale;
        switch (movementInput)
        {
            case > 0:
                _velocity.x = Mathf.MoveTowards(_velocity.x, movementInput * speed, acceleration * Time.deltaTime);
                _animator.SetBool("Walk", true);
                scale.x = 0.3f;
                break;
            case < 0:
                _velocity.x = Mathf.MoveTowards(_velocity.x, movementInput * speed, acceleration * Time.deltaTime);
                _animator.SetBool("Walk", true);
                scale.x = -0.3f;
                break;
            default:
                _velocity.x = Mathf.MoveTowards(_velocity.x, 0, deceleration * Time.deltaTime);
                _animator.SetBool("Walk", false);
                break;
        }
        transform.localScale = scale;
        transform.Translate(_velocity * Time.deltaTime);

        if (Input.GetKeyDown("space"))
        {
            StartJump();
        }

        if (Input.GetKeyDown("space"))
        {
            StopJump();
        }
    }
    
    void JoystickController()
    {
        float movementInput = _joystick.Horizontal;
        Vector2 scale = transform.localScale;
        switch (movementInput)
        {
            case > 0:
                _velocity.x = Mathf.MoveTowards(_velocity.x, movementInput * speed, acceleration * Time.deltaTime);
                _animator.SetBool("Walk", true);
                scale.x = 0.3f;
                break;
            case < 0:
                _velocity.x = Mathf.MoveTowards(_velocity.x, movementInput * speed, acceleration * Time.deltaTime);
                _animator.SetBool("Walk", true);
                scale.x = -0.3f;
                break;
            default:
                _velocity.x = Mathf.MoveTowards(_velocity.x, 0, deceleration * Time.deltaTime);
                _animator.SetBool("Walk", false);
                break;
        }
        transform.localScale = scale;
        transform.Translate(_velocity * Time.deltaTime);
        
        if (_joystickButton.isKeyPressed == true && isJumping == false)
        {
            isJumping = true;
            StartJump();
        }

        if (_joystickButton.isKeyPressed == false && isJumping == true)
        {
            isJumping = false;
            StopJump();
        }
    }

    private void StartJump()
    {
        if(!(jumpCount < jumpLimit)) return;
        FindObjectOfType<SoundControl>().JumpSound();
        _rigidbody2D.AddForce(new Vector2(0,jumpForce),ForceMode2D.Impulse);
        _animator.SetBool("Jump",true);
        FindObjectOfType<SlideControl>().Slider(jumpLimit,jumpCount);
    }

    private void StopJump()
    {
        _animator.SetBool("Jump",false);
        jumpCount++;
        FindObjectOfType<SlideControl>().Slider(jumpLimit,jumpCount);
    }
    
    public void ResetJump()
    {
        jumpCount = 0;
        FindObjectOfType<SlideControl>().Slider(jumpLimit,jumpCount);
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "DeathPoint")
        {
            FindObjectOfType<GameControl>().GameOver();
        }
    }
    
    public void GameOver()
    {
        Destroy(gameObject);
    }


}
