using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlatformPool : MonoBehaviour
{
    [SerializeField] private GameObject platformPrefab;
    
    private List<GameObject> platforms = new List<GameObject>();

    private Vector2 _platformPosition;

    [SerializeField] private float distanceBetweenPlatforms;

    // Start is called before the first frame update
    void Start()
    {
        GeneratePlatform();
    }

    private void Update()
    {
        if (platforms[platforms.Count - 1].transform.position.y < Camera.main.transform.position.y + ScreenCalculator.Instance.Height)
        {
            Debug.Log("Platform yerlestir.");
        }
    }

    void GeneratePlatform()
    {
        _platformPosition = new Vector2(0, 0);
        for (int i = 0; i < 10; i++)
        {
            GameObject platform = Instantiate(platformPrefab, _platformPosition, Quaternion.identity);
            platforms.Add(platform);
            platform.GetComponent<Platform>().IsMovement = true;
            NextPlatformPosition();
        }
    }

    private void NextPlatformPosition()
    {
        _platformPosition.y += distanceBetweenPlatforms;
        float random = Random.Range(0.0f, 1.0f);

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
