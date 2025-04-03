using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
    private ObjectPool _obstaclePool;
    private void Start()
    {
        _obstaclePool = FindObjectOfType<ObjectPool>();
        StartCoroutine(DelayedDestroy());
    }

    private IEnumerator DelayedDestroy()
    {
        yield return new WaitForSeconds(6f);
        _obstaclePool.ReturnObject(gameObject);
        Debug.Log("Destroyed");
    }
}
