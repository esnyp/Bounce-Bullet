using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpSpawner : MonoBehaviour
{
    public GameObject healthUpPower;
    public GameObject hurtEnemyPower;
    public GameObject objectToSpawn;
    // Start is called before the first frame update
   public void Start()
    {
        StartCoroutine(spawnPowerUp());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnPowerUp()
    {

        int ranInt = Random.Range(2, 5);
        int ranInt2 = Random.Range(1, 3);
        Debug.Log(ranInt2);
        if(ranInt2 == 2)
        {
            objectToSpawn = healthUpPower; 
        }
        else
        {
            objectToSpawn = hurtEnemyPower;
        }

     yield return new WaitForSeconds(ranInt);
        Instantiate(objectToSpawn, transform.position, objectToSpawn.transform.rotation);
        yield return null;
    }
}
