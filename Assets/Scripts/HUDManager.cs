using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{

    public Text healthText;
    public Text enemyHealthText;
    public Canvas endScreen;

    public int currentHealth = 3;
    public int maxHealth = 3;

    public int enemyCurrentHealth = 5;
    public int enemyMaxHealth = 5;

    public string playerHealthPrefix = "Player Health:  ";
    public string enemyHealthPrefix = "Enemy Health:  ";

    

    // Start is called before the first frame update
    void Start()
    {
        
        maxHealth = currentHealth;
        enemyMaxHealth = enemyCurrentHealth;

        healthText.text = playerHealthPrefix + maxHealth.ToString();
        enemyHealthText.text = enemyHealthPrefix + enemyMaxHealth.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = playerHealthPrefix + currentHealth.ToString();
        enemyHealthText.text = enemyHealthPrefix + enemyCurrentHealth.ToString();

        if (currentHealth <= 0)
        {
          playerDeath();
        }
    }

   public void takeDamage()
    {
        currentHealth = currentHealth - 1;
        
    }

    public void enemyTakeDamage()
    {
        enemyCurrentHealth = enemyCurrentHealth - 1;

    }

    public void takeHeal(int dmg)
    {
        if (currentHealth >= 5)
        {
            currentHealth = 5;
            Debug.Log("health is up");
        }
        else
        {
            currentHealth++;
        }
        

    }

    public void playerDeath()
    {
        endScreen.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
