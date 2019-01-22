using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {

        Spawn();
        
    }

    void Spawn()
    {

        Instantiate(obj, transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(1f, 2f));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
