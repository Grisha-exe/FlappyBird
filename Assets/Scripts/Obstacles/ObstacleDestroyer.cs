using System.Collections;
using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
    private ObjectPool _obstaclePool;

    private void Start()
    {
        _obstaclePool = FindObjectOfType<ObjectPool>(true);
        StartCoroutine(DelayedDestroy());
    }

    private IEnumerator DelayedDestroy()
    {
        if (GamePause.IsGamePaused == false)
        {
            yield return new WaitForSeconds(6f);
            _obstaclePool.ReturnObject(gameObject);
        }
    }
}