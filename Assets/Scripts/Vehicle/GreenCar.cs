using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCar : Vehicle
{
    [SerializeField] private float _vehicaleSpeed;

    // Update is called once per frame
    void Update()
    {
        Move(_vehicaleSpeed);
        VehicleDestroy();
    }
}
