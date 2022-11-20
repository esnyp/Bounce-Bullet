using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //speed of player
    public float speed = 10; 

    //bounds of player
    public float topBound = 4.5f;
    public float bottomBound = -4.5f;

    public AudioSource audioPlayer;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        else if (Input.GetKeyDown(KeyCode.P) && Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }

    }

    private void FixedUpdate()
    {
        float movementSpeedY = speed * Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(0, movementSpeedY, 0);

        // set bounds of the player

        if(transform.position.y > topBound)
        {
            transform.position = new Vector3(transform.position.x, topBound, 0);
        }

        else if (transform.position.y < bottomBound)
        {
            transform.position = new Vector3(transform.position.x, bottomBound, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Ball")
        {
            audioPlayer.Play();
        }
    }
}
