using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20.0f;
    public float rotationSpeed = 20.0f;
    public float horizontalSpeed = 10.0f;
    public float verticalInput;
    public float forwardInput;
    public float rotationInput;
    public float downInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        forwardInput = Input.GetAxis("Horizontal");
       
        // Move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // Tilt the plane up/down based on up/down keys
        transform.Rotate(Vector3.left * Time.deltaTime * verticalInput * rotationSpeed);
        // transform.Translate(Vector3. * Time.deltaTime * downInput);
    }
}
