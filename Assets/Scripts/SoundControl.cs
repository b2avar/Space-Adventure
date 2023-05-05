using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    [SerializeField] private AudioClip jump;
    [SerializeField] private AudioClip token;
    [SerializeField] private AudioClip gameOver;

    private AudioSource _audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void JumpSound()
    {
        _audioSource.clip = jump;
        _audioSource.Play();
    }
    
    public void TokenSound()
    {
        _audioSource.clip = token;
        _audioSource.Play();
    }
    
    public void GameOverSound()
    {
        _audioSource.clip = gameOver;
        _audioSource.Play();
    }
}
