using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _recordText;
    private bool _isGameOver;
    private int _record;
    private GameOverUIMover _gameOverUIMover;
    public GameObject GameOverUI;
    private Spawner _spawner;
    private ObstacleDestroyer _obstacleDestroyer;
    

    private void Awake()
    {
        _gameOverUIMover = FindObjectOfType<GameOverUIMover>(true);
        _spawner = FindObjectOfType<Spawner>(true);
        _obstacleDestroyer = FindObjectOfType<ObstacleDestroyer>(true);
    }
    // Update is called once per frame
    void Update()
    {
        if (_isGameOver && Input.touchCount > 0 || Input.GetKeyDown(KeyCode.Space) && _isGameOver)
        {
            RestartGame();
        }
    }

    public void GameOver()
    {
        GamePause.PauseGame();
        _spawner.StopSpawning();
        _isGameOver = true;
        _record = PlayerPrefs.GetInt("Score");
        _recordText.text = _record.ToString();
        GameOverUI.SetActive(true);
        _gameOverUIMover.Move();
    }

    private async void RestartGame()
    {
        _gameOverUIMover.Removing();
        await Task.Delay(1500);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}