using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScorePoints : MonoBehaviour
{
    ScoreManager scoreManager;
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);
        if (other.GetComponent<PlayerMarker>() != null)
        {
            scoreManager.AddScore();
        }
    }
}
