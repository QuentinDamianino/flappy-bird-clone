using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfScreenScript : MonoBehaviour
{
    public LogicScript logic;
    public BirdScript bird;
    private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.gameObject.layer == 3)
        {
            bird.birdIsAlive = false;
            logic.gameOver();
        }
    }
}
