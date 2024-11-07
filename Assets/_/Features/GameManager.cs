using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ProjectilePhysics _projectilePhysics;

    private void OnEnable()
    {
        _projectilePhysics.OnCollisionWithEnemy.AddListener(EnemyIsHit);
    }

    private void OnDisable()
    {
        _projectilePhysics.OnCollisionWithEnemy.RemoveListener(EnemyIsHit);
    }

    private void EnemyIsHit(GameObject hit)
    {
        Debug.Log($"{hit}Enemy hit");

        hit.gameObject.SetActive(false);
    }
}
