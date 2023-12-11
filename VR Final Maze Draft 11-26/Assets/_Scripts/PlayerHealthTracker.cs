using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthTracker : MonoBehaviour
{
    public Slider slider;
    private int health = 3;

    public GameObject healthPanel;
    public GameObject healthPaneOff;
    public GameObject healthPaneOn;
    private float healthOnScreenTimer = 2f;
    private bool startTimer = false;

    // Start is called before the first frame update
    void Start()
    {
        AxeInjurer.OnAxeCollide += DisplayHealth;
        healthPanel.transform.position = healthPaneOff.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer)
        {
            healthOnScreenTimer -= Time.deltaTime;
        }

        if (healthOnScreenTimer <= 0)
        {
            startTimer = false;
            healthOnScreenTimer = 2f;
            healthPanel.transform.position = healthPaneOff.transform.position;
        }
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }

    void DisplayHealth()
    {
        healthPanel.transform.position = healthPaneOn.transform.position;
        startTimer=true;
    }
}
