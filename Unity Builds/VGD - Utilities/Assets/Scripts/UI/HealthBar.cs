using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;


    private void Start()
    {

    }

    private void Update()
    {
        updateShownMaxHealthDisplayed();
        updateCurrentHealthDisplayed();
    }

    public void updateShownMaxHealthDisplayed()
    {
        slider.maxValue = PlayerStats.maxHealth;
        fill.color = gradient.Evaluate(1f);
    }

    public void updateCurrentHealthDisplayed()
    {
        slider.value = PlayerStats.currentHealth;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
