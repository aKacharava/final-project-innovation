using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpaw : MonoBehaviour
{
    [SerializeField]
    GameObject[] spawnObject = new GameObject[2];

    float minSpawnDistance = 1f;
    float maxSpawnDistance = 3f;
    int spawnCount = 0;

    Vector3 spawnRadius;

    void Start()
    {
        //spawnObject[0].GetComponent<Animator>().enabled = false;
        //spawnObject[1].GetComponent<Animator>().enabled = false;
        InvokeRepeating("SpawnObject", 7, 7);
    }

    void SpawnObject()
    {
        if (spawnCount < 5)
        {
            spawnRadius = new Vector3(Random.Range(minSpawnDistance, maxSpawnDistance), 0, Random.Range(minSpawnDistance, maxSpawnDistance));
            Instantiate(spawnObject[Random.Range(0, 2)], this.transform.position + spawnRadius, Quaternion.identity);
            spawnCount++;
        }
        //else if(spawnCount == 5)
        //{
        //    PlayAnimation();
        //    //Invoke("PlayAnimation", 3);
        //    spawnCount++;
        //}
    }

    void PlayAnimation()
    {
        spawnObject[0].GetComponent<Animator>().enabled = true;
        spawnObject[1].GetComponent<Animator>().enabled = true;
    }
}