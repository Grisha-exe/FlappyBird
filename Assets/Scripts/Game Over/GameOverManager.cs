 using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _recordText;
    public GameObject GameOverUI;
    private bool _isGameOver;
    private int _record;

    // Update is called once per frame
    void Update()
    {
        if (_isGameOver && Input.GetKeyDown(KeyCode.Space))
        {
            RestartGame();
        }
    }

    public void GameOver()
    {
        _isGameOver = true;
        _record = PlayerPrefs.GetInt("Score");
        _recordText.text = _record.ToString();
        GameOverUI.SetActive(true);
        Debug.Log("Game Over. Press Space to continue.");
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        Time.timeScale = 1.0f;
    }
}