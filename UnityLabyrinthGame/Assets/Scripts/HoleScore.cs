using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HoleScore : MonoBehaviour
{
    public bool isVictoryHole = false;

    public int holeScore;
    private GameManager gameManager;
    private PointScoring pointScoring;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        pointScoring = FindObjectOfType<PointScoring>();
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && isVictoryHole == true) 
        {
            gameManager.WinState();
        }
        else if(other.gameObject.tag == "Player" && isVictoryHole == false) 
        {
            pointScoring.score += holeScore;
            gameManager.LoseState();

        }
    }
}
