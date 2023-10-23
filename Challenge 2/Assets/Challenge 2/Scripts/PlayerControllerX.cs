using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float time = 1;
    private float timer;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        timer -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (timer < 0)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timer = time;
            }
            
        }
    }
}
