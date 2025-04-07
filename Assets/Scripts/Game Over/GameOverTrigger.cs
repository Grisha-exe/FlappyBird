using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    private AudioManager _audioManager;
    private GameOverManager _gameOverManager;

    private void Awake()
    {
        _audioManager = FindObjectOfType<AudioManager>(true);
        _gameOverManager = FindObjectOfType<GameOverManager>(true);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerMovement>() != null)
        {
            _gameOverManager.GameOver();
            _audioManager.DieClip();
        }
    }
}