using UnityEngine;

public class temp : MonoBehaviour
{
    //Player stats
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
        healthBar.setHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            takeDamage(20);
        }
    }

    void takeDamage(int damage)
    {
        currentHealth-=damage;
        healthBar.setHealth(currentHealth);
    }
}