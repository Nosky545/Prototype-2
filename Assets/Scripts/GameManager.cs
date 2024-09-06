using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    public int lives = 3;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Score: " + score);
        Debug.Log("Lives: " + lives);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ScoreManager()
    {
        score++;
        Debug.Log("Score: " + score);
    }

    public void LivesManager()
    {
        if (lives > 1)
        {
        lives--;
        Debug.Log("Lives: " + lives);
        }

        else if (lives == 1)
        {
            Destroy(player);
            Debug.Log("Game Over !");
        }
    }
}
