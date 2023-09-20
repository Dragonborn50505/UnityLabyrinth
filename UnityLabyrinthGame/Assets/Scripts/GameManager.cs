using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private PointScoring _pointScoring;

    private int _currentLives = 3;

    [SerializeField] private Transform _ball;

    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private TextMeshProUGUI _endScreen;
    [SerializeField] private GameObject _endGameScreen;

    [SerializeField] private string _winConditionText = "You Win!";
    [SerializeField] private string _loseConditionText = "You Lose!";

    private void Awake()
    {
        _pointScoring = GetComponent<PointScoring>();
    }

    void Start()
    {
        _endGameScreen.SetActive(false);
    }

    void Update()
    {
        LoseState();
        WinState();
    }

    private void LoseState()
    {
        if (_currentLives <= 0)
        {
            _endScreen.text = _loseConditionText;
            _endGameScreen.SetActive(true);
        }
    }

    private void WinState()
    {
        //TODO: Add a bool to see if the player has won the game;
        _endScreen.text = _winConditionText;
        _endGameScreen.SetActive(true);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("SampleScene");
        //TODO: Jovan - Scene Loading could go smoother/better - need time to figure out which way I can do it. 
    }
}
