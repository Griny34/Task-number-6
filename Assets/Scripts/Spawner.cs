using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private EnemyMovement _prefab;
    [SerializeField] private Transform[] _spawnerPoint;
    [SerializeField ]private float _delay;

    private void Start()
    {
        StartCoroutine(DetainOn());
    }

    private void InstantiateEnemy()
    {
        int indexPointSpawner = Random.Range(0, _spawnerPoint.Length);

        Instantiate(_prefab, _spawnerPoint[indexPointSpawner].position, Quaternion.identity);
    }

    private IEnumerator DetainOn()
    {
        while (true)
        {
            yield return new WaitForSeconds(_delay);
            InstantiateEnemy();
        }
    }
}
