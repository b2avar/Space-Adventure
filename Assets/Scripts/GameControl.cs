using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    [SerializeField] private GameObject[] uiObjects;
    [SerializeField] private GameObject gameOverPanel;


    private void Start()
    {
        gameOverPanel.SetActive(false);
        UIObjectOpen();
    }

    public void GameOver()
    {
        FindObjectOfType<SoundControl>().GameOverSound();
        gameOverPanel.SetActive(true);
        FindObjectOfType<Score>().GameOver();
        FindObjectOfType<PlayerMovement>().GameOver();
        FindObjectOfType<CameraMovement>().GameOver();
        UIObjectClose();
    }
    
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
    
    void UIObjectOpen()
    {
        foreach (var uiObj in uiObjects)
        {
            uiObj.SetActive(true);
        }
    }
    
    void UIObjectClose()
    {
        foreach (var uiObj in uiObjects)
        {
            uiObj.SetActive(false);
        }
    }
}
