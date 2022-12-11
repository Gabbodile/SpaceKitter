using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject player;
    public GameObject gameOverScreen;

    public int health = 5;
    public int maxHealth = 5;
 
    void Start()
    {
        health = maxHealth;
        gameOverScreen.SetActive(false);
    }

    public void Damage(int damageMultiplier)
    {
        health -= damageMultiplier;
        if (health <= 0)
        {
            gameOverScreen.SetActive(true);
        }
    }
}
