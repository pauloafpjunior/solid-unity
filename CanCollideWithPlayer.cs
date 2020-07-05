using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CanCollideWithPlayer : MonoBehaviour
{
    public virtual void OnCollision(GameObject gObject)
    {
        Player player =  gObject?.GetComponent<Player>();

        if (player != null) {
            HandleCollision(player);
        }
    }

    public abstract void HandleCollision(Player player);
}
