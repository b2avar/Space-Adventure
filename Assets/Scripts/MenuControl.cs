using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    [SerializeField] private Sprite[] musicIcons;
    [SerializeField] private Button musicButton;
    private bool isMusicOn;
    
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
        if (isMusicOn)
        {
            isMusicOn = false;
            musicButton.image.sprite = musicIcons[0];
        }
        
        else
        {
            isMusicOn = true;
            musicButton.image.sprite = musicIcons[1];
        }

    }
}
