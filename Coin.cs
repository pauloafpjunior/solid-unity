using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : CanCollideWithPlayer
{
    void OnTriggerEnter2D(Collider2D other)
    {
        OnCollision(other.gameObject);
    }

    override public void HandleCollision(Player player)
    {
        player.AddCoin();
    }
}
