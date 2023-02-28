using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 18f;
    public float xRange = 23;
    public GameObject projectilePrefab;

    public float currentCooldown = 0;
    public float cooldown = 0.35f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //cooldown for the pizza projectile so that player does not spam the pizza projectile
        if (currentCooldown > 0)
        {
            currentCooldown -= Time.deltaTime;
        }
        //keeps player in the road's bound
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //Launch a pizza projectile from the tank when the player press "space"
        if (Input.GetKeyDown(KeyCode.Space) && currentCooldown <= 0)
        { 
            Instantiate(projectilePrefab, transform.position + new Vector3(0,2,0), projectilePrefab.transform.rotation);
            currentCooldown = cooldown;
        }
        //reads horizontal input
        horizontalInput = Input.GetAxis("Horizontal");
        //turning speed of the player
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
