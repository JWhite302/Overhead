using UnityEngine;

[CreateAssetMenu(menuName= "Powerups/HealthBuff" )]
public class HealthBuff : PowerUpEffect
{
    public float amount;
    public override void Apply(GameObject Player)
    {
        Player.GetComponent<Health>().currentHealth += amount;
        Debug.Log("Player gained health");
    }
}
