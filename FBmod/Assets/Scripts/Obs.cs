using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obs : MonoBehaviour
{
    public static float moveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        if (transform.position.x < Camera.main.ScreenToWorldPoint(Vector3.zero).x - 2.0f)
        {
            Destroy(gameObject);
        }

        if (GameManager.score == 3)
        {
            moveSpeed = 5.5f;
        }
    }

}
