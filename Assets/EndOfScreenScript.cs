using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfScreenScript : MonoBehaviour
{
    public LogicScript logic;
    private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.gameObject.layer == 3)
        {
            logic.gameOver();
        }
    }
}
