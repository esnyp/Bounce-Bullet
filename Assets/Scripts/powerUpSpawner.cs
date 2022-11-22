using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpSpawner : MonoBehaviour
{
    public GameObject healthUpPower;
    public GameObject hurtEnemyPower;
    public GameObject scalePower;

    public GameObject objectToSpawn;
    // Start is called before the first frame update

    private void Awake()
    {
        StartCoroutine(spawnPowerUp());
    }
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public IEnumerator spawnPowerUp()
    {

        int ranInt = Random.Range(2, 40);
        int ranInt2 = Random.Range(1, 4);
        Debug.Log(ranInt2);

        switch (ranInt2)
        {
            case 1:
                objectToSpawn = healthUpPower;
               break;
            case 2:
                objectToSpawn = hurtEnemyPower;
                break;
            case 3:
                objectToSpawn = scalePower;
                break;

        }


        

     yield return new WaitForSeconds(ranInt);
        Instantiate(objectToSpawn, transform.position, objectToSpawn.transform.rotation);
        yield return null;
    }
}
