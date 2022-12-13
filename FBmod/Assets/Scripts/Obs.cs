using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obs : MonoBehaviour
{
    public static float moveSpeed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        if (transform.position.x < Camera.main.ScreenToWorldPoint(Vector3.zero).x - 2.0f)
        {
            Destroy(gameObject);
        }

        increaseDifficulty(GameSettings.score);

    }

    private void increaseDifficulty(int score)
    {
        switch (score)
        {
            case 10:
                moveSpeed = 5.5f;
                break;
            case 20:
                moveSpeed = 5.6f;
                break;
            case 30:
                moveSpeed = 5.7f;
                break;
            case 40:
                moveSpeed = 5.8f;
                break;
            case 50:
                moveSpeed = 5.9f;
                break;
            case 60:
                moveSpeed = 6.0f;
                break;

        }
    }

}
