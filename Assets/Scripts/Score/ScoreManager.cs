using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    private int _score;
    public int Record;
    
    private void Start()
    {
        _scoreText.text = "0";
        Record = PlayerPrefs.GetInt("Score");
    }

    public void AddScore()
    {
        _score++;
        UpdateScoreDisplay(_score);
    }
    
    public void UpdateScoreDisplay(int newScore)
    {
        _scoreText.text = newScore.ToString();

        if (_score > Record)
        {
            Record = _score;
            PlayerPrefs.SetInt("Score", Record);
        }
    }
}
