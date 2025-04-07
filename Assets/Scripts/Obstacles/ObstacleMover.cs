using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    public float speed;

    void Update()
    {
        if (GamePause.IsGamePaused == false)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }
}
