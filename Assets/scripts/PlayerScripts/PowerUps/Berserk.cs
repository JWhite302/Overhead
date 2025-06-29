using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/Berserk")]
public class Berserk : PowerUpEffect
{
    public override void Apply(GameObject Player)
    {
        Player.GetComponent<DamangeOnCollision>().damage += 3;
        Player.GetComponent<Health>().TakeDamage(0);
    }
}
