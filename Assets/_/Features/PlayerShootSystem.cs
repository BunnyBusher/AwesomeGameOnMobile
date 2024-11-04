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
            var projectile = _projectilePoolSystem.GetFisrtProjectile();
            
            
        }
    }
}
