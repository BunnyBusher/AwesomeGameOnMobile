using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootSystem : MonoBehaviour
{
    [SerializeField] private ProjectilePoolSystem _projectilePoolSystem;



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireAProjectile();

        }
    }

    [ContextMenu("Fire projectile")]
    private void FireAProjectile()
    {
        var projectile = _projectilePoolSystem.GetFisrtProjectile();
        projectile.transform.position = transform.position;
    }
}
