using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollisions : MonoBehaviour
{
    [SerializeField]
    private GameObject effect;

    void OnTriggerEnter(Collider other)
    {

        Instantiate(effect, transform.position, Quaternion.identity);

        if (other.gameObject.tag.Equals("Player"))
        {
            //sends player to game over screen when the obstacle hits the player
            SceneManager.LoadScene(2);
        }
        else 
        {
            //increases the score counter by 1 on every obstacle hit by the pizza
            ScoreCounter.IncrementScore();
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
