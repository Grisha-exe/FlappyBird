using UnityEngine;
using UnityEngine.Serialization;

public class AddScorePoints : MonoBehaviour
{
    [SerializeField] private AudioManager _audioManager;
    public ScoreManager ScoreManager;
    
    private void Awake()
    {
        ScoreManager = FindObjectOfType<ScoreManager>(true);
        _audioManager = FindObjectOfType<AudioManager>(true);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);
        if (other.GetComponent<PlayerMarker>() != null)
        {
            ScoreManager.AddScore();
            _audioManager.AddScoreClip();
        }
    }
}
