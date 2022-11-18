using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth = 3;
    

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    void takeDamage(int amount)
    {
        currentHealth -= amount;

        if(currentHealth <= 0)
        {
            
        }
    }
}
