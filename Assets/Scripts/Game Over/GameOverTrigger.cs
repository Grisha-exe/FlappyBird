using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerMovement>() != null)
        {
            Debug.Log("Game Over");
            FindObjectOfType<GameOverManager>(true).GameOver();

            Time.timeScale = 0;
        }
    }
}