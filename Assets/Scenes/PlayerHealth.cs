using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int maxHealth = 100;
    int currentHealth = 100;

    void Update()
    {
        // Take damage
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }

        // Restore health
        if (Input.GetKeyDown(KeyCode.H))
        {
            Heal(20);
        }
    }

    void TakeDamage(int damage)
    {
        if (currentHealth <= 0)
            return;

        currentHealth -= damage;

        if (currentHealth < 0)
            currentHealth = 0;

        Debug.Log("Health: " + currentHealth);

        if (currentHealth == 0)
        {
            Debug.Log("GAME OVER!");
        }
    }

    void Heal(int amount)
    {
        currentHealth += amount;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        Debug.Log("Health: " + currentHealth);
    }
}