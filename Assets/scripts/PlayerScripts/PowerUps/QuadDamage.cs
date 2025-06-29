using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(menuName = "Powerups/QuadDamage")]
public class QuadDamage : PowerUpEffect
{
    public float amount;
    public override void Apply(GameObject Projectile)
    {
        Projectile.GetComponent<Projectile>().projectileDamage = amount;
        Debug.Log("Player Damage Increased");
    }
}
