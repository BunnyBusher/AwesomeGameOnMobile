using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class ProjectilePhysics : MonoBehaviour
{
    [SerializeField] private float ProjectileSpeed;
    private bool _IsFired;

    public UnityEvent<GameObject> OnCollisionWithEnemy;

    private void Awake()
    {
        if (ProjectileSpeed <= 0) ProjectileSpeed = 4;
    }

    private void OnEnable()
    {
        _IsFired = true;
    }

    private void OnDisable()
    {
        _IsFired = false;
    }

    private void OnTriggerEnter2D (Collider2D trigger)
    {
        if (trigger.gameObject.CompareTag("Enemy"))
        {
                       
            OnCollisionWithEnemy?.Invoke(trigger.gameObject);
            transform.gameObject.SetActive(false);

        }
    }
    private void Update()
    {
        if (_IsFired)
        {
            transform.Translate(Vector3.up * ProjectileSpeed * Time.deltaTime);
        }
    }
}
