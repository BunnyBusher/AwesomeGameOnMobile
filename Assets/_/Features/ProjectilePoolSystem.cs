using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePoolSystem : MonoBehaviour
{
    [SerializeField] private GameObject _projectilePrefab;
    [SerializeField] private int _projectileInPool;

    private void Awake()
    {
        if (_projectileInPool <= 0) _projectileInPool = 20;
    }

    private void Start()
    {
        for (int i = 0; i < _projectileInPool; i++)
        {
            AddItemInPool();
        }
    }

    private GameObject AddItemInPool()
    {
        var instance = Instantiate(_projectilePrefab, transform);
        instance.SetActive(false);
        return instance;
    }

    public GameObject GetFisrtProjectile()
    {
        foreach (Transform child in transform)
        {
            if(child.gameObject.activeSelf == false)
            {
                child.gameObject.SetActive(true);
                return child.gameObject;
            }
        }
        var instance = Instantiate(_projectilePrefab, transform);
        instance.SetActive(true);
        return instance;
    }

}
