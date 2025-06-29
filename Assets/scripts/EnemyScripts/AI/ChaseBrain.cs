using UnityEngine;

[CreateAssetMenu(menuName = "Brains/Chase")]
public class ChaseBrain : Brain
{
    public string targetTag;
    public override void Think(Thinker thinker)
    {
        GameObject target = GameObject.FindGameObjectWithTag(targetTag);
        if (target)
        {
            var movement = thinker.gameObject.GetComponent<MovementChase>();
            if (movement)
            {
                movement.ChaseTarget(target.transform.position);
            }
        }
    }
}
