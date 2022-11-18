using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnPowerUp());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnPowerUp()
    {
       int ranInt = Random.Range(5, 40);

     yield return new WaitForSeconds(ranInt);
        Instantiate(objectToSpawn, transform.position, objectToSpawn.transform.rotation);
        yield return null;
    }
}
