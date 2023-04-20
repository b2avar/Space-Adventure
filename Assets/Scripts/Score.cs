using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text tokenText;

    private int score;
    private int token;
    
    // Start is called before the first frame update
    void Start()
    {
        tokenText.text = " X " + token;
    }

    // Update is called once per frame
    void Update()
    {
        score = (int)Camera.main.transform.position.y;
        scoreText.text = "Puan: " + score;
    }
    
    public void GetToken()
    {
        token++;
        tokenText.text = " X " + token;
    }
}
