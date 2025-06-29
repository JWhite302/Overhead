using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemyType", menuName = "Game/Enemy Type")]
public class EnemyTypeSo : ScriptableObject
{
    public GameObject Prefab;
    public float MoveSpeed;
    public float SpawnInterval;
    public float SpawnWeight;

    
}
