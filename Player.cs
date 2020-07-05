using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int amountOfCoins = 0;
    private int healthy = 100;

    public void AddCoin()
    {
        amountOfCoins += 1;
    }

    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            healthy -= damage;
        }

        if (healthy <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Game Over
    }
}
