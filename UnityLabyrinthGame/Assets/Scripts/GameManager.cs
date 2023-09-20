using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int CurrentScore { get; private set; }
    private int _currentLives = 3;

    [SerializeField] private Transform _ball;

    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private GameObject _endGameScreen;

    void Start()
    {
            
    }

    void Update()
    {
        
    }

    private void LoseState() 
    {
        if(_currentLives <= 0) 
        {

        }
    }

    private void LoseLife() 
    {

    }

    public void RestartLevel() 
    {
        SceneManager.LoadScene("SampleScene"); 
        //TODO: Jovan - Scene Loading could go smoother/better - need time to figure out which way I can do it. 
    }
}
