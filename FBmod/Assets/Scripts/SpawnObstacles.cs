using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public float spawnRate = 3.5f;
    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1.0f, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        GameObject obsSpawner = Instantiate(obstacle, transform.position, Quaternion.identity);
        //obsSpawner.transform.position += new Vector3(transform.position.x, transform.position.y * Random.Range(-3f, 2f), -1);
        obsSpawner.transform.position += Vector3.up * Random.Range(-3f, 2f);
    }
}
