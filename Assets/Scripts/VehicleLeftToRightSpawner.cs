using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleLeftToRightSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _vehiclePrefabs;

    private int _vehiclePositionX = 5, _vehiclePositionY = 0, _vehiclePositionZ = 80;
    private int _vehicleRotationXAndZ = 0, _vehicleRotationY = 180;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("StartSpawning", 1.0f, 25.0f);
    }

    private void StartSpawning()
    {
        int _vehiclePrefabNumber = Random.Range(0, _vehiclePrefabs.Length);

        Vector3 _vehicleSpawnPosition = new Vector3(_vehiclePositionX, _vehiclePositionY, _vehiclePositionZ);

        _vehiclePrefabs[_vehiclePrefabNumber].transform.eulerAngles =
            new Vector3(_vehicleRotationXAndZ, _vehicleRotationY, _vehicleRotationXAndZ);

        Instantiate(_vehiclePrefabs[_vehiclePrefabNumber], _vehicleSpawnPosition, _vehiclePrefabs[_vehiclePrefabNumber].transform.rotation);
    }
}
