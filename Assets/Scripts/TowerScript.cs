using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{
    float Range = 2;
    float CurrColdown, Cooldown;
    private void Update()
    {
        if (CanShoot())
            SearchTarget();

        if (CurrColdown > 0)
            CurrColdown -= Time.deltaTime;
    }

    bool CanShoot()
    {
        if (CurrColdown <= 0)
            return true;
        return false;
    }

    void SearchTarget()
    {
        Transform nearestEnemy = null;
        float nearestEnemyDistance = Mathf.Infinity;

        foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            float CurrDistance = Vector2.Distance(transform.position, enemy.transform.position);

                if (CurrDistance < nearestEnemyDistance && CurrDistance <= Range)
            {
                nearestEnemy = enemy.transform;
                nearestEnemyDistance = CurrDistance;
            }
        }
        if (nearestEnemy != null)
            Shoot(nearestEnemy);
        
    }
    void Shoot(Transform enemy)
    {
        CurrColdown = Cooldown;
        Debug.Log("Shoot");
    }

}