public class SpikeCollisionWithPlayer : CollisionWithPlayer
{
    private const int DAMAGE = 10;

    public override void HandleCollisionWithPlayer(Player player)
    {
        player?.TakeDamage(DAMAGE);
    }
}
