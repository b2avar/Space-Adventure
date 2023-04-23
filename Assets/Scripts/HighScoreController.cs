using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScoreController : MonoBehaviour
{
    [SerializeField]
    private Text easyScoreText, easyTokenText, mediumScoreText, mediumTokenText, hardScoreText, hardTokenText;


    private void Start()
    {
        easyScoreText.text = "Puan: " + Options.GetEasyScoreValue();
        easyTokenText.text = " X " + Options.GetEasyTokenValue();
        
        mediumScoreText.text = "Puan: " + Options.GetMediumScoreValue();
        mediumTokenText.text = " X " + Options.GetMediumTokenValue();
        
        hardScoreText.text = "Puan: " + Options.GetHardScoreValue();
        hardTokenText.text = " X " + Options.GetHardTokenValue();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
