using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 10f;
    private float spawnRangeZ = 20f;
    private float spawnPosZ = 20f;
    private float spawnPosX = 20f;

    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    void SpawnRandomAnimalTop()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalLeft()
    {
        Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Quaternion spawnRot = Quaternion.Euler(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, spawnRot);
    }

    void SpawnRandomAnimalRight()
    {
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Quaternion spawnRot = Quaternion.Euler(0, 270, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, spawnRot);
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalTop", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
