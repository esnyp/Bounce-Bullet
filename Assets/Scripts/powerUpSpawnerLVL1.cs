using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpSpawnerLVL1 : MonoBehaviour
{
    public GameObject healthUpPower;
    public GameObject hurtEnemyPower;

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

        int ranInt = Random.Range(3, 20);
        int ranInt2 = Random.Range(1, 3);
        Debug.Log(ranInt2);

        switch (ranInt2)
        {
            case 1:
                objectToSpawn = healthUpPower;
                break;
            case 2:
                objectToSpawn = hurtEnemyPower;
                break;        
        }




        yield return new WaitForSeconds(ranInt);
        Instantiate(objectToSpawn, transform.position, objectToSpawn.transform.rotation);
        yield return null;
    }
}
