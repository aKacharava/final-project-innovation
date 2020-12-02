using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpaw : MonoBehaviour
{
    [SerializeField]
    GameObject spawnObject;

    float minLookDistance = 1f;
    float maxLookDistance = 3.5f;
    int spawnCount = 0;

    ///Vector3 


    void Start()
    {
        InvokeRepeating("SpawnObject", 7, 7);
    }

    void SpawnObject()
    {
        if (spawnCount < 3)
        {
            Instantiate(spawnObject, this.transform.position, Quaternion.identity);
            spawnCount++;
        }
    }
}
