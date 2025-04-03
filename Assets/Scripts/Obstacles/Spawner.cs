using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public ObjectPool ObstaclePool;
    public float minSpawnTime = 0.5f; // Минимальный интервал спавна
    public float maxSpawnTime = 2f; // Максимальный интервал спавна
    private readonly float _maxSpawnPositionY = -2.2f;
    private readonly float _minSpawnPositionY = -5.6f;

    void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }

    IEnumerator SpawnCoroutine()
    {
        while (true) // Бесконечный цикл
        {
            float waitTime = Random.Range(minSpawnTime, maxSpawnTime); // Рандомное время ожидания
            yield return new WaitForSeconds(waitTime);
            
            GameObject obstacle = ObstaclePool.GetObject();
            obstacle.transform.position = new Vector2(12, Random.Range(_minSpawnPositionY, _maxSpawnPositionY));
        }
    }
}