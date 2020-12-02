using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpaw : MonoBehaviour
{
    [SerializeField]
    GameObject spawnObject;

    float minSpawnDistance = 0.3f;
    float maxSpawnDistance = 1f;
    int spawnCount = 0;

    Vector3 spawnRadius;


    void Start()
    {
        InvokeRepeating("SpawnObject", 7, 7);
    }

    void SpawnObject()
    {
        if (spawnCount < 3)
        {
            spawnRadius = new Vector3(Random.Range(minSpawnDistance, maxSpawnDistance), 0, Random.Range(minSpawnDistance, maxSpawnDistance));
            Instantiate(spawnObject, this.transform.position + spawnRadius, Quaternion.identity);
            spawnCount++;
        }
    }
}