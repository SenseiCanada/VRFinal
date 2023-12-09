using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class XRHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    public PlayerHealthTracker healthTracker;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthTracker.SetMaxHealth(maxHealth);
        AxeInjurer.OnAxeCollide += InjurePlayer;
    }

    // Update is called once per frame
    void Update()
    {
        PLayerDeath();
    }

    void PLayerDeath()
    {
        if(currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void InjurePlayer()
    {
        TakeDamage(1);
    }

    void TakeDamage(int damagae)
    {
        currentHealth -= damagae;
        healthTracker.SetHealth(currentHealth);
    }
}
