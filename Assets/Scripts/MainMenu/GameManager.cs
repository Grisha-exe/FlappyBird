using System;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    private int _score;
    private MainMenuUIMover _menuMover;
    private Spawner _spawner;
    public bool IsGameStarted;
    public GameObject MainMenu;

    private void Awake()
    {
        IsGameStarted = false;
        GamePause.PauseGame();
        _spawner = FindObjectOfType<Spawner>(true);
        _menuMover = FindObjectOfType<MainMenuUIMover>(true);
    }
    
    void Start()
    {
        MainMenu.SetActive(true);
        _menuMover.Move();
        _score = PlayerPrefs.GetInt("Score");
        _scoreText.text = _score.ToString();
    }
    
    void Update()
    {
        if (Input.touchCount > 0 && IsGameStarted == false || Input.GetKeyDown(KeyCode.Space) && IsGameStarted == false)
        {
            _menuMover.Removing();
            GamePause.ResumeGame();
            MainMenu.SetActive(false);
            IsGameStarted = true;
            _spawner.StartSpawning();
        }
    }
}