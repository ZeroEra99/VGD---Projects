using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    // Player stats with initial value
    public Transform LastCheckpoint;

    public static int maxLives = 3;
    public static int maxHealth = 100;
    public static int maxMana = 100;
    public static int maxStamina = 100;

    public static int currentLives;
    public static int currentHealth;
    public static int currentMana;
    public static int currentStamina;

    public static string startValues = "Test";

    // Start is called before the first frame update
    void Start()
    {
        currentLives = maxLives;
        currentHealth = maxHealth;
        currentMana = maxMana;
        currentStamina = maxStamina;
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
