using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    
    [SerializeField]
    private GameObject _enemyPrefab;
    /*[SerializeField]
    private float _minSpawnTime;
    [SerializeField]
    private float _maxSpawnTime;
    private float _timeUntilSpawn;*/

    public List<EnemyTypeSo> EnemyTypes;
    public AnimationCurve DifficultyCurve;

    private List<float> _timers;
    private float _elapsedTime;

    void Awake()
    {
        //SetTimeUntilSpawn();
        _timers = new List<float>(new float[EnemyTypes.Count]);
    }
    void Update()
    {
        /*_timeUntilSpawn -= Time.deltaTime;
        if (_timeUntilSpawn <= 0)
        {
            Instantiate(_enemyPrefab, transform.position, transform.rotation);
            SetTimeUntilSpawn();
        }*/
        _elapsedTime += Time.deltaTime;
        var difficultyMultiplier = Mathf.Clamp(DifficultyCurve.Evaluate(_elapsedTime), 0.1f, 5f);

        for (var i = 0; i < EnemyTypes.Count; i++)
        {
            _timers[i] += Time.deltaTime;
            var scaledInterval = EnemyTypes[i].SpawnInterval / difficultyMultiplier;

            if (!(_timers[i] >= scaledInterval)) continue;

            _timers[i] = 0f;
            SpawnEnemy(EnemyTypes[i]);
        }
    }
    private void SpawnEnemy(EnemyTypeSo enemyType)
    {
        var enemy = Instantiate(enemyType.Prefab, transform.position, transform.rotation);
        var foundAi = enemy.GetComponent<MovementChase>();
        if (foundAi)
        {
            foundAi.speed = enemyType.MoveSpeed;
        }

    }
    
    /*private void SetTimeUntilSpawn()
    {
        _timeUntilSpawn = Random.Range(-_minSpawnTime, _maxSpawnTime);
    }*/
}
