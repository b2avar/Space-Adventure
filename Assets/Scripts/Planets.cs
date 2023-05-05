using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

public class Planets : MonoBehaviour
{
    private List<GameObject> planets = new List<GameObject>();
    private List<GameObject> planetUsed = new List<GameObject>();

    private void Awake()
    {
        Object[] sprites = Resources.LoadAll("Gezegenler/Gezegenler");

        for (int i = 1; i < sprites.Length; i++)
        {
            GameObject planet = new GameObject();
            SpriteRenderer spriteRenderer = planet.AddComponent<SpriteRenderer>();
            spriteRenderer.sprite = (Sprite)sprites[i];
            Color spriteColor = spriteRenderer.color;
            spriteColor.a = 0.5f;
            spriteRenderer.color = spriteColor;
            planet.name = sprites[i].name;
            spriteRenderer.sortingLayerName = "Planets";
            Vector2 pos = planet.transform.position;
            pos.x = -10;
            planet.transform.position = pos;
            planets.Add(planet);
        }
    }

    public void GeneratePlanet(float refY)
    {
        float height = ScreenCalculator.Instance.Height;
        float width = ScreenCalculator.Instance.Width;

        // Zone 1
        float xValue1 = Random.Range(0.0f, width);
        float yValue1 = Random.Range(refY, refY + height);
        GameObject planet = RandomPlanet();
        planet.transform.position = new Vector2(xValue1, yValue1);
        
        // Zone 2
        float xValue2 = Random.Range(-width, 0.0f);
        float yValue2 = Random.Range(refY, refY + height);
        GameObject planet2 = RandomPlanet();
        planet2.transform.position = new Vector2(xValue2, yValue2);
        
        // Zone 3
        float xValue3 = Random.Range(-width, 0.0f);
        float yValue3 = Random.Range(refY-height, refY);
        GameObject planet3 = RandomPlanet();
        planet3.transform.position = new Vector2(xValue3, yValue3);
        
        // Zone 4
        float xValue4 = Random.Range(0.0f, width);
        float yValue4 = Random.Range(refY-height, refY);
        GameObject planet4 = RandomPlanet();
        planet4.transform.position = new Vector2(xValue4, yValue4);
    }

    GameObject RandomPlanet()
    {
        if (planets.Count > 0)
        {
            int random;
            if (planets.Count == 1)
            {
                random = 0;
            }
            else
            {
                random = Random.Range(0, planets.Count - 1);
            }

            GameObject planet = planets[random];
            planets.Remove(planet);
            planetUsed.Add(planet);
            return planet;
        }
        else
        {
            for (int i = 0; i < 8; i++)
            {
                planets.Add(planetUsed[i]);
            }
            planetUsed.RemoveRange(0,8);
            int random = Random.Range(0, 8);
            GameObject planet = planets[random];
            planets.Remove(planet);
            planetUsed.Add(planet);
            return planet;
        }
    }
}
