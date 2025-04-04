using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    private int _score;

    public GameObject MainMenu;

    // Start is called before the first frame update
    void Start()
    {
        MainMenu.SetActive(true);
        Time.timeScale = 0f;
        _score = PlayerPrefs.GetInt("Score");
        _scoreText.text = _score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MainMenu.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}