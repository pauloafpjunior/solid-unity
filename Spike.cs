using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : CanCollideWithPlayer
{
    private int damage = 10;

    void OnTriggerEnter2D(Collider2D other)
    {
        OnCollision(other.gameObject);
    }

    override public void HandleCollision(Player player)
    {
        player.TakeDamage(damage);
    }
}
