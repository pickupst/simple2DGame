using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] obj;
    public float spawnMin = 1f;
    public float spawnMax = 2f;

    public GameObject powerUp;
    public float puSpawnMin = 2f;
    public float puSpawnMax = 5f;


    // Start is called before the first frame update
    void Start()
    {

        Spawn();
        SpawnPowerUp();
    }

    void Spawn()
    {

        Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));

    }

    void SpawnPowerUp()
    {

        Instantiate(powerUp, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        Invoke("SpawnPowerUp", Random.Range(puSpawnMin, puSpawnMax));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
