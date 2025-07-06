using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(menuName = "Powerups/QuadDamage")]
public class QuadDamage : PowerUpEffect
{
    private float amount = 4;
    public Projectile projectile;
    public override void Apply(GameObject Player)
    {
        projectile.projectileDamage = amount;
        Debug.Log("Player Damage Increased");
    }
}
