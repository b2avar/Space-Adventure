using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    [SerializeField] private Sprite[] musicIcons;
    [SerializeField] private Button musicButton;

    private void Start()
    {
        if (Options.SettingsHasKey() == false)
        {
            Options.SetEasyValue(1);
        }
        
        if (Options.MusicHaskey() == false)
        {
            Options.SetMusicOpenValue(1);
        }

        
        CheckMusicSettings();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
    
    public void HighScore()
    {
        SceneManager.LoadScene("HighScore");
    }
    
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    
    public void Music()
    {
        if (Options.GetMusicOpenValue() == 1)
        {
            Options.SetMusicOpenValue(0);
            musicButton.image.sprite = musicIcons[0];
        }
        
        else
        {
            Options.SetMusicOpenValue(1);
            musicButton.image.sprite = musicIcons[1];
        }

    }
    
    void CheckMusicSettings()
    {
        if (Options.GetMusicOpenValue() == 1)
        {
            musicButton.image.sprite = musicIcons[1];
        }

        else
        {
            musicButton.image.sprite = musicIcons[0];
        }
    }
}
