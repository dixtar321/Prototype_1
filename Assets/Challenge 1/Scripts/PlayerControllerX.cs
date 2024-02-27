using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 20.0f;
    private float rotationSpeed = 100.0f;
    private float verticalInput;
    private float invert = -1.0f;

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical") * invert;

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed  * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime * verticalInput);

        transform.Rotate(0, 0, 0, Space.World);
    }
}
