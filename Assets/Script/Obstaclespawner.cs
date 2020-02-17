using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclespawner : MonoBehaviour
{
    public GameObject obstacleSetPrefab;
    public float obstacleSpawnTime;
    public Transform spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacleSet", 0, obstacleSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnObstacleSet ()
    {
        Instantiate(obstacleSetPrefab, spawnPosition.position, Quaternion.identity);
    }
}
