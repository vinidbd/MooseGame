using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    float spawnRangeX = 10;
    float spawnPosZ = 20;
    float startDelay = 5;
    float spawnInterval = 2;
    void Start()
    {
        //repeatedly call function to spawn animals, with a time interval inbetween
        InvokeRepeating("SpawnAnimal", startDelay, spawnInterval);
    }
    void SpawnAnimal() {
            //chooses random X position in game bounds to spawn animal on. Changes every iteration. Keeps Z position fixed.
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            //chooses and stores which element of array to spawn. Changes every iteration.
            int animalIndex = Random.Range(0,animalPrefabs.Length);
            //chooses prefab to spawn, and assigns position and index values defined above to instance
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}

