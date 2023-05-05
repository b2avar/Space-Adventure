using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text tokenText;
    
    [SerializeField] private Text gameOverScoreText;
    [SerializeField] private Text gameOverTokenText;

    private int score;
    private int highScore;
    private int token;
    private int highToken;

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
        FindObjectOfType<SoundControl>().TokenSound();
        token++;
        tokenText.text = " X " + token;
    }
    
    public void GameOver()
    {
        if (Options.GetEasyValue() == 1)
        {
            highScore = Options.GetEasyScoreValue();
            highToken = Options.GetEasyTokenValue();
            if (score > highScore)
            {
                Options.SetEasyScoreValue(score);
            }

            if (token > highToken)
            {
                Options.SetEasyTokenValue(token);
            }
        }
        
        if (Options.GetMediumValue() == 1)
        {
            highScore = Options.GetMediumScoreValue();
            highToken = Options.GetMediumTokenValue();
            if (score > highScore)
            {
                Options.SetMediumScoreValue(score);
            }

            if (token > highToken)
            {
                Options.SetMediumTokenValue(token);
            }
        }
        
        if (Options.GetHardValue() == 1)
        {
            highScore = Options.GetHardScoreValue();
            highToken = Options.GetHardTokenValue();
            if (score > highScore)
            {
                Options.SetHardScoreValue(score);
            }

            if (token > highToken)
            {
                Options.SetHardTokenValue(token);
            }
        }
        
        
        getScore = false;
        gameOverScoreText.text = "Puan: " + score;
        gameOverTokenText.text = " X " + token;


    }
}
