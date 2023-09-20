using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleScore : MonoBehaviour
{
    public bool isVictoryHole = false;

    public int holeScore;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && isVictoryHole == true) 
        {
            FindObjectOfType<GameManager>().WinState();

        }
        else if(other.gameObject.tag == "Player" && isVictoryHole == false) 
        {
            FindObjectOfType<PointScoring>().score += holeScore;
            FindObjectOfType<GameManager>().LoseState();

        }
    }
}
