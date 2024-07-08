using System.Collections;
using UnityEngine;

public class DogsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _dogsPrefab;

    void Start()
    {
        InvokeRepeating("StartSpawning", 1.0f, 3.0f);
    }

    void StartSpawning()
    {
        int _dogRotationXAndZ = 0, _dogRotationZ = 90;
        float _dogPostionX = -58.0f, _dogPositionY = 0.08f, _dogPositionZ = Random.Range(85, -12);

        int _dogPrefabNumber = Random.Range(0, _dogsPrefab.Length);

        _dogsPrefab[_dogPrefabNumber].transform.eulerAngles = new Vector3(_dogRotationXAndZ, _dogRotationZ, _dogRotationXAndZ);
        Vector3 _spawnPosition = new Vector3(_dogPostionX, _dogPositionY, _dogPositionZ);

        Instantiate(_dogsPrefab[_dogPrefabNumber], _spawnPosition, _dogsPrefab[_dogPrefabNumber].transform.rotation);
    }
}
