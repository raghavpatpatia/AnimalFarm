using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public float xMin;
    public float xMax;
    public float zMin;
    public float zMax;
    public float zPos;
    public float xPos;
    private float startTime = 1.0f;
    private float spawnDelay = 1.5f;
    private float startTimeSide = 1.0f;
    private float spawnDelaySide = 2.0f;
    public GameObject[] Animals;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("animalSpawnX", startTime, spawnDelay);
        InvokeRepeating("animalSpawnZ", startTimeSide, spawnDelaySide);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void animalSpawnX()
    {
        int animalIndex = Random.Range(0, Animals.Length);
        Vector3 spawnPos = new Vector3 (Random.Range(xMin, xMax), 0, zPos);
        Instantiate(Animals[animalIndex], spawnPos, Animals[animalIndex].transform.rotation);
    }
    void animalSpawnZ()
    {
        int animalIndex = Random.Range(0, Animals.Length);
        Vector3 spawnPos = new Vector3(xPos, 0, Random.Range(zMin, zMax));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(Animals[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
}
