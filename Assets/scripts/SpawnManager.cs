using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private const int V = 30;
    public GameObject[] obstaclePrefabs;
    private float spawnRangeX = 17;
    private float spawnPosZ = 170;
    private float startDelay = 1;
    private float repeatRate = 1.75f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnObstacle ()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, obstaclePrefabs[obstacleIndex].transform.rotation);

    }

}
