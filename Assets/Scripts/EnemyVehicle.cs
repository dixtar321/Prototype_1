using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVehicle : MonoBehaviour
{
    private float _vehicleSpeed = 30.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * _vehicleSpeed * Time.deltaTime);
    }
}
