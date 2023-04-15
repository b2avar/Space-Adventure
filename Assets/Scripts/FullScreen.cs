using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreen : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        Vector2 tempScale = transform.localScale;
        
        var spriteWidth = spriteRenderer.size.x;
        var screenHeight = Camera.main.orthographicSize * 2.0f;
        var screenWidth = (screenHeight / Screen.height) * Screen.width;
        tempScale.x = screenWidth / spriteWidth;
        transform.localScale = tempScale;
    }
}
