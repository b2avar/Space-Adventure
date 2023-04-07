using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class BackgroundMovementControl : MonoBehaviour
{
    private float _backgroundPosition;
    private float _distance = 10.24f;



    // Start is called before the first frame update
    void Start()
    {
        _backgroundPosition = transform.position.y;
    }
    

// Update is called once per frame
    void Update()
    {
        if (_backgroundPosition + _distance < Camera.main.transform.position.y)
        {
            ChanceBackground();
        }
    }
    
    void ChanceBackground()
    {
        _backgroundPosition += (_distance * 2);
        Vector2 newPosition = new Vector2(0, _backgroundPosition);
        transform.position = newPosition;
    }
}
