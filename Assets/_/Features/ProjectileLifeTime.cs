using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLifeTime : MonoBehaviour
{
    [SerializeField] private float LifeTime;
    private float _currentTime;

    private void Awake()
    {
        if (LifeTime <= 0) LifeTime = 3f;
    }

    private void OnEnable()
    {
        _currentTime = 0;
    }

    private void Update()
    {
        LifeTimeOfProjectile();        
    }

    private void LifeTimeOfProjectile()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime >= LifeTime) gameObject.SetActive(false);
    }

    
}
