using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : MonoBehaviour
{
    [SerializeField] private GameObject token;
    
    public void TokenOpen()
    {
        token.SetActive(true);
    }
    
    public void TokenClose()
    {
        token.SetActive(false);
    }
}
