using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickDestory : MonoBehaviour
{
    public int wallHP = 3;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
