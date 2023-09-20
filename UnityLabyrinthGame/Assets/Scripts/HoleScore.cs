using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
