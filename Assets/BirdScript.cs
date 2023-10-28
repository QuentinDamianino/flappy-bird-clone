using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D MyRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public AudioSource flap;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            MyRigidbody.velocity = Vector2.up * flapStrength;
            flap.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collison)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
