using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    private float spawnRate = 2.5f;
    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1.0f, spawnRate);
    }

    void SpawnObstacle()
    {
        GameObject obsSpawner = Instantiate(obstacle, transform.position, Quaternion.identity);
        obsSpawner.transform.position += Vector3.up * Random.Range(-3f, 2f);
    }
}
