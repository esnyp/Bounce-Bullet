using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    // speed of the ball
    public float speed = 5f;

    // Initial direction of the ball
    private Vector2 spawnDir;

    // ball's components
    Rigidbody2D rig2D;
    // Use this for initialization

    private void Start()
    {

        //setting balls Rigidbody 2D
        rig2D = this.gameObject.GetComponent<Rigidbody2D>();

        //generating random number based on possible initial directions
        int rand = 
            Random.Range(1, 3);
        Debug.Log(rand);

        //setting initial direction
        if(rand == 1)
        {
            spawnDir = new Vector2(1, 1);
        }
        else 
        {
            spawnDir = new Vector2(1, -1);
        }

        //moving ball in initial direction and adding speed
        rig2D.velocity = (spawnDir * speed);
    }

}
