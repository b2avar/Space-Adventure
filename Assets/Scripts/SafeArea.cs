using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeArea : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -ScreenCalculator.Instance.Width)
        {
            Vector2 temp = transform.position;
            temp.x = -ScreenCalculator.Instance.Width + (GetComponent<Collider2D>().bounds.size.x/2);
            transform.position = temp;
        }
        
        if (transform.position.x > ScreenCalculator.Instance.Width)
        {
            Vector2 temp = transform.position;
            temp.x = ScreenCalculator.Instance.Width - (GetComponent<Collider2D>().bounds.size.x/2);
            transform.position = temp;
        }
    }
}
