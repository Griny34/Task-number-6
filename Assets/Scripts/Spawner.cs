using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private EnemyMovement _prefab;
    [SerializeField] private Transform[] _spawnerPoint;
    [SerializeField] private int _spawnTime;

    private float _elapsedTime = 0;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if( _elapsedTime > _spawnTime)
        {
            _elapsedTime = 0;

            int indexPointSpawner = Random.Range(0, _spawnerPoint.Length);

            Instantiate(_prefab, _spawnerPoint[indexPointSpawner].position, Quaternion.identity);
        }
    }
}
