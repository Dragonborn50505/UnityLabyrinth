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
    [SerializeField] private Transform _maze;
    [SerializeField] Vector3 _ballOriginalPos;
    [SerializeField] Vector3 _mazeOriginalRotation;

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
       /* LoseState();
        WinState();*/
       if (Input.GetKeyDown(KeyCode.R))
       {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       }
    }

    public void LoseState()
    {
        _endScreen.text = _loseConditionText;
        _scoreText.text = FindObjectOfType<PointScoring>().score.ToString();
        _endGameScreen?.SetActive(true);
    }

    public void WinState()
    {
        //TODO: Add a bool to see if the player has won the game;
        _endScreen.text = _winConditionText;
        _scoreText.text = FindObjectOfType<PointScoring>().score.ToString();
        _endGameScreen?.SetActive(true);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("SampleScene");
        //TODO: Jovan - Scene Loading could go smoother/better - need time to figure out which way I can do it. 
    }

    public void ResetPosition() 
    {
        _maze.rotation = Quaternion.Euler(_mazeOriginalRotation);
        _ball.position = _ballOriginalPos;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
