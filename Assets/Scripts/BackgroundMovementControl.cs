using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class BackgroundMovementControl : MonoBehaviour
{
    private float _backgroundPosition;
    private float distance = 10.24f;



    // Start is called before the first frame update
    private void Start()
    {
        _backgroundPosition = transform.position.y;
    }
    
    
    private void Update()
    {
        if (_backgroundPosition + distance < Camera.main.transform.position.y)
        {
            ChanceBackground();
        }
    }
    
    private void ChanceBackground()
    {
        _backgroundPosition += (distance * 2);
        var newPosition = new Vector2(0, _backgroundPosition);
        transform.position = newPosition;
    }
}
