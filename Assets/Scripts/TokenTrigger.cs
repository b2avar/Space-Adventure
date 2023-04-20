using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "PlayerFeet")
        {
            GetComponentInParent<Token>().TokenClose();
            FindObjectOfType<Score>().GetToken();
        }
    }
}
