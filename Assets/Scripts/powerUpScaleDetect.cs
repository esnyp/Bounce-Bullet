using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpScaleDetect : MonoBehaviour
{
    PlayerControl playerControl;
    [SerializeField] GameObject player;
  

    private void Awake()
    {
        playerControl = player.GetComponent<PlayerControl>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector3 newSize = new Vector3(player.transform.localScale.x* (float)1.4, 
            player.transform.localScale.y * (float)1.4,
            player.transform.localScale.z * (float)1.4);

        Vector3 a = player.transform.localScale;
        player.transform.localScale = newSize;
    }
}
