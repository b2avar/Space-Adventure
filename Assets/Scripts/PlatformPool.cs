using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlatformPool : MonoBehaviour
{
    [SerializeField] private GameObject platformPrefab;
    [SerializeField] private GameObject deadlyPlatformPrefab;
    [SerializeField] private GameObject playerPrefab;
    
    private List<GameObject> platforms = new List<GameObject>();

    private Vector2 _platformPosition;
    private Vector2 _playerPosition;

    [SerializeField] private float distanceBetweenPlatforms;
    
    private void Start()
    {
        GeneratePlatform();
    }

    private void Update()
    {
        if (platforms[^1].transform.position.y < Camera.main.transform.position.y + ScreenCalculator.Instance.Height)
        {
            PlacePlatform();
        }
    }

    private void GeneratePlatform()
    {
        _platformPosition = new Vector2(0, 0);
        _playerPosition = new Vector2(0.0f, 0.5f);

        var player = Instantiate(playerPrefab, _playerPosition, Quaternion.identity);
        var ilkPlatform = Instantiate(platformPrefab, _platformPosition, Quaternion.identity);
        platforms.Add(ilkPlatform);
        NextPlatformPosition();
        ilkPlatform.GetComponent<Platform>().IsMovement = true;
        
        for (var i = 0; i < 8; i++)
        {
            var platform = Instantiate(platformPrefab, _platformPosition, Quaternion.identity);
            platforms.Add(platform);
            platform.GetComponent<Platform>().IsMovement = true;
            NextPlatformPosition();
        }

        var deadlyPlatform = Instantiate(deadlyPlatformPrefab, _platformPosition, Quaternion.identity);
        deadlyPlatform.GetComponent<DeadlyPlatform>().IsMovement = true;
        platforms.Add(deadlyPlatform);
        NextPlatformPosition();
    }

    private void PlacePlatform()
    {
        for (var i = 0; i < 5; i++)
        {
            (platforms[i + 5], platforms[i]) = (platforms[i], platforms[i + 5]);
            platforms[i + 5].transform.position = _platformPosition;
            NextPlatformPosition();
        }
    }

    private void NextPlatformPosition()
    {
        _platformPosition.y += distanceBetweenPlatforms;
        var random = Random.Range(0.0f, 1.0f);

        if (random < 0.5f)
        {
            _platformPosition.x = ScreenCalculator.Instance.Width / 2;
        }
        else
        {
            _platformPosition.x = -ScreenCalculator.Instance.Width / 2;

        }
    }
}
