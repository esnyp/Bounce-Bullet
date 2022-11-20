using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //Speed of the enemy
    
    //the ball
    Transform ball;

    //the ball's rigidbody 2D
    Rigidbody2D ballRig2D;

    //bound of enemy

    public float topBound = 4.5f;
    public float bottomBound = -4.5f;

    public AudioSource audioPlayer2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float speed = 2.75f;

        //finding the ball
        if (ball == null)
        {
            ball = GameObject.FindGameObjectWithTag("Ball").transform;
        }

        //setting the ball's rigidbodby to a variable
        ballRig2D = ball.GetComponent<Rigidbody2D>();

        //checking x direction of the ball
        if (ballRig2D.velocity.x < 0)
        {
            //checking y direction of ball
            if (ball.position.y < this.transform.position.y)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);             
            }
            else if (ball.position.y > this.transform.position.y)
            {
                //move ball up if higher than paddle
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
        }

        // set bounds of enemy
        if (transform.position.y > topBound)
        {
            transform.position = new Vector3(transform.position.x, topBound, 0);
        }

        else if ( transform.position.y < bottomBound)
        {
            transform.position = new Vector3(transform.position.x, bottomBound, 0);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            audioPlayer2.Play();
        }
    }


}
