using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMoving : MonoBehaviour
{
    private float speed = 20;

    void Start()
    {
        
    }

    void Update()
    {
        //the road is a moving background which gives the illusion to the player that the tank is moving forward
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
