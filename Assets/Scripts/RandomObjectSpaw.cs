using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class RandomObjectSpaw : MonoBehaviour
{
    [SerializeField]
    GameObject spawnObject;

    float minSpawnDistance = 0.3f;
    float maxSpawnDistance = 1f;
    int spawnCount = 0;

    Vector3 spawnRadius;

    AudioSource audioClip1;

    void Start()
    {
        audioClip1 = GetComponent<AudioSource>();
        InvokeRepeating("SpawnObject", 7, 7);
    }

    void SpawnObject()
    {
        if (spawnCount < 3)
        {
            spawnRadius = new Vector3(Random.Range(minSpawnDistance, maxSpawnDistance), 0, Random.Range(minSpawnDistance, maxSpawnDistance));
            Instantiate(spawnObject, this.transform.position + spawnRadius, Quaternion.identity);
            audioClip1.Play(0);
            spawnCount++;
        }
    }
}