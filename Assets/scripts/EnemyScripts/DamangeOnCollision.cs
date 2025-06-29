using UnityEngine;

public class DamangeOnCollision : MonoBehaviour
{
    public string targetTag;
    public float damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
