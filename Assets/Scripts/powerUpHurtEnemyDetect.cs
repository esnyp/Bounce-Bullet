using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpHurtEnemyDetect : MonoBehaviour
{
    HUDManager hudManager;
    [SerializeField] GameObject hpHUD;

    private void Awake()
    {
        hudManager = hpHUD.GetComponent<HUDManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hudManager.enemyTakeDamage();
    }
}
