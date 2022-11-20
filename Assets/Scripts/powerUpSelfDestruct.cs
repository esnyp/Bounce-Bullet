using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpSelfDestruct : MonoBehaviour
{
    public GameObject spawner;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);      
    }
}
