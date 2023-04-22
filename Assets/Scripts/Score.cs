using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text tokenText;
    
    [SerializeField] private Text gameOverScoreText;
    [SerializeField] private Text gameOverTokenText;

    private int score;
    private int token;

    private bool getScore = true;
    
    // Start is called before the first frame update
    void Start()
    {
        tokenText.text = " X " + token;
    }

    // Update is called once per frame
    void Update()
    {
        if (getScore)
        {
            score = (int)Camera.main.transform.position.y;
            scoreText.text = "Puan: " + score;
        }
    }
    
    public void GetToken()
    {
        token++;
        tokenText.text = " X " + token;
    }
    
    public void GameOver()
    {
        getScore = false;
        gameOverScoreText.text = "Puan: " + score;
        gameOverTokenText.text = " X " + token;


    }
}
