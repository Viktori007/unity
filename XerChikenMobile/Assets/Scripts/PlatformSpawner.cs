using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEngine.EventSystems;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject _platformPrefab;
    [SerializeField] private Transform trans;
    [SerializeField] private float _verticalOffset = 0.5f;

    private float? _lastPointPositionY = null, _lastlastPointPositionY = null;
    private GameObject _player;
    private int _moveDirection = 0;

    private void Start()
    {
        //_lastPointPositionY = transStart.position.y;
        Spawn();

    }


    private void Update()
    {
        _moveDirection = ((_lastlastPointPositionY+400 > trans.position.y) && _moveDirection == 0) ? 1 : 0;
        if (_moveDirection == 1)
        {
            Spawn();
        }

    }

    public void Spawn()
    {
        Transform randomSpawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
        float spawnPointPositionY = _lastPointPositionY == null ? randomSpawnPoint.position.y : (float)_lastPointPositionY - _verticalOffset;

        randomSpawnPoint.position = new Vector3(randomSpawnPoint.position.x, spawnPointPositionY, randomSpawnPoint.position.z);
        _lastlastPointPositionY = _lastPointPositionY == null ? spawnPointPositionY : _lastPointPositionY;
        _lastPointPositionY = spawnPointPositionY;
        


        Instantiate(_platformPrefab, randomSpawnPoint.position, Quaternion.identity);
    }
}
