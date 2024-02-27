using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed = 20.0f;
    private float _turnSpeed = 35.0f;
    private float _horizontalInput;
    private float _forwardInput;

    void Update()
    {
        // getting axis for turn right or left (+-1)
        _horizontalInput = Input.GetAxis("Horizontal");
        // getting axis for moving forward or back (+-1)
        _forwardInput = Input.GetAxis("Vertical");

        //We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _forwardInput);

        //We'll turn the vehicle 
        transform.Rotate(Vector3.up, _turnSpeed * Time.deltaTime * _horizontalInput);
    }
}
