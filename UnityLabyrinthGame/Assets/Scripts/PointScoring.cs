using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScoring : MonoBehaviour
{
    public int score, health;
    HoleScore enemyHole;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hole")
        {
            //Increases score based on enemy's hole score
            enemyHole = other.gameObject.GetComponent<HoleScore>();
            score += enemyHole.holeScore;
            health--;

            //Reset position in some way
        }
    }
}
