using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    private static int Score;

    public TextMeshProUGUI text;

    public static void IncrementScore() {
        Score++;
        //game sends player to "You win screen"
        if (Score == 10) {
            SceneManager.LoadScene(3);
        }
    }

    private void Start()
    {
        //game resets player score to 0 when they restart the game
        Score = 0;
    }

    private void Update()
    {
        //shows the player their own score while playing the game
        text.text = $"Score: {Score}";
    }

}
