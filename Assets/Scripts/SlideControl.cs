using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideControl : MonoBehaviour
{
    private Slider _slider;

    // Start is called before the first frame update
    void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.value = 1.0f;
    }
    
    public void Slider(int maxValue, int currentValue)
    {
        int sliderValue = maxValue - currentValue;
        _slider.maxValue = maxValue;
        _slider.value = sliderValue;

    }
}
