using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed;
    public float projectileDamage;
    public string targetTag;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //projectileDamage = Player.GetComponent<PlayerDamage>;
        rb.linearVelocity = transform.right * projectileSpeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            collision.gameObject.GetComponent<Health>().TakeDamage(projectileDamage);
            Destroy(gameObject);
        }
    }
}
