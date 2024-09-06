using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer;
    public float coolDown = 3f;
    

    // Update is called once per frame
    void Update()
    {
        // Timer
        timer += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (timer >= coolDown)
            {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = 0f;
            }
        }
    }
}
