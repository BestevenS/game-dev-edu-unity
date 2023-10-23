using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 20.0f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        // first: transform.Translate(0,0,1);
        // second update: transform.Translate(Vector3.forward);
        // third update: transform.Translate(Vector3.forward * Time.deltaTime * 20);
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * speed);

        // Rotates the vehicle
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * speed);
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed);
    }
}
