using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatRoad : MonoBehaviour
{
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //respawns road when they're about to reach the end of the road
        if (transform.position.z < startPos.z - 50)
        {
            transform.position = startPos;
        }
    }
}
