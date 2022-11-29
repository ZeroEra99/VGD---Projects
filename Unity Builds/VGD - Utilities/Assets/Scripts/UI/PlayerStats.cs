using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    // Player stats with initial value
    public static Transform LastCheckpoint;

    public static int maxLives = 3;
    public static int maxHealth = 100;
    public static int maxMana = 100;
    public static int maxStamina = 100;
    public static Dictionary<KeyCode, int> maxPowerupCooldown =
        new Dictionary<KeyCode, int>() { // declare all Cooldowns here
            { KeyCode.E, 3 },
            { KeyCode.Q, 10 },
            { KeyCode.K, 15 },
        };

    public static int currentLives;
    public static int currentHealth;
    public static int currentMana;
    public static int currentStamina;
    public static Dictionary<KeyCode, int> currentPowerupCooldown =
        new Dictionary<KeyCode, int>();

    public static string startParams = maxLives + " mL\n" + maxHealth + " mH\n" + maxMana + " mM\n" + maxStamina + " mS";

    // Start is called before the first frame update
    void Start()
    {
        currentLives = maxLives;
        currentHealth = maxHealth;
        currentMana = maxMana;
        currentStamina = maxStamina;
        foreach (KeyValuePair<KeyCode, int> powerupCooldown in PlayerStats.maxPowerupCooldown) // initializes all cooldowns as 0
        {
            currentPowerupCooldown[powerupCooldown.Key] = 0;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void useMana(int mana)
    {
        currentMana -= mana;
    }
    public void takeDamage(int damage)
    {
        currentHealth -= damage;
    }

}
