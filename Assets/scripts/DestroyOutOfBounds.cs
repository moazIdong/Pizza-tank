using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 200;
    public float lowerBound = -12;
    public bool isObstacle = false;

    void Start()
    {
        
    }

    void Update()
    {
        //despawns pizza slices if they reach out of bound
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < lowerBound)
        {
            //despawns the object if it passes the player
            Destroy(gameObject);
            if (isObstacle) {
                //sends the player to game over screen if they miss an object which passed them
                SceneManager.LoadScene(2);
            }
        }
    }
}
