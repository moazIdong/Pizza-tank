using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBuilding : MonoBehaviour
{
    private Vector3 initialPos;

    void Start()
    {
        initialPos = transform.position;
    }


    void Update()
    {
        //respawns buildings when they've reached out of player sight
        if(transform.position.z < initialPos.z - 150)
        {
            transform.position = initialPos;
        }
    }
}
