public class CoinCollisionWithPlayer : CollisionWithPlayer
{
    public override void HandleCollisionWithPlayer(Player player)
    {
        player?.AddCoin();
    }
}
