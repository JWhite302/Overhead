using UnityEngine;

public class MovementChase : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public void ChaseTarget(Vector2 targetPosition)
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
}
