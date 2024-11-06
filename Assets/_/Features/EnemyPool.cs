using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private float _offset;
    [SerializeField] private Vector2 _rowAndColumn;

    private Transform _parentTransform;
    

    private void Awake()
    {
        _parentTransform = transform;

        

        

        for (int x = 0; x < _rowAndColumn.x; x++)
        {

            for (int y = 0; y < _rowAndColumn.y; y++)
            {
                var current = Instantiate(_enemyPrefab, new Vector3((_parentTransform.position.x + x) * _offset, (_parentTransform.position.y - y) * _offset, 0), Quaternion.identity, _parentTransform);
                
            }
        }
    }

}
