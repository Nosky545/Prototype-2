using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.LivesManager();
        }

        if (other.CompareTag("Projectile"))
        {  
            Destroy(other.gameObject);

            Slider hungryBar;

            hungryBar = gameObject.GetComponentInChildren<Slider>();

            hungryBar.value++;

            if (hungryBar.value >= hungryBar.maxValue)
            {
                Invoke("DestroyAnimal", 0.1f);
            }
        }
    }

    void DestroyAnimal()
    {
        Destroy(gameObject);
        gameManager.ScoreManager();
    }
}
