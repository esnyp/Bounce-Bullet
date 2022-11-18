using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBackBound : MonoBehaviour
{
    HUDManager hudManager;
    [SerializeField] GameObject hpHUD;

    private void Awake()
    {
        hudManager = hpHUD.GetComponent<HUDManager>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Destroy(other.gameObject);
            hudManager.enemyTakeDamage();
        }
    }
}
