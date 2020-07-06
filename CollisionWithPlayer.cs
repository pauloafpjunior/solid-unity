using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public abstract class CollisionWithPlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Player player = other.GetComponent<Player>();

        if (player != null)
        {
            HandleCollisionWithPlayer(player);
        }
    }

    public abstract void HandleCollisionWithPlayer(Player player);
}
