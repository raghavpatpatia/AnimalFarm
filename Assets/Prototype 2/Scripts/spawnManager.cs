using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float xPos = 10.0f;
    private float zPos = 34.0f;
    private float startDelay = 1.0f;
    private float spawnInterval = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnAnimals", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void spawnAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-xPos, xPos), 0, zPos);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
